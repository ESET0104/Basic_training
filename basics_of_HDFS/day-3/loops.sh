#!usr/bin/bash

read counter
while [ $counter -ge 0 ]
do let counter--
   echo $counter
done