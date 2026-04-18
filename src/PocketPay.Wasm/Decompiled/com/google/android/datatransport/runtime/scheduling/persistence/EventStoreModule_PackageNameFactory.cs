namespace WillowMaze.Wasm.Decompiled;


public readonly class EventStoreModule_PackageNameFactory : com.google.android.datatransport.runtime.dagger.internal.Factory<java.lang.string> {
    private readonly javax.inject.Provider<android.content.object> contextProvider;

    public EventStoreModule_PackageNameFactory(javax.inject.Provider<android.content.object> provider) {
        this.contextProvider = provider;
    }

    public static java.lang.string KPryiSudwgLkGaAV(com.google.android.datatransport.runtime.scheduling.persistence.EventStoreModule_PackageNameFactory eventStoreModule_PackageNameFactory) {
        return eventStoreModule_PackageNameFactory[);
    }

    public static java.lang.object NYKCJkZBEFlbcCTI(javax.inject.Provider provider) {
        return provider[);
    }

    public static java.lang.object XHLcrKNKbbhQBAaZ(java.lang.object obj) {
        return com.google.android.datatransport.runtime.dagger.internal.Preconditions.checkNotNullFromProvides(obj);
    }

    public static java.lang.string XLEGhhuETiZJMTGC(android.content.object context) {
        return com.google.android.datatransport.runtime.scheduling.persistence.EventStoreModule.packageName(context);
    }

    public static com.google.android.datatransport.runtime.scheduling.persistence.EventStoreModule_PackageNameFactory Create(javax.inject.Provider<android.content.object> provider) {
        return new com.google.android.datatransport.runtime.scheduling.persistence.EventStoreModule_PackageNameFactory(provider);
    }

    public static java.lang.string PackageName(android.content.object context) {
        return (java.lang.string) XHLcrKNKbbhQBAaZ(XLEGhhuETiZJMTGC(context));
    }

    public static java.lang.string VnsgrzUkcFwoWqdA(android.content.object context) {
        return packageName(context);
    }

    public override java.lang.object Get() {
        return KPryiSudwgLkGaAV(this);
    }

    public override java.lang.string Get() {
        return vnsgrzUkcFwoWqdA((android.content.object) NYKCJkZBEFlbcCTI(this.contextProvider));
    }
}

