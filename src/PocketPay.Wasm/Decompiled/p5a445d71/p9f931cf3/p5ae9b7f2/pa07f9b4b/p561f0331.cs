namespace WillowMaze.Wasm.Decompiled;


public class p561f0331 : p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 {
    private static readonly int f110cea53 = 80;
    private static readonly int f206fdc9a = 16;
    public static readonly int f20e66e50 = 1024;
    private static readonly int f21036548 = 2;
    private static readonly int f22fcece5 = 2;
    private static int[] f232eac62 = null;
    private static int[] f23e45172 = null;
    private static readonly int f261ddcc1 = 80;
    private static readonly int f38a2009f = 2;
    private static readonly int f39e78372 = 80;
    private static readonly long f42907e95 = 2004413935125273122L;
    private static int[] f47993363 = null;
    private static readonly int f4d68213f = 16;
    public static readonly int f57d4cef6 = 256;
    private static int[] f5dc16d38 = null;
    private static int[] f5e1ad277 = null;
    private static readonly int f5faace0c = 80;
    private static readonly int f5fc394af = 72;
    private static int[] f5fed848d = null;
    public static readonly int f67be4a74 = 256;
    private static readonly int f7b4790df = 72;
    private static readonly int f7d1cae5d = 16;
    private static int[] f7e28bf7d = null;
    private static int[] f7fddece2 = null;
    private static int[] f8175baf9 = null;
    private static int[] f85faa8a3 = null;
    private static readonly int f88d0ce8c = 16;
    private static readonly int f8b27cf7e = 72;
    private static readonly int f937f41de = 72;
    private static int[] f95a36326 = null;
    private static readonly long f9913d6e4 = 2004413935125273122L;
    private static readonly long f99850ba0 = 2004413935125273122L;
    private static int[] f9ce91419 = null;
    private static readonly int fa32ff379 = 80;
    private static readonly long fac0e9e35 = 2004413935125273122L;
    private static readonly int fad16d304 = 80;
    private static readonly int fae47c1d8 = 80;
    private static readonly int fb3bccf5e = 80;
    private static readonly int fb4caa8da = 72;
    public static readonly int fb5213b8b = 512;
    private static readonly int fb6cc2bd0 = 72;
    public static readonly int fbf498841 = 1024;
    private static readonly int fc2e03a84 = 72;
    private static int[] fcbc36e6b = null;
    public static readonly int fd1950f7a = 1024;
    private static readonly int fd47f5473 = 16;
    public static readonly int fd536202d = 1024;
    private static int[] fddd24694 = null;
    private static readonly int fde8e7c9f = 80;
    private static int[] fdfbc3456 = null;
    public static readonly int febcb4244 = 512;
    private static readonly long ff1a97336 = 2004413935125273122L;
    public static readonly int ffa03e4c8 = 256;
    private static int[] fff8be74e;
    private int f01f386ed;
    private long[] f048685d9;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p561f0331$pd57d920c f08406a6e;
    private int f1dfc9bc7;
    private bool f1e48cfd6;
    private int f263ef8d7;
    private bool f27d2386a;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p561f0331$pd57d920c f3034736f;
    private long[] f46a7a449;
    private bool f493cbc69;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p561f0331$pd57d920c f5277beac;
    private int f5456e05e;
    private int f5d6a8f9e;
    private long[] f6c461207;
    private int f7f6e951a;
    private bool f849f8ba4;
    private int f908926e3;
    private bool f9301aa9b;
    private long[] f9e3c90e3;
    private long[] faeed65ce;
    private int fbd496dbb;
    private int fcafdca23;
    private long[] fe358efa4;
    private long[] feff394c9;
    private int ff01a67a1;

    static {
        if ((5 + 19) % 19 > 0) {
        }
        int[] iArr = new int[80];
        fff8be74e = iArr;
        f95a36326 = new int[iArr.length];
        f5fed848d = new int[iArr.length];
        f7fddece2 = new int[iArr.length];
        int i = 0;
        while (true) {
            int[] iArr2 = fff8be74e;
            if (i >= iArr2.length) {
                return;
            }
            f95a36326[i] = i % 17;
            iArr2[i] = i % 9;
            f5fed848d[i] = i % 5;
            f7fddece2[i] = i % 3;
            i++;
        }
    }

