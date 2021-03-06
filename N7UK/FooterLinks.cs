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
    ///The FooterLinks recording.
    /// </summary>
    [TestModule("9d88c4ec-e3c0-4e42-aec7-864dde07018c", ModuleType.Recording, 1)]
    public partial class FooterLinks : ITestModule
    {
        /// <summary>
        /// Holds an instance of the N7UKRepository repository.
        /// </summary>
        public static N7UKRepository repo = N7UKRepository.Instance;

        static FooterLinks instance = new FooterLinks();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public FooterLinks()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static FooterLinks Instance
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
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'CochlearImplantSoundProcessorNucleus.UtilityNav.Adult'.", repo.CochlearImplantSoundProcessorNucleus.UtilityNav.AdultInfo, new RecordItemIndex(1));
            Validate.Exists(repo.CochlearImplantSoundProcessorNucleus.UtilityNav.AdultInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'CochlearImplantSoundProcessorNucleus' at 1904;243.", repo.CochlearImplantSoundProcessorNucleus.SelfInfo, new RecordItemIndex(2));
            repo.CochlearImplantSoundProcessorNucleus.Self.MoveTo("1904;243");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'CochlearImplantSoundProcessorNucleus' at 1914;637.", repo.CochlearImplantSoundProcessorNucleus.SelfInfo, new RecordItemIndex(3));
            repo.CochlearImplantSoundProcessorNucleus.Self.MoveTo("1914;637");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'CochlearImplantSoundProcessorNucleus.ListInlineListUnstyledFooterLinks.CookiePolicy'.", repo.CochlearImplantSoundProcessorNucleus.ListInlineListUnstyledFooterLinks.CookiePolicyInfo, new RecordItemIndex(4));
            Validate.Exists(repo.CochlearImplantSoundProcessorNucleus.ListInlineListUnstyledFooterLinks.CookiePolicyInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CochlearImplantSoundProcessorNucleus.ListInlineListUnstyledFooterLinks.CookiePolicy' at 81;14.", repo.CochlearImplantSoundProcessorNucleus.ListInlineListUnstyledFooterLinks.CookiePolicyInfo, new RecordItemIndex(5));
            repo.CochlearImplantSoundProcessorNucleus.ListInlineListUnstyledFooterLinks.CookiePolicy.Click("81;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'CochlearHearingImplantsCochlearUni.COCHLEARGLOBALPRIVACYPOLICY'.", repo.CochlearHearingImplantsCochlearUni.COCHLEARGLOBALPRIVACYPOLICYInfo, new RecordItemIndex(6));
            Validate.Exists(repo.CochlearHearingImplantsCochlearUni.COCHLEARGLOBALPRIVACYPOLICYInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GlobalPrivacyPolicyGoogleChrome' at 488;29.", repo.GlobalPrivacyPolicyGoogleChrome.SelfInfo, new RecordItemIndex(7));
            repo.GlobalPrivacyPolicyGoogleChrome.Self.Click("488;29");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'CochlearImplantSoundProcessorNucleus.ListInlineListUnstyledFooterLinks.SomeLiTag'.", repo.CochlearImplantSoundProcessorNucleus.ListInlineListUnstyledFooterLinks.SomeLiTagInfo, new RecordItemIndex(8));
            Validate.Exists(repo.CochlearImplantSoundProcessorNucleus.ListInlineListUnstyledFooterLinks.SomeLiTagInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CochlearImplantSoundProcessorNucleus.ListInlineListUnstyledFooterLinks.PrivacyPolicy' at 65;11.", repo.CochlearImplantSoundProcessorNucleus.ListInlineListUnstyledFooterLinks.PrivacyPolicyInfo, new RecordItemIndex(9));
            repo.CochlearImplantSoundProcessorNucleus.ListInlineListUnstyledFooterLinks.PrivacyPolicy.Click("65;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'CochlearHearingImplantsCochlearUni.COCHLEARGLOBALPRIVACYPOLICY'.", repo.CochlearHearingImplantsCochlearUni.COCHLEARGLOBALPRIVACYPOLICYInfo, new RecordItemIndex(10));
            Validate.Exists(repo.CochlearHearingImplantsCochlearUni.COCHLEARGLOBALPRIVACYPOLICYInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GlobalPrivacyPolicyGoogleChrome' at 488;30.", repo.GlobalPrivacyPolicyGoogleChrome.SelfInfo, new RecordItemIndex(11));
            repo.GlobalPrivacyPolicyGoogleChrome.Self.Click("488;30");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'CochlearImplantSoundProcessorNucleus.ListInlineListUnstyledFooterLinks.TermsOfUse'.", repo.CochlearImplantSoundProcessorNucleus.ListInlineListUnstyledFooterLinks.TermsOfUseInfo, new RecordItemIndex(12));
            Validate.Exists(repo.CochlearImplantSoundProcessorNucleus.ListInlineListUnstyledFooterLinks.TermsOfUseInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CochlearImplantSoundProcessorNucleus.ListInlineListUnstyledFooterLinks.TermsOfUse' at 56;12.", repo.CochlearImplantSoundProcessorNucleus.ListInlineListUnstyledFooterLinks.TermsOfUseInfo, new RecordItemIndex(13));
            repo.CochlearImplantSoundProcessorNucleus.ListInlineListUnstyledFooterLinks.TermsOfUse.Click("56;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'CochlearHearingImplantsCochlearUni.TermsOfUse'.", repo.CochlearHearingImplantsCochlearUni.TermsOfUseInfo, new RecordItemIndex(14));
            Validate.Exists(repo.CochlearHearingImplantsCochlearUni.TermsOfUseInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GlobalPrivacyPolicyGoogleChrome' at 489;32.", repo.GlobalPrivacyPolicyGoogleChrome.SelfInfo, new RecordItemIndex(15));
            repo.GlobalPrivacyPolicyGoogleChrome.Self.Click("489;32");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'CochlearImplantSoundProcessorNucleus.ListInlineListUnstyledFooterLinks.ATagBlank'.", repo.CochlearImplantSoundProcessorNucleus.ListInlineListUnstyledFooterLinks.ATagBlankInfo, new RecordItemIndex(16));
            Validate.Exists(repo.CochlearImplantSoundProcessorNucleus.ListInlineListUnstyledFooterLinks.ATagBlankInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CochlearImplantSoundProcessorNucleus.ListInlineListUnstyledFooterLinks.ATagBlank' at 56;13.", repo.CochlearImplantSoundProcessorNucleus.ListInlineListUnstyledFooterLinks.ATagBlankInfo, new RecordItemIndex(17));
            repo.CochlearImplantSoundProcessorNucleus.ListInlineListUnstyledFooterLinks.ATagBlank.Click("56;13");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'CochlearHearingImplantsCochlearUni.ATagLearnAboutHearingLoss'.", repo.CochlearHearingImplantsCochlearUni.ATagLearnAboutHearingLossInfo, new RecordItemIndex(18));
            Validate.Exists(repo.CochlearHearingImplantsCochlearUni.ATagLearnAboutHearingLossInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GlobalPrivacyPolicyGoogleChrome' at 33;64.", repo.GlobalPrivacyPolicyGoogleChrome.SelfInfo, new RecordItemIndex(19));
            repo.GlobalPrivacyPolicyGoogleChrome.Self.Click("33;64");
            Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'CochlearImplantSoundProcessorNucleus.PTagC2017CochlearLtdAllRightsRese'.", repo.CochlearImplantSoundProcessorNucleus.PTagC2017CochlearLtdAllRightsReseInfo, new RecordItemIndex(20));
            //Validate.Exists(repo.CochlearImplantSoundProcessorNucleus.PTagC2017CochlearLtdAllRightsReseInfo);
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'CochlearImplantSoundProcessorNucleus.PTagC2018CochlearLtdAllRightsRese'.", repo.CochlearImplantSoundProcessorNucleus.PTagC2018CochlearLtdAllRightsReseInfo, new RecordItemIndex(21));
            Validate.Exists(repo.CochlearImplantSoundProcessorNucleus.PTagC2018CochlearLtdAllRightsReseInfo);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
