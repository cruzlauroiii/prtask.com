namespace WillowMaze.Wasm.Decompiled;

public interface Pc60ad0d1
{
    bool CheckPaymentPriorityBoardingIsShown();
    object GetActualPaymentSettingsInfo(object P0);
    object GetComboDevicePaymentSettings(object P0);
    object GetComboPaybackReceiptPaymentSettings(List<object> P0, object P1);
    object GetDefaultPaymentSettings(object P0);
    object GetDevicePaymentSettings(object P0);
    object GetIfNotExistPaymentSettings(List<object> P0, object P1);
    object GetPaybackDevicePaymentSettings(p18cf5223 P0, object P1);
    object GetRemoteDevicesPaymentSettingsMap(object P0);
    object GetSelectedMainDevicePaymentSettings(object P0);
    p69a322d5 GetTapOnPhoneInfo();
    p04decbae GetTapOnPhoneQrInfo();
    object SetActualPaymentPrioritySettings(List<object> P0, object P1);
}
