using System;
using AltTester.AltTesterUnitySDK.Driver;
using AutomatedTesting.Helpers.CommonHelpers;
using NUnit.Framework;
using System.Threading;

public partial class FullScanCorrectionA1R
{
    private AltDriver altDriver;
    private ScanCorrectionHelpersA1R helpers; // Utiliser une instance des Helpers pour accéder aux méthodes.

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        altDriver = AltDriverConfig.GetAltDriver();
        helpers = new ScanCorrectionHelpersAR(altDriver); // Initialisation avec le driver.
        Helpers.Initialize(altDriver); // Appel de la méthode Initialize
    }

    [OneTimeTearDown]
    public void TearDown()
    {
        AltDriverConfig.StopAltDriver();
    }

    [Test]
    public void FullScanCorrectionA1RWorkflow()
    {
        VerifyProductCode("A1");
        ExecuteCleanupLevel();
        ExecutePoseLevel();
        ExecuteSculptLevel();

    }
    private void VerifyProductCode(string expectedProductCode)
    {
       // GenericHelpers.VerifyTextContainsProductCode("/Canvas/BackToOrderPan/Button Navigation/Text (1)", expectedProductCode);
    }

    private void ExecuteCleanupLevel()
    {
        Helpers.ClickCleanupBtnMainViewObject();
        Helpers.ClickSelectPartOfInterestArmRightA2(); // Cannot use object here, use coordinate.
        Helpers.ClickQuitBtnObject();
        Helpers.ClickConfirmBtnPopUpObject();
        Helpers.ClickCleanupBtnMainViewObject();
        Helpers.ClickSelectPartOfInterestArmRightA2(); // Cannot use object here, use coordinate.
        Helpers.ClickNextStepBtnObject();
        Helpers.ClickCrossBtnObject();
        RepeatPreviousStep();
        SetCleanupLandmarks();
        Helpers.ClickPreviousStepBtnObject();
        Helpers.ClickKeepBtnLandmarksPopUpObject();
        Helpers.CuttingPlanePositionObject();
        Helpers.ClickVerticalAngleBtnObject();
        Helpers.MoveVerticalSliderCuttingPlanePositionObject();
        Helpers.ClickVerticalAngleBtnObject();
        Helpers.ClickHorizontalAngleBtnObject();
        Helpers.MoveHorizontalSliderCuttingPlanePositionObject();
        Helpers.ClickHorizontalAngleBtnObject();
        Helpers.ClickResetPlaneBtnObject();
        Helpers.CuttingPlanePositionObject();
        Helpers.ClickNextStepBtnObject();
        Helpers.ClickPreviousStepBtnObject();
        Helpers.CuttingPlanePositionObject();
        Helpers.ClickNextStepBtnObject();
        Helpers.ClickValidateBtnObject(); // Once the level has been fully completed one time, repeat all previous steps.
        ExecuteFullCleanupLevel();
    }

    private void ExecuteFullCleanupLevel()
    {
        Helpers.ClickCleanupBtnMainViewObject();
        Helpers.ClickConfirmBtnPopUpObject();
        Helpers.VerifyAndAssertText("/Cleanup/LevelNavigationPanel(Clone)/Canvas/StatusText/Variable Size Container/Text", Helpers.SelectPartOfScanText);
        Helpers.ClickSelectPartOfInterestArmRightA2();
        Helpers.ClickQuitBtnObject();
        Helpers.VerifyAndAssertText("/Canvas/WarnPopup(Clone)/Forma Info Panel v3/Content/Content text", Helpers.ModificationsWillBeLostText);
        Helpers.ClickConfirmBtnPopUpObject();
        Helpers.ClickCleanupBtnMainViewObject();
        Helpers.VerifyAndAssertText("/Cleanup/LevelNavigationPanel(Clone)/Canvas/StatusText/Variable Size Container/Text", Helpers.SelectPartOfScanText);
        Helpers.ClickSelectPartOfInterestArmRightA2();
        Helpers.ClickNextStepBtnObject();
        Helpers.VerifyAndAssertText("/Cleanup/LevelNavigationPanel(Clone)/Canvas/StatusText/Variable Size Container/Text", Helpers.PositionLandmarkText);
        Helpers.VerifyAndAssertText("/Cleanup/LMRunPlacementStep(Clone)/LMRunPlacementStepPanel/Canvas/ImageContainer/Label", Helpers.WristCreaseCenterText);
        Helpers.ClickCrossBtnObject(); // Return to Step 1 of Cleanup. Repeat the previous step.
        Helpers.VerifyAndAssertText("/Cleanup/LevelNavigationPanel(Clone)/Canvas/StatusText/Variable Size Container/Text", Helpers.SelectPartOfScanText);
        RepeatPreviousStep();
        Helpers.VerifyAndAssertText("/Cleanup/LevelNavigationPanel(Clone)/Canvas/StatusText/Variable Size Container/Text", Helpers.PositionLandmarkText);
        Helpers.VerifyAndAssertText("/Cleanup/LMRunPlacementStep(Clone)/LMRunPlacementStepPanel/Canvas/ImageContainer/Label", Helpers.WristCreaseCenterText);
        SetCleanupLandmarks();
        Helpers.ClickPreviousStepBtnObject();
        Helpers.VerifyAndAssertText("/Canvas/Popup(Clone)/Content/Content text", Helpers.OldLandmarksOrSetAgainText);
        Helpers.ClickKeepBtnLandmarksPopUpObject();
        Helpers.VerifyAndAssertText("/Cleanup/LevelNavigationPanel(Clone)/Canvas/StatusText/Variable Size Container/Text", Helpers.SelectPartOfScanCropOffText);
        Helpers.CuttingPlanePositionObject();
        Helpers.ClickVerticalAngleBtnObject();
        Helpers.MoveVerticalSliderCuttingPlanePositionObject();
        Helpers.ClickVerticalAngleBtnObject();
        Helpers.ClickHorizontalAngleBtnObject();
        Helpers.MoveHorizontalSliderCuttingPlanePositionObject();
        Helpers.ClickHorizontalAngleBtnObject();
        Helpers.ClickResetPlaneBtnObject();
        Helpers.CuttingPlanePositionObject();
        Helpers.ClickNextStepBtnObject();
        Helpers.VerifyAndAssertText("/Cleanup/LevelNavigationPanel(Clone)/Canvas/StatusText/Variable Size Container/Text", Helpers.CheckConfirmScanText);
        Helpers.ClickPreviousStepBtnObject();
        Helpers.CuttingPlanePositionObject();
        Helpers.ClickNextStepBtnObject();
        Helpers.VerifyAndAssertText("/Cleanup/LevelNavigationPanel(Clone)/Canvas/StatusText/Variable Size Container/Text", Helpers.CheckConfirmScanText);
        Helpers.ClickValidateBtnObject();
    }

    private void RepeatPreviousStep()
    {
        Helpers.ClickQuitBtnObject();
        Helpers.VerifyAndAssertText("/Canvas/WarnPopup(Clone)/Forma Info Panel v3/Content/Content text", Helpers.ModificationsWillBeLostText);
        Helpers.ClickConfirmBtnPopUpObject();
        Helpers.ClickCleanupBtnMainViewObject();
        Helpers.VerifyAndAssertText("/Cleanup/LevelNavigationPanel(Clone)/Canvas/StatusText/Variable Size Container/Text", Helpers.SelectPartOfScanText);
        Helpers.ClickSelectPartOfInterestArmRightA2();
        Helpers.ClickNextStepBtnObject();
    }

    private void SetCleanupLandmarks()
    {
        Helpers.ClickWristCreaseCenterCleanupLandmark();
        Helpers.ClickTickBtnObject();
        Helpers.VerifyAndAssertText("/Cleanup/LMRunPlacementStep(Clone)/LMRunPlacementStepPanel/Canvas/ImageContainer/Label", Helpers.VentralArmText);
        Helpers.ClickBackArrowBtnObject();
        Helpers.VerifyAndAssertText("/Cleanup/LMRunPlacementStep(Clone)/LMRunPlacementStepPanel/Canvas/ImageContainer/Label", Helpers.WristCreaseCenterText);
        Helpers.ClickWristCreaseCenterCleanupLandmark();
        Helpers.ClickTickBtnObject();
        Helpers.VerifyAndAssertText("/Cleanup/LMRunPlacementStep(Clone)/LMRunPlacementStepPanel/Canvas/ImageContainer/Label", Helpers.VentralArmText);
        Helpers.ClickVentralArmCleanupLandmark();
        Helpers.ClickTickBtnObject();

    }


    private void ExecutePoseLevel()
    {

        // STEPS FOR OLD EDITOR
        Helpers.ClickPoseBtnMainViewObject();
        Helpers.VerifyAndAssertText("/Canvas/StatusText/Variable Size Container/Text", Helpers.PosingModeSelectionText);
        Helpers.ClickQuitBtnPoseObject();
        Helpers.VerifyAndAssertText("/Canvas/WarnPopup(Clone)/Forma Info Panel v3/Content/Content text", Helpers.ModificationsWillBeLostText);
        Helpers.ClickConfirmBtnPopUpObject();
        Helpers.ClickPoseBtnMainViewObject();
        Helpers.VerifyAndAssertText("/Canvas/StatusText/Variable Size Container/Text", Helpers.PosingModeSelectionText);
        Helpers.ClickAdvancedPoseBtnObject();
        Helpers.VerifyAndAssertText("/Canvas/StatusText/Variable Size Container/Text", Helpers.PositionLandmarkText);
        Helpers.VerifyAndAssertText("/PoseCTL/LMRunPlacementStep/LMRunPlacementStepPanel/Canvas/ImageContainer/Label", Helpers.ThumbTipText);
        altDriver.SetDelayAfterCommand(0.12f);
        SetPoseLandmarks();
        altDriver.SetDelayAfterCommand(0);
        Helpers.PerformRepeatedClicks(Helpers.ClickBackArrowBtnPoseObject, 12);
        Helpers.PerformRepeatedClicks(Helpers.ClickTickBtnPoseObject, 13);
        Helpers.BeingProcessed();
        Helpers.VerifyAndAssertText("/Canvas/StatusText/Variable Size Container/Text", Helpers.CheckTheLimbPoseText);
        Helpers.ClickPreviousStepBtnPoseObject();
        Helpers.VerifyAndAssertText("/Canvas/Popup(Clone)/Content/Content text", Helpers.OldLandmarksOrSetAgainText);
        Helpers.ClickResetBtnPopUpObject();
        Helpers.ClickThumbTipLandmark();
        Helpers.PerformRepeatedClicks(Helpers.ClickTickBtnPoseObject, 13);
        Helpers.BeingProcessed();
        Helpers.ClickFirstSphereThumbExtFlexObject();
        Helpers.ClickFirstSphereThumbExtFlexBtnObject();
        Helpers.MoveSliderFirstSphereThumbExtFlexObject();
        Helpers.ClickSecondSphereThumbExtFlexObject();
        Helpers.ClickSecondSphereThumbExtFlexBtnObject();
        Helpers.MoveSliderSecondSphereThumbExtFlexObject();
        Helpers.ClickThirdSphereThumbExtFlexObject();
        Helpers.ClickThirdSphereThumbExtFlexBtnObject();
        Helpers.MoveSliderThirdSphereThumbExtFlexObject();
        Helpers.ClickThirdSphereThumbInversEversBtnObject();
        Helpers.MoveSliderThirdSphereThumbInversEversObject();
        Helpers.ClickThirdSphereThumbAbductAdductBtnObject();
        Helpers.MoveSliderThirdSphereThumbAbductAdductObject();
        Helpers.ClickFirstSphereIndexExtFlexObject();
        Helpers.ClickFirstSphereIndexExtFlexBtnObject();
        Helpers.MoveSliderFirstSphereIndexExtFlexObject();
        Helpers.ClickSecondSphereIndexExtFlexObject();
        Helpers.ClickSecondSphereIndexExtFlexBtnObject();
        Helpers.MoveSliderSecondSphereIndexExtFlexObject();
        Helpers.ClickThirdSphereIndexExtFlexObject();
        Helpers.ClickThirdSphereIndexExtFlexBtnObject();
        Helpers.MoveSliderThirdSphereIndexExtFlexObject();
        Helpers.ClickFirstSphereMiddleExtFlexObject();
        Helpers.ClickFirstSphereMiddleExtFlexBtnObject();
        Helpers.MoveSliderFirstSphereMiddleExtFlexObject();
        Helpers.ClickSecondSphereMiddleExtFlexObject();
        Helpers.ClickSecondSphereMiddleExtFlexBtnObject();
        Helpers.MoveSliderSecondSphereMiddleExtFlexObject();
        Helpers.ClickThirdSphereMiddleExtFlexObject();
        Helpers.ClickThirdSphereMiddleExtFlexBtnObject();
        Helpers.MoveSliderThirdSphereMiddleExtFlexObject();
        Helpers.ClickFirstSphereRingExtFlexObject();
        Helpers.ClickFirstSphereRingExtFlexBtnObject();
        Helpers.MoveSliderFirstSphereRingExtFlexObject();
        Helpers.ClickSecondSphereRingExtFlexObject();
        Helpers.ClickSecondSphereRingExtFlexBtnObject();
        Helpers.MoveSliderSecondSphereRingExtFlexObject();
        Helpers.ClickThirdSphereRingExtFlexObject();
        Helpers.ClickThirdSphereRingExtFlexBtnObject();
        Helpers.MoveSliderThirdSphereRingExtFlexObject();
        Helpers.ClickFirstSphereLittleExtFlexObject();
        Helpers.ClickFirstSphereLittleExtFlexBtnObject();
        Helpers.MoveSliderFirstSphereLittleExtFlexObject();
        Helpers.ClickSecondSphereLittleExtFlexObject();
        Helpers.ClickSecondSphereLittleExtFlexBtnObject();
        Helpers.MoveSliderSecondSphereLittleExtFlexObject();
        Helpers.ClickThirdSphereLittleExtFlexObject();
        Helpers.ClickThirdSphereLittleExtFlexBtnObject();
        Helpers.MoveSliderThirdSphereLittleExtFlexObject();
        Helpers.ClickHandSphereObject();
        Helpers.ClickHandSphereExtFlexBtnObject();
        Helpers.MoveSliderHandSphereExtFlexObject();
        Helpers.ClickHandSphereAbducAdducBtnObject();
        Helpers.MoveSliderHandSphereAbducAdducObject();
        Helpers.ClickGlobalRotationPoseBtnObject();
        Helpers.ClickGlobalRotationForwardPoseBtnObject();
        Helpers.MoveSliderGlobalRotationForwardObject();
        Helpers.ClickGlobalRotationRightPoseBtnObject();
        Helpers.MoveSliderGlobalRotationRightObject();
        Helpers.ClickGlobalRotationVerticalPoseBtnObject();
        Helpers.MoveSliderGlobalRotationVerticalObject();
        altDriver.SetDelayAfterCommand(0.12f);
        Helpers.ClickNeutralPoseBtnObject();
        Helpers.ClickResetSliderPoseBtnObject();
        Helpers.ClickAppearanceBtnObject();
        //VerifyAndAssertText("/Canvas/PosePan(Clone)/Panel/MatDropDown/Dropdown List/Viewport/Content/Item 0: Normal", NormalAppearanceText);
        //VerifyAndAssertText("/Canvas/PosePan(Clone)/Panel/MatDropDown/Dropdown List/Viewport/Content/Item 1: Transparent", TransparentAppearanceText);
        //VerifyAndAssertText("/Canvas/PosePan(Clone)/Panel/MatDropDown/Dropdown List/Viewport/Content/Item 2: Neutral ghost", NeutralGhostAppearanceText);
        Helpers.ClickTransparentChoiceBtnObject();
        Helpers.ClickAppearanceBtnObject();
        Helpers.ClickNeutralGhostChoiceBtnObject();
        altDriver.SetDelayAfterCommand(0);
        Helpers.ClickPreviousStepBtnPoseObject();
        Helpers.VerifyAndAssertText("/Canvas/Popup(Clone)/Content/Content text", Helpers.OldLandmarksOrSetAgainText);
        Helpers.ClickKeepBtnLandmarksPopUpObject(); // Repeat all actions for this step (pose editor) until PreviousStepBtn
        Helpers.BeingProcessed();
        ExecutePoseEditorSteps();
        Helpers.ClickValidateBtnPoseObject();
        Helpers.ClickPoseBtnMainViewObject();
        Helpers.VerifyAndAssertText("/Canvas/WarnPopup(Clone)/Forma Info Panel v3/Content/Content text", Helpers.AllChangesLostText);
        Helpers.ClickConfirmBtnPopUpObject();
        Helpers.VerifyAndAssertText("/Canvas/StatusText/Variable Size Container/Text", Helpers.PosingModeSelectionText);
        Helpers.ClickAdvancedPoseBtnObject();
        Helpers.VerifyAndAssertText("/Canvas/Popup(Clone)/Content/Content text", Helpers.OldLandmarksOrSetAgainText);
        Helpers.ClickKeepBtnLandmarksPopUpObject();//Repeat one last time the actions performed in the step editor and validate again)
        Helpers.BeingProcessed();
        ExecutePoseEditorSteps();
        Helpers.ClickResetSliderPoseBtnObject();
        Helpers.ClickValidateBtnPoseObject();

    }

    private void ExecutePoseEditorSteps()
    {

        Helpers.ClickFirstSphereThumbExtFlexObject();
        Helpers.ClickFirstSphereThumbExtFlexBtnObject();
        Helpers.MoveSliderFirstSphereThumbExtFlexObject();
        Helpers.ClickSecondSphereThumbExtFlexObject();
        Helpers.ClickSecondSphereThumbExtFlexBtnObject();
        Helpers.MoveSliderSecondSphereThumbExtFlexObject();
        Helpers.ClickThirdSphereThumbExtFlexObject();
        Helpers.ClickThirdSphereThumbExtFlexBtnObject();
        Helpers.MoveSliderThirdSphereThumbExtFlexObject();
        Helpers.ClickThirdSphereThumbInversEversBtnObject();
        Helpers.MoveSliderThirdSphereThumbInversEversObject();
        Helpers.ClickThirdSphereThumbAbductAdductBtnObject();
        Helpers.MoveSliderThirdSphereThumbAbductAdductObject();
        Helpers.ClickFirstSphereIndexExtFlexObject();
        Helpers.ClickFirstSphereIndexExtFlexBtnObject();
        Helpers.MoveSliderFirstSphereIndexExtFlexObject();
        Helpers.ClickSecondSphereIndexExtFlexObject();
        Helpers.ClickSecondSphereIndexExtFlexBtnObject();
        Helpers.MoveSliderSecondSphereIndexExtFlexObject();
        Helpers.ClickThirdSphereIndexExtFlexObject();
        Helpers.ClickThirdSphereIndexExtFlexBtnObject();
        Helpers.MoveSliderThirdSphereIndexExtFlexObject();
        Helpers.ClickFirstSphereMiddleExtFlexObject();
        Helpers.ClickFirstSphereMiddleExtFlexBtnObject();
        Helpers.MoveSliderFirstSphereMiddleExtFlexObject();
        Helpers.ClickSecondSphereMiddleExtFlexObject();
        Helpers.ClickSecondSphereMiddleExtFlexBtnObject();
        Helpers.MoveSliderSecondSphereMiddleExtFlexObject();
        Helpers.ClickThirdSphereMiddleExtFlexObject();
        Helpers.ClickThirdSphereMiddleExtFlexBtnObject();
        Helpers.MoveSliderThirdSphereMiddleExtFlexObject();
        Helpers.ClickFirstSphereRingExtFlexObject();
        Helpers.ClickFirstSphereRingExtFlexBtnObject();
        Helpers.MoveSliderFirstSphereRingExtFlexObject();
        Helpers.ClickSecondSphereRingExtFlexObject();
        Helpers.ClickSecondSphereRingExtFlexBtnObject();
        Helpers.MoveSliderSecondSphereRingExtFlexObject();
        Helpers.ClickThirdSphereRingExtFlexObject();
        Helpers.ClickThirdSphereRingExtFlexBtnObject();
        Helpers.MoveSliderThirdSphereRingExtFlexObject();
        Helpers.ClickFirstSphereLittleExtFlexObject();
        Helpers.ClickFirstSphereLittleExtFlexBtnObject();
        Helpers.MoveSliderFirstSphereLittleExtFlexObject();
        Helpers.ClickSecondSphereLittleExtFlexObject();
        Helpers.ClickSecondSphereLittleExtFlexBtnObject();
        Helpers.MoveSliderSecondSphereLittleExtFlexObject();
        Helpers.ClickThirdSphereLittleExtFlexObject();
        Helpers.ClickThirdSphereLittleExtFlexBtnObject();
        Helpers.MoveSliderThirdSphereLittleExtFlexObject();
        Helpers.ClickHandSphereObject();
        Helpers.ClickHandSphereExtFlexBtnObject();
        Helpers.MoveSliderHandSphereExtFlexObject();
        Helpers.ClickHandSphereAbducAdducBtnObject();
        Helpers.MoveSliderHandSphereAbducAdducObject();

    }

    private void SetPoseLandmarks()
    {
        Helpers.ClickThumbTipLandmark();
        Helpers.ClickTickBtnPoseObject();
        Helpers.VerifyAndAssertText("/PoseCTL/LMRunPlacementStep/LMRunPlacementStepPanel/Canvas/ImageContainer/Label", Helpers.DistalEndIndexFingerText);
        Helpers.ClickDistalEndIndexLandmark();
        Helpers.ClickTickBtnPoseObject();
        Helpers.VerifyAndAssertText("/PoseCTL/LMRunPlacementStep/LMRunPlacementStepPanel/Canvas/ImageContainer/Label", Helpers.DistalEndMiddleFingerText);
        Helpers.ClickDistalMiddleFingerLandmark();
        Helpers.ClickTickBtnPoseObject();
        Helpers.VerifyAndAssertText("/PoseCTL/LMRunPlacementStep/LMRunPlacementStepPanel/Canvas/ImageContainer/Label", Helpers.DistalEndRingFingerText);
        Helpers.ClickDistalRingFingerLandmark();
        Helpers.ClickTickBtnPoseObject();
        Helpers.VerifyAndAssertText("/PoseCTL/LMRunPlacementStep/LMRunPlacementStepPanel/Canvas/ImageContainer/Label", Helpers.DistalEndLittleFingerText);
        Helpers.ClickDistalLittleFingerLandmark();
        Helpers.ClickTickBtnPoseObject();
        Helpers.VerifyAndAssertText("/PoseCTL/LMRunPlacementStep/LMRunPlacementStepPanel/Canvas/ImageContainer/Label", Helpers.ThumbMetacarpalText);
        Helpers.ClickThumbMetacarpalLandmark();
        Helpers.ClickTickBtnPoseObject();
        Helpers.VerifyAndAssertText("/PoseCTL/LMRunPlacementStep/LMRunPlacementStepPanel/Canvas/ImageContainer/Label", Helpers.IndexMetacarpalText);
        Helpers.ClickIndexMetacarpalLandmark();
        Helpers.ClickTickBtnPoseObject();
        Helpers.VerifyAndAssertText("/PoseCTL/LMRunPlacementStep/LMRunPlacementStepPanel/Canvas/ImageContainer/Label", Helpers.MiddleMetacarpalText);
        Helpers.ClickMiddleMetacarpalLandmark();
        Helpers.ClickTickBtnPoseObject();
        Helpers.VerifyAndAssertText("/PoseCTL/LMRunPlacementStep/LMRunPlacementStepPanel/Canvas/ImageContainer/Label", Helpers.RingMetacarpalText);
        Helpers.ClickRingMetacarpalLandmark();
        Helpers.ClickTickBtnPoseObject();
        Helpers.VerifyAndAssertText("/PoseCTL/LMRunPlacementStep/LMRunPlacementStepPanel/Canvas/ImageContainer/Label", Helpers.LittleMetacarpalText);
        Helpers.ClickLittleMetacarpalLandmark();
        Helpers.ClickTickBtnPoseObject();
        Helpers.VerifyAndAssertText("/PoseCTL/LMRunPlacementStep/LMRunPlacementStepPanel/Canvas/ImageContainer/Label", Helpers.MetacarpalCreaseCenterText);
        Helpers.ClickCreaseCenterMetacarpalLandmark();
        Helpers.ClickTickBtnPoseObject();
        Helpers.VerifyAndAssertText("/PoseCTL/LMRunPlacementStep/LMRunPlacementStepPanel/Canvas/ImageContainer/Label", Helpers.MedialBorderMetacarpalText);
        Helpers.ClickMedialBorderMetacarpalLandmark();
        Helpers.ClickTickBtnPoseObject();
        Helpers.VerifyAndAssertText("/PoseCTL/LMRunPlacementStep/LMRunPlacementStepPanel/Canvas/ImageContainer/Label", Helpers.WristCreaseCenterText);
        Helpers.ClickWristCreaseCenterLandmark();
    }

    private void ExecuteSculptLevel()
    {
        Helpers.ClickSculptBtnMainNoThumbViewObject();
        Helpers.VerifyAndAssertText("/Canvas/StatusText/Variable Size Container/Text", Helpers.SculptEditorText);
        Helpers.ClickFirstOnMeshToActivateDrawingSculptObject();
        Helpers.FirstPullOnMeshSculptObject();
        Helpers.SecondPullOnMeshSculptObject();
        Helpers.ClickUndoBtnSculptObject();
        Helpers.ClickUndoBtnSculptObject();
        Helpers.ClickRedoBtnSculptObject();
        Helpers.ClickRedoBtnSculptObject();
        Helpers.ClickBrushDiameterBtnSculptObject();
        Helpers.MoveSliderBrushDiameterSculptObject();
        Helpers.ClickPullPushBtnSculptObject();
        Helpers.ClickOnAxisYSculptObject();
        Thread.Sleep(500);
        Helpers.ClickOnAxisXSculptObject();
        Thread.Sleep(500);
        Helpers.FirstPushOnMeshSculptObject();
        Helpers.SecondPushOnMeshSculptObject();
        Helpers.ClickEraseBtnSculptObject();
        Helpers.EraseAreaOnMeshSculptObject();
        Helpers.MoveSliderEraserDiameterSculptObject();
        Helpers.ClickOnBrushBtnSculptObject();
        Helpers.ClickLimitValueBtnSculptObject();
        Helpers.MoveSliderLimitValueSculptObject();
        Helpers.CheckLimitValuePullPushSculptObject();
        Helpers.ClickPullPushBtnSculptObject();
        Helpers.ClickNextStepBtnSculptObject();
        Helpers.VerifyAndAssertText("/Canvas/StatusText/Variable Size Container/Text", Helpers.SculptValidationText);
        Helpers.ClickPreviousStepBtnSculptObject();
        Helpers.VerifyAndAssertText("/Canvas/SculptUI(Clone)/InteractiveUIRoot/Pull Push  Switch/Labels/Label On", Helpers.PullOptionActivated);
        Helpers.ClickPullPushBtnSculptObject();
        Helpers.ClickNextStepBtnSculptObject();
        Helpers.VerifyAndAssertText("/Canvas/StatusText/Variable Size Container/Text", Helpers.SculptValidationText);
        Helpers.ClickPreviousStepBtnSculptObject();
        Helpers.VerifyAndAssertText("/Canvas/SculptUI(Clone)/InteractiveUIRoot/Pull Push  Switch/Labels/Label Off", Helpers.PushOptionActivated);
        Helpers.ClickOnAxisYSculptObject();
        Thread.Sleep(500);
        Helpers.ClickOnAxisAntiXSculptObject();
        Thread.Sleep(500);
        Helpers.ClickFlattenToolBtnSculptObject();
        Helpers.MoveFlattenToolSculptObject();
        Helpers.ClickOnAxisYSculptObject();
        Thread.Sleep(500);
        Helpers.ClickOnAxisXSculptObject();
        Thread.Sleep(500);
        Helpers.ClickFillValleyToolBtnSculptObject();
        Helpers.MoveFillValleyToolBtnSculptObject();
        Helpers.ClickNextStepBtnSculptObject();
        Helpers.SecondPushOnMeshSculptObject();
        Helpers.ClickValidateBtnSculptObject();
        Helpers.ClickSculptBtnMainNoThumbViewObject();
        Helpers.ClickConfirmBtnPopUpObject(); // The previous changes are deleted (not saved) and we repeat again the previous step unitl Validate btn
        ExecuteSculptSteps();
    }

    private void ExecuteSculptSteps()
    {
        Helpers.ClickOnBrushBtnSculptObject();
        Helpers.MoveSliderBrushDiameterToMinSculptObject();
        Helpers.ClickFirstOnMeshToActivateDrawingSculptObject();
        Helpers.FirstPullOnMeshSculptObject();
        Helpers.SecondPullOnMeshSculptObject();
        Helpers.ClickUndoBtnSculptObject();
        Helpers.ClickUndoBtnSculptObject();
        Helpers.ClickRedoBtnSculptObject();
        Helpers.ClickRedoBtnSculptObject();
        Helpers.ClickBrushDiameterBtnSculptObject();
        Helpers.MoveSliderBrushDiameterSculptObject();
        Helpers.ClickPullPushBtnSculptObject();
        Helpers.ClickOnAxisYSculptObject();
        Thread.Sleep(500);
        Helpers.ClickOnAxisXSculptObject();
        Thread.Sleep(500);
        Helpers.FirstPushOnMeshSculptObject();
        Helpers.SecondPushOnMeshSculptObject();
        Helpers.ClickEraseBtnSculptObject();
        Helpers.EraseAreaOnMeshSculptObject();
        Helpers.MoveSliderEraserDiameterSculptObject();
        Helpers.ClickOnBrushBtnSculptObject();
        Helpers.ClickLimitValueBtnSculptObject();
        Helpers.MoveSliderLimitValueSculptObject();
        Helpers.CheckLimitValuePullPushSculptObject();
        Helpers.ClickPullPushBtnSculptObject();
        Helpers.ClickNextStepBtnSculptObject();
        Helpers.ClickPreviousStepBtnSculptObject();
        Helpers.ClickPullPushBtnSculptObject();
        Helpers.ClickNextStepBtnSculptObject();
        Helpers.ClickPreviousStepBtnSculptObject();
        Helpers.ClickOnAxisYSculptObject();
        Thread.Sleep(500);
        Helpers.ClickOnAxisAntiXSculptObject();
        Thread.Sleep(500);
        Helpers.ClickFlattenToolBtnSculptObject();
        Helpers.MoveFlattenToolSculptObject();
        Helpers.ClickOnAxisYSculptObject();
        Thread.Sleep(500);
        Helpers.ClickOnAxisXSculptObject();
        Thread.Sleep(500);
        Helpers.ClickFillValleyToolBtnSculptObject();
        Helpers.MoveFillValleyToolBtnSculptObject();
        Helpers.ClickNextStepBtnSculptObject();
        Helpers.SecondPushOnMeshSculptObject();
        Helpers.ClickValidateBtnSculptObject();
    }
}