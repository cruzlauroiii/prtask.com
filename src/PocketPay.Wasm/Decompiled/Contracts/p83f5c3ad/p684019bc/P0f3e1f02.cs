namespace WillowMaze.Wasm.Decompiled;

public interface P0f3e1f02
{
    void ClearTapOnPhoneInfo();
    pe6acf149 GetQrBanner();
    string GetTapOnPhoneMid();
    string GetTapOnPhoneTid();
    void HideQrBanner();
    bool IsQrEnabled();
    object SetQrEnabled(bool P0, object P1);
    object UpdateTapOnPhoneInfo(object P0);
    object UpdateTapOnPhoneQrInfo(object P0);
}
