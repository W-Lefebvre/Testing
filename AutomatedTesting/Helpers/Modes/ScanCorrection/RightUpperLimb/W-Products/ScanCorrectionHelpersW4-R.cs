using System;
using AltTester.AltTesterUnitySDK.Driver;
using NUnit.Framework;
using System.Threading;

public partial class FullScanCorrectionW4R
{
    public class ScanCorrectionHelpersW4R
    {
        private AltDriver altDriver;

        public ScanCorrectionHelpersW4R(AltDriver driver)
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
        public void ClickSelectPartOfInterestArmRightA2() => Click(938.4489f, 685.3403f);
        public void ClickWristCreaseCenterCleanupLandmark() => Click(947.9677f, 691.1025f);
        public void ClickVentralArmCleanupLandmark() => Click(1218.304f, 710.3097f);
        public void ClickThumbTipLandmark() => Click(1066.002f, 1004.181f);
        public void ClickDistalEndIndexLandmark() => Click(896.5659f, 815.9496f);
        public void ClickDistalMiddleFingerLandmark() => Click(887.047f, 804.4252f);
        public void ClickDistalRingFingerLandmark() => Click(907.9885f, 781.3765f);
        public void ClickDistalLittleFingerLandmark() => Click(944.1602f, 767.9315f);
        public void ClickThumbMetacarpalLandmark() => Click(1104.077f, 873.5713f);
        public void ClickIndexMetacarpalLandmark() => Click(1195.458f, 852.4434f);
        public void ClickMiddleMetacarpalLandmark() => Click(1199.266f, 823.6324f);
        public void ClickRingMetacarpalLandmark() => Click(1204.977f, 810.1874f);
        public void ClickLittleMetacarpalLandmark() => Click(1203.073f, 787.1387f);
        public void ClickCreaseCenterMetacarpalLandmark() => Click(906.0847f, 817.8703f);
        public void ClickMedialBorderMetacarpalLandmark() => Click(1033.637f, 838.9983f);
        public void ClickWristCreaseCenterLandmark() => Click(1077.424f, 794.8216f);
        public void ClickThumbInterPhalangealLandmark() => Click(1050.771f, 1054.119f);
        public void ClickThumbMetaPhalangealLandmark() => Click(1094.558f, 858.2055f);
        public void ClickFirstInterdigitalLandmark() => Click(970.813f, 977.2904f);
        public void ClickFirstOnMeshToActivateDrawing() => Click(487.4975f, 791.1719f);

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

        public void ClickOnAxisYSculptObject()
        {
            var ClickOnAxisYSculptObject = altDriver.WaitForObject(By.PATH, "/Canvas/Compass3D/AntiYBar/AntiY");
            ClickOnAxisYSculptObject.Tap();
        }

        public void ClickOnAxisXSculptObject()
        {
            var ClickOnAxisXSculptObject = altDriver.WaitForObject(By.PATH, "/Canvas/Compass3D/XBar/X/XLabel");
            ClickOnAxisXSculptObject.Tap();
        }

        public void ClickOnAxisAntiXSculptObject()
        {
            var ClickOnAxisAntiXSculptObject = altDriver.WaitForObject(By.PATH, "/Canvas/Compass3D/AntiXBar/AntiX");
            ClickOnAxisAntiXSculptObject.Tap();
        }

        public void ClickOnAxisAntiZSculptObject()
        {
            var ClickOnAxisAntiZSculptObject = altDriver.WaitForObject(By.PATH, "/Canvas/Compass3D/AntiZBar/AntiZ");
            ClickOnAxisAntiZSculptObject.Tap();
        }

        // CLEANUP LEVEL OBJECT // 

        public void ClickCleanupBtnMainViewObject()
        {
            var ClickCleanupBtnMainView = altDriver.WaitForObject(By.PATH, "/Canvas/MainMenu(Clone)/MainMenuBtn(Clone)/Text");
            ClickCleanupBtnMainView.Tap();
        }

        public void ClickQuitBtnObject()
        {
            var ClickQuitBtn = altDriver.WaitForObject(By.PATH, "/Cleanup/LevelNavigationPanel(Clone)/Canvas/NavPrev Step/Forma Button v3 Contextual/Text");
            ClickQuitBtn.Tap();
        }

        public void ClickConfirmBtnPopUpObject()
        {
            var ClickConfirmBtnPopUpObject = altDriver.WaitForObject(By.PATH, "/Canvas/WarnPopup(Clone)/Forma Info Panel v3/Content/Bottom Container/Do it btn/Text");
            ClickConfirmBtnPopUpObject.Tap();
        }

        public void ClickNextStepBtnObject()
        {
            var ClickNextStepBtnObject = altDriver.WaitForObject(By.PATH, "/Cleanup/LevelNavigationPanel(Clone)/Canvas/NavNext Step/Forma Button v3 Contextual");
            ClickNextStepBtnObject.Tap();
        }

        public void ClickPreviousStepBtnObject()
        {
            var ClickPreviousStepBtnObject = altDriver.WaitForObject(By.PATH, "/Cleanup/LevelNavigationPanel(Clone)/Canvas/NavPrev Step/Forma Button v3 Contextual");
            ClickPreviousStepBtnObject.Tap();
        }

        public void ClickCrossBtnObject()
        {
            var ClickCrossBtnObject = altDriver.WaitForObject(By.PATH, "/Cleanup/LMRunPlacementStep(Clone)/LMRunPlacementStepPanel/Canvas/SubStepPrevButton/Forma Button v3 Tools");
            ClickCrossBtnObject.Tap();
        }

