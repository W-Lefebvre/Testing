using System;
using AltTester.AltTesterUnitySDK.Driver;
using NUnit.Framework;
using System.Threading;

public partial class ThumbCircumferenceResetCorrectly
{
    private AltDriver altDriver;
    //private ExportCleanupHelpersA1L helpers; // Utiliser une instance des helpers pour accéder aux méthodes.

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        altDriver = new AltDriver(host: ConnexionConfig.Host, port: ConnexionConfig.Port, appName: ConnexionConfig.AppName);
        //helpers = new ExportCleanupHelpersA1L(altDriver); // Initialisation avec le driver.
    }

    [OneTimeTearDown]
    public void TearDown()
    {
        altDriver.Stop();
    }

    [Test]
    public void CheckThumbCircumference()
    {
        CheckThumbCircumferenceReset();
    }
    #region Buttons, Screen coordinates & Actions
        public void ClickThumbTipLandmark() => Click(1086.943f, 1006.101f);
        public void ClickDistalEndIndexLandmark() => Click(1256.379f, 815.9496f);
        public void ClickDistalMiddleFingerLandmark() => Click(1262.09f, 781.3765f);
        public void ClickDistalRingFingerLandmark() => Click(1241.149f, 771.7729f);
        public void ClickDistalLittleFingerLandmark() => Click(1204.977f, 760.2485f);
        public void ClickThumbMetacarpalLandmark() => Click(1048.868f, 869.7299f);
        public void ClickIndexMetacarpalLandmark() => Click(965.1017f, 848.6019f);
        public void ClickMiddleMetacarpalLandmark() => Click(965.1017f, 821.7117f);
        public void ClickRingMetacarpalLandmark() => Click(972.7168f, 790.9802f);
        public void ClickLittleMetacarpalLandmark() => Click(982.2356f, 773.6936f);
        public void ClickCreaseCenterMetacarpalLandmark() => Click(1216.4f, 796.7423f);
        public void ClickMedialBorderMetacarpalLandmark() => Click(1123.115f, 829.3947f);
        public void ClickWristCreaseCenterLandmark() => Click(1086.943f, 764.09f);

        public void Click(float x, float y)
        {
            altDriver.BeginTouch(new AltVector2(x, y));
            altDriver.EndTouch(1);
        }

        public void Move(float startX, float startY, float endX, float endY)
        {
            altDriver.BeginTouch(new AltVector2(startX, startY));
            altDriver.MoveTouch(1, new AltVector2(endX, endY));
            altDriver.EndTouch(1);
        }

        public void BeingProcessed()
        {

            altDriver.WaitForObjectNotBePresent(By.PATH, "/Canvas/Loading Panel"); // Wait until the loading panel object "Your request is being processed, please wait" disappears
        }

        public void PerformRepeatedClicks(Action clickAction, int repetitions)
        {
            for (int i = 0; i < repetitions; i++)
            {
                clickAction();
            }
        }


      public void ClickFitBtnMainViewObject()
        {
            var ClickFitBtnMainViewObject = altDriver.WaitForObject(By.PATH, "/Canvas/MainMenu(Clone)/MainMenuBtn(Clone)");
            ClickFitBtnMainViewObject.Tap();
        }

        public void ClickQuitBtnFitObject()
        {
            var ClickQuitBtnFitObject = altDriver.WaitForObject(By.PATH, "/Fit/LMRunPlacementStep(Clone)/LMRunPlacementStepPanel/Canvas/SubStepPrevButton/Forma Button v3 Tools/Icon");
            ClickQuitBtnFitObject.Tap();
        }

        public void ClickCancelBtnPopUpFitObject()
        {
            var ClickCancelBtnPopUpFitObject = altDriver.WaitForObject(By.PATH, "/Canvas/WarnPopup(Clone)/Forma Info Panel v3/Content/Bottom Container/Back btn");
            ClickCancelBtnPopUpFitObject.Tap();
        }

        public void ClickConfirmBtnPopUpObject()
        {
            var ClickConfirmBtnPopUpObject = altDriver.WaitForObject(By.PATH, "/Canvas/WarnPopup(Clone)/Forma Info Panel v3/Content/Bottom Container/Do it btn");
            ClickConfirmBtnPopUpObject.Tap();
        }

        public void ClickTickBtnFitObject()
        {
            var ClickTickBtnFitObject = altDriver.WaitForObject(By.PATH, "/Fit/LMRunPlacementStep(Clone)/LMRunPlacementStepPanel/Canvas/SubStepNextButton/Forma Button v3 Tools");
            ClickTickBtnFitObject.Tap();
        }

        public void ClickBackArrowBtnFitObject()
        {
            var ClickBackArrowBtnFitObject = altDriver.WaitForObject(By.PATH, "/Fit/LMRunPlacementStep(Clone)/LMRunPlacementStepPanel/Canvas/SubStepPrevButton/Forma Button v3 Tools/Icon");
            ClickBackArrowBtnFitObject.Tap();
        }

        public void ClickPreviousStepBtnFitObject()
        {
            var ClickPreviousStepBtnFitObject = altDriver.WaitForObject(By.PATH, "/Fit/LevelNavigationPanel(Clone)/Canvas/NavPrev Step/Forma Button v3 Contextual");
            ClickPreviousStepBtnFitObject.Tap();
        }

        public void ClickResetPopUpBtnFitObject()
        {
            var ClickResetPopUpBtnFitObject = altDriver.WaitForObject(By.PATH, "/Canvas/Popup(Clone)/Content/Bottom Container/Cancel button");
            ClickResetPopUpBtnFitObject.Tap();
        }

        public void ClickLenghtBtnFitObject()
        {
            var ClickLenghtBtnFitObject = altDriver.WaitForObject(By.PATH, "/Fit/FitEditorStep(Clone)/FitEditorPanel/Canvas/NonGenerativePatternPan/LevelBottomMenu/Lines/Line2/ShiftLengthSlider/ButtonAndSlidingPanel/Button");
            ClickLenghtBtnFitObject.Tap();
        }

        public void MoveSliderLengthFitObject()
        {
            var MoveSliderLengthFitObject = altDriver.WaitForObject(By.PATH, "/Fit/FitEditorStep(Clone)/FitEditorPanel/Canvas/NonGenerativePatternPan/LevelBottomMenu/Lines/Line2/ShiftLengthSlider/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            MoveSliderLengthFitObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(603.3847f, 429.8839f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(599.5771f, 257.0187f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void MoveSliderLengthTo100FitObject()
        {
            var MoveSliderLengthFitObject = altDriver.WaitForObject(By.PATH, "/Fit/FitEditorStep(Clone)/FitEditorPanel/Canvas/NonGenerativePatternPan/LevelBottomMenu/Lines/Line2/ShiftLengthSlider/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderLengthFitObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(609.096f, 268.5431f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(607.1922f, 437.5668f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void ClickBoundaryWidthBtnFitObject()
        {
            var ClickBoundaryWidthBtnFitObject = altDriver.WaitForObject(By.PATH, "/Fit/FitEditorStep(Clone)/FitEditorPanel/Canvas/NonGenerativePatternPan/LevelBottomMenu/Lines/Line2/BoundaryWidthSlider/ButtonAndSlidingPanel/Button");
            ClickBoundaryWidthBtnFitObject.Tap();
        }

        public void MoveSliderBoundaryWidthFitObject()
        {
            var MoveSliderLengthFitObject = altDriver.WaitForObject(By.PATH, "/Fit/FitEditorStep(Clone)/FitEditorPanel/Canvas/NonGenerativePatternPan/LevelBottomMenu/Lines/Line2/BoundaryWidthSlider/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderLengthFitObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(890.047f, 299.2747f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(890.8545f, 424.1218f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0);            
        }

        public void ClickPatternRegionSelectorFitObject()
        {
            var ClickPatternRegionSelectorFitObject = altDriver.WaitForObject(By.PATH, "/Fit/FitEditorStep(Clone)/TemplateItems/PatternRegionSelector");
            ClickPatternRegionSelectorFitObject.Tap();
        }

        public void MoveSliderWidthFitObject()
        {
            var MoveSliderWidthFitObject = altDriver.WaitForObject(By.PATH, "/Fit/FitEditorStep(Clone)/FitEditorPanel/Canvas/GenerativePatternPan/Sliders/Width Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderWidthFitObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(569.1168f, 86.07423f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(759.4941f, 95.67785f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0);  
        }

        public void MoveSliderDensityFitObject()
        {
            var MoveSliderDensityFitObject = altDriver.WaitForObject(By.PATH, "/Fit/FitEditorStep(Clone)/FitEditorPanel/Canvas/GenerativePatternPan/Sliders/Density Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderDensityFitObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(1098.366f, 84.1535f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(959.3904f, 78.39133f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0);  
        }

        public void ClickPatternPannelCloseBtnFitObject()
        {
            var ClickPatternPannelCloseBtnFitObject = altDriver.WaitForObject(By.PATH, "/Fit/FitEditorStep(Clone)/FitEditorPanel/Canvas/GenerativePatternPan/Close Btn");
            ClickPatternPannelCloseBtnFitObject.Tap();
        }

        public void ClickPatternsOnOffSwitchBtnFitObject()
        {
            var ClickPatternsOnOffSwitchBtnFitObject = altDriver.WaitForObject(By.PATH, "/Fit/FitEditorStep(Clone)/FitEditorPanel/Canvas/NonGenerativePatternPan/LevelBottomMenu/Lines/Line2/PatternOnOffSwitch/Background/Switch button");
            ClickPatternsOnOffSwitchBtnFitObject.Tap();
        }

        public void ClickGlobalThicknessBtnFitObject()
        {
            var ClickGlobalThicknessBtnFitObject = altDriver.WaitForObject(By.PATH, "/Fit/FitThicknessStep(Clone)/FitThicknessPanel/Canvas/Grid/GlobalThicknessSlider/ButtonAndSlidingPanel/Button/Icon");
            ClickGlobalThicknessBtnFitObject.Tap();
        }

        public void MoveSliderGlobalThicknessFitObject()
        {
            var MoveSliderGlobalThicknessFitObject = altDriver.WaitForObject(By.PATH, "/Fit/FitThicknessStep(Clone)/FitThicknessPanel/Canvas/Grid/GlobalThicknessSlider/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderGlobalThicknessFitObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(473.9281f, 189.7934f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(470.1205f, 341.5306f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0);  
        }

        public void ClickGlobalOffsetBtnFitObject()
        {
            var ClickGlobalOffsetBtnFitObject = altDriver.WaitForObject(By.PATH, "/Fit/FitThicknessStep(Clone)/FitThicknessPanel/Canvas/Grid/OffsetSlider/ButtonAndSlidingPanel/Button/Icon");
            ClickGlobalOffsetBtnFitObject.Tap();
        }

        public void MoveSliderGlobalOffsetFitObject()
        {
            var MoveSliderGlobalOffsetFitObject = altDriver.WaitForObject(By.PATH, "/Fit/FitThicknessStep(Clone)/FitThicknessPanel/Canvas/Grid/OffsetSlider/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderGlobalOffsetFitObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(730.9375f, 218.6042f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(736.6489f, 368.4207f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0);  
        }

        public void ClickBoundaryThicknessBtnFitObject()
        {
            var ClickBoundaryThicknessBtnFitObject = altDriver.WaitForObject(By.PATH, "/Fit/FitThicknessStep(Clone)/FitThicknessPanel/Canvas/Grid/Boundary/BoundaryThicknessSlider/ButtonAndSlidingPanel/Button/Icon");
            ClickBoundaryThicknessBtnFitObject.Tap();
        }

        public void MoveSliderBoundaryThicknessFitObject()
        {
            var MoveSliderBoundaryThicknessFitObject = altDriver.WaitForObject(By.PATH, "/Fit/FitThicknessStep(Clone)/FitThicknessPanel/Canvas/Grid/Boundary/BoundaryThicknessSlider/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderBoundaryThicknessFitObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(997.4658f, 164.8239f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(993.6583f, 360.7379f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0);  
        }

        public void ClickBoundaryFlareBtnFitObject()
        {
            var ClickBoundaryFlareBtnFitObject = altDriver.WaitForObject(By.PATH, "/Fit/FitThicknessStep(Clone)/FitThicknessPanel/Canvas/Grid/Boundary/FlareSlider/ButtonAndSlidingPanel/Button/Icon");
            ClickBoundaryFlareBtnFitObject.Tap();
        }

        public void MoveSliderBoundaryFlareFitObject()
        {
            var MoveSliderBoundaryFlareFitObject = altDriver.WaitForObject(By.PATH, "/Fit/FitThicknessStep(Clone)/FitThicknessPanel/Canvas/Grid/Boundary/FlareSlider/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderBoundaryFlareFitObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(1269.705f, 162.9032f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1263.994f, 358.8171f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0);  
        }

        public void ClickNextStepBtnFitObject()
        {
            var ClickNextStepBtnFitObject = altDriver.WaitForObject(By.PATH, "/Fit/LevelNavigationPanel(Clone)/Canvas/NavNext Step/Forma Button v3 Contextual");
            ClickNextStepBtnFitObject.Tap();
        }

        public void ClickOkInformationPopUpBtnFitObject()
        {
            var ClickOkInformationPopUpBtnFitObject = altDriver.WaitForObject(By.PATH, "/Canvas/ValidationCheckPopup(Clone)/Content/Bottom Container/Confirm button");
            ClickOkInformationPopUpBtnFitObject.Tap();
        }

        public void ClickValidateBtnFitObject()
        {
            var ClickValidateBtnFitObject = altDriver.WaitForObject(By.PATH, "/Fit/LevelNavigationPanel(Clone)/Canvas/NavNext Step/Forma Button v3 Contextual");
            ClickValidateBtnFitObject.Tap();
        }
#endregion

    private void CheckThumbCircumferenceReset()
    {
         altDriver.SetDelayAfterCommand(0.15f);
         ClickFitBtnMainViewObject();
         SetFitLandmarks();
         ClickTickBtnFitObject();
         BeingProcessed();
         CheckThumbCircumferenceValueStep2();
         ClickNextStepBtnFitObject();
         CheckThumbCircumferenceValueStep3();
         ClickPreviousStepBtnFitObject();
         CheckThumbCircumferenceValueStep2();
    }

    private void SetFitLandmarks()
    {
        altDriver.SetDelayAfterCommand(0.12f);
       //  ClickThumbTipLandmark();
         ClickTickBtnFitObject();
         ClickDistalEndIndexLandmark();
         ClickTickBtnFitObject();   
         ClickDistalMiddleFingerLandmark();
         ClickTickBtnFitObject();
         ClickDistalRingFingerLandmark();
         ClickTickBtnFitObject();
         ClickDistalLittleFingerLandmark();
         ClickTickBtnFitObject();
         ClickThumbMetacarpalLandmark();
         ClickTickBtnFitObject();
         ClickIndexMetacarpalLandmark();
         ClickTickBtnFitObject();
         ClickMiddleMetacarpalLandmark();
         ClickTickBtnFitObject();
         ClickRingMetacarpalLandmark();
         ClickTickBtnFitObject();
         ClickLittleMetacarpalLandmark();
         ClickTickBtnFitObject();
         ClickCreaseCenterMetacarpalLandmark();
         ClickTickBtnFitObject();
         ClickMedialBorderMetacarpalLandmark();
         ClickTickBtnFitObject();
         ClickWristCreaseCenterLandmark();
    }

        private void CheckThumbCircumferenceValueStep2()
    {
        var validationMessageObject = altDriver.WaitForObject(By.PATH, "/Fit/ThumbInterphalangealJointVisualizer(Clone)/Canvas/Text");
        Assert.IsTrue(validationMessageObject.enabled, "The object is not visible or enabled.");
        string actualText = validationMessageObject.GetText();
        string expectedText = "IP : 72 mm";
        Assert.AreEqual(expectedText, actualText, $"The validation message is incorrect. Expected: {expectedText}, but got: {actualText}");
    }

        private void CheckThumbCircumferenceValueStep3()
    {
        var validationMessageObject = altDriver.WaitForObject(By.PATH, "/Fit/ThumbInterphalangealJointVisualizer(Clone)/Canvas/Text");
        Assert.IsTrue(validationMessageObject.enabled, "The object is not visible or enabled.");
        string actualText = validationMessageObject.GetText();
        string expectedText = "IP : 73 mm";
        Assert.AreEqual(expectedText, actualText, $"The validation message is incorrect. Expected: {expectedText}, but got: {actualText}");
    }


}