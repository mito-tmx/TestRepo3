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

namespace sample_1.module.module2
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
	/// <summary>
	///The Recording8 recording.
	/// </summary>
	[TestModule("f2909ca0-0d87-42cd-ac60-c8358c55bb4e", ModuleType.Recording, 1)]
	public partial class Recording8 : ITestModule
	{
		/// <summary>
		/// Holds an instance of the sample_1.sample_1Repository repository.
		/// </summary>
		public static sample_1.sample_1Repository repo = sample_1.sample_1Repository.Instance;

		static Recording8 instance = new Recording8();

		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public Recording8()
		{
		}

		/// <summary>
		/// Gets a static instance of this recording.
		/// </summary>
		public static Recording8 Instance
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
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WindowsApp電卓.Num5Button' at 28;22.", repo.WindowsApp電卓.Num5ButtonInfo, new RecordItemIndex(1));
			repo.WindowsApp電卓.Num5Button.Click("28;22");
			Delay.Milliseconds(200);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WindowsApp電卓.MultiplyButton' at 23;23.", repo.WindowsApp電卓.MultiplyButtonInfo, new RecordItemIndex(2));
			repo.WindowsApp電卓.MultiplyButton.Click("23;23");
			Delay.Milliseconds(200);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WindowsApp電卓.Num9Button' at 18;22.", repo.WindowsApp電卓.Num9ButtonInfo, new RecordItemIndex(3));
			repo.WindowsApp電卓.Num9Button.Click("18;22");
			Delay.Milliseconds(200);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WindowsApp電卓.MultiplyButton' at 20;23.", repo.WindowsApp電卓.MultiplyButtonInfo, new RecordItemIndex(4));
			repo.WindowsApp電卓.MultiplyButton.Click("20;23");
			Delay.Milliseconds(200);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WindowsApp電卓.ClearButton' at 49;19.", repo.WindowsApp電卓.ClearButtonInfo, new RecordItemIndex(5));
			repo.WindowsApp電卓.ClearButton.Click("49;19");
			Delay.Milliseconds(200);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WindowsApp電卓.Close' at 36;11.", repo.WindowsApp電卓.CloseInfo, new RecordItemIndex(6));
			repo.WindowsApp電卓.Close.Click("36;11");
			Delay.Milliseconds(200);
			
		}

#region Image Feature Data
#endregion
	}
#pragma warning restore 0436
}
