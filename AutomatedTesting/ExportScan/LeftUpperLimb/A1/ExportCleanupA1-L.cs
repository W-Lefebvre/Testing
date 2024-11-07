using System;
using System.IO;
using System.Threading;
using AltTester.AltTesterUnitySDK.Driver;
using NUnit.Framework;

public partial class ExportCleanupA1L
{
    private AltDriver altDriver;
    private ExportCleanupHelpersA1L helpers; // Use an instance of helpers to access methods.
    private string signalFilePath = "/Users/williamlefebvre/Desktop/TestResume/signal_file.txt"; // Spécifiez ici le chemin du fichier signal

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        altDriver = new AltDriver(host: ConnexionConfig.Host, port: ConnexionConfig.Port, appName: ConnexionConfig.AppName);
        helpers = new ExportCleanupHelpersA1L(altDriver); // Initialize with the driver.
    }

    [OneTimeTearDown]
    public void TearDown()
    {
        altDriver.Stop();
    }

    [Test]
    public void ExportCleanupScanA1()
    {
        ExecuteCleanupLevelAndExportScan();
    }

    private void ExecuteCleanupLevelAndExportScan()
    {
        helpers.ClickCleanupBtnMainViewObject();
        Console.WriteLine("Human verification required: please validate the quality of the 3D model.");
        altDriver.SetDelayAfterCommand(0.12f);
        
        // Action before the pause
        helpers.ClickSelectPartOfInterestArmLeftA1();

        // Pause for human verification, waiting for modification of signal file
        WaitForSignalFileModification();

        // Continue with the test after confirmation
        helpers.ClickNextStepBtnObject();
        helpers.ClickOnAxisAntiZSculptObject();
        helpers.ClickOnAxisXSculptObject();
        SetCleanupLandmarks();
        helpers.CuttingPlanePositionObject();
        helpers.ClickNextStepBtnObject();
        helpers.ClickValidateBtnObject();
        helpers.ClickSaveAndContinueBtnObject();
        helpers.ClickOnExportBtnObject();
    }

    private void SetCleanupLandmarks()
    {
        helpers.ClickWristCreaseCenterCleanupLandmark();
        helpers.ClickTickBtnObject();
        helpers.ClickVentralArmCleanupLandmark();
        helpers.ClickTickBtnObject();
    }

    private void WaitForSignalFileModification()
    {
        Console.WriteLine("Waiting for modification of signal file...");

        // Check if the file exist
        if (!File.Exists(signalFilePath))
        {
            Console.WriteLine("Signal file does not exist. Creating a new one...");
            File.WriteAllText(signalFilePath, "Initial content"); // Crée le fichier s'il n'existe pas déjà
        }

        // Enregistre l'heure de la dernière modification du fichier
        DateTime lastModified = File.GetLastWriteTime(signalFilePath);

        // Boucle d'attente jusqu'à ce que le fichier soit modifié
        while (File.GetLastWriteTime(signalFilePath) == lastModified)
        {
            // Petite pause pour éviter d'utiliser trop de ressources
            Thread.Sleep(500);
        }

        Console.WriteLine("Signal file modified. Resuming test...");
    }
}
