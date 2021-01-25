# C# Introduction
 Bu repository hem kendim için hem de c# diline yeni başlayanlar için oluşturduğum bir kaynaktır. Konular birbileri ile etkileşim halinde olduğu için sırası ile takip edilmesini öneririm. Bu repository c# diline giriş seviyesindedir. Buradaki konuları bitirdikten sonra daha ileri bir seviye olan ve sizi sektörde ileriye taşıyacak olan [OOP-csharp](https://github.com/rmznkrblt/OOP-csharp) repositorysine devam ediniz. İyi çalışmalar...
 
# [Veriables(Değişkenler)](https://github.com/rmznkrblt/csharp-introduction/tree/main/Veriables)
Değişkenler, veri değerlerini depolamak için kullanılan kaplardır.<br>
Tanımlama:
 * tip değişkenAdı = değer; (tip kısmını bilmiyorsanız eğer bir sonraki konu bu olacağı için takılmayın.)
  - Burada degişken adının ilk kelimesinin küçük harfle ikinci kelimenin büyük harfle yazılmış olmasına dikkat ediniz. Bu bir yazım kuralıdır bunları alışkanlık haline getirmeliyiz. Bundan sonraki tanımlamalar da aynı şekilde kurallara uygun yazılacaktır bunlara dikkat ediniz. 
  
<bold> Constants</bold>: Eğer tanımlanan değişkenin değerinin program boyunca değişmesini istemiyorsak const anahtar kelimesi ile tanımlamalıyız
* const tip değişkenAdı = değer;

# [Data Types(Veri tipleri)](https://github.com/rmznkrblt/csharp-introduction/tree/main/DataTypes)
 İlkel türler(), dil tarafından önceden tanımlanmıştır ve ayrılmış anahtar sözcüklerle adlandırılırlar. Dilin temel türlerini temsil ederler.
 
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

* while

* do/while


* for <br>
![Tensorboard Keras](G:\Project\c# project\GitHub\Image\csharp-introduction image\a3.gif "for loop")

* foreach
# Kaynaklar
 [w3schools](https://www.w3schools.com/cs/cs_variables.asp)<br>
 [tutorialspoint](https://www.tutorialspoint.com/csharp/index.htm)<br>
 [microsoft](https://docs.microsoft.com/tr-tr/dotnet/csharp/)<br>
 [Markdown komutları için](https://guides.github.com/features/mastering-markdown/)<br>
