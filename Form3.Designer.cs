using System;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form3 : Form
    {
        private Label labelRate2;
        private Button buttonProceed;
        private Button buttonCalculate;
        private TextBox textBoxFinalAmount;
        private Label labelFinalAmount;
        private TextBox textBoxDiscount;
        private Label labelDiscount;
        private TextBox textBoxTotal;
        private Label labelTotal;
        private Button buttonDiscard;
        private ListBox listBoxCart;
        private Button button4;
        private Label labelRate4;
        private PictureBox pictureBox4;
        private Button button3;
        private Label labelRate3;
        private PictureBox pictureBox3;
        private Button button2;
        private PictureBox pictureBox2;
        private Button button1;
        private Label labelRate1;
        private PictureBox pictureBox1;

        

        private void Form3_Load(object sender, EventArgs e)
        {
            // Initialize any additional components or logic when the form loads
            // For example, setting initial values for TextBoxes or other controls
        }

        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelRate1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelRate2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelRate3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.labelRate4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.listBoxCart = new System.Windows.Forms.ListBox();
            this.buttonDiscard = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.textBoxDiscount = new System.Windows.Forms.TextBox();
            this.labelFinalAmount = new System.Windows.Forms.Label();
            this.textBoxFinalAmount = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonProceed = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp3.Properties.Resources.para;
            this.pictureBox1.Location = new System.Drawing.Point(12, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelRate1
            // 
            this.labelRate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.labelRate1.Location = new System.Drawing.Point(12, 135);
            this.labelRate1.Name = "labelRate1";
            this.labelRate1.Size = new System.Drawing.Size(161, 23);
            this.labelRate1.TabIndex = 1;
            this.labelRate1.Text = "Rate: $100";
            this.labelRate1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add to Cart";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp3.Properties.Resources.treking;
            this.pictureBox2.Location = new System.Drawing.Point(212, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(161, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // labelRate2
            // 
            this.labelRate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.labelRate2.Location = new System.Drawing.Point(212, 135);
            this.labelRate2.Name = "labelRate2";
            this.labelRate2.Size = new System.Drawing.Size(161, 23);
            this.labelRate2.TabIndex = 4;
            this.labelRate2.Text = "Rate: $200";
            this.labelRate2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(239, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 37);
            this.button2.TabIndex = 5;
            this.button2.Text = "Add to Cart";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp3.Properties.Resources.camping;
            this.pictureBox3.Location = new System.Drawing.Point(417, 32);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(161, 100);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // labelRate3
            // 
            this.labelRate3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.labelRate3.Location = new System.Drawing.Point(417, 135);
            this.labelRate3.Name = "labelRate3";
            this.labelRate3.Size = new System.Drawing.Size(161, 23);
            this.labelRate3.TabIndex = 7;
            this.labelRate3.Text = "Rate: $150";
            this.labelRate3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(434, 161);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 37);
            this.button3.TabIndex = 8;
            this.button3.Text = "Add to Cart";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp3.Properties.Resources.rafting;
            this.pictureBox4.Location = new System.Drawing.Point(639, 32);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(161, 100);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // labelRate4
            // 
            this.labelRate4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.labelRate4.Location = new System.Drawing.Point(639, 135);
            this.labelRate4.Name = "labelRate4";
            this.labelRate4.Size = new System.Drawing.Size(161, 23);
            this.labelRate4.TabIndex = 10;
            this.labelRate4.Text = "Rate: $250";
            this.labelRate4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(656, 161);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 37);
            this.button4.TabIndex = 11;
            this.button4.Text = "Add to Cart";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // listBoxCart
            // 
            this.listBoxCart.FormattingEnabled = true;
            this.listBoxCart.Location = new System.Drawing.Point(36, 221);
            this.listBoxCart.Name = "listBoxCart";
            this.listBoxCart.Size = new System.Drawing.Size(200, 95);
            this.listBoxCart.TabIndex = 12;
            // 
            // buttonDiscard
            // 
            this.buttonDiscard.Location = new System.Drawing.Point(286, 243);
            this.buttonDiscard.Name = "buttonDiscard";
            this.buttonDiscard.Size = new System.Drawing.Size(161, 37);
            this.buttonDiscard.TabIndex = 13;
            this.buttonDiscard.Text = "Discard Cart";
            this.buttonDiscard.UseVisualStyleBackColor = true;
            // 
            // labelTotal
            // 
            this.labelTotal.Location = new System.Drawing.Point(12, 330);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(161, 23);
            this.labelTotal.TabIndex = 14;
            this.labelTotal.Text = "Total:";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(179, 327);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotal.TabIndex = 15;
            // 
            // labelDiscount
            // 
            this.labelDiscount.Location = new System.Drawing.Point(12, 358);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(161, 23);
            this.labelDiscount.TabIndex = 16;
            this.labelDiscount.Text = "Discount:";
            // 
            // textBoxDiscount
            // 
            this.textBoxDiscount.Location = new System.Drawing.Point(179, 355);
            this.textBoxDiscount.Name = "textBoxDiscount";
            this.textBoxDiscount.Size = new System.Drawing.Size(100, 20);
            this.textBoxDiscount.TabIndex = 17;
            // 
            // labelFinalAmount
            // 
            this.labelFinalAmount.Location = new System.Drawing.Point(12, 387);
            this.labelFinalAmount.Name = "labelFinalAmount";
            this.labelFinalAmount.Size = new System.Drawing.Size(161, 23);
            this.labelFinalAmount.TabIndex = 18;
            this.labelFinalAmount.Text = "Final Amount:";
            // 
            // textBoxFinalAmount
            // 
            this.textBoxFinalAmount.Location = new System.Drawing.Point(179, 384);
            this.textBoxFinalAmount.Name = "textBoxFinalAmount";
            this.textBoxFinalAmount.Size = new System.Drawing.Size(100, 20);
            this.textBoxFinalAmount.TabIndex = 19;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(299, 380);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(117, 37);
            this.buttonCalculate.TabIndex = 20;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            // 
            // buttonProceed
            // 
            this.buttonProceed.Location = new System.Drawing.Point(480, 380);
            this.buttonProceed.Name = "buttonProceed";
            this.buttonProceed.Size = new System.Drawing.Size(161, 37);
            this.buttonProceed.TabIndex = 21;
            this.buttonProceed.Text = "Proceed to Checkout";
            this.buttonProceed.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonProceed);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxFinalAmount);
            this.Controls.Add(this.labelFinalAmount);
            this.Controls.Add(this.textBoxDiscount);
            this.Controls.Add(this.labelDiscount);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.buttonDiscard);
            this.Controls.Add(this.listBoxCart);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.labelRate4);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.labelRate3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelRate2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelRate1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form3";
            this.Text = "Shopping Cart";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
