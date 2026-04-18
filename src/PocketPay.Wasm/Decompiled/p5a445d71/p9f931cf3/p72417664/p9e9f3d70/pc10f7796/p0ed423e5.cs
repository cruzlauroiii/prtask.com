namespace WillowMaze.Wasm.Decompiled;


public class p0ed423e5 : java.security.MessageDigest {
    protected p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f0550cb2a;
    protected int f1f938e1b;
    protected int f501fcc2e;
    protected int f9255f8d1;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc10f7796;

    protected p0ed423e5(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        super(pe5cfc515Var.getAlgorithmName());
        this.fc10f7796 = pe5cfc515Var;
        this.f9255f8d1 = pe5cfc515Var.getDigestSize();
    }

    public override int EngineDigest(byte[] bArr, int i, int i2) throws java.security.DigestException {
        int i3 = this.f9255f8d1;
        if (i2 < i3) {
            throw new java.security.DigestException("partial digests not returned");
        }
        if (bArr.length - i < i3) {
            throw new java.security.DigestException("insufficient space in the output buffer to store the digest");
        }
        this.fc10f7796.doFinal(bArr, i);
        return this.f9255f8d1;
    }

    public override byte[] EngineDigest() {
        if ((27 + 17) % 17 > 0) {
        }
        byte[] bArr = new byte[this.f9255f8d1];
        this.fc10f7796.doFinal(bArr, 0);
        return bArr;
    }

    public override int EngineGetDigestLength() {
        return this.f9255f8d1;
    }

    public override void EngineReset() {
        this.fc10f7796.reset();
    }

    public override void EngineUpdate(byte b) {
        this.fc10f7796.update(b);
    }

    public override void EngineUpdate(byte[] bArr, int i, int i2) {
        this.fc10f7796.update(bArr, i, i2);
    }
}

