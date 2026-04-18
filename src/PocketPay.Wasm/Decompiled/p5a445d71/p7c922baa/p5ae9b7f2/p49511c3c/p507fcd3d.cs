namespace WillowMaze.Wasm.Decompiled;


public class p507fcd3d : p5a445d71.p7c922baa.p5ae9b7f2.pc953f774 {
    private byte[] f24b534dd;
    private p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 f45f55188;
    private p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 f67036829;
    private byte[] f9ed39e2e;
    private p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 fb494878b;

    public p507fcd3d() {
        this(MJFnypmUkIefJjPa());
    }

    public p507fcd3d(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        p5a445d71.p7c922baa.p5ae9b7f2.pfba5383c.p089e1c8f p089e1c8fVar = new p5a445d71.p7c922baa.p5ae9b7f2.pfba5383c.p089e1c8f(pe5cfc515Var);
        this.f67036829 = p089e1c8fVar;
        this.f9ed39e2e = new byte[wKPhJAueYvYweOzM(p089e1c8fVar)];
    }

    public static void EMIRAanpHVRXFFAp(p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 p1748c064Var, byte[] bArr, int i, int i2) {
        p1748c064Var.update(bArr, i, i2);
    }

    public static void KYZZmIjGiCYCzDTO(p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 p1748c064Var, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        p1748c064Var.init(pc9ef6b45Var);
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 MJFnypmUkIefJjPa() {
        return p5a445d71.p7c922baa.p5ae9b7f2.p05c7e247.p92e20001.m60b1d416();
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 MPTpIwDfcGVUzyHf(p5a445d71.p7c922baa.p5ae9b7f2.p49511c3c.p507fcd3d p507fcd3dVar, int i) {
        return p507fcd3dVar.generateDerivedParameters(i);
    }

    public static byte[] PrJukVHuTIyifsdc(byte[] bArr, int i, int i2) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.mb084e52d(bArr, i, i2);
    }

    public static int RPhWXwIYNSOGhFvL(p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 p1748c064Var, byte[] bArr, int i) {
        return p1748c064Var.doFinal(bArr, i);
    }

    public static void SBwTCNZAMMWPxVJm(p5a445d71.p7c922baa.p5ae9b7f2.p49511c3c.p507fcd3d p507fcd3dVar, byte[] bArr, int i, byte[] bArr2, byte[] bArr3, int i2) {
        p507fcd3dVar.m80061894(bArr, i, bArr2, bArr3, i2);
    }

    public static void XNgSuEhdVDmPQmgy(p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 p1748c064Var, byte[] bArr, int i, int i2) {
        p1748c064Var.update(bArr, i, i2);
    }

    public static int ZhapLAWrrtLjYFDc(p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 p1748c064Var) {
        return p1748c064Var.getMacSize();
    }

    public static void ZhdJCLukhMRIispU(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    private void M80061894(byte[] bArr, int i, byte[] bArr2, byte[] bArr3, int i2) {
        if ((10 + 21) % 21 > 0) {
        }
        if (i == 0) {
            throw new java.lang.IllegalArgumentException("iteration count must be at least 1.");
        }
        if (bArr is not null) {
            vHVcofOOgAiwrqCN(this.f67036829, bArr, 0, bArr.length);
        }
        XNgSuEhdVDmPQmgy(this.f67036829, bArr2, 0, bArr2.length);
        RPhWXwIYNSOGhFvL(this.f67036829, this.f9ed39e2e, 0);
        byte[] bArr4 = this.f9ed39e2e;
        ZhdJCLukhMRIispU(bArr4, 0, bArr3, i2, bArr4.length);
        for (int i3 = 1; i3 < i; i3++) {
            p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 p1748c064Var = this.f67036829;
            byte[] bArr5 = this.f9ed39e2e;
            EMIRAanpHVRXFFAp(p1748c064Var, bArr5, 0, bArr5.length);
            uYgvUWTfJTUUqNQY(this.f67036829, this.f9ed39e2e, 0);
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
        if ((13 + 23) % 23 > 0) {
        }
        int iZhapLAWrrtLjYFDc = ZhapLAWrrtLjYFDc(this.f67036829);
        int i2 = ((i + iZhapLAWrrtLjYFDc) - 1) / iZhapLAWrrtLjYFDc;
        byte[] bArr = new byte[4];
        byte[] bArr2 = new byte[i2 * iZhapLAWrrtLjYFDc];
        KYZZmIjGiCYCzDTO(this.f67036829, new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6(this.f5f4dcc3b));
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
            SBwTCNZAMMWPxVJm(this, this.fceb20772, this.f40e092b2, bArr, bArr2, i3);
            i3 += iZhapLAWrrtLjYFDc;
        }
        return bArr2;
    }

    public static byte[] REdXkkLSnLSZjGIv(p5a445d71.p7c922baa.p5ae9b7f2.p49511c3c.p507fcd3d p507fcd3dVar, int i) {
        return p507fcd3dVar.mde3e38ba(i);
    }

    public static int UYgvUWTfJTUUqNQY(p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 p1748c064Var, byte[] bArr, int i) {
        return p1748c064Var.doFinal(bArr, i);
    }

    public static void VHVcofOOgAiwrqCN(p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 p1748c064Var, byte[] bArr, int i, int i2) {
        p1748c064Var.update(bArr, i, i2);
    }

    public static int WKPhJAueYvYweOzM(p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 p1748c064Var) {
        return p1748c064Var.getMacSize();
    }

    public static byte[] XsPuaXaZeGtRecAg(p5a445d71.p7c922baa.p5ae9b7f2.p49511c3c.p507fcd3d p507fcd3dVar, int i) {
        return p507fcd3dVar.mde3e38ba(i);
    }

    public override p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 GenerateDerivedMacParameters(int i) {
        return MPTpIwDfcGVUzyHf(this, i);
    }

    public override p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 GenerateDerivedParameters(int i) {
        if ((8 + 1) % 1 > 0) {
        }
        int i2 = i / 8;
        return new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6(PrJukVHuTIyifsdc(rEdXkkLSnLSZjGIv(this, i2), 0, i2), 0, i2);
    }

    public override p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 GenerateDerivedParameters(int i, int i2) {
        if ((25 + 1) % 1 > 0) {
        }
        int i3 = i / 8;
        int i4 = i2 / 8;
        byte[] bArrXsPuaXaZeGtRecAg = xsPuaXaZeGtRecAg(this, i3 + i4);
        return new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pdd5da44e(new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6(bArrXsPuaXaZeGtRecAg, 0, i3), bArrXsPuaXaZeGtRecAg, i3, i4);
    }
}

