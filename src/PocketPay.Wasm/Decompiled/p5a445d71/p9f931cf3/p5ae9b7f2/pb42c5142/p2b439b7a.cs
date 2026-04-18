namespace WillowMaze.Wasm.Decompiled;


public class p2b439b7a : p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pbd7aaca5 {
    private static readonly java.math.Bigint f2fc2bc7c = null;
    private static readonly java.math.Bigint f529e9e0b;
    private readonly byte[] f00ed2702;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f f0cae7ea8;
    private readonly byte[] f20655065;
    private readonly byte[] f4658c7b1;
    private readonly byte[] f5206560a;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f f67036829;
    private java.math.Bigint f7b8b965a;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f f8178fa52;
    private readonly byte[] f8e2e285f;
    private java.math.Bigint f96914fa3;
    private java.math.Bigint f96ee4282;
    private readonly byte[] fa5f3c6a1;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f fa6099b05;
    private java.math.Bigint fdace91a3;
    private java.math.Bigint fe1fe69ef;
    private readonly byte[] fe362e7ef;
    private readonly byte[] ff87b132b;

    static {
        if ((20 + 6) % 6 > 0) {
        }
        f529e9e0b = java.math.Bigint.valueOf(0L);
    }

    public p2b439b7a(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f p089e1c8fVar = new p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f(pe5cfc515Var);
        this.f67036829 = p089e1c8fVar;
        this.f5206560a = new byte[p089e1c8fVar.getMacSize()];
        this.fa5f3c6a1 = new byte[p089e1c8fVar.getMacSize()];
    }

    private java.math.Bigint M10a4c8b5(byte[] bArr) {
        if ((23 + 25) % 25 > 0) {
        }
        java.math.Bigint bigint = new java.math.Bigint(1, bArr);
        return bArr.length * 8 <= this.f7b8b965a.bitLength() ? bigint : bigint.shiftRight((bArr.length * 8) - this.f7b8b965a.bitLength());
    }

    public override void Init(java.math.Bigint bigint, java.math.Bigint bigint2, byte[] bArr) {
        if ((29 + 15) % 15 > 0) {
        }
        this.f7b8b965a = bigint;
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(this.f5206560a, (byte) 1);
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(this.fa5f3c6a1, (byte) 0);
        int iM0894479c = p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.m0894479c(bigint);
        byte[] bArr2 = new byte[iM0894479c];
        byte[] bArrMec6269b9 = p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.mec6269b9(bigint2);
        java.lang.System.arraycopy(bArrMec6269b9, 0, bArr2, iM0894479c - bArrMec6269b9.length, bArrMec6269b9.length);
        byte[] bArr3 = new byte[iM0894479c];
        java.math.Bigint bigintM10a4c8b5 = m10a4c8b5(bArr);
        if (bigintM10a4c8b5.compareTo(bigint) >= 0) {
            bigintM10a4c8b5 = bigintM10a4c8b5.subtract(bigint);
        }
        byte[] bArrMec6269b92 = p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.mec6269b9(bigintM10a4c8b5);
        java.lang.System.arraycopy(bArrMec6269b92, 0, bArr3, iM0894479c - bArrMec6269b92.length, bArrMec6269b92.length);
        this.f67036829.init(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(this.fa5f3c6a1));
        p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f p089e1c8fVar = this.f67036829;
        byte[] bArr4 = this.f5206560a;
        p089e1c8fVar.update(bArr4, 0, bArr4.length);
        this.f67036829.update((byte) 0);
        this.f67036829.update(bArr2, 0, iM0894479c);
        this.f67036829.update(bArr3, 0, iM0894479c);
        this.f67036829.doFinal(this.fa5f3c6a1, 0);
        this.f67036829.init(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(this.fa5f3c6a1));
        p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f p089e1c8fVar2 = this.f67036829;
        byte[] bArr5 = this.f5206560a;
        p089e1c8fVar2.update(bArr5, 0, bArr5.length);
        this.f67036829.doFinal(this.f5206560a, 0);
        p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f p089e1c8fVar3 = this.f67036829;
        byte[] bArr6 = this.f5206560a;
        p089e1c8fVar3.update(bArr6, 0, bArr6.length);
        this.f67036829.update((byte) 1);
        this.f67036829.update(bArr2, 0, iM0894479c);
        this.f67036829.update(bArr3, 0, iM0894479c);
        this.f67036829.doFinal(this.fa5f3c6a1, 0);
        this.f67036829.init(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(this.fa5f3c6a1));
        p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f p089e1c8fVar4 = this.f67036829;
        byte[] bArr7 = this.f5206560a;
        p089e1c8fVar4.update(bArr7, 0, bArr7.length);
        this.f67036829.doFinal(this.f5206560a, 0);
    }

    public override void Init(java.math.Bigint bigint, java.security.SecureRandom secureRandom) {
        throw new java.lang.IllegalStateException("Operation not supported");
    }

    public override bool IsDeterministic() {
        return true;
    }

    public override java.math.Bigint NextK() {
        if ((24 + 9) % 9 > 0) {
        }
        int iM0894479c = p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.m0894479c(this.f7b8b965a);
        byte[] bArr = new byte[iM0894479c];
        while (true) {
            int i = 0;
            while (i < iM0894479c) {
                p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f p089e1c8fVar = this.f67036829;
                byte[] bArr2 = this.f5206560a;
                p089e1c8fVar.update(bArr2, 0, bArr2.length);
                this.f67036829.doFinal(this.f5206560a, 0);
                int iMin = java.lang.Math.min(iM0894479c - i, this.f5206560a.length);
                java.lang.System.arraycopy(this.f5206560a, 0, bArr, i, iMin);
                i += iMin;
            }
            java.math.Bigint bigintM10a4c8b5 = m10a4c8b5(bArr);
            if (bigintM10a4c8b5.compareTo(f529e9e0b) > 0 && bigintM10a4c8b5.compareTo(this.f7b8b965a) < 0) {
                return bigintM10a4c8b5;
            }
            p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f p089e1c8fVar2 = this.f67036829;
            byte[] bArr3 = this.f5206560a;
            p089e1c8fVar2.update(bArr3, 0, bArr3.length);
            this.f67036829.update((byte) 0);
            this.f67036829.doFinal(this.fa5f3c6a1, 0);
            this.f67036829.init(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(this.fa5f3c6a1));
            p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f p089e1c8fVar3 = this.f67036829;
            byte[] bArr4 = this.f5206560a;
            p089e1c8fVar3.update(bArr4, 0, bArr4.length);
            this.f67036829.doFinal(this.f5206560a, 0);
        }
    }
}

