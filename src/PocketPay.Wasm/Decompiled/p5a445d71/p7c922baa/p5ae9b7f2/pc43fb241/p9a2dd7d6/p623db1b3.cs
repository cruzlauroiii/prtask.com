namespace WillowMaze.Wasm.Decompiled;


public class p623db1b3 : p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.p52c18907 {
    private static readonly int fb890b593 = 262144;
    private static readonly int fc0faa20e = 262144;
    private static readonly long fcf42ea96 = 140737488355328L;
    private static readonly long fea8d3206 = 140737488355328L;
    private static readonly long febecb53e = 140737488355328L;
    private static readonly long ff155e175 = 140737488355328L;
    private byte[] f04d000ad;
    private long f179d76db;
    private int f19355e2c;
    private byte[] f1dc24c75;
    private byte[] f2e5298ce;
    private byte[] f31ed86f0;
    private p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 f3acd79e6;
    private p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p54466d0a f41f4a3d6;
    private p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 f46e97eb4;
    private long f47bd22b6;
    private p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p54466d0a f5a983bb2;
    private byte[] f5e668a9d;
    private long f6cbdc4ac;
    private p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 f7fce0b3e;
    private long f881174bf;
    private int fa14d69e4;
    private byte[] fa2c26a5c;
    private int fe9f58b9d;
    private p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 fee474090;
    private byte[] ff318b4dc;

    public p623db1b3(p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 p1748c064Var, int i, p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p54466d0a p54466d0aVar, byte[] bArr, byte[] bArr2) {
        if (i > yecLRajiApUfShdd(p1748c064Var)) {
            throw new java.lang.IllegalArgumentException("Requested security strength is not supported by the derivation function");
        }
        if (YTOSKWWdRcFekHfT(p54466d0aVar) < i) {
            throw new java.lang.IllegalArgumentException("Not enough entropy for security strength required");
        }
        this.f19355e2c = i;
        this.f41f4a3d6 = p54466d0aVar;
        this.f46e97eb4 = p1748c064Var;
        byte[] bArrKLZOwcwBZkaKKCmE = kLZOwcwBZkaKKCmE(MNrAkbmQIzXGpDOY(this), bArr2, bArr);
        byte[] bArr3 = new byte[NlNcbhXeFPhnuBPw(p1748c064Var)];
        this.f2e5298ce = bArr3;
        byte[] bArr4 = new byte[bArr3.length];
        this.f31ed86f0 = bArr4;
        HaGCpCsxgMgkadji(bArr4, (byte) 1);
        MrHcdadgEYjuzGha(this, bArrKLZOwcwBZkaKKCmE);
        this.f179d76db = 1L;
    }

    public static byte[] AIdTDLCdtQPOXUNG(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p54466d0a p54466d0aVar) {
        return p54466d0aVar.getEntropy();
    }

    public static int ASEBLsBKzaDmcVry(p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 p1748c064Var, byte[] bArr, int i) {
        return p1748c064Var.doFinal(bArr, i);
    }

