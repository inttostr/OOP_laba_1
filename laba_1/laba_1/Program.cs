using System;
using System.Text;
using laba_1;

var r1 = new Rational(2, 3);
var r2 = new Rational(5, 2);

Console.WriteLine(r1.ToString()); // Output: 2/3
Console.WriteLine(r2.ToString()); // Output: 5/2

Console.WriteLine(r1 + r2); // Output: 16/6
Console.WriteLine(r1 - r2); // Output: -8/6
Console.WriteLine(r1 * r2); // Output: 10/6
Console.WriteLine(r1 / r2); // Output: 4/15

Console.WriteLine(-r1); // Output: -2/3

Console.WriteLine(r1 == r2); // Output: False
Console.WriteLine(r1 != r2); // Output: True
Console.WriteLine(r1 < r2); // Output: True
Console.WriteLine(r1 <= r2); // Output: True
Console.WriteLine(r1 > r2); // Output: False
Console.WriteLine(r1 >= r2); // Output: False

