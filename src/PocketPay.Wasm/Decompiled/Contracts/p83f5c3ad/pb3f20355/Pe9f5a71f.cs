namespace WillowMaze.Wasm.Decompiled;

public interface Pe9f5a71f
{
    void ClearTapOnPhoneInfo();
    pe6acf149 GetQrBanner();
    bool GetTapOnPhoneIsQrEnabled();
    string GetTapOnPhoneMid();
    string GetTapOnPhoneQrMid();
    string GetTapOnPhoneQrName();
    string GetTapOnPhoneQrTid();
    string GetTapOnPhoneTid();
    void HideQrBanner();
    void SetTapOnPhoneIsQrEnabled(bool P0);
    void SetTapOnPhoneMid(string P0);
    void SetTapOnPhoneQrMid(string P0);
    void SetTapOnPhoneQrName(string P0);
    void SetTapOnPhoneQrTid(string P0);
    void SetTapOnPhoneTid(string P0);
    void ShowQrBanner();
    object UpdateTapOnPhoneInfo(object P0);
    object UpdateTapOnPhoneQrInfo(object P0);
}
