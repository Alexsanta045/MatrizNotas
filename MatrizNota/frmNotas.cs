using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace MatrizNotas_2620134
{
    public partial class frmNotas : Form
    {
        public int N, F;
        public double[,] MNotas;
        public frmNotas()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            N = Convert.ToInt32(Interaction.InputBox("Ingrese el número de estudiantes"));
            string[] VNombres = new string[N];
            string[] VResultado = new string[N];
            MNotas = new double[N, 7];
            dgvNotas.RowCount = (N + 3);
            dgvNotas.Rows[N].Cells[0].Style.BackColor = Color.Transparent;
            dgvNotas.Rows[N+1].Cells[0].Style.BackColor = Color.Transparent;
            dgvNotas.Rows[N+2].Cells[0].Style.BackColor = Color.Transparent;
            dgvNotas.Rows[N].Cells[8].Style.BackColor = Color.Transparent;
            dgvNotas.Rows[N + 1].Cells[8].Style.BackColor = Color.Transparent;
            dgvNotas.Rows[N + 2].Cells[8].Style.BackColor = Color.Transparent;
            
            dgvNotas.Rows[N].Cells[1].Value = "Nota Prom.";
            dgvNotas.Rows[N].Cells[1].Style.BackColor = Color.SkyBlue;
            
            dgvNotas.Rows[N+1].Cells[1].Value = "Nota Mayor";
            dgvNotas.Rows[N+1].Cells[1].Style.BackColor = Color.SkyBlue;
            
            dgvNotas.Rows[N+2].Cells[1].Value = "Nota Menor";
            dgvNotas.Rows[N+2].Cells[1].Style.BackColor = Color.SkyBlue;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }
    }
}
