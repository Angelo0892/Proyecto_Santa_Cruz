namespace ACTIVOS_FIJOS.Views
{
    /*partial class DepreciacionForm
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "DepreciacionForm";
        }

        #endregion
    }*/

    partial class DepreciacionForm
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtVidaUtil_ = new System.Windows.Forms.TextBox();
            this.txtNumeroDepreciaciones_ = new System.Windows.Forms.TextBox();
            this.txtValoResidual_ = new System.Windows.Forms.TextBox();
            this.txtValorDepreciacion_ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValorAdquisicion_ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtActivoID_ = new System.Windows.Forms.TextBox();
            this.dtpFechaAdquisicion_ = new System.Windows.Forms.DateTimePicker();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRegistrarDepreciacion = new System.Windows.Forms.Button();
            this.txtNombreActivo_ = new System.Windows.Forms.TextBox();
            this.textCodigoActivoFijo_ = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewActivos = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActivos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(960, 550);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(952, 524);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "DEPRECIAR ACTIVO FIJO";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtVidaUtil_);
            this.groupBox3.Controls.Add(this.txtNumeroDepreciaciones_);
            this.groupBox3.Controls.Add(this.txtValoResidual_);
            this.groupBox3.Controls.Add(this.txtValorDepreciacion_);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtValorAdquisicion_);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtActivoID_);
            this.groupBox3.Controls.Add(this.dtpFechaAdquisicion_);
            this.groupBox3.Controls.Add(this.txtObservaciones);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnRegistrarDepreciacion);
            this.groupBox3.Controls.Add(this.txtNombreActivo_);
            this.groupBox3.Controls.Add(this.textCodigoActivoFijo_);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(684, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(232, 499);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DEPRECIAR";
            // 
            // txtVidaUtil_
            // 
            this.txtVidaUtil_.Location = new System.Drawing.Point(149, 139);
            this.txtVidaUtil_.Name = "txtVidaUtil_";
            this.txtVidaUtil_.Size = new System.Drawing.Size(67, 20);
            this.txtVidaUtil_.TabIndex = 21;
            this.txtVidaUtil_.Visible = false;
            // 
            // txtNumeroDepreciaciones_
            // 
            this.txtNumeroDepreciaciones_.Location = new System.Drawing.Point(149, 76);
            this.txtNumeroDepreciaciones_.Name = "txtNumeroDepreciaciones_";
            this.txtNumeroDepreciaciones_.Size = new System.Drawing.Size(67, 20);
            this.txtNumeroDepreciaciones_.TabIndex = 20;
            this.txtNumeroDepreciaciones_.Visible = false;
            // 
            // txtValoResidual_
            // 
            this.txtValoResidual_.Location = new System.Drawing.Point(164, 259);
            this.txtValoResidual_.Name = "txtValoResidual_";
            this.txtValoResidual_.Size = new System.Drawing.Size(52, 20);
            this.txtValoResidual_.TabIndex = 19;
            this.txtValoResidual_.Visible = false;
            // 
            // txtValorDepreciacion_
            // 
            this.txtValorDepreciacion_.Location = new System.Drawing.Point(22, 290);
            this.txtValorDepreciacion_.Name = "txtValorDepreciacion_";
            this.txtValorDepreciacion_.ReadOnly = true;
            this.txtValorDepreciacion_.Size = new System.Drawing.Size(194, 20);
            this.txtValorDepreciacion_.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Valor Actual del Activo Fijo::";
            // 
            // txtValorAdquisicion_
            // 
            this.txtValorAdquisicion_.Location = new System.Drawing.Point(22, 231);
            this.txtValorAdquisicion_.Name = "txtValorAdquisicion_";
            this.txtValorAdquisicion_.ReadOnly = true;
            this.txtValorAdquisicion_.Size = new System.Drawing.Size(194, 20);
            this.txtValorAdquisicion_.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Valor de Adquisicion del Activo Fijo:";
            // 
            // txtActivoID_
            // 
            this.txtActivoID_.Location = new System.Drawing.Point(149, 19);
            this.txtActivoID_.Name = "txtActivoID_";
            this.txtActivoID_.Size = new System.Drawing.Size(67, 20);
            this.txtActivoID_.TabIndex = 14;
            this.txtActivoID_.Visible = false;
            // 
            // dtpFechaAdquisicion_
            // 
            this.dtpFechaAdquisicion_.Location = new System.Drawing.Point(20, 170);
            this.dtpFechaAdquisicion_.Name = "dtpFechaAdquisicion_";
            this.dtpFechaAdquisicion_.Size = new System.Drawing.Size(196, 20);
            this.dtpFechaAdquisicion_.TabIndex = 4;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(22, 351);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(194, 71);
            this.txtObservaciones.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Descripcion de Depreciacion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fecha de Adquisicion:";
            // 
            // btnRegistrarDepreciacion
            // 
            this.btnRegistrarDepreciacion.BackColor = System.Drawing.Color.Lime;
            this.btnRegistrarDepreciacion.Location = new System.Drawing.Point(20, 443);
            this.btnRegistrarDepreciacion.Name = "btnRegistrarDepreciacion";
            this.btnRegistrarDepreciacion.Size = new System.Drawing.Size(196, 43);
            this.btnRegistrarDepreciacion.TabIndex = 8;
            this.btnRegistrarDepreciacion.Text = "DEPRECIAR";
            this.btnRegistrarDepreciacion.UseVisualStyleBackColor = false;
            this.btnRegistrarDepreciacion.Click += new System.EventHandler(this.btnRegistrarDepreciacion_Click);
            // 
            // txtNombreActivo_
            // 
            this.txtNombreActivo_.Location = new System.Drawing.Point(20, 107);
            this.txtNombreActivo_.Name = "txtNombreActivo_";
            this.txtNombreActivo_.ReadOnly = true;
            this.txtNombreActivo_.Size = new System.Drawing.Size(196, 20);
            this.txtNombreActivo_.TabIndex = 5;
            // 
            // textCodigoActivoFijo_
            // 
            this.textCodigoActivoFijo_.Location = new System.Drawing.Point(20, 45);
            this.textCodigoActivoFijo_.Name = "textCodigoActivoFijo_";
            this.textCodigoActivoFijo_.ReadOnly = true;
            this.textCodigoActivoFijo_.Size = new System.Drawing.Size(196, 20);
            this.textCodigoActivoFijo_.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de Activo Fijo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo de Activo Fijo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewActivos);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(672, 486);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ACTIVOS FIJOS";
            // 
            // dataGridViewActivos
            // 
            this.dataGridViewActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActivos.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewActivos.Name = "dataGridViewActivos";
            this.dataGridViewActivos.Size = new System.Drawing.Size(660, 465);
            this.dataGridViewActivos.TabIndex = 0;
            this.dataGridViewActivos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewActivos_CellClick);
            // 
            // DepreciacionForm
            // 
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tabControl1);
            this.Name = "DepreciacionForm";
            this.Text = "Depreciación de Activos";
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActivos)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtActivoID_;
        private System.Windows.Forms.DateTimePicker dtpFechaAdquisicion_;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRegistrarDepreciacion;
        private System.Windows.Forms.TextBox txtNombreActivo_;
        private System.Windows.Forms.TextBox textCodigoActivoFijo_;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewActivos;
        private System.Windows.Forms.TextBox txtValorDepreciacion_;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValorAdquisicion_;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVidaUtil_;
        private System.Windows.Forms.TextBox txtNumeroDepreciaciones_;
        private System.Windows.Forms.TextBox txtValoResidual_;
    }
}
