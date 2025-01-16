namespace CALC1
{
    partial class Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            textBox_Result = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button20 = new Button();
            button11 = new Button();
            SuspendLayout();
            // 
            // textBox_Result
            // 
            textBox_Result.BackColor = Color.FromArgb(224, 224, 224);
            textBox_Result.Font = new Font("Copperplate Gothic Bold", 26F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Result.Location = new Point(15, 41);
            textBox_Result.Multiline = true;
            textBox_Result.Name = "textBox_Result";
            textBox_Result.Size = new Size(454, 156);
            textBox_Result.TabIndex = 0;
            textBox_Result.Text = "0";
            textBox_Result.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Lucida Console", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(15, 216);
            button1.Name = "button1";
            button1.Size = new Size(86, 86);
            button1.TabIndex = 1;
            button1.Text = "7";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button_click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Lucida Console", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(107, 216);
            button2.Name = "button2";
            button2.Size = new Size(86, 86);
            button2.TabIndex = 2;
            button2.Text = "8";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button_click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Lucida Console", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ControlText;
            button3.Location = new Point(199, 216);
            button3.Name = "button3";
            button3.Size = new Size(86, 86);
            button3.TabIndex = 3;
            button3.Text = "9";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button_click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Lucida Console", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(291, 216);
            button4.Name = "button4";
            button4.Size = new Size(86, 86);
            button4.TabIndex = 4;
            button4.Text = "/";
            button4.UseVisualStyleBackColor = false;
            button4.Click += operation_click;
            // 
            // button5
            // 
            button5.BackColor = Color.Tomato;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Lucida Console", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(383, 216);
            button5.Name = "button5";
            button5.Size = new Size(86, 86);
            button5.TabIndex = 5;
            button5.Text = "C";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button_clear_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Tomato;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Lucida Console", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Location = new Point(383, 308);
            button6.Name = "button6";
            button6.Size = new Size(86, 86);
            button6.TabIndex = 10;
            button6.Text = "←";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button_backspace_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.FlatStyle = FlatStyle.Popup;
            button7.Font = new Font("Lucida Console", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(291, 308);
            button7.Name = "button7";
            button7.Size = new Size(86, 86);
            button7.TabIndex = 9;
            button7.Text = "*";
            button7.UseVisualStyleBackColor = false;
            button7.Click += operation_click;
            // 
            // button8
            // 
            button8.BackColor = Color.White;
            button8.FlatStyle = FlatStyle.Popup;
            button8.Font = new Font("Lucida Console", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.ForeColor = SystemColors.ControlText;
            button8.Location = new Point(199, 308);
            button8.Name = "button8";
            button8.Size = new Size(86, 86);
            button8.TabIndex = 8;
            button8.Text = "6";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button_click;
            // 
            // button9
            // 
            button9.BackColor = Color.White;
            button9.FlatStyle = FlatStyle.Popup;
            button9.Font = new Font("Lucida Console", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.ForeColor = SystemColors.ControlText;
            button9.Location = new Point(107, 308);
            button9.Name = "button9";
            button9.Size = new Size(86, 86);
            button9.TabIndex = 7;
            button9.Text = "5";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button_click;
            // 
            // button10
            // 
            button10.BackColor = Color.White;
            button10.FlatStyle = FlatStyle.Popup;
            button10.Font = new Font("Lucida Console", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button10.ForeColor = SystemColors.ControlText;
            button10.Location = new Point(15, 308);
            button10.Name = "button10";
            button10.Size = new Size(86, 86);
            button10.TabIndex = 6;
            button10.Text = "4";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button_click;
            // 
            // button12
            // 
            button12.BackColor = Color.White;
            button12.FlatStyle = FlatStyle.Popup;
            button12.Font = new Font("Lucida Console", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button12.Location = new Point(291, 400);
            button12.Name = "button12";
            button12.Size = new Size(86, 86);
            button12.TabIndex = 14;
            button12.Text = "-";
            button12.UseVisualStyleBackColor = false;
            button12.Click += operation_click;
            // 
            // button13
            // 
            button13.BackColor = Color.White;
            button13.FlatStyle = FlatStyle.Popup;
            button13.Font = new Font("Lucida Console", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button13.ForeColor = SystemColors.ControlText;
            button13.Location = new Point(199, 400);
            button13.Name = "button13";
            button13.RightToLeft = RightToLeft.No;
            button13.Size = new Size(86, 86);
            button13.TabIndex = 13;
            button13.Text = "3";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button_click;
            // 
            // button14
            // 
            button14.BackColor = Color.White;
            button14.FlatStyle = FlatStyle.Popup;
            button14.Font = new Font("Lucida Console", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button14.ForeColor = SystemColors.ControlText;
            button14.Location = new Point(107, 400);
            button14.Name = "button14";
            button14.Size = new Size(86, 86);
            button14.TabIndex = 12;
            button14.Text = "2";
            button14.UseVisualStyleBackColor = false;
            button14.Click += button_click;
            // 
            // button15
            // 
            button15.BackColor = Color.White;
            button15.FlatStyle = FlatStyle.Popup;
            button15.Font = new Font("Lucida Console", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button15.ForeColor = SystemColors.ControlText;
            button15.Location = new Point(15, 400);
            button15.Name = "button15";
            button15.Size = new Size(86, 86);
            button15.TabIndex = 11;
            button15.Text = "1";
            button15.UseVisualStyleBackColor = false;
            button15.Click += button_click;
            // 
            // button16
            // 
            button16.BackColor = Color.White;
            button16.FlatStyle = FlatStyle.Popup;
            button16.Font = new Font("Lucida Console", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button16.Location = new Point(383, 400);
            button16.Name = "button16";
            button16.Size = new Size(86, 178);
            button16.TabIndex = 20;
            button16.Text = "=";
            button16.UseVisualStyleBackColor = false;
            button16.Click += button_equal_Click;
            // 
            // button17
            // 
            button17.BackColor = Color.White;
            button17.FlatStyle = FlatStyle.Popup;
            button17.Font = new Font("Lucida Console", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button17.Location = new Point(291, 492);
            button17.Name = "button17";
            button17.Size = new Size(86, 86);
            button17.TabIndex = 19;
            button17.Text = "+";
            button17.UseVisualStyleBackColor = false;
            button17.Click += operation_click;
            // 
            // button18
            // 
            button18.BackColor = Color.White;
            button18.FlatStyle = FlatStyle.Popup;
            button18.Font = new Font("Lucida Console", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button18.ForeColor = SystemColors.ControlText;
            button18.Location = new Point(107, 492);
            button18.Name = "button18";
            button18.Size = new Size(86, 86);
            button18.TabIndex = 18;
            button18.Text = ".";
            button18.UseVisualStyleBackColor = false;
            button18.Click += button_click;
            // 
            // button20
            // 
            button20.BackColor = Color.White;
            button20.FlatStyle = FlatStyle.Popup;
            button20.Font = new Font("Lucida Console", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button20.ForeColor = SystemColors.ControlText;
            button20.Location = new Point(15, 492);
            button20.Name = "button20";
            button20.Size = new Size(86, 86);
            button20.TabIndex = 16;
            button20.Text = "0";
            button20.UseVisualStyleBackColor = false;
            button20.Click += button_click;
            // 
            // button11
            // 
            button11.BackColor = Color.White;
            button11.FlatStyle = FlatStyle.Popup;
            button11.Font = new Font("Lucida Console", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button11.Location = new Point(199, 492);
            button11.Name = "button11";
            button11.Size = new Size(86, 86);
            button11.TabIndex = 21;
            button11.Text = "+/-";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button_neg_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(486, 605);
            Controls.Add(button11);
            Controls.Add(button16);
            Controls.Add(button17);
            Controls.Add(button18);
            Controls.Add(button20);
            Controls.Add(button12);
            Controls.Add(button13);
            Controls.Add(button14);
            Controls.Add(button15);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox_Result);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Calculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Result;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button20;
        private Button button11;
    }
}
