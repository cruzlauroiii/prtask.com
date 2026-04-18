namespace WillowMaze.Wasm.Decompiled;


public class pe2c0fb97 : p5a445d71.p7c922baa.p5ae9b7f2.pd1977c1b {
    public static readonly int f08e13d21 = 13004;
    public static readonly int f1abcaf73 = 13516;
    public static readonly int f1e38eeb7 = 188;
    public static readonly int f2138b170 = 14028;
    public static readonly int f21a87303 = 14284;
    public static readonly int f24752512 = 13772;
    public static readonly int f2fca523b = 14028;
    public static readonly int f42ea107d = 14028;
    public static readonly int f4933a455 = 12748;
    public static readonly int f55024cea = 188;
    public static readonly int f5798dd45 = 14540;
    public static readonly int f57fb2076 = 13260;
    public static readonly int f63ea8e74 = 12748;
    public static readonly int f6a914fee = 13516;
    public static readonly int f6c6edc60 = 13772;
    public static readonly int f7125630b = 14284;
    public static readonly int f73646397 = 13260;
    public static readonly int f7b8847c4 = 188;
    public static readonly int f99884844 = 12748;
    public static readonly int f9b32be77 = 13004;
    public static readonly int fa252920c = 14540;
    public static readonly int fb1ca8eec = 14540;
    public static readonly int fc1acec4d = 14540;
    public static readonly int fc2feb281 = 14540;
    public static readonly int fc4085657 = 14028;
    public static readonly int fc61b3229 = 14284;
    public static readonly int fcde38591 = 13260;
    public static readonly int fe0ead865 = 14284;
    public static readonly int febcd4582 = 13004;
    public static readonly int ffee94a1f = 14028;
    public static readonly int ffef90335 = 13772;
    private p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe f08406a6e;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p753eae39 f109d9447;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p753eae39 f1138a43e;
    private byte[] f14511f2f;
    private byte[] f29357eae;
    private p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 f3060e3a1;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p753eae39 f36a95c65;
    private byte[] f3d8e65a2;
    private int f4f56d52c;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p753eae39 f62eeaabd;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p753eae39 f6a958b65;
    private int f6c090634;
    private p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe f6cdf08d0;
    private int f7448a384;
    private byte[] f7a25ef62;
    private p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe f89d5c321;
    private int f93707f72;
    private int fab302ed8;
    private int face2cc93;
    private int fbab1c8fe;
    private p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 fc10f7796;
    private byte[] fd076db4d;
    private p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe fe24c9e4b;
    private int fe2561308;
    private p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 ff12a1e6a;
    private p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe ff3c80f33;

    public pe2c0fb97(p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe p42a46bbeVar, p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        this(p42a46bbeVar, pe5cfc515Var, false);
    }

    public pe2c0fb97(p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe p42a46bbeVar, p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, bool z) {
        this.f08406a6e = p42a46bbeVar;
        this.fc10f7796 = pe5cfc515Var;
        if (z) {
            this.f93707f72 = 188;
            return;
        }
        java.lang.int numNnJGdciRUMOmJmOw = NnJGdciRUMOmJmOw(pe5cfc515Var);
        if (numNnJGdciRUMOmJmOw is null) {
            throw new java.lang.IllegalArgumentException(LHoLtQAMirZpIQqS(yiqyskJrmjwzXnxa(new java.lang.stringBuilder("no valid trailer for digest: "), KBdvdyQZpiGQhsCN(pe5cfc515Var))));
        }
        this.f93707f72 = kGRBZGYVwgUJleqe(numNnJGdciRUMOmJmOw);
    }

    public static void CitIpQQvDrUSBuun(p5a445d71.p7c922baa.p5ae9b7f2.pb42c5142.pe2c0fb97 pe2c0fb97Var, byte[] bArr) {
        pe2c0fb97Var.m8f780856(bArr);
    }

    public static void GEqrZXNtHASIFxYa(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte b) {
        pe5cfc515Var.update(b);
    }

    public static java.math.Bigint GMUlIuyLICCialwT(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p753eae39 p753eae39Var) {
        return p753eae39Var.getModulus();
    }

    public static int HUDogghYMcRTLmxt(java.math.Bigint bigint) {
        return bigint.bitLength();
    }

    public static int InHtARODMmbHvCQN(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i) {
        return pe5cfc515Var.doFinal(bArr, i);
    }

    public static java.lang.string KBdvdyQZpiGQhsCN(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getAlgorithmName();
    }

    public static java.math.Bigint LCnydHEsDYmmwTjM(java.math.Bigint bigint, java.math.Bigint bigint2) {
        return bigint.min(bigint2);
    }

