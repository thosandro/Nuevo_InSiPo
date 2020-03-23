namespace Nuevo_InSiPo.Interfaces
{
    partial class frCargaNovedes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frCargaNovedes));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbET = new System.Windows.Forms.ComboBox();
            this.txtFechaHora = new System.Windows.Forms.MaskedTextBox();
            this.cbEquipo = new System.Windows.Forms.ComboBox();
            this.cbMotivo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbResponsable = new System.Windows.Forms.ComboBox();
            this.txtAP = new System.Windows.Forms.TextBox();
            this.cbCorte = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.opcApertura = new System.Windows.Forms.RadioButton();
            this.opcCierre = new System.Windows.Forms.RadioButton();
            this.groupGeneral = new System.Windows.Forms.GroupBox();
            this.opcApu = new System.Windows.Forms.CheckBox();
            this.groupFalla = new System.Windows.Forms.GroupBox();
            this.opcCierreNegativo = new System.Windows.Forms.RadioButton();
            this.opcRecierrePositivo = new System.Windows.Forms.RadioButton();
            this.opcRecierreNegativo = new System.Windows.Forms.RadioButton();
            this.opcApuFalla = new System.Windows.Forms.CheckBox();
            this.opcDisparo = new System.Windows.Forms.RadioButton();
            this.opcCierreFalla = new System.Windows.Forms.RadioButton();
            this.groupActuaciones = new System.Windows.Forms.GroupBox();
            this.opcInstantanea = new System.Windows.Forms.RadioButton();
            this.opcTemporizada = new System.Windows.Forms.RadioButton();
            this.opcFaseE = new System.Windows.Forms.CheckBox();
            this.opcFaseT = new System.Windows.Forms.CheckBox();
            this.opcFaseS = new System.Windows.Forms.CheckBox();
            this.opcFaseR = new System.Windows.Forms.CheckBox();
            this.opcBuchoolz = new System.Windows.Forms.CheckBox();
            this.opcImpedancia = new System.Windows.Forms.CheckBox();
            this.opcItierra = new System.Windows.Forms.CheckBox();
            this.opcIfase = new System.Windows.Forms.CheckBox();
            this.opcCuba = new System.Windows.Forms.CheckBox();
            this.opcInstantanea_ = new System.Windows.Forms.CheckBox();
            this.opcTemporizada_ = new System.Windows.Forms.CheckBox();
            this.txtActuaciones = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.Label();
            this.txtNombreET = new System.Windows.Forms.Label();
            this.txtNivelTension = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.txtTipoEquipo = new System.Windows.Forms.Label();
            this.txtNombreCampo = new System.Windows.Forms.Label();
            this.txtDescripcionEquipo = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIdEquipo = new System.Windows.Forms.Label();
            this.txtIdMotivo = new System.Windows.Forms.Label();
            this.txtIdResponsable = new System.Windows.Forms.Label();
            this.opcMantenerFecha = new System.Windows.Forms.CheckBox();
            this.txtIdSistema = new System.Windows.Forms.Label();
            this.txtIdET = new System.Windows.Forms.Label();
            this.groupGeneral.SuspendLayout();
            this.groupFalla.SuspendLayout();
            this.groupActuaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.Location = new System.Drawing.Point(40, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha y hora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.Location = new System.Drawing.Point(40, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "E.T.";
            // 
            // cbET
            // 
            this.cbET.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cbET.FormattingEnabled = true;
            this.cbET.Location = new System.Drawing.Point(140, 119);
            this.cbET.Name = "cbET";
            this.cbET.Size = new System.Drawing.Size(133, 24);
            this.cbET.TabIndex = 3;
            this.cbET.SelectedIndexChanged += new System.EventHandler(this.cbET_SelectedIndexChanged);
            this.cbET.TextChanged += new System.EventHandler(this.cbET_TextChanged);
            this.cbET.Leave += new System.EventHandler(this.cbET_Leave);
            // 
            // txtFechaHora
            // 
            this.txtFechaHora.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFechaHora.Location = new System.Drawing.Point(140, 90);
            this.txtFechaHora.Mask = "00/00/00 00:00";
            this.txtFechaHora.Name = "txtFechaHora";
            this.txtFechaHora.Size = new System.Drawing.Size(133, 23);
            this.txtFechaHora.TabIndex = 1;
            // 
            // cbEquipo
            // 
            this.cbEquipo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cbEquipo.FormattingEnabled = true;
            this.cbEquipo.Location = new System.Drawing.Point(140, 150);
            this.cbEquipo.Name = "cbEquipo";
            this.cbEquipo.Size = new System.Drawing.Size(133, 24);
            this.cbEquipo.TabIndex = 4;
            this.cbEquipo.SelectedIndexChanged += new System.EventHandler(this.cbEquipo_SelectedIndexChanged);
            // 
            // cbMotivo
            // 
            this.cbMotivo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cbMotivo.FormattingEnabled = true;
            this.cbMotivo.Location = new System.Drawing.Point(140, 208);
            this.cbMotivo.Name = "cbMotivo";
            this.cbMotivo.Size = new System.Drawing.Size(133, 24);
            this.cbMotivo.TabIndex = 5;
            this.cbMotivo.SelectedIndexChanged += new System.EventHandler(this.cbMotivo_SelectedIndexChanged);
            this.cbMotivo.TextChanged += new System.EventHandler(this.cbMotivo_TextChanged);
            this.cbMotivo.Leave += new System.EventHandler(this.cbMotivo_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label3.Location = new System.Drawing.Point(41, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Equipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label4.Location = new System.Drawing.Point(41, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Motivo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label5.Location = new System.Drawing.Point(41, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Responsable";
            // 
            // cbResponsable
            // 
            this.cbResponsable.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cbResponsable.FormattingEnabled = true;
            this.cbResponsable.Location = new System.Drawing.Point(140, 239);
            this.cbResponsable.Name = "cbResponsable";
            this.cbResponsable.Size = new System.Drawing.Size(240, 24);
            this.cbResponsable.TabIndex = 6;
            // 
            // txtAP
            // 
            this.txtAP.Enabled = false;
            this.txtAP.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAP.Location = new System.Drawing.Point(328, 270);
            this.txtAP.Name = "txtAP";
            this.txtAP.Size = new System.Drawing.Size(51, 23);
            this.txtAP.TabIndex = 14;
            this.txtAP.TabStop = false;
            // 
            // cbCorte
            // 
            this.cbCorte.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cbCorte.FormattingEnabled = true;
            this.cbCorte.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cbCorte.Location = new System.Drawing.Point(139, 270);
            this.cbCorte.Name = "cbCorte";
            this.cbCorte.Size = new System.Drawing.Size(51, 24);
            this.cbCorte.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label6.Location = new System.Drawing.Point(297, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "AP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label7.Location = new System.Drawing.Point(41, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Corte";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDescripcion.Location = new System.Drawing.Point(278, 319);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(234, 144);
            this.txtDescripcion.TabIndex = 123;
            this.txtDescripcion.TabStop = false;
            this.txtDescripcion.Visible = false;
            // 
            // opcApertura
            // 
            this.opcApertura.AutoSize = true;
            this.opcApertura.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.opcApertura.Location = new System.Drawing.Point(15, 22);
            this.opcApertura.Name = "opcApertura";
            this.opcApertura.Size = new System.Drawing.Size(83, 20);
            this.opcApertura.TabIndex = 1;
            this.opcApertura.TabStop = true;
            this.opcApertura.Text = "Apertura";
            this.opcApertura.UseVisualStyleBackColor = true;
            this.opcApertura.CheckedChanged += new System.EventHandler(this.opcApertura_CheckedChanged);
            // 
            // opcCierre
            // 
            this.opcCierre.AutoSize = true;
            this.opcCierre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.opcCierre.Location = new System.Drawing.Point(15, 42);
            this.opcCierre.Name = "opcCierre";
            this.opcCierre.Size = new System.Drawing.Size(64, 20);
            this.opcCierre.TabIndex = 2;
            this.opcCierre.TabStop = true;
            this.opcCierre.Text = "Cierre";
            this.opcCierre.UseVisualStyleBackColor = true;
            this.opcCierre.CheckedChanged += new System.EventHandler(this.opcCierre_CheckedChanged);
            // 
            // groupGeneral
            // 
            this.groupGeneral.Controls.Add(this.opcApu);
            this.groupGeneral.Controls.Add(this.opcApertura);
            this.groupGeneral.Controls.Add(this.opcCierre);
            this.groupGeneral.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupGeneral.Location = new System.Drawing.Point(38, 311);
            this.groupGeneral.Name = "groupGeneral";
            this.groupGeneral.Size = new System.Drawing.Size(234, 152);
            this.groupGeneral.TabIndex = 8;
            this.groupGeneral.TabStop = false;
            this.groupGeneral.Text = " Descripción: ";
            this.groupGeneral.Visible = false;
            // 
            // opcApu
            // 
            this.opcApu.AutoSize = true;
            this.opcApu.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.opcApu.Location = new System.Drawing.Point(35, 62);
            this.opcApu.Name = "opcApu";
            this.opcApu.Size = new System.Drawing.Size(162, 20);
            this.opcApu.TabIndex = 3;
            this.opcApu.Text = "A pedido del usuario";
            this.opcApu.UseVisualStyleBackColor = true;
            this.opcApu.CheckedChanged += new System.EventHandler(this.opcApu_CheckedChanged);
            // 
            // groupFalla
            // 
            this.groupFalla.Controls.Add(this.opcCierreNegativo);
            this.groupFalla.Controls.Add(this.opcRecierrePositivo);
            this.groupFalla.Controls.Add(this.opcRecierreNegativo);
            this.groupFalla.Controls.Add(this.opcApuFalla);
            this.groupFalla.Controls.Add(this.opcDisparo);
            this.groupFalla.Controls.Add(this.opcCierreFalla);
            this.groupFalla.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupFalla.Location = new System.Drawing.Point(15, 333);
            this.groupFalla.Name = "groupFalla";
            this.groupFalla.Size = new System.Drawing.Size(234, 152);
            this.groupFalla.TabIndex = 9;
            this.groupFalla.TabStop = false;
            this.groupFalla.Text = " Descripción ";
            this.groupFalla.Visible = false;
            // 
            // opcCierreNegativo
            // 
            this.opcCierreNegativo.AutoSize = true;
            this.opcCierreNegativo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.opcCierreNegativo.Location = new System.Drawing.Point(15, 103);
            this.opcCierreNegativo.Name = "opcCierreNegativo";
            this.opcCierreNegativo.Size = new System.Drawing.Size(134, 20);
            this.opcCierreNegativo.TabIndex = 5;
            this.opcCierreNegativo.TabStop = true;
            this.opcCierreNegativo.Text = "Intento negativo";
            this.opcCierreNegativo.UseVisualStyleBackColor = true;
            this.opcCierreNegativo.CheckedChanged += new System.EventHandler(this.opcCierreNegativo_CheckedChanged);
            // 
            // opcRecierrePositivo
            // 
            this.opcRecierrePositivo.AutoSize = true;
            this.opcRecierrePositivo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.opcRecierrePositivo.Location = new System.Drawing.Point(15, 42);
            this.opcRecierrePositivo.Name = "opcRecierrePositivo";
            this.opcRecierrePositivo.Size = new System.Drawing.Size(126, 20);
            this.opcRecierrePositivo.TabIndex = 2;
            this.opcRecierrePositivo.TabStop = true;
            this.opcRecierrePositivo.Text = "Recierre exitoso";
            this.opcRecierrePositivo.UseVisualStyleBackColor = true;
            this.opcRecierrePositivo.CheckedChanged += new System.EventHandler(this.opcRecierrePositivo_CheckedChanged);
            // 
            // opcRecierreNegativo
            // 
            this.opcRecierreNegativo.AutoSize = true;
            this.opcRecierreNegativo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.opcRecierreNegativo.Location = new System.Drawing.Point(15, 62);
            this.opcRecierreNegativo.Name = "opcRecierreNegativo";
            this.opcRecierreNegativo.Size = new System.Drawing.Size(139, 20);
            this.opcRecierreNegativo.TabIndex = 3;
            this.opcRecierreNegativo.TabStop = true;
            this.opcRecierreNegativo.Text = "Recierre negativo";
            this.opcRecierreNegativo.UseVisualStyleBackColor = true;
            this.opcRecierreNegativo.CheckedChanged += new System.EventHandler(this.opcRecierreNegativo_CheckedChanged);
            // 
            // opcApuFalla
            // 
            this.opcApuFalla.AutoSize = true;
            this.opcApuFalla.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.opcApuFalla.Location = new System.Drawing.Point(35, 124);
            this.opcApuFalla.Name = "opcApuFalla";
            this.opcApuFalla.Size = new System.Drawing.Size(162, 20);
            this.opcApuFalla.TabIndex = 6;
            this.opcApuFalla.Text = "A pedido del usuario";
            this.opcApuFalla.UseVisualStyleBackColor = true;
            this.opcApuFalla.CheckedChanged += new System.EventHandler(this.opcApuFalla_CheckedChanged);
            // 
            // opcDisparo
            // 
            this.opcDisparo.AutoSize = true;
            this.opcDisparo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.opcDisparo.Location = new System.Drawing.Point(15, 22);
            this.opcDisparo.Name = "opcDisparo";
            this.opcDisparo.Size = new System.Drawing.Size(75, 20);
            this.opcDisparo.TabIndex = 1;
            this.opcDisparo.TabStop = true;
            this.opcDisparo.Text = "Disparo";
            this.opcDisparo.UseVisualStyleBackColor = true;
            this.opcDisparo.CheckedChanged += new System.EventHandler(this.opcDisparo_CheckedChanged);
            // 
            // opcCierreFalla
            // 
            this.opcCierreFalla.AutoSize = true;
            this.opcCierreFalla.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.opcCierreFalla.Location = new System.Drawing.Point(15, 82);
            this.opcCierreFalla.Name = "opcCierreFalla";
            this.opcCierreFalla.Size = new System.Drawing.Size(64, 20);
            this.opcCierreFalla.TabIndex = 4;
            this.opcCierreFalla.TabStop = true;
            this.opcCierreFalla.Text = "Cierre";
            this.opcCierreFalla.UseVisualStyleBackColor = true;
            this.opcCierreFalla.CheckedChanged += new System.EventHandler(this.opcCierreFalla_CheckedChanged);
            // 
            // groupActuaciones
            // 
            this.groupActuaciones.Controls.Add(this.opcInstantanea);
            this.groupActuaciones.Controls.Add(this.opcTemporizada);
            this.groupActuaciones.Controls.Add(this.opcFaseE);
            this.groupActuaciones.Controls.Add(this.opcFaseT);
            this.groupActuaciones.Controls.Add(this.opcFaseS);
            this.groupActuaciones.Controls.Add(this.opcFaseR);
            this.groupActuaciones.Controls.Add(this.opcBuchoolz);
            this.groupActuaciones.Controls.Add(this.opcImpedancia);
            this.groupActuaciones.Controls.Add(this.opcItierra);
            this.groupActuaciones.Controls.Add(this.opcIfase);
            this.groupActuaciones.Controls.Add(this.opcCuba);
            this.groupActuaciones.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupActuaciones.Location = new System.Drawing.Point(38, 491);
            this.groupActuaciones.Name = "groupActuaciones";
            this.groupActuaciones.Size = new System.Drawing.Size(234, 143);
            this.groupActuaciones.TabIndex = 10;
            this.groupActuaciones.TabStop = false;
            this.groupActuaciones.Text = " Actuaciones ";
            this.groupActuaciones.Visible = false;
            // 
            // opcInstantanea
            // 
            this.opcInstantanea.AutoSize = true;
            this.opcInstantanea.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.opcInstantanea.Location = new System.Drawing.Point(59, 22);
            this.opcInstantanea.Name = "opcInstantanea";
            this.opcInstantanea.Size = new System.Drawing.Size(103, 20);
            this.opcInstantanea.TabIndex = 12;
            this.opcInstantanea.TabStop = true;
            this.opcInstantanea.Text = "Instantánea";
            this.opcInstantanea.UseVisualStyleBackColor = true;
            this.opcInstantanea.Visible = false;
            this.opcInstantanea.CheckedChanged += new System.EventHandler(this.opcInstantanea_CheckedChanged_1);
            // 
            // opcTemporizada
            // 
            this.opcTemporizada.AutoSize = true;
            this.opcTemporizada.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.opcTemporizada.Location = new System.Drawing.Point(59, 41);
            this.opcTemporizada.Name = "opcTemporizada";
            this.opcTemporizada.Size = new System.Drawing.Size(110, 20);
            this.opcTemporizada.TabIndex = 11;
            this.opcTemporizada.TabStop = true;
            this.opcTemporizada.Text = "Temporizada";
            this.opcTemporizada.UseVisualStyleBackColor = true;
            this.opcTemporizada.Visible = false;
            this.opcTemporizada.CheckedChanged += new System.EventHandler(this.opcTemporizada_CheckedChanged_1);
            // 
            // opcFaseE
            // 
            this.opcFaseE.AutoSize = true;
            this.opcFaseE.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.opcFaseE.Location = new System.Drawing.Point(177, 70);
            this.opcFaseE.Name = "opcFaseE";
            this.opcFaseE.Size = new System.Drawing.Size(34, 20);
            this.opcFaseE.TabIndex = 8;
            this.opcFaseE.Tag = "4";
            this.opcFaseE.Text = "E";
            this.opcFaseE.UseVisualStyleBackColor = true;
            this.opcFaseE.Visible = false;
            this.opcFaseE.CheckedChanged += new System.EventHandler(this.opcFaseE_CheckedChanged);
            // 
            // opcFaseT
            // 
            this.opcFaseT.AutoSize = true;
            this.opcFaseT.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.opcFaseT.Location = new System.Drawing.Point(139, 70);
            this.opcFaseT.Name = "opcFaseT";
            this.opcFaseT.Size = new System.Drawing.Size(32, 20);
            this.opcFaseT.TabIndex = 7;
            this.opcFaseT.Tag = "3";
            this.opcFaseT.Text = "T";
            this.opcFaseT.UseVisualStyleBackColor = true;
            this.opcFaseT.Visible = false;
            this.opcFaseT.CheckedChanged += new System.EventHandler(this.opcFaseT_CheckedChanged);
            // 
            // opcFaseS
            // 
            this.opcFaseS.AutoSize = true;
            this.opcFaseS.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.opcFaseS.Location = new System.Drawing.Point(100, 70);
            this.opcFaseS.Name = "opcFaseS";
            this.opcFaseS.Size = new System.Drawing.Size(33, 20);
            this.opcFaseS.TabIndex = 6;
            this.opcFaseS.Tag = "2";
            this.opcFaseS.Text = "S";
            this.opcFaseS.UseVisualStyleBackColor = true;
            this.opcFaseS.Visible = false;
            this.opcFaseS.CheckedChanged += new System.EventHandler(this.opcFaseS_CheckedChanged);
            // 
            // opcFaseR
            // 
            this.opcFaseR.AutoSize = true;
            this.opcFaseR.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.opcFaseR.Location = new System.Drawing.Point(59, 70);
            this.opcFaseR.Name = "opcFaseR";
            this.opcFaseR.Size = new System.Drawing.Size(35, 20);
            this.opcFaseR.TabIndex = 5;
            this.opcFaseR.Tag = "1";
            this.opcFaseR.Text = "R";
            this.opcFaseR.UseVisualStyleBackColor = true;
            this.opcFaseR.Visible = false;
            this.opcFaseR.CheckedChanged += new System.EventHandler(this.opcFaseR_CheckedChanged);
            // 
            // opcBuchoolz
            // 
            this.opcBuchoolz.AutoSize = true;
            this.opcBuchoolz.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.opcBuchoolz.Location = new System.Drawing.Point(6, 110);
            this.opcBuchoolz.Name = "opcBuchoolz";
            this.opcBuchoolz.Size = new System.Drawing.Size(84, 20);
            this.opcBuchoolz.TabIndex = 10;
            this.opcBuchoolz.Text = "Buchholz";
            this.opcBuchoolz.UseVisualStyleBackColor = true;
            this.opcBuchoolz.CheckedChanged += new System.EventHandler(this.opcBuchoolz_CheckedChanged);
            // 
            // opcImpedancia
            // 
            this.opcImpedancia.AutoSize = true;
            this.opcImpedancia.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.opcImpedancia.Location = new System.Drawing.Point(6, 70);
            this.opcImpedancia.Name = "opcImpedancia";
            this.opcImpedancia.Size = new System.Drawing.Size(41, 20);
            this.opcImpedancia.TabIndex = 4;
            this.opcImpedancia.Tag = "0";
            this.opcImpedancia.Text = "RZ";
            this.opcImpedancia.UseVisualStyleBackColor = true;
            this.opcImpedancia.CheckedChanged += new System.EventHandler(this.opcImpedancia_CheckedChanged);
            // 
            // opcItierra
            // 
            this.opcItierra.AutoSize = true;
            this.opcItierra.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.opcItierra.Location = new System.Drawing.Point(6, 42);
            this.opcItierra.Name = "opcItierra";
            this.opcItierra.Size = new System.Drawing.Size(47, 20);
            this.opcItierra.TabIndex = 2;
            this.opcItierra.Text = "Io>";
            this.opcItierra.UseVisualStyleBackColor = true;
            this.opcItierra.CheckedChanged += new System.EventHandler(this.opcItierra_CheckedChanged);
            // 
            // opcIfase
            // 
            this.opcIfase.AutoSize = true;
            this.opcIfase.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.opcIfase.Location = new System.Drawing.Point(6, 22);
            this.opcIfase.Name = "opcIfase";
            this.opcIfase.Size = new System.Drawing.Size(38, 20);
            this.opcIfase.TabIndex = 1;
            this.opcIfase.Text = "I>";
            this.opcIfase.UseVisualStyleBackColor = true;
            this.opcIfase.CheckedChanged += new System.EventHandler(this.opcIfase_CheckedChanged);
            // 
            // opcCuba
            // 
            this.opcCuba.AutoSize = true;
            this.opcCuba.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.opcCuba.Location = new System.Drawing.Point(6, 90);
            this.opcCuba.Name = "opcCuba";
            this.opcCuba.Size = new System.Drawing.Size(64, 20);
            this.opcCuba.TabIndex = 9;
            this.opcCuba.Text = "Cuba";
            this.opcCuba.UseVisualStyleBackColor = true;
            this.opcCuba.CheckedChanged += new System.EventHandler(this.opcCuba_CheckedChanged);
            // 
            // opcInstantanea_
            // 
            this.opcInstantanea_.AutoSize = true;
            this.opcInstantanea_.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.opcInstantanea_.Location = new System.Drawing.Point(435, 269);
            this.opcInstantanea_.Name = "opcInstantanea_";
            this.opcInstantanea_.Size = new System.Drawing.Size(104, 20);
            this.opcInstantanea_.TabIndex = 11;
            this.opcInstantanea_.Text = "Instantánea";
            this.opcInstantanea_.UseVisualStyleBackColor = true;
            this.opcInstantanea_.Visible = false;
            // 
            // opcTemporizada_
            // 
            this.opcTemporizada_.AutoSize = true;
            this.opcTemporizada_.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.opcTemporizada_.Location = new System.Drawing.Point(435, 249);
            this.opcTemporizada_.Name = "opcTemporizada_";
            this.opcTemporizada_.Size = new System.Drawing.Size(111, 20);
            this.opcTemporizada_.TabIndex = 3;
            this.opcTemporizada_.Text = "Temporizada";
            this.opcTemporizada_.UseVisualStyleBackColor = true;
            this.opcTemporizada_.Visible = false;
            // 
            // txtActuaciones
            // 
            this.txtActuaciones.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtActuaciones.Location = new System.Drawing.Point(278, 499);
            this.txtActuaciones.Multiline = true;
            this.txtActuaciones.Name = "txtActuaciones";
            this.txtActuaciones.ReadOnly = true;
            this.txtActuaciones.Size = new System.Drawing.Size(234, 121);
            this.txtActuaciones.TabIndex = 124;
            this.txtActuaciones.TabStop = false;
            this.txtActuaciones.Text = "Sin señalización.";
            this.txtActuaciones.Visible = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(518, 692);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(35, 35);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Tag = "btnGuardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Century Gothic", 23F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(56, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(457, 39);
            this.label8.TabIndex = 29;
            this.label8.Text = "Carga de Novedades";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMotivo
            // 
            this.txtMotivo.AutoSize = true;
            this.txtMotivo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMotivo.Location = new System.Drawing.Point(279, 211);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(78, 16);
            this.txtMotivo.TabIndex = 30;
            this.txtMotivo.Text = "< Motivo >";
            // 
            // txtNombreET
            // 
            this.txtNombreET.AutoSize = true;
            this.txtNombreET.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNombreET.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNombreET.Location = new System.Drawing.Point(278, 122);
            this.txtNombreET.Name = "txtNombreET";
            this.txtNombreET.Size = new System.Drawing.Size(101, 16);
            this.txtNombreET.TabIndex = 31;
            this.txtNombreET.Text = "< Nombre ET >";
            this.txtNombreET.UseMnemonic = false;
            // 
            // txtNivelTension
            // 
            this.txtNivelTension.AutoSize = true;
            this.txtNivelTension.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNivelTension.Location = new System.Drawing.Point(679, 158);
            this.txtNivelTension.Name = "txtNivelTension";
            this.txtNivelTension.Size = new System.Drawing.Size(83, 16);
            this.txtNivelTension.TabIndex = 32;
            this.txtNivelTension.Text = "< Campo >";
            this.txtNivelTension.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtNivelTension.TextChanged += new System.EventHandler(this.txtTipoEquipo_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(42, 637);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 16);
            this.label9.TabIndex = 33;
            this.label9.Text = "Observaciones";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtObservaciones.Location = new System.Drawing.Point(38, 657);
            this.txtObservaciones.MaxLength = 10000;
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(474, 70);
            this.txtObservaciones.TabIndex = 11;
            // 
            // txtTipoEquipo
            // 
            this.txtTipoEquipo.AutoSize = true;
            this.txtTipoEquipo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTipoEquipo.Location = new System.Drawing.Point(588, 178);
            this.txtTipoEquipo.Name = "txtTipoEquipo";
            this.txtTipoEquipo.Size = new System.Drawing.Size(103, 16);
            this.txtTipoEquipo.TabIndex = 35;
            this.txtTipoEquipo.Text = "< tipoEquipo >";
            this.txtTipoEquipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtTipoEquipo.TextChanged += new System.EventHandler(this.txtTipoEquipo_TextChanged);
            // 
            // txtNombreCampo
            // 
            this.txtNombreCampo.AutoSize = true;
            this.txtNombreCampo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNombreCampo.Location = new System.Drawing.Point(697, 178);
            this.txtNombreCampo.Name = "txtNombreCampo";
            this.txtNombreCampo.Size = new System.Drawing.Size(134, 16);
            this.txtNombreCampo.TabIndex = 36;
            this.txtNombreCampo.Text = "< nombreCampo >";
            this.txtNombreCampo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtNombreCampo.TextChanged += new System.EventHandler(this.txtTipoEquipo_TextChanged);
            // 
            // txtDescripcionEquipo
            // 
            this.txtDescripcionEquipo.AutoSize = true;
            this.txtDescripcionEquipo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDescripcionEquipo.Location = new System.Drawing.Point(137, 178);
            this.txtDescripcionEquipo.Name = "txtDescripcionEquipo";
            this.txtDescripcionEquipo.Size = new System.Drawing.Size(156, 16);
            this.txtDescripcionEquipo.TabIndex = 37;
            this.txtDescripcionEquipo.Text = "< Descripcion Equipo >";
            this.txtDescripcionEquipo.UseMnemonic = false;
            this.txtDescripcionEquipo.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(399, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(174, 16);
            this.label10.TabIndex = 38;
            this.label10.Text = "¡Hay cosas ocultas >>>>>";
            this.label10.UseMnemonic = false;
            this.label10.Visible = false;
            // 
            // txtIdEquipo
            // 
            this.txtIdEquipo.AutoSize = true;
            this.txtIdEquipo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtIdEquipo.Location = new System.Drawing.Point(588, 158);
            this.txtIdEquipo.Name = "txtIdEquipo";
            this.txtIdEquipo.Size = new System.Drawing.Size(85, 16);
            this.txtIdEquipo.TabIndex = 39;
            this.txtIdEquipo.Text = "< idEquipo>";
            this.txtIdEquipo.UseMnemonic = false;
            // 
            // txtIdMotivo
            // 
            this.txtIdMotivo.AutoSize = true;
            this.txtIdMotivo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtIdMotivo.Location = new System.Drawing.Point(590, 211);
            this.txtIdMotivo.Name = "txtIdMotivo";
            this.txtIdMotivo.Size = new System.Drawing.Size(86, 16);
            this.txtIdMotivo.TabIndex = 40;
            this.txtIdMotivo.Text = "< idMotivo>";
            this.txtIdMotivo.UseMnemonic = false;
            // 
            // txtIdResponsable
            // 
            this.txtIdResponsable.AutoSize = true;
            this.txtIdResponsable.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtIdResponsable.Location = new System.Drawing.Point(590, 242);
            this.txtIdResponsable.Name = "txtIdResponsable";
            this.txtIdResponsable.Size = new System.Drawing.Size(117, 16);
            this.txtIdResponsable.TabIndex = 41;
            this.txtIdResponsable.Text = "<idResponsable>";
            this.txtIdResponsable.UseMnemonic = false;
            // 
            // opcMantenerFecha
            // 
            this.opcMantenerFecha.AutoSize = true;
            this.opcMantenerFecha.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.opcMantenerFecha.Location = new System.Drawing.Point(282, 92);
            this.opcMantenerFecha.Name = "opcMantenerFecha";
            this.opcMantenerFecha.Size = new System.Drawing.Size(130, 20);
            this.opcMantenerFecha.TabIndex = 2;
            this.opcMantenerFecha.Text = "Mantener fecha";
            this.opcMantenerFecha.UseVisualStyleBackColor = true;
            // 
            // txtIdSistema
            // 
            this.txtIdSistema.AutoSize = true;
            this.txtIdSistema.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtIdSistema.Location = new System.Drawing.Point(648, 122);
            this.txtIdSistema.Name = "txtIdSistema";
            this.txtIdSistema.Size = new System.Drawing.Size(89, 16);
            this.txtIdSistema.TabIndex = 126;
            this.txtIdSistema.Text = "< idSistema>";
            this.txtIdSistema.UseMnemonic = false;
            // 
            // txtIdET
            // 
            this.txtIdET.AutoSize = true;
            this.txtIdET.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtIdET.Location = new System.Drawing.Point(590, 122);
            this.txtIdET.Name = "txtIdET";
            this.txtIdET.Size = new System.Drawing.Size(52, 16);
            this.txtIdET.TabIndex = 125;
            this.txtIdET.Text = "< idET>";
            this.txtIdET.UseMnemonic = false;
            // 
            // frCargaNovedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(143)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(569, 745);
            this.Controls.Add(this.opcInstantanea_);
            this.Controls.Add(this.txtIdSistema);
            this.Controls.Add(this.txtIdET);
            this.Controls.Add(this.opcMantenerFecha);
            this.Controls.Add(this.txtIdResponsable);
            this.Controls.Add(this.opcTemporizada_);
            this.Controls.Add(this.txtIdMotivo);
            this.Controls.Add(this.groupFalla);
            this.Controls.Add(this.txtIdEquipo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDescripcionEquipo);
            this.Controls.Add(this.txtNombreCampo);
            this.Controls.Add(this.txtTipoEquipo);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNivelTension);
            this.Controls.Add(this.txtNombreET);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtActuaciones);
            this.Controls.Add(this.groupActuaciones);
            this.Controls.Add(this.groupGeneral);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbCorte);
            this.Controls.Add(this.txtAP);
            this.Controls.Add(this.cbResponsable);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbMotivo);
            this.Controls.Add(this.cbEquipo);
            this.Controls.Add(this.txtFechaHora);
            this.Controls.Add(this.cbET);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frCargaNovedes";
            this.Text = "Carga de Novedades";
            this.Load += new System.EventHandler(this.frCargaNovedes_Load);
            this.groupGeneral.ResumeLayout(false);
            this.groupGeneral.PerformLayout();
            this.groupFalla.ResumeLayout(false);
            this.groupFalla.PerformLayout();
            this.groupActuaciones.ResumeLayout(false);
            this.groupActuaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbET;
        private System.Windows.Forms.MaskedTextBox txtFechaHora;
        private System.Windows.Forms.ComboBox cbEquipo;
        private System.Windows.Forms.ComboBox cbMotivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbResponsable;
        private System.Windows.Forms.TextBox txtAP;
        private System.Windows.Forms.ComboBox cbCorte;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.RadioButton opcApertura;
        private System.Windows.Forms.RadioButton opcCierre;
        private System.Windows.Forms.GroupBox groupGeneral;
        private System.Windows.Forms.GroupBox groupFalla;
        private System.Windows.Forms.RadioButton opcRecierrePositivo;
        private System.Windows.Forms.RadioButton opcRecierreNegativo;
        private System.Windows.Forms.CheckBox opcApuFalla;
        private System.Windows.Forms.RadioButton opcDisparo;
        private System.Windows.Forms.RadioButton opcCierreFalla;
        private System.Windows.Forms.CheckBox opcApu;
        private System.Windows.Forms.GroupBox groupActuaciones;
        private System.Windows.Forms.CheckBox opcCuba;
        private System.Windows.Forms.TextBox txtActuaciones;
        private System.Windows.Forms.CheckBox opcBuchoolz;
        private System.Windows.Forms.CheckBox opcImpedancia;
        private System.Windows.Forms.CheckBox opcItierra;
        private System.Windows.Forms.CheckBox opcIfase;
        private System.Windows.Forms.CheckBox opcFaseE;
        private System.Windows.Forms.CheckBox opcFaseT;
        private System.Windows.Forms.CheckBox opcFaseS;
        private System.Windows.Forms.CheckBox opcFaseR;
        private System.Windows.Forms.CheckBox opcTemporizada_;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton opcCierreNegativo;
        private System.Windows.Forms.Label txtMotivo;
        private System.Windows.Forms.Label txtNombreET;
        private System.Windows.Forms.Label txtNivelTension;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label txtTipoEquipo;
        private System.Windows.Forms.Label txtNombreCampo;
        private System.Windows.Forms.Label txtDescripcionEquipo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label txtIdEquipo;
        private System.Windows.Forms.Label txtIdMotivo;
        private System.Windows.Forms.Label txtIdResponsable;
        private System.Windows.Forms.CheckBox opcMantenerFecha;
        private System.Windows.Forms.Label txtIdSistema;
        private System.Windows.Forms.Label txtIdET;
        private System.Windows.Forms.CheckBox opcInstantanea_;
        private System.Windows.Forms.RadioButton opcInstantanea;
        private System.Windows.Forms.RadioButton opcTemporizada;
    }
}