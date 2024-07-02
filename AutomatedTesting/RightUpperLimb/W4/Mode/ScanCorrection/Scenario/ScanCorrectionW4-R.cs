using System;
using AltTester.AltTesterUnitySDK.Driver;
using NUnit.Framework;
using System.Threading;

public partial class FullScanCorrectionW4R
{
    private AltDriver altDriver;
    private ScanCorrectionHelpersW4R helpers; // Utiliser une instance des helpers pour accéder aux méthodes.

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        altDriver = new AltDriver(host: "192.168.1.13", port: 13000, appName: "__default__");        helpers = new ScanCorrectionHelpersW4R(altDriver); // Initialisation avec le driver.
    }

    [OneTimeTearDown]
    public void TearDown()
    {
        altDriver.Stop();
    }

    [Test]
    public void FullScanCorrectionW4Workflow()
    {
        ExecuteCleanupLevel();
        ExecutePoseLevel();
        ExecuteThumbLevel();
        ExecuteSculptLevel();

    }

    private void ExecuteCleanupLevel()
    {
        altDriver.SetDelayAfterCommand(0.12f);
        helpers.ClickCleanupBtnMainViewObject();
        helpers.ClickSelectPartOfInterestArmRightA2(); // Cannot use object here, use coordinate.
        helpers.ClickQuitBtnObject();
        helpers.ClickConfirmBtnPopUpObject();
        helpers.ClickCleanupBtnMainViewObject();
        helpers.ClickSelectPartOfInterestArmRightA2(); // Cannot use object here, use coordinate.
        helpers.ClickNextStepBtnObject();
        helpers.ClickCrossBtnObject();
        RepeatPreviousStep();
        SetCleanupLandmarks();
        helpers.ClickPreviousStepBtnObject();
        helpers.ClickKeepBtnLandmarksPopUpObject();
        helpers.CuttingPlanePositionObject();
        helpers.ClickVerticalAngleBtnObject();
        helpers.MoveVerticalSliderCuttingPlanePositionObject();
        helpers.ClickVerticalAngleBtnObject();
        helpers.ClickHorizontalAngleBtnObject();
        helpers.MoveHorizontalSliderCuttingPlanePositionObject();
        helpers.ClickHorizontalAngleBtnObject();
        helpers.ClickResetPlaneBtnObject();
        helpers.CuttingPlanePositionObject();
        helpers.ClickNextStepBtnObject();
        helpers.ClickPreviousStepBtnObject();
        helpers.CuttingPlanePositionObject();
        helpers.ClickNextStepBtnObject();
        helpers.ClickValidateBtnObject(); // Once the level has been fully completed one time, repeat all previous steps.
        ExecuteFullCleanupLevel();
    }

    private void ExecuteFullCleanupLevel()
    {
        helpers.ClickCleanupBtnMainViewObject();
        helpers.ClickConfirmBtnPopUpObject();
        helpers.VerifyAndAssertText("/Cleanup/LevelNavigationPanel(Clone)/Canvas/StatusText/Variable Size Container/Text", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.SelectPartOfScanText);
        helpers.ClickSelectPartOfInterestArmRightA2();
        helpers.ClickQuitBtnObject();
        helpers.VerifyAndAssertText("/Canvas/WarnPopup(Clone)/Forma Info Panel v3/Content/Content text", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.ModificationsWillBeLostText);
        helpers.ClickConfirmBtnPopUpObject();
        helpers.ClickCleanupBtnMainViewObject();
        helpers.VerifyAndAssertText("/Cleanup/LevelNavigationPanel(Clone)/Canvas/StatusText/Variable Size Container/Text", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.SelectPartOfScanText);
        helpers.ClickSelectPartOfInterestArmRightA2();
        helpers.ClickNextStepBtnObject();
        helpers.VerifyAndAssertText("/Cleanup/LevelNavigationPanel(Clone)/Canvas/StatusText/Variable Size Container/Text", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.PositionLandmarkText);
        helpers.VerifyAndAssertText("/Cleanup/LMRunPlacementStep(Clone)/LMRunPlacementStepPanel/Canvas/ImageContainer/Label", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.WristCreaseCenterText);
        helpers.ClickCrossBtnObject(); // Return to Step 1 of Cleanup. Repeat the previous step.
        helpers.VerifyAndAssertText("/Cleanup/LevelNavigationPanel(Clone)/Canvas/StatusText/Variable Size Container/Text", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.SelectPartOfScanText);
        RepeatPreviousStep();
        helpers.VerifyAndAssertText("/Cleanup/LevelNavigationPanel(Clone)/Canvas/StatusText/Variable Size Container/Text", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.PositionLandmarkText);
        helpers.VerifyAndAssertText("/Cleanup/LMRunPlacementStep(Clone)/LMRunPlacementStepPanel/Canvas/ImageContainer/Label", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.WristCreaseCenterText);
        SetCleanupLandmarks();
        helpers.ClickPreviousStepBtnObject();
        helpers.VerifyAndAssertText("/Canvas/Popup(Clone)/Content/Content text", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.OldLandmarksOrSetAgainText);
        helpers.ClickKeepBtnLandmarksPopUpObject();
        helpers.VerifyAndAssertText("/Cleanup/LevelNavigationPanel(Clone)/Canvas/StatusText/Variable Size Container/Text", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.SelectPartOfScanCropOffText);
        helpers.CuttingPlanePositionObject();
        helpers.ClickVerticalAngleBtnObject();
        helpers.MoveVerticalSliderCuttingPlanePositionObject();
        helpers.ClickVerticalAngleBtnObject();
        helpers.ClickHorizontalAngleBtnObject();
        helpers.MoveHorizontalSliderCuttingPlanePositionObject();
        helpers.ClickHorizontalAngleBtnObject();
        helpers.ClickResetPlaneBtnObject();
        helpers.CuttingPlanePositionObject();
        helpers.ClickNextStepBtnObject();
        helpers.VerifyAndAssertText("/Cleanup/LevelNavigationPanel(Clone)/Canvas/StatusText/Variable Size Container/Text", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.CheckConfirmScanText);
        helpers.ClickPreviousStepBtnObject();
        helpers.CuttingPlanePositionObject();
        helpers.ClickNextStepBtnObject();
        helpers.VerifyAndAssertText("/Cleanup/LevelNavigationPanel(Clone)/Canvas/StatusText/Variable Size Container/Text", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.CheckConfirmScanText);
        helpers.ClickValidateBtnObject();
    }

    private void RepeatPreviousStep()
    {
        helpers.ClickQuitBtnObject();
        helpers.VerifyAndAssertText("/Canvas/WarnPopup(Clone)/Forma Info Panel v3/Content/Content text", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.ModificationsWillBeLostText);
        helpers.ClickConfirmBtnPopUpObject();
        helpers.ClickCleanupBtnMainViewObject();
        helpers.VerifyAndAssertText("/Cleanup/LevelNavigationPanel(Clone)/Canvas/StatusText/Variable Size Container/Text", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.SelectPartOfScanText);
        helpers.ClickSelectPartOfInterestArmRightA2();
        helpers.ClickNextStepBtnObject();
    }

    private void SetCleanupLandmarks()
    {
        helpers.ClickWristCreaseCenterCleanupLandmark();
        helpers.ClickTickBtnObject();
        helpers.VerifyAndAssertText("/Cleanup/LMRunPlacementStep(Clone)/LMRunPlacementStepPanel/Canvas/ImageContainer/Label", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.VentralArmText);
        helpers.ClickBackArrowBtnObject();
        helpers.VerifyAndAssertText("/Cleanup/LMRunPlacementStep(Clone)/LMRunPlacementStepPanel/Canvas/ImageContainer/Label", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.WristCreaseCenterText);
        helpers.ClickWristCreaseCenterCleanupLandmark();
        helpers.ClickTickBtnObject();
        helpers.VerifyAndAssertText("/Cleanup/LMRunPlacementStep(Clone)/LMRunPlacementStepPanel/Canvas/ImageContainer/Label", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.VentralArmText);
        helpers.ClickVentralArmCleanupLandmark();
        helpers.ClickTickBtnObject();

    }


    private void ExecutePoseLevel()
    {

        /// STEPS FOR THE NEW EDITOR. PUT THEM BACK WHEN THE OLD EDITOR HAS BEEN REPLACED///
        /// 
        //ClickPoseBtnMainViewObject();
        //VerifyAndAssertText("/Pose/LevelNavigationPanel(Clone)/Canvas/StatusText/Variable Size Container/Text", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.PosingModeSelectionText);
        //ClickQuitBtnPoseObject();
        //VerifyAndAssertText("/Canvas/WarnPopup(Clone)/Forma Info Panel v3/Content/Content text", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.ModificationsWillBeLostText);
        //ClickConfirmBtnPopUpObject();
        //ClickPoseBtnMainViewObject();
        //VerifyAndAssertText("/Pose/LevelNavigationPanel(Clone)/Canvas/StatusText/Variable Size Container/Text", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.PosingModeSelectionText);
        //ClickAdvancedPoseBtnObject();
        //VerifyAndAssertText("/Pose/LevelNavigationPanel(Clone)/Canvas/StatusText/Variable Size Container/Text", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.PositionLandmarkText);
        //VerifyAndAssertText("/Pose/LMRunPlacementStep(Clone)/LMRunPlacementStepPanel/Canvas/ImageContainer/Label", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.ThumbTipText);
        //SetPoseLandmarks();
        //PerformRepeatedClicks(ClickBackArrowBtnPoseObject, 12);
        //PerformRepeatedClicks(ClickTickBtnPoseObject, 13);
        //BeingProcessed();
        //VerifyAndAssertText("/Pose/LevelNavigationPanel(Clone)/Canvas/StatusText/Variable Size Container/Text", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.CheckTheLimbPoseText);
        //ClickPreviousStepBtnPoseObject();
        //VerifyAndAssertText("/Canvas/Popup(Clone)/Content/Content text", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.OldLandmarksOrSetAgainText);
        //ClickResetBtnPopUpObject();
        //ClickThumbTipLandmark();
        //PerformRepeatedClicks(ClickTickBtnPoseObject, 13);
        //BeingProcessed();
        //ClickHandExtFlexBtnObject();
        //VerifyAndAssertText("/Canvas/PosePan(Clone)/SliderPanel/PoseSlider(Clone)/SlideMask/Background/Title", HandExtFlexSliderText);
        //MoveSliderHandExtFlexObject();
        //ClickHandAdAbBtnObject();
        //VerifyAndAssertText("/Canvas/PosePan(Clone)/SliderPanel/PoseSlider(Clone)[1]/SlideMask/Background/Title", HandAdAbSliderText);
        //MoveSliderHandAdAbObject();
        //ClickThumbExtFlexBtnObject();
        //VerifyAndAssertText("/Canvas/PosePan(Clone)/SliderPanel/PoseSlider(Clone)[2]/SlideMask/Background/Title", ThumbExtFlexText);
        //MoveSliderThumbExtFlexObject();
        //PerformRepeatedClicks(ClickUndoBtnPoseObject, 3);
        //PerformRepeatedClicks(ClickRedoBtnPoseObject, 3);
        //ClickThumbAdAbBtnObject();
        //VerifyAndAssertText("/Canvas/PosePan(Clone)/SliderPanel/PoseSlider(Clone)[3]/SlideMask/Background/Title", ThumbAdAbText);
        //MoveSliderThumbAdAbObject();
        //ClickFingerExtFlexBtnObject();
        //VerifyAndAssertText("/Canvas/PosePan(Clone)/SliderPanel/PoseSlider(Clone)[4]/SlideMask/Background/Title", FingerExtFlexText);
        //MoveSliderFingerExtFlexObject();
        //ClickFingerSplayBtnObject();
        //VerifyAndAssertText("/Canvas/PosePan(Clone)/SliderPanel/PoseSlider(Clone)[5]/SlideMask/Background/Title", FingerSplayText);
        //MoveSliderFingerSplayObject();
        //ClickFingerSplayBtnObject();
        //ClickNeutralPoseBtnObject();
        //ClickResetSliderPoseBtnObject();
        //ClickAppearanceBtnObject();
        //VerifyAndAssertText("/Canvas/PosePan(Clone)/BottomPanel/MatDropDown/Dropdown List/Viewport/Content/Item 0: Normal/Item Label", NormalAppearanceText);
        //VerifyAndAssertText("/Canvas/PosePan(Clone)/BottomPanel/MatDropDown/Dropdown List/Viewport/Content/Item 1: Transparent/Item Label", TransparentAppearanceText);
        //VerifyAndAssertText("/Canvas/PosePan(Clone)/BottomPanel/MatDropDown/Dropdown List/Viewport/Content/Item 2: Neutral ghost/Item Label", NeutralGhostAppearanceText);
        //ClickTransparentChoiceBtnObject();
        //ClickAppearanceBtnObject();
        //ClickNeutralGhostChoiceBtnObject();
        //ClickHandExtFlexBtnObject();
        //VerifyAndAssertText("/Canvas/PosePan(Clone)/SliderPanel/PoseSlider(Clone)/SlideMask/Background/Title", HandExtFlexSliderText);
        //MoveSliderHandExtFlexObject();
        //ClickPreviousStepBtnPoseObject();
        //VerifyAndAssertText("/Canvas/Popup(Clone)/Content/Content text", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.OldLandmarksOrSetAgainText);
        //ClickKeepBtnLandmarksPopUpObject(); // Repeat all actions for this step (pose editor) until PreviousStepBtn
        //BeingProcessed();
        //ExecutePoseEditorSteps();
        //ClickValidateBtnPoseObject();
        //ClickPoseBtnMainViewObject();
        //VerifyAndAssertText("/Canvas/WarnPopup(Clone)/Forma Info Panel v3/Content/Content text", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.AllChangesLostText);
        //ClickConfirmBtnPopUpObject();
        //VerifyAndAssertText("/Pose/LevelNavigationPanel(Clone)/Canvas/StatusText/Variable Size Container/Text", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.PosingModeSelectionText);
        //ClickAdvancedPoseBtnObject();
        //VerifyAndAssertText("/Canvas/Popup(Clone)/Content/Content text", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.OldLandmarksOrSetAgainText);
        //ClickKeepBtnLandmarksPopUpObject();//Repeat one last time the actions performed in the step editor and validate again)
        //BeingProcessed();
        //ExecutePoseEditorSteps(); 
        //ClickResetSliderPoseBtnObject();
        //ClickValidateBtnPoseObject();

        // STEPS FOR OLD EDITOR
        helpers.ClickPoseBtnMainViewObject();
        helpers.VerifyAndAssertText("/Canvas/StatusText/Variable Size Container/Text", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.PosingModeSelectionText);
        helpers.ClickQuitBtnPoseObject();
        helpers.VerifyAndAssertText("/Canvas/WarnPopup(Clone)/Forma Info Panel v3/Content/Content text", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.ModificationsWillBeLostText);
        helpers.ClickConfirmBtnPopUpObject();
        helpers.ClickPoseBtnMainViewObject();
        helpers.VerifyAndAssertText("/Canvas/StatusText/Variable Size Container/Text", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.PosingModeSelectionText);
        helpers.ClickAdvancedPoseBtnObject();
        helpers.VerifyAndAssertText("/Canvas/StatusText/Variable Size Container/Text", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.PositionLandmarkText);
        helpers.VerifyAndAssertText("/PoseCTL/LMRunPlacementStep/LMRunPlacementStepPanel/Canvas/ImageContainer/Label", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.ThumbTipText);
        SetPoseLandmarks();
        helpers.PerformRepeatedClicks(helpers.ClickBackArrowBtnPoseObject, 12);
        helpers.PerformRepeatedClicks(helpers.ClickTickBtnPoseObject, 13);
        helpers.BeingProcessed();
        helpers.VerifyAndAssertText("/Canvas/StatusText/Variable Size Container/Text", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.CheckTheLimbPoseText);
        helpers.ClickPreviousStepBtnPoseObject();
        helpers.VerifyAndAssertText("/Canvas/Popup(Clone)/Content/Content text", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.OldLandmarksOrSetAgainText);
        helpers.ClickResetBtnPopUpObject();
        helpers.ClickThumbTipLandmark();
        helpers.PerformRepeatedClicks(helpers.ClickTickBtnPoseObject, 13);
        helpers.BeingProcessed();
        helpers.ClickFirstSphereThumbExtFlexObject();
        helpers.ClickFirstSphereThumbExtFlexBtnObject();
        helpers.MoveSliderFirstSphereThumbExtFlexObject();
        helpers.ClickSecondSphereThumbExtFlexObject();
        helpers.ClickSecondSphereThumbExtFlexBtnObject();
        helpers.MoveSliderSecondSphereThumbExtFlexObject();
        helpers.ClickThirdSphereThumbExtFlexObject();
        helpers.ClickThirdSphereThumbExtFlexBtnObject();
        helpers.MoveSliderThirdSphereThumbExtFlexObject();
        helpers.ClickThirdSphereThumbInversEversBtnObject();
        helpers.MoveSliderThirdSphereThumbInversEversObject();
        helpers.ClickThirdSphereThumbAbductAdductBtnObject();
        helpers.MoveSliderThirdSphereThumbAbductAdductObject();
        helpers.ClickFirstSphereIndexExtFlexObject();
        helpers.ClickFirstSphereIndexExtFlexBtnObject();
        helpers.MoveSliderFirstSphereIndexExtFlexObject();
        helpers.ClickSecondSphereIndexExtFlexObject();
        helpers.ClickSecondSphereIndexExtFlexBtnObject();
        helpers.MoveSliderSecondSphereIndexExtFlexObject();
        helpers.ClickThirdSphereIndexExtFlexObject();
        helpers.ClickThirdSphereIndexExtFlexBtnObject();
        helpers.MoveSliderThirdSphereIndexExtFlexObject();
        helpers.ClickFirstSphereMiddleExtFlexObject();
        helpers.ClickFirstSphereMiddleExtFlexBtnObject();
        helpers.MoveSliderFirstSphereMiddleExtFlexObject();
        helpers.ClickSecondSphereMiddleExtFlexObject();
        helpers.ClickSecondSphereMiddleExtFlexBtnObject();
        helpers.MoveSliderSecondSphereMiddleExtFlexObject();
        helpers.ClickThirdSphereMiddleExtFlexObject();
        helpers.ClickThirdSphereMiddleExtFlexBtnObject();
        helpers.MoveSliderThirdSphereMiddleExtFlexObject();
        helpers.ClickFirstSphereRingExtFlexObject();
        helpers.ClickFirstSphereRingExtFlexBtnObject();
        helpers.MoveSliderFirstSphereRingExtFlexObject();
        helpers.ClickSecondSphereRingExtFlexObject();
        helpers.ClickSecondSphereRingExtFlexBtnObject();
        helpers.MoveSliderSecondSphereRingExtFlexObject();
        helpers.ClickThirdSphereRingExtFlexObject();
        helpers.ClickThirdSphereRingExtFlexBtnObject();
        helpers.MoveSliderThirdSphereRingExtFlexObject();
        helpers.ClickFirstSphereLittleExtFlexObject();
        helpers.ClickFirstSphereLittleExtFlexBtnObject();
        helpers.MoveSliderFirstSphereLittleExtFlexObject();
        helpers.ClickSecondSphereLittleExtFlexObject();
        helpers.ClickSecondSphereLittleExtFlexBtnObject();
        helpers.MoveSliderSecondSphereLittleExtFlexObject();
        helpers.ClickThirdSphereLittleExtFlexObject();
        helpers.ClickThirdSphereLittleExtFlexBtnObject();
        helpers.MoveSliderThirdSphereLittleExtFlexObject();
        helpers.ClickHandSphereObject();
        helpers.ClickHandSphereExtFlexBtnObject();
        helpers.MoveSliderHandSphereExtFlexObject();
        helpers.ClickHandSphereAbducAdducBtnObject();
        helpers.MoveSliderHandSphereAbducAdducObject();
        helpers.ClickGlobalRotationPoseBtnObject();
        helpers.ClickGlobalRotationForwardPoseBtnObject();
        helpers.MoveSliderGlobalRotationForwardObject();
        helpers.ClickGlobalRotationRightPoseBtnObject();
        helpers.MoveSliderGlobalRotationRightObject();
        helpers.ClickGlobalRotationVerticalPoseBtnObject();
        helpers.MoveSliderGlobalRotationVerticalObject();
        helpers.ClickNeutralPoseBtnObject();
        helpers.ClickResetSliderPoseBtnObject();
        helpers.ClickAppearanceBtnObject();
        //VerifyAndAssertText("/Canvas/PosePan(Clone)/Panel/MatDropDown/Dropdown List/Viewport/Content/Item 0: Normal", NormalAppearanceText);
        //VerifyAndAssertText("/Canvas/PosePan(Clone)/Panel/MatDropDown/Dropdown List/Viewport/Content/Item 1: Transparent", TransparentAppearanceText);
        //VerifyAndAssertText("/Canvas/PosePan(Clone)/Panel/MatDropDown/Dropdown List/Viewport/Content/Item 2: Neutral ghost", NeutralGhostAppearanceText);
        helpers.ClickTransparentChoiceBtnObject();
        helpers.ClickAppearanceBtnObject();
        helpers.ClickNeutralGhostChoiceBtnObject();
        helpers.ClickPreviousStepBtnPoseObject();
        helpers.VerifyAndAssertText("/Canvas/Popup(Clone)/Content/Content text", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.OldLandmarksOrSetAgainText);
        helpers.ClickKeepBtnLandmarksPopUpObject(); // Repeat all actions for this step (pose editor) until PreviousStepBtn
        helpers.BeingProcessed();
        ExecutePoseEditorSteps();
        helpers.ClickValidateBtnPoseObject();
        helpers.ClickPoseBtnMainViewObject();
        helpers.VerifyAndAssertText("/Canvas/WarnPopup(Clone)/Forma Info Panel v3/Content/Content text", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.AllChangesLostText);
        helpers.ClickConfirmBtnPopUpObject();
        helpers.VerifyAndAssertText("/Canvas/StatusText/Variable Size Container/Text", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.PosingModeSelectionText);
        helpers.ClickAdvancedPoseBtnObject();
        helpers.VerifyAndAssertText("/Canvas/Popup(Clone)/Content/Content text", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.OldLandmarksOrSetAgainText);
        helpers.ClickKeepBtnLandmarksPopUpObject();//Repeat one last time the actions performed in the step editor and validate again)
        helpers.BeingProcessed();
        ExecutePoseEditorSteps();
        helpers.ClickResetSliderPoseBtnObject();
        helpers.ClickValidateBtnPoseObject();

    }

    private void ExecutePoseEditorSteps()
    {
        /// STEPS FOR THE NEW EDITOR. PUT THEM BACK WHEN THE OLD EDITOR HAS BEEN REPLACED ///
        //ClickHandExtFlexBtnObject();
        //VerifyAndAssertText("/Canvas/PosePan(Clone)/SliderPanel/PoseSlider(Clone)/SlideMask/Background/Title", HandExtFlexSliderText);
        //MoveSliderHandExtFlexObject();
        //ClickHandAdAbBtnObject();
        //VerifyAndAssertText("/Canvas/PosePan(Clone)/SliderPanel/PoseSlider(Clone)[1]/SlideMask/Background/Title", HandAdAbSliderText);
        //MoveSliderHandAdAbObject();
        //ClickThumbExtFlexBtnObject();
        //VerifyAndAssertText("/Canvas/PosePan(Clone)/SliderPanel/PoseSlider(Clone)[2]/SlideMask/Background/Title", ThumbExtFlexText);
        //MoveSliderThumbExtFlexObject();
        //PerformRepeatedClicks(ClickUndoBtnPoseObject, 3);
        //PerformRepeatedClicks(ClickRedoBtnPoseObject, 3);
        //ClickThumbAdAbBtnObject();
        //VerifyAndAssertText("/Canvas/PosePan(Clone)/SliderPanel/PoseSlider(Clone)[3]/SlideMask/Background/Title", ThumbAdAbText);
        //MoveSliderThumbAdAbObject();
        //ClickFingerExtFlexBtnObject();
        //VerifyAndAssertText("/Canvas/PosePan(Clone)/SliderPanel/PoseSlider(Clone)[4]/SlideMask/Background/Title", FingerExtFlexText);
        //MoveSliderFingerExtFlexObject();
        //ClickFingerSplayBtnObject();
        //VerifyAndAssertText("/Canvas/PosePan(Clone)/SliderPanel/PoseSlider(Clone)[5]/SlideMask/Background/Title", FingerSplayText);
        //MoveSliderFingerSplayObject();
        //ClickFingerSplayBtnObject();
        //ClickNeutralPoseBtnObject();
        //ClickResetSliderPoseBtnObject();
        //ClickAppearanceBtnObject();
        //VerifyAndAssertText("/Canvas/PosePan(Clone)/BottomPanel/MatDropDown/Dropdown List/Viewport/Content/Item 0: Normal/Item Label", NormalAppearanceText);
        //VerifyAndAssertText("/Canvas/PosePan(Clone)/BottomPanel/MatDropDown/Dropdown List/Viewport/Content/Item 1: Transparent/Item Label", TransparentAppearanceText);
        //VerifyAndAssertText("/Canvas/PosePan(Clone)/BottomPanel/MatDropDown/Dropdown List/Viewport/Content/Item 2: Neutral ghost/Item Label", NeutralGhostAppearanceText);
        //ClickTransparentChoiceBtnObject();
        //ClickAppearanceBtnObject();
        //ClickNeutralGhostChoiceBtnObject();
        //ClickHandExtFlexBtnObject();
        //VerifyAndAssertText("/Canvas/PosePan(Clone)/SliderPanel/PoseSlider(Clone)/SlideMask/Background/Title", HandExtFlexSliderText);
        //MoveSliderHandExtFlexObject();
        helpers.ClickFirstSphereThumbExtFlexObject();
        helpers.ClickFirstSphereThumbExtFlexBtnObject();
        helpers.MoveSliderFirstSphereThumbExtFlexObject();
        helpers.ClickSecondSphereThumbExtFlexObject();
        helpers.ClickSecondSphereThumbExtFlexBtnObject();
        helpers.MoveSliderSecondSphereThumbExtFlexObject();
        helpers.ClickThirdSphereThumbExtFlexObject();
        helpers.ClickThirdSphereThumbExtFlexBtnObject();
        helpers.MoveSliderThirdSphereThumbExtFlexObject();
        helpers.ClickThirdSphereThumbInversEversBtnObject();
        helpers.MoveSliderThirdSphereThumbInversEversObject();
        helpers.ClickThirdSphereThumbAbductAdductBtnObject();
        helpers.MoveSliderThirdSphereThumbAbductAdductObject();
        helpers.ClickFirstSphereIndexExtFlexObject();
        helpers.ClickFirstSphereIndexExtFlexBtnObject();
        helpers.MoveSliderFirstSphereIndexExtFlexObject();
        helpers.ClickSecondSphereIndexExtFlexObject();
        helpers.ClickSecondSphereIndexExtFlexBtnObject();
        helpers.MoveSliderSecondSphereIndexExtFlexObject();
        helpers.ClickThirdSphereIndexExtFlexObject();
        helpers.ClickThirdSphereIndexExtFlexBtnObject();
        helpers.MoveSliderThirdSphereIndexExtFlexObject();
        helpers.ClickFirstSphereMiddleExtFlexObject();
        helpers.ClickFirstSphereMiddleExtFlexBtnObject();
        helpers.MoveSliderFirstSphereMiddleExtFlexObject();
        helpers.ClickSecondSphereMiddleExtFlexObject();
        helpers.ClickSecondSphereMiddleExtFlexBtnObject();
        helpers.MoveSliderSecondSphereMiddleExtFlexObject();
        helpers.ClickThirdSphereMiddleExtFlexObject();
        helpers.ClickThirdSphereMiddleExtFlexBtnObject();
        helpers.MoveSliderThirdSphereMiddleExtFlexObject();
        helpers.ClickFirstSphereRingExtFlexObject();
        helpers.ClickFirstSphereRingExtFlexBtnObject();
        helpers.MoveSliderFirstSphereRingExtFlexObject();
        helpers.ClickSecondSphereRingExtFlexObject();
        helpers.ClickSecondSphereRingExtFlexBtnObject();
        helpers.MoveSliderSecondSphereRingExtFlexObject();
        helpers.ClickThirdSphereRingExtFlexObject();
        helpers.ClickThirdSphereRingExtFlexBtnObject();
        helpers.MoveSliderThirdSphereRingExtFlexObject();
        helpers.ClickFirstSphereLittleExtFlexObject();
        helpers.ClickFirstSphereLittleExtFlexBtnObject();
        helpers.MoveSliderFirstSphereLittleExtFlexObject();
        helpers.ClickSecondSphereLittleExtFlexObject();
        helpers.ClickSecondSphereLittleExtFlexBtnObject();
        helpers.MoveSliderSecondSphereLittleExtFlexObject();
        helpers.ClickThirdSphereLittleExtFlexObject();
        helpers.ClickThirdSphereLittleExtFlexBtnObject();
        helpers.MoveSliderThirdSphereLittleExtFlexObject();
        helpers.ClickHandSphereObject();
        helpers.ClickHandSphereExtFlexBtnObject();
        helpers.MoveSliderHandSphereExtFlexObject();
        helpers.ClickHandSphereAbducAdducBtnObject();
        helpers.MoveSliderHandSphereAbducAdducObject();

    }

    private void SetPoseLandmarks()
    {
        helpers.ClickThumbTipLandmark();
        helpers.ClickTickBtnPoseObject();
        helpers.VerifyAndAssertText("/PoseCTL/LMRunPlacementStep/LMRunPlacementStepPanel/Canvas/ImageContainer/Label", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.DistalEndIndexFingerText);
        helpers.ClickDistalEndIndexLandmark();
        helpers.ClickTickBtnPoseObject();
        helpers.VerifyAndAssertText("/PoseCTL/LMRunPlacementStep/LMRunPlacementStepPanel/Canvas/ImageContainer/Label", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.DistalEndMiddleFingerText);
        helpers.ClickDistalMiddleFingerLandmark();
        helpers.ClickTickBtnPoseObject();
        helpers.VerifyAndAssertText("/PoseCTL/LMRunPlacementStep/LMRunPlacementStepPanel/Canvas/ImageContainer/Label", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.DistalEndRingFingerText);
        helpers.ClickDistalRingFingerLandmark();
        helpers.ClickTickBtnPoseObject();
        helpers.VerifyAndAssertText("/PoseCTL/LMRunPlacementStep/LMRunPlacementStepPanel/Canvas/ImageContainer/Label", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.DistalEndLittleFingerText);
        helpers.ClickDistalLittleFingerLandmark();
        helpers.ClickTickBtnPoseObject();
        helpers.VerifyAndAssertText("/PoseCTL/LMRunPlacementStep/LMRunPlacementStepPanel/Canvas/ImageContainer/Label", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.ThumbMetacarpalText);
        helpers.ClickThumbMetacarpalLandmark();
        helpers.ClickTickBtnPoseObject();
        helpers.VerifyAndAssertText("/PoseCTL/LMRunPlacementStep/LMRunPlacementStepPanel/Canvas/ImageContainer/Label", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.IndexMetacarpalText);
        helpers.ClickIndexMetacarpalLandmark();
        helpers.ClickTickBtnPoseObject();
        helpers.VerifyAndAssertText("/PoseCTL/LMRunPlacementStep/LMRunPlacementStepPanel/Canvas/ImageContainer/Label", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.MiddleMetacarpalText);
        helpers.ClickMiddleMetacarpalLandmark();
        helpers.ClickTickBtnPoseObject();
        helpers.VerifyAndAssertText("/PoseCTL/LMRunPlacementStep/LMRunPlacementStepPanel/Canvas/ImageContainer/Label", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.RingMetacarpalText);
        helpers.ClickRingMetacarpalLandmark();
        helpers.ClickTickBtnPoseObject();
        helpers.VerifyAndAssertText("/PoseCTL/LMRunPlacementStep/LMRunPlacementStepPanel/Canvas/ImageContainer/Label", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.LittleMetacarpalText);
        helpers.ClickLittleMetacarpalLandmark();
        helpers.ClickTickBtnPoseObject();
        helpers.VerifyAndAssertText("/PoseCTL/LMRunPlacementStep/LMRunPlacementStepPanel/Canvas/ImageContainer/Label", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.MetacarpalCreaseCenterText);
        helpers.ClickCreaseCenterMetacarpalLandmark();
        helpers.ClickTickBtnPoseObject();
        helpers.VerifyAndAssertText("/PoseCTL/LMRunPlacementStep/LMRunPlacementStepPanel/Canvas/ImageContainer/Label", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.MedialBorderMetacarpalText);
        helpers.ClickMedialBorderMetacarpalLandmark();
        helpers.ClickTickBtnPoseObject();
        helpers.VerifyAndAssertText("/PoseCTL/LMRunPlacementStep/LMRunPlacementStepPanel/Canvas/ImageContainer/Label", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.WristCreaseCenterText);
        helpers.ClickWristCreaseCenterLandmark();
    }

    private void ExecuteThumbLevel()
    {
        helpers.ClickThumbBtnMainViewObject();
        helpers.VerifyAndAssertText("/Canvas/StatusText/Variable Size Container/Text", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.PositionLandmarkText);
        helpers.VerifyAndAssertText("/ThumbCTL/LMRunPlacementStep/LMRunPlacementStepPanel/Canvas/ImageContainer/Label", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.ThumbInterPhalangealText);
        helpers.ClickCrossBtnThumbObject();
        helpers.VerifyAndAssertText("/Canvas/WarnPopup(Clone)/Forma Info Panel v3/Content/Content text", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.ModificationsWillBeLostText);
        helpers.ClickConfirmBtnPopUpObject();
        helpers.ClickThumbBtnMainViewObject();
        helpers.VerifyAndAssertText("/Canvas/StatusText/Variable Size Container/Text", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.PositionLandmarkText);
        helpers.VerifyAndAssertText("/ThumbCTL/LMRunPlacementStep/LMRunPlacementStepPanel/Canvas/ImageContainer/Label", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.ThumbInterPhalangealText);
        SetThumbLandmarks();
        helpers.ClickBackArrowBtnThumbObject();
        helpers.VerifyAndAssertText("/ThumbCTL/LMRunPlacementStep/LMRunPlacementStepPanel/Canvas/ImageContainer/Label", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.ThumbMetacarpalText);
        helpers.ClickBackArrowBtnThumbObject();
        helpers.VerifyAndAssertText("/ThumbCTL/LMRunPlacementStep/LMRunPlacementStepPanel/Canvas/ImageContainer/Label", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.ThumbInterPhalangealText);
        helpers.PerformRepeatedClicks(helpers.ClickTickBtnThumbObject, 3);
        helpers.VerifyAndAssertText("/Canvas/StatusText/Variable Size Container/Text", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.CheckTheThumbText);
        helpers.ClickPreviousStepBtnThumbObject();
        helpers.VerifyAndAssertText("/Canvas/Popup(Clone)/Content/Content text", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.OldLandmarksOrSetAgainText);
        helpers.ClickResetBtnPopUpObject(); // Repeat the step to set the landmarks
        SetThumbLandmarks();
        helpers.ClickTickBtnThumbObject();
        helpers.VerifyAndAssertText("/Canvas/ThumbEditorPanel(Clone)/Text", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.ThumbEditorPanelText);
        helpers.ClickCircumferenceBtnThumbObject();
        helpers.MoveSliderCircToMinThumbObject();
        helpers.MoveSliderCircToMaxThumbObject();
        helpers.ClickResetSliderBtnThumbObject();
        helpers.ClickValidateBtnThumbObject();
        helpers.ClickThumbBtnMainViewObject();
        helpers.VerifyAndAssertText("/Canvas/WarnPopup(Clone)/Forma Info Panel v3/Content/Content text", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.AllChangesLostText);
        helpers.ClickConfirmBtnPopUpObject();
        Thread.Sleep(1000);
        helpers.ClickResetBtnPopUpObject(); // Repeat the previous step (set landmarks until ValidateBtn)
        ExecuteThumbEditorSteps();
    }

    private void ExecuteThumbEditorSteps()
    {
        SetThumbLandmarks();
        helpers.ClickTickBtnThumbObject();
        helpers.ClickCircumferenceBtnThumbObject();
        helpers.MoveSliderCircToMinThumbObject();
        helpers.MoveSliderCircToMaxThumbObject();
        helpers.ClickResetSliderBtnThumbObject();
        helpers.ClickValidateBtnThumbObject();
    }

    private void SetThumbLandmarks()
    {
        helpers.ClickThumbInterPhalangealLandmark();
        helpers.ClickTickBtnThumbObject();
        helpers.VerifyAndAssertText("/ThumbCTL/LMRunPlacementStep/LMRunPlacementStepPanel/Canvas/ImageContainer/Label", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.ThumbMetacarpalText);
        helpers.ClickThumbMetaPhalangealLandmark();
        helpers.ClickTickBtnThumbObject();
        helpers.VerifyAndAssertText("/ThumbCTL/LMRunPlacementStep/LMRunPlacementStepPanel/Canvas/ImageContainer/Label", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.FirstInterdigitalText);
        helpers.ClickFirstInterdigitalLandmark();
    }

    private void ExecuteSculptLevel()
    {
        helpers.ClickSculptBtnMainViewObject();
        helpers.VerifyAndAssertText("/Canvas/StatusText/Variable Size Container/Text", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.SculptEditorText);
        helpers.ClickFirstOnMeshToActivateDrawingSculptObject();
        helpers.FirstPullOnMeshSculptObject();
        helpers.SecondPullOnMeshSculptObject();
        helpers.ClickUndoBtnSculptObject();
        helpers.ClickUndoBtnSculptObject();
        helpers.ClickRedoBtnSculptObject();
        helpers.ClickRedoBtnSculptObject();
        helpers.ClickBrushDiameterBtnSculptObject();
        helpers.MoveSliderBrushDiameterSculptObject();
        helpers.ClickPullPushBtnSculptObject();
        helpers.ClickOnAxisYSculptObject();
        Thread.Sleep(1000);
        helpers.ClickOnAxisXSculptObject();
        Thread.Sleep(1000);
        helpers.FirstPushOnMeshSculptObject();
        helpers.SecondPushOnMeshSculptObject();
        helpers.ClickEraseBtnSculptObject();
        helpers.EraseAreaOnMeshSculptObject();
        helpers.MoveSliderEraserDiameterSculptObject();
        helpers.ClickOnBrushBtnSculptObject();
        helpers.ClickLimitValueBtnSculptObject();
        helpers.MoveSliderLimitValueSculptObject();
        helpers.CheckLimitValuePullPushSculptObject();
        helpers.ClickPullPushBtnSculptObject();
        helpers.ClickNextStepBtnSculptObject();
        helpers.VerifyAndAssertText("/Canvas/StatusText/Variable Size Container/Text", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.SculptValidationText);
        helpers.ClickPreviousStepBtnSculptObject();
        helpers.VerifyAndAssertText("/Canvas/SculptUI(Clone)/InteractiveUIRoot/Pull Push  Switch/Labels/Label On", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.PullOptionActivated);
        helpers.ClickPullPushBtnSculptObject();
        helpers.ClickNextStepBtnSculptObject();
        helpers.VerifyAndAssertText("/Canvas/StatusText/Variable Size Container/Text", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.SculptValidationText);
        helpers.ClickPreviousStepBtnSculptObject();
        helpers.VerifyAndAssertText("/Canvas/SculptUI(Clone)/InteractiveUIRoot/Pull Push  Switch/Labels/Label Off", FullScanCorrectionW4R.ScanCorrectionHelpersW4R.PushOptionActivated);
        helpers.ClickOnAxisYSculptObject();
        Thread.Sleep(1000);
        helpers.ClickOnAxisAntiXSculptObject();
        Thread.Sleep(1000);
        helpers.ClickFlattenToolBtnSculptObject();
        helpers.MoveFlattenToolSculptObject();
        helpers.ClickOnAxisYSculptObject();
        Thread.Sleep(1000);
        helpers.ClickOnAxisXSculptObject();
        Thread.Sleep(1000);
        helpers.ClickFillValleyToolBtnSculptObject();
        helpers.MoveFillValleyToolBtnSculptObject();
        helpers.ClickNextStepBtnSculptObject();
        helpers.SecondPushOnMeshSculptObject();
        helpers.ClickValidateBtnSculptObject();
        helpers.ClickSculptBtnMainViewObject();
        helpers.ClickConfirmBtnPopUpObject(); // The previous changes are deleted (not saved) and we repeat again the previous step unitl Validate btn
        ExecuteSculptSteps();
    }

    private void ExecuteSculptSteps()
    {
        helpers.ClickOnBrushBtnSculptObject();
        helpers.MoveSliderBrushDiameterToMinSculptObject();
        helpers.ClickFirstOnMeshToActivateDrawingSculptObject();
        helpers.FirstPullOnMeshSculptObject();
        helpers.SecondPullOnMeshSculptObject();
        helpers.ClickUndoBtnSculptObject();
        helpers.ClickUndoBtnSculptObject();
        helpers.ClickRedoBtnSculptObject();
        helpers.ClickRedoBtnSculptObject();
        helpers.ClickBrushDiameterBtnSculptObject();
        helpers.MoveSliderBrushDiameterSculptObject();
        helpers.ClickPullPushBtnSculptObject();
        helpers.ClickOnAxisYSculptObject();
        Thread.Sleep(1000);
        helpers.ClickOnAxisXSculptObject();
        Thread.Sleep(1000);
        helpers.FirstPushOnMeshSculptObject();
        helpers.SecondPushOnMeshSculptObject();
        helpers.ClickEraseBtnSculptObject();
        helpers.EraseAreaOnMeshSculptObject();
        helpers.MoveSliderEraserDiameterSculptObject();
        helpers.ClickOnBrushBtnSculptObject();
        helpers.ClickLimitValueBtnSculptObject();
        helpers.MoveSliderLimitValueSculptObject();
        helpers.CheckLimitValuePullPushSculptObject();
        helpers.ClickPullPushBtnSculptObject();
        helpers.ClickNextStepBtnSculptObject();
        helpers.ClickPreviousStepBtnSculptObject();
        helpers.ClickPullPushBtnSculptObject();
        helpers.ClickNextStepBtnSculptObject();
        helpers.ClickPreviousStepBtnSculptObject();
        helpers.ClickOnAxisYSculptObject();
        Thread.Sleep(1000);
        helpers.ClickOnAxisAntiXSculptObject();
        Thread.Sleep(1000);
        helpers.ClickFlattenToolBtnSculptObject();
        helpers.MoveFlattenToolSculptObject();
        helpers.ClickOnAxisYSculptObject();
        Thread.Sleep(1000);
        helpers.ClickOnAxisXSculptObject();
        Thread.Sleep(1000);
        helpers.ClickFillValleyToolBtnSculptObject();
        helpers.MoveFillValleyToolBtnSculptObject();
        helpers.ClickNextStepBtnSculptObject();
        helpers.SecondPushOnMeshSculptObject();
        helpers.ClickValidateBtnSculptObject();
    }
}