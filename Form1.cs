using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dante3
{

    public partial class Form1 : Form
    {
        private int cero = 0;
        private bool f = false;
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

        #region.metodos
        bool prueba()
        {
            string cadena = this.CmbBool.SelectedItem.ToString();
            if (cadena == "true")
            {
                return  true;

            }
            else
            {
                return false;
            }
        }
  
        

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
            //falta jugar con esto
            //deberia ser una clase o que aca?
                        
            int REALid = Convert.ToInt32(TxtId.Text);
            string nombre = TxtNombre.Text;
            string apellido = TxtApellido.Text;
            string problema = TxtProblema.Text;
            string resolucion = TxtResolucion.Text;
            string remuneracion = TxtRemuneracion.Text;
            string fecha = TxtFecha.Text;
            DateTime FechaReal = DateTime.Parse(fecha);
            bool f = prueba();



            OleDbConnection CN = new OleDbConnection(cadena);
       
            string QuerieUpdatePrueba = "UPDATE Clientes SET Nombre = 'Davidbec' WHERE Id =" + REALid;
            string QuerieUpdate = "UPDATE Clientes SET Nombre=(?),Apellido=(?),Problema=(?),Resolucion=(?),Estado=(?),Remuneracion=(?),Fecha = (?) WHERE Id =" + REALid;

            
            

            CN.Open();
            OleDbCommand Micomando = new OleDbCommand(QuerieUpdate, CN);

            //parametros
            Micomando.Parameters.Add("?",nombre);
            Micomando.Parameters.Add("?", apellido);
            Micomando.Parameters.Add("?", problema);
            Micomando.Parameters.Add("?", resolucion);
            Micomando.Parameters.Add("?", f); //no entiendo porque anda y tampoco porque no andaba
            Micomando.Parameters.Add("?", remuneracion);
            Micomando.Parameters.Add("?", FechaReal); // ya anda

            int resultado = Micomando.ExecuteNonQuery();
            CN.Close();

        }
        private void Eliminar()
        {  
         string ID = TxtId.Text;
         //string nombre2 = TxtNombre.Text;
         int REALid = Convert.ToInt32(ID);
         OleDbConnection CN = new OleDbConnection(cadena);
         string QuerieDelete = "DELETE FROM Clientes WHERE Id =" + ID;
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
            DateTime FechaReal = DateTime.Parse(fecha);
            bool f = prueba();

            string QuerieInsertPrueba = "INSERT INTO Clientes (Estado) VALUES (?)";
            string QuerieInsert = "INSERT INTO Clientes (Nombre,Apellido,Problema,Resolucion,Estado,Remuneracion,Fecha) VALUES (?,?,?,?,?,?,?)";
            OleDbCommand Micomando = new OleDbCommand(QuerieInsert, CN);
           
            //podria hacer un metodo para esto 
            Micomando.Parameters.Add("?", nombre);
            Micomando.Parameters.Add("?", apellido);
            Micomando.Parameters.Add("?", problema);
            Micomando.Parameters.Add("?", resolucion);
            Micomando.Parameters.Add("?", f); //no entiendo porque anda y tampoco porque no andaba
            Micomando.Parameters.Add("?", remuneracion);
            Micomando.Parameters.Add ("?", FechaReal); // ya anda
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
        public void BotonEliminar()
        {
            Eliminar();
            CargarGrid();
            LimpiezaTxts();
        }
        
        public void BotonEditar()
        {
            Editar();
            CargarGrid();
            LimpiezaTxts();
        }
        public void BotonAgregar()
        {
            Agregar();
            CargarGrid();
            LimpiezaTxts();
        }
        public void LimpiezaCombo()
        {
            Cmb1.Items.Clear();
            //Cmb1.DataSource = null;
        }

        public void LimpiezaTxts()
        {
            TxtId.Text = "";
            TxtApellido.Text = "";
            TxtFecha.Text = "";
            TxtNombre.Text = "";
            TxtProblema.Text = "";
            TxtRemuneracion.Text = "";
            TxtResolucion.Text = "";
            TxtId.Text = "";
            CmbBool.Text = "";
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
        #endregion
        #region.CosasDelForm
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // CargarCombo();
            //consultafallida();
           CargarGrid();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            LimpiezaCombo();
            consultaNombres();
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            LimpiezaCombo();
            consultaApellidos();
        }

        private void dtgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            //boton de editar
            if (Btn3.Text == "EDITAR")
            {
                button1.Visible = false;
                button2.Visible = false;

                // BotonEditar();
                Btn3.Text = "MODIFICAR";
            }
            else
            {  ///BOTON DE editar
                BotonEditar();
                Btn3.Text = "EDITAR";
                button1.Visible = true;
                button2.Visible = true;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "AGREGAR" )
            {
                button1.Text = "GUARDAR";
                Btn3.Visible = false;
                button2.Visible = false;
              
            }
            else 
            {  ///BOTON DE AGREGAR
                  BotonAgregar();
                button1.Text = "AGREGAR";
                Btn3.Visible = true;
                button2.Visible = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //BOTON DE ELIMINAR
            
            if (button2.Text=="ELIMINAR")
            {
                button1.Visible=false;
                Btn3.Visible=false;
                button2.Text = "DAR DE BAJA";
           
            }
            else
            {  ///BOTON DE eliminar
                BotonEliminar();
                button2.Text = "ELIMINAR";
                Btn3.Visible = true;
                button1.Visible = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            //if (checkBox1.Checked)
            //{
            //    lblFinalizacion.Text = "HECHO";
            //    f = true;
            //}
            //else 
            //{
            //    lblFinalizacion.Text = "NO HACER NADA";
            //    f = false;
            //}
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dtgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             cero = e.RowIndex;// contiene el indice de la fila selecionada
            int c = e.ColumnIndex;// contiene el indice de la columna selecionada

            if (cero != -1)//solo hago que aparezca la descripcion si la fila es mayor a -1 //y una columna que exista osea mayor a 0// no funcio no
            {   
                var valor8 = dtgv1.Rows[cero].Cells[5].Value;
                var valor7 = dtgv1.Rows[cero].Cells[6].Value;
                var valor6 = dtgv1.Rows[cero].Cells[7].Value;
                var valor5 = dtgv1.Rows[cero].Cells[4].Value; 
                var valor4 = dtgv1.Rows[cero].Cells[3].Value; 
                var valor3 = dtgv1.Rows[cero].Cells[2].Value; 
                var valor2 = dtgv1.Rows[cero].Cells[1].Value; 
                var valor = dtgv1.Rows[cero].Cells[0].Value; // ID en columna 0
                if (valor != null)
                    TxtId.Text = valor.ToString(); // Lo convierte a texto 
                else
                {
                   // TxtId.Text = ""; // Limpia si no hay valor
                    LimpiezaTxts();
                }
                // TxtId.Text= (string)dtgv1.Rows[cero].Cells[1].Value;// paso el valor a string 
                TxtNombre.Text = valor2.ToString();
                TxtApellido.Text = valor3.ToString();
                TxtProblema.Text = valor4.ToString();
                TxtRemuneracion.Text = valor7.ToString();
                TxtResolucion.Text = valor5.ToString();
                TxtFecha.Text = valor6.ToString();
                CmbBool.Text = valor8.ToString();
                 
            }
        
        }
        #endregion

        private void lblFinalizacion_Click(object sender, EventArgs e)
        {

        }

        private void CmbBool_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //prueba();
        }
    }
}
