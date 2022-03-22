using System.Text.RegularExpressions;
namespace lib;
public class Gram
{
    public List<VT> VT { get; private set; }
    public List<VN> VN { get; private set; }
    public VN StartVN { get; private set; }

    public Gram()
    {
        VT = new List<VT>();
        VN = new List<VN>();
    }
    public Gram(string arg, int maxVT = 6, int maxVN = 10)
    {
        VT = new List<VT>();
        VN = new List<VN>();

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
        //AddVN(m[1].Value.Trim(new char[] { '{', '}' }),
        m[2].Value.Trim(new char[] { '{', '}' });
        StartVN = SearchVN(Regex.Match(arg, @"(?<=,)[\wА-Яа-яёЁ]+$").Value);

        /* }
         catch (Exception e)
         {
             Console.WriteLine(e.Message);
         }*/
    }
    public void AddVT(string args)
    {
        args = Regex.Replace(args, @"\s", "");
        args.Trim(new char[] { '{', '}' });

        foreach (string item in args.Split(new char[] { ',' }))
        {
            VT T = new(item);
            VT.Add(T);
        }
    }
    public void AddVT(params string[] args)
    {
        foreach (string item in args)
        {
            VT T = new(item);
            VT.Add(T);
        }
    }

    public void AddVN(string VN_list)
    {
        VN_list = Regex.Replace(VN_list, @"\s", "");
        VN_list.Trim(new char[] { '{', '}' });
        //формируем список VN
        foreach (string item in VN_list.Split(new char[] { ',' }))
        {
            VN.Add(new VN(item));
        }
    }
    public void AddVN(params string[] VN_list)
    {
        //формируем список VN
        foreach (string item in VN_list)
        {
            VN.Add(new VN(item));
        }
    }

    public void SetStartVN(string vnName)
    {
        StartVN = SearchVN(vnName);
    }
    public void AddRules(params string[] Rules_list)
    {

        // Каждая строка правил
        foreach (string rule in Rules_list)
        {
            //выбираем левую и правую части правил
            string left = rule.Substring(0, rule.IndexOf('-'));
            string right = rule.Substring(rule.IndexOf('-') + 1);

            VN? tempVN = SearchVN(left);// Находим VN символ из алфавита
            if (tempVN is null)
            {
                throw new Exception($"Символ \"{left}\" не найден");
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
                    throw new Exception($"Невалидная строка правил: {part}");
                }
                //если часть правила прочитана,добавляем цепочку к сиволу VN
                tempVN.AddRule(tempChain);
            }
        }
    }
    public void AddRules(string Rules_list)
    {
        Rules_list = Regex.Replace(Rules_list, @"\s", "");
        Rules_list.Trim(new char[] { '{', '}' });
        // Каждая строка правил
        foreach (string rule in Rules_list.Split(new char[] { ',' }))
        {
            //выбираем левую и правую части правил
            string left = rule.Substring(0, rule.IndexOf('-'));
            string right = rule.Substring(rule.IndexOf('-') + 1);

            VN? tempVN = SearchVN(left);// Находим VN символ из алфавита
            if (tempVN is null)
            {
                throw new Exception($"Символ \"{left}\" не найден");
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
                    throw new Exception($"ошибка на строке: {a}");
                }
                //если часть правила прочитана,добавляем цепочку к сиволу VN
                tempVN.AddRule(tempChain);
            }
        }
    }

    public void CheckVN_Rules()
    {
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


    //В исходной цепочке ищем VN слева или справа, если нашлось- заменяем его и вызываем рекурсию, иначе 
    // (в цепочке только терминальные символы) добавляем её к дереву
    public List<Chain> BuildChains(bool leftSearch,int maxLengthVT,int maxLengthVN)
    {
        List<Chain> chainsTree = new();
        BuildChain(new Chain(StartVN));

        void BuildChain(Chain currentChain)
        {
            if (currentChain.CountVT > maxLengthVT || currentChain.CountVN > maxLengthVN)
            {
                return;
            }
            var replacedSymbol = currentChain.SearchVN(leftSearch);
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
        return chainsTree;
    }
}
