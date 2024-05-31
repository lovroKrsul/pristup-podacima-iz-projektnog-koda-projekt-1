
namespace Zadatak
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.CbDatabases = new System.Windows.Forms.ComboBox();
            this.sqlCommandLBL = new System.Windows.Forms.Label();
            this.commandTb = new System.Windows.Forms.TextBox();
            this.ResultsLbl = new System.Windows.Forms.Label();
            this.executeBtn = new System.Windows.Forms.Button();
            this.resultsDS = new System.Windows.Forms.DataGridView();
            this.messagesLBL = new System.Windows.Forms.Label();
            this.messagesTB = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Databases:";
            // 
            // CbDatabases
            // 
            this.CbDatabases.FormattingEnabled = true;
            this.CbDatabases.Location = new System.Drawing.Point(87, 25);
            this.CbDatabases.Name = "CbDatabases";
            this.CbDatabases.Size = new System.Drawing.Size(142, 21);
            this.CbDatabases.TabIndex = 1;
            this.CbDatabases.SelectedIndexChanged += new System.EventHandler(this.CbDatabases_SelectedIndexChanged);
            // 
            // sqlCommandLBL
            // 
            this.sqlCommandLBL.AutoSize = true;
            this.sqlCommandLBL.Location = new System.Drawing.Point(12, 90);
            this.sqlCommandLBL.Name = "sqlCommandLBL";
            this.sqlCommandLBL.Size = new System.Drawing.Size(69, 13);
            this.sqlCommandLBL.TabIndex = 2;
            this.sqlCommandLBL.Text = "sql command";
            // 
            // commandTb
            // 
            this.commandTb.Location = new System.Drawing.Point(87, 87);
            this.commandTb.Multiline = true;
            this.commandTb.Name = "commandTb";
            this.commandTb.Size = new System.Drawing.Size(964, 77);
            this.commandTb.TabIndex = 3;
            // 
            // ResultsLbl
            // 
            this.ResultsLbl.AutoSize = true;
            this.ResultsLbl.Location = new System.Drawing.Point(32, 187);
            this.ResultsLbl.Name = "ResultsLbl";
            this.ResultsLbl.Size = new System.Drawing.Size(37, 13);
            this.ResultsLbl.TabIndex = 4;
            this.ResultsLbl.Text = "results";
            // 
            // executeBtn
            // 
            this.executeBtn.Location = new System.Drawing.Point(1057, 90);
            this.executeBtn.Name = "executeBtn";
            this.executeBtn.Size = new System.Drawing.Size(75, 23);
            this.executeBtn.TabIndex = 8;
            this.executeBtn.Text = "execute";
            this.executeBtn.UseVisualStyleBackColor = true;
            this.executeBtn.Click += new System.EventHandler(this.executeBtn_Click);
            // 
            // resultsDS
            // 
            this.resultsDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsDS.Location = new System.Drawing.Point(87, 184);
            this.resultsDS.Name = "resultsDS";
            this.resultsDS.Size = new System.Drawing.Size(1055, 198);
            this.resultsDS.TabIndex = 9;
            // 
            // messagesLBL
            // 
            this.messagesLBL.AutoSize = true;
            this.messagesLBL.Location = new System.Drawing.Point(26, 391);
            this.messagesLBL.Name = "messagesLBL";
            this.messagesLBL.Size = new System.Drawing.Size(54, 13);
            this.messagesLBL.TabIndex = 10;
            this.messagesLBL.Text = "messages";
            // 
            // messagesTB
            // 
            this.messagesTB.Location = new System.Drawing.Point(87, 388);
            this.messagesTB.Name = "messagesTB";
            this.messagesTB.ReadOnly = true;
            this.messagesTB.Size = new System.Drawing.Size(1055, 218);
            this.messagesTB.TabIndex = 11;
            this.messagesTB.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1178, 679);
            this.Controls.Add(this.messagesTB);
            this.Controls.Add(this.messagesLBL);
            this.Controls.Add(this.resultsDS);
            this.Controls.Add(this.executeBtn);
            this.Controls.Add(this.ResultsLbl);
            this.Controls.Add(this.commandTb);
            this.Controls.Add(this.sqlCommandLBL);
            this.Controls.Add(this.CbDatabases);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sql Viewer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.resultsDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbDatabases;
        private System.Windows.Forms.Label sqlCommandLBL;
        private System.Windows.Forms.TextBox commandTb;
        private System.Windows.Forms.Label ResultsLbl;
        private System.Windows.Forms.Button executeBtn;
        private System.Windows.Forms.DataGridView resultsDS;
        private System.Windows.Forms.Label messagesLBL;
        private System.Windows.Forms.RichTextBox messagesTB;
    }
}

