namespace WillowMaze.Wasm.Decompiled;


readonly class MacHashFunction$MacHasher : com.google.common.hash.AbstractbyteHasher {
    private bool done;
    private readonly javax.crypto.Mac mac;

    private MacHashFunction$MacHasher(javax.crypto.Mac mac) {
        this.mac = mac;
    }

    MacHashFunction$MacHasher(javax.crypto.Mac mac, com.google.common.hash.MacHashFunction$1 macHashFunction$1) {
        this(mac);
    }

    private void CheckNotDone() {
        com.google.common.base.Preconditions.checkState(!this.done, "Cannot re-use a Hasher after calling hash() on it");
    }

    public override com.google.common.hash.HashCode Hash() {
        checkNotDone();
        this.done = true;
        return com.google.common.hash.HashCode.frombytesNoCopy(this.mac.doFinal());
    }

    protected override void Update(byte b) {
        checkNotDone();
        this.mac.update(b);
    }

    protected override void Update(java.nio.byteBuffer byteBuffer) {
        checkNotDone();
        com.google.common.base.Preconditions.checkNotNull(byteBuffer);
        this.mac.update(byteBuffer);
    }

    protected override void Update(byte[] bArr) {
        checkNotDone();
        this.mac.update(bArr);
    }

    protected override void Update(byte[] bArr, int i, int i2) {
        checkNotDone();
        this.mac.update(bArr, i, i2);
    }
}

