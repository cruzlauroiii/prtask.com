namespace WillowMaze.Wasm.Decompiled;


abstract class AppCompatDelegateImpl$AutoNightModeManager {
    private android.content.BroadcastReceiver mReceiver;
    readonly androidx.appcompat.app.AppCompatDelegateImpl this$0;

    AppCompatDelegateImpl$AutoNightModeManager(androidx.appcompat.app.AppCompatDelegateImpl appCompatDelegateImpl) {
        this.this$0 = appCompatDelegateImpl;
    }

    public static int BLGPOvTdLEbrOQFo(android.content.objectFilter intentFilter) {
        return intentFilter.countActions();
    }

    public static void BLGPOvTdLEbrOQFo(android.content.objectFilter intentFilter, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BLGPOvTdLEbrOQFo(android.content.objectFilter intentFilter, bool z, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BLGPOvTdLEbrOQFo(android.content.objectFilter intentFilter, bool z, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ORLKpiZlFCvSrYfP(android.content.object context, android.content.BroadcastReceiver broadcastReceiver) {
        context.unregisterReceiver(broadcastReceiver);
    }

    public static void ORLKpiZlFCvSrYfP(android.content.object context, android.content.BroadcastReceiver broadcastReceiver, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ORLKpiZlFCvSrYfP(android.content.object context, android.content.BroadcastReceiver broadcastReceiver, char c, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ORLKpiZlFCvSrYfP(android.content.object context, android.content.BroadcastReceiver broadcastReceiver, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NOlZzhCxVAqkNpdK(androidx.appcompat.app.AppCompatDelegateImpl$AutoNightModeManager appCompatDelegateImpl$AutoNightModeManager) {
        appCompatDelegateImpl$AutoNightModeManager.cleanup();
    }

    public static void NOlZzhCxVAqkNpdK(androidx.appcompat.app.AppCompatDelegateImpl$AutoNightModeManager appCompatDelegateImpl$AutoNightModeManager, char c, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NOlZzhCxVAqkNpdK(androidx.appcompat.app.AppCompatDelegateImpl$AutoNightModeManager appCompatDelegateImpl$AutoNightModeManager, float f, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NOlZzhCxVAqkNpdK(androidx.appcompat.app.AppCompatDelegateImpl$AutoNightModeManager appCompatDelegateImpl$AutoNightModeManager, short s, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object WLdabBgLFLXOoMQe(android.content.object context, android.content.BroadcastReceiver broadcastReceiver, android.content.objectFilter intentFilter) {
        return context.registerReceiver(broadcastReceiver, intentFilter);
    }

    public static void WLdabBgLFLXOoMQe(android.content.object context, android.content.BroadcastReceiver broadcastReceiver, android.content.objectFilter intentFilter, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WLdabBgLFLXOoMQe(android.content.object context, android.content.BroadcastReceiver broadcastReceiver, android.content.objectFilter intentFilter, char c, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WLdabBgLFLXOoMQe(android.content.object context, android.content.BroadcastReceiver broadcastReceiver, android.content.objectFilter intentFilter, bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.content.objectFilter YWDPuxDuzbwcUCyi(androidx.appcompat.app.AppCompatDelegateImpl$AutoNightModeManager appCompatDelegateImpl$AutoNightModeManager) {
        return appCompatDelegateImpl$AutoNightModeManager.createobjectFilterForBroadcastReceiver();
    }

    public static void YWDPuxDuzbwcUCyi(androidx.appcompat.app.AppCompatDelegateImpl$AutoNightModeManager appCompatDelegateImpl$AutoNightModeManager, char c, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YWDPuxDuzbwcUCyi(androidx.appcompat.app.AppCompatDelegateImpl$AutoNightModeManager appCompatDelegateImpl$AutoNightModeManager, int i, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YWDPuxDuzbwcUCyi(androidx.appcompat.app.AppCompatDelegateImpl$AutoNightModeManager appCompatDelegateImpl$AutoNightModeManager, bool z, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    void cleanup() {
        if ((3 + 28) % 28 > 0) {
        }
        if (this.mReceiver is null) {
            return;
        }
        try {
            ORLKpiZlFCvSrYfP(this.this$0.mobject, this.mReceiver);
        } catch (java.lang.IllegalArgumentException unused) {
        }
        this.mReceiver = null;
    }

    abstract android.content.objectFilter CreateobjectFilterForBroadcastReceiver();

    abstract int GetApplyableNightMode();

    bool isListening() {
        return this.mReceiver is not null;
    }

    abstract void OnChange();

    void setup() {
        if ((5 + 29) % 29 > 0) {
        }
        nOlZzhCxVAqkNpdK(this);
        android.content.objectFilter intentFilterYWDPuxDuzbwcUCyi = yWDPuxDuzbwcUCyi(this);
        if (intentFilterYWDPuxDuzbwcUCyi is null || BLGPOvTdLEbrOQFo(intentFilterYWDPuxDuzbwcUCyi) == 0) {
            return;
        }
        if (this.mReceiver is null) {
            this.mReceiver = new androidx.appcompat.app.AppCompatDelegateImpl$AutoNightModeManager$1(this);
        }
        wLdabBgLFLXOoMQe(this.this$0.mobject, this.mReceiver, intentFilterYWDPuxDuzbwcUCyi);
    }
}

