using System;
using AltTester.AltTesterUnitySDK.Driver;
using NUnit.Framework;
using System.Threading;

namespace AutomatedTesting.Helpers.CommonHelpers
{
    public static class Helpers
    {
        private static AltDriver altDriver;

        /// <summary>
        /// Initializes the AltDriver instance.
        /// </summary>
        /// <param name="driver">The AltDriver instance to be used.</param>
        public static void Initialize(AltDriver driver)
        {
            altDriver = driver;
        }

        #region Touch Interaction Methods

        /// <summary>
        /// Simulates a touch click at the specified coordinates.
        /// </summary>
        public static void Click(float x, float y)
        {
            altDriver.BeginTouch(new AltVector2(x, y));
            altDriver.EndTouch(1);
        }

        /// <summary>
        /// Simulates a touch move from start coordinates to end coordinates.
        /// </summary>
        public static void Move(float startX, float startY, float endX, float endY)
        {
            altDriver.BeginTouch(new AltVector2(startX, startY));
            altDriver.MoveTouch(1, new AltVector2(endX, endY));
            altDriver.EndTouch(1);
        }

        /// <summary>
        /// Performs a specified click action a given number of times.
        /// </summary>
        /// <param name="clickAction">The action to perform.</param>
        /// <param name="repetitions">The number of repetitions.</param>
        public static void PerformRepeatedClicks(Action clickAction, int repetitions)
        {
            for (int i = 0; i < repetitions; i++)
            {
                clickAction();
            }
        }

        #endregion

        #region Text Verification Methods

        /// <summary>
        /// Finds and returns the text of an object by its path.
        /// </summary>
        /// <param name="path">The path of the object.</param>
        /// <returns>The text of the object.</returns>
        public static string FindTextByPath(string path)
        {
            return altDriver.FindObject(By.PATH, path).GetText();
        }

        /// <summary>
        /// Verifies that the text at the given path matches the expected text.
        /// </summary>
        /// <param name="path">The path of the object.</param>
        /// <param name="expectedText">The expected text.</param>
        public static void VerifyAndAssertText(string path, string expectedText)
        {
            string foundText = FindTextByPath(path);
            Assert.That(foundText, Is.EqualTo(expectedText));
        }

        /// <summary>
        /// Verifies that the text at the given path contains the specified product code.
        /// </summary>
        /// <param name="path">The path of the object.</param>
        /// <param name="productCode">The product code to look for.</param>
        public static void VerifyTextContainsProductCode(string path, string productCode)
        {
            var textObject = altDriver.FindObject(By.PATH, path);
            string text = textObject.GetText();
            Assert.IsTrue(text.Contains(productCode), $"The text does not contain '{productCode}'.");
        }

        #endregion

        #region Text To Verify 

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

        #endregion

        #region Loading Screen Methods

        /// <summary>
        /// Waits until the loading panel is no longer present.
        /// </summary>
        public static void BeingProcessed()
        {
            altDriver.WaitForObjectNotBePresent(By.PATH, "/Canvas/Loading Panel");
        }

        #endregion

        #region Popup Methods
        public static void ClickConfirmBtnPopUpObject()
        {
            var ClickConfirmBtnPopUpObject = altDriver.WaitForObject(By.PATH, "/Canvas/WarnPopup(Clone)/Forma Info Panel v3/Content/Bottom Container/Do it btn/Text");
            ClickConfirmBtnPopUpObject.Tap();
        }

        public static void ClickKeepBtnLandmarksPopUpObject()
        {
            var ClickKeepBtnLandmarksPopUpObject = altDriver.WaitForObject(By.PATH, "/Canvas/Popup(Clone)/Content/Bottom Container/Confirm button");
            ClickKeepBtnLandmarksPopUpObject.Tap();
        }
        #endregion


/// SCAN CORRECTION MODE HELPERS 

        #region Scan Correction Mode

        #region Scan correction - Screen Coordinates Methods - Upper limbs

        public static void ClickSelectPartOfInterestArmRightA2() => Click(996.2365f, 686.395f);
        public static void ClickWristCreaseCenterCleanupLandmark() => Click(843.1122f, 646.7988f);
        public static void ClickVentralArmCleanupLandmark() => Click(1084.338f, 632.4872f);
        public static void ClickThumbTipLandmark() => Click(1038.221f, 850.7391f);
        public static void ClickDistalEndIndexLandmark() => Click(1094.98f, 875.7844f);
        public static void ClickDistalMiddleFingerLandmark() => Click(1137.549f, 829.2717f);
        public static void ClickDistalRingFingerLandmark() => Click(1102.075f, 761.2916f);
        public static void ClickDistalLittleFingerLandmark() => Click(1215.593f, 757.7137f);
        public static void ClickThumbMetacarpalLandmark() => Click(1112.717f, 897.2518f);
        public static void ClickIndexMetacarpalLandmark() => Click(1102.075f, 922.2971f);
        public static void ClickMiddleMetacarpalLandmark() => Click(1087.885f, 915.1413f);
        public static void ClickRingMetacarpalLandmark() => Click(1080.79f, 911.5634f);
        public static void ClickLittleMetacarpalLandmark() => Click(1048.863f, 897.2518f);
        public static void ClickCreaseCenterMetacarpalLandmark() => Click(928.2506f, 861.4728f);
        public static void ClickMedialBorderMetacarpalLandmark() => Click(1070.148f, 807.8043f);
        public static void ClickWristCreaseCenterLandmark() => Click(1077.243f, 818.538f);
        public static void ClickThumbInterPhalangealLandmark() => Click(1066.6f, 1094.036f);
        public static void ClickThumbMetaPhalangealLandmark() => Click(1109.17f, 890.096f);
        public static void ClickFirstInterdigitalLandmark() => Click(903.4186f, 968.8098f);
        public static void ClickFirstOnMeshToActivateDrawing() => Click(487.4975f, 791.1719f);

        #endregion

        #region Scan Correction - Screen Coordinates Methods - Lower limbs

        public static void ClickSelectPartOfInterestLegRightB2() => Click(989.8507f, 986.894f);
        public static void ClickMedialMalleolusCenterCleanupLandmark() => Click(1258.283f, 625.7979f);
        public static void ClickTibiaMidCleanupLandmark() => Click(1077.424f, 873.5713f);
        public static void ClickMetatarsusFirstBonePoseLandmark() => Click(1182.132f, 639.2429f);
        public static void ClickFirstToePoseLandmark() => Click(1399.162f, 742.962f);
        public static void ClickSecondToePoseLandmark() => Click(1332.53f, 708.389f);
        public static void ClickThirdToePoseLandmark() => Click(1281.128f, 706.4683f);
        public static void ClickFourthToePoseLandmark() => Click(1222.111f, 687.261f);
        public static void ClickFifthToePoseLandmark() => Click(1166.902f, 669.9745f);
        public static void ClickMetatarsusFifthBonePoseLandmark() => Click(1185.939f, 637.3222f);
        public static void ClickLateralMalleolusCenterPoseLandmark() => Click(1026.022f, 789.0594f);
        public static void ClickCalcaneusCenterPoseLandmark() => Click(1185.939f, 741.0413f);
        public static void ReplaceMedialMalleolusCenterCleanupLandmark() => Click(1140.249f, 806.3459f);
        //public static void ClickFirstOnMeshToActivateDrawing() => Click(487.4975f, 791.1719f);

        #endregion

        #region Scan Correction - Cleanup Methods

        public static void ClickCleanupBtnMainViewObject()
        {
            var clickCleanupBtnMainView = altDriver.WaitForObject(By.PATH, "/Canvas/MainMenu(Clone)/MainMenuBtn(Clone)/Text");
            clickCleanupBtnMainView.Tap();
        }

        public static void ClickQuitBtnObject()
        {
            var ClickQuitBtn = altDriver.WaitForObject(By.PATH, "/Cleanup/LevelNavigationPanel(Clone)/Canvas/NavPrev Step/Forma Button v3 Contextual/Text");
            ClickQuitBtn.Tap();
        }

        public static void ClickNextStepBtnObject()
        {
            var ClickNextStepBtnObject = altDriver.WaitForObject(By.PATH, "/Cleanup/LevelNavigationPanel(Clone)/Canvas/NavNext Step/Forma Button v3 Contextual");
            ClickNextStepBtnObject.Tap();
        }

        public static void ClickPreviousStepBtnObject()
        {
            var ClickPreviousStepBtnObject = altDriver.WaitForObject(By.PATH, "/Cleanup/LevelNavigationPanel(Clone)/Canvas/NavPrev Step/Forma Button v3 Contextual");
            ClickPreviousStepBtnObject.Tap();
        }

        public static void ClickCrossBtnObject()
        {
            var ClickCrossBtnObject = altDriver.WaitForObject(By.PATH, "/Cleanup/LMRunPlacementStep(Clone)/LMRunPlacementStepPanel/Canvas/SubStepPrevButton/Forma Button v3 Tools");
            ClickCrossBtnObject.Tap();
        }

        public static void ClickTickBtnObject()
        {
            var ClickTickBtnObject = altDriver.WaitForObject(By.PATH, "/Cleanup/LMRunPlacementStep(Clone)/LMRunPlacementStepPanel/Canvas/SubStepNextButton/Forma Button v3 Tools");
            ClickTickBtnObject.Tap();
        }

        public static void ClickBackArrowBtnObject()
        {
            var ClickBackArrowBtnObject = altDriver.WaitForObject(By.PATH, "/Cleanup/LMRunPlacementStep(Clone)/LMRunPlacementStepPanel/Canvas/SubStepPrevButton/Forma Button v3 Tools");
            ClickBackArrowBtnObject.Tap();
        }

        public static void ClickValidateBtnObject()
        {
            var ClickValidateBtnObject = altDriver.WaitForObject(By.PATH, "/Cleanup/LevelNavigationPanel(Clone)/Canvas/NavNext Step/Forma Button v3 Contextual");
            ClickValidateBtnObject.Tap();
        }

        public static void CuttingPlanePositionObject()
        {
            var Plane1 = altDriver.WaitForObject(By.PATH, "/Cleanup/CropScanStep(Clone)/MeshCropperTool/Plane1");
            var startPosition = Plane1.GetScreenPosition();
            Move(startPosition.x, startPosition.y, 942.4403f, 643.2209f);
        }

        public static void CuttingPlanePositionLowerLimbObject()
        {
            var Plane1 = altDriver.WaitForObject(By.PATH, "/Cleanup/CropScanStep(Clone)/MeshCropperTool/Plane1");
            //var startPosition = Plane1.GetScreenPosition();
            Move(1136.441f, 566.2554f, 1123.115f, 1050.278f);
        }

        public static void ClickVerticalAngleBtnObject()
        {
            var ClickVerticalAngleBtnObject = altDriver.WaitForObject(By.PATH, "/Cleanup/CropScanStep(Clone)/CropScanPanel/Canvas/ExtensibleYSlider/ButtonAndSlidingPanel/Button");
            ClickVerticalAngleBtnObject.Tap();
        }

