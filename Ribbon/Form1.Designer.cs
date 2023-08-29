namespace Ribbon
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rbnMenu = new System.Windows.Forms.Ribbon();
            this.rbnTabCatalogos = new System.Windows.Forms.RibbonTab();
            this.rbnPnlCatProductos = new System.Windows.Forms.RibbonPanel();
            this.rbnPnlCatSocios = new System.Windows.Forms.RibbonPanel();
            this.rbnPnlCatUbicaciones = new System.Windows.Forms.RibbonPanel();
            this.rbnTabMovimientos = new System.Windows.Forms.RibbonTab();
            this.rbnPnlMovEntradas = new System.Windows.Forms.RibbonPanel();
            this.rbnPnlMovSalidas = new System.Windows.Forms.RibbonPanel();
            this.rbnTabReportes = new System.Windows.Forms.RibbonTab();
            this.rbnPnlRepMovArticulos = new System.Windows.Forms.RibbonPanel();
            this.rbnTabHerramientas = new System.Windows.Forms.RibbonTab();
            this.tabControl1 = new MdiTabControl.TabControl();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.rbnBtnInvProductos = new System.Windows.Forms.RibbonButton();
            this.rbnBtnProdCategorias = new System.Windows.Forms.RibbonButton();
            this.rbnBtnProdSubCategorias = new System.Windows.Forms.RibbonButton();
            this.rbnbtnCatSocProveedore = new System.Windows.Forms.RibbonButton();
            this.rbnBtnCatUbiLocations = new System.Windows.Forms.RibbonButton();
            this.rbnBtnMovEntFactura = new System.Windows.Forms.RibbonButton();
            this.rbnBtnMovEntVales = new System.Windows.Forms.RibbonButton();
            this.rbnBtnMovSalVale = new System.Windows.Forms.RibbonButton();
            this.rbnBtnMovSalDevolucion = new System.Windows.Forms.RibbonButton();
            this.rbnBtnRepArtInventario = new System.Windows.Forms.RibbonButton();
            this.rbnBtnRepArtCardex = new System.Windows.Forms.RibbonButton();
            this.SuspendLayout();
            // 
            // rbnMenu
            // 
            this.rbnMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbnMenu.Location = new System.Drawing.Point(0, 0);
            this.rbnMenu.Minimized = false;
            this.rbnMenu.Name = "rbnMenu";
            // 
            // 
            // 
            this.rbnMenu.OrbDropDown.BorderRoundness = 8;
            this.rbnMenu.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.rbnMenu.OrbDropDown.Name = "";
            this.rbnMenu.OrbDropDown.Size = new System.Drawing.Size(527, 72);
            this.rbnMenu.OrbDropDown.TabIndex = 0;
            this.rbnMenu.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2013;
            this.rbnMenu.OrbText = "Archivo";
            this.rbnMenu.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnMenu.Size = new System.Drawing.Size(800, 148);
            this.rbnMenu.TabIndex = 0;
            this.rbnMenu.Tabs.Add(this.rbnTabCatalogos);
            this.rbnMenu.Tabs.Add(this.rbnTabMovimientos);
            this.rbnMenu.Tabs.Add(this.rbnTabReportes);
            this.rbnMenu.Tabs.Add(this.rbnTabHerramientas);
            this.rbnMenu.TabsMargin = new System.Windows.Forms.Padding(5, 26, 20, 0);
            this.rbnMenu.TabSpacing = 4;
            this.rbnMenu.Text = "ribbon1";
            // 
            // rbnTabCatalogos
            // 
            this.rbnTabCatalogos.Name = "rbnTabCatalogos";
            this.rbnTabCatalogos.Panels.Add(this.rbnPnlCatProductos);
            this.rbnTabCatalogos.Panels.Add(this.rbnPnlCatSocios);
            this.rbnTabCatalogos.Panels.Add(this.rbnPnlCatUbicaciones);
            this.rbnTabCatalogos.Text = "Catálogos";
            // 
            // rbnPnlCatProductos
            // 
            this.rbnPnlCatProductos.Items.Add(this.rbnBtnInvProductos);
            this.rbnPnlCatProductos.Items.Add(this.rbnBtnProdCategorias);
            this.rbnPnlCatProductos.Items.Add(this.rbnBtnProdSubCategorias);
            this.rbnPnlCatProductos.Name = "rbnPnlCatProductos";
            this.rbnPnlCatProductos.Text = "Productos";
            // 
            // rbnPnlCatSocios
            // 
            this.rbnPnlCatSocios.Items.Add(this.rbnbtnCatSocProveedore);
            this.rbnPnlCatSocios.Name = "rbnPnlCatSocios";
            this.rbnPnlCatSocios.Text = "Socios";
            // 
            // rbnPnlCatUbicaciones
            // 
            this.rbnPnlCatUbicaciones.Items.Add(this.rbnBtnCatUbiLocations);
            this.rbnPnlCatUbicaciones.Name = "rbnPnlCatUbicaciones";
            this.rbnPnlCatUbicaciones.Text = "Ubicaciones";
            // 
            // rbnTabMovimientos
            // 
            this.rbnTabMovimientos.Name = "rbnTabMovimientos";
            this.rbnTabMovimientos.Panels.Add(this.rbnPnlMovEntradas);
            this.rbnTabMovimientos.Panels.Add(this.rbnPnlMovSalidas);
            this.rbnTabMovimientos.Text = "Movimientos";
            // 
            // rbnPnlMovEntradas
            // 
            this.rbnPnlMovEntradas.Items.Add(this.rbnBtnMovEntFactura);
            this.rbnPnlMovEntradas.Items.Add(this.rbnBtnMovEntVales);
            this.rbnPnlMovEntradas.Name = "rbnPnlMovEntradas";
            this.rbnPnlMovEntradas.Text = "Entradas";
            // 
            // rbnPnlMovSalidas
            // 
            this.rbnPnlMovSalidas.Items.Add(this.rbnBtnMovSalVale);
            this.rbnPnlMovSalidas.Items.Add(this.rbnBtnMovSalDevolucion);
            this.rbnPnlMovSalidas.Name = "rbnPnlMovSalidas";
            this.rbnPnlMovSalidas.Text = "Salidas";
            // 
            // rbnTabReportes
            // 
            this.rbnTabReportes.Name = "rbnTabReportes";
            this.rbnTabReportes.Panels.Add(this.rbnPnlRepMovArticulos);
            this.rbnTabReportes.Text = "Reportes";
            // 
            // rbnPnlRepMovArticulos
            // 
            this.rbnPnlRepMovArticulos.Items.Add(this.rbnBtnRepArtInventario);
            this.rbnPnlRepMovArticulos.Items.Add(this.rbnBtnRepArtCardex);
            this.rbnPnlRepMovArticulos.Name = "rbnPnlRepMovArticulos";
            this.rbnPnlRepMovArticulos.Text = "Artuculos";
            // 
            // rbnTabHerramientas
            // 
            this.rbnTabHerramientas.Name = "rbnTabHerramientas";
            this.rbnTabHerramientas.Text = "Herramientas";
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 148);
            this.tabControl1.MenuRenderer = null;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Size = new System.Drawing.Size(800, 302);
            this.tabControl1.TabCloseButtonImage = null;
            this.tabControl1.TabCloseButtonImageDisabled = null;
            this.tabControl1.TabCloseButtonImageHot = null;
            this.tabControl1.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // rbnBtnInvProductos
            // 
            this.rbnBtnInvProductos.Image = global::Ribbon.Properties.Resources.Articulos_48X48;
            this.rbnBtnInvProductos.LargeImage = global::Ribbon.Properties.Resources.Articulos_48X48;
            this.rbnBtnInvProductos.Name = "rbnBtnInvProductos";
            this.rbnBtnInvProductos.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbnBtnInvProductos.SmallImage")));
            this.rbnBtnInvProductos.Text = "Productos";
            this.rbnBtnInvProductos.ToolTip = "Muestra el catálogo de productos.";
            this.rbnBtnInvProductos.Click += new System.EventHandler(this.rbnBtnInvProductos_Click);
            // 
            // rbnBtnProdCategorias
            // 
            this.rbnBtnProdCategorias.Image = global::Ribbon.Properties.Resources.Categorias_48X48;
            this.rbnBtnProdCategorias.LargeImage = global::Ribbon.Properties.Resources.Categorias_48X48;
            this.rbnBtnProdCategorias.Name = "rbnBtnProdCategorias";
            this.rbnBtnProdCategorias.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbnBtnProdCategorias.SmallImage")));
            this.rbnBtnProdCategorias.Text = "Categorias";
            this.rbnBtnProdCategorias.Click += new System.EventHandler(this.rbnBtnProdCategorias_Click);
            // 
            // rbnBtnProdSubCategorias
            // 
            this.rbnBtnProdSubCategorias.Image = global::Ribbon.Properties.Resources.Articulos48X48;
            this.rbnBtnProdSubCategorias.LargeImage = global::Ribbon.Properties.Resources.Articulos48X48;
            this.rbnBtnProdSubCategorias.Name = "rbnBtnProdSubCategorias";
            this.rbnBtnProdSubCategorias.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbnBtnProdSubCategorias.SmallImage")));
            this.rbnBtnProdSubCategorias.Text = "Sub-Categorias";
            this.rbnBtnProdSubCategorias.Click += new System.EventHandler(this.rbnBtnProdSubCategorias_Click);
            // 
            // rbnbtnCatSocProveedore
            // 
            this.rbnbtnCatSocProveedore.Image = global::Ribbon.Properties.Resources.Personal48X48;
            this.rbnbtnCatSocProveedore.LargeImage = global::Ribbon.Properties.Resources.Personal48X48;
            this.rbnbtnCatSocProveedore.Name = "rbnbtnCatSocProveedore";
            this.rbnbtnCatSocProveedore.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbnbtnCatSocProveedore.SmallImage")));
            this.rbnbtnCatSocProveedore.Text = "Proveedores";
            // 
            // rbnBtnCatUbiLocations
            // 
            this.rbnBtnCatUbiLocations.Image = global::Ribbon.Properties.Resources.Rack_48X48;
            this.rbnBtnCatUbiLocations.LargeImage = global::Ribbon.Properties.Resources.Rack_48X48;
            this.rbnBtnCatUbiLocations.Name = "rbnBtnCatUbiLocations";
            this.rbnBtnCatUbiLocations.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbnBtnCatUbiLocations.SmallImage")));
            this.rbnBtnCatUbiLocations.Text = "Ubicaciones";
            // 
            // rbnBtnMovEntFactura
            // 
            this.rbnBtnMovEntFactura.Image = global::Ribbon.Properties.Resources.Invoice_48X48;
            this.rbnBtnMovEntFactura.LargeImage = global::Ribbon.Properties.Resources.Invoice_48X48;
            this.rbnBtnMovEntFactura.Name = "rbnBtnMovEntFactura";
            this.rbnBtnMovEntFactura.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbnBtnMovEntFactura.SmallImage")));
            this.rbnBtnMovEntFactura.Text = "Factura";
            // 
            // rbnBtnMovEntVales
            // 
            this.rbnBtnMovEntVales.Image = global::Ribbon.Properties.Resources.Survey_48X48;
            this.rbnBtnMovEntVales.LargeImage = global::Ribbon.Properties.Resources.Survey_48X48;
            this.rbnBtnMovEntVales.Name = "rbnBtnMovEntVales";
            this.rbnBtnMovEntVales.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbnBtnMovEntVales.SmallImage")));
            this.rbnBtnMovEntVales.Text = "Vale";
            // 
            // rbnBtnMovSalVale
            // 
            this.rbnBtnMovSalVale.Image = ((System.Drawing.Image)(resources.GetObject("rbnBtnMovSalVale.Image")));
            this.rbnBtnMovSalVale.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbnBtnMovSalVale.LargeImage")));
            this.rbnBtnMovSalVale.Name = "rbnBtnMovSalVale";
            this.rbnBtnMovSalVale.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbnBtnMovSalVale.SmallImage")));
            this.rbnBtnMovSalVale.Text = "Vale";
            // 
            // rbnBtnMovSalDevolucion
            // 
            this.rbnBtnMovSalDevolucion.Image = global::Ribbon.Properties.Resources.Devolucion_48X48;
            this.rbnBtnMovSalDevolucion.LargeImage = global::Ribbon.Properties.Resources.Devolucion_48X48;
            this.rbnBtnMovSalDevolucion.Name = "rbnBtnMovSalDevolucion";
            this.rbnBtnMovSalDevolucion.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbnBtnMovSalDevolucion.SmallImage")));
            this.rbnBtnMovSalDevolucion.Text = "Devolución";
            // 
            // rbnBtnRepArtInventario
            // 
            this.rbnBtnRepArtInventario.Image = global::Ribbon.Properties.Resources.inventory_48X48;
            this.rbnBtnRepArtInventario.LargeImage = global::Ribbon.Properties.Resources.inventory_48X48;
            this.rbnBtnRepArtInventario.Name = "rbnBtnRepArtInventario";
            this.rbnBtnRepArtInventario.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbnBtnRepArtInventario.SmallImage")));
            this.rbnBtnRepArtInventario.Text = "Inventario";
            this.rbnBtnRepArtInventario.Click += new System.EventHandler(this.rbnBtnRepArtInventario_Click);
            // 
            // rbnBtnRepArtCardex
            // 
            this.rbnBtnRepArtCardex.Image = global::Ribbon.Properties.Resources.Survey_48X48;
            this.rbnBtnRepArtCardex.LargeImage = global::Ribbon.Properties.Resources.Survey_48X48;
            this.rbnBtnRepArtCardex.Name = "rbnBtnRepArtCardex";
            this.rbnBtnRepArtCardex.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbnBtnRepArtCardex.SmallImage")));
            this.rbnBtnRepArtCardex.Text = "Cardex";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.rbnMenu);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Sistema de Inventario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Ribbon rbnMenu;
        private System.Windows.Forms.RibbonTab rbnTabCatalogos;
        private System.Windows.Forms.RibbonPanel rbnPnlCatProductos;
        private System.Windows.Forms.RibbonButton rbnBtnInvProductos;
        private System.Windows.Forms.RibbonButton rbnBtnProdCategorias;
        private System.Windows.Forms.RibbonButton rbnBtnProdSubCategorias;
        private System.Windows.Forms.RibbonPanel rbnPnlCatSocios;
        private System.Windows.Forms.RibbonTab rbnTabReportes;
        private System.Windows.Forms.RibbonPanel rbnPnlRepMovArticulos;
        private System.Windows.Forms.RibbonButton rbnBtnRepArtInventario;
        private System.Windows.Forms.RibbonButton rbnBtnRepArtCardex;
        private System.Windows.Forms.RibbonTab rbnTabMovimientos;
        private System.Windows.Forms.RibbonPanel rbnPnlMovEntradas;
        private System.Windows.Forms.RibbonButton rbnBtnMovEntFactura;
        private System.Windows.Forms.RibbonButton rbnBtnMovEntVales;
        private System.Windows.Forms.RibbonPanel rbnPnlMovSalidas;
        private System.Windows.Forms.RibbonButton rbnBtnMovSalVale;
        private System.Windows.Forms.RibbonButton rbnBtnMovSalDevolucion;
        private System.Windows.Forms.RibbonButton rbnbtnCatSocProveedore;
        private System.Windows.Forms.RibbonPanel rbnPnlCatUbicaciones;
        private System.Windows.Forms.RibbonButton rbnBtnCatUbiLocations;
        private MdiTabControl.TabControl tabControl1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.RibbonTab rbnTabHerramientas;
    }
}

