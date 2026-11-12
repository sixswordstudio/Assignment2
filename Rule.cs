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
            Time = time;
            Action = action;
            Consequence = consequence;
        }

        public override string ToString()
        {
            return $"Time: {Time}, Action: {Action}, Consequence: {Consequence}";
        }
    }
}