        public static void MoveVerticalSliderCuttingPlanePositionObject()
        {
            var MoveVerticalSlider = altDriver.WaitForObject(By.PATH, "/Cleanup/CropScanStep(Clone)/CropScanPanel/Canvas/ExtensibleYSlider/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveVerticalSlider.GetScreenPosition();
            Move(740.2367f, 335.5216f, 747.3315f, 407.0796f);
        }

        public static void ClickHorizontalAngleBtnObject()
        {
            var ClickVerticalAngleBtnObject = altDriver.WaitForObject(By.PATH, "/Cleanup/CropScanStep(Clone)/CropScanPanel/Canvas/ExtensibleXSlider/ButtonAndSlidingPanel/Button");
            ClickVerticalAngleBtnObject.Tap();
        }

        public static void MoveHorizontalSliderCuttingPlanePositionObject()
        {
            var MoveHorizontalSlider = altDriver.WaitForObject(By.PATH, "/Cleanup/CropScanStep(Clone)/CropScanPanel/Canvas/ExtensibleXSlider/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveHorizontalSlider.GetScreenPosition();
            Move(992.1044f, 335.5216f, 1006.294f, 174.5161f);
        }

        public static void ClickResetPlaneBtnObject()
        {
            var ClickResetPlaneBtnObject = altDriver.WaitForObject(By.PATH, "/Cleanup/CropScanStep(Clone)/CropScanPanel/Canvas/Button Reset");
            ClickResetPlaneBtnObject.Tap();
        }

        #endregion

        #region Scan Correction - Pose Methods
        #region CommonHelpers
        public static void ClickAdvancedPoseBtnObject()
        {
            var ClickAdvancedPoseBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PoseModeSelectPan(Clone)/AdvancedMode");
            ClickAdvancedPoseBtnObject.Tap();
        }

        public static void ClickTickBtnPoseObject()
        {
            var ClickTickBtnPoseObject = altDriver.WaitForObject(By.PATH, "/PoseCTL/LMRunPlacementStep/LMRunPlacementStepPanel/Canvas/SubStepNextButton/Forma Button v3 Tools/Icon");
            ClickTickBtnPoseObject.Tap();
        }

        public static void ClickBackArrowBtnPoseObject()
        {
            var ClickBackArrowBtnPoseObject = altDriver.WaitForObject(By.PATH, "/PoseCTL/LMRunPlacementStep/LMRunPlacementStepPanel/Canvas/SubStepPrevButton/Forma Button v3 Tools/Icon");
            ClickBackArrowBtnPoseObject.Tap();
        }

        public static void ClickPreviousStepBtnPoseObject()
        {
            var ClickPreviousStepBtnPoseObject = altDriver.WaitForObject(By.PATH, "/Canvas/Navigation Buttons Panel/NavPrev Step/Forma Button v3 Contextual/Background");
            ClickPreviousStepBtnPoseObject.Tap();
        }

        public static void ClickValidateBtnPoseObject()
        {
            var ClickValidateBtnPoseObject = altDriver.WaitForObject(By.PATH, "/Canvas/Navigation Buttons Panel/NavNext Step/Forma Button v3 Contextual/Background");
            ClickValidateBtnPoseObject.Tap();
        }

        public static void ClickPoseBtnMainViewObject()
        {
            var ClickPoseBtnMainViewObject = altDriver.WaitForObject(By.PATH, "/Canvas/MainMenu(Clone)/MainMenuBtn(Clone)[1]");
            ClickPoseBtnMainViewObject.Tap();
        }

        public static void ClickQuitBtnPoseObject()
        {
            var ClickQuitBtnPoseObject = altDriver.WaitForObject(By.PATH, "/Canvas/Navigation Buttons Panel/NavPrev Step/Forma Button v3 Contextual/Text");
            ClickQuitBtnPoseObject.Tap();
        }

        public static void ClickResetBtnPopUpObject()
        {
            var ClickResetBtnPopUpObject = altDriver.WaitForObject(By.PATH, "/Canvas/Popup(Clone)/Content/Bottom Container/Cancel button");
            ClickResetBtnPopUpObject.Tap();
        }

        public static void ClickUndoBtnPoseObject()
        {
            var ClickUndoBtnPoseObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/BottomPanel/Undo");
            ClickUndoBtnPoseObject.Tap();
        }

        public static void ClickRedoBtnPoseObject()
        {
            var ClickRedoBtnPoseObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/BottomPanel/Redo");
            ClickRedoBtnPoseObject.Tap();
        }

        public static void ClickNeutralPoseBtnObject()
        {
            var ClickNeutralPoseBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/AutomaticNeutralButton");
            ClickNeutralPoseBtnObject.Tap();
        }

        public static void ClickResetSliderPoseBtnObject()
        {
            var ClickResetSliderPoseBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/ResetButton");
            ClickResetSliderPoseBtnObject.Tap();
        }

        public static void ClickGlobalRotationPoseBtnObject()
        {
            var ClickGlobalRotationPoseBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/GlobalButton");
            ClickGlobalRotationPoseBtnObject.Tap();
        }

        public static void ClickGlobalRotationForwardPoseBtnObject()
        {
            var ClickGlobalRotationForwardPoseBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Button");
            ClickGlobalRotationForwardPoseBtnObject.Tap();
        }

        public static void ClickAppearanceBtnObject()
        {
            var ClickAppearanceBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/MatDropDown");
            ClickAppearanceBtnObject.Tap();
        }

        public static void ClickTransparentChoiceBtnObject()
        {
            var ClickTransparentChoiceBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/MatDropDown/Dropdown List/Viewport/Content/Item 1: Transparent");
            ClickTransparentChoiceBtnObject.Tap();
        }

        public static void ClickNeutralGhostChoiceBtnObject()
        {
            var ClickNeutralGhostChoiceBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/MatDropDown/Dropdown List/Viewport/Content/Item 2: Neutral ghost");
            ClickNeutralGhostChoiceBtnObject.Tap();
        }

        public static void ClickGlobalRotationRightPoseBtnObject()
        {
            var ClickGlobalRotationRightPoseBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)[1]/ButtonAndSlidingPanel/Button");
            ClickGlobalRotationRightPoseBtnObject.Tap();
        }

         public static void MoveSliderGlobalRotationForwardObject()
        {
            var MoveSliderGlobalRotationForwardObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderGlobalRotationForwardObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(889.2289f, 339.0995f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(892.7763f, 482.2155f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }
        public static void MoveSliderGlobalRotationRightObject()
        {
            var MoveSliderGlobalRotationRightObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)[1]/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderGlobalRotationRightObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(1137.549f, 356.989f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1141.097f, 231.7625f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public static void ClickGlobalRotationVerticalPoseBtnObject()
        {
            var ClickGlobalRotationVerticalPoseBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)[2]/ButtonAndSlidingPanel/Button");
            ClickGlobalRotationVerticalPoseBtnObject.Tap();
        }

        public static void MoveSliderGlobalRotationVerticalObject()
        {
            var MoveSliderGlobalRotationVerticalObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)[2]/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderGlobalRotationVerticalObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(1382.322f, 339.0995f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1389.417f, 428.547f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        #endregion
        #region Upper Limbs

        public static void MoveSliderHandExtFlexObject()
        {
            var MoveSliderHandExtFlex = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/SliderPanel/PoseSlider(Clone)/SlideMask/Background/Slider/Handle Slide Area");
            var startPosition = MoveSliderHandExtFlex.GetScreenPosition();
            Move(396.1357f, 1158.438f, 257.7858f, 1158.438f);
        }

        public static void ClickHandAdAbBtnObject()
        {
            var ClickHandAdAbBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/SliderPanel/PoseSlider(Clone)[1]/IconPanel");
            ClickHandAdAbBtnObject.Tap();
        }

        public static void MoveSliderHandAdAbObject()
        {
            var MoveSliderHandAdAbObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/SliderPanel/PoseSlider(Clone)[1]/SlideMask/Background/Slider/Handle Slide Area");
            var startPosition = MoveSliderHandAdAbObject.GetScreenPosition();
            Move(222.3114f, 1033.212f, 353.5665f, 1033.212f);
        }

        public static void ClickThumbExtFlexBtnObject()
        {
            var ClickThumbExtFlexBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/SliderPanel/PoseSlider(Clone)[2]/IconPanel");
            ClickThumbExtFlexBtnObject.Tap();
        }

        public static void MoveSliderThumbExtFlexObject()
        {
            var MoveSliderThumbExtFlexObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/SliderPanel/PoseSlider(Clone)[2]/SlideMask/Background/Slider/Handle Slide Area");
            var startPosition = MoveSliderThumbExtFlexObject.GetScreenPosition();
            Move(318.0921f, 907.9855f, 381.9459f, 907.9855f);
        }

        public static void ClickThumbAdAbBtnObject()
        {
            var ClickThumbAdAbBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/SliderPanel/PoseSlider(Clone)[3]/IconPanel");
            ClickThumbAdAbBtnObject.Tap();
        }

        public static void MoveSliderThumbAdAbObject()
        {
            var MoveSliderThumbAdAbObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/SliderPanel/PoseSlider(Clone)[3]/SlideMask/Background/Slider/Handle Slide Area");
            var startPosition = MoveSliderThumbAdAbObject.GetScreenPosition();
            Move(310.9973f, 786.3369f, 247.1435f, 779.1812f);
        }

        public static void ClickFingerExtFlexBtnObject()
        {
            var ClickFingerExtFlexBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/SliderPanel/PoseSlider(Clone)[4]/IconPanel");
            ClickFingerExtFlexBtnObject.Tap();
        }

        public static void MoveSliderFingerExtFlexObject()
        {
            var MoveSliderFingerExtFlexObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/SliderPanel/PoseSlider(Clone)[4]/SlideMask/Background/Slider/Handle Slide Area");
            var startPosition = MoveSliderFingerExtFlexObject.GetScreenPosition();
            Move(325.187f, 661.1104f, 261.3332f, 657.5325f);
        }

        public static void ClickFingerSplayBtnObject()
        {
            var ClickFingerSplayBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/SliderPanel/PoseSlider(Clone)[5]/IconPanel");
            ClickFingerSplayBtnObject.Tap();
        }

        public static void MoveSliderFingerSplayObject()
        {
            var MoveSliderFingerSplayObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/SliderPanel/PoseSlider(Clone)[5]/SlideMask/Background/Slider/Handle Slide Area");
            var startPosition = MoveSliderFingerSplayObject.GetScreenPosition();
            Move(144.2679f, 539.4619f, 236.5012f, 539.4619f);
        }

        public static void ClickFirstSphereThumbExtFlexObject()
        {
            var ClickFirstSphereThumbExtFlexObject = altDriver.WaitForObject(By.PATH, "/PoseCTL/MBMForeArm(Clone)/Armature/lower arm.R/hand.R/f.thumb1.R/f.thumb2.R/f.thumb3.R/Sphere");
            ClickFirstSphereThumbExtFlexObject.Tap();
        }

        public static void ClickFirstSphereThumbExtFlexBtnObject()
        {
            var ClickFirstSphereThumbExtFlexBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Button");
            ClickFirstSphereThumbExtFlexBtnObject.Tap();
        }

        public static void MoveSliderFirstSphereThumbExtFlexObject()
        {
            var MoveSliderFirstSphereThumbExtFlexObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderFirstSphereThumbExtFlexObject.GetScreenPosition();
            Move(1328.976f, 343.6817f, 1325.427f, 426.0182f);
        }

        public static void ClickSecondSphereThumbExtFlexObject()
        {
            var ClickSecondSphereThumbExtFlexObject = altDriver.WaitForObject(By.PATH, "/PoseCTL/MBMForeArm(Clone)/Armature/lower arm.R/hand.R/f.thumb1.R/f.thumb2.R/Sphere");
            ClickSecondSphereThumbExtFlexObject.Tap();
        }

        public static void ClickSecondSphereThumbExtFlexBtnObject()
        {
            var ClickSecondSphereThumbExtFlexBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Button");
            ClickSecondSphereThumbExtFlexBtnObject.Tap();
        }

        public static void MoveSliderSecondSphereThumbExtFlexObject()
        {
            var MoveSliderSecondSphereThumbExtFlexObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderSecondSphereThumbExtFlexObject.GetScreenPosition();
            Move(1321.878f, 347.2616f, 1328.976f, 408.1189f);
        }

        public static void ClickThirdSphereThumbExtFlexObject()
        {
            var ClickThirdSphereThumbExtFlexObject = altDriver.WaitForObject(By.PATH, "/PoseCTL/MBMForeArm(Clone)/Armature/lower arm.R/hand.R/f.thumb1.R/Sphere");
            ClickThirdSphereThumbExtFlexObject.Tap();
        }

        public static void ClickThirdSphereThumbExtFlexBtnObject()
        {
            var ClickThirdSphereThumbExtFlexBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Button");
            ClickThirdSphereThumbExtFlexBtnObject.Tap();
        }

        public static void MoveSliderThirdSphereThumbExtFlexObject()
        {
            var MoveSliderThirdSphereThumbExtFlexObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderThirdSphereThumbExtFlexObject.GetScreenPosition();
            Move(892.4401f, 350.8414f, 888.891f, 297.1437f);
        }

        public static void ClickThirdSphereThumbInversEversBtnObject()
        {
            var ClickThirdSphereThumbInversEversBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)[1]/ButtonAndSlidingPanel/Button");
            ClickThirdSphereThumbInversEversBtnObject.Tap();
        }

        public static void MoveSliderThirdSphereThumbInversEversObject()
        {
            var MoveSliderThirdSphereThumbInversEversObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderThirdSphereThumbInversEversObject.GetScreenPosition();
            Move(1137.326f, 347.2616f, 1123.13f, 422.4383f);
        }

        public static void ClickThirdSphereThumbAbductAdductBtnObject()
        {
            var ClickThirdSphereThumbAbductAdductBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)[2]/ButtonAndSlidingPanel/Button");
            ClickThirdSphereThumbAbductAdductBtnObject.Tap();
        }

        public static void MoveSliderThirdSphereThumbAbductAdductObject()
        {
            var MoveSliderThirdSphereThumbAbductAdductObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderThirdSphereThumbAbductAdductObject.GetScreenPosition();
            Move(1378.663f, 336.522f, 1392.859f, 426.0182f);
        }

        public static void ClickFirstSphereIndexExtFlexObject()
        {
            var ClickFirstSphereIndexExtFlexObject = altDriver.WaitForObject(By.PATH, "/PoseCTL/MBMForeArm(Clone)/Armature/lower arm.R/hand.R/palm1.R/f.index1.R/f.index2.R/f.index3.R/Sphere");
            ClickFirstSphereIndexExtFlexObject.Tap();
        }

        public static void ClickFirstSphereIndexExtFlexBtnObject()
        {
            var ClickFirstSphereIndexExtFlexBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Button");
            ClickFirstSphereIndexExtFlexBtnObject.Tap();
        }

        public static void MoveSliderFirstSphereIndexExtFlexObject()
        {
            var MoveSliderFirstSphereIndexExtFlexObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderFirstSphereIndexExtFlexObject.GetScreenPosition();
            Move(1325.427f, 375.9003f, 1318.329f, 279.2445f);
        }

        public static void ClickSecondSphereIndexExtFlexObject()
        {
            var ClickSecondSphereIndexExtFlexObject = altDriver.WaitForObject(By.PATH, "/PoseCTL/MBMForeArm(Clone)/Armature/lower arm.R/hand.R/palm1.R/f.index1.R/f.index2.R/Sphere");
            ClickSecondSphereIndexExtFlexObject.Tap();
        }

        public static void ClickSecondSphereIndexExtFlexBtnObject()
        {
            var ClickSecondSphereIndexExtFlexBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Button");
            ClickSecondSphereIndexExtFlexBtnObject.Tap();
        }

        public static void MoveSliderSecondSphereIndexExtFlexObject()
        {
            var MoveSliderSecondSphereIndexExtFlexObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderSecondSphereIndexExtFlexObject.GetScreenPosition();
            Move(1328.976f, 375.9003f, 1325.427f, 443.9174f);
        }

        public static void ClickThirdSphereIndexExtFlexObject()
        {
            var ClickThirdSphereIndexExtFlexObject = altDriver.WaitForObject(By.PATH, "/PoseCTL/MBMForeArm(Clone)/Armature/lower arm.R/hand.R/palm1.R/f.index1.R/Sphere");
            ClickThirdSphereIndexExtFlexObject.Tap();
        }

        public static void ClickThirdSphereIndexExtFlexBtnObject()
        {
            var ClickThirdSphereIndexExtFlexBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Button");
            ClickThirdSphereIndexExtFlexBtnObject.Tap();
        }

        public static void MoveSliderThirdSphereIndexExtFlexObject()
        {
            var MoveSliderThirdSphereIndexExtFlexObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderThirdSphereIndexExtFlexObject.GetScreenPosition();
            Move(1328.976f, 372.3205f, 1321.878f, 286.4042f);
        }

        public static void ClickFirstSphereMiddleExtFlexObject()
        {
            var ClickFirstSphereMiddleExtFlexObject = altDriver.WaitForObject(By.PATH, "/PoseCTL/MBMForeArm(Clone)/Armature/lower arm.R/hand.R/palm2.R/f.middle1.R/f.middle2.R/f.middle3.R/Sphere");
            ClickFirstSphereMiddleExtFlexObject.Tap();
        }

        public static void ClickFirstSphereMiddleExtFlexBtnObject()
        {
            var ClickFirstSphereMiddleExtFlexBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Button");
            ClickFirstSphereMiddleExtFlexBtnObject.Tap();
        }

        public static void MoveSliderFirstSphereMiddleExtFlexObject()
        {
            var MoveSliderFirstSphereMiddleExtFlexObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderFirstSphereMiddleExtFlexObject.GetScreenPosition();
            Move(1325.427f, 375.9003f, 1321.878f, 250.6057f);
        }

        public static void ClickSecondSphereMiddleExtFlexObject()
        {
            var ClickSecondSphereMiddleExtFlexObject = altDriver.WaitForObject(By.PATH, "/PoseCTL/MBMForeArm(Clone)/Armature/lower arm.R/hand.R/palm2.R/f.middle1.R/f.middle2.R/f.middle3.R/Sphere");
            ClickSecondSphereMiddleExtFlexObject.Tap();
        }

        public static void ClickSecondSphereMiddleExtFlexBtnObject()
        {
            var ClickSecondSphereMiddleExtFlexBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Button");
            ClickSecondSphereMiddleExtFlexBtnObject.Tap();
        }

        public static void MoveSliderSecondSphereMiddleExtFlexObject()
        {
            var MoveSliderSecondSphereMiddleExtFlexObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderSecondSphereMiddleExtFlexObject.GetScreenPosition();
            Move(1322.016f, 374.8784f, 1332.658f, 278.2752f);
        }

        public static void ClickThirdSphereMiddleExtFlexObject()
        {
            var ClickThirdSphereMiddleExtFlexObject = altDriver.WaitForObject(By.PATH, "/PoseCTL/MBMForeArm(Clone)/Armature/lower arm.R/hand.R/palm2.R/f.middle1.R/Sphere");
            ClickThirdSphereMiddleExtFlexObject.Tap();
        }

        public static void ClickThirdSphereMiddleExtFlexBtnObject()
        {
            var ClickThirdSphereMiddleExtFlexBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Button");
            ClickThirdSphereMiddleExtFlexBtnObject.Tap();
        }

        public static void MoveSliderThirdSphereMiddleExtFlexObject()
        {
            var MoveSliderThirdSphereMiddleExtFlexObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderThirdSphereMiddleExtFlexObject.GetScreenPosition();
            Move(1322.016f, 367.7227f, 1329.111f, 442.8586f);
        }

        public static void ClickFirstSphereRingExtFlexObject()
        {
            var ClickFirstSphereRingExtFlexObject = altDriver.WaitForObject(By.PATH, "/PoseCTL/MBMForeArm(Clone)/Armature/lower arm.R/hand.R/palm3.R/f.ring1.R/f.ring2.R/f.ring3.R/Sphere");
            ClickFirstSphereRingExtFlexObject.Tap();
        }

        public static void ClickFirstSphereRingExtFlexBtnObject()
        {
            var ClickFirstSphereRingExtFlexBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Button");
            ClickFirstSphereRingExtFlexBtnObject.Tap();
        }

        public static void MoveSliderFirstSphereRingExtFlexObject()
        {
            var MoveSliderFirstSphereRingExtFlexObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderFirstSphereRingExtFlexObject.GetScreenPosition();
            Move(1322.016f, 371.3006f, 1329.111f, 260.3857f);
        }

        public static void ClickSecondSphereRingExtFlexObject()
        {
            var ClickSecondSphereRingExtFlexObject = altDriver.WaitForObject(By.PATH, "/PoseCTL/MBMForeArm(Clone)/Armature/lower arm.R/hand.R/palm3.R/f.ring1.R/f.ring2.R/Sphere");
            ClickSecondSphereRingExtFlexObject.Tap();
        }

        public static void ClickSecondSphereRingExtFlexBtnObject()
        {
            var ClickSecondSphereRingExtFlexBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Button");
            ClickSecondSphereRingExtFlexBtnObject.Tap();
        }

        public static void MoveSliderSecondSphereRingExtFlexObject()
        {
            var MoveSliderSecondSphereRingExtFlexObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderSecondSphereRingExtFlexObject.GetScreenPosition();
            Move(1325.563f, 371.3006f, 1325.563f, 274.6973f);
        }

        public static void ClickThirdSphereRingExtFlexObject()
        {
            var ClickThirdSphereRingExtFlexObject = altDriver.WaitForObject(By.PATH, "/PoseCTL/MBMForeArm(Clone)/Armature/lower arm.R/hand.R/palm3.R/f.ring1.R/Sphere");
            ClickThirdSphereRingExtFlexObject.Tap();
        }

        public static void ClickThirdSphereRingExtFlexBtnObject()
        {
            var ClickThirdSphereRingExtFlexBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Button");
            ClickThirdSphereRingExtFlexBtnObject.Tap();
        }

        public static void MoveSliderThirdSphereRingExtFlexObject()
        {
            var MoveSliderThirdSphereRingExtFlexObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderThirdSphereRingExtFlexObject.GetScreenPosition();
            Move(1325.563f, 367.7227f, 1325.563f, 464.326f);
        }

        public static void ClickFirstSphereLittleExtFlexObject()
        {
            var ClickFirstSphereLittleExtFlexObject = altDriver.WaitForObject(By.PATH, "/PoseCTL/MBMForeArm(Clone)/Armature/lower arm.R/hand.R/palm4.R/f.pinky1.R/f.pinky2.R/f.pinky3.R/Sphere");
            ClickFirstSphereLittleExtFlexObject.Tap();
        }

        public static void ClickFirstSphereLittleExtFlexBtnObject()
        {
            var ClickFirstSphereLittleExtFlexBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Button");
            ClickFirstSphereLittleExtFlexBtnObject.Tap();
        }

        public static void MoveSliderFirstSphereLittleExtFlexObject()
        {
            var MoveSliderFirstSphereLittleExtFlexObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderFirstSphereLittleExtFlexObject.GetScreenPosition();
            Move(1329.111f, 367.7227f, 1318.468f, 249.652f);
        }

        public static void ClickSecondSphereLittleExtFlexObject()
        {
            var ClickSecondSphereLittleExtFlexObject = altDriver.WaitForObject(By.PATH, "/PoseCTL/MBMForeArm(Clone)/Armature/lower arm.R/hand.R/palm4.R/f.pinky1.R/f.pinky2.R/Sphere");
            ClickSecondSphereLittleExtFlexObject.Tap();
        }

        public static void ClickSecondSphereLittleExtFlexBtnObject()
        {
            var ClickSecondSphereLittleExtFlexBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Button");
            ClickSecondSphereLittleExtFlexBtnObject.Tap();
        }

        public static void MoveSliderSecondSphereLittleExtFlexObject()
        {
            var MoveSliderSecondSphereLittleExtFlexObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderSecondSphereLittleExtFlexObject.GetScreenPosition();
            Move(1322.016f, 367.1447f, 1325.563f, 285.431f);
        }

        public static void ClickThirdSphereLittleExtFlexObject()
        {
            var ClickThirdSphereLittleExtFlexObject = altDriver.WaitForObject(By.PATH, "/PoseCTL/MBMForeArm(Clone)/Armature/lower arm.R/hand.R/palm4.R/f.pinky1.R/Sphere");
            ClickThirdSphereLittleExtFlexObject.Tap();
        }

        public static void ClickThirdSphereLittleExtFlexBtnObject()
        {
            var ClickThirdSphereLittleExtFlexBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Button");
            ClickThirdSphereLittleExtFlexBtnObject.Tap();
        }

        public static void MoveSliderThirdSphereLittleExtFlexObject()
        {
            var MoveSliderThirdSphereLittleExtFlexObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderThirdSphereLittleExtFlexObject.GetScreenPosition();
            Move(1329.111f, 374.8784f, 1329.111f, 464.326f);
        }

        public static void ClickHandSphereObject()
        {
            var ClickHandSphereObject = altDriver.WaitForObject(By.PATH, "/PoseCTL/MBMForeArm(Clone)/Armature/lower arm.R/hand.R/Sphere");
            ClickHandSphereObject.Tap();
        }

        public static void ClickHandSphereExtFlexBtnObject()
        {
            var ClickThirdSphereLittleExtFlexBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)[1]/ButtonAndSlidingPanel/Button");
            ClickThirdSphereLittleExtFlexBtnObject.Tap();
        }

        public static void MoveSliderHandSphereExtFlexObject()
        {
            var MoveSliderHandSphereExtFlexObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)[1]/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderHandSphereExtFlexObject.GetScreenPosition();
            Move(1353.943f, 378.4564f, 1364.585f, 278.2752f);
        }

