
# Strings-and-Text-Processing

With solving this problems, I practice working with Strings.

## Problem: Character Multiplier
Create a method that takes two strings as arguments and return the sum of their character codes multiplied. The countinue with the next two characters. If one of the strings is longer than the other, add the remaining charter codes to the total sum without multiplication.
### Example:
#### input:
Gosho Pesho
#### output:
53253 

## Problem: Conver from base-10 to base-N

Write a program that take a base-10 and convert it to a base-N, where 2<=N<=10.
The input consists of 1 line countaining two numbers separated by a single space. The first number is the base N to which you have to convert. The second one is the base 10 number to be converted. Do not use any built and converting functionality. 

### Example:
#### input:
3 154
#### output:
12201

## Problem: Convert from base-N to base-10

Write a program that take a base-N and convert it to a base-10,where 2<=N<=10
The input consists of 1 line countaining two numbers separated by a single space.The first number is the base N to which you have to convert. The second one is the base N number to be converted. Do not use any built and converting functionality. 

### Example:
#### input:
3 12201
#### output:
154
## Problem: Letters Change Numbers

Vokan likes math. But he also likes the English Alphabet a lot. He invented a game with numbers and letters from the English Alphabet. The game was simple. You get a string consisting of a number between two letters. Depending on whether the letter was in front of the number or after it you would perform differend mathematical operators on the number to arhieve the result. 

First you start with the letter before the number. 

If it's Uppercase you divide the number by the letter`s position in the Alphabet.

If it's lowercase you multiply the number by the letter's position. Then you move to the letter after the number. 

If it's Uppercase you substract its position from the resulted number.

If it's lowercase you add its position to the resulted number. 

But the game became too easy for Vokan really quick. He decided to complicate it a bit by doing the same but with the multiply strings keeping track of only the total sum of all results. Once he started to solve this with more strings and bigger numbers it became quite hard to do it only in his mind. So he kindly asks you to write a program that calculates the sum of all numbers after the operations on each number have been done.


### Example
#### input:
a12b s17G
#### output:
300.00


