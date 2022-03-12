using System.Collections;

abstract class V
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
class VT : V
{
    public VT(string VT, params Chain[] rules) : base(VT)
    { }
}
sealed class VN : V //менять осторожно
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
class Chain : IEnumerable<V>
{
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
    public Chain Replace(VN it, Chain that)
    {
        List<V> copy = new();
        int index = chain.IndexOf(it);
        for (int i = 0; i < chain.Count; i++)
        {
            if (i == index)
            {
                foreach (var item in that)
                {
                    copy.Add(item);
                }
            }
            else copy.Add(chain[i]);
        }
        return new Chain(copy);
    }
    public void Print()
    {
        foreach (var item in chain)
        {
            if (item is VN)
                Console.Write($"<{item.name}>");
            else
            {
                Console.Write($"{(item.name=="h"?"":item.name)} ");
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
}