    public static void CxLPYMoaDFtMyrnS(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void FXytJqIWTgOInkXT(p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 p1748c064Var, byte[] bArr, int i, int i2) {
        p1748c064Var.update(bArr, i, i2);
    }

    public static void HaGCpCsxgMgkadji(byte[] bArr, byte b) {
        p5a445d71.p7c922baa.p05c7e247.pff43b8de.ma552c747(bArr, b);
    }

    public static void LfoREinsYwzOEBcq(p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 p1748c064Var, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        p1748c064Var.init(pc9ef6b45Var);
    }

    public static byte[] MNrAkbmQIzXGpDOY(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.p623db1b3 p623db1b3Var) {
        return p623db1b3Var.me50610cf();
    }

    public static void MVyIxWcihDDboIfW(p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 p1748c064Var, byte[] bArr, int i, int i2) {
        p1748c064Var.update(bArr, i, i2);
    }

    public static void MWeCfCRBMPyZktAh(p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 p1748c064Var, byte[] bArr, int i, int i2) {
        p1748c064Var.update(bArr, i, i2);
    }

    public static void MrHcdadgEYjuzGha(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.p623db1b3 p623db1b3Var, byte[] bArr) {
        p623db1b3Var.m298c3452(bArr);
    }

    public static int NlNcbhXeFPhnuBPw(p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 p1748c064Var) {
        return p1748c064Var.getMacSize();
    }

    public static int QpLYTwXreLpgFcZU(p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 p1748c064Var, byte[] bArr, int i) {
        return p1748c064Var.doFinal(bArr, i);
    }

    public static int SWBqMYyFhVScAnKh(p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 p1748c064Var, byte[] bArr, int i) {
        return p1748c064Var.doFinal(bArr, i);
    }

    public static void SkbTMMZhhqLqpQSh(p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 p1748c064Var, byte[] bArr, int i, int i2) {
        p1748c064Var.update(bArr, i, i2);
    }

    public static void WqZhAqupLfuzHegW(p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 p1748c064Var, byte[] bArr, int i, int i2) {
        p1748c064Var.update(bArr, i, i2);
    }

    public static byte[] XufKdSBNtbuAvYFC(byte[] bArr, byte[] bArr2) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md844b504(bArr, bArr2);
    }

    public static int YTOSKWWdRcFekHfT(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p54466d0a p54466d0aVar) {
        return p54466d0aVar.entropySize();
    }

    public static void ZVtPrwbELlUziEsi(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.p623db1b3 p623db1b3Var, byte[] bArr, byte b) {
        p623db1b3Var.mbb82a6de(bArr, b);
    }

    public static void ZsPzJHQonTvGxWIh(p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 p1748c064Var, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        p1748c064Var.init(pc9ef6b45Var);
    }

    public static void ZuxMthGlQkHpWnFr(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.p623db1b3 p623db1b3Var, byte[] bArr) {
        p623db1b3Var.reseed(bArr);
    }

    public static void AQRLuhnqeEGISglv(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.p623db1b3 p623db1b3Var, byte[] bArr) {
        p623db1b3Var.m298c3452(bArr);
    }

    public static byte[] BPvuDMIdmrsZyXHE(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.p623db1b3 p623db1b3Var) {
        return p623db1b3Var.me50610cf();
    }

    public static void BdTTEpwKOXpJiHai(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static byte[] KLZOwcwBZkaKKCmE(byte[] bArr, byte[] bArr2, byte[] bArr3) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md844b504(bArr, bArr2, bArr3);
    }

    public static void KLdwYbrpFfFSApVe(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.p623db1b3 p623db1b3Var, byte[] bArr) {
        p623db1b3Var.m298c3452(bArr);
    }

    private void M298c3452(byte[] bArr) {
        ZVtPrwbELlUziEsi(this, bArr, (byte) 0);
        if (bArr is null) {
            return;
        }
        wZrMlQaohcIXtNNu(this, bArr, (byte) 1);
    }

    private void Mbb82a6de(byte[] bArr, byte b) {
        if ((22 + 25) % 25 > 0) {
        }
        LfoREinsYwzOEBcq(this.f46e97eb4, new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6(this.f2e5298ce));
        p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 p1748c064Var = this.f46e97eb4;
        byte[] bArr2 = this.f31ed86f0;
        FXytJqIWTgOInkXT(p1748c064Var, bArr2, 0, bArr2.length);
        pIydQGTwTwIGJjbP(this.f46e97eb4, b);
        if (bArr is not null) {
            MWeCfCRBMPyZktAh(this.f46e97eb4, bArr, 0, bArr.length);
        }
        ASEBLsBKzaDmcVry(this.f46e97eb4, this.f2e5298ce, 0);
        ZsPzJHQonTvGxWIh(this.f46e97eb4, new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6(this.f2e5298ce));
        p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 p1748c064Var2 = this.f46e97eb4;
        byte[] bArr3 = this.f31ed86f0;
        MVyIxWcihDDboIfW(p1748c064Var2, bArr3, 0, bArr3.length);
        QpLYTwXreLpgFcZU(this.f46e97eb4, this.f31ed86f0, 0);
    }

