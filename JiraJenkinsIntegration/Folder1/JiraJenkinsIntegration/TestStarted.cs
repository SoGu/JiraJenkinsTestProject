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

namespace JiraJenkinsIntegration
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The TestStarted recording.
    /// </summary>
    [TestModule("4076e89c-1316-4488-be4a-448986c23303", ModuleType.Recording, 1)]
    public partial class TestStarted : ITestModule
    {
        /// <summary>
        /// Holds an instance of the JiraJenkinsIntegrationRepository repository.
        /// </summary>
        public static JiraJenkinsIntegrationRepository repo = JiraJenkinsIntegrationRepository.Instance;

        static TestStarted instance = new TestStarted();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public TestStarted()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static TestStarted Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.1")]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.1")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "User", "Test started", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Application", "Run application 'app\\RxTestApplication.exe' with arguments '' in normal mode.", new RecordItemIndex(1));
            Host.Local.RunApplication("app\\RxTestApplication.exe", "", "", false);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.StandardControls' at 46;9.", repo.RxMainFrame.StandardControlsInfo, new RecordItemIndex(2));
            repo.RxMainFrame.StandardControls.Click("46;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RxTabStandard.FirstName' at 93;8.", repo.RxMainFrame.RxTabStandard.FirstNameInfo, new RecordItemIndex(3));
            repo.RxMainFrame.RxTabStandard.FirstName.Click("93;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'stefan' with focus on 'RxMainFrame.RxTabStandard.FirstName'.", repo.RxMainFrame.RxTabStandard.FirstNameInfo, new RecordItemIndex(4));
            repo.RxMainFrame.RxTabStandard.FirstName.PressKeys("stefan");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RxTabStandard.UpDownEdit' at 36;3.", repo.RxMainFrame.RxTabStandard.UpDownEditInfo, new RecordItemIndex(5));
            repo.RxMainFrame.RxTabStandard.UpDownEdit.Click("36;3");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'RxMainFrame.RxTabStandard.UpDownEdit'.", repo.RxMainFrame.RxTabStandard.UpDownEditInfo, new RecordItemIndex(6));
            Keyboard.PrepareFocus(repo.RxMainFrame.RxTabStandard.UpDownEdit);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '36' with focus on 'RxMainFrame.RxTabStandard.UpDownEdit'.", repo.RxMainFrame.RxTabStandard.UpDownEditInfo, new RecordItemIndex(7));
            repo.RxMainFrame.RxTabStandard.UpDownEdit.PressKeys("36");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RxTabStandard.BtnAddPerson' at 10;3.", repo.RxMainFrame.RxTabStandard.BtnAddPersonInfo, new RecordItemIndex(8));
            repo.RxMainFrame.RxTabStandard.BtnAddPerson.Click("10;3");
            Delay.Milliseconds(200);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.RxMainFrame.Self, false, new RecordItemIndex(9));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
