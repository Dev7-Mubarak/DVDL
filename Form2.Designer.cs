namespace DVDL
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.LabForName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmsFormat = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmClear = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnSendDateBack = new System.Windows.Forms.Button();
            this.LabPersonID = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmsFormat.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(677, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "???";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // LabForName
            // 
            this.LabForName.AutoSize = true;
            this.LabForName.BackColor = System.Drawing.SystemColors.Control;
            this.LabForName.Font = new System.Drawing.Font("Tahoma", 16F);
            this.LabForName.ForeColor = System.Drawing.Color.Red;
            this.LabForName.Location = new System.Drawing.Point(630, 414);
            this.LabForName.Name = "LabForName";
            this.LabForName.Size = new System.Drawing.Size(42, 27);
            this.LabForName.TabIndex = 2;
            this.LabForName.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label3.Location = new System.Drawing.Point(678, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // cmsFormat
            // 
            this.cmsFormat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.tsmClear});
            this.cmsFormat.Name = "cmsFormat";
            this.cmsFormat.Size = new System.Drawing.Size(108, 70);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // tsmClear
            // 
            this.tsmClear.Name = "tsmClear";
            this.tsmClear.Size = new System.Drawing.Size(107, 22);
            this.tsmClear.Text = "Clear";
            // 
            // BtnSendDateBack
            // 
            this.BtnSendDateBack.Location = new System.Drawing.Point(512, 171);
            this.BtnSendDateBack.Name = "BtnSendDateBack";
            this.BtnSendDateBack.Size = new System.Drawing.Size(95, 39);
            this.BtnSendDateBack.TabIndex = 6;
            this.BtnSendDateBack.Text = "SendDateBack";
            this.BtnSendDateBack.UseVisualStyleBackColor = true;
            this.BtnSendDateBack.Click += new System.EventHandler(this.BtnSendDateBack_Click);
            // 
            // LabPersonID
            // 
            this.LabPersonID.AutoSize = true;
            this.LabPersonID.Font = new System.Drawing.Font("Tahoma", 14F);
            this.LabPersonID.Location = new System.Drawing.Point(230, 176);
            this.LabPersonID.Name = "LabPersonID";
            this.LabPersonID.Size = new System.Drawing.Size(86, 23);
            this.LabPersonID.TabIndex = 4;
            this.LabPersonID.Text = "PersonID";
            this.LabPersonID.Click += new System.EventHandler(this.LabPersonID_Click);
            // 
            // textBox1
            // 
            this.textBox1.ContextMenuStrip = this.cmsFormat;
            this.textBox1.Location = new System.Drawing.Point(322, 181);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LabPersonID);
            this.Controls.Add(this.BtnSendDateBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LabForName);
            this.Controls.Add(this.label2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.cmsFormat.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabForName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip cmsFormat;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmClear;
        private System.Windows.Forms.Button BtnSendDateBack;
        private System.Windows.Forms.Label LabPersonID;
        private System.Windows.Forms.TextBox textBox1;
    }
}