﻿
namespace Capa_Vista_S
{
    partial class Frm_Salones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Salones));
            this.Pnl_Superior = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_capacidad = new System.Windows.Forms.TextBox();
            this.Txt_ubicacion = new System.Windows.Forms.TextBox();
            this.Btn_modificar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Lbl_Capacidad = new System.Windows.Forms.Label();
            this.Lbl_Ubicacion = new System.Windows.Forms.Label();
            this.Lbl_Nombre = new System.Windows.Forms.Label();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Lbl_Consulta = new System.Windows.Forms.Label();
            this.Dvg_Salones = new System.Windows.Forms.DataGridView();
            this.Lbl_Disponibilidad = new System.Windows.Forms.Label();
            this.Chk_disponibilidad = new System.Windows.Forms.CheckBox();
            this.Pnl_Superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dvg_Salones)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_Superior
            // 
            this.Pnl_Superior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(142)))), ((int)(((byte)(181)))));
            this.Pnl_Superior.Controls.Add(this.label1);
            this.Pnl_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Superior.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Superior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pnl_Superior.Name = "Pnl_Superior";
            this.Pnl_Superior.Size = new System.Drawing.Size(1348, 64);
            this.Pnl_Superior.TabIndex = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(28, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "MODULO HOTELERIA";
            // 
            // Txt_capacidad
            // 
            this.Txt_capacidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_capacidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_capacidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_capacidad.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Txt_capacidad.Location = new System.Drawing.Point(836, 160);
            this.Txt_capacidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_capacidad.Name = "Txt_capacidad";
            this.Txt_capacidad.Size = new System.Drawing.Size(237, 27);
            this.Txt_capacidad.TabIndex = 111;
            // 
            // Txt_ubicacion
            // 
            this.Txt_ubicacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_ubicacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_ubicacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_ubicacion.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Txt_ubicacion.Location = new System.Drawing.Point(275, 223);
            this.Txt_ubicacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_ubicacion.Name = "Txt_ubicacion";
            this.Txt_ubicacion.Size = new System.Drawing.Size(237, 27);
            this.Txt_ubicacion.TabIndex = 110;
            // 
            // Btn_modificar
            // 
            this.Btn_modificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_modificar.BackColor = System.Drawing.Color.White;
            this.Btn_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_modificar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_modificar.Image")));
            this.Btn_modificar.Location = new System.Drawing.Point(1157, 78);
            this.Btn_modificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_modificar.Name = "Btn_modificar";
            this.Btn_modificar.Size = new System.Drawing.Size(53, 46);
            this.Btn_modificar.TabIndex = 109;
            this.Btn_modificar.UseVisualStyleBackColor = false;
            this.Btn_modificar.Click += new System.EventHandler(this.Btn_modificar_Click);
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_eliminar.BackColor = System.Drawing.Color.White;
            this.Btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_eliminar.Image")));
            this.Btn_eliminar.Location = new System.Drawing.Point(1099, 78);
            this.Btn_eliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(53, 46);
            this.Btn_eliminar.TabIndex = 108;
            this.Btn_eliminar.UseVisualStyleBackColor = false;
            this.Btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_guardar.BackColor = System.Drawing.Color.White;
            this.Btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_guardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_guardar.Image")));
            this.Btn_guardar.Location = new System.Drawing.Point(1040, 78);
            this.Btn_guardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(53, 46);
            this.Btn_guardar.TabIndex = 107;
            this.Btn_guardar.UseVisualStyleBackColor = false;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Lbl_Capacidad
            // 
            this.Lbl_Capacidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Capacidad.AutoSize = true;
            this.Lbl_Capacidad.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lbl_Capacidad.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Lbl_Capacidad.Location = new System.Drawing.Point(591, 160);
            this.Lbl_Capacidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Capacidad.Name = "Lbl_Capacidad";
            this.Lbl_Capacidad.Size = new System.Drawing.Size(197, 20);
            this.Lbl_Capacidad.TabIndex = 106;
            this.Lbl_Capacidad.Text = "Capacidad de personas ";
            // 
            // Lbl_Ubicacion
            // 
            this.Lbl_Ubicacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Ubicacion.AutoSize = true;
            this.Lbl_Ubicacion.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lbl_Ubicacion.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Lbl_Ubicacion.Location = new System.Drawing.Point(29, 223);
            this.Lbl_Ubicacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Ubicacion.Name = "Lbl_Ubicacion";
            this.Lbl_Ubicacion.Size = new System.Drawing.Size(88, 20);
            this.Lbl_Ubicacion.TabIndex = 105;
            this.Lbl_Ubicacion.Text = "Ubicacion";
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lbl_Nombre.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Lbl_Nombre.Location = new System.Drawing.Point(28, 160);
            this.Lbl_Nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(151, 20);
            this.Lbl_Nombre.TabIndex = 104;
            this.Lbl_Nombre.Text = "Nombre Del Salon";
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Nombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Nombre.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Txt_Nombre.Location = new System.Drawing.Point(275, 158);
            this.Txt_Nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(237, 27);
            this.Txt_Nombre.TabIndex = 103;
            // 
            // Lbl_Consulta
            // 
            this.Lbl_Consulta.AutoSize = true;
            this.Lbl_Consulta.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lbl_Consulta.Font = new System.Drawing.Font("Rockwell", 18F);
            this.Lbl_Consulta.Location = new System.Drawing.Point(25, 90);
            this.Lbl_Consulta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Consulta.Name = "Lbl_Consulta";
            this.Lbl_Consulta.Size = new System.Drawing.Size(229, 35);
            this.Lbl_Consulta.TabIndex = 102;
            this.Lbl_Consulta.Text = "Datos del Salon";
            // 
            // Dvg_Salones
            // 
            this.Dvg_Salones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dvg_Salones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dvg_Salones.Location = new System.Drawing.Point(16, 378);
            this.Dvg_Salones.Margin = new System.Windows.Forms.Padding(4);
            this.Dvg_Salones.Name = "Dvg_Salones";
            this.Dvg_Salones.RowHeadersWidth = 51;
            this.Dvg_Salones.Size = new System.Drawing.Size(1316, 396);
            this.Dvg_Salones.TabIndex = 101;
            this.Dvg_Salones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dvg_Salones_CellClick);
            // 
            // Lbl_Disponibilidad
            // 
            this.Lbl_Disponibilidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Disponibilidad.AutoSize = true;
            this.Lbl_Disponibilidad.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lbl_Disponibilidad.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Lbl_Disponibilidad.Location = new System.Drawing.Point(591, 223);
            this.Lbl_Disponibilidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Disponibilidad.Name = "Lbl_Disponibilidad";
            this.Lbl_Disponibilidad.Size = new System.Drawing.Size(123, 20);
            this.Lbl_Disponibilidad.TabIndex = 112;
            this.Lbl_Disponibilidad.Text = "Disponibilidad";
            // 
            // Chk_disponibilidad
            // 
            this.Chk_disponibilidad.AutoSize = true;
            this.Chk_disponibilidad.Location = new System.Drawing.Point(836, 230);
            this.Chk_disponibilidad.Margin = new System.Windows.Forms.Padding(4);
            this.Chk_disponibilidad.Name = "Chk_disponibilidad";
            this.Chk_disponibilidad.Size = new System.Drawing.Size(18, 17);
            this.Chk_disponibilidad.TabIndex = 113;
            this.Chk_disponibilidad.UseVisualStyleBackColor = true;
            // 
            // Frm_Salones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 789);
            this.Controls.Add(this.Chk_disponibilidad);
            this.Controls.Add(this.Lbl_Disponibilidad);
            this.Controls.Add(this.Txt_capacidad);
            this.Controls.Add(this.Txt_ubicacion);
            this.Controls.Add(this.Btn_modificar);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Lbl_Capacidad);
            this.Controls.Add(this.Lbl_Ubicacion);
            this.Controls.Add(this.Lbl_Nombre);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.Lbl_Consulta);
            this.Controls.Add(this.Dvg_Salones);
            this.Controls.Add(this.Pnl_Superior);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Salones";
            this.Text = "Frm_Salones";
            this.Pnl_Superior.ResumeLayout(false);
            this.Pnl_Superior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dvg_Salones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Superior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_capacidad;
        private System.Windows.Forms.TextBox Txt_ubicacion;
        private System.Windows.Forms.Button Btn_modificar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Label Lbl_Capacidad;
        private System.Windows.Forms.Label Lbl_Ubicacion;
        private System.Windows.Forms.Label Lbl_Nombre;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.Label Lbl_Consulta;
        private System.Windows.Forms.DataGridView Dvg_Salones;
        private System.Windows.Forms.Label Lbl_Disponibilidad;
        private System.Windows.Forms.CheckBox Chk_disponibilidad;
    }
}