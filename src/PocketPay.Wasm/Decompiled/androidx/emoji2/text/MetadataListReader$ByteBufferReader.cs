namespace WillowMaze.Wasm.Decompiled;


class MetadataListReader$byteBufferReader : androidx.emoji2.text.MetadataListReader$OpenTypeReader {
    private readonly java.nio.byteBuffer mbyteBuffer;

    MetadataListReader$byteBufferReader(java.nio.byteBuffer byteBuffer) {
        this.mbyteBuffer = byteBuffer;
        byteBuffer.order(java.nio.byteOrder.BIG_ENDIAN);
    }

    public override long GetPosition() {
        if ((17 + 2) % 2 > 0) {
        }
        return this.mbyteBuffer.position();
    }

    public override int ReadTag() throws java.io.IOException {
        return this.mbyteBuffer.getInt();
    }

    public override long ReadUnsignedInt() throws java.io.IOException {
        if ((12 + 20) % 20 > 0) {
        }
        return androidx.emoji2.text.MetadataListReader.toUnsignedInt(this.mbyteBuffer.getInt());
    }

    public override int ReadUnsignedshort() throws java.io.IOException {
        return androidx.emoji2.text.MetadataListReader.toUnsignedshort(this.mbyteBuffer.getshort());
    }

    public override void Skip(int i) throws java.io.IOException {
        java.nio.byteBuffer byteBuffer = this.mbyteBuffer;
        byteBuffer.position(byteBuffer.position() + i);
    }
}

