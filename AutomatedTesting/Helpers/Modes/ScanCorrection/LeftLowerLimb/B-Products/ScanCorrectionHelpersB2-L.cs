using System;
using AltTester.AltTesterUnitySDK.Driver;
using NUnit.Framework;
using System.Threading;

public partial class FullScanCorrectionB2L
{
    public class ScanCorrectionHelpersB2L
    {
        private AltDriver altDriver;

        public ScanCorrectionHelpersB2L(AltDriver driver)
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
        public const string SelectPartOfScanCropOffText = "Select the part of the scan you want to crop off";
        public const string ThumbTipText = "Thumb tip";
        public const string CheckTheLimbPoseText = "Check the limb pose and modify if needed";
        public const string NormalAppearanceText = "Normal";
        public const string TransparentAppearanceText = "Transparent";
        public const string NeutralGhostAppearanceText = "Neutral ghost";
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
        public void ClickSelectPartOfInterestLegLeftB2() => Click(1008.888f, 973.449f);
        public void ClickMedialMalleolusCenterCleanupLandmark() => Click(1263.994f, 648.8466f);
        public void ClickTibiaMidCleanupLandmark() => Click(1088.847f, 863.9677f);
        public void ClickMetatarsusFirstBonePoseLandmark() => Click(715.7073f, 662.2916f);
        public void ClickFirstToePoseLandmark() => Click(1399.162f, 742.962f);
        public void ClickSecondToePoseLandmark() => Click(1332.53f, 708.389f);
        public void ClickThirdToePoseLandmark() => Click(1281.128f, 706.4683f);
        public void ClickFourthToePoseLandmark() => Click(1222.111f, 687.261f);
        public void ClickFifthToePoseLandmark() => Click(1166.902f, 669.9745f);
        public void ClickMetatarsusFifthBonePoseLandmark() => Click(1185.939f, 637.3222f);
        public void ClickLateralMalleolusCenterPoseLandmark() => Click(1026.022f, 789.0594f);
        public void ClickCalcaneusCenterPoseLandmark() => Click(1185.939f, 741.0413f);
        public void ReplaceMedialMalleolusCenterCleanupLandmark() => Click(1140.249f, 806.3459f);
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

        // CLEANUP LEVEL OBJECT // 


        public void FindMaterial()
        {
            var FindMaterial = altDriver.FindObjectWhichContains(By.PATH, "/Canvas/BackToOrderPan/Button Navigation/Text (1)");
           // Assert.AreEqual("PP", FindMaterial.name);
        }
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
            Move(1153.575f, 552.8103f, 1142.153f, 1077.168f);
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

        public void ClickTickBtnPoseObject()
        {
            var ClickTickBtnPoseObject = altDriver.WaitForObject(By.PATH, "/PoseCTL/LMRunPlacementStep/LMRunPlacementStepPanel/Canvas/SubStepNextButton/Forma Button v3 Tools/Icon");
            ClickTickBtnPoseObject.Tap();
        }

