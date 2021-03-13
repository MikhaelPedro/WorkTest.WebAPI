
namespace WF_WebAPI
{
    partial class Atualizar
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
            this.buttonCadastar = new System.Windows.Forms.Button();
            this.buttonDeletar = new System.Windows.Forms.Button();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCadastar
            // 
            this.buttonCadastar.Location = new System.Drawing.Point(109, 31);
            this.buttonCadastar.Name = "buttonCadastar";
            this.buttonCadastar.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastar.TabIndex = 0;
            this.buttonCadastar.Text = "Cadastrar";
            this.buttonCadastar.UseVisualStyleBackColor = true;
            this.buttonCadastar.Click += new System.EventHandler(this.buttonCadastar_Click);
            // 
            // buttonDeletar
            // 
            this.buttonDeletar.Location = new System.Drawing.Point(109, 77);
            this.buttonDeletar.Name = "buttonDeletar";
            this.buttonDeletar.Size = new System.Drawing.Size(75, 23);
            this.buttonDeletar.TabIndex = 1;
            this.buttonDeletar.Text = "Deletar";
            this.buttonDeletar.UseVisualStyleBackColor = true;
            this.buttonDeletar.Click += new System.EventHandler(this.buttonDeletar_Click);
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Location = new System.Drawing.Point(109, 176);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(75, 23);
            this.buttonConsultar.TabIndex = 3;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(109, 124);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 4;
            this.buttonUpdate.Text = "Atualizar";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // Atualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 260);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonConsultar);
            this.Controls.Add(this.buttonDeletar);
            this.Controls.Add(this.buttonCadastar);
            this.Name = "Atualizar";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Atualizar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCadastar;
        private System.Windows.Forms.Button buttonDeletar;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.Button buttonUpdate;
    }
}

