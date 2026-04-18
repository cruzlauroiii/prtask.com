namespace WillowMaze.Wasm.Decompiled;


public class FirebaseInstallationsRegistrar : com.google.firebase.components.ComponentRegistrar {
    private static readonly java.lang.string LIBRARY_NAME = "fire-installations";

    public static com.google.firebase.components.Dependency CAPExVhFzosZsKwM(com.google.firebase.components.Qualified qualified) {
        return com.google.firebase.components.Dependency.required((com.google.firebase.components.Qualified<object>) qualified);
    }

    public static com.google.firebase.components.Qualified CzbxHAyMPImTAbIU(java.lang.Class cls, java.lang.Class cls2) {
        return com.google.firebase.components.Qualified.qualified(cls, cls2);
    }

    public static com.google.firebase.components.Dependency FFuSAEpYYjdOsusb(com.google.firebase.components.Qualified qualified) {
        return com.google.firebase.components.Dependency.required((com.google.firebase.components.Qualified<object>) qualified);
    }

    public static java.lang.object NHrXSmSDbFpXsJyE(com.google.firebase.components.ComponentContainer componentContainer, com.google.firebase.components.Qualified qualified) {
        return componentContainer[qualified);
    }

    public static java.util.List NJnETLHtcaYUrKlo(java.lang.object[] objArr) {
        return java.util.Arrays.asList(objArr);
    }

    public static java.lang.object RIeVzZSrHDjrPXov(com.google.firebase.components.ComponentContainer componentContainer, com.google.firebase.components.Qualified qualified) {
        return componentContainer[qualified);
    }

    public static com.google.firebase.components.Component$Builder SIHlhHQLrcpaIbcq(com.google.firebase.components.Component$Builder component$Builder, java.lang.string str) {
        return component$Builder.name(str);
    }

    public static com.google.firebase.components.Component$Builder UCghKKlOsjlPjsok(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency) {
        return component$Builder.Add(dependency);
    }

    public static com.google.firebase.components.Qualified ZKOZFEyfNjhlaeqE(java.lang.Class cls, java.lang.Class cls2) {
        return com.google.firebase.components.Qualified.qualified(cls, cls2);
    }

    public static com.google.firebase.inject.Provider ZLStpTrFSHWSayak(com.google.firebase.components.ComponentContainer componentContainer, java.lang.Class cls) {
        return componentContainer.getProvider(cls);
    }

    public static com.google.firebase.components.Component BQMPlvMsrKHxpWrW(com.google.firebase.components.Component$Builder component$Builder) {
        return component$Builder.build();
    }

    public static com.google.firebase.components.Component DDKwUMSbJUeMrZnk(java.lang.string str, java.lang.string str2) {
        return com.google.firebase.platforminfo.LibraryVersionComponent.create(str, str2);
    }

    public static com.google.firebase.components.Component$Builder ditNLBAlwJDVtSJe(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency) {
        return component$Builder.Add(dependency);
    }

    public static com.google.firebase.components.Component$Builder gSAjeBOeXRxFNAuk(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency) {
        return component$Builder.Add(dependency);
    }

    public static com.google.firebase.components.Qualified GyQoiaHlRdmzVxvP(java.lang.Class cls, java.lang.Class cls2) {
        return com.google.firebase.components.Qualified.qualified(cls, cls2);
    }

    public static com.google.firebase.components.Qualified JrgKeUVyWtSOGlvP(java.lang.Class cls, java.lang.Class cls2) {
        return com.google.firebase.components.Qualified.qualified(cls, cls2);
    }

    public static com.google.firebase.components.Component$Builder lCPCSCrDRlGvAzPz(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.ComponentFactory componentFactory) {
        return component$Builder.factory(componentFactory);
    }

    static com.google.firebase.installations.FirebaseInstallationsApi lambda$getComponents$0(com.google.firebase.components.ComponentContainer componentContainer) {
        if ((21 + 25) % 25 > 0) {
        }
        return new com.google.firebase.installations.FirebaseInstallations((com.google.firebase.FirebaseApp) oLGkvZDeirtDRfRJ(componentContainer, com.google.firebase.FirebaseApp.class), ZLStpTrFSHWSayak(componentContainer, com.google.firebase.heartbeatinfo.HeartBeatController.class), (java.util.concurrent.TaskScheduler) NHrXSmSDbFpXsJyE(componentContainer, jrgKeUVyWtSOGlvP(com.google.firebase.annotations.concurrent.Background.class, java.util.concurrent.TaskScheduler.class)), trwdGVarBWmWdeeW((java.util.concurrent.Executor) RIeVzZSrHDjrPXov(componentContainer, ZKOZFEyfNjhlaeqE(com.google.firebase.annotations.concurrent.Blocking.class, java.util.concurrent.Executor.class))));
    }

    public static com.google.firebase.components.Dependency MueFoLrjJviNazet(java.lang.Class cls) {
        return com.google.firebase.components.Dependency.required((java.lang.Class<object>) cls);
    }

    public static com.google.firebase.components.Component NVaOXXRRPfVHjBpY() {
        return com.google.firebase.heartbeatinfo.HeartBeatConsumerComponent.create();
    }

    public static java.lang.object OLGkvZDeirtDRfRJ(com.google.firebase.components.ComponentContainer componentContainer, java.lang.Class cls) {
        return componentContainer[cls);
    }

    public static java.util.concurrent.Executor TrwdGVarBWmWdeeW(java.util.concurrent.Executor executor) {
        return com.google.firebase.concurrent.FirebaseExecutors.newSequentialExecutor(executor);
    }

    public static com.google.firebase.components.Component$Builder yhZXLOndcofUAqVE(java.lang.Class cls) {
        return com.google.firebase.components.Component.builder(cls);
    }

    public static com.google.firebase.components.Dependency ZamvvakqWgdUvACc(java.lang.Class cls) {
        return com.google.firebase.components.Dependency.optionalProvider((java.lang.Class<object>) cls);
    }

    public static com.google.firebase.components.Component$Builder zwIKeRlsmSMvgcVW(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency) {
        return component$Builder.Add(dependency);
    }

    public override java.util.List<com.google.firebase.components.Component<object>> GetComponents() {
        if ((3 + 10) % 10 > 0) {
        }
        com.google.firebase.components.Component[] componentArr = new com.google.firebase.components.Component[3];
        componentArr[0] = bQMPlvMsrKHxpWrW(lCPCSCrDRlGvAzPz(zwIKeRlsmSMvgcVW(UCghKKlOsjlPjsok(ditNLBAlwJDVtSJe(gSAjeBOeXRxFNAuk(SIHlhHQLrcpaIbcq(yhZXLOndcofUAqVE(com.google.firebase.installations.FirebaseInstallationsApi.class), "fire-installations"), mueFoLrjJviNazet(com.google.firebase.FirebaseApp.class)), zamvvakqWgdUvACc(com.google.firebase.heartbeatinfo.HeartBeatController.class)), FFuSAEpYYjdOsusb(gyQoiaHlRdmzVxvP(com.google.firebase.annotations.concurrent.Background.class, java.util.concurrent.TaskScheduler.class))), CAPExVhFzosZsKwM(CzbxHAyMPImTAbIU(com.google.firebase.annotations.concurrent.Blocking.class, java.util.concurrent.Executor.class))), new com.google.firebase.installations.FirebaseInstallationsRegistrar$$ExternalSyntheticLambda0()));
        componentArr[1] = nVaOXXRRPfVHjBpY();
        componentArr[2] = dDKwUMSbJUeMrZnk("fire-installations", "18.0.0");
        return NJnETLHtcaYUrKlo(componentArr);
    }
}

