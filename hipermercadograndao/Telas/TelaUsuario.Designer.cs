
namespace hipermercadograndao.Telas
{
    partial class TelaUsuario
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
            this.btn_atendente = new System.Windows.Forms.Button();
            this.btn_diretor = new System.Windows.Forms.Button();
            this.btn_gerente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_atendente
            // 
            this.btn_atendente.Location = new System.Drawing.Point(37, 65);
            this.btn_atendente.Name = "btn_atendente";
            this.btn_atendente.Size = new System.Drawing.Size(115, 81);
            this.btn_atendente.TabIndex = 0;
            this.btn_atendente.Text = "Atendente";
            this.btn_atendente.UseVisualStyleBackColor = true;
            this.btn_atendente.Click += new System.EventHandler(this.btn_atendente_Click);
            // 
            // btn_diretor
            // 
            this.btn_diretor.Location = new System.Drawing.Point(179, 65);
            this.btn_diretor.Name = "btn_diretor";
            this.btn_diretor.Size = new System.Drawing.Size(112, 81);
            this.btn_diretor.TabIndex = 1;
            this.btn_diretor.Text = "Diretor";
            this.btn_diretor.UseVisualStyleBackColor = true;
            this.btn_diretor.Click += new System.EventHandler(this.btn_diretor_Click);
            // 
            // btn_gerente
            // 
            this.btn_gerente.Location = new System.Drawing.Point(324, 65);
            this.btn_gerente.Name = "btn_gerente";
            this.btn_gerente.Size = new System.Drawing.Size(112, 81);
            this.btn_gerente.TabIndex = 2;
            this.btn_gerente.Text = "Gerente";
            this.btn_gerente.UseVisualStyleBackColor = true;
            this.btn_gerente.Click += new System.EventHandler(this.btn_gerente_Click);
            // 
            // TelaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 191);
            this.Controls.Add(this.btn_gerente);
            this.Controls.Add(this.btn_diretor);
            this.Controls.Add(this.btn_atendente);
            this.Name = "TelaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_atendente;
        private System.Windows.Forms.Button btn_diretor;
        private System.Windows.Forms.Button btn_gerente;
    }
}