        public static void ClickHandSphereAbducAdducBtnObject()
        {
            var ClickHandSphereAbducAdducBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Button");
            ClickHandSphereAbducAdducBtnObject.Tap();
        }

        public static void MoveSliderHandSphereAbducAdducObject()
        {
            var MoveSliderHandSphereAbducAdducObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderHandSphereAbducAdducObject.GetScreenPosition();
            Move(1063.053f, 292.5868f, 1080.79f, 378.4564f);
        }

        public static void ClickHandExtFlexBtnObject()
        {
            var ClickHandExtFlexBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/SliderPanel/PoseSlider(Clone)/IconPanel");
            ClickHandExtFlexBtnObject.Tap();
        }
        public static void MoveSliderGlobalRotationForwardUpperLimbObject()
        {
            var MoveSliderGlobalRotationForwardUpperLimbObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderGlobalRotationForwardUpperLimbObject.GetScreenPosition();
            Move(889.2289f, 339.0995f, 892.7763f, 482.2155f);
        }

        #endregion
        #region Lower Limbs
        public static void ClickFirstSphereFootObject()
        {
            var ClickFirstSphereFootObject = altDriver.WaitForObject(By.PATH, "/PoseCTL/MBMFoot(Clone)/Armature/Shin/FootConnector/Foot/Sphere");
            ClickFirstSphereFootObject.Tap();
        }

