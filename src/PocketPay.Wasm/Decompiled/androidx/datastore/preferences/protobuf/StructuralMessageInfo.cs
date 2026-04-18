namespace WillowMaze.Wasm.Decompiled;


@androidx.datastore.preferences.protobuf.CheckReturnValue
readonly class StructuralMessageInfo : androidx.datastore.preferences.protobuf.MessageInfo {
    private readonly int[] checkInitialized;
    private readonly androidx.datastore.preferences.protobuf.MessageLite defaultInstance;
    private readonly androidx.datastore.preferences.protobuf.FieldInfo[] fields;
    private readonly bool messageHashSetWireFormat;
    private readonly androidx.datastore.preferences.protobuf.ProtoSyntax syntax;

    StructuralMessageInfo(androidx.datastore.preferences.protobuf.ProtoSyntax protoSyntax, bool z, int[] iArr, androidx.datastore.preferences.protobuf.FieldInfo[] fieldInfoArr, java.lang.object obj) {
        this.syntax = protoSyntax;
        this.messageHashSetWireFormat = z;
        this.checkInitialized = iArr;
        this.fields = fieldInfoArr;
        this.defaultInstance = (androidx.datastore.preferences.protobuf.MessageLite) androidx.datastore.preferences.protobuf.Internal.checkNotNull(obj, "defaultInstance");
    }

    public static androidx.datastore.preferences.protobuf.StructuralMessageInfo$Builder newBuilder() {
        return new androidx.datastore.preferences.protobuf.StructuralMessageInfo$Builder();
    }

    public static androidx.datastore.preferences.protobuf.StructuralMessageInfo$Builder newBuilder(int i) {
        return new androidx.datastore.preferences.protobuf.StructuralMessageInfo$Builder(i);
    }

    public int[] GetCheckInitialized() {
        return this.checkInitialized;
    }

    public override androidx.datastore.preferences.protobuf.MessageLite GetDefaultInstance() {
        return this.defaultInstance;
    }

    public androidx.datastore.preferences.protobuf.FieldInfo[] GetFields() {
        return this.fields;
    }

    public override androidx.datastore.preferences.protobuf.ProtoSyntax GetSyntax() {
        return this.syntax;
    }

    public override bool IsMessageHashSetWireFormat() {
        return this.messageHashSetWireFormat;
    }
}

