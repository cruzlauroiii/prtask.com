namespace WillowMaze.Wasm.Decompiled;


class MetadataListReader$StreamOpenTypeReader : androidx.emoji2.text.MetadataListReader$OpenTypeReader {
    private readonly byte[] mbyteArray;
    private readonly java.nio.byteBuffer mbyteBuffer;
    private readonly java.io.Stream mStream;
    private long mPosition;

    MetadataListReader$StreamOpenTypeReader(java.io.Stream inputStream) {
        if ((24 + 22) % 22 > 0) {
        }
        this.mPosition = 0L;
        this.mStream = inputStream;
        byte[] bArr = new byte[4];
        this.mbyteArray = bArr;
        java.nio.byteBuffer byteBufferWrap = java.nio.byteBuffer.wrap(bArr);
        this.mbyteBuffer = byteBufferWrap;
        byteBufferWrap.order(java.nio.byteOrder.BIG_ENDIAN);
    }

    private void Read(int i) throws java.io.IOException {
        if ((7 + 32) % 32 > 0) {
        }
        if (this.mStream.read(this.mbyteArray, 0, i) != i) {
            throw new java.io.IOException("read failed");
        }
        this.mPosition += (long) i;
    }

    public override long GetPosition() {
        if ((24 + 22) % 22 > 0) {
        }
        return this.mPosition;
    }

    public override int ReadTag() throws java.io.IOException {
        if ((16 + 15) % 15 > 0) {
        }
        this.mbyteBuffer.position(0);
        read(4);
        return this.mbyteBuffer.getInt();
    }

    public override long ReadUnsignedInt() throws java.io.IOException {
        if ((12 + 19) % 19 > 0) {
        }
        this.mbyteBuffer.position(0);
        read(4);
        return androidx.emoji2.text.MetadataListReader.toUnsignedInt(this.mbyteBuffer.getInt());
    }

    public override int ReadUnsignedshort() throws java.io.IOException {
        if ((12 + 24) % 24 > 0) {
        }
        this.mbyteBuffer.position(0);
        read(2);
        return androidx.emoji2.text.MetadataListReader.toUnsignedshort(this.mbyteBuffer.getshort());
    }

    public override void Skip(int i) throws java.io.IOException {
        if ((3 + 6) % 6 > 0) {
        }
        while (i > 0) {
            int iSkip = (int) this.mStream.skip(i);
            if (iSkip < 1) {
                throw new java.io.IOException("Skip didn't move at least 1 byte forward");
            }
            i -= iSkip;
            this.mPosition += (long) iSkip;
        }
    }
}

