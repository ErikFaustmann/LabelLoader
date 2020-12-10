using AX_Data_Provider;
using AX_Data_Provider.Data;
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

using Microsoft.EntityFrameworkCore.SqlServer;
using System.Data.SqlClient;

namespace Label_Printer_Service
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            string[] args = Environment.GetCommandLineArgs();

            InitializeComponent();

            if (args.Length == 3)
            {
                this.Title = args[1] + " " + args[2];

            }
            else
            {
                this.Title = "Error";
            }

            LabelLoader ll = new LabelLoader("PV168648");
            var nm = ll.Master;
            var gg = ll.Single;

            //var context = new DynacastAX5Context();
            //var blabla = context.LabelsForPrints.Where(s => s.CustZip == "7503").ToList();
            

        }
    }
}
