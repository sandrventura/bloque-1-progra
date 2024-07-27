using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PELICULAS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void peliculasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.peliculasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_PeliculasDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_PeliculasDataSet.Peliculas' Puede moverla o quitarla según sea necesario.
            this.peliculasTableAdapter.Fill(this.db_PeliculasDataSet.Peliculas);
            Registro();
        }
        private void Registro() {
lblRegisto.Text = (peliculasBindingSource. Position + 1) + " de" + peliculasBindingSource.Count;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            peliculasBindingSource.MoveFirst();
            Registro();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            peliculasBindingSource.MoveLast();
            Registro();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            peliculasBindingSource.MovePrevious();
            Registro();
        }

       

        private void btnadelante_Click(object sender, EventArgs e)
        {
            peliculasBindingSource.MoveNext();
            Registro();
        }
        private void estadoCtrls(Boolean estado) {
            grbNavegacion.Enabled = estado;
            btnEliminar.Enabled = estado;
            grbDatos.Enabled = !estado;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (btnAgregar.Text == "Agregar")
            {
                btnAgregar.Text = "Guardar";
                btnModificar.Text = "cancelar";
                estadoCtrls(false);
                peliculasBindingSource.AddNew();
            }
            else
            {// guardar
                peliculasBindingSource.EndEdit();
                peliculasTableAdapter.Update(this.db_PeliculasDataSet);
                estadoCtrls(true);
                btnAgregar.Text = "Agregar";
                btnModificar.Text = "Modificar";
            }
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (btnModificar.Text == "Modificar")
            {
                btnAgregar.Text = "Guardar";
                btnModificar.Text = "cancelar";
                estadoCtrls(false);

            }
            else
            {
                peliculasBindingSource.CancelEdit();
                estadoCtrls(true);
                btnAgregar.Text = "Agregar";
                btnModificar.Text = "Modificar";
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if ( MessageBox.Show("esta seguro de eliminar este elemento"+ tituloTextBox.Text+"?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){}
            peliculasBindingSource.RemoveCurrent();
            peliculasTableAdapter.Update(db_PeliculasDataSet);
            Registro();
        }


        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = peliculasDataGridView.DataSource;
            bs.Filter = "Titulo LIKE '%" + txtBuscar.Text + "%' OR [codigo de pelicula] LIKE '%" + txtBuscar.Text + "%'";

            peliculasDataGridView.DataSource = bs;

        }
    }
    }

