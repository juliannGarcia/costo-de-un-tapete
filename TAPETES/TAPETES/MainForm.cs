/*
 * Created by SharpDevelop.
 * User: CC2-PC14
 * Date: 13/11/2024
 * Time: 08:01 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TAPETES
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		
		
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
            try
    { 
        // Obtener valores ingresados
        decimal largo = decimal.Parse(txtLargo.Text);
        decimal ancho = decimal.Parse(txtAncho.Text);
        decimal costoAserrin = decimal.Parse(txtCosto.Text);
        decimal cantidadAserrin = decimal.Parse(txtCantidadUsada1.Text);
        decimal costoPintura = decimal.Parse(txtLitro.Text);
        decimal cantidadPintura = decimal.Parse(txtCantidadUsada2.Text);
        decimal costoFlores = decimal.Parse(txtCostoPorDocena.Text);
        decimal cantidadFlores = decimal.Parse(txtCantidadUsada4.Text);
        decimal precioFrutosSecos = decimal.Parse(txtCostoporKg.Text);
        decimal cantidadFrutosSecos = decimal.Parse(txtCantidadUsada3.Text);
        decimal costoAgua = decimal.Parse(txtCostoPorLitro.Text);
        decimal cantidadAgua = decimal.Parse(txtCantidadUsada5.Text);
        int numeroIntegrantes = int.Parse(txtNumeroDeIntegrantes.Text);
        decimal horasDiseño = decimal.Parse(txtHorasDeDiseño.Text);
        decimal costoPorHora = decimal.Parse(txtCostoDeCadaHora.Text);
        decimal costoManoObra = decimal.Parse(txtCostoManoDeObra.Text);
        decimal totalAlimentos = numeroIntegrantes*(precioFrutosSecos+costoFlores);
        decimal costomanodeobra = costoManoObra * numeroIntegrantes;
        

        // Calcular el área del tapete
        decimal area = largo * ancho;

        // Calcular costos
        decimal totalAserrin = costoAserrin * cantidadAserrin;
        decimal totalPintura = costoPintura * cantidadPintura;
        decimal totalFrutosSecos = precioFrutosSecos * cantidadFrutosSecos;
        decimal totalAgua = costoAgua * cantidadAgua;
        decimal totalDiseño = horasDiseño * costoPorHora;
        decimal totalflores = cantidadFlores * costoFlores;
        decimal totalalimentos = numeroIntegrantes * (costoFlores + precioFrutosSecos);
        decimal totalManoDeObra = costoManoObra * numeroIntegrantes;
        
        
        
        //calcular costo de mano de obra total
        decimal totalManoObra = costoManoObra*numeroIntegrantes;

        // Calcular precio final
       decimal PrecioFinal = totalAserrin+totalPintura+totalFrutosSecos+totalflores+totalAlimentos+totalAgua+totalDiseño+totalManoDeObra;

        // Mostrar el resultado
        lblPrecioFinal.Text = "El precio final del tapete es: " + PrecioFinal.ToString("C");
    }
    catch (FormatException)
    {
        MessageBox.Show("Por favor, ingrese valores válidos.");
    }
}
}
          }
		  
	

 