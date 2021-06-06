
namespace hipermercadograndao.Telas
{
    partial class TelaPrincipal
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
            this.lbl_TrocarUsuario = new System.Windows.Forms.Label();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.txt_nomeProduto = new System.Windows.Forms.TextBox();
            this.chb_porkg = new System.Windows.Forms.CheckBox();
            this.lbl_nomeproduto = new System.Windows.Forms.Label();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.rtb_fatura = new System.Windows.Forms.RichTextBox();
            this.cmb_Produtos = new System.Windows.Forms.ComboBox();
            this.nud_valor = new System.Windows.Forms.NumericUpDown();
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.nud_quantidade = new System.Windows.Forms.NumericUpDown();
            this.lbl_quantidade = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_valor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_quantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_TrocarUsuario
            // 
            this.lbl_TrocarUsuario.AutoSize = true;
            this.lbl_TrocarUsuario.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbl_TrocarUsuario.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_TrocarUsuario.Location = new System.Drawing.Point(561, 9);
            this.lbl_TrocarUsuario.Name = "lbl_TrocarUsuario";
            this.lbl_TrocarUsuario.Size = new System.Drawing.Size(145, 30);
            this.lbl_TrocarUsuario.TabIndex = 0;
            this.lbl_TrocarUsuario.Text = "Trocar Usuario";
            this.lbl_TrocarUsuario.Click += new System.EventHandler(this.lbl_TrocarUsuario_Click);
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Usuario.Location = new System.Drawing.Point(17, 14);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(63, 25);
            this.lbl_Usuario.TabIndex = 1;
            this.lbl_Usuario.Text = "Nome";
            // 
            // txt_nomeProduto
            // 
            this.txt_nomeProduto.Location = new System.Drawing.Point(17, 119);
            this.txt_nomeProduto.Name = "txt_nomeProduto";
            this.txt_nomeProduto.Size = new System.Drawing.Size(127, 23);
            this.txt_nomeProduto.TabIndex = 2;
            // 
            // chb_porkg
            // 
            this.chb_porkg.AutoSize = true;
            this.chb_porkg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chb_porkg.Location = new System.Drawing.Point(17, 209);
            this.chb_porkg.Name = "chb_porkg";
            this.chb_porkg.Size = new System.Drawing.Size(102, 25);
            this.chb_porkg.TabIndex = 3;
            this.chb_porkg.Text = "É por Kilo?";
            this.chb_porkg.UseVisualStyleBackColor = true;
            this.chb_porkg.CheckedChanged += new System.EventHandler(this.chb_porkg_CheckedChanged);
            // 
            // lbl_nomeproduto
            // 
            this.lbl_nomeproduto.AutoSize = true;
            this.lbl_nomeproduto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_nomeproduto.Location = new System.Drawing.Point(12, 95);
            this.lbl_nomeproduto.Name = "lbl_nomeproduto";
            this.lbl_nomeproduto.Size = new System.Drawing.Size(113, 21);
            this.lbl_nomeproduto.TabIndex = 4;
            this.lbl_nomeproduto.Text = "Nome produto";
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_valor.Location = new System.Drawing.Point(223, 95);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(106, 21);
            this.lbl_valor.TabIndex = 6;
            this.lbl_valor.Text = "Valor produto";
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(17, 289);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(127, 78);
            this.btn_adicionar.TabIndex = 9;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(356, 373);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(127, 23);
            this.btn_remover.TabIndex = 10;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // rtb_fatura
            // 
            this.rtb_fatura.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtb_fatura.Location = new System.Drawing.Point(356, 92);
            this.rtb_fatura.Name = "rtb_fatura";
            this.rtb_fatura.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rtb_fatura.Size = new System.Drawing.Size(350, 275);
            this.rtb_fatura.TabIndex = 11;
            this.rtb_fatura.Text = "********** GRANDÃO SUPERMECADO **********";
            // 
            // cmb_Produtos
            // 
            this.cmb_Produtos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Produtos.FormattingEnabled = true;
            this.cmb_Produtos.Location = new System.Drawing.Point(17, 373);
            this.cmb_Produtos.Name = "cmb_Produtos";
            this.cmb_Produtos.Size = new System.Drawing.Size(333, 23);
            this.cmb_Produtos.TabIndex = 12;
            // 
            // nud_valor
            // 
            this.nud_valor.DecimalPlaces = 2;
            this.nud_valor.Location = new System.Drawing.Point(223, 119);
            this.nud_valor.Name = "nud_valor";
            this.nud_valor.Size = new System.Drawing.Size(127, 23);
            this.nud_valor.TabIndex = 13;
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.Location = new System.Drawing.Point(223, 289);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(127, 78);
            this.btn_finalizar.TabIndex = 15;
            this.btn_finalizar.Text = "Finalizar Compra";
            this.btn_finalizar.UseVisualStyleBackColor = true;
            this.btn_finalizar.Click += new System.EventHandler(this.btn_finalizar_Click);
            // 
            // nud_quantidade
            // 
            this.nud_quantidade.Location = new System.Drawing.Point(17, 169);
            this.nud_quantidade.Name = "nud_quantidade";
            this.nud_quantidade.Size = new System.Drawing.Size(127, 23);
            this.nud_quantidade.TabIndex = 17;
            // 
            // lbl_quantidade
            // 
            this.lbl_quantidade.AutoSize = true;
            this.lbl_quantidade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_quantidade.Location = new System.Drawing.Point(12, 145);
            this.lbl_quantidade.Name = "lbl_quantidade";
            this.lbl_quantidade.Size = new System.Drawing.Size(91, 21);
            this.lbl_quantidade.TabIndex = 16;
            this.lbl_quantidade.Text = "Quantidade";
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 404);
            this.Controls.Add(this.nud_quantidade);
            this.Controls.Add(this.lbl_quantidade);
            this.Controls.Add(this.btn_finalizar);
            this.Controls.Add(this.nud_valor);
            this.Controls.Add(this.cmb_Produtos);
            this.Controls.Add(this.rtb_fatura);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.lbl_nomeproduto);
            this.Controls.Add(this.chb_porkg);
            this.Controls.Add(this.txt_nomeProduto);
            this.Controls.Add(this.lbl_Usuario);
            this.Controls.Add(this.lbl_TrocarUsuario);
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)(this.nud_valor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_quantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TrocarUsuario;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.TextBox txt_nomeProduto;
        private System.Windows.Forms.CheckBox chb_porkg;
        private System.Windows.Forms.Label lbl_nomeproduto;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.RichTextBox rtb_fatura;
        private System.Windows.Forms.ComboBox cmb_Produtos;
        private System.Windows.Forms.NumericUpDown nud_valor;
        private System.Windows.Forms.Button btn_finalizar;
        private System.Windows.Forms.NumericUpDown nud_quantidade;
        private System.Windows.Forms.Label lbl_quantidade;
    }
}