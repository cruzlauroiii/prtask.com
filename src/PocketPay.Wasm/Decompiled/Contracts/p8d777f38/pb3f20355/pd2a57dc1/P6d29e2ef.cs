namespace WillowMaze.Wasm.Decompiled;

public interface P6d29e2ef
{
    bool CheckAppNeededToReview();
    pd4ccf9ff GetAnimationPreview();
    long GetBatchCloseDate();
    int GetLastUpdateVersionCode();
    bool IsNeedToRequestNotificationPermission();
    bool IsShowAppUpdate();
    bool IsShowLogoutPin();
    void OnAppLaunched();
    void OnAppReviewFinished();
    void SetAnimationPreview(pd4ccf9ff P0);
    void SetBatchCloseDate(long P0);
    void SetLastUpdateVersionCode(int P0);
    void SetNeedToRequestNotificationPermission(bool P0);
    void SetShouldRequestNotificationPermission(bool P0);
    void SetShowLogoutPin(bool P0);
    void SetShowUpdate(bool P0);
}
