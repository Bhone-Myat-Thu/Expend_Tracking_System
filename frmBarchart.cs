using Assignment_Project.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Assignment_Project
{
    public partial class frmBarchart : Form
    {
        int uid = frmLogin.userid;

        public frmBarchart()
        {
            InitializeComponent();


            ExpenseTracker expTrack = new ExpenseTracker();

            chartExpense.Legends[0].Docking = Docking.Bottom;
            chartExpense.Legends[0].Alignment = StringAlignment.Center;
            chartExpense.ChartAreas[0].AxisY.Minimum = 0;


            Title title = new Title();
            title.Font = new Font("Rubik", 18, FontStyle.Bold);
            title.Text = "Expense Checker";
            chartExpense.Titles.Add(title);

            chartExpense.Series["Education"].Points.AddXY("Jan", expTrack.showChart("Jan", uid, "Education"));
            chartExpense.Series["Health"].Points.AddXY("Jan", expTrack.showChart("Jan", uid, "Health"));
            chartExpense.Series["Saving"].Points.AddXY("Jan", expTrack.showChart("Jan", uid, "Saving"));
            chartExpense.Series["Transportation"].Points.AddXY("Jan", expTrack.showChart("Jan", uid, "Transporation"));

            chartExpense.Series["Education"].Points.AddXY("Feb", expTrack.showChart("Feb", uid, "Education"));
            chartExpense.Series["Health"].Points.AddXY("Feb", expTrack.showChart("Feb", uid, "Health"));
            chartExpense.Series["Saving"].Points.AddXY("Feb", expTrack.showChart("Feb", uid, "Saving"));
            chartExpense.Series["Transportation"].Points.AddXY("Feb", expTrack.showChart("Feb", uid, "Transporation"));

            chartExpense.Series["Education"].Points.AddXY("Mar", expTrack.showChart("Mar", uid, "Education"));
            chartExpense.Series["Health"].Points.AddXY("Mar", expTrack.showChart("Mar", uid, "Health"));
            chartExpense.Series["Saving"].Points.AddXY("Mar", expTrack.showChart("Mar", uid, "Saving"));
            chartExpense.Series["Transportation"].Points.AddXY("Mar", expTrack.showChart("Mar", uid, "Transporation"));

            chartExpense.Series["Education"].Points.AddXY("Apr", expTrack.showChart("Apr", uid, "Education"));
            chartExpense.Series["Health"].Points.AddXY("Apr", expTrack.showChart("Apr", uid, "Health"));
            chartExpense.Series["Saving"].Points.AddXY("Apr", expTrack.showChart("Apr", uid, "Saving"));
            chartExpense.Series["Transportation"].Points.AddXY("Apr", expTrack.showChart("Apr", uid, "Transporation"));

            chartExpense.Series["Education"].Points.AddXY("May", expTrack.showChart("May", uid, "Education"));
            chartExpense.Series["Health"].Points.AddXY("May", expTrack.showChart("May", uid, "Health"));
            chartExpense.Series["Saving"].Points.AddXY("May", expTrack.showChart("May", uid, "Saving"));
            chartExpense.Series["Transportation"].Points.AddXY("May", expTrack.showChart("May", uid, "Transporation"));

            chartExpense.Series["Education"].Points.AddXY("Jun", expTrack.showChart("Jun", uid, "Education"));
            chartExpense.Series["Health"].Points.AddXY("Jun", expTrack.showChart("Jun", uid, "Health"));
            chartExpense.Series["Saving"].Points.AddXY("Jun", expTrack.showChart("Jun", uid, "Saving"));
            chartExpense.Series["Transportation"].Points.AddXY("Jun", expTrack.showChart("Jun", uid, "Transporation"));

            chartExpense.Series["Education"].Points.AddXY("Jul", expTrack.showChart("Jul", uid, "Education"));
            chartExpense.Series["Health"].Points.AddXY("Jul", expTrack.showChart("Jul", uid, "Health"));
            chartExpense.Series["Saving"].Points.AddXY("Jul", expTrack.showChart("Jul", uid, "Saving"));
            chartExpense.Series["Transportation"].Points.AddXY("Jul", expTrack.showChart("Jul", uid, "Transporation"));

            chartExpense.Series["Education"].Points.AddXY("Aug", expTrack.showChart("Aug", uid, "Education"));
            chartExpense.Series["Health"].Points.AddXY("Aug", expTrack.showChart("Aug", uid, "Health"));
            chartExpense.Series["Saving"].Points.AddXY("Aug", expTrack.showChart("Aug", uid, "Saving"));
            chartExpense.Series["Transportation"].Points.AddXY("Aug", expTrack.showChart("Aug", uid, "Transporation"));

            chartExpense.Series["Education"].Points.AddXY("Sep", expTrack.showChart("Sep", uid, "Education"));
            chartExpense.Series["Health"].Points.AddXY("Sep", expTrack.showChart("Sep", uid, "Health"));
            chartExpense.Series["Saving"].Points.AddXY("Sep", expTrack.showChart("Sep", uid, "Saving"));
            chartExpense.Series["Transportation"].Points.AddXY("Sep", expTrack.showChart("Sep", uid, "Transporation"));

            chartExpense.Series["Education"].Points.AddXY("Oct", expTrack.showChart("Oct", uid, "Education"));
            chartExpense.Series["Health"].Points.AddXY("Oct", expTrack.showChart("Oct", uid, "Health"));
            chartExpense.Series["Saving"].Points.AddXY("Oct", expTrack.showChart("Oct", uid, "Saving"));
            chartExpense.Series["Transportation"].Points.AddXY("Oct", expTrack.showChart("Oct", uid, "Transporation"));

            chartExpense.Series["Education"].Points.AddXY("Nov", expTrack.showChart("Nov", uid, "Education"));
            chartExpense.Series["Health"].Points.AddXY("Nov", expTrack.showChart("Nov", uid, "Health"));
            chartExpense.Series["Saving"].Points.AddXY("Nov", expTrack.showChart("Nov", uid, "Saving"));
            chartExpense.Series["Transportation"].Points.AddXY("Nov", expTrack.showChart("Nov", uid, "Transporation"));

            chartExpense.Series["Education"].Points.AddXY("Dec", expTrack.showChart("Dec", uid, "Education"));
            chartExpense.Series["Health"].Points.AddXY("Dec", expTrack.showChart("Dec", uid, "Health"));
            chartExpense.Series["Saving"].Points.AddXY("Dec", expTrack.showChart("Dec", uid, "Saving"));
            chartExpense.Series["Transportation"].Points.AddXY("Dec", expTrack.showChart("Dec", uid, "Transporation"));

        }

    }
}
