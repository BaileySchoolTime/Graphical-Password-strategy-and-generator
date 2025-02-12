namespace BJW_GraphicalPasswordGen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            fileSystemWatcher1 = new FileSystemWatcher();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            ClearButton = new Button();
            nextButton = new Button();
            groupBox1 = new GroupBox();
            B1button = new Button();
            A1button = new Button();
            C2button = new Button();
            A2button = new Button();
            B2button = new Button();
            A3button = new Button();
            B3button = new Button();
            C3button = new Button();
            A4button = new Button();
            B4button = new Button();
            C4button = new Button();
            D4button = new Button();
            D3button = new Button();
            D2button = new Button();
            D1button = new Button();
            C1button = new Button();
            label27 = new Label();
            passwordTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(197, 21);
            label1.TabIndex = 0;
            label1.Text = "Image Password Generator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 52);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Email:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(67, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(146, 23);
            textBox1.TabIndex = 2;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(86, 140);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(75, 23);
            ClearButton.TabIndex = 3;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += clearButton_Click;
            // 
            // nextButton
            // 
            nextButton.Location = new Point(264, 411);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(75, 23);
            nextButton.TabIndex = 21;
            nextButton.Text = "Next";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(B1button);
            groupBox1.Controls.Add(A1button);
            groupBox1.Controls.Add(C2button);
            groupBox1.Controls.Add(A2button);
            groupBox1.Controls.Add(B2button);
            groupBox1.Controls.Add(A3button);
            groupBox1.Controls.Add(B3button);
            groupBox1.Controls.Add(C3button);
            groupBox1.Controls.Add(A4button);
            groupBox1.Controls.Add(B4button);
            groupBox1.Controls.Add(C4button);
            groupBox1.Controls.Add(D4button);
            groupBox1.Controls.Add(D3button);
            groupBox1.Controls.Add(D2button);
            groupBox1.Controls.Add(D1button);
            groupBox1.Controls.Add(C1button);
            groupBox1.Location = new Point(12, 190);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(236, 244);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Images";
            // 
            // B1button
            // 
            B1button.Font = new Font("Segoe UI", 20F);
            B1button.Image = Properties.Resources.Turtle;
            B1button.Location = new Point(64, 31);
            B1button.Name = "B1button";
            B1button.Size = new Size(45, 45);
            B1button.TabIndex = 36;
            B1button.UseVisualStyleBackColor = true;
            B1button.Click += B1button_Click;
            // 
            // A1button
            // 
            A1button.Font = new Font("Segoe UI", 20F);
            A1button.Image = (Image)resources.GetObject("A1button.Image");
            A1button.Location = new Point(13, 31);
            A1button.Name = "A1button";
            A1button.Size = new Size(45, 45);
            A1button.TabIndex = 35;
            A1button.UseVisualStyleBackColor = true;
            A1button.Click += A1button_Click;
            // 
            // C2button
            // 
            C2button.Font = new Font("Segoe UI", 20F);
            C2button.Image = Properties.Resources.owl;
            C2button.Location = new Point(115, 82);
            C2button.Name = "C2button";
            C2button.Size = new Size(45, 45);
            C2button.TabIndex = 34;
            C2button.UseVisualStyleBackColor = true;
            C2button.Click += C2button_Click;
            // 
            // A2button
            // 
            A2button.Font = new Font("Segoe UI", 20F);
            A2button.Image = (Image)resources.GetObject("A2button.Image");
            A2button.Location = new Point(13, 82);
            A2button.Name = "A2button";
            A2button.Size = new Size(45, 45);
            A2button.TabIndex = 33;
            A2button.UseVisualStyleBackColor = true;
            A2button.Click += A2button_Click;
            // 
            // B2button
            // 
            B2button.Font = new Font("Segoe UI", 20F);
            B2button.Image = Properties.Resources.PolarBear;
            B2button.Location = new Point(64, 82);
            B2button.Name = "B2button";
            B2button.Size = new Size(45, 45);
            B2button.TabIndex = 32;
            B2button.UseVisualStyleBackColor = true;
            B2button.Click += B2button_Click;
            // 
            // A3button
            // 
            A3button.Font = new Font("Segoe UI", 20F);
            A3button.Image = Properties.Resources.kangaroo;
            A3button.Location = new Point(13, 130);
            A3button.Name = "A3button";
            A3button.Size = new Size(45, 45);
            A3button.TabIndex = 22;
            A3button.UseVisualStyleBackColor = true;
            A3button.Click += A3button_Click;
            // 
            // B3button
            // 
            B3button.Font = new Font("Segoe UI", 20F);
            B3button.Image = Properties.Resources.zebra;
            B3button.Location = new Point(64, 130);
            B3button.Name = "B3button";
            B3button.Size = new Size(45, 45);
            B3button.TabIndex = 23;
            B3button.UseVisualStyleBackColor = true;
            B3button.Click += B3button_Click;
            // 
            // C3button
            // 
            C3button.Font = new Font("Segoe UI", 20F);
            C3button.Image = Properties.Resources.Croc;
            C3button.Location = new Point(115, 130);
            C3button.Name = "C3button";
            C3button.Size = new Size(45, 45);
            C3button.TabIndex = 24;
            C3button.UseVisualStyleBackColor = true;
            C3button.Click += C3button_Click;
            // 
            // A4button
            // 
            A4button.Font = new Font("Segoe UI", 20F);
            A4button.Image = Properties.Resources.Gorilla;
            A4button.Location = new Point(13, 183);
            A4button.Name = "A4button";
            A4button.Size = new Size(45, 45);
            A4button.TabIndex = 25;
            A4button.UseVisualStyleBackColor = true;
            A4button.Click += A4button_Click;
            // 
            // B4button
            // 
            B4button.Font = new Font("Segoe UI", 20F);
            B4button.Image = Properties.Resources.whale;
            B4button.Location = new Point(64, 183);
            B4button.Name = "B4button";
            B4button.Size = new Size(45, 45);
            B4button.TabIndex = 26;
            B4button.UseVisualStyleBackColor = true;
            B4button.Click += B4button_Click;
            // 
            // C4button
            // 
            C4button.Font = new Font("Segoe UI", 20F);
            C4button.Image = Properties.Resources.peacock;
            C4button.Location = new Point(115, 181);
            C4button.Name = "C4button";
            C4button.Size = new Size(45, 45);
            C4button.TabIndex = 27;
            C4button.UseVisualStyleBackColor = true;
            C4button.Click += C4button_Click;
            // 
            // D4button
            // 
            D4button.Font = new Font("Segoe UI", 20F);
            D4button.Image = Properties.Resources.ape;
            D4button.Location = new Point(166, 181);
            D4button.Name = "D4button";
            D4button.Size = new Size(45, 45);
            D4button.TabIndex = 28;
            D4button.UseVisualStyleBackColor = true;
            D4button.Click += D4button_Click;
            // 
            // D3button
            // 
            D3button.Font = new Font("Segoe UI", 20F);
            D3button.Image = Properties.Resources.bison;
            D3button.Location = new Point(166, 130);
            D3button.Name = "D3button";
            D3button.Size = new Size(45, 45);
            D3button.TabIndex = 29;
            D3button.UseVisualStyleBackColor = true;
            D3button.Click += D3button_Click;
            // 
            // D2button
            // 
            D2button.Font = new Font("Segoe UI", 20F);
            D2button.Image = Properties.Resources.shark;
            D2button.Location = new Point(166, 82);
            D2button.Name = "D2button";
            D2button.Size = new Size(45, 45);
            D2button.TabIndex = 30;
            D2button.UseVisualStyleBackColor = true;
            D2button.Click += D2button_Click;
            // 
            // D1button
            // 
            D1button.Font = new Font("Segoe UI", 20F);
            D1button.Image = Properties.Resources.perry;
            D1button.Location = new Point(166, 31);
            D1button.Name = "D1button";
            D1button.Size = new Size(45, 45);
            D1button.TabIndex = 31;
            D1button.UseVisualStyleBackColor = true;
            D1button.Click += D1button_Click;
            // 
            // C1button
            // 
            C1button.Font = new Font("Segoe UI", 20F);
            C1button.Image = Properties.Resources.cheetah;
            C1button.Location = new Point(115, 31);
            C1button.Name = "C1button";
            C1button.Size = new Size(45, 45);
            C1button.TabIndex = 7;
            C1button.UseVisualStyleBackColor = true;
            C1button.Click += C1button_Click;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(76, 78);
            label27.Name = "label27";
            label27.Size = new Size(96, 15);
            label27.TabIndex = 22;
            label27.Text = "Image Password:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(53, 96);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.ReadOnly = true;
            passwordTextBox.Size = new Size(146, 23);
            passwordTextBox.TabIndex = 27;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 441);
            Controls.Add(passwordTextBox);
            Controls.Add(groupBox1);
            Controls.Add(label27);
            Controls.Add(nextButton);
            Controls.Add(ClearButton);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private Label label1;
        private Button ClearButton;
        private TextBox textBox1;
        private Label label2;
        private Button nextButton;
        private GroupBox groupBox1;
        private Button B1button;
        private Button A1button;
        private Button C2button;
        private Button A2button;
        private Button B2button;
        private Button A3button;
        private Button B3button;
        private Button C3button;
        private Button A4button;
        private Button B4button;
        private Button C4button;
        private Button D4button;
        private Button D3button;
        private Button D2button;
        private Button D1button;
        private Button C1button;
        private Label label27;
        private TextBox passwordTextBox;
    }
}
