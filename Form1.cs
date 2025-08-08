using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dante3
{

    public partial class Form1 : Form
    {


        ///cadena es la ruta del archivo de acces
        ///se obtiene:
        ///1-llendo a origenes de datos
        ///2-bases de datos
        ///3-conjunto de datos
        ///4- y tocando el cheklist aparecera la ruta
        ///5- pasarlo a una variable para manejo rapido
        static string cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\CLIENTES.accdb";
  
         /// Conectar db
         /// primero se la instacia con la clase OleDb 
         /// poner en el parametro la ruta (cadena)
         
    
         OleDbConnection conect= new OleDbConnection(cadena);
        /// luego instaciar los demas clases del oledb
        /// va la clase  comand (la encargada de recibir comandos o querys )
        /// y el dataadapter (donde va el comand )
        OleDbCommand comd = new OleDbCommand();
        OleDbDataAdapter adapter = new OleDbDataAdapter();
        public void consultaNombres()
        {
            OleDbConnection miconexion = new OleDbConnection(cadena);

            string querie = "SELECT Nombre FROM Clientes";

            OleDbCommand comando = new OleDbCommand(querie);
            comando.Connection = miconexion;
            miconexion.Open();
            OleDbDataReader midatareader = comando.ExecuteReader();
                while (midatareader.Read())
                {
                Cmb1.Items.Add(midatareader["Nombre"].ToString());
                }
            miconexion.Close();
        }
        public void ConsultaInTxt()
        {
           // string ruta = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\CLIENTES.accdb";
            OleDbConnection Miconexion = new OleDbConnection(cadena);
            string querieGrid = "SELECT Nombre FROM Clientes";
            // ESTE NO ERA JAJA OleDbCommand Micomando = new OleDbCommand(querieGrid,Miconexion);
            OleDbDataAdapter MiAdaptador = new OleDbDataAdapter(querieGrid,Miconexion);
            DataSet Midataset = new DataSet();
            MiAdaptador.Fill(Midataset,"Clientes");//jugar con esto
            foreach (DataRow fila in Midataset.Tables[0].Rows)
            {
                TxtId.Text += fila["Nombre"].ToString() 
                    ;
                Midataset = null;
            }
        }
        public void consultaApellidos()
        {
            OleDbConnection miconexion = new OleDbConnection(cadena);

            string querie2 = "SELECT Apellido FROM Clientes";

            OleDbCommand comando = new OleDbCommand(querie2);
            comando.Connection = miconexion;
            miconexion.Open();
            OleDbDataReader midatareader = comando.ExecuteReader();
            while (midatareader.Read())
            {
                Cmb1.Items.Add(midatareader["Apellido"].ToString());
            }
            miconexion.Close();
        }

        public DataTable CargaParcial()
        {
            ///istancio la datatable y hago el return para solucionar el error de la funcion
            DataTable dt = new DataTable();
            ///se inicializa el comando y se lo conecta
            comd = new OleDbCommand();
            comd.Connection = conect;
            ///instrucion que hara (query)
            comd.CommandText = "SELECT Nombre FROM Clientes";

            //se inicializa el adaptador y se le pone el comando que tendra junto a la conexion
            adapter = new OleDbDataAdapter(comd);

            // luego se abre la conexion y carga en el adaptador la tabla
            conect.Open();
            adapter.Fill(dt);
            conect.Close();

            return dt;
        }
        private void Editar()
        {

            OleDbConnection CN = new OleDbConnection(cadena);
       
            string QuerieUpdate = "UPDATE Clientes SET Nombre = 'Davidbec' WHERE Id =" + 1;
          
            CN.Open();
            OleDbCommand Micomando = new OleDbCommand(QuerieUpdate, CN);
            int resultado = Micomando.ExecuteNonQuery();
            CN.Close();

        }
        private void Eliminar()
        {

            OleDbConnection CN = new OleDbConnection(cadena);
            string QuerieDelete = "DELETE FROM Clientes WHERE Id =" + 1;

            CN.Open();
            OleDbCommand Micomando = new OleDbCommand(QuerieDelete, CN);
            int resultado = Micomando.ExecuteNonQuery();
            CN.Close();

        }

        private void Agregar()
        {

            OleDbConnection CN = new OleDbConnection(cadena) ;
            //deberia ser una clase o que aca?
            string nombre= TxtNombre.Text;
            string apellido = TxtApellido.Text;
            string problema = TxtProblema.Text;
            string resolucion = TxtResolucion.Text;
            string remuneracion = TxtRemuneracion.Text;
            string fecha = TxtFecha.Text;
            

            string QuerieInsert = "INSERT INTO Clientes (Nombre,Apellido,Problema,Resolucion,Remuneracion) VALUES (?,?,?,?,?)";
            OleDbCommand Micomando = new OleDbCommand(QuerieInsert, CN);
           
            //podria hacer un metodo para esto 
            Micomando.Parameters.AddWithValue("?", nombre);
            Micomando.Parameters.Add("?", apellido);
            Micomando.Parameters.Add("?", problema);
            Micomando.Parameters.Add("?", resolucion);
            Micomando.Parameters.Add("?", remuneracion);
            //Micomando.Parameters.Add ("?", fecha); no hay una clase string para esto debo tener otro input
            try
            {
                CN.Open();

                int resultado = Micomando.ExecuteNonQuery();
                CN.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("hubo un problema: ", ex.Message); //deberia estar mejor pero ex no quiere ser string
            }
        }

        /// funcion que returna una tabla de la base de datos

        public DataTable CargarDatos()
        {
            ///istancio la datatable y hago el return para solucionar el error de la funcion
            DataTable dt2 = new DataTable();
            ///se inicializa el comando y se lo conecta
            comd = new OleDbCommand();
            comd.Connection = conect;
            ///instrucion que hara (query)
            comd.CommandText = "SELECT * FROM Clientes";

            //se inicializa el adaptador y se le pone el comando que tendra junto a la conexion
            adapter = new OleDbDataAdapter(comd);

            // luego se abre la conexion y carga en el adaptador la tabla
            conect.Open();
            adapter.Fill(dt2);
            conect.Close();

            return dt2;
        }
    
     
        public void CargarCombo()
        {
            DataTable dt = CargarDatos();
            Cmb1.DataSource = dt;
            Cmb1.DisplayMember = "Nombre";
            Cmb1.ValueMember = "Id";
        }
        public void CargarGrid()
        {
            DataTable dt = CargarDatos();
            dtgv1.DataSource = dt;
            
            
        }
        public void Consulta1Grid()
        {
            DataTable dt2 = CargaParcial();
            dtgv1.DataSource= dt2;
        }
        public void LimpiezaGrida ()
        {
            dtgv1.DataSource = null;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // CargarCombo();
            //consultafallida();
           // CargarGrid();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            consultaNombres();
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            consultaApellidos();
        }

        private void dtgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            //boton de editar
            Editar();
            CargarGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ///BOTON DE AGREGAR
            Agregar();
            CargarGrid();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //BOTON DE ELIMINAR
            Eliminar();
            CargarGrid();
        }
    }
}
