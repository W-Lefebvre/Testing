using System;
using AltTester.AltTesterUnitySDK.Driver;
using NUnit.Framework;
using System.Threading;

public partial class FullScanCorrectionB2R
{
    private AltDriver altDriver;
    private ScanCorrectionHelpersB2R helpers; // Utiliser une instance des helpers pour accéder aux méthodes.

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        altDriver = new AltDriver(host: ConnexionConfig.Host, port: ConnexionConfig.Port, appName: ConnexionConfig.AppName);
        helpers = new ScanCorrectionHelpersB2R(altDriver); // Initialisation avec le driver.
    }

    [OneTimeTearDown]
    public void TearDown()
    {
        altDriver.Stop();
    }

    [Test]
    public void FullScanCorrectionB2RWorkflow()
    {
        ExecuteCleanupLevel();
        ExecutePoseLevel();
        ExecuteSculptLevel();

    }

    private void ExecuteCleanupLevel()
    {
        //altDriver.SetDelayAfterCommand(0.25f);
        
        helpers.ClickCleanupBtnMainViewObject();
        helpers.ClickSelectPartOfInterestLegRightB2(); // Cannot use object here, use coordinate.
        helpers.ClickQuitBtnObject();
        helpers.ClickConfirmBtnPopUpObject();
        helpers.ClickCleanupBtnMainViewObject();
        helpers.ClickSelectPartOfInterestLegRightB2();
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
        helpers.ClickSelectPartOfInterestLegRightB2();
        helpers.ClickQuitBtnObject();
        helpers.ClickConfirmBtnPopUpObject();
        helpers.ClickCleanupBtnMainViewObject();
        helpers.ClickSelectPartOfInterestLegRightB2();
        helpers.ClickNextStepBtnObject();
        helpers.ClickCrossBtnObject(); // Return to Step 1 of Cleanup. Repeat the previous step.
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
        helpers.ClickValidateBtnObject();
    }

    private void RepeatPreviousStep()
    {
        helpers.ClickQuitBtnObject();
        helpers.ClickConfirmBtnPopUpObject();
        helpers.ClickCleanupBtnMainViewObject();
        helpers.ClickSelectPartOfInterestLegRightB2();
        helpers.ClickNextStepBtnObject();
    }

    private void SetCleanupLandmarks()
    {
        helpers.ClickMedialMalleolusCenterCleanupLandmark();
        helpers.ClickTickBtnObject();
        helpers.ClickBackArrowBtnObject();
        helpers.ClickMedialMalleolusCenterCleanupLandmark();
        helpers.ClickTickBtnObject();
        helpers.ClickOnAxisZObject();
        Thread.Sleep(100);
        helpers.ClickTibiaMidCleanupLandmark();
        helpers.ClickBackArrowBtnObject();
        helpers.ClickTickBtnObject();
        helpers.ClickTickBtnObject();

    }


    private void ExecutePoseLevel()
    {
        // STEPS FOR OLD EDITOR
        helpers.ClickPoseBtnMainViewObject();
        helpers.ClickCrossBtnPoseObject();
        helpers.ClickConfirmBtnPopUpObject();
        helpers.ClickPoseBtnMainViewObject();
        altDriver.SetDelayAfterCommand(0.12f);
        SetPoseLandmarks();
        altDriver.SetDelayAfterCommand(0);
        helpers.PerformRepeatedClicks(helpers.ClickBackArrowBtnPoseObject, 9);
        helpers.PerformRepeatedClicks(helpers.ClickTickBtnPoseObject, 10);
        helpers.BeingProcessed();
        helpers.ClickPreviousStepBtnPoseObject();
        helpers.ClickResetBtnPopUpObject();
        helpers.ReplaceMedialMalleolusCenterCleanupLandmark();
        helpers.PerformRepeatedClicks(helpers.ClickTickBtnPoseObject, 10);
        helpers.BeingProcessed();
        helpers.ClickGlobalRotationPoseBtnObject();
        helpers.ClickGlobalRotationForwardPoseBtnObject();
        helpers.MoveSliderGlobalRotationForwardObject();
        helpers.ClickGlobalRotationRightPoseBtnObject();
        helpers.MoveSliderGlobalRotationRightObject();
        helpers.ClickGlobalRotationVerticalPoseBtnObject();
        helpers.MoveSliderGlobalRotationVerticalObject();
        helpers.ClickResetSliderPoseBtnObject();
        helpers.ClickAppearanceBtnObject();
        helpers.ClickTransparentChoiceBtnObject();
       // helpers.ClickAppearanceBtnObject();
        //helpers.ClickNeutralGhostChoiceBtnObject();
        //helpers.ClickAppearanceBtnObject();
        //helpers.ClickTransparentChoiceBtnObject();
        helpers.ClickFirstSphereFootObject();
        helpers.ClickFirstSphereFootInvEverBtnObject();
        helpers.MoveSliderFirstSphereFootInvEverObject();
        helpers.ClickFirstSphereFootPlantarDorsalBtnObject();
        helpers.MoveSliderFirstSphereFootPlantarDorsalObject();
        helpers.ClickFirstSphereFootTwistLeftRightBtnObject();
        helpers.MoveSliderFirstSphereFootTwistLeftRightObject();
        helpers.ClickSecondSphereFootObject();
        helpers.ClickSecondSphereFootAbductAdductBtnObject();
        helpers.MoveSliderSecondSphereFootAbductAdductBtnObject();
        helpers.ClickSecondSphereFootTwistLeftRightBtnObject();
        helpers.MoveSliderSecondSphereFootTwistLeftRightBtnObject();
        helpers.ClickThirdSphereFootObject();
        helpers.ClickThirdSphereFootRaiseLowerBtnObject();
        helpers.MoveSliderThirdSphereFootRaiseLowerBtnObject();
        helpers.ClickFourthSphereFootObject();
        helpers.ClickFourthSphereFootExtFlexBtnObject();
        helpers.MoveSliderFourthSphereFootExtFlexBtnObject();
        helpers.ClickPreviousStepBtnPoseObject();
        helpers.ClickKeepBtnLandmarksPopUpObject();
        helpers.BeingProcessed();
        ExecutePoseEditorSteps();
        helpers.ClickValidateBtnPoseObject();
        helpers.ClickPoseBtnMainViewObject();
        helpers.ClickConfirmBtnPopUpObject();
        helpers.ClickKeepBtnLandmarksPopUpObject(); //Repeat one last time the actions performed in the step editor and validate again)
        helpers.BeingProcessed();
        ExecutePoseEditorSteps();
        helpers.ClickResetSliderPoseBtnObject();
        helpers.ClickValidateBtnPoseObject();
    }

    private void ExecutePoseEditorSteps()
    {
        helpers.ClickPreviousStepBtnPoseObject();
        helpers.ClickResetBtnPopUpObject();
        helpers.ReplaceMedialMalleolusCenterCleanupLandmark();
        helpers.PerformRepeatedClicks(helpers.ClickTickBtnPoseObject, 10);
        helpers.BeingProcessed();
        helpers.ClickGlobalRotationPoseBtnObject();
        helpers.ClickGlobalRotationForwardPoseBtnObject();
        helpers.MoveSliderGlobalRotationForwardObject();
        helpers.ClickGlobalRotationRightPoseBtnObject();
        helpers.MoveSliderGlobalRotationRightObject();
        helpers.ClickGlobalRotationVerticalPoseBtnObject();
        helpers.MoveSliderGlobalRotationVerticalObject();
        helpers.ClickResetSliderPoseBtnObject();
        helpers.ClickAppearanceBtnObject();
        helpers.ClickTransparentChoiceBtnObject();
       // helpers.ClickAppearanceBtnObject();
        //helpers.ClickNeutralGhostChoiceBtnObject();
        //helpers.ClickAppearanceBtnObject();
        //helpers.ClickTransparentChoiceBtnObject();
        helpers.ClickFirstSphereFootObject();
        helpers.ClickFirstSphereFootInvEverBtnObject();
        helpers.MoveSliderFirstSphereFootInvEverObject();
        helpers.ClickFirstSphereFootPlantarDorsalBtnObject();
        helpers.MoveSliderFirstSphereFootPlantarDorsalObject();
        helpers.ClickFirstSphereFootTwistLeftRightBtnObject();
        helpers.MoveSliderFirstSphereFootTwistLeftRightObject();
        helpers.ClickSecondSphereFootObject();
        helpers.ClickSecondSphereFootAbductAdductBtnObject();
        helpers.MoveSliderSecondSphereFootAbductAdductBtnObject();
        helpers.ClickSecondSphereFootTwistLeftRightBtnObject();
        helpers.MoveSliderSecondSphereFootTwistLeftRightBtnObject();
        helpers.ClickThirdSphereFootObject();
        helpers.ClickThirdSphereFootRaiseLowerBtnObject();
        helpers.MoveSliderThirdSphereFootRaiseLowerBtnObject();
        helpers.ClickFourthSphereFootObject();
        helpers.ClickFourthSphereFootExtFlexBtnObject();
        helpers.MoveSliderFourthSphereFootExtFlexBtnObject();
    }

    private void SetPoseLandmarks()
    {
        helpers.ClickMedialMalleolusCenterCleanupLandmark();
        helpers.ClickTickBtnPoseObject();
        helpers.ClickMetatarsusFirstBonePoseLandmark();
        helpers.ClickTickBtnPoseObject();
        helpers.ClickFirstToePoseLandmark();
        helpers.ClickTickBtnPoseObject();
        helpers.ClickSecondToePoseLandmark();
        helpers.ClickTickBtnPoseObject();
        helpers.ClickThirdToePoseLandmark();
        helpers.ClickTickBtnPoseObject();
        helpers.ClickFourthToePoseLandmark();
        helpers.ClickTickBtnPoseObject();
        helpers.ClickFifthToePoseLandmark();
        helpers.ClickTickBtnPoseObject();
        helpers.ClickMetatarsusFifthBonePoseLandmark();
        helpers.ClickTickBtnPoseObject();
        helpers.ClickLateralMalleolusCenterPoseLandmark();
        helpers.ClickTickBtnPoseObject();
        helpers.ClickCalcaneusCenterPoseLandmark();
    }

    private void ExecuteSculptLevel()
    {
        //altDriver.SetDelayAfterCommand(0.25f);
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
        helpers.ClickOnAxisAntiZSculptObject();
        Thread.Sleep(250);
        helpers.ClickOnAxisXSculptObject();
        Thread.Sleep(250);
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
        helpers.ClickFlattenToolBtnSculptObject();
        helpers.MoveFlattenToolSculptObject();
       // helpers.ClickOnAxisYSculptObject();
       // Thread.Sleep(250);
       // helpers.ClickOnAxisXSculptObject();
       // Thread.Sleep(250);
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
        helpers.ClickOnAxisAntiZSculptObject();
        Thread.Sleep(250);
        helpers.ClickOnAxisXSculptObject();
        Thread.Sleep(250);
        helpers.FirstPushOnMeshSculptObject();
        helpers.SecondPushOnMeshSculptObject();
        helpers.ClickEraseBtnSculptObject();
        helpers.ClickBrushDiameterBtnSculptObject();
        helpers.MoveSliderEraserDiameterSculptObject();
        helpers.EraseAreaOnMeshSculptObject();
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
        helpers.ClickFlattenToolBtnSculptObject();
        helpers.MoveFlattenToolSculptObject();
       // helpers.ClickOnAxisYSculptObject();
       // Thread.Sleep(250);
       // helpers.ClickOnAxisXSculptObject();
       // Thread.Sleep(250);
        helpers.ClickFillValleyToolBtnSculptObject();
        helpers.MoveFillValleyToolBtnSculptObject();
        helpers.ClickNextStepBtnSculptObject();
        helpers.SecondPushOnMeshSculptObject();
        helpers.ClickValidateBtnSculptObject();

    }
}