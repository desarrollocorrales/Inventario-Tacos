using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvenTacos.Modelos
{
    public static class ConnectionStrings
    {
        public static string MSSQL =
            "metadata=res://*/Entity.MSSQL.SoftRestaurantModelo.csdl|" +
            "res://*/Entity.MSSQL.SoftRestaurantModelo.ssdl|" +
            "res://*/Entity.MSSQL.SoftRestaurantModelo.msl;" +
            "provider=System.Data.SqlClient;" +
            "provider connection string=" +
            string.Format("'data source={0};", Properties.Settings.Default.MSSQL.Servidor) +
            string.Format(" initial catalog={0};", Properties.Settings.Default.MSSQL.BaseDeDatos) +
            string.Format(" user id={0};", Properties.Settings.Default.MSSQL.Usuario) +
            string.Format(" password={0};'", Properties.Settings.Default.MSSQL.Contraseña);

        public static string MySQL =
            "metadata=res://*/Entity.MySQL.TacosInventarioModel.csdl|" +
            "res://*/Entity.MySQL.TacosInventarioModel.ssdl|" +
            "res://*/Entity.MySQL.TacosInventarioModel.msl;" +
            "provider=MySql.Data.MySqlClient;" +
            "provider connection string=" +
            string.Format("'server={0};", Properties.Settings.Default.MySQL.Servidor) +
            string.Format(" user id={0};", Properties.Settings.Default.MySQL.Usuario) +
            string.Format(" port={0};", Properties.Settings.Default.MySQL.Puerto) +
            string.Format(" database={0};", Properties.Settings.Default.MySQL.BaseDeDatos) +
            string.Format(" password={0};'", Properties.Settings.Default.MySQL.Contraseña);
    }
}