        public void ClickTickBtnObject()
        {
            var ClickTickBtnObject = altDriver.WaitForObject(By.PATH, "/Cleanup/LMRunPlacementStep(Clone)/LMRunPlacementStepPanel/Canvas/SubStepNextButton/Forma Button v3 Tools");
            ClickTickBtnObject.Tap();
        }

        public void ClickBackArrowBtnObject()
        {
            var ClickBackArrowBtnObject = altDriver.WaitForObject(By.PATH, "/Cleanup/LMRunPlacementStep(Clone)/LMRunPlacementStepPanel/Canvas/SubStepPrevButton/Forma Button v3 Tools");
            ClickBackArrowBtnObject.Tap();
        }

        public void ClickValidateBtnObject()
        {
            var ClickValidateBtnObject = altDriver.WaitForObject(By.PATH, "/Cleanup/LevelNavigationPanel(Clone)/Canvas/NavNext Step/Forma Button v3 Contextual");
            ClickValidateBtnObject.Tap();
        }

        public void CuttingPlanePositionObject()
        {
            var Plane1 = altDriver.WaitForObject(By.PATH, "/Cleanup/CropScanStep(Clone)/MeshCropperTool/Plane1");
            //var startPosition = Plane1.GetScreenPosition();
            Move(1157.383f, 739.1206f, 679.5356f, 723.7548f);
        }

        public void ClickVerticalAngleBtnObject()
        {
            var ClickVerticalAngleBtnObject = altDriver.WaitForObject(By.PATH, "/Cleanup/CropScanStep(Clone)/CropScanPanel/Canvas/ExtensibleYSlider/ButtonAndSlidingPanel/Button");
            ClickVerticalAngleBtnObject.Tap();
        }

