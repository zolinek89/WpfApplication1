using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApplication1.ServiceReference1;


namespace WpfApplication1
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string myString { get; set; }

        public MainWindow(string value)
        {
            InitializeComponent();
            this.myString = value;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Service1Client C = new Service1Client();
            C.SendData(textBox2.Text,myString, textBox1.Text);
            
            


        }

       
            

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            Service1Client C = new Service1Client();
            textBox.Text = C.GetData(myString);

        }
    }
}
