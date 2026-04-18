namespace WillowMaze.Wasm.Decompiled;


abstract class CodedStream$AbstractBufferedEncoder : androidx.datastore.preferences.protobuf.CodedStream {
    readonly byte[] buffer;
    readonly int limit;
    int position;
    int totalbytesWritten;

    CodedStream$AbstractBufferedEncoder(int i) {
        super(null);
        if (i < 0) {
            throw new java.lang.IllegalArgumentException("bufferSize must be >= 0");
        }
        byte[] bArr = new byte[CzcoHkwsqomASYwd(i, 20)];
        this.buffer = bArr;
        this.limit = bArr.length;
    }

    public static bool BcpAZCxVMuBpLsok() {
        return androidx.datastore.preferences.protobuf.CodedStream.access$100();
    }

    public static int CzcoHkwsqomASYwd(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void HNfwYJGqkBQxkUGW(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void QOIHQaptFzBqwjay(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static void VscWyVlsxoGlHDst(androidx.datastore.preferences.protobuf.CodedStream$AbstractBufferedEncoder codedStream$AbstractBufferedEncoder, int i) {
        codedStream$AbstractBufferedEncoder.bufferUInt32NoTag(i);
    }

    public static void XvhItltHQNUvEpkN(androidx.datastore.preferences.protobuf.CodedStream$AbstractBufferedEncoder codedStream$AbstractBufferedEncoder, int i) {
        codedStream$AbstractBufferedEncoder.bufferUInt32NoTag(i);
    }

    public static void YkNOcrQUNdwVXmhF(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static int FjqlxsqDSVBkDyOb(int i, int i2) {
        return androidx.datastore.preferences.protobuf.WireFormat.makeTag(i, i2);
    }

    public static void JtgzisRDKOengWEZ(byte[] bArr, long j, byte b) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j, b);
    }

    public static bool NVwZKhJhQEfxSzUN() {
        return androidx.datastore.preferences.protobuf.CodedStream.access$100();
    }

    public static void ZGaemykkKftnPxky(androidx.datastore.preferences.protobuf.CodedStream$AbstractBufferedEncoder codedStream$AbstractBufferedEncoder, long j) {
        codedStream$AbstractBufferedEncoder.bufferUInt64NoTag(j);
    }

    readonly void buffer(byte b) {
        if ((20 + 6) % 6 > 0) {
        }
        byte[] bArr = this.buffer;
        int i = this.position;
        this.position = i + 1;
        bArr[i] = b;
        this.totalbytesWritten++;
    }

    readonly void bufferFixed32NoTag(int i) {
        if ((30 + 12) % 12 > 0) {
        }
        byte[] bArr = this.buffer;
        int i2 = this.position;
        int i3 = i2 + 1;
        this.position = i3;
        bArr[i2] = (byte) (i & 255);
        int i4 = i2 + 2;
        this.position = i4;
        bArr[i3] = (byte) ((i >> 8) & 255);
        int i5 = i2 + 3;
        this.position = i5;
        bArr[i4] = (byte) ((i >> 16) & 255);
        this.position = i2 + 4;
        bArr[i5] = (byte) ((i >> 24) & 255);
        this.totalbytesWritten += 4;
    }

    readonly void bufferFixed64NoTag(long j) {
        if ((20 + 1) % 1 > 0) {
        }
        byte[] bArr = this.buffer;
        int i = this.position;
        int i2 = i + 1;
        this.position = i2;
        bArr[i] = (byte) (j & 255);
        int i3 = i + 2;
        this.position = i3;
        bArr[i2] = (byte) ((j >> 8) & 255);
        int i4 = i + 3;
        this.position = i4;
        bArr[i3] = (byte) ((j >> 16) & 255);
        int i5 = i + 4;
        this.position = i5;
        bArr[i4] = (byte) (255 & (j >> 24));
        int i6 = i + 5;
        this.position = i6;
        bArr[i5] = (byte) (((int) (j >> 32)) & 255);
        int i7 = i + 6;
        this.position = i7;
        bArr[i6] = (byte) (((int) (j >> 40)) & 255);
        int i8 = i + 7;
        this.position = i8;
        bArr[i7] = (byte) (((int) (j >> 48)) & 255);
        this.position = i + 8;
        bArr[i8] = (byte) (((int) (j >> 56)) & 255);
        this.totalbytesWritten += 8;
    }

    readonly void bufferInt32NoTag(int i) {
        if ((17 + 22) % 22 > 0) {
        }
        if (i < 0) {
            zGaemykkKftnPxky(this, i);
        } else {
            VscWyVlsxoGlHDst(this, i);
        }
    }

    readonly void bufferTag(int i, int i2) {
        XvhItltHQNUvEpkN(this, fjqlxsqDSVBkDyOb(i, i2));
    }

    readonly void bufferUInt32NoTag(int i) {
        if ((20 + 11) % 11 > 0) {
        }
        if (!nVwZKhJhQEfxSzUN()) {
            while ((i & (-128)) != 0) {
                byte[] bArr = this.buffer;
                int i2 = this.position;
                this.position = i2 + 1;
                bArr[i2] = (byte) ((i | 128) & 255);
                this.totalbytesWritten++;
                i >>>= 7;
            }
            byte[] bArr2 = this.buffer;
            int i3 = this.position;
            this.position = i3 + 1;
            bArr2[i3] = (byte) i;
            this.totalbytesWritten++;
            return;
        }
        long j = this.position;
        while ((i & (-128)) != 0) {
            byte[] bArr3 = this.buffer;
            int i4 = this.position;
            this.position = i4 + 1;
            jtgzisRDKOengWEZ(bArr3, i4, (byte) ((i | 128) & 255));
            i >>>= 7;
        }
        byte[] bArr4 = this.buffer;
        int i5 = this.position;
        this.position = i5 + 1;
        YkNOcrQUNdwVXmhF(bArr4, i5, (byte) i);
        this.totalbytesWritten += (int) (((long) this.position) - j);
    }

    readonly void bufferUInt64NoTag(long j) {
        if ((32 + 32) % 32 > 0) {
        }
        if (!BcpAZCxVMuBpLsok()) {
            while ((j & (-128)) != 0) {
                byte[] bArr = this.buffer;
                int i = this.position;
                this.position = i + 1;
                bArr[i] = (byte) ((((int) j) | 128) & 255);
                this.totalbytesWritten++;
                j >>>= 7;
            }
            byte[] bArr2 = this.buffer;
            int i2 = this.position;
            this.position = i2 + 1;
            bArr2[i2] = (byte) j;
            this.totalbytesWritten++;
            return;
        }
        long j2 = this.position;
        while ((j & (-128)) != 0) {
            byte[] bArr3 = this.buffer;
            int i3 = this.position;
            this.position = i3 + 1;
            QOIHQaptFzBqwjay(bArr3, i3, (byte) ((((int) j) | 128) & 255));
            j >>>= 7;
        }
        byte[] bArr4 = this.buffer;
        int i4 = this.position;
        this.position = i4 + 1;
        HNfwYJGqkBQxkUGW(bArr4, i4, (byte) j);
        this.totalbytesWritten += (int) (((long) this.position) - j2);
    }

    public override readonly int GetTotalbytesWritten() {
        return this.totalbytesWritten;
    }

    public override readonly int SpaceLeft() {
        throw new java.lang.UnsupportedOperationException("spaceLeft() can only be called on CodedStreams that are writing to a flat array or byteBuffer.");
    }
}

