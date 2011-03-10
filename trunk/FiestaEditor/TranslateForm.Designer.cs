namespace FiestaEditor
{
    partial class TranslateForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbToTranslate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbToRef = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbFromTranslate = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbFromRef = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbFrom = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbToTranslate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbToRef);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbTo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 256);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File To Translate:";
            // 
            // cmbToTranslate
            // 
            this.cmbToTranslate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbToTranslate.FormattingEnabled = true;
            this.cmbToTranslate.Location = new System.Drawing.Point(17, 173);
            this.cmbToTranslate.Name = "cmbToTranslate";
            this.cmbToTranslate.Size = new System.Drawing.Size(171, 21);
            this.cmbToTranslate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Column to be translated:";
            // 
            // cmbToRef
            // 
            this.cmbToRef.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbToRef.FormattingEnabled = true;
            this.cmbToRef.Location = new System.Drawing.Point(17, 104);
            this.cmbToRef.Name = "cmbToRef";
            this.cmbToRef.Size = new System.Drawing.Size(171, 21);
            this.cmbToRef.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Reference column:";
            // 
            // cmbTo
            // 
            this.cmbTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTo.FormattingEnabled = true;
            this.cmbTo.Location = new System.Drawing.Point(19, 47);
            this.cmbTo.Name = "cmbTo";
            this.cmbTo.Size = new System.Drawing.Size(170, 21);
            this.cmbTo.TabIndex = 1;
            this.cmbTo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbTo_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbFromTranslate);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbFromRef);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbFrom);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(262, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 256);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Translate source:";
            // 
            // cmbFromTranslate
            // 
            this.cmbFromTranslate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFromTranslate.FormattingEnabled = true;
            this.cmbFromTranslate.Location = new System.Drawing.Point(17, 173);
            this.cmbFromTranslate.Name = "cmbFromTranslate";
            this.cmbFromTranslate.Size = new System.Drawing.Size(171, 21);
            this.cmbFromTranslate.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Column to be translated:";
            // 
            // cmbFromRef
            // 
            this.cmbFromRef.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFromRef.FormattingEnabled = true;
            this.cmbFromRef.Location = new System.Drawing.Point(17, 104);
            this.cmbFromRef.Name = "cmbFromRef";
            this.cmbFromRef.Size = new System.Drawing.Size(171, 21);
            this.cmbFromRef.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Reference column:";
            // 
            // cmbFrom
            // 
            this.cmbFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFrom.FormattingEnabled = true;
            this.cmbFrom.Location = new System.Drawing.Point(19, 47);
            this.cmbFrom.Name = "cmbFrom";
            this.cmbFrom.Size = new System.Drawing.Size(170, 21);
            this.cmbFrom.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "File:";
            // 
            // TranslateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 315);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TranslateForm";
            this.Text = "frmTranslate";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTo;
        private System.Windows.Forms.ComboBox cmbToTranslate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbToRef;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbFromTranslate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbFromRef;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbFrom;
        private System.Windows.Forms.Label label6;
    }
}