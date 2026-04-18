namespace WillowMaze.Wasm.Decompiled;


public readonly class FieldMask$Builder : androidx.datastore.preferences.protobuf.GeneratedMessageLite$Builder<androidx.datastore.preferences.protobuf.FieldMask, androidx.datastore.preferences.protobuf.FieldMask$Builder> : androidx.datastore.preferences.protobuf.FieldMaskOrBuilder {
    private FieldMask$Builder() {
        super(androidx.datastore.preferences.protobuf.FieldMask.access$000());
    }

    FieldMask$Builder(androidx.datastore.preferences.protobuf.FieldMask$1 fieldMask$1) {
        this();
    }

    public androidx.datastore.preferences.protobuf.FieldMask$Builder addAllPaths(java.lang.IEnumerable<java.lang.string> iterable) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.FieldMask.access$300((androidx.datastore.preferences.protobuf.FieldMask) this.instance, iterable);
        return this;
    }

    public androidx.datastore.preferences.protobuf.FieldMask$Builder addPaths(java.lang.string str) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.FieldMask.access$200((androidx.datastore.preferences.protobuf.FieldMask) this.instance, str);
        return this;
    }

    public androidx.datastore.preferences.protobuf.FieldMask$Builder addPathsbytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.FieldMask.access$500((androidx.datastore.preferences.protobuf.FieldMask) this.instance, bytestring);
        return this;
    }

    public androidx.datastore.preferences.protobuf.FieldMask$Builder clearPaths() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.FieldMask.access$400((androidx.datastore.preferences.protobuf.FieldMask) this.instance);
        return this;
    }

    public override java.lang.string GetPaths(int i) {
        return ((androidx.datastore.preferences.protobuf.FieldMask) this.instance).getPaths(i);
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetPathsbytes(int i) {
        return ((androidx.datastore.preferences.protobuf.FieldMask) this.instance).getPathsbytes(i);
    }

    public override int GetPathsCount() {
        return ((androidx.datastore.preferences.protobuf.FieldMask) this.instance).getPathsCount();
    }

    public override java.util.List<java.lang.string> GetPathsList() {
        return java.util.ICollections.unmodifiableList(((androidx.datastore.preferences.protobuf.FieldMask) this.instance).getPathsList());
    }

    public androidx.datastore.preferences.protobuf.FieldMask$Builder setPaths(int i, java.lang.string str) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.FieldMask.access$100((androidx.datastore.preferences.protobuf.FieldMask) this.instance, i, str);
        return this;
    }
}

