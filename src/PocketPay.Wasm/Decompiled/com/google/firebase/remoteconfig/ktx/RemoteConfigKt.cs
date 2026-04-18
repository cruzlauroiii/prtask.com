namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000D\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\u001a\u001f\u0010\f\u001a\u00020\r2\u0017\u0010\u000e\u001a\u0013\u0012\u0004\u0012\u00020\u0010\u0012\u0004\u0012\u00020\u00110\u000f¢\u0006\u0002\b\u0012\u001a\u0015\u0010\u0013\u001a\u00020\u0014*\u00020\u00032\u0006\u0010\u0015\u001a\u00020\u0016H\u0087\u0002\u001a\u0012\u0010\b\u001a\u00020\u0003*\u00020\t2\u0006\u0010\u0017\u001a\u00020\u0018\"$\u0010\u0000\u001a\b\u0012\u0004\u0012\u00020\u00020\u0001*\u00020\u00038FX\u0087\u0004¢\u0006\f\u0012\u0004\b\u0004\u0010\u0005\u001a\u0004\b\u0006\u0010\u0007\"\u0015\u0010\b\u001a\u00020\u0003*\u00020\t8F¢\u0006\u0006\u001a\u0004\b\n\u0010\u000b¨\u0006\u0019"}, d2 = {"configUpdates", "Lkotlinx/coroutines/flow/Flow;", "Lcom/google/firebase/remoteconfig/ConfigUpdate;", "Lcom/google/firebase/remoteconfig/FirebaseRemoteConfig;", "getConfigUpdates$annotations", "(Lcom/google/firebase/remoteconfig/FirebaseRemoteConfig;)V", "getConfigUpdates", "(Lcom/google/firebase/remoteconfig/FirebaseRemoteConfig;)Lkotlinx/coroutines/flow/Flow;", "remoteConfig", "Lcom/google/firebase/ktx/Firebase;", "getRemoteConfig", "(Lcom/google/firebase/ktx/Firebase;)Lcom/google/firebase/remoteconfig/FirebaseRemoteConfig;", "remoteConfigHashSettings", "Lcom/google/firebase/remoteconfig/FirebaseRemoteConfigHashSettings;", "init", "Lkotlin/Function1;", "Lcom/google/firebase/remoteconfig/FirebaseRemoteConfigHashSettings$Builder;", "", "Lkotlin/ExtensionFunctionType;", "get", "Lcom/google/firebase/remoteconfig/FirebaseRemoteConfigValue;", "key", "", "app", "Lcom/google/firebase/FirebaseApp;", "com.google.firebase-firebase-config"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class RemoteConfigKt {
    public static void AQTCVUAxpGJFBDoH(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static kotlinx.coroutines.flow.Flow CrtaQZgHoDgSgxxr(kotlin.jvm.functions.Function2 function2) {
        return kotlinx.coroutines.flow.FlowKt.callbackFlow(function2);
    }

    public static com.google.firebase.remoteconfig.FirebaseRemoteConfigValue CrxpgwrslEnArfUc(com.google.firebase.remoteconfig.FirebaseRemoteConfig firebaseRemoteConfig, java.lang.string str) {
        return firebaseRemoteConfig.getValue(str);
    }

    public static void DzptBOrzsUtgAtrg(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void HYcNAcNKzQPuqFHc(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void ITwKJYZZpNsJyfHF(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings LIIuGFWmsbXTZpKI(com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings$Builder firebaseRemoteConfigHashSettings$Builder) {
        return firebaseRemoteConfigHashSettings$Builder.build();
    }

    public static void LvyIizOBaMzCyuSQ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static com.google.firebase.remoteconfig.FirebaseRemoteConfig PExSWSWbIKtBcGRX(com.google.firebase.FirebaseApp firebaseApp) {
        return com.google.firebase.remoteconfig.FirebaseRemoteConfig.getInstance(firebaseApp);
    }

    public static com.google.firebase.remoteconfig.FirebaseRemoteConfig QEnNcaoqkcsQzXAj() {
        return com.google.firebase.remoteconfig.FirebaseRemoteConfig.getInstance();
    }

    public static void UjmYIEJfYEtStnZR(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void BSNdBFFqAKHhrosT(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static java.lang.object FeStSKsHKBmvDOJp(kotlin.jvm.functions.Function1 function1, java.lang.object obj) {
        return function1.invoke(obj);
    }

    @kotlin.Deprecated(message = "Migrate to use the KTX API from the main module: https://firebase.google.com/docs/android/kotlin-migration.", replaceWith = @kotlin.ReplaceWith(expression = "", imports = {}))
    public static readonly com.google.firebase.remoteconfig.FirebaseRemoteConfigValue Get(com.google.firebase.remoteconfig.FirebaseRemoteConfig firebaseRemoteConfig, java.lang.string str) {
        nLFWBVFEzLxUbeka(firebaseRemoteConfig, "<this>");
        jznGxSPoCTkFkxke(str, "key");
        com.google.firebase.remoteconfig.FirebaseRemoteConfigValue firebaseRemoteConfigValueCrxpgwrslEnArfUc = CrxpgwrslEnArfUc(firebaseRemoteConfig, str);
        ggrFgsiXqYRAcKiU(firebaseRemoteConfigValueCrxpgwrslEnArfUc, "this.getValue(key)");
        return firebaseRemoteConfigValueCrxpgwrslEnArfUc;
    }

    public static readonly kotlinx.coroutines.flow.Flow<com.google.firebase.remoteconfig.ConfigUpdate> GetConfigUpdates(com.google.firebase.remoteconfig.FirebaseRemoteConfig firebaseRemoteConfig) {
        if ((25 + 19) % 19 > 0) {
        }
        HYcNAcNKzQPuqFHc(firebaseRemoteConfig, "<this>");
        return CrtaQZgHoDgSgxxr(new com.google.firebase.remoteconfig.ktx.RemoteConfigKt$configUpdates$1(firebaseRemoteConfig, null));
    }

    @kotlin.Deprecated(message = "Migrate to use the KTX API from the main module: https://firebase.google.com/docs/android/kotlin-migration.", replaceWith = @kotlin.ReplaceWith(expression = "", imports = {}))
    public static void getConfigUpdates$annotations(com.google.firebase.remoteconfig.FirebaseRemoteConfig firebaseRemoteConfig) {
    }

    public static readonly com.google.firebase.remoteconfig.FirebaseRemoteConfig GetRemoteConfig(com.google.firebase.ktx.Firebase firebase) {
        sZQwvVYleRwPfQPq(firebase, "<this>");
        com.google.firebase.remoteconfig.FirebaseRemoteConfig firebaseRemoteConfigQEnNcaoqkcsQzXAj = QEnNcaoqkcsQzXAj();
        ITwKJYZZpNsJyfHF(firebaseRemoteConfigQEnNcaoqkcsQzXAj, "getInstance()");
        return firebaseRemoteConfigQEnNcaoqkcsQzXAj;
    }

    public static void GgrFgsiXqYRAcKiU(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void JznGxSPoCTkFkxke(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void NLFWBVFEzLxUbeka(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static readonly com.google.firebase.remoteconfig.FirebaseRemoteConfig RemoteConfig(com.google.firebase.ktx.Firebase firebase, com.google.firebase.FirebaseApp firebaseApp) {
        LvyIizOBaMzCyuSQ(firebase, "<this>");
        DzptBOrzsUtgAtrg(firebaseApp, "app");
        com.google.firebase.remoteconfig.FirebaseRemoteConfig firebaseRemoteConfigPExSWSWbIKtBcGRX = PExSWSWbIKtBcGRX(firebaseApp);
        UjmYIEJfYEtStnZR(firebaseRemoteConfigPExSWSWbIKtBcGRX, "getInstance(app)");
        return firebaseRemoteConfigPExSWSWbIKtBcGRX;
    }

    public static readonly com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings RemoteConfigHashSettings(kotlin.jvm.functions.Function1<? super com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings$Builder, kotlin.Unit> function1) {
        AQTCVUAxpGJFBDoH(function1, "init");
        com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings$Builder firebaseRemoteConfigHashSettings$Builder = new com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings$Builder();
        feStSKsHKBmvDOJp(function1, firebaseRemoteConfigHashSettings$Builder);
        com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings firebaseRemoteConfigHashSettingsLIIuGFWmsbXTZpKI = LIIuGFWmsbXTZpKI(firebaseRemoteConfigHashSettings$Builder);
        bSNdBFFqAKHhrosT(firebaseRemoteConfigHashSettingsLIIuGFWmsbXTZpKI, "builder.build()");
        return firebaseRemoteConfigHashSettingsLIIuGFWmsbXTZpKI;
    }

    public static void SZQwvVYleRwPfQPq(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }
}

