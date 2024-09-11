namespace WinFormsApp1
{
    public partial class Form1 : System.Windows.Forms.Form
    {

        private Proyecto proyecto;

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCrearProyecto_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fechaInicio = dtpFechaInicio.Value;
            proyecto = new Proyecto(nombre, fechaInicio);
            MessageBox.Show("Proyecto Creado Exitosamente");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (proyecto == null)
            {
                MessageBox.Show("Debe de crear un proyecto primero");
                return;
            }

            string descripcion = txtTareaDescripcion.Text;
            int duracionhoras = (int)numDuraciónHoras.Value;
            string mensaje = proyecto.Agregartarea(descripcion, duracionhoras);
            lstDetalles.Items.Add(mensaje);
        }

        private void btnMostrarDetalles_Click(object sender, EventArgs e)
        {

            if (proyecto == null)
            {
                MessageBox.Show("Debe de crear un proyecto primero");
                return;
            }

            string detalles = proyecto.MostrarDetalles();
            lstDetalles.Items.Add(detalles);

        }

        private void btnAginarRecurso_Click(object sender, EventArgs e)
        {

            if (proyecto == null)
            {
                MessageBox.Show("Debe de crear un proyecto primero");
                return;
            }

            string nombre = txtRecursoNombre.Text;
            string rol = txtRolRecurso.Text;
            string mensaje = proyecto.AsignarRecurso(nombre, rol);
            lstDetalles.Items.Add(mensaje);


        }
    }
}
