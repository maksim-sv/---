using System.Collections;
namespace lib;
public abstract class V
{
    public readonly string name;
    internal V(string NameV)
    {
        name = NameV;
    }
    internal virtual void Print()
    {
        Console.WriteLine(name);
    }
}
public class VT : V
{
    internal VT(string VT, params Chain[] rules) : base(VT)
    { }
}
public class VN : V //менять осторожно
{
    public List<Chain> Rules { get; private set; }
    internal VN(string VN) : base(VN)
    {
        Rules = new();
    }
    internal void AddRule(Chain InRule)
    {
        Rules.Add(InRule);
    }
    internal override void Print()
    {
        Console.Write(name + "-");
        foreach (var item in Rules)
        {
            item.Print();
            Console.Write(" | ");
        }
        Console.WriteLine();
    }

}
public class Chain : IEnumerable<V>
{
    public List<ChainHistory>? chainHistory { get; private set; }
    public List<V> chain { get; private set; }
    internal int CountVT
    {
        get
        {
            int count = 0;
            foreach (var item in chain)
            {
                if (item is VT)
                    count++;
            }
            return count;
        }
    }
    internal int CountVN
    {
        get
        {
            int count = 0;
            foreach (var item in chain)
            {
                if (item is VN)
                    count++;
            }
            return count;
        }
    }
    internal Chain()
    {
        chain = new();
    }
    internal Chain(params V[] args)
    {
        chain = new();
        foreach (var item in args)
        {
            chain.Add(item);
        }
    }
    internal void AddToChain(V arg)
    {
        chain.Add(arg);
    }
    internal (int,VN)? SearchVN(bool leftSearch = true)
    {
        if (leftSearch)
            for (int i = 0; i < chain.Count; i++)
            {
                if (chain[i] is VN) return (i,(VN)chain[i]);
            }
        else
            for (int i = chain.Count - 1; i > -1; i--)
            {
                if (chain[i] is VN) return (i,(VN)chain[i]);
            }
        return null;
    }
    internal Chain Replace(int from, Chain that)//возвращает копию цепочки с историей
    {
        Chain copy = new();
        for (int i = 0; i < chain.Count; i++)
        {
            if (i == from)
            {
                foreach (var item in that)
                {
                    copy.AddToChain(item);
                }
            }
            else copy.AddToChain(chain[i]);
        }
        //записать историю
        copy.chainHistory = new();
        if (this.chainHistory is not null)
        {
            foreach (var item in chainHistory)
            {
                copy.chainHistory.Add(item);
            }
        }
        copy.chainHistory?.Add(new ChainHistory(from, this, copy));
        return copy;
    }

    public string Print()
    {
        string a="";
        foreach (var item in chain)
        {
            if (item is VN)
                a+=$"<{item.name}>";
            else
            {
                // Console.Write($"{(item.name == "h" ? "" : item.name)} ");
                a+=item.name;
            }
        }
        return a;
    }
    internal List<string> PrintHistory()
    {
        List<string> history = new List<string>();  
 
            foreach (var item in chainHistory)
            {
                //вывести исходную цепочку
                for (int i = 0; i < item.ReplacedChain.chain.Count; i++)
                {
                    if (item.ReplacedChain.chain[i] is VN)
                    {
                        Console.Write("<");
                        if (i == item.ReplacedSymbolIndex)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(item.ReplacedChain.chain[i].name);
                            Console.ResetColor();
                        }
                        else Console.Write(item.ReplacedChain.chain[i].name);
                        Console.Write(">");
                    }
                    else
                    {
                        Console.Write(item.ReplacedChain.chain[i].name);
                    }
                }
                Console.Write("-");
                item.ReceivedChain.Print();
                Console.Write("\n");
                
            }
        return history;
    }
    public IEnumerator<V> GetEnumerator()
    {
        return ((IEnumerable<V>)chain).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable)chain).GetEnumerator();
    }
    public string[] ChainToStringArray()//для тестов

    {
        if (chain.Count == 0) throw new Exception("цепочка пуста");
        int hCount = 0;
        foreach (var item in chain)
        {
            if (item.name == "h") hCount++;
        }
        string[] a = new string[chain.Count - hCount];
        for (int i = 0; i < chain.Count; i++)
        {
            if (chain[i].name == "h")
                break;
            else
                a[i] = chain[i].name;
        }
        return a;
    }
}
public class ChainHistory
{
    public int ReplacedSymbolIndex { get; private set; }
    public Chain ReplacedChain { get; private set; }
    public Chain ReceivedChain { get; private set; }

    internal ChainHistory(int replacedSymbolIndex, Chain replacedChain, Chain receivedChain)
    {
        ReplacedSymbolIndex = replacedSymbolIndex;
        ReplacedChain = replacedChain;
        ReceivedChain = receivedChain;
    }
}