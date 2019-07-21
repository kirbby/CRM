namespace CRM
{
    partial class FrmContactLog
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firma = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Ansprechperson = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.LetzteAktion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notizen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Channel = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NächsteAktion = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NotizenNächsteAktion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Datum,
            this.Firma,
            this.Ansprechperson,
            this.LetzteAktion,
            this.Notizen,
            this.Channel,
            this.NächsteAktion,
            this.NotizenNächsteAktion});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(939, 602);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(12, 617);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Hinzufügen";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Datum
            // 
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            // 
            // Firma
            // 
            this.Firma.HeaderText = "Firma";
            this.Firma.Name = "Firma";
            this.Firma.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Firma.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Ansprechperson
            // 
            this.Ansprechperson.HeaderText = "Ansprechperson";
            this.Ansprechperson.Name = "Ansprechperson";
            // 
            // LetzteAktion
            // 
            this.LetzteAktion.HeaderText = "LetzteAktion";
            this.LetzteAktion.Name = "LetzteAktion";
            this.LetzteAktion.ReadOnly = true;
            // 
            // Notizen
            // 
            this.Notizen.HeaderText = "Notizen";
            this.Notizen.Name = "Notizen";
            this.Notizen.ReadOnly = true;
            // 
            // Channel
            // 
            this.Channel.HeaderText = "Channel";
            this.Channel.Name = "Channel";
            // 
            // NächsteAktion
            // 
            this.NächsteAktion.HeaderText = "Nächste Aktion";
            this.NächsteAktion.Name = "NächsteAktion";
            // 
            // NotizenNächsteAktion
            // 
            this.NotizenNächsteAktion.HeaderText = "Notizen Nächste Aktion";
            this.NotizenNächsteAktion.Name = "NotizenNächsteAktion";
            // 
            // FrmContactLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 652);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmContactLog";
            this.Text = "FrmContactLog";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewComboBoxColumn Firma;
        private System.Windows.Forms.DataGridViewComboBoxColumn Ansprechperson;
        private System.Windows.Forms.DataGridViewTextBoxColumn LetzteAktion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notizen;
        private System.Windows.Forms.DataGridViewComboBoxColumn Channel;
        private System.Windows.Forms.DataGridViewComboBoxColumn NächsteAktion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotizenNächsteAktion;
        private System.Windows.Forms.Button button1;
    }
}