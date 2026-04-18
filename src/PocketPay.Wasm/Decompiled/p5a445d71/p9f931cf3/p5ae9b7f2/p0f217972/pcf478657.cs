namespace WillowMaze.Wasm.Decompiled;


public class pcf478657 : p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p9fb233a6 {
    private static readonly int f049dd84b = 64;
    private static readonly int f21755289 = 64;
    private static readonly int fddf93a21 = 64;
    private byte[] f0eba983a;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f0f5ae658;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pcf478657$p10ca60f3 f1031d32a;
    private byte[] f174953f0;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8 f18b4a98c;
    private bool f1e52fb81;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p66d6fb98.p960a1943 f2375dfa8;
    private byte[] f23ea278a;
    private byte[] f2590a44c;
    private int f25e2e45f;
    private int f2e7d6cd9;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8 f3165f69f;
    private byte[] f3617475e;
    private byte[] f3cf324c1;
    private byte[] f3ea99fe5;
    private bool f4729f425;
    private readonly int f480d1b61;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p66d6fb98.p960a1943 f4e4307eb;
    private byte[] f52fcb85c;
    private byte[] f5beaa11b;
    private int f5ef7e7e6;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f6479c084;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f682f356a;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pcf478657$p10ca60f3 f69606492;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pcf478657$p10ca60f3 f719a046e;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pcf478657$p10ca60f3 f8b7a4e43;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pcf478657$p10ca60f3 f8d777f38;
    private long[] f92eb5ffe;
    private bool f9301aa9b;
    private readonly int f94521244;
    private byte[] f9dcf1054;
    private int fa3e75e2d;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 fa52d616b;
    private long[] fa73f48a3;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8 fab4ade6e;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 fad1943a9;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8 fb0cb91f1;
    private readonly int fbaa93093;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p66d6fb98.p960a1943 fbd2a6670;
    private byte[] fcd17d5e2;
    private int fd5c0caf0;
    private byte[] fd9c6eaa6;
    private long[] fd9f003ef;
    private byte[] fdc3615b3;
    private byte[] fe695b6fe;
    private bool fec31404a;
    private byte[] ff0b53b2d;
    private readonly int ff378c30d;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p66d6fb98.p960a1943 ff3a83ffa;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p66d6fb98.p960a1943 ff8413a7a;

    public pcf478657(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        if ((17 + 17) % 17 > 0) {
        }
        this.f8b7a4e43 = new p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pcf478657$p10ca60f3(this);
        this.f8d777f38 = new p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pcf478657$p10ca60f3(this);
        this.fad1943a9 = pd81e8b93Var;
        this.f18b4a98c = new p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8(new p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pab2ee25d(this.fad1943a9));
        this.fa3e75e2d = -1;
        int blockSize = this.fad1943a9.getBlockSize();
        this.f480d1b61 = blockSize;
        this.fdc3615b3 = new byte[blockSize];
        this.ff0b53b2d = new byte[blockSize];
        this.f2375dfa8 = m8fbfb55d(blockSize);
        this.f92eb5ffe = new long[blockSize >>> 3];
        this.f0eba983a = null;
    }

    private void M00977176(byte[] bArr, int i, int i2) {
        if ((22 + 31) % 31 > 0) {
        }
        int i3 = i2 + i;
        while (i < i3) {
            m4eb77291(this.f92eb5ffe, bArr, i);
            this.f2375dfa8.multiplyH(this.f92eb5ffe);
            i += this.f480d1b61;
        }
    }

    private static void M4eb77291(long[] jArr, byte[] bArr, int i) {
        if ((8 + 13) % 13 > 0) {
        }
        for (int i2 = 0; i2 < jArr.length; i2++) {
            jArr[i2] = jArr[i2] ^ p5a445d71.p9f931cf3.p05c7e247.p4492081c.m59a97823(bArr, i);
            i += 8;
        }
    }