        public static void ClickFirstSphereFootInvEverBtnObject()
        {
            var ClickFirstSphereFootInvEverBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Button");
            ClickFirstSphereFootInvEverBtnObject.Tap();
        }

        public static void MoveSliderFirstSphereFootInvEverObject()
        {
            var MoveSliderFirstSphereFootInvEverObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderFirstSphereFootInvEverObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(841.3564f, 339.6099f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(843.2602f, 445.2497f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public static void ClickFirstSphereFootPlantarDorsalBtnObject()
        {
            var ClickFirstSphereFootPlantarDorsalBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)[1]/ButtonAndSlidingPanel/Button");
            ClickFirstSphereFootPlantarDorsalBtnObject.Tap();
        }

        public static void MoveSliderFirstSphereFootPlantarDorsalObject()
        {
            var MoveSliderFirstSphereFootPlantarDorsalObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)[1]/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderFirstSphereFootPlantarDorsalObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(1109.788f, 320.4026f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1111.692f, 449.0912f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public static void ClickFirstSphereFootTwistLeftRightBtnObject()
        {
            var ClickFirstSphereFootTwistLeftRightBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)[2]/ButtonAndSlidingPanel/Button");
            ClickFirstSphereFootTwistLeftRightBtnObject.Tap();
        }

        public static void MoveSliderFirstSphereFootTwistLeftRightObject()
        {
            var MoveSliderFirstSphereFootTwistLeftRightObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)[2]/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderFirstSphereFootTwistLeftRightObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(1374.413f, 335.7684f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1374.413f, 454.8534f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public static void ClickSecondSphereFootObject()
        {
            var ClickSecondSphereFootObject = altDriver.WaitForObject(By.PATH, "/PoseCTL/MBMFoot(Clone)/Armature/Shin/FootConnector/Foot/FootControl1/Sphere");
            ClickSecondSphereFootObject.Tap();
        }

        public static void ClickSecondSphereFootAbductAdductBtnObject()
        {
            var ClickSecondSphereFootAbductAdductBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Button");
            ClickSecondSphereFootAbductAdductBtnObject.Tap();
        }

        public static void MoveSliderSecondSphereFootAbductAdductBtnObject()
        {
            var MoveSliderSecondSphereFootAbductAdductBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderSecondSphereFootAbductAdductBtnObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(1035.541f, 337.6891f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1033.637f, 456.7741f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public static void ClickSecondSphereFootTwistLeftRightBtnObject()
        {
            var ClickSecondSphereFootTwistLeftRightBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)[1]/ButtonAndSlidingPanel/Button");
            ClickSecondSphereFootTwistLeftRightBtnObject.Tap();
        }

        public static void MoveSliderSecondSphereFootTwistLeftRightBtnObject()
        {
            var MoveSliderSecondSphereFootTwistLeftRightBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)[1]/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderSecondSphereFootTwistLeftRightBtnObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(1345.856f, 339.6099f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1347.76f, 470.2191f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public static void ClickThirdSphereFootObject()
        {
            var ClickThirdSphereFootObject = altDriver.WaitForObject(By.PATH, "/PoseCTL/MBMFoot(Clone)/Armature/Shin/FootConnector/Foot/FootControl1/FootControl2/Sphere");
            ClickThirdSphereFootObject.Tap();
        }

        public static void ClickThirdSphereFootRaiseLowerBtnObject()
        {
            var ClickThirdSphereFootRaiseLowerBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Button");
            ClickThirdSphereFootRaiseLowerBtnObject.Tap();
        }

        public static void MoveSliderThirdSphereFootRaiseLowerBtnObject()
        {
            var MoveSliderThirdSphereFootRaiseLowerBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderThirdSphereFootRaiseLowerBtnObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(1288.743f, 345.372f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1286.839f, 462.5363f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public static void ClickFourthSphereFootObject()
        {
            var ClickFourthSphereFootObject = altDriver.WaitForObject(By.PATH, "/PoseCTL/MBMFoot(Clone)/Armature/Shin/FootConnector/Foot/FootControl1/FootControl2/Toes/Sphere");
            ClickFourthSphereFootObject.Tap();
        }

        public static void ClickFourthSphereFootExtFlexBtnObject()
        {
            var ClickFourthSphereFootExtFlexBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Button");
            ClickFourthSphereFootExtFlexBtnObject.Tap();
        }

        public static void MoveSliderFourthSphereFootExtFlexBtnObject()
        {
            var MoveSliderFourthSphereFootExtFlexBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/PosePan(Clone)/Panel/SliderTemplate(Clone)/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderFourthSphereFootExtFlexBtnObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(1288.743f, 341.5306f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1284.936f, 474.0606f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }
        #endregion
        #endregion

        #region Scan Correction - Thumb Methods
        public static void ClickThumbBtnMainViewObject()
        {
            var ClickThumbBtnMainViewObject = altDriver.WaitForObject(By.PATH, "/Canvas/MainMenu(Clone)/MainMenuBtn(Clone)[2]");
            ClickThumbBtnMainViewObject.Tap();
        }

        public static void ClickCrossBtnThumbObject()
        {
            var ClickCrossBtnThumbObject = altDriver.WaitForObject(By.PATH, "/ThumbCTL/LMRunPlacementStep/LMRunPlacementStepPanel/Canvas/SubStepPrevButton/Forma Button v3 Tools");
            ClickCrossBtnThumbObject.Tap();
        }

        public static void ClickTickBtnThumbObject()
        {
            var ClickTickBtnThumbObject = altDriver.WaitForObject(By.PATH, "/ThumbCTL/LMRunPlacementStep/LMRunPlacementStepPanel/Canvas/SubStepNextButton/Forma Button v3 Tools/Icon");
            ClickTickBtnThumbObject.Tap();
        }

        public static void ClickBackArrowBtnThumbObject()
        {
            var ClickBackArrowBtnThumbObject = altDriver.WaitForObject(By.PATH, "/ThumbCTL/LMRunPlacementStep/LMRunPlacementStepPanel/Canvas/SubStepPrevButton/Forma Button v3 Tools");
            ClickBackArrowBtnThumbObject.Tap();
        }

        public static void ClickPreviousStepBtnThumbObject()
        {
            var ClickPreviousStepBtnThumbObject = altDriver.WaitForObject(By.PATH, "/Canvas/Navigation Buttons Panel/NavPrev Step/Forma Button v3 Contextual");
            ClickPreviousStepBtnThumbObject.Tap();
        }

        public static void ClickEditBtnThumbObject()
        {
            var ClickEditBtnThumbObject = altDriver.WaitForObject(By.PATH, "/Canvas/ThumbEditorPanel(Clone)/DisplayCircSliderSwitch/Background/Switch button/icon left");
            ClickEditBtnThumbObject.Tap();
        }

        public static void ClickCircumferenceBtnThumbObject()
        {
            var ClickCircumferenceBtnThumbObject = altDriver.WaitForObject(By.PATH, "/Canvas/ThumbEditorPanel(Clone)/ExtensibleCircumferenceSlider/ButtonAndSlidingPanel/Button");
            ClickCircumferenceBtnThumbObject.Tap();
        }

        public static void MoveSliderCircToMinThumbObject()
        {
            var MoveSliderCircToMinThumbObject = altDriver.WaitForObject(By.PATH, "/Canvas/ThumbEditorPanel(Clone)/ExtensibleCircumferenceSlider/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area");
            var startPosition = MoveSliderCircToMinThumbObject.GetScreenPosition();
            Move(1092.88f, 324.5237f, 1092.88f, 193.672f);
        }

        public static void MoveSliderCircToMaxThumbObject()
        {
            var MoveSliderCircToMaxThumbObject = altDriver.WaitForObject(By.PATH, "/Canvas/ThumbEditorPanel(Clone)/ExtensibleCircumferenceSlider/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area");
            var startPosition = MoveSliderCircToMaxThumbObject.GetScreenPosition();
            Move(1096.478f, 215.4806f, 1092.88f, 466.2798f);
        }

        public static void ClickResetSliderBtnThumbObject()
        {
            var ClickResetSliderBtnThumbObject = altDriver.WaitForObject(By.PATH, "/Canvas/ThumbEditorPanel(Clone)/ResetButton");
            ClickResetSliderBtnThumbObject.Tap();
        }

        public static void ClickValidateBtnThumbObject()
        {
            var ClickValidateBtnThumbObject = altDriver.WaitForObject(By.PATH, "/Canvas/Navigation Buttons Panel/NavNext Step/Forma Button v3 Contextual");
            ClickValidateBtnThumbObject.Tap();
        }

        #endregion

        #region Scan Correction - Sculpt Methods
        #region CommonHelpers
        public static void ClickSculptBtnMainNoThumbViewObject()
        {
            var ClickSculptBtnMainNoThumbViewObject = altDriver.WaitForObject(By.PATH, "/Canvas/MainMenu(Clone)/MainMenuBtn(Clone)[2]");
            ClickSculptBtnMainNoThumbViewObject.Tap();
        }

        public static void ClickFirstOnMeshToActivateDrawingSculptObject()
        {
            var ClickFirstOnMeshToActivateDrawingSculptObject = altDriver.WaitForObject(By.PATH, "/StatusMN/scanClean");
            ClickFirstOnMeshToActivateDrawingSculptObject.Tap();
        }

        public static void ClickUndoBtnSculptObject()
        {
            var ClickUndoBtnSculptObject = altDriver.WaitForObject(By.PATH, "/Canvas/UndoRedoPan(Clone)/Undo Button");
            ClickUndoBtnSculptObject.Tap();
        }

        public static void ClickRedoBtnSculptObject()
        {
            var ClickRedoBtnSculptObject = altDriver.WaitForObject(By.PATH, "/Canvas/UndoRedoPan(Clone)/Redo Button");
            ClickRedoBtnSculptObject.Tap();
        }

        public static void ClickBrushDiameterBtnSculptObject()
        {
            var ClickBrushDiameterBtnSculptObject = altDriver.WaitForObject(By.PATH, "/Canvas/SculptUI(Clone)/InteractiveUIRoot/BrushSlider/ExtensibleSlider/ButtonAndSlidingPanel/Button");
            ClickBrushDiameterBtnSculptObject.Tap();
        }

        public static void MoveSliderBrushDiameterToMinSculptObject()
        {
            var MoveSliderBrushDiameterToMinSculptObject = altDriver.WaitForObject(By.PATH, "/Canvas/SculptUI(Clone)/InteractiveUIRoot/BrushSlider/ExtensibleSlider/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area");
            var startPosition = MoveSliderBrushDiameterToMinSculptObject.GetScreenPosition();
            Move(1082.085f, 280.9065f, 1078.487f, 211.8458f);
        }

        public static void ClickPullPushBtnSculptObject()
        {
            var ClickPullPushBtnSculptObject = altDriver.WaitForObject(By.PATH, "/Canvas/SculptUI(Clone)/InteractiveUIRoot/Pull Push  Switch/Background/Switch button");
            ClickPullPushBtnSculptObject.Tap();
        }

        public static void ClickOnAxisYSculptObject()
        {
            var ClickOnAxisYSculptObject = altDriver.WaitForObject(By.PATH, "/Canvas/Compass3D/AntiYBar/AntiY");
            ClickOnAxisYSculptObject.Tap();
        }

        public static void ClickOnAxisXSculptObject()
        {
            var ClickOnAxisXSculptObject = altDriver.WaitForObject(By.PATH, "/Canvas/Compass3D/XBar/X/XLabel");
            ClickOnAxisXSculptObject.Tap();
        }

        public static void ClickOnAxisAntiXSculptObject()
        {
            var ClickOnAxisAntiXSculptObject = altDriver.WaitForObject(By.PATH, "/Canvas/Compass3D/AntiXBar/AntiX");
            ClickOnAxisAntiXSculptObject.Tap();
        }

        public static void ClickEraseBtnSculptObject()
        {
            var ClickEraseBtnSculptObject = altDriver.WaitForObject(By.PATH, "/Canvas/SculptUI(Clone)/InteractiveUIRoot/Tools/Button Erase");
            ClickEraseBtnSculptObject.Tap();
        }

        public static void MoveSliderEraserDiameterSculptObject()
        {
            var MoveSliderEraserDiameterSculptObject = altDriver.WaitForObject(By.PATH, "/Canvas/SculptUI(Clone)/InteractiveUIRoot/BrushSlider/ExtensibleSlider/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderEraserDiameterSculptObject.GetScreenPosition();
            Move(1078.836f, 259.8422f, 1082.42f, 357.4334f);
        }

        public static void ClickOnBrushBtnSculptObject()
        {
            var ClickOnBrushBtnSculptObject = altDriver.WaitForObject(By.PATH, "/Canvas/SculptUI(Clone)/InteractiveUIRoot/Tools/Button Sculpt");
            ClickOnBrushBtnSculptObject.Tap();
        }
        public static void ClickNextStepBtnSculptObject()
        {
            var ClickNextStepBtnSculptObject = altDriver.WaitForObject(By.PATH, "/Canvas/Navigation Buttons Panel/NavNext Step/Forma Button v3 Contextual");
            ClickNextStepBtnSculptObject.Tap();
        }

        public static void ClickPreviousStepBtnSculptObject()
        {
            var ClickPreviousStepBtnSculptObject = altDriver.WaitForObject(By.PATH, "/Canvas/Navigation Buttons Panel/NavPrev Step/Forma Button v3 Contextual");
            ClickPreviousStepBtnSculptObject.Tap();
        }

        public static void ClickFlattenToolBtnSculptObject()
        {
            var ClickFlattenToolBtnSculptObject = altDriver.WaitForObject(By.PATH, "/Canvas/SculptUI(Clone)/InteractiveUIRoot/Tools/Button Level");
            ClickFlattenToolBtnSculptObject.Tap();
        }

        public static void ClickLimitValueBtnSculptObject()
        {
            var ClickLimitValueBtnSculptObject = altDriver.WaitForObject(By.PATH, "/Canvas/SculptUI(Clone)/InteractiveUIRoot/Limit Value/ButtonAndSlidingPanel/Button");
            ClickLimitValueBtnSculptObject.Tap();
        }

        public static void ClickFillValleyToolBtnSculptObject()
        {
            var ClickFillValleyToolBtnSculptObject = altDriver.WaitForObject(By.PATH, "/Canvas/SculptUI(Clone)/InteractiveUIRoot/Tools/Button Flatten");
            ClickFillValleyToolBtnSculptObject.Tap();
        }

        public static void ClickValidateBtnSculptObject()
        {
            var ClickValidateBtnSculptObject = altDriver.WaitForObject(By.PATH, "/Canvas/Navigation Buttons Panel/NavNext Step/Forma Button v3 Contextual");
            ClickValidateBtnSculptObject.Tap();
        }

        #endregion
        #region Upper Limbs
        public static void FirstPullOnMeshSculptUpperLimbObject()
        {

            altDriver.MoveMouse(new AltVector2(487.4975f, 791.1719f), 1);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1078.836f, 787.5574f), 4);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }
        #endregion
        #region Lower Limbs
        public static void FirstPullOnMeshSculptLowerLimbObject()
        {
            altDriver.MoveMouse(new AltVector2(917.5073f, 1319.179f), 1);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(904.1809f, 956.1625f), 2);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }


        public static void SecondPullOnMeshSculptLowerLimbObject()
        {
            altDriver.MoveMouse(new AltVector2(1088.847f, 1307.655f), 1);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1050.771f, 950.4003f), 2);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }


        public static void FirstPushOnMeshSculptLowerLimbObject()
        {
            altDriver.MoveMouse(new AltVector2(1081.232f, 1238.509f), 1);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1105.981f, 925.4308f), 2);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public static void SecondPushOnMeshSculptLowerLimbObject()
        {
            altDriver.MoveMouse(new AltVector2(1204.977f, 1273.082f), 1);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1227.822f, 931.1931f), 2);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public static void MoveSliderBrushDiameterSculptLowerLimbObject()
        {
            var MoveSliderBrushDiameterSculptLowerLimbObject = altDriver.WaitForObject(By.PATH, "/Canvas/SculptUI(Clone)/InteractiveUIRoot/BrushSlider/ExtensibleSlider/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area");
            var startPosition = MoveSliderBrushDiameterSculptLowerLimbObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(1078.836f, 259.8422f), 1);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1082.42f, 357.4334f), 2);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public static void MoveSliderBrushDiameterToMinSculptLowerLimbObject()
        {
            var MoveSliderBrushDiameterToMinSculptLowerLimbObject = altDriver.WaitForObject(By.PATH, "/Canvas/SculptUI(Clone)/InteractiveUIRoot/BrushSlider/ExtensibleSlider/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area");
            var startPosition = MoveSliderBrushDiameterToMinSculptLowerLimbObject.GetScreenPosition();
            Move(1088.847f, 322.3234f, 1088.847f, 381.8658f);
        }

