
namespace hipermercadograndao.Telas
{
    partial class TelaPagamento
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
            this.rtb_fatura = new System.Windows.Forms.RichTextBox();
            this.lbl_valortotal = new System.Windows.Forms.Label();
            this.cmb_Pagamento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.lbl_dinheiro = new System.Windows.Forms.Label();
            this.nud_dinheiro = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nud_dinheiro)).BeginInit();
            this.SuspendLayout();
            // 
            // rtb_fatura
            // 
            this.rtb_fatura.BackColor = System.Drawing.SystemColors.Info;
            this.rtb_fatura.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtb_fatura.Location = new System.Drawing.Point(12, 12);
            this.rtb_fatura.Name = "rtb_fatura";
            this.rtb_fatura.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rtb_fatura.Size = new System.Drawing.Size(350, 275);
            this.rtb_fatura.TabIndex = 12;
            this.rtb_fatura.Text = "********** GRANDÃO SUPERMECADO **********";
            // 
            // lbl_valortotal
            // 
            this.lbl_valortotal.AutoSize = true;
            this.lbl_valortotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_valortotal.Location = new System.Drawing.Point(12, 290);
            this.lbl_valortotal.Name = "lbl_valortotal";
            this.lbl_valortotal.Size = new System.Drawing.Size(105, 25);
            this.lbl_valortotal.TabIndex = 19;
            this.lbl_valortotal.Text = "Valor Total:";
            // 
            // cmb_Pagamento
            // 
            this.cmb_Pagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Pagamento.FormattingEnabled = true;
            this.cmb_Pagamento.Items.AddRange(new object[] {
            "Crédito",
            "Débito",
            "Dinheiro"});
            this.cmb_Pagamento.Location = new System.Drawing.Point(110, 347);
            this.cmb_Pagamento.Name = "cmb_Pagamento";
            this.cmb_Pagamento.Size = new System.Drawing.Size(252, 23);
            this.cmb_Pagamento.TabIndex = 20;
            this.cmb_Pagamento.SelectedIndexChanged += new System.EventHandler(this.cmb_Pagamento_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 42);
            this.label1.TabIndex = 21;
            this.label1.Text = "Forma de \r\npagamento:";
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.Location = new System.Drawing.Point(12, 433);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(126, 45);
            this.btn_finalizar.TabIndex = 22;
            this.btn_finalizar.Text = "Finalizar";
            this.btn_finalizar.UseVisualStyleBackColor = true;
            this.btn_finalizar.Click += new System.EventHandler(this.btn_finalizar_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(236, 433);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(126, 45);
            this.btn_fechar.TabIndex = 23;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // lbl_dinheiro
            // 
            this.lbl_dinheiro.AutoSize = true;
            this.lbl_dinheiro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_dinheiro.Location = new System.Drawing.Point(12, 379);
            this.lbl_dinheiro.Name = "lbl_dinheiro";
            this.lbl_dinheiro.Size = new System.Drawing.Size(73, 42);
            this.lbl_dinheiro.TabIndex = 24;
            this.lbl_dinheiro.Text = "Dinheiro\r\nrecebido:";
            this.lbl_dinheiro.Visible = false;
            // 
            // nud_dinheiro
            // 
            this.nud_dinheiro.DecimalPlaces = 2;
            this.nud_dinheiro.Location = new System.Drawing.Point(110, 398);
            this.nud_dinheiro.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nud_dinheiro.Name = "nud_dinheiro";
            this.nud_dinheiro.Size = new System.Drawing.Size(252, 23);
            this.nud_dinheiro.TabIndex = 25;
            this.nud_dinheiro.Visible = false;
            // 
            // TelaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 490);
            this.Controls.Add(this.nud_dinheiro);
            this.Controls.Add(this.lbl_dinheiro);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_finalizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_Pagamento);
            this.Controls.Add(this.lbl_valortotal);
            this.Controls.Add(this.rtb_fatura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaPagamento";
            ((System.ComponentModel.ISupportInitialize)(this.nud_dinheiro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_fatura;
        private System.Windows.Forms.Label lbl_valortotal;
        private System.Windows.Forms.ComboBox cmb_Pagamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_finalizar;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Label lbl_dinheiro;
        private System.Windows.Forms.NumericUpDown nud_dinheiro;
    }
}