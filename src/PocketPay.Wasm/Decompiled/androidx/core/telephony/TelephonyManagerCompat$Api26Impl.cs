namespace WillowMaze.Wasm.Decompiled;


class TelephonyManagerCompat$Api26Impl {
    private TelephonyManagerCompat$Api26Impl() {
    }

    static java.lang.string GetImei(android.telephony.TelephonyManager telephonyManager) {
        return telephonyManager.getImei();
    }
}

