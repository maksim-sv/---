using lib;
using static System.Console;
using System.Text.RegularExpressions;
// See https://aka.ms/new-console-template for more information
string rule = @"({0,1,a,b,c,h},{Г,Х},{Г-0Х|1Х,Х-1Х|aХ|bХ|cХ|h,Х-0Х},Г)";
// string rule = @"{0,1,a,b,c,h}";

try
{
    Gram gram = new(rule,3,2,false);
    gram.Print();
}
catch (Exception e) { WriteLine(e.Message); }
Read();