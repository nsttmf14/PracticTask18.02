
namespace WindowsFormsApp1
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NameTextBox2 = new System.Windows.Forms.TextBox();
            this.AgeNumericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.GroupComboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DescriptionRichTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AgeNumericUpDown2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Возраст";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Группа";
            // 
            // NameTextBox2
            // 
            this.NameTextBox2.Location = new System.Drawing.Point(88, 5);
            this.NameTextBox2.Name = "NameTextBox2";
            this.NameTextBox2.Size = new System.Drawing.Size(120, 20);
            this.NameTextBox2.TabIndex = 3;
            // 
            // AgeNumericUpDown2
            // 
            this.AgeNumericUpDown2.Location = new System.Drawing.Point(88, 31);
            this.AgeNumericUpDown2.Name = "AgeNumericUpDown2";
            this.AgeNumericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.AgeNumericUpDown2.TabIndex = 4;
            // 
            // GroupComboBox2
            // 
            this.GroupComboBox2.FormattingEnabled = true;
            this.GroupComboBox2.Items.AddRange(new object[] {
            "09-121",
            "09-122"});
            this.GroupComboBox2.Location = new System.Drawing.Point(88, 60);
            this.GroupComboBox2.Name = "GroupComboBox2";
            this.GroupComboBox2.Size = new System.Drawing.Size(121, 21);
            this.GroupComboBox2.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DescriptionRichTextBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 140);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Описание";
            // 
            // DescriptionRichTextBox2
            // 
            this.DescriptionRichTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescriptionRichTextBox2.Location = new System.Drawing.Point(3, 16);
            this.DescriptionRichTextBox2.Name = "DescriptionRichTextBox2";
            this.DescriptionRichTextBox2.Size = new System.Drawing.Size(357, 121);
            this.DescriptionRichTextBox2.TabIndex = 0;
            this.DescriptionRichTextBox2.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 27);
            this.button1.TabIndex = 7;
            this.button1.Text = "Сохранить изменения";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 227);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GroupComboBox2);
            this.Controls.Add(this.AgeNumericUpDown2);
            this.Controls.Add(this.NameTextBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Изменения";
            ((System.ComponentModel.ISupportInitialize)(this.AgeNumericUpDown2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox NameTextBox2;
        public System.Windows.Forms.NumericUpDown AgeNumericUpDown2;
        public System.Windows.Forms.ComboBox GroupComboBox2;
        public System.Windows.Forms.RichTextBox DescriptionRichTextBox2;
    }
}