using System.Collections.ObjectModel;

namespace WpfApp2
{
    public class Rep
    {
        static Rep()
        {
            Db = new ObservableCollection<Worker>
            {
                new Worker("имя_1", Dep.Ot["it"], 1),
                new Worker("имя_2", Dep.Ot["бухгалтерия"], 2),
                new Worker("имя_3", Dep.Ot["it"], 3),
                new Worker("имя_31", Dep.Ot["бухгалтерия"], 3),
                new Worker("имя_32", Dep.Ot["it"], 3)
            
            };
        }

        public static ObservableCollection<Worker> Db { get; internal set; }
        public static ObservableCollection<Worker> DbFind { get; internal set; }
    }



}
