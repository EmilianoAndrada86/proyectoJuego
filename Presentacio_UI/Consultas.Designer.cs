namespace Presentacio_UI
{
    partial class Consultas
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreJuegoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadPartidasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consulta1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.codigoJugadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreJugadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantGanadasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantEmpatadasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantPerdidasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consulta2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consulta1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consulta2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.nombreJuegoDataGridViewTextBoxColumn,
            this.cantidadPartidasDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.consulta1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(424, 199);
            this.dataGridView1.TabIndex = 0;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            // 
            // nombreJuegoDataGridViewTextBoxColumn
            // 
            this.nombreJuegoDataGridViewTextBoxColumn.DataPropertyName = "nombreJuego";
            this.nombreJuegoDataGridViewTextBoxColumn.HeaderText = "Nombre del Juego";
            this.nombreJuegoDataGridViewTextBoxColumn.Name = "nombreJuegoDataGridViewTextBoxColumn";
            // 
            // cantidadPartidasDataGridViewTextBoxColumn
            // 
            this.cantidadPartidasDataGridViewTextBoxColumn.DataPropertyName = "cantidadPartidas";
            this.cantidadPartidasDataGridViewTextBoxColumn.HeaderText = "Cantidad Partidas Jugadas";
            this.cantidadPartidasDataGridViewTextBoxColumn.Name = "cantidadPartidasDataGridViewTextBoxColumn";
            // 
            // consulta1BindingSource
            // 
            this.consulta1BindingSource.DataSource = typeof(BE.consulta1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(424, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ver Juego con mas Partidas Jugadas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoJugadorDataGridViewTextBoxColumn,
            this.nombreJugadorDataGridViewTextBoxColumn,
            this.cantGanadasDataGridViewTextBoxColumn,
            this.cantEmpatadasDataGridViewTextBoxColumn,
            this.cantPerdidasDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.consulta2BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(502, 21);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(583, 199);
            this.dataGridView2.TabIndex = 2;
            // 
            // codigoJugadorDataGridViewTextBoxColumn
            // 
            this.codigoJugadorDataGridViewTextBoxColumn.DataPropertyName = "codigoJugador";
            this.codigoJugadorDataGridViewTextBoxColumn.HeaderText = "Codigo de Jugador";
            this.codigoJugadorDataGridViewTextBoxColumn.Name = "codigoJugadorDataGridViewTextBoxColumn";
            // 
            // nombreJugadorDataGridViewTextBoxColumn
            // 
            this.nombreJugadorDataGridViewTextBoxColumn.DataPropertyName = "nombreJugador";
            this.nombreJugadorDataGridViewTextBoxColumn.HeaderText = "Nombre de Jugador";
            this.nombreJugadorDataGridViewTextBoxColumn.Name = "nombreJugadorDataGridViewTextBoxColumn";
            // 
            // cantGanadasDataGridViewTextBoxColumn
            // 
            this.cantGanadasDataGridViewTextBoxColumn.DataPropertyName = "cantGanadas";
            this.cantGanadasDataGridViewTextBoxColumn.HeaderText = "Partidas Ganadas";
            this.cantGanadasDataGridViewTextBoxColumn.Name = "cantGanadasDataGridViewTextBoxColumn";
            // 
            // cantEmpatadasDataGridViewTextBoxColumn
            // 
            this.cantEmpatadasDataGridViewTextBoxColumn.DataPropertyName = "cantEmpatadas";
            this.cantEmpatadasDataGridViewTextBoxColumn.HeaderText = "Partidas Empatadas";
            this.cantEmpatadasDataGridViewTextBoxColumn.Name = "cantEmpatadasDataGridViewTextBoxColumn";
            // 
            // cantPerdidasDataGridViewTextBoxColumn
            // 
            this.cantPerdidasDataGridViewTextBoxColumn.DataPropertyName = "cantPerdidas";
            this.cantPerdidasDataGridViewTextBoxColumn.HeaderText = "Partidas Perdidas";
            this.cantPerdidasDataGridViewTextBoxColumn.Name = "cantPerdidasDataGridViewTextBoxColumn";
            // 
            // consulta2BindingSource
            // 
            this.consulta2BindingSource.DataSource = typeof(BE.consulta2);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(502, 246);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(658, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(427, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Ver Historial de Jugadores del Juego";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 568);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Consultas";
            this.Text = "Consultas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Consultas_FormClosing);
            this.Load += new System.EventHandler(this.Consultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consulta1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consulta2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreJuegoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadPartidasDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource consulta1BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoJugadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreJugadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantGanadasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantEmpatadasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantPerdidasDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource consulta2BindingSource;
    }
}