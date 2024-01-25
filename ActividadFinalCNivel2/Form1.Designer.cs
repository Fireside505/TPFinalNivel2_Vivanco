namespace ActividadFinalCNivel2
{
    partial class FormArticulos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgrdvwArticulos = new System.Windows.Forms.DataGridView();
            this.pctrbxArticulo = new System.Windows.Forms.PictureBox();
            this.bttonAgregar = new System.Windows.Forms.Button();
            this.buttnModificar = new System.Windows.Forms.Button();
            this.bttnEliminar = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtbxFiltroRapido = new System.Windows.Forms.TextBox();
            this.bttnBuscar = new System.Windows.Forms.Button();
            this.lblCampo = new System.Windows.Forms.Label();
            this.cmbbxCampo = new System.Windows.Forms.ComboBox();
            this.cmbbxCriterio = new System.Windows.Forms.ComboBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblAvanzado = new System.Windows.Forms.Label();
            this.txtbxFiltroAvanzado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvwArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgrdvwArticulos
            // 
            this.dtgrdvwArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdvwArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgrdvwArticulos.Location = new System.Drawing.Point(12, 52);
            this.dtgrdvwArticulos.MultiSelect = false;
            this.dtgrdvwArticulos.Name = "dtgrdvwArticulos";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrdvwArticulos.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgrdvwArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrdvwArticulos.Size = new System.Drawing.Size(766, 330);
            this.dtgrdvwArticulos.TabIndex = 0;
            this.dtgrdvwArticulos.SelectionChanged += new System.EventHandler(this.dtgrdvw_SelectionChanged);
            // 
            // pctrbxArticulo
            // 
            this.pctrbxArticulo.Location = new System.Drawing.Point(796, 33);
            this.pctrbxArticulo.Name = "pctrbxArticulo";
            this.pctrbxArticulo.Size = new System.Drawing.Size(263, 349);
            this.pctrbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrbxArticulo.TabIndex = 1;
            this.pctrbxArticulo.TabStop = false;
            // 
            // bttonAgregar
            // 
            this.bttonAgregar.Location = new System.Drawing.Point(15, 395);
            this.bttonAgregar.Name = "bttonAgregar";
            this.bttonAgregar.Size = new System.Drawing.Size(113, 43);
            this.bttonAgregar.TabIndex = 2;
            this.bttonAgregar.Text = "Agregar";
            this.bttonAgregar.UseVisualStyleBackColor = true;
            this.bttonAgregar.Click += new System.EventHandler(this.bttonAgregar_Click);
            // 
            // buttnModificar
            // 
            this.buttnModificar.Location = new System.Drawing.Point(155, 395);
            this.buttnModificar.Name = "buttnModificar";
            this.buttnModificar.Size = new System.Drawing.Size(113, 43);
            this.buttnModificar.TabIndex = 3;
            this.buttnModificar.Text = "Modificar";
            this.buttnModificar.UseVisualStyleBackColor = true;
            this.buttnModificar.Click += new System.EventHandler(this.buttnModificar_Click);
            // 
            // bttnEliminar
            // 
            this.bttnEliminar.Location = new System.Drawing.Point(665, 395);
            this.bttnEliminar.Name = "bttnEliminar";
            this.bttnEliminar.Size = new System.Drawing.Size(113, 43);
            this.bttnEliminar.TabIndex = 4;
            this.bttnEliminar.Text = "Eliminar";
            this.bttnEliminar.UseVisualStyleBackColor = true;
            this.bttnEliminar.Click += new System.EventHandler(this.bttnEliminar_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(13, 24);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(46, 13);
            this.lblBuscar.TabIndex = 5;
            this.lblBuscar.Text = "Buscar: ";
            // 
            // txtbxFiltroRapido
            // 
            this.txtbxFiltroRapido.Location = new System.Drawing.Point(65, 21);
            this.txtbxFiltroRapido.Name = "txtbxFiltroRapido";
            this.txtbxFiltroRapido.Size = new System.Drawing.Size(194, 20);
            this.txtbxFiltroRapido.TabIndex = 6;
            this.txtbxFiltroRapido.TextChanged += new System.EventHandler(this.txtbxFiltro_TextChanged);
            // 
            // bttnBuscar
            // 
            this.bttnBuscar.Location = new System.Drawing.Point(665, 477);
            this.bttnBuscar.Name = "bttnBuscar";
            this.bttnBuscar.Size = new System.Drawing.Size(113, 43);
            this.bttnBuscar.TabIndex = 7;
            this.bttnBuscar.Text = "Buscar";
            this.bttnBuscar.UseVisualStyleBackColor = true;
            this.bttnBuscar.Click += new System.EventHandler(this.bttnBuscar_Click);
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(47, 492);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(46, 13);
            this.lblCampo.TabIndex = 8;
            this.lblCampo.Text = "Campo: ";
            // 
            // cmbbxCampo
            // 
            this.cmbbxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbxCampo.FormattingEnabled = true;
            this.cmbbxCampo.Location = new System.Drawing.Point(96, 489);
            this.cmbbxCampo.Name = "cmbbxCampo";
            this.cmbbxCampo.Size = new System.Drawing.Size(121, 21);
            this.cmbbxCampo.TabIndex = 9;
            this.cmbbxCampo.SelectedIndexChanged += new System.EventHandler(this.cmbbxCampo_SelectedIndexChanged);
            // 
            // cmbbxCriterio
            // 
            this.cmbbxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbxCriterio.FormattingEnabled = true;
            this.cmbbxCriterio.Location = new System.Drawing.Point(289, 489);
            this.cmbbxCriterio.Name = "cmbbxCriterio";
            this.cmbbxCriterio.Size = new System.Drawing.Size(121, 21);
            this.cmbbxCriterio.TabIndex = 11;
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(236, 492);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(45, 13);
            this.lblCriterio.TabIndex = 10;
            this.lblCriterio.Text = "Criterio: ";
            // 
            // lblAvanzado
            // 
            this.lblAvanzado.AutoSize = true;
            this.lblAvanzado.Location = new System.Drawing.Point(424, 492);
            this.lblAvanzado.Name = "lblAvanzado";
            this.lblAvanzado.Size = new System.Drawing.Size(86, 13);
            this.lblAvanzado.TabIndex = 12;
            this.lblAvanzado.Text = "Filtro Avanzado: ";
            // 
            // txtbxFiltroAvanzado
            // 
            this.txtbxFiltroAvanzado.Location = new System.Drawing.Point(507, 489);
            this.txtbxFiltroAvanzado.Name = "txtbxFiltroAvanzado";
            this.txtbxFiltroAvanzado.Size = new System.Drawing.Size(132, 20);
            this.txtbxFiltroAvanzado.TabIndex = 13;
            this.txtbxFiltroAvanzado.TextChanged += new System.EventHandler(this.txtbxFiltroAvanzado_TextChanged);
            // 
            // FormArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 537);
            this.Controls.Add(this.txtbxFiltroAvanzado);
            this.Controls.Add(this.lblAvanzado);
            this.Controls.Add(this.cmbbxCriterio);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.cmbbxCampo);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.bttnBuscar);
            this.Controls.Add(this.txtbxFiltroRapido);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.bttnEliminar);
            this.Controls.Add(this.buttnModificar);
            this.Controls.Add(this.bttonAgregar);
            this.Controls.Add(this.pctrbxArticulo);
            this.Controls.Add(this.dtgrdvwArticulos);
            this.Name = "FormArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvwArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrdvwArticulos;
        private System.Windows.Forms.PictureBox pctrbxArticulo;
        private System.Windows.Forms.Button bttonAgregar;
        private System.Windows.Forms.Button buttnModificar;
        private System.Windows.Forms.Button bttnEliminar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtbxFiltroRapido;
        private System.Windows.Forms.Button bttnBuscar;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.ComboBox cmbbxCampo;
        private System.Windows.Forms.ComboBox cmbbxCriterio;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblAvanzado;
        private System.Windows.Forms.TextBox txtbxFiltroAvanzado;
    }
}

