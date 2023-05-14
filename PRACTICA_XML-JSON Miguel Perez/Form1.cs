using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;


namespace PRACTICA_XML_JSON_Miguel_Perez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show($"Por favor antes de iniciar, Actualizar la ruta de los archivos XML y JSON", "Alerta");
        }

        public class Empleado
        {
            public int idempleado { get; set; }
            public string strnombre { get; set; }
            public string numdocumento { get; set; }
            public string strdireccion { get; set; }
            public string strtelefono { get; set; }
            public string stremail { get; set; }
            public DateTime dtmingreso { get; set; }
        }

        private void CargarDatos()
        {
            string fileJson = File.ReadAllText(@"C:\Users\Miguel Pérez\Downloads\PRACTICA_XML-JSON Miguel Perez\PRACTICA_XML-JSON Miguel Perez\jsonEmpleados.json");

            JObject json = JObject.Parse(fileJson);

            JArray empleados = (JArray)json["EMPLEADOS"];

            DataTable dt = new DataTable();
            dt.Columns.Add("idempleado");
            dt.Columns.Add("strnombre");
            dt.Columns.Add("numdocumento");
            dt.Columns.Add("strdireccion");
            dt.Columns.Add("strtelefono");
            dt.Columns.Add("stremail");
            dt.Columns.Add("dtmingreso");

            foreach (var empleado in empleados)
            {
                DataRow row = dt.NewRow();
                row["idempleado"] = empleado["idempleado"].ToString();
                row["strnombre"] = empleado["strnombre"].ToString();
                row["numdocumento"] = empleado["numdocumento"].ToString();
                row["strdireccion"] = empleado["strdireccion"].ToString();
                row["strtelefono"] = empleado["strtelefono"].ToString();
                row["stremail"] = empleado["stremail"].ToString();
                row["dtmingreso"] = empleado["dtmingreso"].ToString();
                dt.Rows.Add(row);
            }
            dgEmpleados.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCargarJSON_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnCargarXML_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(@"C:\Users\Miguel Pérez\Downloads\PRACTICA_XML-JSON Miguel Perez\PRACTICA_XML-JSON Miguel Perez\xmlEmpleados.xml");
            dgEmpleados.DataSource = ds.Tables[0];
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
