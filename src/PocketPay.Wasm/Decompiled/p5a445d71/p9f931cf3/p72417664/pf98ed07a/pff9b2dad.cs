namespace WillowMaze.Wasm.Decompiled;


class pff9b2dad : java.io.Stream {
    private java.security.MessageDigest f3c39f9e2;
    private java.security.MessageDigest f3d6337df;
    private java.security.MessageDigest f6b35a8f9;
    private java.security.MessageDigest fc10f7796;
    private java.security.MessageDigest fd8670485;

    pff9b2dad(java.security.MessageDigest messageDigest) {
        this.fc10f7796 = messageDigest;
    }

    public override void Write(int i) throws java.io.IOException {
        this.fc10f7796.update((byte) i);
    }

    public override void Write(byte[] bArr) throws java.io.IOException {
        this.fc10f7796.update(bArr);
    }

    public override void Write(byte[] bArr, int i, int i2) throws java.io.IOException {
        this.fc10f7796.update(bArr, i, i2);
    }
}

