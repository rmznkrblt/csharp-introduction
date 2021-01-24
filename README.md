# csharp-introduction
 Bu repository hem kendim için hem de c# diline yeni başlayanlar için oluşturduğum bir kaynaktır. Kod içerisinde gerekli açıklamalar yapılmıştır fakat bazı konular hakkında bir ön bilgi amacıyla README.md kısmında kısa bir konu anlatımı yaptım. Eğer bilmediğiniz yada eksik bildiğinizi düşündüğünüz konular varsa bu kısımdan çalıştıktan sonra koda geçmenizi öneririm. İyi çalışmalar...
 
# Veriables(Değişkenler)
Değişkenler, veri değerlerini depolamak için kullanılan kaplardır.<br>
Tanımlama:
 * tip değişkenAdı = değer; (tip kısmını bilmiyorsanız eğer bir sonraki konu bu olacağı için takılmayın.)
  - Burada degişken adının ilk kelimesinin küçük harfle ikinci kelimenin büyük harfle yazılmış olmasına dikkat ediniz. Bu bir yazım kuralıdır bunları alışkanlık haline getirmeliyiz. Bundan sonraki tanımlamalar da aynı şekilde kurallara uygun yazılacaktır bunlara dikkat ediniz. 
  
<bold> Constants</bold>: Eğer tanımlanan değişkenin değerinin program boyunca değişmesini istemiyorsak const anahtar kelimesi ile tanımlamalıyız
* const tip değişkenAdı = değer;

# Data Types(Veri tipleri)
 İlkel türler, dil tarafından önceden tanımlanmıştır ve ayrılmış anahtar sözcüklerle adlandırılırlar. Dilin temel türlerini temsil ederler.
 * int sayi = 5;                // Sadece tam sayıları tutar
 * double doubleSayi = 5.99D;   // Kayar noktalı sayıları tutar
 * char myLetter = 'D';         // Karakter tutar
 * bool myBool = true;          // True yada false değerlerini tutar
 * string myText = "Hello";     // Kelime tutar.
 
 | Veri tipi | Hafızada kapladığı boyut |Değer aralığı|
| --: | --:| --:|
| int   | 4 byte | -2,147,483,648 - 2,147,483,647 aralığındaki tam sayıları tutar |
| long | 8 byte | -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 aralığındaki tam sayıları tutar |
| float    | 4 byte | ondalıklı kısmı 6 - 7 aralığında kesirli sayıları tutar |
| double    | 8 byte | ondalıklı kısmı 15 basamağa kadar tutabilir |
| bool    | 1 byte | true yada false değerini tutar |
| char    | 2 byte | tek tırnak içerisinde tek bir harf/karakter saklar |
| string    | 2 byte | çift tırnak içerisinde kelime saklar |

# .Net Freamework
 .Net Freamework, aşağıdaki uygulama türlerini yazmanıza yardımcı olan devrim niteliğinde bir platformdur:
  * Windows Uygulamaları
  * Web Uygulamaları
  * Web Servisleri
 
 .Net Freamework uygulamaları, çoklu platform uygulamalarıdır. Freamework, aşağıdaki dillerden herhangi birinden kullanılabilecek şekilde tasarlanmıştır: C#, C++, Visual Basic, Jscript, COBOL, vb. Tüm bu diller freamework e erişebilir ve birbirleriyle iletişim kurabilir.
 
 .Net Freamework, C# gibi istemci dilleri tarafından kullanılan devasa bir kod kitaplığından oluşur. Aşağıda .Net Freamework ün bazı bileşenleri verilmiştir:
  * Common Language Runtime (CLR)
  * The .Net Framework Class Library
  * Common Language Specification
  * Common Type System
  * Metadata and Assemblies
  * Windows Forms
  * ASP.Net and ASP.Net AJAX
  * ADO.Net
  * Windows Workflow Foundation (WF)
  * Windows Presentation Foundation
  * Windows Communication Foundation (WCF)
  * LINQ
 


# Kaynaklar
 [w3schools](https://www.w3schools.com/cs/cs_variables.asp)<br>
 [tutorialspoint](https://www.tutorialspoint.com/csharp/index.htm)
