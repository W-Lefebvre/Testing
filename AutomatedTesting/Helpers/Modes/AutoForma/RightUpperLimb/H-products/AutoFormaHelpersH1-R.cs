using System;
using AltTester.AltTesterUnitySDK.Driver;
using NUnit.Framework;
using System.Threading;

public partial class FullAutoFormaH1R
{
    public class AutoFormaHelpersH1R
    {
        private AltDriver altDriver;

        public AutoFormaHelpersH1R(AltDriver driver)
        {
            altDriver = driver;
        }

        // TEXT TO CHECK FOR ASSERTIONS //
        public const string SelectPartOfScanText = "Select the part of the scan you want to use";
        public const string ModificationsWillBeLostText = "Modifications will be lost.";
        public const string AllChangesLostText = "All current changes from this point will be lost if you return to this step";
        public const string PositionLandmarkText = "Please position landmark onto the scan";
        public const string CheckConfirmScanText = "Check and confirm the scan";
        public const string OldLandmarksOrSetAgainText = "Do you want to use old landmarks or set them again?";
        public const string VentralArmText = "Ventral Arm";
        public const string WristCreaseCenterText = "Wrist Crease Center";
        public const string DistalEndIndexFingerText = "Distal end of the index finger";
        public const string DistalEndMiddleFingerText = "Distal end of the middle finger";
        public const string DistalEndRingFingerText = "Distal end of the ring finger";
        public const string DistalEndLittleFingerText = "Distal end of the little finger";
        public const string ThumbMetacarpalText = "Thumb metacarpal-phalangeal articulation";
        public const string IndexMetacarpalText = "Metacarpo-Phalangian of the index";
        public const string MiddleMetacarpalText = "Metacarpo-Phalangian of the middle finger";
        public const string RingMetacarpalText = "Metacarpo-Phalangeal of the ring finger";
        public const string LittleMetacarpalText = "Metacarpo-Phalangeal of the little finger";
        public const string MetacarpalCreaseCenterText = "MetaCarpal Crease Center";
        public const string MedialBorderMetacarpalText = "Medial border of the 5th metacarpal";
        public const string PosingModeSelectionText = "Please select posing mode";
        public const string SelectPartOfScanCropOffText = "Select the part of the scan you want to crop off";
        public const string ThumbTipText = "Thumb tip";
        public const string CheckTheLimbPoseText = "Check the limb pose and modify if needed";
        public const string HandExtFlexSliderText = "Hand extens/flex ion";
        public const string HandAdAbSliderText = "Hand ad/ab duction";
        public const string ThumbExtFlexText = "Thumb extens/flex ion";
        public const string ThumbAdAbText = "Thumb ab/ad duction";
        public const string FingerExtFlexText = "Finger extens/flex ion";
        public const string FingerSplayText = "Finger splay";
        public const string NormalAppearanceText = "Normal";
        public const string TransparentAppearanceText = "Transparent";
        public const string NeutralGhostAppearanceText = "Neutral ghost";
        public const string ThumbInterPhalangealText = "Thumb inter-phalangeal articulation";
        public const string FirstInterdigitalText = "First interdigital connection";
        public const string CheckTheThumbText = "Check the thumb and modify if needed";
        public const string ThumbEditorPanelText = "Inputting a circumference value different from real circumference at IP joint can compromise the fitting.";
        public const string SculptEditorText = "Check the scan and make local modifications if needed";
        public const string SculptValidationText = "Check and validate";
        public const string PullOptionActivated = "Pull";
        public const string PushOptionActivated = "Push";

        public string FindTextByPath(string path)
        {
            return altDriver.FindObject(By.PATH, path).GetText();
        }

        public void VerifyAndAssertText(string path, string expectedText)
        {
            string foundText = FindTextByPath(path);
            Assert.That(foundText, Is.EqualTo(expectedText));
        }

