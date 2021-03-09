using CLASE3_ARBOLES.Clases.BaseDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1Fercampos.Clases.BaseDatos
{
    class Listardatos
    {
       
        public List<string> animalnombre = new List<string>();
        public List<string> animalsonido = new List<string>();

        

        public void CargarAnimalesBaseDatos()
        {
            ClsConexion cn = new ClsConexion();
            Listardatos dato = new Listardatos();
           

            DataTable dt = cn.consultandodatosdirectamente("SELECT *  FROM animales");

            foreach (DataRow dr in dt.Rows)
            {
                animalnombre.Add(dr["animalnombre"].ToString());
                animalsonido.Add(dr["animalsonido"].ToString());
                
            }
            
        }
     
    }
}
