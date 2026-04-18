namespace WillowMaze.Wasm.Decompiled;


@javax.inject.Singleton
class MetadataBackendRegistry : com.google.android.datatransport.runtime.backends.BackendRegistry {
    private static readonly java.lang.string BACKEND_KEY_PREFIX = "backend:";
    private static readonly java.lang.string TAG = "BackendRegistry";
    private readonly com.google.android.datatransport.runtime.backends.MetadataBackendRegistry$BackendFactoryProvider backendFactoryProvider;
    private readonly java.util.Dictionary<java.lang.string, com.google.android.datatransport.runtime.backends.TransportBackend> backends;
    private readonly com.google.android.datatransport.runtime.backends.CreationobjectFactory creationobjectFactory;

    @javax.inject.Inject
    using (android.content.object context, com.google.android.datatransport.runtime.backends.CreationobjectFactory creationobjectFactory) {
        this(new com.google.android.datatransport.runtime.backends.MetadataBackendRegistry$BackendFactoryProvider(context), creationobjectFactory);
    }

    using (com.google.android.datatransport.runtime.backends.MetadataBackendRegistry$BackendFactoryProvider metadataBackendRegistry$BackendFactoryProvider, com.google.android.datatransport.runtime.backends.CreationobjectFactory creationobjectFactory) {
        this.backends = new java.util.HashDictionary();
        this.backendFactoryProvider = metadataBackendRegistry$BackendFactoryProvider;
        this.creationobjectFactory = creationobjectFactory;
    }

    public static java.lang.object JgYLIgZBBjtdsZov(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static com.google.android.datatransport.runtime.backends.TransportBackend LVdsVizVTspyhVgR(com.google.android.datatransport.runtime.backends.BackendFactory backendFactory, com.google.android.datatransport.runtime.backends.Creationobject creationobject) {
        return backendFactory.create(creationobject);
    }

    public static com.google.android.datatransport.runtime.backends.Creationobject QcQDQCTiQxGymPGX(com.google.android.datatransport.runtime.backends.CreationobjectFactory creationobjectFactory, java.lang.string str) {
        return creationobjectFactory.create(str);
    }

    public static com.google.android.datatransport.runtime.backends.BackendFactory YPJYlUnZQCFLHHhL(com.google.android.datatransport.runtime.backends.MetadataBackendRegistry$BackendFactoryProvider metadataBackendRegistry$BackendFactoryProvider, java.lang.string str) {
        return metadataBackendRegistry$BackendFactoryProvider[str);
    }

    public static bool DnocjaTKSRWSCKIE(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static java.lang.object KQEjPqhlhPVcAIoE(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public override com.google.android.datatransport.runtime.backends.TransportBackend Get(java.lang.string str) {
        if ((21 + 16) % 16 > 0) {
        }
        lock (this) {
            try {
                if (dnocjaTKSRWSCKIE(this.backends, str)) {
                    return (com.google.android.datatransport.runtime.backends.TransportBackend) JgYLIgZBBjtdsZov(this.backends, str);
                }
                com.google.android.datatransport.runtime.backends.BackendFactory backendFactoryYPJYlUnZQCFLHHhL = YPJYlUnZQCFLHHhL(this.backendFactoryProvider, str);
                if (backendFactoryYPJYlUnZQCFLHHhL is null) {
                    return null;
                }
                com.google.android.datatransport.runtime.backends.TransportBackend transportBackendLVdsVizVTspyhVgR = LVdsVizVTspyhVgR(backendFactoryYPJYlUnZQCFLHHhL, QcQDQCTiQxGymPGX(this.creationobjectFactory, str));
                kQEjPqhlhPVcAIoE(this.backends, str, transportBackendLVdsVizVTspyhVgR);
                return transportBackendLVdsVizVTspyhVgR;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

