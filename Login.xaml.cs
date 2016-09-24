using System.Windows;
using WpfApplication1.ServiceReference1;

namespace WpfApplication1
{
    /// <summary>
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class Login : Window
    {
        public string Namel;
        
       
        public Login()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Service1Client C = new Service1Client();
            bool Log=C.Login(textBox2.Text,textBox.Text);
            if(Log)
            {
                MessageBox.Show("Udane Logowanie. Witaj " + textBox.Text);
                
                MainWindow subwin = new MainWindow(textBox.Text);
                subwin.Show();
                


                this.Close();
            }
            else
            {
                MessageBox.Show("Błąd logowania");
            }
        }
    }
}
