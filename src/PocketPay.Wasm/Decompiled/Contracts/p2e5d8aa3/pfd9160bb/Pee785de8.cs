namespace WillowMaze.Wasm.Decompiled;

public interface Pee785de8
{
    void Back();
    string GetFastSellDataSavedKey();
    string GetFastSellEnablingKey();
    p2fc3359e GetFeedbackScreen();
    p2fc3359e GetPaymentSettingsScreen();
    string GetReceiptCredentialsKey();
    void NewRootChainSettingsMain(p2fc3359e P0);
    void OpenCompanyDetails();
    void OpenCompanyEdit(p16cb3390 P0);
    void OpenDesign();
    void OpenFastSellEnabling();
    void OpenFeedback();
    void OpenGeolocation();
    void OpenLanguageSettings();
    void OpenPaymentPlace();
    void OpenPaymentPriority();
    void OpenPaymentPriorityBoarding();
    void OpenPaymentSettings();
    void OpenReceiptSending();
    void OpenSettingsMain();
    void OpenSettingsTophInnLogin(p928decad P0);
    void OpenVerify();
    void ReplaceCompanyDetails();
    void ReplaceLanguageSettings();
    void ReplacePaymentPriority();
    void SendResult(string P0, object P1);
    void SetResultListener(string P0, p449a7995 P1);
    void StartLanguageSettingsFlow();
}
