using WindowsFormsApp1;

namespace pract11_2_Lezhen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelA2.Visible = false;
            labelB2.Visible = false;
            label6.Visible = false;
            textBoxA2.Visible = false;
            textBoxB2.Visible = false;
            textBoxNUM2.Visible = false;                    
        }

        private void textBoxA1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxA2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxB1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxB2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNUM1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNUM2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAdd.Checked == true)
            {
                labelA2.Visible = true;
                labelB2.Visible = true;
                label6.Visible = true;
                textBoxA2.Visible = true;
                textBoxB2.Visible = true;
                textBoxNUM2.Visible = true;
            }
            else
            {
                labelA2.Visible = false;
                labelB2.Visible = false;
                label6.Visible = false;
                textBoxA2.Visible = false;
                textBoxB2.Visible = false;
                textBoxNUM2.Visible = false;
            }
        }

        private void radioButtonSubtract_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSubtract.Checked == true)
            {
                labelA2.Visible = true;
                labelB2.Visible = true;
                label6.Visible = true;
                textBoxA2.Visible = true;
                textBoxB2.Visible = true;
                textBoxNUM2.Visible = true;
            }
            else
            {
                labelA2.Visible = false;
                labelB2.Visible = false;
                label6.Visible = false;
                textBoxA2.Visible = false;
                textBoxB2.Visible = false;
                textBoxNUM2.Visible = false;
            }
        }

        private void radioButtonMultiply_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMultiply.Checked == true)
            {
                labelA2.Visible = true;
                labelB2.Visible = true;
                label6.Visible = true;
                textBoxA2.Visible = true;
                textBoxB2.Visible = true;
                textBoxNUM2.Visible = true;
            }
            else
            {
                labelA2.Visible = false;
                labelB2.Visible = false;
                label6.Visible = false;
                textBoxA2.Visible = false;
                textBoxB2.Visible = false;
                textBoxNUM2.Visible = false;
            }
        }

        private void radioButtonDivide_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDivide.Checked == true)
            {
                labelA2.Visible = true;
                labelB2.Visible = true;
                label6.Visible = true;
                textBoxA2.Visible = true;
                textBoxB2.Visible = true;
                textBoxNUM2.Visible = true;
            }
            else
            {
                labelA2.Visible = false;
                labelB2.Visible = false;
                label6.Visible = false;
                textBoxA2.Visible = false;
                textBoxB2.Visible = false;
                textBoxNUM2.Visible = false;
            }
        }

        private void radioButtonConjugate_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButtonPower_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonSquareRoot_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonModulus_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButtonArgument_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonSecondKompNum_CheckedChanged(object sender, EventArgs e)
        {

            

        }

        private void radioButtonToAlgebraic_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonToTrigonometric_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonToExponential_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            try
            {
                ComplexNumber c1 = new ComplexNumber(Convert.ToDouble(textBoxA1.Text), Convert.ToDouble(textBoxB1.Text));
                ComplexNumber c2 = new ComplexNumber(Convert.ToDouble(textBoxA2.Text), Convert.ToDouble(textBoxB2.Text));
                if (radioButtonAdd.Checked)
                {
                    if (radioButtonToAlgebraic.Checked)
                    {
                        MessageBox.Show(c1.Add(c2).ToAlgebraic());
                        textBoxNUM1.Text = c1.ToAlgebraic();
                        textBoxNUM2.Text = c2.ToAlgebraic();
                    }
                    if (radioButtonToTrigonometric.Checked)
                    {
                        MessageBox.Show(c1.Add(c2).ToTrigonometric());
                        textBoxNUM1.Text = c1.ToTrigonometric();
                        textBoxNUM2.Text = c2.ToTrigonometric();
                    }
                    if (radioButtonToExponential.Checked)
                    {
                        MessageBox.Show(c1.Add(c2).ToExponential());
                        textBoxNUM1.Text = c1.ToExponential();
                        textBoxNUM2.Text = c2.ToExponential();
                    }
                }
                if (radioButtonSubtract.Checked)
                {                    
                    if (radioButtonToAlgebraic.Checked)
                    {
                        MessageBox.Show(c1.Subtract(c2).ToAlgebraic());
                        textBoxNUM1.Text = c1.ToAlgebraic();
                        textBoxNUM2.Text = c2.ToAlgebraic();
                    }
                    if (radioButtonToTrigonometric.Checked)
                    {
                        MessageBox.Show(c1.Subtract(c2).ToTrigonometric());
                        textBoxNUM1.Text = c1.ToTrigonometric();
                        textBoxNUM2.Text = c2.ToTrigonometric();
                    }
                    if (radioButtonToExponential.Checked)
                    {
                        MessageBox.Show(c1.Subtract(c2).ToExponential());
                        textBoxNUM1.Text = c1.ToExponential();
                        textBoxNUM2.Text = c2.ToExponential();
                    }
                }
                if (radioButtonMultiply.Checked)
                {
                    if (radioButtonToAlgebraic.Checked)
                    {
                        MessageBox.Show(c1.Multiply(c2).ToAlgebraic());
                        textBoxNUM1.Text = c1.ToAlgebraic();
                        textBoxNUM2.Text = c2.ToAlgebraic();
                    }
                    if (radioButtonToTrigonometric.Checked)
                    {
                        MessageBox.Show(c1.Multiply(c2).ToTrigonometric());
                        textBoxNUM1.Text = c1.ToTrigonometric();
                        textBoxNUM2.Text = c2.ToTrigonometric();
                    }
                    if (radioButtonToExponential.Checked)
                    {
                        MessageBox.Show(c1.Multiply(c2).ToExponential());
                        textBoxNUM1.Text = c1.ToExponential();
                        textBoxNUM2.Text = c2.ToExponential();
                    }                    
                }
                if (radioButtonDivide.Checked)
                {
                    
                    if (radioButtonToAlgebraic.Checked)
                    {
                        MessageBox.Show(c1.Divide(c2).ToAlgebraic());
                        textBoxNUM1.Text = c1.ToAlgebraic();
                        textBoxNUM2.Text = c2.ToAlgebraic();
                    }
                    if (radioButtonToTrigonometric.Checked)
                    {
                        MessageBox.Show(c1.Divide(c2).ToTrigonometric());
                        textBoxNUM1.Text = c1.ToTrigonometric();
                        textBoxNUM2.Text = c2.ToTrigonometric();
                    }
                    if (radioButtonToExponential.Checked)
                    {
                        MessageBox.Show(c1.Divide(c2).ToExponential());
                        textBoxNUM1.Text = c1.ToExponential();
                        textBoxNUM2.Text = c2.ToExponential();
                    }
                }
            }            
            catch
            {
                try
                {
                    ComplexNumber c1 = new ComplexNumber(Convert.ToDouble(textBoxA1.Text), Convert.ToDouble(textBoxB1.Text));
                    
                    if (radioButtonConjugate.Checked)
                    {
                        textBoxA2.Text = ""; textBoxB2.Text = ""; textBoxNUM2.Text = "";
                        if (radioButtonToAlgebraic.Checked)
                        {
                            MessageBox.Show(c1.Conjugate().ToAlgebraic());
                            textBoxNUM1.Text = c1.ToAlgebraic();
                        }
                        if (radioButtonToTrigonometric.Checked)
                        {
                            MessageBox.Show(c1.Conjugate().ToTrigonometric());
                            textBoxNUM1.Text = c1.ToTrigonometric();
                        }
                        if (radioButtonToExponential.Checked)
                        {
                            MessageBox.Show(c1.Conjugate().ToExponential());
                            textBoxNUM1.Text = c1.ToExponential();
                        }
                    }
                    if (radioButtonPower.Checked)
                    {
                        textBoxA2.Text = ""; textBoxB2.Text = ""; textBoxNUM2.Text = "";
                        if (radioButtonToAlgebraic.Checked)
                        {
                            MessageBox.Show(c1.Power(2).ToAlgebraic());
                            textBoxNUM1.Text = c1.ToAlgebraic();
                        }
                        if (radioButtonToTrigonometric.Checked)
                        {
                            MessageBox.Show(c1.Power(2).ToTrigonometric());
                            textBoxNUM1.Text = c1.ToTrigonometric();
                        }
                        if (radioButtonToExponential.Checked)
                        {
                            MessageBox.Show(c1.Power(2).ToExponential());
                            textBoxNUM1.Text = c1.ToExponential();
                        }
                    }
                    if (radioButtonSquareRoot.Checked)
                    {
                        textBoxA2.Text = ""; textBoxB2.Text = ""; textBoxNUM2.Text = "";
                        if (radioButtonToAlgebraic.Checked)
                        {
                            MessageBox.Show(c1.SquareRoot().ToAlgebraic());
                            textBoxNUM1.Text = c1.ToAlgebraic();
                        }
                        if (radioButtonToTrigonometric.Checked)
                        {
                            MessageBox.Show(c1.SquareRoot().ToTrigonometric());
                            textBoxNUM1.Text = c1.ToTrigonometric();
                        }
                        if (radioButtonToExponential.Checked)
                        {
                            MessageBox.Show(c1.SquareRoot().ToExponential());
                            textBoxNUM1.Text = c1.ToExponential();
                        }
                    }
                    if (radioButtonModulus.Checked)
                    {
                        textBoxA2.Text = ""; textBoxB2.Text = ""; textBoxNUM2.Text = "";
                        MessageBox.Show(Convert.ToString(c1.Modulus()));
                        if (radioButtonToAlgebraic.Checked)
                        {
                            textBoxNUM1.Text = c1.ToAlgebraic();
                        }
                        if (radioButtonToTrigonometric.Checked)
                        {
                            textBoxNUM1.Text = c1.ToTrigonometric();
                        }
                        if (radioButtonToExponential.Checked)
                        {
                            textBoxNUM1.Text = c1.ToExponential();
                        }
                    }
                    if (radioButtonArgument.Checked)
                    {
                        textBoxA2.Text = ""; textBoxB2.Text = ""; textBoxNUM2.Text = "";
                        MessageBox.Show(Convert.ToString(c1.Argument()));
                        if (radioButtonToAlgebraic.Checked)
                        {                            
                            textBoxNUM1.Text = c1.ToAlgebraic();
                        }
                        if (radioButtonToTrigonometric.Checked)
                        {
                            textBoxNUM1.Text = c1.ToTrigonometric();
                        }
                        if (radioButtonToExponential.Checked)
                        {
                            textBoxNUM1.Text = c1.ToExponential();
                        }
                    }

                }
                catch { MessageBox.Show("Вы не ввели значения числа"); }
            }
            
        }

        private void labelA2_Click(object sender, EventArgs e)
        {

        }






        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
