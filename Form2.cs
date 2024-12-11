using System;
using System.Windows.Forms;
using WindowsFormsApp3; // Ensure your namespace is correct here

namespace Login
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            // Button click event to navigate to Form4
            button5.Click += Button5_Click;
        }

        private void Button5_Click(object sender, EventArgs e)
        {

            Form3 form3 = new Form3();
            form3.Show();

            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // You can handle picture box click event if needed
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Any additional load logic can go here
        }
    }
}
