using static System.Console;

//WriteLine($"VT count={train.CountVT}, VN count={train.CountVN}");
 string rule = @"({вагон,локомотив},{голова,хвост},{голова-локомотивхвост,хвост-локомотивхвост|вагонхвост|локомотив|вагон},голова)";
// string rule = @"({0,1,a,b,c,h},{Г,Х},{Г-0Х|1Х,Х-0Х|1Х|aХ|bХ|cХ|h},Г)";
//string rule = @"({0,1,h},{Г,Х},{Г-0Г|1Г|101Х,Х-0Х|1Х|h},Г)";
WriteLine(rule);
/*try
{
    cl.a();
}
catch (Exception e)
{
    WriteLine(e.Message);
}*/
try
{
    Gram gram = new(rule);
    gram.MaxLengthVN = 3;
    gram.MaxLengthVT = 5;
    gram.Print();
    gram.BuildChains();
}
catch (Exception e) { WriteLine(e.Message); }





class cl//для тестов
{
    public static void a()
    {
        if (true)
        {

            throw new Exception("abba");
        }
    }
    public List<V> chain;
    public string[] VT, VN;
    public cl()
    {
        chain = new();
    }
    public bool Search(string a)
    {
        List<V> tempChain = new();
    A:
        while (a.Length > 0)
        {
            foreach (var item in VT)
            {
                if (item == a.Substring(0, item.Length))
                {
                    V T = new VT(item);
                    tempChain.Add(T);
                    a = a.Substring(item.Length);
                    goto A;
                }
            }
            foreach (var item in VN)
            {
                if (item == a.Substring(0, item.Length))
                {
                    V T = new VN(item);
                    tempChain.Add(T);
                    a = a.Substring(item.Length);
                    goto A;
                }
            }
            return false;
        }
        chain = tempChain;
        return true;
    }
}

//Gram gram = new(a);