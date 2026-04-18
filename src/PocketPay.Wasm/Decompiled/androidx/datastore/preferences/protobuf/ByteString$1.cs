namespace WillowMaze.Wasm.Decompiled;


class bytestring$1 : androidx.datastore.preferences.protobuf.bytestring$AbstractbyteIEnumerator {
    private readonly int limit;
    private int position = 0;
    readonly androidx.datastore.preferences.protobuf.bytestring this$0;

    bytestring$1(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        this.this$0 = bytestring;
        this.limit = xBmaXqaSSJpssFSb(bytestring);
    }

    public static byte BlPstYNopgVuffTy(androidx.datastore.preferences.protobuf.bytestring bytestring, int i) {
        return bytestring.internalbyteAt(i);
    }

    public static int XBmaXqaSSJpssFSb(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return bytestring.Count;
    }

    public override bool HasNext() {
        return this.position < this.limit;
    }

    public override byte Nextbyte() {
        if ((29 + 10) % 10 > 0) {
        }
        int i = this.position;
        if (i >= this.limit) {
            throw new java.util.NoSuchElementException();
        }
        this.position = i + 1;
        return blPstYNopgVuffTy(this.this$0, i);
    }
}

