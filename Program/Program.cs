using lib;
using static System.Console;
// See https://aka.ms/new-console-template for more information
string rule = @"({0,1,a,b,c,h},{Г,Х},{Г-0Х|1Х,Х-0Х|1Х|aХ|bХ|cХ|h},Г)";
try
{
    Gram gram = new(rule);
    gram.MaxLengthVN = 3;
    gram.MaxLengthVT = 4;
    gram.Print();

}
catch (Exception e) { WriteLine(e.Message); }
