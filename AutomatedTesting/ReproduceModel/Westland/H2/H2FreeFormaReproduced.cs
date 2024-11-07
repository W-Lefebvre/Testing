using System;
using AltTester.AltTesterUnitySDK.Driver;
using NUnit.Framework;
using System.Threading;

public partial class ModelToReproduceWestlandTest
{
    private AltDriver altDriver;
    //private ExportCleanupHelpersA1L helpers; // Utiliser une instance des helpers pour accéder aux méthodes.

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        altDriver = new AltDriver(host: ConnexionConfig.Host, port: ConnexionConfig.Port, appName: ConnexionConfig.AppName);
        //helpers = new ExportCleanupHelpersA1L(altDriver); // Initialisation avec le driver.
    }

    [OneTimeTearDown]
    public void TearDown()
    {
        altDriver.Stop();
    }

    [Test]
    public void ModelToReproduceTest()
    {
        ReproduceModel();
    }

    public void Move(float startX, float startY, float endX, float endY)
    {
        altDriver.BeginTouch(new AltVector2(startX, startY));
        altDriver.MoveTouch(1, new AltVector2(endX, endY));
        altDriver.EndTouch(1);
    }

    public void ClickOnDrawLevelBtn()
    {
       var ClickOnDrawLevelBtn = altDriver.WaitForObject(By.PATH, "/Canvas/MainMenu(Clone)/MainMenuBtn(Clone)/Text");
       ClickOnDrawLevelBtn.Tap(); 
    }

    public void ClickOnScanToActivateDrawing()
    {
            altDriver.BeginTouch(new AltVector2(382.5469f,673.816f));
            altDriver.MoveTouch(1,new AltVector2(824.655f,739.1206f));
            altDriver.EndTouch(1);
    }

    public void DrawOnTheScan()
    {

// Début du trajet : premier mouvement de la souris
altDriver.MoveMouse(new AltVector2(365.413f, 739.1206f), 1f);

// Appuyer sur le bouton gauche de la souris pour signaler un clic
altDriver.KeyDown(AltKeyCode.Mouse0, 1);

// Mouvement vers un point intermédiaire (ajoutez autant de points intermédiaires que nécessaire)
altDriver.MoveMouse(new AltVector2(800.500f, 742.000f), 1f);  // Point intermédiaire
altDriver.KeyDown(AltKeyCode.Space, 1);
altDriver.KeyUp(AltKeyCode.Space);

// Autre mouvement vers un autre point intermédiaire
altDriver.MoveMouse(new AltVector2(1200.250f, 743.500f), 1f); // Autre point intermédiaire
altDriver.KeyDown(AltKeyCode.Space, 1);
altDriver.KeyUp(AltKeyCode.Space);

// Mouvement final vers la destination
altDriver.MoveMouse(new AltVector2(1779.917f, 744.8828f), 4f);

// Relâcher le bouton gauche de la souris à la fin du trajet
altDriver.KeyUp(AltKeyCode.Mouse0);




    }

    public void ClickNextStepBtnObject()
    {
            var ClickNextStepBtnObject = altDriver.WaitForObject(By.PATH, "/Draw/LevelNavigationPanel(Clone)/Canvas/NavNext Step/Forma Button v3 Contextual");
            ClickNextStepBtnObject.Tap();
    }

    public void ClickOkValidationPopUpbject()
    {
            var ClickOkValidationPopUpbject = altDriver.WaitForObject(By.PATH, "/Canvas/ValidationCheckPopup(Clone)/Content/Bottom Container/Confirm button");
            ClickOkValidationPopUpbject.Tap();
    }



    private void ReproduceModel()
    {
        ClickOnDrawLevelBtn();
        altDriver.SetDelayAfterCommand(0.5f);
        ClickOnScanToActivateDrawing();
        DrawOnTheScan();
        //ClickOnScanToActivateDrawing();


    }
} 