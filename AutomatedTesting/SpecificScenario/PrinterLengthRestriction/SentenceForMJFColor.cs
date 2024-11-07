using System;
using AltTester.AltTesterUnitySDK.Driver;
using NUnit.Framework;
using System.Threading;

public partial class LengthRestrictionColor
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

    public void DrawOnTheScan2()
    {
            altDriver.MoveMouse(new AltVector2(359.7016f, 721.834f), 1);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1496.255f, 725.6755f), 4);
            altDriver.KeyUp(AltKeyCode.Mouse0);
    }

    public void ClickPreviousStepBtnObject()
    {
            var ClickPreviousStepBtnObject = altDriver.WaitForObject(By.PATH, "/Draw/LevelNavigationPanel(Clone)/Canvas/NavPrev Step");
            ClickPreviousStepBtnObject.Tap();
    }

    public void ClickNextStepBtnObject()
    {
            var ClickNextStepBtnObject = altDriver.WaitForObject(By.PATH, "/Draw/LevelNavigationPanel(Clone)/Canvas/NavNext Step/Forma Button v3 Contextual");
            ClickNextStepBtnObject.Tap();
    }

    public void ClickQuitBtnObject()
    {
            var ClickQuitBtnObject = altDriver.WaitForObject(By.PATH, "/Draw/LevelNavigationPanel(Clone)/Canvas/NavNext Step/Forma Button v3 Contextual");
            ClickQuitBtnObject.Tap();
    }

    public void ClickConfirmExitLevelPopUpbject()
    {
            var ClickConfirmExitLevelPopUpbject = altDriver.WaitForObject(By.NAME, "Do it btn");
            ClickConfirmExitLevelPopUpbject.Tap();
    }

    public void ClickOkValidationPopUpbject()
    {
            var ClickOkValidationPopUpbject = altDriver.WaitForObject(By.PATH, "/Canvas/ValidationCheckPopup(Clone)/Content/Bottom Container/Confirm button");
            ClickOkValidationPopUpbject.Tap();
    }


public void VerifyCorrectValidationMessageForBlack()
{
    var validationMessageObject = altDriver.WaitForObject(By.NAME, "MaxSplintLengthExceededWarning");
    Assert.IsTrue(validationMessageObject.enabled, "The object is not visible or enabled.");
    string actualText = validationMessageObject.GetText();
    string expectedText = "Length exceeds maximum length for MJF black (34 cm). Please reduce length or model will not be able to be printed.";
    Assert.AreEqual(expectedText, actualText, $"The validation message is incorrect. Expected: {expectedText}, but got: {actualText}");
}

public void VerifyCorrectValidationMessageForColor()
{
    var validationMessageObject = altDriver.WaitForObject(By.NAME, "MaxSplintLengthExceededWarning");
    Assert.IsTrue(validationMessageObject.enabled, "The object is not visible or enabled.");
    string actualText = validationMessageObject.GetText();
    string expectedText = "Length exceeds maximum length for MJF color (30 cm). Please reduce length or model will be printed in black.";
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
        VerifyCorrectValidationMessageForBlack();
        ClickPreviousStepBtnObject();
        ClickPreviousStepBtnObject();
        ClickPreviousStepBtnObject();
        ClickPreviousStepBtnObject();
        ClickConfirmExitLevelPopUpbject();
        ClickOnDrawLevelBtn();
        ClickOnScanToActivateDrawing();
        DrawOnTheScan2();
        ClickNextStepBtnObject();
        ClickNextStepBtnObject();
        ClickNextStepBtnObject();
        ClickOkValidationPopUpbject();
        VerifyCorrectValidationMessageForColor();



    }
}