using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CantidadInformacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnArchivo.Enabled = false;
        }
        List<informacion> info = new List<informacion>();
        private void txtComenzar_Click(object sender, EventArgs e)
        {
            dtgProbabilidades.Rows.Clear();
            grafica.Series.Clear();
            grafica.Series.Add("Cantidad de informacion");
            grafica.Series.Add("Entropia");

            grafica.Series[0].ChartType = SeriesChartType.Line;
            grafica.Series[1].ChartType = SeriesChartType.Line;
            List<char> caracteres = new List<char>();
            info.Clear();
            if (txtCadena.Text != null)
            {
                string cadena = txtCadena.Text;


                char[] separar = new char[cadena.Length];
                bool ban = false;
                cadena.CopyTo(0, separar, 0, cadena.Length);
                foreach (char let in separar)
                {
                    caracteres.Add(let);
                }
              
               
                for (int x = 0; x < caracteres.Count; x++)
                {
                    int con = 0;
                    for (int y = 0; y < caracteres.Count; y++)
                    {
                        if (caracteres[x] == caracteres[y])
                        {
                            con++;
                            if (x != y)
                            {
                                caracteres.RemoveAt(y);
                                y--;
                            }

                        }
                    }


                    info.Add(new informacion(caracteres[x], con, cadena.Length)); //Creamos nuestros objetos y  los añadimos a la lista
                    

                }
                
                info = info.OrderByDescending(o => o.Probabilidad).ToList();
                double ht=0,ct=0,pt=0;
                int at = 0;
                
                foreach (informacion let in info)
                {
                    dtgProbabilidades.Rows.Add(let.Letra, let.Aparicion, let.Probabilidad, let.Ci, let.Hi);
                    ht = let.Hi + ht;
                    ct = let.Ci + ct;
                    pt = pt + let.Probabilidad;
                    at = at + let.Aparicion;
                }
                dtgProbabilidades.Rows.Add("Totales",at,pt, ct, ht);
                graficar();
            }
        }
        public void graficar()
        {
            foreach(informacion let in info)
            {
                
              
                grafica.Series[0].Points.Add(let.Ci).BorderWidth=3;
         ;
                grafica.Series[1].Points.Add(let.Hi).BorderWidth=3;
            }
        }
        private void btnArchivo_Click(object sender, EventArgs e)
        {
            openFile.Filter = "txt files (*.txt)|*txt";
            openFile.InitialDirectory = "C:\\Users\\magnu\\Desktop\\CuatriActual\\Seguridad\\CantidadDeInformacion\\CantidadInformacion";

            if (openFile.ShowDialog() == DialogResult.OK && openFile.ToString() != "")
            {
                string archivo = openFile.FileName;
                if (File.Exists(archivo))
                {
                    txtCadena.Text = File.ReadAllText(archivo);
                }
            }
        }

        private void radEscribri_CheckedChanged(object sender, EventArgs e)
        {
            if (radEscribri.Checked)
            {
                txtCadena.Enabled = true;
                radArchivo.Checked = false;
                btnArchivo.Enabled = false;
            }
        }

        private void radArchivo_CheckedChanged(object sender, EventArgs e)
        {
            if (radArchivo.Checked)
            {
                txtCadena.Enabled = false;
                radEscribri.Checked = false;
                btnArchivo.Enabled = true;
            }
        }
    }
}
