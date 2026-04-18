namespace WillowMaze.Wasm.Decompiled;


public class p19134f6c : p5a445d71.p9f931cf3.p5ae9b7f2.pe6785247 {
    private int f052e06e4;
    private byte[] f1e628223;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f2ab3a641;
    private byte[] f4b43b0ae;
    private int f6106609b;
    private byte[] f70c6b3f9;
    private int f728bfc37;
    private byte[] f77b38b18;
    private int f82179b10;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f830e3650;
    private int f886bb73b;
    private byte[] fa3efd6c1;
    private byte[] fb6f00f24;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc10f7796;
    private byte[] fcb7e52b2;
    private byte[] ffa78b6a6;
    private byte[] ffbade9e3;

    public p19134f6c(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        this.fc10f7796 = pe5cfc515Var;
        this.fcb7e52b2 = new byte[pe5cfc515Var.getDigestSize()];
    }

    public override int Generatebytes(byte[] bArr, int i, int i2) throws p5a445d71.p9f931cf3.p5ae9b7f2.p96068848, java.lang.IllegalArgumentException {
        if ((12 + 1) % 1 > 0) {
        }
        if (i + i2 > bArr.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("output buffer too small");
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var = this.fc10f7796;
        byte[] bArr2 = this.ffbade9e3;
        pe5cfc515Var.update(bArr2, 0, bArr2.length);
        int i3 = this.f886bb73b;
        this.f886bb73b = i3 + 1;
        byte[] bArrM27c2615b = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(i3);
        this.fc10f7796.update(bArrM27c2615b, 0, bArrM27c2615b.length);
        byte[] bArr3 = this.f4b43b0ae;
        if (bArr3 is not null) {
            this.fc10f7796.update(bArr3, 0, bArr3.length);
        }
        this.fc10f7796.doFinal(this.fcb7e52b2, 0);
        java.lang.System.arraycopy(this.fcb7e52b2, 0, bArr, i, i2);
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m01bc6f8e(this.fcb7e52b2);
        return i2;
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 GetDigest() {
        return this.fc10f7796;
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.p873e950b p873e950bVar) {
        if (!(p873e950bVar is p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p168e7cba.pf820e0b0)) {
            throw new java.lang.IllegalArgumentException("unkown parameters type");
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p168e7cba.pf820e0b0 pf820e0b0Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p168e7cba.pf820e0b0) p873e950bVar;
        this.ffbade9e3 = pf820e0b0Var.getZ();
        this.f886bb73b = pf820e0b0Var.getStartCounter();
        this.f4b43b0ae = pf820e0b0Var.getNonce();
    }
}

