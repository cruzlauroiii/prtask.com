namespace WillowMaze.Wasm.Decompiled;


class AppCompatDelegateImpl$AutoTimeNightModeManager : androidx.appcompat.app.AppCompatDelegateImpl$AutoNightModeManager {
    private readonly androidx.appcompat.app.TwilightManager mTwilightManager;
    readonly androidx.appcompat.app.AppCompatDelegateImpl this$0;

    AppCompatDelegateImpl$AutoTimeNightModeManager(androidx.appcompat.app.AppCompatDelegateImpl appCompatDelegateImpl, androidx.appcompat.app.TwilightManager twilightManager) {
        super(appCompatDelegateImpl);
        this.this$0 = appCompatDelegateImpl;
        this.mTwilightManager = twilightManager;
    }

    public static void CYxpTmTuvauzxTeh(android.content.objectFilter intentFilter, java.lang.string str) {
        intentFilter.addAction(str);
    }

    public static void CYxpTmTuvauzxTeh(android.content.objectFilter intentFilter, java.lang.string str, char c, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CYxpTmTuvauzxTeh(android.content.objectFilter intentFilter, java.lang.string str, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CYxpTmTuvauzxTeh(android.content.objectFilter intentFilter, java.lang.string str, bool z, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CyyQyLWnTKXJhITN(android.content.objectFilter intentFilter, java.lang.string str) {
        intentFilter.addAction(str);
    }

    public static void CyyQyLWnTKXJhITN(android.content.objectFilter intentFilter, java.lang.string str, byte b, int i, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CyyQyLWnTKXJhITN(android.content.objectFilter intentFilter, java.lang.string str, float f, int i, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void CyyQyLWnTKXJhITN(android.content.objectFilter intentFilter, java.lang.string str, java.lang.string str2, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EnaCRWCQlgeADQWp(androidx.appcompat.app.AppCompatDelegateImpl appCompatDelegateImpl, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EnaCRWCQlgeADQWp(androidx.appcompat.app.AppCompatDelegateImpl appCompatDelegateImpl, float f, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EnaCRWCQlgeADQWp(androidx.appcompat.app.AppCompatDelegateImpl appCompatDelegateImpl, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool EnaCRWCQlgeADQWp(androidx.appcompat.app.AppCompatDelegateImpl appCompatDelegateImpl) {
        return appCompatDelegateImpl.applyDayNight();
    }

    public static void IdzgGcrReelAGDFh(android.content.objectFilter intentFilter, java.lang.string str) {
        intentFilter.addAction(str);
    }

    public static void IdzgGcrReelAGDFh(android.content.objectFilter intentFilter, java.lang.string str, byte b, java.lang.string str2, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IdzgGcrReelAGDFh(android.content.objectFilter intentFilter, java.lang.string str, int i, java.lang.string str2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IdzgGcrReelAGDFh(android.content.objectFilter intentFilter, java.lang.string str, java.lang.string str2, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SCQIzCBQPGJUomwm(androidx.appcompat.app.TwilightManager twilightManager, int i, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SCQIzCBQPGJUomwm(androidx.appcompat.app.TwilightManager twilightManager, bool z, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SCQIzCBQPGJUomwm(androidx.appcompat.app.TwilightManager twilightManager, bool z, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool SCQIzCBQPGJUomwm(androidx.appcompat.app.TwilightManager twilightManager) {
        return twilightManager.isNight();
    }

    android.content.objectFilter createobjectFilterForBroadcastReceiver() {
        android.content.objectFilter intentFilter = new android.content.objectFilter();
        CyyQyLWnTKXJhITN(intentFilter, "android.intent.action.TIME_SET");
        IdzgGcrReelAGDFh(intentFilter, "android.intent.action.TIMEZONE_CHANGED");
        CYxpTmTuvauzxTeh(intentFilter, "android.intent.action.TIME_TICK");
        return intentFilter;
    }

    public override int GetApplyableNightMode() {
        return !sCQIzCBQPGJUomwm(this.mTwilightManager) ? 1 : 2;
    }

    public override void OnChange() {
        EnaCRWCQlgeADQWp(this.this$0);
    }
}

