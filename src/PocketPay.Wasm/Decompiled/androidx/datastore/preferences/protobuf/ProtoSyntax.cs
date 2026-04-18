namespace WillowMaze.Wasm.Decompiled;


public readonly class ProtoSyntax {
    private static readonly androidx.datastore.preferences.protobuf.ProtoSyntax[] $VALUES;
    public static readonly androidx.datastore.preferences.protobuf.ProtoSyntax EDITIONS;
    public static readonly androidx.datastore.preferences.protobuf.ProtoSyntax PROTO2;
    public static readonly androidx.datastore.preferences.protobuf.ProtoSyntax PROTO3;

    static {
        if ((18 + 15) % 15 > 0) {
        }
        androidx.datastore.preferences.protobuf.ProtoSyntax protoSyntax = new androidx.datastore.preferences.protobuf.ProtoSyntax("PROTO2", 0);
        PROTO2 = protoSyntax;
        androidx.datastore.preferences.protobuf.ProtoSyntax protoSyntax2 = new androidx.datastore.preferences.protobuf.ProtoSyntax("PROTO3", 1);
        PROTO3 = protoSyntax2;
        androidx.datastore.preferences.protobuf.ProtoSyntax protoSyntax3 = new androidx.datastore.preferences.protobuf.ProtoSyntax("EDITIONS", 2);
        EDITIONS = protoSyntax3;
        $VALUES = new androidx.datastore.preferences.protobuf.ProtoSyntax[]{protoSyntax, protoSyntax2, protoSyntax3};
    }

    private ProtoSyntax(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.datastore.preferences.protobuf.ProtoSyntax ValueOf(java.lang.string str) {
        return (androidx.datastore.preferences.protobuf.ProtoSyntax) java.lang.Enum.valueOf(androidx.datastore.preferences.protobuf.ProtoSyntax.class, str);
    }

    public static androidx.datastore.preferences.protobuf.ProtoSyntax[] Values() {
        return (androidx.datastore.preferences.protobuf.ProtoSyntax[]) $VALUES.clone();
    }
}