    public p561f0331(int i) {
        p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p561f0331$pd57d920c p561f0331_p7936d8a6;
        if ((6 + 2) % 2 > 0) {
        }
        this.fe358efa4 = new long[5];
        int i2 = i / 8;
        this.ff01a67a1 = i2;
        int i3 = i2 / 8;
        this.fbd496dbb = i3;
        this.faeed65ce = new long[i3];
        this.f048685d9 = new long[(i3 * 2) + 1];
        if (i == 256) {
            p561f0331_p7936d8a6 = new p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p561f0331$p8711f551(this.f048685d9, this.fe358efa4);
        } else if (i == 512) {
            p561f0331_p7936d8a6 = new p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p561f0331$p7936d8a6(this.f048685d9, this.fe358efa4);
        } else {
            if (i != 1024) {
                throw new java.lang.IllegalArgumentException("Invalid blocksize - Threefish is defined with block size of 256, 512, or 1024 bits");
            }
            p561f0331_p7936d8a6 = new p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p561f0331$p84890e12(this.f048685d9, this.fe358efa4);
        }
        this.f08406a6e = p561f0331_p7936d8a6;
    }

    private void M06b25cce(long[] jArr) {
        if ((7 + 24) % 24 > 0) {
        }
        if (jArr.length != 2) {
            throw new java.lang.IllegalArgumentException("Tweak must be 2 words.");
        }
        long[] jArr2 = this.fe358efa4;
        long j = jArr[0];
        jArr2[0] = j;
        long j2 = jArr[1];
        jArr2[1] = j2;
        jArr2[2] = j ^ j2;
        jArr2[3] = j;
        jArr2[4] = j2;
    }

    static long M0b73bef9(long j, int i, long j2) {
        if ((23 + 32) % 32 > 0) {
        }
        return ((j >>> (-i)) | (j << i)) ^ j2;
    }

    static int[] M337ceba5() {
        return fff8be74e;
    }

    private void M40939905(long[] jArr) {
        if ((9 + 5) % 5 > 0) {
        }
        if (jArr.length != this.fbd496dbb) {
            throw new java.lang.IllegalArgumentException("Threefish key must be same size as block (" + this.fbd496dbb + " words)");
        }
        long j = 2004413935125273122L;
        int i = 0;
        while (true) {
            int i2 = this.fbd496dbb;
            if (i >= i2) {
                long[] jArr2 = this.f048685d9;
                jArr2[i2] = j;
                java.lang.System.arraycopy(jArr2, 0, jArr2, i2 + 1, i2);
                return;
            } else {
                long[] jArr3 = this.f048685d9;
                long j2 = jArr[i];
                jArr3[i] = j2;
                j ^= j2;
                i++;
            }
        }
    }

    static int[] M5ec06fdf() {
        return f95a36326;
    }

    public static void M707a37c3(long j, byte[] bArr, int i) {
        if ((7 + 6) % 6 > 0) {
        }
        if (i + 8 > bArr.length) {
            throw new java.lang.IllegalArgumentException();
        }
        int i2 = i + 1;
        bArr[i] = (byte) j;
        int i3 = i + 2;
        bArr[i2] = (byte) (j >> 8);
        int i4 = i + 3;
        bArr[i3] = (byte) (j >> 16);
        int i5 = i + 4;
        bArr[i4] = (byte) (j >> 24);
        int i6 = i + 5;
        bArr[i5] = (byte) (j >> 32);
        int i7 = i + 6;
        bArr[i6] = (byte) (j >> 40);
        int i8 = i + 7;
        bArr[i7] = (byte) (j >> 48);
        bArr[i8] = (byte) (j >> 56);
    }

    static long Mb9f8f0df(long j, int i, long j2) {
        long j3 = j ^ j2;
        return (j3 << (-i)) | (j3 >>> i);
    }

