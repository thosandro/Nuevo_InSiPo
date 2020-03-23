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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.dateFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btFiltroFecha = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.dgNovedades = new System.Windows.Forms.DataGridView();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgNovedades)).BeginInit();
            this.SuspendLayout();
            // 
            // dateFechaFinal
            // 
            this.dateFechaFinal.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.dateFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaFinal.Location = new System.Drawing.Point(76, 84);
            this.dateFechaFinal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateFechaFinal.Name = "dateFechaFinal";
            this.dateFechaFinal.Size = new System.Drawing.Size(157, 23);
            this.dateFechaFinal.TabIndex = 1;
            // 
            // dateFechaInicial
            // 
            this.dateFechaInicial.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.dateFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaInicial.Location = new System.Drawing.Point(76, 53);
            this.dateFechaInicial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateFechaInicial.Name = "dateFechaInicial";
            this.dateFechaInicial.Size = new System.Drawing.Size(157, 23);
            this.dateFechaInicial.TabIndex = 2;
            this.dateFechaInicial.Value = new System.DateTime(1999, 3, 23, 13, 26, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.Location = new System.Drawing.Point(16, 58);
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
            this.label2.Location = new System.Drawing.Point(16, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hasta:";
            // 
            // btFiltroFecha
            // 
            this.btFiltroFecha.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btFiltroFecha.Location = new System.Drawing.Point(19, 115);
            this.btFiltroFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btFiltroFecha.Name = "btFiltroFecha";
            this.btFiltroFecha.Size = new System.Drawing.Size(214, 30);
            this.btFiltroFecha.TabIndex = 7;
            this.btFiltroFecha.Text = "Aplicar filtro";
            this.btFiltroFecha.UseVisualStyleBackColor = true;
            this.btFiltroFecha.Click += new System.EventHandler(this.btFiltroFecha_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.radioButton1.Location = new System.Drawing.Point(289, 50);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(109, 21);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.radioButton2.Location = new System.Drawing.Point(289, 79);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(109, 21);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.radioButton3.Location = new System.Drawing.Point(289, 108);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(109, 21);
            this.radioButton3.TabIndex = 10;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // dgNovedades
            // 
            this.dgNovedades.AllowUserToAddRows = false;
            this.dgNovedades.AllowUserToDeleteRows = false;
            this.dgNovedades.AllowUserToResizeColumns = false;
            this.dgNovedades.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgNovedades.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgNovedades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgNovedades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgNovedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgNovedades.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgNovedades.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgNovedades.Location = new System.Drawing.Point(0, 180);
            this.dgNovedades.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgNovedades.MultiSelect = false;
            this.dgNovedades.Name = "dgNovedades";
            this.dgNovedades.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgNovedades.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgNovedades.RowHeadersWidth = 80;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgNovedades.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgNovedades.RowTemplate.Height = 40;
            this.dgNovedades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgNovedades.ShowEditingIcon = false;
            this.dgNovedades.Size = new System.Drawing.Size(1131, 464);
            this.dgNovedades.TabIndex = 11;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.radioButton4.Location = new System.Drawing.Point(289, 137);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(109, 21);
            this.radioButton4.TabIndex = 12;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // frNovedades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 644);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.dgNovedades);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btFiltroFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateFechaInicial);
            this.Controls.Add(this.dateFechaFinal);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frNovedades";
            this.Text = "frNovedades";
            this.Load += new System.EventHandler(this.frNovedades_Load);
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
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.DataGridView dgNovedades;
        private System.Windows.Forms.RadioButton radioButton4;
    }
}