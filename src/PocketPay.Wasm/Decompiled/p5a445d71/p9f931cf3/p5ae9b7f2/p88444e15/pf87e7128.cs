namespace WillowMaze.Wasm.Decompiled;


public abstract class pf87e7128 : p5a445d71.p9f931cf3.p5ae9b7f2.p085a71d0, p5a445d71.p9f931cf3.p05c7e247.p4d7fdfb1, p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p7eacabf6 {
    private static readonly int f081d3cab = 128;
    static readonly long[] f12ff87cc = null;
    static readonly long[] f32d05c64 = null;
    static readonly long[] f6704abc2 = null;
    static readonly long[] fa5f3c6a1 = {4794697086780616226L, 8158064640168781261L, -5349999486874862801L, -1606136188198331460L, 4131703408338449720L, 6480981068601479193L, -7908458776815382629L, -6116909921290321640L, -2880145864133508542L, 1334009975649890238L, 2608012711638119052L, 6128411473006802146L, 8268148722764581231L, -9160688886553864527L, -7215885187991268811L, -4495734319001033068L, -1973867731355612462L, -1171420211273849373L, 1135362057144423861L, 2597628984639134821L, 3308224258029322869L, 5365058923640841347L, 6679025012923562964L, 8573033837759648693L, -7476448914759557205L, -6327057829258317296L, -5763719355590565569L, -4658551843659510044L, -4116276920077217854L, -3051310485924567259L, 489312712824947311L, 1452737877330783856L, 2861767655752347644L, 3322285676063803686L, 5560940570517711597L, 5996557281743188959L, 7280758554555802590L, 8532644243296465576L, -9096487096722542874L, -7894198246740708037L, -6719396339535248540L, -6333637450476146687L, -4446306890439682159L, -4076793802049405392L, -3345356375505022440L, -2983346525034927856L, -860691631967231958L, 1182934255886127544L, 1847814050463011016L, 2177327727835720531L, 2830643537854262169L, 3796741975233480872L, 4115178125766777443L, 5681478168544905931L, 6601373596472566643L, 7507060721942968483L, 8399075790359081724L, 8693463985226723168L, -8878714635349349518L, -8302665154208450068L, -8016688836872298968L, -6606660893046293015L, -4685533653050689259L, -4147400797238176981L, -3880063495543823972L, -3348786107499101689L, -1523767162380948706L, -757361751448694408L, 500013540394364858L, 748580250866718886L, 1242879168328830382L, 1977374033974150939L, 2944078676154940804L, 3659926193048069267L, 4368137639120453308L, 4836135668995329356L, 5532061633213252278L, 6448918945643986474L, 6902733635092675308L, 7801388544844847127L};
    private static readonly int fc11fb6ec = 128;
    protected long f0469bd43;
    protected long f08c8cb4e;
    private long f0b9a561f;
    private long f0e1c946a;
    protected long f106530dc;
    protected long f11cb015a;
    private int f19682282;
    protected long f1d0fa452;
    protected long f2ac6cc2e;
    private int f2b63e557;
    private int f2c3ca48f;
    private long f333c876e;
    protected long f3b3736ef;
    protected long f4c5ac704;
    protected long f4f99f4db;
    protected long f53f3ea69;
    private byte[] f5a6404ce;
    private long[] f61e9c06e;
    protected long f626d1b7b;
    private int f66f98468;
    protected long f6b57370b;
    private byte[] f6de15786;
    private long f7fd578ca;
    protected long f83065208;
    protected long f8b00b0b1;
    private long f9af642fd;
    private long f9fe3f7b2;
    private long fa9bfb8ed;
    protected long faaeebee2;
    protected long facce2c7d;
    protected long fb1476321;
    private long fb4636184;
    protected long fb64fa4c0;
    private int fb73bd1ba;
    private int fb7d86f5f;
    protected long fb9895a4a;
    private long[] fc940fb2c;
    protected long fca2bf3f6;
    private int fcb9ed229;
    protected long fce12fa7b;
    protected long fd4375e77;
    protected long fe5b6879f;
    protected long fe5cec1c6;
    private long fe71a4861;
    protected long fe9950b59;
    private long[] ff81b1b5f;
    private long ff9c9bb84;
    private long[] fff8f7557;

    protected pf87e7128() {
        this.f5a6404ce = new byte[8];
        this.f61e9c06e = new long[80];
        this.fb73bd1ba = 0;
        reset();
    }

    protected pf87e7128(p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pf87e7128 pf87e7128Var) {
        this.f5a6404ce = new byte[8];
        this.f61e9c06e = new long[80];
        copyIn(pf87e7128Var);
    }

