namespace Canada_Airline_Test
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            addBtn = new Button();
            displayBtn = new Button();
            displayTextbox = new RichTextBox();
            firstNameTextbox = new TextBox();
            weekTextbox1 = new TextBox();
            weekTextbox2 = new TextBox();
            weekTextbox3 = new TextBox();
            weekTextbox4 = new TextBox();
            lastNameTextbox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(285, 32);
            label1.Name = "label1";
            label1.Size = new Size(149, 20);
            label1.TabIndex = 0;
            label1.Text = "Canada Airline Points";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 99);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 1;
            label2.Text = "First Name:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(300, 102);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 2;
            label3.Text = "Last Name:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 160);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 4;
            label4.Text = "Week 1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 209);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 5;
            label5.Text = "Week 2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 259);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 6;
            label6.Text = "Week 3";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(49, 307);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 7;
            label7.Text = "Week 4";
            // 
            // addBtn
            // 
            addBtn.Location = new Point(313, 160);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 29);
            addBtn.TabIndex = 9;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // displayBtn
            // 
            displayBtn.Location = new Point(433, 160);
            displayBtn.Name = "displayBtn";
            displayBtn.Size = new Size(94, 29);
            displayBtn.TabIndex = 11;
            displayBtn.Text = "Display";
            displayBtn.UseVisualStyleBackColor = true;
            displayBtn.Click += displayBtn_Click;
            // 
            // displayTextbox
            // 
            displayTextbox.Location = new Point(346, 229);
            displayTextbox.Name = "displayTextbox";
            displayTextbox.Size = new Size(272, 191);
            displayTextbox.TabIndex = 12;
            displayTextbox.Text = "";
            // 
            // firstNameTextbox
            // 
            firstNameTextbox.Location = new Point(148, 96);
            firstNameTextbox.Name = "firstNameTextbox";
            firstNameTextbox.Size = new Size(125, 27);
            firstNameTextbox.TabIndex = 13;
            // 
            // weekTextbox1
            // 
            weekTextbox1.Location = new Point(148, 161);
            weekTextbox1.Name = "weekTextbox1";
            weekTextbox1.Size = new Size(125, 27);
            weekTextbox1.TabIndex = 15;
            // 
            // weekTextbox2
            // 
            weekTextbox2.Location = new Point(148, 209);
            weekTextbox2.Name = "weekTextbox2";
            weekTextbox2.Size = new Size(125, 27);
            weekTextbox2.TabIndex = 17;
            // 
            // weekTextbox3
            // 
            weekTextbox3.Location = new Point(148, 259);
            weekTextbox3.Name = "weekTextbox3";
            weekTextbox3.Size = new Size(125, 27);
            weekTextbox3.TabIndex = 19;
            // 
            // weekTextbox4
            // 
            weekTextbox4.Location = new Point(148, 307);
            weekTextbox4.Name = "weekTextbox4";
            weekTextbox4.Size = new Size(125, 27);
            weekTextbox4.TabIndex = 21;
            // 
            // lastNameTextbox
            // 
            lastNameTextbox.Location = new Point(402, 99);
            lastNameTextbox.Name = "lastNameTextbox";
            lastNameTextbox.Size = new Size(125, 27);
            lastNameTextbox.TabIndex = 25;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lastNameTextbox);
            Controls.Add(weekTextbox4);
            Controls.Add(weekTextbox3);
            Controls.Add(weekTextbox2);
            Controls.Add(weekTextbox1);
            Controls.Add(firstNameTextbox);
            Controls.Add(displayTextbox);
            Controls.Add(displayBtn);
            Controls.Add(addBtn);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button addBtn;
        private Button displayBtn;
        private RichTextBox displayTextbox;
        private TextBox firstNameTextbox;
        private TextBox weekTextbox1;
        private TextBox weekTextbox2;
        private TextBox weekTextbox3;
        private TextBox weekTextbox4;
        private TextBox lastNameTextbox;
    }
}