namespace ЛАБА5ВЫЧМАТ
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.integrateRectangleButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.simpsonButton = new System.Windows.Forms.Button();
            this.recatngleTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.simpsonTextBox = new System.Windows.Forms.TextBox();
            this.accuracyTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rectangleStepTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.simpsonStepTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // integrateRectangleButton
            // 
            this.integrateRectangleButton.Location = new System.Drawing.Point(12, 105);
            this.integrateRectangleButton.Name = "integrateRectangleButton";
            this.integrateRectangleButton.Size = new System.Drawing.Size(260, 23);
            this.integrateRectangleButton.TabIndex = 0;
            this.integrateRectangleButton.Text = "Интегрировать прямоугольниками";
            this.integrateRectangleButton.UseVisualStyleBackColor = true;
            this.integrateRectangleButton.Click += new System.EventHandler(this.integrateRectangleButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "От";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "До";
            // 
            // fromTextBox
            // 
            this.fromTextBox.Location = new System.Drawing.Point(74, 24);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(198, 20);
            this.fromTextBox.TabIndex = 3;
            // 
            // toTextBox
            // 
            this.toTextBox.Location = new System.Drawing.Point(74, 50);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(198, 20);
            this.toTextBox.TabIndex = 4;
            // 
            // simpsonButton
            // 
            this.simpsonButton.Location = new System.Drawing.Point(12, 186);
            this.simpsonButton.Name = "simpsonButton";
            this.simpsonButton.Size = new System.Drawing.Size(260, 23);
            this.simpsonButton.TabIndex = 5;
            this.simpsonButton.Text = "Интегрировать Симпсоном";
            this.simpsonButton.UseVisualStyleBackColor = true;
            this.simpsonButton.Click += new System.EventHandler(this.simpsonButton_Click);
            // 
            // recatngleTextBox
            // 
            this.recatngleTextBox.Location = new System.Drawing.Point(74, 134);
            this.recatngleTextBox.Name = "recatngleTextBox";
            this.recatngleTextBox.ReadOnly = true;
            this.recatngleTextBox.Size = new System.Drawing.Size(198, 20);
            this.recatngleTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Результат";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Результат";
            // 
            // simpsonTextBox
            // 
            this.simpsonTextBox.Location = new System.Drawing.Point(74, 215);
            this.simpsonTextBox.Name = "simpsonTextBox";
            this.simpsonTextBox.ReadOnly = true;
            this.simpsonTextBox.Size = new System.Drawing.Size(198, 20);
            this.simpsonTextBox.TabIndex = 8;
            // 
            // accuracyTextBox
            // 
            this.accuracyTextBox.Location = new System.Drawing.Point(74, 76);
            this.accuracyTextBox.Name = "accuracyTextBox";
            this.accuracyTextBox.Size = new System.Drawing.Size(198, 20);
            this.accuracyTextBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Точность";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Шаг";
            // 
            // rectangleStepTextBox
            // 
            this.rectangleStepTextBox.Location = new System.Drawing.Point(74, 160);
            this.rectangleStepTextBox.Name = "rectangleStepTextBox";
            this.rectangleStepTextBox.ReadOnly = true;
            this.rectangleStepTextBox.Size = new System.Drawing.Size(198, 20);
            this.rectangleStepTextBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Шаг";
            // 
            // simpsonStepTextBox
            // 
            this.simpsonStepTextBox.Location = new System.Drawing.Point(74, 241);
            this.simpsonStepTextBox.Name = "simpsonStepTextBox";
            this.simpsonStepTextBox.ReadOnly = true;
            this.simpsonStepTextBox.Size = new System.Drawing.Size(198, 20);
            this.simpsonStepTextBox.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 278);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.simpsonStepTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rectangleStepTextBox);
            this.Controls.Add(this.accuracyTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.simpsonTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.recatngleTextBox);
            this.Controls.Add(this.simpsonButton);
            this.Controls.Add(this.toTextBox);
            this.Controls.Add(this.fromTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.integrateRectangleButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button integrateRectangleButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fromTextBox;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.Button simpsonButton;
        private System.Windows.Forms.TextBox recatngleTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox simpsonTextBox;
        private System.Windows.Forms.TextBox accuracyTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox rectangleStepTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox simpsonStepTextBox;
    }
}