        // SCREEN COORDINATES METHOD //
        public void ClickThumbTipLandmark() => Click(1067.905f, 858.2055f);
        public void ClickDistalEndIndexLandmark() => Click(1125.019f, 871.6506f);
        public void ClickDistalMiddleFingerLandmark() => Click(1155.479f, 833.2361f);
        public void ClickDistalRingFingerLandmark() => Click(1121.211f, 792.9009f);
        public void ClickDistalLittleFingerLandmark() => Click(1214.496f, 769.8522f);
        public void ClickThumbMetacarpalLandmark() => Click(1111.692f, 863.9677f);
        public void ClickIndexMetacarpalLandmark() => Click(1092.655f, 915.8273f);
        public void ClickMiddleMetacarpalLandmark() => Click(1090.751f, 902.3822f);
        public void ClickRingMetacarpalLandmark() => Click(1085.039f, 900.4614f);
        public void ClickLittleMetacarpalLandmark() => Click(1079.328f, 881.2542f);
        public void ClickCreaseCenterMetacarpalLandmark() => Click(932.7375f, 863.9677f);
        public void ClickMedialBorderMetacarpalLandmark() => Click(1096.462f, 802.5045f);
        public void ClickWristCreaseCenterLandmark() => Click(1056.483f, 800.5838f);
        /*  public void ClickThumbInterPhalangealLandmark() => Click(1066.6f, 1094.036f);
          public void ClickThumbMetaPhalangealLandmark() => Click(1109.17f, 890.096f);
          public void ClickFirstInterdigitalLandmark() => Click(903.4186f, 968.8098f);
          public void ClickFirstOnMeshToActivateDrawing() => Click(487.4975f, 791.1719f); */
        public void ClickOnSplintToAddRivetHole1Closing() => Click(452.9865f, 1009.943f);
        public void ClickOnSplintToAddRivetHole2Closing() => Click(481.5432f, 652.688f);
        public void ClickOnSplintToAddMushroomPin1Closing() => Click(1155.479f, 986.894f);
        public void ClickOnSplintToAddMushroomPin2Closing() => Click(1123.115f, 702.6268f);
        public void ClickOnSplintToAddFreeBeltloop1Closing() => Click(584.3469f, 933.1138f);
        public void ClickOnSplintToAddFreeBeltloop2Closing() => Click(578.6356f, 729.517f);
        public void ClickOnSplintToAddSlottedHole1Closing() => Click(1001.273f, 911.9858f);
        public void ClickOnSplintToAddSlottedHole2Closing() => Click(919.4111f, 767.9315f);
        public void ClickOnSplintToAddSerialNumber() => Click(679.9304f, 800.6485f);

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

