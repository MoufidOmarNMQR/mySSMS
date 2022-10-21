namespace mySSMS
{
    partial class frmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnInvia = new System.Windows.Forms.Button();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.clmNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCognome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTelefono = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbPorte = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnApriChiudi = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // btnInvia
            // 
            this.btnInvia.Location = new System.Drawing.Point(613, 64);
            this.btnInvia.Name = "btnInvia";
            this.btnInvia.Size = new System.Drawing.Size(123, 69);
            this.btnInvia.TabIndex = 0;
            this.btnInvia.Text = "Invia";
            this.btnInvia.UseVisualStyleBackColor = true;
            this.btnInvia.Click += new System.EventHandler(this.btnInvia_Click);
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(176, 76);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(431, 48);
            this.txtQuery.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inserire Query";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmNome,
            this.clmCognome,
            this.clmTelefono});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(50, 171);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(686, 257);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // clmNome
            // 
            this.clmNome.Text = "Nome";
            this.clmNome.Width = 204;
            // 
            // clmCognome
            // 
            this.clmCognome.Text = "Cognome";
            this.clmCognome.Width = 285;
            // 
            // clmTelefono
            // 
            this.clmTelefono.Text = "Telefono";
            this.clmTelefono.Width = 183;
            // 
            // cmbPorte
            // 
            this.cmbPorte.FormattingEnabled = true;
            this.cmbPorte.Location = new System.Drawing.Point(176, 24);
            this.cmbPorte.Name = "cmbPorte";
            this.cmbPorte.Size = new System.Drawing.Size(121, 28);
            this.cmbPorte.TabIndex = 4;
            this.cmbPorte.SelectedIndexChanged += new System.EventHandler(this.cmbPorte_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select Port";
            // 
            // btnApriChiudi
            // 
            this.btnApriChiudi.Location = new System.Drawing.Point(329, 12);
            this.btnApriChiudi.Name = "btnApriChiudi";
            this.btnApriChiudi.Size = new System.Drawing.Size(123, 58);
            this.btnApriChiudi.TabIndex = 6;
            this.btnApriChiudi.Text = "Open";
            this.btnApriChiudi.UseVisualStyleBackColor = true;
            this.btnApriChiudi.Click += new System.EventHandler(this.btnApriChiudi_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnApriChiudi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPorte);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.btnInvia);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInvia;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader clmNome;
        private System.Windows.Forms.ColumnHeader clmCognome;
        private System.Windows.Forms.ColumnHeader clmTelefono;
        private System.Windows.Forms.ComboBox cmbPorte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnApriChiudi;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

