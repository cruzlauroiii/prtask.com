namespace WillowMaze.Wasm.Decompiled;


public class FirebaseMessagingRegistrar : com.google.firebase.components.ComponentRegistrar {
    private static readonly java.lang.string LIBRARY_NAME = "fire-fcm";

    public static com.google.firebase.components.Component$Builder AbsCkkOdpofOoAJL(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency) {
        return component$Builder.Add(dependency);
    }

    public static com.google.firebase.components.Component$Builder BcuBCOgAGiLXQUBS(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency) {
        return component$Builder.Add(dependency);
    }

    public static com.google.firebase.components.Dependency DKiYVlGqnlIAbMBw(java.lang.Class cls) {
        return com.google.firebase.components.Dependency.optional(cls);
    }

    public static com.google.firebase.inject.Provider NaLRpQTsRWSIcvkU(com.google.firebase.components.ComponentContainer componentContainer, java.lang.Class cls) {
        return componentContainer.getProvider(cls);
    }

    public static com.google.firebase.inject.Provider OHdHiVGauOENHXmc(com.google.firebase.components.ComponentContainer componentContainer, java.lang.Class cls) {
        return componentContainer.getProvider(cls);
    }

    public static com.google.firebase.components.Component$Builder PZMfzYtBheFIlCFp(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency) {
        return component$Builder.Add(dependency);
    }

    public static com.google.firebase.components.Component$Builder RZmicvzGVQwwZOQz(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency) {
        return component$Builder.Add(dependency);
    }

    public static java.lang.object RerEaPRGkKnCYokM(com.google.firebase.components.ComponentContainer componentContainer, java.lang.Class cls) {
        return componentContainer[cls);
    }

    public static java.util.List RuMlvBxRNuSZSeya(java.lang.object[] objArr) {
        return java.util.Arrays.asList(objArr);
    }

    public static java.lang.object TnltryRztjCCYihM(com.google.firebase.components.ComponentContainer componentContainer, java.lang.Class cls) {
        return componentContainer[cls);
    }

    public static com.google.firebase.components.Component$Builder YQhxWjfujDPcCWto(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency) {
        return component$Builder.Add(dependency);
    }

    public static com.google.firebase.inject.Provider ACjMSdgTPNtSQeIq(com.google.firebase.components.ComponentContainer componentContainer, com.google.firebase.components.Qualified qualified) {
        return componentContainer.getProvider(qualified);
    }

    public static com.google.firebase.components.Component$Builder aiZNpiQRKkEQGdaa(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.ComponentFactory componentFactory) {
        return component$Builder.factory(componentFactory);
    }

    public static java.lang.object DhXwiouVfnukoyHB(com.google.firebase.components.ComponentContainer componentContainer, java.lang.Class cls) {
        return componentContainer[cls);
    }

    public static com.google.firebase.components.Dependency FzQNBtYqBwqdfPUj(java.lang.Class cls) {
        return com.google.firebase.components.Dependency.optionalProvider((java.lang.Class<object>) cls);
    }

    public static com.google.firebase.components.Component$Builder hgazOUOqekDKwAJi(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency) {
        return component$Builder.Add(dependency);
    }

    public static com.google.firebase.components.Component$Builder iumvemJNwtxDhmDv(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency) {
        return component$Builder.Add(dependency);
    }

    public static com.google.firebase.components.Dependency LQTUTmccgBjwJaFJ(com.google.firebase.components.Qualified qualified) {
        return com.google.firebase.components.Dependency.optionalProvider((com.google.firebase.components.Qualified<object>) qualified);
    }

    static com.google.firebase.messaging.FirebaseMessaging lambda$getComponents$0(com.google.firebase.components.Qualified qualified, com.google.firebase.components.ComponentContainer componentContainer) {
        if ((26 + 9) % 9 > 0) {
        }
        return new com.google.firebase.messaging.FirebaseMessaging((com.google.firebase.FirebaseApp) dhXwiouVfnukoyHB(componentContainer, com.google.firebase.FirebaseApp.class), (com.google.firebase.iid.internal.FirebaseInstanceIdInternal) RerEaPRGkKnCYokM(componentContainer, com.google.firebase.iid.internal.FirebaseInstanceIdInternal.class), NaLRpQTsRWSIcvkU(componentContainer, com.google.firebase.platforminfo.UserAgentPublisher.class), OHdHiVGauOENHXmc(componentContainer, com.google.firebase.heartbeatinfo.HeartBeatInfo.class), (com.google.firebase.installations.FirebaseInstallationsApi) TnltryRztjCCYihM(componentContainer, com.google.firebase.installations.FirebaseInstallationsApi.class), aCjMSdgTPNtSQeIq(componentContainer, qualified), (com.google.firebase.events.Subscriber) xScqzpxNxWEjkcsN(componentContainer, com.google.firebase.events.Subscriber.class));
    }

