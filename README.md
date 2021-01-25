# csharp-introduction
This repository is a resource created both for myself and for beginners to the c # language. Since the topics interact with each other, I recommend that they be followed sequentially. This repository has been prepared for the beginners to help them understand basic C# programming. After the topics here are over, continue with the [OOP-csharp](https://github.com/rmznkrblt/OOP-csharp) repository, which is a more advanced level and will carry you forward in the sector. Good luck with!!!...
 
# What is c#?
 C# is a modern, object-oriented, and type-safe programming language. C# has its roots in the C family of languages and will be immediately familiar to C, C++, Java, and JavaScript programmers. C# provides language constructs to directly support these concepts, making C# a natural language in which to create and use software components. Since its origin, C# has added features to support new workloads and emerging software design practices.
 The most recent version is 9.0, which was released in 2020 in .NET 5.0 and included in Visual Studio 2019 version 16.8. Mono is a free and open-source project to develop a cross-platform compiler and runtime environment (i.e. virtual machine) for the language.

C# is used for:
* Mobile applications
* Desktop applications
* Web applications
* Web services
* Web sites
* Games
* VR
* Database applications
* And much, much more!
 
 Following are some of the components of the c# −
 * [Garbage collection](https://docs.microsoft.com/tr-tr/dotnet/standard/garbage-collection/)
 * [Exception handling](https://docs.microsoft.com/tr-tr/dotnet/csharp/programming-guide/exceptions/)
 * [Lambda expressions](https://docs.microsoft.com/tr-tr/dotnet/csharp/language-reference/operators/lambda-expressions)
 * [Query syntax](https://docs.microsoft.com/tr-tr/dotnet/csharp/linq/)
 * [Asynchronous operations](https://docs.microsoft.com/tr-tr/dotnet/csharp/programming-guide/concepts/async/)
 * [Pattern matching](https://docs.microsoft.com/tr-tr/dotnet/csharp/pattern-matching)
 * [Unified type system](https://docs.microsoft.com/tr-tr/dotnet/csharp/programming-guide/types/)
 
  All C# types, including primitive types such as int and double, inherit from a single root object type. All types share a set of common operations. Values of any type can be stored, transported, and operated upon in a consistent manner. Furthermore, C# supports both user-defined reference types and value types. C# allows dynamic allocation of objects and in-line storage of lightweight structures.
  
  
#  [Veriables and Data Types](https://github.com/rmznkrblt/csharp-introduction/tree/main/VeriablesAndTypes)
 Variables are containers for storing data values.
 ### Declaring (Creating) Variables
 To create a variable, you must specify the type and assign it a value:
 ### Syntax
```c#
type variableName = value;
```
 Where type is a C# type (such as int or string), and variableName is the name of the variable (such as x or name). The equal sign is used to assign values to the variable. <br>
 There are two kinds of types in C#: value types and reference types. <br>
 While value types are stored generally in the stack, reference types are stored in the managed heap.
 A value type derives from System.ValueType and contains the data inside its own memory allocation. In other words, variables or objects or value types have their own copy of the data.
 
 * Value Type :<br>
  Value type variables can be assigned a value directly. They are derived from the class System.ValueType.
  The value types directly contain data. <br>
  A data type specifies the size and type of variable values. It is important to use the correct data type for the corresponding variable; to avoid errors, to save time and memory, but it will also make your code more maintainable and readable. The most common data types are:
  
| Type | Represents |	Range | Default Value |
| -- | -- | -- | -- |
| bool | Boolean value | 	True or False | False |
| byte | 8-bit unsigned integer | 	0 to 255 | 0 |
| char | 16-bit Unicode character | U +0000 to U +ffff | '\0' |
| decimal |	128-bit precise decimal values with 28-29 significant digits | (-7.9 x 1028 to 7.9 x 1028) / 100 to 28 | 0.0M |
| double| 64-bit double-precision floating point type | (+/-)5.0 x 10-324 to (+/-)1.7 x 10308 | 0.0D |
| float | 32-bit single-precision floating point type | -3.4 x 1038 to + 3.4 x 1038 | 0.0F |
| int | 32-bit signed integer type | -2,147,483,648 to 2,147,483,647 | 0 |
| long | 64-bit signed integer type | -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 | 0L |
| sbyte | 8-bit signed integer type | -128 to 127 | 0 |
| short | 16-bit signed integer type | -32,768 to 32,767 | 0 |
| uint | 32-bit unsigned integer type | 0 to 4,294,967,295 | 0 |
| ulong | 64-bit unsigned integer type | 0 to 18,446,744,073,709,551,615 | 0 |
| ushort |	16-bit unsigned integer type | 0 to 65,535 | 0 |

* Reference Type<br>
The reference types do not contain the actual data stored in a variable, but they contain a reference to the variables.<br>
In other words, they refer to a memory location. Using multiple variables, the reference types can refer to a memory location. If the data in the memory location is changed by one of the variables, the other variable automatically reflects this change in value. Example of built-in reference types are: object, dynamic, and string.<br>
* Object Type <br>
The Object Type is the ultimate base class for all data types in C# Common Type System (CTS). Object is an alias for System.Object class. The object types can be assigned values of any other types, value types, reference types, predefined or user-defined types.<br>
When a value type is converted to object type, it is called boxing and on the other hand, when an object type is converted to a value type, it is called unboxing.
### Object Type Syntax
```c#
object objName;
objName = value; // this is boxing
```
* Dynamic Type<br>
You can store any type of value in the dynamic data type variable. Type checking for these types of variables takes place at run-time.
### Dynamic Type Syntax
```c#
dynamic <variable_name> = value;
```
* Constant<br>
 In C#, a const keyword is used to declare constant fields and constant local. The value of the constant field is the same throughout the program or in other words, once the constant field is assigned the value of this field is not be changed. In C#, constant fields and locals are not variables, a constant is a number, string, null reference, boolean values.
### Constant Syntax
```c#
public const type constName = value;
```

# [Type Casting](https://github.com/rmznkrblt/csharp-introduction/tree/main/DataTypes)

In C#, there are two types of casting:

* Implicit Casting (automatically) - converting a smaller type to a larger type size
char -> int -> long -> float -> double

* Explicit Casting (manually) - converting a larger type to a smaller size type. These conversions are done explicitly by users using the pre-defined functions.<br>
double -> float -> long -> int -> char<br>

### Type Conversion Methods
ToBoolean, ToByte, ToChar, ToDateTime, ToDecimal, ToDouble, ToInt16, ToInt32, ToInt64, ToSbyte, ToSingle, ToString, ToType, ToUInt16, ToUInt32, ToUInt64<br>
     
# [Operators](https://github.com/rmznkrblt/csharp-introduction/tree/main/Operators)

Operators are used to perform operations on variables and values.

| Operator |	Name |	Description |	Example |
| -- | -- | -- | -- |
| +	| Addition	| Adds together two values |	x + y	|
| - | Subtraction	| Subtracts one value from another |	x - y	|
| *	| Multiplication	| Multiplies two values	| x * y	|
| /	| Division	| Divides one value by another	| x / y	|
| %	| Modulus	| Returns the division remainder |	x % y	|
| ++ | Increment	| Increases the value of a variable by 1 |	x++	|
| --	| Decrement	| Decreases the value of a variable by 1 |	x-- |

# [Conditions(Koşullar)](https://github.com/rmznkrblt/csharp-introduction/tree/main/Conditions)
 Eğer bir olayın gerçekleşmesi için bir koşul, şart varsa iki switch yada if...else metodları kullanılır.

* if...else<br>
```c#
if (condition)
{
  // block of code to be executed if the condition is True
}
```
* switch<br>
```c#
switch(expression)
{
  case x:
    // code block
    break;
  case y:
    // code block
    break;
  default:
    // code block
    break;
}
```


# Loops(Döngüler) 

* while<br>
![Tensorboard Keras](https://blog.penjee.com/wp-content/uploads/2015/04/top-5-programming-animated-gifs_demonstration-of-while-loop-animation_logo.gif)

* do/while


* for <br>
![Tensorboard Keras](https://media.geeksforgeeks.org/wp-content/uploads/20191108131134/For-Loop.jpg)

* foreach
# Kaynaklar
 [w3schools](https://www.w3schools.com/cs/cs_variables.asp)<br>
 [tutorialspoint](https://www.tutorialspoint.com/csharp/index.htm)<br>
 [microsoft](https://docs.microsoft.com/tr-tr/dotnet/csharp/)<br>
 [Markdown komutları için](https://guides.github.com/features/mastering-markdown/)<br>
