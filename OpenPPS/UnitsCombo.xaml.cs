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
    /// Логика взаимодействия для UnitsCombo.xaml
    /// </summary>
    public partial class UnitsCombo : UserControl
    {
        public Units test { set; get; }

        public UnitsCombo()
        {
            InitializeComponent();
            
        }

        public UnitsCombo(string _s)
        {
            switch (_s)
            {
                case "pressure":
                    break;
                case "length":
                    break;
                case "volume":
                    break;
                default:
                    break;
            }
        }
    }
}
