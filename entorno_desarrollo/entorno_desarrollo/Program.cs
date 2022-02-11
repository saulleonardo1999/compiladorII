﻿using System;
using System.Windows.Forms;

namespace Entorno_desarrollo
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			//try{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new MainForm());
			//}
			//catch(Exception e){
			//	MessageBox.Show(e.Message+"\n"+e.StackTrace);
			//}
		}
	}
		
}
