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

namespace WpfApp1_dz3
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            string text = textBox1.Text;
            text = text.ToUpper();
            string output = "";
            int count = 0;

            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in words)
            {
                count++;
            }
            output = count.ToString();
            textBox2.Text = output;
            if (textBox1.Text == "")
            {
                MessageBox.Show("ВВЕДИ ТЕКСТ!!!");
                textBox2.Text = " ";
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
        }
        
    }
}
