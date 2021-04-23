
namespace BancaUI
{
    partial class FormBanca
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
            this.textBoxIntestatario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCreaConto = new System.Windows.Forms.Button();
            this.listBoxConti = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownImporto = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCausale = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonVersa = new System.Windows.Forms.Button();
            this.buttonPreleva = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelSaldo = new System.Windows.Forms.Label();
            this.buttonEliminaConto = new System.Windows.Forms.Button();
            this.listBoxOperazioni = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownImporto)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxIntestatario
            // 
            this.textBoxIntestatario.Location = new System.Drawing.Point(21, 39);
            this.textBoxIntestatario.Name = "textBoxIntestatario";
            this.textBoxIntestatario.Size = new System.Drawing.Size(204, 23);
            this.textBoxIntestatario.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Intestatario";
            // 
            // buttonCreaConto
            // 
            this.buttonCreaConto.Location = new System.Drawing.Point(21, 68);
            this.buttonCreaConto.Name = "buttonCreaConto";
            this.buttonCreaConto.Size = new System.Drawing.Size(75, 23);
            this.buttonCreaConto.TabIndex = 2;
            this.buttonCreaConto.Text = "Crea Conto";
            this.buttonCreaConto.UseVisualStyleBackColor = true;
            this.buttonCreaConto.Click += new System.EventHandler(this.buttonCreaConto_Click);
            // 
            // listBoxConti
            // 
            this.listBoxConti.FormattingEnabled = true;
            this.listBoxConti.ItemHeight = 15;
            this.listBoxConti.Location = new System.Drawing.Point(21, 146);
            this.listBoxConti.Name = "listBoxConti";
            this.listBoxConti.Size = new System.Drawing.Size(204, 274);
            this.listBoxConti.TabIndex = 3;
            this.listBoxConti.SelectedIndexChanged += new System.EventHandler(this.listBoxConti_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Conti";
            // 
            // numericUpDownImporto
            // 
            this.numericUpDownImporto.DecimalPlaces = 2;
            this.numericUpDownImporto.Location = new System.Drawing.Point(333, 40);
            this.numericUpDownImporto.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDownImporto.Name = "numericUpDownImporto";
            this.numericUpDownImporto.Size = new System.Drawing.Size(128, 23);
            this.numericUpDownImporto.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Importo";
            // 
            // textBoxCausale
            // 
            this.textBoxCausale.Location = new System.Drawing.Point(467, 40);
            this.textBoxCausale.Name = "textBoxCausale";
            this.textBoxCausale.Size = new System.Drawing.Size(221, 23);
            this.textBoxCausale.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(467, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Causale";
            // 
            // buttonVersa
            // 
            this.buttonVersa.Location = new System.Drawing.Point(333, 69);
            this.buttonVersa.Name = "buttonVersa";
            this.buttonVersa.Size = new System.Drawing.Size(75, 23);
            this.buttonVersa.TabIndex = 9;
            this.buttonVersa.Text = "Versa";
            this.buttonVersa.UseVisualStyleBackColor = true;
            this.buttonVersa.Click += new System.EventHandler(this.buttonVersa_Click);
            // 
            // buttonPreleva
            // 
            this.buttonPreleva.Location = new System.Drawing.Point(414, 69);
            this.buttonPreleva.Name = "buttonPreleva";
            this.buttonPreleva.Size = new System.Drawing.Size(75, 23);
            this.buttonPreleva.TabIndex = 10;
            this.buttonPreleva.Text = "Preleva";
            this.buttonPreleva.UseVisualStyleBackColor = true;
            this.buttonPreleva.Click += new System.EventHandler(this.buttonPreleva_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Saldo";
            // 
            // labelSaldo
            // 
            this.labelSaldo.AutoSize = true;
            this.labelSaldo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSaldo.Location = new System.Drawing.Point(333, 128);
            this.labelSaldo.Name = "labelSaldo";
            this.labelSaldo.Size = new System.Drawing.Size(0, 32);
            this.labelSaldo.TabIndex = 12;
            // 
            // buttonEliminaConto
            // 
            this.buttonEliminaConto.Location = new System.Drawing.Point(231, 397);
            this.buttonEliminaConto.Name = "buttonEliminaConto";
            this.buttonEliminaConto.Size = new System.Drawing.Size(104, 23);
            this.buttonEliminaConto.TabIndex = 13;
            this.buttonEliminaConto.Text = "Elimina Conto";
            this.buttonEliminaConto.UseVisualStyleBackColor = true;
            this.buttonEliminaConto.Click += new System.EventHandler(this.buttonEliminaConto_Click);
            // 
            // listBoxOperazioni
            // 
            this.listBoxOperazioni.FormattingEnabled = true;
            this.listBoxOperazioni.ItemHeight = 15;
            this.listBoxOperazioni.Location = new System.Drawing.Point(333, 163);
            this.listBoxOperazioni.Name = "listBoxOperazioni";
            this.listBoxOperazioni.Size = new System.Drawing.Size(355, 214);
            this.listBoxOperazioni.TabIndex = 14;
            // 
            // FormBanca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 452);
            this.Controls.Add(this.listBoxOperazioni);
            this.Controls.Add(this.buttonEliminaConto);
            this.Controls.Add(this.labelSaldo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonPreleva);
            this.Controls.Add(this.buttonVersa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCausale);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownImporto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxConti);
            this.Controls.Add(this.buttonCreaConto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIntestatario);
            this.Name = "FormBanca";
            this.Text = "Banca";
            this.Load += new System.EventHandler(this.FormBanca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownImporto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIntestatario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCreaConto;
        private System.Windows.Forms.ListBox listBoxConti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownImporto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCausale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonVersa;
        private System.Windows.Forms.Button buttonPreleva;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelSaldo;
        private System.Windows.Forms.Button buttonEliminaConto;
        private System.Windows.Forms.ListBox listBoxOperazioni;
    }
}

