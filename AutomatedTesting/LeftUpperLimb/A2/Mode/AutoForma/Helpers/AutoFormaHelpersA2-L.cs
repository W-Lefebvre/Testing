using System;
using AltTester.AltTesterUnitySDK.Driver;
using NUnit.Framework;
using System.Threading;

public partial class FullAutoFormaA2L
{
    public class AutoFormaHelpersA2L
    {
        private AltDriver altDriver;

        public AutoFormaHelpersA2L(AltDriver driver)
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
        public void ClickOnSplintToAddRivetHole1Closing() => Click(456.7941f, 691.1025f);
        public void ClickOnSplintToAddRivetHole2Closing() => Click(489.1583f, 942.7174f);
        public void ClickOnSplintToAddMushroomPin1Closing() => Click(1155.479f, 986.894f);
        public void ClickOnSplintToAddMushroomPin2Closing() => Click(1123.115f, 702.6268f);
        public void ClickOnSplintToAddFreeBeltloop1Closing() => Click(563.4055f, 842.8397f);
        public void ClickOnSplintToAddFreeBeltloop2Closing() => Click(668.113f, 735.2791f);
        public void ClickOnSplintToAddSlottedHole1Closing() => Click(871.8168f, 796.7423f);
        public void ClickOnSplintToAddSlottedHole2Closing() => Click(953.6791f, 735.2791f);
        public void ClickOnSplintToAddSerialNumber() => Click(1319.204f, 671.8952f);

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

        // AXIS BUTTON 

        public void ClickOnAxisAntiZObject()
        {
            var ClickOnAxisAntiZObject = altDriver.WaitForObject(By.PATH, "/Canvas/Compass3D/AntiZBar/AntiZ");
            ClickOnAxisAntiZObject.Tap();
        }

        public void ClickOnAxisZObject()
        {
            var ClickOnAxisZObject = altDriver.WaitForObject(By.PATH, "/Canvas/Compass3D/ZBar/Z/ZLabel");
            ClickOnAxisZObject.Tap();
        }

        public void ClickOnAxisXObject()
        {
            var ClickOnAxisXObject = altDriver.WaitForObject(By.PATH, "/Canvas/Compass3D/XBar/X/XLabel");
            ClickOnAxisXObject.Tap();
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


        // RAIL BELT LOOPS LEVEL //


        public void ClickBelt0RailObject()
        {
            var ClickBelt0RailObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/ClosingSystemsEditors/BeltLoopsEditors/RailBeltLoopsEditor/RailBeltLoop(Clone)[2]");
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
            altDriver.MoveMouse(new AltVector2(472.0243f, 237.8115f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(472.0243f, 387.628f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0);  
        }

        public void MoveSliderBeltLengthBackToDefaultRailObject()
        {
            var MoveSliderBeltLengthBackToDefaultRailObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/BeltLoopsEditorsPanel/LengthSlider/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderBeltLengthBackToDefaultRailObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(472.0243f, 381.8658f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(472.0243f, 226.2871f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0);  
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
            altDriver.MoveMouse(new AltVector2(730.9375f, 422.201f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(732.8413f, 548.9689f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0); 
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
            altDriver.MoveMouse(new AltVector2(730.9375f, 418.3596f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(732.8413f, 235.8907f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0); 
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
            altDriver.MoveMouse(new AltVector2(470.1205f, 449.0912f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(475.8318f, 358.8171f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0); 
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
            var ClickOnPlacedSlottedHoleClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/ClosingSystemsEditors/SlottedHolesEditor/SlottedHole(Clone)");
            ClickOnPlacedSlottedHoleClosingObject.Click();
        }

        public void ClickOnSecondPlacedSlottedHoleClosingObject()
        {
            var ClickOnSecondPlacedMushroomPinClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/ClosingSystemsEditors/SlottedHolesEditor/SlottedHole(Clone)[1]");
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
            var CorrectRailBeltLoopPosition = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/ClosingSystemsEditors/BeltLoopsEditors/RailBeltLoopsEditor/RailBeltLoop(Clone)[2]");
            CorrectRailBeltLoopPosition.Tap();
            altDriver.MoveMouse(new AltVector2(1012.696f, 787.1387f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(963.1979f, 783.2972f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0); 
        }

        // SERIAL NUMBER ENGRAVER

        public void ClickSerialNumberBtnMainViewObject()
        {
            var ClickSerialNumberBtnMainViewObject = altDriver.WaitForObject(By.PATH, "/Canvas/MainMenu(Clone)/MainMenuBtn(Clone)[2]");
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

        public void ClickNextStepBtnSerialNumberObject()
        {
            var ClickNextStepBtnSerialNumberObject = altDriver.WaitForObject(By.PATH, "/TextEngrave/LevelNavigationPanel(Clone)/Canvas/NavNext Step/Forma Button v3 Contextual");
            ClickNextStepBtnSerialNumberObject.Tap();
        }

        public void ClickValidateBtnSerialNumberObject()
        {
            var ClickValidateBtnSerialNumberObject = altDriver.WaitForObject(By.PATH, "/TextEngrave/LevelNavigationPanel(Clone)/Canvas/NavNext Step/Forma Button v3 Contextual");
            ClickValidateBtnSerialNumberObject.Tap();
        }

    }
}