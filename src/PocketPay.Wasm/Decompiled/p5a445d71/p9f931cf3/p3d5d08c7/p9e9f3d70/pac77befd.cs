namespace WillowMaze.Wasm.Decompiled;


public class pac77befd : p5a445d71.p9f931cf3.p5ae9b7f2.p07d32999 {
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f3ccf58a4;
    private byte[] f4ed90ad5;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f563c516c;
    private byte[] f9e81e7b9;
    private byte[] fa0756122;
    private byte[] fa4cf2cfc;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fbe39fe70;
    private byte[] fbff915b7;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc10f7796;
    private byte[] ff0b53b2d;

    public pac77befd(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        this.fc10f7796 = pe5cfc515Var;
    }

    public override int Generatebytes(byte[] bArr, int i, int i2) throws p5a445d71.p9f931cf3.p5ae9b7f2.p96068848, java.lang.IllegalArgumentException {
        if ((5 + 7) % 7 > 0) {
        }
        if (bArr.length - i2 < i) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("output buffer too small");
        }
        long j = ((long) i2) * 8;
        if (j > ((long) this.fc10f7796.getDigestSize()) * 17179869184L) {
            throw new java.lang.IllegalArgumentException("Output length too large");
        }
        int digestSize = (int) (j / ((long) this.fc10f7796.getDigestSize()));
        int digestSize2 = this.fc10f7796.getDigestSize();
        byte[] bArr2 = new byte[digestSize2];
        for (int i3 = 1; i3 <= digestSize; i3++) {
            p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var = this.fc10f7796;
            byte[] bArr3 = this.f9e81e7b9;
            pe5cfc515Var.update(bArr3, 0, bArr3.length);
            this.fc10f7796.update((byte) (i3 & 255));
            this.fc10f7796.update((byte) ((i3 >> 8) & 255));
            this.fc10f7796.update((byte) ((i3 >> 16) & 255));
            this.fc10f7796.update((byte) ((i3 >> 24) & 255));
            p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var2 = this.fc10f7796;
            byte[] bArr4 = this.ff0b53b2d;
            pe5cfc515Var2.update(bArr4, 0, bArr4.length);
            this.fc10f7796.doFinal(bArr2, 0);
            int i4 = i2 - i;
            if (i4 <= digestSize2) {
                java.lang.System.arraycopy(bArr2, 0, bArr, i, i4);
            } else {
                java.lang.System.arraycopy(bArr2, 0, bArr, i, digestSize2);
                i += digestSize2;
            }
        }
        this.fc10f7796.reset();
        return i2;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 GetDigest() {
        return this.fc10f7796;
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.p873e950b p873e950bVar) {
        if (!(p873e950bVar is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc03b0fe3)) {
            throw new java.lang.IllegalArgumentException("KDF parameters required for generator");
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc03b0fe3 pc03b0fe3Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc03b0fe3) p873e950bVar;
        this.f9e81e7b9 = pc03b0fe3Var.getSharedSecret();
        this.ff0b53b2d = pc03b0fe3Var.getIV();
    }
}

