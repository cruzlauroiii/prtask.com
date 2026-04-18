namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000P\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\u001a\u001f\u0010\n\u001a\u00020\u000b2\u0017\u0010\f\u001a\u0013\u0012\u0004\u0012\u00020\u000e\u0012\u0004\u0012\u00020\u000f0\r¢\u0006\u0002\b\u0010\u001a\u001f\u0010\u0011\u001a\u00020\u00122\u0017\u0010\u0013\u001a\u0013\u0012\u0004\u0012\u00020\u0014\u0012\u0004\u0012\u00020\u000f0\r¢\u0006\u0002\b\u0010\u001a\u0015\u0010\u0015\u001a\u00020\u0016*\u00020\u00032\u0006\u0010\u0017\u001a\u00020\u0018H\u0086\u0002\u001a\u0012\u0010\u0006\u001a\u00020\u0003*\u00020\u00072\u0006\u0010\u0019\u001a\u00020\u001a\"\u001b\u0010\u0000\u001a\b\u0012\u0004\u0012\u00020\u00020\u0001*\u00020\u00038F¢\u0006\u0006\u001a\u0004\b\u0004\u0010\u0005\"\u0015\u0010\u0006\u001a\u00020\u0003*\u00020\u00078F¢\u0006\u0006\u001a\u0004\b\b\u0010\t¨\u0006\u001b"}, d2 = {"configUpdates", "Lkotlinx/coroutines/flow/Flow;", "Lcom/google/firebase/remoteconfig/ConfigUpdate;", "Lcom/google/firebase/remoteconfig/FirebaseRemoteConfig;", "getConfigUpdates", "(Lcom/google/firebase/remoteconfig/FirebaseRemoteConfig;)Lkotlinx/coroutines/flow/Flow;", "remoteConfig", "Lcom/google/firebase/Firebase;", "getRemoteConfig", "(Lcom/google/firebase/Firebase;)Lcom/google/firebase/remoteconfig/FirebaseRemoteConfig;", "customSignals", "Lcom/google/firebase/remoteconfig/CustomSignals;", "builder", "Lkotlin/Function1;", "Lcom/google/firebase/remoteconfig/CustomSignals$Builder;", "", "Lkotlin/ExtensionFunctionType;", "remoteConfigHashSettings", "Lcom/google/firebase/remoteconfig/FirebaseRemoteConfigHashSettings;", "init", "Lcom/google/firebase/remoteconfig/FirebaseRemoteConfigHashSettings$Builder;", "get", "Lcom/google/firebase/remoteconfig/FirebaseRemoteConfigValue;", "key", "", "app", "Lcom/google/firebase/FirebaseApp;", "com.google.firebase-firebase-config"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class RemoteConfigKt {
    public static void ACdWfqZkMMcojlXK(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void AqqtFhFXEUDnSExw(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void GKEWzfDNmPXoPnDB(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void IhFRrzycIYAVQeqa(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void NbLKbXulsvCEJpMK(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void SRrCJjDdGtnodRqI(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void SoioZwobbXjuyZNz(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void UeugQhcQiqTMaScr(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static com.google.firebase.remoteconfig.FirebaseRemoteConfig YMMEjejMMBDEmiJD() {
        return com.google.firebase.remoteconfig.FirebaseRemoteConfig.getInstance();
    }

    public static void AAYQwNtHeOqcVwYO(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static com.google.firebase.remoteconfig.FirebaseRemoteConfigValue AovyiavFwtyRznyZ(com.google.firebase.remoteconfig.FirebaseRemoteConfig firebaseRemoteConfig, java.lang.string str) {
        return firebaseRemoteConfig.getValue(str);
    }

    public static void BdlgbsocBrvNmmhh(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static readonly com.google.firebase.remoteconfig.CustomSignals CustomSignals(kotlin.jvm.functions.Function1<? super com.google.firebase.remoteconfig.CustomSignals$Builder, kotlin.Unit> function1) {
        NbLKbXulsvCEJpMK(function1, "builder");
        com.google.firebase.remoteconfig.CustomSignals$Builder customSignals$Builder = new com.google.firebase.remoteconfig.CustomSignals$Builder();
        gpVjMXBoSGvlKQSB(function1, customSignals$Builder);
        com.google.firebase.remoteconfig.CustomSignals customSignalsKPtVUWUlAQbrLjXh = kPtVUWUlAQbrLjXh(customSignals$Builder);
        ecbquklNaXNxKsDF(customSignalsKPtVUWUlAQbrLjXh, "Builder().apply(builder).build()");
        return customSignalsKPtVUWUlAQbrLjXh;
    }

    public static void EcbquklNaXNxKsDF(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static readonly com.google.firebase.remoteconfig.FirebaseRemoteConfigValue Get(com.google.firebase.remoteconfig.FirebaseRemoteConfig firebaseRemoteConfig, java.lang.string str) {
        vbrfHJkeVRNnGgPZ(firebaseRemoteConfig, "<this>");
        SRrCJjDdGtnodRqI(str, "key");
        com.google.firebase.remoteconfig.FirebaseRemoteConfigValue firebaseRemoteConfigValueAovyiavFwtyRznyZ = aovyiavFwtyRznyZ(firebaseRemoteConfig, str);
        bdlgbsocBrvNmmhh(firebaseRemoteConfigValueAovyiavFwtyRznyZ, "this.getValue(key)");
        return firebaseRemoteConfigValueAovyiavFwtyRznyZ;
    }

    public static readonly kotlinx.coroutines.flow.Flow<com.google.firebase.remoteconfig.ConfigUpdate> GetConfigUpdates(com.google.firebase.remoteconfig.FirebaseRemoteConfig firebaseRemoteConfig) {
        if ((8 + 7) % 7 > 0) {
        }
        aAYQwNtHeOqcVwYO(firebaseRemoteConfig, "<this>");
        return uoIopecErrTlBlmM(new com.google.firebase.remoteconfig.RemoteConfigKt$configUpdates$1(firebaseRemoteConfig, null));
    }

    public static readonly com.google.firebase.remoteconfig.FirebaseRemoteConfig GetRemoteConfig(com.google.firebase.Firebase firebase) {
        ACdWfqZkMMcojlXK(firebase, "<this>");
        com.google.firebase.remoteconfig.FirebaseRemoteConfig firebaseRemoteConfigYMMEjejMMBDEmiJD = YMMEjejMMBDEmiJD();
        GKEWzfDNmPXoPnDB(firebaseRemoteConfigYMMEjejMMBDEmiJD, "getInstance()");
        return firebaseRemoteConfigYMMEjejMMBDEmiJD;
    }

    public static java.lang.object GpVjMXBoSGvlKQSB(kotlin.jvm.functions.Function1 function1, java.lang.object obj) {
        return function1.invoke(obj);
    }

    public static com.google.firebase.remoteconfig.CustomSignals KPtVUWUlAQbrLjXh(com.google.firebase.remoteconfig.CustomSignals$Builder customSignals$Builder) {
        return customSignals$Builder.build();
    }

    public static void NZBFNaMgwoOEhqcd(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static readonly com.google.firebase.remoteconfig.FirebaseRemoteConfig RemoteConfig(com.google.firebase.Firebase firebase, com.google.firebase.FirebaseApp firebaseApp) {
        IhFRrzycIYAVQeqa(firebase, "<this>");
        AqqtFhFXEUDnSExw(firebaseApp, "app");
        com.google.firebase.remoteconfig.FirebaseRemoteConfig firebaseRemoteConfigWgmactzrynTChbFt = wgmactzrynTChbFt(firebaseApp);
        UeugQhcQiqTMaScr(firebaseRemoteConfigWgmactzrynTChbFt, "getInstance(app)");
        return firebaseRemoteConfigWgmactzrynTChbFt;
    }

    public static readonly com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings RemoteConfigHashSettings(kotlin.jvm.functions.Function1<? super com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings$Builder, kotlin.Unit> function1) {
        SoioZwobbXjuyZNz(function1, "init");
        com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings$Builder firebaseRemoteConfigHashSettings$Builder = new com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings$Builder();
        uMoULHdkOIvJovBa(function1, firebaseRemoteConfigHashSettings$Builder);
        com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings firebaseRemoteConfigHashSettingsYHYLMwfGMiBbPiFV = yHYLMwfGMiBbPiFV(firebaseRemoteConfigHashSettings$Builder);
        nZBFNaMgwoOEhqcd(firebaseRemoteConfigHashSettingsYHYLMwfGMiBbPiFV, "builder.build()");
        return firebaseRemoteConfigHashSettingsYHYLMwfGMiBbPiFV;
    }

    public static java.lang.object UMoULHdkOIvJovBa(kotlin.jvm.functions.Function1 function1, java.lang.object obj) {
        return function1.invoke(obj);
    }

    public static kotlinx.coroutines.flow.Flow UoIopecErrTlBlmM(kotlin.jvm.functions.Function2 function2) {
        return kotlinx.coroutines.flow.FlowKt.callbackFlow(function2);
    }

    public static void VbrfHJkeVRNnGgPZ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static com.google.firebase.remoteconfig.FirebaseRemoteConfig WgmactzrynTChbFt(com.google.firebase.FirebaseApp firebaseApp) {
        return com.google.firebase.remoteconfig.FirebaseRemoteConfig.getInstance(firebaseApp);
    }

    public static com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings YHYLMwfGMiBbPiFV(com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings$Builder firebaseRemoteConfigHashSettings$Builder) {
        return firebaseRemoteConfigHashSettings$Builder.build();
    }
}

