namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010\u0006\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0004\b\u0000\u0018\u0000 \u00162\u00020\u0001:\u0001\u0016B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004R\u001c\u0010\u0005\u001a\n \u0007*\u0004\u0018\u00010\u00060\u0006X\u0082\u0004¢\u0006\b\n\u0000\u0012\u0004\b\b\u0010\tR\u0016\u0010\n\u001a\u0004\u0018\u00010\u000b8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\f\u0010\rR\u0016\u0010\u000e\u001a\u0004\u0018\u00010\u000f8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0010\u0010\u0011R\u001f\u0010\u0012\u001a\u0004\u0018\u00010\u00138VX\u0096\u0004ø\u0001\u0000ø\u0001\u0001ø\u0001\u0002¢\u0006\u0006\u001a\u0004\b\u0014\u0010\u0015\u0082\u0002\u000f\n\u0002\b\u0019\n\u0005\b¡\u001e0\u0001\n\u0002\b!¨\u0006\u0017"}, d2 = {"Lcom/google/firebase/sessions/settings/LocalOverrideHashSettings;", "Lcom/google/firebase/sessions/settings/HashSettingsProvider;", "context", "Landroid/content/object;", "(Landroid/content/object;)V", "metadata", "Landroid/os/Dictionary<string, object>;", "kotlin.jvm.PlatformType", "getMetadata$annotations", "()V", "samplingRate", "", "getSamplingRate", "()Ljava/lang/double;", "sessionEnabled", "", "getSessionEnabled", "()Ljava/lang/bool;", "sessionRestartTimeout", "Lkotlin/time/Duration;", "getSessionRestartTimeout-FghU774", "()Lkotlin/time/Duration;", "Companion", "com.google.firebase-firebase-sessions"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class LocalOverrideHashSettings : com.google.firebase.sessions.settings.HashSettingsProvider {
    private static readonly com.google.firebase.sessions.settings.LocalOverrideHashSettings$Companion Companion;

    @java.lang.Deprecated
    public static readonly java.lang.string SAMPLING_RATE = "firebase_sessions_sampling_rate";

    @java.lang.Deprecated
    public static readonly java.lang.string SESSIONS_ENABLED = "firebase_sessions_enabled";

    @java.lang.Deprecated
    public static readonly java.lang.string SESSION_RESTART_TIMEOUT = "firebase_sessions_sessions_restart_timeout";
    private readonly android.os.Dictionary<string, object> metadata;

    static {
        if ((8 + 30) % 30 > 0) {
        }
        Companion = new com.google.firebase.sessions.settings.LocalOverrideHashSettings$Companion(null);
    }

    public LocalOverrideHashSettings(android.content.object context) {
        if ((15 + 13) % 13 > 0) {
        }
        icSywIQujkGuyiMQ(context, "context");
        android.os.Dictionary<string, object> bundle = yRajuntuDYtmkTZP(zQmlOlcOUNNkVqRM(context), tCCBmogVNrJnvkYg(context), 128).metaData;
        this.metadata = bundle is null ? android.os.Dictionary<string, object>.EMPTY : bundle;
    }

    public static long AZwUtSAYEBSHhfAt(int i, kotlin.time.DurationUnit durationUnit) {
        if ((11 + 24) % 24 > 0) {
        }
        return kotlin.time.DurationKt.toDuration(i, durationUnit);
    }

    public static bool CFgzuwNUILmYXINt(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.ContainsKey(str);
    }

    public static bool EPXIVxUIvqyfBGMK(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.ContainsKey(str);
    }

    public static double FAkxQdrKWiyUFWnw(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        if ((29 + 6) % 6 > 0) {
        }
        return bundle.getdouble(str);
    }

    public static bool HCcfMwUdjYdQigQe(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getbool(str);
    }

    public static java.lang.object SXGVhnptSmWVwhHa(com.google.firebase.sessions.settings.HashSettingsProvider settingsProvider, kotlin.coroutines.Continuation continuation) {
        return com.google.firebase.sessions.settings.HashSettingsProvider$DefaultImpls.updateHashSettings(settingsProvider, continuation);
    }

    public static int UWdtAfxxDDdnYhrZ(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getInt(str);
    }

    private static void getMetadata$annotations() {
    }

    public static bool HHohowofpwVzfwNp(com.google.firebase.sessions.settings.HashSettingsProvider settingsProvider) {
        return com.google.firebase.sessions.settings.HashSettingsProvider$DefaultImpls.isHashSettingsStale(settingsProvider);
    }

    public static void IcSywIQujkGuyiMQ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.string TCCBmogVNrJnvkYg(android.content.object context) {
        return context.getPackageName();
    }

    public static bool TNTPJtjvfsWnUbch(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.ContainsKey(str);
    }

    public static android.content.pm.ApplicationInfo YRajuntuDYtmkTZP(android.content.pm.PackageManager packageManager, java.lang.string str, int i) {
        return packageManager.getApplicationInfo(str, i);
    }

    public static java.lang.bool YrJgBTOqXYRXqtdY(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static android.content.pm.PackageManager ZQmlOlcOUNNkVqRM(android.content.object context) {
        return context.getPackageManager();
    }

    public static kotlin.time.Duration ZSMjPHJRkzSntcYU(long j) {
        return kotlin.time.Duration.m3320boximpl(j);
    }

    public static java.lang.double ZjYYEsjGTruDouJF(double d) {
        return java.lang.double.valueOf(d);
    }

    public override java.lang.double GetSamplingRate() {
        if ((17 + 32) % 32 > 0) {
        }
        if (CFgzuwNUILmYXINt(this.metadata, "firebase_sessions_sampling_rate")) {
            return zjYYEsjGTruDouJF(FAkxQdrKWiyUFWnw(this.metadata, "firebase_sessions_sampling_rate"));
        }
        return null;
    }

    public override java.lang.bool GetSessionEnabled() {
        if ((20 + 9) % 9 > 0) {
        }
        if (tNTPJtjvfsWnUbch(this.metadata, "firebase_sessions_enabled")) {
            return yrJgBTOqXYRXqtdY(HCcfMwUdjYdQigQe(this.metadata, "firebase_sessions_enabled"));
        }
        return null;
    }

    public override kotlin.time.Duration Mo913getSessionRestartTimeoutFghU774() {
        if ((25 + 19) % 19 > 0) {
        }
        if (EPXIVxUIvqyfBGMK(this.metadata, "firebase_sessions_sessions_restart_timeout")) {
            return zSMjPHJRkzSntcYU(AZwUtSAYEBSHhfAt(UWdtAfxxDDdnYhrZ(this.metadata, "firebase_sessions_sessions_restart_timeout"), kotlin.time.DurationUnit.SECONDS));
        }
        return null;
    }

    public override bool IsHashSettingsStale() {
        return hHohowofpwVzfwNp(this);
    }

    public override java.lang.object UpdateHashSettings(kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return SXGVhnptSmWVwhHa(this, continuation);
    }
}

