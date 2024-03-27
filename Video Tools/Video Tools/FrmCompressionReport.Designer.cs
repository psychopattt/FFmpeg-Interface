
namespace Video_Tools
{
    partial class FrmCompressionReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompressionReport));
            this.tblReportMain = new System.Windows.Forms.TableLayoutPanel();
            this.txtReportDesc = new System.Windows.Forms.RichTextBox();
            this.lblReportTitle = new System.Windows.Forms.Label();
            this.btnReportClose = new System.Windows.Forms.Button();
            this.tblReportMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblReportMain
            // 
            this.tblReportMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblReportMain.ColumnCount = 1;
            this.tblReportMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblReportMain.Controls.Add(this.txtReportDesc, 0, 1);
            this.tblReportMain.Controls.Add(this.lblReportTitle, 0, 0);
            this.tblReportMain.Controls.Add(this.btnReportClose, 0, 2);
            this.tblReportMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblReportMain.Location = new System.Drawing.Point(0, 0);
            this.tblReportMain.Name = "tblReportMain";
            this.tblReportMain.RowCount = 3;
            this.tblReportMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblReportMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblReportMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblReportMain.Size = new System.Drawing.Size(664, 681);
            this.tblReportMain.TabIndex = 0;
            // 
            // txtReportDesc
            // 
            this.txtReportDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtReportDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReportDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReportDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtReportDesc.Location = new System.Drawing.Point(6, 55);
            this.txtReportDesc.Margin = new System.Windows.Forms.Padding(5, 3, 5, 8);
            this.txtReportDesc.Name = "txtReportDesc";
            this.txtReportDesc.ReadOnly = true;
            this.txtReportDesc.Size = new System.Drawing.Size(652, 516);
            this.txtReportDesc.TabIndex = 6;
            this.txtReportDesc.TabStop = false;
            this.txtReportDesc.Text = "";
            // 
            // lblReportTitle
            // 
            this.lblReportTitle.AutoSize = true;
            this.lblReportTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReportTitle.Font = new System.Drawing.Font("Consolas", 15F);
            this.lblReportTitle.Location = new System.Drawing.Point(4, 1);
            this.lblReportTitle.Name = "lblReportTitle";
            this.lblReportTitle.Size = new System.Drawing.Size(656, 50);
            this.lblReportTitle.TabIndex = 4;
            this.lblReportTitle.Text = "Compression Report";
            this.lblReportTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReportClose
            // 
            this.btnReportClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnReportClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReportClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReportClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnReportClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportClose.Location = new System.Drawing.Point(4, 583);
            this.btnReportClose.Name = "btnReportClose";
            this.btnReportClose.Size = new System.Drawing.Size(656, 94);
            this.btnReportClose.TabIndex = 3;
            this.btnReportClose.Text = "Close";
            this.btnReportClose.UseVisualStyleBackColor = false;
            this.btnReportClose.Click += new System.EventHandler(this.btnReportClose_Click);
            // 
            // FrmCompressionReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CancelButton = this.btnReportClose;
            this.ClientSize = new System.Drawing.Size(664, 681);
            this.Controls.Add(this.tblReportMain);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(300, 400);
            this.Name = "FrmCompressionReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Compression Report";
            this.Load += new System.EventHandler(this.FrmCompressionReport_Load);
            this.tblReportMain.ResumeLayout(false);
            this.tblReportMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblReportMain;
        private System.Windows.Forms.Button btnReportClose;
        private System.Windows.Forms.Label lblReportTitle;
        private System.Windows.Forms.RichTextBox txtReportDesc;
    }
}