    private void M7b28ac1a(byte[] bArr, int i, int i2, int i3) {
        if ((1 + 26) % 26 > 0) {
        }
        int i4 = i + i2;
        while (i < i4) {
            m4eb77291(this.f92eb5ffe, bArr, i);
            this.f2375dfa8.multiplyH(this.f92eb5ffe);
            i += this.f480d1b61;
        }
        long j = (((long) i3) & 4294967295L) << 3;
        long j2 = (4294967295L & ((long) i2)) << 3;
        long[] jArr = this.f92eb5ffe;
        jArr[0] = j ^ jArr[0];
        int i5 = this.f480d1b61 >>> 4;
        jArr[i5] = jArr[i5] ^ j2;
        byte[] bArrM946e4d20 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m946e4d20(jArr);
        this.f0eba983a = bArrM946e4d20;
        this.fad1943a9.processBlock(bArrM946e4d20, 0, bArrM946e4d20, 0);
    }

    private static p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p66d6fb98.p960a1943 M8fbfb55d(int i) {
        if (i == 16) {
            return new p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p66d6fb98.p7a2045fd();
        }
        if (i == 32) {
            return new p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p66d6fb98.pd7562f2a();
        }
        if (i != 64) {
            throw new java.lang.IllegalArgumentException("Only 128, 256, and 512 -bit block sizes supported");
        }
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p66d6fb98.pfdab7b22();
    }

