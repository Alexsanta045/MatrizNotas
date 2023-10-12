
namespace MatrizNota
{
    partial class frmNotas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotas));
            this.dgvNotas = new System.Windows.Forms.DataGridView();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btningresar = new System.Windows.Forms.Button();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNota1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNota2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNota3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmNota4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNota5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDefinitiva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmResultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNotas
            // 
            this.dgvNotas.AllowUserToAddRows = false;
            this.dgvNotas.AllowUserToDeleteRows = false;
            this.dgvNotas.AllowUserToResizeColumns = false;
            this.dgvNotas.AllowUserToResizeRows = false;
            this.dgvNotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNotas.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmNombre,
            this.clmCodigo,
            this.clmNota1,
            this.clmNota2,
            this.clmNota3,
            this.ClmNota4,
            this.clmNota5,
            this.clmDefinitiva,
            this.clmResultado});
            resources.ApplyResources(this.dgvNotas, "dgvNotas");
            this.dgvNotas.Name = "dgvNotas";
            this.dgvNotas.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNotas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNotas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvNotas.RowTemplate.Height = 33;
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnsalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.btnsalir, "btnsalir");
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            resources.ApplyResources(this.btncalcular, "btncalcular");
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btningresar
            // 
            this.btningresar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            resources.ApplyResources(this.btningresar, "btningresar");
            this.btningresar.Name = "btningresar";
            this.btningresar.UseVisualStyleBackColor = false;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // clmNombre
            // 
            resources.ApplyResources(this.clmNombre, "clmNombre");
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.ReadOnly = true;
            // 
            // clmCodigo
            // 
            resources.ApplyResources(this.clmCodigo, "clmCodigo");
            this.clmCodigo.Name = "clmCodigo";
            this.clmCodigo.ReadOnly = true;
            // 
            // clmNota1
            // 
            resources.ApplyResources(this.clmNota1, "clmNota1");
            this.clmNota1.Name = "clmNota1";
            this.clmNota1.ReadOnly = true;
            // 
            // clmNota2
            // 
            resources.ApplyResources(this.clmNota2, "clmNota2");
            this.clmNota2.Name = "clmNota2";
            this.clmNota2.ReadOnly = true;
            // 
            // clmNota3
            // 
            resources.ApplyResources(this.clmNota3, "clmNota3");
            this.clmNota3.Name = "clmNota3";
            this.clmNota3.ReadOnly = true;
            // 
            // ClmNota4
            // 
            resources.ApplyResources(this.ClmNota4, "ClmNota4");
            this.ClmNota4.Name = "ClmNota4";
            this.ClmNota4.ReadOnly = true;
            // 
            // clmNota5
            // 
            resources.ApplyResources(this.clmNota5, "clmNota5");
            this.clmNota5.Name = "clmNota5";
            this.clmNota5.ReadOnly = true;
            // 
            // clmDefinitiva
            // 
            resources.ApplyResources(this.clmDefinitiva, "clmDefinitiva");
            this.clmDefinitiva.Name = "clmDefinitiva";
            this.clmDefinitiva.ReadOnly = true;
            // 
            // clmResultado
            // 
            resources.ApplyResources(this.clmResultado, "clmResultado");
            this.clmResultado.Name = "clmResultado";
            this.clmResultado.ReadOnly = true;
            // 
            // frmNotas
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.dgvNotas);
            this.Name = "frmNotas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNotas;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNota1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNota2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNota3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmNota4;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNota5;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDefinitiva;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmResultado;
    }
}

