//передает данные с форм
using lib;
using static System.Windows.Forms.ListBox;

namespace PLT_lab1_winform
{
    internal class View
    {
        internal Dictionary<String, Gram> grams { get; }
        internal ListBox.ObjectCollection? VTList;
        internal ListBox.ObjectCollection? VNList;
        internal ListBox.ObjectCollection? RulesList;
        internal object? S;

        public View()
        {
            S = null;
            grams = new Dictionary<String,Gram>();
            {
                Gram a1 = new Gram();
                a1.AddVT("вагон,локомотив");
                a1.AddVN("голова,хвост");
                a1.AddRules("голова-локомотивхвост,хвост-локомотивхвост|вагонхвост|локомотив,хвост-вагон");
                a1.SetStartVN("голова");
                grams.Add("поезд",a1);
            }
            {
                Gram a1 = new Gram();
                a1.AddVT("0,1,h");
                a1.AddVN("Г,Х");
                a1.AddRules("Г-0Г|1Г|101Х,Х-0Х|1Х|h");
                a1.SetStartVN("Г");
                grams.Add("содержит 101", a1);
            }
            {
                Gram a1 = new Gram();
                a1.AddVT("0,1,a,b,c,h");
                a1.AddVN("Г,Х");
                a1.AddRules("Г-0Х|1Х,Х-0Х|1Х|aХ|bХ|cХ|h");
                a1.SetStartVN("Г");
                grams.Add("начинается с 0 или 1", a1);
            }
            {
                Gram a1 = new Gram();
                a1.AddVT("x, y, z");
                a1.AddVN("S,A,B,T");
                a1.AddRules("S-xB|xTB,T-xA|xTA,B-yz,A-yA|yzz");
                a1.SetStartVN("S");
                grams.Add("2 VN", a1);
            }
            {
                Gram a1 = new Gram();
                a1.AddVT("a,b,_h");
                a1.AddVN("S,T");
                a1.AddRules("S-SS|Sa|_h|aT,T-aa|_h");
                a1.SetStartVN("S");
                grams.Add("с пустотй цепочкой", a1);
            }
        }
        string[] ObjColToStringArray(ObjectCollection arg)
        {
            string [] a = new string[arg.Count];
            arg.CopyTo(a,0);
            return a;
        }
        internal void SaveGram(string name)
        {
            Gram gram = new Gram();
            gram.AddVT(ObjColToStringArray(VTList));
            gram.AddVN(ObjColToStringArray(VNList));
            gram.AddRules(ObjColToStringArray(RulesList));
            gram.SetStartVN(S.ToString());
            gram.CheckVN_Rules();
            grams.Add(name,gram);
        }
    }
}