        public static void EraseAreaOnMeshSculptLowerLimbObject()
        {
            altDriver.MoveMouse(new AltVector2(1204.977f, 1273.082f), 1);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1227.822f, 931.1931f), 2);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public static void MoveSliderLimitValueSculptLowerLimbObject()
        {
            altDriver.MoveMouse(new AltVector2(1329.707f, 306.8306f), 1);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1329.707f, 136.9497f), 2);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public static void CheckLimitValuePullPushSculptLowerLimbObject()
        {
            altDriver.MoveMouse(new AltVector2(1203.073f, 792.9009f), 1);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1225.919f, 633.4807f), 2);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public static void MoveFlattenToolSculptLowerLimbObject()
        {
            altDriver.MoveMouse(new AltVector2(1204.977f, 1273.082f), 1);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1227.822f, 931.1931f), 2);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public static void MoveFillValleyToolBtnSculptObject()
        {
            altDriver.MoveMouse(new AltVector2(1081.232f, 1238.509f), 1);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1105.981f, 925.4308f), 2);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }
        #endregion
        #endregion
        #endregion


/// FREE FORMA MODE HELPERS

        #region Free Forma Mode 

        #region Free Forma - Screen Coordinates Methods - Upper limbs 

        #endregion

        #endregion


/// AUTO FORMA MODE HELPERS

        #region Auto Forma Mode
        
        #region Auto Forma - Screen Coordinates Methods - Upper limbs
        
        // SCREEN COORDINATES METHOD //
        public static void ClickThumbTipLandmarkAutoForma() => Click(1067.905f, 858.2055f);
        public static void ClickDistalEndIndexLandmarkAutoForma() => Click(1125.019f, 871.6506f);
        public static void ClickDistalMiddleFingerLandmarkAutoForma() => Click(1155.479f, 833.2361f);
        public static void ClickDistalRingFingerLandmarkAutoForma() => Click(1121.211f, 792.9009f);
        public static void ClickDistalLittleFingerLandmarkAutoForma() => Click(1214.496f, 769.8522f);
        public static void ClickThumbMetacarpalLandmarkAutoForma() => Click(1111.692f, 863.9677f);
        public static void ClickIndexMetacarpalLandmarkAutoForma() => Click(1092.655f, 915.8273f);
        public static void ClickMiddleMetacarpalLandmarkAutoForma() => Click(1090.751f, 902.3822f);
        public static void ClickRingMetacarpalLandmarkAutoForma() => Click(1085.039f, 900.4614f);
        public static void ClickLittleMetacarpalLandmarkAutoForma() => Click(1079.328f, 881.2542f);
        public static void ClickCreaseCenterMetacarpalLandmarkAutoForma() => Click(932.7375f, 863.9677f);
        public static void ClickMedialBorderMetacarpalLandmarkAutoForma() => Click(1096.462f, 802.5045f);
        public static void ClickWristCreaseCenterLandmarkAutoForma() => Click(1056.483f, 800.5838f);
        /*  public void ClickThumbInterPhalangealLandmark() => Click(1066.6f, 1094.036f);
          public void ClickThumbMetaPhalangealLandmark() => Click(1109.17f, 890.096f);
          public void ClickFirstInterdigitalLandmark() => Click(903.4186f, 968.8098f);
          public void ClickFirstOnMeshToActivateDrawing() => Click(487.4975f, 791.1719f); */
        public static void ClickOnSplintToAddRivetHole1Closing() => Click(452.9865f, 1009.943f);
        public static void ClickOnSplintToAddRivetHole2Closing() => Click(481.5432f, 652.688f);
        public static void ClickOnSplintToAddMushroomPin1Closing() => Click(1155.479f, 986.894f);
        public static void ClickOnSplintToAddMushroomPin2Closing() => Click(1123.115f, 702.6268f);
        public static void ClickOnSplintToAddFreeBeltloop1Closing() => Click(584.3469f, 933.1138f);
        public static void ClickOnSplintToAddFreeBeltloop2Closing() => Click(578.6356f, 729.517f);
        public static void ClickOnSplintToAddSlottedHole1Closing() => Click(1001.273f, 911.9858f);
        public static void ClickOnSplintToAddSlottedHole2Closing() => Click(919.4111f, 767.9315f);
        public static void ClickOnSplintToAddSerialNumber() => Click(679.9304f, 800.6485f);
        #endregion
       
        #region Auto Forma - Fit Methods

        public static void ClickFitBtnMainViewObject()
        {
            var ClickFitBtnMainViewObject = altDriver.WaitForObject(By.PATH, "/Canvas/MainMenu(Clone)/MainMenuBtn(Clone)");
            ClickFitBtnMainViewObject.Tap();
        }

        public static void ClickQuitBtnFitObject()
        {
            var ClickQuitBtnFitObject = altDriver.WaitForObject(By.PATH, "/Fit/LMRunPlacementStep(Clone)/LMRunPlacementStepPanel/Canvas/SubStepPrevButton/Forma Button v3 Tools/Icon");
            ClickQuitBtnFitObject.Tap();
        }

        public static void ClickCancelBtnPopUpFitObject()
        {
            var ClickCancelBtnPopUpFitObject = altDriver.WaitForObject(By.PATH, "/Canvas/WarnPopup(Clone)/Forma Info Panel v3/Content/Bottom Container/Back btn");
            ClickCancelBtnPopUpFitObject.Tap();
        }

        public static void ClickTickBtnFitObject()
        {
            var ClickTickBtnFitObject = altDriver.WaitForObject(By.PATH, "/Fit/LMRunPlacementStep(Clone)/LMRunPlacementStepPanel/Canvas/SubStepNextButton/Forma Button v3 Tools");
            ClickTickBtnFitObject.Tap();
        }

        public static void ClickBackArrowBtnFitObject()
        {
            var ClickBackArrowBtnFitObject = altDriver.WaitForObject(By.PATH, "/Fit/LMRunPlacementStep(Clone)/LMRunPlacementStepPanel/Canvas/SubStepPrevButton/Forma Button v3 Tools/Icon");
            ClickBackArrowBtnFitObject.Tap();
        }

        public static void ClickPreviousStepBtnFitObject()
        {
            var ClickPreviousStepBtnFitObject = altDriver.WaitForObject(By.PATH, "/Fit/LevelNavigationPanel(Clone)/Canvas/NavPrev Step/Forma Button v3 Contextual");
            ClickPreviousStepBtnFitObject.Tap();
        }

        public static void ClickResetPopUpBtnFitObject()
        {
            var ClickResetPopUpBtnFitObject = altDriver.WaitForObject(By.PATH, "/Canvas/Popup(Clone)/Content/Bottom Container/Cancel button");
            ClickResetPopUpBtnFitObject.Tap();
        }

        public static void ClickLenghtBtnFitObject()
        {
            var ClickLenghtBtnFitObject = altDriver.WaitForObject(By.PATH, "/Fit/FitEditorStep(Clone)/FitEditorPanel/Canvas/NonGenerativePatternPan/LevelBottomMenu/Lines/Line2/ShiftLengthSlider/ButtonAndSlidingPanel/Button");
            ClickLenghtBtnFitObject.Tap();
        }

        public static void MoveSliderLengthFitObject()
        {
            var MoveSliderLengthFitObject = altDriver.WaitForObject(By.PATH, "/Fit/FitEditorStep(Clone)/FitEditorPanel/Canvas/NonGenerativePatternPan/LevelBottomMenu/Lines/Line2/ShiftLengthSlider/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderLengthFitObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(748.0715f, 426.0425f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(749.9753f, 251.2565f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public static void MoveSliderLengthTo100FitObject()
        {
            var MoveSliderLengthFitObject = altDriver.WaitForObject(By.PATH, "/Fit/FitEditorStep(Clone)/FitEditorPanel/Canvas/NonGenerativePatternPan/LevelBottomMenu/Lines/Line2/ShiftLengthSlider/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderLengthFitObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(749.9753f, 249.3358f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(749.9753f, 433.7254f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public static void ClickBoundaryWidthBtnFitObject()
        {
            var ClickBoundaryWidthBtnFitObject = altDriver.WaitForObject(By.PATH, "/Fit/FitEditorStep(Clone)/FitEditorPanel/Canvas/NonGenerativePatternPan/LevelBottomMenu/Lines/Line2/BoundaryWidthSlider/ButtonAndSlidingPanel/Button");
            ClickBoundaryWidthBtnFitObject.Tap();
        }

        public static void MoveSliderBoundaryWidthFitObject()
        {
            var MoveSliderLengthFitObject = altDriver.WaitForObject(By.PATH, "/Fit/FitEditorStep(Clone)/FitEditorPanel/Canvas/NonGenerativePatternPan/LevelBottomMenu/Lines/Line2/BoundaryWidthSlider/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderLengthFitObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(1027.579f, 306.8984f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1020.484f, 410.6575f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0);            
        }

        public static void ClickSelectableAlveoleZoneBtnFitObject()
        {
            var ClickSelectableAlveoleZoneBtnFitObject = altDriver.WaitForObject(By.PATH, "/Fit/FitEditorStep(Clone)/TemplateItems/SelectableAlveoleZone");
            ClickSelectableAlveoleZoneBtnFitObject.Tap();
        }

        public static void MoveSliderRadiusFitObject()
        {
            var MoveSliderRadiusFitObject = altDriver.WaitForObject(By.PATH, "/Fit/FitEditorStep(Clone)/FitEditorPanel/Canvas/GenerativePatternPan/Sliders/Radius Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderRadiusFitObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(573.5073f, 181.6719f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(672.8354f, 181.6719f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0);  
        }

        public static void MoveSliderRadiusTo0FitObject()
        {
            var MoveSliderRadiusTo0FitObject = altDriver.WaitForObject(By.PATH, "/Fit/FitEditorStep(Clone)/FitEditorPanel/Canvas/GenerativePatternPan/Sliders/Radius Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderRadiusTo0FitObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(763.3017f, 182.1105f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(565.3092f, 178.269f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0);  
        }

        public static void MoveSliderWidthFitObject()
        {
            var MoveSliderWidthFitObject = altDriver.WaitForObject(By.PATH, "/Fit/FitEditorStep(Clone)/FitEditorPanel/Canvas/GenerativePatternPan/Sliders/Width Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderWidthFitObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(612.9774f, 72.94879f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(761.003f, 63.90094f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0);  
        }

        public static void MoveSliderDensityFitObject()
        {
            var MoveSliderDensityFitObject = altDriver.WaitForObject(By.PATH, "/Fit/FitEditorStep(Clone)/FitEditorPanel/Canvas/GenerativePatternPan/Sliders/Density Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderDensityFitObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(110.882f, 176.9991f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1182.652f, 176.991f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0);  
        }

        public static void ClickGlobalThicknessBtnFitObject()
        {
            var ClickGlobalThicknessBtnFitObject = altDriver.WaitForObject(By.PATH, "/Fit/FitThicknessStep(Clone)/FitThicknessPanel/Canvas/Grid/GlobalThicknessSlider/ButtonAndSlidingPanel/Button/Icon");
            ClickGlobalThicknessBtnFitObject.Tap();
        }

        public static void MoveSliderGlobalThicknessFitObject()
        {
            var MoveSliderGlobalThicknessFitObject = altDriver.WaitForObject(By.PATH, "/Fit/FitThicknessStep(Clone)/FitThicknessPanel/Canvas/Grid/GlobalThicknessSlider/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderGlobalThicknessFitObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(469.4373f, 176.9991f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(460.4661f, 272.0015f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0);  
        }

        public static void ClickGlobalOffsetBtnFitObject()
        {
            var ClickGlobalOffsetBtnFitObject = altDriver.WaitForObject(By.PATH, "/Fit/FitThicknessStep(Clone)/FitThicknessPanel/Canvas/Grid/OffsetSlider/ButtonAndSlidingPanel/Button/Icon");
            ClickGlobalOffsetBtnFitObject.Tap();
        }

        public static void MoveSliderGlobalOffsetFitObject()
        {
            var MoveSliderGlobalOffsetFitObject = altDriver.WaitForObject(By.PATH, "/Fit/FitThicknessStep(Clone)/FitThicknessPanel/Canvas/Grid/OffsetSlider/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderGlobalOffsetFitObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(725.118f, 213.1905f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(729.6036f, 312.7169f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0);  
        }

        public static void ClickBoundaryThicknessBtnFitObject()
        {
            var ClickBoundaryThicknessBtnFitObject = altDriver.WaitForObject(By.PATH, "/Fit/FitThicknessStep(Clone)/FitThicknessPanel/Canvas/Grid/Boundary/BoundaryThicknessSlider/ButtonAndSlidingPanel/Button/Icon");
            ClickBoundaryThicknessBtnFitObject.Tap();
        }

        public static void MoveSliderBoundaryThicknessFitObject()
        {
            var MoveSliderBoundaryThicknessFitObject = altDriver.WaitForObject(By.PATH, "/Fit/FitThicknessStep(Clone)/FitThicknessPanel/Canvas/Grid/Boundary/BoundaryThicknessSlider/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderBoundaryThicknessFitObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(994.2254f, 154.3795f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(998.7411f, 244.858f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0);  
        }

        public static void ClickBoundaryFlareBtnFitObject()
        {
            var ClickBoundaryFlareBtnFitObject = altDriver.WaitForObject(By.PATH, "/Fit/FitThicknessStep(Clone)/FitThicknessPanel/Canvas/Grid/Boundary/FlareSlider/ButtonAndSlidingPanel/Button/Icon");
            ClickBoundaryFlareBtnFitObject.Tap();
        }

        public static void MoveSliderBoundaryFlareFitObject()
        {
            var MoveSliderBoundaryFlareFitObject = altDriver.WaitForObject(By.PATH, "/Fit/FitThicknessStep(Clone)/FitThicknessPanel/Canvas/Grid/Boundary/FlareSlider/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderBoundaryFlareFitObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(1272.364f, 163.4273f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1272.364f, 272.0015f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0);  
        }

        public static void ClickNextStepBtnFitObject()
        {
            var ClickNextStepBtnFitObject = altDriver.WaitForObject(By.PATH, "/Fit/LevelNavigationPanel(Clone)/Canvas/NavNext Step/Forma Button v3 Contextual");
            ClickNextStepBtnFitObject.Tap();
        }

        public static void ClickOkInformationPopUpBtnFitObject()
        {
            var ClickOkInformationPopUpBtnFitObject = altDriver.WaitForObject(By.PATH, "/Canvas/ValidationCheckPopup(Clone)/Content/Bottom Container/Confirm button");
            ClickOkInformationPopUpBtnFitObject.Tap();
        }

        public static void ClickValidateBtnFitObject()
        {
            var ClickValidateBtnFitObject = altDriver.WaitForObject(By.PATH, "/Fit/LevelNavigationPanel(Clone)/Canvas/NavNext Step/Forma Button v3 Contextual");
            ClickValidateBtnFitObject.Tap();
        }

        #endregion
    
        #region Auto Forma - Rail Belt Loop  Methods - Old level, need to be updated with the new build

        public static void ClickBelt0RailObject()
        {
            var ClickBelt0RailObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/ClosingSystemsEditors/BeltLoopsEditors/RailBeltLoopsEditor/RailBeltLoop(Clone)/PreviewMesh");
            ClickBelt0RailObject.Tap();
        }

        public static void ClickBelt1RailObject()
        {
            var ClickBelt1RailObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/ClosingSystemsEditors/BeltLoopsEditors/RailBeltLoopsEditor/RailBeltLoop(Clone)[1]/PreviewMesh");
            ClickBelt1RailObject.Tap();
        }

        public static void ClickBelt2RailObject()
        {
            var ClickBelt2RailObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/ClosingSystemsEditors/BeltLoopsEditors/RailBeltLoopsEditor/RailBeltLoop(Clone)[2]/PreviewMesh");
            ClickBelt2RailObject.Tap();
        }

        public static void ClickBelt3RailObject()
        {
            var ClickBelt3RailObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/ClosingSystemsEditors/BeltLoopsEditors/RailBeltLoopsEditor/RailBeltLoop(Clone)[3]/PreviewMesh");
            ClickBelt3RailObject.Tap();
        }

        public static void ClickBelt4RailObject()
        {
            var ClickBelt4RailObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/ClosingSystemsEditors/BeltLoopsEditors/RailBeltLoopsEditor/RailBeltLoop(Clone)[4]/PreviewMesh");
            ClickBelt4RailObject.Tap();
        }

        public static void ClickBelt5RailObject()
        {
            var ClickBelt5RailObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/ClosingSystemsEditors/BeltLoopsEditors/RailBeltLoopsEditor/RailBeltLoop(Clone)[5]/PreviewMesh");
            ClickBelt5RailObject.Tap();
        }

        public static void ClickBeltLengthRailObject()
        {
            var ClickBeltLengthRailObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/BeltLoopsEditorsPanel/LengthSlider/ButtonAndSlidingPanel/Button");
            ClickBeltLengthRailObject.Tap();
        }

        public static void MoveSliderBeltLengthRailObject()
        {
            var MoveSliderBeltLengthRailObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/BeltLoopsEditorsPanel/LengthSlider/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderBeltLengthRailObject.GetScreenPosition();
            Move(361.7824f, 213.1905f, 361.7824f, 244.858f);
        }

        public static void ClickBeltClearanceRailObject()
        {
            var ClickBeltClearanceRailObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/BeltLoopsEditorsPanel/ClearanceSlider/ButtonAndSlidingPanel/Button");
            ClickBeltClearanceRailObject.Tap();
        }

        public static void MoveSliderBeltClearanceRailObject()
        {
            var MoveSliderBeltClearanceRailObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/BeltLoopsEditorsPanel/ClearanceSlider/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderBeltClearanceRailObject.GetScreenPosition();
            Move(626.4342f, 249.3819f, 626.4342f, 321.7647f);
        }

        public static void ClickBeltWidthRailObject()
        {
            var ClickBeltWidthRailObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/BeltLoopsEditorsPanel/WidthSlider/ButtonAndSlidingPanel/Button");
            ClickBeltWidthRailObject.Tap();
        }

        public static void MoveSliderBeltWidthRailObject()
        {
            var MoveSliderBeltWidthRailObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/BeltLoopsEditorsPanel/WidthSlider/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderBeltWidthRailObject.GetScreenPosition();
            Move(895.5717f, 258.4297f, 895.5717f, 339.8604f);
        }

        public static void ClickBeltThicknessRailObject()
        {
            var ClickBeltThicknessRailObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/BeltLoopsEditorsPanel/ThicknessSlider/ButtonAndSlidingPanel/Button");
            ClickBeltThicknessRailObject.Tap();
        }

        public static void MoveSliderBelThicknessRailObject()
        {
            var MoveSliderBelThicknessRailObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/BeltLoopsEditorsPanel/ThicknessSlider/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderBelThicknessRailObject.GetScreenPosition();
            Move(1169.195f, 163.4273f, 1164.709f, 231.2862f);
        }

        public static void ClickBeltTrashRailObject()
        {
            var ClickBeltTrashRailObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/BeltLoopsEditorsPanel/DeleteButton");
            ClickBeltTrashRailObject.Tap();
        }

        public static void ClickResetBtnRailObject()
        {
            var ClickResetBtnRailObject = altDriver.WaitForObject(By.PATH, "/Canvas/RailBeltLoopPersPan(Clone)");
            ClickResetBtnRailObject.Tap();
        }

        public static void ClickCancelExitLevelBtnRailObject()
        {
            var ClickCancelExitLevelBtnRailObject = altDriver.WaitForObject(By.PATH, "/Canvas/WarnPopup(Clone)/Forma Info Panel v3/Content/Bottom Container/Back btn");
            ClickCancelExitLevelBtnRailObject.Tap();
        }

        public static void ClickConfirmExitLevelBtnRailObject()
        {
            var ClickConfirmExitLevelBtnRailObject = altDriver.WaitForObject(By.PATH, "/Canvas/WarnPopup(Clone)/Forma Info Panel v3/Content/Bottom Container/Do it btn");
            ClickConfirmExitLevelBtnRailObject.Tap();
        }

        public static void ClickQuitBtnRailObject()
        {
            var ClickQuitBtnRailObject = altDriver.WaitForObject(By.PATH, "/Canvas/Navigation Buttons Panel/NavPrev Step/Forma Button v3 Contextual/Text");
            ClickQuitBtnRailObject.Tap();
        }

        public static void ClickNextStepBtnRailObject()
        {
            var ClickNextStepBtnRailObject = altDriver.WaitForObject(By.PATH, "/Canvas/Navigation Buttons Panel/NavNext Step/Forma Button v3 Contextual/Text");
            ClickNextStepBtnRailObject.Tap();
        }

        public static void ClickPreviousStepBtnRailObject()
        {
            var ClickPreviousStepBtnRailObject = altDriver.WaitForObject(By.PATH, "/Canvas/Navigation Buttons Panel/NavPrev Step/Forma Button v3 Contextual");
            ClickPreviousStepBtnRailObject.Tap();
        }

        public static void ClickValidateBtnRailObject()
        {
            var ClickValidateBtnRailObject = altDriver.WaitForObject(By.PATH, "/Canvas/Navigation Buttons Panel/NavNext Step/Forma Button v3 Contextual");
            ClickValidateBtnRailObject.Tap();
        }

        #endregion

        #region Auto Forma - Closing Systems Methods 

        public static void ClickClosingSystemsBtnMainViewObject()
        {
            var ClickClosingSystemsBtnMainViewObject = altDriver.WaitForObject(By.PATH, "/Canvas/MainMenu(Clone)/MainMenuBtn(Clone)[1]");
            ClickClosingSystemsBtnMainViewObject.Tap();
        }

        public static void ClickQuitBtnClosingObject()
        {
            var ClickQuitBtnClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/LevelNavigationPanel(Clone)/Canvas/NavPrev Step/Forma Button v3 Contextual");
            ClickQuitBtnClosingObject.Tap();
        }

        public static void ClickShowMenuClosingSystemBtnClosingObject()
        {
            var ClickShowMenuClosingSystemBtnClosingObject = altDriver.WaitForObject(By.PATH,"/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/ClosingSystemsEditorPanel/ClosingSystemsDropdown");
            ClickShowMenuClosingSystemBtnClosingObject.Tap();
        }

        public static void ClickRivetHoleClosingSystemBtnClosingObject()
        {
            var ClickRivetHoleClosingSystemBtnClosingObject = altDriver.WaitForObject(By.PATH,"/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/ClosingSystemsEditorPanel/ClosingSystemsDropdown/Dropdown List/Viewport/Content/Item 0: Rivet  Hole");
            ClickRivetHoleClosingSystemBtnClosingObject.Tap();
        }

        public static void ClickMushroomPinClosingSystemBtnClosingObject()
        {
            var ClickMushroomPinClosingSystemBtnClosingObject = altDriver.WaitForObject(By.PATH,"/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/ClosingSystemsEditorPanel/ClosingSystemsDropdown/Dropdown List/Viewport/Content/Item 1: Pin");
            ClickMushroomPinClosingSystemBtnClosingObject.Tap();
        }

        public static void ClickFreeBeltLoopClosingSystemBtnClosingObject()
        {
            var ClickFreeBeltLoopClosingSystemBtnClosingObject = altDriver.WaitForObject(By.PATH,"/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/ClosingSystemsEditorPanel/ClosingSystemsDropdown/Dropdown List/Viewport/Content/Item 2: Free  Belt  Loop");
            ClickFreeBeltLoopClosingSystemBtnClosingObject.Tap();
        }

        public static void ClickSlottedHoleClosingSystemBtnClosingObject()
        {
            var ClickSlottedHoleClosingSystemBtnClosingObject = altDriver.WaitForObject(By.PATH,"/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/ClosingSystemsEditorPanel/ClosingSystemsDropdown/Dropdown List/Viewport/Content/Item 3: Slotted Hole");
            ClickSlottedHoleClosingSystemBtnClosingObject.Tap();
        }

        public static void ClickRailBeltLoopClosingSystemBtnClosingObject()
        {
            var ClickRailBeltLoopClosingSystemBtnClosingObject = altDriver.WaitForObject(By.PATH,"/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/ClosingSystemsEditorPanel/ClosingSystemsDropdown/Dropdown List/Viewport/Content/Item 4: Rail  Belt  Loops");
            ClickRailBeltLoopClosingSystemBtnClosingObject.Tap();
        }

        public static void ClickRotateScanAntiYClosingObject()
        {
            var ClickRotateScanAntiYClosingObject = altDriver.WaitForObject(By.PATH, "/Canvas/Compass3D/AntiYBar/AntiY");
            ClickRotateScanAntiYClosingObject.Tap();
        }

        public static void ClickRotateScanYClosingObject()
        {
            var ClickRotateScanYClosingObject = altDriver.WaitForObject(By.PATH, "/Canvas/Compass3D/YBar/Y/YLabel");
            ClickRotateScanYClosingObject.Tap();
        }

        public static void ClickRotateScanXClosingObject()
        {
            var ClickRotateScanXClosingObject = altDriver.WaitForObject(By.PATH, "/Canvas/Compass3D/XBar/X/XLabel");
            ClickRotateScanXClosingObject.Tap();
        }

        public static void ClickBackArrowBtnClosingObject()
        {
            var ClickBackArrowBtnClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/ClosingSystemPlacementPanel/CancelButton");
            ClickBackArrowBtnClosingObject.Tap();
        }

        public static void ClickTickBtnClosingObject()
        {
            var ClickTickBtnClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/ClosingSystemPlacementPanel/ConfirmButton");
            ClickTickBtnClosingObject.Tap();
        }

        public static void ClickOnPlacedRivetHoleClosingObject()
        {
            var ClickOnPlacedRivetHoleClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/ClosingSystemsEditors/RivetHolesEditor/RivetHole(Clone)");
            ClickOnPlacedRivetHoleClosingObject.Tap();
        }

        public static void ClickOnSecondPlacedRivetHoleClosingObject()
        {
            var ClickOnSecondPlacedRivetHoleClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/ClosingSystemsEditors/RivetHolesEditor/RivetHole(Clone)[1]");
            ClickOnSecondPlacedRivetHoleClosingObject.Tap();
        }

        public static void ClickOnDiameterRivetHoleClosingObject()
        {
            var ClickOnDiameterRivetHoleClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/RivetHolesEditorPanel/DiameterSlider/ButtonAndSlidingPanel/Button");
            ClickOnDiameterRivetHoleClosingObject.Tap();
        }

        public static void MoveSliderDiameterRivetHoleClosingObject()
        {
            var MoveSliderDiameterRivetHoleClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/RivetHolesEditorPanel/DiameterSlider/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderDiameterRivetHoleClosingObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(496.7733f, 241.6529f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(502.4847f, 418.3596f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0);  
        }

        public static void ClickSelectAllRivetHoleClosingObject()
        {
            var ClickSelectAllRivetHoleClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/RivetHolesEditorPanel/SelectAllButton");
            ClickSelectAllRivetHoleClosingObject.Tap();
        }

        public static void ClickOnPlacedMushroomPinClosingObject()
        {
            var ClickOnPlacedMushroomPinClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/ClosingSystemsEditors/PinsEditor/Pin(Clone)/PreviewMesh");
            ClickOnPlacedMushroomPinClosingObject.Click();
        }

        public static void ClickOnSecondPlacedMushroomPinClosingObject()
        {
            var ClickOnSecondPlacedMushroomPinClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/ClosingSystemsEditors/PinsEditor/Pin(Clone)[1]/PreviewMesh");
            ClickOnSecondPlacedMushroomPinClosingObject.Tap();
        }

        public static void ClickOnScaleMushroomPinClosingObject()
        {
            var ClickOnScaleMushroomPinClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/PinsEditorPanel/ScaleSlider/ButtonAndSlidingPanel/Button");
            ClickOnScaleMushroomPinClosingObject.Tap();
        }

        public static void MoveSliderScaleMushroomPinClosingObject()
        {
            var MoveSliderScaleMushroomPinClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/PinsEditorPanel/ScaleSlider/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderScaleMushroomPinClosingObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(477.7356f, 180.1897f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(481.5432f, 416.4388f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0); 
        }

        public static void ClickSelectAllMushroomPinClosingObject()
        {
            var ClickSelectAllMushroomPinClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/PinsEditorPanel/SelectAllButton");
            ClickSelectAllMushroomPinClosingObject.Tap();
        }

        public static void ClickOnPlacedFreeBeltLoopClosingObject()
        {
            var ClickOnPlacedFreeBeltLoopClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/ClosingSystemsEditors/BeltLoopsEditors/FreeBeltLoopsEditor/FreeBeltLoop(Clone)/PreviewMesh");
            ClickOnPlacedFreeBeltLoopClosingObject.Click();
        }

        public static void ClickOnSecondPlacedFreeBeltLoopClosingObject()
        {
            var ClickOnSecondPlacedMushroomPinClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/ClosingSystemsEditors/PinsEditor/Pin(Clone)[1]/PreviewMesh");
            ClickOnSecondPlacedMushroomPinClosingObject.Tap();
        }

        public static void ClickOnPlacedSlottedHoleClosingObject()
        {
            var ClickOnPlacedSlottedHoleClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/ClosingSystemsEditors/SlottedHolesEditor/SlottedHole(Clone)/PreviewMesh");
            ClickOnPlacedSlottedHoleClosingObject.Click();
        }

        public static void ClickOnSecondPlacedSlottedHoleClosingObject()
        {
            var ClickOnSecondPlacedMushroomPinClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/ClosingSystemsEditors/SlottedHolesEditor/SlottedHole(Clone)[1]/PreviewMesh");
            ClickOnSecondPlacedMushroomPinClosingObject.Tap();
        }

        public static void ClickOnLengthSlottedHoleClosingObject()
        {
            var ClickOnLengthSlottedHoleClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/SlottedHolesEditorPanel/Background/LengthDropdown/NumberedDropdown/ButtonAndLabels/Button");
            ClickOnLengthSlottedHoleClosingObject.Tap();
        }

        public static void ClickOnLength15mmSlottedHoleClosingObject()
        {
            var ClickOnLengthSlottedHoleClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/SlottedHolesEditorPanel/Background/LengthDropdown/NumberedDropdown/Dropdown List/Viewport/Content/Item 2: 15 mm");
            ClickOnLengthSlottedHoleClosingObject.Tap();
        }

        public static void ClickOnLength35mmSlottedHoleClosingObject()
        {
            var ClickOnLength35mmSlottedHoleClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/SlottedHolesEditorPanel/Background/LengthDropdown/NumberedDropdown/Dropdown List/Viewport/Content/Item 0: 35 mm");
            ClickOnLength35mmSlottedHoleClosingObject.Tap();
        }

        public static void ClickSelectAllSlottedHoleClosingObject()
        {
            var ClickSelectAllSlottedHoleClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/SlottedHolesEditorPanel/Background/SelectAllButton");
            ClickSelectAllSlottedHoleClosingObject.Tap();
        }

        public static void ClickNextStepBtnClosingObject()
        {
            var ClickNextStepBtnClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/LevelNavigationPanel(Clone)/Canvas/NavNext Step/Forma Button v3 Contextual");
            ClickNextStepBtnClosingObject.Tap();
        }

        public static void ClickPreviousStepBtnClosingObject()
        {
            var ClickPreviousStepBtnClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/LevelNavigationPanel(Clone)/Canvas/NavPrev Step/Forma Button v3 Contextual");
            ClickPreviousStepBtnClosingObject.Tap();
        }

        public static void ClickValidateBtnClosingObject()
        {
            var ClickValidateBtnClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/LevelNavigationPanel(Clone)/Canvas/NavNext Step/Forma Button v3 Contextual");
            ClickValidateBtnClosingObject.Tap();
        }

        public static void ClickOnPlacedFreeBeltClosingObject()
        {
            var ClickOnPlacedFreeBeltClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/ClosingSystemsEditors/BeltLoopsEditors/FreeBeltLoopsEditor/FreeBeltLoop(Clone)");
            ClickOnPlacedFreeBeltClosingObject.Tap();
        }

        public static void ClickOnThicknessFreeBeltClosingObject()
        {
            var ClickOnThicknessFreeBeltClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/BeltLoopsEditorsPanel/ThicknessSlider/ButtonAndSlidingPanel/Button");
            ClickOnThicknessFreeBeltClosingObject.Tap();
        }

        public static void MoveSliderThicknessFreeBeltClosingObject()
        {
            var MoveSliderThicknessFreeBeltClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/BeltLoopsEditorsPanel/ThicknessSlider/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderThicknessFreeBeltClosingObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(478.9281f, 452.9326f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(470.1205f, 525.9202f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0); 
        }

        public static void ClickOnLengthFreeBeltClosingObject()
        {
            var ClickOnLengthFreeBeltClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/BeltLoopsEditorsPanel/LengthSlider/ButtonAndSlidingPanel/Button");
            ClickOnLengthFreeBeltClosingObject.Tap();
        }

        public static void MoveSliderLengthFreeBeltClosingObject()
        {
            var MoveSliderLengthFreeBeltClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/BeltLoopsEditorsPanel/LengthSlider/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderLengthFreeBeltClosingObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(468.2167f, 249.3358f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(470.1205f, 370.3415f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0); 
        }

        public static void ClickOnClearanceFreeBeltClosingObject()
        {
            var ClickOnClearanceFreeBeltClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/BeltLoopsEditorsPanel/ClearanceSlider/ButtonAndSlidingPanel/Button");
            ClickOnClearanceFreeBeltClosingObject.Tap();
        }

        public static void MoveSliderClearanceFreeBeltClosingObject()
        {
            var MoveSliderClearanceFreeBeltClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/BeltLoopsEditorsPanel/ClearanceSlider/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderClearanceFreeBeltClosingObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(730.9375f, 424.1218f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(738.5526f, 545.1274f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0); 
        }

        public static void ClickOnWidthFreeBeltClosingObject()
        {
            var ClickOnWidthFreeBeltClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/BeltLoopsEditorsPanel/WidthSlider/ButtonAndSlidingPanel/Button");
            ClickOnWidthFreeBeltClosingObject.Tap();
        }

        public static void MoveSliderWidthFreeBeltClosingObject()
        {
            var MoveSliderWidthFreeBeltClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/BeltLoopsEditorsPanel/WidthSlider/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area/Handle");
            var startPosition = MoveSliderWidthFreeBeltClosingObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(736.6489f, 228.2078f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(734.7451f, 328.0855f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0); 
        }

        public static void ClickOnSecondPlacedFreeBeltClosingObject()
        {
            var ClickOnSecondPlacedFreeBeltClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/ClosingSystemsEditors/BeltLoopsEditors/FreeBeltLoopsEditor/FreeBeltLoop(Clone)[1]");
            ClickOnSecondPlacedFreeBeltClosingObject.Tap();
        }

        public static void ClickSelectAllFreeBeltClosingObject()
        {
            var ClickSelectAllFreeBeltClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/BeltLoopsEditorsPanel/SelectAllButton");
            ClickSelectAllFreeBeltClosingObject.Tap();
        }

        public static void ClickAddRailBeltClosingObject()
        {
            var ClickAddRailBeltClosingObject = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/Canvas/BottomMenu/ClosingSystemsEditorPanel/ClosingSystemsDropdown/Dropdown List/Viewport/Content/Item 4: Rail  Belt  Loops");
            ClickAddRailBeltClosingObject.Tap();
        }

        public static void CorrectRailBeltLoopPosition()
        {
            var CorrectRailBeltLoopPosition = altDriver.WaitForObject(By.PATH, "/ClosingSystems/ClosingSystemsEditorStep(Clone)/ClosingSystemsEditors/BeltLoopsEditors/RailBeltLoopsEditor/RailBeltLoop(Clone)[2]/PreviewMesh");
            CorrectRailBeltLoopPosition.Tap();
            altDriver.MoveMouse(new AltVector2(1092.655f, 946.5588f), 0.25f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(980.3318f, 823.6324f), 0.5f);
            altDriver.KeyUp(AltKeyCode.Mouse0); 
        }

        #endregion

        #region Auto Forma - Serial Number Engraver Methods

        public static void ClickSerialNumberBtnMainViewObject()
        {
            var ClickSerialNumberBtnMainViewObject = altDriver.WaitForObject(By.PATH, "/Canvas/MainMenu(Clone)/MainMenuBtn(Clone)[3]");
            ClickSerialNumberBtnMainViewObject.Tap();
        }

        public static void ClickQuitBtnSerialNumberObject()
        {
            var ClickQuitBtnSerialNumberObject = altDriver.WaitForObject(By.PATH, "/Canvas/Navigation Buttons Panel/NavPrev Step/Forma Button v3 Contextual");
            ClickQuitBtnSerialNumberObject.Tap();
        }

        public static void ClickCancelBtnPopUpSerialNumberObject()
        {
            var ClickCancelBtnPopUpSerialNumberObject = altDriver.WaitForObject(By.PATH, "/Canvas/WarnPopup(Clone)/Forma Info Panel v3/Content/Bottom Container/Back btn");
            ClickCancelBtnPopUpSerialNumberObject.Tap();
        }

        public static void ClickConfirmBtnPopUpSerialNumberObject()
        {
            var ClickConfirmBtnPopUpSerialNumberObject = altDriver.WaitForObject(By.PATH, "/Canvas/WarnPopup(Clone)/Forma Info Panel v3/Content/Bottom Container/Do it btn");
            ClickConfirmBtnPopUpSerialNumberObject.Tap();
        }

        public static void ClickNextStepBtnPopUpSerialNumberObject()
        {
            var ClickNextStepBtnPopUpSerialNumberObject = altDriver.WaitForObject(By.PATH, "/Canvas/Navigation Buttons Panel/NavNext Step/Forma Button v3 Contextual");
            ClickNextStepBtnPopUpSerialNumberObject.Tap();
        }

        #endregion

        #endregion


    }
}