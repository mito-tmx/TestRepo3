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

namespace sample_1.module.module4
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
	/// <summary>
	///The Recording7 recording.
	/// </summary>
	[TestModule("25f0ddd9-7ec8-4065-b159-4074763cab4b", ModuleType.Recording, 1)]
	public partial class Recording7 : ITestModule
	{
		/// <summary>
		/// Holds an instance of the sample_1.sample_1Repository repository.
		/// </summary>
		public static sample_1.sample_1Repository repo = sample_1.sample_1Repository.Instance;

		static Recording7 instance = new Recording7();

		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public Recording7()
		{
		}

		/// <summary>
		/// Gets a static instance of this recording.
		/// </summary>
		public static Recording7 Instance
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
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WindowsApp電卓.Num1Button' at 54;28.", repo.WindowsApp電卓.Num1ButtonInfo, new RecordItemIndex(1));
			repo.WindowsApp電卓.Num1Button.Click("54;28");
			Delay.Milliseconds(200);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WindowsApp電卓.NegateButton' at 62;34.", repo.WindowsApp電卓.NegateButtonInfo, new RecordItemIndex(2));
			repo.WindowsApp電卓.NegateButton.Click("62;34");
			Delay.Milliseconds(200);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WindowsApp電卓.Text2' at 0;21.", repo.WindowsApp電卓.Text2Info, new RecordItemIndex(3));
			repo.WindowsApp電卓.Text2.Click("0;21");
			Delay.Milliseconds(200);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WindowsApp電卓.SomeText1' at 6;14.", repo.WindowsApp電卓.SomeText1Info, new RecordItemIndex(4));
			repo.WindowsApp電卓.SomeText1.Click("6;14");
			Delay.Milliseconds(200);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WindowsApp電卓.Num6Button' at 21;27.", repo.WindowsApp電卓.Num6ButtonInfo, new RecordItemIndex(5));
			repo.WindowsApp電卓.Num6Button.Click("21;27");
			Delay.Milliseconds(200);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WindowsApp電卓.PlusButton' at 22;21.", repo.WindowsApp電卓.PlusButtonInfo, new RecordItemIndex(6));
			repo.WindowsApp電卓.PlusButton.Click("22;21");
			Delay.Milliseconds(200);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WindowsApp電卓.Num6Button' at 24;27.", repo.WindowsApp電卓.Num6ButtonInfo, new RecordItemIndex(7));
			repo.WindowsApp電卓.Num6Button.Click("24;27");
			Delay.Milliseconds(200);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WindowsApp電卓.SomeText2' at 1;4.", repo.WindowsApp電卓.SomeText2Info, new RecordItemIndex(8));
			repo.WindowsApp電卓.SomeText2.Click("1;4");
			Delay.Milliseconds(200);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WindowsApp電卓.Close' at 30;13.", repo.WindowsApp電卓.CloseInfo, new RecordItemIndex(9));
			repo.WindowsApp電卓.Close.Click("30;13");
			Delay.Milliseconds(200);
			
		}

#region Image Feature Data
#endregion
	}
#pragma warning restore 0436
}
