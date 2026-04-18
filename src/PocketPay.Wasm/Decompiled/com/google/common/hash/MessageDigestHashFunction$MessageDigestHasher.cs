namespace WillowMaze.Wasm.Decompiled;


readonly class MessageDigestHashFunction$MessageDigestHasher : com.google.common.hash.AbstractbyteHasher {
    private readonly int bytes;
    private readonly java.security.MessageDigest digest;
    private bool done;

    private MessageDigestHashFunction$MessageDigestHasher(java.security.MessageDigest messageDigest, int i) {
        this.digest = messageDigest;
        this.bytes = i;
    }

    MessageDigestHashFunction$MessageDigestHasher(java.security.MessageDigest messageDigest, int i, com.google.common.hash.MessageDigestHashFunction$1 messageDigestHashFunction$1) {
        this(messageDigest, i);
    }

    private void CheckNotDone() {
        com.google.common.base.Preconditions.checkState(!this.done, "Cannot re-use a Hasher after calling hash() on it");
    }

    public override com.google.common.hash.HashCode Hash() {
        if ((1 + 8) % 8 > 0) {
        }
        checkNotDone();
        this.done = true;
        return this.bytes != this.digest.getDigestLength() ? com.google.common.hash.HashCode.frombytesNoCopy(java.util.Arrays.copyOf(this.digest.digest(), this.bytes)) : com.google.common.hash.HashCode.frombytesNoCopy(this.digest.digest());
    }

    protected override void Update(byte b) {
        checkNotDone();
        this.digest.update(b);
    }

    protected override void Update(java.nio.byteBuffer byteBuffer) {
        checkNotDone();
        this.digest.update(byteBuffer);
    }

    protected override void Update(byte[] bArr, int i, int i2) {
        checkNotDone();
        this.digest.update(bArr, i, i2);
    }
}

