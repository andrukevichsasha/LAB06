using LAB06;

Box a = new Box(13, 4, 9);
Box b = new Box(7);

a.Lenght = 8;

Console.WriteLine(a);
Console.WriteLine(b);

Box c = a +  b;
Box d = a -  b;

Console.WriteLine(c);
Console.WriteLine(d);

Console.WriteLine(a == c);
Console.WriteLine(b != d);