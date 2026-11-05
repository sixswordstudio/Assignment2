using System.Drawing;
using System.Text;
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

namespace Assignment2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // I want to have a list of actions (string), a list of consequences (string), and list of time remaining (not sure, int? double?) 

            // Time will have 3 items in the list. actions will have 5 items.consequences will have 7.

            // Then i will have to... for i, print the time in grid position 1, and print the action in grid position 2, and print the consequence in grid position 3.

            Rule.Add(new Rule(200, "if you like pie", "then bleep blorp all day"));



            }

        }
    }
}