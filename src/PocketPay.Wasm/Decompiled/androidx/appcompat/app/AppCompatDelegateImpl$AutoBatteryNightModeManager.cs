namespace WillowMaze.Wasm.Decompiled;


class AppCompatDelegateImpl$AutoBatteryNightModeManager : androidx.appcompat.app.AppCompatDelegateImpl$AutoNightModeManager {
    private readonly android.os.PowerManager mPowerManager;
    readonly androidx.appcompat.app.AppCompatDelegateImpl this$0;

    AppCompatDelegateImpl$AutoBatteryNightModeManager(androidx.appcompat.app.AppCompatDelegateImpl appCompatDelegateImpl, android.content.object context) {
        super(appCompatDelegateImpl);
        this.this$0 = appCompatDelegateImpl;
        this.mPowerManager = (android.os.PowerManager) HeutoshYZPmzDdGk(mRytzORDcvlsBnYr(context), "power");
    }

    public static java.lang.object HeutoshYZPmzDdGk(android.content.object context, java.lang.string str) {
        return context.getSystemService(str);
    }

    public static void HeutoshYZPmzDdGk(android.content.object context, java.lang.string str, byte b, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HeutoshYZPmzDdGk(android.content.object context, java.lang.string str, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HeutoshYZPmzDdGk(android.content.object context, java.lang.string str, bool z, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OkChTmMqJCEcCkft(android.os.PowerManager powerManager, char c, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OkChTmMqJCEcCkft(android.os.PowerManager powerManager, java.lang.string str, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OkChTmMqJCEcCkft(android.os.PowerManager powerManager, java.lang.string str, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool OkChTmMqJCEcCkft(android.os.PowerManager powerManager) {
        return androidx.appcompat.app.AppCompatDelegateImpl$Api21Impl.isPowerSaveMode(powerManager);
    }

    public static void RejUjQWtipLJBjEE(androidx.appcompat.app.AppCompatDelegateImpl appCompatDelegateImpl, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RejUjQWtipLJBjEE(androidx.appcompat.app.AppCompatDelegateImpl appCompatDelegateImpl, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RejUjQWtipLJBjEE(androidx.appcompat.app.AppCompatDelegateImpl appCompatDelegateImpl, bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool RejUjQWtipLJBjEE(androidx.appcompat.app.AppCompatDelegateImpl appCompatDelegateImpl) {
        return appCompatDelegateImpl.applyDayNight();
    }

    public static void KGqemaqzAhRNHrss(android.content.objectFilter intentFilter, java.lang.string str) {
        intentFilter.addAction(str);
    }

    public static void KGqemaqzAhRNHrss(android.content.objectFilter intentFilter, java.lang.string str, char c, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KGqemaqzAhRNHrss(android.content.objectFilter intentFilter, java.lang.string str, float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KGqemaqzAhRNHrss(android.content.objectFilter intentFilter, java.lang.string str, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object MRytzORDcvlsBnYr(android.content.object context) {
        return context.getApplicationobject();
    }

    public static void MRytzORDcvlsBnYr(android.content.object context, int i, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MRytzORDcvlsBnYr(android.content.object context, int i, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MRytzORDcvlsBnYr(android.content.object context, int i, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    android.content.objectFilter createobjectFilterForBroadcastReceiver() {
        android.content.objectFilter intentFilter = new android.content.objectFilter();
        kGqemaqzAhRNHrss(intentFilter, "android.os.action.POWER_SAVE_MODE_CHANGED");
        return intentFilter;
    }

    public override int GetApplyableNightMode() {
        return !OkChTmMqJCEcCkft(this.mPowerManager) ? 1 : 2;
    }

    public override void OnChange() {
        RejUjQWtipLJBjEE(this.this$0);
    }
}

