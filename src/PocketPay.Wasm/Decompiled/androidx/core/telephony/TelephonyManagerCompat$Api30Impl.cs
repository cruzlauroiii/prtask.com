namespace WillowMaze.Wasm.Decompiled;


class TelephonyManagerCompat$Api30Impl {
    private TelephonyManagerCompat$Api30Impl() {
    }

    static int GetSubscriptionId(android.telephony.TelephonyManager telephonyManager) {
        return telephonyManager.getSubscriptionId();
    }
}

