using System.Collections;
namespace lib;
public abstract class V
{
    public readonly string name;
    public V(string NameV)
    {
        name = NameV;
    }
    public virtual void Print()
    {
        Console.WriteLine(name);
    }
}
public class VT : V
{
    public VT(string VT, params Chain[] rules) : base(VT)
    { }
}
public class VN : V //менять осторожно
{
    public List<Chain> Rules { get; private set; }
    public VN(string VN) : base(VN)
    {
        Rules = new();
    }
    public void AddRule(Chain InRule)
    {
        Rules.Add(InRule);
    }
    public override void Print()
    {
        Console.Write(name + "-");
        foreach (var item in Rules)
        {
            item.Print();
            Console.Write(" | ");
        }
        // Console.Write("\b\b");
        Console.WriteLine();
    }

}
public class Chain : IEnumerable<V>
{
    public List<ChainHistory>? chainHistory { get; private set; }
    public List<V> chain { get; private set; }
    public bool IsEmpty
    {
        get { return chain.Count > 0; }
    }
    public int CountVT
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
    public int CountVN
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

    public Chain(List<V> args)
    {
        chain = args;
    }
    public Chain()
    {
        chain = new();
    }
    public Chain(params V[] args)
    {
        chain = new();
        foreach (var item in args)
        {
            chain.Add(item);
        }
    }
    public void AddToChain(V arg)
    {
        chain.Add(arg);
    }
    public VN? SearchVN(bool leftSearch = true)
    {
        if (leftSearch)
            for (int i = 0; i < chain.Count; i++)
            {
                if (chain[i] is VN) return (VN)chain[i];
            }
        else
            for (int i = chain.Count - 1; i > -1; i--)
            {
                if (chain[i] is VN) return (VN)chain[i];
            }
        return null;
    }
    public Chain Replace(VN from, Chain that)
    {
        Chain copy = new();
        int index = chain.IndexOf(from);
        for (int i = 0; i < chain.Count; i++)
        {
            if (i == index)
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
        copy.chainHistory?.Add(new ChainHistory(from, new Chain(chain), that));
        return copy;

    }

    public void Print()
    {
        foreach (var item in chain)
        {
            if (item is VN)
                Console.Write($"<{item.name}>");
            else
            {
                Console.Write($"{(item.name == "h" ? "" : item.name)} ");
            }
        }
    }
    public void PrintHistory()
    {
        if (chainHistory is null) Console.WriteLine("История не сохранена");
        else
        {
            foreach (var item in chainHistory)
            {
                foreach (var item1 in item.ReplacedChain)
                {
                    if (item1 == item.ReplacedSymbol)
                    {
                        Console.Write($"*{item1.name}*");
                    }
                    else
                    {
                        Console.Write(item1.name);
                    }
                }
                Console.Write("-");
                foreach (var item1 in item.ReceivedChain)
                {
                    Console.Write(item1.name);
                }
                Console.WriteLine();
            }
        }
    }
    public IEnumerator<V> GetEnumerator()
    {
        return ((IEnumerable<V>)chain).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable)chain).GetEnumerator();
    }
    internal string[] ChainToStringArray()//для тестов

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
    public VN ReplacedSymbol { get; private set; }
    public Chain ReplacedChain { get; private set; }
    public Chain ReceivedChain { get; private set; }

    public ChainHistory(VN replacedSymbol, Chain replacedChain, Chain receivedChain)
    {
        ReplacedSymbol = replacedSymbol;
        ReplacedChain = replacedChain;
        ReceivedChain = receivedChain;
    }
}