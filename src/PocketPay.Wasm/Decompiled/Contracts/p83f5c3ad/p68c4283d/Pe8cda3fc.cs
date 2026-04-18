namespace WillowMaze.Wasm.Decompiled;

public interface Pe8cda3fc
{
    void ReportAuthErrorEvent();
    void ReportAuthSuccessEvent();
    void ReportAuthorizationErrorCancelEvent();
    void ReportAuthorizationErrorSupportEvent();
    void ReportAutoLoginErrorEvent(string P0, string P1);
    void ReportAutoLoginSuccessEvent(string P0, string P1);
    void ReportDeviceIsBlockedCancelEvent();
    void ReportDeviceIsBlockedSupportEvent();
    void ReportOpenTophEvent(string P0);
    void ReportPaymentPaybackErrorEvent();
    void ReportPaymentPaybackSuccessEvent();
    void ReportPaymentSellErrorEvent();
    void ReportPaymentSellSuccessEvent();
    void ReportRequestEvent();
    void ReportVirtualDeviceAutoLoginErrorEvent(string P0);
    void ReportVirtualDeviceAutoLoginSuccessEvent(string P0);
    void ReportstartScreen();
}
