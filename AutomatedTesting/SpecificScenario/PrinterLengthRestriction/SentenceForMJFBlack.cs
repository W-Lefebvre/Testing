using System;
using AltTester.AltTesterUnitySDK.Driver;
using NUnit.Framework;
using System.Threading;

public partial class LengthRestriction
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
    public void CheckPrinterLengthRestriction()
    {
        CheckPrinterRestriction();
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
            altDriver.BeginTouch(new AltVector2(365.413f,792.9009f));
            altDriver.MoveTouch(1,new AltVector2(466.313f,790.9802f));
            altDriver.EndTouch(1);
    }

    public void DrawOnTheScan()
    {
            altDriver.MoveMouse(new AltVector2(365.413f, 739.1206f), 1);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1779.917f, 744.8828f), 4);
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


public void VerifyCorrectValidationMessage()
{
    // Attendre que l'objet soit visible
    var validationMessageObject = altDriver.WaitForObject(By.NAME, "MaxSplintLengthExceededWarning");

    // Vérifier que l'objet est activé dans la hiérarchie
    Assert.IsTrue(validationMessageObject.enabled, "The object is not visible or enabled.");

    // Récupérer le texte de l'objet
    string actualText = validationMessageObject.GetText();

    // Chaîne de texte attendue
    string expectedText = "Length exceeds maximum length for MJF black (34 cm). Please reduce length or model will not be able to be printed.";

    // Utilisation d'une assertion pour comparer les textes
    Assert.AreEqual(expectedText, actualText, $"The validation message is incorrect. Expected: {expectedText}, but got: {actualText}");
}




    private void CheckPrinterRestriction()
    {
        ClickOnDrawLevelBtn();
        ClickOnScanToActivateDrawing();
        DrawOnTheScan();
        ClickNextStepBtnObject();
        ClickNextStepBtnObject();
        ClickNextStepBtnObject();
        ClickOkValidationPopUpbject();
        VerifyCorrectValidationMessage();
    }
}