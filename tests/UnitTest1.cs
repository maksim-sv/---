using Xunit;
using lib;
using System.Collections.Generic;
namespace tests;

public class UnitTest1
{
    [Fact]
    public void CheckBuildTreeGram()
    {
        string rule = @"({вагон,локомотив},{голова,хвост},{голова-локомотивхвост,хвост-локомотивхвост|вагонхвост|локомотив,хвост-вагон},голова)";
        Gram gram = new Gram(rule, 3);
        string[][] a = {
            new string [] {"локомотив","локомотив"},
            new string [] {"локомотив","вагон"},
            new string [] {"локомотив","локомотив","локомотив"},
            new string [] {"локомотив","локомотив","вагон"},
            new string [] {"локомотив","вагон","локомотив"},
            new string [] {"локомотив","вагон","вагон"},
        };
        Assert.Equal(a, gram.TreeToStringArray());

        string rule1 = @"({0,1,h},{Г,Х},{Г-0Г|1Г|101Х,Х-0Х|1Х|h},Г)";
        Gram gram1 = new Gram(rule1, 6);
        string[][] a1 = {
            "1 0 1".Split(),// я узнал что так можно после того как написал синтаксис массивов
            new string [] {"1","0","1","0"},
            new string [] {"0","1","0","1"},
            new string [] {"1","1","0","1"},
            new string [] {"1","0","1","1"},
            new string [] {"1","0","1","1","1"},
            new string [] {"1","0","1","1","0"},
            new string [] {"1","0","1","0","1"},
            new string [] {"1","0","1","0","0"},
            new string [] {"1","1","0","1","1"},
            new string [] {"1","1","1","0","1"},
            new string [] {"1","0","1","0","1"},
            new string [] {"0","1","0","1","1"},
            new string [] {"0","1","0","1","0"},
            new string [] {"0","1","1","0","1"},
            new string [] {"1","1","0","1","0"},
            new string [] {"0","0","1","0","1"},

        };
        Assert.Equal(a1, gram1.TreeToStringArray());

        string rule2 = @"({0,1,a,b,c,h},{Г,Х},{Г-0Х|1Х,Х-0Х|1Х|aХ|bХ|cХ|h},Г)";
        Gram gram2 = new Gram(rule2, 4, 3);
        string[][] a2 = {
            "0".Split(),
            "1".Split(),
            "0 a".Split(),
            "1 0".Split(),
            "1 c".Split(),
            "0 0".Split(),
            "0 c".Split(),
            "1 a".Split(),
            "1 b".Split(),
            "0 b".Split(),
            "0 1".Split(),
            "1 1".Split(),
            "1 a 0".Split(),
            "1 1 b".Split(),
            "1 a 1".Split(),
            "1 1 a".Split(),
            "1 1 1".Split(),
            "1 1 0".Split(),
            "1 1 c".Split(),
            "1 a a".Split(),
            "0 0 a".Split(),
            "1 a c".Split(),
            "1 b 0".Split(),
            "1 b 1".Split(),
            "1 b a".Split(),
            "1 b b".Split(),
            "1 b c".Split(),
            "1 c 0".Split(),
            "1 c 1".Split(),
            "1 c a".Split(),
            "1 c b".Split(),
            "1 c c".Split(),
            "1 a b".Split(),
            "1 0 c".Split(),
            "1 0 0".Split(),
            "1 0 a".Split(),
            "0 0 b".Split(),
            "0 0 c".Split(),
            "0 1 0".Split(),
            "0 1 1".Split(),
            "0 1 a".Split(),
            "0 1 b".Split(),
            "0 1 c".Split(),
            "0 a 0".Split(),
            "0 a 1".Split(),
            "0 a a".Split(),
            "0 a b".Split(),
            "1 0 b".Split(),
            "0 a c".Split(),
            "0 b 1".Split(),
            "0 b a".Split(),
            "0 b b".Split(),
            "0 b c".Split(),
            "0 c 0".Split(),
            "0 c 1".Split(),
            "0 c a".Split(),
            "0 c b".Split(),
            "0 c c".Split(),
            "0 0 1".Split(),
            "1 0 1".Split(),
            "0 b 0".Split(),
            "0 0 0".Split()
                    };
        // Assert.Equal(expected, gram.TreeChains);
        Assert.Equal(a2, gram2.TreeToStringArray());
    }

    [Fact]
    public void CheckGram()
    {
        string gram = @"( { вагон,локомотив},{ голова,
        хвост},{голова-локомотивхвост,хвост-локомотивхвост  |вагонхвост
        |локомотив,хвост-вагон},голова)";
        Assert.True(GramChecker.ComplexCheckGram(gram));

        string gram1 = @"{asd},{asd},
        {asd},s";
        Assert.False(GramChecker.ComplexCheckGram(gram1));

        string gram2 = @"{},{asd},
        {asd-fd},fd-gd";
        Assert.False(GramChecker.ComplexCheckGram(gram2));
        string gram3 = @"{},{asd},
        {asd-fd},fd-gd";
        Assert.False(GramChecker.ComplexCheckGram(gram3));
        string gram4 = @"{},{asd},
        {asd-fd},()";
        Assert.False(GramChecker.ComplexCheckGram(gram4));
        string gram5 = @"{asd-sad
        },{asd },
        {asd-fd},asjkld";
        Assert.False(GramChecker.ComplexCheckGram(gram5));
        string gram6 = @"asd-sad
        },{asd },
        {-ds-kfj},asjkld";
        Assert.False(GramChecker.ComplexCheckGram(gram6));
    }

}
