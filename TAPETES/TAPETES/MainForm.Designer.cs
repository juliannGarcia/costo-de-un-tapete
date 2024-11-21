/*
 * Created by SharpDevelop.
 * User: CC2-PC14
 * Date: 13/11/2024
 * Time: 08:01 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TAPETES
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblTamaño = new System.Windows.Forms.Label();
			this.txtLargo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtCosto = new System.Windows.Forms.TextBox();
			this.lblCosto = new System.Windows.Forms.Label();
			this.txtCantidadUsada1 = new System.Windows.Forms.TextBox();
			this.lblCantidad = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtLitro = new System.Windows.Forms.TextBox();
			this.txtCantidadUsada2 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtCostoporKg = new System.Windows.Forms.TextBox();
			this.txtCantidadUsada3 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.txtCantidadUsada4 = new System.Windows.Forms.TextBox();
			this.txtCostoPorDocena = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.txtCantidadUsada5 = new System.Windows.Forms.TextBox();
			this.txtCostoPorLitro = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.txtNumeroDeIntegrantes = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.txtAncho = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.txtHorasDeDiseño = new System.Windows.Forms.TextBox();
			this.txtCostoDeCadaHora = new System.Windows.Forms.TextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.txtCostoManoDeObra = new System.Windows.Forms.TextBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.lblPrecioFinal = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblTamaño
			// 
			this.lblTamaño.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTamaño.Location = new System.Drawing.Point(12, 113);
			this.lblTamaño.Name = "lblTamaño";
			this.lblTamaño.Size = new System.Drawing.Size(202, 28);
			this.lblTamaño.TabIndex = 0;
			this.lblTamaño.Text = "Tamaño del tapete (area):";
			// 
			// txtLargo
			// 
			this.txtLargo.Location = new System.Drawing.Point(217, 113);
			this.txtLargo.Name = "txtLargo";
			this.txtLargo.Size = new System.Drawing.Size(100, 20);
			this.txtLargo.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(66, 156);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(145, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Aserrin: ";
			// 
			// txtCosto
			// 
			this.txtCosto.Location = new System.Drawing.Point(217, 159);
			this.txtCosto.Name = "txtCosto";
			this.txtCosto.Size = new System.Drawing.Size(100, 20);
			this.txtCosto.TabIndex = 3;
			// 
			// lblCosto
			// 
			this.lblCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCosto.Location = new System.Drawing.Point(217, 136);
			this.lblCosto.Name = "lblCosto";
			this.lblCosto.Size = new System.Drawing.Size(100, 23);
			this.lblCosto.TabIndex = 4;
			this.lblCosto.Text = "Costo Por Bulto";
			// 
			// txtCantidadUsada1
			// 
			this.txtCantidadUsada1.Location = new System.Drawing.Point(352, 159);
			this.txtCantidadUsada1.Name = "txtCantidadUsada1";
			this.txtCantidadUsada1.Size = new System.Drawing.Size(100, 20);
			this.txtCantidadUsada1.TabIndex = 5;
			// 
			// lblCantidad
			// 
			this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCantidad.Location = new System.Drawing.Point(352, 136);
			this.lblCantidad.Name = "lblCantidad";
			this.lblCantidad.Size = new System.Drawing.Size(100, 20);
			this.lblCantidad.TabIndex = 6;
			this.lblCantidad.Text = "Cantidad Usada";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(66, 193);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(107, 23);
			this.label2.TabIndex = 7;
			this.label2.Text = "Pintura:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(217, 182);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 8;
			this.label3.Text = "Costo por litro";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(352, 182);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 9;
			this.label4.Text = " Cantidad Usada";
			// 
			// txtLitro
			// 
			this.txtLitro.Location = new System.Drawing.Point(217, 196);
			this.txtLitro.Name = "txtLitro";
			this.txtLitro.Size = new System.Drawing.Size(100, 20);
			this.txtLitro.TabIndex = 10;
			// 
			// txtCantidadUsada2
			// 
			this.txtCantidadUsada2.Location = new System.Drawing.Point(352, 196);
			this.txtCantidadUsada2.Name = "txtCantidadUsada2";
			this.txtCantidadUsada2.Size = new System.Drawing.Size(100, 20);
			this.txtCantidadUsada2.TabIndex = 11;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(66, 233);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(130, 23);
			this.label5.TabIndex = 12;
			this.label5.Text = "Frutos secos:";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(217, 219);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 13;
			this.label6.Text = "Costo por kg";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(352, 219);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 14;
			this.label7.Text = "Cantidad Usada";
			// 
			// txtCostoporKg
			// 
			this.txtCostoporKg.Location = new System.Drawing.Point(217, 236);
			this.txtCostoporKg.Name = "txtCostoporKg";
			this.txtCostoporKg.Size = new System.Drawing.Size(100, 20);
			this.txtCostoporKg.TabIndex = 15;
			// 
			// txtCantidadUsada3
			// 
			this.txtCantidadUsada3.Location = new System.Drawing.Point(352, 236);
			this.txtCantidadUsada3.Name = "txtCantidadUsada3";
			this.txtCantidadUsada3.Size = new System.Drawing.Size(100, 20);
			this.txtCantidadUsada3.TabIndex = 16;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(66, 279);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(91, 16);
			this.label8.TabIndex = 17;
			this.label8.Text = "Flores:";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(217, 259);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(118, 23);
			this.label9.TabIndex = 18;
			this.label9.Text = "Costo por docena ";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(352, 259);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(118, 23);
			this.label10.TabIndex = 19;
			this.label10.Text = "Cantidad Usada";
			// 
			// txtCantidadUsada4
			// 
			this.txtCantidadUsada4.Location = new System.Drawing.Point(352, 275);
			this.txtCantidadUsada4.Name = "txtCantidadUsada4";
			this.txtCantidadUsada4.Size = new System.Drawing.Size(100, 20);
			this.txtCantidadUsada4.TabIndex = 20;
			// 
			// txtCostoPorDocena
			// 
			this.txtCostoPorDocena.Location = new System.Drawing.Point(217, 275);
			this.txtCostoPorDocena.Name = "txtCostoPorDocena";
			this.txtCostoPorDocena.Size = new System.Drawing.Size(100, 20);
			this.txtCostoPorDocena.TabIndex = 21;
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(66, 311);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(231, 23);
			this.label11.TabIndex = 22;
			this.label11.Text = "Agua:";
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(352, 298);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(118, 23);
			this.label12.TabIndex = 23;
			this.label12.Text = "Cantidad Usada ";
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(217, 298);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(118, 23);
			this.label13.TabIndex = 24;
			this.label13.Text = "Costo por litro ";
			// 
			// txtCantidadUsada5
			// 
			this.txtCantidadUsada5.Location = new System.Drawing.Point(352, 314);
			this.txtCantidadUsada5.Name = "txtCantidadUsada5";
			this.txtCantidadUsada5.Size = new System.Drawing.Size(100, 20);
			this.txtCantidadUsada5.TabIndex = 25;
			// 
			// txtCostoPorLitro
			// 
			this.txtCostoPorLitro.Location = new System.Drawing.Point(217, 314);
			this.txtCostoPorLitro.Name = "txtCostoPorLitro";
			this.txtCostoPorLitro.Size = new System.Drawing.Size(100, 20);
			this.txtCostoPorLitro.TabIndex = 26;
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(66, 364);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(130, 23);
			this.label14.TabIndex = 27;
			this.label14.Text = "Integrantes: ";
			// 
			// txtNumeroDeIntegrantes
			// 
			this.txtNumeroDeIntegrantes.Location = new System.Drawing.Point(217, 367);
			this.txtNumeroDeIntegrantes.Name = "txtNumeroDeIntegrantes";
			this.txtNumeroDeIntegrantes.Size = new System.Drawing.Size(100, 20);
			this.txtNumeroDeIntegrantes.TabIndex = 28;
			// 
			// label15
			// 
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(12, 409);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(231, 23);
			this.label15.TabIndex = 29;
			this.label15.Text = "Tiempo de diseño :";
			// 
			// label16
			// 
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(217, 344);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(144, 20);
			this.label16.TabIndex = 30;
			this.label16.Text = "Numero de personas";
			// 
			// txtAncho
			// 
			this.txtAncho.Location = new System.Drawing.Point(352, 113);
			this.txtAncho.Name = "txtAncho";
			this.txtAncho.Size = new System.Drawing.Size(100, 20);
			this.txtAncho.TabIndex = 31;
			// 
			// label17
			// 
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(217, 90);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(100, 23);
			this.label17.TabIndex = 32;
			this.label17.Text = "Largo";
			// 
			// label18
			// 
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.Location = new System.Drawing.Point(352, 90);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(100, 23);
			this.label18.TabIndex = 33;
			this.label18.Text = "Ancho";
			// 
			// label19
			// 
			this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.Location = new System.Drawing.Point(217, 390);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(118, 23);
			this.label19.TabIndex = 34;
			this.label19.Text = "Horas de diseño";
			// 
			// label20
			// 
			this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label20.Location = new System.Drawing.Point(352, 390);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(118, 23);
			this.label20.TabIndex = 35;
			this.label20.Text = "Costo de cada hora";
			// 
			// txtHorasDeDiseño
			// 
			this.txtHorasDeDiseño.Location = new System.Drawing.Point(217, 408);
			this.txtHorasDeDiseño.Name = "txtHorasDeDiseño";
			this.txtHorasDeDiseño.Size = new System.Drawing.Size(100, 20);
			this.txtHorasDeDiseño.TabIndex = 36;
			// 
			// txtCostoDeCadaHora
			// 
			this.txtCostoDeCadaHora.Location = new System.Drawing.Point(352, 408);
			this.txtCostoDeCadaHora.Name = "txtCostoDeCadaHora";
			this.txtCostoDeCadaHora.Size = new System.Drawing.Size(100, 20);
			this.txtCostoDeCadaHora.TabIndex = 37;
			// 
			// label21
			// 
			this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label21.Location = new System.Drawing.Point(12, 441);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(231, 23);
			this.label21.TabIndex = 38;
			this.label21.Text = "Costo mano de obra:";
			// 
			// txtCostoManoDeObra
			// 
			this.txtCostoManoDeObra.Location = new System.Drawing.Point(217, 440);
			this.txtCostoManoDeObra.Name = "txtCostoManoDeObra";
			this.txtCostoManoDeObra.Size = new System.Drawing.Size(100, 20);
			this.txtCostoManoDeObra.TabIndex = 39;
			// 
			// btnCalcular
			// 
			this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalcular.Location = new System.Drawing.Point(228, 486);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(133, 33);
			this.btnCalcular.TabIndex = 40;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// lblPrecioFinal
			// 
			this.lblPrecioFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPrecioFinal.Location = new System.Drawing.Point(487, 370);
			this.lblPrecioFinal.Name = "lblPrecioFinal";
			this.lblPrecioFinal.Size = new System.Drawing.Size(332, 129);
			this.lblPrecioFinal.TabIndex = 41;
			this.lblPrecioFinal.Text = "////";
			// 
			// label22
			// 
			this.label22.Location = new System.Drawing.Point(487, 340);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(100, 23);
			this.label22.TabIndex = 42;
			this.label22.Text = "Precio Final ";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(831, 521);
			this.Controls.Add(this.label22);
			this.Controls.Add(this.lblPrecioFinal);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.txtCostoManoDeObra);
			this.Controls.Add(this.label21);
			this.Controls.Add(this.txtCostoDeCadaHora);
			this.Controls.Add(this.txtHorasDeDiseño);
			this.Controls.Add(this.label20);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.txtAncho);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.txtNumeroDeIntegrantes);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.txtCostoPorLitro);
			this.Controls.Add(this.txtCantidadUsada5);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.txtCostoPorDocena);
			this.Controls.Add(this.txtCantidadUsada4);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtCantidadUsada3);
			this.Controls.Add(this.txtCostoporKg);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtCantidadUsada2);
			this.Controls.Add(this.txtLitro);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblCantidad);
			this.Controls.Add(this.txtCantidadUsada1);
			this.Controls.Add(this.lblCosto);
			this.Controls.Add(this.txtCosto);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtLargo);
			this.Controls.Add(this.lblTamaño);
			this.Name = "MainForm";
			this.Text = "TAPETES";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label lblPrecioFinal;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.TextBox txtCostoManoDeObra;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.TextBox txtCostoDeCadaHora;
		private System.Windows.Forms.TextBox txtHorasDeDiseño;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox txtAncho;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox txtNumeroDeIntegrantes;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox txtCostoPorLitro;
		private System.Windows.Forms.TextBox txtCantidadUsada5;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtCostoPorDocena;
		private System.Windows.Forms.TextBox txtCantidadUsada4;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtCantidadUsada3;
		private System.Windows.Forms.TextBox txtCostoporKg;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtCantidadUsada2;
		private System.Windows.Forms.TextBox txtLitro;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblCantidad;
		private System.Windows.Forms.TextBox txtCantidadUsada1;
		private System.Windows.Forms.Label lblCosto;
		private System.Windows.Forms.TextBox txtCosto;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtLargo;
		private System.Windows.Forms.Label lblTamaño;
	}
}
