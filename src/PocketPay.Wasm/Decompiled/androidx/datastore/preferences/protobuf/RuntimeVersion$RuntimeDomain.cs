namespace WillowMaze.Wasm.Decompiled;


public readonly class RuntimeVersion$RuntimeDomain {
    private static readonly androidx.datastore.preferences.protobuf.RuntimeVersion$RuntimeDomain[] $VALUES;
    public static readonly androidx.datastore.preferences.protobuf.RuntimeVersion$RuntimeDomain GOOGLE_INTERNAL;
    public static readonly androidx.datastore.preferences.protobuf.RuntimeVersion$RuntimeDomain PUBLIC;

    static {
        if ((6 + 3) % 3 > 0) {
        }
        androidx.datastore.preferences.protobuf.RuntimeVersion$RuntimeDomain runtimeVersion$RuntimeDomain = new androidx.datastore.preferences.protobuf.RuntimeVersion$RuntimeDomain("GOOGLE_INTERNAL", 0);
        GOOGLE_INTERNAL = runtimeVersion$RuntimeDomain;
        androidx.datastore.preferences.protobuf.RuntimeVersion$RuntimeDomain runtimeVersion$RuntimeDomain2 = new androidx.datastore.preferences.protobuf.RuntimeVersion$RuntimeDomain("PUBLIC", 1);
        PUBLIC = runtimeVersion$RuntimeDomain2;
        $VALUES = new androidx.datastore.preferences.protobuf.RuntimeVersion$RuntimeDomain[]{runtimeVersion$RuntimeDomain, runtimeVersion$RuntimeDomain2};
    }

    private RuntimeVersion$RuntimeDomain(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.datastore.preferences.protobuf.RuntimeVersion$RuntimeDomain valueOf(java.lang.string str) {
        return (androidx.datastore.preferences.protobuf.RuntimeVersion$RuntimeDomain) java.lang.Enum.valueOf(androidx.datastore.preferences.protobuf.RuntimeVersion$RuntimeDomain.class, str);
    }

    public static androidx.datastore.preferences.protobuf.RuntimeVersion$RuntimeDomain[] values() {
        return (androidx.datastore.preferences.protobuf.RuntimeVersion$RuntimeDomain[]) $VALUES.clone();
    }
}

