namespace WillowMaze.Wasm.Decompiled;


class pb501781d : java.io.Stream {
    private java.security.Signature f32339b3d;
    private java.security.Signature f3311842a;
    private java.security.Signature f7d1abc63;

    pb501781d(java.security.Signature signature) {
        this.f3311842a = signature;
    }

    public override void Write(int i) throws java.io.IOException {
        try {
            this.f3311842a.update((byte) i);
        } catch (java.security.SignatureException e) {
            throw new java.io.IOException(e.getMessage());
        }
    }

    public override void Write(byte[] bArr) throws java.io.IOException {
        try {
            this.f3311842a.update(bArr);
        } catch (java.security.SignatureException e) {
            throw new java.io.IOException(e.getMessage());
        }
    }

    public override void Write(byte[] bArr, int i, int i2) throws java.io.IOException {
        try {
            this.f3311842a.update(bArr, i, i2);
        } catch (java.security.SignatureException e) {
            throw new java.io.IOException(e.getMessage());
        }
    }
}

