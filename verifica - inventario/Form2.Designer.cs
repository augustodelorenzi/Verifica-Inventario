namespace verifica___inventario
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
            this.buttonCanc = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxCF = new System.Windows.Forms.TextBox();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.textBoxCP = new System.Windows.Forms.TextBox();
            this.textBoxProd = new System.Windows.Forms.TextBox();
            this.textBoxQuant = new System.Windows.Forms.TextBox();
            this.textBoxPrz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCanc
            // 
            this.buttonCanc.Location = new System.Drawing.Point(177, 413);
            this.buttonCanc.Name = "buttonCanc";
            this.buttonCanc.Size = new System.Drawing.Size(75, 23);
            this.buttonCanc.TabIndex = 0;
            this.buttonCanc.Text = "Annulla";
            this.buttonCanc.UseVisualStyleBackColor = true;
            this.buttonCanc.Click += new System.EventHandler(this.buttonCanc_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(263, 413);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Salva";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxCF
            // 
            this.textBoxCF.Location = new System.Drawing.Point(134, 21);
            this.textBoxCF.Name = "textBoxCF";
            this.textBoxCF.Size = new System.Drawing.Size(118, 23);
            this.textBoxCF.TabIndex = 2;
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(134, 62);
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(210, 102);
            this.textBoxDesc.TabIndex = 3;
            // 
            // textBoxCP
            // 
            this.textBoxCP.Location = new System.Drawing.Point(134, 181);
            this.textBoxCP.Name = "textBoxCP";
            this.textBoxCP.Size = new System.Drawing.Size(165, 23);
            this.textBoxCP.TabIndex = 4;
            // 
            // textBoxProd
            // 
            this.textBoxProd.Location = new System.Drawing.Point(134, 222);
            this.textBoxProd.Name = "textBoxProd";
            this.textBoxProd.Size = new System.Drawing.Size(165, 23);
            this.textBoxProd.TabIndex = 5;
            // 
            // textBoxQuant
            // 
            this.textBoxQuant.Location = new System.Drawing.Point(134, 264);
            this.textBoxQuant.Name = "textBoxQuant";
            this.textBoxQuant.Size = new System.Drawing.Size(52, 23);
            this.textBoxQuant.TabIndex = 6;
            // 
            // textBoxPrz
            // 
            this.textBoxPrz.Location = new System.Drawing.Point(134, 303);
            this.textBoxPrz.Name = "textBoxPrz";
            this.textBoxPrz.Size = new System.Drawing.Size(52, 23);
            this.textBoxPrz.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Codice Farnell";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Descrizione";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Codice Produttore";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Produttore";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Quantità";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Prezzo";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 448);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPrz);
            this.Controls.Add(this.textBoxQuant);
            this.Controls.Add(this.textBoxProd);
            this.Controls.Add(this.textBoxCP);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.textBoxCF);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCanc);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonCanc;
        private Button buttonSave;
        private TextBox textBoxCF;
        private TextBox textBoxDesc;
        private TextBox textBoxCP;
        private TextBox textBoxProd;
        private TextBox textBoxQuant;
        private TextBox textBoxPrz;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}