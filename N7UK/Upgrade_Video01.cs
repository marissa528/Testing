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
    ///The Upgrade_Video01 recording.
    /// </summary>
    [TestModule("0757f658-4795-4709-8b96-f986eec18fe2", ModuleType.Recording, 1)]
    public partial class Upgrade_Video01 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the N7UKRepository repository.
        /// </summary>
        public static N7UKRepository repo = N7UKRepository.Instance;

        static Upgrade_Video01 instance = new Upgrade_Video01();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Upgrade_Video01()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Upgrade_Video01 Instance
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
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'CochlearImplantSoundProcessorNucleus.UtilityNav.Upgrade'.", repo.CochlearImplantSoundProcessorNucleus.UtilityNav.UpgradeInfo, new RecordItemIndex(1));
            Validate.Exists(repo.CochlearImplantSoundProcessorNucleus.UtilityNav.UpgradeInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CochlearImplantSoundProcessorNucleus.UtilityNav.Upgrade' at 44;15.", repo.CochlearImplantSoundProcessorNucleus.UtilityNav.UpgradeInfo, new RecordItemIndex(2));
            repo.CochlearImplantSoundProcessorNucleus.UtilityNav.Upgrade.Click("44;15");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'CochlearImplantSoundProcessorNucleus.UtilityNav.Upgrade'.", repo.CochlearImplantSoundProcessorNucleus.UtilityNav.UpgradeInfo, new RecordItemIndex(3));
            Validate.Exists(repo.CochlearImplantSoundProcessorNucleus.UtilityNav.UpgradeInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CochlearImplantSoundProcessorNucleus.FluidContainer.FaFaAngleDownButton' at 27;32.", repo.CochlearImplantSoundProcessorNucleus.FluidContainer.FaFaAngleDownButtonInfo, new RecordItemIndex(4));
            repo.CochlearImplantSoundProcessorNucleus.FluidContainer.FaFaAngleDownButton.Click("27;32");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CochlearImplantSoundProcessorNucleus.FluidContainer.BtnPlay' at 65;97.", repo.CochlearImplantSoundProcessorNucleus.FluidContainer.BtnPlayInfo, new RecordItemIndex(5));
            repo.CochlearImplantSoundProcessorNucleus.FluidContainer.BtnPlay.Click("65;97");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'CochlearImplantSoundProcessorNucleus'.", repo.CochlearImplantSoundProcessorNucleus.SelfInfo, new RecordItemIndex(6));
            Validate.Exists(repo.CochlearImplantSoundProcessorNucleus.SelfInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CochlearImplantSoundProcessorNucleus' at 44;862.", repo.CochlearImplantSoundProcessorNucleus.SelfInfo, new RecordItemIndex(7));
            repo.CochlearImplantSoundProcessorNucleus.Self.Click("44;862");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'UpgradeToCochlearImplantSoundProces' at 30;69.", repo.UpgradeToCochlearImplantSoundProces.SelfInfo, new RecordItemIndex(8));
            repo.UpgradeToCochlearImplantSoundProces.Self.Click("30;69");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'CochlearImplantSoundProcessorNucleus.UtilityNav.Upgrade'.", repo.CochlearImplantSoundProcessorNucleus.UtilityNav.UpgradeInfo, new RecordItemIndex(9));
            Validate.Exists(repo.CochlearImplantSoundProcessorNucleus.UtilityNav.UpgradeInfo);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
