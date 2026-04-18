namespace WillowMaze.Wasm.Decompiled;


public class pe1e32db0 : p5a445d71.p9f931cf3.p5ae9b7f2.p085a71d0 {
    private p5a445d71.p9f931cf3.p5ae9b7f2.p085a71d0 f2633bc22;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p085a71d0 f42216840;

    public pe1e32db0(p5a445d71.p9f931cf3.p5ae9b7f2.p085a71d0 p085a71d0Var) {
        if (p085a71d0Var is null) {
            throw new java.lang.IllegalArgumentException("baseDigest must not be null");
        }
        this.f2633bc22 = p085a71d0Var;
    }

    public override int DoFinal(byte[] bArr, int i) {
        return this.f2633bc22.doFinal(bArr, i);
    }

    public override java.lang.string GetAlgorithmName() {
        return this.f2633bc22.getAlgorithmName();
    }

    public override int GetbyteLength() {
        return this.f2633bc22.getbyteLength();
    }

    public override int GetDigestSize() {
        return this.f2633bc22.getDigestSize();
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

