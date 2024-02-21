using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Threading;

namespace UsingAppDomains
{
	internal static class Program
	{
		static AppDomain drawer;
		static AppDomain text_window;

		static Assembly drawer_asm;
		static Assembly text_window_asm;

		static Form drawer_form;
		static Form text_window_form;

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		[LoaderOptimization(LoaderOptimization.MultiDomain)] //Для того чтобы домены имели доступ к исполняемому коду друг друга
		static void Main()
		{
			Application.EnableVisualStyles();
			//Application.SetCompatibleTextRenderingDefault(false);
			//Application.Run(new MainFOrm());
			drawer = AppDomain.CreateDomain("TextDrawer");
			text_window = AppDomain.CreateDomain("TextWindow");
			drawer_asm = drawer.Load(AssemblyName.GetAssemblyName("TextDrawer.exe"));
			text_window_asm = drawer.Load(AssemblyName.GetAssemblyName("TextWindow.exe"));
			drawer_form = Activator.CreateInstance(drawer_asm.GetType("TextDrawer.MainForm")) as Form;
			text_window_form = Activator.CreateInstance(text_window_asm.GetType("TextWindow.MainForm"), new object[] { drawer_asm.GetModule("TextDrawer.exe"), drawer_form}) as Form;

			(new Thread(new ThreadStart(Runvisualizer))).Start();
			(new Thread(new ThreadStart(RunDrawer))).Start();

			drawer.DomainUnload += new EventHandler(Drawer_DomanUnload);
		}
		static void Drawer_DomanUnload(object sender, EventArgs e)
		{
			MessageBox.Show($"Domain {(sender as AppDomain).FriendlyName} has been unloaded");
		}
		static void RunDrawer()
		{
			drawer_form.ShowDialog();
			AppDomain.Unload(drawer);
		}
		static void Runvisualizer()
		{
			text_window_form.ShowDialog();
			Application.Exit();
		}
	}	
}
