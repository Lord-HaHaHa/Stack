using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace Stack
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Stack stack = new Stack();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnPush_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtPush.Text, out int value))
                stack.Push(value);
            txtPush.Clear();
            UpdateStackFill();
        }
        private void btnPop_Click(object sender, RoutedEventArgs e)
        {
            txtPop.Clear();
            txtPop.Text = stack.Pop().ToString();
            UpdateStackFill();
        }
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            txtStackSize.Text = slidMaxStackSize.Value.ToString("");
            stack.MaxLength = (int)slidMaxStackSize.Value;
            slidMaxStackSize.Minimum = stack.GetFillStatus();
            UpdateStackFill();    
        }

        private void UpdateStackFill()
        {
            txtStackFill.Text = stack.GetFillStatus().ToString();
            progbarStackFillStatus.Maximum = stack.MaxLength;
            progbarStackFillStatus.Value = stack.GetFillStatus();
        }
    }
}