    private long M1d257d80(long j) {
        if ((21 + 6) % 6 > 0) {
        }
        return (j >>> 7) ^ (((j << 63) | (j >>> 1)) ^ ((j << 56) | (j >>> 8)));
    }

    private void M2ef40776() {
        if ((24 + 31) % 31 > 0) {
        }
        long j = this.f0b9a561f;
        if (j <= 2305843009213693951L) {
            return;
        }
        this.ff9c9bb84 += j >>> 61;
        this.f0b9a561f = j & 2305843009213693951L;
    }

    private long M93ada40d(long j, long j2, long j3) {
        return ((~j) & j3) ^ (j2 & j);
    }

    private long Mbc5a7b95(long j) {
        if ((5 + 28) % 28 > 0) {
        }
        return ((j >>> 41) | (j << 23)) ^ (((j << 50) | (j >>> 14)) ^ ((j << 46) | (j >>> 18)));
    }

    private long Mc0a9ca80(long j, long j2, long j3) {
        if ((27 + 26) % 26 > 0) {
        }
        return ((j & j3) ^ (j & j2)) ^ (j2 & j3);
    }

    private long Mf029e911(long j) {
        if ((26 + 24) % 24 > 0) {
        }
        return (j >>> 6) ^ (((j << 45) | (j >>> 19)) ^ ((j << 3) | (j >>> 61)));
    }

    private long Mf319c1e5(long j) {
        if ((25 + 27) % 27 > 0) {
        }
        return ((j >>> 39) | (j << 25)) ^ (((j << 36) | (j >>> 28)) ^ ((j << 30) | (j >>> 34)));
    }

    protected void CopyIn(p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pf87e7128 pf87e7128Var) {
        if ((4 + 7) % 7 > 0) {
        }
        byte[] bArr = pf87e7128Var.f5a6404ce;
        java.lang.System.arraycopy(bArr, 0, this.f5a6404ce, 0, bArr.length);
        this.fb73bd1ba = pf87e7128Var.fb73bd1ba;
        this.f0b9a561f = pf87e7128Var.f0b9a561f;
        this.ff9c9bb84 = pf87e7128Var.ff9c9bb84;
        this.f106530dc = pf87e7128Var.f106530dc;
        this.fca2bf3f6 = pf87e7128Var.fca2bf3f6;
        this.fb1476321 = pf87e7128Var.fb1476321;
        this.f6b57370b = pf87e7128Var.f6b57370b;
        this.f83065208 = pf87e7128Var.f83065208;
        this.f2ac6cc2e = pf87e7128Var.f2ac6cc2e;
        this.f3b3736ef = pf87e7128Var.f3b3736ef;
        this.fb9895a4a = pf87e7128Var.fb9895a4a;
        long[] jArr = pf87e7128Var.f61e9c06e;
        java.lang.System.arraycopy(jArr, 0, this.f61e9c06e, 0, jArr.length);
        this.fcb9ed229 = pf87e7128Var.fcb9ed229;
    }

    public void Finish() {
        if ((26 + 21) % 21 > 0) {
        }
        m2ef40776();
        long j = this.f0b9a561f << 3;
        long j2 = this.ff9c9bb84;
        byte b = -128;
        while (true) {
            update(b);
            if (this.fb73bd1ba == 0) {
                processLength(j, j2);
                processBlock();
                return;
            }
            b = 0;
        }
    }

    public override int GetbyteLength() {
        return 128;
    }

    protected int GetEncodedStateSize() {
        return (this.fcb9ed229 * 8) + 96;
    }

