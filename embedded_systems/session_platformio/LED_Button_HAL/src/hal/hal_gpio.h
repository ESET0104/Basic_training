#ifndef HAL_GPIO_H
#define HAL_GPIO_H

#include <avr/io.h>

#define INPUT 0
#define OUTPUT 1

void HAL_GPIO_init(volatile uint8_t *port, uint8_t pin, uint8_t direction);
void HAL_GPIO_write(volatile uint8_t *port, uint8_t pin, uint8_t value);
void HAL_GPIO_toggle(volatile uint8_t *port, uint8_t pin);
uint8_t HAL_GPIO_read(volatile uint8_t *port, uint8_t pin);

#endif