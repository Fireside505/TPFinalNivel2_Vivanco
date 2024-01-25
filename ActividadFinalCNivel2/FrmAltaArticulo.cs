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
using System.Configuration;
using System.IO;
using System.Web;
using System.Drawing.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace ActividadFinalCNivel2
{
    public partial class FrmAltaArticulo : Form
    {
        private Articulo articulo = null;
        private OpenFileDialog archivo = null;

        public FrmAltaArticulo()
        {
            InitializeComponent();
        }

        public FrmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private bool ValidarCmbbox()
        {
            if (cmbbxCategoria.SelectedItem == null || cmbbxMarca.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccionar una opcion de CATEGORIA Y MARCA");
                return true;
            }

            return false;
        }
        private bool ValidarTxtbx()
        {

            if (string.IsNullOrEmpty(txtbxCodigo.Text)|| string.IsNullOrEmpty(txtbxNombre.Text)|| string.IsNullOrEmpty(txtbxDescripcion.Text) || string.IsNullOrEmpty(txtbxImagen.Text))
            
                MessageBox.Show("Por favor, completar todos los campos");
                return true;
        }
        
        private void bttnAceptar_Click(object sender, EventArgs e)
        {

            ArticulosDatos datosArticulo = new ArticulosDatos();

            try
            {
                if (ValidarTxtbx())
                    return;

                if (articulo == null)
                    articulo = new Articulo();
                articulo.CodigoArticulo = txtbxCodigo.Text;
                articulo.Nombre = txtbxNombre.Text;
                articulo.Descripcion = txtbxDescripcion.Text;
                articulo.Imagen = txtbxImagen.Text;
                articulo.Categoria = (Categoria)cmbbxCategoria.SelectedItem;
                articulo.Marca = (Marca)cmbbxMarca.SelectedItem;
                articulo.Precio = decimal.Parse(txtbxPrecio.Text);

                if (articulo.Id != 0)
                {
                    datosArticulo.modificar(articulo);
                    MessageBox.Show("Articulo modificado exitosamente");
                }
                else
                {
                    datosArticulo.agregar(articulo);
                    MessageBox.Show("Articulo agregado exitosamente");
                }
                if (archivo != null && !(txtbxImagen.Text.ToUpper().Contains("http")))
                {
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["Articulo-Imagenes"] + archivo.SafeFileName);
                }
                


                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FrmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaDatos marcaDatos = new MarcaDatos();
            try
            {
                cmbbxMarca.DataSource = marcaDatos.listar();
                cmbbxMarca.ValueMember = "Id";
                cmbbxMarca.DisplayMember = "descripcion";

                if (articulo != null)
                {
                    txtbxCodigo.Text = articulo.CodigoArticulo;
                    txtbxNombre.Text = articulo.Nombre;
                    txtbxDescripcion.Text = articulo.Descripcion;
                    txtbxImagen.Text = articulo.Imagen;
                    txtbxPrecio.Text = articulo.Precio.ToString("0.00");
                    cargarImagen(articulo.Imagen);
                    cmbbxMarca.SelectedValue = articulo.Marca.id;
                    cmbbxCategoria.SelectedValue = articulo.Categoria.id;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

            CategoriaDatos categoriaDatos = new CategoriaDatos();
            try
            {
                cmbbxCategoria.DataSource = categoriaDatos.Listar();
                cmbbxCategoria.ValueMember = "Id";
                cmbbxCategoria.DisplayMember = "descripcion";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }

        private void txtbxImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtbxImagen.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pctrbxAgregarArticulo.Load(imagen);
            }
            catch (Exception ex)
            {

                pctrbxAgregarArticulo.Load("https://media.istockphoto.com/id/1147544807/vector/thumbnail-image-vector-graphic.jpg?s=612x612&w=0&k=20&c=rnCKVbdxqkjlcs3xH87-9gocETqpspHFXu5dIGB4wuM=");
            }

        }

        private void txtbxPrecio_TextChanged(object sender, EventArgs e)
        {
                if (!decimal.TryParse(txtbxPrecio.Text, out _))
                {
                    MessageBox.Show("Por favor, ingrese un número válido.");
                }
            

        }

        private void bttnAgregarImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg; |png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtbxImagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
            }
        }
    }
}
