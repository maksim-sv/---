using System.Text.RegularExpressions;
namespace lib;
public class Gram
{
    List<VT> VT;
    List<VN> VN;
    VN? StartVN;
    List<Chain> treeChains;
    public List<Chain> TreeChains
    {
        get
        {
            if (treeChains is null)
                BuildChains();
            return treeChains;
        }
    }
    public string[] [] TreeToStringArray()// для тестов
    {
            if (TreeChains.Count ==0) throw new Exception("дерво пусто");
            string[] [] a = new string [TreeChains.Count] [];
            for (int i = 0; i < TreeChains.Count; i++)
            {
                    a[i] = TreeChains[i].ChainToStringArray();
            }
            return a;
        
    }
    int maxLengthVT, maxLengthVN;
    public int MaxLengthVT
    {
        get
        {
            return maxLengthVT;
        }
        set
        {
            maxLengthVT = value > 0 ? value : 1;
        }
    }
    public int MaxLengthVN
    {
        get
        {
            return maxLengthVN;
        }
        set
        {
            maxLengthVN = value > 0 ? value : 1;
        }
    }
    public Gram(string a, int maxVT = 6, int maxVN = 10)
    {
        MaxLengthVT = maxVT;
        MaxLengthVN = maxVN;
        VT = new List<VT>();
        VN = new List<VN>();
        a = a.Trim(new char[] { '(', ')' });
        string[] args = new string[4];
        {
            int start = 1, end, length;
            end = a.IndexOf('}', start);
            if (end == -1) throw new Exception("ошибка при парсинге VT\nНеверная грамматика");
            length = end - start;
            args[0] = (a.Substring(start, length));
            start = end + 3;
            end = a.IndexOf('}', start);
            if (end == -1) throw new Exception("ошибка при парсинге VN\nНеверная грамматика");
            length = end - start;
            args[1] = (a.Substring(start, length));
            start = end + 3;
            end = a.IndexOf('}', start);
            if (end == -1) throw new Exception("ошибка при парсинге правил\nНеверная грамматика");
            length = end - start;
            args[2] = (a.Substring(start, length));
            start = end + 2;
            args[3] = a.Substring(start);

            try
            {
                AddVT(args[0]);
                AddVN(args[1], args[2]);
                StartVN = SearchVN(args[3]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new Exception("не удалось создать грамматику");
            }
        }
    }
    public void AddVT(string args)
    {

        foreach (string item in args.Split(new char[] { ',' }))
        {
            VT T = new(item);
            VT.Add(T);
        }
    }
    public void AddVN(string VN_list, string Rules_list)
    {
        //формируем список VN
        //List<VN> temp_VN_list = new();
        foreach (string item in VN_list.Split(new char[] { ',' }))
        {
            //temp_VN_list.Add(new VN(item));
            VN.Add(new VN(item));
        }
        //Парсим правила
        Rules_list = Regex.Replace(Rules_list, @"[ \r\n\t]", "");//убрать пробелы, таб, переносы
        //Каждая строка правил
        foreach (string rule in Rules_list.Split(new char[] { ',' }))
        {
            //выбираем левую и правую части правил
            string left = rule.Substring(0, rule.IndexOf('-'));
            string right = rule.Substring(rule.IndexOf('-') + 1);

            VN? tempVN = SearchVN(left);
            if (tempVN is null)
            {
                Console.WriteLine($"VN символ <{left}> не найден\nдобавить {left} в список VN?\n1 or 0");
                if (Console.ReadKey().Key == ConsoleKey.D1)
                {
                    // temp_VN_list.Add(new VN(left));
                    VN.Add(new VN(left));
                    Console.WriteLine("ok");
                }
                else if (Console.ReadKey().Key == ConsoleKey.D0)
                {
                    break;
                }
            }
            //выбираем часть правила
            foreach (var part in right.Split(new char[] { '|' }))
            {
                Chain tempChain = new();
                string a = part;// костыль т.к. part изменять нельзя
                try
                {
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
                    //если часть правила прочитано
                    tempVN.AddRule(tempChain);//есть проверка на пустоту
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    // break;//перейти к следущей части правила если в текущей ошибка
                }
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
        if (TreeChains is null) return;
        Console.WriteLine("Chains:");
        foreach (var item in treeChains)
        {
            item.Print();
            Console.Write($"    L:{item.chain.Count}");
            Console.WriteLine();
        }
    }
    //build chains
    void BuildChains()
    {
        treeChains = new();
        BuildChain(new Chain(new List<V> { StartVN }));

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
            VN? T = currentChain.SearchVN();
            if (T is null)
            {
                treeChains.Add(currentChain);
                return;
            }
            foreach (var item in T.Rules)
            {
                BuildChain(currentChain.Replace(T, item));
            }
        }
        Comparison<Chain> a = (Chain x, Chain y) =>
        {
            if (x.chain.Count == y.chain.Count) return 0;
            return (x.chain.Count > y.chain.Count) ? 1 : -1;
        };
        treeChains.Sort(a);
    }
}
