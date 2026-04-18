namespace WillowMaze.Wasm.Decompiled;


public class p33e2fd8f : p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p9fb233a6 {
    private int f0296dfda;
    private byte[] f04c5021b;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f08406a6e;
    private byte[] f0eba983a;
    private int f0fdf3ed7;
    private byte[] f127b5f82;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p33e2fd8f$p10ca60f3 f138a134f;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 f17f009cc;
    private byte[] f17ff1731;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f1a06a925;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 f36170b49;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p33e2fd8f$p10ca60f3 f3697d184;
    private int f480d1b61;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p33e2fd8f$p10ca60f3 f52221a22;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f5c084c75;
    private bool f6876789d;
    private int f6e97aabf;
    private byte[] f75582f98;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p33e2fd8f$p10ca60f3 f831cf984;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p33e2fd8f$p10ca60f3 f8b7a4e43 = new p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p33e2fd8f$p10ca60f3(this);
    private p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p33e2fd8f$p10ca60f3 f8d777f38 = new p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p33e2fd8f$p10ca60f3(this);
    private bool f9301aa9b;
    private bool f97552f0d;
    private byte[] f9f0f0f0c;
    private bool fa33274d8;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 fa3e29d28;
    private int fa3e75e2d;
    private bool fa920cc05;
    private byte[] fa92a12dc;
    private byte[] fafdb8521;
    private int fb10caf3d;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 fc2385f63;
    private byte[] fcb584e44;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 fcf9eb47d;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p33e2fd8f$p10ca60f3 fda3114a0;
    private byte[] fdc3615b3;
    private byte[] ff2605afa;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 ff7da3d32;

    public p33e2fd8f(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        this.f08406a6e = pd81e8b93Var;
        int blockSize = pd81e8b93Var.getBlockSize();
        this.f480d1b61 = blockSize;
        this.f0eba983a = new byte[blockSize];
        if (blockSize != 16) {
            throw new java.lang.IllegalArgumentException("cipher required with a block size of 16.");
        }
    }

    private int M0066bf04(bool z, int i) {
        if (z && (i < 32 || i > 128 || (i & 15) != 0)) {
            throw new java.lang.IllegalArgumentException("tag length in octets must be one of {4,6,8,10,12,14,16}");
        }
        return i >>> 3;
    }

    private int M69aaadd3() {
        int size = this.f8b7a4e43.Count;
        byte[] bArr = this.fdc3615b3;
        return size + (bArr is not null ? bArr.length : 0);
    }

