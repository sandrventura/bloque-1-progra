namespace PELICULAS
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idPeliculasLabel;
            System.Windows.Forms.Label codigo_de_PeliculaLabel;
            System.Windows.Forms.Label tituloLabel;
            System.Windows.Forms.Label autorLabel;
            System.Windows.Forms.Label sinopsisLabel;
            System.Windows.Forms.Label duracionLabel;
            System.Windows.Forms.Label clasificacionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.db_PeliculasDataSet = new PELICULAS.db_PeliculasDataSet();
            this.peliculasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.peliculasTableAdapter = new PELICULAS.db_PeliculasDataSetTableAdapters.PeliculasTableAdapter();
            this.tableAdapterManager = new PELICULAS.db_PeliculasDataSetTableAdapters.TableAdapterManager();
            this.idPeliculasLabel1 = new System.Windows.Forms.Label();
            this.codigo_de_PeliculaTextBox = new System.Windows.Forms.TextBox();
            this.tituloTextBox = new System.Windows.Forms.TextBox();
            this.autorTextBox = new System.Windows.Forms.TextBox();
            this.sinopsisTextBox = new System.Windows.Forms.TextBox();
            this.duracionTextBox = new System.Windows.Forms.TextBox();
            this.clasificacionTextBox = new System.Windows.Forms.TextBox();
            this.grbNavegacion = new System.Windows.Forms.GroupBox();
            this.lblRegisto = new System.Windows.Forms.Label();
            this.btnadelante = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnretroceder = new System.Windows.Forms.Button();
            this.btnsiguiente = new System.Windows.Forms.Button();
            this.grbEdicion = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.peliculasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            idPeliculasLabel = new System.Windows.Forms.Label();
            codigo_de_PeliculaLabel = new System.Windows.Forms.Label();
            tituloLabel = new System.Windows.Forms.Label();
            autorLabel = new System.Windows.Forms.Label();
            sinopsisLabel = new System.Windows.Forms.Label();
            duracionLabel = new System.Windows.Forms.Label();
            clasificacionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.db_PeliculasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasBindingSource)).BeginInit();
            this.grbNavegacion.SuspendLayout();
            this.grbEdicion.SuspendLayout();
            this.grbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idPeliculasLabel
            // 
            idPeliculasLabel.AutoSize = true;
            idPeliculasLabel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            idPeliculasLabel.Location = new System.Drawing.Point(7, 22);
            idPeliculasLabel.Name = "idPeliculasLabel";
            idPeliculasLabel.Size = new System.Drawing.Size(64, 13);
            idPeliculasLabel.TabIndex = 1;
            idPeliculasLabel.Text = "Id Peliculas:";
            // 
            // codigo_de_PeliculaLabel
            // 
            codigo_de_PeliculaLabel.AutoSize = true;
            codigo_de_PeliculaLabel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            codigo_de_PeliculaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codigo_de_PeliculaLabel.Location = new System.Drawing.Point(7, 42);
            codigo_de_PeliculaLabel.Name = "codigo_de_PeliculaLabel";
            codigo_de_PeliculaLabel.Size = new System.Drawing.Size(117, 13);
            codigo_de_PeliculaLabel.TabIndex = 3;
            codigo_de_PeliculaLabel.Text = "Codigo de Pelicula:";
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tituloLabel.Location = new System.Drawing.Point(7, 68);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new System.Drawing.Size(43, 13);
            tituloLabel.TabIndex = 5;
            tituloLabel.Text = "Titulo:";
            // 
            // autorLabel
            // 
            autorLabel.AutoSize = true;
            autorLabel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            autorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            autorLabel.Location = new System.Drawing.Point(7, 94);
            autorLabel.Name = "autorLabel";
            autorLabel.Size = new System.Drawing.Size(41, 13);
            autorLabel.TabIndex = 7;
            autorLabel.Text = "Autor:";
            // 
            // sinopsisLabel
            // 
            sinopsisLabel.AutoSize = true;
            sinopsisLabel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            sinopsisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sinopsisLabel.Location = new System.Drawing.Point(7, 120);
            sinopsisLabel.Name = "sinopsisLabel";
            sinopsisLabel.Size = new System.Drawing.Size(58, 13);
            sinopsisLabel.TabIndex = 9;
            sinopsisLabel.Text = "Sinopsis:";
            // 
            // duracionLabel
            // 
            duracionLabel.AutoSize = true;
            duracionLabel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            duracionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            duracionLabel.Location = new System.Drawing.Point(7, 146);
            duracionLabel.Name = "duracionLabel";
            duracionLabel.Size = new System.Drawing.Size(62, 13);
            duracionLabel.TabIndex = 11;
            duracionLabel.Text = "Duracion:";
            // 
            // clasificacionLabel
            // 
            clasificacionLabel.AutoSize = true;
            clasificacionLabel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            clasificacionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            clasificacionLabel.Location = new System.Drawing.Point(7, 172);
            clasificacionLabel.Name = "clasificacionLabel";
            clasificacionLabel.Size = new System.Drawing.Size(83, 13);
            clasificacionLabel.TabIndex = 13;
            clasificacionLabel.Text = "Clasificacion:";
            // 
            // db_PeliculasDataSet
            // 
            this.db_PeliculasDataSet.DataSetName = "db_PeliculasDataSet";
            this.db_PeliculasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // peliculasBindingSource
            // 
            this.peliculasBindingSource.DataMember = "Peliculas";
            this.peliculasBindingSource.DataSource = this.db_PeliculasDataSet;
            // 
            // peliculasTableAdapter
            // 
            this.peliculasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PeliculasTableAdapter = this.peliculasTableAdapter;
            this.tableAdapterManager.UpdateOrder = PELICULAS.db_PeliculasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idPeliculasLabel1
            // 
            this.idPeliculasLabel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.idPeliculasLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "IdPeliculas", true));
            this.idPeliculasLabel1.Location = new System.Drawing.Point(135, 13);
            this.idPeliculasLabel1.Name = "idPeliculasLabel1";
            this.idPeliculasLabel1.Size = new System.Drawing.Size(62, 23);
            this.idPeliculasLabel1.TabIndex = 2;
            this.idPeliculasLabel1.Text = "label1";
            // 
            // codigo_de_PeliculaTextBox
            // 
            this.codigo_de_PeliculaTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.codigo_de_PeliculaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "Codigo de Pelicula", true));
            this.codigo_de_PeliculaTextBox.Location = new System.Drawing.Point(138, 39);
            this.codigo_de_PeliculaTextBox.Name = "codigo_de_PeliculaTextBox";
            this.codigo_de_PeliculaTextBox.Size = new System.Drawing.Size(86, 20);
            this.codigo_de_PeliculaTextBox.TabIndex = 4;
            // 
            // tituloTextBox
            // 
            this.tituloTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tituloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "Titulo", true));
            this.tituloTextBox.Location = new System.Drawing.Point(138, 65);
            this.tituloTextBox.Name = "tituloTextBox";
            this.tituloTextBox.Size = new System.Drawing.Size(193, 20);
            this.tituloTextBox.TabIndex = 6;
            // 
            // autorTextBox
            // 
            this.autorTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.autorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "Autor", true));
            this.autorTextBox.Location = new System.Drawing.Point(138, 91);
            this.autorTextBox.Name = "autorTextBox";
            this.autorTextBox.Size = new System.Drawing.Size(193, 20);
            this.autorTextBox.TabIndex = 8;
            // 
            // sinopsisTextBox
            // 
            this.sinopsisTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sinopsisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "Sinopsis", true));
            this.sinopsisTextBox.Location = new System.Drawing.Point(138, 117);
            this.sinopsisTextBox.Name = "sinopsisTextBox";
            this.sinopsisTextBox.Size = new System.Drawing.Size(193, 20);
            this.sinopsisTextBox.TabIndex = 10;
            // 
            // duracionTextBox
            // 
            this.duracionTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.duracionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "Duracion", true));
            this.duracionTextBox.Location = new System.Drawing.Point(138, 143);
            this.duracionTextBox.Name = "duracionTextBox";
            this.duracionTextBox.Size = new System.Drawing.Size(86, 20);
            this.duracionTextBox.TabIndex = 12;
            // 
            // clasificacionTextBox
            // 
            this.clasificacionTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clasificacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "Clasificacion", true));
            this.clasificacionTextBox.Location = new System.Drawing.Point(138, 169);
            this.clasificacionTextBox.Name = "clasificacionTextBox";
            this.clasificacionTextBox.Size = new System.Drawing.Size(86, 20);
            this.clasificacionTextBox.TabIndex = 14;
            // 
            // grbNavegacion
            // 
            this.grbNavegacion.Controls.Add(this.lblRegisto);
            this.grbNavegacion.Controls.Add(this.btnadelante);
            this.grbNavegacion.Controls.Add(this.btnAtras);
            this.grbNavegacion.Controls.Add(this.btnretroceder);
            this.grbNavegacion.Controls.Add(this.btnsiguiente);
            this.grbNavegacion.Location = new System.Drawing.Point(8, 268);
            this.grbNavegacion.Name = "grbNavegacion";
            this.grbNavegacion.Size = new System.Drawing.Size(487, 107);
            this.grbNavegacion.TabIndex = 15;
            this.grbNavegacion.TabStop = false;
            this.grbNavegacion.Text = "NAVEGACION";
            // 
            // lblRegisto
            // 
            this.lblRegisto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "IdPeliculas", true));
            this.lblRegisto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisto.Location = new System.Drawing.Point(211, 30);
            this.lblRegisto.Name = "lblRegisto";
            this.lblRegisto.Size = new System.Drawing.Size(62, 23);
            this.lblRegisto.TabIndex = 3;
            this.lblRegisto.Text = "x de n ";
            // 
            // btnadelante
            // 
            this.btnadelante.Image = ((System.Drawing.Image)(resources.GetObject("btnadelante.Image")));
            this.btnadelante.Location = new System.Drawing.Point(317, 30);
            this.btnadelante.Name = "btnadelante";
            this.btnadelante.Size = new System.Drawing.Size(38, 38);
            this.btnadelante.TabIndex = 2;
            this.btnadelante.Text = "==";
            this.btnadelante.UseVisualStyleBackColor = true;
            this.btnadelante.Click += new System.EventHandler(this.btnadelante_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.Image")));
            this.btnAtras.Location = new System.Drawing.Point(123, 30);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(34, 38);
            this.btnAtras.TabIndex = 0;
            this.btnAtras.Text = "==";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnretroceder
            // 
            this.btnretroceder.Image = ((System.Drawing.Image)(resources.GetObject("btnretroceder.Image")));
            this.btnretroceder.Location = new System.Drawing.Point(-1, 19);
            this.btnretroceder.Margin = new System.Windows.Forms.Padding(2);
            this.btnretroceder.Name = "btnretroceder";
            this.btnretroceder.Size = new System.Drawing.Size(110, 78);
            this.btnretroceder.TabIndex = 0;
            this.btnretroceder.UseVisualStyleBackColor = true;
            this.btnretroceder.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.Image = ((System.Drawing.Image)(resources.GetObject("btnsiguiente.Image")));
            this.btnsiguiente.Location = new System.Drawing.Point(370, 9);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(107, 78);
            this.btnsiguiente.TabIndex = 1;
            this.btnsiguiente.UseVisualStyleBackColor = true;
            this.btnsiguiente.Click += new System.EventHandler(this.button2_Click);
            // 
            // grbEdicion
            // 
            this.grbEdicion.Controls.Add(this.btnEliminar);
            this.grbEdicion.Controls.Add(this.btnModificar);
            this.grbEdicion.Controls.Add(this.btnAgregar);
            this.grbEdicion.Location = new System.Drawing.Point(501, 295);
            this.grbEdicion.Name = "grbEdicion";
            this.grbEdicion.Size = new System.Drawing.Size(122, 118);
            this.grbEdicion.TabIndex = 16;
            this.grbEdicion.TabStop = false;
            this.grbEdicion.Text = "EDICION";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(36, 95);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(36, 57);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(36, 19);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // grbDatos
            // 
            this.grbDatos.Controls.Add(this.autorTextBox);
            this.grbDatos.Controls.Add(this.clasificacionTextBox);
            this.grbDatos.Controls.Add(clasificacionLabel);
            this.grbDatos.Controls.Add(idPeliculasLabel);
            this.grbDatos.Controls.Add(this.duracionTextBox);
            this.grbDatos.Controls.Add(this.idPeliculasLabel1);
            this.grbDatos.Controls.Add(duracionLabel);
            this.grbDatos.Controls.Add(codigo_de_PeliculaLabel);
            this.grbDatos.Controls.Add(this.sinopsisTextBox);
            this.grbDatos.Controls.Add(this.codigo_de_PeliculaTextBox);
            this.grbDatos.Controls.Add(sinopsisLabel);
            this.grbDatos.Controls.Add(tituloLabel);
            this.grbDatos.Controls.Add(autorLabel);
            this.grbDatos.Controls.Add(this.tituloTextBox);
            this.grbDatos.Location = new System.Drawing.Point(11, 12);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(365, 194);
            this.grbDatos.TabIndex = 17;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Datos de Peliculas";
            // 
            // peliculasDataGridView
            // 
            this.peliculasDataGridView.AllowUserToAddRows = false;
            this.peliculasDataGridView.AllowUserToDeleteRows = false;
            this.peliculasDataGridView.AutoGenerateColumns = false;
            this.peliculasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.peliculasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.peliculasDataGridView.DataSource = this.peliculasBindingSource;
            this.peliculasDataGridView.Location = new System.Drawing.Point(382, 40);
            this.peliculasDataGridView.Name = "peliculasDataGridView";
            this.peliculasDataGridView.ReadOnly = true;
            this.peliculasDataGridView.Size = new System.Drawing.Size(655, 231);
            this.peliculasDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdPeliculas";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdPeliculas";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Codigo de Pelicula";
            this.dataGridViewTextBoxColumn2.HeaderText = "CODIGO DE PELICULA";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Titulo";
            this.dataGridViewTextBoxColumn3.HeaderText = "TITULO";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Autor";
            this.dataGridViewTextBoxColumn4.HeaderText = "AUTOR";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Sinopsis";
            this.dataGridViewTextBoxColumn5.HeaderText = "SINOPSIS";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 15;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Duracion";
            this.dataGridViewTextBoxColumn6.HeaderText = "DURACION";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Clasificacion";
            this.dataGridViewTextBoxColumn7.HeaderText = "CLASIFICACION";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtBuscar.Location = new System.Drawing.Point(471, 12);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(152, 20);
            this.txtBuscar.TabIndex = 18;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 450);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.peliculasDataGridView);
            this.Controls.Add(this.grbDatos);
            this.Controls.Add(this.grbEdicion);
            this.Controls.Add(this.grbNavegacion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_PeliculasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasBindingSource)).EndInit();
            this.grbNavegacion.ResumeLayout(false);
            this.grbEdicion.ResumeLayout(false);
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private db_PeliculasDataSet db_PeliculasDataSet;
        private System.Windows.Forms.BindingSource peliculasBindingSource;
        private db_PeliculasDataSetTableAdapters.PeliculasTableAdapter peliculasTableAdapter;
        private db_PeliculasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label idPeliculasLabel1;
        private System.Windows.Forms.TextBox codigo_de_PeliculaTextBox;
        private System.Windows.Forms.TextBox tituloTextBox;
        private System.Windows.Forms.TextBox autorTextBox;
        private System.Windows.Forms.TextBox sinopsisTextBox;
        private System.Windows.Forms.TextBox duracionTextBox;
        private System.Windows.Forms.TextBox clasificacionTextBox;
        private System.Windows.Forms.GroupBox grbNavegacion;
        private System.Windows.Forms.Button btnretroceder;
        private System.Windows.Forms.Button btnsiguiente;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnadelante;
        private System.Windows.Forms.Label lblRegisto;
        private System.Windows.Forms.GroupBox grbEdicion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.DataGridView peliculasDataGridView;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}

