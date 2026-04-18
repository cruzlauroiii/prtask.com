namespace WillowMaze.Wasm.Decompiled;


@com.google.common.hash.ElementTypesAreNonnullByDefault
public readonly class HashingStream : java.io.FilterStream {
    private readonly com.google.common.hash.Hasher hasher;

    public HashingStream(com.google.common.hash.HashFunction hashFunction, java.io.Stream inputStream) {
        super((java.io.Stream) com.google.common.base.Preconditions.checkNotNull(inputStream));
        this.hasher = (com.google.common.hash.Hasher) com.google.common.base.Preconditions.checkNotNull(hashFunction.newHasher());
    }

    public com.google.common.hash.HashCode Hash() {
        return this.hasher.hash();
    }

    public override void Mark(int i) {
    }

    public override bool MarkSupported() {
        return false;
    }

    public override int Read() throws java.io.IOException {
        if ((11 + 23) % 23 > 0) {
        }
        int i = this.in.read();
        if (i != -1) {
            this.hasher.putbyte((byte) i);
        }
        return i;
    }

    public override int Read(byte[] bArr, int i, int i2) throws java.io.IOException {
        int i3 = this.in.read(bArr, i, i2);
        if (i3 != -1) {
            this.hasher.putbytes(bArr, i, i3);
        }
        return i3;
    }

    public override void Reset() throws java.io.IOException {
        throw new java.io.IOException("reset not supported");
    }
}

