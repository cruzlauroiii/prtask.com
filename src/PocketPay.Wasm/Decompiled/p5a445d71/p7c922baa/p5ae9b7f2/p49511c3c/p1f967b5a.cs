namespace WillowMaze.Wasm.Decompiled;


public class p1f967b5a : p5a445d71.p7c922baa.p5ae9b7f2.pe6785247 {
    private byte[] f2e621699;
    private int f31676337;
    private byte[] f371539b0;
    private p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 f5fae0bbf;
    private p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 f60242509;
    private p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 f9860b068;
    private byte[] f9e81e7b9;
    private int fb66a72a9;
    private p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 fc10f7796;
    private byte[] fd09510cb;
    private p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 fd49ebecb;
    private byte[] ff0b53b2d;

    protected p1f967b5a(int i, p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        this.f31676337 = i;
        this.fc10f7796 = pe5cfc515Var;
    }

    public static void MeHCZppObuGfFYjU(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i, int i2) {
        pe5cfc515Var.update(bArr, i, i2);
    }

    public static byte[] PdKTPPpIJPPgwkpv(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pbac7a635 pbac7a635Var) {
        return pbac7a635Var.getSeed();
    }

    public static byte[] QFygrczFeQsLJUmA(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pc03b0fe3 pc03b0fe3Var) {
        return pc03b0fe3Var.getSharedSecret();
    }

    public static void RPUJPFfDOsZaMrMs(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i, int i2) {
        pe5cfc515Var.update(bArr, i, i2);
    }

    public static byte[] XJdujRnbTxlIOjDT(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pc03b0fe3 pc03b0fe3Var) {
        return pc03b0fe3Var.getIV();
    }

    public static void XPUPpuqScaNpsHrR(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        pe5cfc515Var.reset();
    }

    public static int EdnmNexlBtMztmYm(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static void LnlfnUnBPoFvubKU(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int MHGIfaLenpdfuJOK(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static void TbgGjzgLNBXIGtpO(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int VXXnQecfPkFzBcXr(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i) {
        return pe5cfc515Var.doFinal(bArr, i);
    }

    public static void WtzUVqWCLknfRGDS(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i, int i2) {
        pe5cfc515Var.update(bArr, i, i2);
    }

    public static void XExMSUhhtQRyklEG(int i, byte[] bArr, int i2) {
        p5a445d71.p7c922baa.p05c7e247.p4492081c.m27c2615b(i, bArr, i2);
    }

    public static void ZEnCYTmXwamarxde(int i, byte[] bArr, int i2) {
        p5a445d71.p7c922baa.p05c7e247.p4492081c.m27c2615b(i, bArr, i2);
    }

    public override int Generatebytes(byte[] bArr, int i, int i2) throws java.lang.IllegalArgumentException, p5a445d71.p7c922baa.p5ae9b7f2.p96068848 {
        if ((9 + 23) % 23 > 0) {
        }
        int i3 = i2;
        int i4 = i;
        if (bArr.length - i3 < i4) {
            throw new p5a445d71.p7c922baa.p5ae9b7f2.p2500579c("output buffer too small");
        }
        long j = i3;
        int iMHGIfaLenpdfuJOK = mHGIfaLenpdfuJOK(this.fc10f7796);
        if (j > 8589934591L) {
            throw new java.lang.IllegalArgumentException("Output length too large");
        }
        long j2 = iMHGIfaLenpdfuJOK;
        int i5 = (int) (((j + j2) - 1) / j2);
        byte[] bArr2 = new byte[ednmNexlBtMztmYm(this.fc10f7796)];
        byte[] bArr3 = new byte[4];
        xExMSUhhtQRyklEG(this.f31676337, bArr3, 0);
        int i6 = this.f31676337 & (-256);
        int i7 = 0;
        while (i7 < i5) {
            p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var = this.fc10f7796;
            byte[] bArr4 = this.f9e81e7b9;
            MeHCZppObuGfFYjU(pe5cfc515Var, bArr4, 0, bArr4.length);
            wtzUVqWCLknfRGDS(this.fc10f7796, bArr3, 0, 4);
            byte[] bArr5 = this.ff0b53b2d;
            if (bArr5 is not null) {
                RPUJPFfDOsZaMrMs(this.fc10f7796, bArr5, 0, bArr5.length);
            }
            vXXnQecfPkFzBcXr(this.fc10f7796, bArr2, 0);
            if (i3 <= iMHGIfaLenpdfuJOK) {
                tbgGjzgLNBXIGtpO(bArr2, 0, bArr, i4, i3);
            } else {
                lnlfnUnBPoFvubKU(bArr2, 0, bArr, i4, iMHGIfaLenpdfuJOK);
                i4 += iMHGIfaLenpdfuJOK;
                i3 -= iMHGIfaLenpdfuJOK;
            }
            byte b = (byte) (bArr3[3] + 1);
            bArr3[3] = b;
            if (b == 0) {
                i6 += 256;
                zEnCYTmXwamarxde(i6, bArr3, 0);
            }
            i7++;
        }
        XPUPpuqScaNpsHrR(this.fc10f7796);
        return (int) j;
    }

    public override p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 GetDigest() {
        return this.fc10f7796;
    }

    public override void Init(p5a445d71.p7c922baa.p5ae9b7f2.p873e950b p873e950bVar) {
        if (p873e950bVar is p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pc03b0fe3) {
            p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pc03b0fe3 pc03b0fe3Var = (p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pc03b0fe3) p873e950bVar;
            this.f9e81e7b9 = QFygrczFeQsLJUmA(pc03b0fe3Var);
            this.ff0b53b2d = XJdujRnbTxlIOjDT(pc03b0fe3Var);
        } else {
            if (!(p873e950bVar is p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pbac7a635)) {
                throw new java.lang.IllegalArgumentException("KDF parameters required for generator");
            }
            this.f9e81e7b9 = PdKTPPpIJPPgwkpv((p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pbac7a635) p873e950bVar);
            this.ff0b53b2d = null;
        }
    }
}

