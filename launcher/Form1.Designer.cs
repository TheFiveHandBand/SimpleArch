namespace SimpleArchLauncher
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
            txtGamePath = new TextBox();
            btnBrowse = new Button();
            btnLaunch = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(342, 38);
            label1.TabIndex = 0;
            label1.Text = "Welcome to SimpleArch!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 70);
            label2.Name = "label2";
            label2.Size = new Size(361, 20);
            label2.TabIndex = 1;
            label2.Text = "Please select the folder where your games are stored.";
            label2.Click += label2_Click;
            // 
            // txtGamePath
            // 
            txtGamePath.Location = new Point(20, 120);
            txtGamePath.Name = "txtGamePath";
            txtGamePath.ReadOnly = true;
            txtGamePath.Size = new Size(350, 27);
            txtGamePath.TabIndex = 2;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(380, 118);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(94, 29);
            btnBrowse.TabIndex = 3;
            btnBrowse.Text = "Browse...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnLaunch
            // 
            btnLaunch.Location = new Point(151, 312);
            btnLaunch.Name = "btnLaunch";
            btnLaunch.Size = new Size(201, 29);
            btnLaunch.TabIndex = 4;
            btnLaunch.Text = "Launch SimpleArch";
            btnLaunch.UseVisualStyleBackColor = true;
            btnLaunch.Click += btnLaunch_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 353);
            Controls.Add(btnLaunch);
            Controls.Add(btnBrowse);
            Controls.Add(txtGamePath);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome To SimpleArch";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtGamePath;
        private Button btnBrowse;
        private Button btnLaunch;
    }
}
