#!usr/bin/bash

echo "what is your name?"
read name

echo "what is your age?"
read age

if [ $age -ge 18 ]; then
        echo "Hi $name, you can vote."
else
        echo "Hi $name, you can't vote."
fi