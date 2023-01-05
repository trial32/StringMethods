// See https://aka.ms/new-console-template for more information



string degisken="Dersimiz C#, hoşgeldiniz!";
string degisken2 = "dersimiz C#, hoşgeldiniz!";

//Uzunluk - Karakter sayısı
Console.WriteLine(degisken.Length);

//ToUpper and To Lower

Console.WriteLine(degisken.ToUpper()); //Bunlar orjinal değişkenimizi değiştirmiyor
Console.WriteLine(degisken.ToLower());

//Concat -Birleştirme İşlmesi
Console.WriteLine(String.Concat(degisken," Merhaba!"));

//Compare and CompareTo
Console.WriteLine(degisken.CompareTo(degisken2));
Console.WriteLine(String.Compare(degisken,degisken2,true));

//contains 
Console.WriteLine(degisken.Contains(degisken2));
Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));
Console.WriteLine(degisken.StartsWith("Merhaba"));

//indexof
Console.WriteLine(degisken.IndexOf("Cs"));
Console.WriteLine(degisken.IndexOf("CS"));
Console.WriteLine(degisken.LastIndexOf("i"));

//insert
Console.WriteLine(degisken.Insert(0,"Merhaba "));


//Padleft, PadRight
Console.WriteLine(degisken+degisken2.PadLeft(30));
Console.WriteLine(degisken+degisken2.PadLeft(30,'*'));
Console.WriteLine(degisken.PadRight(50)+degisken2.PadLeft(30));
Console.WriteLine(degisken.PadRight(50,'-')+degisken2);

//Remove

Console.WriteLine(degisken.Remove(10));
Console.WriteLine(degisken.Remove(5,3));
Console.WriteLine(degisken.Remove(0,1));

//Replace
Console.WriteLine(degisken.Replace("CSharp","C#"));
Console.WriteLine(degisken.Replace(" ","*"));

//Split

Console.WriteLine(degisken.Split(' ')[1]);

//Substring
Console.WriteLine(degisken.Substring(4));
Console.WriteLine(degisken.Substring(4,6));