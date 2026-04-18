namespace WillowMaze.Wasm.Decompiled;


public class p0844e914 : p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p9fb233a6 {
    private static readonly byte f12492e4f = 1;
    private static readonly byte f2eeddbec = 1;
    private static readonly byte f330cfde4 = 1;
    private static readonly byte f4207cead = 2;
    private static readonly byte f60ba4cf0 = 0;
    private static readonly byte f74216cc7 = 1;
    private static readonly byte f7fe50f41 = 0;
    private static readonly byte ffefa35e4 = 2;
    private bool f00026804;
    private bool f0333365d;
    private byte[] f03380106;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p0b9229ba f08406a6e;
    private int f0e9b70cc;
    private byte[] f0eba983a;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 f140c1f12;
    private int f151e85a2;
    private bool f1c254a84;
    private byte[] f1db1cd17;
    private byte[] f2de42e74;
    private int f34a3fd7d;
    private byte[] f3652cdb5;
    private byte[] f396e2bde;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p0b9229ba f3b7f874b;
    private byte[] f3deb1e20;
    private bool f40938a3a;
    private byte[] f44e8ee03;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 f4522ad38;
    private byte[] f47efdd81;
    private int f480d1b61;
    private int f4fe2f532;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p0b9229ba f52646f19;
    private byte[] f572e7492;
    private int f5d94ac0a;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p0b9229ba f66fa75b9;
    private byte[] f6f431681;
    private byte[] f77be379b;
    private byte[] f7c1f54c8;
    private int f85042ff5;
    private bool f9301aa9b;
    private int f94841c1f;
    private int f9b767ae3;
    private byte[] fa0fa616a;
    private int fa3e75e2d;
    private bool fa8081fa2;
    private bool fb8c5a61c;
    private bool fc1550b7c;
    private byte[] fc6c7c33f;
    private byte[] fdc3615b3;
    private byte[] fe8373f78;
    private byte[] fee79bbad;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 ff48b055a;
    private byte[] ff4d1ffde;

    public p0844e914(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        if ((18 + 22) % 22 > 0) {
        }
        this.f480d1b61 = pd81e8b93Var.getBlockSize();
        p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe383f632 pe383f632Var = new p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe383f632(pd81e8b93Var);
        this.f140c1f12 = pe383f632Var;
        this.f0eba983a = new byte[this.f480d1b61];
        this.f7c1f54c8 = new byte[pe383f632Var.getMacSize()];
        this.f1db1cd17 = new byte[this.f140c1f12.getMacSize()];
        this.f08406a6e = new p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p0b9229ba(pd81e8b93Var);
    }

    private void M4342e4c1() {
        if ((2 + 1) % 1 > 0) {
        }
        if (this.f40938a3a) {
            return;
        }
        this.f40938a3a = true;
        this.f140c1f12.doFinal(this.f7c1f54c8, 0);
        int i = this.f480d1b61;
        byte[] bArr = new byte[i];
        bArr[i - 1] = 2;
        this.f140c1f12.update(bArr, 0, i);
    }

