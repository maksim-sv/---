using System.Text.RegularExpressions;
namespace lib;
public class Gram
{
    List<VT> VT;
    List<VN> VN;
    VN StartVN;
    bool leftSearch;
    public bool LeftSearch
    {
        get { return leftSearch; }
        set
        {
            if (leftSearch != value)
            {
                leftSearch = value;
                BuildChains();
            }
        }
    }
    List<Chain> chainsTree;
    public string[][] TreeToStringArray()// для тестов
    {
        if (chainsTree.Count == 0) throw new Exception("дерво пусто");
        string[][] a = new string[chainsTree.Count][];
        for (int i = 0; i < chainsTree.Count; i++)
        {
            a[i] = chainsTree[i].ChainToStringArray();
        }
        return a;
    }
    int maxLengthVT, maxLengthVN;
    int MaxLengthVT
    {
        get
        {
            return maxLengthVT;
        }
        set
        {
            maxLengthVT = value > 0 ? value : 1;
            BuildChains();
        }
    }
    int MaxLengthVN
    {
        get
        {
            return maxLengthVN;
        }
        set
        {
            maxLengthVN = value > 0 ? value : 1;
            BuildChains();
        }
    }
    public Gram(string arg, int maxVT = 6, int maxVN = 10, bool leftSearchArg=true)
    {
        maxLengthVT = maxVT;
        maxLengthVN = maxVN;
        leftSearch = leftSearchArg;
        VT = new List<VT>();
        VN = new List<VN>();
        chainsTree = new List<Chain>();

        arg = Regex.Replace(arg, @"\s", "");
        arg = arg.Trim(new char[] { '(', ')' });
     /*   try
        {*/
            GramChecker.CheckGram(arg);
            MatchCollection m = Regex.Matches(arg, @"\{[\wА-Яа-яёЁ\-,\|]+\}");
            GramChecker.CheckV(m[0].Value);
            GramChecker.CheckV(m[1].Value);
            GramChecker.CheckP(m[2].Value);
            AddVT(m[0].Value.Trim(new char[] { '{', '}' }));
            AddVN(m[1].Value.Trim(new char[] { '{', '}' }),
            m[2].Value.Trim(new char[] { '{', '}' }));
            StartVN = SearchVN(Regex.Match(arg, @"(?<=,)[\wА-Яа-яёЁ]+$").Value);
            BuildChains();
       /* }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }*/
    }
    void AddVT(string args)
    {
        Console.WriteLine("VT:\n" + args);
        foreach (string item in args.Split(new char[] { ',' }))
        {
            VT T = new(item);
            VT.Add(T);
        }
    }
    void AddVN(string VN_list, string Rules_list)
    {
        Console.WriteLine("VN:\n" + VN_list);
        Console.WriteLine("P:\n" + Rules_list);
        //формируем список VN
        foreach (string item in VN_list.Split(new char[] { ',' }))
        {
            //temp_VN_list.Add(new VN(item));
            VN.Add(new VN(item));
        }
        //Каждая строка правил
        foreach (string rule in Rules_list.Split(new char[] { ',' }))
        {
            //выбираем левую и правую части правил
            string left = rule.Substring(0, rule.IndexOf('-'));
            string right = rule.Substring(rule.IndexOf('-') + 1);

            VN? tempVN = SearchVN(left);// Находим VN символ из алфавита
            if (tempVN is null)
            {
                /*  Console.WriteLine($"VN символ <{left}> не найден\nдобавить {left} в список VN?\n1 or 0");
                  if (Console.ReadKey().Key == ConsoleKey.D1)
                  {
                      // temp_VN_list.Add(new VN(left));
                      VN.Add(new VN(left));
                      Console.WriteLine("ok");
                  }
                  else if (Console.ReadKey().Key == ConsoleKey.D0)
                  {
                      break;
                  }*/
                throw new Exception($"Невалидная строка правил: {rule}"+"\n"+$"Символ \"{left}\" не найден");
            }
            //выбираем часть правила,выбираем символ из алфавита и читаем его из начала правила
            // если в правиле нет ни одного символа алфавита- кидаем исключение
            foreach (var part in right.Split(new char[] { '|' }))
            {
                Chain tempChain = new();
                string a = part;// костыль т.к. part readonly
                //искать среди алфавита
                
                A://Заноово искать среди VT и VN
                    if (a.Length > 0)
                    {
                        foreach (var item in VT)//искать первое слово среди VT
                        {
                            if (item.name.Length <= a.Length && item.name == a.Substring(0, item.name.Length))//найти первое слово среди VT
                            {
                                tempChain.AddToChain(item);//добавить слово к цепочке
                                a = a.Substring(item.name.Length);//Вырезать первое слово
                                goto A;
                            }
                        }
                        // foreach (var item in temp_VN_list)//То же что и VT
                        foreach (var item in VN)
                        {
                            if (item.name.Length <= a.Length && item.name == a.Substring(0, item.name.Length))
                            {
                                tempChain.AddToChain(item);
                                a = a.Substring(item.name.Length);
                                goto A;
                            }
                        }
                        throw new Exception($"Невалидная строка правил: {part}\nошибка на строке: {a}");
                    }
                    //если часть правила прочитана,добавляем цепочку к сиволу VN
                    tempVN.AddRule(tempChain);
            }
        }

        //у всех ли VN есть правила?
        foreach (var item in VN)
        {
            if (item.Rules.Count == 0) throw new Exception($"нетерминальный символ <{item.name}> не имеет правил");
            //предложить добавить новое правило
        }
    }
    VN SearchVN(string a)
    {
        foreach (var item in VN)
        {
            if (a == item.name) return item;
        }
        throw new Exception($"не удалось найти нетерминальный символ <{a}>");
    }
    public void Print()
    {
        Console.WriteLine("VT:");
        foreach (var item in VT)
        {
            item.Print();
        }
        Console.WriteLine("VN:");
        foreach (var item in VN)
        {
            item.Print();
        }

        Console.WriteLine($"S:{StartVN}");
        Console.WriteLine("Chains:");
        int i = 0;
        foreach (var item in chainsTree)
        {

            Console.Write($"{i++}\t");
            item.Print();
            Console.Write("\t"+$"L:{item.chain.Count}"+"\n");
            Console.WriteLine("History:");
            PrintChainHistory(i -1);
        }
    }
    public void PrintChainHistory(int i)
    {
        if (i > -1 && i < chainsTree.Count)
        {
            chainsTree[i].PrintHistory();
        }
        else
        {
            Console.WriteLine("неверный индекс");
        }
    }
    //В исходной цепочке ищем VN слева или справа, если нашлось- заменяем его и вызываем рекурсию, иначе 
    // (в цепочке только терминальные символы) добавляем её к дереву
    void BuildChains()
    {
        chainsTree = new();
        BuildChain(new Chain(StartVN));

        void BuildChain(Chain currentChain)
        {
            if (currentChain.CountVT > maxLengthVT || currentChain.CountVN > maxLengthVN)
            {
                if (currentChain.CountVN > maxLengthVN)
                {
                    Console.Write("\nпревышена глубина поиска: цепочка \"");
                    currentChain.Print();
                    Console.Write("\" сброшена");
                }
                return;
            }
            var replacedSymbol =currentChain.SearchVN(LeftSearch);
            if (replacedSymbol is null)
            {
                chainsTree.Add(currentChain);
                return;
            }
            foreach (var item in replacedSymbol?.Item2.Rules)
            {
                BuildChain(currentChain.Replace((int)replacedSymbol?.Item1, item));//вызываем рекурсию для  копии цепочки
            }
        }
        Comparison<Chain> a = (Chain x, Chain y) =>
        {
            if (x.chain.Count == y.chain.Count) return 0;
            return (x.chain.Count > y.chain.Count) ? 1 : -1;
        };
        chainsTree.Sort(a);//сортируем цепочки по длине
    }
}
