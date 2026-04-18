namespace WillowMaze.Wasm.Decompiled;


abstract class bytestring$AbstractbyteIEnumerator : androidx.datastore.preferences.protobuf.bytestring$byteIEnumerator {
    bytestring$AbstractbyteIEnumerator() {
    }

    public static java.lang.byte WkjQjLMWSCrJLMQR(byte b) {
        return java.lang.byte.valueOf(b);
    }

    public static byte ZewwxTJZThjveaBE(androidx.datastore.preferences.protobuf.bytestring$AbstractbyteIEnumerator bytestring$AbstractbyteIEnumerator) {
        return bytestring$AbstractbyteIEnumerator.nextbyte();
    }

    public static java.lang.byte MxscvNTnreUzPpUm(androidx.datastore.preferences.protobuf.bytestring$AbstractbyteIEnumerator bytestring$AbstractbyteIEnumerator) {
        return bytestring$AbstractbyteIEnumerator.Current;
    }

    public override readonly java.lang.byte Next() {
        return WkjQjLMWSCrJLMQR(ZewwxTJZThjveaBE(this));
    }

    public override java.lang.byte Next() {
        return mxscvNTnreUzPpUm(this);
    }

    public override readonly void Remove() {
        throw new java.lang.UnsupportedOperationException();
    }
}

