/*
 * Created by SharpDevelop.
 * User: dkurz
 * Date: 12.08.2013
 * Time: 14:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace StrombergAmpel
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
			
			flowtrail_functions ftf = new flowtrail_functions();
			ftf.getSourceCode();
			
						
			pictureBox1.ImageLocation = ftf.returnImage;
			label1.Text = ftf.returnStatus;
			label1.TextAlign = ContentAlignment.MiddleCenter;
			
			
			
			
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
	}
}
