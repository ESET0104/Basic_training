#include <avr/io.h>
#include <util/delay.h>

#define LED_PIN PD4
#define push PD2

int main(void) {
    DDRD |= (1 << LED_PIN);
    DDRD &= ~(1 << push);

    PORTD |= (1 << push);

    while(1) {
        if(!(PIND & (1 << push))) {
            PORTD |= (1 << LED_PIN);
            _delay_ms(500);

            PORTD &= ~(1 << LED_PIN);
             _delay_ms(500);
        }
        else PORTD &= ~(1 << LED_PIN);
    }
}