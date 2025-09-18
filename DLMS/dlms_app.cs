using System;
using System.Collections.Generic;

namespace dlms_app
{
    public class ObisCode
    {
        public byte A { get; set; }
        public byte B { get; set; }
        public byte C { get; set; }
        public byte D { get; set; }
        public byte E { get; set; }
        public byte F { get; set; }

        public ObisCode(byte a, byte b, byte c, byte d, byte e, byte f)
        {
            A = a; B = b; C = c; D = d; E = e; F = f;
        }

        public byte[] ToByteArray()
        {
            return [A, B, C, D, E, F];
        }

        public string ToString()
        {
            return $"{A}-{B}:{C}.{D}.{E}.{F}";
        }
    }

    public class MeterObject
    {
        public ObisCode Obis { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public ushort ShortName { get; set; }

        public MeterObject(ObisCode obis, string name, int value, ushort shortName)
        {
            Obis = obis;
            Name = name;
            Value = value;
            ShortName = shortName;
        }
    }

    public static class DlmsService
    {
        private static List<MeterObject> meterObjects = new()
        {
            new MeterObject(new ObisCode(1, 0, 1, 8, 0, 255), "Active Energy Import", 12345, 0x0001),
            new MeterObject(new ObisCode(1, 0, 32, 7, 0, 255), "Voltage", 230, 0x0002),
            new MeterObject(new ObisCode(1, 0, 21, 7, 0, 255), "Current", 15, 0x0003)
        };


        private static bool ObisMatch(ObisCode obis1, ObisCode obis2)
        {
            return obis1.A == obis2.A &&
                   obis1.B == obis2.B &&
                   obis1.C == obis2.C &&
                   obis1.D == obis2.D &&
                   obis1.E == obis2.E &&
                   obis1.F == obis2.F;
        }

        public static void dlms_get(ObisCode obis)
        {
            foreach (var obj in meterObjects)
            {
                if (ObisMatch(obis, obj.Obis))
                {
                    Console.WriteLine($"[GET] {obj.Name} = {obj.Value}");
                    return;
                }
            }
            Console.WriteLine("[GET] OBIS not found.");
        }

        public static void dlms_action(ObisCode obis, string method)
        {
            if (method == "RESET")
            {
                Console.WriteLine("[ACTION] Resetting meter values...");
                foreach (var obj in meterObjects)
                {
                    obj.Value = 0;
                }
                Console.WriteLine("[ACTION] Reset complete.");
            }
            else if (method == "SYNC_TIME")
            {
                Console.WriteLine("[ACTION] Synchronizing meter clock to system time...");
                Console.WriteLine("[ACTION] Time synchronization complete.");
            }
            else
            {
                Console.WriteLine("[ACTION] Unknown method.");
            }
        }

        public static void dlms_set(ObisCode obis, int newValue)
        {
            foreach (var obj in meterObjects)
            {
                if (ObisMatch(obis, obj.Obis))
                {
                    obj.Value = newValue;
                    Console.WriteLine($"[SET] {obj.Name} updated to {newValue}");
                    return;
                }
            }
            Console.WriteLine("[SET] OBIS not found.");
        }

        public static void dlms_read_sn(ushort shortName)
        {
            Console.WriteLine($"[READ-SN] Reading object with Short Name: 0x{shortName:X4}");

            foreach (var obj in meterObjects)
            {
                if (obj.ShortName == shortName)
                {
                    Console.WriteLine($"[READ-SN] {obj.Name} = {obj.Value}");
                    return;
                }
            }
            Console.WriteLine("[READ-SN] Short Name not found.");
        }

        public static void dlms_write_sn(ushort shortName, int newValue)
        {
            Console.WriteLine($"[WRITE-SN] Writing value {newValue} to Short Name: 0x{shortName:X4}");

            foreach (var obj in meterObjects)
            {
                if (obj.ShortName == shortName)
                {
                    obj.Value = newValue;
                    Console.WriteLine($"[WRITE-SN] {obj.Name} updated to {newValue}");
                    return;
                }
            }
            Console.WriteLine("[WRITE-SN] Short Name not found.");
        }
    }

    public static class GetRequestApdu
    {
        public static byte[] CreateGetRequest(ObisCode obis, ushort classId, byte attributeId)
        {
            List<byte> apdu = new List<byte>();

            apdu.Add(0xC0); // GET-Request
            apdu.Add(0x01); // Get-Request-Normal
            apdu.Add(0x01); // Invoke ID = 1, normal priority

            // Class ID (2 bytes)
            apdu.Add((byte)(classId >> 8));
            apdu.Add((byte)(classId & 0xFF));

            // OBIS code
            apdu.AddRange(obis.ToByteArray());

            // Attribute ID
            apdu.Add(attributeId);

            // Access Selector
            apdu.Add(0x00);

            return apdu.ToArray();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           
            var obisEnergy = new ObisCode(1, 0, 1, 8, 0, 255);
            var obisVoltage = new ObisCode(1, 0, 32, 7, 0, 255);

           
            Console.WriteLine("=== Original APDU Example ===");
            byte[] apdu = GetRequestApdu.CreateGetRequest(obisEnergy, 3, 2);
            Console.WriteLine("OBIS Code: " + obisEnergy);
            Console.WriteLine("GET Request APDU: " + BitConverter.ToString(apdu));

            
            Console.WriteLine("\n=== Testing DLMS Service Functions ===");

            
            DlmsService.dlms_set(obisVoltage, 240);
            DlmsService.dlms_action(obisEnergy, "RESET");
            DlmsService.dlms_read_sn(0x0001);
            DlmsService.dlms_write_sn(0x0001, 5000);

            
            Console.WriteLine("\n=== Verification ===");
            DlmsService.dlms_get(obisVoltage);
            DlmsService.dlms_get(obisEnergy);
        }
    }
}