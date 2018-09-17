using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace WpfApp2
{
    public static class Dep
    {
        static Dep()
        {
            Ot = new Dictionary<string, string>();
            Ot.Add("все","");
            Ot.Add("it", "Отдел 1");
            Ot.Add("бухгалтерия", "Отдел 2");
        }
        static public Dictionary<string, string> Ot { get; set; }
    }



}
