using System.Text.RegularExpressions;
namespace lib;
public class GramChecker
{
    static public bool ComplexCheckGram(string arg)
    {
        arg = Regex.Replace(arg, @"\s", "");
        arg = arg.Trim(new char[] { '(', ')' });
        try
        {
            CheckGram(arg);
            MatchCollection m= Regex.Matches(arg, @"\{[\wА-Яа-яёЁ\-,\|]+\}");
            CheckV(m[0].Value);
            CheckV(m[1].Value);
            CheckP(m[2].Value);
        }
        catch (Exception e) { Console.WriteLine(e.Message); return false; }
        return true;
    }
    static public void CheckGram(string arg)
    {
        if (
        Regex.IsMatch(arg, @"^\{[\wА-Яа-яёЁ,]+\},\{[\wА-Яа-яёЁ,]+\},\{[\wА-Яа-яёЁ\-\|,]+\},[\wА-Яа-яёЁ]+$") == false
        ) throw new Exception($"неправильная грамматика\nошибка при парсинге:{arg}");
    }
    static public bool CheckV(string arg)
    {
        arg = arg.Trim(new char[] { '{', '}' });
        if (
         Regex.IsMatch(arg, @"^([\wА-Яа-яёЁ]+,)*[\wА-Яа-яёЁ]+$") == false)
            return false;
        else return true;
            //throw new Exception($"неправильный алфавит\nошибка при парсинге:{arg}");
    }
    static public bool CheckP(string arg)
    {
        arg = arg.Trim(new char[] { '{', '}' });
       // foreach (var item in arg.Split(","))
        {
            if (Regex.IsMatch(arg, @"^[\wА-Яа-яёЁ]+-([\wА-Яа-яёЁ]+\|)*[\wА-Яа-яёЁ]+$") == false) return false;
               else return true;
                    // throw new Exception($"неправильные правила\nошибка при парсинге:{item}");
        }
    }
    static public void CheckS(string arg)
    {
        if (Regex.IsMatch(arg, @"^[\wА-Яа-яёЁ]+$") == false)
            throw new Exception($"неправильный S\nошибка при парсинге:{arg}");
    }

}