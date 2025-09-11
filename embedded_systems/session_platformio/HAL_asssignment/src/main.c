#include "hal/hal_gpio.h"
#include "../config/pin_config.h"
#include <util/delay.h>


int main(void) {
    HAL_GPIO_init(LED_PORT, LED_PIN, OUTPUT);
    HAL_GPIO_init(BUTTON_PORT, BUTTON_PIN, INPUT);

    *(BUTTON_PORT) |= (1 << BUTTON_PIN); 

    int mode = 0;
    uint8_t last_button_state = 1; 
    uint8_t led_on = 0;

    while (1) {
        uint8_t button_state = HAL_GPIO_read(BUTTON_PORT, BUTTON_PIN);
        if (!button_state && last_button_state) {
            mode = (mode + 1) % 4;
            _delay_ms(200);
        }
        last_button_state = button_state;

        switch (mode) {
            case 0:
                HAL_GPIO_write(LED_PORT, LED_PIN, 0);
                break;
            case 1:
                HAL_GPIO_write(LED_PORT, LED_PIN, led_on);
                _delay_ms(500);
                led_on = !led_on;
                break;
            case 2:
                HAL_GPIO_write(LED_PORT, LED_PIN, led_on);
                _delay_ms(100);
                led_on = !led_on;
                break;
            case 3:
                HAL_GPIO_write(LED_PORT, LED_PIN, 1);
                _delay_ms(50);
                break;
        }
    }
}