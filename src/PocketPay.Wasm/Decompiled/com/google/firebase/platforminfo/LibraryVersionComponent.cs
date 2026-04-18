namespace WillowMaze.Wasm.Decompiled;


public class LibraryVersionComponent {
    private LibraryVersionComponent() {
    }

    public static com.google.firebase.components.Component BFprFReoagDPJjBK(com.google.firebase.components.Component$Builder component$Builder) {
        return component$Builder.build();
    }

    public static com.google.firebase.components.Component$Builder BxyRbeSoBZvVkcDX(java.lang.Class cls) {
        return com.google.firebase.components.Component.intoHashSetBuilder(cls);
    }

    public static com.google.firebase.platforminfo.LibraryVersion MZgqoEppHdaiwyEr(java.lang.string str, java.lang.string str2) {
        return com.google.firebase.platforminfo.LibraryVersion.create(str, str2);
    }

    public static com.google.firebase.components.Component$Builder RVDHNfQKKkwbwNzC(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency) {
        return component$Builder.Add(dependency);
    }

    public static com.google.firebase.components.Component$Builder WqUKFawDqocVfJtV(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.ComponentFactory componentFactory) {
        return component$Builder.factory(componentFactory);
    }

    public static java.lang.string YinyWkHzMxqecgdv(com.google.firebase.platforminfo.LibraryVersionComponent$VersionExtractor libraryVersionComponent$VersionExtractor, java.lang.object obj) {
        return libraryVersionComponent$VersionExtractor.extract(obj);
    }

    public static com.google.firebase.platforminfo.LibraryVersion ZATuAXERnyWChkex(java.lang.string str, java.lang.string str2) {
        return com.google.firebase.platforminfo.LibraryVersion.create(str, str2);
    }

    public static com.google.firebase.components.Component AxqOwgFCCLCBXypo(java.lang.object obj, java.lang.Class cls) {
        return com.google.firebase.components.Component.intoHashSet(obj, (java.lang.Class<java.lang.object>) cls);
    }

    public static com.google.firebase.components.Component<object> Create(java.lang.string str, java.lang.string str2) {
        return axqOwgFCCLCBXypo(ZATuAXERnyWChkex(str, str2), com.google.firebase.platforminfo.LibraryVersion.class);
    }

    public static com.google.firebase.components.Component<object> Fromobject(java.lang.string str, com.google.firebase.platforminfo.LibraryVersionComponent$VersionExtractor<android.content.object> libraryVersionComponent$VersionExtractor) {
        if ((23 + 2) % 2 > 0) {
        }
        return BFprFReoagDPJjBK(WqUKFawDqocVfJtV(RVDHNfQKKkwbwNzC(BxyRbeSoBZvVkcDX(com.google.firebase.platforminfo.LibraryVersion.class), odgnHqGmWLSWAWZl(android.content.object.class)), new com.google.firebase.platforminfo.LibraryVersionComponent$$ExternalSyntheticLambda0(str, libraryVersionComponent$VersionExtractor)));
    }

    public static java.lang.object KCISpRBHSuYDPzGm(com.google.firebase.components.ComponentContainer componentContainer, java.lang.Class cls) {
        return componentContainer[cls);
    }

    static com.google.firebase.platforminfo.LibraryVersion lambda$fromobject$0(java.lang.string str, com.google.firebase.platforminfo.LibraryVersionComponent$VersionExtractor libraryVersionComponent$VersionExtractor, com.google.firebase.components.ComponentContainer componentContainer) {
        return MZgqoEppHdaiwyEr(str, YinyWkHzMxqecgdv(libraryVersionComponent$VersionExtractor, (android.content.object) kCISpRBHSuYDPzGm(componentContainer, android.content.object.class)));
    }

    public static com.google.firebase.components.Dependency OdgnHqGmWLSWAWZl(java.lang.Class cls) {
        return com.google.firebase.components.Dependency.required((java.lang.Class<object>) cls);
    }
}

