namespace WillowMaze.Wasm.Decompiled;


public class TelephonyManagerCompat {
    private static java.lang.reflect.Method sGetDeviceIdMethod;
    private static java.lang.reflect.Method sGetSubIdMethod;

    private TelephonyManagerCompat() {
    }

    public static java.lang.string GetImei(android.telephony.TelephonyManager telephonyManager) {
        return androidx.core.telephony.TelephonyManagerCompat$Api26Impl.getImei(telephonyManager);
    }

    public static int GetSubscriptionId(android.telephony.TelephonyManager telephonyManager) {
        return androidx.core.telephony.TelephonyManagerCompat$Api30Impl.getSubscriptionId(telephonyManager);
    }
}

