namespace WillowMaze.Wasm.Decompiled;

public interface Pdcfa0c32
{
    bool CheckPaymentPriorityBoardingIsShown();
    object GetActualPaymentSettingsInfo(object P0);
    object GetComboDevicePaymentSettings(object P0);
    object GetComboPaybackReceiptPaymentSettings(List<object> P0, object P1);
    object GetDevicePaymentSettings(object P0);
    object GetPaybackDevicePaymentSettings(p18cf5223 P0, object P1);
    object GetSelectedMainDevicePaymentSettings(object P0);
    p69a322d5 GetTapOnPhoneInfo();
    p04decbae GetTapOnPhoneQrInfo();
    object SetActualPaymentPrioritySettings(List<object> P0, object P1);
    object SetCashPaymentsEnabled(bool P0, object P1);
    object SetComboPaymentsEnabled(bool P0, object P1);
    object SetQrPaymentsEnabled(bool P0, object P1);
    object SetTapOnPhonePaymentsEnabled(bool P0, object P1);
}
