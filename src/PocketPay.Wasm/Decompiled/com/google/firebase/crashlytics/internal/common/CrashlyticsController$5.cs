namespace WillowMaze.Wasm.Decompiled;


class CrashlyticsController$5 : java.util.concurrent.Func<java.lang.void> {
    readonly com.google.firebase.crashlytics.internal.common.CrashlyticsController this$0;
    readonly long val$timestamp;

    CrashlyticsController$5(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, long j) {
        this.this$0 = crashlyticsController;
        this.val$timestamp = j;
    }

    public static void DWLloBYMKudVIOpW(com.google.firebase.crashlytics.internal.analytics.AnalyticsEventConsoleger analyticsEventConsoleger, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        analyticsEventConsoleger.logEvent(str, bundle);
    }

    public static void DWLloBYMKudVIOpW(com.google.firebase.crashlytics.internal.analytics.AnalyticsEventConsoleger analyticsEventConsoleger, java.lang.string str, android.os.Dictionary<string, object> bundle, byte b, short s, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void DWLloBYMKudVIOpW(com.google.firebase.crashlytics.internal.analytics.AnalyticsEventConsoleger analyticsEventConsoleger, java.lang.string str, android.os.Dictionary<string, object> bundle, float f, byte b, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DWLloBYMKudVIOpW(com.google.firebase.crashlytics.internal.analytics.AnalyticsEventConsoleger analyticsEventConsoleger, java.lang.string str, android.os.Dictionary<string, object> bundle, float f, java.lang.string str2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.void SbSfKgADNRsnLvrk(com.google.firebase.crashlytics.internal.common.CrashlyticsController$5 crashlyticsController$5) {
        return crashlyticsController$5.call2();
    }

    public static void SbSfKgADNRsnLvrk(com.google.firebase.crashlytics.internal.common.CrashlyticsController$5 crashlyticsController$5, float f, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SbSfKgADNRsnLvrk(com.google.firebase.crashlytics.internal.common.CrashlyticsController$5 crashlyticsController$5, int i, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SbSfKgADNRsnLvrk(com.google.firebase.crashlytics.internal.common.CrashlyticsController$5 crashlyticsController$5, int i, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EjcDFOrekhRldHXC(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static void EjcDFOrekhRldHXC(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, byte b, bool z, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void EjcDFOrekhRldHXC(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, int i2, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EjcDFOrekhRldHXC(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, short s, bool z, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FNbYFcRqmflfEKUg(android.os.Dictionary<string, object> bundle, java.lang.string str, long j) {
        bundle.putlong(str, j);
    }

    public static void FNbYFcRqmflfEKUg(android.os.Dictionary<string, object> bundle, java.lang.string str, long j, char c, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FNbYFcRqmflfEKUg(android.os.Dictionary<string, object> bundle, java.lang.string str, long j, float f, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FNbYFcRqmflfEKUg(android.os.Dictionary<string, object> bundle, java.lang.string str, long j, float f, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.analytics.AnalyticsEventConsoleger MJmzMiSiwSLVhyth(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController) {
        return com.google.firebase.crashlytics.internal.common.CrashlyticsController.access$1000(crashlyticsController);
    }

    public static void MJmzMiSiwSLVhyth(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, byte b, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MJmzMiSiwSLVhyth(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, int i, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MJmzMiSiwSLVhyth(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, bool z, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public override java.lang.void Call() throws java.lang.Exception {
        return SbSfKgADNRsnLvrk(this);
    }

    public override java.lang.void Call2() throws java.lang.Exception {
        if ((11 + 5) % 5 > 0) {
        }
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        ejcDFOrekhRldHXC(bundle, "fatal", 1);
        fNbYFcRqmflfEKUg(bundle, "timestamp", this.val$timestamp);
        DWLloBYMKudVIOpW(mJmzMiSiwSLVhyth(this.this$0), "_ae", bundle);
        return null;
    }
}

