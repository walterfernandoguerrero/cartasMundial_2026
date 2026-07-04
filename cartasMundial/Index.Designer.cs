namespace cartasMundial
{
    partial class Index
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
            this.dgvSuperHeroe = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pbxImagenHeroe = new System.Windows.Forms.PictureBox();
            this.lbl_Nombre_Heroe = new System.Windows.Forms.Label();
            this.btnAgregar_Heroe = new System.Windows.Forms.Button();
            this.lblErrorImagen = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuperHeroe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenHeroe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSuperHeroe
            // 
            this.dgvSuperHeroe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuperHeroe.Location = new System.Drawing.Point(24, 89);
            this.dgvSuperHeroe.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvSuperHeroe.Name = "dgvSuperHeroe";
            this.dgvSuperHeroe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSuperHeroe.Size = new System.Drawing.Size(609, 368);
            this.dgvSuperHeroe.TabIndex = 2;
            this.dgvSuperHeroe.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvSuperHeroe_MouseClick);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(29, 61);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(161, 25);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "SUPER HEROES:";
            // 
            // pbxImagenHeroe
            // 
            this.pbxImagenHeroe.Location = new System.Drawing.Point(682, 181);
            this.pbxImagenHeroe.Name = "pbxImagenHeroe";
            this.pbxImagenHeroe.Size = new System.Drawing.Size(262, 276);
            this.pbxImagenHeroe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagenHeroe.TabIndex = 4;
            this.pbxImagenHeroe.TabStop = false;
            // 
            // lbl_Nombre_Heroe
            // 
            this.lbl_Nombre_Heroe.AutoSize = true;
            this.lbl_Nombre_Heroe.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre_Heroe.Location = new System.Drawing.Point(679, 152);
            this.lbl_Nombre_Heroe.Name = "lbl_Nombre_Heroe";
            this.lbl_Nombre_Heroe.Size = new System.Drawing.Size(82, 23);
            this.lbl_Nombre_Heroe.TabIndex = 5;
            this.lbl_Nombre_Heroe.Text = "nombre";
            // 
            // btnAgregar_Heroe
            // 
            this.btnAgregar_Heroe.Location = new System.Drawing.Point(24, 501);
            this.btnAgregar_Heroe.Name = "btnAgregar_Heroe";
            this.btnAgregar_Heroe.Size = new System.Drawing.Size(93, 32);
            this.btnAgregar_Heroe.TabIndex = 6;
            this.btnAgregar_Heroe.Text = "AGREGAR";
            this.btnAgregar_Heroe.UseVisualStyleBackColor = true;
            this.btnAgregar_Heroe.Click += new System.EventHandler(this.btnAgregar_Heroe_Click);
            // 
            // lblErrorImagen
            // 
            this.lblErrorImagen.AutoSize = true;
            this.lblErrorImagen.Location = new System.Drawing.Point(683, 479);
            this.lblErrorImagen.Name = "lblErrorImagen";
            this.lblErrorImagen.Size = new System.Drawing.Size(0, 15);
            this.lblErrorImagen.TabIndex = 7;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(132, 501);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(93, 32);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 568);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblErrorImagen);
            this.Controls.Add(this.btnAgregar_Heroe);
            this.Controls.Add(this.lbl_Nombre_Heroe);
            this.Controls.Add(this.pbxImagenHeroe);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvSuperHeroe);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Index";
            this.Text = "Index";
            this.Load += new System.EventHandler(this.Index_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuperHeroe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenHeroe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSuperHeroe;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pbxImagenHeroe;
        private System.Windows.Forms.Label lbl_Nombre_Heroe;
        private System.Windows.Forms.Button btnAgregar_Heroe;
        private System.Windows.Forms.Label lblErrorImagen;
        private System.Windows.Forms.Button btnModificar;
    }
}