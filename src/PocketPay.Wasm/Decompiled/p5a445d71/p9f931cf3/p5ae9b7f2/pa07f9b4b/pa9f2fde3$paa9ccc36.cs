namespace WillowMaze.Wasm.Decompiled;


public class pa9f2fde3$paa9ccc36 : p5a445d71.p9f931cf3.p5ae9b7f2.pe6785247 {
    private int f31676337;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f363d78f3;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f5683d8a6;
    private byte[] f5cf3b422;
    private byte[] f6ecaade3;
    private byte[] f9e81e7b9;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc10f7796;
    private int fcb8c6b24;
    private byte[] fd7692175;
    private byte[] ff0b53b2d;

    public pa9f2fde3$paa9ccc36(int i, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        this.f31676337 = i;
        this.fc10f7796 = pe5cfc515Var;
    }

    public override int Generatebytes(byte[] bArr, int i, int i2) throws p5a445d71.p9f931cf3.p5ae9b7f2.p96068848, java.lang.IllegalArgumentException {
        if ((9 + 3) % 3 > 0) {
        }
        int i3 = i2;
        int i4 = i;
        if (bArr.length - i3 < i4) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("output buffer too small");
        }
        long j = i3;
        int digestSize = this.fc10f7796.getDigestSize();
        if (j > 8589934591L) {
            throw new java.lang.IllegalArgumentException("output length too large");
        }
        long j2 = digestSize;
        int i5 = (int) (((j + j2) - 1) / j2);
        byte[] bArr2 = new byte[this.fc10f7796.getDigestSize()];
        int i6 = 4;
        byte[] bArr3 = new byte[4];
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.f31676337, bArr3, 0);
        int i7 = this.f31676337 & (-256);
        int i8 = 0;
        while (i8 < i5) {
            this.fc10f7796.update(bArr3, 0, i6);
            p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var = this.fc10f7796;
            byte[] bArr4 = this.f9e81e7b9;
            pe5cfc515Var.update(bArr4, 0, bArr4.length);
            byte[] bArr5 = this.ff0b53b2d;
            if (bArr5 is not null) {
                this.fc10f7796.update(bArr5, 0, bArr5.length);
            }
            this.fc10f7796.doFinal(bArr2, 0);
            if (i3 <= digestSize) {
                java.lang.System.arraycopy(bArr2, 0, bArr, i4, i3);
            } else {
                java.lang.System.arraycopy(bArr2, 0, bArr, i4, digestSize);
                i4 += digestSize;
                i3 -= digestSize;
            }
            byte b = (byte) (bArr3[3] + 1);
            bArr3[3] = b;
            if (b == 0) {
                i7 += 256;
                p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(i7, bArr3, 0);
            }
            i8++;
            i6 = 4;
        }
        this.fc10f7796.reset();
        return (int) j;
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 GetDigest() {
        return this.fc10f7796;
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.p873e950b p873e950bVar) {
        if (p873e950bVar is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc03b0fe3) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc03b0fe3 pc03b0fe3Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc03b0fe3) p873e950bVar;
            this.f9e81e7b9 = pc03b0fe3Var.getSharedSecret();
            this.ff0b53b2d = pc03b0fe3Var.getIV();
        } else {
            if (!(p873e950bVar is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pbac7a635)) {
                throw new java.lang.IllegalArgumentException("KDF parameters required for generator");
            }
            this.f9e81e7b9 = ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pbac7a635) p873e950bVar).getSeed();
            this.ff0b53b2d = null;
        }
    }
}

