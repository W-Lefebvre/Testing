using System;
using AltTester.AltTesterUnitySDK.Driver;
using NUnit.Framework;
using System.Threading;

public partial class ExportCleanupA2L
{
    public class ExportCleanupHelpersA2L
    {
        private AltDriver altDriver;

        public ExportCleanupHelpersA2L(AltDriver driver)
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
        public void ClickSelectPartOfInterestArmLeftA2() => Click(986.0432f, 911.9858f);
        public void ClickWristCreaseCenterCleanupLandmark() => Click(970.813f, 904.3029f);
        public void ClickVentralArmCleanupLandmark() => Click(1256.379f, 888.9371f);
        public void ClickThumbInterPhalangealLandmark() => Click(1105.981f, 1034.912f);
        public void ClickThumbMetaPhalangealLandmark() => Click(1062.194f, 863.9677f);
        public void ClickFirstInterdigitalLandmark() => Click(1178.324f, 963.8453f);

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

         // THUMB LEVEL OBJECT //

        public void ClickThumbBtnMainViewObject()
        {
            var ClickThumbBtnMainViewObject = altDriver.WaitForObject(By.PATH, "/Canvas/MainMenu(Clone)/MainMenuBtn(Clone)[2]");
            ClickThumbBtnMainViewObject.Tap();
        }

        public void ClickCrossBtnThumbObject()
        {
            var ClickCrossBtnThumbObject = altDriver.WaitForObject(By.PATH, "/ThumbCTL/LMRunPlacementStep/LMRunPlacementStepPanel/Canvas/SubStepPrevButton/Forma Button v3 Tools");
            ClickCrossBtnThumbObject.Tap();
        }

        public void ClickTickBtnThumbObject()
        {
            var ClickTickBtnThumbObject = altDriver.WaitForObject(By.PATH, "/ThumbCTL/LMRunPlacementStep/LMRunPlacementStepPanel/Canvas/SubStepNextButton/Forma Button v3 Tools/Icon");
            ClickTickBtnThumbObject.Tap();
        }

        public void ClickBackArrowBtnThumbObject()
        {
            var ClickBackArrowBtnThumbObject = altDriver.WaitForObject(By.PATH, "/ThumbCTL/LMRunPlacementStep/LMRunPlacementStepPanel/Canvas/SubStepPrevButton/Forma Button v3 Tools");
            ClickBackArrowBtnThumbObject.Tap();
        }

        public void ClickPreviousStepBtnThumbObject()
        {
            var ClickPreviousStepBtnThumbObject = altDriver.WaitForObject(By.PATH, "/Canvas/Navigation Buttons Panel/NavPrev Step/Forma Button v3 Contextual");
            ClickPreviousStepBtnThumbObject.Tap();
        }

        public void ClickEditBtnThumbObject()
        {
            var ClickEditBtnThumbObject = altDriver.WaitForObject(By.PATH, "/Canvas/ThumbEditorPanel(Clone)/DisplayCircSliderSwitch/Background/Switch button/icon left");
            ClickEditBtnThumbObject.Tap();
        }

        public void ClickCircumferenceBtnThumbObject()
        {
            var ClickCircumferenceBtnThumbObject = altDriver.WaitForObject(By.PATH, "/Canvas/ThumbEditorPanel(Clone)/ExtensibleCircumferenceSlider/ButtonAndSlidingPanel/Button");
            ClickCircumferenceBtnThumbObject.Tap();
        }

        public void MoveSliderCircToMinThumbObject()
        {
            var MoveSliderCircToMinThumbObject = altDriver.WaitForObject(By.PATH, "/Canvas/ThumbEditorPanel(Clone)/ExtensibleCircumferenceSlider/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area");
            var startPosition = MoveSliderCircToMinThumbObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(1092.88f, 324.5237f), 0.12f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1092.88f, 193.672f), 0.25f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void MoveSliderCircToMaxThumbObject()
        {
            var MoveSliderCircToMaxThumbObject = altDriver.WaitForObject(By.PATH, "/Canvas/ThumbEditorPanel(Clone)/ExtensibleCircumferenceSlider/ButtonAndSlidingPanel/Sliding Panel /Mask/Content/Slider/Handle Slide Area");
            var startPosition = MoveSliderCircToMaxThumbObject.GetScreenPosition();
            altDriver.MoveMouse(new AltVector2(1096.478f, 215.4806f), 0.12f);
            altDriver.KeyDown(AltKeyCode.Mouse0, 1);
            altDriver.MoveMouse(new AltVector2(1092.88f, 466.2798f), 0.25f);
            altDriver.KeyUp(AltKeyCode.Mouse0);
        }

        public void ClickResetSliderBtnThumbObject()
        {
            var ClickResetSliderBtnThumbObject = altDriver.WaitForObject(By.PATH, "/Canvas/ThumbEditorPanel(Clone)/ResetButton");
            ClickResetSliderBtnThumbObject.Tap();
        }

        public void ClickValidateBtnThumbObject()
        {
            var ClickValidateBtnThumbObject = altDriver.WaitForObject(By.PATH, "/Canvas/Navigation Buttons Panel/NavNext Step/Forma Button v3 Contextual");
            ClickValidateBtnThumbObject.Tap();
        }    

    }   
}