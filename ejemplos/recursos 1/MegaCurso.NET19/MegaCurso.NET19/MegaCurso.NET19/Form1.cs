using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaCurso.NET19
{
    public partial class fMain : Form
    {

        private System.Threading.Timer _ThreadTimer;

        public fMain()
        {
            InitializeComponent();

            Control.CheckForIllegalCrossThreadCalls = false;
        }



        private void btnAction_Click(object sender, EventArgs e)
        {

            DateTime myDate = DateTime.Now;




            //number of processor ticks
            //this.txtResult.Text = myDate.Ticks.ToString();


            //add quantity to date
            //myDate = myDate.AddDays(10);
            //this.txtResult.Text = myDate.ToString();


            //default value when no date is set
            //this.txtResult.Text = DateTime.MinValue.ToString();
            //this.txtResult.Text = DateTime.MaxValue.ToString();


            //add - calc diff between dates
            //DateTime otherDate = new DateTime(2010, 1, 1);
            //this.txtResult.Text = otherDate.AddYears(-10).ToString();

            //TimeSpan diff = myDate - otherDate;
            //this.txtResult.Text =  (myDate - otherDate).TotalHours.ToString();


            //custom initialization
            //DateTime otherDate = new DateTime(2004, 10, 08, 22, 15, 10);
            //this.txtResult.Text = otherDate.ToString();

            //long date format
            //this.txtResult.Text = myDate.ToLongDateString();

            //custom datetime formats
            //this.txtResult.Text = myDate.ToString("dddd dd MMMM yyyy HH:mm:ss,ffff");

        }

        private void myTmr_Tick(object sender, EventArgs e)
        {
            this.txtResult.Text = DateTime.Now.ToString();
        }

        private void btnEnableTimer_Click(object sender, EventArgs e)
        {
            this.myTmr.Enabled = true;
        }



        private void btnTimerThread_Click(object sender, EventArgs e)
        {
            string testString = "hola";


            //init using ints
            //_ThreadTimer = new System.Threading.Timer(new TimerCallback(ExecuteTimer), 
            //    testString, 
            //    1000,
            //    2000);

            //init using timespans
            //_ThreadTimer = new System.Threading.Timer(new TimerCallback(ExecuteTimer),
            //    testString,
            //    (int)TimeSpan.FromSeconds(1).TotalMilliseconds,
            //    (int)TimeSpan.FromSeconds(2).TotalMilliseconds);

            //init, wait 10 seconds, execute and disable
            _ThreadTimer = new System.Threading.Timer(new TimerCallback(ExecuteTimer),
                testString,
                (int)TimeSpan.FromSeconds(10).TotalMilliseconds,
                Timeout.Infinite);

        }


        private void ExecuteTimer(object state)
        {
            this.txtResult.Text = state.ToString() + "-" + DateTime.Now.ToString();
        }



        private void btnParse_Click(object sender, EventArgs e)
        {

            string dateStr = "12/28/2005";

            DateTime myDate = DateTime.MinValue;
                
            DateTime.TryParse(dateStr, 
                System.Globalization.CultureInfo.InvariantCulture, 
                System.Globalization.DateTimeStyles.None, out myDate);


            if(myDate == DateTime.MinValue)
            {
                MessageBox.Show("No es un formato de fecha válido");
            }
            else
            {
                MessageBox.Show(myDate.ToString());
            }
        }


    }
}
