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
    /// Interaction logic for Challenges.xaml
    /// </summary>
    public partial class Challenges : Window
    {
        private readonly Random random = new Random();
        private readonly List<int> times = new List<int> { 5, 10, 15 };
        private readonly List<string> actions = new List<string>
        {
            "If the Leafs give up the first goal",
            "If the Leafs take a penalty",
            "If the Leafs score on the power play",
            "If the Leafs blow a 2 goal lead",
            "If the Leafs blow a 3 goal lead",
            "If the Leafs win in overtime"
        };
        private readonly List<string> consequences = new List<string>
        {
            "say 'this is our year' with a straight face",
            "wear your Leafs jersey inside out on the Go Train back to Oshawa",
            "do jumping jacks during the American National Anthem",
            "text a habs fan 'I still belief'",
            "you are now the goal horn. sing us the song of your people",
            "you must become a true believer in the power of the amulet.",
            "write a letter of apology to Mats Sundin"
        };

        public Challenges()
        {
            InitializeComponent();

            //todo: timer countdown :(



        }

        // Generate the rules by randomly selecting an action, a consequence, and a time.
        private void Roll_Click(object sender, RoutedEventArgs e)
        {
            string action = actions[random.Next(actions.Count)];
            string consequence = consequences[random.Next(consequences.Count)];
            int time = times[random.Next(times.Count)];

            // Create a new instance of the Rule class using the randomly selected action, consequence, and time.
            Rule rule = new Rule(time, action, consequence);

            RulesTextBlock.Text = rule.ToString();
            TimeTextBlock.Text = $"You have {rule.Time} minutes!";

        }
    }
}

