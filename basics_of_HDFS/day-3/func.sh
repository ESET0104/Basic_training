#!usr/bin/bash

func() {
        local x=$1
        local y=$2
        result=$(( x + y ))
}

a=3;
b=4;

echo "the sum of two numbers: "
func $a $b
echo $result