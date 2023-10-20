using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLopezIE
{
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
            PopulateTreeView();
        }
        public void PopulateTreeView()
        {

            // Declara una variable rootNode que representará el nodo raíz del TreeView.
            TreeNode rootNode;


            //Crea un objeto DirectoryInfo que apunta a la carpeta.
            DirectoryInfo info = new DirectoryInfo(@"../../Resources");

            //Verifica si la carpeta especificada en info realmente existe en el sistema de archivos.
            if (info.Exists)
            {

                //Crea un nodo en el TreeView con el nombre de la carpeta info.Name.
                rootNode = new TreeNode(info.Name);

                //Asigna el objeto info como un "tag" al nodo rootNode.Esto se usa para adjuntar información adicional a un nodo.
                rootNode.Tag = info;

                //Llama al método GetDirectories para llenar los nodos del TreeView con subdirectorios y archivos dentro de info.
                GetDirectories(info.GetDirectories(), rootNode);

                //Agrega el nodo rootNode al TreeView llamado tvwProveedores.
                tvwProveedores.Nodes.Add(rootNode);
            }
        }

        //Este método se encarga de llenar el TreeView con subdirectorios y archivos dentro de un directorio específico.
        public void GetDirectories(DirectoryInfo[] subDirs,

            TreeNode nodeToAddTo)
        {

            //Declara una variable aNode que representará un nodo del TreeView.
            TreeNode aNode;

            //Declara un arreglo de objetos DirectoryInfo que representarán subdirectorios dentro del directorio actual.
            DirectoryInfo[] subSubDirs;

            //Inicia un bucle foreach para iterar a través de los directorios subDir en el arreglo subDirs.
            foreach (DirectoryInfo subDir in subDirs)
            {

                //Crea un nodo con el nombre del directorio subDir.Name
                aNode = new TreeNode(subDir.Name);

                //Obtiene los subdirectorios dentro del directorio actual y los almacena en subSubDirs.
                subSubDirs = subDir.GetDirectories();

                //Verifica si hay subdirectorios dentro del directorio actual.
                if (subSubDirs.Length != 0)
                {

                    //Llama recursivamente al método GetDirectories para llenar los subdirectorios del directorio actual.
                    GetDirectories(subSubDirs, aNode);
                }

                //Agrega el nodo aNode al nodo padre nodeToAddTo, que es un nodo del TreeView.
                nodeToAddTo.Nodes.Add(aNode);
            }
        }
        public void tvwProveedores_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            {

                //Esta línea crea una variable newSelected y la inicializa con el nodo que se ha seleccionado en el TreeView.
                TreeNode newSelected = e.Node;

                //Esta línea borra todos los elementos existentes en el ListView llamado lstProveedores.Esto se hace para limpiar cualquier contenido anterior antes de mostrar los nuevos datos.
                lstProveedores.Items.Clear();

                //Aquí se obtiene el objeto DirectoryInfo que se adjuntó al nodo newSelected como un "tag".
                DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;

                //Se declara un arreglo de objetos ListViewSubItem, que se utilizarán para agregar subelementos a los elementos del ListView.
                ListViewItem.ListViewSubItem[] subItems;

                //Se declara una variable item que se utilizará para representar cada elemento del ListView.Se inicializa como null.
                ListViewItem item = null;

                //Inicia un bucle para iterar a través de los subdirectorios del directorio representado por nodeDirInfo.
                foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
                {

                    //En cada iteración del bucle, se crea un nuevo elemento ListViewItem con el nombre del subdirectorio dir.Name.

                    item = new ListViewItem(dir.Name);

                    //Se crea un arreglo de objetos ListViewSubItem llamado subItems que contiene información adicional para el elemento del ListView.En este caso, se agrega un subelemento con la etiqueta "Directory" y la fecha de último acceso del subdirectorio.
                    subItems = new ListViewItem.ListViewSubItem[]

                        {new ListViewItem.ListViewSubItem(item, "Directory"), new ListViewItem.ListViewSubItem(item,dir.LastAccessTime.ToShortDateString())};

                    //Se agregan los subelementos contenidos en el arreglo subItems al elemento item.
                    item.SubItems.AddRange(subItems);

                    //Se agrega el elemento item al ListView llamado lstProveedores.
                    lstProveedores.Items.Add(item);
                }



                //El segundo bucle foreach es similar al primero, pero esta vez itera a través de los archivos en el directorio representado por nodeDirInfo.Se crea un elemento ListViewItem para cada archivo y se agregan subelementos con la etiqueta "File" y la fecha de último acceso.
                foreach (FileInfo file in nodeDirInfo.GetFiles())
                {
                    item = new ListViewItem(file.Name, 1);

                    subItems = new ListViewItem.ListViewSubItem[]
                        { new ListViewItem.ListViewSubItem(item, "File"),
             new ListViewItem.ListViewSubItem(item,
                file.LastAccessTime.ToShortDateString())};

                    item.SubItems.AddRange(subItems);
                    lstProveedores.Items.Add(item);
                }

                //Esta línea ajusta automáticamente el tamaño de las columnas del ListView para que se ajusten al contenido.En este caso, se utiliza HeaderSize, lo que significa que el tamaño se ajusta según el encabezado de la columna.Esto asegura que las columnas se ajusten correctamente al contenido de los elementos.
                lstProveedores.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }
        string leerLinea;
        string[] separarDatos;
        private bool grillaCreada = false;
        public static int pos = 0;
        //Esta línea obtiene el índice de la fila actualmente seleccionada en el DataGridView(dgvProveedores) y lo almacena en la variable pos.El índice se refiere a la posición de la fila en el DataGridView.
        public void dgvProveedores1_CellClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Asigna el valor de la celda en la columna 0 (primera columna) de la fila con el índice pos al campo de texto txtModificarNumero en el formulario modificarProveedor.Esto parece ser una operación para mostrar información relacionada con un proveedor en el formulario de modificación
            pos = dgvProveedores1.CurrentRow.Index;
            //Estas líneas asignan valores de celdas específicas en el DataGridView a campos de texto en el formulario modificarProveedor.Cada línea se refiere a una columna diferente en el DataGridView, y los valores se extraen de la fila seleccionada con el índice pos.
            txtModificarNumero.Text = dgvProveedores1[0, pos].Value.ToString();
            txtModificarEntidad.Text = dgvProveedores1[1, pos].Value.ToString();
            txtModificarApertura.Text = dgvProveedores1[2, pos].Value.ToString();
            txtModificarNExpediente.Text = dgvProveedores1[3, pos].Value.ToString();
            txtModificarJuzgado.Text = dgvProveedores1[4, pos].Value.ToString();
            txtModificarJurisdiccion.Text = dgvProveedores1[5, pos].Value.ToString();
            txtModificarDireccion.Text = dgvProveedores1[6, pos].Value.ToString();
            txtModificarLiquidadorResponsable.Text = dgvProveedores1[7, pos].Value.ToString();
        }

        private void lstProveedores_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            //Esto verifica si la variable booleana grillaCreada es false. Si es la primera vez que se carga la grilla(es decir, grillaCreada es false), se ejecutará el código dentro de este bloque.
            if (!grillaCreada)
            {
                //Se crea un objeto StreamReader llamado sr para leer el archivo CSV llamado "Lista.csv".
                StreamReader sr = new StreamReader(@"../../Resources/Lista.csv");
                //Declara una variable leerLinea para almacenar una línea del archivo CSV.
                string leerLinea;
                //Declara un arreglo de cadenas llamado separarDatos para dividir los datos de una línea en campos separados por el carácter; (punto y coma).
                string[] separarDatos;
                //Lee la primera línea del archivo CSV y la almacena en la variable leerLinea.
                leerLinea = sr.ReadLine();
                //Divide la línea leída en campos utilizando el carácter ; como delimitador y almacena los campos en el arreglo separarDatos.Esto se hace asumiendo que el archivo CSV tiene campos separados por punto y coma.
                separarDatos = leerLinea.Split(';');
                //Inicia un bucle for que recorre los elementos en el arreglo separarDatos.
                for (int indice = 0; indice < separarDatos.Length; indice++)
                {
                    //Agrega una columna al DataGridView(dgvProveedores) utilizando el valor en separarDatos[indice] como nombre de la columna.Esto crea las columnas en el DataGridView basadas en los encabezados del archivo CSV.
                    dgvProveedores1.Columns.Add(separarDatos[indice], separarDatos[indice]);
                }
                //Inicia un bucle while que se ejecuta mientras no se llegue al final del archivo CSV.
                while (sr.EndOfStream == false)
                {
                    //Lee la siguiente línea del archivo CSV y la almacena en la variable leerLinea.
                    leerLinea = sr.ReadLine();
                    //Divide la nueva línea en campos y almacena los campos en el arreglo separarDatos.
                    separarDatos = leerLinea.Split(';');
                    //Agrega una nueva fila al DataGridView(dgvProveedores) utilizando los datos en separarDatos.
                    dgvProveedores1.Rows.Add(separarDatos);
                }
                //Cierra el archivo CSV después de leer todos los datos.
                sr.Close();
                //Establece la variable grillaCreada como true para indicar que la grilla se ha creado y cargado con los datos del archivo CSV.
                grillaCreada = true;
            }


            //Inicio del bloque de código que se ejecuta si grillaCreada es true.
            else
            {
                //Borra todas las filas del DataGridView(dgvProveedores) para limpiar los datos existentes.
                dgvProveedores.Rows.Clear();
                //Borra todas las columnas del DataGridView para limpiar los encabezados de columna existentes.
                dgvProveedores.Columns.Clear();
                //Se repite el proceso para abrir nuevamente el archivo CSV, leer los encabezados y datos, y agregarlos al DataGridView.
                StreamReader sr = new StreamReader(@"../../Resources/Lista.csv");
                string leerLinea;
                string[] separarDatos;
                leerLinea = sr.ReadLine();
                separarDatos = leerLinea.Split(';');
                for (int indice = 0; indice < separarDatos.Length; indice++)
                {
                    dgvProveedores.Columns.Add(separarDatos[indice], separarDatos[indice]);
                }
                while (sr.EndOfStream == false)
                {
                    leerLinea = sr.ReadLine();
                    separarDatos = leerLinea.Split(';');
                    dgvProveedores.Rows.Add(separarDatos);
                }
                sr.Close();
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMenu M = new frmMenu();
            this.Hide();
            M.Show();
        }

        //En esta línea se declara una variable estática pública llamada rutaArchivo y se le asigna la ruta del archivo "../../Resources/Lista.csv". Esta variable almacena la ruta del archivo CSV que se va a leer y modificar en el resto del código.
        public static string rutaArchivo = @"../../Resources/Lista.csv";
        private void button2_Click(object sender, EventArgs e)
        {

            //Se crea una variable llamada posicion que toma el valor de la propiedad pos del formulario frmProveedores y la convierte a una cadena (ToString). La variable pos almacena el identificador.
            string posicion = frmProveedores.pos.ToString();

            //Se crea una lista de cadenas llamada lista. Esta lista se utilizará para almacenar las líneas del archivo CSV después de modificarlas.

            List<string> lista = new List<string>();

            //Aquí se crea un objeto StreamReader llamado leer para leer el contenido del archivo CSV especificado en rutaArchivo. La instrucción using garantiza que el objeto leer se cierre correctamente después de su uso.
            using (StreamReader leer = new StreamReader(rutaArchivo))
            {

                //Se declara una variable linea para almacenar cada línea leída del archivo CSV.
                string linea;

                //Esto inicia un bucle while que leerá cada línea del archivo hasta que no haya más líneas que leer.
                while ((linea = leer.ReadLine()) != null)
                {

                    //Cada línea se divide en un array de cadenas llamado parametros utilizando el carácter ; como separador. Esto asume que las líneas del archivo CSV están separadas por punto y coma.
                    string[] parametros = linea.Split(';');

                    //Se verifica si el primer elemento en parametros (probablemente algún tipo de identificador) es diferente de la variable posicion.
                    if (parametros[0] != posicion)
                    {
                        //Si el identificador no coincide, la línea original se agrega a la lista lista.
                        lista.Add(linea);
                    }
                    //Si el identificador coincide, se crea una nueva línea concatenando algunos valores de campos de entrada de textoy y se agrega al lista.
                    else
                    {
                        //Después de terminar de leer y procesar todas las líneas del archivo CSV, se cierra el objeto StreamReader.
                        string lineaDos = "" + ";" + "" + ";" + "" + ";" + "" + ";" + "" + ";" + "" + ";" + "" + ";" + "" + ";";
                        lista.Add(lineaDos);
                    }
                }
            }

            //Luego, se crea un objeto StreamWriter llamado escribir para escribir datos en el mismo archivo (rutaArchivo) en el que se leyeron los datos.
            using (StreamWriter escribir = new StreamWriter(rutaArchivo))
            {

                //Se recorre la lista lista y se escribe cada elemento en el archivo usando escribir.WriteLine(linea).
                foreach (string linea in lista)
                {
                    escribir.WriteLine(linea);
                }
            }

            //Este código está leyendo un archivo CSV, realizando modificaciones en función de un identificador (posicion) y escribiendo las líneas modificadas o no modificadas de vuelta en el mismo archivo CSV.
            MessageBox.Show("Proveedor Modificado");

            txtModificarNumero.Clear();
            txtModificarEntidad.Clear();
            txtModificarApertura.Clear();
            txtModificarNExpediente.Clear();
            txtModificarJuzgado.Clear();
            txtModificarJurisdiccion.Clear();
            txtModificarDireccion.Clear();
            txtModificarLiquidadorResponsable.Clear();
        }
        int numGuia = 158;
        clseArchivo grabado = new clseArchivo();

        private void button3_Click(object sender, EventArgs e)
        {




            if (txtModificarEntidad.Text == "")
            {
                MessageBox.Show("Campo Entidad vacio");
                txtModificarEntidad.Focus();
            }
            else
            {
                if (txtModificarApertura.Text == "")
                {
                    MessageBox.Show("Campo Apertura vacio");
                    txtModificarApertura.Focus();
                }
                else
                {
                    if (txtModificarNExpediente.Text == "")
                    {
                        MessageBox.Show("Campo número de expediente vacio");
                        txtModificarNExpediente.Focus();
                    }
                    else
                    {
                        if (txtModificarJuzgado.Text == "")
                        {
                            MessageBox.Show("Campo Juzgado vacio");
                            txtModificarJuzgado.Focus();
                        }
                        else
                        {
                            if (txtModificarJurisdiccion.Text == "")
                            {
                                MessageBox.Show("Campo Jurisdiccion vacio");
                                txtModificarJurisdiccion.Focus();
                            }
                            else
                            {
                                if (txtModificarDireccion.Text == "")
                                {
                                    MessageBox.Show("Campo Direccion vacio");
                                    txtModificarDireccion.Focus();
                                }
                                else
                                {
                                    if (txtModificarLiquidadorResponsable.Text == "")
                                    {
                                        MessageBox.Show("Campo Liquidador responsable vacio");
                                        txtModificarLiquidadorResponsable.Focus();
                                    }
                                    else
                                    {
                                        string[] datosProveedores = new string[] { numGuia.ToString(), txtModificarEntidad.Text, txtModificarApertura.Text, txtModificarNExpediente.Text, txtModificarJuzgado.Text, txtModificarJurisdiccion.Text, txtModificarDireccion.Text, txtModificarLiquidadorResponsable.Text };

                                        string datosConcatenados = string.Join(";", datosProveedores);

                                        grabado.Grabar(datosConcatenados);

                                        numGuia++;
                                        txtModificarNumero.Text = numGuia.ToString();
                                        txtModificarEntidad.Clear();
                                        txtModificarApertura.Clear();
                                        txtModificarNExpediente.Clear();
                                        txtModificarJuzgado.Clear();
                                        txtModificarJurisdiccion.Clear();
                                        txtModificarDireccion.Clear();
                                        txtModificarLiquidadorResponsable.Clear();
                                        MessageBox.Show("Proveedor cargado");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void frmProveedores_Load(object sender, EventArgs e)
        {


            txtModificarNumero.Text = numGuia.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Se crea una variable llamada posicion que toma el valor de la propiedad pos del formulario frmProveedores y la convierte a una cadena (ToString). La variable pos almacena el identificador.
            string posicion = frmProveedores.pos.ToString();

            //Se crea una lista de cadenas llamada lista. Esta lista se utilizará para almacenar las líneas del archivo CSV después de modificarlas.

            List<string> lista = new List<string>();

            //Aquí se crea un objeto StreamReader llamado leer para leer el contenido del archivo CSV especificado en rutaArchivo. La instrucción using garantiza que el objeto leer se cierre correctamente después de su uso.
            using (StreamReader leer = new StreamReader(rutaArchivo))
            {

                //Se declara una variable linea para almacenar cada línea leída del archivo CSV.
                string linea;

                //Esto inicia un bucle while que leerá cada línea del archivo hasta que no haya más líneas que leer.
                while ((linea = leer.ReadLine()) != null)
                {

                    //Cada línea se divide en un array de cadenas llamado parametros utilizando el carácter ; como separador. Esto asume que las líneas del archivo CSV están separadas por punto y coma.
                    string[] parametros = linea.Split(';');

                    //Se verifica si el primer elemento en parametros (probablemente algún tipo de identificador) es diferente de la variable posicion.
                    if (parametros[0] != posicion)
                    {
                        //Si el identificador no coincide, la línea original se agrega a la lista lista.
                        lista.Add(linea);
                    }
                    //Si el identificador coincide, se crea una nueva línea concatenando algunos valores de campos de entrada de textoy y se agrega al lista.
                    else
                    {
                        //Después de terminar de leer y procesar todas las líneas del archivo CSV, se cierra el objeto StreamReader.
                        string lineaDos = "" + ";" + "" + ";" + "" + ";" + "" + ";" + "" + ";" + "" + ";" + "" + ";" + "" + ";";
                        lista.Add(lineaDos);
                    }
                }
            }
        }
    }
}
