// Amy Park
// COSC 2100
// Assignment 2
// Classes and Exceptions
// Rule.cs defines what 1 rule contains ( 1 instance of a rule, which is 1 action, 1 consequence, and 1 time remaining). The Rule class is Public so it can be used in MainWindow.xaml.cs to create a list of rules, which will be displayed in the GUI.)

using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2

// Requirements:
// Time, Action, and Consequence properties,
// a constructor accepting all three,
// an overridden ToString() or equivalent instance method producing meaningful rule text.
// backing fields kept private.

{
    public class Rule
    {
         Random Random = new Random();

        // Starting times in minutes for the three rules.
        // The times are stored in a list of integers, which will be used to create the rules.
        List<int> times = new List<int> // My brain can finally start to read this properly! data type, variable name, then assign the variable a new instance of a list int, full of the following values:
            {
                5,  // 300 s
                10, // 600 s
                15  // 900 s
            };

        List<string> actions = new List<string>
            {
                "If the leafs give away the puck...",
                "If the leafs let in 3 goals...",
                "Action 3",
                "Action 4",
                "Action 5"
             };

        List<string> consequences = new List<string>
            {
                "Follow 5 Montreal thirst trap accounts",
                "",
                "Consequence 3",
                "Consequence 4",
                "Consequence 5",
                "Consequence 6",
                "Consequence 7"
            };




        // Create list of rules for actions, consequences, and time remaining
        private int time;
        private string action;
        private string consequence;

        // The public Time takes the private time, and sets the private time as the value for the public Time. Public time can be accessed by other classes, but the private time can only be accessed within this Rules class file. 
        public int Time 
        {
            get { return time; } 
            set { time = value; } 
        
        } 
        public string Action
        {
            get { return action; }
            set { action = value; }
        }
        public string Consequence
        {
            get { return consequence; }
            set { consequence = value; }
        }

        // Constructor for Rule class
        public Rule(int time, string action, string consequence)
        {
            if (time <= 0)
                throw new ArgumentOutOfRangeException(nameof(time), "Rule time must be greater than zero.");
            if (string.IsNullOrWhiteSpace(action))
                throw new ArgumentException("A rule needs an action.", nameof(action));
            if (string.IsNullOrWhiteSpace(consequence))
                throw new ArgumentException("A rule needs a consequence.", nameof(consequence));// throwing exceptions when they come up!

            Time = time; // Given the above, Capitalized Time is the public property, and lowercase time is the private field. By setting the public to the private, I guess I am add a layer of security and control over how things are accessed, modified, and displayed. 
            Action = action;
            Consequence = consequence;
        }


        public override string ToString()
        {
            return $"Time: {Time}, Action: {Action}, Consequence: {Consequence}";
        }
    }
}