        // FIT LEVEL 

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
            var startPosition = MoveSliderLengthFitObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(748.0715f, 426.0425f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(749.9753f, 251.2565f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void MoveSliderLengthTo100FitObject()
        {
            var MoveSliderLengthFitObject = altDriver.WaitForObject(By.PATH, "/Fit/FitEditorStep(Clone)/FitEditorPanel/Canvas/NonGenerativePatternPan/LevelBottomMenu/Lines/Line2/ShiftLengthSlider/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderLengthFitObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(749.9753f, 249.3358f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(749.9753f, 433.7254f), 0.5f);
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
            altDriver.MoveMouse(new AltVector2(1027.579f, 306.8984f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1020.484f, 410.6575f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0);            
        }

        public void ClickSelectableAlveoleZoneBtnFitObject()
        {
            var ClickSelectableAlveoleZoneBtnFitObject = altDriver.WaitForObject(By.PATH, "/Fit/FitEditorStep(Clone)/TemplateItems/SelectableAlveoleZone");
            ClickSelectableAlveoleZoneBtnFitObject.Tap();
        }

        public void MoveSliderRadiusFitObject()
        {
            var MoveSliderRadiusFitObject = altDriver.WaitForObject(By.PATH, "/Fit/FitEditorStep(Clone)/FitEditorPanel/Canvas/GenerativePatternPan/Sliders/Radius Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderRadiusFitObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(573.5073f, 181.6719f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(672.8354f, 181.6719f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0);  
        }

        public void MoveSliderRadiusTo0FitObject()
        {
            var MoveSliderRadiusTo0FitObject = altDriver.WaitForObject(By.PATH, "/Fit/FitEditorStep(Clone)/FitEditorPanel/Canvas/GenerativePatternPan/Sliders/Radius Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderRadiusTo0FitObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(763.3017f, 182.1105f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(565.3092f, 178.269f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0);  
        }

        public void MoveSliderWidthFitObject()
        {
            var MoveSliderWidthFitObject = altDriver.WaitForObject(By.PATH, "/Fit/FitEditorStep(Clone)/FitEditorPanel/Canvas/GenerativePatternPan/Sliders/Width Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderWidthFitObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(612.9774f, 72.94879f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(761.003f, 63.90094f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0);  
        }

        public void MoveSliderDensityFitObject()
        {
            var MoveSliderDensityFitObject = altDriver.WaitForObject(By.PATH, "/Fit/FitEditorStep(Clone)/FitEditorPanel/Canvas/GenerativePatternPan/Sliders/Density Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderDensityFitObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(110.882f, 176.9991f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1182.652f, 176.991f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0);  
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
            altDriver.MoveMouse(new AltVector2(469.4373f, 176.9991f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(460.4661f, 272.0015f), 0.5f);
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
            altDriver.MoveMouse(new AltVector2(725.118f, 213.1905f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(729.6036f, 312.7169f), 0.5f);
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
            altDriver.MoveMouse(new AltVector2(994.2254f, 154.3795f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(998.7411f, 244.858f), 0.5f);
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
            altDriver.MoveMouse(new AltVector2(1272.364f, 163.4273f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1272.364f, 272.0015f), 0.5f);
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


        // RAIL BELT LOOPS LEVEL //


        public void ClickBelt0RailObject()
        {
            var ClickBelt0RailObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/ClosingSystemsEditors/BeltLoopsEditors/RailBeltLoopsEditor/RailBeltLoop(Clone)/PreviewMesh");
            ClickBelt0RailObject.Tap();
        }

        public void ClickBelt1RailObject()
        {
            var ClickBelt1RailObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/ClosingSystemsEditors/BeltLoopsEditors/RailBeltLoopsEditor/RailBeltLoop(Clone)[1]/PreviewMesh");
            ClickBelt1RailObject.Tap();
        }

        public void ClickBelt2RailObject()
        {
            var ClickBelt2RailObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/ClosingSystemsEditors/BeltLoopsEditors/RailBeltLoopsEditor/RailBeltLoop(Clone)[2]/PreviewMesh");
            ClickBelt2RailObject.Tap();
        }

        public void ClickBelt3RailObject()
        {
            var ClickBelt3RailObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/ClosingSystemsEditors/BeltLoopsEditors/RailBeltLoopsEditor/RailBeltLoop(Clone)[3]/PreviewMesh");
            ClickBelt3RailObject.Tap();
        }

        public void ClickBelt4RailObject()
        {
            var ClickBelt4RailObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/ClosingSystemsEditors/BeltLoopsEditors/RailBeltLoopsEditor/RailBeltLoop(Clone)[4]/PreviewMesh");
            ClickBelt4RailObject.Tap();
        }

        public void ClickBelt5RailObject()
        {
            var ClickBelt5RailObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/ClosingSystemsEditors/BeltLoopsEditors/RailBeltLoopsEditor/RailBeltLoop(Clone)[5]/PreviewMesh");
            ClickBelt5RailObject.Tap();
        }

        public void ClickBeltLengthRailObject()
        {
            var ClickBeltLengthRailObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/BeltLoopsEditorsPanel/LengthSlider/ButtonAndSlidingPanel/Button");
            ClickBeltLengthRailObject.Tap();
        }

        public void MoveSliderBeltLengthRailObject()
        {
            var MoveSliderBeltLengthRailObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/BeltLoopsEditorsPanel/LengthSlider/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderBeltLengthRailObject.GetScreenPosition();
            Move(361.7824f, 213.1905f, 361.7824f, 244.858f);
        }

        public void ClickBeltClearanceRailObject()
        {
            var ClickBeltClearanceRailObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/BeltLoopsEditorsPanel/ClearanceSlider/ButtonAndSlidingPanel/Button");
            ClickBeltClearanceRailObject.Tap();
        }

        public void MoveSliderBeltClearanceRailObject()
        {
            var MoveSliderBeltClearanceRailObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/BeltLoopsEditorsPanel/ClearanceSlider/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderBeltClearanceRailObject.GetScreenPosition();
            Move(626.4342f, 249.3819f, 626.4342f, 321.7647f);
        }

        public void ClickBeltWidthRailObject()
        {
            var ClickBeltWidthRailObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/BeltLoopsEditorsPanel/WidthSlider/ButtonAndSlidingPanel/Button");
            ClickBeltWidthRailObject.Tap();
        }

        public void MoveSliderBeltWidthRailObject()
        {
            var MoveSliderBeltWidthRailObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/BeltLoopsEditorsPanel/WidthSlider/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderBeltWidthRailObject.GetScreenPosition();
            Move(895.5717f, 258.4297f, 895.5717f, 339.8604f);
        }

        public void ClickBeltThicknessRailObject()
        {
            var ClickBeltThicknessRailObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/BeltLoopsEditorsPanel/ThicknessSlider/ButtonAndSlidingPanel/Button");
            ClickBeltThicknessRailObject.Tap();
        }

        public void MoveSliderBelThicknessRailObject()
        {
            var MoveSliderBelThicknessRailObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/BeltLoopsEditorsPanel/ThicknessSlider/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderBelThicknessRailObject.GetScreenPosition();
            Move(1169.195f, 163.4273f, 1164.709f, 231.2862f);
        }

        public void ClickBeltTrashRailObject()
        {
            var ClickBeltTrashRailObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/BeltLoopsEditorsPanel/DeleteButton");
            ClickBeltTrashRailObject.Tap();
        }

        public void ClickResetBtnRailObject()
        {
            var ClickResetBtnRailObject = altDriver.WaitForObject(By.PATH, "/Canvas/RailBeltLoopPersPan(Clone)");
            ClickResetBtnRailObject.Tap();
        }

        public void ClickCancelExitLevelBtnRailObject()
        {
            var ClickCancelExitLevelBtnRailObject = altDriver.WaitForObject(By.PATH, "/Canvas/WarnPopup(Clone)/Forma Info Panel v3/Content/Bottom Container/Back btn");
            ClickCancelExitLevelBtnRailObject.Tap();
        }

        public void ClickConfirmExitLevelBtnRailObject()
        {
            var ClickConfirmExitLevelBtnRailObject = altDriver.WaitForObject(By.PATH, "/Canvas/WarnPopup(Clone)/Forma Info Panel v3/Content/Bottom Container/Do it btn");
            ClickConfirmExitLevelBtnRailObject.Tap();
        }

        public void ClickQuitBtnRailObject()
        {
            var ClickQuitBtnRailObject = altDriver.WaitForObject(By.PATH, "/Canvas/Navigation Buttons Panel/NavPrev Step/Forma Button v3 Contextual/Text");
            ClickQuitBtnRailObject.Tap();
        }

        public void ClickNextStepBtnRailObject()
        {
            var ClickNextStepBtnRailObject = altDriver.WaitForObject(By.PATH, "/Canvas/Navigation Buttons Panel/NavNext Step/Forma Button v3 Contextual/Text");
            ClickNextStepBtnRailObject.Tap();
        }

        public void ClickPreviousStepBtnRailObject()
        {
            var ClickPreviousStepBtnRailObject = altDriver.WaitForObject(By.PATH, "/Canvas/Navigation Buttons Panel/NavPrev Step/Forma Button v3 Contextual");
            ClickPreviousStepBtnRailObject.Tap();
        }

        public void ClickValidateBtnRailObject()
        {
            var ClickValidateBtnRailObject = altDriver.WaitForObject(By.PATH, "/Canvas/Navigation Buttons Panel/NavNext Step/Forma Button v3 Contextual");
            ClickValidateBtnRailObject.Tap();
        }

        // CLOSING SYSTEMS LEVEL

        public void ClickClosingSystemsBtnMainViewObject()
        {
            var ClickClosingSystemsBtnMainViewObject = altDriver.WaitForObject(By.PATH, "/Canvas/MainMenu(Clone)/MainMenuBtn(Clone)[1]");
            ClickClosingSystemsBtnMainViewObject.Tap();
        }

        public void ClickQuitBtnClosingObject()
        {
            var ClickQuitBtnClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/LevelNavigationPanel(Clone)/Canvas/NavPrev Step/Forma Button v3 Contextual");
            ClickQuitBtnClosingObject.Tap();
        }

        public void ClickShowMenuClosingSystemBtnClosingObject()
        {
            var ClickShowMenuClosingSystemBtnClosingObject = altDriver.WaitForObject(By.PATH,"/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/ClosingSystemsEditorPanel/ClosingSystemsDropdown");
            ClickShowMenuClosingSystemBtnClosingObject.Tap();
        }

        public void ClickRivetHoleClosingSystemBtnClosingObject()
        {
            var ClickRivetHoleClosingSystemBtnClosingObject = altDriver.WaitForObject(By.PATH,"/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/ClosingSystemsEditorPanel/ClosingSystemsDropdown/Dropdown List/Viewport/Content/Item 0: Rivet  Hole");
            ClickRivetHoleClosingSystemBtnClosingObject.Tap();
        }

        public void ClickMushroomPinClosingSystemBtnClosingObject()
        {
            var ClickMushroomPinClosingSystemBtnClosingObject = altDriver.WaitForObject(By.PATH,"/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/ClosingSystemsEditorPanel/ClosingSystemsDropdown/Dropdown List/Viewport/Content/Item 1: Pin");
            ClickMushroomPinClosingSystemBtnClosingObject.Tap();
        }

        public void ClickFreeBeltLoopClosingSystemBtnClosingObject()
        {
            var ClickFreeBeltLoopClosingSystemBtnClosingObject = altDriver.WaitForObject(By.PATH,"/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/ClosingSystemsEditorPanel/ClosingSystemsDropdown/Dropdown List/Viewport/Content/Item 2: Free  Belt  Loop");
            ClickFreeBeltLoopClosingSystemBtnClosingObject.Tap();
        }

        public void ClickSlottedHoleClosingSystemBtnClosingObject()
        {
            var ClickSlottedHoleClosingSystemBtnClosingObject = altDriver.WaitForObject(By.PATH,"/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/ClosingSystemsEditorPanel/ClosingSystemsDropdown/Dropdown List/Viewport/Content/Item 3: Slotted Hole");
            ClickSlottedHoleClosingSystemBtnClosingObject.Tap();
        }

        public void ClickRailBeltLoopClosingSystemBtnClosingObject()
        {
            var ClickRailBeltLoopClosingSystemBtnClosingObject = altDriver.WaitForObject(By.PATH,"/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/ClosingSystemsEditorPanel/ClosingSystemsDropdown/Dropdown List/Viewport/Content/Item 4: Rail  Belt  Loops");
            ClickRailBeltLoopClosingSystemBtnClosingObject.Tap();
        }

        public void ClickRotateScanAntiYClosingObject()
        {
            var ClickRotateScanAntiYClosingObject = altDriver.WaitForObject(By.PATH, "/Canvas/Compass3D/AntiYBar/AntiY");
            ClickRotateScanAntiYClosingObject.Tap();
        }

        public void ClickRotateScanYClosingObject()
        {
            var ClickRotateScanYClosingObject = altDriver.WaitForObject(By.PATH, "/Canvas/Compass3D/YBar/Y/YLabel");
            ClickRotateScanYClosingObject.Tap();
        }

        public void ClickRotateScanXClosingObject()
        {
            var ClickRotateScanXClosingObject = altDriver.WaitForObject(By.PATH, "/Canvas/Compass3D/XBar/X/XLabel");
            ClickRotateScanXClosingObject.Tap();
        }

        public void ClickBackArrowBtnClosingObject()
        {
            var ClickBackArrowBtnClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/ClosingSystemPlacementPanel/CancelButton");
            ClickBackArrowBtnClosingObject.Tap();
        }

        public void ClickTickBtnClosingObject()
        {
            var ClickTickBtnClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/ClosingSystemPlacementPanel/ConfirmButton");
            ClickTickBtnClosingObject.Tap();
        }

        public void ClickOnPlacedRivetHoleClosingObject()
        {
            var ClickOnPlacedRivetHoleClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/ClosingSystemsEditors/RivetHolesEditor/RivetHole(Clone)");
            ClickOnPlacedRivetHoleClosingObject.Tap();
        }

        public void ClickOnSecondPlacedRivetHoleClosingObject()
        {
            var ClickOnSecondPlacedRivetHoleClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/ClosingSystemsEditors/RivetHolesEditor/RivetHole(Clone)[1]");
            ClickOnSecondPlacedRivetHoleClosingObject.Tap();
        }

        public void ClickOnDiameterRivetHoleClosingObject()
        {
            var ClickOnDiameterRivetHoleClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/RivetHolesEditorPanel/DiameterSlider/ButtonAndSlidingPanel/Button");
            ClickOnDiameterRivetHoleClosingObject.Tap();
        }

        public void MoveSliderDiameterRivetHoleClosingObject()
        {
            var MoveSliderDiameterRivetHoleClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/RivetHolesEditorPanel/DiameterSlider/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderDiameterRivetHoleClosingObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(496.7733f, 241.6529f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(502.4847f, 418.3596f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0);  
        }

        public void ClickSelectAllRivetHoleClosingObject()
        {
            var ClickSelectAllRivetHoleClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/RivetHolesEditorPanel/SelectAllButton");
            ClickSelectAllRivetHoleClosingObject.Tap();
        }

        public void ClickOnPlacedMushroomPinClosingObject()
        {
            var ClickOnPlacedMushroomPinClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/ClosingSystemsEditors/PinsEditor/Pin(Clone)/PreviewMesh");
            ClickOnPlacedMushroomPinClosingObject.Click();
        }

        public void ClickOnSecondPlacedMushroomPinClosingObject()
        {
            var ClickOnSecondPlacedMushroomPinClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/ClosingSystemsEditors/PinsEditor/Pin(Clone)[1]/PreviewMesh");
            ClickOnSecondPlacedMushroomPinClosingObject.Tap();
        }

        public void ClickOnScaleMushroomPinClosingObject()
        {
            var ClickOnScaleMushroomPinClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/PinsEditorPanel/ScaleSlider/ButtonAndSlidingPanel/Button");
            ClickOnScaleMushroomPinClosingObject.Tap();
        }

        public void MoveSliderScaleMushroomPinClosingObject()
        {
            var MoveSliderScaleMushroomPinClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/PinsEditorPanel/ScaleSlider/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderScaleMushroomPinClosingObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(477.7356f, 180.1897f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(481.5432f, 416.4388f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0); 
        }

        public void ClickSelectAllMushroomPinClosingObject()
        {
            var ClickSelectAllMushroomPinClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/PinsEditorPanel/SelectAllButton");
            ClickSelectAllMushroomPinClosingObject.Tap();
        }

        public void ClickOnPlacedFreeBeltLoopClosingObject()
        {
            var ClickOnPlacedFreeBeltLoopClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/ClosingSystemsEditors/BeltLoopsEditors/FreeBeltLoopsEditor/FreeBeltLoop(Clone)/PreviewMesh");
            ClickOnPlacedFreeBeltLoopClosingObject.Click();
        }

        public void ClickOnSecondPlacedFreeBeltLoopClosingObject()
        {
            var ClickOnSecondPlacedMushroomPinClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/ClosingSystemsEditors/PinsEditor/Pin(Clone)[1]/PreviewMesh");
            ClickOnSecondPlacedMushroomPinClosingObject.Tap();
        }

        public void ClickOnPlacedSlottedHoleClosingObject()
        {
            var ClickOnPlacedSlottedHoleClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/ClosingSystemsEditors/SlottedHolesEditor/SlottedHole(Clone)/PreviewMesh");
            ClickOnPlacedSlottedHoleClosingObject.Click();
        }

        public void ClickOnSecondPlacedSlottedHoleClosingObject()
        {
            var ClickOnSecondPlacedMushroomPinClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/ClosingSystemsEditors/SlottedHolesEditor/SlottedHole(Clone)[1]/PreviewMesh");
            ClickOnSecondPlacedMushroomPinClosingObject.Tap();
        }

        public void ClickOnLengthSlottedHoleClosingObject()
        {
            var ClickOnLengthSlottedHoleClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/SlottedHolesEditorPanel/Background/LengthDropdown/NumberedDropdown/ButtonAndLabels/Button");
            ClickOnLengthSlottedHoleClosingObject.Tap();
        }

        public void ClickOnLength15mmSlottedHoleClosingObject()
        {
            var ClickOnLengthSlottedHoleClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/SlottedHolesEditorPanel/Background/LengthDropdown/NumberedDropdown/Dropdown List/Viewport/Content/Item 2: 15 mm");
            ClickOnLengthSlottedHoleClosingObject.Tap();
        }

        public void ClickOnLength35mmSlottedHoleClosingObject()
        {
            var ClickOnLength35mmSlottedHoleClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/SlottedHolesEditorPanel/Background/LengthDropdown/NumberedDropdown/Dropdown List/Viewport/Content/Item 0: 35 mm");
            ClickOnLength35mmSlottedHoleClosingObject.Tap();
        }

        public void ClickSelectAllSlottedHoleClosingObject()
        {
            var ClickSelectAllSlottedHoleClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/SlottedHolesEditorPanel/Background/SelectAllButton");
            ClickSelectAllSlottedHoleClosingObject.Tap();
        }

        public void ClickNextStepBtnClosingObject()
        {
            var ClickNextStepBtnClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/LevelNavigationPanel(Clone)/Canvas/NavNext Step/Forma Button v3 Contextual");
            ClickNextStepBtnClosingObject.Tap();
        }

        public void ClickPreviousStepBtnClosingObject()
        {
            var ClickPreviousStepBtnClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/LevelNavigationPanel(Clone)/Canvas/NavPrev Step/Forma Button v3 Contextual");
            ClickPreviousStepBtnClosingObject.Tap();
        }

        public void ClickValidateBtnClosingObject()
        {
            var ClickValidateBtnClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/LevelNavigationPanel(Clone)/Canvas/NavNext Step/Forma Button v3 Contextual");
            ClickValidateBtnClosingObject.Tap();
        }

        public void ClickOnPlacedFreeBeltClosingObject()
        {
            var ClickOnPlacedFreeBeltClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/ClosingSystemsEditors/BeltLoopsEditors/FreeBeltLoopsEditor/FreeBeltLoop(Clone)");
            ClickOnPlacedFreeBeltClosingObject.Tap();
        }

        public void ClickOnThicknessFreeBeltClosingObject()
        {
            var ClickOnThicknessFreeBeltClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/BeltLoopsEditorsPanel/ThicknessSlider/ButtonAndSlidingPanel/Button");
            ClickOnThicknessFreeBeltClosingObject.Tap();
        }

        public void MoveSliderThicknessFreeBeltClosingObject()
        {
            var MoveSliderThicknessFreeBeltClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/BeltLoopsEditorsPanel/ThicknessSlider/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderThicknessFreeBeltClosingObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(478.9281f, 452.9326f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(470.1205f, 525.9202f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0); 
        }

        public void ClickOnLengthFreeBeltClosingObject()
        {
            var ClickOnLengthFreeBeltClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/BeltLoopsEditorsPanel/LengthSlider/ButtonAndSlidingPanel/Button");
            ClickOnLengthFreeBeltClosingObject.Tap();
        }

        public void MoveSliderLengthFreeBeltClosingObject()
        {
            var MoveSliderLengthFreeBeltClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/BeltLoopsEditorsPanel/LengthSlider/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderLengthFreeBeltClosingObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(468.2167f, 249.3358f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(470.1205f, 370.3415f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0); 
        }

        public void ClickOnClearanceFreeBeltClosingObject()
        {
            var ClickOnClearanceFreeBeltClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/BeltLoopsEditorsPanel/ClearanceSlider/ButtonAndSlidingPanel/Button");
            ClickOnClearanceFreeBeltClosingObject.Tap();
        }

        public void MoveSliderClearanceFreeBeltClosingObject()
        {
            var MoveSliderClearanceFreeBeltClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/BeltLoopsEditorsPanel/ClearanceSlider/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderClearanceFreeBeltClosingObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(730.9375f, 424.1218f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(738.5526f, 545.1274f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0); 
        }

        public void ClickOnWidthFreeBeltClosingObject()
        {
            var ClickOnWidthFreeBeltClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/BeltLoopsEditorsPanel/WidthSlider/ButtonAndSlidingPanel/Button");
            ClickOnWidthFreeBeltClosingObject.Tap();
        }

        public void MoveSliderWidthFreeBeltClosingObject()
        {
            var MoveSliderWidthFreeBeltClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/BeltLoopsEditorsPanel/WidthSlider/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderWidthFreeBeltClosingObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(736.6489f, 228.2078f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(734.7451f, 328.0855f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0); 
        }

        public void ClickOnSecondPlacedFreeBeltClosingObject()
        {
            var ClickOnSecondPlacedFreeBeltClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/ClosingSystemsEditors/BeltLoopsEditors/FreeBeltLoopsEditor/FreeBeltLoop(Clone)[1]");
            ClickOnSecondPlacedFreeBeltClosingObject.Tap();
        }

        public void ClickSelectAllFreeBeltClosingObject()
        {
            var ClickSelectAllFreeBeltClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/BeltLoopsEditorsPanel/SelectAllButton");
            ClickSelectAllFreeBeltClosingObject.Tap();
        }

        public void ClickAddRailBeltClosingObject()
        {
            var ClickAddRailBeltClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/ClosingSystemsEditorPanel/ClosingSystemsDropdown/Dropdown List/Viewport/Content/Item 4: Rail  Belt  Loops");
            ClickAddRailBeltClosingObject.Tap();
        }

        public void CorrectRailBeltLoopPosition()
        {
            var CorrectRailBeltLoopPosition = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/ClosingSystemsEditors/BeltLoopsEditors/RailBeltLoopsEditor/RailBeltLoop(Clone)[2]/PreviewMesh");
            CorrectRailBeltLoopPosition.Tap();
            altDriver.MoveMouse(new AltVector2(1092.655f, 946.5588f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(980.3318f, 823.6324f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0); 
        }

        // SERIAL NUMBER ENGRAVER

        public void ClickSerialNumberBtnMainViewObject()
        {
            var ClickSerialNumberBtnMainViewObject = altDriver.WaitForObject(By.PATH, "/Canvas/MainMenu(Clone)/MainMenuBtn(Clone)[3]");
            ClickSerialNumberBtnMainViewObject.Tap();
        }

        public void ClickQuitBtnSerialNumberObject()
        {
            var ClickQuitBtnSerialNumberObject = altDriver.WaitForObject(By.PATH, "/Canvas/Navigation Buttons Panel/NavPrev Step/Forma Button v3 Contextual");
            ClickQuitBtnSerialNumberObject.Tap();
        }

        public void ClickCancelBtnPopUpSerialNumberObject()
        {
            var ClickCancelBtnPopUpSerialNumberObject = altDriver.WaitForObject(By.PATH, "/Canvas/WarnPopup(Clone)/Forma Info Panel v3/Content/Bottom Container/Back btn");
            ClickCancelBtnPopUpSerialNumberObject.Tap();
        }

        public void ClickConfirmBtnPopUpSerialNumberObject()
        {
            var ClickConfirmBtnPopUpSerialNumberObject = altDriver.WaitForObject(By.PATH, "/Canvas/WarnPopup(Clone)/Forma Info Panel v3/Content/Bottom Container/Do it btn");
            ClickConfirmBtnPopUpSerialNumberObject.Tap();
        }

        public void ClickNextStepBtnPopUpSerialNumberObject()
        {
            var ClickNextStepBtnPopUpSerialNumberObject = altDriver.WaitForObject(By.PATH, "/Canvas/Navigation Buttons Panel/NavNext Step/Forma Button v3 Contextual");
            ClickNextStepBtnPopUpSerialNumberObject.Tap();
        }


    }
}