    public static java.lang.string LHoLtQAMirZpIQqS(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.math.Bigint MmNYRebsAzqKZMUK(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p753eae39 p753eae39Var) {
        return p753eae39Var.getModulus();
    }

    public static java.lang.int NnJGdciRUMOmJmOw(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return p5a445d71.p7c922baa.p5ae9b7f2.pb42c5142.p78369c04.m8729361b(pe5cfc515Var);
    }

    public static void NuJvpiZyItPWRUXh(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        pe5cfc515Var.reset();
    }

    public static void QeAUHDjyARXImbOm(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i, int i2) {
        pe5cfc515Var.update(bArr, i, i2);
    }

    public static java.math.Bigint RTFdLboCRWNKYIll(java.math.Bigint bigint, java.math.Bigint bigint2) {
        return bigint.subtract(bigint2);
    }

    public static int SFyrPXEgbwpBiVCo(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i) {
        return pe5cfc515Var.doFinal(bArr, i);
    }

    public static void UFpRUVMqKwngaVfa(p5a445d71.p7c922baa.p5ae9b7f2.pb42c5142.pe2c0fb97 pe2c0fb97Var, byte[] bArr) {
        pe2c0fb97Var.m8f780856(bArr);
    }

    public static int UXTlCBUTWPYKzMNY(java.math.Bigint bigint) {
        return bigint.intValue();
    }

    public static byte[] YHaDbtLSrpCmrWoq(int i, java.math.Bigint bigint) {
        return p5a445d71.p7c922baa.p05c7e247.p68e35a3f.mec6269b9(i, bigint);
    }

    public static void YcuaYzofGjUtOqxO(p5a445d71.p7c922baa.p5ae9b7f2.pb42c5142.pe2c0fb97 pe2c0fb97Var, byte[] bArr) {
        pe2c0fb97Var.m8f780856(bArr);
    }

    public static void ZBKeWEWxmbaTxTHM(p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe p42a46bbeVar, bool z, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        p42a46bbeVar.init(z, pc9ef6b45Var);
    }

    public static java.math.Bigint AjbDIfdcTQLnKbPF(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p753eae39 p753eae39Var) {
        return p753eae39Var.getModulus();
    }

    public static int DSfBTwmosPSKCBjY(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static int DcDvONwxRndTLmbp(java.math.Bigint bigint) {
        return bigint.intValue();
    }

    public static int EkLkPQxCzcnqPWNP(java.math.Bigint bigint) {
        return bigint.bitLength();
    }

    public static java.math.Bigint HehmgwvuXzFUFHFc(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p753eae39 p753eae39Var) {
        return p753eae39Var.getModulus();
    }

    public static int KGRBZGYVwgUJleqe(java.lang.int num) {
        return num.intValue();
    }

    private void M31ec78aa() {
        int length;
        if ((25 + 22) % 22 > 0) {
        }
        int iDSfBTwmosPSKCBjY = dSfBTwmosPSKCBjY(this.fc10f7796);
        if (this.f93707f72 != 188) {
            byte[] bArr = this.f14511f2f;
            length = (bArr.length - iDSfBTwmosPSKCBjY) - 2;
            SFyrPXEgbwpBiVCo(this.fc10f7796, bArr, length);
            byte[] bArr2 = this.f14511f2f;
            int length2 = bArr2.length - 2;
            int i = this.f93707f72;
            bArr2[length2] = (byte) (i >>> 8);
            bArr2[bArr2.length - 1] = (byte) i;
        } else {
            byte[] bArr3 = this.f14511f2f;
            length = (bArr3.length - iDSfBTwmosPSKCBjY) - 1;
            InHtARODMmbHvCQN(this.fc10f7796, bArr3, length);
            this.f14511f2f[r0.length - 1] = -68;
        }
        this.f14511f2f[0] = 107;
        for (int i2 = length - 2; i2 != 0; i2--) {
            this.f14511f2f[i2] = -69;
        }
        this.f14511f2f[length - 1] = -70;
    }

    private void M8f780856(byte[] bArr) {
        if ((14 + 31) % 31 > 0) {
        }
        for (int i = 0; i != bArr.length; i++) {
            bArr[i] = 0;
        }
    }

    public static byte[] NYQFlalaBsZEjoij(int i, java.math.Bigint bigint) {
        return p5a445d71.p7c922baa.p05c7e247.p68e35a3f.mec6269b9(i, bigint);
    }

    public static byte[] PHcadZYvWyUClMAN(p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe p42a46bbeVar, byte[] bArr, int i, int i2) {
        return p42a46bbeVar.processBlock(bArr, i, i2);
    }

    public static void RSlSOWtJjFUyGBOF(p5a445d71.p7c922baa.p5ae9b7f2.pb42c5142.pe2c0fb97 pe2c0fb97Var) {
        pe2c0fb97Var.m31ec78aa();
    }

    public static bool RqUnuaVogStIoXUU(byte[] bArr, byte[] bArr2) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m66e765de(bArr, bArr2);
    }

    public static byte[] WlNfYooRUZgKFeOh(p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe p42a46bbeVar, byte[] bArr, int i, int i2) {
        return p42a46bbeVar.processBlock(bArr, i, i2);
    }

    public static void WngrNaAYRvzRrvmn(p5a445d71.p7c922baa.p5ae9b7f2.pb42c5142.pe2c0fb97 pe2c0fb97Var) {
        pe2c0fb97Var.m31ec78aa();
    }

    public static void XQELePZpxZkpxphe(p5a445d71.p7c922baa.p5ae9b7f2.pb42c5142.pe2c0fb97 pe2c0fb97Var) {
        pe2c0fb97Var.reset();
    }

    public static java.lang.stringBuilder YiqyskJrmjwzXnxa(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.math.Bigint ZNeJKtjKVLiNsCQY(java.math.Bigint bigint, java.math.Bigint bigint2) {
        return bigint.subtract(bigint2);
    }

    public override byte[] GenerateSignature() throws p5a445d71.p7c922baa.p5ae9b7f2.p48d8e57f {
        if ((20 + 20) % 20 > 0) {
        }
        wngrNaAYRvzRrvmn(this);
        p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe p42a46bbeVar = this.f08406a6e;
        byte[] bArr = this.f14511f2f;
        java.math.Bigint bigint = new java.math.Bigint(1, pHcadZYvWyUClMAN(p42a46bbeVar, bArr, 0, bArr.length));
        UFpRUVMqKwngaVfa(this, this.f14511f2f);
        return nYQFlalaBsZEjoij((ekLkPQxCzcnqPWNP(hehmgwvuXzFUFHFc(this.f62eeaabd)) + 7) / 8, LCnydHEsDYmmwTjM(bigint, zNeJKtjKVLiNsCQY(ajbDIfdcTQLnKbPF(this.f62eeaabd), bigint)));
    }

    public override void Init(bool z, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p753eae39 p753eae39Var = (p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p753eae39) pc9ef6b45Var;
        this.f62eeaabd = p753eae39Var;
        ZBKeWEWxmbaTxTHM(this.f08406a6e, z, p753eae39Var);
        int iHUDogghYMcRTLmxt = HUDogghYMcRTLmxt(MmNYRebsAzqKZMUK(this.f62eeaabd));
        this.f4f56d52c = iHUDogghYMcRTLmxt;
        this.f14511f2f = new byte[(iHUDogghYMcRTLmxt + 7) / 8];
        xQELePZpxZkpxphe(this);
    }

    public override void Reset() {
        NuJvpiZyItPWRUXh(this.fc10f7796);
    }

    public override void Update(byte b) {
        GEqrZXNtHASIFxYa(this.fc10f7796, b);
    }

    public override void Update(byte[] bArr, int i, int i2) {
        QeAUHDjyARXImbOm(this.fc10f7796, bArr, i, i2);
    }

    public override bool VerifySignature(byte[] bArr) {
        if ((10 + 9) % 9 > 0) {
        }
        bool zRqUnuaVogStIoXUU = false;
        try {
            this.f14511f2f = wlNfYooRUZgKFeOh(this.f08406a6e, bArr, 0, bArr.length);
            java.math.Bigint bigint = new java.math.Bigint(1, this.f14511f2f);
            if ((dcDvONwxRndTLmbp(bigint) & 15) != 12) {
                bigint = RTFdLboCRWNKYIll(GMUlIuyLICCialwT(this.f62eeaabd), bigint);
                if ((UXTlCBUTWPYKzMNY(bigint) & 15) == 12) {
                    rSlSOWtJjFUyGBOF(this);
                    byte[] bArrYHaDbtLSrpCmrWoq = YHaDbtLSrpCmrWoq(this.f14511f2f.length, bigint);
                    zRqUnuaVogStIoXUU = rqUnuaVogStIoXUU(this.f14511f2f, bArrYHaDbtLSrpCmrWoq);
                    CitIpQQvDrUSBuun(this, this.f14511f2f);
                    YcuaYzofGjUtOqxO(this, bArrYHaDbtLSrpCmrWoq);
                }
            } else {
                rSlSOWtJjFUyGBOF(this);
                byte[] bArrYHaDbtLSrpCmrWoq2 = YHaDbtLSrpCmrWoq(this.f14511f2f.length, bigint);
                zRqUnuaVogStIoXUU = rqUnuaVogStIoXUU(this.f14511f2f, bArrYHaDbtLSrpCmrWoq2);
                CitIpQQvDrUSBuun(this, this.f14511f2f);
                YcuaYzofGjUtOqxO(this, bArrYHaDbtLSrpCmrWoq2);
            }
        } catch (java.lang.Exception unused) {
        }
        return zRqUnuaVogStIoXUU;
    }
}

