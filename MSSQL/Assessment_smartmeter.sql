create database smartmeter
use smartmeter

/* Task 0 
Create databse tables to store smartmeter readings and customer details
*/

create table Customers(CustomerId int primary key, CustomerName varchar(50), CustomerAddress varchar(200), Region varchar(10))

create table SmartMeterReadings(MeterId int, CustomerId int, Location varchar(20), InstalledDate date, ReadingDateTime datetime, EnergyConsumed float, foreign key (CustomerId) references Customers(CustomerId))

insert into Customers values(1, 'Rohith', 'Chennai', 'South'),(2, 'Shivam', 'Delhi', 'North'),(3, 'Gopal', 'Gujarat', 'West'),(4, 'Patel', 'Bihar', 'East')
insert into SmartMeterReadings values(301, 1, 'Rooftop', '2024-02-15', '2024-03-15 10:00:00', 15.0),
(305, 2, 'Basement', '2024-05-19', '2024-06-20 14:30:00', 45.0),
(314, 3, 'Basement', '2024-04-29', '2024-05-30 17:45:00', 37.0),
(320, 4, 'rooftop', '2024-07-09', '2024-08-10 12:20:00', 29.0),
(314, 3, 'Basement', '2024-05-19', '2024-07-20 15:00:00', 51.0),
(301, 1, 'Rooftop', '2024-02-15', '2024-04-15 10:00:00', 22.0)

insert into SmartMeterReadings values(320, 4, 'rooftop', '2024-07-09', '2025-03-08 16:06', 48.50),
(305, 2, 'Basement', '2024-05-19', '2025-01-20 13:50', 56.40),
(301, 1, 'Rooftop', '2024-02-15', '2025-02-15 14:40', 37.30),
(314, 3, 'Basement', '2024-05-19', '2025-02-19 10:25', 52.80),
(320, 4, 'rooftop', '2024-07-09', '2025-04-10 15:50', 39.90) 

select * from Customers
select * from SmartMeterReadings


/*Task 1
Write a query to fetch all smart meter readings where:
- EnergyConsumed is between 10 and 50 kwh
- ReadingDateTime is between '2024-01-01' and '2024-12-31'
- Exclude meters installed after '2024-06-30'
*/

select * from SmartMeterReadings where EnergyConsumed between 10 and 50

select * from SmartMeterReadings where ReadingDateTime between '2024-01-01' and '2024-12-31'

select * from SmartMeterReadings where InstalledDate < '2024-06-30'


/* Task 2
calculate:
- Average energy consumed per reading
- Maximum energy consumed in a single reading
- only include readings from the current year
*/

--Overall calculations
select Avg(EnergyConsumed) as AvgEnergyConsumed, Max(EnergyConsumed) as MaxEnergyConsumed from SmartMeterReadings where year(ReadingDateTime) = year(GETDATE())


--Per Customer
select CustomerId, Avg(EnergyConsumed) as AvgEnergyConsumed, Max(EnergyConsumed) as MaxEnergyConsumed from SmartMeterReadings where year(ReadingDateTime) = year(GETDATE())
 group by CustomerId