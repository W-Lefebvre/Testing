using System;
using AltTester.AltTesterUnitySDK.Driver;
using NUnit.Framework;
using System.Threading;

public partial class ExportCleanupA1L
{
    public class ExportCleanupHelpersA1L
    {
        private AltDriver altDriver;

        public ExportCleanupHelpersA1L(AltDriver driver)
        {
            altDriver = driver;
        }

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

        // SCREEN COORDINATES METHOD //
        public void ClickSelectPartOfInterestArmLeftA1() => Click(889.8749f, 918.0978f);
        public void ClickWristCreaseCenterCleanupLandmark() => Click(970.813f, 904.3029f);
        public void ClickVentralArmCleanupLandmark() => Click(1256.379f, 888.9371f);

        public void ClickOnAxisAntiZSculptObject()
        {
            var ClickOnAxisAntiZSculptObject = altDriver.WaitForObject(By.PATH, "/Canvas/Compass3D/AntiZBar/AntiZ");
            ClickOnAxisAntiZSculptObject.Tap();
        }

        public void ClickOnAxisXSculptObject()
        {
            var ClickOnAxisXSculptObject = altDriver.WaitForObject(By.PATH, "/Canvas/Compass3D/XBar/X/XLabel");
            ClickOnAxisXSculptObject.Tap();
        }

        // CLEANUP LEVEL OBJECT // 

        public void ClickCleanupBtnMainViewObject()
        {
            var ClickCleanupBtnMainView = altDriver.WaitForObject(By.PATH, "/Canvas/MainMenu(Clone)/MainMenuBtn(Clone)/Text");
            ClickCleanupBtnMainView.Tap();
        }

        public void ClickQuitBtnObject()
        {
            var ClickQuitBtn = altDriver.WaitForObject(By.PATH, "/Cleanup/LevelNavigationPanel(Clone)/Canvas/NavPrev Step/Forma Button v3 Contextual/Text");
            ClickQuitBtn.Tap();
        }

        public void ClickConfirmBtnPopUpObject()
        {
            var ClickConfirmBtnPopUpObject = altDriver.WaitForObject(By.PATH, "/Canvas/WarnPopup(Clone)/Forma Info Panel v3/Content/Bottom Container/Do it btn/Text");
            ClickConfirmBtnPopUpObject.Tap();
        }

        public void ClickNextStepBtnObject()
        {
            var ClickNextStepBtnObject = altDriver.WaitForObject(By.PATH, "/Cleanup/LevelNavigationPanel(Clone)/Canvas/NavNext Step/Forma Button v3 Contextual");
            ClickNextStepBtnObject.Tap();
        }

        public void ClickPreviousStepBtnObject()
        {
            var ClickPreviousStepBtnObject = altDriver.WaitForObject(By.PATH, "/Cleanup/LevelNavigationPanel(Clone)/Canvas/NavPrev Step/Forma Button v3 Contextual");
            ClickPreviousStepBtnObject.Tap();
        }

        public void ClickCrossBtnObject()
        {
            var ClickCrossBtnObject = altDriver.WaitForObject(By.PATH, "/Cleanup/LMRunPlacementStep(Clone)/LMRunPlacementStepPanel/Canvas/SubStepPrevButton/Forma Button v3 Tools");
            ClickCrossBtnObject.Tap();
        }

        public void ClickTickBtnObject()
        {
            var ClickTickBtnObject = altDriver.WaitForObject(By.PATH, "/Cleanup/LMRunPlacementStep(Clone)/LMRunPlacementStepPanel/Canvas/SubStepNextButton/Forma Button v3 Tools");
            ClickTickBtnObject.Tap();
        }

        public void ClickBackArrowBtnObject()
        {
            var ClickBackArrowBtnObject = altDriver.WaitForObject(By.PATH, "/Cleanup/LMRunPlacementStep(Clone)/LMRunPlacementStepPanel/Canvas/SubStepPrevButton/Forma Button v3 Tools");
            ClickBackArrowBtnObject.Tap();
        }

        public void ClickValidateBtnObject()
        {
            var ClickValidateBtnObject = altDriver.WaitForObject(By.PATH, "/Cleanup/LevelNavigationPanel(Clone)/Canvas/NavNext Step/Forma Button v3 Contextual");
            ClickValidateBtnObject.Tap();
        }

        public void CuttingPlanePositionObject()
        {
            var Plane1 = altDriver.WaitForObject(By.PATH, "/Cleanup/CropScanStep(Clone)/MeshCropperTool/Plane1");
            var startPosition = Plane1.GetScreenPosition();
            Move(1102.173f, 719.9133f, 620.5186f, 756.4071f);
        }

        public void ClickSaveAndContinueBtnObject()
        {
            var ClickSaveAndContinueBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/Export Btn/Text");
            ClickSaveAndContinueBtnObject.Tap();
        }

        public void ClickOnExportBtnObject()
        {
            var ClickOnExportBtnObject = altDriver.WaitForObject(By.PATH, "/Canvas/ExportPopup(Clone)/Content/Bottom Container/Confirm button");
            ClickOnExportBtnObject.Tap();
        }

    }   
}