        public void MoveVerticalSliderCuttingPlanePositionObject()
        {
            var MoveVerticalSlider = altDriver.WaitForObject(By.PATH, "/Cleanup/CropScanStep(Clone)/CropScanPanel/Canvas/ExtensibleYSlider/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveVerticalSlider.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(740.2367f, 335.5216f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(747.3315f, 407.0796f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void ClickHorizontalAngleBtnObject()
        {
            var ClickVerticalAngleBtnObject = altDriver.WaitForObject(By.PATH, "/Cleanup/CropScanStep(Clone)/CropScanPanel/Canvas/ExtensibleXSlider/ButtonAndSlidingPanel/Button");
            ClickVerticalAngleBtnObject.Tap();
        }

        public void MoveHorizontalSliderCuttingPlanePositionObject()
        {
            var MoveHorizontalSlider = altDriver.WaitForObject(By.PATH, "/Cleanup/CropScanStep(Clone)/CropScanPanel/Canvas/ExtensibleXSlider/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveHorizontalSlider.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(992.1044f, 335.5216f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1006.294f, 174.5161f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void ClickResetPlaneBtnObject()
        {
            var ClickResetPlaneBtnObject = altDriver.WaitForObject(By.PATH, "/Cleanup/CropScanStep(Clone)/CropScanPanel/Canvas/Button Reset");
            ClickResetPlaneBtnObject.Tap();
        }

        // POSE LEVEL OBJECT //

        public void ClickAdvancedPoseBtnObject()
        {
            var ClickAdvancedPoseBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PoseModeSelectPan(Clone)/AdvancedMode");
            ClickAdvancedPoseBtnObject.Tap();
        }

        public void ClickTickBtnPoseObject()
        {
            var ClickTickBtnPoseObject = altDriver.WaitForObject(By.PATH, "/PoseCTL/LMRunPlacementStep/LMRunPlacementStepPanel/Canvas/SubStepNextButton/Forma Button v3 Tools/Icon");
            ClickTickBtnPoseObject.Tap();
        }

        public void ClickBackArrowBtnPoseObject()
        {
            var ClickBackArrowBtnPoseObject = altDriver.WaitForObject(By.PATH, "/PoseCTL/LMRunPlacementStep/LMRunPlacementStepPanel/Canvas/SubStepPrevButton/Forma Button v3 Tools/Icon");
            ClickBackArrowBtnPoseObject.Tap();
        }

        public void ClickPreviousStepBtnPoseObject()
        {
            var ClickPreviousStepBtnPoseObject = altDriver.WaitForObject(By.PATH, "/Canvas/Navigation Buttons Panel/NavPrev Step/Forma Button v3 Contextual/Background");
            ClickPreviousStepBtnPoseObject.Tap();
        }

        public void ClickKeepBtnLandmarksPopUpObject()
        {
            var ClickKeepBtnLandmarksPopUpObject = altDriver.WaitForObject(By.PATH, "/Canvas/Popup(Clone)/Content/Bottom Container/Confirm button");
            ClickKeepBtnLandmarksPopUpObject.Tap();
        }

        public void ClickValidateBtnPoseObject()
        {
            var ClickValidateBtnPoseObject = altDriver.WaitForObject(By.PATH, "/Canvas/Navigation Buttons Panel/NavNext Step/Forma Button v3 Contextual/Background");
            ClickValidateBtnPoseObject.Tap();
        }

        public void ClickPoseBtnMainViewObject()
        {
            var ClickPoseBtnMainViewObject = altDriver.WaitForObject(By.PATH, "/Canvas/MainMenu(Clone)/MainMenuBtn(Clone)[1]");
            ClickPoseBtnMainViewObject.Tap();
        }

        public void ClickQuitBtnPoseObject()
        {
            var ClickQuitBtnPoseObject = altDriver.WaitForObject(By.PATH, "/Canvas/Navigation Buttons Panel/NavPrev Step/Forma Button v3 Contextual/Text");
            ClickQuitBtnPoseObject.Tap();
        }

        public void ClickResetBtnPopUpObject()
        {
            var ClickResetBtnPopUpObject = altDriver.WaitForObject(By.PATH, "/Canvas/Popup(Clone)/Content/Bottom Container/Cancel button");
            ClickResetBtnPopUpObject.Tap();
        }

        public void ClickUndoBtnPoseObject()
        {
            var ClickUndoBtnPoseObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/BottomPanel/Undo");
            ClickUndoBtnPoseObject.Tap();
        }

        public void ClickRedoBtnPoseObject()
        {
            var ClickRedoBtnPoseObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/BottomPanel/Redo");
            ClickRedoBtnPoseObject.Tap();
        }

        public void ClickHandExtFlexBtnObject()
        {
            var ClickHandExtFlexBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/SliderPanel/PoseSlider(Clone)/IconPanel");
            ClickHandExtFlexBtnObject.Tap();
        }

        public void MoveSliderHandExtFlexObject()
        {
            var MoveSliderHandExtFlex = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/SliderPanel/PoseSlider(Clone)/SlideMask/Background/Slider/Handle Slide Area");
            var startPosition = MoveSliderHandExtFlex.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(396.1357f, 1158.438f), 0.12f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(257.7858f, 1158.438f), 0.25f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void ClickHandAdAbBtnObject()
        {
            var ClickHandAdAbBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/SliderPanel/PoseSlider(Clone)[1]/IconPanel");
            ClickHandAdAbBtnObject.Tap();
        }

        public void MoveSliderHandAdAbObject()
        {
            var MoveSliderHandAdAbObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/SliderPanel/PoseSlider(Clone)[1]/SlideMask/Background/Slider/Handle Slide Area");
            var startPosition = MoveSliderHandAdAbObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(222.3114f, 1033.212f), 0.12f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(353.5665f, 1033.212f), 0.25f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
            
        }

        public void ClickThumbExtFlexBtnObject()
        {
            var ClickThumbExtFlexBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/SliderPanel/PoseSlider(Clone)[2]/IconPanel");
            ClickThumbExtFlexBtnObject.Tap();
        }

        public void MoveSliderThumbExtFlexObject()
        {
            var MoveSliderThumbExtFlexObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/SliderPanel/PoseSlider(Clone)[2]/SlideMask/Background/Slider/Handle Slide Area");
            var startPosition = MoveSliderThumbExtFlexObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(318.0921f, 907.9855f), 0.12f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(381.9459f, 907.9855f), 0.25f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void ClickThumbAdAbBtnObject()
        {
            var ClickThumbAdAbBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/SliderPanel/PoseSlider(Clone)[3]/IconPanel");
            ClickThumbAdAbBtnObject.Tap();
        }

        public void MoveSliderThumbAdAbObject()
        {
            var MoveSliderThumbAdAbObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/SliderPanel/PoseSlider(Clone)[3]/SlideMask/Background/Slider/Handle Slide Area");
            var startPosition = MoveSliderThumbAdAbObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(310.9973f, 786.3369f), 0.12f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(247.1435f, 779.1812f), 0.25f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void ClickFingerExtFlexBtnObject()
        {
            var ClickFingerExtFlexBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/SliderPanel/PoseSlider(Clone)[4]/IconPanel");
            ClickFingerExtFlexBtnObject.Tap();
        }

        public void MoveSliderFingerExtFlexObject()
        {
            var MoveSliderFingerExtFlexObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/SliderPanel/PoseSlider(Clone)[4]/SlideMask/Background/Slider/Handle Slide Area");
            var startPosition = MoveSliderFingerExtFlexObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(325.187f, 661.1104f), 0.12f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(261.3332f, 657.5325f), 0.25f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void ClickFingerSplayBtnObject()
        {
            var ClickFingerSplayBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/SliderPanel/PoseSlider(Clone)[5]/IconPanel");
            ClickFingerSplayBtnObject.Tap();
        }

        public void MoveSliderFingerSplayObject()
        {
            var MoveSliderFingerSplayObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/SliderPanel/PoseSlider(Clone)[5]/SlideMask/Background/Slider/Handle Slide Area");
            var startPosition = MoveSliderFingerSplayObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(144.2679f, 539.4619f), 0.12f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(236.5012f, 539.4619f), 0.25f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void ClickNeutralPoseBtnObject()
        {
            var ClickNeutralPoseBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/AutomaticNeutralButton");
            ClickNeutralPoseBtnObject.Tap();
        }

        public void ClickResetSliderPoseBtnObject()
        {
            var ClickResetSliderPoseBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/ResetButton");
            ClickResetSliderPoseBtnObject.Tap();
        }

        public void ClickGlobalRotationPoseBtnObject()
        {
            var ClickGlobalRotationPoseBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/GlobalButton");
            ClickGlobalRotationPoseBtnObject.Tap();
        }

        public void ClickGlobalRotationForwardPoseBtnObject()
        {
            var ClickGlobalRotationForwardPoseBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Button");
            ClickGlobalRotationForwardPoseBtnObject.Tap();
        }

        public void MoveSliderGlobalRotationForwardObject()
        {
            var MoveSliderGlobalRotationForwardObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderGlobalRotationForwardObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(889.2289f, 339.0995f), 0.12f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(892.7763f, 482.2155f), 0.25f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void ClickGlobalRotationRightPoseBtnObject()
        {
            var ClickGlobalRotationRightPoseBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)[1]/ButtonAndSlidingPanel/Button");
            ClickGlobalRotationRightPoseBtnObject.Tap();
        }

        public void MoveSliderGlobalRotationRightObject()
        {
            var MoveSliderGlobalRotationRightObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)[1]/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderGlobalRotationRightObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(1137.549f, 356.989f), 0.12f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1141.097f, 231.7625f), 0.25f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void ClickGlobalRotationVerticalPoseBtnObject()
        {
            var ClickGlobalRotationVerticalPoseBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)[2]/ButtonAndSlidingPanel/Button");
            ClickGlobalRotationVerticalPoseBtnObject.Tap();
        }

        public void MoveSliderGlobalRotationVerticalObject()
        {
            var MoveSliderGlobalRotationVerticalObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)[2]/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderGlobalRotationVerticalObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(1382.322f, 339.0995f), 0.12f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1389.417f, 428.547f), 0.25f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void ClickAppearanceBtnObject()
        {
            var ClickAppearanceBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/MatDropDown");
            ClickAppearanceBtnObject.Tap();
        }

        public void ClickTransparentChoiceBtnObject()
        {
            var ClickTransparentChoiceBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/MatDropDown/Dropdown List/Viewport/Content/Item 1: Transparent");
            ClickTransparentChoiceBtnObject.Tap();
        }

        public void ClickNeutralGhostChoiceBtnObject()
        {
            var ClickNeutralGhostChoiceBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/MatDropDown/Dropdown List/Viewport/Content/Item 2: Neutral ghost");
            ClickNeutralGhostChoiceBtnObject.Tap();
        }

        public void ClickFirstSphereThumbExtFlexObject()
        {
            var ClickFirstSphereThumbExtFlexObject = altDriver.WaitForObject(By.PATH, "/PoseCTL/MBMForeArm(Clone)/Armature/lower arm.R/hand.R/f.thumb1.R/f.thumb2.R/f.thumb3.R/Sphere");
            ClickFirstSphereThumbExtFlexObject.Tap();
        }

        public void ClickFirstSphereThumbExtFlexBtnObject()
        {
            var ClickFirstSphereThumbExtFlexBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Button");
            ClickFirstSphereThumbExtFlexBtnObject.Tap();
        }

        public void MoveSliderFirstSphereThumbExtFlexObject()
        {
            var MoveSliderFirstSphereThumbExtFlexObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderFirstSphereThumbExtFlexObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(1328.976f, 343.6817f), 0.12f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1325.427f, 426.0182f), 0.25f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void ClickSecondSphereThumbExtFlexObject()
        {
            var ClickSecondSphereThumbExtFlexObject = altDriver.WaitForObject(By.PATH, "/PoseCTL/MBMForeArm(Clone)/Armature/lower arm.R/hand.R/f.thumb1.R/f.thumb2.R/Sphere");
            ClickSecondSphereThumbExtFlexObject.Tap();
        }

        public void ClickSecondSphereThumbExtFlexBtnObject()
        {
            var ClickSecondSphereThumbExtFlexBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Button");
            ClickSecondSphereThumbExtFlexBtnObject.Tap();
        }

        public void MoveSliderSecondSphereThumbExtFlexObject()
        {
            var MoveSliderSecondSphereThumbExtFlexObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderSecondSphereThumbExtFlexObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(1321.878f, 347.2616f), 0.12f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1328.976f, 408.1189f), 0.25f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void ClickThirdSphereThumbExtFlexObject()
        {
            var ClickThirdSphereThumbExtFlexObject = altDriver.WaitForObject(By.PATH, "/PoseCTL/MBMForeArm(Clone)/Armature/lower arm.R/hand.R/f.thumb1.R/Sphere");
            ClickThirdSphereThumbExtFlexObject.Tap();
        }

        public void ClickThirdSphereThumbExtFlexBtnObject()
        {
            var ClickThirdSphereThumbExtFlexBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Button");
            ClickThirdSphereThumbExtFlexBtnObject.Tap();
        }

        public void MoveSliderThirdSphereThumbExtFlexObject()
        {
            var MoveSliderThirdSphereThumbExtFlexObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderThirdSphereThumbExtFlexObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(892.4401f, 350.8414f), 0.12f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(888.891f, 297.1437f), 0.25f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void ClickThirdSphereThumbInversEversBtnObject()
        {
            var ClickThirdSphereThumbInversEversBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)[1]/ButtonAndSlidingPanel/Button");
            ClickThirdSphereThumbInversEversBtnObject.Tap();
        }

        public void MoveSliderThirdSphereThumbInversEversObject()
        {
            var MoveSliderThirdSphereThumbInversEversObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderThirdSphereThumbInversEversObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(1137.326f, 347.2616f), 0.12f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1123.13f, 422.4383f), 0.25f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void ClickThirdSphereThumbAbductAdductBtnObject()
        {
            var ClickThirdSphereThumbAbductAdductBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)[2]/ButtonAndSlidingPanel/Button");
            ClickThirdSphereThumbAbductAdductBtnObject.Tap();
        }

        public void MoveSliderThirdSphereThumbAbductAdductObject()
        {
            var MoveSliderThirdSphereThumbAbductAdductObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderThirdSphereThumbAbductAdductObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(1378.663f, 336.522f), 0.12f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1392.859f, 426.0182f), 0.25f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void ClickFirstSphereIndexExtFlexObject()
        {
            var ClickFirstSphereIndexExtFlexObject = altDriver.WaitForObject(By.PATH, "/PoseCTL/MBMForeArm(Clone)/Armature/lower arm.R/hand.R/palm1.R/f.index1.R/f.index2.R/f.index3.R/Sphere");
            ClickFirstSphereIndexExtFlexObject.Tap();
        }

        public void ClickFirstSphereIndexExtFlexBtnObject()
        {
            var ClickFirstSphereIndexExtFlexBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Button");
            ClickFirstSphereIndexExtFlexBtnObject.Tap();
        }

        public void MoveSliderFirstSphereIndexExtFlexObject()
        {
            var MoveSliderFirstSphereIndexExtFlexObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderFirstSphereIndexExtFlexObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(1325.427f, 375.9003f), 0.12f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1318.329f, 279.2445f), 0.25f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void ClickSecondSphereIndexExtFlexObject()
        {
            var ClickSecondSphereIndexExtFlexObject = altDriver.WaitForObject(By.PATH, "/PoseCTL/MBMForeArm(Clone)/Armature/lower arm.R/hand.R/palm1.R/f.index1.R/f.index2.R/Sphere");
            ClickSecondSphereIndexExtFlexObject.Tap();
        }

        public void ClickSecondSphereIndexExtFlexBtnObject()
        {
            var ClickSecondSphereIndexExtFlexBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Button");
            ClickSecondSphereIndexExtFlexBtnObject.Tap();
        }

        public void MoveSliderSecondSphereIndexExtFlexObject()
        {
            var MoveSliderSecondSphereIndexExtFlexObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderSecondSphereIndexExtFlexObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(1328.976f, 375.9003f), 0.12f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1325.427f, 443.9174f), 0.25f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void ClickThirdSphereIndexExtFlexObject()
        {
            var ClickThirdSphereIndexExtFlexObject = altDriver.WaitForObject(By.PATH, "/PoseCTL/MBMForeArm(Clone)/Armature/lower arm.R/hand.R/palm1.R/f.index1.R/Sphere");
            ClickThirdSphereIndexExtFlexObject.Tap();
        }

        public void ClickThirdSphereIndexExtFlexBtnObject()
        {
            var ClickThirdSphereIndexExtFlexBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Button");
            ClickThirdSphereIndexExtFlexBtnObject.Tap();
        }

        public void MoveSliderThirdSphereIndexExtFlexObject()
        {
            var MoveSliderThirdSphereIndexExtFlexObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderThirdSphereIndexExtFlexObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(1328.976f, 372.3205f), 0.12f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1321.878f, 286.4042f), 0.25f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void ClickFirstSphereMiddleExtFlexObject()
        {
            var ClickFirstSphereMiddleExtFlexObject = altDriver.WaitForObject(By.PATH, "/PoseCTL/MBMForeArm(Clone)/Armature/lower arm.R/hand.R/palm2.R/f.middle1.R/f.middle2.R/f.middle3.R/Sphere");
            ClickFirstSphereMiddleExtFlexObject.Tap();
        }

        public void ClickFirstSphereMiddleExtFlexBtnObject()
        {
            var ClickFirstSphereMiddleExtFlexBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Button");
            ClickFirstSphereMiddleExtFlexBtnObject.Tap();
        }

        public void MoveSliderFirstSphereMiddleExtFlexObject()
        {
            var MoveSliderFirstSphereMiddleExtFlexObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderFirstSphereMiddleExtFlexObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(1325.427f, 375.9003f), 0.12f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1321.878f, 250.6057f), 0.25f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void ClickSecondSphereMiddleExtFlexObject()
        {
            var ClickSecondSphereMiddleExtFlexObject = altDriver.WaitForObject(By.PATH, "/PoseCTL/MBMForeArm(Clone)/Armature/lower arm.R/hand.R/palm2.R/f.middle1.R/f.middle2.R/f.middle3.R/Sphere");
            ClickSecondSphereMiddleExtFlexObject.Tap();
        }

        public void ClickSecondSphereMiddleExtFlexBtnObject()
        {
            var ClickSecondSphereMiddleExtFlexBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Button");
            ClickSecondSphereMiddleExtFlexBtnObject.Tap();
        }

        public void MoveSliderSecondSphereMiddleExtFlexObject()
        {
            var MoveSliderSecondSphereMiddleExtFlexObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderSecondSphereMiddleExtFlexObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(1322.016f, 374.8784f), 0.12f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1332.658f, 278.2752f), 0.25f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void ClickThirdSphereMiddleExtFlexObject()
        {
            var ClickThirdSphereMiddleExtFlexObject = altDriver.WaitForObject(By.PATH, "/PoseCTL/MBMForeArm(Clone)/Armature/lower arm.R/hand.R/palm2.R/f.middle1.R/Sphere");
            ClickThirdSphereMiddleExtFlexObject.Tap();
        }

        public void ClickThirdSphereMiddleExtFlexBtnObject()
        {
            var ClickThirdSphereMiddleExtFlexBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Button");
            ClickThirdSphereMiddleExtFlexBtnObject.Tap();
        }

        public void MoveSliderThirdSphereMiddleExtFlexObject()
        {
            var MoveSliderThirdSphereMiddleExtFlexObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderThirdSphereMiddleExtFlexObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(1322.016f, 367.7227f), 0.12f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1329.111f, 442.8586f), 0.25f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void ClickFirstSphereRingExtFlexObject()
        {
            var ClickFirstSphereRingExtFlexObject = altDriver.WaitForObject(By.PATH, "/PoseCTL/MBMForeArm(Clone)/Armature/lower arm.R/hand.R/palm3.R/f.ring1.R/f.ring2.R/f.ring3.R/Sphere");
            ClickFirstSphereRingExtFlexObject.Tap();
        }

        public void ClickFirstSphereRingExtFlexBtnObject()
        {
            var ClickFirstSphereRingExtFlexBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Button");
            ClickFirstSphereRingExtFlexBtnObject.Tap();
        }

        public void MoveSliderFirstSphereRingExtFlexObject()
        {
            var MoveSliderFirstSphereRingExtFlexObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderFirstSphereRingExtFlexObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(1322.016f, 371.3006f), 0.12f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1329.111f, 260.3857f), 0.25f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void ClickSecondSphereRingExtFlexObject()
        {
            var ClickSecondSphereRingExtFlexObject = altDriver.WaitForObject(By.PATH, "/PoseCTL/MBMForeArm(Clone)/Armature/lower arm.R/hand.R/palm3.R/f.ring1.R/f.ring2.R/Sphere");
            ClickSecondSphereRingExtFlexObject.Tap();
        }

        public void ClickSecondSphereRingExtFlexBtnObject()
        {
            var ClickSecondSphereRingExtFlexBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Button");
            ClickSecondSphereRingExtFlexBtnObject.Tap();
        }

        public void MoveSliderSecondSphereRingExtFlexObject()
        {
            var MoveSliderSecondSphereRingExtFlexObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderSecondSphereRingExtFlexObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(1325.563f, 371.3006f), 0.12f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1325.563f, 274.6973f), 0.25f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void ClickThirdSphereRingExtFlexObject()
        {
            var ClickThirdSphereRingExtFlexObject = altDriver.WaitForObject(By.PATH, "/PoseCTL/MBMForeArm(Clone)/Armature/lower arm.R/hand.R/palm3.R/f.ring1.R/Sphere");
            ClickThirdSphereRingExtFlexObject.Tap();
        }

        public void ClickThirdSphereRingExtFlexBtnObject()
        {
            var ClickThirdSphereRingExtFlexBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Button");
            ClickThirdSphereRingExtFlexBtnObject.Tap();
        }

        public void MoveSliderThirdSphereRingExtFlexObject()
        {
            var MoveSliderThirdSphereRingExtFlexObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderThirdSphereRingExtFlexObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(1325.563f, 367.7227f), 0.12f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1325.563f, 464.326f), 0.25f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void ClickFirstSphereLittleExtFlexObject()
        {
            var ClickFirstSphereLittleExtFlexObject = altDriver.WaitForObject(By.PATH, "/PoseCTL/MBMForeArm(Clone)/Armature/lower arm.R/hand.R/palm4.R/f.pinky1.R/f.pinky2.R/f.pinky3.R/Sphere");
            ClickFirstSphereLittleExtFlexObject.Tap();
        }

        public void ClickFirstSphereLittleExtFlexBtnObject()
        {
            var ClickFirstSphereLittleExtFlexBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Button");
            ClickFirstSphereLittleExtFlexBtnObject.Tap();
        }

        public void MoveSliderFirstSphereLittleExtFlexObject()
        {
            var MoveSliderFirstSphereLittleExtFlexObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderFirstSphereLittleExtFlexObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(1329.111f, 367.7227f), 0.12f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1318.468f, 249.652f), 0.25f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void ClickSecondSphereLittleExtFlexObject()
        {
            var ClickSecondSphereLittleExtFlexObject = altDriver.WaitForObject(By.PATH, "/PoseCTL/MBMForeArm(Clone)/Armature/lower arm.R/hand.R/palm4.R/f.pinky1.R/f.pinky2.R/Sphere");
            ClickSecondSphereLittleExtFlexObject.Tap();
        }

        public void ClickSecondSphereLittleExtFlexBtnObject()
        {
            var ClickSecondSphereLittleExtFlexBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Button");
            ClickSecondSphereLittleExtFlexBtnObject.Tap();
        }

        public void MoveSliderSecondSphereLittleExtFlexObject()
        {
            var MoveSliderSecondSphereLittleExtFlexObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderSecondSphereLittleExtFlexObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(1322.016f, 367.1447f), 0.12f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1325.563f, 285.431f), 0.25f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void ClickThirdSphereLittleExtFlexObject()
        {
            var ClickThirdSphereLittleExtFlexObject = altDriver.WaitForObject(By.PATH, "/PoseCTL/MBMForeArm(Clone)/Armature/lower arm.R/hand.R/palm4.R/f.pinky1.R/Sphere");
            ClickThirdSphereLittleExtFlexObject.Tap();
        }

        public void ClickThirdSphereLittleExtFlexBtnObject()
        {
            var ClickThirdSphereLittleExtFlexBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Button");
            ClickThirdSphereLittleExtFlexBtnObject.Tap();
        }

        public void MoveSliderThirdSphereLittleExtFlexObject()
        {
            var MoveSliderThirdSphereLittleExtFlexObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderThirdSphereLittleExtFlexObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(1329.111f, 374.8784f), 0.12f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1329.111f, 464.326f), 0.25f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void ClickHandSphereObject()
        {
            var ClickHandSphereObject = altDriver.WaitForObject(By.PATH, "/PoseCTL/MBMForeArm(Clone)/Armature/lower arm.R/hand.R/Sphere");
            ClickHandSphereObject.Tap();
        }

        public void ClickHandSphereExtFlexBtnObject()
        {
            var ClickThirdSphereLittleExtFlexBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)[1]/ButtonAndSlidingPanel/Button");
            ClickThirdSphereLittleExtFlexBtnObject.Tap();
        }

        public void MoveSliderHandSphereExtFlexObject()
        {
            var MoveSliderHandSphereExtFlexObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)[1]/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderHandSphereExtFlexObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(1353.943f, 378.4564f), 0.12f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1364.585f, 278.2752f), 0.25f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void ClickHandSphereAbducAdducBtnObject()
        {
            var ClickHandSphereAbducAdducBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Button");
            ClickHandSphereAbducAdducBtnObject.Tap();
        }

        public void MoveSliderHandSphereAbducAdducObject()
        {
            var MoveSliderHandSphereAbducAdducObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderHandSphereAbducAdducObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(1063.053f, 292.5868f), 0.12f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1080.79f, 378.4564f), 0.25f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }


        // THUMB LEVEL OBJECT //

        public void ClickThumbBtnMainViewObject()
        {
            var ClickThumbBtnMainViewObject = altDriver.WaitForObject(By.PATH, "/Canvas/MainMenu(Clone)/MainMenuBtn(Clone)[2]");
            ClickThumbBtnMainViewObject.Tap();
        }

        public void ClickCrossBtnThumbObject()
        {
            var ClickCrossBtnThumbObject = altDriver.WaitForObject(By.PATH, "/ThumbCTL/LMRunPlacementStep/LMRunPlacementStepPanel/Canvas/SubStepPrevButton/Forma Button v3 Tools");
            ClickCrossBtnThumbObject.Tap();
        }

        public void ClickTickBtnThumbObject()
        {
            var ClickTickBtnThumbObject = altDriver.WaitForObject(By.PATH, "/ThumbCTL/LMRunPlacementStep/LMRunPlacementStepPanel/Canvas/SubStepNextButton/Forma Button v3 Tools/Icon");
            ClickTickBtnThumbObject.Tap();
        }

        public void ClickBackArrowBtnThumbObject()
        {
            var ClickBackArrowBtnThumbObject = altDriver.WaitForObject(By.PATH, "/ThumbCTL/LMRunPlacementStep/LMRunPlacementStepPanel/Canvas/SubStepPrevButton/Forma Button v3 Tools");
            ClickBackArrowBtnThumbObject.Tap();
        }

        public void ClickPreviousStepBtnThumbObject()
        {
            var ClickPreviousStepBtnThumbObject = altDriver.WaitForObject(By.PATH, "/Canvas/Navigation Buttons Panel/NavPrev Step/Forma Button v3 Contextual");
            ClickPreviousStepBtnThumbObject.Tap();
        }

        public void ClickEditBtnThumbObject()
        {
            var ClickEditBtnThumbObject = altDriver.WaitForObject(By.PATH, "/Canvas/ThumbEditorPanel(Clone)/DisplayCircSliderSwitch/Background/Switch button/icon left");
            ClickEditBtnThumbObject.Tap();
        }

        public void ClickCircumferenceBtnThumbObject()
        {
            var ClickCircumferenceBtnThumbObject = altDriver.WaitForObject(By.PATH, "/Canvas/ThumbEditorPanel(Clone)/ExtensibleCircumferenceSlider/ButtonAndSlidingPanel/Button");
            ClickCircumferenceBtnThumbObject.Tap();
        }

        public void MoveSliderCircToMinThumbObject()
        {
            var MoveSliderCircToMinThumbObject = altDriver.WaitForObject(By.PATH, "/Canvas/ThumbEditorPanel(Clone)/ExtensibleCircumferenceSlider/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area");
            var startPosition = MoveSliderCircToMinThumbObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(1092.88f, 324.5237f), 0.12f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1092.88f, 193.672f), 0.25f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void MoveSliderCircToMaxThumbObject()
        {
            var MoveSliderCircToMaxThumbObject = altDriver.WaitForObject(By.PATH, "/Canvas/ThumbEditorPanel(Clone)/ExtensibleCircumferenceSlider/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area");
            var startPosition = MoveSliderCircToMaxThumbObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(1096.478f, 215.4806f), 0.12f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1092.88f, 466.2798f), 0.25f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void ClickResetSliderBtnThumbObject()
        {
            var ClickResetSliderBtnThumbObject = altDriver.WaitForObject(By.PATH, "/Canvas/ThumbEditorPanel(Clone)/ResetButton");
            ClickResetSliderBtnThumbObject.Tap();
        }

        public void ClickValidateBtnThumbObject()
        {
            var ClickValidateBtnThumbObject = altDriver.WaitForObject(By.PATH, "/Canvas/Navigation Buttons Panel/NavNext Step/Forma Button v3 Contextual");
            ClickValidateBtnThumbObject.Tap();
        }

        // SCULPT LEVEL //

        public void ClickSculptBtnMainViewObject()
        {
            var ClickSculptBtnMainViewObject = altDriver.WaitForObject(By.PATH, "/Canvas/MainMenu(Clone)/MainMenuBtn(Clone)[3]");
            ClickSculptBtnMainViewObject.Tap();
        }

        public void ClickFirstOnMeshToActivateDrawingSculptObject()
        {
            var ClickFirstOnMeshToActivateDrawingSculptObject = altDriver.WaitForObject(By.PATH, "/StatusMN/scanClean");
            ClickFirstOnMeshToActivateDrawingSculptObject.Tap();
        }


        public void FirstPullOnMeshSculptObject()
        {

            altDriver.MoveMouse(new AltVector2(487.4975f, 791.1719f), 1);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1078.836f, 787.5574f), 4);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void SecondPullOnMeshSculptObject()
        {
            altDriver.MoveMouse(new AltVector2(491.0813f, 675.5082f), 1);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(960.5682f, 682.7372f), 4);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void ClickUndoBtnSculptObject()
        {
            var ClickUndoBtnSculptObject = altDriver.WaitForObject(By.PATH, "/Canvas/UndoRedoPan(Clone)/Undo Button");
            ClickUndoBtnSculptObject.Tap();
        }

        public void ClickRedoBtnSculptObject()
        {
            var ClickRedoBtnSculptObject = altDriver.WaitForObject(By.PATH, "/Canvas/UndoRedoPan(Clone)/Redo Button");
            ClickRedoBtnSculptObject.Tap();
        }

        public void ClickBrushDiameterBtnSculptObject()
        {
            var ClickBrushDiameterBtnSculptObject = altDriver.WaitForObject(By.PATH, "/Canvas/SculptUI(Clone)/InteractiveUIRoot/BrushSlider/ExtensibleSlider/ButtonAndSlidingPanel/Button");
            ClickBrushDiameterBtnSculptObject.Tap();
        }

        public void MoveSliderBrushDiameterSculptObject()
        {
            var MoveSliderBrushDiameterSculptObject = altDriver.WaitForObject(By.PATH, "/Canvas/SculptUI(Clone)/InteractiveUIRoot/BrushSlider/ExtensibleSlider/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area");
            var startPosition = MoveSliderBrushDiameterSculptObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(729.5944f, 213.873f), 0.12f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(718.9521f, 460.748f), 0.25f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void MoveSliderBrushDiameterToMinSculptObject()
        {
            var MoveSliderBrushDiameterToMinSculptObject = altDriver.WaitForObject(By.PATH, "/Canvas/SculptUI(Clone)/InteractiveUIRoot/BrushSlider/ExtensibleSlider/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area");
            var startPosition = MoveSliderBrushDiameterToMinSculptObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(1082.085f, 280.9065f), 0.12f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1078.487f, 211.8458f), 0.25f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void ClickPullPushBtnSculptObject()
        {
            var ClickPullPushBtnSculptObject = altDriver.WaitForObject(By.PATH, "/Canvas/SculptUI(Clone)/InteractiveUIRoot/Pull Push  Switch/Background/Switch button");
            ClickPullPushBtnSculptObject.Tap();
        }

        public void FirstPushOnMeshSculptObject()
        {
            altDriver.MoveMouse(new AltVector2(580.6781f, 881.5341f), 1);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(971.3198f, 899.6065f), 4);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void SecondPushOnMeshSculptObject()
        {
            altDriver.MoveMouse(new AltVector2(552.0071f, 744.1835f), 1);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(942.6488f, 765.8704f), 4);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void ClickEraseBtnSculptObject()
        {
            var ClickEraseBtnSculptObject = altDriver.WaitForObject(By.PATH, "/Canvas/SculptUI(Clone)/InteractiveUIRoot/Tools/Button Erase");
            ClickEraseBtnSculptObject.Tap();
        }

        public void EraseAreaOnMeshSculptObject()
        {
            altDriver.MoveMouse(new AltVector2(580.6781f, 881.5341f), 1);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(971.3198f, 899.6065f), 4);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void MoveSliderEraserDiameterSculptObject()
        {
            var MoveSliderEraserDiameterSculptObject = altDriver.WaitForObject(By.PATH, "/Canvas/SculptUI(Clone)/InteractiveUIRoot/BrushSlider/ExtensibleSlider/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderEraserDiameterSculptObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(1078.836f, 259.8422f), 0.12f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1082.42f, 357.4334f), 0.25f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void ClickLimitValueBtnSculptObject()
        {
            var ClickLimitValueBtnSculptObject = altDriver.WaitForObject(By.PATH, "/Canvas/SculptUI(Clone)/InteractiveUIRoot/Limit Value/ButtonAndSlidingPanel/Button");
            ClickLimitValueBtnSculptObject.Tap();
        }

        public void MoveSliderLimitValueSculptObject()
        {
            altDriver.MoveMouse(new AltVector2(1329.707f, 306.8306f), 1);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1329.707f, 136.9497f), 1);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void ClickOnBrushBtnSculptObject()
        {
            var ClickOnBrushBtnSculptObject = altDriver.WaitForObject(By.PATH, "/Canvas/SculptUI(Clone)/InteractiveUIRoot/Tools/Button Sculpt");
            ClickOnBrushBtnSculptObject.Tap();
        }

        public void CheckLimitValuePullPushSculptObject()
        {
            altDriver.MoveMouse(new AltVector2(552.0071f, 744.1835f), 1);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(942.6488f, 765.8704f), 4);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void ClickNextStepBtnSculptObject()
        {
            var ClickNextStepBtnSculptObject = altDriver.WaitForObject(By.PATH, "/Canvas/Navigation Buttons Panel/NavNext Step/Forma Button v3 Contextual");
            ClickNextStepBtnSculptObject.Tap();
        }

        public void ClickPreviousStepBtnSculptObject()
        {
            var ClickPreviousStepBtnSculptObject = altDriver.WaitForObject(By.PATH, "/Canvas/Navigation Buttons Panel/NavPrev Step/Forma Button v3 Contextual");
            ClickPreviousStepBtnSculptObject.Tap();
        }

        public void ClickFlattenToolBtnSculptObject()
        {
            var ClickFlattenToolBtnSculptObject = altDriver.WaitForObject(By.PATH, "/Canvas/SculptUI(Clone)/InteractiveUIRoot/Tools/Button Level");
            ClickFlattenToolBtnSculptObject.Tap();
        }

        public void MoveFlattenToolSculptObject()
        {
            altDriver.MoveMouse(new AltVector2(491.0813f, 675.5082f), 1);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(960.5682f, 682.7372f), 4);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void ClickFillValleyToolBtnSculptObject()
        {
            var ClickFillValleyToolBtnSculptObject = altDriver.WaitForObject(By.PATH, "/Canvas/SculptUI(Clone)/InteractiveUIRoot/Tools/Button Flatten");
            ClickFillValleyToolBtnSculptObject.Tap();
        }

        public void MoveFillValleyToolBtnSculptObject()
        {
            altDriver.MoveMouse(new AltVector2(552.0071f, 744.1835f), 1);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(942.6488f, 765.8704f), 4);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void ClickValidateBtnSculptObject()
        {
            var ClickValidateBtnSculptObject = altDriver.WaitForObject(By.PATH, "/Canvas/Navigation Buttons Panel/NavNext Step/Forma Button v3 Contextual");
            ClickValidateBtnSculptObject.Tap();
        }

    }
}