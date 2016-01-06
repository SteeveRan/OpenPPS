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

namespace OpenPPS
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Units_Pressure pr = new Units_Pressure();
            pr.Set(System.Convert.ToDouble(textBox.Text));
            textBlock.Text = pr.Get_kPa() + " кПа\n" 
                + pr.Get_MPa() + " MПа\n"
                + pr.Get_mm_Hg() + " мм рт. ст.\n"
                + pr.Get_m_H20() + " м в. ст.\n"
                + pr.Get_N_m2() + " Н/м2\n"
                + pr.Get_bar() + " бар\n"
                + pr.Get_kgs_cm2() + " кгс/см2\n"
                + pr.Get_kgs_m2() + " кгс/м2\n"
                ;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            TabItem newTab = new TabItem();
            newTab.Header = "Гидро";
            SimpleGidro newContent = new SimpleGidro();
            newTab.Content = newContent;
            tabControl.Items.Add(newTab);
        }
    }
}
