int a;
int b;
int swapA;

a = 1;
b = 2;
swapA = 0;

//Temporarily save the value of a
swapA = a;

//a takes the value of b
a = b;

//b takes the value of a
b = swapA;

Console.WriteLine(a);
Console.WriteLine(b);