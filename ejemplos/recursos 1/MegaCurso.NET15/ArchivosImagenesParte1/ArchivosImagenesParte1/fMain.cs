using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ArchivosImagenesParte1
{
    public partial class fMain : Form
    {
        private const string fileName = "test.txt";

        public fMain()
        {
            InitializeComponent();
        }


        private void ReadAllTestFile()
        {
            try
            {
                txtResult.Clear();
                string contents = File.ReadAllText(fileName);

                string[] lines = contents.Split(new string[] { System.Environment.NewLine },
                    StringSplitOptions.RemoveEmptyEntries);


                foreach (string line in lines)
                {
                    //string[] values = line.Split(new char[] { ';' } , StringSplitOptions.RemoveEmptyEntries);
                    string[] values = line.Split(';');

                    string name = values[0];
                    string phone = values[1];
                    string postalCode = values[2];

                    txtResult.AppendText(string.Format(
                        "Nombre:{0}, Telefono:{1}, Código postal:{2}",
                        name, phone, postalCode)
                    );

                    txtResult.AppendText(System.Environment.NewLine);

                }
            }
            catch(FileNotFoundException)
            {
                string err = string.Format("No se encuentra el archivo {0}", fileName);
                MessageBox.Show(err);
                return;
            }
            catch (Exception ex)
            {
                string err = string.Format("Error al leer el archivo {0}", fileName);
                err += Environment.NewLine;
                err += ex.Message;

                MessageBox.Show(err);
                return;
            }
            //finally
            //{
            //    MessageBox.Show("Sale siempre haya error o no");
            //}

            MessageBox.Show("Lectura de todo el archivo completa");
        }


        private void ReadTestFile()
        {
            txtResult.Clear();
            string[] lines = File.ReadAllLines(fileName);

            foreach(string line in lines)
            {
                //string[] values = line.Split(new char[] { ';' } , StringSplitOptions.RemoveEmptyEntries);
                string[] values = line.Split(';');

                string name = values[0];
                string phone = values[1];
                string postalCode = values[2];

                txtResult.AppendText(string.Format(
                    "Nombre:{0}, Telefono:{1}, Código postal:{2}",
                    name, phone, postalCode)
                );

                txtResult.AppendText(System.Environment.NewLine);

            }

            MessageBox.Show("Lectura completa");

        }






        private void WriteTestFile()
        {
            txtResult.Clear();

            StringBuilder contents = new StringBuilder();

            Random r = new Random();
            for (int i = 1; i<= 100; i++)
            {
                string line = "valuéñ" + i;

                string phone = r.Next().ToString();
                line += ";" + phone;

                string postalCode =  r.Next().ToString();
                line += ";" + postalCode;


                //line += "\r\n";
                line += System.Environment.NewLine;


                contents.Append(line);
            }


            File.WriteAllText(fileName, contents.ToString());


            MessageBox.Show("Completado");
        }


        private void ReadFilesAndFolders()
        {
            txtResult.Clear();

            //string[] folders = Directory.GetDirectories("c:\\docs\\MegaCurso.NET15\\ArchivosImagenesParte1\\ArchivosImagenesParte1");
            string[] folders = Directory.GetDirectories(@"c:\docs\MegaCurso.NET15\ArchivosImagenesParte1\ArchivosImagenesParte1\");
            foreach(string folder in folders)
            {
                txtResult.AppendText(folder);
                txtResult.AppendText(Environment.NewLine);
            }

            string[] files = Directory.GetFiles(@"c:\docs\MegaCurso.NET15\ArchivosImagenesParte1\ArchivosImagenesParte1\");
            foreach (string file in files)
            {
                txtResult.AppendText(file);
                txtResult.AppendText(Environment.NewLine);
            }

        }


        private void GetFileInfo()
        {
            txtResult.Clear();

            FileInfo flInfo = new FileInfo(fileName);

            string contents = "";
            contents += string.Format("Tamaño : {0} ", flInfo.Length) + Environment.NewLine;
            contents += string.Format("Fecha creación : {0} " , flInfo.CreationTime) + Environment.NewLine;
            contents += string.Format("Fecha últ escrit : {0} ", flInfo.LastWriteTime) + Environment.NewLine;


            txtResult.Text = contents;
        }


        private void DeleteFile()
        {
            File.Delete(fileName);
            MessageBox.Show("Archivo eliminado");
        }


        private void btnRead_Click(object sender, EventArgs e)
        {
            ReadTestFile();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            WriteTestFile();
        }

        private void btnReadAllFile_Click(object sender, EventArgs e)
        {
            ReadAllTestFile();
        }

        private void btnReadFolders_Click(object sender, EventArgs e)
        {
            ReadFilesAndFolders();
        }

        private void btnGetFileInfo_Click(object sender, EventArgs e)
        {
            GetFileInfo();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteFile();
        }

    }
}
