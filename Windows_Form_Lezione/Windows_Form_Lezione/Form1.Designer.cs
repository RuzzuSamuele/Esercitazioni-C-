
namespace Windows_Form_Lezione
{
    partial class Login
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Botton");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Label");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("CheckBox");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Root", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.checkCSHARP = new System.Windows.Forms.CheckBox();
            this.buttonInvia = new System.Windows.Forms.Button();
            this.Bottone_Maschio = new System.Windows.Forms.RadioButton();
            this.Bottone_Femmina = new System.Windows.Forms.RadioButton();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelIndirizzo = new System.Windows.Forms.Label();
            this.TextBox_Nome = new System.Windows.Forms.TextBox();
            this.TextBox_Indirizzo = new System.Windows.Forms.TextBox();
            this.ListaCittà = new System.Windows.Forms.ListBox();
            this.checkASP = new System.Windows.Forms.CheckBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.TextBox_Indirizzo);
            this.GroupBox.Controls.Add(this.TextBox_Nome);
            this.GroupBox.Controls.Add(this.labelIndirizzo);
            this.GroupBox.Controls.Add(this.labelNome);
            this.GroupBox.Location = new System.Drawing.Point(77, 55);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(200, 100);
            this.GroupBox.TabIndex = 0;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "User Details";
            // 
            // checkCSHARP
            // 
            this.checkCSHARP.AutoSize = true;
            this.checkCSHARP.Location = new System.Drawing.Point(194, 295);
            this.checkCSHARP.Name = "checkCSHARP";
            this.checkCSHARP.Size = new System.Drawing.Size(40, 17);
            this.checkCSHARP.TabIndex = 1;
            this.checkCSHARP.Text = "C#";
            this.checkCSHARP.UseVisualStyleBackColor = true;
            // 
            // buttonInvia
            // 
            this.buttonInvia.Location = new System.Drawing.Point(194, 341);
            this.buttonInvia.Name = "buttonInvia";
            this.buttonInvia.Size = new System.Drawing.Size(75, 23);
            this.buttonInvia.TabIndex = 3;
            this.buttonInvia.Text = "Invia";
            this.buttonInvia.UseVisualStyleBackColor = true;
            this.buttonInvia.Click += new System.EventHandler(this.buttonInvia_Click);
            // 
            // Bottone_Maschio
            // 
            this.Bottone_Maschio.AutoSize = true;
            this.Bottone_Maschio.Location = new System.Drawing.Point(300, 77);
            this.Bottone_Maschio.Name = "Bottone_Maschio";
            this.Bottone_Maschio.Size = new System.Drawing.Size(65, 17);
            this.Bottone_Maschio.TabIndex = 4;
            this.Bottone_Maschio.TabStop = true;
            this.Bottone_Maschio.Text = "Maschio";
            this.Bottone_Maschio.UseVisualStyleBackColor = true;
            // 
            // Bottone_Femmina
            // 
            this.Bottone_Femmina.AutoSize = true;
            this.Bottone_Femmina.Location = new System.Drawing.Point(300, 115);
            this.Bottone_Femmina.Name = "Bottone_Femmina";
            this.Bottone_Femmina.Size = new System.Drawing.Size(67, 17);
            this.Bottone_Femmina.TabIndex = 5;
            this.Bottone_Femmina.TabStop = true;
            this.Bottone_Femmina.Text = "Femmina";
            this.Bottone_Femmina.UseVisualStyleBackColor = true;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(16, 26);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            // 
            // labelIndirizzo
            // 
            this.labelIndirizzo.AutoSize = true;
            this.labelIndirizzo.Location = new System.Drawing.Point(16, 60);
            this.labelIndirizzo.Name = "labelIndirizzo";
            this.labelIndirizzo.Size = new System.Drawing.Size(45, 13);
            this.labelIndirizzo.TabIndex = 1;
            this.labelIndirizzo.Text = "Indirizzo";
            // 
            // TextBox_Nome
            // 
            this.TextBox_Nome.Location = new System.Drawing.Point(94, 23);
            this.TextBox_Nome.Name = "TextBox_Nome";
            this.TextBox_Nome.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Nome.TabIndex = 2;
            // 
            // TextBox_Indirizzo
            // 
            this.TextBox_Indirizzo.Location = new System.Drawing.Point(94, 59);
            this.TextBox_Indirizzo.Name = "TextBox_Indirizzo";
            this.TextBox_Indirizzo.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Indirizzo.TabIndex = 3;
            // 
            // ListaCittà
            // 
            this.ListaCittà.FormattingEnabled = true;
            this.ListaCittà.Items.AddRange(new object[] {
            "Torino",
            "Milano",
            "Venezia",
            "Bologna",
            "Roma",
            "Napoli",
            "Bari",
            "Tokyo",
            "Kyoto",
            "Seoul",
            "Hong Kong",
            "Shangai",
            "Bangkok",
            "Londra",
            "Washington",
            "Los Angeles",
            "New York"});
            this.ListaCittà.Location = new System.Drawing.Point(77, 180);
            this.ListaCittà.Name = "ListaCittà";
            this.ListaCittà.Size = new System.Drawing.Size(120, 95);
            this.ListaCittà.TabIndex = 6;
            this.ListaCittà.SelectedIndexChanged += new System.EventHandler(this.ListaCittà_SelectedIndexChanged_1);
            // 
            // checkASP
            // 
            this.checkASP.AutoSize = true;
            this.checkASP.Location = new System.Drawing.Point(194, 318);
            this.checkASP.Name = "checkASP";
            this.checkASP.Size = new System.Drawing.Size(47, 17);
            this.checkASP.TabIndex = 2;
            this.checkASP.Text = "ASP";
            this.checkASP.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(229, 180);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Nodo1";
            treeNode1.Text = "Botton";
            treeNode2.Name = "Nodo3";
            treeNode2.Text = "Label";
            treeNode3.Name = "Nodo4";
            treeNode3.Text = "CheckBox";
            treeNode4.Name = "Nodo0";
            treeNode4.Text = "Root";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.treeView1.Size = new System.Drawing.Size(121, 97);
            this.treeView1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Windows_Form_Lezione.Properties.Resources.Garfield;
            this.pictureBox1.Location = new System.Drawing.Point(373, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 180);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.ListaCittà);
            this.Controls.Add(this.Bottone_Femmina);
            this.Controls.Add(this.Bottone_Maschio);
            this.Controls.Add(this.buttonInvia);
            this.Controls.Add(this.checkASP);
            this.Controls.Add(this.checkCSHARP);
            this.Controls.Add(this.GroupBox);
            this.Name = "Login";
            this.Text = "Login";
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.CheckBox checkCSHARP;
        private System.Windows.Forms.TextBox TextBox_Indirizzo;
        private System.Windows.Forms.TextBox TextBox_Nome;
        private System.Windows.Forms.Label labelIndirizzo;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Button buttonInvia;
        private System.Windows.Forms.RadioButton Bottone_Maschio;
        private System.Windows.Forms.RadioButton Bottone_Femmina;
        private System.Windows.Forms.ListBox ListaCittà;
        private System.Windows.Forms.CheckBox checkASP;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

