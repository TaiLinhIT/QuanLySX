namespace QuanLySX
{
    partial class frm_Main
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
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            tblPnlDisplay = new TableLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(837, 57);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(742, 27);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 1;
            label2.Text = "Time";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(329, 15);
            label1.Name = "label1";
            label1.Size = new Size(177, 30);
            label1.TabIndex = 0;
            label1.Text = "OUTPUT DIGITAL";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(tblPnlDisplay);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 57);
            panel2.Name = "panel2";
            panel2.Size = new Size(837, 527);
            panel2.TabIndex = 1;
            // 
            // tblPnlDisplay
            // 
            tblPnlDisplay.BackColor = Color.Black;
            tblPnlDisplay.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tblPnlDisplay.ColumnCount = 7;
            tblPnlDisplay.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857113F));
            tblPnlDisplay.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tblPnlDisplay.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tblPnlDisplay.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tblPnlDisplay.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tblPnlDisplay.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tblPnlDisplay.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tblPnlDisplay.ForeColor = Color.FromArgb(250, 158, 11);
            tblPnlDisplay.Location = new Point(36, 41);
            tblPnlDisplay.Name = "tblPnlDisplay";
            tblPnlDisplay.RowCount = 12;
            tblPnlDisplay.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            tblPnlDisplay.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            tblPnlDisplay.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            tblPnlDisplay.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            tblPnlDisplay.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            tblPnlDisplay.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            tblPnlDisplay.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            tblPnlDisplay.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            tblPnlDisplay.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            tblPnlDisplay.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            tblPnlDisplay.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            tblPnlDisplay.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            tblPnlDisplay.Size = new Size(789, 445);
            tblPnlDisplay.TabIndex = 0;
            // 
            // frm_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 584);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frm_Main";
            Text = "Display";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private TableLayoutPanel tblPnlDisplay;
    }
}
