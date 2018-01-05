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

namespace N7UK
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Parent recording.
    /// </summary>
    [TestModule("7d8a4172-a67e-4201-99a5-a9ec59edf351", ModuleType.Recording, 1)]
    public partial class Parent : ITestModule
    {
        /// <summary>
        /// Holds an instance of the N7UKRepository repository.
        /// </summary>
        public static N7UKRepository repo = N7UKRepository.Instance;

        static Parent instance = new Parent();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Parent()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Parent Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.0")]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.0")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            //Report.Log(ReportLevel.Info, "Website", "Opening web site 'http://www.hearyourway.com/wps/wcm/connect/uk/n7/home' with browser 'chrome' in normal mode.", new RecordItemIndex(0));
            //Host.Current.OpenBrowser("http://www.hearyourway.com/wps/wcm/connect/uk/n7/home", "chrome", "", false, false, false, false, false);
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'CochlearImplantSoundProcessorNucleus.UtilityNav.Parent'.", repo.CochlearImplantSoundProcessorNucleus.UtilityNav.ParentInfo, new RecordItemIndex(1));
            Validate.Exists(repo.CochlearImplantSoundProcessorNucleus.UtilityNav.ParentInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CochlearImplantSoundProcessorNucleus.UtilityNav.Parent' at 31;7.", repo.CochlearImplantSoundProcessorNucleus.UtilityNav.ParentInfo, new RecordItemIndex(2));
            repo.CochlearImplantSoundProcessorNucleus.UtilityNav.Parent.Click("31;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'CochlearImplantSoundProcessorNucleus.UtilityNav.Parent'.", repo.CochlearImplantSoundProcessorNucleus.UtilityNav.ParentInfo, new RecordItemIndex(3));
            Validate.Exists(repo.CochlearImplantSoundProcessorNucleus.UtilityNav.ParentInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'CochlearImplantSoundProcessorNucleus' at 1910;63.", repo.CochlearImplantSoundProcessorNucleus.SelfInfo, new RecordItemIndex(4));
            repo.CochlearImplantSoundProcessorNucleus.Self.MoveTo("1910;63");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'CochlearImplantSoundProcessorNucleus' at 1908;382.", repo.CochlearImplantSoundProcessorNucleus.SelfInfo, new RecordItemIndex(5));
            repo.CochlearImplantSoundProcessorNucleus.Self.MoveTo("1908;382");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'CochlearImplantSoundProcessorNucleus.FluidContainer.ProvenToOptimiseYourChildsHearingP'.", repo.CochlearImplantSoundProcessorNucleus.FluidContainer.ProvenToOptimiseYourChildsHearingPInfo, new RecordItemIndex(6));
            Validate.Exists(repo.CochlearImplantSoundProcessorNucleus.FluidContainer.ProvenToOptimiseYourChildsHearingPInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CochlearImplantSoundProcessorNucleus1' at 33;71.", repo.CochlearImplantSoundProcessorNucleus1.SelfInfo, new RecordItemIndex(7));
            repo.CochlearImplantSoundProcessorNucleus1.Self.Click("33;71");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'CochlearImplantSoundProcessorNucleus.UtilityNav.Parent'.", repo.CochlearImplantSoundProcessorNucleus.UtilityNav.ParentInfo, new RecordItemIndex(8));
            Validate.Exists(repo.CochlearImplantSoundProcessorNucleus.UtilityNav.ParentInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'CochlearImplantSoundProcessorNucleus' at 1909;322.", repo.CochlearImplantSoundProcessorNucleus.SelfInfo, new RecordItemIndex(9));
            repo.CochlearImplantSoundProcessorNucleus.Self.MoveTo("1909;322");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'CochlearImplantSoundProcessorNucleus' at 1911;628.", repo.CochlearImplantSoundProcessorNucleus.SelfInfo, new RecordItemIndex(10));
            repo.CochlearImplantSoundProcessorNucleus.Self.MoveTo("1911;628");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'CochlearImplantSoundProcessorNucleus.FluidContainer.SpanTagParent'.", repo.CochlearImplantSoundProcessorNucleus.FluidContainer.SpanTagParentInfo, new RecordItemIndex(11));
            Validate.Exists(repo.CochlearImplantSoundProcessorNucleus.FluidContainer.SpanTagParentInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CochlearImplantSoundProcessorNucleus.FluidContainer.SpanTagParent' at 81;20.", repo.CochlearImplantSoundProcessorNucleus.FluidContainer.SpanTagParentInfo, new RecordItemIndex(12));
            repo.CochlearImplantSoundProcessorNucleus.FluidContainer.SpanTagParent.Click("81;20");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'CochlearImplantSoundProcessorNucleus.UtilityNav.Parent'.", repo.CochlearImplantSoundProcessorNucleus.UtilityNav.ParentInfo, new RecordItemIndex(13));
            Validate.Exists(repo.CochlearImplantSoundProcessorNucleus.UtilityNav.ParentInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'CochlearImplantSoundProcessorNucleus' at 1909;105.", repo.CochlearImplantSoundProcessorNucleus.SelfInfo, new RecordItemIndex(14));
            repo.CochlearImplantSoundProcessorNucleus.Self.MoveTo("1909;105");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'CochlearImplantSoundProcessorNucleus' at 1914;441.", repo.CochlearImplantSoundProcessorNucleus.SelfInfo, new RecordItemIndex(15));
            repo.CochlearImplantSoundProcessorNucleus.Self.MoveTo("1914;441");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'CochlearImplantSoundProcessorNucleus.FluidContainer.ProvenToOptimiseYourChildsHearingP'.", repo.CochlearImplantSoundProcessorNucleus.FluidContainer.ProvenToOptimiseYourChildsHearingPInfo, new RecordItemIndex(16));
            Validate.Exists(repo.CochlearImplantSoundProcessorNucleus.FluidContainer.ProvenToOptimiseYourChildsHearingPInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CochlearImplantSoundProcessorNucleus1' at 31;69.", repo.CochlearImplantSoundProcessorNucleus1.SelfInfo, new RecordItemIndex(17));
            repo.CochlearImplantSoundProcessorNucleus1.Self.Click("31;69");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'CochlearImplantSoundProcessorNucleus.UtilityNav.Parent'.", repo.CochlearImplantSoundProcessorNucleus.UtilityNav.ParentInfo, new RecordItemIndex(18));
            Validate.Exists(repo.CochlearImplantSoundProcessorNucleus.UtilityNav.ParentInfo);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
