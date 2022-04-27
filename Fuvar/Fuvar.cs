using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuvar
{
    class Fuvar
    {
        //taxi_id;indulas;idotartam;tavolsag;viteldij;borravalo;fizetes_modja
        int taxi_id;
        DateTime indulas;
        int idotartam;
        double tavolsag;
        double viteldij;
        double borravalo;
        string fizetesmod;

        public Fuvar (string sor)
        {
            string[] daraboltSor = sor.Split(';');
            Taxi_id = Convert.ToInt32(daraboltSor[0]);
            Indulas = Convert.ToDateTime(daraboltSor[1]);
            Idotartam = Convert.ToInt32(daraboltSor[2]);
            Tavolsag = Convert.ToDouble(daraboltSor[3]);
            Viteldij= Convert.ToDouble(daraboltSor[4]);
            Borravalo = Convert.ToDouble(daraboltSor[5]);
            Fizetesmod = daraboltSor[6];
        }

        public int Taxi_id { get => taxi_id; set => taxi_id = value; }
        public DateTime Indulas { get => indulas; set => indulas = value; }
        public int Idotartam { get => idotartam; set => idotartam = value; }
        public double Tavolsag { get => tavolsag; set => tavolsag = value; }
        public double Viteldij { get => viteldij; set => viteldij = value; }
        public double Borravalo { get => borravalo; set => borravalo = value; }
        public string Fizetesmod { get => fizetesmod; set => fizetesmod = value; }
    }
}
