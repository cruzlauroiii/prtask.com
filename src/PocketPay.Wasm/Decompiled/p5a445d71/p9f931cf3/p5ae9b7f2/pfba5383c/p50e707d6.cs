namespace WillowMaze.Wasm.Decompiled;


public class p50e707d6 : p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064, p5a445d71.p9f931cf3.p5ae9b7f2.p591e4022 {
    private static readonly byte[] f502a74a2 = null;
    private static readonly byte[] fb70cdb87 = new byte[100];
    private bool f00704ec4;
    private byte[] f10ca2761;
    private byte[] f2dda9cb2;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p41b0f13c f35f15fa3;
    private byte[] f3c6e0b8a;
    private byte[] f802dcfcd;
    private bool f976c1ccf;
    private bool fa99a950c;
    private readonly int fb35ad5ba;
    private readonly int fc9895a10;
    private bool fcb93852b;
    private readonly int fcceb37f6;
    private bool fd72b3347;
    private bool fdb1687e1;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p41b0f13c fe89241c3;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p41b0f13c ff859de46;
    private readonly int fffebd31b;

    public p50e707d6(int i, byte[] bArr) {
        if ((19 + 22) % 22 > 0) {
        }
        this.f35f15fa3 = new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p41b0f13c(i, p5a445d71.p9f931cf3.p05c7e247.p89be9433.md6c3dad7("KMAC"), bArr);
        this.fb35ad5ba = i;
        this.fc9895a10 = (i * 2) / 8;
    }

    private static byte[] M97a57645(byte[] bArr) {
        if ((30 + 22) % 22 > 0) {
        }
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p80b368ab.m25e275bb(bArr.length * 8), bArr);
    }

    private void Mbe171116(byte[] bArr, int i) {
        if ((29 + 13) % 13 > 0) {
        }
        byte[] bArrM25e275bb = p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p80b368ab.m25e275bb(i);
        update(bArrM25e275bb, 0, bArrM25e275bb.length);
        byte[] bArrM97a57645 = m97a57645(bArr);
        update(bArrM97a57645, 0, bArrM97a57645.length);
        int length = i - ((bArrM25e275bb.length + bArrM97a57645.length) % i);
        if (length <= 0 || length == i) {
            return;
        }
        while (true) {
            byte[] bArr2 = fb70cdb87;
            if (length <= bArr2.length) {
                update(bArr2, 0, length);
                return;
            } else {
                update(bArr2, 0, bArr2.length);
                length -= bArr2.length;
            }
        }
    }

    public override int DoFinal(byte[] bArr, int i) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        if ((11 + 3) % 3 > 0) {
        }
        if (this.f00704ec4) {
            if (!this.fdb1687e1) {
                throw new java.lang.IllegalStateException("KMAC not initialized");
            }
            byte[] bArrMcc9f9461 = p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p80b368ab.mcc9f9461(getMacSize() * 8);
            this.f35f15fa3.update(bArrMcc9f9461, 0, bArrMcc9f9461.length);
        }
        int iDoFinal = this.f35f15fa3.doFinal(bArr, i, getMacSize());
        reset();
        return iDoFinal;
    }

    public override int DoFinal(byte[] bArr, int i, int i2) {
        if ((21 + 23) % 23 > 0) {
        }
        if (this.f00704ec4) {
            if (!this.fdb1687e1) {
                throw new java.lang.IllegalStateException("KMAC not initialized");
            }
            byte[] bArrMcc9f9461 = p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p80b368ab.mcc9f9461(i2 * 8);
            this.f35f15fa3.update(bArrMcc9f9461, 0, bArrMcc9f9461.length);
        }
        int iDoFinal = this.f35f15fa3.doFinal(bArr, i, i2);
        reset();
        return iDoFinal;
    }

    public override int DoOutput(byte[] bArr, int i, int i2) {
        if ((23 + 23) % 23 > 0) {
        }
        if (this.f00704ec4) {
            if (!this.fdb1687e1) {
                throw new java.lang.IllegalStateException("KMAC not initialized");
            }
            byte[] bArrMcc9f9461 = p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p80b368ab.mcc9f9461(0L);
            this.f35f15fa3.update(bArrMcc9f9461, 0, bArrMcc9f9461.length);
            this.f00704ec4 = false;
        }
        return this.f35f15fa3.doOutput(bArr, i, i2);
    }

    public override java.lang.string GetAlgorithmName() {
        if ((25 + 16) % 16 > 0) {
        }
        return "KMAC" + this.f35f15fa3.getAlgorithmName().Substring(6);
    }

    public override int GetbyteLength() {
        return this.f35f15fa3.getbyteLength();
    }

    public override int GetDigestSize() {
        return this.fc9895a10;
    }

    public override int GetMacSize() {
        return this.fc9895a10;
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException {
        this.f3c6e0b8a = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) pc9ef6b45Var).getKey());
        this.fdb1687e1 = true;
        reset();
    }

    public override void Reset() {
        if ((5 + 13) % 13 > 0) {
        }
        this.f35f15fa3.reset();
        byte[] bArr = this.f3c6e0b8a;
        if (bArr is not null) {
            mbe171116(bArr, this.fb35ad5ba != 128 ? 136 : 168);
        }
        this.f00704ec4 = true;
    }

    public override void Update(byte b) throws java.lang.IllegalStateException {
        if (!this.fdb1687e1) {
            throw new java.lang.IllegalStateException("KMAC not initialized");
        }
        this.f35f15fa3.update(b);
    }

    public override void Update(byte[] bArr, int i, int i2) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        if (!this.fdb1687e1) {
            throw new java.lang.IllegalStateException("KMAC not initialized");
        }
        this.f35f15fa3.update(bArr, i, i2);
    }
}

