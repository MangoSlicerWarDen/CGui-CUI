using System;
using System.Collections.Generic;
using System.Numerics;
using System.Threading;
using System.Threading.Tasks;
using cui.Abstractions;
using cui.Controls;

namespace cui.Test
{
    public class MainMenu : MenuBase
    {
        public MainMenu() : base("Main Menu")
        {
            //Enter your oWo code here.

            Controls.Add(new Label("test ultra test :cool_glasses:"));
        }
    }
}