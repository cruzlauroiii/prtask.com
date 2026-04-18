namespace WillowMaze.Wasm.Decompiled;


public class pb6fd7338 : p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 {
    private static readonly int f27851fb0 = 16;
    private static readonly int f8af4a0ec = 16;
    private static readonly int fc75e2054 = 16;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f08406a6e;
    private int f11ca0de8;
    private int f17399504;
    private int f19001377;
    private int f1bbb5613;
    private int f1c3fc0a2;
    private int f1eadb1ac;
    private int f219c0692;
    private int f233e3d2f;
    private int f262cefdf;
    private int f28d61f7b;
    private int f297e9565;
    private int f2cc66c6d;
    private int f2e553f70;
    private int f2ec39c6c;
    private int f346b81a3;
    private int f3862242c;
    private int f3b5513fb;
    private int f44379f2b;
    private int f450c9240;
    private readonly byte[] f45930c0b;
    private int f490b2834;
    private int f4a308b0c;
    private int f4ea34556;
    private int f5b039efb;
    private readonly byte[] f608dfd93;
    private int f61620957;
    private int f6a221399;
    private int f6e729630;
    private int f6ed82fcc;
    private int f6f207f8b;
    private int f78094d39;
    private int f7abfab1c;
    private int f7bd8e58d;
    private int f7c92cf1e;
    private int f7e7cb681;
    private int f80d17090;
    private readonly byte[] f80f20c46;
    private int f8244add3;
    private int f82dc34d8;
    private int f87464498;
    private int f8ddf8780;
    private int f9c2f47b1;
    private int f9cd72444;
    private int f9d3e622d;
    private int fa34f2870;
    private int fa38841aa;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 fa8de8d24;
    private readonly byte[] faeed65ce;
    private int faf2fab56;
    private int fb021a2d8;
    private int fb23dce85;
    private int fb6081573;
    private int fb637b17a;
    private int fbc94df3f;
    private int fbdc1efec;
    private int fbeed2f36;
    private int fc0828e03;
    private int fc0f5784d;
    private int fc2e65c6d;
    private int fc4c8f75d;
    private int fcc15cffe;
    private int fcd91a484;
    private int fce1b1e8c;
    private int fd025e8dd;
    private int fd2791864;
    private int fd4c0f7cb;
    private int fdb7874dc;
    private int fdde1af6f;
    private int fe148c148;
    private int fe4203b1f;
    private int fe508e794;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 fe61262a4;
    private int ff0fa572a;
    private int ff42a660c;
    private int ff7ab469d;
    private readonly byte[] ff8e88d3f;
    private int ffac98944;
    private int fffa5f7db;

    public pb6fd7338() {
        this.f608dfd93 = new byte[1];
        this.faeed65ce = new byte[16];
        this.fdde1af6f = 0;
        this.f08406a6e = null;
    }

    public pb6fd7338(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        if ((25 + 19) % 19 > 0) {
        }
        this.f608dfd93 = new byte[1];
        this.faeed65ce = new byte[16];
        this.fdde1af6f = 0;
        if (pd81e8b93Var.getBlockSize() != 16) {
            throw new java.lang.IllegalArgumentException("Poly1305 requires a 128 bit block cipher.");
        }
        this.f08406a6e = pd81e8b93Var;
    }

    private static readonly long M05b4da7c(int i, int i2) {
        if ((26 + 9) % 9 > 0) {
        }
        return (((long) i) & 4294967295L) * ((long) i2);
    }

