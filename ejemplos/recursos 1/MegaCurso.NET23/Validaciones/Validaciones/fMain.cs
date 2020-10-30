using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.RegularExpressions;


namespace Validaciones
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
            ValidateInput();
        }

        private void txtInput_KeyUp(object sender, KeyEventArgs e)
        {
            ValidateInput();
        }



        private void ValidateInput()
        {
            //if empty, is invalid
            //bool isValid = !string.IsNullOrEmpty(this.txtInput.Text);

            //allow uppercase and lowercase
            //bool isValid = Regex.IsMatch(this.txtInput.Text, "[A-Za-z]");

            //allow only numbers, any number length, use match object
            //Match m = Regex.Match(this.txtInput.Text, "[0-9]+");

            //allow only numbers, any number length, start and end of string
            //bool isValid = Regex.IsMatch(this.txtInput.Text, "^[0-9]+$");

            //allow specific number length
            //bool isValid = Regex.IsMatch(this.txtInput.Text, "^[0-9]{1,5}$");
            //isValid = Regex.IsMatch(this.txtInput.Text, "^[0-9]{4}$");

            //allow one zeta to 5
            //bool isValid = Regex.IsMatch(this.txtInput.Text, "^z{1,5}$");


            //allow alphabet, numbers and underscore _   [A-Za-z0-9_]
            //bool isValid = Regex.IsMatch(this.txtInput.Text, @"^\w+$");

            //allow only digits, any length
            //bool isValid = Regex.IsMatch(this.txtInput.Text, @"^\d+$");

            //allow any number of blanks
            //bool isValid = Regex.IsMatch(this.txtInput.Text, @"^\s$");

            //use of OR |
            bool isValid = Regex.IsMatch(this.txtInput.Text, @"^([A-C]|[FG])$");


            this.txtInput.BackColor = isValid ? Color.PaleGreen : Color.MistyRose;

        }

        private void txtCifDni_KeyUp(object sender, KeyEventArgs e)
        {

            string pattern = @"^[A-Z]?\d{8}[A-Z]?$";

            bool isValid = Regex.IsMatch(txtCifDni.Text, pattern);
            this.txtCifDni.BackColor = isValid ? Color.PaleGreen : Color.MistyRose;

        }



        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            int score = 0;

            if (txtPassword.TextLength > 4)
                score++;

            if (Regex.IsMatch(txtPassword.Text, "[A-Z]+"))
                score++;

            if (Regex.IsMatch(txtPassword.Text, @"\d+"))
                score++;

            Color backColor = Color.MistyRose;

            if (score == 2)
                backColor = Color.Yellow;
            else if (score == 3)
                backColor = Color.Green;

            this.txtPassword.BackColor = backColor;
        }



        private void btnExtractGroup_Click(object sender, EventArgs e)
        {
            string pattern = @"^(?<NUMEROS>\d{8})(?<LETRA>[A-Z]{1})$";

            string sample = "12345678A";

            Match match = Regex.Match(sample, pattern);

            Group numberGroup = match.Groups["NUMEROS"];
            Group letterGroup = match.Groups["LETRA"];

        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            string pattern = "[A-Z]+";

            string input = "amznMANS324";

            string output = Regex.Replace(input, pattern, "ó");

        }




        private void Test(string inputParam)
        {
            ValidateT.NotNullEmpty(inputParam, "El parámetro input no puede ser nulo");


        }


    }
}
