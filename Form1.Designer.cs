
namespace dotNetPractical_6
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
            this.buttonseven = new System.Windows.Forms.Button();
            this.buttoneight = new System.Windows.Forms.Button();
            this.buttonnine = new System.Windows.Forms.Button();
            this.buttondiv = new System.Windows.Forms.Button();
            this.buttonclearentry = new System.Windows.Forms.Button();
            this.buttonclear = new System.Windows.Forms.Button();
            this.buttonmulti = new System.Windows.Forms.Button();
            this.buttonsix = new System.Windows.Forms.Button();
            this.buttonfive = new System.Windows.Forms.Button();
            this.buttonfour = new System.Windows.Forms.Button();
            this.buttonsub = new System.Windows.Forms.Button();
            this.buttonthree = new System.Windows.Forms.Button();
            this.buttontwo = new System.Windows.Forms.Button();
            this.buttonone = new System.Windows.Forms.Button();
            this.buttonequal = new System.Windows.Forms.Button();
            this.buttonadd = new System.Windows.Forms.Button();
            this.buttondot = new System.Windows.Forms.Button();
            this.buttonzero = new System.Windows.Forms.Button();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.labelCurrentOperation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonseven
            // 
            this.buttonseven.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonseven.Location = new System.Drawing.Point(22, 88);
            this.buttonseven.Name = "buttonseven";
            this.buttonseven.Size = new System.Drawing.Size(45, 45);
            this.buttonseven.TabIndex = 0;
            this.buttonseven.Text = "7";
            this.buttonseven.UseVisualStyleBackColor = true;
            this.buttonseven.Click += new System.EventHandler(this.button_click);
            // 
            // buttoneight
            // 
            this.buttoneight.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoneight.Location = new System.Drawing.Point(73, 88);
            this.buttoneight.Name = "buttoneight";
            this.buttoneight.Size = new System.Drawing.Size(45, 45);
            this.buttoneight.TabIndex = 1;
            this.buttoneight.Text = "8";
            this.buttoneight.UseVisualStyleBackColor = true;
            this.buttoneight.Click += new System.EventHandler(this.button_click);
            // 
            // buttonnine
            // 
            this.buttonnine.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonnine.Location = new System.Drawing.Point(124, 88);
            this.buttonnine.Name = "buttonnine";
            this.buttonnine.Size = new System.Drawing.Size(45, 45);
            this.buttonnine.TabIndex = 2;
            this.buttonnine.Text = "9";
            this.buttonnine.UseVisualStyleBackColor = true;
            this.buttonnine.Click += new System.EventHandler(this.button_click);
            // 
            // buttondiv
            // 
            this.buttondiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondiv.Location = new System.Drawing.Point(175, 88);
            this.buttondiv.Name = "buttondiv";
            this.buttondiv.Size = new System.Drawing.Size(45, 45);
            this.buttondiv.TabIndex = 3;
            this.buttondiv.Text = "/";
            this.buttondiv.UseVisualStyleBackColor = true;
            this.buttondiv.Click += new System.EventHandler(this.operator_click);
            // 
            // buttonclearentry
            // 
            this.buttonclearentry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonclearentry.Location = new System.Drawing.Point(226, 88);
            this.buttonclearentry.Name = "buttonclearentry";
            this.buttonclearentry.Size = new System.Drawing.Size(60, 45);
            this.buttonclearentry.TabIndex = 4;
            this.buttonclearentry.Text = "CE";
            this.buttonclearentry.UseVisualStyleBackColor = true;
            this.buttonclearentry.Click += new System.EventHandler(this.buttonclearentry_Click);
            // 
            // buttonclear
            // 
            this.buttonclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonclear.Location = new System.Drawing.Point(226, 139);
            this.buttonclear.Name = "buttonclear";
            this.buttonclear.Size = new System.Drawing.Size(60, 45);
            this.buttonclear.TabIndex = 9;
            this.buttonclear.Text = "C";
            this.buttonclear.UseVisualStyleBackColor = true;
            this.buttonclear.Click += new System.EventHandler(this.buttonclear_Click);
            // 
            // buttonmulti
            // 
            this.buttonmulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmulti.Location = new System.Drawing.Point(175, 139);
            this.buttonmulti.Name = "buttonmulti";
            this.buttonmulti.Size = new System.Drawing.Size(45, 45);
            this.buttonmulti.TabIndex = 8;
            this.buttonmulti.Text = "*";
            this.buttonmulti.UseVisualStyleBackColor = true;
            this.buttonmulti.Click += new System.EventHandler(this.operator_click);
            // 
            // buttonsix
            // 
            this.buttonsix.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsix.Location = new System.Drawing.Point(124, 139);
            this.buttonsix.Name = "buttonsix";
            this.buttonsix.Size = new System.Drawing.Size(45, 45);
            this.buttonsix.TabIndex = 7;
            this.buttonsix.Text = "6";
            this.buttonsix.UseVisualStyleBackColor = true;
            this.buttonsix.Click += new System.EventHandler(this.button_click);
            // 
            // buttonfive
            // 
            this.buttonfive.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonfive.Location = new System.Drawing.Point(73, 139);
            this.buttonfive.Name = "buttonfive";
            this.buttonfive.Size = new System.Drawing.Size(45, 45);
            this.buttonfive.TabIndex = 6;
            this.buttonfive.Text = "5";
            this.buttonfive.UseVisualStyleBackColor = true;
            this.buttonfive.Click += new System.EventHandler(this.button_click);
            // 
            // buttonfour
            // 
            this.buttonfour.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonfour.Location = new System.Drawing.Point(22, 139);
            this.buttonfour.Name = "buttonfour";
            this.buttonfour.Size = new System.Drawing.Size(45, 45);
            this.buttonfour.TabIndex = 5;
            this.buttonfour.Text = "4";
            this.buttonfour.UseVisualStyleBackColor = true;
            this.buttonfour.Click += new System.EventHandler(this.button_click);
            // 
            // buttonsub
            // 
            this.buttonsub.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsub.Location = new System.Drawing.Point(175, 190);
            this.buttonsub.Name = "buttonsub";
            this.buttonsub.Size = new System.Drawing.Size(45, 45);
            this.buttonsub.TabIndex = 13;
            this.buttonsub.Text = "-";
            this.buttonsub.UseVisualStyleBackColor = true;
            this.buttonsub.Click += new System.EventHandler(this.operator_click);
            // 
            // buttonthree
            // 
            this.buttonthree.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonthree.Location = new System.Drawing.Point(124, 190);
            this.buttonthree.Name = "buttonthree";
            this.buttonthree.Size = new System.Drawing.Size(45, 45);
            this.buttonthree.TabIndex = 12;
            this.buttonthree.Text = "3";
            this.buttonthree.UseVisualStyleBackColor = true;
            this.buttonthree.Click += new System.EventHandler(this.button_click);
            // 
            // buttontwo
            // 
            this.buttontwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttontwo.Location = new System.Drawing.Point(73, 190);
            this.buttontwo.Name = "buttontwo";
            this.buttontwo.Size = new System.Drawing.Size(45, 45);
            this.buttontwo.TabIndex = 11;
            this.buttontwo.Text = "2";
            this.buttontwo.UseVisualStyleBackColor = true;
            this.buttontwo.Click += new System.EventHandler(this.button_click);
            // 
            // buttonone
            // 
            this.buttonone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonone.Location = new System.Drawing.Point(22, 190);
            this.buttonone.Name = "buttonone";
            this.buttonone.Size = new System.Drawing.Size(45, 45);
            this.buttonone.TabIndex = 10;
            this.buttonone.Text = "1";
            this.buttonone.UseVisualStyleBackColor = true;
            this.buttonone.Click += new System.EventHandler(this.button_click);
            // 
            // buttonequal
            // 
            this.buttonequal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonequal.Location = new System.Drawing.Point(226, 190);
            this.buttonequal.Name = "buttonequal";
            this.buttonequal.Size = new System.Drawing.Size(60, 96);
            this.buttonequal.TabIndex = 19;
            this.buttonequal.Text = "=";
            this.buttonequal.UseVisualStyleBackColor = true;
            this.buttonequal.Click += new System.EventHandler(this.buttonequal_Click);
            // 
            // buttonadd
            // 
            this.buttonadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonadd.Location = new System.Drawing.Point(175, 241);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(45, 45);
            this.buttonadd.TabIndex = 18;
            this.buttonadd.Text = "+";
            this.buttonadd.UseVisualStyleBackColor = true;
            this.buttonadd.Click += new System.EventHandler(this.operator_click);
            // 
            // buttondot
            // 
            this.buttondot.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondot.Location = new System.Drawing.Point(124, 241);
            this.buttondot.Name = "buttondot";
            this.buttondot.Size = new System.Drawing.Size(45, 45);
            this.buttondot.TabIndex = 17;
            this.buttondot.Text = ".";
            this.buttondot.UseVisualStyleBackColor = true;
            this.buttondot.Click += new System.EventHandler(this.button_click);
            // 
            // buttonzero
            // 
            this.buttonzero.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonzero.Location = new System.Drawing.Point(22, 241);
            this.buttonzero.Name = "buttonzero";
            this.buttonzero.Size = new System.Drawing.Size(96, 45);
            this.buttonzero.TabIndex = 15;
            this.buttonzero.Text = "0";
            this.buttonzero.UseVisualStyleBackColor = true;
            this.buttonzero.Click += new System.EventHandler(this.button_click);
            // 
            // textBox_Result
            // 
            this.textBox_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Result.Location = new System.Drawing.Point(22, 47);
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.Size = new System.Drawing.Size(264, 34);
            this.textBox_Result.TabIndex = 20;
            this.textBox_Result.Text = "0";
            this.textBox_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelCurrentOperation
            // 
            this.labelCurrentOperation.AutoSize = true;
            this.labelCurrentOperation.BackColor = System.Drawing.SystemColors.Window;
            this.labelCurrentOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentOperation.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelCurrentOperation.Location = new System.Drawing.Point(17, 15);
            this.labelCurrentOperation.Name = "labelCurrentOperation";
            this.labelCurrentOperation.Size = new System.Drawing.Size(0, 29);
            this.labelCurrentOperation.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 308);
            this.Controls.Add(this.labelCurrentOperation);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.buttonequal);
            this.Controls.Add(this.buttonadd);
            this.Controls.Add(this.buttondot);
            this.Controls.Add(this.buttonzero);
            this.Controls.Add(this.buttonsub);
            this.Controls.Add(this.buttonthree);
            this.Controls.Add(this.buttontwo);
            this.Controls.Add(this.buttonone);
            this.Controls.Add(this.buttonclear);
            this.Controls.Add(this.buttonmulti);
            this.Controls.Add(this.buttonsix);
            this.Controls.Add(this.buttonfive);
            this.Controls.Add(this.buttonfour);
            this.Controls.Add(this.buttonclearentry);
            this.Controls.Add(this.buttondiv);
            this.Controls.Add(this.buttonnine);
            this.Controls.Add(this.buttoneight);
            this.Controls.Add(this.buttonseven);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonseven;
        private System.Windows.Forms.Button buttoneight;
        private System.Windows.Forms.Button buttonnine;
        private System.Windows.Forms.Button buttondiv;
        private System.Windows.Forms.Button buttonclearentry;
        private System.Windows.Forms.Button buttonclear;
        private System.Windows.Forms.Button buttonmulti;
        private System.Windows.Forms.Button buttonsix;
        private System.Windows.Forms.Button buttonfive;
        private System.Windows.Forms.Button buttonfour;
        private System.Windows.Forms.Button buttonsub;
        private System.Windows.Forms.Button buttonthree;
        private System.Windows.Forms.Button buttontwo;
        private System.Windows.Forms.Button buttonone;
        private System.Windows.Forms.Button buttonequal;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.Button buttondot;
        private System.Windows.Forms.Button buttonzero;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Label labelCurrentOperation;
    }
}