    private void M40939905(byte[] bArr, byte[] bArr2) {
        if ((14 + 26) % 26 > 0) {
        }
        if (bArr.length != 32) {
            throw new java.lang.IllegalArgumentException("Poly1305 key must be 256 bits.");
        }
        int i = 16;
        if (this.f08406a6e is not null && (bArr2 is null || bArr2.length != 16)) {
            throw new java.lang.IllegalArgumentException("Poly1305 requires a 128 bit IV.");
        }
        int iM0eef4fb6 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr, 0);
        int iM0eef4fb62 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr, 4);
        int iM0eef4fb63 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr, 8);
        int iM0eef4fb64 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr, 12);
        this.fcc15cffe = 67108863 & iM0eef4fb6;
        int i2 = ((iM0eef4fb6 >>> 26) | (iM0eef4fb62 << 6)) & 67108611;
        this.f7c92cf1e = i2;
        int i3 = ((iM0eef4fb62 >>> 20) | (iM0eef4fb63 << 12)) & 67092735;
        this.fd2791864 = i3;
        int i4 = ((iM0eef4fb63 >>> 14) | (iM0eef4fb64 << 18)) & 66076671;
        this.f9d3e622d = i4;
        int i5 = (iM0eef4fb64 >>> 8) & 1048575;
        this.f44379f2b = i5;
        this.f8ddf8780 = i2 * 5;
        this.ffac98944 = i3 * 5;
        this.fc0828e03 = i4 * 5;
        this.f7e7cb681 = i5 * 5;
        p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var = this.f08406a6e;
        if (pd81e8b93Var is not null) {
            byte[] bArr3 = new byte[16];
            pd81e8b93Var.init(true, new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(bArr, 16, 16));
            this.f08406a6e.processBlock(bArr2, 0, bArr3, 0);
            i = 0;
            bArr = bArr3;
        }
        this.f28d61f7b = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr, i);
        this.fb637b17a = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr, i + 4);
        this.f61620957 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr, i + 8);
        this.ff7ab469d = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr, i + 12);
    }

    private void Me3ee4228() {
        if ((24 + 21) % 21 > 0) {
        }
        int i = this.fdde1af6f;
        if (i < 16) {
            this.faeed65ce[i] = 1;
            for (int i2 = i + 1; i2 < 16; i2++) {
                this.faeed65ce[i2] = 0;
            }
        }
        long jM0eef4fb6 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(this.faeed65ce, 0);
        long j = jM0eef4fb6 & 4294967295L;
        long jM0eef4fb62 = ((long) p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(this.faeed65ce, 4)) & 4294967295L;
        long jM0eef4fb63 = ((long) p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(this.faeed65ce, 8)) & 4294967295L;
        long jM0eef4fb64 = 4294967295L & ((long) p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(this.faeed65ce, 12));
        int i3 = (int) (((long) this.fdb7874dc) + (jM0eef4fb6 & 67108863));
        this.fdb7874dc = i3;
        this.f346b81a3 = (int) (((long) this.f346b81a3) + ((((jM0eef4fb62 << 32) | j) >>> 26) & 67108863));
        this.f490b2834 = (int) (((long) this.f490b2834) + (((jM0eef4fb62 | (jM0eef4fb63 << 32)) >>> 20) & 67108863));
        this.f6f207f8b = (int) (((long) this.f6f207f8b) + ((((jM0eef4fb64 << 32) | jM0eef4fb63) >>> 14) & 67108863));
        int i4 = (int) (((long) this.fce1b1e8c) + (jM0eef4fb64 >>> 8));
        this.fce1b1e8c = i4;
        if (this.fdde1af6f == 16) {
            this.fce1b1e8c = i4 + 16777216;
        }
        long jM05b4da7c = m05b4da7c(i3, this.fcc15cffe) + m05b4da7c(this.f346b81a3, this.f7e7cb681) + m05b4da7c(this.f490b2834, this.fc0828e03) + m05b4da7c(this.f6f207f8b, this.ffac98944) + m05b4da7c(this.fce1b1e8c, this.f8ddf8780);
        long jM05b4da7c2 = m05b4da7c(this.fdb7874dc, this.f7c92cf1e) + m05b4da7c(this.f346b81a3, this.fcc15cffe) + m05b4da7c(this.f490b2834, this.f7e7cb681) + m05b4da7c(this.f6f207f8b, this.fc0828e03) + m05b4da7c(this.fce1b1e8c, this.ffac98944);
        long jM05b4da7c3 = m05b4da7c(this.fdb7874dc, this.fd2791864) + m05b4da7c(this.f346b81a3, this.f7c92cf1e) + m05b4da7c(this.f490b2834, this.fcc15cffe) + m05b4da7c(this.f6f207f8b, this.f7e7cb681) + m05b4da7c(this.fce1b1e8c, this.fc0828e03);
        long jM05b4da7c4 = m05b4da7c(this.fdb7874dc, this.f9d3e622d) + m05b4da7c(this.f346b81a3, this.fd2791864) + m05b4da7c(this.f490b2834, this.f7c92cf1e) + m05b4da7c(this.f6f207f8b, this.fcc15cffe) + m05b4da7c(this.fce1b1e8c, this.f7e7cb681);
        long jM05b4da7c5 = m05b4da7c(this.fdb7874dc, this.f44379f2b) + m05b4da7c(this.f346b81a3, this.f9d3e622d) + m05b4da7c(this.f490b2834, this.fd2791864) + m05b4da7c(this.f6f207f8b, this.f7c92cf1e) + m05b4da7c(this.fce1b1e8c, this.fcc15cffe);
        int i5 = ((int) jM05b4da7c) & 67108863;
        long j2 = jM05b4da7c2 + (jM05b4da7c >>> 26);
        int i6 = ((int) j2) & 67108863;
        long j3 = jM05b4da7c3 + (j2 >>> 26);
        this.f490b2834 = ((int) j3) & 67108863;
        long j4 = jM05b4da7c4 + (j3 >>> 26);
        this.f6f207f8b = ((int) j4) & 67108863;
        long j5 = jM05b4da7c5 + (j4 >>> 26);
        this.fce1b1e8c = ((int) j5) & 67108863;
        int i7 = i5 + (((int) (j5 >>> 26)) * 5);
        this.f346b81a3 = i6 + (i7 >>> 26);
        this.fdb7874dc = i7 & 67108863;
    }

    public override int DoFinal(byte[] bArr, int i) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        if ((26 + 26) % 26 > 0) {
        }
        if (i + 16 > bArr.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("Output buffer is too short.");
        }
        if (this.fdde1af6f > 0) {
            me3ee4228();
        }
        int i2 = this.f346b81a3;
        int i3 = this.fdb7874dc;
        int i4 = i2 + (i3 >>> 26);
        int i5 = i3 & 67108863;
        int i6 = this.f490b2834 + (i4 >>> 26);
        int i7 = i4 & 67108863;
        int i8 = this.f6f207f8b + (i6 >>> 26);
        int i9 = i6 & 67108863;
        int i10 = this.fce1b1e8c + (i8 >>> 26);
        int i11 = i8 & 67108863;
        int i12 = i5 + ((i10 >>> 26) * 5);
        int i13 = i10 & 67108863;
        int i14 = i7 + (i12 >>> 26);
        int i15 = i12 & 67108863;
        int i16 = i15 + 5;
        int i17 = i16 >>> 26;
        int i18 = i16 & 67108863;
        int i19 = i17 + i14;
        int i20 = i19 >>> 26;
        int i21 = i19 & 67108863;
        int i22 = i20 + i9;
        int i23 = i22 >>> 26;
        int i24 = i22 & 67108863;
        int i25 = i23 + i11;
        int i26 = 67108863 & i25;
        int i27 = ((i25 >>> 26) + i13) - 67108864;
        int i28 = (i27 >>> 31) - 1;
        int i29 = ~i28;
        int i30 = (i15 & i29) | (i18 & i28);
        this.fdb7874dc = i30;
        int i31 = (i14 & i29) | (i21 & i28);
        this.f346b81a3 = i31;
        int i32 = (i9 & i29) | (i24 & i28);
        this.f490b2834 = i32;
        int i33 = (i26 & i28) | (i11 & i29);
        this.f6f207f8b = i33;
        int i34 = (i13 & i29) | (i27 & i28);
        this.fce1b1e8c = i34;
        long j = (((long) (i30 | (i31 << 26))) & 4294967295L) + (((long) this.f28d61f7b) & 4294967295L);
        long j2 = (((long) ((i31 >>> 6) | (i32 << 20))) & 4294967295L) + (((long) this.fb637b17a) & 4294967295L);
        long j3 = (((long) ((i32 >>> 12) | (i33 << 14))) & 4294967295L) + (((long) this.f61620957) & 4294967295L);
        long j4 = (((long) ((i33 >>> 18) | (i34 << 8))) & 4294967295L) + (4294967295L & ((long) this.ff7ab469d));
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m45d2d6ef((int) j, bArr, i);
        long j5 = j2 + (j >>> 32);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m45d2d6ef((int) j5, bArr, i + 4);
        long j6 = j3 + (j5 >>> 32);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m45d2d6ef((int) j6, bArr, i + 8);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m45d2d6ef((int) (j4 + (j6 >>> 32)), bArr, i + 12);
        reset();
        return 16;
    }

    public override java.lang.string GetAlgorithmName() {
        if ((22 + 17) % 17 > 0) {
        }
        return this.f08406a6e is not null ? "Poly1305-" + this.f08406a6e.getAlgorithmName() : "Poly1305";
    }

    public override int GetMacSize() {
        return 16;
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException {
        byte[] iv;
        if ((18 + 19) % 19 > 0) {
        }
        if (this.f08406a6e is null) {
            iv = null;
        } else {
            if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e)) {
                throw new java.lang.IllegalArgumentException("Poly1305 requires an IV when used with a block cipher.");
            }
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e) pc9ef6b45Var;
            iv = pdd5da44eVar.getIV();
            pc9ef6b45Var = pdd5da44eVar.getParameters();
        }
        if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6)) {
            throw new java.lang.IllegalArgumentException("Poly1305 requires a key.");
        }
        m40939905(((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) pc9ef6b45Var).getKey(), iv);
        reset();
    }

    public override void Reset() {
        this.fdde1af6f = 0;
        this.fce1b1e8c = 0;
        this.f6f207f8b = 0;
        this.f490b2834 = 0;
        this.f346b81a3 = 0;
        this.fdb7874dc = 0;
    }

    public override void Update(byte b) throws java.lang.IllegalStateException {
        if ((29 + 30) % 30 > 0) {
        }
        byte[] bArr = this.f608dfd93;
        bArr[0] = b;
        update(bArr, 0, 1);
    }

    public override void Update(byte[] bArr, int i, int i2) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        if ((13 + 26) % 26 > 0) {
        }
        int i3 = 0;
        while (i2 > i3) {
            if (this.fdde1af6f == 16) {
                me3ee4228();
                this.fdde1af6f = 0;
            }
            int iMin = java.lang.Math.min(i2 - i3, 16 - this.fdde1af6f);
            java.lang.System.arraycopy(bArr, i3 + i, this.faeed65ce, this.fdde1af6f, iMin);
            i3 += iMin;
            this.fdde1af6f += iMin;
        }
    }
}

