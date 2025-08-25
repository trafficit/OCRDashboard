using System;
using System.Drawing;
using System.Windows.Forms;

namespace OCRDashboard
{
    public partial class MainForm : Form
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtInputPath;
        private TextBox txtOutputPath;
        private ComboBox comboFormat;
        private Button btnBrowseInput;
        private Button btnBrowseOutput;
        private Button btnStart;
        private ProgressBar progressBar;
        private Label lblStatus;
        private Label lblFormat;
        private Label lblSignature;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtInputPath = new TextBox();
            txtOutputPath = new TextBox();
            comboFormat = new ComboBox();
            btnBrowseInput = new Button();
            btnBrowseOutput = new Button();
            btnStart = new Button();
            progressBar = new ProgressBar();
            lblStatus = new Label();
            lblFormat = new Label();
            lblSignature = new Label();
            SuspendLayout();
            // 
            // txtInputPath
            // 
            txtInputPath.AllowDrop = true;
            txtInputPath.BackColor = Color.White;
            txtInputPath.Location = new Point(20, 20);
            txtInputPath.Name = "txtInputPath";
            txtInputPath.Size = new Size(400, 30);
            txtInputPath.TabIndex = 0;
            txtInputPath.DragDrop += txtInputPath_DragDrop;
            txtInputPath.DragEnter += txtInputPath_DragEnter;
            // 
            // txtOutputPath
            // 
            txtOutputPath.BackColor = Color.White;
            txtOutputPath.Location = new Point(20, 100);
            txtOutputPath.Name = "txtOutputPath";
            txtOutputPath.Size = new Size(400, 30);
            txtOutputPath.TabIndex = 4;
            // 
            // comboFormat
            // 
            comboFormat.BackColor = Color.White;
            comboFormat.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFormat.Items.AddRange(new object[] { "Text (.txt)", "CSV (.csv)" });
            comboFormat.Location = new Point(126, 62);
            comboFormat.Name = "comboFormat";
            comboFormat.Size = new Size(150, 31);
            comboFormat.TabIndex = 3;
            // 
            // btnBrowseInput
            // 
            btnBrowseInput.BackColor = Color.FromArgb(255, 220, 180);
            btnBrowseInput.FlatStyle = FlatStyle.Flat;
            btnBrowseInput.Location = new Point(430, 20);
            btnBrowseInput.Name = "btnBrowseInput";
            btnBrowseInput.Size = new Size(111, 30);
            btnBrowseInput.TabIndex = 1;
            btnBrowseInput.Text = "Browse...";
            btnBrowseInput.UseVisualStyleBackColor = false;
            btnBrowseInput.Click += btnBrowseInput_Click;
            // 
            // btnBrowseOutput
            // 
            btnBrowseOutput.BackColor = Color.FromArgb(255, 220, 180);
            btnBrowseOutput.FlatStyle = FlatStyle.Flat;
            btnBrowseOutput.Location = new Point(430, 100);
            btnBrowseOutput.Name = "btnBrowseOutput";
            btnBrowseOutput.Size = new Size(111, 30);
            btnBrowseOutput.TabIndex = 5;
            btnBrowseOutput.Text = "Browse...";
            btnBrowseOutput.UseVisualStyleBackColor = false;
            btnBrowseOutput.Click += btnBrowseOutput_Click;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.Orange;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.ForeColor = Color.White;
            btnStart.Location = new Point(150, 189);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(142, 48);
            btnStart.TabIndex = 6;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(20, 160);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(400, 20);
            progressBar.TabIndex = 7;
            // 
            // lblStatus
            // 
            lblStatus.ForeColor = Color.DarkOrange;
            lblStatus.Location = new Point(455, 160);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(100, 20);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Waiting...";
            // 
            // lblFormat
            // 
            lblFormat.ForeColor = Color.DarkOrange;
            lblFormat.Location = new Point(20, 65);
            lblFormat.Name = "lblFormat";
            lblFormat.Size = new Size(100, 23);
            lblFormat.TabIndex = 2;
            lblFormat.Text = "Output Format:";
            // 
            // lblSignature
            // 
            lblSignature.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblSignature.ForeColor = Color.OrangeRed;
            lblSignature.Location = new Point(389, 216);
            lblSignature.Name = "lblSignature";
            lblSignature.Size = new Size(202, 21);
            lblSignature.TabIndex = 9;
            lblSignature.Text = "Made by Alex for KUKA";
            lblSignature.TextAlign = ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            BackColor = Color.FromArgb(255, 245, 230);
            ClientSize = new Size(603, 246);
            Controls.Add(txtInputPath);
            Controls.Add(btnBrowseInput);
            Controls.Add(lblFormat);
            Controls.Add(comboFormat);
            Controls.Add(txtOutputPath);
            Controls.Add(btnBrowseOutput);
            Controls.Add(btnStart);
            Controls.Add(progressBar);
            Controls.Add(lblStatus);
            Controls.Add(lblSignature);
            Font = new Font("Segoe UI", 10F);
            Name = "MainForm";
            Text = "OCR Dashboard shield recognition ";
            ResumeLayout(false);
            PerformLayout();
        }

        // Заглушки для событий
        private void btnBrowseInput_Click(object sender, EventArgs e) { }
        private void btnBrowseOutput_Click(object sender, EventArgs e) { }
        private void btnStart_Click(object sender, EventArgs e) { }
        private void txtInputPath_DragEnter(object sender, DragEventArgs e) => e.Effect = DragDropEffects.Copy;
        private void txtInputPath_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                txtInputPath.Text = files[0];
            }
        }
    }
}
