using System.Collections;
using System.ComponentModel;
using System.Windows;

namespace WpfApp2
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
            comboBx.ItemsSource = Dep.Ot;
        }
    }



}
