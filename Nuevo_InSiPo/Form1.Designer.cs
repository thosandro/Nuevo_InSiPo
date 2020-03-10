namespace Nuevo_InSiPo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvTasCampos = new System.Windows.Forms.DataGridView();
            this.dgvSpiderCampos = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnNuevoSpider = new System.Windows.Forms.Button();
            this.btnNuevoTas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasCampos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpiderCampos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTasCampos
            // 
            this.dgvTasCampos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasCampos.Location = new System.Drawing.Point(420, 155);
            this.dgvTasCampos.Name = "dgvTasCampos";
            this.dgvTasCampos.Size = new System.Drawing.Size(368, 285);
            this.dgvTasCampos.TabIndex = 0;
            // 
            // dgvSpiderCampos
            // 
            this.dgvSpiderCampos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpiderCampos.Location = new System.Drawing.Point(12, 155);
            this.dgvSpiderCampos.Name = "dgvSpiderCampos";
            this.dgvSpiderCampos.Size = new System.Drawing.Size(368, 285);
            this.dgvSpiderCampos.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(420, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(368, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Llenar TAS Campos";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(368, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "Llenar SPIDER Campos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNuevoSpider
            // 
            this.btnNuevoSpider.Location = new System.Drawing.Point(12, 115);
            this.btnNuevoSpider.Name = "btnNuevoSpider";
            this.btnNuevoSpider.Size = new System.Drawing.Size(368, 34);
            this.btnNuevoSpider.TabIndex = 5;
            this.btnNuevoSpider.Text = "Agregar nuevo registro";
            this.btnNuevoSpider.UseVisualStyleBackColor = true;
            this.btnNuevoSpider.Click += new System.EventHandler(this.btnNuevoSpider_Click);
            // 
            // btnNuevoTas
            // 
            this.btnNuevoTas.Location = new System.Drawing.Point(420, 115);
            this.btnNuevoTas.Name = "btnNuevoTas";
            this.btnNuevoTas.Size = new System.Drawing.Size(368, 34);
            this.btnNuevoTas.TabIndex = 4;
            this.btnNuevoTas.Text = "Agregar nuevo registro";
            this.btnNuevoTas.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 452);
            this.Controls.Add(this.btnNuevoSpider);
            this.Controls.Add(this.btnNuevoTas);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvSpiderCampos);
            this.Controls.Add(this.dgvTasCampos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasCampos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpiderCampos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTasCampos;
        private System.Windows.Forms.DataGridView dgvSpiderCampos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnNuevoSpider;
        private System.Windows.Forms.Button btnNuevoTas;
    }
}

