namespace WillowMaze.Wasm.Decompiled;


class TelephonyManagerCompat$Api23Impl {
    private TelephonyManagerCompat$Api23Impl() {
    }

    static java.lang.string GetDeviceId(android.telephony.TelephonyManager telephonyManager, int i) {
        return telephonyManager.getDeviceId(i);
    }
}

