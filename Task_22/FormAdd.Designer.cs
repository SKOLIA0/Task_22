using System.Windows.Forms;

namespace Task_22
{
    partial class FormAdd
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
            buttonAdd = new Button();
            textBoxName = new TextBox();
            label1 = new Label();
            labelName = new Label();
            labelDateOfBirth = new Label();
            dateTimePickerDateOfBirth = new DateTimePicker();
            labelPhoneNumber = new Label();
            maskedTextBoxPhoneNumber = new MaskedTextBox();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(12, 117);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(205, 23);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Отправить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(12, 30);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(205, 23);
            textBoxName.TabIndex = 1;
            textBoxName.KeyPress += textBoxName_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(138, 15);
            label1.TabIndex = 4;
            label1.Text = "Добавить новую запись";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(223, 30);
            labelName.Name = "labelName";
            labelName.Size = new Size(31, 15);
            labelName.TabIndex = 5;
            labelName.Text = "Имя";
            // 
            // labelDateOfBirth
            // 
            labelDateOfBirth.AutoSize = true;
            labelDateOfBirth.Location = new Point(223, 62);
            labelDateOfBirth.Name = "labelDateOfBirth";
            labelDateOfBirth.Size = new Size(90, 15);
            labelDateOfBirth.TabIndex = 6;
            labelDateOfBirth.Text = "Дата рождения";
            // 
            // dateTimePickerDateOfBirth
            // 
            dateTimePickerDateOfBirth.Location = new Point(12, 59);
            dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            dateTimePickerDateOfBirth.Size = new Size(205, 23);
            dateTimePickerDateOfBirth.TabIndex = 7;
            dateTimePickerDateOfBirth.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.ForeColor = SystemColors.ControlText;
            labelPhoneNumber.Location = new Point(223, 91);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Size = new Size(101, 15);
            labelPhoneNumber.TabIndex = 8;
            labelPhoneNumber.Text = "Номер телефона";
            // 
            // maskedTextBoxPhoneNumber
            // 
            maskedTextBoxPhoneNumber.Location = new Point(12, 88);
            maskedTextBoxPhoneNumber.Mask = "+7 (000) 000-0000";
            maskedTextBoxPhoneNumber.Name = "maskedTextBoxPhoneNumber";
            maskedTextBoxPhoneNumber.Size = new Size(205, 23);
            maskedTextBoxPhoneNumber.TabIndex = 9;
            maskedTextBoxPhoneNumber.Mask = "+7 (000) 000-0000";
            maskedTextBoxPhoneNumber.Enter += maskedTextBoxPhoneNumber_Enter;
            // 
            // FormAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 156);
            Controls.Add(maskedTextBoxPhoneNumber);
            Controls.Add(labelPhoneNumber);
            Controls.Add(dateTimePickerDateOfBirth);
            Controls.Add(labelDateOfBirth);
            Controls.Add(labelName);
            Controls.Add(label1);
            Controls.Add(textBoxName);
            Controls.Add(buttonAdd);
            Name = "FormAdd";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Новая запись";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAdd;
        private TextBox textBoxName;
        private Label label1;
        private Label labelName;
        private Label labelDateOfBirth;
        private DateTimePicker dateTimePickerDateOfBirth;
        private Label labelPhoneNumber;
        private MaskedTextBox maskedTextBoxPhoneNumber;
    }
}