    private byte[] Me50610cf() {
        if ((15 + 9) % 9 > 0) {
        }
        byte[] bArrAIdTDLCdtQPOXUNG = AIdTDLCdtQPOXUNG(this.f41f4a3d6);
        if (bArrAIdTDLCdtQPOXUNG.length < (this.f19355e2c + 7) / 8) {
            throw new java.lang.IllegalStateException("Insufficient entropy provided by entropy source");
        }
        return bArrAIdTDLCdtQPOXUNG;
    }

    public static void NJisaQZdtSoOtadV(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.p623db1b3 p623db1b3Var, byte[] bArr) {
        p623db1b3Var.m298c3452(bArr);
    }

    public static void OhVYhhUKSnaFPIFk(p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 p1748c064Var, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        p1748c064Var.init(pc9ef6b45Var);
    }

    public static void PIydQGTwTwIGJjbP(p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 p1748c064Var, byte b) {
        p1748c064Var.update(b);
    }

    public static void RxLtogPzZrpTJAXK(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int SUsWJHaWYfBUBMeq(p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 p1748c064Var, byte[] bArr, int i) {
        return p1748c064Var.doFinal(bArr, i);
    }

    public static void WZrMlQaohcIXtNNu(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.p623db1b3 p623db1b3Var, byte[] bArr, byte b) {
        p623db1b3Var.mbb82a6de(bArr, b);
    }

    public static int YecLRajiApUfShdd(p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 p1748c064Var) {
        return p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.pa470a233.m5ca8859e(p1748c064Var);
    }

    public override int Generate(byte[] bArr, byte[] bArr2, bool z) {
        if ((12 + 8) % 8 > 0) {
        }
        int length = bArr.length * 8;
        if (length > 262144) {
            throw new java.lang.IllegalArgumentException("Number of bits per request limited to 262144");
        }
        if (this.f179d76db > 140737488355328L) {
            return -1;
        }
        if (z) {
            ZuxMthGlQkHpWnFr(this, bArr2);
            bArr2 = null;
        }
        if (bArr2 is not null) {
            aQRLuhnqeEGISglv(this, bArr2);
        }
        int length2 = bArr.length;
        byte[] bArr3 = new byte[length2];
        int length3 = bArr.length / this.f31ed86f0.length;
        ohVYhhUKSnaFPIFk(this.f46e97eb4, new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6(this.f2e5298ce));
        for (int i = 0; i < length3; i++) {
            p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 p1748c064Var = this.f46e97eb4;
            byte[] bArr4 = this.f31ed86f0;
            WqZhAqupLfuzHegW(p1748c064Var, bArr4, 0, bArr4.length);
            SWBqMYyFhVScAnKh(this.f46e97eb4, this.f31ed86f0, 0);
            byte[] bArr5 = this.f31ed86f0;
            rxLtogPzZrpTJAXK(bArr5, 0, bArr3, bArr5.length * i, bArr5.length);
        }
        byte[] bArr6 = this.f31ed86f0;
        if (bArr6.length * length3 < length2) {
            SkbTMMZhhqLqpQSh(this.f46e97eb4, bArr6, 0, bArr6.length);
            sUsWJHaWYfBUBMeq(this.f46e97eb4, this.f31ed86f0, 0);
            byte[] bArr7 = this.f31ed86f0;
            CxLPYMoaDFtMyrnS(bArr7, 0, bArr3, bArr7.length * length3, length2 - (length3 * bArr7.length));
        }
        nJisaQZdtSoOtadV(this, bArr2);
        this.f179d76db++;
        bdTTEpwKOXpJiHai(bArr3, 0, bArr, 0, bArr.length);
        return length;
    }

    public override int GetBlockSize() {
        return this.f31ed86f0.length * 8;
    }

    public override void Reseed(byte[] bArr) {
        if ((6 + 18) % 18 > 0) {
        }
        kLdwYbrpFfFSApVe(this, XufKdSBNtbuAvYFC(bPvuDMIdmrsZyXHE(this), bArr));
        this.f179d76db = 1L;
    }
}

