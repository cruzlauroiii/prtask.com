namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0007\n\u0002\u0010\u000e\n\u0002\b\r\bf\u0018\u00002\u00020\u0001J\b\u0010\u0002\u001a\u00020\u0003H&J\b\u0010\u0004\u001a\u00020\u0003H&J\b\u0010\u0005\u001a\u00020\u0003H&J\b\u0010\u0006\u001a\u00020\u0003H&J\b\u0010\u0007\u001a\u00020\u0003H&J\b\u0010\b\u001a\u00020\u0003H&J\u0010\u0010\t\u001a\u00020\u00032\u0006\u0010\n\u001a\u00020\u000bH&J\u0018\u0010\f\u001a\u00020\u00032\u0006\u0010\r\u001a\u00020\u000b2\u0006\u0010\u000e\u001a\u00020\u000bH&J\u0018\u0010\u000f\u001a\u00020\u00032\u0006\u0010\r\u001a\u00020\u000b2\u0006\u0010\u000e\u001a\u00020\u000bH&J\u0010\u0010\u0010\u001a\u00020\u00032\u0006\u0010\u000e\u001a\u00020\u000bH&J\u0010\u0010\u0011\u001a\u00020\u00032\u0006\u0010\u000e\u001a\u00020\u000bH&J\b\u0010\u0012\u001a\u00020\u0003H&J\b\u0010\u0013\u001a\u00020\u0003H&J\b\u0010\u0014\u001a\u00020\u0003H&J\b\u0010\u0015\u001a\u00020\u0003H&J\b\u0010\u0016\u001a\u00020\u0003H&J\b\u0010\u0017\u001a\u00020\u0003H&¨\u0006\u0018"}, d2 = {"Lp83f5c3ad/p68c4283d/pe8cda3fc;", "", "reportstartScreen", "", "reportRequestEvent", "reportDeviceIsBlockedSupportEvent", "reportDeviceIsBlockedCancelEvent", "reportAuthorizationErrorSupportEvent", "reportAuthorizationErrorCancelEvent", "reportOpenTophEvent", "startTapOnPhoneRoute", "", "reportAutoConsoleinSuccessEvent", "employeeId", "deviceId", "reportAutoConsoleinErrorEvent", "reportVirtualDeviceAutoConsoleinSuccessEvent", "reportVirtualDeviceAutoConsoleinErrorEvent", "reportAuthSuccessEvent", "reportAuthErrorEvent", "reportPaymentSellSuccessEvent", "reportPaymentSellErrorEvent", "reportPaymentPaybackSuccessEvent", "reportPaymentPaybackErrorEvent", "feature-toph-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface pe8cda3fc {
    void reportAuthErrorEvent();

    void reportAuthSuccessEvent();

    void reportAuthorizationErrorCancelEvent();

    void reportAuthorizationErrorSupportEvent();

    void reportAutoConsoleinErrorEvent(java.lang.string employeeId, java.lang.string deviceId);

    void reportAutoConsoleinSuccessEvent(java.lang.string employeeId, java.lang.string deviceId);

    void reportDeviceIsBlockedCancelEvent();

    void reportDeviceIsBlockedSupportEvent();

    void reportOpenTophEvent(java.lang.string startTapOnPhoneRoute);

    void reportPaymentPaybackErrorEvent();

    void reportPaymentPaybackSuccessEvent();

    void reportPaymentSellErrorEvent();

    void reportPaymentSellSuccessEvent();

    void reportRequestEvent();

    void reportVirtualDeviceAutoConsoleinErrorEvent(java.lang.string deviceId);

    void reportVirtualDeviceAutoConsoleinSuccessEvent(java.lang.string deviceId);

    void reportstartScreen();
}

