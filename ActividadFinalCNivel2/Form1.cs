using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Datos;
using System.Net;
using System.Web;

namespace ActividadFinalCNivel2
{
    public partial class FormArticulos : Form
    {
        private ArticulosDatos articulo = null;

        private List<Articulo> listaArticulos;
        public FormArticulos()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar();
                cmbbxCampo.Items.Add("Código");
                cmbbxCampo.Items.Add("Nombre");
                cmbbxCampo.Items.Add("Descripción");
                dtgrdvwArticulos.Columns["Precio"].DefaultCellStyle.Format = "0.00";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Cargar()
        {
            ArticulosDatos datos = new ArticulosDatos();
            listaArticulos = datos.listar();
            dtgrdvwArticulos.DataSource = listaArticulos;
            OcultarColumnas();
            cargarImagen(listaArticulos[0].Imagen);
        }

        private void OcultarColumnas()
        {
            dtgrdvwArticulos.Columns ["Imagen"].Visible = false;
            dtgrdvwArticulos.Columns ["Id"].Visible = false;
        }
        private void dtgrdvw_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgrdvwArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dtgrdvwArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.Imagen);
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pctrbxArticulo.Load(imagen);
            }
            catch (Exception ex)
            {

                pctrbxArticulo.Load("https://media.istockphoto.com/id/1147544807/vector/thumbnail-image-vector-graphic.jpg?s=612x612&w=0&k=20&c=rnCKVbdxqkjlcs3xH87-9gocETqpspHFXu5dIGB4wuM=");
            }
            
        }


        private void bttonAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaArticulo alta = new FrmAltaArticulo();
            alta.ShowDialog();
            Cargar();

            
        }

        private void buttnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dtgrdvwArticulos.CurrentRow.DataBoundItem;
            FrmAltaArticulo modificar = new FrmAltaArticulo(seleccionado);
            modificar.ShowDialog();
            Cargar();
        }

        private void bttnEliminar_Click(object sender, EventArgs e)
        {
            ArticulosDatos dato = new ArticulosDatos();
            Articulo seleccionado;

            try
            {
                DialogResult pregunta = MessageBox.Show("¿Seguro que quiere eliminar el articulo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (pregunta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)(dtgrdvwArticulos.CurrentRow.DataBoundItem);
                    dato.Eliminar(seleccionado.Id);
                    Cargar();
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private bool validarFiltro()
        {
            if (cmbbxCampo.SelectedIndex < 0 || cmbbxCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, los filtros deben contener una opción");
                return true;
            }
            
            return false;
        }

        private void bttnBuscar_Click(object sender, EventArgs e)
        {
            ArticulosDatos datos = new ArticulosDatos();
            try
            {
                if (validarFiltro())
                    return;
                string campo = cmbbxCampo.SelectedItem.ToString();
                string criterio = cmbbxCriterio.SelectedItem.ToString();
                string filtroAvanzado = txtbxFiltroAvanzado.Text;
                dtgrdvwArticulos.DataSource = datos.filtrar(campo, criterio, filtroAvanzado);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }

        private void txtbxFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtbxFiltroRapido.Text;
            if (filtro.Length >= 2)
            {
                listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaArticulos;
            }
            dtgrdvwArticulos.DataSource = null;
            dtgrdvwArticulos.DataSource = listaFiltrada;
            OcultarColumnas();
        }

        private void cmbbxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cmbbxCampo.SelectedItem.ToString();
            if (opcion == "Código")
            {
                cmbbxCriterio.Items.Clear();
                cmbbxCriterio.Items.Add("Comienza con");
                cmbbxCriterio.Items.Add("Termina con");
                cmbbxCriterio.Items.Add("Contiene");
            }
            else if (opcion == "Nombre")
            {
                cmbbxCriterio.Items.Clear();
                cmbbxCriterio.Items.Add("Comienza con");
                cmbbxCriterio.Items.Add("Termina con");
                cmbbxCriterio.Items.Add("Contiene");
            }
            else
            {
                cmbbxCriterio.Items.Clear();
                cmbbxCriterio.Items.Add("Comienza con");
                cmbbxCriterio.Items.Add("Termina con");
                cmbbxCriterio.Items.Add("Contiene");
            }

        }

        private void txtbxFiltroAvanzado_TextChanged(object sender, EventArgs e)
        {

        }
    }




}
