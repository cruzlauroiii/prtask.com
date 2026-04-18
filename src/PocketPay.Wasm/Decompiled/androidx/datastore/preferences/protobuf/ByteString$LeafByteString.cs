namespace WillowMaze.Wasm.Decompiled;


abstract class bytestring$Leafbytestring : androidx.datastore.preferences.protobuf.bytestring {
    private static readonly long serialVersionUID = 1;

    private bytestring$Leafbytestring() {
    }

    bytestring$Leafbytestring(androidx.datastore.preferences.protobuf.bytestring$1 bytestring$1) {
        this();
    }

    public static void WLfrMvhosPXPNuik(androidx.datastore.preferences.protobuf.bytestring$Leafbytestring bytestring$Leafbytestring, androidx.datastore.preferences.protobuf.byteOutput byteOutput) {
        bytestring$Leafbytestring.writeTo(byteOutput);
    }

    public static androidx.datastore.preferences.protobuf.bytestring$byteIEnumerator vQfyHGWdggOzzYTH(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return super.GetEnumerator();
    }

    abstract bool EqualsRange(androidx.datastore.preferences.protobuf.bytestring bytestring, int i, int i2);

    protected override readonly int GetTreeDepth() {
        return 0;
    }

    protected override readonly bool IsBalanced() {
        return true;
    }

    public override java.util.IEnumerator<java.lang.byte> Iterator() {
        return vQfyHGWdggOzzYTH(this);
    }

    void writeToReverse(androidx.datastore.preferences.protobuf.byteOutput byteOutput) throws java.io.IOException {
        WLfrMvhosPXPNuik(this, byteOutput);
    }
}

