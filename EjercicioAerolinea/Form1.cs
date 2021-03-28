using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioAerolinea
{
    public partial class Form1 : Form
    {
        SqlConnection cnx = null;
        public SqlConnection Cnx { get => cnx; set => cnx = value; }
        public Form1()
        {
            InitializeComponent();
        }

        private void butConexion_Click(object sender, EventArgs e)
        {
            try
            {
                cnx = new SqlConnection(
                    "Data Source =DESKTOP-GSHP0S4; Initial Catalog = CSHARP; Integrated Security = true;");
                butConexion.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error conectando: " + ex.Message);
            }
        }

        private void butAbrir_Click(object sender, EventArgs e)
        {
            try
            {
                cnx.Open();
                butAbrir.Enabled = false;
            } catch (Exception ex) 
            { 
                MessageBox.Show("Error conectando: " + ex.Message); 
            }
        }

        private void butCerrar_Click(object sender, EventArgs e)
        {
            try
            {
                cnx.Close();
                butCerrar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error conectando: " + ex.Message);
            }
        }

        private void butRegistros_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = @"select count(*) from Flights";
                SqlCommand cmd = new SqlCommand(sql, Cnx);
                int recuento = (int)cmd.ExecuteScalar();
                listSelect.Items.Add("Recuento total de registros : " + recuento);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error conectando: " + ex.Message);
            }
        }

        private void butRCodigo_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = @"select origin, AVG(arrDelay) Arr_Delay, avg(DepDelay) DepDelay from Flights
                                group by Origin order by Origin";
                SqlCommand cmd = new SqlCommand(sql, Cnx);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string origin = (string)dr["origin"];
                    int arrDelay = (int)dr["Arr_Delay"];
                    int DepDelay = (int)dr["DepDelay"];
                    string resultado = "Origen : " + origin + " Retraso llegada : " + arrDelay + " Retraso salida : " + DepDelay;
                    listSelect.Items.Add(resultado);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error conectando: " + ex.Message);
            }
        }

        //private void butRMesAnyo_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        string sql = @"select City, colYear, colMonth, AVG(arrDelay) Arr_Delay from Flights f
        //                        inner join USAirports a on f.Origin= a.IATA
        //                        group by City, colYear, colMonth
        //                        order by City;";

        //        SqlCommand cmd = new SqlCommand(sql, Cnx);
        //        SqlDataReader dr = cmd.ExecuteReader();
        //        while (dr.Read())
        //        {
        //            string city = (string)dr["City"];
        //            int colYear = (int)dr["colYear"];
        //            int colMonth = (int)dr["colMonth"];
        //            int arrDelay = (int)dr["Arr_Delay"];
        //            string resultado = " Origen : " + city + "Año : " +colYear+ " Mes : " +colMonth+ " Retraso llegada : " + arrDelay ;
        //            listSelect.Items.Add(resultado);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error conectando: " + ex.Message);
        //    }
        //}
    }
}
