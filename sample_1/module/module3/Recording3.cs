﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace sample_1.module.module3
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
	/// <summary>
	///The Recording3 recording.
	/// </summary>
	[TestModule("88193ca2-a72c-478b-af21-cc6b25a0bc04", ModuleType.Recording, 1)]
	public partial class Recording3 : ITestModule
	{
		/// <summary>
		/// Holds an instance of the sample_1.sample_1Repository repository.
		/// </summary>
		public static sample_1.sample_1Repository repo = sample_1.sample_1Repository.Instance;

		static Recording3 instance = new Recording3();

		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public Recording3()
		{
		}

		/// <summary>
		/// Gets a static instance of this recording.
		/// </summary>
		public static Recording3 Instance
		{
			get { return instance; }
		}

#region Variables

#endregion

		/// <summary>
		/// Starts the replay of the static recording <see cref="Instance"/>.
		/// </summary>
		[System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
		public static void Start()
		{
			TestModuleRunner.Run(Instance);
		}

		/// <summary>
		/// Performs the playback of actions in this recording.
		/// </summary>
		/// <remarks>You should not call this method directly, instead pass the module
		/// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
		/// that will in turn invoke this method.</remarks>
		[System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
		void ITestModule.Run()
		{
			Mouse.DefaultMoveTime = 300;
			Keyboard.DefaultKeyPressTime = 100;
			Delay.SpeedFactor = 1.00;

			Init();

			Report.Log(ReportLevel.Info, "Application", "Run application 'C:\\vender\\Ranorex\\Sample\\RxDemoApp\\RxDemoApp.exe' with arguments '' in normal mode.", new RecordItemIndex(0));
			Host.Local.RunApplication("C:\\vender\\Ranorex\\Sample\\RxDemoApp\\RxDemoApp.exe", "", "C:\\vender\\Ranorex\\Sample\\RxDemoApp", false);
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.UIElementTestArea' at 26;16.", repo.RxMainFrame.UIElementTestAreaInfo, new RecordItemIndex(1));
			repo.RxMainFrame.UIElementTestArea.Click("26;16");
			Delay.Milliseconds(200);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RxTabUIElements.FirstName行2' at 25;8.", repo.RxMainFrame.RxTabUIElements.FirstName行2Info, new RecordItemIndex(2));
			repo.RxMainFrame.RxTabUIElements.FirstName行2.Click("25;8");
			Delay.Milliseconds(200);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RxTabUIElements.TreeView' at 14;63.", repo.RxMainFrame.RxTabUIElements.TreeViewInfo, new RecordItemIndex(3));
			repo.RxMainFrame.RxTabUIElements.TreeView.Click("14;63");
			Delay.Milliseconds(200);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RxTabUIElements.WebTesting' at 21;6.", repo.RxMainFrame.RxTabUIElements.WebTestingInfo, new RecordItemIndex(4));
			repo.RxMainFrame.RxTabUIElements.WebTesting.Click("21;6");
			Delay.Milliseconds(200);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RxTabUIElements.RdbRedLight' at 44;6.", repo.RxMainFrame.RxTabUIElements.RdbRedLightInfo, new RecordItemIndex(5));
			repo.RxMainFrame.RxTabUIElements.RdbRedLight.Click("44;6");
			Delay.Milliseconds(200);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RxButtonExit' at 49;21.", repo.RxMainFrame.RxButtonExitInfo, new RecordItemIndex(6));
			repo.RxMainFrame.RxButtonExit.Click("49;21");
			Delay.Milliseconds(200);
			
		}

#region Image Feature Data
#endregion
	}
#pragma warning restore 0436
}
