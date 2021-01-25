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
  
  
#  [Veriables](https://github.com/rmznkrblt/csharp-introduction/tree/main/Veriables)  and [Data Types](https://github.com/rmznkrblt/csharp-introduction/tree/main/DataTypes)
 Variables are containers for storing data values.
 ### Declaring (Creating) Variables
 To create a variable, you must specify the type and assign it a value:
 ### Syntax
```c#
type variableName = value;
```
 Where type is a C# type (such as int or string), and variableName is the name of the variable (such as x or name). The equal sign is used to assign values to the variable.
 
 There are two kinds of types in C#: value types and reference types. 
 
 
  
<bold> Constants</bold>: Eğer tanımlanan değişkenin değerinin program boyunca değişmesini istemiyorsak const anahtar kelimesi ile tanımlamalıyız
* const tip değişkenAdı = değer;

# [Data Types(Veri tipleri)](https://github.com/rmznkrblt/csharp-introduction/tree/main/DataTypes)
 
 | Veri tipi | Hafızada kapladığı alan |Değer aralığı|
| -- | -- | -- |
| int   | 4 byte | 2,147,483,648 - 2,147,483,647 aralığındaki tam sayıları tutar |
| long | 8 byte | 9,223,372,036,854,775,808 - 9,223,372,036,854,775,807 aralığındaki tam sayıları tutar |
| float    | 4 byte | ondalıklı kısmı 6 - 7 aralığında kesirli sayıları tutar |
| double    | 8 byte | ondalıklı kısmı 15 basamağa kadar tutabilir |
| bool    | 1 byte | true yada false değerini tutar |
| char    | 2 byte | tek tırnak içerisinde tek bir harf/karakter saklar |
| string    | 2 byte | çift tırnak içerisinde kelime saklar |


# [Type Casting(Tip dönüşümü)](https://github.com/rmznkrblt/csharp-introduction/tree/main/DataTypes)

İki çeşit tip dönüşümü vardır:

 1 - Automatically(otomatik olarak)
   * Eğer kendisinden büyük bir tipe dönüşüm yapılacaksa direk atama (=) işlemi yapılması yeterli<br>
      char -> int -> long -> float -> double <br>
      
 2 - manually(elle)
    * Bu durum kendisinden küçük bir tipe dönüşüm yapılacaksa uygulanır. <br>
      double -> float -> long -> int -> char<br>
    * Bu durum söz konusuysa aşağı metodlar kullanılmalı:<br>
     ToBoolean, ToByte, ToChar, ToDateTime, ToDecimal, ToDouble, ToInt16, ToInt32, ToInt64, ToSbyte, oSingle, ToString, ToType, ToUInt16, ToUInt32, ToUInt64<br>
     
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