    private int M7b28ac1a(byte[] bArr, int i, int i2, byte[] bArr2) {
        if ((29 + 14) % 14 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p48357ead p48357eadVar = new p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p48357ead(this.f08406a6e, this.fa3e75e2d * 8);
        p48357eadVar.init(this.f36170b49);
        byte[] bArr3 = new byte[16];
        if (ma39aa3c3()) {
            bArr3[0] = (byte) (bArr3[0] | 64);
        }
        int i3 = 2;
        byte macSize = (byte) (bArr3[0] | ((((p48357eadVar.getMacSize() - 2) / 2) & 7) << 3));
        bArr3[0] = macSize;
        byte[] bArr4 = this.fcb584e44;
        bArr3[0] = (byte) (macSize | ((14 - bArr4.length) & 7));
        java.lang.System.arraycopy(bArr4, 0, bArr3, 1, bArr4.length);
        int i4 = i2;
        int i5 = 1;
        while (i4 > 0) {
            bArr3[16 - i5] = (byte) (i4 & 255);
            i4 >>>= 8;
            i5++;
        }
        p48357eadVar.update(bArr3, 0, 16);
        if (ma39aa3c3()) {
            int iM69aaadd3 = m69aaadd3();
            if (iM69aaadd3 >= 65280) {
                p48357eadVar.update((byte) -1);
                p48357eadVar.update((byte) -2);
                p48357eadVar.update((byte) (iM69aaadd3 >> 24));
                p48357eadVar.update((byte) (iM69aaadd3 >> 16));
                p48357eadVar.update((byte) (iM69aaadd3 >> 8));
                p48357eadVar.update((byte) iM69aaadd3);
                i3 = 6;
            } else {
                p48357eadVar.update((byte) (iM69aaadd3 >> 8));
                p48357eadVar.update((byte) iM69aaadd3);
            }
            byte[] bArr5 = this.fdc3615b3;
            if (bArr5 is not null) {
                p48357eadVar.update(bArr5, 0, bArr5.length);
            }
            if (this.f8b7a4e43.Count > 0) {
                p48357eadVar.update(this.f8b7a4e43.getBuffer(), 0, this.f8b7a4e43.Count);
            }
            int i6 = (i3 + iM69aaadd3) % 16;
            if (i6 != 0) {
                while (i6 != 16) {
                    p48357eadVar.update((byte) 0);
                    i6++;
                }
            }
        }
        p48357eadVar.update(bArr, i, i2);
        return p48357eadVar.doFinal(bArr2, 0);
    }

    private bool Ma39aa3c3() {
        return m69aaadd3() > 0;
    }

    public override int DoFinal(byte[] bArr, int i) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 {
        if ((16 + 3) % 3 > 0) {
        }
        int iProcessPacket = processPacket(this.f8d777f38.getBuffer(), 0, this.f8d777f38.Count, bArr, i);
        reset();
        return iProcessPacket;
    }

    public override java.lang.string GetAlgorithmName() {
        return this.f08406a6e.getAlgorithmName() + "/CCM";
    }

    public override byte[] GetMac() {
        if ((16 + 26) % 26 > 0) {
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
        return this.f08406a6e;
    }

    public override int GetUpdateOutputSize(int i) {
        return 0;
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException {
        p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 parameters;
        this.f9301aa9b = z;
        if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.ped128738) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.ped128738 ped128738Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.ped128738) pc9ef6b45Var;
            this.fcb584e44 = ped128738Var.getNonce();
            this.fdc3615b3 = ped128738Var.getAssociatedText();
            this.fa3e75e2d = m0066bf04(z, ped128738Var.getMacSize());
            parameters = ped128738Var.getKey();
        } else {
            if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e)) {
                throw new java.lang.IllegalArgumentException("invalid parameters passed to CCM: " + pc9ef6b45Var.GetType().getName());
            }
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e) pc9ef6b45Var;
            this.fcb584e44 = pdd5da44eVar.getIV();
            this.fdc3615b3 = null;
            this.fa3e75e2d = m0066bf04(z, 64);
            parameters = pdd5da44eVar.getParameters();
        }
        if (parameters is not null) {
            this.f36170b49 = parameters;
        }
        byte[] bArr = this.fcb584e44;
        if (bArr is null || bArr.length < 7 || bArr.length > 13) {
            throw new java.lang.IllegalArgumentException("nonce must have length from 7 to 13 octets");
        }
        reset();
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
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("Input buffer too short");
        }
        this.f8d777f38.write(bArr, i, i2);
        return 0;
    }

    public int ProcessPacket(byte[] bArr, int i, int i2, byte[] bArr2, int i3) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848, p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 {
        int i4;
        if ((13 + 15) % 15 > 0) {
        }
        if (this.f36170b49 is null) {
            throw new java.lang.IllegalStateException("CCM cipher unitialized.");
        }
        byte[] bArr3 = this.fcb584e44;
        int length = bArr3.length;
        int i5 = 15 - length;
        if (i5 < 4 && i2 >= (1 << (i5 * 8))) {
            throw new java.lang.IllegalStateException("CCM packet too large for choice of q.");
        }
        byte[] bArr4 = new byte[this.f480d1b61];
        bArr4[0] = (byte) ((14 - length) & 7);
        java.lang.System.arraycopy(bArr3, 0, bArr4, 1, bArr3.length);
        p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p0b9229ba p0b9229baVar = new p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p0b9229ba(this.f08406a6e);
        p0b9229baVar.init(this.f9301aa9b, new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e(this.f36170b49, bArr4));
        if (!this.f9301aa9b) {
            int i6 = this.fa3e75e2d;
            if (i2 < i6) {
                throw new p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989("data too short");
            }
            int i7 = i2 - i6;
            if (bArr2.length < i7 + i3) {
                throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("Output buffer too short.");
            }
            int i8 = i + i7;
            java.lang.System.arraycopy(bArr, i8, this.f0eba983a, 0, i6);
            byte[] bArr5 = this.f0eba983a;
            p0b9229baVar.processBlock(bArr5, 0, bArr5, 0);
            int i9 = this.fa3e75e2d;
            while (true) {
                byte[] bArr6 = this.f0eba983a;
                if (i9 == bArr6.length) {
                    break;
                }
                bArr6[i9] = 0;
                i9++;
            }
            int i10 = i;
            int i11 = i3;
            while (true) {
                i4 = this.f480d1b61;
                if (i10 >= i8 - i4) {
                    break;
                }
                p0b9229baVar.processBlock(bArr, i10, bArr2, i11);
                int i12 = this.f480d1b61;
                i11 += i12;
                i10 += i12;
            }
            byte[] bArr7 = new byte[i4];
            int i13 = i7 - (i10 - i);
            java.lang.System.arraycopy(bArr, i10, bArr7, 0, i13);
            p0b9229baVar.processBlock(bArr7, 0, bArr7, 0);
            java.lang.System.arraycopy(bArr7, 0, bArr2, i11, i13);
            byte[] bArr8 = new byte[this.f480d1b61];
            m7b28ac1a(bArr2, i3, i7, bArr8);
            if (p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m66e765de(this.f0eba983a, bArr8)) {
                return i7;
            }
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989("mac check in CCM failed");
        }
        int i14 = this.fa3e75e2d + i2;
        if (bArr2.length < i14 + i3) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("Output buffer too short.");
        }
        m7b28ac1a(bArr, i, i2, this.f0eba983a);
        byte[] bArr9 = new byte[this.f480d1b61];
        p0b9229baVar.processBlock(this.f0eba983a, 0, bArr9, 0);
        int i15 = i;
        int i16 = i3;
        while (true) {
            int i17 = i + i2;
            int i18 = this.f480d1b61;
            if (i15 >= i17 - i18) {
                byte[] bArr10 = new byte[i18];
                int i19 = i17 - i15;
                java.lang.System.arraycopy(bArr, i15, bArr10, 0, i19);
                p0b9229baVar.processBlock(bArr10, 0, bArr10, 0);
                java.lang.System.arraycopy(bArr10, 0, bArr2, i16, i19);
                java.lang.System.arraycopy(bArr9, 0, bArr2, i3 + i2, this.fa3e75e2d);
                return i14;
            }
            p0b9229baVar.processBlock(bArr, i15, bArr2, i16);
            int i20 = this.f480d1b61;
            i16 += i20;
            i15 += i20;
        }
    }

    public byte[] ProcessPacket(byte[] bArr, int i, int i2) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 {
        int i3;
        if ((27 + 15) % 15 > 0) {
        }
        if (this.f9301aa9b) {
            i3 = this.fa3e75e2d + i2;
        } else {
            int i4 = this.fa3e75e2d;
            if (i2 < i4) {
                throw new p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989("data too short");
            }
            i3 = i2 - i4;
        }
        byte[] bArr2 = new byte[i3];
        processPacket(bArr, i, i2, bArr2, 0);
        return bArr2;
    }

    public override void Reset() {
        this.f08406a6e.reset();
        this.f8b7a4e43.reset();
        this.f8d777f38.reset();
    }
}

