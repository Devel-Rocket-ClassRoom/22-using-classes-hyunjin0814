using System;

// README.md를 읽고 아래에 코드를 작성하세요.
ClassName.MemberName();

Console.WriteLine(Square.GetName());

MyFirstClass.StaticMethod();
MyFirstClass firstclass = new MyFirstClass();
firstclass.InstanceMethod();

Person person1 = new Person();
person1.Name = "홍길동";
person1.Age = 25;
person1.Introduce();

Person person2 = new Person();
person2.Name = "김철수";
person2.Age = 30;
person2.Introduce();

Point point1 = new Point();
point1.X = 10;
point1.Y = 20;

Point point2 = point1;
point2.X = 100;

Console.WriteLine($"point1.X = {point1.X}");
Console.WriteLine($"point2.X = {point2.X}");

PointStruct ps1 = new PointStruct();
ps1.X = 10;
PointStruct ps2 = ps1;
ps2.X = 100;

Console.WriteLine($"구조체: ps1.X = {ps1.X}, ps2.X = {ps2.X}");

PointClass pc1 = new PointClass();
pc1.X = 10;
PointClass pc2 = pc1;
pc2.X = 100;

Console.WriteLine($"구조체: pc1.X = {pc1.X}, pc2.X = {pc2.X}");

Calculator calc = new Calculator();
Console.WriteLine($"3 + 5 = {calc.Add(3, 5)}");
Console.WriteLine($"3 * 5 = {calc.Multiply(3, 5)}");

Player player1 = new Player();
player1.ShowInfo();

Player player2 = new Player("용사", 150);
player2.ShowInfo();

Stock stock = new Stock();
stock.CurrentPrice = 30;
Console.WriteLine($"주가: {stock.CurrentPrice}");