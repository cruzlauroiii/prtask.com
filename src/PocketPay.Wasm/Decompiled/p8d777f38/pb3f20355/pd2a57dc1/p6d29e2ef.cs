namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00002\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\t\n\u0002\b\u0005\n\u0002\u0010\u000b\n\u0002\b\u0004\n\u0002\u0010\u0002\n\u0002\b\u000b\bf\u0018\u00002\u00020\u0001J\b\u0010\u0019\u001a\u00020\u001aH&J\b\u0010\u001b\u001a\u00020\u0015H&J\b\u0010\u001c\u001a\u00020\u001aH&J\b\u0010\u001d\u001a\u00020\u0015H&J\u0010\u0010\u001e\u001a\u00020\u001a2\u0006\u0010\u001f\u001a\u00020\u0015H&J\b\u0010 \u001a\u00020\u0015H&J\u0010\u0010!\u001a\u00020\u001a2\u0006\u0010\"\u001a\u00020\u0015H&J\u0010\u0010#\u001a\u00020\u001a2\u0006\u0010$\u001a\u00020\u0015H&R\u0018\u0010\u0002\u001a\u00020\u0003X¦\u000e¢\u0006\f\u001a\u0004\b\u0004\u0010\u0005\"\u0004\b\u0006\u0010\u0007R\u0018\u0010\b\u001a\u00020\tX¦\u000e¢\u0006\f\u001a\u0004\b\n\u0010\u000b\"\u0004\b\f\u0010\rR\u0018\u0010\u000e\u001a\u00020\u000fX¦\u000e¢\u0006\f\u001a\u0004\b\u0010\u0010\u0011\"\u0004\b\u0012\u0010\u0013R\u0018\u0010\u0014\u001a\u00020\u0015X¦\u000e¢\u0006\f\u001a\u0004\b\u0014\u0010\u0016\"\u0004\b\u0017\u0010\u0018¨\u0006%"}, d2 = {"Lp8d777f38/pb3f20355/pd2a57dc1/p6d29e2ef;", "", "lastUpdateVersionCode", "", "getLastUpdateVersionCode", "()I", "setLastUpdateVersionCode", "(I)V", "animationPreview", "Lpad5f82e8/p07214c67/pd4ccf9ff;", "getAnimationPreview", "()Lpad5f82e8/p07214c67/pd4ccf9ff;", "setAnimationPreview", "(Lpad5f82e8/p07214c67/pd4ccf9ff;)V", "batchCloseDateTime", "", "getBatchCloseDateTime", "()J", "setBatchCloseDateTime", "(J)V", "isNeedToRequestNotificationPermission", "", "()Z", "setNeedToRequestNotificationPermission", "(Z)V", "onAppLaunched", "", "checkAppNeededToReview", "onAppReviewFinished", "isShowAppUpdate", "setShowUpdate", "isShowUpdate", "isShowConsoleoutPin", "setShowConsoleoutPin", "isShowPin", "setShouldRequestNotificationPermission", "shouldRequest", "common-data-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface p6d29e2ef {
    bool checkAppNeededToReview();

    pad5f82e8.p07214c67.pd4ccf9ff getAnimationPreview();

    long getBatchCloseDateTime();

    int getLastUpdateVersionCode();

    bool isNeedToRequestNotificationPermission();

    bool isShowAppUpdate();

    bool isShowConsoleoutPin();

    void onAppLaunched();

    void onAppReviewFinished();

    void setAnimationPreview(pad5f82e8.p07214c67.pd4ccf9ff pd4ccf9ffVar);

    void setBatchCloseDateTime(long j);

    void setLastUpdateVersionCode(int i);

    void setNeedToRequestNotificationPermission(bool z);

    void setShouldRequestNotificationPermission(bool shouldRequest);

    void setShowConsoleoutPin(bool isShowPin);

    void setShowUpdate(bool isShowUpdate);
}

