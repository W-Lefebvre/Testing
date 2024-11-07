using System;
using AltTester.AltTesterUnitySDK.Driver;
using NUnit.Framework;
using System.Threading;

public partial class ExportCleanupA2L
{
    private AltDriver altDriver;
    private ExportCleanupHelpersA2L helpers; // Utiliser une instance des helpers pour accéder aux méthodes.

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        altDriver = new AltDriver(host: ConnexionConfig.Host, port: ConnexionConfig.Port, appName: ConnexionConfig.AppName);
        helpers = new ExportCleanupHelpersA2L(altDriver); // Initialisation avec le driver.
    }

    [OneTimeTearDown]
    public void TearDown()
    {
        altDriver.Stop();
    }

    [Test]
    public void ExportCleanupScanA2()
    {
        ExecuteCleanupLevel();
        ExecuteThumbLevel();
    }

    private void ExecuteCleanupLevel()
    {
        helpers.ClickCleanupBtnMainViewObject();
        altDriver.SetDelayAfterCommand(0.12f);
        helpers.ClickSelectPartOfInterestArmLeftA2(); // Cannot use object here, use coordinate.
        helpers.ClickNextStepBtnObject();
        helpers.ClickOnAxisAntiZSculptObject();
        helpers.ClickOnAxisXSculptObject();
        SetCleanupLandmarks();
        helpers.CuttingPlanePositionObject();
        helpers.ClickNextStepBtnObject();
        helpers.ClickValidateBtnObject(); // Once the level has been fully completed one time, repeat all previous steps.
    }


    private void SetCleanupLandmarks()
    {
        helpers.ClickWristCreaseCenterCleanupLandmark();
        helpers.ClickTickBtnObject();
        helpers.ClickVentralArmCleanupLandmark();
        helpers.ClickTickBtnObject();

    }

        private void ExecuteThumbLevel()
    {
        helpers.ClickThumbBtnMainViewObject();
        altDriver.SetDelayAfterCommand(0.12f);
        SetThumbLandmarks();
        helpers.ClickValidateBtnThumbObject();
        helpers.ClickSaveAndContinueBtnObject();
        helpers.ClickOnExportBtnObject();
    }


    private void SetThumbLandmarks()
    {
        helpers.ClickThumbInterPhalangealLandmark();
        helpers.ClickTickBtnThumbObject();
        helpers.ClickThumbMetaPhalangealLandmark();
        helpers.ClickTickBtnThumbObject();
        helpers.ClickFirstInterdigitalLandmark();
        helpers.ClickTickBtnThumbObject();
    }
}