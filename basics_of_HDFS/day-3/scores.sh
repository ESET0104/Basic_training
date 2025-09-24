#!usr/bin/bash
echo "enter your score:"
read score

if [ $score -ge 75 ]; then
        echo "You are into bucket 1"
elif [ $score -ge 50 ]; then
        echo "you are into bucket 2"
elif [ $score -ge 25 ]; then
        echo "you are into bucket 3"
else 
        echo "you are into bucket 4"
fi