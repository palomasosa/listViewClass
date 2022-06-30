namespace tareaPrgrmWindowsForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Alumnos", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Profesores", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Directivos", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Paloma",
            "Sosa",
            "42517138"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "Sergio ",
            "Algorry ",
            "20541362"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Henry",
            "Cap",
            "51516"}, -1);
            this.lstVwDatosPersonas = new System.Windows.Forms.ListView();
            this.columnID = new System.Windows.Forms.ColumnHeader();
            this.columnNombre = new System.Windows.Forms.ColumnHeader();
            this.columnApellido = new System.Windows.Forms.ColumnHeader();
            this.columnDNI = new System.Windows.Forms.ColumnHeader();
            this.lstVwDatos = new System.Windows.Forms.ListView();
            this.columnaID = new System.Windows.Forms.ColumnHeader();
            this.columnaNombre = new System.Windows.Forms.ColumnHeader();
            this.columnaApellido = new System.Windows.Forms.ColumnHeader();
            this.columnaDNI = new System.Windows.Forms.ColumnHeader();
            this.txtBxID = new System.Windows.Forms.TextBox();
            this.TxtBxNombre = new System.Windows.Forms.TextBox();
            this.TxtBxApellido = new System.Windows.Forms.TextBox();
            this.TxtBxDNI = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstVwDatosPersonas
            // 
            this.lstVwDatosPersonas.CheckBoxes = true;
            this.lstVwDatosPersonas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnNombre,
            this.columnApellido,
            this.columnDNI});
            this.lstVwDatosPersonas.LabelEdit = true;
            this.lstVwDatosPersonas.Location = new System.Drawing.Point(47, 190);
            this.lstVwDatosPersonas.Name = "lstVwDatosPersonas";
            this.lstVwDatosPersonas.Size = new System.Drawing.Size(364, 199);
            this.lstVwDatosPersonas.TabIndex = 0;
            this.lstVwDatosPersonas.UseCompatibleStateImageBehavior = false;
            this.lstVwDatosPersonas.View = System.Windows.Forms.View.Details;
            this.lstVwDatosPersonas.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.lstVwDatosPersonas_AfterLabelEdit);
            this.lstVwDatosPersonas.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lstVwDatosPersonas_ColumnClick);
            this.lstVwDatosPersonas.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lstVwDatosPersonas_ColumnWidthChanging);
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            // 
            // columnNombre
            // 
            this.columnNombre.Text = "Nombre";
            this.columnNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnNombre.Width = 100;
            // 
            // columnApellido
            // 
            this.columnApellido.Text = "Apellido";
            this.columnApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnApellido.Width = 100;
            // 
            // columnDNI
            // 
            this.columnDNI.Text = "DNI";
            this.columnDNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnDNI.Width = 100;
            // 
            // lstVwDatos
            // 
            this.lstVwDatos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnaID,
            this.columnaNombre,
            this.columnaApellido,
            this.columnaDNI});
            listViewGroup1.Header = "Alumnos";
            listViewGroup1.Name = "grupoAlumnos";
            listViewGroup2.Header = "Profesores";
            listViewGroup2.Name = "gurpoProfesores";
            listViewGroup3.Header = "Directivos";
            listViewGroup3.Name = "grupoDirectivos";
            this.lstVwDatos.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3});
            listViewItem3.Group = listViewGroup3;
            this.lstVwDatos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lstVwDatos.Location = new System.Drawing.Point(47, 430);
            this.lstVwDatos.Name = "lstVwDatos";
            this.lstVwDatos.Size = new System.Drawing.Size(363, 264);
            this.lstVwDatos.TabIndex = 1;
            this.lstVwDatos.UseCompatibleStateImageBehavior = false;
            this.lstVwDatos.View = System.Windows.Forms.View.Details;
            this.lstVwDatos.SelectedIndexChanged += new System.EventHandler(this.lstVwDatos_SelectedIndexChanged);
            // 
            // columnaID
            // 
            this.columnaID.Text = "ID";
            // 
            // columnaNombre
            // 
            this.columnaNombre.Text = "Nombre";
            this.columnaNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnaNombre.Width = 100;
            // 
            // columnaApellido
            // 
            this.columnaApellido.Text = "Apellido";
            this.columnaApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnaApellido.Width = 100;
            // 
            // columnaDNI
            // 
            this.columnaDNI.Text = "DNI";
            this.columnaDNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnaDNI.Width = 100;
            // 
            // txtBxID
            // 
            this.txtBxID.Location = new System.Drawing.Point(119, 33);
            this.txtBxID.Name = "txtBxID";
            this.txtBxID.Size = new System.Drawing.Size(100, 23);
            this.txtBxID.TabIndex = 2;
            // 
            // TxtBxNombre
            // 
            this.TxtBxNombre.Location = new System.Drawing.Point(119, 62);
            this.TxtBxNombre.Name = "TxtBxNombre";
            this.TxtBxNombre.Size = new System.Drawing.Size(100, 23);
            this.TxtBxNombre.TabIndex = 3;
            // 
            // TxtBxApellido
            // 
            this.TxtBxApellido.Location = new System.Drawing.Point(119, 91);
            this.TxtBxApellido.Name = "TxtBxApellido";
            this.TxtBxApellido.Size = new System.Drawing.Size(100, 23);
            this.TxtBxApellido.TabIndex = 4;
            // 
            // TxtBxDNI
            // 
            this.TxtBxDNI.Location = new System.Drawing.Point(119, 120);
            this.TxtBxDNI.Name = "TxtBxDNI";
            this.TxtBxDNI.Size = new System.Drawing.Size(100, 23);
            this.TxtBxDNI.TabIndex = 5;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(75, 36);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 15);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "ID";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(62, 65);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(62, 94);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(51, 15);
            this.lblApellido.TabIndex = 8;
            this.lblApellido.Text = "Apellido";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(75, 123);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(27, 15);
            this.lblDNI.TabIndex = 9;
            this.lblDNI.Text = "DNI";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(238, 57);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(238, 86);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 11;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnCambiar
            // 
            this.btnCambiar.Location = new System.Drawing.Point(238, 115);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(75, 23);
            this.btnCambiar.TabIndex = 15;
            this.btnCambiar.Text = "Editar";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 450);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.TxtBxDNI);
            this.Controls.Add(this.TxtBxApellido);
            this.Controls.Add(this.TxtBxNombre);
            this.Controls.Add(this.txtBxID);
            this.Controls.Add(this.lstVwDatos);
            this.Controls.Add(this.lstVwDatosPersonas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView lstVwDatosPersonas;
        private ColumnHeader columnID;
        private ColumnHeader columnNombre;
        private ColumnHeader columnApellido;
        private ColumnHeader columnDNI;
        private ListView lstVwDatos;
        private ColumnHeader columnaID;
        private ColumnHeader columnaNombre;
        private ColumnHeader columnaApellido;
        private ColumnHeader columnaDNI;
        private TextBox txtBxID;
        private TextBox TxtBxNombre;
        private TextBox TxtBxApellido;
        private TextBox TxtBxDNI;
        private Label lblID;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDNI;
        private Button btnAgregar;
        private Button btnBorrar;
        private Button btnCambiar;
    }
}