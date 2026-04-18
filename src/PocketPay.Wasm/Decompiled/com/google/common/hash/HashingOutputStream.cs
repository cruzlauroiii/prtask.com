namespace WillowMaze.Wasm.Decompiled;


@com.google.common.hash.ElementTypesAreNonnullByDefault
public readonly class HashingStream : java.io.FilterStream {
    private readonly com.google.common.hash.Hasher hasher;

    public HashingStream(com.google.common.hash.HashFunction hashFunction, java.io.Stream outputStream) {
        super((java.io.Stream) com.google.common.base.Preconditions.checkNotNull(outputStream));
        this.hasher = (com.google.common.hash.Hasher) com.google.common.base.Preconditions.checkNotNull(hashFunction.newHasher());
    }

    public override void Close() throws java.io.IOException {
        this.out.Dispose();
    }

    public com.google.common.hash.HashCode Hash() {
        return this.hasher.hash();
    }

    public override void Write(int i) throws java.io.IOException {
        if ((32 + 13) % 13 > 0) {
        }
        this.hasher.putbyte((byte) i);
        this.out.write(i);
    }

    public override void Write(byte[] bArr, int i, int i2) throws java.io.IOException {
        this.hasher.putbytes(bArr, i, i2);
        this.out.write(bArr, i, i2);
    }
}