        public void ClickCrossBtnPoseObject()
        {
            var ClickCrossBtnPoseObject = altDriver.WaitForObject(By.PATH, "/PoseCTL/LMRunPlacementStep/LMRunPlacementStepPanel/Canvas/SubStepPrevButton/Forma Button v3 Tools/Icon");
            ClickCrossBtnPoseObject.Tap();
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
            var ClickValidateBtnPoseObject = altDriver.WaitForObject(By.PATH, "/Canvas/Navigation Buttons Panel/NavNext Step/Forma Button v3 Contextual/Text");
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
            altDriver.MoveMouse(new AltVector2(889.2289f, 339.0995f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(892.7763f, 482.2155f), 0.5f);
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
            altDriver.MoveMouse(new AltVector2(1137.549f, 356.989f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1141.097f, 231.7625f), 0.5f);
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
            altDriver.MoveMouse(new AltVector2(1382.322f, 339.0995f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1389.417f, 428.547f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void ClickAppearanceBtnObject()
        {
            var ClickAppearanceBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/MatDropDown/ButtonAndLabels/Button");
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

        public void ClickFirstSphereFootObject()
        {
            var ClickFirstSphereFootObject = altDriver.WaitForObject(By.PATH, "/PoseCTL/MBMFoot(Clone)/Armature/Shin/FootConnector/Foot/Sphere");
            ClickFirstSphereFootObject.Tap();
        }

        public void ClickFirstSphereFootInvEverBtnObject()
        {
            var ClickFirstSphereFootInvEverBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Button");
            ClickFirstSphereFootInvEverBtnObject.Tap();
        }

        public void MoveSliderFirstSphereFootInvEverObject()
        {
            var MoveSliderFirstSphereFootInvEverObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderFirstSphereFootInvEverObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(841.3564f, 339.6099f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(843.2602f, 445.2497f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void ClickFirstSphereFootPlantarDorsalBtnObject()
        {
            var ClickFirstSphereFootPlantarDorsalBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)[1]/ButtonAndSlidingPanel/Button");
            ClickFirstSphereFootPlantarDorsalBtnObject.Tap();
        }

        public void MoveSliderFirstSphereFootPlantarDorsalObject()
        {
            var MoveSliderFirstSphereFootPlantarDorsalObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)[1]/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderFirstSphereFootPlantarDorsalObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(1109.788f, 320.4026f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1111.692f, 449.0912f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void ClickFirstSphereFootTwistLeftRightBtnObject()
        {
            var ClickFirstSphereFootTwistLeftRightBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)[2]/ButtonAndSlidingPanel/Button");
            ClickFirstSphereFootTwistLeftRightBtnObject.Tap();
        }

        public void MoveSliderFirstSphereFootTwistLeftRightObject()
        {
            var MoveSliderFirstSphereFootTwistLeftRightObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)[2]/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderFirstSphereFootTwistLeftRightObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(1374.413f, 335.7684f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1374.413f, 454.8534f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void ClickSecondSphereFootObject()
        {
            var ClickSecondSphereFootObject = altDriver.WaitForObject(By.PATH, "/PoseCTL/MBMFoot(Clone)/Armature/Shin/FootConnector/Foot/FootControl1/Sphere");
            ClickSecondSphereFootObject.Tap();
        }

        public void ClickSecondSphereFootAbductAdductBtnObject()
        {
            var ClickSecondSphereFootAbductAdductBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Button");
            ClickSecondSphereFootAbductAdductBtnObject.Tap();
        }

        public void MoveSliderSecondSphereFootAbductAdductBtnObject()
        {
            var MoveSliderSecondSphereFootAbductAdductBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderSecondSphereFootAbductAdductBtnObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(1035.541f, 337.6891f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1033.637f, 456.7741f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void ClickSecondSphereFootTwistLeftRightBtnObject()
        {
            var ClickSecondSphereFootTwistLeftRightBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)[1]/ButtonAndSlidingPanel/Button");
            ClickSecondSphereFootTwistLeftRightBtnObject.Tap();
        }

        public void MoveSliderSecondSphereFootTwistLeftRightBtnObject()
        {
            var MoveSliderSecondSphereFootTwistLeftRightBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)[1]/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderSecondSphereFootTwistLeftRightBtnObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(1345.856f, 339.6099f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1347.76f, 470.2191f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void ClickThirdSphereFootObject()
        {
            var ClickThirdSphereFootObject = altDriver.WaitForObject(By.PATH, "/PoseCTL/MBMFoot(Clone)/Armature/Shin/FootConnector/Foot/FootControl1/FootControl2/Sphere");
            ClickThirdSphereFootObject.Tap();
        }

        public void ClickThirdSphereFootRaiseLowerBtnObject()
        {
            var ClickThirdSphereFootRaiseLowerBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Button");
            ClickThirdSphereFootRaiseLowerBtnObject.Tap();
        }

        public void MoveSliderThirdSphereFootRaiseLowerBtnObject()
        {
            var MoveSliderThirdSphereFootRaiseLowerBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderThirdSphereFootRaiseLowerBtnObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(1288.743f, 345.372f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1286.839f, 462.5363f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void ClickFourthSphereFootObject()
        {
            var ClickFourthSphereFootObject = altDriver.WaitForObject(By.PATH, "/PoseCTL/MBMFoot(Clone)/Armature/Shin/FootConnector/Foot/FootControl1/FootControl2/Toes/Sphere");
            ClickFourthSphereFootObject.Tap();
        }

        public void ClickFourthSphereFootExtFlexBtnObject()
        {
            var ClickFourthSphereFootExtFlexBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Button");
            ClickFourthSphereFootExtFlexBtnObject.Tap();
        }

        public void MoveSliderFourthSphereFootExtFlexBtnObject()
        {
            var MoveSliderFourthSphereFootExtFlexBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderFourthSphereFootExtFlexBtnObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(1288.743f, 341.5306f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1284.936f, 474.0606f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        // SCULPT LEVEL //

        public void ClickSculptBtnMainViewObject()
        {
            var ClickSculptBtnMainViewObject = altDriver.WaitForObject(By.PATH, "/Canvas/MainMenu(Clone)/MainMenuBtn(Clone)[2]");
            ClickSculptBtnMainViewObject.Tap();
        }

        public void ClickFirstOnMeshToActivateDrawingSculptObject()
        {
            var ClickFirstOnMeshToActivateDrawingSculptObject = altDriver.WaitForObject(By.PATH, "/StatusMN/scanClean");
            ClickFirstOnMeshToActivateDrawingSculptObject.Tap();
        }


        public void FirstPullOnMeshSculptObject()
        {
            altDriver.MoveMouse(new AltVector2(917.5073f, 1319.179f), 1);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(904.1809f, 956.1625f), 2);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void SecondPullOnMeshSculptObject()
        {
            altDriver.MoveMouse(new AltVector2(1088.847f, 1307.655f), 1);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1050.771f, 950.4003f), 2);
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
            altDriver.MoveMouse(new AltVector2(1078.836f, 259.8422f), 1);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1082.42f, 357.4334f), 2);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void MoveSliderBrushDiameterToMinSculptObject()
        {
            var MoveSliderBrushDiameterToMinSculptObject = altDriver.WaitForObject(By.PATH, "/Canvas/SculptUI(Clone)/InteractiveUIRoot/BrushSlider/ExtensibleSlider/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area");
            var startPosition = MoveSliderBrushDiameterToMinSculptObject.GetScreenPosition();
            Move(1088.847f, 322.3234f, 1088.847f, 381.8658f);
        }

        public void ClickPullPushBtnSculptObject()
        {
            var ClickPullPushBtnSculptObject = altDriver.WaitForObject(By.PATH, "/Canvas/SculptUI(Clone)/InteractiveUIRoot/Pull Push  Switch/Background/Switch button");
            ClickPullPushBtnSculptObject.Tap();
        }

        public void ClickOnAxisAntiZSculptObject()
        {
            var ClickOnAxisAntiZSculptObject = altDriver.WaitForObject(By.PATH, "/Canvas/Compass3D/AntiZBar/AntiZ");
            ClickOnAxisAntiZSculptObject.Tap();
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

        public void ClickOnAxisZObject()
        {
            var ClickOnAxisZObject = altDriver.WaitForObject(By.PATH, "/Canvas/Compass3D/ZBar/Z/ZLabel");
            ClickOnAxisZObject.Tap();
        }

        public void FirstPushOnMeshSculptObject()
        {
            altDriver.MoveMouse(new AltVector2(1081.232f, 1238.509f), 1);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1105.981f, 925.4308f), 2);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void SecondPushOnMeshSculptObject()
        {
            altDriver.MoveMouse(new AltVector2(1204.977f, 1273.082f), 1);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1227.822f, 931.1931f), 2);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void ClickEraseBtnSculptObject()
        {
            var ClickEraseBtnSculptObject = altDriver.WaitForObject(By.PATH, "/Canvas/SculptUI(Clone)/InteractiveUIRoot/Tools/Button Erase");
            ClickEraseBtnSculptObject.Tap();
        }

        public void EraseAreaOnMeshSculptObject()
        {
            altDriver.MoveMouse(new AltVector2(1204.977f, 1273.082f), 1);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1227.822f, 931.1931f), 2);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void MoveSliderEraserDiameterSculptObject()
        {
            var MoveSliderEraserDiameterSculptObject = altDriver.WaitForObject(By.PATH, "/Canvas/SculptUI(Clone)/InteractiveUIRoot/BrushSlider/ExtensibleSlider/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderEraserDiameterSculptObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(1078.836f, 259.8422f), 1);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1082.42f, 357.4334f), 2);
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
            altDriver.MoveMouse(new AltVector2(1329.707f, 136.9497f), 2);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void ClickOnBrushBtnSculptObject()
        {
            var ClickOnBrushBtnSculptObject = altDriver.WaitForObject(By.PATH, "/Canvas/SculptUI(Clone)/InteractiveUIRoot/Tools/Button Sculpt");
            ClickOnBrushBtnSculptObject.Tap();
        }

        public void CheckLimitValuePullPushSculptObject()
        {
            altDriver.MoveMouse(new AltVector2(1203.073f, 792.9009f), 1);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1225.919f, 633.4807f), 2);
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
            altDriver.MoveMouse(new AltVector2(1204.977f, 1273.082f), 1);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1227.822f, 931.1931f), 2);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void ClickFillValleyToolBtnSculptObject()
        {
            var ClickFillValleyToolBtnSculptObject = altDriver.WaitForObject(By.PATH, "/Canvas/SculptUI(Clone)/InteractiveUIRoot/Tools/Button Flatten");
            ClickFillValleyToolBtnSculptObject.Tap();
        }

        public void MoveFillValleyToolBtnSculptObject()
        {
            altDriver.MoveMouse(new AltVector2(1081.232f, 1238.509f), 1);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1105.981f, 925.4308f), 2);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void ClickValidateBtnSculptObject()
        {
            var ClickValidateBtnSculptObject = altDriver.WaitForObject(By.PATH, "/Canvas/Navigation Buttons Panel/NavNext Step/Forma Button v3 Contextual");
            ClickValidateBtnSculptObject.Tap();
        }

    }
}