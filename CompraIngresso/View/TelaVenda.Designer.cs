namespace CompraIngresso.View
{
    partial class TelaVenda
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
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResul = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Venda de Ingresso Online";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(183, 100);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(159, 23);
            this.txtQuantidade.TabIndex = 1;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(183, 148);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(159, 23);
            this.txtValor.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantidade de Ingresso:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor:";
            // 
            // lblResul
            // 
            this.lblResul.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblResul.Location = new System.Drawing.Point(42, 226);
            this.lblResul.Name = "lblResul";
            this.lblResul.Size = new System.Drawing.Size(300, 198);
            this.lblResul.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TelaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblResul);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "TelaVenda";
            this.Text = "Venda de Ingresso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtQuantidade;
        private TextBox txtValor;
        private Label label2;
        private Label label3;
        private Label lblResul;
        private Button button1;
    }
}