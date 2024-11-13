namespace WinFormsApp1
{
    partial class Form1
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
            listBox1 = new ListBox();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            checkedListBox1 = new CheckedListBox();
            label2 = new Label();
            label3 = new Label();
            checkedListBox2 = new CheckedListBox();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(350, 529);
            listBox1.TabIndex = 0;
            listBox1.DoubleClick += listBox1_DoubleClick;
            // 
            // button1
            // 
            button1.Location = new Point(368, 12);
            button1.Name = "button1";
            button1.Size = new Size(227, 34);
            button1.TabIndex = 1;
            button1.Text = "New assignment";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(368, 172);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(227, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(368, 154);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 3;
            label1.Text = "Search";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(372, 222);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(223, 94);
            checkedListBox1.TabIndex = 4;
            checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(372, 204);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 5;
            label2.Text = "Priority";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(372, 319);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 6;
            label3.Text = "Status";
            // 
            // checkedListBox2
            // 
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Location = new Point(372, 337);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(223, 94);
            checkedListBox2.TabIndex = 7;
            checkedListBox2.ItemCheck += checkedListBox2_ItemCheck;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 559);
            Controls.Add(checkedListBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(checkedListBox1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private CheckedListBox checkedListBox1;
        private Label label2;
        private Label label3;
        private CheckedListBox checkedListBox2;
    }
}