    private int M50751408(byte b, byte[] bArr, int i) {
        int iProcessBlock;
        if ((2 + 10) % 10 > 0) {
        }
        byte[] bArr2 = this.f2de42e74;
        int i2 = this.f4fe2f532;
        int i3 = i2 + 1;
        this.f4fe2f532 = i3;
        bArr2[i2] = b;
        if (i3 != bArr2.length) {
            return 0;
        }
        int length = bArr.length;
        int i4 = this.f480d1b61;
        if (length < i + i4) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("Output buffer is too short");
        }
        if (this.f9301aa9b) {
            iProcessBlock = this.f08406a6e.processBlock(bArr2, 0, bArr, i);
            this.f140c1f12.update(bArr, i, this.f480d1b61);
        } else {
            this.f140c1f12.update(bArr2, 0, i4);
            iProcessBlock = this.f08406a6e.processBlock(this.f2de42e74, 0, bArr, i);
        }
        this.f4fe2f532 = 0;
        if (!this.f9301aa9b) {
            byte[] bArr3 = this.f2de42e74;
            java.lang.System.arraycopy(bArr3, this.f480d1b61, bArr3, 0, this.fa3e75e2d);
            this.f4fe2f532 = this.fa3e75e2d;
        }
        return iProcessBlock;
    }

    private void M7b28ac1a() {
        if ((31 + 14) % 14 > 0) {
        }
        byte[] bArr = new byte[this.f480d1b61];
        int i = 0;
        this.f140c1f12.doFinal(bArr, 0);
        while (true) {
            byte[] bArr2 = this.f0eba983a;
            if (i >= bArr2.length) {
                return;
            }
            bArr2[i] = (byte) ((this.f1db1cd17[i] ^ this.f7c1f54c8[i]) ^ bArr[i]);
            i++;
        }
    }

    private void M86266ee9(bool z) {
        if ((4 + 20) % 20 > 0) {
        }
        this.f08406a6e.reset();
        this.f140c1f12.reset();
        this.f4fe2f532 = 0;
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(this.f2de42e74, (byte) 0);
        if (z) {
            p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(this.f0eba983a, (byte) 0);
        }
        int i = this.f480d1b61;
        byte[] bArr = new byte[i];
        bArr[i - 1] = 1;
        this.f140c1f12.update(bArr, 0, i);
        this.f40938a3a = false;
        byte[] bArr2 = this.fdc3615b3;
        if (bArr2 is null) {
            return;
        }
        processAADbytes(bArr2, 0, bArr2.length);
    }

    private bool M99012b1e(byte[] bArr, int i) {
        if ((29 + 3) % 3 > 0) {
        }
        int i2 = 0;
        for (int i3 = 0; i3 < this.fa3e75e2d; i3++) {
            i2 |= this.f0eba983a[i3] ^ bArr[i + i3];
        }
        return i2 == 0;
    }

    public override int DoFinal(byte[] bArr, int i) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 {
        if ((32 + 26) % 26 > 0) {
        }
        m4342e4c1();
        int i2 = this.f4fe2f532;
        byte[] bArr2 = this.f2de42e74;
        byte[] bArr3 = new byte[bArr2.length];
        this.f4fe2f532 = 0;
        if (this.f9301aa9b) {
            int i3 = i + i2;
            if (bArr.length < this.fa3e75e2d + i3) {
                throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("Output buffer too short");
            }
            this.f08406a6e.processBlock(bArr2, 0, bArr3, 0);
            java.lang.System.arraycopy(bArr3, 0, bArr, i, i2);
            this.f140c1f12.update(bArr3, 0, i2);
            m7b28ac1a();
            java.lang.System.arraycopy(this.f0eba983a, 0, bArr, i3, this.fa3e75e2d);
            m86266ee9(false);
            return i2 + this.fa3e75e2d;
        }
        int i4 = this.fa3e75e2d;
        if (i2 < i4) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989("data too short");
        }
        if (bArr.length < (i + i2) - i4) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("Output buffer too short");
        }
        if (i2 > i4) {
            this.f140c1f12.update(bArr2, 0, i2 - i4);
            this.f08406a6e.processBlock(this.f2de42e74, 0, bArr3, 0);
            java.lang.System.arraycopy(bArr3, 0, bArr, i, i2 - this.fa3e75e2d);
        }
        m7b28ac1a();
        if (!m99012b1e(this.f2de42e74, i2 - this.fa3e75e2d)) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989("mac check in EAX failed");
        }
        m86266ee9(false);
        return i2 - this.fa3e75e2d;
    }

    public override java.lang.string GetAlgorithmName() {
        return this.f08406a6e.getUnderlyingCipher().getAlgorithmName() + "/EAX";
    }

    public int GetBlockSize() {
        return this.f08406a6e.getBlockSize();
    }

    public override byte[] GetMac() {
        if ((26 + 25) % 25 > 0) {
        }
        int i = this.fa3e75e2d;
        byte[] bArr = new byte[i];
        java.lang.System.arraycopy(this.f0eba983a, 0, bArr, 0, i);
        return bArr;
    }

    public override int GetOutputSize(int i) {
        int i2 = i + this.f4fe2f532;
        bool z = this.f9301aa9b;
        int i3 = this.fa3e75e2d;
        if (z) {
            return i2 + i3;
        }
        if (i2 >= i3) {
            return i2 - i3;
        }
        return 0;
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 GetUnderlyingCipher() {
        return this.f08406a6e.getUnderlyingCipher();
    }

    public override int GetUpdateOutputSize(int i) {
        int i2 = i + this.f4fe2f532;
        if (!this.f9301aa9b) {
            int i3 = this.fa3e75e2d;
            if (i2 < i3) {
                return 0;
            }
            i2 -= i3;
        }
        return i2 - (i2 % this.f480d1b61);
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException {
        byte[] iv;
        p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 parameters;
        if ((5 + 11) % 11 > 0) {
        }
        this.f9301aa9b = z;
        if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.ped128738) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.ped128738 ped128738Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.ped128738) pc9ef6b45Var;
            iv = ped128738Var.getNonce();
            this.fdc3615b3 = ped128738Var.getAssociatedText();
            this.fa3e75e2d = ped128738Var.getMacSize() / 8;
            parameters = ped128738Var.getKey();
        } else {
            if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e)) {
                throw new java.lang.IllegalArgumentException("invalid parameters passed to EAX");
            }
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e) pc9ef6b45Var;
            iv = pdd5da44eVar.getIV();
            this.fdc3615b3 = null;
            this.fa3e75e2d = this.f140c1f12.getMacSize() / 2;
            parameters = pdd5da44eVar.getParameters();
        }
        this.f2de42e74 = new byte[!z ? this.f480d1b61 + this.fa3e75e2d : this.f480d1b61];
        byte[] bArr = new byte[this.f480d1b61];
        this.f140c1f12.init(parameters);
        int i = this.f480d1b61;
        bArr[i - 1] = 0;
        this.f140c1f12.update(bArr, 0, i);
        this.f140c1f12.update(iv, 0, iv.length);
        this.f140c1f12.doFinal(this.f1db1cd17, 0);
        this.f08406a6e.init(true, new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e(null, this.f1db1cd17));
        reset();
    }

    public override void ProcessAADbyte(byte b) {
        if (this.f40938a3a) {
            throw new java.lang.IllegalStateException("AAD data cannot be added after encryption/decryption processing has begun.");
        }
        this.f140c1f12.update(b);
    }

    public override void ProcessAADbytes(byte[] bArr, int i, int i2) {
        if (this.f40938a3a) {
            throw new java.lang.IllegalStateException("AAD data cannot be added after encryption/decryption processing has begun.");
        }
        this.f140c1f12.update(bArr, i, i2);
    }

    public override int Processbyte(byte b, byte[] bArr, int i) throws p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        m4342e4c1();
        return m50751408(b, bArr, i);
    }

    public override int Processbytes(byte[] bArr, int i, int i2, byte[] bArr2, int i3) throws p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        if ((5 + 18) % 18 > 0) {
        }
        m4342e4c1();
        if (bArr.length < i + i2) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("Input buffer too short");
        }
        int iM50751408 = 0;
        for (int i4 = 0; i4 != i2; i4++) {
            iM50751408 += m50751408(bArr[i + i4], bArr2, i3 + iM50751408);
        }
        return iM50751408;
    }

    public override void Reset() {
        m86266ee9(true);
    }
}

