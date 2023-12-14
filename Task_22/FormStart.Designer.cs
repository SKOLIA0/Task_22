namespace Task_22
{
    partial class FormStart
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
            listBoxList = new ListBox();
            buttonLoad = new Button();
            buttonReset = new Button();
            buttonFormAdd = new Button();
            buttonFormFindAge = new Button();
            buttonFormFindName = new Button();
            SuspendLayout();
            // 
            // listBoxList
            // 
            listBoxList.FormattingEnabled = true;
            listBoxList.ItemHeight = 15;
            listBoxList.Location = new Point(305, 12);
            listBoxList.Name = "listBoxList";
            listBoxList.Size = new Size(483, 424);
            listBoxList.TabIndex = 0;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(22, 21);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(143, 23);
            buttonLoad.TabIndex = 1;
            buttonLoad.Text = "Загрузить данные";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(22, 57);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(143, 23);
            buttonReset.TabIndex = 2;
            buttonReset.Text = "Обновить/сбросить";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonFormAdd
            // 
            buttonFormAdd.Location = new Point(22, 93);
            buttonFormAdd.Name = "buttonFormAdd";
            buttonFormAdd.Size = new Size(143, 23);
            buttonFormAdd.TabIndex = 3;
            buttonFormAdd.Text = "Добавить";
            buttonFormAdd.UseVisualStyleBackColor = true;
            buttonFormAdd.Click += buttonFormAdd_Click;
            // 
            // buttonFormFindAge
            // 
            buttonFormFindAge.Location = new Point(22, 129);
            buttonFormFindAge.Name = "buttonFormFindAge";
            buttonFormFindAge.Size = new Size(143, 23);
            buttonFormFindAge.TabIndex = 4;
            buttonFormFindAge.Text = "Искать по возрасту";
            buttonFormFindAge.UseVisualStyleBackColor = true;
            buttonFormFindAge.Click += buttonFormFindAge_Click;
            // 
            // buttonFormFindName
            // 
            buttonFormFindName.Location = new Point(22, 165);
            buttonFormFindName.Name = "buttonFormFindName";
            buttonFormFindName.Size = new Size(143, 23);
            buttonFormFindName.TabIndex = 5;
            buttonFormFindName.Text = "Искать по имени";
            buttonFormFindName.UseVisualStyleBackColor = true;
            buttonFormFindName.Click += buttonFormFindName_Click;
            // 
            // FormStart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonFormFindName);
            Controls.Add(buttonFormFindAge);
            Controls.Add(buttonFormAdd);
            Controls.Add(buttonReset);
            Controls.Add(buttonLoad);
            Controls.Add(listBoxList);
            Name = "FormStart";
            Text = "Task 22";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxList;
        private Button buttonLoad;
        private Button buttonReset;
        private Button buttonFormAdd;
        private Button buttonFormFindAge;
        private Button buttonFormFindName;
    }
}