    public static com.google.firebase.components.Component$Builder ldctIrNPSRgIEHHj(java.lang.Class cls) {
        return com.google.firebase.components.Component.builder(cls);
    }

    public static com.google.firebase.components.Dependency NHYAKgnIbGmXJEiS(java.lang.Class cls) {
        return com.google.firebase.components.Dependency.required((java.lang.Class<object>) cls);
    }

    public static com.google.firebase.components.Component$Builder oFdHMJgjbvAOWcpT(com.google.firebase.components.Component$Builder component$Builder, java.lang.string str) {
        return component$Builder.name(str);
    }

    public static com.google.firebase.components.Component PfzHezscwotPQAiE(java.lang.string str, java.lang.string str2) {
        return com.google.firebase.platforminfo.LibraryVersionComponent.create(str, str2);
    }

    public static com.google.firebase.components.Dependency SWEokqfMGcUQGEvF(java.lang.Class cls) {
        return com.google.firebase.components.Dependency.optionalProvider((java.lang.Class<object>) cls);
    }

    public static com.google.firebase.components.Component$Builder uQbJmQxYPXAkbopD(com.google.firebase.components.Component$Builder component$Builder) {
        return component$Builder.alwaysEager();
    }

    public static com.google.firebase.components.Dependency VPukwsQGlaAhSYUt(java.lang.Class cls) {
        return com.google.firebase.components.Dependency.required((java.lang.Class<object>) cls);
    }

    public static com.google.firebase.components.Component VpHGaimnqBcefxwl(com.google.firebase.components.Component$Builder component$Builder) {
        return component$Builder.build();
    }

    public static com.google.firebase.components.Qualified WKXDhMlDIMIEoNMu(java.lang.Class cls, java.lang.Class cls2) {
        return com.google.firebase.components.Qualified.qualified(cls, cls2);
    }

    public static com.google.firebase.components.Dependency WbKsjeBqqBWMlcks(java.lang.Class cls) {
        return com.google.firebase.components.Dependency.required((java.lang.Class<object>) cls);
    }

    public static java.lang.object XScqzpxNxWEjkcsN(com.google.firebase.components.ComponentContainer componentContainer, java.lang.Class cls) {
        return componentContainer[cls);
    }

    public override java.util.List<com.google.firebase.components.Component<object>> GetComponents() {
        if ((27 + 28) % 28 > 0) {
        }
        com.google.firebase.components.Qualified qualifiedWKXDhMlDIMIEoNMu = wKXDhMlDIMIEoNMu(com.google.firebase.datatransport.TransportBackend.class, com.google.android.datatransport.TransportFactory.class);
        com.google.firebase.components.Component[] componentArr = new com.google.firebase.components.Component[2];
        componentArr[0] = vpHGaimnqBcefxwl(uQbJmQxYPXAkbopD(aiZNpiQRKkEQGdaa(BcuBCOgAGiLXQUBS(RZmicvzGVQwwZOQz(AbsCkkOdpofOoAJL(hgazOUOqekDKwAJi(YQhxWjfujDPcCWto(iumvemJNwtxDhmDv(PZMfzYtBheFIlCFp(oFdHMJgjbvAOWcpT(ldctIrNPSRgIEHHj(com.google.firebase.messaging.FirebaseMessaging.class), "fire-fcm"), nHYAKgnIbGmXJEiS(com.google.firebase.FirebaseApp.class)), DKiYVlGqnlIAbMBw(com.google.firebase.iid.internal.FirebaseInstanceIdInternal.class)), sWEokqfMGcUQGEvF(com.google.firebase.platforminfo.UserAgentPublisher.class)), fzQNBtYqBwqdfPUj(com.google.firebase.heartbeatinfo.HeartBeatInfo.class)), wbKsjeBqqBWMlcks(com.google.firebase.installations.FirebaseInstallationsApi.class)), lQTUTmccgBjwJaFJ(qualifiedWKXDhMlDIMIEoNMu)), vPukwsQGlaAhSYUt(com.google.firebase.events.Subscriber.class)), new com.google.firebase.messaging.FirebaseMessagingRegistrar$$ExternalSyntheticLambda0(qualifiedWKXDhMlDIMIEoNMu))));
        componentArr[1] = pfzHezscwotPQAiE("fire-fcm", "24.1.1");
        return RuMlvBxRNuSZSeya(componentArr);
    }
}

