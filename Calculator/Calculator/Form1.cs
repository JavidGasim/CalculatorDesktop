namespace Calculator
{
    public partial class Form1 : Form
    {
        double FirstNumber;
        string Operation;
        public Form1()
        {
            InitializeComponent();
        }
        private void bir_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text = "1";
            }
            else
            {
                label1.Text = label1.Text + "1";
            }
        }

        private void iki_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text = "2";
            }
            else
            {
                label1.Text = label1.Text + "2";
            }
        }

        private void uc_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text = "3";
            }
            else
            {
                label1.Text = label1.Text + "3";
            }
        }

        private void dord_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text = "4";
            }
            else
            {
                label1.Text = label1.Text + "4";
            }
        }

        private void bes_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text = "5";
            }
            else
            {
                label1.Text = label1.Text + "5";
            }
        }

        private void alti_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text = "6";
            }
            else
            {
                label1.Text = label1.Text + "6";
            }
        }

        private void yeddi_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text = "7";
            }
            else
            {
                label1.Text = label1.Text + "7";
            }
        }

        private void sekkiz_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text = "8";
            }
            else
            {
                label1.Text = label1.Text + "8";
            }
        }

        private void doqquz_Click(object sender, EventArgs e)
        {
            if (label1.Text == "" && label1.Text != null)
            {
                label1.Text = "9";
            }
            else
            {
                label1.Text = label1.Text + "9";
            }
        }

        private void sifir_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "0";
        }

        private void toplama_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(label1.Text);
            label1.Text = "0";
            Operation = "+";
        }

        private void cixma_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(label1.Text);
            label1.Text = "0";
            Operation = "-";

        }

        private void vurma_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(label1.Text);
            label1.Text = "0";
            Operation = "*";
        }

        private void bolme_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(label1.Text);
            label1.Text = "0";
            Operation = "/";
        }

        private void clear_Click_1(object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        private void faiz_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(label1.Text);
            label1.Text = "0";
            Operation = "%";
        }

        private void noqte_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + ".";
        }

        private void beraber_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(label1.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                label1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                label1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                label1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    label1.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    label1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
            if (Operation == "%")
            {
                Result = (FirstNumber * SecondNumber) / 100;
                label1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
        }
    }
}