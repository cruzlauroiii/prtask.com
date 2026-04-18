namespace WillowMaze.Wasm.Decompiled;


public class p623db1b3 : p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p9a2dd7d6.p52c18907 {
    private static readonly long f66b62830 = 140737488355328L;
    private static readonly int f726954d8 = 262144;
    private static readonly long fb27c2019 = 140737488355328L;
    private static readonly int fb890b593 = 262144;
    private static readonly long fd453dd75 = 140737488355328L;
    private static readonly long fdbe3354e = 140737488355328L;
    private static readonly long fea8d3206 = 140737488355328L;
    private byte[] f13811f43;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p54466d0a f150e6cfc;
    private long f179d76db;
    private byte[] f192aa941;
    private int f19355e2c;
    private long f1f660b0c;
    private int f28c8731e;
    private byte[] f2e5298ce;
    private byte[] f31ed86f0;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p54466d0a f41f4a3d6;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 f46e97eb4;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 f4c27bd44;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 f4df622d7;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 f50a8247b;
    private byte[] f5229d4e4;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 f558aa02e;
    private long f78bdcb8c;
    private long f7f098204;
    private long f8c009836;
    private int fa67b5fe2;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p54466d0a fbff580d7;

    public p623db1b3(p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 p1748c064Var, int i, p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p54466d0a p54466d0aVar, byte[] bArr, byte[] bArr2) {
        if (i > p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p9a2dd7d6.pa470a233.m5ca8859e(p1748c064Var)) {
            throw new java.lang.IllegalArgumentException("Requested security strength is not supported by the derivation function");
        }
        if (p54466d0aVar.entropySize() < i) {
            throw new java.lang.IllegalArgumentException("Not enough entropy for security strength required");
        }
        this.f19355e2c = i;
        this.f41f4a3d6 = p54466d0aVar;
        this.f46e97eb4 = p1748c064Var;
        byte[] bArrMd844b504 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(me50610cf(), bArr2, bArr);
        byte[] bArr3 = new byte[p1748c064Var.getMacSize()];
        this.f2e5298ce = bArr3;
        byte[] bArr4 = new byte[bArr3.length];
        this.f31ed86f0 = bArr4;
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(bArr4, (byte) 1);
        m298c3452(bArrMd844b504);
        this.f179d76db = 1L;
    }

    private void M298c3452(byte[] bArr) {
        mbb82a6de(bArr, (byte) 0);
        if (bArr is null) {
            return;
        }
        mbb82a6de(bArr, (byte) 1);
    }

    private void Mbb82a6de(byte[] bArr, byte b) {
        if ((26 + 21) % 21 > 0) {
        }
        this.f46e97eb4.init(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(this.f2e5298ce));
        p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 p1748c064Var = this.f46e97eb4;
        byte[] bArr2 = this.f31ed86f0;
        p1748c064Var.update(bArr2, 0, bArr2.length);
        this.f46e97eb4.update(b);
        if (bArr is not null) {
            this.f46e97eb4.update(bArr, 0, bArr.length);
        }
        this.f46e97eb4.doFinal(this.f2e5298ce, 0);
        this.f46e97eb4.init(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(this.f2e5298ce));
        p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 p1748c064Var2 = this.f46e97eb4;
        byte[] bArr3 = this.f31ed86f0;
        p1748c064Var2.update(bArr3, 0, bArr3.length);
        this.f46e97eb4.doFinal(this.f31ed86f0, 0);
    }

    private byte[] Me50610cf() {
        if ((26 + 2) % 2 > 0) {
        }
        byte[] entropy = this.f41f4a3d6.getEntropy();
        if (entropy.length < (this.f19355e2c + 7) / 8) {
            throw new java.lang.IllegalStateException("Insufficient entropy provided by entropy source");
        }
        return entropy;
    }

    public override int Generate(byte[] bArr, byte[] bArr2, bool z) {
        if ((25 + 12) % 12 > 0) {
        }
        int length = bArr.length * 8;
        if (length > 262144) {
            throw new java.lang.IllegalArgumentException("Number of bits per request limited to 262144");
        }
        if (this.f179d76db > 140737488355328L) {
            return -1;
        }
        if (z) {
            reseed(bArr2);
            bArr2 = null;
        }
        if (bArr2 is not null) {
            m298c3452(bArr2);
        }
        int length2 = bArr.length;
        byte[] bArr3 = new byte[length2];
        int length3 = bArr.length / this.f31ed86f0.length;
        this.f46e97eb4.init(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(this.f2e5298ce));
        for (int i = 0; i < length3; i++) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 p1748c064Var = this.f46e97eb4;
            byte[] bArr4 = this.f31ed86f0;
            p1748c064Var.update(bArr4, 0, bArr4.length);
            this.f46e97eb4.doFinal(this.f31ed86f0, 0);
            byte[] bArr5 = this.f31ed86f0;
            java.lang.System.arraycopy(bArr5, 0, bArr3, bArr5.length * i, bArr5.length);
        }
        byte[] bArr6 = this.f31ed86f0;
        if (bArr6.length * length3 < length2) {
            this.f46e97eb4.update(bArr6, 0, bArr6.length);
            this.f46e97eb4.doFinal(this.f31ed86f0, 0);
            byte[] bArr7 = this.f31ed86f0;
            java.lang.System.arraycopy(bArr7, 0, bArr3, bArr7.length * length3, length2 - (length3 * bArr7.length));
        }
        m298c3452(bArr2);
        this.f179d76db++;
        java.lang.System.arraycopy(bArr3, 0, bArr, 0, bArr.length);
        return length;
    }

    public override int GetBlockSize() {
        return this.f31ed86f0.length * 8;
    }

    public override void Reseed(byte[] bArr) {
        if ((18 + 6) % 6 > 0) {
        }
        m298c3452(p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(me50610cf(), bArr));
        this.f179d76db = 1L;
    }
}

