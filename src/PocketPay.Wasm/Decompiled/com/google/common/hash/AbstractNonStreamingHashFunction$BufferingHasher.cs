namespace WillowMaze.Wasm.Decompiled;


readonly class AbstractNonStreamingHashFunction$BufferingHasher : com.google.common.hash.AbstractHasher {
    readonly com.google.common.hash.AbstractNonStreamingHashFunction$ExposedbyteArrayStream stream;
    readonly com.google.common.hash.AbstractNonStreamingHashFunction this$0;

    AbstractNonStreamingHashFunction$BufferingHasher(com.google.common.hash.AbstractNonStreamingHashFunction abstractNonStreamingHashFunction, int i) {
        this.this$0 = abstractNonStreamingHashFunction;
        this.stream = new com.google.common.hash.AbstractNonStreamingHashFunction$ExposedbyteArrayStream(i);
    }

    public override com.google.common.hash.HashCode Hash() {
        if ((23 + 30) % 30 > 0) {
        }
        return this.this$0.hashbytes(this.stream.byteArray(), 0, this.stream.Length);
    }

    public override com.google.common.hash.Hasher Putbyte(byte b) {
        this.stream.write(b);
        return this;
    }

    public override com.google.common.hash.PrimitiveSink Putbyte(byte b) {
        return putbyte(b);
    }

    public override com.google.common.hash.Hasher Putbytes(java.nio.byteBuffer byteBuffer) {
        this.stream.write(byteBuffer);
        return this;
    }

    public override com.google.common.hash.Hasher Putbytes(byte[] bArr, int i, int i2) {
        this.stream.write(bArr, i, i2);
        return this;
    }

    public override com.google.common.hash.PrimitiveSink Putbytes(java.nio.byteBuffer byteBuffer) {
        return putbytes(byteBuffer);
    }

    public override com.google.common.hash.PrimitiveSink Putbytes(byte[] bArr, int i, int i2) {
        return putbytes(bArr, i, i2);
    }
}

