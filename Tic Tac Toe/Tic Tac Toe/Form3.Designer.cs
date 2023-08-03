namespace Tic_Tac_Toe
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            listBox2 = new ListBox();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(122, 102);
            button1.Name = "button1";
            button1.Size = new Size(52, 42);
            button1.TabIndex = 0;
            button1.Text = "PvP";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(226, 102);
            button2.Name = "button2";
            button2.Size = new Size(52, 42);
            button2.TabIndex = 1;
            button2.Text = "PvAI";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(-1, 20);
            label1.Name = "label1";
            label1.Size = new Size(428, 21);
            label1.TabIndex = 2;
            label1.Text = "Welcome to my tictactoe game and thanks for playing <3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(122, 50);
            label2.Name = "label2";
            label2.Size = new Size(156, 20);
            label2.TabIndex = 3;
            label2.Text = "Please Select a Mode:";
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.Yellow;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(223, 98);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(58, 49);
            listBox2.TabIndex = 5;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Yellow;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(119, 98);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(58, 49);
            listBox1.TabIndex = 6;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(425, 169);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form3";
            Text = "Tic-Tac-Toe lobby ~by Bugra";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private ListBox listBox2;
        private ListBox listBox1;
    }
}