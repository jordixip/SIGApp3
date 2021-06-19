using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

using Xamarin.Forms;

namespace SIGApp3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        private void onclick(object sender, EventArgs e)
        {
            // recuperar imagen
            // abrir conexion con la base de datos
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Do work here; connection closed on following line.
            }
            // hacer el insert into
            // cerrar conexion con la base de datos
        }




    }
}