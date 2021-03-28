
namespace EjercicioAerolinea
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
            this.listSelect = new System.Windows.Forms.ListBox();
            this.butRegistros = new System.Windows.Forms.Button();
            this.butRCodigo = new System.Windows.Forms.Button();
            this.butrMesAnyoCiu = new System.Windows.Forms.Button();
            this.butTopCancel = new System.Windows.Forms.Button();
            this.butDistancia = new System.Windows.Forms.Button();
            this.butREmpresas = new System.Windows.Forms.Button();
            this.butConexion = new System.Windows.Forms.Button();
            this.butAbrir = new System.Windows.Forms.Button();
            this.butCerrar = new System.Windows.Forms.Button();
            this.butRMesAnyo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listSelect
            // 
            this.listSelect.FormattingEnabled = true;
            this.listSelect.ItemHeight = 16;
            this.listSelect.Location = new System.Drawing.Point(43, 193);
            this.listSelect.Name = "listSelect";
            this.listSelect.Size = new System.Drawing.Size(628, 196);
            this.listSelect.TabIndex = 0;
            // 
            // butRegistros
            // 
            this.butRegistros.Location = new System.Drawing.Point(257, 12);
            this.butRegistros.Name = "butRegistros";
            this.butRegistros.Size = new System.Drawing.Size(194, 37);
            this.butRegistros.TabIndex = 1;
            this.butRegistros.Text = "Registros";
            this.butRegistros.UseVisualStyleBackColor = true;
            this.butRegistros.Click += new System.EventHandler(this.butRegistros_Click);
            // 
            // butRCodigo
            // 
            this.butRCodigo.Location = new System.Drawing.Point(257, 55);
            this.butRCodigo.Name = "butRCodigo";
            this.butRCodigo.Size = new System.Drawing.Size(194, 37);
            this.butRCodigo.TabIndex = 2;
            this.butRCodigo.Text = "Retrasos Codigo";
            this.butRCodigo.UseVisualStyleBackColor = true;
            this.butRCodigo.Click += new System.EventHandler(this.butRCodigo_Click);
            // 
            // butrMesAnyoCiu
            // 
            this.butrMesAnyoCiu.Location = new System.Drawing.Point(477, 12);
            this.butrMesAnyoCiu.Name = "butrMesAnyoCiu";
            this.butrMesAnyoCiu.Size = new System.Drawing.Size(194, 37);
            this.butrMesAnyoCiu.TabIndex = 3;
            this.butrMesAnyoCiu.Text = "Retrasos Mes/Año/Ciudad";
            this.butrMesAnyoCiu.UseVisualStyleBackColor = true;
            this.butrMesAnyoCiu.Click += new System.EventHandler(this.butrMesAnyoCiu_Click);
            // 
            // butTopCancel
            // 
            this.butTopCancel.Location = new System.Drawing.Point(477, 55);
            this.butTopCancel.Name = "butTopCancel";
            this.butTopCancel.Size = new System.Drawing.Size(194, 37);
            this.butTopCancel.TabIndex = 4;
            this.butTopCancel.Text = "Top Canceladas";
            this.butTopCancel.UseVisualStyleBackColor = true;
            this.butTopCancel.Click += new System.EventHandler(this.butTopCancel_Click);
            // 
            // butDistancia
            // 
            this.butDistancia.Location = new System.Drawing.Point(477, 98);
            this.butDistancia.Name = "butDistancia";
            this.butDistancia.Size = new System.Drawing.Size(194, 37);
            this.butDistancia.TabIndex = 5;
            this.butDistancia.Text = "Top Distancia";
            this.butDistancia.UseVisualStyleBackColor = true;
            this.butDistancia.Click += new System.EventHandler(this.butDistancia_Click);
            // 
            // butREmpresas
            // 
            this.butREmpresas.Location = new System.Drawing.Point(477, 141);
            this.butREmpresas.Name = "butREmpresas";
            this.butREmpresas.Size = new System.Drawing.Size(194, 37);
            this.butREmpresas.TabIndex = 6;
            this.butREmpresas.Text = "Top Retraso Empresas";
            this.butREmpresas.UseVisualStyleBackColor = true;
            this.butREmpresas.Click += new System.EventHandler(this.butREmpresas_Click);
            // 
            // butConexion
            // 
            this.butConexion.Location = new System.Drawing.Point(43, 12);
            this.butConexion.Name = "butConexion";
            this.butConexion.Size = new System.Drawing.Size(194, 37);
            this.butConexion.TabIndex = 7;
            this.butConexion.Text = "Conexión";
            this.butConexion.UseVisualStyleBackColor = true;
            this.butConexion.Click += new System.EventHandler(this.butConexion_Click);
            // 
            // butAbrir
            // 
            this.butAbrir.Location = new System.Drawing.Point(43, 55);
            this.butAbrir.Name = "butAbrir";
            this.butAbrir.Size = new System.Drawing.Size(194, 37);
            this.butAbrir.TabIndex = 8;
            this.butAbrir.Text = "Abrir";
            this.butAbrir.UseVisualStyleBackColor = true;
            this.butAbrir.Click += new System.EventHandler(this.butAbrir_Click);
            // 
            // butCerrar
            // 
            this.butCerrar.Location = new System.Drawing.Point(43, 98);
            this.butCerrar.Name = "butCerrar";
            this.butCerrar.Size = new System.Drawing.Size(194, 37);
            this.butCerrar.TabIndex = 9;
            this.butCerrar.Text = "Cerrar";
            this.butCerrar.UseVisualStyleBackColor = true;
            this.butCerrar.Click += new System.EventHandler(this.butCerrar_Click);
            // 
            // butRMesAnyo
            // 
            this.butRMesAnyo.Location = new System.Drawing.Point(257, 98);
            this.butRMesAnyo.Name = "butRMesAnyo";
            this.butRMesAnyo.Size = new System.Drawing.Size(194, 37);
            this.butRMesAnyo.TabIndex = 10;
            this.butRMesAnyo.Text = "Retrasos Mes/año";
            this.butRMesAnyo.UseVisualStyleBackColor = true;
            this.butRMesAnyo.Click += new System.EventHandler(this.butRMesAnyo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 400);
            this.Controls.Add(this.butRMesAnyo);
            this.Controls.Add(this.butCerrar);
            this.Controls.Add(this.butAbrir);
            this.Controls.Add(this.butConexion);
            this.Controls.Add(this.butREmpresas);
            this.Controls.Add(this.butDistancia);
            this.Controls.Add(this.butTopCancel);
            this.Controls.Add(this.butrMesAnyoCiu);
            this.Controls.Add(this.butRCodigo);
            this.Controls.Add(this.butRegistros);
            this.Controls.Add(this.listSelect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listSelect;
        private System.Windows.Forms.Button butRegistros;
        private System.Windows.Forms.Button butRCodigo;
        private System.Windows.Forms.Button butrMesAnyoCiu;
        private System.Windows.Forms.Button butTopCancel;
        private System.Windows.Forms.Button butDistancia;
        private System.Windows.Forms.Button butREmpresas;
        private System.Windows.Forms.Button butConexion;
        private System.Windows.Forms.Button butAbrir;
        private System.Windows.Forms.Button butCerrar;
        private System.Windows.Forms.Button butRMesAnyo;
    }
}

