using ACTIVOS_FIJOS.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVOS_FIJOS.Controllers
{
    public class ActivoFijoController
    {
        private string connectionString = "Server=DESKTOP-TM74ECK\\SQLEXPRESS;Database=ActivosFijosDB;Integrated Security=True;";
        public List<ActivoFijo> GetAllAssetsWithDetails_()
        {
            List<ActivoFijo> assets = new List<ActivoFijo>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
SELECT 
    a.ActivoID, a.CodigoActivo, na.NombreActivoID, na.NombreActivo_, a.EstadoBaja, 
    c.CategoriaID, c.NombreCategoria, u.UbicacionID, u.NombreUbicacion, 
    un.UnidadID, un.NombreUnidad, a.FechaAdquisicion, a.ValorAdquisicion, 
    a.Numero_Depreciaciones, a.DescripcionActivo, a.MotivoBajaActivo, 
    a.MotivoEliminarActivo
FROM ACTIVOFIJO a
JOIN CATEGORIA c ON a.CategoriaID = c.CategoriaID
JOIN UBICACION u ON a.UbicacionID = u.UbicacionID
JOIN UNIDAD un ON a.UnidadID = un.UnidadID
JOIN NOMBREACTIVO na ON a.NombreActivoID = na.NombreActivoID
WHERE a.EstadoBaja <> 'Eliminado'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var asset = new ActivoFijo
                    {
                        ActivoID = (int)reader["ActivoID"],
                        CodigoActivo = (string)reader["CodigoActivo"],
                        NombreActivoID = (int)reader["NombreActivoID"],
                        NombreActivo = new NombreActivo { NombreActivoID = (int)reader["NombreActivoID"], NombreActivo_ = (string)reader["NombreActivo_"] },
                        EstadoBaja = (string)reader["EstadoBaja"],
                        CategoriaID = (int)reader["CategoriaID"],
                        Categoria = new Categoria { CategoriaID = (int)reader["CategoriaID"], NombreCategoria = (string)reader["NombreCategoria"] },
                        UbicacionID = (int)reader["UbicacionID"],
                        Ubicacion = new Ubicacion { UbicacionID = (int)reader["UbicacionID"], NombreUbicacion = (string)reader["NombreUbicacion"] },
                        UnidadID = (int)reader["UnidadID"],
                        Unidad = new Unidad { UnidadID = (int)reader["UnidadID"], NombreUnidad = (string)reader["NombreUnidad"] },
                        FechaAdquisicion = (DateTime)reader["FechaAdquisicion"],
                        ValorAdquisicion = (decimal)reader["ValorAdquisicion"],
                        NumeroDepreciaciones = (int)reader["Numero_Depreciaciones"],
                        DescripcionActivo = reader["DescripcionActivo"] != DBNull.Value ? (string)reader["DescripcionActivo"] : string.Empty,
                        MotivoBajaActivo = reader["MotivoBajaActivo"] != DBNull.Value ? (string)reader["MotivoBajaActivo"] : string.Empty,
                        MotivoEliminarActivo = reader["MotivoEliminarActivo"] != DBNull.Value ? (string)reader["MotivoEliminarActivo"] : string.Empty
                    };

                    assets.Add(asset);
                }
            }
            return assets;
        } 
        public List<object> GetAllAssetsWithDetails()
        {
            List<object> assets = new List<object>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
SELECT 
    a.ActivoID, a.CodigoActivo, na.NombreActivoID, na.NombreActivo_, a.EstadoBaja, 
    c.CategoriaID, c.NombreCategoria, u.UbicacionID, u.NombreUbicacion, 
    un.UnidadID, un.NombreUnidad, a.FechaAdquisicion, a.ValorAdquisicion, 
    a.Numero_Depreciaciones, a.DescripcionActivo, a.MotivoBajaActivo, 
    a.MotivoEliminarActivo
FROM ACTIVOFIJO a
JOIN CATEGORIA c ON a.CategoriaID = c.CategoriaID
JOIN UBICACION u ON a.UbicacionID = u.UbicacionID
JOIN UNIDAD un ON a.UnidadID = un.UnidadID
JOIN NOMBREACTIVO na ON a.NombreActivoID = na.NombreActivoID
WHERE a.EstadoBaja <> 'Eliminado'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var asset = new
                    {
                        ActivoID = (int)reader["ActivoID"],
                        CodigoActivo = (string)reader["CodigoActivo"],
                        NombreActivoID = (int)reader["NombreActivoID"],
                        NombreActivo = (string)reader["NombreActivo_"],
                        EstadoBaja = (string)reader["EstadoBaja"],
                        CategoriaID = (int)reader["CategoriaID"],
                        NombreCategoria = (string)reader["NombreCategoria"],
                        UbicacionID = (int)reader["UbicacionID"],
                        NombreUbicacion = (string)reader["NombreUbicacion"],
                        UnidadID = (int)reader["UnidadID"],
                        NombreUnidad = (string)reader["NombreUnidad"],
                        FechaAdquisicion = (DateTime)reader["FechaAdquisicion"],
                        ValorAdquisicion = (decimal)reader["ValorAdquisicion"],
                        NumeroDepreciaciones = (int)reader["Numero_Depreciaciones"],
                        DescripcionActivo = reader["DescripcionActivo"] != DBNull.Value ? (string)reader["DescripcionActivo"] : string.Empty,
                        MotivoBajaActivo = reader["MotivoBajaActivo"] != DBNull.Value ? (string)reader["MotivoBajaActivo"] : string.Empty,
                        MotivoEliminarActivo = reader["MotivoEliminarActivo"] != DBNull.Value ? (string)reader["MotivoEliminarActivo"] : string.Empty
                    };

                    assets.Add(asset);
                }
            }
            return assets;
        }
        public List<object> GetInactiveAssets()
        {
            List<object> assets = new List<object>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
SELECT 
    a.ActivoID, a.CodigoActivo, na.NombreActivoID, na.NombreActivo_, a.EstadoBaja, 
    c.CategoriaID, c.NombreCategoria, u.UbicacionID, u.NombreUbicacion, 
    un.UnidadID, un.NombreUnidad, a.FechaAdquisicion, a.ValorAdquisicion, 
    a.Numero_Depreciaciones, a.DescripcionActivo, a.MotivoBajaActivo, 
    a.MotivoEliminarActivo
FROM ACTIVOFIJO a
JOIN CATEGORIA c ON a.CategoriaID = c.CategoriaID
JOIN UBICACION u ON a.UbicacionID = u.UbicacionID
JOIN UNIDAD un ON a.UnidadID = un.UnidadID
JOIN NOMBREACTIVO na ON a.NombreActivoID = na.NombreActivoID
WHERE a.EstadoBaja = 'Inactivo'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var asset = new
                    {
                        ActivoID = (int)reader["ActivoID"],
                        CodigoActivo = (string)reader["CodigoActivo"],
                        NombreActivoID = (int)reader["NombreActivoID"],
                        NombreActivo = (string)reader["NombreActivo_"],
                        EstadoBaja = (string)reader["EstadoBaja"],
                        CategoriaID = (int)reader["CategoriaID"],
                        NombreCategoria = (string)reader["NombreCategoria"],
                        UbicacionID = (int)reader["UbicacionID"],
                        NombreUbicacion = (string)reader["NombreUbicacion"],
                        UnidadID = (int)reader["UnidadID"],
                        NombreUnidad = (string)reader["NombreUnidad"],
                        FechaAdquisicion = (DateTime)reader["FechaAdquisicion"],
                        ValorAdquisicion = (decimal)reader["ValorAdquisicion"],
                        NumeroDepreciaciones = (int)reader["Numero_Depreciaciones"],
                        DescripcionActivo = reader["DescripcionActivo"] != DBNull.Value ? (string)reader["DescripcionActivo"] : string.Empty,
                        MotivoBajaActivo = reader["MotivoBajaActivo"] != DBNull.Value ? (string)reader["MotivoBajaActivo"] : string.Empty,
                        MotivoEliminarActivo = reader["MotivoEliminarActivo"] != DBNull.Value ? (string)reader["MotivoEliminarActivo"] : string.Empty
                    };

                    assets.Add(asset);
                }
            }
            return assets;
        }
        public List<object> GetAllAssetsWithDetailsDepreciacion()
        {
            List<object> assets = new List<object>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
            SELECT 
                a.ActivoID, 
                a.CodigoActivo, 
                na.NombreActivo_, 
                a.EstadoBaja, 
                c.CategoriaID, 
                c.NombreCategoria, 
                a.ValorAdquisicion, 
                a.FechaAdquisicion, 
                a.Numero_Depreciaciones, 
                c.VidaUtil, 
                c.ValoResidual,
                ISNULL(a.ValorAdquisicion - (d.Valor_depreciacion_anual * (a.Numero_Depreciaciones)), a.ValorAdquisicion) AS ValorDepreciacion
            FROM 
                ACTIVOFIJO a
                JOIN CATEGORIA c ON a.CategoriaID = c.CategoriaID
                JOIN NOMBREACTIVO na ON a.NombreActivoID = na.NombreActivoID
                LEFT JOIN (
                    SELECT 
                        ActivoID, 
                        Valor_depreciacion_anual,
                        ROW_NUMBER() OVER (PARTITION BY ActivoID ORDER BY FechaDesgaste DESC) AS rn
                    FROM 
                        DEPRECIACION
                ) d ON a.ActivoID = d.ActivoID AND d.rn = 1
            WHERE 
                a.EstadoBaja <> 'Eliminado'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var asset = new
                    {
                        ActivoID = (int)reader["ActivoID"],
                        CodigoActivo = (string)reader["CodigoActivo"],
                        NombreActivo = (string)reader["NombreActivo_"],
                        EstadoBaja = (string)reader["EstadoBaja"],
                        CategoriaID = (int)reader["CategoriaID"],
                        NombreCategoria = (string)reader["NombreCategoria"],
                        ValorAdquisicion = (decimal)reader["ValorAdquisicion"],
                        FechaAdquisicion = (DateTime)reader["FechaAdquisicion"],
                        NumeroDepreciaciones = (int)reader["Numero_Depreciaciones"],
                        VidaUtil = (int)reader["VidaUtil"],
                        ValoResidual = (decimal)reader["ValoResidual"],
                        ValorDepreciacion = (decimal)reader["ValorDepreciacion"]
                    };

                    assets.Add(asset);
                }
            }
            return assets;
        }
        public List<object> GetAllAssetsWithDetails_baja_reportes()
        {
            List<object> assets = new List<object>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
SELECT 
    a.ActivoID, a.CodigoActivo, na.NombreActivoID, na.NombreActivo_, a.EstadoBaja, 
    c.CategoriaID, c.NombreCategoria, u.UbicacionID, u.NombreUbicacion, 
    un.UnidadID, un.NombreUnidad, a.FechaAdquisicion, a.ValorAdquisicion, 
    a.Numero_Depreciaciones, a.DescripcionActivo, a.MotivoBajaActivo, 
    a.MotivoEliminarActivo
FROM ACTIVOFIJO a
JOIN CATEGORIA c ON a.CategoriaID = c.CategoriaID
JOIN UBICACION u ON a.UbicacionID = u.UbicacionID
JOIN UNIDAD un ON a.UnidadID = un.UnidadID
JOIN NOMBREACTIVO na ON a.NombreActivoID = na.NombreActivoID
WHERE a.EstadoBaja = 'Baja'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var asset = new
                    {
                        ActivoID = (int)reader["ActivoID"],
                        CodigoActivo = (string)reader["CodigoActivo"],
                        NombreActivoID = (int)reader["NombreActivoID"],
                        NombreActivo = (string)reader["NombreActivo_"],
                        EstadoBaja = (string)reader["EstadoBaja"],
                        CategoriaID = (int)reader["CategoriaID"],
                        NombreCategoria = (string)reader["NombreCategoria"],
                        UbicacionID = (int)reader["UbicacionID"],
                        NombreUbicacion = (string)reader["NombreUbicacion"],
                        UnidadID = (int)reader["UnidadID"],
                        NombreUnidad = (string)reader["NombreUnidad"],
                        FechaAdquisicion = (DateTime)reader["FechaAdquisicion"],
                        ValorAdquisicion = (decimal)reader["ValorAdquisicion"],
                        NumeroDepreciaciones = (int)reader["Numero_Depreciaciones"],
                        DescripcionActivo = reader["DescripcionActivo"] != DBNull.Value ? (string)reader["DescripcionActivo"] : string.Empty,
                        MotivoBajaActivo = reader["MotivoBajaActivo"] != DBNull.Value ? (string)reader["MotivoBajaActivo"] : string.Empty,
                        MotivoEliminarActivo = reader["MotivoEliminarActivo"] != DBNull.Value ? (string)reader["MotivoEliminarActivo"] : string.Empty
                    };

                    assets.Add(asset);
                }
            }
            return assets;
        }        
        public List<object> GetAllAssetsWithDepreciationRecords()
        {
            List<object> assets = new List<object>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
SELECT 
    a.ActivoID, a.CodigoActivo, na.NombreActivoID, na.NombreActivo_, a.EstadoBaja, 
    c.CategoriaID, c.NombreCategoria, u.UbicacionID, u.NombreUbicacion, 
    un.UnidadID, un.NombreUnidad, a.FechaAdquisicion, a.ValorAdquisicion, 
    a.Numero_Depreciaciones, a.DescripcionActivo, a.MotivoBajaActivo, 
    a.MotivoEliminarActivo
FROM ACTIVOFIJO a
JOIN CATEGORIA c ON a.CategoriaID = c.CategoriaID
JOIN UBICACION u ON a.UbicacionID = u.UbicacionID
JOIN UNIDAD un ON a.UnidadID = un.UnidadID
JOIN NOMBREACTIVO na ON a.NombreActivoID = na.NombreActivoID
JOIN DEPRECIACION d ON a.ActivoID = d.ActivoID";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var asset = new
                    {
                        ActivoID = (int)reader["ActivoID"],
                        CodigoActivo = (string)reader["CodigoActivo"],
                        NombreActivoID = (int)reader["NombreActivoID"],
                        NombreActivo = (string)reader["NombreActivo_"],
                        EstadoBaja = (string)reader["EstadoBaja"],
                        CategoriaID = (int)reader["CategoriaID"],
                        NombreCategoria = (string)reader["NombreCategoria"],
                        UbicacionID = (int)reader["UbicacionID"],
                        NombreUbicacion = (string)reader["NombreUbicacion"],
                        UnidadID = (int)reader["UnidadID"],
                        NombreUnidad = (string)reader["NombreUnidad"],
                        FechaAdquisicion = (DateTime)reader["FechaAdquisicion"],
                        ValorAdquisicion = (decimal)reader["ValorAdquisicion"],
                        NumeroDepreciaciones = (int)reader["Numero_Depreciaciones"],
                        DescripcionActivo = reader["DescripcionActivo"] != DBNull.Value ? (string)reader["DescripcionActivo"] : string.Empty,
                        MotivoBajaActivo = reader["MotivoBajaActivo"] != DBNull.Value ? (string)reader["MotivoBajaActivo"] : string.Empty,
                        MotivoEliminarActivo = reader["MotivoEliminarActivo"] != DBNull.Value ? (string)reader["MotivoEliminarActivo"] : string.Empty
                    };

                    assets.Add(asset);
                }
            }
            return assets; 
        }
        public List<object> GetAllAssignedAssets()
        {
            List<object> assets = new List<object>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
SELECT 
    a.ActivoID, a.CodigoActivo, na.NombreActivoID, na.NombreActivo_, a.EstadoBaja, 
    c.CategoriaID, c.NombreCategoria, u.UbicacionID, u.NombreUbicacion, 
    un.UnidadID, un.NombreUnidad, a.FechaAdquisicion, a.ValorAdquisicion, 
    a.Numero_Depreciaciones, a.DescripcionActivo, a.MotivoBajaActivo, 
    a.MotivoEliminarActivo, p.PersonalID, p.NombrePersonal, p.Apellido, 
    p.Email, p.Telefono, asg.FechaAsignacion, asg.Observaciones
FROM ACTIVOFIJO a
JOIN CATEGORIA c ON a.CategoriaID = c.CategoriaID
JOIN UBICACION u ON a.UbicacionID = u.UbicacionID
JOIN UNIDAD un ON a.UnidadID = un.UnidadID
JOIN NOMBREACTIVO na ON a.NombreActivoID = na.NombreActivoID
JOIN ASIGNACION asg ON a.ActivoID = asg.ActivoID
JOIN PERSONAL p ON asg.PersonalID = p.PersonalID
WHERE a.EstadoBaja <> 'Eliminado'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var asset = new
                    {
                        ActivoID = (int)reader["ActivoID"],
                        CodigoActivo = (string)reader["CodigoActivo"],
                        NombreActivoID = (int)reader["NombreActivoID"],
                        NombreActivo = (string)reader["NombreActivo_"],
                        EstadoBaja = (string)reader["EstadoBaja"],
                        CategoriaID = (int)reader["CategoriaID"],
                        NombreCategoria = (string)reader["NombreCategoria"],
                        UbicacionID = (int)reader["UbicacionID"],
                        NombreUbicacion = (string)reader["NombreUbicacion"],
                        UnidadID = (int)reader["UnidadID"],
                        NombreUnidad = (string)reader["NombreUnidad"],
                        FechaAdquisicion = (DateTime)reader["FechaAdquisicion"],
                        ValorAdquisicion = (decimal)reader["ValorAdquisicion"],
                        NumeroDepreciaciones = (int)reader["Numero_Depreciaciones"],
                        DescripcionActivo = reader["DescripcionActivo"] != DBNull.Value ? (string)reader["DescripcionActivo"] : string.Empty,
                        MotivoBajaActivo = reader["MotivoBajaActivo"] != DBNull.Value ? (string)reader["MotivoBajaActivo"] : string.Empty,
                        MotivoEliminarActivo = reader["MotivoEliminarActivo"] != DBNull.Value ? (string)reader["MotivoEliminarActivo"] : string.Empty,
                        PersonalID = (int)reader["PersonalID"],
                        NombrePersonal = (string)reader["NombrePersonal"],
                        Apellido = (string)reader["Apellido"],
                        Email = (string)reader["Email"],
                        Telefono = (string)reader["Telefono"],
                        FechaAsignacion = (DateTime)reader["FechaAsignacion"],
                        Observaciones = reader["Observaciones"] != DBNull.Value ? (string)reader["Observaciones"] : string.Empty
                    };

                    assets.Add(asset);
                }
            }
            return assets;
        }
        public void AddAsset(ActivoFijo asset)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO ACTIVOFIJO (CodigoActivo, NombreActivoID, CategoriaID, FechaAdquisicion, ValorAdquisicion, UbicacionID, UnidadID, DescripcionActivo) " +
                    "VALUES (@CodigoActivo, @NombreActivoID, @CategoriaID, @FechaAdquisicion, @ValorAdquisicion, @UbicacionID, @UnidadID, @DescripcionActivo)", conn);

                cmd.Parameters.AddWithValue("@CodigoActivo", asset.CodigoActivo);
                cmd.Parameters.AddWithValue("@NombreActivoID", asset.NombreActivoID);
                cmd.Parameters.AddWithValue("@CategoriaID", asset.CategoriaID);
                cmd.Parameters.AddWithValue("@FechaAdquisicion", asset.FechaAdquisicion);
                cmd.Parameters.AddWithValue("@ValorAdquisicion", asset.ValorAdquisicion);
                cmd.Parameters.AddWithValue("@UbicacionID", asset.UbicacionID);
                cmd.Parameters.AddWithValue("@UnidadID", asset.UnidadID);
                //cmd.Parameters.AddWithValue("@EstadoBaja", asset.EstadoBaja);
                //cmd.Parameters.AddWithValue("@NumeroDepreciaciones", asset.NumeroDepreciaciones);
                cmd.Parameters.AddWithValue("@DescripcionActivo", asset.DescripcionActivo);
                //cmd.Parameters.AddWithValue("@MotivoBajaActivo", asset.MotivoBajaActivo);
                //cmd.Parameters.AddWithValue("@MotivoEliminarActivo", asset.MotivoEliminarActivo);
                cmd.ExecuteNonQuery();
            }
        }
        public void UpdateAsset(ActivoFijo asset)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE ACTIVOFIJO SET CodigoActivo = @CodigoActivo, NombreActivoID = @NombreActivoID, CategoriaID = @CategoriaID, FechaAdquisicion = @FechaAdquisicion, ValorAdquisicion = @ValorAdquisicion, UbicacionID = @UbicacionID, UnidadID = @UnidadID, DescripcionActivo = @DescripcionActivo WHERE ActivoID = @ActivoID", conn);

                cmd.Parameters.AddWithValue("@ActivoID", asset.ActivoID);
                cmd.Parameters.AddWithValue("@CodigoActivo", asset.CodigoActivo);
                cmd.Parameters.AddWithValue("@NombreActivoID", asset.NombreActivoID);
                cmd.Parameters.AddWithValue("@CategoriaID", asset.CategoriaID);
                cmd.Parameters.AddWithValue("@FechaAdquisicion", asset.FechaAdquisicion);
                cmd.Parameters.AddWithValue("@ValorAdquisicion", asset.ValorAdquisicion);
                cmd.Parameters.AddWithValue("@UbicacionID", asset.UbicacionID);
                cmd.Parameters.AddWithValue("@UnidadID", asset.UnidadID);
                cmd.Parameters.AddWithValue("@DescripcionActivo", asset.DescripcionActivo);
                cmd.ExecuteNonQuery();
            }
        }
        public void UpdateAssetStatusbaja(int activoID, string motivoBajaActivo)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE ACTIVOFIJO SET EstadoBaja = 'Baja', MotivoBajaActivo = @MotivoBajaActivo WHERE ActivoID = @ActivoID", conn);

                cmd.Parameters.AddWithValue("@ActivoID", activoID);
                cmd.Parameters.AddWithValue("@MotivoBajaActivo", motivoBajaActivo);

                cmd.ExecuteNonQuery();
            }
        }
        public void UpdateAssetToEliminated(int activoID, string motivoEliminarActivo)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE ACTIVOFIJO SET EstadoBaja = 'Eliminado', MotivoEliminarActivo = @MotivoEliminarActivo WHERE ActivoID = @ActivoID", conn);

                cmd.Parameters.AddWithValue("@ActivoID", activoID);
                cmd.Parameters.AddWithValue("@MotivoEliminarActivo", motivoEliminarActivo);

                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteAsset(int assetId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM ACTIVOFIJO WHERE ActivoID = @ActivoID", conn);
                cmd.Parameters.AddWithValue("@ActivoID", assetId);
                cmd.ExecuteNonQuery();
            }
        }
        public ActivoFijo GetActivoByCodigo(string codigo)
        {
            ActivoFijo activo = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM ACTIVOFIJO WHERE CodigoActivo = @CodigoActivo", conn);
                cmd.Parameters.AddWithValue("@CodigoActivo", codigo);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        activo = new ActivoFijo
                        {
                            ActivoID = (int)reader["ActivoID"],
                            CodigoActivo = (string)reader["CodigoActivo"],
                            NombreActivoID = (int)reader["NombreActivoID"], // Cambiado a int
                            CategoriaID = (int)reader["CategoriaID"],
                            FechaAdquisicion = (DateTime)reader["FechaAdquisicion"],
                            ValorAdquisicion = (decimal)reader["ValorAdquisicion"],
                            UbicacionID = (int)reader["UbicacionID"],
                            UnidadID = (int)reader["UnidadID"],
                            EstadoBaja = reader["EstadoBaja"] != DBNull.Value ? (string)reader["EstadoBaja"] : "Inactivo", // Valor por defecto
                            NumeroDepreciaciones = reader["NumeroDepreciaciones"] != DBNull.Value ? (int)reader["NumeroDepreciaciones"] : 0 // Nuevo atributo
                        };

                        // Relaciones
                        activo.Categoria = new Categoria { /* Asignar propiedades según sea necesario */ };
                        activo.Ubicacion = new Ubicacion { /* Asignar propiedades según sea necesario */ };
                        activo.Unidad = new Unidad { /* Asignar propiedades según sea necesario */ };
                        activo.NombreActivo = new NombreActivo { /* Asignar propiedades según sea necesario */ };
                    }
                }
            }
            return activo;
        }
    }
}
