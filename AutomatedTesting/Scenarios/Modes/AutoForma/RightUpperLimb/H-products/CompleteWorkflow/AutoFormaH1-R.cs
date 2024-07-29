using System;
using AltTester.AltTesterUnitySDK.Driver;
using AutomatedTesting.Helpers.CommonHelpers;
using NUnit.Framework;
using System.Threading;

public partial class FullAutoFormaH1R
{
    private AltDriver altDriver;
    private AutoFormaHelpersH1R helpers; // Utiliser une instance des helpers pour accéder aux méthodes.

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        altDriver = AltDriverConfig.GetAltDriver();
        helpers = new AutoFormaHelpersH1R(altDriver); // Initialisation avec le driver.
    }

    [OneTimeTearDown]
    public void TearDown()
    {
        AltDriverConfig.StopAltDriver();
    }

    [Test]
    public void FullAutoFormaH1RWorkflow()
    {
        VerifyProductCode("H1");
        ExecuteFitLevel();
       // ExecuteClosingSystemLevel();
       // ExecuteSerialNumberEngraverLevel();

    }

    private void VerifyProductCode(string expectedProductCode)
    {
        GenericHelpers.VerifyTextContainsProductCode("/Canvas/BackToOrderPan/Button Navigation/Text (1)", expectedProductCode);
    }

    private void ExecuteFitLevel()
    {
        altDriver.SetDelayAfterCommand(0.12f);
        helpers.ClickFitBtnMainViewObject();
        helpers.ClickQuitBtnFitObject();
        helpers.ClickCancelBtnPopUpFitObject();
        helpers.ClickQuitBtnFitObject();
        helpers.ClickConfirmBtnPopUpObject();
        helpers.ClickFitBtnMainViewObject();
        SetFitLandmarks();
        helpers.PerformRepeatedClicks(helpers.ClickBackArrowBtnFitObject, 12);
        helpers.PerformRepeatedClicks(helpers.ClickTickBtnFitObject, 13);
        helpers.BeingProcessed();
        helpers.ClickPreviousStepBtnFitObject();
        helpers.ClickResetPopUpBtnFitObject();
        helpers.ClickThumbTipLandmark();
        helpers.PerformRepeatedClicks(helpers.ClickTickBtnFitObject, 13);
        helpers.BeingProcessed();
      //  helpers.ClickLenghtBtnFitObject();
      //  helpers.MoveSliderLengthFitObject();
      //  helpers.MoveSliderLengthTo100FitObject();
        helpers.ClickBoundaryWidthBtnFitObject();
        helpers.MoveSliderBoundaryWidthFitObject();
        helpers.ClickSelectableAlveoleZoneBtnFitObject();
        helpers.MoveSliderRadiusFitObject();
        helpers.MoveSliderWidthFitObject();
        helpers.MoveSliderDensityFitObject();
        helpers.MoveSliderRadiusTo0FitObject();
        helpers.ClickNextStepBtnFitObject();
        helpers.ClickPreviousStepBtnFitObject();
        helpers.ClickNextStepBtnFitObject();
        helpers.ClickGlobalThicknessBtnFitObject();
        helpers.MoveSliderGlobalThicknessFitObject();
        helpers.ClickGlobalOffsetBtnFitObject();
        helpers.MoveSliderGlobalOffsetFitObject();
        helpers.ClickBoundaryThicknessBtnFitObject();
        helpers.MoveSliderBoundaryThicknessFitObject();
        helpers.ClickBoundaryFlareBtnFitObject();
        helpers.MoveSliderBoundaryFlareFitObject();
        helpers.ClickNextStepBtnFitObject();
        helpers.ClickOkInformationPopUpBtnFitObject();
        helpers.ClickValidateBtnFitObject();

    }

    private void SetFitLandmarks()
    {
        altDriver.SetDelayAfterCommand(0.12f);
        helpers.ClickThumbTipLandmark();
        helpers.ClickTickBtnFitObject();
        helpers.ClickDistalEndIndexLandmark();
        helpers.ClickTickBtnFitObject();
        helpers.ClickDistalMiddleFingerLandmark();
        helpers.ClickTickBtnFitObject();
        helpers.ClickDistalRingFingerLandmark();
        helpers.ClickTickBtnFitObject();
        helpers.ClickDistalLittleFingerLandmark();
        helpers.ClickTickBtnFitObject();
        helpers.ClickThumbMetacarpalLandmark();
        helpers.ClickTickBtnFitObject();
        helpers.ClickIndexMetacarpalLandmark();
        helpers.ClickTickBtnFitObject();
        helpers.ClickMiddleMetacarpalLandmark();
        helpers.ClickTickBtnFitObject();
        helpers.ClickRingMetacarpalLandmark();
        helpers.ClickTickBtnFitObject();
        helpers.ClickLittleMetacarpalLandmark();
        helpers.ClickTickBtnFitObject();
        helpers.ClickCreaseCenterMetacarpalLandmark();
        helpers.ClickTickBtnFitObject();
        helpers.ClickMedialBorderMetacarpalLandmark();
        helpers.ClickTickBtnFitObject();
        helpers.ClickWristCreaseCenterLandmark();
    }


    private void ExecuteClosingSystemLevel()
    {
        altDriver.SetDelayAfterCommand(0.20f);
        helpers.ClickClosingSystemsBtnMainViewObject();
        helpers.ClickQuitBtnClosingObject();
        helpers.ClickCancelExitLevelBtnRailObject();
        helpers.ClickQuitBtnClosingObject();
        helpers.ClickConfirmExitLevelBtnRailObject();
        helpers.ClickClosingSystemsBtnMainViewObject();
        helpers.ClickRotateScanAntiYClosingObject();
        helpers.ClickRotateScanXClosingObject();
        helpers.ClickShowMenuClosingSystemBtnClosingObject();
        helpers.ClickRivetHoleClosingSystemBtnClosingObject();
        helpers.ClickBackArrowBtnClosingObject();
        helpers.ClickShowMenuClosingSystemBtnClosingObject();
        helpers.ClickRivetHoleClosingSystemBtnClosingObject();
        helpers.ClickOnSplintToAddRivetHole1Closing();
        helpers.ClickTickBtnClosingObject();
        helpers.ClickShowMenuClosingSystemBtnClosingObject();
        helpers.ClickRivetHoleClosingSystemBtnClosingObject();
        helpers.ClickBackArrowBtnClosingObject();
        helpers.ClickShowMenuClosingSystemBtnClosingObject();
        helpers.ClickRivetHoleClosingSystemBtnClosingObject();
        helpers.ClickOnSplintToAddRivetHole2Closing();
        helpers.ClickTickBtnClosingObject();
        helpers.ClickOnPlacedRivetHoleClosingObject();
        helpers.ClickOnDiameterRivetHoleClosingObject();
        helpers.MoveSliderDiameterRivetHoleClosingObject();
        helpers.ClickOnDiameterRivetHoleClosingObject();
        helpers.ClickOnSecondPlacedRivetHoleClosingObject();
        helpers.ClickSelectAllRivetHoleClosingObject();
        helpers.ClickOnDiameterRivetHoleClosingObject();
        helpers.MoveSliderDiameterRivetHoleClosingObject();
        helpers.ClickShowMenuClosingSystemBtnClosingObject();
        helpers.ClickMushroomPinClosingSystemBtnClosingObject();
        helpers.ClickBackArrowBtnClosingObject();
        helpers.ClickShowMenuClosingSystemBtnClosingObject();
        helpers.ClickMushroomPinClosingSystemBtnClosingObject();
        helpers.ClickOnSplintToAddMushroomPin1Closing();
        helpers.ClickTickBtnClosingObject();
        helpers.ClickShowMenuClosingSystemBtnClosingObject();
        helpers.ClickMushroomPinClosingSystemBtnClosingObject();
        helpers.ClickBackArrowBtnClosingObject();
        helpers.ClickShowMenuClosingSystemBtnClosingObject();
        helpers.ClickMushroomPinClosingSystemBtnClosingObject();
        helpers.ClickOnSplintToAddMushroomPin2Closing();
        helpers.ClickTickBtnClosingObject();

        /// ISSUE WHEN SELECTING THE MUSHROOM PIN - CONSIDERED AS A MESH.
       /* helpers.ClickOnPlacedMushroomPinClosingObject();
        helpers.ClickOnScaleMushroomPinClosingObject();
        helpers.MoveSliderScaleMushroomPinClosingObject();
        helpers.ClickOnSecondPlacedMushroomPinClosingObject();
        helpers.ClickSelectAllMushroomPinClosingObject();
        helpers.ClickOnScaleMushroomPinClosingObject();
        helpers.MoveSliderScaleMushroomPinClosingObject(); */ 

        helpers.ClickShowMenuClosingSystemBtnClosingObject();
        helpers.ClickFreeBeltLoopClosingSystemBtnClosingObject();
        helpers.ClickBackArrowBtnClosingObject();
        helpers.ClickShowMenuClosingSystemBtnClosingObject();
        helpers.ClickFreeBeltLoopClosingSystemBtnClosingObject();
        helpers.ClickOnSplintToAddFreeBeltloop1Closing();
        helpers.ClickTickBtnClosingObject();
        helpers.ClickShowMenuClosingSystemBtnClosingObject();
        helpers.ClickFreeBeltLoopClosingSystemBtnClosingObject();
        helpers.ClickBackArrowBtnClosingObject();
        helpers.ClickShowMenuClosingSystemBtnClosingObject();
        helpers.ClickFreeBeltLoopClosingSystemBtnClosingObject();
        helpers.ClickOnSplintToAddFreeBeltloop2Closing();
        helpers.ClickTickBtnClosingObject();
        helpers.ClickOnPlacedFreeBeltClosingObject();
        helpers.ClickOnThicknessFreeBeltClosingObject();
        helpers.MoveSliderThicknessFreeBeltClosingObject();
        helpers.ClickOnLengthFreeBeltClosingObject();
        helpers.MoveSliderLengthFreeBeltClosingObject();
        helpers.ClickOnClearanceFreeBeltClosingObject();
        helpers.MoveSliderClearanceFreeBeltClosingObject();
        helpers.ClickOnWidthFreeBeltClosingObject();
        helpers.MoveSliderWidthFreeBeltClosingObject();
        helpers.ClickSelectAllFreeBeltClosingObject();
        helpers.ClickOnThicknessFreeBeltClosingObject();
        helpers.MoveSliderThicknessFreeBeltClosingObject();
        helpers.ClickOnLengthFreeBeltClosingObject();
        helpers.MoveSliderLengthFreeBeltClosingObject();
        helpers.ClickOnClearanceFreeBeltClosingObject();
        helpers.MoveSliderClearanceFreeBeltClosingObject();
        helpers.ClickOnWidthFreeBeltClosingObject();
        helpers.MoveSliderWidthFreeBeltClosingObject();
        helpers.ClickShowMenuClosingSystemBtnClosingObject();
        helpers.ClickSlottedHoleClosingSystemBtnClosingObject();
        helpers.ClickBackArrowBtnClosingObject();
        helpers.ClickOnSplintToAddSlottedHole1Closing();
        helpers.ClickShowMenuClosingSystemBtnClosingObject();
        helpers.ClickSlottedHoleClosingSystemBtnClosingObject();
        helpers.ClickOnSplintToAddSlottedHole1Closing();
        helpers.ClickTickBtnClosingObject();
        helpers.ClickShowMenuClosingSystemBtnClosingObject();
        helpers.ClickSlottedHoleClosingSystemBtnClosingObject();
        helpers.ClickBackArrowBtnClosingObject();
        helpers.ClickShowMenuClosingSystemBtnClosingObject();
        helpers.ClickSlottedHoleClosingSystemBtnClosingObject();
        helpers.ClickOnSplintToAddSlottedHole2Closing();
        helpers.ClickTickBtnClosingObject();

        /// ISSUE WHEN SELECTING THE SLOTTED HOLE - CONSIDERED AS A MESH.
        /*helpers.ClickOnPlacedSlottedHoleClosingObject();
        helpers.ClickOnLengthSlottedHoleClosingObject();
        helpers.ClickOnLength35mmSlottedHoleClosingObject();
        helpers.ClickOnLengthSlottedHoleClosingObject();
        helpers.ClickOnLength15mmSlottedHoleClosingObject();
        helpers.ClickOnSecondPlacedSlottedHoleClosingObject();
        helpers.ClickSelectAllSlottedHoleClosingObject();
        helpers.ClickOnLengthSlottedHoleClosingObject();
        helpers.ClickOnLength35mmSlottedHoleClosingObject();
        helpers.ClickOnLengthSlottedHoleClosingObject();
        helpers.ClickOnLength15mmSlottedHoleClosingObject(); */
        
        altDriver.SetDelayAfterCommand(1);
        helpers.ClickShowMenuClosingSystemBtnClosingObject();
        helpers.ClickAddRailBeltClosingObject();
        helpers.ClickRotateScanAntiYClosingObject();

        helpers.CorrectRailBeltLoopPosition();
        helpers.ClickBelt0RailObject();
        helpers.ClickBeltLengthRailObject();
        helpers.MoveSliderBeltLengthRailObject();
        helpers.ClickBeltClearanceRailObject();
        helpers.MoveSliderBeltClearanceRailObject();
        helpers.ClickBeltWidthRailObject();
        helpers.MoveSliderBeltWidthRailObject();
        helpers.ClickBeltThicknessRailObject();
        helpers.MoveSliderBelThicknessRailObject();
        helpers.ClickBeltTrashRailObject();
        helpers.ClickRotateScanXClosingObject();
        helpers.ClickRotateScanAntiYClosingObject();
        helpers.ClickNextStepBtnClosingObject();
        helpers.ClickPreviousStepBtnClosingObject();
        helpers.ClickNextStepBtnClosingObject();
        helpers.ClickValidateBtnClosingObject();



        /*
        helpers.ClickAddRailBeltClosingObject();
        helpers.ClickBelt0RailObject();
        helpers.ClickBeltLengthRailObject();
        helpers.MoveSliderBeltLengthRailObject();
        helpers.ClickBeltClearanceRailObject();
        helpers.MoveSliderBeltClearanceRailObject();
        helpers.ClickBeltWidthRailObject();
        helpers.MoveSliderBeltWidthRailObject();
        helpers.ClickBeltThicknessRailObject();
        helpers.MoveSliderBelThicknessRailObject();
        helpers.ClickBeltTrashRailObject();
        helpers.ClickRotateScanXClosingObject();
        helpers.ClickRotateScanAntiYClosingObject();
        helpers.CorrectRailBeltLoopPosition();
        helpers.ClickNextStepBtnClosingObject();
        helpers.ClickPreviousStepBtnClosingObject();
        helpers.ClickNextStepBtnClosingObject();
        helpers.ClickValidateBtnClosingObject();*/

    }

    private void ExecuteSerialNumberEngraverLevel()
    {
        helpers.ClickSerialNumberBtnMainViewObject();
        helpers.ClickRotateScanAntiYClosingObject();
        helpers.ClickRotateScanXClosingObject();
        helpers.ClickOnSplintToAddSerialNumber();
        helpers.ClickOnSplintToAddSerialNumber();
        helpers.ClickNextStepBtnPopUpSerialNumberObject();
    }
}