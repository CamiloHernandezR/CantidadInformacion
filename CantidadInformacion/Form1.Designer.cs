namespace CantidadInformacion
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.btnArchivo = new System.Windows.Forms.Button();
            this.radEscribri = new System.Windows.Forms.RadioButton();
            this.radArchivo = new System.Windows.Forms.RadioButton();
            this.dtgProbabilidades = new System.Windows.Forms.DataGridView();
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.txtComenzar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entropia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.grafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProbabilidades)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grafica)).BeginInit();
            this.SuspendLayout();
            // 
            // btnArchivo
            // 
            this.btnArchivo.Location = new System.Drawing.Point(46, 124);
            this.btnArchivo.Name = "btnArchivo";
            this.btnArchivo.Size = new System.Drawing.Size(214, 23);
            this.btnArchivo.TabIndex = 19;
            this.btnArchivo.Text = "Seleccionar Archivo";
            this.btnArchivo.UseVisualStyleBackColor = true;
            this.btnArchivo.Click += new System.EventHandler(this.btnArchivo_Click);
            // 
            // radEscribri
            // 
            this.radEscribri.AutoSize = true;
            this.radEscribri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radEscribri.Location = new System.Drawing.Point(316, 68);
            this.radEscribri.Name = "radEscribri";
            this.radEscribri.Size = new System.Drawing.Size(132, 22);
            this.radEscribri.TabIndex = 18;
            this.radEscribri.TabStop = true;
            this.radEscribri.Text = "EscribirMensaje";
            this.radEscribri.UseVisualStyleBackColor = true;
            this.radEscribri.CheckedChanged += new System.EventHandler(this.radEscribri_CheckedChanged);
            // 
            // radArchivo
            // 
            this.radArchivo.AutoSize = true;
            this.radArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radArchivo.Location = new System.Drawing.Point(316, 30);
            this.radArchivo.Name = "radArchivo";
            this.radArchivo.Size = new System.Drawing.Size(97, 22);
            this.radArchivo.TabIndex = 17;
            this.radArchivo.TabStop = true;
            this.radArchivo.Text = "Usar un txt";
            this.radArchivo.UseVisualStyleBackColor = true;
            this.radArchivo.CheckedChanged += new System.EventHandler(this.radArchivo_CheckedChanged);
            // 
            // dtgProbabilidades
            // 
            this.dtgProbabilidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProbabilidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Rep,
            this.Column2,
            this.CI,
            this.Entropia});
            this.dtgProbabilidades.Location = new System.Drawing.Point(12, 184);
            this.dtgProbabilidades.Name = "dtgProbabilidades";
            this.dtgProbabilidades.Size = new System.Drawing.Size(655, 264);
            this.dtgProbabilidades.TabIndex = 16;
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(11, 12);
            this.txtCadena.Multiline = true;
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(272, 89);
            this.txtCadena.TabIndex = 15;
            // 
            // txtComenzar
            // 
            this.txtComenzar.Location = new System.Drawing.Point(316, 103);
            this.txtComenzar.Name = "txtComenzar";
            this.txtComenzar.Size = new System.Drawing.Size(152, 65);
            this.txtComenzar.TabIndex = 20;
            this.txtComenzar.Text = "Commenzar";
            this.txtComenzar.UseVisualStyleBackColor = true;
            this.txtComenzar.Click += new System.EventHandler(this.txtComenzar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grafica);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(689, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 460);
            this.panel1.TabIndex = 21;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Caracter";
            this.Column1.Name = "Column1";
            // 
            // Rep
            // 
            this.Rep.HeaderText = "Apariciones";
            this.Rep.Name = "Rep";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "probabilidad";
            this.Column2.Name = "Column2";
            // 
            // CI
            // 
            this.CI.HeaderText = "In";
            this.CI.Name = "CI";
            // 
            // Entropia
            // 
            this.Entropia.HeaderText = "Hn";
            this.Entropia.Name = "Entropia";
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // grafica
            // 
            this.grafica.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            this.grafica.BorderlineWidth = 4;
            chartArea1.Name = "ChartArea1";
            this.grafica.ChartAreas.Add(chartArea1);
            this.grafica.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.grafica.Legends.Add(legend1);
            this.grafica.Location = new System.Drawing.Point(0, 0);
            this.grafica.Name = "grafica";
            this.grafica.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.grafica.Size = new System.Drawing.Size(459, 460);
            this.grafica.TabIndex = 0;
            this.grafica.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 460);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtComenzar);
            this.Controls.Add(this.btnArchivo);
            this.Controls.Add(this.radEscribri);
            this.Controls.Add(this.radArchivo);
            this.Controls.Add(this.dtgProbabilidades);
            this.Controls.Add(this.txtCadena);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtgProbabilidades)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grafica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnArchivo;
        private System.Windows.Forms.RadioButton radEscribri;
        private System.Windows.Forms.RadioButton radArchivo;
        private System.Windows.Forms.DataGridView dtgProbabilidades;
        private System.Windows.Forms.TextBox txtCadena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entropia;
        private System.Windows.Forms.Button txtComenzar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafica;
    }
}