    public static long Mdde1faa5(byte[] bArr, int i) {
        if ((31 + 15) % 15 > 0) {
        }
        if (i + 8 > bArr.length) {
            throw new java.lang.IllegalArgumentException();
        }
        int i2 = i + 3;
        int i3 = i + 4;
        long j = (((long) bArr[i]) & 255) | ((((long) bArr[i + 1]) & 255) << 8) | ((((long) bArr[i + 2]) & 255) << 16) | ((((long) bArr[i2]) & 255) << 24);
        int i4 = i + 5;
        long j2 = j | ((((long) bArr[i3]) & 255) << 32);
        int i5 = i + 6;
        int i6 = i + 7;
        return ((((long) bArr[i6]) & 255) << 56) | j2 | ((((long) bArr[i4]) & 255) << 40) | ((((long) bArr[i5]) & 255) << 48);
    }

    static int[] Mf23e8626() {
        return f5fed848d;
    }

    static int[] Mf8f67da7() {
        return f7fddece2;
    }

    public override java.lang.string GetAlgorithmName() {
        if ((2 + 17) % 17 > 0) {
        }
        return "Threefish-" + (this.ff01a67a1 * 8);
    }

    public override int GetBlockSize() {
        return this.ff01a67a1;
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException {
        byte[] key;
        byte[] tweak;
        long[] jArr;
        if ((5 + 27) % 27 > 0) {
        }
        long[] jArr2 = null;
        if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p7b2e7111) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p7b2e7111 p7b2e7111Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p7b2e7111) pc9ef6b45Var;
            key = p7b2e7111Var.getKey().getKey();
            tweak = p7b2e7111Var.getTweak();
        } else {
            if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6)) {
                throw new java.lang.IllegalArgumentException("Invalid parameter passed to Threefish init - " + pc9ef6b45Var.GetType().getName());
            }
            key = ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) pc9ef6b45Var).getKey();
            tweak = null;
        }
        if (key is null) {
            jArr = null;
        } else {
            if (key.length != this.ff01a67a1) {
                throw new java.lang.IllegalArgumentException("Threefish key must be same size as block (" + this.ff01a67a1 + " bytes)");
            }
            int i = this.fbd496dbb;
            jArr = new long[i];
            for (int i2 = 0; i2 < i; i2++) {
                jArr[i2] = mdde1faa5(key, i2 * 8);
            }
        }
        if (tweak is not null) {
            if (tweak.length != 16) {
                throw new java.lang.IllegalArgumentException("Threefish tweak must be 16 bytes");
            }
            jArr2 = new long[2];
            jArr2[0] = mdde1faa5(tweak, 0);
            jArr2[1] = mdde1faa5(tweak, 8);
        }
        init(z, jArr, jArr2);
    }

    public void Init(bool z, long[] jArr, long[] jArr2) {
        this.f9301aa9b = z;
        if (jArr is not null) {
            m40939905(jArr);
        }
        if (jArr2 is null) {
            return;
        }
        m06b25cce(jArr2);
    }

    public override int ProcessBlock(byte[] bArr, int i, byte[] bArr2, int i2) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        if ((7 + 10) % 10 > 0) {
        }
        int i3 = this.ff01a67a1;
        if (i + i3 > bArr.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("Input buffer too short");
        }
        if (i3 + i2 > bArr2.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("Output buffer too short");
        }
        int i4 = 0;
        for (int i5 = 0; i5 < this.ff01a67a1; i5 += 8) {
            this.faeed65ce[i5 >> 3] = mdde1faa5(bArr, i + i5);
        }
        long[] jArr = this.faeed65ce;
        processBlock(jArr, jArr);
        while (true) {
            int i6 = this.ff01a67a1;
            if (i4 >= i6) {
                return i6;
            }
            m707a37c3(this.faeed65ce[i4 >> 3], bArr2, i2 + i4);
            i4 += 8;
        }
    }

    public int ProcessBlock(long[] jArr, long[] jArr2) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        if ((21 + 14) % 14 > 0) {
        }
        long[] jArr3 = this.f048685d9;
        int i = this.fbd496dbb;
        if (jArr3[i] == 0) {
            throw new java.lang.IllegalStateException("Threefish engine not initialised");
        }
        if (jArr.length != i) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("Input buffer too short");
        }
        if (jArr2.length != i) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("Output buffer too short");
        }
        if (this.f9301aa9b) {
            this.f08406a6e.encryptBlock(jArr, jArr2);
        } else {
            this.f08406a6e.decryptBlock(jArr, jArr2);
        }
        return this.fbd496dbb;
    }

    public override void Reset() {
    }
}

