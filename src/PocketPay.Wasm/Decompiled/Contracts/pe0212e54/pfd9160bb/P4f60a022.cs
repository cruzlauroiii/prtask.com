namespace WillowMaze.Wasm.Decompiled;

public interface P4f60a022
{
    void Back();
    void BackToRootScreen();
    void Finish();
    string GetHasDeviceInStorageErrorKey();
    string GetOrderDeviceTypeKey();
    void OpenShops(p37893195 P0);
    void ReplaceShops(p37893195 P0);
    void SendResult(string P0, object P1);
    void SendResult(string P0, p6c2f9b8a P1);
    void SetResultListener(string P0, p449a7995 P1);
    void StartShopsFlow(p37893195 P0);
}
