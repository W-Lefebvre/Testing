using System;
using AltTester.AltTesterUnitySDK.Driver;
using NUnit.Framework;
using System.Threading;

public partial class FullAutoFormaW1R
{
    private AltDriver altDriver;
    private AutoFormaHelpersW1R helpers; // Utiliser une instance des helpers pour accéder aux méthodes.

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        altDriver = new AltDriver(host: ConnexionConfig.Host, port: ConnexionConfig.Port, appName: ConnexionConfig.AppName);
        helpers = new AutoFormaHelpersW1R(altDriver); // Initialisation avec le driver.
    }

    [OneTimeTearDown]
    public void TearDown()
    {
        altDriver.Stop();
    }

    [Test]
    public void FullAutoFormaW1RWorkflow()
    {
        ExecuteFitLevel();
        ExecuteClosingSystemLevel();
        ExecuteSerialNumberEngraverLevel();

    }

    private void ExecuteFitLevel()
    {
        altDriver.SetDelayAfterCommand(0.15f);
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
        helpers.ClickLenghtBtnFitObject();
        helpers.MoveSliderLengthFitObject();
        Thread.Sleep(500);
        helpers.MoveSliderLengthTo100FitObject();
        helpers.ClickBoundaryWidthBtnFitObject();
        helpers.MoveSliderBoundaryWidthFitObject();
        helpers.ClickPatternRegionSelectorFitObject();
        helpers.MoveSliderWidthFitObject();
        helpers.MoveSliderDensityFitObject();
        helpers.ClickPatternPannelCloseBtnFitObject();
        helpers.ClickPatternsOnOffSwitchBtnFitObject();
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
        helpers.ClickPreviousStepBtnFitObject();
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
        altDriver.SetDelayAfterCommand(0.15f);
        helpers.ClickClosingSystemsBtnMainViewObject();
        helpers.ClickQuitBtnClosingObject();
        helpers.ClickCancelExitLevelBtnRailObject();
        helpers.ClickQuitBtnClosingObject();
        helpers.ClickConfirmExitLevelBtnRailObject();
        helpers.ClickClosingSystemsBtnMainViewObject();
        helpers.ClickOnAxisAntiZObject();
        helpers.ClickOnAxisXObject();
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

       /*helpers.ClickShowMenuClosingSystemBtnClosingObject();
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
        helpers.ClickOnPlacedMushroomPinClosingObject();
        helpers.ClickOnScaleMushroomPinClosingObject();
        helpers.MoveSliderScaleMushroomPinClosingObject();
        helpers.ClickOnSecondPlacedMushroomPinClosingObject();
        helpers.ClickSelectAllMushroomPinClosingObject();
        helpers.ClickOnScaleMushroomPinClosingObject();
        helpers.MoveSliderScaleMushroomPinClosingObject();  

*/
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
        helpers.ClickOnPlacedSlottedHoleClosingObject();
        helpers.ClickOnLengthSlottedHoleClosingObject();
        helpers.ClickOnLength35mmSlottedHoleClosingObject();
        helpers.ClickOnLengthSlottedHoleClosingObject();
        helpers.ClickOnLength15mmSlottedHoleClosingObject();
        helpers.ClickOnSecondPlacedSlottedHoleClosingObject();
        helpers.ClickSelectAllSlottedHoleClosingObject();
        helpers.ClickOnLengthSlottedHoleClosingObject();
        helpers.ClickOnLength35mmSlottedHoleClosingObject();
        helpers.ClickOnLengthSlottedHoleClosingObject();
        helpers.ClickOnLength15mmSlottedHoleClosingObject(); 
        helpers.ClickShowMenuClosingSystemBtnClosingObject();
        helpers.ClickAddRailBeltClosingObject();
        helpers.ClickRotateScanAntiYClosingObject();
        helpers.ClickBelt0RailObject();
        helpers.CorrectRailBeltLoopPosition();
        helpers.MoveSliderBeltLengthRailObject();
        helpers.MoveSliderBeltLengthBackToDefaultRailObject();
        helpers.ClickBeltClearanceRailObject();
        helpers.MoveSliderBeltClearanceRailObject();
        helpers.ClickBeltWidthRailObject();
        helpers.MoveSliderBeltWidthRailObject();
        helpers.ClickBeltThicknessRailObject();
        helpers.MoveSliderBelThicknessRailObject();
        helpers.ClickNextStepBtnClosingObject();
        helpers.ClickPreviousStepBtnClosingObject();
        helpers.ClickNextStepBtnClosingObject();
        helpers.ClickValidateBtnClosingObject(); 

    }

    private void ExecuteSerialNumberEngraverLevel()
    {
        helpers.ClickSerialNumberBtnMainViewObject();
        helpers.ClickOnSplintToAddSerialNumber();
        helpers.ClickOnSplintToAddSerialNumber();
        helpers.ClickNextStepBtnSerialNumberObject();
        helpers.ClickValidateBtnSerialNumberObject();
    }
}