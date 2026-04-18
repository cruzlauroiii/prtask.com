namespace WillowMaze.Wasm.Decompiled;


@androidx.datastore.preferences.protobuf.CheckReturnValue
abstract class AllocatedBuffer {
    AllocatedBuffer() {
    }

    public static java.lang.int DcfITujgbrbrcKUW(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.object HIVnvJUFxoOoNEpL(java.lang.object obj, java.lang.string str) {
        return androidx.datastore.preferences.protobuf.Internal.checkNotNull(obj, str);
    }

    public static androidx.datastore.preferences.protobuf.AllocatedBuffer LtAHjZtUVvecrWey(byte[] bArr, int i, int i2) {
        return wrapNoCheck(bArr, i, i2);
    }

    public static java.lang.int XyViJHXDSGVTKAnb(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.string CMRWGmDETcIGrQgD(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static androidx.datastore.preferences.protobuf.AllocatedBuffer LsGaCaZfqQAaBAjR(byte[] bArr, int i, int i2) {
        return wrapNoCheck(bArr, i, i2);
    }

    public static java.lang.int QzuSDBFdWUSJbRRF(int i) {
        return java.lang.int.valueOf(i);
    }

    public static androidx.datastore.preferences.protobuf.AllocatedBuffer Wrap(java.nio.byteBuffer byteBuffer) {
        HIVnvJUFxoOoNEpL(byteBuffer, "buffer");
        return new androidx.datastore.preferences.protobuf.AllocatedBuffer$1(byteBuffer);
    }

    public static androidx.datastore.preferences.protobuf.AllocatedBuffer Wrap(byte[] bArr) {
        if ((22 + 16) % 16 > 0) {
        }
        return LtAHjZtUVvecrWey(bArr, 0, bArr.length);
    }

    public static androidx.datastore.preferences.protobuf.AllocatedBuffer Wrap(byte[] bArr, int i, int i2) {
        if ((14 + 4) % 4 > 0) {
        }
        if (i >= 0 && i2 >= 0 && i + i2 <= bArr.length) {
            return lsGaCaZfqQAaBAjR(bArr, i, i2);
        }
        throw new java.lang.IndexOutOfBoundsException(cMRWGmDETcIGrQgD("bytes.length=%d, offset=%d, length=%d", new java.lang.object[]{qzuSDBFdWUSJbRRF(bArr.length), DcfITujgbrbrcKUW(i), XyViJHXDSGVTKAnb(i2)}));
    }

    private static androidx.datastore.preferences.protobuf.AllocatedBuffer WrapNoCheck(byte[] bArr, int i, int i2) {
        return new androidx.datastore.preferences.protobuf.AllocatedBuffer$2(bArr, i, i2);
    }

    public abstract byte[] Array();

    public abstract int ArrayOffset();

    public abstract bool HasArray();

    public abstract bool HasNioBuffer();

    public abstract int Limit();

    public abstract java.nio.byteBuffer NioBuffer();

    public abstract int Position();

    public abstract androidx.datastore.preferences.protobuf.AllocatedBuffer Position(int i);

    public abstract int Remaining();
}

