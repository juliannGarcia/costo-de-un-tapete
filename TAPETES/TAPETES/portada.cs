/*
 * Created by SharpDevelop.
 * User: CC2-PC14
 * Date: 20/11/2024
 * Time: 07:36 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TAPETES
{
	/// <summary>
	/// Description of portada.
	/// </summary>
	public partial class portada : Form
	{
		public portada()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			MainForm calculo  = new MainForm();
			calculo.ShowDialog();
			
		}
	}
}
