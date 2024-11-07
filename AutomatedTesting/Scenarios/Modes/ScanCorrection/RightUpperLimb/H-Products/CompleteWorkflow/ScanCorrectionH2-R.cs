using System;
using AltTester.AltTesterUnitySDK.Driver;
using AutomatedTesting.Helpers.CommonHelpers;
using NUnit.Framework;
using System.Threading;

public partial class FullScanCorrectionH2R
{
    private AltDriver altDriver;
    private ScanCorrectionHelpersH2R helpers; // Utiliser une instance des helpers pour accéder aux méthodes.

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
<<<<<<< HEAD:AutomatedTesting/Scenarios/Modes/ScanCorrection/RightUpperLimb/H-Products/CompleteWorkflow/ScanCorrectionH2-R.cs
        altDriver = AltDriverConfig.GetAltDriver();        
=======
        altDriver = new AltDriver(host: ConnexionConfig.Host, port: ConnexionConfig.Port, appName: ConnexionConfig.AppName);
>>>>>>> temp-branch:AutomatedTesting/RightUpperLimb/H2/Mode/ScanCorrection/Scenario/ScanCorrectionH2-R.cs
        helpers = new ScanCorrectionHelpersH2R(altDriver); // Initialisation avec le driver.
    }

    [OneTimeTearDown]
    public void TearDown()
    {
        AltDriverConfig.StopAltDriver();
    }

    [Test]
    public void FullScanCorrectionH2Workflow()
    {
        VerifyProductCode("H2");
        ExecuteCleanupLevel();
        ExecutePoseLevel();
        ExecuteThumbLevel();
        ExecuteSculptLevel();

    }

    private void VerifyProductCode(string expectedProductCode)
    {
        GenericHelpers.VerifyTextContainsProductCode(altDriver, "/Canvas/BackToOrderPan/Button Navigation/Text (1)", expectedProductCode);
    }

    private void ExecuteCleanupLevel()
    {
        helpers.ClickCleanupBtnMainViewObject();
        altDriver.SetDelayAfterCommand(0.25f);
        helpers.ClickSelectPartOfInterestArmRightA2(); // Cannot use object here, use coordinate.
        helpers.ClickQuitBtnObject();
        helpers.ClickConfirmBtnPopUpObject();
        helpers.ClickCleanupBtnMainViewObject();
        helpers.ClickSelectPartOfInterestArmRightA2(); // Cannot use object here, use coordinate.
        helpers.ClickNextStepBtnObject();
        helpers.ClickCrossBtnObject();
        RepeatPreviousStep();
        helpers.ClickOnAxisAntiZSculptObject();
        helpers.ClickOnAxisXSculptObject();
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
        //// helpers.VerifyAndAssertText("/Cleanup/LevelNavigationPanel(Clone)/Canvas/StatusText/Variable Size Container/Text", FullScanCorrectionA1R.ScanCorrectionHelpersA1R.SelectPartOfScanText);
        helpers.ClickSelectPartOfInterestArmRightA2();
        helpers.ClickQuitBtnObject();
        //// helpers.VerifyAndAssertText("/Canvas/WarnPopup(Clone)/Forma Info Panel v3/Content/Content text", FullScanCorrectionA1R.ScanCorrectionHelpersA1R.ModificationsWillBeLostText);
        helpers.ClickConfirmBtnPopUpObject();
        helpers.ClickCleanupBtnMainViewObject();
        //// helpers.VerifyAndAssertText("/Cleanup/LevelNavigationPanel(Clone)/Canvas/StatusText/Variable Size Container/Text", FullScanCorrectionA1R.ScanCorrectionHelpersA1R.SelectPartOfScanText);
        helpers.ClickSelectPartOfInterestArmRightA2();
        helpers.ClickNextStepBtnObject();
        //// helpers.VerifyAndAssertText("/Cleanup/LevelNavigationPanel(Clone)/Canvas/StatusText/Variable Size Container/Text", FullScanCorrectionA1R.ScanCorrectionHelpersA1R.PositionLandmarkText);
        //// helpers.VerifyAndAssertText("/Cleanup/LMRunPlacementStep(Clone)/LMRunPlacementStepPanel/Canvas/ImageContainer/Label", FullScanCorrectionA1R.ScanCorrectionHelpersA1R.WristCreaseCenterText);
        helpers.ClickCrossBtnObject(); // Return to Step 1 of Cleanup. Repeat the previous step.
        //// helpers.VerifyAndAssertText("/Cleanup/LevelNavigationPanel(Clone)/Canvas/StatusText/Variable Size Container/Text", FullScanCorrectionA1R.ScanCorrectionHelpersA1R.SelectPartOfScanText);
        RepeatPreviousStep();
        helpers.ClickOnAxisAntiZSculptObject();
        helpers.ClickOnAxisXSculptObject();
        //// helpers.VerifyAndAssertText("/Cleanup/LevelNavigationPanel(Clone)/Canvas/StatusText/Variable Size Container/Text", FullScanCorrectionA1R.ScanCorrectionHelpersA1R.PositionLandmarkText);
        //// helpers.VerifyAndAssertText("/Cleanup/LMRunPlacementStep(Clone)/LMRunPlacementStepPanel/Canvas/ImageContainer/Label", FullScanCorrectionA1R.ScanCorrectionHelpersA1R.WristCreaseCenterText);
        SetCleanupLandmarks();
        helpers.ClickPreviousStepBtnObject();
        //// helpers.VerifyAndAssertText("/Canvas/Popup(Clone)/Content/Content text", FullScanCorrectionA1R.ScanCorrectionHelpersA1R.OldLandmarksOrSetAgainText);
        helpers.ClickKeepBtnLandmarksPopUpObject();
        //// helpers.VerifyAndAssertText("/Cleanup/LevelNavigationPanel(Clone)/Canvas/StatusText/Variable Size Container/Text", FullScanCorrectionA1R.ScanCorrectionHelpersA1R.SelectPartOfScanCropOffText);
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
        //// helpers.VerifyAndAssertText("/Cleanup/LevelNavigationPanel(Clone)/Canvas/StatusText/Variable Size Container/Text", FullScanCorrectionA1R.ScanCorrectionHelpersA1R.CheckConfirmScanText);
        helpers.ClickPreviousStepBtnObject();
        helpers.CuttingPlanePositionObject();
        helpers.ClickNextStepBtnObject();
        //// helpers.VerifyAndAssertText("/Cleanup/LevelNavigationPanel(Clone)/Canvas/StatusText/Variable Size Container/Text", FullScanCorrectionA1R.ScanCorrectionHelpersA1R.CheckConfirmScanText);
        helpers.ClickValidateBtnObject();
    }

    private void RepeatPreviousStep()
    {
        helpers.ClickQuitBtnObject();
        helpers.ClickConfirmBtnPopUpObject();
        helpers.ClickCleanupBtnMainViewObject();
        helpers.ClickSelectPartOfInterestArmRightA2();
        helpers.ClickNextStepBtnObject();
    }

    private void SetCleanupLandmarks()
    {
        helpers.ClickWristCreaseCenterCleanupLandmark();
        helpers.ClickTickBtnObject();
        helpers.ClickBackArrowBtnObject();
        helpers.ClickWristCreaseCenterCleanupLandmark();
        helpers.ClickTickBtnObject();
        helpers.ClickVentralArmCleanupLandmark();
        helpers.ClickTickBtnObject();

    }


    private void ExecutePoseLevel()
    {

          // STEPS FOR OLD EDITOR
        helpers.ClickPoseBtnMainViewObject();
        //// helpers.VerifyAndAssertText("/Canvas/StatusText/Variable Size Container/Text", FullScanCorrectionA1R.ScanCorrectionHelpersA1R.PosingModeSelectionText);
        helpers.ClickQuitBtnPoseObject();
        //// helpers.VerifyAndAssertText("/Canvas/WarnPopup(Clone)/Forma Info Panel v3/Content/Content text", FullScanCorrectionA1R.ScanCorrectionHelpersA1R.ModificationsWillBeLostText);
        helpers.ClickConfirmBtnPopUpObject();
        helpers.ClickPoseBtnMainViewObject();
        //// helpers.VerifyAndAssertText("/Canvas/StatusText/Variable Size Container/Text", FullScanCorrectionA1R.ScanCorrectionHelpersA1R.PosingModeSelectionText);
        helpers.ClickAdvancedPoseBtnObject();
        //// helpers.VerifyAndAssertText("/Canvas/StatusText/Variable Size Container/Text", FullScanCorrectionA1R.ScanCorrectionHelpersA1R.PositionLandmarkText);
        //// helpers.VerifyAndAssertText("/PoseCTL/LMRunPlacementStep/LMRunPlacementStepPanel/Canvas/ImageContainer/Label", FullScanCorrectionA1R.ScanCorrectionHelpersA1R.ThumbTipText);
        altDriver.SetDelayAfterCommand(0.12f);
        SetPoseLandmarks();
       // altDriver.SetDelayAfterCommand(0);
        helpers.PerformRepeatedClicks(helpers.ClickBackArrowBtnPoseObject, 12);
        helpers.PerformRepeatedClicks(helpers.ClickTickBtnPoseObject, 13);
        helpers.BeingProcessed();
        //// helpers.VerifyAndAssertText("/Canvas/StatusText/Variable Size Container/Text", FullScanCorrectionA1R.ScanCorrectionHelpersA1R.CheckTheLimbPoseText);
        helpers.ClickPreviousStepBtnPoseObject();
        //// helpers.VerifyAndAssertText("/Canvas/Popup(Clone)/Content/Content text", FullScanCorrectionA1R.ScanCorrectionHelpersA1R.OldLandmarksOrSetAgainText);
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
        altDriver.SetDelayAfterCommand(0.12f);
        helpers.ClickNeutralPoseBtnObject();
        helpers.ClickResetSliderPoseBtnObject();
        helpers.ClickAppearanceBtnObject();
        //VerifyAndAssertText("/Canvas/PosePan(Clone)/Panel/MatDropDown/Dropdown List/Viewport/Content/Item 0: Normal", NormalAppearanceText);
        //VerifyAndAssertText("/Canvas/PosePan(Clone)/Panel/MatDropDown/Dropdown List/Viewport/Content/Item 1: Transparent", TransparentAppearanceText);
        //VerifyAndAssertText("/Canvas/PosePan(Clone)/Panel/MatDropDown/Dropdown List/Viewport/Content/Item 2: Neutral ghost", NeutralGhostAppearanceText);
        helpers.ClickTransparentChoiceBtnObject();
        helpers.ClickAppearanceBtnObject();
        helpers.ClickNeutralGhostChoiceBtnObject();
        altDriver.SetDelayAfterCommand(0);
        helpers.ClickPreviousStepBtnPoseObject();
        //// helpers.VerifyAndAssertText("/Canvas/Popup(Clone)/Content/Content text", FullScanCorrectionA1R.ScanCorrectionHelpersA1R.OldLandmarksOrSetAgainText);
        helpers.ClickKeepBtnLandmarksPopUpObject(); // Repeat all actions for this step (pose editor) until PreviousStepBtn
        helpers.BeingProcessed();
        ExecutePoseEditorSteps();
        helpers.ClickValidateBtnPoseObject();
        helpers.ClickPoseBtnMainViewObject();
       // // helpers.VerifyAndAssertText("/Canvas/WarnPopup(Clone)/Forma Info Panel v3/Content/Content text", FullScanCorrectionA1R.ScanCorrectionHelpersA1R.AllChangesLostText);
        helpers.ClickConfirmBtnPopUpObject();
       // // helpers.VerifyAndAssertText("/Canvas/StatusText/Variable Size Container/Text", FullScanCorrectionA1R.ScanCorrectionHelpersA1R.PosingModeSelectionText);
        helpers.ClickAdvancedPoseBtnObject();
        //// helpers.VerifyAndAssertText("/Canvas/Popup(Clone)/Content/Content text", FullScanCorrectionA1R.ScanCorrectionHelpersA1R.OldLandmarksOrSetAgainText);
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
        helpers.ClickDistalEndIndexLandmark();
        helpers.ClickTickBtnPoseObject();
        helpers.ClickDistalMiddleFingerLandmark();
        helpers.ClickTickBtnPoseObject();
        helpers.ClickDistalRingFingerLandmark();
        helpers.ClickTickBtnPoseObject();
        helpers.ClickDistalLittleFingerLandmark();
        helpers.ClickTickBtnPoseObject();
        helpers.ClickThumbMetacarpalLandmark();
        helpers.ClickTickBtnPoseObject();
        helpers.ClickIndexMetacarpalLandmark();
        helpers.ClickTickBtnPoseObject();
        helpers.ClickMiddleMetacarpalLandmark();
        helpers.ClickTickBtnPoseObject();
        helpers.ClickRingMetacarpalLandmark();
        helpers.ClickTickBtnPoseObject();
        helpers.ClickLittleMetacarpalLandmark();
        helpers.ClickTickBtnPoseObject();
        helpers.ClickCreaseCenterMetacarpalLandmark();
        helpers.ClickTickBtnPoseObject();
        helpers.ClickMedialBorderMetacarpalLandmark();
        helpers.ClickTickBtnPoseObject();
        helpers.ClickWristCreaseCenterLandmark();
    }

    private void ExecuteThumbLevel()
    {
        helpers.ClickThumbBtnMainViewObject();
        altDriver.SetDelayAfterCommand(0.12f);
        helpers.ClickCrossBtnThumbObject();
        helpers.ClickConfirmBtnPopUpObject();
        helpers.ClickThumbBtnMainViewObject();
        SetThumbLandmarks();
        helpers.ClickBackArrowBtnThumbObject();
        helpers.ClickBackArrowBtnThumbObject();
        helpers.PerformRepeatedClicks(helpers.ClickTickBtnThumbObject, 3);
        helpers.ClickPreviousStepBtnThumbObject();
        helpers.ClickResetBtnPopUpObject(); // Repeat the step to set the landmarks
        SetThumbLandmarks();
        helpers.ClickTickBtnThumbObject();
        helpers.ClickCircumferenceBtnThumbObject();
        helpers.MoveSliderCircToMinThumbObject();
        helpers.MoveSliderCircToMaxThumbObject();
        helpers.ClickResetSliderBtnThumbObject();
        helpers.ClickValidateBtnThumbObject();
        helpers.ClickThumbBtnMainViewObject();
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
        helpers.ClickThumbMetaPhalangealLandmark();
        helpers.ClickTickBtnThumbObject();
        helpers.ClickFirstInterdigitalLandmark();
    }

    private void ExecuteSculptLevel()
    {
        helpers.ClickSculptBtnMainViewObject();
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