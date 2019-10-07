using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CantidadInformacion
{
    class informacion
    {
        char letra;
        int aparicion;
        double probabilidad;
        double ci;
        double hi;
        bool ban;
        public informacion(char let, int aparicion, int tot)
        {
            this.letra = let;
            this.aparicion = aparicion;
            prob(tot);
            this.ban = false;
            CantidadInformacion();
            entropia();
            
        }
        public informacion(int aparicion, double probabilidad)
        {
            this.ban = true;
            this.aparicion = aparicion;
            this.probabilidad = probabilidad;
        }
        public char Letra { get => letra; set => letra = value; }
        public int Aparicion { get => aparicion; set => aparicion = value; }
        public double Probabilidad { get => probabilidad; set => probabilidad = value; }
    
        public bool Ban { get => ban; set => ban = value; }
        public double Ci { get => ci; set => ci = value; }
        public double Hi { get => hi; set => hi = value; }

        public void prob(int tot)
        {
            this.Probabilidad = Math.Truncate(Convert.ToDouble(aparicion) / Convert.ToDouble(tot) * 100) / 100;

        }
        public void CantidadInformacion()
        {
            this.Ci = Math.Round(Math.Abs(Math.Log(this.Probabilidad) / Math.Log(2)),3);
        }
        public void entropia()
        {
            this.Hi = Math.Round(this.Probabilidad * this.Ci,3);
        }

    }
}
