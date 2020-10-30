using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;

using System.Threading;
using System.Threading.Tasks;


using System.Windows.Forms;



namespace MultiThreading
{
    public partial class fMain : Form
    {

        private SynchronizationContext _syncContext;

        public fMain()
        {
            InitializeComponent();

            //set the current context to the UI context
            _syncContext = SynchronizationContext.Current;

            //don't use this!
            //Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void btnTestCounter_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 50000; i++)
            {
                this.lblCounter.Text = string.Format("Contador:{0}", i);
                Application.DoEvents();
            }
        }



        private bool _runThread;
        private Thread _CountThread;

        private void btnTestThread_Click(object sender, EventArgs e)
        {
            btnTestThread.Enabled = false;
            btnStopThread.Enabled = true;

            _CountThread = new Thread(new ThreadStart(this.CountWithThread));
            _CountThread.Start();

            //Thread thWithParam = new Thread(new ParameterizedThreadStart(this.CountWithThreadParam));
            //thWithParam.Start("hola");
        }


        private void CountWithThreadParam(object obj)
        {

        }



        private void btnStopThread_Click(object sender, EventArgs e)
        {
            //_runThread = false;

            //don't do this
            //_CountThread.Abort();
        }


        private delegate void UpdateUiThreadDelegate(int value);
        private void CountWithThread()
        {
            _runThread = true;
            UpdateUiThreadDelegate dlg = new UpdateUiThreadDelegate(this.UpdateUiThread);
            for (int i = 0; i < 50000; i++)
            {
                if (!_runThread)
                    return;

                this.Invoke(dlg, i);
            }

        }


        private void UpdateUiThread(int value)
        {
            this.lblThread.Text = string.Format("Contador:{0}", value);
        }



        private DateTime _previousTime;

        private async void btnTestAsync_Click(object sender, EventArgs e)
        {
            btnTestAsync.Enabled = false;

            _previousTime = DateTime.Now;
            int counter = 0;

            //System.IO.FileStream fs;
            //await fs.WriteAsync()

            await Task.Run(() =>
            {

                for (int i = 0; i < 500000; i++)
                {
                    this.UpdateUiAsync(i);
                    counter = i;
                }

            });

            this.lblCounterAsync.Text = string.Format("Contador:{0}", counter);
            this.btnTestAsync.Enabled = true;
        }


        private void UpdateUiAsync(int counter)
        {
            DateTime now = DateTime.Now;

            if( (now - _previousTime).Milliseconds <= 50)
            {
                return;
            }

            _previousTime = now;

            _syncContext.Post(new SendOrPostCallback(value =>
            {

                this.lblCounterAsync.Text = string.Format("Contador:{0}", counter);

            }), counter);

            
        }



        private bool _runFiles;

        private async void btnFileAsync_Click(object sender, EventArgs e)
        {
            btnTestAsync.Enabled = false;

            _runFiles = true;
            _previousTime = DateTime.Now;

            //System.IO.FileStream fs;
            //await fs.WriteAsync()

            await Task.Run(() =>
            {
                this.ReadFiles(@"d:\");

            });

            this.btnTestAsync.Enabled = true;

        }



        private void ReadFiles(string path)
        {
            if (path.Length > 250)
                return;

            string[] files = Directory.GetFiles(path);
            foreach(string file in files)
            {
                if (!_runFiles)
                    return;

                this.UpdateUiFileAsync(file);
            }

            string[] folders = Directory.GetDirectories(path);
            foreach (string folder in folders)
            {
                if (!_runFiles)
                    return;

                this.UpdateUiFileAsync(folder);
                this.ReadFiles(folder);
            }

        }



        private void UpdateUiFileAsync(string name)
        {
            DateTime now = DateTime.Now;

            if ((now - _previousTime).Milliseconds <= 50)
            {
                return;
            }

            _previousTime = now;

            _syncContext.Post(new SendOrPostCallback(value =>
            {
                this.lblFileAsync.Text = string.Format("Contador:{0}", value);

            }), name);


        }

        private void btnStopFileAsync_Click(object sender, EventArgs e)
        {
            _runFiles = false;
        }


    }
}
