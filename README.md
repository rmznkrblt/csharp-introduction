# C# Introduction
This repository is a resource created both for myself and for beginners to the c # language. Since the topics interact with each other, I recommend that they be followed sequentially. This repository has been prepared for the beginners to help them understand basic C# programming. After the topics here are over, continue with the [OOP-csharp](https://github.com/rmznkrblt/OOP-csharp) repository, which is a more advanced level and will carry you forward in the sector. Good luck with!!!...
 
# What is c#?
 C# is a modern, object-oriented, and type-safe programming language. C# has its roots in the C family of languages and will be immediately familiar to C, C++, Java, and JavaScript programmers. C# provides language constructs to directly support these concepts, making C# a natural language in which to create and use software components. Since its origin, C# has added features to support new workloads and emerging software design practices.
 
# [Data Types](https://github.com/rmznkrblt/csharp-introduction/tree/main/DataTypes) and [Veriables](https://github.com/rmznkrblt/csharp-introduction/tree/main/Veriables) 

  
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
if (condition) <br>
{<br>
  // block of code to be executed if the condition is True<br>
}<br>

* switch<br>
switch(expression) <br>
{ <br>
  case x: <br>
    // code block <br>
    break; <br>
  case y: <br>
    // code block <br>
    break; <br>
  default: <br>
    // code block <br>
    break; <br>
} <br>

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
