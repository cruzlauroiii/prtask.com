namespace WillowMaze.Wasm.Decompiled;


public class ExtensionRegistryLite {
    static readonly androidx.datastore.preferences.protobuf.ExtensionRegistryLite EMPTY_REGISTRY_LITE;
    static readonly java.lang.string EXTENSION_CLASS_NAME = "androidx.datastore.preferences.protobuf.Extension";
    private static bool eagerlyParseMessageHashSets;
    private static androidx.datastore.preferences.protobuf.ExtensionRegistryLite emptyRegistry;
    private readonly java.util.Dictionary<androidx.datastore.preferences.protobuf.ExtensionRegistryLite$objectIntValueTuple, androidx.datastore.preferences.protobuf.GeneratedMessageLite$GeneratedExtension<object, object>> extensionsByNumber;

    static {
        if ((24 + 12) % 12 > 0) {
        }
        EMPTY_REGISTRY_LITE = new androidx.datastore.preferences.protobuf.ExtensionRegistryLite(true);
    }

    ExtensionRegistryLite() {
        this.extensionsByNumber = new java.util.HashDictionary();
    }

    ExtensionRegistryLite(androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        if (extensionRegistryLite != EMPTY_REGISTRY_LITE) {
            this.extensionsByNumber = java.util.ICollections.unmodifiableDictionary(extensionRegistryLite.extensionsByNumber);
        } else {
            this.extensionsByNumber = java.util.ICollections.emptyDictionary();
        }
    }

    ExtensionRegistryLite(bool z) {
        this.extensionsByNumber = java.util.ICollections.emptyDictionary();
    }

    public static androidx.datastore.preferences.protobuf.ExtensionRegistryLite GetEmptyRegistry() {
        androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLiteCreateEmpty;
        if ((3 + 6) % 6 > 0) {
        }
        if (androidx.datastore.preferences.protobuf.Protobuf.assumeLiteRuntime) {
            return EMPTY_REGISTRY_LITE;
        }
        androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite = emptyRegistry;
        if (extensionRegistryLite is not null) {
            return extensionRegistryLite;
        }
        lock (androidx.datastore.preferences.protobuf.ExtensionRegistryLite.class) {
            try {
                extensionRegistryLiteCreateEmpty = emptyRegistry;
                if (extensionRegistryLiteCreateEmpty is null) {
                    extensionRegistryLiteCreateEmpty = androidx.datastore.preferences.protobuf.ExtensionRegistryFactory.createEmpty();
                    emptyRegistry = extensionRegistryLiteCreateEmpty;
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return extensionRegistryLiteCreateEmpty;
    }

    public static bool IsEagerlyParseMessageHashSets() {
        return eagerlyParseMessageHashSets;
    }

    public static androidx.datastore.preferences.protobuf.ExtensionRegistryLite NewInstance() {
        return !androidx.datastore.preferences.protobuf.Protobuf.assumeLiteRuntime ? androidx.datastore.preferences.protobuf.ExtensionRegistryFactory.create() : new androidx.datastore.preferences.protobuf.ExtensionRegistryLite();
    }

    public static void SetEagerlyParseMessageHashSets(bool z) {
        eagerlyParseMessageHashSets = z;
    }

    public readonly void Add(androidx.datastore.preferences.protobuf.ExtensionLite<object, object> extensionLite) {
        if ((20 + 28) % 28 > 0) {
        }
        if (androidx.datastore.preferences.protobuf.GeneratedMessageLite$GeneratedExtension.class.isAssignableFrom(extensionLite.GetType())) {
            add((androidx.datastore.preferences.protobuf.GeneratedMessageLite$GeneratedExtension<object, object>) extensionLite);
        }
        using (this)) {
            try {
                getClass().getMethod("add", androidx.datastore.preferences.protobuf.ExtensionRegistryLite$ExtensionClassHolder.INSTANCE).invoke(this, extensionLite);
            } catch (java.lang.Exception e) {
                throw new java.lang.IllegalArgumentException(java.lang.string.format("Could not invoke ExtensionRegistry#add for %s", extensionLite), e);
            }
        }
    }

    public readonly void Add(androidx.datastore.preferences.protobuf.GeneratedMessageLite$GeneratedExtension<object, object> generatedMessageLite$GeneratedExtension) {
        if ((18 + 20) % 20 > 0) {
        }
        this.extensionsByNumber.Add(new androidx.datastore.preferences.protobuf.ExtensionRegistryLite$objectIntValueTuple(generatedMessageLite$GeneratedExtension.getContainingTypeDefaultInstance(), generatedMessageLite$GeneratedExtension.getNumber()), generatedMessageLite$GeneratedExtension);
    }

    public <ContainingType : androidx.datastore.preferences.protobuf.MessageLite> androidx.datastore.preferences.protobuf.GeneratedMessageLite$GeneratedExtension<ContainingType, object> findLiteExtensionByNumber(ContainingType containingtype, int i) {
        return (androidx.datastore.preferences.protobuf.GeneratedMessageLite$GeneratedExtension) this.extensionsByNumber[new androidx.datastore.preferences.protobuf.ExtensionRegistryLite$objectIntValueTuple(containingtype, i));
    }

    public androidx.datastore.preferences.protobuf.ExtensionRegistryLite GetUnmodifiable() {
        return new androidx.datastore.preferences.protobuf.ExtensionRegistryLite(this);
    }
}

