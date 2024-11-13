namespace WinFormsApp1
{
    partial class DetailForm
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
            button1 = new Button();
            button2 = new Button();
            txtTitle = new TextBox();
            txtDescription = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboPriority = new ComboBox();
            comboStatus = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(32, 333);
            button1.Name = "button1";
            button1.Size = new Size(120, 39);
            button1.TabIndex = 0;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(180, 333);
            button2.Name = "button2";
            button2.Size = new Size(122, 39);
            button2.TabIndex = 1;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(31, 59);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(270, 23);
            txtTitle.TabIndex = 2;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(30, 105);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(271, 145);
            txtDescription.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 41);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 4;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 87);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 5;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 268);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 6;
            label3.Text = "Priority";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(179, 268);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 7;
            label4.Text = "Status";
            // 
            // comboPriority
            // 
            comboPriority.FormattingEnabled = true;
            comboPriority.Location = new Point(30, 286);
            comboPriority.Name = "comboPriority";
            comboPriority.Size = new Size(121, 23);
            comboPriority.TabIndex = 8;
            // 
            // comboStatus
            // 
            comboStatus.FormattingEnabled = true;
            comboStatus.Location = new Point(180, 286);
            comboStatus.Name = "comboStatus";
            comboStatus.Size = new Size(121, 23);
            comboStatus.TabIndex = 9;
            // 
            // DetailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 383);
            Controls.Add(comboStatus);
            Controls.Add(comboPriority);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDescription);
            Controls.Add(txtTitle);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "DetailForm";
            Text = "DetailForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox txtTitle;
        private TextBox txtDescription;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboPriority;
        private ComboBox comboStatus;
    }
}