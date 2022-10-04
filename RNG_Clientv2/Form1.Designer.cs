namespace RNG_Clientv2
{
    partial class Form1
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
            this.BtnConnect = new System.Windows.Forms.Button();
            this.Numbers = new System.Windows.Forms.NumericUpDown();
            this.Num = new System.Windows.Forms.ListBox();
            this.BtnDisconnect = new System.Windows.Forms.Button();
            this.maxNumber = new System.Windows.Forms.NumericUpDown();
            this.IPBar = new System.Windows.Forms.TextBox();
            this.Generate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Numbers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(12, 12);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(105, 25);
            this.BtnConnect.TabIndex = 0;
            this.BtnConnect.Text = "Connetti";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // Numbers
            // 
            this.Numbers.Location = new System.Drawing.Point(12, 147);
            this.Numbers.Name = "Numbers";
            this.Numbers.Size = new System.Drawing.Size(74, 27);
            this.Numbers.TabIndex = 1;
            this.Numbers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Numbers.ValueChanged += new System.EventHandler(this.Numbers_ValueChanged);
            // 
            // Num
            // 
            this.Num.FormattingEnabled = true;
            this.Num.ItemHeight = 20;
            this.Num.Location = new System.Drawing.Point(238, 32);
            this.Num.Name = "Num";
            this.Num.Size = new System.Drawing.Size(150, 404);
            this.Num.TabIndex = 3;
            // 
            // BtnDisconnect
            // 
            this.BtnDisconnect.Enabled = false;
            this.BtnDisconnect.Location = new System.Drawing.Point(12, 409);
            this.BtnDisconnect.Name = "BtnDisconnect";
            this.BtnDisconnect.Size = new System.Drawing.Size(94, 29);
            this.BtnDisconnect.TabIndex = 4;
            this.BtnDisconnect.Text = "Disconnetti";
            this.BtnDisconnect.UseVisualStyleBackColor = true;
            // 
            // maxNumber
            // 
            this.maxNumber.Location = new System.Drawing.Point(12, 202);
            this.maxNumber.Name = "maxNumber";
            this.maxNumber.Size = new System.Drawing.Size(74, 27);
            this.maxNumber.TabIndex = 5;
            this.maxNumber.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.maxNumber.ValueChanged += new System.EventHandler(this.maxNumber_ValueChanged);
            // 
            // IPBar
            // 
            this.IPBar.Location = new System.Drawing.Point(12, 264);
            this.IPBar.Name = "IPBar";
            this.IPBar.Size = new System.Drawing.Size(125, 27);
            this.IPBar.TabIndex = 6;
            this.IPBar.TextChanged += new System.EventHandler(this.IPBar_TextChanged);
            // 
            // Generate
            // 
            this.Generate.Enabled = false;
            this.Generate.Location = new System.Drawing.Point(12, 43);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(105, 77);
            this.Generate.TabIndex = 7;
            this.Generate.Text = "Genera";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.IPBar);
            this.Controls.Add(this.maxNumber);
            this.Controls.Add(this.BtnDisconnect);
            this.Controls.Add(this.Num);
            this.Controls.Add(this.Numbers);
            this.Controls.Add(this.BtnConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Numbers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnConnect;
        private NumericUpDown Numbers;
        private ListBox Num;
        private Button BtnDisconnect;
        private NumericUpDown maxNumber;
        private TextBox IPBar;
        private Button Generate;
    }
}