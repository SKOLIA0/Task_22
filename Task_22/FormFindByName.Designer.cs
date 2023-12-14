namespace Task_22
{
    partial class FormFindByName
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
            textBoxFindName = new TextBox();
            buttonFindName = new Button();
            labelFindName = new Label();
            SuspendLayout();
            // 
            // textBoxFindName
            // 
            textBoxFindName.Location = new Point(64, 61);
            textBoxFindName.Name = "textBoxFindName";
            textBoxFindName.Size = new Size(205, 23);
            textBoxFindName.TabIndex = 0;
            // 
            // buttonFindName
            // 
            buttonFindName.Location = new Point(129, 98);
            buttonFindName.Name = "buttonFindName";
            buttonFindName.Size = new Size(75, 23);
            buttonFindName.TabIndex = 1;
            buttonFindName.Text = "Найти";
            buttonFindName.UseVisualStyleBackColor = true;
            buttonFindName.Click += buttonFindName_Click;
            // 
            // labelFindName
            // 
            labelFindName.AutoSize = true;
            labelFindName.Location = new Point(126, 35);
            labelFindName.Name = "labelFindName";
            labelFindName.Size = new Size(78, 15);
            labelFindName.TabIndex = 2;
            labelFindName.Text = "Введите  имя";
            labelFindName.Click += labelFindName_Click;
            // 
            // FormFindByName
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 156);
            Controls.Add(labelFindName);
            Controls.Add(buttonFindName);
            Controls.Add(textBoxFindName);
            Name = "FormFindByName";
            Text = "Поиск по имени";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxFindName;
        private Button buttonFindName;
        private Label labelFindName;
    }
}