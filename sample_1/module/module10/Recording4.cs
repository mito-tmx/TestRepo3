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

namespace sample_1.module.module10
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
	/// <summary>
	///The Recording4 recording.
	/// </summary>
	[TestModule("b15d5244-ef04-4e8c-8bf9-6bed2c0625cb", ModuleType.Recording, 1)]
	public partial class Recording4 : ITestModule
	{
		/// <summary>
		/// Holds an instance of the sample_1.sample_1Repository repository.
		/// </summary>
		public static sample_1.sample_1Repository repo = sample_1.sample_1Repository.Instance;

		static Recording4 instance = new Recording4();

		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public Recording4()
		{
		}

		/// <summary>
		/// Gets a static instance of this recording.
		/// </summary>
		public static Recording4 Instance
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
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.UIElementTestArea' at 56;7.", repo.RxMainFrame.UIElementTestAreaInfo, new RecordItemIndex(1));
			repo.RxMainFrame.UIElementTestArea.Click("56;7");
			Delay.Milliseconds(200);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.UploadTesting' at 17;8.", repo.RxMainFrame.UploadTestingInfo, new RecordItemIndex(2));
			repo.RxMainFrame.UploadTesting.Click("17;8");
			Delay.Milliseconds(200);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RBSlow' at 26;4.", repo.RxMainFrame.RBSlowInfo, new RecordItemIndex(3));
			repo.RxMainFrame.RBSlow.Click("26;4");
			Delay.Milliseconds(200);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.ResetUpload' at 79;11.", repo.RxMainFrame.ResetUploadInfo, new RecordItemIndex(4));
			repo.RxMainFrame.ResetUpload.Click("79;11");
			Delay.Milliseconds(200);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RxButtonExit' at 43;12.", repo.RxMainFrame.RxButtonExitInfo, new RecordItemIndex(5));
			repo.RxMainFrame.RxButtonExit.Click("43;12");
			Delay.Milliseconds(200);
			
		}

#region Image Feature Data
#endregion
	}
#pragma warning restore 0436
}
