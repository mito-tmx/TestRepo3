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

namespace sample_1.module.module5
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
	/// <summary>
	///The Recording5 recording.
	/// </summary>
	[TestModule("86381dee-a94b-4e8c-a8d5-1e5a6661a4d3", ModuleType.Recording, 1)]
	public partial class Recording5 : ITestModule
	{
		/// <summary>
		/// Holds an instance of the sample_1.sample_1Repository repository.
		/// </summary>
		public static sample_1.sample_1Repository repo = sample_1.sample_1Repository.Instance;

		static Recording5 instance = new Recording5();

		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public Recording5()
		{
		}

		/// <summary>
		/// Gets a static instance of this recording.
		/// </summary>
		public static Recording5 Instance
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
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.TestDatabase' at 32;17.", repo.RxMainFrame.TestDatabaseInfo, new RecordItemIndex(1));
			repo.RxMainFrame.TestDatabase.Click("32;17");
			Delay.Milliseconds(200);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.ImageBasedAutomation' at 42;10.", repo.RxMainFrame.ImageBasedAutomationInfo, new RecordItemIndex(2));
			repo.RxMainFrame.ImageBasedAutomation.Click("42;10");
			Delay.Milliseconds(200);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.UIElementTestArea' at 44;4.", repo.RxMainFrame.UIElementTestAreaInfo, new RecordItemIndex(3));
			repo.RxMainFrame.UIElementTestArea.Click("44;4");
			Delay.Milliseconds(200);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.UploadTesting' at 48;9.", repo.RxMainFrame.UploadTestingInfo, new RecordItemIndex(4));
			repo.RxMainFrame.UploadTesting.Click("48;9");
			Delay.Milliseconds(200);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RxButtonExit' at 42;13.", repo.RxMainFrame.RxButtonExitInfo, new RecordItemIndex(5));
			repo.RxMainFrame.RxButtonExit.Click("42;13");
			Delay.Milliseconds(200);
			
		}

#region Image Feature Data
#endregion
	}
#pragma warning restore 0436
}
