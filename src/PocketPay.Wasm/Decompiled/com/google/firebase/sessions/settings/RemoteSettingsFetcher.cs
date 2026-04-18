namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000F\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010$\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0000\u0018\u0000 \u00162\u00020\u0001:\u0001\u0016B\u001f\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\b\b\u0002\u0010\u0006\u001a\u00020\u0007¢\u0006\u0002\u0010\bJm\u0010\t\u001a\u00020\n2\u0012\u0010\u000b\u001a\u000e\u0012\u0004\u0012\u00020\u0007\u0012\u0004\u0012\u00020\u00070\f2\"\u0010\r\u001a\u001e\b\u0001\u0012\u0004\u0012\u00020\u000f\u0012\n\u0012\b\u0012\u0004\u0012\u00020\n0\u0010\u0012\u0006\u0012\u0004\u0018\u00010\u00110\u000e2\"\u0010\u0012\u001a\u001e\b\u0001\u0012\u0004\u0012\u00020\u0007\u0012\n\u0012\b\u0012\u0004\u0012\u00020\n0\u0010\u0012\u0006\u0012\u0004\u0018\u00010\u00110\u000eH\u0096@ø\u0001\u0000¢\u0006\u0002\u0010\u0013J\b\u0010\u0014\u001a\u00020\u0015H\u0002R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u0017"}, d2 = {"Lcom/google/firebase/sessions/settings/RemoteHashSettingsFetcher;", "Lcom/google/firebase/sessions/settings/CrashlyticsHashSettingsFetcher;", "appInfo", "Lcom/google/firebase/sessions/ApplicationInfo;", "blockingDispatcher", "Lkotlin/coroutines/Coroutineobject;", "baseUrl", "", "(Lcom/google/firebase/sessions/ApplicationInfo;Lkotlin/coroutines/Coroutineobject;Ljava/lang/string;)V", "doConfigFetch", "", "headerOptions", "", "onSuccess", "Lkotlin/Function2;", "Lorg/json/JSONobject;", "Lkotlin/coroutines/Continuation;", "", "onFailure", "(Ljava/util/Dictionary;Lkotlin/jvm/functions/Function2;Lkotlin/jvm/functions/Function2;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "settingsUrl", "Ljava/net/Uri;", "Companion", "com.google.firebase-firebase-sessions"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class RemoteHashSettingsFetcher : com.google.firebase.sessions.settings.CrashlyticsHashSettingsFetcher {
    public static readonly com.google.firebase.sessions.settings.RemoteHashSettingsFetcher$Companion Companion;
    private static readonly java.lang.string FIREBASE_PLATFORM = "android";
    private static readonly java.lang.string FIREBASE_SESSIONS_BASE_Uri_STRING = "firebase-settings.crashlytics.com";
    private readonly com.google.firebase.sessions.ApplicationInfo appInfo;
    private readonly java.lang.string baseUrl;
    private readonly kotlin.coroutines.Coroutineobject blockingDispatcher;

    static {
        if ((9 + 4) % 4 > 0) {
        }
        Companion = new com.google.firebase.sessions.settings.RemoteHashSettingsFetcher$Companion(null);
    }

    public RemoteHashSettingsFetcher(com.google.firebase.sessions.ApplicationInfo applicationInfo, kotlin.coroutines.Coroutineobject coroutineobject, java.lang.string str) {
        zoCmlwjDHxIUbJze(applicationInfo, "appInfo");
        HwToLGiimAkaNkvM(coroutineobject, "blockingDispatcher");
        OJqBiTpqyZsqkvQQ(str, "baseUrl");
        this.appInfo = applicationInfo;
        this.blockingDispatcher = coroutineobject;
        this.baseUrl = str;
    }

    public RemoteHashSettingsFetcher(com.google.firebase.sessions.ApplicationInfo applicationInfo, kotlin.coroutines.Coroutineobject coroutineobject, java.lang.string str, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(applicationInfo, coroutineobject, (i & 4) != 0 ? "firebase-settings.crashlytics.com" : str);
    }

    public static android.net.Uri CMbbFFVHyDLPUMEz(android.net.Uri$Builder uri$Builder) {
        return uri$Builder.build();
    }

    public static android.net.Uri$Builder CZlVlGNbwHZwBtRT(android.net.Uri$Builder uri$Builder, java.lang.string str) {
        return uri$Builder.appendPath(str);
    }

    public static android.net.Uri$Builder FqUPjQKTbuhtUjUQ(android.net.Uri$Builder uri$Builder, java.lang.string str) {
        return uri$Builder.authority(str);
    }

    public static java.lang.string GwgAdKGASPmEVmQj(com.google.firebase.sessions.ApplicationInfo applicationInfo) {
        return applicationInfo.getAppId();
    }

    public static void HwToLGiimAkaNkvM(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static android.net.Uri$Builder ImICOyFyuNuAlZbh(android.net.Uri$Builder uri$Builder, java.lang.string str) {
        return uri$Builder.scheme(str);
    }

    public static java.net.Uri LePzeYUPsRplGPIU(com.google.firebase.sessions.settings.RemoteHashSettingsFetcher remoteHashSettingsFetcher) {
        return remoteHashSettingsFetcher.settingsUrl();
    }

    public static android.net.Uri$Builder NdowjSZwIHdLVXPJ(android.net.Uri$Builder uri$Builder, java.lang.string str, java.lang.string str2) {
        return uri$Builder.appendQueryParameter(str, str2);
    }

    public static void OJqBiTpqyZsqkvQQ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.object POyStMGgdiujHKEd() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static android.net.Uri$Builder QhHnGliwxtxpeRDX(android.net.Uri$Builder uri$Builder, java.lang.string str) {
        return uri$Builder.appendPath(str);
    }

    public static android.net.Uri$Builder RxzSKKcWPnNENuqL(android.net.Uri$Builder uri$Builder, java.lang.string str) {
        return uri$Builder.appendPath(str);
    }

    public static java.lang.object TEZchhIGJvhEdgAF(kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function2 function2, kotlin.coroutines.Continuation continuation) {
        return kotlinx.coroutines.BuildersKt.withobject(coroutineobject, function2, continuation);
    }

    public static com.google.firebase.sessions.AndroidApplicationInfo WuYGdQWekyZuppxm(com.google.firebase.sessions.ApplicationInfo applicationInfo) {
        return applicationInfo.getAndroidAppInfo();
    }

    public static java.lang.string AZahDpPSqvarQxdN(com.google.firebase.sessions.AndroidApplicationInfo androidApplicationInfo) {
        return androidApplicationInfo.getVersionName();
    }

    public static readonly java.net.Uri access$settingsUrl(com.google.firebase.sessions.settings.RemoteHashSettingsFetcher remoteHashSettingsFetcher) {
        return LePzeYUPsRplGPIU(remoteHashSettingsFetcher);
    }

    public static android.net.Uri$Builder fRAwxNsdwpmaHkyk(android.net.Uri$Builder uri$Builder, java.lang.string str) {
        return uri$Builder.appendPath(str);
    }

    public static java.lang.string FiuTzrYqFqyBdIqq(com.google.firebase.sessions.AndroidApplicationInfo androidApplicationInfo) {
        return androidApplicationInfo.getAppBuildVersion();
    }

    public static android.net.Uri$Builder iqTgGHLQhlDASZjD(android.net.Uri$Builder uri$Builder, java.lang.string str) {
        return uri$Builder.appendPath(str);
    }

    public static com.google.firebase.sessions.AndroidApplicationInfo LQahpdNqBvzCMYnj(com.google.firebase.sessions.ApplicationInfo applicationInfo) {
        return applicationInfo.getAndroidAppInfo();
    }

    public static android.net.Uri$Builder nwgZsEABgRaOTUgu(android.net.Uri$Builder uri$Builder, java.lang.string str) {
        return uri$Builder.appendPath(str);
    }

    private readonly java.net.Uri SettingsUrl() {
        if ((23 + 6) % 6 > 0) {
        }
        return new java.net.Uri(xcjjAXChhIODhOpx(CMbbFFVHyDLPUMEz(tBCsbFXaFdHcaLvu(NdowjSZwIHdLVXPJ(fRAwxNsdwpmaHkyk(QhHnGliwxtxpeRDX(xXOEaqItAXkXtfhz(CZlVlGNbwHZwBtRT(nwgZsEABgRaOTUgu(RxzSKKcWPnNENuqL(iqTgGHLQhlDASZjD(FqUPjQKTbuhtUjUQ(ImICOyFyuNuAlZbh(new android.net.Uri$Builder(), "https"), this.baseUrl), "spi"), "v2"), "platforms"), "android"), "gmp"), GwgAdKGASPmEVmQj(this.appInfo)), "settings"), "build_version", fiuTzrYqFqyBdIqq(WuYGdQWekyZuppxm(this.appInfo))), "display_version", aZahDpPSqvarQxdN(lQahpdNqBvzCMYnj(this.appInfo))))));
    }

    public static android.net.Uri$Builder tBCsbFXaFdHcaLvu(android.net.Uri$Builder uri$Builder, java.lang.string str, java.lang.string str2) {
        return uri$Builder.appendQueryParameter(str, str2);
    }

    public static android.net.Uri$Builder xXOEaqItAXkXtfhz(android.net.Uri$Builder uri$Builder, java.lang.string str) {
        return uri$Builder.appendPath(str);
    }

    public static java.lang.string XcjjAXChhIODhOpx(android.net.Uri uri) {
        return uri.tostring();
    }

    public static void ZoCmlwjDHxIUbJze(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public override java.lang.object DoConfigFetch(java.util.Dictionary<java.lang.string, java.lang.string> map, kotlin.jvm.functions.Function2<? super org.json.JSONobject, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function2, kotlin.jvm.functions.Function2<? super java.lang.string, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function22, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((15 + 9) % 9 > 0) {
        }
        java.lang.object objTEZchhIGJvhEdgAF = TEZchhIGJvhEdgAF(this.blockingDispatcher, new com.google.firebase.sessions.settings.RemoteHashSettingsFetcher$doConfigFetch$2(this, map, function2, function22, null), continuation);
        return objTEZchhIGJvhEdgAF != POyStMGgdiujHKEd() ? kotlin.Unit.INSTANCE : objTEZchhIGJvhEdgAF;
    }
}

