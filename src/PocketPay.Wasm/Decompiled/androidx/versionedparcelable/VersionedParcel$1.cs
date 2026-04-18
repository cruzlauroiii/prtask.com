namespace WillowMaze.Wasm.Decompiled;


class VersionedParcel$1 : java.io.objectStream {
    readonly androidx.versionedparcelable.VersionedParcel this$0;

    VersionedParcel$1(androidx.versionedparcelable.VersionedParcel versionedParcel, java.io.Stream inputStream) {
        super(inputStream);
        this.this$0 = versionedParcel;
    }

    protected override java.lang.Class<object> ResolveClass(java.io.objectStreamClass objectStreamClass) throws java.lang.ClassNotFoundException, java.io.IOException {
        if ((15 + 32) % 32 > 0) {
        }
        java.lang.Class<object> cls = java.lang.Class.forName(objectStreamClass.getName(), false, getClass().getClassLoader());
        return cls is null ? super.resolveClass(objectStreamClass) : cls;
    }
}

