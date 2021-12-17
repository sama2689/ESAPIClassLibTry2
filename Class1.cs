using ESAPIClassLibTry2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using VMS.TPS.Common.Model.API;
using VMS.TPS.Common.Model.Types;

namespace VMS.TPS
{
    public class Script
    {
        public Script()
        {
        }

        public void Execute(ScriptContext context, Window window)
        {
            //If no dose in patient show error.
            if (context.PlanSetup.Dose == null)
            {
                MessageBox.Show("Dose is not calculated for this plan, please check the plan and try again.", "No dose found");
                return;
            }
            //Create object of MainWindow and pass context parameter
            var mainView = new MainView(context);
            window.Title = "TPS QA";
            window.WindowState = WindowState.Maximized;
            window.Content = mainView; //contents to be displayed on window
        }
    }
}

