namespace WinFormUI
{
    partial class DashBoard
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            firstNameText = new TextBox();
            lastNameText = new TextBox();
            generateEmployeeIdButton = new Button();
            label4 = new Label();
            employeeIdText = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(30, 50);
            label1.Name = "label1";
            label1.Size = new Size(304, 32);
            label1.TabIndex = 0;
            label1.Text = "Employee Creation Demo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(52, 126);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 1;
            label2.Text = "First Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(52, 169);
            label3.Name = "label3";
            label3.Size = new Size(87, 21);
            label3.TabIndex = 2;
            label3.Text = "Last Name:";
            // 
            // firstNameText
            // 
            firstNameText.Location = new Point(147, 124);
            firstNameText.Name = "firstNameText";
            firstNameText.Size = new Size(172, 23);
            firstNameText.TabIndex = 3;
            // 
            // lastNameText
            // 
            lastNameText.Location = new Point(147, 171);
            lastNameText.Name = "lastNameText";
            lastNameText.Size = new Size(172, 23);
            lastNameText.TabIndex = 4;
            // 
            // generateEmployeeIdButton
            // 
            generateEmployeeIdButton.Location = new Point(63, 226);
            generateEmployeeIdButton.Name = "generateEmployeeIdButton";
            generateEmployeeIdButton.Size = new Size(245, 43);
            generateEmployeeIdButton.TabIndex = 5;
            generateEmployeeIdButton.Text = "Generate Employee ID";
            generateEmployeeIdButton.UseVisualStyleBackColor = true;
            generateEmployeeIdButton.Click += generateEmployeeIdButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(52, 324);
            label4.Name = "label4";
            label4.Size = new Size(100, 21);
            label4.TabIndex = 6;
            label4.Text = "Employee ID:";
            // 
            // employeeIdText
            // 
            employeeIdText.Enabled = false;
            employeeIdText.Location = new Point(147, 322);
            employeeIdText.Name = "employeeIdText";
            employeeIdText.Size = new Size(172, 23);
            employeeIdText.TabIndex = 7;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 450);
            Controls.Add(employeeIdText);
            Controls.Add(label4);
            Controls.Add(generateEmployeeIdButton);
            Controls.Add(lastNameText);
            Controls.Add(firstNameText);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DashBoard";
            Text = "No DRY Demo Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox firstNameText;
        private TextBox lastNameText;
        private Button generateEmployeeIdButton;
        private Label label4;
        private TextBox employeeIdText;
    }
}