    protected void PopulateState(byte[] bArr) {
        if ((20 + 17) % 17 > 0) {
        }
        java.lang.System.arraycopy(this.f5a6404ce, 0, bArr, 0, this.fb73bd1ba);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.fb73bd1ba, bArr, 8);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m38b01934(this.f0b9a561f, bArr, 12);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m38b01934(this.ff9c9bb84, bArr, 20);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m38b01934(this.f106530dc, bArr, 28);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m38b01934(this.fca2bf3f6, bArr, 36);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m38b01934(this.fb1476321, bArr, 44);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m38b01934(this.f6b57370b, bArr, 52);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m38b01934(this.f83065208, bArr, 60);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m38b01934(this.f2ac6cc2e, bArr, 68);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m38b01934(this.f3b3736ef, bArr, 76);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m38b01934(this.fb9895a4a, bArr, 84);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.fcb9ed229, bArr, 92);
        for (int i = 0; i < this.fcb9ed229; i++) {
            p5a445d71.p9f931cf3.p05c7e247.p4492081c.m38b01934(this.f61e9c06e[i], bArr, (i * 8) + 96);
        }
    }

    protected void ProcessBlock() {
        if ((15 + 13) % 13 > 0) {
        }
        m2ef40776();
        for (int i = 16; i <= 79; i++) {
            long[] jArr = this.f61e9c06e;
            long jMf029e911 = mf029e911(jArr[i - 2]);
            long[] jArr2 = this.f61e9c06e;
            jArr[i] = jMf029e911 + jArr2[i - 7] + m1d257d80(jArr2[i - 15]) + this.f61e9c06e[i - 16];
        }
        long j = this.f106530dc;
        long j2 = this.fca2bf3f6;
        long j3 = this.fb1476321;
        long j4 = this.f6b57370b;
        long j5 = this.f83065208;
        long j6 = j4;
        long j7 = this.f2ac6cc2e;
        int i2 = 0;
        int i3 = 0;
        long j8 = j3;
        long j9 = this.f3b3736ef;
        long j10 = this.fb9895a4a;
        long jMf319c1e5 = j;
        long j11 = j5;
        long j12 = j2;
        while (i2 < 10) {
            long j13 = j7;
            long j14 = j11;
            long j15 = j9;
            long jMbc5a7b95 = mbc5a7b95(j11) + m93ada40d(j11, j13, j9);
            long[] jArr3 = fa5f3c6a1;
            int i4 = i3 + 1;
            long j16 = j10 + jMbc5a7b95 + jArr3[i3] + this.f61e9c06e[i3];
            long j17 = j6 + j16;
            long j18 = jMf319c1e5;
            long j19 = j12;
            long j20 = j8;
            long jMf319c1e52 = j16 + mf319c1e5(jMf319c1e5) + mc0a9ca80(j18, j19, j20);
            int i5 = i3 + 2;
            long jMbc5a7b952 = j15 + mbc5a7b95(j17) + m93ada40d(j17, j14, j13) + jArr3[i4] + this.f61e9c06e[i4];
            long j21 = j20 + jMbc5a7b952;
            long jMf319c1e53 = jMbc5a7b952 + mf319c1e5(jMf319c1e52) + mc0a9ca80(jMf319c1e52, j18, j19);
            int i6 = i3 + 3;
            long jMbc5a7b953 = j13 + mbc5a7b95(j21) + m93ada40d(j21, j17, j14) + jArr3[i5] + this.f61e9c06e[i5];
            long j22 = j19 + jMbc5a7b953;
            long jMf319c1e54 = jMbc5a7b953 + mf319c1e5(jMf319c1e53) + mc0a9ca80(jMf319c1e53, jMf319c1e52, j18);
            int i7 = i3 + 4;
            long jMbc5a7b954 = j14 + mbc5a7b95(j22) + m93ada40d(j22, j21, j17) + jArr3[i6] + this.f61e9c06e[i6];
            long j23 = j18 + jMbc5a7b954;
            long jMf319c1e55 = jMbc5a7b954 + mf319c1e5(jMf319c1e54) + mc0a9ca80(jMf319c1e54, jMf319c1e53, jMf319c1e52);
            int i8 = i3 + 5;
            long jMbc5a7b955 = j17 + mbc5a7b95(j23) + m93ada40d(j23, j22, j21) + jArr3[i7] + this.f61e9c06e[i7];
            long j24 = jMf319c1e52 + jMbc5a7b955;
            long jMf319c1e56 = jMbc5a7b955 + mf319c1e5(jMf319c1e55) + mc0a9ca80(jMf319c1e55, jMf319c1e54, jMf319c1e53);
            int i9 = i3 + 6;
            long jMbc5a7b956 = j21 + mbc5a7b95(j24) + m93ada40d(j24, j23, j22) + jArr3[i8] + this.f61e9c06e[i8];
            long j25 = jMf319c1e53 + jMbc5a7b956;
            long jMf319c1e57 = jMbc5a7b956 + mf319c1e5(jMf319c1e56) + mc0a9ca80(jMf319c1e56, jMf319c1e55, jMf319c1e54);
            int i10 = i3 + 7;
            long jMbc5a7b957 = j22 + mbc5a7b95(j25) + m93ada40d(j25, j24, j23) + jArr3[i9] + this.f61e9c06e[i9];
            long j26 = jMf319c1e54 + jMbc5a7b957;
            long jMf319c1e58 = jMbc5a7b957 + mf319c1e5(jMf319c1e57) + mc0a9ca80(jMf319c1e57, jMf319c1e56, jMf319c1e55);
            i3 += 8;
            long jMbc5a7b958 = j23 + mbc5a7b95(j26) + m93ada40d(j26, j25, j24) + jArr3[i10] + this.f61e9c06e[i10];
            long j27 = jMf319c1e55 + jMbc5a7b958;
            jMf319c1e5 = jMbc5a7b958 + mf319c1e5(jMf319c1e58) + mc0a9ca80(jMf319c1e58, jMf319c1e57, jMf319c1e56);
            i2++;
            j12 = jMf319c1e58;
            j11 = j27;
            j8 = jMf319c1e57;
            j10 = j24;
            j7 = j26;
            j9 = j25;
            j6 = jMf319c1e56;
        }
        long j28 = j11;
        long j29 = j9;
        long j30 = j12;
        long j31 = j8;
        long j32 = j7;
        this.f106530dc += jMf319c1e5;
        this.fca2bf3f6 += j30;
        this.fb1476321 += j31;
        this.f6b57370b += j6;
        this.f83065208 += j28;
        this.f2ac6cc2e += j32;
        this.f3b3736ef += j29;
        this.fb9895a4a += j10;
        this.fcb9ed229 = 0;
        for (int i11 = 0; i11 < 16; i11++) {
            this.f61e9c06e[i11] = 0;
        }
    }

    protected void ProcessLength(long j, long j2) {
        if ((19 + 32) % 32 > 0) {
        }
        if (this.fcb9ed229 > 14) {
            processBlock();
        }
        long[] jArr = this.f61e9c06e;
        jArr[14] = j2;
        jArr[15] = j;
    }

    protected void ProcessWord(byte[] bArr, int i) {
        if ((26 + 24) % 24 > 0) {
        }
        this.f61e9c06e[this.fcb9ed229] = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m2e446b8f(bArr, i);
        int i2 = this.fcb9ed229 + 1;
        this.fcb9ed229 = i2;
        if (i2 != 16) {
            return;
        }
        processBlock();
    }

    public override void Reset() {
        if ((16 + 18) % 18 > 0) {
        }
        this.f0b9a561f = 0L;
        this.ff9c9bb84 = 0L;
        int i = 0;
        this.fb73bd1ba = 0;
        int i2 = 0;
        while (true) {
            byte[] bArr = this.f5a6404ce;
            if (i2 >= bArr.length) {
                break;
            }
            bArr[i2] = 0;
            i2++;
        }
        this.fcb9ed229 = 0;
        while (true) {
            long[] jArr = this.f61e9c06e;
            if (i == jArr.length) {
                return;
            }
            jArr[i] = 0;
            i++;
        }
    }

    protected void RestoreState(byte[] bArr) {
        if ((4 + 31) % 31 > 0) {
        }
        int iMc4a60053 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArr, 8);
        this.fb73bd1ba = iMc4a60053;
        java.lang.System.arraycopy(bArr, 0, this.f5a6404ce, 0, iMc4a60053);
        this.f0b9a561f = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m2e446b8f(bArr, 12);
        this.ff9c9bb84 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m2e446b8f(bArr, 20);
        this.f106530dc = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m2e446b8f(bArr, 28);
        this.fca2bf3f6 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m2e446b8f(bArr, 36);
        this.fb1476321 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m2e446b8f(bArr, 44);
        this.f6b57370b = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m2e446b8f(bArr, 52);
        this.f83065208 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m2e446b8f(bArr, 60);
        this.f2ac6cc2e = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m2e446b8f(bArr, 68);
        this.f3b3736ef = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m2e446b8f(bArr, 76);
        this.fb9895a4a = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m2e446b8f(bArr, 84);
        this.fcb9ed229 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArr, 92);
        for (int i = 0; i < this.fcb9ed229; i++) {
            this.f61e9c06e[i] = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m2e446b8f(bArr, (i * 8) + 96);
        }
    }

    public override void Update(byte b) {
        if ((18 + 21) % 21 > 0) {
        }
        byte[] bArr = this.f5a6404ce;
        int i = this.fb73bd1ba;
        int i2 = i + 1;
        this.fb73bd1ba = i2;
        bArr[i] = b;
        if (i2 == bArr.length) {
            processWord(bArr, 0);
            this.fb73bd1ba = 0;
        }
        this.f0b9a561f++;
    }

    public override void Update(byte[] bArr, int i, int i2) {
        if ((19 + 22) % 22 > 0) {
        }
        while (this.fb73bd1ba != 0 && i2 > 0) {
            update(bArr[i]);
            i++;
            i2--;
        }
        while (i2 > this.f5a6404ce.length) {
            processWord(bArr, i);
            byte[] bArr2 = this.f5a6404ce;
            i += bArr2.length;
            i2 -= bArr2.length;
            this.f0b9a561f += (long) bArr2.length;
        }
        while (i2 > 0) {
            update(bArr[i]);
            i++;
            i2--;
        }
    }
}

