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
                    string resultado = "Origen : " + origin + " Retraso llegada : " + arrDelay + " minutos "+ " Retraso salida : " + DepDelay + " minutos";
                    listSelect.Items.Add(resultado);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error conectando: " + ex.Message);
            }
        }

        private void butRMesAnyo_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = @"select origin, colYear, colMonth, AVG(arrDelay) Arr_Delay from Flights f
                                        inner join USAirports a on f.Origin= a.IATA
                                        group by origin, colYear, colMonth
                                        order by origin;
";

                SqlCommand cmd = new SqlCommand(sql, Cnx);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string origin = (string)dr["origin"];
                    Int16 colYear = (Int16)dr["colYear"];
                    Int16 colMonth = (Int16)dr["colMonth"];
                    int arrDelay = (int)dr["Arr_Delay"];
                    string resultado = " Origen : " + origin + " Año : "+colYear+ " Mes : " +colMonth+ " Retraso Medio : "+arrDelay + " minutos";
                    listSelect.Items.Add(resultado);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error conectando: " + ex.Message);
            }
        }

        private void butrMesAnyoCiu_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = @"select City, colYear, colMonth, AVG(arrDelay) Arr_Delay from Flights f
                                    inner join USAirports a on f.Origin= a.IATA
                                    group by City, colYear, colMonth
                                    order by City;";

                SqlCommand cmd = new SqlCommand(sql, Cnx);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string City = (string)dr["City"];
                    Int16 colYear = (Int16)dr["colYear"];
                    Int16 colMonth = (Int16)dr["colMonth"];
                    int arrDelay = (int)dr["Arr_Delay"];
                    string resultado = " Origen : " + City + " Año : " + colYear + " Mes : " + colMonth + " Retraso Medio : " + arrDelay + " minutos";
                    listSelect.Items.Add(resultado);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error conectando: " + ex.Message);
            }
        }

        private void butTopCancel_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = @" Select UniqueCarrier,  colYear, colMonth ,count(*) Total_cancelled 
                                        from Flights where Cancelled = 1
                                        group by UniqueCarrier, colYear, colMonth
                                        order by Total_cancelled desc;";

                SqlCommand cmd = new SqlCommand(sql, Cnx);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string UniqueCarrier = (string)dr["UniqueCarrier"];
                    Int16 colYear = (Int16)dr["colYear"];
                    Int16 colMonth = (Int16)dr["colMonth"];
                    int Total_cancelled = (int)dr["Total_cancelled"];
                    string resultado = " Compañia : " + UniqueCarrier + " Año : " + colYear + " Mes : " + colMonth + " Total cancelados : " + Total_cancelled;
                    listSelect.Items.Add(resultado);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error conectando: " + ex.Message);
            }
        }

        private void butDistancia_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = @"select top 10 TailNum, sum(Distance) as distance  from Flights
                                        where TailNum is not null and TailNum != ''
                                        group by TailNum
                                        order by Distance desc";

                SqlCommand cmd = new SqlCommand(sql, Cnx);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string TailNum = (string)dr["TailNum"];
                    int distance = (int)dr["distance"];

                    string resultado = " Avion : " + TailNum + " Distancia total : " + distance + " Km";
                    listSelect.Items.Add(resultado);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error conectando: " + ex.Message);
            }
        }

        private void butREmpresas_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = @" select c.CarrierCode carrierCode,  avg(f.ArrDelay) avgDelay from Flights f
                                    inner join Carriers c on f.UniqueCarrier = c.CarrierCode
                                    group by c.CarrierCode
                                    having avg(f.ArrDelay) > 10
                                    order by avgDelay desc";

                SqlCommand cmd = new SqlCommand(sql, Cnx);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string carrierCode = (string)dr["carrierCode"];
                    int avgDelay = (int)dr["avgDelay"];
                    string resultado = " Empresa : " + carrierCode + " Retraso Medio : " + avgDelay + " minutos";
                    listSelect.Items.Add(resultado);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error conectando: " + ex.Message);
            }
        }
    }
}

