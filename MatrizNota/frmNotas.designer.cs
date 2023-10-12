
namespace MatrizNotas_2620134
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
            this.dgvNotas = new System.Windows.Forms.DataGridView();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNota1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNota2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNota3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNota4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNota5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNotaDef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmResultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNotas
            // 
            this.dgvNotas.AllowUserToAddRows = false;
            this.dgvNotas.AllowUserToDeleteRows = false;
            this.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotas.ColumnHeadersVisible = false;
            this.dgvNotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmNombre,
            this.clmCodigo,
            this.clmNota1,
            this.clmNota2,
            this.clmNota3,
            this.clmNota4,
            this.clmNota5,
            this.clmNotaDef,
            this.clmResultado});
            this.dgvNotas.Location = new System.Drawing.Point(21, 12);
            this.dgvNotas.Name = "dgvNotas";
            this.dgvNotas.ReadOnly = true;
            this.dgvNotas.Size = new System.Drawing.Size(809, 336);
            this.dgvNotas.TabIndex = 0;
            // 
            // clmNombre
            // 
            this.clmNombre.HeaderText = "Nombre Estudiante";
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.ReadOnly = true;
            this.clmNombre.Width = 120;
            // 
            // clmCodigo
            // 
            this.clmCodigo.HeaderText = "Código";
            this.clmCodigo.Name = "clmCodigo";
            this.clmCodigo.ReadOnly = true;
            this.clmCodigo.Width = 70;
            // 
            // clmNota1
            // 
            this.clmNota1.HeaderText = "Nota 1";
            this.clmNota1.Name = "clmNota1";
            this.clmNota1.ReadOnly = true;
            this.clmNota1.Width = 70;
            // 
            // clmNota2
            // 
            this.clmNota2.HeaderText = "Nota 2";
            this.clmNota2.Name = "clmNota2";
            this.clmNota2.ReadOnly = true;
            this.clmNota2.Width = 70;
            // 
            // clmNota3
            // 
            this.clmNota3.HeaderText = "Nota 3";
            this.clmNota3.Name = "clmNota3";
            this.clmNota3.ReadOnly = true;
            this.clmNota3.Width = 70;
            // 
            // clmNota4
            // 
            this.clmNota4.HeaderText = "Nota 4";
            this.clmNota4.Name = "clmNota4";
            this.clmNota4.ReadOnly = true;
            this.clmNota4.Width = 70;
            // 
            // clmNota5
            // 
            this.clmNota5.HeaderText = "Nota5";
            this.clmNota5.Name = "clmNota5";
            this.clmNota5.ReadOnly = true;
            this.clmNota5.Width = 70;
            // 
            // clmNotaDef
            // 
            this.clmNotaDef.HeaderText = "Nota Definitiva";
            this.clmNotaDef.Name = "clmNotaDef";
            this.clmNotaDef.ReadOnly = true;
            this.clmNotaDef.Width = 120;
            // 
            // clmResultado
            // 
            this.clmResultado.HeaderText = "Resultado";
            this.clmResultado.Name = "clmResultado";
            this.clmResultado.ReadOnly = true;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(191, 384);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 42);
            this.btnIngresar.TabIndex = 1;
            this.btnIngresar.Text = "Ingresar Notas";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(371, 384);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 42);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular Totales";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(546, 384);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 42);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.dgvNotas);
            this.Name = "frmNotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Notas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNotas;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNota1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNota2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNota3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNota4;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNota5;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNotaDef;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmResultado;
    }
}

