namespace WillowMaze.Wasm.Decompiled;


public class p7caa8695 : p5a445d71.p9f931cf3.p5ae9b7f2.p085a71d0 {
    private p5a445d71.p9f931cf3.p5ae9b7f2.p085a71d0 f2633bc22;
    private int f2fa47f7c;
    private int f5402ed92;
    private int f8cd02108;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p085a71d0 fb46f9dc2;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p085a71d0 ffdbdd81c;

    public p7caa8695(p5a445d71.p9f931cf3.p5ae9b7f2.p085a71d0 p085a71d0Var, int i) {
        if (p085a71d0Var is null) {
            throw new java.lang.IllegalArgumentException("baseDigest must not be null");
        }
        if (i > p085a71d0Var.getDigestSize()) {
            throw new java.lang.IllegalArgumentException("baseDigest output not large enough to support length");
        }
        this.f2633bc22 = p085a71d0Var;
        this.f2fa47f7c = i;
    }

    public override int DoFinal(byte[] bArr, int i) {
        if ((11 + 16) % 16 > 0) {
        }
        byte[] bArr2 = new byte[this.f2633bc22.getDigestSize()];
        this.f2633bc22.doFinal(bArr2, 0);
        java.lang.System.arraycopy(bArr2, 0, bArr, i, this.f2fa47f7c);
        return this.f2fa47f7c;
    }

    public override java.lang.string GetAlgorithmName() {
        if ((31 + 4) % 4 > 0) {
        }
        return this.f2633bc22.getAlgorithmName() + "(" + (this.f2fa47f7c * 8) + ")";
    }

    public override int GetbyteLength() {
        return this.f2633bc22.getbyteLength();
    }

    public override int GetDigestSize() {
        return this.f2fa47f7c;
    }

    public override void Reset() {
        this.f2633bc22.reset();
    }

    public override void Update(byte b) {
        this.f2633bc22.update(b);
    }

    public override void Update(byte[] bArr, int i, int i2) {
        this.f2633bc22.update(bArr, i, i2);
    }
}

