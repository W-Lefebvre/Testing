using System;
using AltTester.AltTesterUnitySDK.Driver;
using NUnit.Framework;
using System.Threading;

public partial class GridBehaviourCheck
{
    private AltDriver altDriver;

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        altDriver = new AltDriver(host: ConnexionConfig.Host, port: ConnexionConfig.Port, appName: ConnexionConfig.AppName);
    }

    [OneTimeTearDown]
    public void TearDown()
    {
        altDriver.Stop();
    }

    [Test]
    public void CheckGridBehaviour()
    {
        CheckGridBehaviourByDefault();
    }
    #region Buttons, Screen coordinates & Actions

        public void Click(float x, float y)
        {
            altDriver.BeginTouch(new AltVector2(x, y));
            altDriver.EndTouch(1);
        }

        public void Move(float startX, float startY, float endX, float endY)
        {
            altDriver.BeginTouch(new AltVector2(startX, startY));
            altDriver.MoveTouch(1, new AltVector2(endX, endY));
            altDriver.EndTouch(1);
        }

        public void BeingProcessed()
        {

            altDriver.WaitForObjectNotBePresent(By.PATH, "/Canvas/Loading Panel"); // Wait until the loading panel object "Your request is being processed, please wait" disappears
        }

        public void PerformRepeatedClicks(Action clickAction, int repetitions)
        {
            for (int i = 0; i < repetitions; i++)
            {
                clickAction();
            }
        }


      public void ClickFitBtnMainViewObject()
        {
            var ClickFitBtnMainViewObject = altDriver.WaitForObject(By.PATH, "/Canvas/MainMenu(Clone)/MainMenuBtn(Clone)");
            ClickFitBtnMainViewObject.Tap();
        }

        public void ClickQuitBtnFitObject()
        {
            var ClickQuitBtnFitObject = altDriver.WaitForObject(By.PATH, "/Fit/LMRunPlacementStep(Clone)/LMRunPlacementStepPanel/Canvas/SubStepPrevButton/Forma Button v3 Tools/Icon");
            ClickQuitBtnFitObject.Tap();
        }

        public void ClickCancelBtnPopUpFitObject()
        {
            var ClickCancelBtnPopUpFitObject = altDriver.WaitForObject(By.PATH, "/Canvas/WarnPopup(Clone)/Forma Info Panel v3/Content/Bottom Container/Back btn");
            ClickCancelBtnPopUpFitObject.Tap();
        }

        public void ClickConfirmBtnPopUpObject()
        {
            var ClickConfirmBtnPopUpObject = altDriver.WaitForObject(By.PATH, "/Canvas/WarnPopup(Clone)/Forma Info Panel v3/Content/Bottom Container/Do it btn");
            ClickConfirmBtnPopUpObject.Tap();
        }

        public void ClickTickBtnFitObject()
        {
            var ClickTickBtnFitObject = altDriver.WaitForObject(By.PATH, "/Fit/LMRunPlacementStep(Clone)/LMRunPlacementStepPanel/Canvas/SubStepNextButton/Forma Button v3 Tools");
            ClickTickBtnFitObject.Tap();
        }

        public void ClickBackArrowBtnFitObject()
        {
            var ClickBackArrowBtnFitObject = altDriver.WaitForObject(By.PATH, "/Fit/LMRunPlacementStep(Clone)/LMRunPlacementStepPanel/Canvas/SubStepPrevButton/Forma Button v3 Tools/Icon");
            ClickBackArrowBtnFitObject.Tap();
        }

        public void ClickPreviousStepBtnFitObject()
        {
            var ClickPreviousStepBtnFitObject = altDriver.WaitForObject(By.PATH, "/Fit/LevelNavigationPanel(Clone)/Canvas/NavPrev Step/Forma Button v3 Contextual");
            ClickPreviousStepBtnFitObject.Tap();
        }

        public void ClickResetPopUpBtnFitObject()
        {
            var ClickResetPopUpBtnFitObject = altDriver.WaitForObject(By.PATH, "/Canvas/Popup(Clone)/Content/Bottom Container/Cancel button");
            ClickResetPopUpBtnFitObject.Tap();
        }

        public void ClickLenghtBtnFitObject()
        {
            var ClickLenghtBtnFitObject = altDriver.WaitForObject(By.PATH, "/Fit/FitEditorStep(Clone)/FitEditorPanel/Canvas/NonGenerativePatternPan/LevelBottomMenu/Lines/Line2/ShiftLengthSlider/ButtonAndSlidingPanel/Button");
            ClickLenghtBtnFitObject.Tap();
        }

        public void ClickNextStepBtnFitObject()
        {
            var ClickNextStepBtnFitObject = altDriver.WaitForObject(By.PATH, "/Fit/LevelNavigationPanel(Clone)/Canvas/NavNext Step/Forma Button v3 Contextual");
            ClickNextStepBtnFitObject.Tap();
        }

        public void ClickValidateBtnFitObject()
        {
            var ClickValidateBtnFitObject = altDriver.WaitForObject(By.PATH, "/Fit/LevelNavigationPanel(Clone)/Canvas/NavNext Step/Forma Button v3 Contextual");
            ClickValidateBtnFitObject.Tap();
        }
#endregion

    private void CheckGridBehaviourByDefault()
    {
         altDriver.SetDelayAfterCommand(0.50f);
         ClickFitBtnMainViewObject();
         CheckIfButtonIsEnabled();
    }

        private void CheckIfButtonIsEnabled()
    {
        // Attendre que l'objet de la grille soit présent et désactivé
        var gridObject = altDriver.WaitForObject(By.PATH, "/Canvas/Top right icons/Toggle Grid Button /Icon", enabled: false);

        // Vérification que l'objet est bien trouvé et désactivé
        Assert.IsNotNull(gridObject, "La grille est activée par défaut, ce qui n'est pas le comportement attendu."); 
    }




}