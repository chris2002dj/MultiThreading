using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MultiThreading
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Btn_Task_Click(object sender, RoutedEventArgs e)
        {
            Lbl_Risultato.Content = "Risultato: ";
            Task.Factory.StartNew(DoWork);
        }

        // Metodo 
        private void DoWork()
        {
            for (int i = 0; i <= 10000; i++)
            {
                for (int j = 0; j < 10000; j++)
                {

                }
            }

            Dispatcher.Invoke(AggiornaInterfaccia);
        }

        private void AggiornaInterfaccia()
        {
            Lbl_Risultato.Content += "Finito";
        }
    }
}
