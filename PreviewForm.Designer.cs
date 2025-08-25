#nullable disable
namespace OCRDashboard
{
    partial class PreviewForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtPreview;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAutoClear;
        private System.Windows.Forms.Button btnCloseAll;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        /// <summary>
        /// Initialize UI components.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPreview = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAutoClear = new System.Windows.Forms.Button();
            this.btnCloseAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPreview
            // 
            this.txtPreview.Location = new System.Drawing.Point(12, 12);
            this.txtPreview.Multiline = true;
            this.txtPreview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPreview.Size = new System.Drawing.Size(728, 360); // 30% wider than original
            this.txtPreview.ReadOnly = false;
            this.txtPreview.TabIndex = 0;
            this.txtPreview.Font = new System.Drawing.Font("Consolas", 10);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(420, 390);
            this.btnClear.Size = new System.Drawing.Size(100, 30);
            this.btnClear.Text = "Clear";
            this.btnClear.TabIndex = 1;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnAutoClear
            // 
            this.btnAutoClear.Location = new System.Drawing.Point(530, 390);
            this.btnAutoClear.Size = new System.Drawing.Size(100, 30);
            this.btnAutoClear.Text = "AutoClear";
            this.btnAutoClear.TabIndex = 2;
            this.btnAutoClear.UseVisualStyleBackColor = true;
            this.btnAutoClear.Click += new System.EventHandler(this.BtnAutoClear_Click);
            // 
            // btnCloseAll
            // 
            this.btnCloseAll.Location = new System.Drawing.Point(640, 390);
            this.btnCloseAll.Size = new System.Drawing.Size(100, 30);
            this.btnCloseAll.Text = "Close All";
            this.btnCloseAll.TabIndex = 3;
            this.btnCloseAll.UseVisualStyleBackColor = true;
            this.btnCloseAll.Click += new System.EventHandler(this.BtnCloseAll_Click);
            // 
            // PreviewForm
            // 
            this.ClientSize = new System.Drawing.Size(752, 440); // Adjusted for wider layout
            this.Controls.Add(this.txtPreview);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAutoClear);
            this.Controls.Add(this.btnCloseAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PreviewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OCR Preview";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
