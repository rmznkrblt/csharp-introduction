# Veriables and Types

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
