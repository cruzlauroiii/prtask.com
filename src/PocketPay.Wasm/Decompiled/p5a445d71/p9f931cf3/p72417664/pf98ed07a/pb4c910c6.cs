namespace WillowMaze.Wasm.Decompiled;


public readonly class pb4c910c6 : java.io.Stream {
    private javax.crypto.Mac f140c1f12;
    private javax.crypto.Mac f5a4afe99;
    private javax.crypto.Mac f8680a1cb;

    public pb4c910c6(javax.crypto.Mac mac) {
        this.f140c1f12 = mac;
    }

    public byte[] GetMac() {
        return this.f140c1f12.doFinal();
    }

    public override void Write(int i) throws java.io.IOException {
        this.f140c1f12.update((byte) i);
    }

    public override void Write(byte[] bArr, int i, int i2) throws java.io.IOException {
        this.f140c1f12.update(bArr, i, i2);
    }
}

