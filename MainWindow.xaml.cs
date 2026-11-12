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
using System.Windows.Threading;

namespace Assignment2
{
    /// <summary>
    /// Interaction logic for Challenges.xaml
    /// </summary>
    public partial class Challenges : Window
    {
        private readonly Random random = new Random();
        private readonly List<int> times = new List<int> { 5, 10, 15 };
        private readonly List<Rule> rules = new List<Rule>();
        private readonly DispatcherTimer timer = new DispatcherTimer();
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

            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;



        }

        // Generate three rules with 5, 10, and 15 minute countdowns.
        private void Roll_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                rules.Clear();
                foreach (int minutes in times)
                {
                    rules.Add(CreateRandomRule(minutes));
                }
                RefreshDisplay();
                timer.Start();
            }
            catch (ArgumentException exception)
            {
                timer.Stop();
                MessageBox.Show(exception.Message, "Invalid rule");
            } // adding exception handling
        } // Fixing this so that it clears and updates the rules when the button is clicked again

        private Rule CreateRandomRule(int minutes)
        {
            return new Rule(minutes * 60,
                actions[random.Next(actions.Count)],
                consequences[random.Next(consequences.Count)]);
        } // Creates a random rule with the specified time, this time using Objects more effectively

        private void Timer_Tick(object? sender, EventArgs e)
        {
            try
            {
                for (int index = 0; index < rules.Count; index++)
                {
                    rules[index].Time--;
                    if (rules[index].Time == 0)
                    {
                        rules[index] = CreateRandomRule(times[index]);
                    }
                }
                RefreshDisplay();
            }
            catch (ArgumentException exception)
            {
                timer.Stop();
                MessageBox.Show(exception.Message, "Invalid rule");
            }
        } // for loop that creates the timer ticking countdown. Calls objects from the Rule class to create a new rule when the time reaches 0.

        private void RefreshDisplay() // Refreshes the display of the rules and their countdowns in the GUI, so that the timer ticks aren't just sitting there in the background doing their thing while the UI chills slothily.
        { // this is more complicated than I would want to use, but I am out of time
            List<string> countdowns = new List<string>();
            List<string> descriptions = new List<string>();
            foreach (Rule rule in rules)
            {
                countdowns.Add($"{rule.Time / 60:00}:{rule.Time % 60:00}");
                descriptions.Add($"{rule.Action}, {rule.Consequence}");
            }
            TimeTextBlock.Text = string.Join("\n\n", countdowns);
            RulesTextBlock.Text = string.Join("\n\n", descriptions);
        } // I 
    }
}

