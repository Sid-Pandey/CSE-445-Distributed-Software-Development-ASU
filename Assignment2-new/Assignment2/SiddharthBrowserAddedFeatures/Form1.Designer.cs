namespace SiddharthBrowserAddedFeatures
{
    partial class Form1
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
            this.input = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.input1 = new System.Windows.Forms.TextBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.input_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.encrypted = new System.Windows.Forms.Label();
            this.encrypt_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.decrypted = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(0, 1);
            this.input.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(882, 20);
            this.input.TabIndex = 0;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(879, -2);
            this.search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(71, 26);
            this.search.TabIndex = 1;
            this.search.Text = "Go!";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(0, 24);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(15, 16);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(962, 346);
            this.webBrowser1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(595, 384);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Simple Calculator";
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(568, 412);
            this.input1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(76, 20);
            this.input1.TabIndex = 4;
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(664, 412);
            this.input2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(76, 20);
            this.input2.TabIndex = 5;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(587, 443);
            this.add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(56, 19);
            this.add.TabIndex = 7;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // subtract
            // 
            this.subtract.Location = new System.Drawing.Point(664, 443);
            this.subtract.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(56, 19);
            this.subtract.TabIndex = 9;
            this.subtract.Text = "-";
            this.subtract.UseVisualStyleBackColor = true;
            this.subtract.Click += new System.EventHandler(this.subtract_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(587, 479);
            this.multiply.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(56, 19);
            this.multiply.TabIndex = 11;
            this.multiply.Text = "x";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(664, 479);
            this.divide.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(56, 19);
            this.divide.TabIndex = 13;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(381, 243);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(6, 6);
            this.button5.TabIndex = 14;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(758, 466);
            this.output.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(108, 15);
            this.output.TabIndex = 15;
            this.output.Text = "The answer is : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 433);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Enter text to be encrypted : ";
            // 
            // input_text
            // 
            this.input_text.Location = new System.Drawing.Point(206, 432);
            this.input_text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.input_text.Name = "input_text";
            this.input_text.Size = new System.Drawing.Size(208, 20);
            this.input_text.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 457);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "The encrypted text is : ";
            // 
            // encrypted
            // 
            this.encrypted.AutoSize = true;
            this.encrypted.Location = new System.Drawing.Point(248, 458);
            this.encrypted.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.encrypted.Name = "encrypted";
            this.encrypted.Size = new System.Drawing.Size(76, 13);
            this.encrypted.TabIndex = 19;
            this.encrypted.Text = "[EncryptedTxt]";
            this.encrypted.Click += new System.EventHandler(this.encrypted_Click);
            // 
            // encrypt_button
            // 
            this.encrypt_button.Location = new System.Drawing.Point(434, 429);
            this.encrypt_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.encrypt_button.Name = "encrypt_button";
            this.encrypt_button.Size = new System.Drawing.Size(77, 21);
            this.encrypt_button.TabIndex = 20;
            this.encrypt_button.Text = "Encrypt";
            this.encrypt_button.UseVisualStyleBackColor = true;
            this.encrypt_button.Click += new System.EventHandler(this.encrypt_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(112, 396);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "Encryption Service";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 483);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(226, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Check if decrypted text is correct : ";
            // 
            // decrypted
            // 
            this.decrypted.AutoSize = true;
            this.decrypted.Location = new System.Drawing.Point(248, 484);
            this.decrypted.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.decrypted.Name = "decrypted";
            this.decrypted.Size = new System.Drawing.Size(77, 13);
            this.decrypted.TabIndex = 24;
            this.decrypted.Text = "[DercyptedTxt]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(964, 507);
            this.Controls.Add(this.decrypted);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.encrypt_button);
            this.Controls.Add(this.encrypted);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.input_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.output);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.subtract);
            this.Controls.Add(this.add);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.input);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "SiddharthBrowserAddedFeatures";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox input_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label encrypted;
        private System.Windows.Forms.Button encrypt_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label decrypted;
    }
}

