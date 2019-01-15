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
	///The Recording6 recording.
	/// </summary>
	[TestModule("1b0516e8-890c-4f95-ac67-aa76e61d41a0", ModuleType.Recording, 1)]
	public partial class Recording6 : ITestModule
	{
		/// <summary>
		/// Holds an instance of the sample_1.sample_1Repository repository.
		/// </summary>
		public static sample_1.sample_1Repository repo = sample_1.sample_1Repository.Instance;

		static Recording6 instance = new Recording6();

		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public Recording6()
		{
		}

		/// <summary>
		/// Gets a static instance of this recording.
		/// </summary>
		public static Recording6 Instance
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

			Report.Log(ReportLevel.Info, "Application", "Run application 'C:\\Windows\\System32\\calc.exe' with arguments '' in normal mode.", new RecordItemIndex(0));
			Host.Local.RunApplication("C:\\Windows\\System32\\calc.exe", "", "C:\\Windows\\System32", false);
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WindowsApp電卓.SomeText' at 19;12.", repo.WindowsApp電卓.SomeTextInfo, new RecordItemIndex(1));
			repo.WindowsApp電卓.SomeText.Click("19;12");
			Delay.Milliseconds(200);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WindowsApp電卓.FlyoutNav.Standard' at 7;0.", repo.WindowsApp電卓.FlyoutNav.StandardInfo, new RecordItemIndex(2));
			repo.WindowsApp電卓.FlyoutNav.Standard.Click("7;0");
			Delay.Milliseconds(200);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WindowsApp電卓.Text1' at 7;12.", repo.WindowsApp電卓.Text1Info, new RecordItemIndex(3));
			repo.WindowsApp電卓.Text1.Click("7;12");
			Delay.Milliseconds(200);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WindowsApp電卓.NavButton' at 35;28.", repo.WindowsApp電卓.NavButtonInfo, new RecordItemIndex(4));
			repo.WindowsApp電卓.NavButton.Click("35;28");
			Delay.Milliseconds(200);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'WindowsApp電卓.FlyoutNav.電力動力コンバーター' at 245;11.", repo.WindowsApp電卓.FlyoutNav.電力動力コンバーターInfo, new RecordItemIndex(5));
			repo.WindowsApp電卓.FlyoutNav.電力動力コンバーター.MoveTo("245;11");
			Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
			Delay.Milliseconds(200);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'WindowsApp電卓.FlyoutNav.電力動力コンバーター' at 253;3.", repo.WindowsApp電卓.FlyoutNav.電力動力コンバーターInfo, new RecordItemIndex(6));
			repo.WindowsApp電卓.FlyoutNav.電力動力コンバーター.MoveTo("253;3");
			Delay.Milliseconds(200);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'WindowsApp電卓.ListViewHeaderItem' at 253;25.", repo.WindowsApp電卓.ListViewHeaderItemInfo, new RecordItemIndex(7));
			repo.WindowsApp電卓.ListViewHeaderItem.MoveTo("253;25");
			Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
			Delay.Milliseconds(200);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WindowsApp電卓.FlyoutNav.標準電卓' at 97;35.", repo.WindowsApp電卓.FlyoutNav.標準電卓Info, new RecordItemIndex(8));
			repo.WindowsApp電卓.FlyoutNav.標準電卓.Click("97;35");
			Delay.Milliseconds(200);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WindowsApp電卓.Close' at 23;20.", repo.WindowsApp電卓.CloseInfo, new RecordItemIndex(9));
			repo.WindowsApp電卓.Close.Click("23;20");
			Delay.Milliseconds(200);
			
		}

#region Image Feature Data
#endregion
	}
#pragma warning restore 0436
}
