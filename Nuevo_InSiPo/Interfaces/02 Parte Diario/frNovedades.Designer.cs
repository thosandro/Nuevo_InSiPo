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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frNovedades));
            this.dateFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.dateFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btFiltroFecha = new System.Windows.Forms.Button();
            this.opcTurnoNoche = new System.Windows.Forms.RadioButton();
            this.opcTurnoManiana = new System.Windows.Forms.RadioButton();
            this.opcTurnoTarde = new System.Windows.Forms.RadioButton();
            this.dgNovedades = new System.Windows.Forms.DataGridView();
            this.opcDiaCompleto = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgNovedades)).BeginInit();
            this.SuspendLayout();
            // 
            // dateFechaFinal
            // 
            this.dateFechaFinal.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.dateFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaFinal.Location = new System.Drawing.Point(73, 61);
            this.dateFechaFinal.Margin = new System.Windows.Forms.Padding(4);
            this.dateFechaFinal.Name = "dateFechaFinal";
            this.dateFechaFinal.Size = new System.Drawing.Size(157, 23);
            this.dateFechaFinal.TabIndex = 1;
            // 
            // dateFechaInicial
            // 
            this.dateFechaInicial.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.dateFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaInicial.Location = new System.Drawing.Point(73, 30);
            this.dateFechaInicial.Margin = new System.Windows.Forms.Padding(4);
            this.dateFechaInicial.Name = "dateFechaInicial";
            this.dateFechaInicial.Size = new System.Drawing.Size(157, 23);
            this.dateFechaInicial.TabIndex = 2;
            this.dateFechaInicial.Value = new System.DateTime(1999, 3, 23, 13, 26, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hasta:";
            // 
            // btFiltroFecha
            // 
            this.btFiltroFecha.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btFiltroFecha.Location = new System.Drawing.Point(16, 105);
            this.btFiltroFecha.Margin = new System.Windows.Forms.Padding(4);
            this.btFiltroFecha.Name = "btFiltroFecha";
            this.btFiltroFecha.Size = new System.Drawing.Size(214, 30);
            this.btFiltroFecha.TabIndex = 7;
            this.btFiltroFecha.Text = "Aplicar filtro";
            this.btFiltroFecha.UseVisualStyleBackColor = true;
            this.btFiltroFecha.Click += new System.EventHandler(this.btFiltroFecha_Click);
            // 
            // opcTurnoNoche
            // 
            this.opcTurnoNoche.AutoSize = true;
            this.opcTurnoNoche.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.opcTurnoNoche.Location = new System.Drawing.Point(286, 27);
            this.opcTurnoNoche.Margin = new System.Windows.Forms.Padding(4);
            this.opcTurnoNoche.Name = "opcTurnoNoche";
            this.opcTurnoNoche.Size = new System.Drawing.Size(107, 20);
            this.opcTurnoNoche.TabIndex = 8;
            this.opcTurnoNoche.TabStop = true;
            this.opcTurnoNoche.Text = "Turno Noche";
            this.opcTurnoNoche.UseVisualStyleBackColor = true;
            this.opcTurnoNoche.CheckedChanged += new System.EventHandler(this.opcTurnoNoche_CheckedChanged);
            // 
            // opcTurnoManiana
            // 
            this.opcTurnoManiana.AutoSize = true;
            this.opcTurnoManiana.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.opcTurnoManiana.Location = new System.Drawing.Point(286, 56);
            this.opcTurnoManiana.Margin = new System.Windows.Forms.Padding(4);
            this.opcTurnoManiana.Name = "opcTurnoManiana";
            this.opcTurnoManiana.Size = new System.Drawing.Size(120, 20);
            this.opcTurnoManiana.TabIndex = 9;
            this.opcTurnoManiana.TabStop = true;
            this.opcTurnoManiana.Text = "Turno Mañana";
            this.opcTurnoManiana.UseVisualStyleBackColor = true;
            this.opcTurnoManiana.CheckedChanged += new System.EventHandler(this.opcTurnoManiana_CheckedChanged);
            // 
            // opcTurnoTarde
            // 
            this.opcTurnoTarde.AutoSize = true;
            this.opcTurnoTarde.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.opcTurnoTarde.Location = new System.Drawing.Point(286, 85);
            this.opcTurnoTarde.Margin = new System.Windows.Forms.Padding(4);
            this.opcTurnoTarde.Name = "opcTurnoTarde";
            this.opcTurnoTarde.Size = new System.Drawing.Size(102, 20);
            this.opcTurnoTarde.TabIndex = 10;
            this.opcTurnoTarde.TabStop = true;
            this.opcTurnoTarde.Text = "Turno Tarde";
            this.opcTurnoTarde.UseVisualStyleBackColor = true;
            this.opcTurnoTarde.CheckedChanged += new System.EventHandler(this.opcTurnoTarde_CheckedChanged);
            // 
            // dgNovedades
            // 
            this.dgNovedades.AllowUserToAddRows = false;
            this.dgNovedades.AllowUserToDeleteRows = false;
            this.dgNovedades.AllowUserToResizeColumns = false;
            this.dgNovedades.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgNovedades.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgNovedades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgNovedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgNovedades.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgNovedades.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgNovedades.Location = new System.Drawing.Point(0, 166);
            this.dgNovedades.Margin = new System.Windows.Forms.Padding(4);
            this.dgNovedades.MultiSelect = false;
            this.dgNovedades.Name = "dgNovedades";
            this.dgNovedades.ReadOnly = true;
            this.dgNovedades.RowHeadersVisible = false;
            this.dgNovedades.RowHeadersWidth = 90;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.dgNovedades.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgNovedades.RowTemplate.Height = 40;
            this.dgNovedades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgNovedades.ShowEditingIcon = false;
            this.dgNovedades.Size = new System.Drawing.Size(1284, 464);
            this.dgNovedades.TabIndex = 11;
            // 
            // opcDiaCompleto
            // 
            this.opcDiaCompleto.AutoSize = true;
            this.opcDiaCompleto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.opcDiaCompleto.Location = new System.Drawing.Point(286, 114);
            this.opcDiaCompleto.Margin = new System.Windows.Forms.Padding(4);
            this.opcDiaCompleto.Name = "opcDiaCompleto";
            this.opcDiaCompleto.Size = new System.Drawing.Size(114, 20);
            this.opcDiaCompleto.TabIndex = 12;
            this.opcDiaCompleto.TabStop = true;
            this.opcDiaCompleto.Text = "Día Completo";
            this.opcDiaCompleto.UseVisualStyleBackColor = true;
            // 
            // frNovedades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(143)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(1284, 630);
            this.Controls.Add(this.opcDiaCompleto);
            this.Controls.Add(this.dgNovedades);
            this.Controls.Add(this.opcTurnoTarde);
            this.Controls.Add(this.opcTurnoManiana);
            this.Controls.Add(this.opcTurnoNoche);
            this.Controls.Add(this.btFiltroFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateFechaInicial);
            this.Controls.Add(this.dateFechaFinal);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1300, 1270);
            this.Name = "frNovedades";
            this.Text = "Ver reporte";
            this.Load += new System.EventHandler(this.frNovedades_Load);
            this.Resize += new System.EventHandler(this.frNovedades_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgNovedades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateFechaFinal;
        private System.Windows.Forms.DateTimePicker dateFechaInicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btFiltroFecha;
        private System.Windows.Forms.RadioButton opcTurnoNoche;
        private System.Windows.Forms.RadioButton opcTurnoManiana;
        private System.Windows.Forms.RadioButton opcTurnoTarde;
        private System.Windows.Forms.DataGridView dgNovedades;
        private System.Windows.Forms.RadioButton opcDiaCompleto;
    }
}