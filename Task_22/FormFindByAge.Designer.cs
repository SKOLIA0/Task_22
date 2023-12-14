namespace Task_22
{
    partial class FormFindByAge
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
            labelFindAge = new Label();
            buttonFindAge = new Button();
            numericUpDownFindAgeFrom = new NumericUpDown();
            numericUpDownAgeTo = new NumericUpDown();
            labelAgeFrom = new Label();
            labelAgeTo = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFindAgeFrom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAgeTo).BeginInit();
            SuspendLayout();
            // 
            // labelFindAge
            // 
            labelFindAge.AutoSize = true;
            labelFindAge.Location = new Point(96, 27);
            labelFindAge.Name = "labelFindAge";
            labelFindAge.Size = new Size(141, 15);
            labelFindAge.TabIndex = 5;
            labelFindAge.Text = "Введите  количество лет";
            // 
            // buttonFindAge
            // 
            buttonFindAge.Location = new Point(129, 105);
            buttonFindAge.Name = "buttonFindAge";
            buttonFindAge.Size = new Size(75, 23);
            buttonFindAge.TabIndex = 4;
            buttonFindAge.Text = "Найти";
            buttonFindAge.UseVisualStyleBackColor = true;
            buttonFindAge.Click += buttonFindAge_Click;
            // 
            // numericUpDownFindAgeFrom
            // 
            numericUpDownFindAgeFrom.Location = new Point(87, 66);
            numericUpDownFindAgeFrom.Name = "numericUpDownFindAgeFrom";
            numericUpDownFindAgeFrom.Size = new Size(63, 23);
            numericUpDownFindAgeFrom.TabIndex = 6;
            // 
            // numericUpDownAgeTo
            // 
            numericUpDownAgeTo.Location = new Point(230, 66);
            numericUpDownAgeTo.Name = "numericUpDownAgeTo";
            numericUpDownAgeTo.Size = new Size(63, 23);
            numericUpDownAgeTo.TabIndex = 7;
            numericUpDownAgeTo.Value = new decimal(new int[] { 99, 0, 0, 0 });
            // 
            // labelAgeFrom
            // 
            labelAgeFrom.AutoSize = true;
            labelAgeFrom.Location = new Point(38, 70);
            labelAgeFrom.Name = "labelAgeFrom";
            labelAgeFrom.Size = new Size(19, 15);
            labelAgeFrom.TabIndex = 8;
            labelAgeFrom.Text = "от";
            // 
            // labelAgeTo
            // 
            labelAgeTo.AutoSize = true;
            labelAgeTo.Location = new Point(180, 70);
            labelAgeTo.Name = "labelAgeTo";
            labelAgeTo.Size = new Size(20, 15);
            labelAgeTo.TabIndex = 9;
            labelAgeTo.Text = "до";
            // 
            // FormFindByAge
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 156);
            Controls.Add(labelAgeTo);
            Controls.Add(labelAgeFrom);
            Controls.Add(numericUpDownAgeTo);
            Controls.Add(numericUpDownFindAgeFrom);
            Controls.Add(labelFindAge);
            Controls.Add(buttonFindAge);
            Name = "FormFindByAge";
            Text = "Поиск по возрасту";
            ((System.ComponentModel.ISupportInitialize)numericUpDownFindAgeFrom).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAgeTo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFindAge;
        private Button buttonFindAge;
        private NumericUpDown numericUpDownFindAgeFrom;
        private NumericUpDown numericUpDownAgeTo;
        private Label labelAgeFrom;
        private Label labelAgeTo;
    }
}