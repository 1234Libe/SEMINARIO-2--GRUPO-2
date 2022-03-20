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

//Universidad Abierta Para Adultos - UAPA.
//Seminario 2, de asignatura: Estructura de Datos y Algoritmos.
//Grupo No. 2.
//Participantes: Ana M Cepeda M, Carlos A. Guzmán H, Ángel Wander Morezux, Roderi D. Peña R, 

namespace Seminario2_ArbolBinarios_Nodos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearArbol_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionarNodo_Click(object sender, EventArgs e)
        {
            TreeView.Nodes.Add(txtNodo.Text);
            txtNodo.Text = "";
        }

        private void btnAdicionarElemento_Click(object sender, EventArgs e)
        {
            TreeView.SelectedNode.Nodes.Add(txtElemento.Text);
            txtElemento.Text = "";
        }

        private void btnLimpiarNodo_Click(object sender, EventArgs e)
        {
            TreeView.Nodes.Clear();
        }

        private void btnEliminarNodo_Click(object sender, EventArgs e)
        {
            TreeView.Nodes.Remove(TreeView.SelectedNode);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
