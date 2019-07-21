namespace CRM
{
    partial class FrmEditContact
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
            this.Firma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ansprechperson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Umsatz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LetzterKontakt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NächsteAktion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Channel = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Notizen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
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
            this.Firma,
            this.Ansprechperson,
            this.Position,
            this.Telefon,
            this.Email,
            this.Umsatz,
            this.LetzterKontakt,
            this.NächsteAktion,
            this.Status,
            this.Channel,
            this.Notizen});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1149, 627);
            this.dataGridView1.TabIndex = 0;
            // 
            // Firma
            // 
            this.Firma.HeaderText = "Firma";
            this.Firma.Name = "Firma";
            // 
            // Ansprechperson
            // 
            this.Ansprechperson.HeaderText = "Ansprechperson";
            this.Ansprechperson.Name = "Ansprechperson";
            // 
            // Position
            // 
            this.Position.HeaderText = "Position";
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            // 
            // Telefon
            // 
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Umsatz
            // 
            this.Umsatz.HeaderText = "Umsatz";
            this.Umsatz.Name = "Umsatz";
            this.Umsatz.ReadOnly = true;
            // 
            // LetzterKontakt
            // 
            this.LetzterKontakt.HeaderText = "Letzter Kontakt";
            this.LetzterKontakt.Name = "LetzterKontakt";
            // 
            // NächsteAktion
            // 
            this.NächsteAktion.HeaderText = "Nächste Aktion";
            this.NächsteAktion.Name = "NächsteAktion";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Channel
            // 
            this.Channel.HeaderText = "Channel";
            this.Channel.Name = "Channel";
            this.Channel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Channel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Notizen
            // 
            this.Notizen.HeaderText = "Notizen";
            this.Notizen.Name = "Notizen";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(875, 645);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Neuer Kunde";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.Location = new System.Drawing.Point(1003, 645);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Kunde bearbeiten";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button3.Location = new System.Drawing.Point(12, 645);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Neuer Eintrag";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button4.Location = new System.Drawing.Point(198, 645);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Schließen";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FrmEditContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 680);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmEditContact";
            this.Text = "CRM";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ansprechperson;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Umsatz;
        private System.Windows.Forms.DataGridViewTextBoxColumn LetzterKontakt;
        private System.Windows.Forms.DataGridViewTextBoxColumn NächsteAktion;
        private System.Windows.Forms.DataGridViewComboBoxColumn Status;
        private System.Windows.Forms.DataGridViewComboBoxColumn Channel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notizen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}