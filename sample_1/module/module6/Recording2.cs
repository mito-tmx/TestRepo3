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

namespace sample_1.module.module6
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
	/// <summary>
	///The Recording2 recording.
	/// </summary>
	[TestModule("8919c19c-90be-4878-bcfe-42de6b6bcad3", ModuleType.Recording, 1)]
	public partial class Recording2 : ITestModule
	{
		/// <summary>
		/// Holds an instance of the sample_1.sample_1Repository repository.
		/// </summary>
		public static sample_1.sample_1Repository repo = sample_1.sample_1Repository.Instance;

		static Recording2 instance = new Recording2();

		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public Recording2()
		{
		}

		/// <summary>
		/// Gets a static instance of this recording.
		/// </summary>
		public static Recording2 Instance
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
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.TestDatabase' at 28;9.", repo.RxMainFrame.TestDatabaseInfo, new RecordItemIndex(1));
			repo.RxMainFrame.TestDatabase.Click("28;9");
			Delay.Milliseconds(200);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RxTabStandard.FirstName' at 71;3.", repo.RxMainFrame.RxTabStandard.FirstNameInfo, new RecordItemIndex(2));
			repo.RxMainFrame.RxTabStandard.FirstName.Click("71;3");
			Delay.Milliseconds(200);
			
			Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'test' with focus on 'RxMainFrame.RxTabStandard.FirstName'.", repo.RxMainFrame.RxTabStandard.FirstNameInfo, new RecordItemIndex(3));
			repo.RxMainFrame.RxTabStandard.FirstName.PressKeys("test");
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RxTabStandard.LastName' at 34;6.", repo.RxMainFrame.RxTabStandard.LastNameInfo, new RecordItemIndex(4));
			repo.RxMainFrame.RxTabStandard.LastName.Click("34;6");
			Delay.Milliseconds(200);
			
			Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'test' with focus on 'RxMainFrame.RxTabStandard.LastName'.", repo.RxMainFrame.RxTabStandard.LastNameInfo, new RecordItemIndex(5));
			repo.RxMainFrame.RxTabStandard.LastName.PressKeys("test");
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RxTabStandard.CmbDepartment' at 351;7.", repo.RxMainFrame.RxTabStandard.CmbDepartmentInfo, new RecordItemIndex(6));
			repo.RxMainFrame.RxTabStandard.CmbDepartment.Click("351;7");
			Delay.Milliseconds(200);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'List1000.ProjectManagement' at 248;1.", repo.List1000.ProjectManagementInfo, new RecordItemIndex(7));
			repo.List1000.ProjectManagement.Click("248;1");
			Delay.Milliseconds(200);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RxTabStandard.Button上へ' at 6;5.", repo.RxMainFrame.RxTabStandard.Button上へInfo, new RecordItemIndex(8));
			repo.RxMainFrame.RxTabStandard.Button上へ.Click("6;5");
			Delay.Milliseconds(200);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RxTabStandard.Button上へ' at 6;5.", repo.RxMainFrame.RxTabStandard.Button上へInfo, new RecordItemIndex(9));
			repo.RxMainFrame.RxTabStandard.Button上へ.Click("6;5");
			Delay.Milliseconds(200);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RxTabStandard.Button上へ' at 14;6.", repo.RxMainFrame.RxTabStandard.Button上へInfo, new RecordItemIndex(10));
			repo.RxMainFrame.RxTabStandard.Button上へ.Click("14;6");
			Delay.Milliseconds(200);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RxTabStandard.RdbMale' at 30;9.", repo.RxMainFrame.RxTabStandard.RdbMaleInfo, new RecordItemIndex(11));
			repo.RxMainFrame.RxTabStandard.RdbMale.Click("30;9");
			Delay.Milliseconds(200);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RxTabStandard.BtnAddPerson' at 56;10.", repo.RxMainFrame.RxTabStandard.BtnAddPersonInfo, new RecordItemIndex(12));
			repo.RxMainFrame.RxTabStandard.BtnAddPerson.Click("56;10");
			Delay.Milliseconds(200);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RxTabStandard.LstPersonList' at 168;1.", repo.RxMainFrame.RxTabStandard.LstPersonListInfo, new RecordItemIndex(13));
			repo.RxMainFrame.RxTabStandard.LstPersonList.Click("168;1");
			Delay.Milliseconds(200);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RxTabStandard.TestTestMale3ProjectManagement' at 195;7.", repo.RxMainFrame.RxTabStandard.TestTestMale3ProjectManagementInfo, new RecordItemIndex(14));
			repo.RxMainFrame.RxTabStandard.TestTestMale3ProjectManagement.Click("195;7");
			Delay.Milliseconds(200);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RxTabStandard.BtnDeletePerson' at 24;17.", repo.RxMainFrame.RxTabStandard.BtnDeletePersonInfo, new RecordItemIndex(15));
			repo.RxMainFrame.RxTabStandard.BtnDeletePerson.Click("24;17");
			Delay.Milliseconds(200);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RxButtonExit' at 10;2.", repo.RxMainFrame.RxButtonExitInfo, new RecordItemIndex(16));
			repo.RxMainFrame.RxButtonExit.Click("10;2");
			Delay.Milliseconds(200);
			
		}

#region Image Feature Data
#endregion
	}
#pragma warning restore 0436
}
