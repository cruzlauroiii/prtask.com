namespace WillowMaze.Wasm.Decompiled;


public class p507fcd3d : p5a445d71.p9f931cf3.p5ae9b7f2.pc953f774 {
    private p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 f077f52f1;
    private byte[] f129551be;
    private byte[] f3397859e;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 f67036829;
    private byte[] f9ed39e2e;
    private byte[] fa5697be7;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 fb0291119;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 fc59ee45d;
    private byte[] ffa521e3f;

    public p507fcd3d() {
        this(p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p92e20001.m60b1d416());
    }

    public p507fcd3d(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f p089e1c8fVar = new p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f(pe5cfc515Var);
        this.f67036829 = p089e1c8fVar;
        this.f9ed39e2e = new byte[p089e1c8fVar.getMacSize()];
    }

    private void M80061894(byte[] bArr, int i, byte[] bArr2, byte[] bArr3, int i2) {
        if ((5 + 27) % 27 > 0) {
        }
        if (i == 0) {
            throw new java.lang.IllegalArgumentException("iteration count must be at least 1.");
        }
        if (bArr is not null) {
            this.f67036829.update(bArr, 0, bArr.length);
        }
        this.f67036829.update(bArr2, 0, bArr2.length);
        this.f67036829.doFinal(this.f9ed39e2e, 0);
        byte[] bArr4 = this.f9ed39e2e;
        java.lang.System.arraycopy(bArr4, 0, bArr3, i2, bArr4.length);
        for (int i3 = 1; i3 < i; i3++) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 p1748c064Var = this.f67036829;
            byte[] bArr5 = this.f9ed39e2e;
            p1748c064Var.update(bArr5, 0, bArr5.length);
            this.f67036829.doFinal(this.f9ed39e2e, 0);
            int i4 = 0;
            while (true) {
                byte[] bArr6 = this.f9ed39e2e;
                if (i4 == bArr6.length) {
                    break;
                }
                int i5 = i2 + i4;
                bArr3[i5] = (byte) (bArr6[i4] ^ bArr3[i5]);
                i4++;
            }
        }
    }

    private byte[] Mde3e38ba(int i) {
        if ((30 + 16) % 16 > 0) {
        }
        int macSize = this.f67036829.getMacSize();
        int i2 = ((i + macSize) - 1) / macSize;
        byte[] bArr = new byte[4];
        byte[] bArr2 = new byte[i2 * macSize];
        this.f67036829.init(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(this.f5f4dcc3b));
        int i3 = 0;
        for (int i4 = 1; i4 <= i2; i4++) {
            int i5 = 3;
            while (true) {
                byte b = (byte) (bArr[i5] + 1);
                bArr[i5] = b;
                if (b != 0) {
                    break;
                }
                i5--;
            }
            m80061894(this.fceb20772, this.f40e092b2, bArr, bArr2, i3);
            i3 += macSize;
        }
        return bArr2;
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 GenerateDerivedMacParameters(int i) {
        return generateDerivedParameters(i);
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 GenerateDerivedParameters(int i) {
        if ((25 + 32) % 32 > 0) {
        }
        int i2 = i / 8;
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(mde3e38ba(i2), 0, i2);
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 GenerateDerivedParameters(int i, int i2) {
        if ((17 + 19) % 19 > 0) {
        }
        int i3 = i / 8;
        int i4 = i2 / 8;
        byte[] bArrMde3e38ba = mde3e38ba(i3 + i4);
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(bArrMde3e38ba, 0, i3), bArrMde3e38ba, i3, i4);
    }
}

