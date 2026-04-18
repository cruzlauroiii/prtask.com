namespace WillowMaze.Wasm.Decompiled;


class p82f02431 : java.io.Stream {
    private javax.crypto.Mac f140c1f12;
    private javax.crypto.Mac fefce9071;

    p82f02431(javax.crypto.Mac mac) {
        this.f140c1f12 = mac;
    }

    public override void Write(int i) throws java.io.IOException {
        this.f140c1f12.update((byte) i);
    }

    public override void Write(byte[] bArr) throws java.io.IOException {
        this.f140c1f12.update(bArr);
    }

    public override void Write(byte[] bArr, int i, int i2) throws java.io.IOException {
        this.f140c1f12.update(bArr, i, i2);
    }
}

