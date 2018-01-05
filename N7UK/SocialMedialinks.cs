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
    ///The SocialMedialinks recording.
    /// </summary>
    [TestModule("2583678d-6a95-4826-b44b-c66f2e803663", ModuleType.Recording, 1)]
    public partial class SocialMedialinks : ITestModule
    {
        /// <summary>
        /// Holds an instance of the N7UKRepository repository.
        /// </summary>
        public static N7UKRepository repo = N7UKRepository.Instance;

        static SocialMedialinks instance = new SocialMedialinks();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SocialMedialinks()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SocialMedialinks Instance
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

            //Report.Log(ReportLevel.Info, "Website", "Opening web site 'http://www.hearyourway.com/wps/wcm/connect/uk/n7/home' with browser 'Chrome' in normal mode.", new RecordItemIndex(0));
            //Host.Current.OpenBrowser("http://www.hearyourway.com/wps/wcm/connect/uk/n7/home", "Chrome", "", false, false, false, false, false);
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'CochlearImplantSoundProcessorNucleus.UtilityNav.Adult'.", repo.CochlearImplantSoundProcessorNucleus.UtilityNav.AdultInfo, new RecordItemIndex(1));
            Validate.Exists(repo.CochlearImplantSoundProcessorNucleus.UtilityNav.AdultInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'CochlearImplantSoundProcessorNucleus' at 1912;87.", repo.CochlearImplantSoundProcessorNucleus.SelfInfo, new RecordItemIndex(2));
            repo.CochlearImplantSoundProcessorNucleus.Self.MoveTo("1912;87");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'CochlearImplantSoundProcessorNucleus' at 1919;501.", repo.CochlearImplantSoundProcessorNucleus.SelfInfo, new RecordItemIndex(3));
            repo.CochlearImplantSoundProcessorNucleus.Self.MoveTo("1919;501");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'CochlearImplantSoundProcessorNucleus.ListInlineListUnstyledSocialLinks.FaFaFacebookFaSocialCircular'.", repo.CochlearImplantSoundProcessorNucleus.ListInlineListUnstyledSocialLinks.FaFaFacebookFaSocialCircularInfo, new RecordItemIndex(4));
            Validate.Exists(repo.CochlearImplantSoundProcessorNucleus.ListInlineListUnstyledSocialLinks.FaFaFacebookFaSocialCircularInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CochlearImplantSoundProcessorNucleus.ListInlineListUnstyledSocialLinks.FaFaFacebookFaSocialCircular' at 33;25.", repo.CochlearImplantSoundProcessorNucleus.ListInlineListUnstyledSocialLinks.FaFaFacebookFaSocialCircularInfo, new RecordItemIndex(5));
            repo.CochlearImplantSoundProcessorNucleus.ListInlineListUnstyledSocialLinks.FaFaFacebookFaSocialCircular.Click("33;25");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'CochlearUKIEHalamanUtamaFacebo.FbLogoImgSpLda9yxacsCe15xSx7f214'.", repo.CochlearUKIEHalamanUtamaFacebo.FbLogoImgSpLda9yxacsCe15xSx7f214Info, new RecordItemIndex(6));
            Validate.Exists(repo.CochlearUKIEHalamanUtamaFacebo.FbLogoImgSpLda9yxacsCe15xSx7f214Info);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CochlearUKIEHalamanUtamaFacebo1' at 489;31.", repo.CochlearUKIEHalamanUtamaFacebo1.SelfInfo, new RecordItemIndex(7));
            repo.CochlearUKIEHalamanUtamaFacebo1.Self.Click("489;31");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'CochlearImplantSoundProcessorNucleus.ListInlineListUnstyledSocialLinks.FaFaTwitterFaSocialCircular'.", repo.CochlearImplantSoundProcessorNucleus.ListInlineListUnstyledSocialLinks.FaFaTwitterFaSocialCircularInfo, new RecordItemIndex(8));
            Validate.Exists(repo.CochlearImplantSoundProcessorNucleus.ListInlineListUnstyledSocialLinks.FaFaTwitterFaSocialCircularInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CochlearImplantSoundProcessorNucleus.ListInlineListUnstyledSocialLinks.FaFaTwitterFaSocialCircular' at 29;25.", repo.CochlearImplantSoundProcessorNucleus.ListInlineListUnstyledSocialLinks.FaFaTwitterFaSocialCircularInfo, new RecordItemIndex(9));
            repo.CochlearImplantSoundProcessorNucleus.ListInlineListUnstyledSocialLinks.FaFaTwitterFaSocialCircular.Click("29;25");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'CochlearUKIEAtCochlearUKTwitter.IconIconBirdIconLarge'.", repo.CochlearUKIEAtCochlearUKTwitter.IconIconBirdIconLargeInfo, new RecordItemIndex(10));
            Validate.Exists(repo.CochlearUKIEAtCochlearUKTwitter.IconIconBirdIconLargeInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CochlearUKIEHalamanUtamaFacebo1' at 485;26.", repo.CochlearUKIEHalamanUtamaFacebo1.SelfInfo, new RecordItemIndex(11));
            repo.CochlearUKIEHalamanUtamaFacebo1.Self.Click("485;26");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'CochlearImplantSoundProcessorNucleus.ListInlineListUnstyledSocialLinks.FaFaYoutubeFaSocialCircular'.", repo.CochlearImplantSoundProcessorNucleus.ListInlineListUnstyledSocialLinks.FaFaYoutubeFaSocialCircularInfo, new RecordItemIndex(12));
            Validate.Exists(repo.CochlearImplantSoundProcessorNucleus.ListInlineListUnstyledSocialLinks.FaFaYoutubeFaSocialCircularInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CochlearImplantSoundProcessorNucleus.ListInlineListUnstyledSocialLinks.FaFaYoutubeFaSocialCircular' at 25;23.", repo.CochlearImplantSoundProcessorNucleus.ListInlineListUnstyledSocialLinks.FaFaYoutubeFaSocialCircularInfo, new RecordItemIndex(13));
            repo.CochlearImplantSoundProcessorNucleus.ListInlineListUnstyledSocialLinks.FaFaYoutubeFaSocialCircular.Click("25;23");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'WebDocument2CochlearEuropeMiddleE.LogoIconContainer'.", repo.WebDocument2CochlearEuropeMiddleE.LogoIconContainerInfo, new RecordItemIndex(14));
            Validate.Exists(repo.WebDocument2CochlearEuropeMiddleE.LogoIconContainerInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CochlearEuropeMiddleEastAfricaY' at 488;30.", repo.CochlearEuropeMiddleEastAfricaY.SelfInfo, new RecordItemIndex(15));
            repo.CochlearEuropeMiddleEastAfricaY.Self.Click("488;30");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'CochlearImplantSoundProcessorNucleus.ListInlineListUnstyledSocialLinks.FaFaLinkedinFaSocialCircular'.", repo.CochlearImplantSoundProcessorNucleus.ListInlineListUnstyledSocialLinks.FaFaLinkedinFaSocialCircularInfo, new RecordItemIndex(16));
            Validate.Exists(repo.CochlearImplantSoundProcessorNucleus.ListInlineListUnstyledSocialLinks.FaFaLinkedinFaSocialCircularInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CochlearImplantSoundProcessorNucleus.ListInlineListUnstyledSocialLinks.FaFaLinkedinFaSocialCircular' at 26;20.", repo.CochlearImplantSoundProcessorNucleus.ListInlineListUnstyledSocialLinks.FaFaLinkedinFaSocialCircularInfo, new RecordItemIndex(17));
            repo.CochlearImplantSoundProcessorNucleus.ListInlineListUnstyledSocialLinks.FaFaLinkedinFaSocialCircular.Click("26;20");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='') on item 'WebDocument1CochlearOverviewLink.LinkedIn1'.", repo.WebDocument1CochlearOverviewLink.LinkedIn1Info, new RecordItemIndex(18));
            Validate.AttributeEqual(repo.WebDocument1CochlearOverviewLink.LinkedIn1Info, "InnerText", "");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CochlearLinkedInGoogleChrome' at 486;28.", repo.CochlearLinkedInGoogleChrome.SelfInfo, new RecordItemIndex(19));
            repo.CochlearLinkedInGoogleChrome.Self.Click("486;28");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'CochlearImplantSoundProcessorNucleus.UtilityNav.Adult'.", repo.CochlearImplantSoundProcessorNucleus.UtilityNav.AdultInfo, new RecordItemIndex(20));
            Validate.Exists(repo.CochlearImplantSoundProcessorNucleus.UtilityNav.AdultInfo);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
