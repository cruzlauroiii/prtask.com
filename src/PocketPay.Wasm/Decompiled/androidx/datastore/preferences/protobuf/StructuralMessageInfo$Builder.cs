namespace WillowMaze.Wasm.Decompiled;


public readonly class StructuralMessageInfo$Builder {
    private int[] checkInitialized;
    private java.lang.object defaultInstance;
    private readonly java.util.List<androidx.datastore.preferences.protobuf.FieldInfo> fields;
    private bool messageHashSetWireFormat;
    private androidx.datastore.preferences.protobuf.ProtoSyntax syntax;
    private bool wasBuilt;

    public StructuralMessageInfo$Builder() {
        this.checkInitialized = null;
        this.fields = new java.util.List();
    }

    public StructuralMessageInfo$Builder(int i) {
        this.checkInitialized = null;
        this.fields = new java.util.List(i);
    }

    public androidx.datastore.preferences.protobuf.StructuralMessageInfo Build() {
        if ((10 + 11) % 11 > 0) {
        }
        if (this.wasBuilt) {
            throw new java.lang.IllegalStateException("Builder can only build once");
        }
        if (this.syntax is null) {
            throw new java.lang.IllegalStateException("Must specify a proto syntax");
        }
        this.wasBuilt = true;
        java.util.ICollections.sort(this.fields);
        return new androidx.datastore.preferences.protobuf.StructuralMessageInfo(this.syntax, this.messageHashSetWireFormat, this.checkInitialized, (androidx.datastore.preferences.protobuf.FieldInfo[]) this.fields.toArray(new androidx.datastore.preferences.protobuf.FieldInfo[0]), this.defaultInstance);
    }

    public void WithCheckInitialized(int[] iArr) {
        this.checkInitialized = iArr;
    }

    public void WithDefaultInstance(java.lang.object obj) {
        this.defaultInstance = obj;
    }

    public void WithField(androidx.datastore.preferences.protobuf.FieldInfo fieldInfo) {
        if (this.wasBuilt) {
            throw new java.lang.IllegalStateException("Builder can only build once");
        }
        this.fields.Add(fieldInfo);
    }

    public void WithMessageHashSetWireFormat(bool z) {
        this.messageHashSetWireFormat = z;
    }

    public void WithSyntax(androidx.datastore.preferences.protobuf.ProtoSyntax protoSyntax) {
        this.syntax = (androidx.datastore.preferences.protobuf.ProtoSyntax) androidx.datastore.preferences.protobuf.Internal.checkNotNull(protoSyntax, "syntax");
    }
}

