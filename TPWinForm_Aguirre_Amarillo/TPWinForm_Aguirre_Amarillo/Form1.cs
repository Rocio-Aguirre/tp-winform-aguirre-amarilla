using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_Aguirre_Amarillo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // de ejemplo
            Articulo art = new Articulo();
            art.Cargar(1, "Facu", "Humano", 10000.99);

            /*
                MessageBox.Show($"Codigo: {art._cod}" +
                $"\nNombre: {art._nombre}"+
                $"\nDescripcion: {art._descr}"+
                $"\nPrecio: {art._precio}");
            */
            
        }
    }
}
