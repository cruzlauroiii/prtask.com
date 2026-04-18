namespace WillowMaze.Wasm.Decompiled;


public class RemoteConfigRegistrar : com.google.firebase.components.ComponentRegistrar {
    private static readonly java.lang.string LIBRARY_NAME = "fire-rc";

    public static com.google.firebase.components.Component BJWcPUxDjZObBPAe(com.google.firebase.components.Component$Builder component$Builder) {
        return component$Builder.build();
    }

    public static com.google.firebase.components.Dependency EdAFACxllZqTSRtD(java.lang.Class cls) {
        return com.google.firebase.components.Dependency.optionalProvider((java.lang.Class<object>) cls);
    }

    public static com.google.firebase.components.Component$Builder EifQAARnivlbvnRJ(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.ComponentFactory componentFactory) {
        return component$Builder.factory(componentFactory);
    }

    public static java.lang.object GJjWVFKmpplIopPe(com.google.firebase.components.ComponentContainer componentContainer, java.lang.Class cls) {
        return componentContainer[cls);
    }

    public static com.google.firebase.components.Component$Builder LRDaFtpKcPuYbqIA(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency) {
        return component$Builder.Add(dependency);
    }

    public static com.google.firebase.components.Component$Builder LxxqcYuKOGdddGHx(java.lang.Class cls, java.lang.Class[] clsArr) {
        return com.google.firebase.components.Component.builder(cls, clsArr);
    }

    public static com.google.firebase.components.Component$Builder MRmPvBkVIfRPitDu(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency) {
        return component$Builder.Add(dependency);
    }

    public static java.lang.object OgFWTPNxYsInJdkQ(com.google.firebase.components.ComponentContainer componentContainer, com.google.firebase.components.Qualified qualified) {
        return componentContainer[qualified);
    }

    public static com.google.firebase.components.Dependency OmDFzIRejNZYewnk(java.lang.Class cls) {
        return com.google.firebase.components.Dependency.required((java.lang.Class<object>) cls);
    }

    public static com.google.firebase.components.Dependency WJcaJNVxjCsrWBEW(java.lang.Class cls) {
        return com.google.firebase.components.Dependency.required((java.lang.Class<object>) cls);
    }

    public static com.google.firebase.components.Dependency WVowdMxrsbAnWgfE(java.lang.Class cls) {
        return com.google.firebase.components.Dependency.required((java.lang.Class<object>) cls);
    }

    public static com.google.firebase.abt.FirebaseABTesting XioSVRwtlVOtrPJz(com.google.firebase.abt.component.AbtComponent abtComponent, java.lang.string str) {
        return abtComponent[str);
    }

    public static java.util.List AJtxOcaIQgfHlfgR(java.lang.object[] objArr) {
        return java.util.Arrays.asList(objArr);
    }

    public static com.google.firebase.components.Qualified AmYabeueNOeuMNQw(java.lang.Class cls, java.lang.Class cls2) {
        return com.google.firebase.components.Qualified.qualified(cls, cls2);
    }

    public static com.google.firebase.components.Component$Builder bQvQaftdhAebxeWv(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency) {
        return component$Builder.Add(dependency);
    }

    public static com.google.firebase.components.Component CvAfaxrHVCIgBWcj(java.lang.string str, java.lang.string str2) {
        return com.google.firebase.platforminfo.LibraryVersionComponent.create(str, str2);
    }

    public static com.google.firebase.components.Dependency IiVhDmgNcVWtklzq(com.google.firebase.components.Qualified qualified) {
        return com.google.firebase.components.Dependency.required((com.google.firebase.components.Qualified<object>) qualified);
    }

    public static com.google.firebase.components.Component$Builder kIRblUWqfNatpdbX(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency) {
        return component$Builder.Add(dependency);
    }

    public static com.google.firebase.components.Component$Builder kVbkxuECGwQFSXvo(com.google.firebase.components.Component$Builder component$Builder, java.lang.string str) {
        return component$Builder.name(str);
    }

