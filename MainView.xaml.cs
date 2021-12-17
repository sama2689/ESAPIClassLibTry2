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
using VMS.TPS.Common.Model.API;

namespace ESAPIClassLibTry2
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    /// 


    public partial class MainView : UserControl
    {
        private ScriptContext context1;

        public MainView()
        {
            InitializeComponent();
        }


        public MainView(ScriptContext context)
        {
            InitializeComponent();
            context1 = context; //Copy currently loaded patient data content


            //The below is all code from the ESAPIQA
            /*
            //Load QA category radio buttons Profile & PDD
            List<string> QACategories = new List<string> { "Profile", "PDD" };
            foreach (object str in QACategories)
            {
                RadioButton rb = new RadioButton() { Content = str, Margin = new Thickness(10), };
                QACategoriesRadioBtn.Children.Add(rb);
                rb.Checked += new RoutedEventHandler(QACat_Checked);
            }

            //Fields radio button are pulled from the patient field names
            List<string> fields = FieldsForRadioButton(context.PlanSetup);
            foreach (object obj in fields)
            {
                RadioButton rb = new RadioButton() { Content = obj, Margin = new Thickness(10), };
                fieldsRadioBtn.Children.Add(rb);
                rb.Checked += new RoutedEventHandler(fieldsRadioBtnChecked);
            }

            //To format gamma Y axis of gamma to 2 decimal spaces - used as bindding in xaml
            //Converting to string because values close to zero are shown as exponential numbers
            cartesianChart1.AxisY[1].LabelFormatter = val => val.ToString("N2");
            cartesianChart1.AxisX[0].LabelFormatter = val => val.ToString("0.##");

            measuredNormValue.Text = MeasuredNormDefaultValue;
            calculatedNormValue.Text = CalculatedNormDefaultValue;
            profileOffsetXmm.Text = MeasuredProfileOffsetXmmValue;
            */
        }
    }

    //constructor with context as an argument
    
}