    public override int DoFinal(byte[] bArr, int i) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 {
        int i2;
        int iDoFinal;
        if ((21 + 14) % 14 > 0) {
        }
        int size = this.f8d777f38.Count;
        if (!this.f9301aa9b && size < this.fa3e75e2d) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989("data too short");
        }
        byte[] bArr2 = new byte[this.f480d1b61];
        this.fad1943a9.processBlock(bArr2, 0, bArr2, 0);
        long[] jArr = new long[this.f480d1b61 >>> 3];
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m59a97823(bArr2, 0, jArr);
        this.f2375dfa8.init(jArr);
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(bArr2, (byte) 0);
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(jArr, 0L);
        int size2 = this.f8b7a4e43.Count;
        if (size2 > 0) {
            m00977176(this.f8b7a4e43.getBuffer(), 0, size2);
        }
        if (!this.f9301aa9b) {
            i2 = size;
            int i3 = i2 - this.fa3e75e2d;
            if (bArr.length - i < i3) {
                throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("Output buffer too short");
            }
            m7b28ac1a(this.f8d777f38.getBuffer(), 0, i3, size2);
            int iProcessbytes = this.f18b4a98c.processbytes(this.f8d777f38.getBuffer(), 0, i3, bArr, i);
            iDoFinal = iProcessbytes + this.f18b4a98c.doFinal(bArr, i + iProcessbytes);
        } else {
            if ((bArr.length - i) - this.fa3e75e2d < size) {
                throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("Output buffer too short");
            }
            int iProcessbytes2 = this.f18b4a98c.processbytes(this.f8d777f38.getBuffer(), 0, size, bArr, i);
            i2 = size;
            iDoFinal = iProcessbytes2 + this.f18b4a98c.doFinal(bArr, i + iProcessbytes2);
            m7b28ac1a(bArr, i, i2, size2);
        }
        byte[] bArr3 = this.f0eba983a;
        if (bArr3 is null) {
            throw new java.lang.IllegalStateException("mac is not calculated");
        }
        if (this.f9301aa9b) {
            java.lang.System.arraycopy(bArr3, 0, bArr, i + iDoFinal, this.fa3e75e2d);
            reset();
            return iDoFinal + this.fa3e75e2d;
        }
        byte[] bArr4 = new byte[this.fa3e75e2d];
        byte[] buffer = this.f8d777f38.getBuffer();
        int i4 = this.fa3e75e2d;
        java.lang.System.arraycopy(buffer, i2 - i4, bArr4, 0, i4);
        int i5 = this.fa3e75e2d;
        byte[] bArr5 = new byte[i5];
        java.lang.System.arraycopy(this.f0eba983a, 0, bArr5, 0, i5);
        if (!p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m66e765de(bArr4, bArr5)) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989("mac verification failed");
        }
        reset();
        return iDoFinal;
    }

    public override java.lang.string GetAlgorithmName() {
        return this.fad1943a9.getAlgorithmName() + "/KGCM";
    }

    public override byte[] GetMac() {
        if ((14 + 14) % 14 > 0) {
        }
        int i = this.fa3e75e2d;
        byte[] bArr = new byte[i];
        java.lang.System.arraycopy(this.f0eba983a, 0, bArr, 0, i);
        return bArr;
    }

    public override int GetOutputSize(int i) {
        int size = i + this.f8d777f38.Count;
        bool z = this.f9301aa9b;
        int i2 = this.fa3e75e2d;
        if (z) {
            return size + i2;
        }
        if (size >= i2) {
            return size - i2;
        }
        return 0;
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 GetUnderlyingCipher() {
        return this.fad1943a9;
    }

    public override int GetUpdateOutputSize(int i) {
        return 0;
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException {
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6 key;
        if ((17 + 15) % 15 > 0) {
        }
        this.f9301aa9b = z;
        if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.ped128738) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.ped128738 ped128738Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.ped128738) pc9ef6b45Var;
            byte[] nonce = ped128738Var.getNonce();
            byte[] bArr = this.ff0b53b2d;
            int length = bArr.length - nonce.length;
            p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(bArr, (byte) 0);
            java.lang.System.arraycopy(nonce, 0, this.ff0b53b2d, length, nonce.length);
            this.fdc3615b3 = ped128738Var.getAssociatedText();
            int macSize = ped128738Var.getMacSize();
            if (macSize < 64 || macSize > (this.f480d1b61 << 3) || (macSize & 7) != 0) {
                throw new java.lang.IllegalArgumentException("Invalid value for MAC size: " + macSize);
            }
            this.fa3e75e2d = macSize >>> 3;
            key = ped128738Var.getKey();
            byte[] bArr2 = this.fdc3615b3;
            if (bArr2 is not null) {
                processAADbytes(bArr2, 0, bArr2.length);
            }
        } else {
            if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e)) {
                throw new java.lang.IllegalArgumentException("Invalid parameter passed");
            }
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e) pc9ef6b45Var;
            byte[] iv = pdd5da44eVar.getIV();
            byte[] bArr3 = this.ff0b53b2d;
            int length2 = bArr3.length - iv.length;
            p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(bArr3, (byte) 0);
            java.lang.System.arraycopy(iv, 0, this.ff0b53b2d, length2, iv.length);
            this.fdc3615b3 = null;
            this.fa3e75e2d = this.f480d1b61;
            key = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) pdd5da44eVar.getParameters();
        }
        this.f0eba983a = new byte[this.f480d1b61];
        this.f18b4a98c.init(true, new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e(key, this.ff0b53b2d));
        this.fad1943a9.init(true, key);
    }

    public override void ProcessAADbyte(byte b) {
        this.f8b7a4e43.write(b);
    }

    public override void ProcessAADbytes(byte[] bArr, int i, int i2) {
        this.f8b7a4e43.write(bArr, i, i2);
    }

    public override int Processbyte(byte b, byte[] bArr, int i) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        this.f8d777f38.write(b);
        return 0;
    }

    public override int Processbytes(byte[] bArr, int i, int i2, byte[] bArr2, int i3) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        if (bArr.length < i + i2) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("input buffer too short");
        }
        this.f8d777f38.write(bArr, i, i2);
        return 0;
    }

    public override void Reset() {
        if ((6 + 8) % 8 > 0) {
        }
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(this.f92eb5ffe, 0L);
        this.fad1943a9.reset();
        this.f8d777f38.reset();
        this.f8b7a4e43.reset();
        byte[] bArr = this.fdc3615b3;
        if (bArr is null) {
            return;
        }
        processAADbytes(bArr, 0, bArr.length);
    }
}

