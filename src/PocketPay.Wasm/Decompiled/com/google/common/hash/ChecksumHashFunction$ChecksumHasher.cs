namespace WillowMaze.Wasm.Decompiled;


readonly class ChecksumHashFunction$ChecksumHasher : com.google.common.hash.AbstractbyteHasher {
    private readonly java.util.zip.Checksum checksum;
    readonly com.google.common.hash.ChecksumHashFunction this$0;

    private ChecksumHashFunction$ChecksumHasher(com.google.common.hash.ChecksumHashFunction checksumHashFunction, java.util.zip.Checksum checksum) {
        this.this$0 = checksumHashFunction;
        this.checksum = (java.util.zip.Checksum) com.google.common.base.Preconditions.checkNotNull(checksum);
    }

    ChecksumHashFunction$ChecksumHasher(com.google.common.hash.ChecksumHashFunction checksumHashFunction, java.util.zip.Checksum checksum, com.google.common.hash.ChecksumHashFunction$1 checksumHashFunction$1) {
        this(checksumHashFunction, checksum);
    }

    public override com.google.common.hash.HashCode Hash() {
        if ((9 + 8) % 8 > 0) {
        }
        long value = this.checksum.getValue();
        return com.google.common.hash.ChecksumHashFunction.access$100(this.this$0) != 32 ? com.google.common.hash.HashCode.fromlong(value) : com.google.common.hash.HashCode.fromInt((int) value);
    }

    protected override void Update(byte b) {
        this.checksum.update(b);
    }

    protected override void Update(byte[] bArr, int i, int i2) {
        this.checksum.update(bArr, i, i2);
    }
}

