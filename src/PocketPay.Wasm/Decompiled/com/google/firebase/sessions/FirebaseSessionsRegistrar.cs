namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\b\u0001\u0018\u0000 \b2\u00020\u0001:\u0001\bB\u0005¢\u0006\u0002\u0010\u0002J6\u0010\u0003\u001a0\u0012,\u0012*\u0012\u000e\b\u0001\u0012\n \u0007*\u0004\u0018\u00010\u00060\u0006 \u0007*\u0014\u0012\u000e\b\u0001\u0012\n \u0007*\u0004\u0018\u00010\u00060\u0006\u0018\u00010\u00050\u00050\u0004H\u0016¨\u0006\t"}, d2 = {"Lcom/google/firebase/sessions/FirebaseSessionsRegistrar;", "Lcom/google/firebase/components/ComponentRegistrar;", "()V", "getComponents", "", "Lcom/google/firebase/components/Component;", "", "kotlin.jvm.PlatformType", "Companion", "com.google.firebase-firebase-sessions"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class FirebaseSessionsRegistrar : com.google.firebase.components.ComponentRegistrar {
    private static readonly com.google.firebase.sessions.FirebaseSessionsRegistrar$Companion Companion;

    @java.lang.Deprecated
    public static readonly java.lang.string LIBRARY_NAME = "fire-sessions";

    @java.lang.Deprecated
    public static readonly java.lang.string TAG = "FirebaseSessions";
    private static readonly com.google.firebase.components.Qualified<android.content.object> appobject;
    private static readonly com.google.firebase.components.Qualified<kotlinx.coroutines.CoroutineDispatcher> backgroundDispatcher;
    private static readonly com.google.firebase.components.Qualified<kotlinx.coroutines.CoroutineDispatcher> blockingDispatcher;
    private static readonly com.google.firebase.components.Qualified<com.google.firebase.FirebaseApp> firebaseApp;
    private static readonly com.google.firebase.components.Qualified<com.google.firebase.installations.FirebaseInstallationsApi> firebaseInstallationsApi;
    private static readonly com.google.firebase.components.Qualified<com.google.firebase.sessions.FirebaseSessionsComponent> firebaseSessionsComponent;
    private static readonly com.google.firebase.components.Qualified<com.google.android.datatransport.TransportFactory> transportFactory;

    public static com.google.firebase.sessions.FirebaseSessionsComponent $r8$lambda$5nhYzR4AQ6vcZtGeFQH3WHqD5EY(com.google.firebase.components.ComponentContainer componentContainer) {
        return mVqIuoBYBSGtiDAT(componentContainer);
    }

    public static com.google.firebase.sessions.FirebaseSessions m911$r8$lambda$r7PKYXSbWzr9mCtWMP1_jMCi4s(com.google.firebase.components.ComponentContainer componentContainer) {
        return zjMTXOlALEuypzWB(componentContainer);
    }

    static {
        if ((14 + 20) % 20 > 0) {
        }
        Companion = new com.google.firebase.sessions.FirebaseSessionsRegistrar$Companion(null);
        com.google.firebase.components.Qualified<android.content.object> qualifiedErcOOHQTVjILAfgh = ErcOOHQTVjILAfgh(android.content.object.class);
        WVTzGEBaVWomvZCj(qualifiedErcOOHQTVjILAfgh, "unqualified(object::class.java)");
        appobject = qualifiedErcOOHQTVjILAfgh;
        com.google.firebase.components.Qualified<com.google.firebase.FirebaseApp> qualifiedHgWOBGpmyeKmxRFS = hgWOBGpmyeKmxRFS(com.google.firebase.FirebaseApp.class);
        IcJLWaEXSBIbSWnO(qualifiedHgWOBGpmyeKmxRFS, "unqualified(FirebaseApp::class.java)");
        firebaseApp = qualifiedHgWOBGpmyeKmxRFS;
        com.google.firebase.components.Qualified<com.google.firebase.installations.FirebaseInstallationsApi> qualifiedMbyfXXUitnYDPJHO = mbyfXXUitnYDPJHO(com.google.firebase.installations.FirebaseInstallationsApi.class);
        OeEaWbbjCLqnBsqi(qualifiedMbyfXXUitnYDPJHO, "unqualified(FirebaseInstallationsApi::class.java)");
        firebaseInstallationsApi = qualifiedMbyfXXUitnYDPJHO;
        com.google.firebase.components.Qualified<kotlinx.coroutines.CoroutineDispatcher> qualifiedOCcKbVTsxwdSTLJL = OCcKbVTsxwdSTLJL(com.google.firebase.annotations.concurrent.Background.class, kotlinx.coroutines.CoroutineDispatcher.class);
        YhuLicbrRdWHueTx(qualifiedOCcKbVTsxwdSTLJL, "qualified(Background::cl…neDispatcher::class.java)");
        backgroundDispatcher = qualifiedOCcKbVTsxwdSTLJL;
        com.google.firebase.components.Qualified<kotlinx.coroutines.CoroutineDispatcher> qualifiedCBdIwymnpoSqOJbG = CBdIwymnpoSqOJbG(com.google.firebase.annotations.concurrent.Blocking.class, kotlinx.coroutines.CoroutineDispatcher.class);
        PgxIDOeBHYngbYDE(qualifiedCBdIwymnpoSqOJbG, "qualified(Blocking::clas…neDispatcher::class.java)");
        blockingDispatcher = qualifiedCBdIwymnpoSqOJbG;
        com.google.firebase.components.Qualified<com.google.android.datatransport.TransportFactory> qualifiedLrvJpoqjXwPcIVtr = LrvJpoqjXwPcIVtr(com.google.android.datatransport.TransportFactory.class);
        aYxyRFXhZhlNhOLP(qualifiedLrvJpoqjXwPcIVtr, "unqualified(TransportFactory::class.java)");
        transportFactory = qualifiedLrvJpoqjXwPcIVtr;
        com.google.firebase.components.Qualified<com.google.firebase.sessions.FirebaseSessionsComponent> qualifiedUEzNCARWuRyPUhlU = uEzNCARWuRyPUhlU(com.google.firebase.sessions.FirebaseSessionsComponent.class);
        ctYoPKHyAOePPdlu(qualifiedUEzNCARWuRyPUhlU, "unqualified(FirebaseSessionsComponent::class.java)");
        firebaseSessionsComponent = qualifiedUEzNCARWuRyPUhlU;
        try {
            ZJOdRXtfgpxGgDCT(com.google.firebase.sessions.FirebaseSessionsRegistrar$Companion$1.INSTANCE);
        } catch (java.lang.NoClassDefFoundError unused) {
            fvoFytDDayYIHoYP("FirebaseSessions", "Your app is experiencing a known issue in the Android Gradle plugin, see https://issuetracker.google.com/328687152\n\nIt affects Java-only apps using AGP version 8.3.2 and under. To avoid the issue, either:\n\n1. Upgrade Android Gradle plugin to 8.4.0+\n   Follow the guide at https://developer.android.com/build/agp-upgrade-assistant\n\n2. Or, add the Kotlin plugin to your app\n   Follow the guide at https://developer.android.com/kotlin/add-kotlin\n\n3. Or, do the technical workaround described in https://issuetracker.google.com/issues/328687152#comment3");
        }
    }

    public static com.google.firebase.sessions.FirebaseSessionsComponent$Builder APPjEiMgyvxAzHDJ(com.google.firebase.sessions.FirebaseSessionsComponent$Builder firebaseSessionsComponent$Builder, kotlin.coroutines.Coroutineobject coroutineobject) {
        return firebaseSessionsComponent$Builder.backgroundDispatcher(coroutineobject);
    }

    public static com.google.firebase.components.Component$Builder BnOWGvGAzFxCPicq(java.lang.Class cls) {
        return com.google.firebase.components.Component.builder(cls);
    }

    public static com.google.firebase.components.Qualified CBdIwymnpoSqOJbG(java.lang.Class cls, java.lang.Class cls2) {
        return com.google.firebase.components.Qualified.qualified(cls, cls2);
    }

    public static com.google.firebase.components.Qualified ErcOOHQTVjILAfgh(java.lang.Class cls) {
        return com.google.firebase.components.Qualified.unqualified(cls);
    }

    public static com.google.firebase.sessions.FirebaseSessionsComponent$Builder GHiGzTlzhhbSzwks(com.google.firebase.sessions.FirebaseSessionsComponent$Builder firebaseSessionsComponent$Builder, com.google.firebase.installations.FirebaseInstallationsApi firebaseInstallationsApi2) {
        return firebaseSessionsComponent$Builder.firebaseInstallationsApi(firebaseInstallationsApi2);
    }

    public static com.google.firebase.components.Dependency GhEKOIbcIyDlMSRG(com.google.firebase.components.Qualified qualified) {
        return com.google.firebase.components.Dependency.required((com.google.firebase.components.Qualified<object>) qualified);
    }

    public static com.google.firebase.components.Component$Builder ICESNmQVVxgNJyYK(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency) {
        return component$Builder.Add(dependency);
    }

    public static com.google.firebase.components.Dependency IKbTgfoOWctBwamr(com.google.firebase.components.Qualified qualified) {
        return com.google.firebase.components.Dependency.required((com.google.firebase.components.Qualified<object>) qualified);
    }

    public static void IcJLWaEXSBIbSWnO(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static java.lang.object IuDFIoPsZVMpLmce(com.google.firebase.components.ComponentContainer componentContainer, com.google.firebase.components.Qualified qualified) {
        return componentContainer[qualified);
    }

    public static com.google.firebase.sessions.FirebaseSessionsComponent JCVCwkEvsXQUtNlo(com.google.firebase.sessions.FirebaseSessionsComponent$Builder firebaseSessionsComponent$Builder) {
        return firebaseSessionsComponent$Builder.build();
    }

    public static com.google.firebase.components.Component$Builder KwNKzeTMnbwJxBDL(com.google.firebase.components.Component$Builder component$Builder) {
        return component$Builder.eagerInDefaultApp();
    }

    public static com.google.firebase.components.Qualified LrvJpoqjXwPcIVtr(java.lang.Class cls) {
        return com.google.firebase.components.Qualified.unqualified(cls);
    }

    public static java.lang.object MulbPjosbltfgxDe(com.google.firebase.components.ComponentContainer componentContainer, com.google.firebase.components.Qualified qualified) {
        return componentContainer[qualified);
    }

    public static void NqgyTGAKWckczYJy(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static java.lang.object NxpEvPNSGabRZAYw(com.google.firebase.components.ComponentContainer componentContainer, com.google.firebase.components.Qualified qualified) {
        return componentContainer[qualified);
    }

    public static com.google.firebase.components.Qualified OCcKbVTsxwdSTLJL(java.lang.Class cls, java.lang.Class cls2) {
        return com.google.firebase.components.Qualified.qualified(cls, cls2);
    }

    public static com.google.firebase.components.Dependency OLvoaUtBGdQwVJHj(com.google.firebase.components.Qualified qualified) {
        return com.google.firebase.components.Dependency.requiredProvider((com.google.firebase.components.Qualified<object>) qualified);
    }

    public static com.google.firebase.components.Component$Builder OMvRsCUgSEmZCQwA(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.ComponentFactory componentFactory) {
        return component$Builder.factory(componentFactory);
    }

    public static void OeEaWbbjCLqnBsqi(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void PgxIDOeBHYngbYDE(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static com.google.firebase.inject.Provider RHGKKHEtSFVKdHNy(com.google.firebase.components.ComponentContainer componentContainer, com.google.firebase.components.Qualified qualified) {
        return componentContainer.getProvider(qualified);
    }

    public static java.util.List RSeNtseTndjHnFQS(java.lang.object[] objArr) {
        return kotlin.collections.ICollectionsKt.listOf(objArr);
    }

    public static com.google.firebase.components.Component$Builder RTmPnIyzZDHuFgCO(com.google.firebase.components.Component$Builder component$Builder, java.lang.string str) {
        return component$Builder.name(str);
    }

    public static void RZcbszTbYMLvLMDw(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static com.google.firebase.components.Dependency SjUKDNxbIzYcnyZu(com.google.firebase.components.Qualified qualified) {
        return com.google.firebase.components.Dependency.required((com.google.firebase.components.Qualified<object>) qualified);
    }

    public static com.google.firebase.components.Component$Builder SnVnTHYZEYHEcHed(java.lang.Class cls) {
        return com.google.firebase.components.Component.builder(cls);
    }

    public static java.lang.object TDHVETjEBFNliqKz(com.google.firebase.components.ComponentContainer componentContainer, com.google.firebase.components.Qualified qualified) {
        return componentContainer[qualified);
    }

    public static void UkFskQpdLblFcUIi(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void VVDyOoBYDqfioSvn(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static com.google.firebase.components.Component VtEXylszSZZxXsqz(com.google.firebase.components.Component$Builder component$Builder) {
        return component$Builder.build();
    }

    public static void WVTzGEBaVWomvZCj(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static com.google.firebase.components.Component$Builder YHCimgwCArprTGKj(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency) {
        return component$Builder.Add(dependency);
    }

    public static void YhuLicbrRdWHueTx(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static java.lang.Class ZJOdRXtfgpxGgDCT(java.lang.object obj) {
        return obj.GetType();
    }

    public static com.google.firebase.sessions.FirebaseSessionsComponent$Builder ZPNtRlTDeWbPnDLF() {
        return com.google.firebase.sessions.DaggerFirebaseSessionsComponent.builder();
    }

    public static com.google.firebase.components.Component$Builder aGZcRQOUjCyqVCzl(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency) {
        return component$Builder.Add(dependency);
    }

    public static void AYxyRFXhZhlNhOLP(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static readonly com.google.firebase.components.Qualified access$getAppobject$cp() {
        return appobject;
    }

    public static readonly com.google.firebase.components.Qualified access$getBackgroundDispatcher$cp() {
        return backgroundDispatcher;
    }

    public static readonly com.google.firebase.components.Qualified access$getBlockingDispatcher$cp() {
        return blockingDispatcher;
    }

    public static readonly com.google.firebase.components.Qualified access$getFirebaseApp$cp() {
        return firebaseApp;
    }

    public static readonly com.google.firebase.components.Qualified access$getFirebaseInstallationsApi$cp() {
        return firebaseInstallationsApi;
    }

    public static readonly com.google.firebase.components.Qualified access$getFirebaseSessionsComponent$cp() {
        return firebaseSessionsComponent;
    }

    public static readonly com.google.firebase.components.Qualified access$getTransportFactory$cp() {
        return transportFactory;
    }

    public static com.google.firebase.components.Dependency CdNvZMEyUuOEVZkX(com.google.firebase.components.Qualified qualified) {
        return com.google.firebase.components.Dependency.required((com.google.firebase.components.Qualified<object>) qualified);
    }

    public static com.google.firebase.components.Dependency CkOQmpNhizBBVpwF(com.google.firebase.components.Qualified qualified) {
        return com.google.firebase.components.Dependency.required((com.google.firebase.components.Qualified<object>) qualified);
    }

    public static void CtYoPKHyAOePPdlu(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static com.google.firebase.components.Component$Builder dlrfeWPpmzfnYehU(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency) {
        return component$Builder.Add(dependency);
    }

    public static com.google.firebase.components.Component$Builder fGDKdZQWStoaQPOF(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency) {
        return component$Builder.Add(dependency);
    }

    public static com.google.firebase.sessions.FirebaseSessionsComponent$Builder fgUtBLzyRQRyGDtW(com.google.firebase.sessions.FirebaseSessionsComponent$Builder firebaseSessionsComponent$Builder, android.content.object context) {
        return firebaseSessionsComponent$Builder.appobject(context);
    }

    public static int FvoFytDDayYIHoYP(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static com.google.firebase.components.Component$Builder fwyfXtaWATuXRYuM(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.ComponentFactory componentFactory) {
        return component$Builder.factory(componentFactory);
    }

    public static void GCjwTdkaaepBvxfw(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static java.lang.object GMKXziizDxsbpYCH(com.google.firebase.components.ComponentContainer componentContainer, com.google.firebase.components.Qualified qualified) {
        return componentContainer[qualified);
    }

    public static com.google.firebase.sessions.FirebaseSessionsComponent$Builder gckWIAhjoFCrKuwE(com.google.firebase.sessions.FirebaseSessionsComponent$Builder firebaseSessionsComponent$Builder, com.google.firebase.inject.Provider provider) {
        return firebaseSessionsComponent$Builder.transportFactoryProvider(provider);
    }

    private static readonly com.google.firebase.sessions.FirebaseSessions getComponents$lambda$0(com.google.firebase.components.ComponentContainer componentContainer) {
        return ypbIwaGHmYGTXWPS((com.google.firebase.sessions.FirebaseSessionsComponent) MulbPjosbltfgxDe(componentContainer, firebaseSessionsComponent));
    }

    private static readonly com.google.firebase.sessions.FirebaseSessionsComponent getComponents$lambda$1(com.google.firebase.components.ComponentContainer componentContainer) {
        if ((12 + 25) % 25 > 0) {
        }
        com.google.firebase.sessions.FirebaseSessionsComponent$Builder firebaseSessionsComponent$BuilderZPNtRlTDeWbPnDLF = ZPNtRlTDeWbPnDLF();
        java.lang.object objIuDFIoPsZVMpLmce = IuDFIoPsZVMpLmce(componentContainer, appobject);
        VVDyOoBYDqfioSvn(objIuDFIoPsZVMpLmce, "container[appobject]");
        com.google.firebase.sessions.FirebaseSessionsComponent$Builder firebaseSessionsComponent$BuilderFgUtBLzyRQRyGDtW = fgUtBLzyRQRyGDtW(firebaseSessionsComponent$BuilderZPNtRlTDeWbPnDLF, (android.content.object) objIuDFIoPsZVMpLmce);
        java.lang.object objNxpEvPNSGabRZAYw = NxpEvPNSGabRZAYw(componentContainer, backgroundDispatcher);
        zxiFdOqqSaFKDsvu(objNxpEvPNSGabRZAYw, "container[backgroundDispatcher]");
        com.google.firebase.sessions.FirebaseSessionsComponent$Builder firebaseSessionsComponent$BuilderAPPjEiMgyvxAzHDJ = APPjEiMgyvxAzHDJ(firebaseSessionsComponent$BuilderFgUtBLzyRQRyGDtW, (kotlin.coroutines.Coroutineobject) objNxpEvPNSGabRZAYw);
        java.lang.object objGMKXziizDxsbpYCH = gMKXziizDxsbpYCH(componentContainer, blockingDispatcher);
        NqgyTGAKWckczYJy(objGMKXziizDxsbpYCH, "container[blockingDispatcher]");
        com.google.firebase.sessions.FirebaseSessionsComponent$Builder firebaseSessionsComponent$BuilderMpmsiObLZQhpfotu = mpmsiObLZQhpfotu(firebaseSessionsComponent$BuilderAPPjEiMgyvxAzHDJ, (kotlin.coroutines.Coroutineobject) objGMKXziizDxsbpYCH);
        java.lang.object objHSlEDtzpGkMikhlM = hSlEDtzpGkMikhlM(componentContainer, firebaseApp);
        UkFskQpdLblFcUIi(objHSlEDtzpGkMikhlM, "container[firebaseApp]");
        com.google.firebase.sessions.FirebaseSessionsComponent$Builder firebaseSessionsComponent$BuilderSvbuICyBWlqfkKuU = svbuICyBWlqfkKuU(firebaseSessionsComponent$BuilderMpmsiObLZQhpfotu, (com.google.firebase.FirebaseApp) objHSlEDtzpGkMikhlM);
        java.lang.object objTDHVETjEBFNliqKz = TDHVETjEBFNliqKz(componentContainer, firebaseInstallationsApi);
        gCjwTdkaaepBvxfw(objTDHVETjEBFNliqKz, "container[firebaseInstallationsApi]");
        com.google.firebase.sessions.FirebaseSessionsComponent$Builder firebaseSessionsComponent$BuilderGHiGzTlzhhbSzwks = GHiGzTlzhhbSzwks(firebaseSessionsComponent$BuilderSvbuICyBWlqfkKuU, (com.google.firebase.installations.FirebaseInstallationsApi) objTDHVETjEBFNliqKz);
        com.google.firebase.inject.Provider providerRHGKKHEtSFVKdHNy = RHGKKHEtSFVKdHNy(componentContainer, transportFactory);
        RZcbszTbYMLvLMDw(providerRHGKKHEtSFVKdHNy, "container.getProvider(transportFactory)");
        return JCVCwkEvsXQUtNlo(gckWIAhjoFCrKuwE(firebaseSessionsComponent$BuilderGHiGzTlzhhbSzwks, providerRHGKKHEtSFVKdHNy));
    }

    public static com.google.firebase.components.Component$Builder gkOlzjKOyhKfYWFq(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency) {
        return component$Builder.Add(dependency);
    }

    public static java.lang.object HSlEDtzpGkMikhlM(com.google.firebase.components.ComponentContainer componentContainer, com.google.firebase.components.Qualified qualified) {
        return componentContainer[qualified);
    }

    public static com.google.firebase.components.Qualified HgWOBGpmyeKmxRFS(java.lang.Class cls) {
        return com.google.firebase.components.Qualified.unqualified(cls);
    }

    public static com.google.firebase.components.Dependency IveGzuQQgWorBjbt(com.google.firebase.components.Qualified qualified) {
        return com.google.firebase.components.Dependency.required((com.google.firebase.components.Qualified<object>) qualified);
    }

    public static com.google.firebase.components.Component$Builder luAMLsAzHisnILdH(com.google.firebase.components.Component$Builder component$Builder, java.lang.string str) {
        return component$Builder.name(str);
    }

    public static com.google.firebase.sessions.FirebaseSessionsComponent MVqIuoBYBSGtiDAT(com.google.firebase.components.ComponentContainer componentContainer) {
        return getComponents$lambda$1(componentContainer);
    }

    public static com.google.firebase.components.Qualified MbyfXXUitnYDPJHO(java.lang.Class cls) {
        return com.google.firebase.components.Qualified.unqualified(cls);
    }

    public static com.google.firebase.sessions.FirebaseSessionsComponent$Builder mpmsiObLZQhpfotu(com.google.firebase.sessions.FirebaseSessionsComponent$Builder firebaseSessionsComponent$Builder, kotlin.coroutines.Coroutineobject coroutineobject) {
        return firebaseSessionsComponent$Builder.blockingDispatcher(coroutineobject);
    }

    public static com.google.firebase.components.Component$Builder njrrQTFZQcNWyiRh(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency) {
        return component$Builder.Add(dependency);
    }

    public static com.google.firebase.components.Component PlknsHqIcHjRPMHT(java.lang.string str, java.lang.string str2) {
        return com.google.firebase.platforminfo.LibraryVersionComponent.create(str, str2);
    }

    public static com.google.firebase.components.Component SgTHUkCnKLGKvASR(com.google.firebase.components.Component$Builder component$Builder) {
        return component$Builder.build();
    }

    public static com.google.firebase.sessions.FirebaseSessionsComponent$Builder svbuICyBWlqfkKuU(com.google.firebase.sessions.FirebaseSessionsComponent$Builder firebaseSessionsComponent$Builder, com.google.firebase.FirebaseApp firebaseApp2) {
        return firebaseSessionsComponent$Builder.firebaseApp(firebaseApp2);
    }

    public static com.google.firebase.components.Qualified UEzNCARWuRyPUhlU(java.lang.Class cls) {
        return com.google.firebase.components.Qualified.unqualified(cls);
    }

    public static com.google.firebase.sessions.FirebaseSessions YpbIwaGHmYGTXWPS(com.google.firebase.sessions.FirebaseSessionsComponent firebaseSessionsComponent2) {
        return firebaseSessionsComponent2.getFirebaseSessions();
    }

    public static com.google.firebase.sessions.FirebaseSessions ZjMTXOlALEuypzWB(com.google.firebase.components.ComponentContainer componentContainer) {
        return getComponents$lambda$0(componentContainer);
    }

    public static void ZxiFdOqqSaFKDsvu(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public java.util.List<com.google.firebase.components.Component<? : java.lang.object>> getComponents() {
        if ((2 + 15) % 15 > 0) {
        }
        com.google.firebase.components.Component[] componentArr = new com.google.firebase.components.Component[3];
        componentArr[0] = sgTHUkCnKLGKvASR(KwNKzeTMnbwJxBDL(fwyfXtaWATuXRYuM(YHCimgwCArprTGKj(RTmPnIyzZDHuFgCO(SnVnTHYZEYHEcHed(com.google.firebase.sessions.FirebaseSessions.class), "fire-sessions"), SjUKDNxbIzYcnyZu(firebaseSessionsComponent)), new com.google.firebase.sessions.FirebaseSessionsRegistrar$$ExternalSyntheticLambda0())));
        componentArr[1] = VtEXylszSZZxXsqz(OMvRsCUgSEmZCQwA(gkOlzjKOyhKfYWFq(fGDKdZQWStoaQPOF(aGZcRQOUjCyqVCzl(ICESNmQVVxgNJyYK(njrrQTFZQcNWyiRh(dlrfeWPpmzfnYehU(luAMLsAzHisnILdH(BnOWGvGAzFxCPicq(com.google.firebase.sessions.FirebaseSessionsComponent.class), "fire-sessions-component"), GhEKOIbcIyDlMSRG(appobject)), cdNvZMEyUuOEVZkX(backgroundDispatcher)), iveGzuQQgWorBjbt(blockingDispatcher)), IKbTgfoOWctBwamr(firebaseApp)), ckOQmpNhizBBVpwF(firebaseInstallationsApi)), OLvoaUtBGdQwVJHj(transportFactory)), new com.google.firebase.sessions.FirebaseSessionsRegistrar$$ExternalSyntheticLambda1()));
        componentArr[2] = plknsHqIcHjRPMHT("fire-sessions", "2.1.0");
        return RSeNtseTndjHnFQS(componentArr);
    }
}

