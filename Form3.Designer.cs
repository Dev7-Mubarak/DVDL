namespace DVDL
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
            this.components = new System.ComponentModel.Container();
            this.txtPersonID = new System.Windows.Forms.TextBox();
            this.CMFormat = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMChangeColor = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMChangeFont = new System.Windows.Forms.ToolStripMenuItem();
            this.Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.CMFormat.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPersonID
            // 
            this.txtPersonID.ContextMenuStrip = this.CMFormat;
            this.txtPersonID.Location = new System.Drawing.Point(265, 172);
            this.txtPersonID.Name = "txtPersonID";
            this.txtPersonID.Size = new System.Drawing.Size(159, 20);
            this.txtPersonID.TabIndex = 0;
            // 
            // CMFormat
            // 
            this.CMFormat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMChangeColor,
            this.TSMChangeFont,
            this.Clear});
            this.CMFormat.Name = "CMFormat";
            this.CMFormat.Size = new System.Drawing.Size(163, 70);
            // 
            // TSMChangeColor
            // 
            this.TSMChangeColor.Name = "TSMChangeColor";
            this.TSMChangeColor.Size = new System.Drawing.Size(162, 22);
            this.TSMChangeColor.Text = "CheangeColor";
            this.TSMChangeColor.Click += new System.EventHandler(this.TSMChangeColor_Click);
            // 
            // TSMChangeFont
            // 
            this.TSMChangeFont.Name = "TSMChangeFont";
            this.TSMChangeFont.Size = new System.Drawing.Size(162, 22);
            this.TSMChangeFont.Text = "TSMChangeFont";
            this.TSMChangeFont.Click += new System.EventHandler(this.TSMChangeFont_Click);
            // 
            // Clear
            // 
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(162, 22);
            this.Clear.Text = "TSMClear";
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "OpenForm 3";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPersonID);
            this.Name = "Form3";
            this.Text = "Form3";
            this.CMFormat.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPersonID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip CMFormat;
        private System.Windows.Forms.ToolStripMenuItem TSMChangeColor;
        private System.Windows.Forms.ToolStripMenuItem TSMChangeFont;
        private System.Windows.Forms.ToolStripMenuItem Clear;
    }
}