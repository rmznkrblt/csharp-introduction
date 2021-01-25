# Operators
Operators are used to perform operations on variables and values.<br>

### Arithmetic Operators

Arithmetic operators are used to perform common mathematical operations:

| Operator |	Name |	Description |	Example |
| -- | -- | -- | -- |
| +	| Addition	| 	Adds two operands |	x + y	|
| - | Subtraction	| Subtracts second operand from the first |	x - y	|
| *	| Multiplication	| Multiplies both operands	| x * y	|
| /	| Division	| Divides numerator by de-numerator	| x / y	|
| %	| Modulus	| Modulus Operator and remainder of after an integer division |	x % y	|
| ++ | Increment	| Increment operator increases integer value by one |	x++	|
| --	| Decrement	| Decrement operator decreases integer value by one |	x-- |
<br>
### Relational Operators

Relational operators are used to compare two values:

| Operator |	Description |	Example |
| -- | -- | -- |
| == |	Checks if the values of two operands are equal or not, if yes then condition becomes true.	| (A == B) is not true. |
| != |	Checks if the values of two operands are equal or not, if values are not equal then condition becomes true.	| (A != B) is true. |
| >	| Checks if the value of left operand is greater than the value of right operand, if yes then condition becomes true.	| (A > B) is not true. |
| <	| Checks if the value of left operand is less than the value of right operand, if yes then condition becomes true.	| (A < B) is true. |
| >=	| Checks if the value of left operand is greater than or equal to the value of right operand, if yes then condition becomes true.	| (A >= B) is not true. |
| <=	| Checks if the value of left operand is less than or equal to the value of right operand, if yes then condition becomes true.	| (A <= B) is true. |

<br>

### Logical Operators

Logical operators are used to determine the logic between variables or values:

| Operator |	Description |	Example |
| -- | -- | -- |
| &&	| Called Logical AND operator. If both the operands are non zero then condition becomes true.	| (A && B) is false. |
| \|\| |	Called Logical OR Operator. If any of the two operands is non zero then condition becomes true.	| (A \|\| B) is true. |
| !	| Called Logical NOT Operator. Use to reverses the logical state of its operand. If a condition is true then Logical NOT operator will make false.	| !(A && B) is true. |

### Bitwise Operators

Bitwise operator works on bits and perform bit by bit operation.

| p |	q |	p & q |	p | q	| p ^ q |
| -- | -- | -- | -- | -- |
| 0	| 0	| 0	| 0	| 0 |
| 0	| 1	| 0	| 1	| 1 |
| 1	| 1	| 1	| 1	| 0 |
| 1	| 0	| 0	| 1	| 1 |



The Bitwise operators supported by C# are listed in the following table.

| Operator |	Description |	Example |
| -- | -- | -- |
| &	| Binary AND Operator copies a bit to the result if it exists in both operands.	| (A & B) = 12, which is 0000 1100 |
| |	| Binary OR Operator copies a bit if it exists in either operand.	| (A | B) = 61, which is 0011 1101 |
| ^	| Binary XOR Operator copies the bit if it is set in one operand but not both.	| (A ^ B) = 49, which is 0011 0001 |
| ~	| Binary Ones Complement Operator is unary and has the effect of 'flipping' bits.	| (~A ) = -61, which is 1100 0011 in 2's complement due to a signed binary number. |
| << |	Binary Left Shift Operator. The left operands value is moved left by the number of bits specified by the right operand.	| A << 2 = 240, which is 1111 0000 |
| >> |	Binary Right Shift Operator. The left operands value is moved right by the number of bits specified by the right operand.	| A >> 2 = 15, which is 0000 1111 |

### Assignment Operators

Assignment operators are used to assign values to variables.

| Operator | Example	| Same As	|
| -- | -- | -- |
| =	| x = 5 |	x = 5	|
| += |	x += 3 |	x = x + 3	|
| -=	| x -= 3 |	x = x - 3	|
| *=	| x *= 3 |	x = x * 3	|
| /=	| x /= 3 |	x = x / 3	|
| %=	| x %= 3 |	x = x % 3	|
| &=	| x &= 3 |	x = x & 3	|
| |=	| x |= 3 |	x = x | 3	|
| ^= | x ^= 3 |	x = x ^ 3	|
| >>=	| x >>= 3	| x = x >> 3	|
| <<=	| x <<= 3 | x = x << 3 |

### Miscellaneous Operators

There are few other important operators including sizeof, typeof and ? : supported by C#.

| Operator |	Description |	Example |
| -- | -- | -- |
| sizeof()	| Returns the size of a data type.	| sizeof(int), returns 4. |
| typeof()	| Returns the type of a class.	| typeof(StreamReader); |
| &	| Returns the address of an variable.	| &a; returns actual address of the variable. |
| *	| Pointer to a variable.	| *a; creates pointer named 'a' to a variable. |
| ? :	| Conditional Expression	| If Condition is true ? Then value X : Otherwise value Y |
| is	| Determines whether an object is of a certain type.	| If( Ford is Car) // checks if Ford is an object of the Car class. |
| as	| Cast without raising an exception if the cast fails. |	Object obj = new StringReader("Hello"); <br> StringReader r = obj as StringReader; |

### Operator Precedence in C#

Operator precedence determines the grouping of terms in an expression. This affects evaluation of an expression. Certain operators have higher precedence than others; for example, the multiplication operator has higher precedence than the addition operator. <br>

Here, operators with the highest precedence appear at the top of the table, those with the lowest appear at the bottom. Within an expression, higher precedence operators are evaluated first.<br>

| Category	| Operator	| Associativity |
| -- | -- | -- | 
| Postfix |	() [] -> . ++ - -	|Left to right |
| Unary |	+ - ! ~ ++ - - (type)* & sizeof	|Right to left |
| Multiplicative	| * / %	|Left to right |
| Additive	| + -	|Left to right |
| Shift	| << >>	|Left to right |
| Relational	| < <= > >=	|Left to right |
| Equality	| == !=	|Left to right |
| Bitwise AND | & |Left to right |
| Bitwise XOR |	^	|Left to right |
| Bitwise OR	| | |	Left to right |
| Logical AND | &&| Left to right |
| Logical OR	| ||  	Left to right |
| Conditional	| ?:	Right to left |
| Assignment	| = += -= *= /= %=>>= <<= &= ^= |=	| Right to left |
| Comma |	,	|Left to right |

