using ACTIVOS_FIJOS.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVOS_FIJOS.Controllers
{
    public class DepreciacionController
    {
        private string connectionString = "Server=DESKTOP-TM74ECK\\SQLEXPRESS;Database=ActivosFijosDB;Integrated Security=True;";
        public decimal CalcularDepreciacionAnual(decimal valorAdquisicion, decimal valorResidual, int vidaUtil)
        {
            decimal depreciacionAnual = (valorAdquisicion - valorResidual) / vidaUtil;
            return depreciacionAnual;
        }
        public void RegistrarDepreciacion(int activoID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Obtener detalles del activo fijo
                string queryActivo = @"
            SELECT 
                ValorAdquisicion, 
                Numero_Depreciaciones, 
                VidaUtil, 
                ValoResidual 
            FROM 
                ACTIVOFIJO a
                JOIN CATEGORIA c ON a.CategoriaID = c.CategoriaID
            WHERE 
                a.ActivoID = @ActivoID";
                SqlCommand cmdActivo = new SqlCommand(queryActivo, conn);
                cmdActivo.Parameters.AddWithValue("@ActivoID", activoID);
                SqlDataReader reader = cmdActivo.ExecuteReader();

                if (reader.Read())
                {
                    decimal valorAdquisicion = (decimal)reader["ValorAdquisicion"];
                    int numeroDepreciaciones = (int)reader["Numero_Depreciaciones"];
                    int vidaUtil = (int)reader["VidaUtil"];
                    decimal valorResidual = (decimal)reader["ValoResidual"];
                    reader.Close();

                    // Verificar si el número de depreciaciones es igual o superior a la vida útil
                    if (numeroDepreciaciones >= vidaUtil)
                    {
                        throw new Exception("No se puede registrar más depreciaciones para este activo fijo, ya ha alcanzado su vida útil.");
                    }

                    // Calcular depreciación anual
                    decimal depreciacionAnual = CalcularDepreciacionAnual(valorAdquisicion, valorResidual, vidaUtil);

                    // Calcular valor depreciado
                    decimal valorDepreciado = valorAdquisicion - (depreciacionAnual * (numeroDepreciaciones + 1));

                    // Insertar registro de depreciación
                    string queryDepreciacion = @"
                INSERT INTO DEPRECIACION (ActivoID, FechaDesgaste, Valor_depreciacion_anual, Valor_Depreciacion_Calculado, Descripcion)
                VALUES (@ActivoID, @FechaDesgaste, @ValorDepreciacionAnual, @ValorDepreciacionCalculado, @Descripcion)";

                    SqlCommand cmdDepreciacion = new SqlCommand(queryDepreciacion, conn);
                    cmdDepreciacion.Parameters.AddWithValue("@ActivoID", activoID);
                    cmdDepreciacion.Parameters.AddWithValue("@FechaDesgaste", DateTime.Now);
                    cmdDepreciacion.Parameters.AddWithValue("@ValorDepreciacionAnual", depreciacionAnual);
                    cmdDepreciacion.Parameters.AddWithValue("@ValorDepreciacionCalculado", valorDepreciado);
                    cmdDepreciacion.Parameters.AddWithValue("@Descripcion", "Depreciación anual calculada");

                    cmdDepreciacion.ExecuteNonQuery();

                    // Actualizar número de depreciaciones en ACTIVOFIJO
                    string queryUpdateActivo = @"
                UPDATE ACTIVOFIJO
                SET Numero_Depreciaciones = Numero_Depreciaciones + 1
                WHERE ActivoID = @ActivoID";

                    SqlCommand cmdUpdateActivo = new SqlCommand(queryUpdateActivo, conn);
                    cmdUpdateActivo.Parameters.AddWithValue("@ActivoID", activoID);

                    cmdUpdateActivo.ExecuteNonQuery();
                }
                else
                {
                    reader.Close();
                    throw new Exception("Activo fijo no encontrado.");
                }
            }
        }
        public List<Depreciacion> GetAllDepreciaciones()
        {
            List<Depreciacion> depreciaciones = new List<Depreciacion>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM DEPRECIACION", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    depreciaciones.Add(new Depreciacion
                    {
                        DepreciacionID = (int)reader["DepreciacionID"],
                        ActivoID = (int)reader["ActivoID"],
                        FechaDesgaste = (DateTime)reader["FechaDesgaste"],
                        //ValorDesgaste_A = (decimal)reader["ValorDesgaste_A"],
                        //ValorDesgaste_D = (decimal)reader["ValorDesgaste_D"],
                        Descripcion = (string)reader["Descripcion"]
                    });
                }
            }
            return depreciaciones;
        }
        public void AddDepreciacion(Depreciacion depreciacion)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO DEPRECIACION (ActivoID, FechaDesgaste, ValorDesgaste_A, ValorDesgaste_D, Descripcion) VALUES (@ActivoID, @FechaDesgaste, @ValorDesgaste_A, @ValorDesgaste_D, @Descripcion)", conn);
                cmd.Parameters.AddWithValue("@ActivoID", depreciacion.ActivoID);
                cmd.Parameters.AddWithValue("@FechaDesgaste", depreciacion.FechaDesgaste);
                //cmd.Parameters.AddWithValue("@ValorDesgaste_A", depreciacion.ValorDesgaste_A);
                //cmd.Parameters.AddWithValue("@ValorDesgaste_D", depreciacion.ValorDesgaste_D);
                cmd.Parameters.AddWithValue("@Descripcion", depreciacion.Descripcion);
                cmd.ExecuteNonQuery();
            }
        }
        public void UpdateDepreciacion(Depreciacion depreciacion)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE DEPRECIACION SET ActivoID = @ActivoID, FechaDesgaste = @FechaDesgaste, ValorDesgaste_A = @ValorDesgaste_A, ValorDesgaste_D = @ValorDesgaste_D, Descripcion = @Descripcion WHERE DepreciacionID = @DepreciacionID", conn);
                cmd.Parameters.AddWithValue("@DepreciacionID", depreciacion.DepreciacionID);
                cmd.Parameters.AddWithValue("@ActivoID", depreciacion.ActivoID);
                cmd.Parameters.AddWithValue("@FechaDesgaste", depreciacion.FechaDesgaste);
                //cmd.Parameters.AddWithValue("@ValorDesgaste_A", depreciacion.ValorDesgaste_A);
                //cmd.Parameters.AddWithValue("@ValorDesgaste_D", depreciacion.ValorDesgaste_D);
                cmd.Parameters.AddWithValue("@Descripcion", depreciacion.Descripcion);
                cmd.ExecuteNonQuery();
            }
        }
        public void DeleteDepreciacion(int depreciacionID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM DEPRECIACION WHERE DepreciacionID = @DepreciacionID", conn);
                cmd.Parameters.AddWithValue("@DepreciacionID", depreciacionID);
                cmd.ExecuteNonQuery();
            }
        }
        public void CalcularDepreciacionLineal(int activoID, decimal valorResidual, int vidaUtil)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT ValorAdquisicion, FechaAdquisicion FROM ACTIVOFIJO WHERE ActivoID = @ActivoID", conn);
                cmd.Parameters.AddWithValue("@ActivoID", activoID);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    decimal valorAdquisicion = (decimal)reader["ValorAdquisicion"];
                    DateTime fechaAdquisicion = (DateTime)reader["FechaAdquisicion"];
                    decimal depreciacionAnual = (valorAdquisicion - valorResidual) / vidaUtil;

                    for (int i = 1; i <= vidaUtil; i++)
                    {
                        DateTime fechaDesgaste = fechaAdquisicion.AddYears(i);
                        AddDepreciacion(new Depreciacion
                        {
                            ActivoID = activoID,
                            FechaDesgaste = fechaDesgaste,
                            //ValorDesgaste_A = depreciacionAnual,
                            //ValorDesgaste_D = depreciacionAnual,
                            Descripcion = $"Depreciación año {i}"
                        });
                    }
                }
            }
        }
    }
}
