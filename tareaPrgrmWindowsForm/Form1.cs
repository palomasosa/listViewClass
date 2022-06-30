namespace tareaPrgrmWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ListViewItem datosPersona = new ListViewItem(txtBxID.Text);
            datosPersona.SubItems.Add(TxtBxNombre.Text);
            datosPersona.SubItems.Add(TxtBxApellido.Text);
            datosPersona.SubItems.Add(TxtBxDNI.Text);
            lstVwDatosPersonas.Items.Add(datosPersona);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
                    

            foreach (ListViewItem itemBorrar in lstVwDatosPersonas.SelectedItems)
            {
                itemBorrar.Remove();
            }
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itemCambiar in lstVwDatosPersonas.SelectedItems)
            {
                itemCambiar.Text = txtBxID.Text;
                itemCambiar.SubItems[1].Text = TxtBxNombre.Text;
                itemCambiar.SubItems[2].Text = TxtBxApellido.Text;
                itemCambiar.SubItems[3].Text = TxtBxDNI.Text;
            }
        }

        private void lstVwDatosPersonas_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            MessageBox.Show("Ha cambiado el ítem exitosamente");
        }

        private void lstVwDatosPersonas_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            
            MessageBox.Show("Esta haciendo click sobre la columna");
           
        }

        private void lstVwDatosPersonas_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            MessageBox.Show("No puede cambiar el ancho de las columnas");
        }

        private void lstVwDatos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}