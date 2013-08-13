/*
 * Created by SharpDevelop.
 * User: dkurz
 * Date: 12.08.2013
 * Time: 15:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Net;

namespace StrombergAmpel
{
	/// <summary>
	/// Description of flowtrail_functions.
	/// </summary>
	public partial class flowtrail_functions : UserControl
	{
		
		public string returnStatus { get; set; }
		public string returnImage { get; set; }
		
		public flowtrail_functions()
		{
			InitializeComponent();
	    }
		
		public void getSourceCode()
		{
			
			int nv_indexOfPicture     = 0;
			
			WebClient wc = new WebClient();
			
			string sv_sourcecode      = "";
			
			string sv_offen_gruen     = "http://www.flowtrail-stromberg.de/images/piktogramme/ampelmann-gruen-rechts.png";
			string sv_geschlossen_rot = "http://www.flowtrail-stromberg.de/images/piktogramme/ampelmann-rot.png";
				
			try
			{
				sv_sourcecode = wc.DownloadString("http://www.flowtrail-stromberg.de");
				
			}catch
			{
				MessageBox.Show("Konnte keine Verbindung zur Website herstellen.");
				returnStatus = "Fehler beim Verbinden mit http://www.flowtrail-stromberg.de.";
			}
			
			nv_indexOfPicture = sv_sourcecode.IndexOf("ampelmann-gruen-rechts.png");
			if(nv_indexOfPicture > 0)
			{
				// Dann ist die Strecke offen	
			    returnImage = sv_offen_gruen;
			    returnStatus = "Strecke geöffnet!";
			}
			else
			{
				//Dann ist die Strecke geschlossen
				returnImage = sv_geschlossen_rot;
				returnStatus = "Strecke geschlossen!";
			}
			
		}
	}
}
