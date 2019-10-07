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

namespace CantidadInformacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<informacion> info = new List<informacion>();
        private void txtComenzar_Click(object sender, EventArgs e)
        {
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
                foreach (informacion let in info)
                {
                    dtgProbabilidades.Rows.Add(let.Letra, let.Aparicion, let.Probabilidad, let.Ci, let.Hi);
                }

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
