using Xunit;
using lib;
using System.Collections.Generic;
namespace tests;

public class UnitTest1
{
    [Fact]
    public void TrainGram()
    {
        string rule = @"({вагон,локомотив},{голова,хвост},{голова-локомотивхвост,хвост-локомотивхвост|вагонхвост|локомотив|вагон},голова)";
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
    }

    [Fact]
    public async void Contain101Gram()
    {
        string rule = @"({0,1,h},{Г,Х},{Г-0Г|1Г|101Х,Х-0Х|1Х|h},Г)";
        Gram gram = new Gram(rule, 6);
        string[][] a = {
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
        Assert.Equal(a, gram.TreeToStringArray());

    }

    [Fact]
    public void First01Gram()
    {
        string rule = @"({0,1,a,b,c,h},{Г,Х},{Г-0Х|1Х,Х-0Х|1Х|aХ|bХ|cХ|h},Г)";
        Gram gram = new Gram(rule, 4, 3);
        string[][] a = {
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
        Assert.Equal(a, gram.TreeToStringArray());
    }
}
