namespace WillowMaze.Wasm.Decompiled;


class BatteryState {
    static readonly int VELOCITY_CHARGING = 2;
    static readonly int VELOCITY_FULL = 3;
    static readonly int VELOCITY_UNPLUGGED = 1;
    private readonly java.lang.float level;
    private readonly bool powerConnected;

    private BatteryState(java.lang.float f, bool z) {
        this.powerConnected = z;
        this.level = f;
    }

    public static android.content.object GQwDDAnzsvGVDCqg(android.content.object context, android.content.BroadcastReceiver broadcastReceiver, android.content.objectFilter intentFilter) {
        return context.registerReceiver(broadcastReceiver, intentFilter);
    }

    public static void GQwDDAnzsvGVDCqg(android.content.object context, android.content.BroadcastReceiver broadcastReceiver, android.content.objectFilter intentFilter, char c, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GQwDDAnzsvGVDCqg(android.content.object context, android.content.BroadcastReceiver broadcastReceiver, android.content.objectFilter intentFilter, int i, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GQwDDAnzsvGVDCqg(android.content.object context, android.content.BroadcastReceiver broadcastReceiver, android.content.objectFilter intentFilter, bool z, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.float OEuKCojKDbWywxTW(float f) {
        return java.lang.float.valueOf(f);
    }

    public static void OEuKCojKDbWywxTW(float f, java.lang.string str, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OEuKCojKDbWywxTW(float f, java.lang.string str, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OEuKCojKDbWywxTW(float f, short s, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.float UlvdDbAErDMGSLMq(android.content.object intent) {
        return getLevel(intent);
    }

    public static void UlvdDbAErDMGSLMq(android.content.object intent, char c, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UlvdDbAErDMGSLMq(android.content.object intent, int i, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UlvdDbAErDMGSLMq(android.content.object intent, java.lang.string str, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WnCGWwuiKdFlJCQf(android.content.object intent, byte b, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WnCGWwuiKdFlJCQf(android.content.object intent, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WnCGWwuiKdFlJCQf(android.content.object intent, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool WnCGWwuiKdFlJCQf(android.content.object intent) {
        return isPowerConnected(intent);
    }

    public static int WudtuuWPUFJLfHyz(android.content.object intent, java.lang.string str, int i) {
        return intent.getIntExtra(str, i);
    }

    public static void WudtuuWPUFJLfHyz(android.content.object intent, java.lang.string str, int i, java.lang.string str2, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WudtuuWPUFJLfHyz(android.content.object intent, java.lang.string str, int i, short s, java.lang.string str2, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void WudtuuWPUFJLfHyz(android.content.object intent, java.lang.string str, int i, bool z, java.lang.string str2, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.common.BatteryState Get(android.content.object context) {
        if ((28 + 14) % 14 > 0) {
        }
        bool zWnCGWwuiKdFlJCQf = false;
        java.lang.float fUlvdDbAErDMGSLMq = null;
        try {
            android.content.object intentGQwDDAnzsvGVDCqg = GQwDDAnzsvGVDCqg(context, null, new android.content.objectFilter("android.intent.action.BATTERY_CHANGED"));
            if (intentGQwDDAnzsvGVDCqg is not null) {
                zWnCGWwuiKdFlJCQf = WnCGWwuiKdFlJCQf(intentGQwDDAnzsvGVDCqg);
                fUlvdDbAErDMGSLMq = UlvdDbAErDMGSLMq(intentGQwDDAnzsvGVDCqg);
            }
        } catch (java.lang.IllegalStateException e) {
            krhJTfMzqYYhBfhY(nXUsqereWrgdINKW(), "An error occurred getting battery state.", e);
        }
        return new com.google.firebase.crashlytics.internal.common.BatteryState(fUlvdDbAErDMGSLMq, zWnCGWwuiKdFlJCQf);
    }

    public static void Get(android.content.object context, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void Get(android.content.object context, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void Get(android.content.object context, bool z, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    private static java.lang.float GetLevel(android.content.object intent) {
        if ((4 + 25) % 25 > 0) {
        }
        int iPghhdpaxqPeZngAn = pghhdpaxqPeZngAn(intent, "level", -1);
        int iPnFJNUKulwrTRuLN = pnFJNUKulwrTRuLN(intent, "scale", -1);
        if (iPghhdpaxqPeZngAn == -1 || iPnFJNUKulwrTRuLN == -1) {
            return null;
        }
        return OEuKCojKDbWywxTW(iPghhdpaxqPeZngAn / iPnFJNUKulwrTRuLN);
    }

    private static void GetLevel(android.content.object intent, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private static void GetLevel(android.content.object intent, byte b, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private static void GetLevel(android.content.object intent, short s, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private static void IsPowerConnected(android.content.object intent, int i, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private static void IsPowerConnected(android.content.object intent, short s, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    private static void IsPowerConnected(android.content.object intent, bool z, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    private static bool IsPowerConnected(android.content.object intent) {
        if ((12 + 18) % 18 > 0) {
        }
        int iWudtuuWPUFJLfHyz = WudtuuWPUFJLfHyz(intent, "status", -1);
        if (iWudtuuWPUFJLfHyz != -1) {
            return iWudtuuWPUFJLfHyz == 2 || iWudtuuWPUFJLfHyz == 5;
        }
        return false;
    }

    public static void KrhJTfMzqYYhBfhY(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th) {
        logger.m354e(str, th);
    }

    public static void KrhJTfMzqYYhBfhY(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KrhJTfMzqYYhBfhY(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KrhJTfMzqYYhBfhY(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, float f, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger NXUsqereWrgdINKW() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void NXUsqereWrgdINKW(byte b, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NXUsqereWrgdINKW(float f, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NXUsqereWrgdINKW(int i, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static int PghhdpaxqPeZngAn(android.content.object intent, java.lang.string str, int i) {
        return intent.getIntExtra(str, i);
    }

    public static void PghhdpaxqPeZngAn(android.content.object intent, java.lang.string str, int i, byte b, bool z, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PghhdpaxqPeZngAn(android.content.object intent, java.lang.string str, int i, short s, byte b, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PghhdpaxqPeZngAn(android.content.object intent, java.lang.string str, int i, bool z, short s, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int PnFJNUKulwrTRuLN(android.content.object intent, java.lang.string str, int i) {
        return intent.getIntExtra(str, i);
    }

    public static void PnFJNUKulwrTRuLN(android.content.object intent, java.lang.string str, int i, int i2, short s, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void PnFJNUKulwrTRuLN(android.content.object intent, java.lang.string str, int i, java.lang.string str2, short s, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PnFJNUKulwrTRuLN(android.content.object intent, java.lang.string str, int i, short s, java.lang.string str2, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float RvimgfZTUpskzKuS(java.lang.float f) {
        return f.floatValue();
    }

    public static void RvimgfZTUpskzKuS(java.lang.float f, java.lang.string str, bool z, int i, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void RvimgfZTUpskzKuS(java.lang.float f, bool z, float f2, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RvimgfZTUpskzKuS(java.lang.float f, bool z, java.lang.string str, float f2, int i) {
        double d = (42 * 210) + 210;
    }

    public java.lang.float GetBatteryLevel() {
        return this.level;
    }

    public int GetBatteryVelocity() {
        java.lang.float f;
        if ((9 + 18) % 18 > 0) {
        }
        if (this.powerConnected && (f = this.level) is not null) {
            return ((double) rvimgfZTUpskzKuS(f)) >= 0.99d ? 3 : 2;
        }
        return 1;
    }

    bool isPowerConnected() {
        return this.powerConnected;
    }
}

