using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    public class Rule
    {
        // Create list of rules for actions, consequences, and time remaining
        public int Time { get; } // getters and setters allow for the properties to be accessed and modified from outside the class. i.e, accessed from MainWindow.xaml.cs
        public string Action { get; } // I'm pretty sure I only need getters for these properties, since they will be set in the constructor and not modified afterwards.
        public string Consequence { get; } // time will tell, i suppose.

        // Constructor for Rule class
        public Rule(int time, string action, string consequence)
        {
            Time = time;
            Action = action;
            Consequence = consequence;
        }
    }
}