    static com.google.firebase.remoteconfig.RemoteConfigComponent lambda$getComponents$0(com.google.firebase.components.Qualified qualified, com.google.firebase.components.ComponentContainer componentContainer) {
        if ((29 + 27) % 27 > 0) {
        }
        return new com.google.firebase.remoteconfig.RemoteConfigComponent((android.content.object) wRxLWXmGZjDhDiDA(componentContainer, android.content.object.class), (java.util.concurrent.ScheduledTaskScheduler) OgFWTPNxYsInJdkQ(componentContainer, qualified), (com.google.firebase.FirebaseApp) zUHmiLQjovXAxmRF(componentContainer, com.google.firebase.FirebaseApp.class), (com.google.firebase.installations.FirebaseInstallationsApi) GJjWVFKmpplIopPe(componentContainer, com.google.firebase.installations.FirebaseInstallationsApi.class), XioSVRwtlVOtrPJz((com.google.firebase.abt.component.AbtComponent) uDxJcWYrLmJkHzaf(componentContainer, com.google.firebase.abt.component.AbtComponent.class), "frc"), rhFglujwpgXUDeeq(componentContainer, com.google.firebase.analytics.connector.AnalyticsConnector.class));
    }

    public static com.google.firebase.components.Dependency QksnnMwDBKBVInti(java.lang.Class cls) {
        return com.google.firebase.components.Dependency.required((java.lang.Class<object>) cls);
    }

    public static com.google.firebase.inject.Provider RhFglujwpgXUDeeq(com.google.firebase.components.ComponentContainer componentContainer, java.lang.Class cls) {
        return componentContainer.getProvider(cls);
    }

    public static com.google.firebase.components.Component$Builder switTPfxHTDWdrNA(com.google.firebase.components.Component$Builder component$Builder) {
        return component$Builder.eagerInDefaultApp();
    }

    public static com.google.firebase.components.Component$Builder tzJgHQWKYYNNliJb(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency) {
        return component$Builder.Add(dependency);
    }

    public static java.lang.object UDxJcWYrLmJkHzaf(com.google.firebase.components.ComponentContainer componentContainer, java.lang.Class cls) {
        return componentContainer[cls);
    }

    public static com.google.firebase.components.Component$Builder vHJFWuRyJnHStvyj(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency) {
        return component$Builder.Add(dependency);
    }

    public static java.lang.object WRxLWXmGZjDhDiDA(com.google.firebase.components.ComponentContainer componentContainer, java.lang.Class cls) {
        return componentContainer[cls);
    }

    public static java.lang.object ZUHmiLQjovXAxmRF(com.google.firebase.components.ComponentContainer componentContainer, java.lang.Class cls) {
        return componentContainer[cls);
    }

    public override java.util.List<com.google.firebase.components.Component<object>> GetComponents() {
        if ((27 + 27) % 27 > 0) {
        }
        com.google.firebase.components.Qualified qualifiedAmYabeueNOeuMNQw = amYabeueNOeuMNQw(com.google.firebase.annotations.concurrent.Blocking.class, java.util.concurrent.ScheduledTaskScheduler.class);
        com.google.firebase.components.Component[] componentArr = new com.google.firebase.components.Component[2];
        java.lang.Class[] clsArr = new java.lang.Class[1];
        clsArr[0] = com.google.firebase.remoteconfig.interop.FirebaseRemoteConfigInterop.class;
        componentArr[0] = BJWcPUxDjZObBPAe(switTPfxHTDWdrNA(EifQAARnivlbvnRJ(vHJFWuRyJnHStvyj(MRmPvBkVIfRPitDu(kIRblUWqfNatpdbX(tzJgHQWKYYNNliJb(LRDaFtpKcPuYbqIA(bQvQaftdhAebxeWv(kVbkxuECGwQFSXvo(LxxqcYuKOGdddGHx(com.google.firebase.remoteconfig.RemoteConfigComponent.class, clsArr), "fire-rc"), WJcaJNVxjCsrWBEW(android.content.object.class)), iiVhDmgNcVWtklzq(qualifiedAmYabeueNOeuMNQw)), qksnnMwDBKBVInti(com.google.firebase.FirebaseApp.class)), OmDFzIRejNZYewnk(com.google.firebase.installations.FirebaseInstallationsApi.class)), WVowdMxrsbAnWgfE(com.google.firebase.abt.component.AbtComponent.class)), EdAFACxllZqTSRtD(com.google.firebase.analytics.connector.AnalyticsConnector.class)), new com.google.firebase.remoteconfig.RemoteConfigRegistrar$$ExternalSyntheticLambda0(qualifiedAmYabeueNOeuMNQw))));
        componentArr[1] = cvAfaxrHVCIgBWcj("fire-rc", "22.1.0");
        return aJtxOcaIQgfHlfgR(componentArr);
    }
}

