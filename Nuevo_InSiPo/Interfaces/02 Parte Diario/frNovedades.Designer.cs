namespace Nuevo_InSiPo.Interfaces._02_Parte_Diario
{
    partial class frNovedades
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
            this.dgNovedades = new System.Windows.Forms.DataGridView();
            this.dateHasta = new System.Windows.Forms.DateTimePicker();
            this.dateDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbDesde = new System.Windows.Forms.Label();
            this.lbHasta = new System.Windows.Forms.Label();
            this.btFiltroFecha = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgNovedades)).BeginInit();
            this.SuspendLayout();
            // 
            // dgNovedades
            // 
            this.dgNovedades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.dgNovedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNovedades.Location = new System.Drawing.Point(12, 212);
            this.dgNovedades.Name = "dgNovedades";
            this.dgNovedades.Size = new System.Drawing.Size(777, 390);
            this.dgNovedades.TabIndex = 0;
            // 
            // dateHasta
            // 
            this.dateHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateHasta.Location = new System.Drawing.Point(59, 64);
            this.dateHasta.Name = "dateHasta";
            this.dateHasta.Size = new System.Drawing.Size(96, 20);
            this.dateHasta.TabIndex = 1;
            // 
            // dateDesde
            // 
            this.dateDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDesde.Location = new System.Drawing.Point(59, 38);
            this.dateDesde.Name = "dateDesde";
            this.dateDesde.Size = new System.Drawing.Size(96, 20);
            this.dateDesde.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hasta:";
            // 
            // lbDesde
            // 
            this.lbDesde.AutoSize = true;
            this.lbDesde.Location = new System.Drawing.Point(114, 133);
            this.lbDesde.Name = "lbDesde";
            this.lbDesde.Size = new System.Drawing.Size(41, 13);
            this.lbDesde.TabIndex = 5;
            this.lbDesde.Text = "Desde:";
            // 
            // lbHasta
            // 
            this.lbHasta.AutoSize = true;
            this.lbHasta.Location = new System.Drawing.Point(117, 155);
            this.lbHasta.Name = "lbHasta";
            this.lbHasta.Size = new System.Drawing.Size(38, 13);
            this.lbHasta.TabIndex = 6;
            this.lbHasta.Text = "Hasta:";
            // 
            // btFiltroFecha
            // 
            this.btFiltroFecha.Location = new System.Drawing.Point(80, 90);
            this.btFiltroFecha.Name = "btFiltroFecha";
            this.btFiltroFecha.Size = new System.Drawing.Size(75, 23);
            this.btFiltroFecha.TabIndex = 7;
            this.btFiltroFecha.Text = "Aplicar filtro";
            this.btFiltroFecha.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(246, 41);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(246, 68);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(246, 93);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 10;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // frNovedades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 632);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btFiltroFecha);
            this.Controls.Add(this.lbHasta);
            this.Controls.Add(this.lbDesde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateDesde);
            this.Controls.Add(this.dateHasta);
            this.Controls.Add(this.dgNovedades);
            this.Name = "frNovedades";
            this.Text = "frNovedades";
            this.Load += new System.EventHandler(this.frNovedades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgNovedades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgNovedades;
        private System.Windows.Forms.DateTimePicker dateHasta;
        private System.Windows.Forms.DateTimePicker dateDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbDesde;
        private System.Windows.Forms.Label lbHasta;
        private System.Windows.Forms.Button btFiltroFecha;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}