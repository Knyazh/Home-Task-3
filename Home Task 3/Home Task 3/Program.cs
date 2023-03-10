// See https://aka.ms/new-console-template for more information


Console.Write("Brand Name :");
string firstBrandName = Console.ReadLine();
Console.Write("Brand Count :");
int firstBrandcount = int.Parse (Console.ReadLine());
Console.Write("Brand Price :");
int firstBrandprice = int.Parse(Console.ReadLine());
int firsttotalPrice = firstBrandcount * firstBrandprice;


Console.WriteLine("Firma :" +  firstBrandName);
Console.WriteLine("Ayaqqabi sayi :" +  firstBrandcount);
Console.WriteLine("Birinin qiymeti ($) :" + firstBrandprice);
Console.WriteLine("Hamısının birlikdə qiymeti ($) :" + firsttotalPrice);
Console.WriteLine(" ");
Console.WriteLine(" ");

Console.Write("Brand Name :");
string secondBrandName = Console.ReadLine();
Console.Write("Brand Count :");
int seconBrandcount = int.Parse(Console.ReadLine());
Console.Write("Brand Price :");
int secondBrandprice = int.Parse(Console.ReadLine());
int secondtotalPrice = seconBrandcount * secondBrandprice;

Console.WriteLine("Firma :" + secondBrandName);
Console.WriteLine("Ayaqqabi sayi :" + seconBrandcount);
Console.WriteLine("Birinin qiymeti ($) :" + secondBrandprice);
Console.WriteLine("Hamısının birlikdə qiymeti ($) :" + secondtotalPrice);
Console.WriteLine(" ");
Console.WriteLine(" ");

Console.Write("Brand Name :");
string thirdBrandName = Console.ReadLine();
Console.Write("Brand Count :");
int thirdBrandcount = int.Parse(Console.ReadLine());
Console.Write("Brand Price :");
int thirdBrandprice = int.Parse(Console.ReadLine());
int thirdtotalPrice = thirdBrandcount * thirdBrandprice;

Console.WriteLine("Firma :" + thirdBrandName);
Console.WriteLine("Ayaqqabi sayi :" + thirdBrandcount);
Console.WriteLine("Birinin qiymeti ($) :" + thirdBrandprice);
Console.WriteLine("Hamısının birlikdə qiymeti ($) :" + thirdtotalPrice);


//Console.WriteLine( "Test changes");
//Console.WriteLine( thirdBrandcount);

Console.WriteLine();