using lib;
using static System.Console;
using System.Text.RegularExpressions;
// See https://aka.ms/new-console-template for more information
string rule = @"({1},{Г},{Г-ГГ|1},Г)";
// string rule = @"{0,1,a,b,c,h}";

try
{
    Gram gram = new(rule,6,4,false);
    gram.Print();
}
catch (Exception e) { WriteLine(e.Message); }
Read();