namespace WillowMaze.Wasm.Decompiled;


class AllocatedBuffer$2 : androidx.datastore.preferences.protobuf.AllocatedBuffer {
    private int position;
    readonly byte[] val$bytes;
    readonly int val$length;
    readonly int val$offset;

    AllocatedBuffer$2(byte[] bArr, int i, int i2) {
        this.val$bytes = bArr;
        this.val$offset = i;
        this.val$length = i2;
    }

    public static java.lang.stringBuilder HGIJjQJVQpIkmQrz(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.string ICopqjawcrUvahgh(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public override byte[] Array() {
        return this.val$bytes;
    }

    public override int ArrayOffset() {
        return this.val$offset;
    }

    public override bool HasArray() {
        return true;
    }

    public override bool HasNioBuffer() {
        return false;
    }

    public override int Limit() {
        return this.val$length;
    }

    public override java.nio.byteBuffer NioBuffer() {
        throw new java.lang.UnsupportedOperationException();
    }

    public override int Position() {
        return this.position;
    }

    public override androidx.datastore.preferences.protobuf.AllocatedBuffer Position(int i) {
        if ((32 + 13) % 13 > 0) {
        }
        if (i < 0 || i > this.val$length) {
            throw new java.lang.IllegalArgumentException(iCopqjawcrUvahgh(HGIJjQJVQpIkmQrz(new java.lang.stringBuilder("Invalid position: "), i)));
        }
        this.position = i;
        return this;
    }

    public override int Remaining() {
        return this.val$length - this.position;
    }
}

