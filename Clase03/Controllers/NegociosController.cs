using Clase03.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clase03.Controllers
{
    public class NegociosController : Controller
    {
        IEnumerable<Cliente> clientes()
        {
            List<Cliente> temporal = new List<Cliente>();
            using (SqlConnection cn = new
                SqlConnection(ConfigurationManager.ConnectionStrings["cadena"].ConnectionString))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("exec usp_clientes", cn);

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    temporal.Add(new Cliente()
                    {
                        idcliente = dr.GetInt32(0),
                        nombrecia = dr.GetString(1),
                        direccion = dr.GetString(2),
                        idpais = dr.GetString(3),
                        fono = dr.GetString(4)
                    });
                }
                dr.Close();
            }
            return temporal;
        }
        public ActionResult ListaClientes()
        {
            return View(clientes());
        }
    }
}