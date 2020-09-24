namespace converter
{
    partial class information
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(information));
            this.output = new System.Windows.Forms.TextBox();
            this.hexa = new System.Windows.Forms.Button();
            this.deci = new System.Windows.Forms.Button();
            this.octal = new System.Windows.Forms.Button();
            this.binary = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.B = new System.Windows.Forms.Button();
            this.A = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.D = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.E = new System.Windows.Forms.Button();
            this.F = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.subtraction = new System.Windows.Forms.Button();
            this.addition = new System.Windows.Forms.Button();
            this.complement = new System.Windows.Forms.Button();
            this.complement2 = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.textBox_hexa = new System.Windows.Forms.TextBox();
            this.textBox_deci = new System.Windows.Forms.TextBox();
            this.textBox_binary = new System.Windows.Forms.TextBox();
            this.textBox_octal = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.info = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(219)))));
            this.output.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.ForeColor = System.Drawing.Color.Black;
            this.output.Location = new System.Drawing.Point(1, 6);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(319, 89);
            this.output.TabIndex = 0;
            this.output.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // hexa
            // 
            this.hexa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.hexa.Location = new System.Drawing.Point(1, 107);
            this.hexa.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.hexa.Name = "hexa";
            this.hexa.Size = new System.Drawing.Size(40, 23);
            this.hexa.TabIndex = 5;
            this.hexa.Text = "hexa";
            this.hexa.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.hexa.UseVisualStyleBackColor = false;
            this.hexa.Click += new System.EventHandler(this.hexa_Click);
            // 
            // deci
            // 
            this.deci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deci.Location = new System.Drawing.Point(1, 133);
            this.deci.Margin = new System.Windows.Forms.Padding(0);
            this.deci.Name = "deci";
            this.deci.Size = new System.Drawing.Size(40, 23);
            this.deci.TabIndex = 6;
            this.deci.Text = "deci";
            this.deci.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.deci.UseVisualStyleBackColor = false;
            this.deci.BackColorChanged += new System.EventHandler(this.deci_BackColorChanged);
            this.deci.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // octal
            // 
            this.octal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.octal.Location = new System.Drawing.Point(1, 165);
            this.octal.Margin = new System.Windows.Forms.Padding(0);
            this.octal.Name = "octal";
            this.octal.Size = new System.Drawing.Size(40, 23);
            this.octal.TabIndex = 8;
            this.octal.Text = "Octal";
            this.octal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.octal.UseVisualStyleBackColor = false;
            this.octal.Click += new System.EventHandler(this.button3_Click);
            // 
            // binary
            // 
            this.binary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.binary.Location = new System.Drawing.Point(1, 193);
            this.binary.Margin = new System.Windows.Forms.Padding(0);
            this.binary.Name = "binary";
            this.binary.Size = new System.Drawing.Size(40, 23);
            this.binary.TabIndex = 7;
            this.binary.Text = "binary";
            this.binary.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.binary.UseVisualStyleBackColor = false;
            this.binary.Click += new System.EventHandler(this.button4_Click);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.Color.Gray;
            this.two.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.two.Location = new System.Drawing.Point(139, 325);
            this.two.Name = "two";
            this.two.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.two.Size = new System.Drawing.Size(40, 29);
            this.two.TabIndex = 9;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.button5_Click);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.Color.Gray;
            this.three.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.three.Location = new System.Drawing.Point(185, 325);
            this.three.Name = "three";
            this.three.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.three.Size = new System.Drawing.Size(40, 29);
            this.three.TabIndex = 10;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.Color.Gray;
            this.one.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.one.Location = new System.Drawing.Point(93, 325);
            this.one.Name = "one";
            this.one.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.one.Size = new System.Drawing.Size(40, 29);
            this.one.TabIndex = 11;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // B
            // 
            this.B.BackColor = System.Drawing.Color.Gray;
            this.B.Enabled = false;
            this.B.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.B.Location = new System.Drawing.Point(47, 255);
            this.B.Name = "B";
            this.B.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.B.Size = new System.Drawing.Size(40, 29);
            this.B.TabIndex = 12;
            this.B.Text = "B";
            this.B.UseVisualStyleBackColor = false;
            this.B.Click += new System.EventHandler(this.B_Click);
            // 
            // A
            // 
            this.A.BackColor = System.Drawing.Color.Gray;
            this.A.Enabled = false;
            this.A.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.A.Location = new System.Drawing.Point(1, 255);
            this.A.Name = "A";
            this.A.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.A.Size = new System.Drawing.Size(40, 29);
            this.A.TabIndex = 13;
            this.A.Text = "A";
            this.A.UseVisualStyleBackColor = false;
            this.A.Click += new System.EventHandler(this.A_Click);
            // 
            // C
            // 
            this.C.BackColor = System.Drawing.Color.Gray;
            this.C.Enabled = false;
            this.C.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.C.Location = new System.Drawing.Point(1, 290);
            this.C.Name = "C";
            this.C.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.C.Size = new System.Drawing.Size(40, 29);
            this.C.TabIndex = 18;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = false;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // D
            // 
            this.D.BackColor = System.Drawing.Color.Gray;
            this.D.Enabled = false;
            this.D.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.D.Location = new System.Drawing.Point(47, 290);
            this.D.Name = "D";
            this.D.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.D.Size = new System.Drawing.Size(40, 29);
            this.D.TabIndex = 17;
            this.D.Text = "D";
            this.D.UseVisualStyleBackColor = false;
            this.D.Click += new System.EventHandler(this.D_Click);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.Color.Gray;
            this.four.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.four.Location = new System.Drawing.Point(93, 290);
            this.four.Name = "four";
            this.four.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.four.Size = new System.Drawing.Size(40, 29);
            this.four.TabIndex = 16;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.Color.Gray;
            this.six.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.six.Location = new System.Drawing.Point(185, 290);
            this.six.Name = "six";
            this.six.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.six.Size = new System.Drawing.Size(40, 29);
            this.six.TabIndex = 15;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.Color.Gray;
            this.five.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.five.Location = new System.Drawing.Point(139, 290);
            this.five.Name = "five";
            this.five.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.five.Size = new System.Drawing.Size(40, 29);
            this.five.TabIndex = 14;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.Color.Gray;
            this.zero.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.zero.Location = new System.Drawing.Point(139, 360);
            this.zero.Name = "zero";
            this.zero.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.zero.Size = new System.Drawing.Size(86, 29);
            this.zero.TabIndex = 24;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // E
            // 
            this.E.BackColor = System.Drawing.Color.Gray;
            this.E.Enabled = false;
            this.E.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.E.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.E.Location = new System.Drawing.Point(1, 325);
            this.E.Name = "E";
            this.E.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.E.Size = new System.Drawing.Size(40, 29);
            this.E.TabIndex = 23;
            this.E.Text = "E";
            this.E.UseVisualStyleBackColor = false;
            this.E.Click += new System.EventHandler(this.button20_Click);
            // 
            // F
            // 
            this.F.BackColor = System.Drawing.Color.Gray;
            this.F.Enabled = false;
            this.F.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.F.Location = new System.Drawing.Point(47, 325);
            this.F.Name = "F";
            this.F.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.F.Size = new System.Drawing.Size(40, 29);
            this.F.TabIndex = 22;
            this.F.Text = "F";
            this.F.UseVisualStyleBackColor = false;
            this.F.Click += new System.EventHandler(this.F_Click);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.Color.Gray;
            this.seven.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.seven.Location = new System.Drawing.Point(93, 255);
            this.seven.Name = "seven";
            this.seven.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.seven.Size = new System.Drawing.Size(40, 29);
            this.seven.TabIndex = 21;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.Color.Gray;
            this.nine.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nine.Location = new System.Drawing.Point(185, 255);
            this.nine.Name = "nine";
            this.nine.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nine.Size = new System.Drawing.Size(40, 29);
            this.nine.TabIndex = 20;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.Color.Gray;
            this.eight.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.eight.Location = new System.Drawing.Point(139, 255);
            this.eight.Name = "eight";
            this.eight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.eight.Size = new System.Drawing.Size(40, 29);
            this.eight.TabIndex = 19;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // subtraction
            // 
            this.subtraction.BackColor = System.Drawing.Color.SpringGreen;
            this.subtraction.Enabled = false;
            this.subtraction.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtraction.Location = new System.Drawing.Point(231, 220);
            this.subtraction.Name = "subtraction";
            this.subtraction.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.subtraction.Size = new System.Drawing.Size(89, 99);
            this.subtraction.TabIndex = 29;
            this.subtraction.Text = "Subtraction";
            this.subtraction.UseVisualStyleBackColor = false;
            this.subtraction.Click += new System.EventHandler(this.subtraction_Click);
            // 
            // addition
            // 
            this.addition.BackColor = System.Drawing.Color.SpringGreen;
            this.addition.Enabled = false;
            this.addition.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addition.Location = new System.Drawing.Point(231, 325);
            this.addition.Name = "addition";
            this.addition.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addition.Size = new System.Drawing.Size(89, 64);
            this.addition.TabIndex = 30;
            this.addition.Text = "Addition";
            this.addition.UseVisualStyleBackColor = false;
            this.addition.Click += new System.EventHandler(this.addition_Click);
            // 
            // complement
            // 
            this.complement.BackColor = System.Drawing.Color.SpringGreen;
            this.complement.Enabled = false;
            this.complement.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complement.Location = new System.Drawing.Point(47, 220);
            this.complement.Name = "complement";
            this.complement.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.complement.Size = new System.Drawing.Size(86, 29);
            this.complement.TabIndex = 31;
            this.complement.Text = "1\'s comp";
            this.complement.UseVisualStyleBackColor = false;
            this.complement.Click += new System.EventHandler(this.complement_Click);
            // 
            // complement2
            // 
            this.complement2.BackColor = System.Drawing.Color.SpringGreen;
            this.complement2.Enabled = false;
            this.complement2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complement2.Location = new System.Drawing.Point(139, 220);
            this.complement2.Name = "complement2";
            this.complement2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.complement2.Size = new System.Drawing.Size(86, 29);
            this.complement2.TabIndex = 32;
            this.complement2.Text = "2\'s comp";
            this.complement2.UseVisualStyleBackColor = false;
            this.complement2.Click += new System.EventHandler(this.button28_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Khaki;
            this.clear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(1, 220);
            this.clear.Name = "clear";
            this.clear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clear.Size = new System.Drawing.Size(40, 29);
            this.clear.TabIndex = 33;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.equal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal.Location = new System.Drawing.Point(1, 360);
            this.equal.Name = "equal";
            this.equal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.equal.Size = new System.Drawing.Size(132, 29);
            this.equal.TabIndex = 34;
            this.equal.Text = "= \' convert\'";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // textBox_hexa
            // 
            this.textBox_hexa.BackColor = System.Drawing.Color.White;
            this.textBox_hexa.Enabled = false;
            this.textBox_hexa.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_hexa.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox_hexa.Location = new System.Drawing.Point(48, 107);
            this.textBox_hexa.Name = "textBox_hexa";
            this.textBox_hexa.ReadOnly = true;
            this.textBox_hexa.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_hexa.Size = new System.Drawing.Size(272, 23);
            this.textBox_hexa.TabIndex = 35;
            this.textBox_hexa.TextChanged += new System.EventHandler(this.textBox_hexa_TextChanged);
            // 
            // textBox_deci
            // 
            this.textBox_deci.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_deci.Enabled = false;
            this.textBox_deci.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_deci.Location = new System.Drawing.Point(48, 136);
            this.textBox_deci.Name = "textBox_deci";
            this.textBox_deci.ReadOnly = true;
            this.textBox_deci.Size = new System.Drawing.Size(272, 23);
            this.textBox_deci.TabIndex = 36;
            // 
            // textBox_binary
            // 
            this.textBox_binary.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_binary.Enabled = false;
            this.textBox_binary.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_binary.Location = new System.Drawing.Point(48, 193);
            this.textBox_binary.Name = "textBox_binary";
            this.textBox_binary.ReadOnly = true;
            this.textBox_binary.Size = new System.Drawing.Size(272, 23);
            this.textBox_binary.TabIndex = 37;
            // 
            // textBox_octal
            // 
            this.textBox_octal.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_octal.Enabled = false;
            this.textBox_octal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_octal.Location = new System.Drawing.Point(48, 162);
            this.textBox_octal.Name = "textBox_octal";
            this.textBox_octal.ReadOnly = true;
            this.textBox_octal.Size = new System.Drawing.Size(272, 23);
            this.textBox_octal.TabIndex = 38;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.DimGray;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Traditional Arabic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.textBox5.Location = new System.Drawing.Point(6, 452);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(310, 25);
            this.textBox5.TabIndex = 39;
            this.textBox5.Text = "(C) Abdo Giprel 2019";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.Color.DimGray;
            this.info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.info.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.ForeColor = System.Drawing.Color.Linen;
            this.info.Location = new System.Drawing.Point(6, 395);
            this.info.Multiline = true;
            this.info.Name = "info";
            this.info.ReadOnly = true;
            this.info.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.info.Size = new System.Drawing.Size(310, 43);
            this.info.TabIndex = 40;
            this.info.Text = "To convert between system press the button of system";
            this.info.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.info.TextChanged += new System.EventHandler(this.info_TextChanged);
            // 
            // information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(322, 487);
            this.Controls.Add(this.info);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox_octal);
            this.Controls.Add(this.textBox_binary);
            this.Controls.Add(this.textBox_deci);
            this.Controls.Add(this.textBox_hexa);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.complement2);
            this.Controls.Add(this.complement);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.subtraction);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.E);
            this.Controls.Add(this.F);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.C);
            this.Controls.Add(this.D);
            this.Controls.Add(this.four);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.A);
            this.Controls.Add(this.B);
            this.Controls.Add(this.one);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.octal);
            this.Controls.Add(this.binary);
            this.Controls.Add(this.deci);
            this.Controls.Add(this.hexa);
            this.Controls.Add(this.output);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "information";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "binary system";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button hexa;
        private System.Windows.Forms.Button deci;
        private System.Windows.Forms.Button octal;
        private System.Windows.Forms.Button binary;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button B;
        private System.Windows.Forms.Button A;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button D;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button E;
        private System.Windows.Forms.Button F;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button subtraction;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button complement;
        private System.Windows.Forms.Button complement2;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.TextBox textBox_hexa;
        private System.Windows.Forms.TextBox textBox_deci;
        private System.Windows.Forms.TextBox textBox_binary;
        private System.Windows.Forms.TextBox textBox_octal;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox info;
        private System.Windows.Forms.Button equal;
    }
}

