
namespace Seminario2_ArbolBinarios_Nodos
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
            this.txtNodo = new System.Windows.Forms.TextBox();
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TreeView = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEliminarNodo = new System.Windows.Forms.Button();
            this.btnLimpiarNodo = new System.Windows.Forms.Button();
            this.btnAdicionarElemento = new System.Windows.Forms.Button();
            this.btnAdicionarNodo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNodo
            // 
            this.txtNodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNodo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtNodo.Location = new System.Drawing.Point(282, 80);
            this.txtNodo.Name = "txtNodo";
            this.txtNodo.Size = new System.Drawing.Size(250, 27);
            this.txtNodo.TabIndex = 0;
            // 
            // txtElemento
            // 
            this.txtElemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtElemento.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtElemento.Location = new System.Drawing.Point(547, 80);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(250, 27);
            this.txtElemento.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 53);
            this.panel1.TabIndex = 6;
            // 
            // TreeView
            // 
            this.TreeView.BackColor = System.Drawing.SystemColors.Menu;
            this.TreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TreeView.Location = new System.Drawing.Point(12, 80);
            this.TreeView.Name = "TreeView";
            this.TreeView.Size = new System.Drawing.Size(243, 394);
            this.TreeView.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Seminario No. 2 Árbol Binario";
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Image = global::Seminario2_ArbolBinarios_Nodos.Properties.Resources.customLogo;
            this.picBoxLogo.Location = new System.Drawing.Point(282, 330);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(486, 144);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxLogo.TabIndex = 7;
            this.picBoxLogo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Seminario2_ArbolBinarios_Nodos.Properties.Resources.multiply_26px;
            this.pictureBox1.Location = new System.Drawing.Point(766, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnEliminarNodo
            // 
            this.btnEliminarNodo.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnEliminarNodo.FlatAppearance.BorderSize = 0;
            this.btnEliminarNodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarNodo.ForeColor = System.Drawing.Color.White;
            this.btnEliminarNodo.Image = global::Seminario2_ArbolBinarios_Nodos.Properties.Resources.delete_node_45px;
            this.btnEliminarNodo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarNodo.Location = new System.Drawing.Point(282, 268);
            this.btnEliminarNodo.Name = "btnEliminarNodo";
            this.btnEliminarNodo.Size = new System.Drawing.Size(250, 56);
            this.btnEliminarNodo.TabIndex = 5;
            this.btnEliminarNodo.Text = "Eliminar Nodo";
            this.btnEliminarNodo.UseVisualStyleBackColor = false;
            this.btnEliminarNodo.Click += new System.EventHandler(this.btnEliminarNodo_Click);
            // 
            // btnLimpiarNodo
            // 
            this.btnLimpiarNodo.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnLimpiarNodo.FlatAppearance.BorderSize = 0;
            this.btnLimpiarNodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarNodo.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarNodo.Image = global::Seminario2_ArbolBinarios_Nodos.Properties.Resources.broom_25px1;
            this.btnLimpiarNodo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarNodo.Location = new System.Drawing.Point(282, 194);
            this.btnLimpiarNodo.Name = "btnLimpiarNodo";
            this.btnLimpiarNodo.Size = new System.Drawing.Size(250, 56);
            this.btnLimpiarNodo.TabIndex = 4;
            this.btnLimpiarNodo.Text = "Limpiar Nodo";
            this.btnLimpiarNodo.UseVisualStyleBackColor = false;
            this.btnLimpiarNodo.Click += new System.EventHandler(this.btnLimpiarNodo_Click);
            // 
            // btnAdicionarElemento
            // 
            this.btnAdicionarElemento.BackColor = System.Drawing.Color.Orange;
            this.btnAdicionarElemento.FlatAppearance.BorderSize = 0;
            this.btnAdicionarElemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarElemento.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarElemento.Image = global::Seminario2_ArbolBinarios_Nodos.Properties.Resources.add_subnode_45px;
            this.btnAdicionarElemento.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdicionarElemento.Location = new System.Drawing.Point(547, 122);
            this.btnAdicionarElemento.Name = "btnAdicionarElemento";
            this.btnAdicionarElemento.Size = new System.Drawing.Size(250, 56);
            this.btnAdicionarElemento.TabIndex = 3;
            this.btnAdicionarElemento.Text = "Insertar SubNodo";
            this.btnAdicionarElemento.UseVisualStyleBackColor = false;
            this.btnAdicionarElemento.Click += new System.EventHandler(this.btnAdicionarElemento_Click);
            // 
            // btnAdicionarNodo
            // 
            this.btnAdicionarNodo.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAdicionarNodo.FlatAppearance.BorderSize = 0;
            this.btnAdicionarNodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarNodo.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarNodo.Image = global::Seminario2_ArbolBinarios_Nodos.Properties.Resources.add_node_45px;
            this.btnAdicionarNodo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdicionarNodo.Location = new System.Drawing.Point(282, 122);
            this.btnAdicionarNodo.Name = "btnAdicionarNodo";
            this.btnAdicionarNodo.Size = new System.Drawing.Size(250, 56);
            this.btnAdicionarNodo.TabIndex = 2;
            this.btnAdicionarNodo.Text = "Insertar Nodo";
            this.btnAdicionarNodo.UseVisualStyleBackColor = false;
            this.btnAdicionarNodo.Click += new System.EventHandler(this.btnAdicionarNodo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(804, 512);
            this.Controls.Add(this.TreeView);
            this.Controls.Add(this.picBoxLogo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEliminarNodo);
            this.Controls.Add(this.btnLimpiarNodo);
            this.Controls.Add(this.btnAdicionarElemento);
            this.Controls.Add(this.btnAdicionarNodo);
            this.Controls.Add(this.txtElemento);
            this.Controls.Add(this.txtNodo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNodo;
        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.Button btnAdicionarNodo;
        private System.Windows.Forms.Button btnAdicionarElemento;
        private System.Windows.Forms.Button btnLimpiarNodo;
        private System.Windows.Forms.Button btnEliminarNodo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.TreeView TreeView;
        private System.Windows.Forms.Label label1;
    }
}

