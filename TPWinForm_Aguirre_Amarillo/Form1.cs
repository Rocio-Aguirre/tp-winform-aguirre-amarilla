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


        // CODIGO y METODO de PRUEBA:
        private void Form1_Load(object sender, EventArgs e)
        {

            int num;
            string str;
            double valor;
            Articulo obj_art = new Articulo();
            List<Articulo> list_art = new List<Articulo>();

            ArticuloBD sql_contenedor = new ArticuloBD();
            
            try
            { 
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
