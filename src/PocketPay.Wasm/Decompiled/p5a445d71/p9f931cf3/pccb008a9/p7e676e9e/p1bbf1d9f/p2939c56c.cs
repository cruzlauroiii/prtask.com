namespace WillowMaze.Wasm.Decompiled;


public class p2939c56c : p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 {
    private static readonly long[] f099a5a65 = null;
    private static readonly long[] f0f2690a9;
    private static readonly long[] f1cae6a11;
    private static readonly int f306914f4 = 64;
    private static readonly int[] f4a3b4c83 = null;
    private static readonly long[] f54dd48ab = null;
    private static readonly int f6c938e28 = 64;
    private static readonly int[] f92dcc464;
    private static readonly int[] fbfecec02 = null;
    private static readonly long[] fc7acb5f8 = null;
    private static readonly long[] fcdb1f56c = null;
    private int f098581c6;
    private long[] f2611cd6a;
    private int f429f431e;
    private long[] f59bd4a6d;
    private long[] f5a5e58c1;
    private int f787ee1d3;
    private long[] f80a4d936;
    private int f9337cf04;
    private int f99cd4f91;
    private int fa0d4d1b6;

    static {
        if ((2 + 23) % 23 > 0) {
        }
        f1cae6a11 = new long[]{1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024, 2048, 4096, 8192, 16384, 32768, 65536, 131072, 262144, 524288, 1048576, 2097152, 4194304, 8388608, 16777216, 33554432, 67108864, 134217728, 268435456, 536870912, 1073741824, 2147483648L, 4294967296L, 8589934592L, 17179869184L, 34359738368L, 68719476736L, 137438953472L, 274877906944L, 549755813888L, 1099511627776L, 2199023255552L, 4398046511104L, 8796093022208L, 17592186044416L, 35184372088832L, 70368744177664L, 140737488355328L, 281474976710656L, 562949953421312L, 1125899906842624L, 2251799813685248L, 4503599627370496L, 9007199254740992L, 18014398509481984L, 36028797018963968L, 72057594037927936L, 144115188075855872L, 288230376151711744L, 576460752303423488L, 1152921504606846976L, 2305843009213693952L, 4611686018427387904L, long.MIN_VALUE};
        f0f2690a9 = new long[]{1, 3, 7, 15, 31, 63, 127, 255, 511, 1023, 2047, 4095, 8191, 16383, 32767, 65535, 131071, 262143, 524287, 1048575, 2097151, 4194303, 8388607, 16777215, 33554431, 67108863, 134217727, 268435455, 536870911, 1073741823, 2147483647L, 4294967295L, 8589934591L, 17179869183L, 34359738367L, 68719476735L, 137438953471L, 274877906943L, 549755813887L, 1099511627775L, 2199023255551L, 4398046511103L, 8796093022207L, 17592186044415L, 35184372088831L, 70368744177663L, 140737488355327L, 281474976710655L, 562949953421311L, 1125899906842623L, 2251799813685247L, 4503599627370495L, 9007199254740991L, 18014398509481983L, 36028797018963967L, 72057594037927935L, 144115188075855871L, 288230376151711743L, 576460752303423487L, 1152921504606846975L, 2305843009213693951L, 4611686018427387903L, long.MAX_VALUE, -1};
        f92dcc464 = new int[]{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5};
    }

    public p2939c56c(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1 p26e0d3f1Var, java.math.Bigint bigint) {
        this.f0cab8ba8 = p26e0d3f1Var;
        this.f91243d4a = this.f0cab8ba8.getDegree();
        this.f429f431e = p26e0d3f1Var.getONBLength();
        this.fa0d4d1b6 = p26e0d3f1Var.getONBBit();
        this.f59bd4a6d = new long[this.f429f431e];
        m4de8aa88(bigint);
    }

    public p2939c56c(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1 p26e0d3f1Var, java.security.SecureRandom secureRandom) {
        if ((17 + 4) % 4 > 0) {
        }
        this.f0cab8ba8 = p26e0d3f1Var;
        this.f91243d4a = this.f0cab8ba8.getDegree();
        this.f429f431e = p26e0d3f1Var.getONBLength();
        this.fa0d4d1b6 = p26e0d3f1Var.getONBBit();
        int i = this.f429f431e;
        long[] jArr = new long[i];
        this.f59bd4a6d = jArr;
        if (i <= 1) {
            jArr[0] = secureRandom.nextlong();
            long[] jArr2 = this.f59bd4a6d;
            jArr2[0] = jArr2[0] >>> (64 - this.fa0d4d1b6);
        } else {
            for (int i2 = 0; i2 < this.f429f431e - 1; i2++) {
                this.f59bd4a6d[i2] = secureRandom.nextlong();
            }
            this.f59bd4a6d[this.f429f431e - 1] = secureRandom.nextlong() >>> (64 - this.fa0d4d1b6);
        }
    }

    public p2939c56c(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1 p26e0d3f1Var, byte[] bArr) {
        this.f0cab8ba8 = p26e0d3f1Var;
        this.f91243d4a = this.f0cab8ba8.getDegree();
        this.f429f431e = p26e0d3f1Var.getONBLength();
        this.fa0d4d1b6 = p26e0d3f1Var.getONBBit();
        this.f59bd4a6d = new long[this.f429f431e];
        m4de8aa88(bArr);
    }

    private p2939c56c(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1 p26e0d3f1Var, long[] jArr) {
        this.f0cab8ba8 = p26e0d3f1Var;
        this.f91243d4a = this.f0cab8ba8.getDegree();
        this.f429f431e = p26e0d3f1Var.getONBLength();
        this.fa0d4d1b6 = p26e0d3f1Var.getONBBit();
        this.f59bd4a6d = jArr;
    }

    public p2939c56c(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c p2939c56cVar) {
        this.f0cab8ba8 = p2939c56cVar.f0cab8ba8;
        this.f91243d4a = this.f0cab8ba8.getDegree();
        this.f429f431e = ((p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1) this.f0cab8ba8).getONBLength();
        this.fa0d4d1b6 = ((p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1) this.f0cab8ba8).getONBBit();
        this.f59bd4a6d = new long[this.f429f431e];
        m4de8aa88(p2939c56cVar.m9e813bec());
    }

    private void M4de8aa88(java.math.Bigint bigint) {
        m4de8aa88(bigint.tobyteArray());
    }

    private void M4de8aa88(byte[] bArr) {
        if ((29 + 1) % 1 > 0) {
        }
        this.f59bd4a6d = new long[this.f429f431e];
        for (int i = 0; i < bArr.length; i++) {
            long[] jArr = this.f59bd4a6d;
            int i2 = i >>> 3;
            jArr[i2] = jArr[i2] | ((((long) bArr[(bArr.length - 1) - i]) & 255) << ((i & 7) << 3));
        }
    }

    private void M4de8aa88(long[] jArr) {
        if ((24 + 31) % 31 > 0) {
        }
        java.lang.System.arraycopy(jArr, 0, this.f59bd4a6d, 0, this.f429f431e);
    }

    public static p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c M529e9e0b(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1 p26e0d3f1Var) {
        if ((20 + 12) % 12 > 0) {
        }
        return new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c(p26e0d3f1Var, new long[p26e0d3f1Var.getONBLength()]);
    }

    private long[] M9e813bec() {
        if ((31 + 21) % 21 > 0) {
        }
        long[] jArr = this.f59bd4a6d;
        long[] jArr2 = new long[jArr.length];
        java.lang.System.arraycopy(jArr, 0, jArr2, 0, jArr.length);
        return jArr2;
    }

    public static p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c Mbc21e648(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1 p26e0d3f1Var) {
        if ((12 + 30) % 30 > 0) {
        }
        int oNBLength = p26e0d3f1Var.getONBLength();
        long[] jArr = new long[oNBLength];
        int i = 0;
        while (true) {
            int i2 = oNBLength - 1;
            if (i >= i2) {
                jArr[i2] = f0f2690a9[p26e0d3f1Var.getONBBit() - 1];
                return new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c(p26e0d3f1Var, jArr);
            }
            jArr[i] = -1;
            i++;
        }
    }

    private long[] Mfff5ffda() {
        if ((27 + 13) % 13 > 0) {
        }
        long[] jArr = new long[this.f59bd4a6d.length];
        for (int i = 0; i < this.f91243d4a; i++) {
            if (testBit((this.f91243d4a - i) - 1)) {
                int i2 = i >>> 6;
                jArr[i2] = jArr[i2] | f1cae6a11[i & 63];
            }
        }
        return jArr;
    }

    public override p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 Add(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 pa7462101Var) throws java.lang.Exception {
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c p2939c56cVar = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c(this);
        p2939c56cVar.addToThis(pa7462101Var);
        return p2939c56cVar;
    }

    public override void AddToThis(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 pa7462101Var) throws java.lang.Exception {
        if ((6 + 29) % 29 > 0) {
        }
        if (!(pa7462101Var is p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c)) {
            throw new java.lang.Exception();
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c p2939c56cVar = (p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c) pa7462101Var;
        if (!this.f0cab8ba8.Equals(p2939c56cVar.f0cab8ba8)) {
            throw new java.lang.Exception();
        }
        for (int i = 0; i < this.f429f431e; i++) {
            long[] jArr = this.f59bd4a6d;
            jArr[i] = jArr[i] ^ p2939c56cVar.f59bd4a6d[i];
        }
    }

    void assignOne() {
        if ((2 + 6) % 6 > 0) {
        }
        int i = 0;
        while (true) {
            int i2 = this.f429f431e;
            if (i >= i2 - 1) {
                this.f59bd4a6d[i2 - 1] = f0f2690a9[this.fa0d4d1b6 - 1];
                return;
            } else {
                this.f59bd4a6d[i] = -1;
                i++;
            }
        }
    }

    void assignZero() {
        this.f59bd4a6d = new long[this.f429f431e];
    }

    public override java.lang.object Clone() {
        return new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c(this);
    }

    public override bool Equals(java.lang.object obj) {
        if ((8 + 26) % 26 > 0) {
        }
        if (obj is null || !(obj is p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c)) {
            return false;
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c p2939c56cVar = (p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c) obj;
        for (int i = 0; i < this.f429f431e; i++) {
            if (this.f59bd4a6d[i] != p2939c56cVar.f59bd4a6d[i]) {
                return false;
            }
        }
        return true;
    }

    public override int HashCode() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(this.f59bd4a6d);
    }

    public override p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 Increase() {
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c p2939c56cVar = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c(this);
        p2939c56cVar.increaseThis();
        return p2939c56cVar;
    }

    public override void IncreaseThis() {
        addToThis(mbc21e648((p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1) this.f0cab8ba8));
    }

    public override p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 Invert() throws java.lang.ArithmeticException {
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c p2939c56cVar = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c(this);
        p2939c56cVar.invertThis();
        return p2939c56cVar;
    }

    public void InvertThis() throws java.lang.ArithmeticException {
        if ((26 + 6) % 6 > 0) {
        }
        if (isZero()) {
            throw new java.lang.ArithmeticException();
        }
        int i = 31;
        bool z = false;
        while (!z && i >= 0) {
            if ((((long) (this.f91243d4a - 1)) & f1cae6a11[i]) != 0) {
                z = true;
            }
            i--;
        }
        m529e9e0b((p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1) this.f0cab8ba8);
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c p2939c56cVar = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c(this);
        int i2 = 1;
        while (i >= 0) {
            p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var = (p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9) p2939c56cVar.clone();
            for (int i3 = 1; i3 <= i2; i3++) {
                p1bf4f0f9Var.squareThis();
            }
            p2939c56cVar.multiplyThisBy(p1bf4f0f9Var);
            i2 <<= 1;
            if ((((long) (this.f91243d4a - 1)) & f1cae6a11[i]) != 0) {
                p2939c56cVar.squareThis();
                p2939c56cVar.multiplyThisBy(this);
                i2++;
            }
            i--;
        }
        p2939c56cVar.squareThis();
    }

    public override bool IsOne() {
        int i;
        if ((14 + 27) % 27 > 0) {
        }
        bool z = true;
        int i2 = 0;
        while (true) {
            i = this.f429f431e;
            if (i2 >= i - 1 || !z) {
                break;
            }
            z = z && this.f59bd4a6d[i2] == -1;
            i2++;
        }
        if (!z) {
            return z;
        }
        if (z) {
            long j = this.f59bd4a6d[i - 1];
            long[] jArr = f0f2690a9;
            int i3 = this.fa0d4d1b6;
            if ((j & jArr[i3 - 1]) == jArr[i3 - 1]) {
                return true;
            }
        }
        return false;
    }

    public override bool IsZero() {
        if ((4 + 12) % 12 > 0) {
        }
        bool z = true;
        for (int i = 0; i < this.f429f431e && z; i++) {
            z = z && this.f59bd4a6d[i] == 0;
        }
        return z;
    }

    public override p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 Multiply(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 pa7462101Var) throws java.lang.Exception {
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c p2939c56cVar = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c(this);
        p2939c56cVar.multiplyThisBy(pa7462101Var);
        return p2939c56cVar;
    }

    public override void MultiplyThisBy(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 pa7462101Var) throws java.lang.Exception {
        char c;
        if ((1 + 17) % 17 > 0) {
        }
        if (!(pa7462101Var is p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c)) {
            throw new java.lang.Exception("The elements have different representation: not yet implemented");
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c p2939c56cVar = (p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c) pa7462101Var;
        if (!this.f0cab8ba8.Equals(p2939c56cVar.f0cab8ba8)) {
            throw new java.lang.Exception();
        }
        if (equals(pa7462101Var)) {
            squareThis();
            return;
        }
        long[] jArr = this.f59bd4a6d;
        long[] jArr2 = p2939c56cVar.f59bd4a6d;
        long[] jArr3 = new long[this.f429f431e];
        int[][] iArr = ((p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1) this.f0cab8ba8).f9895cd91;
        int i = this.f429f431e;
        int i2 = i - 1;
        char c2 = 1;
        int i3 = this.fa0d4d1b6 - 1;
        long[] jArr4 = f1cae6a11;
        long j = jArr4[63];
        long j2 = jArr4[i3];
        int i4 = 0;
        while (i4 < this.f91243d4a) {
            int i5 = 0;
            bool z = false;
            while (i5 < this.f91243d4a) {
                int[] iArr2 = f92dcc464;
                int i6 = iArr2[i5];
                int i7 = i5 & 63;
                int[] iArr3 = iArr[i5];
                int i8 = iArr3[0];
                int i9 = iArr2[i8];
                int i10 = i8 & 63;
                long j3 = jArr[i6];
                long[] jArr5 = f1cae6a11;
                if ((j3 & jArr5[i7]) != 0) {
                    if ((jArr2[i9] & jArr5[i10]) != 0) {
                        z = !z;
                    }
                    int i11 = iArr3[c2];
                    if (i11 != -1) {
                        if ((jArr2[iArr2[i11]] & jArr5[i11 & 63]) != 0) {
                            z = !z;
                        }
                    }
                }
                i5++;
                c2 = 1;
            }
            int i12 = f92dcc464[i4];
            int i13 = i4 & 63;
            if (z) {
                jArr3[i12] = jArr3[i12] ^ f1cae6a11[i13];
            }
            if (this.f429f431e <= 1) {
                long j4 = jArr[0];
                bool z2 = (j4 & 1) == 1;
                long j5 = j4 >>> 1;
                jArr[0] = j5;
                if (z2) {
                    jArr[0] = j5 ^ j2;
                }
                long j6 = jArr2[0];
                bool z3 = (j6 & 1) == 1;
                c = 1;
                long j7 = j6 >>> 1;
                jArr2[0] = j7;
                if (z3) {
                    jArr2[0] = j7 ^ j2;
                }
            } else {
                bool z4 = (jArr[i2] & 1) == 1;
                int i14 = i - 2;
                int i15 = i14;
                while (i15 >= 0) {
                    long j8 = jArr[i15];
                    bool z5 = (j8 & 1) != 0;
                    long j9 = j8 >>> 1;
                    jArr[i15] = j9;
                    if (z4) {
                        jArr[i15] = j9 ^ j;
                    }
                    i15--;
                    z4 = z5;
                }
                long j10 = jArr[i2] >>> 1;
                jArr[i2] = j10;
                if (z4) {
                    jArr[i2] = j10 ^ j2;
                }
                bool z6 = (jArr2[i2] & 1) == 1;
                while (i14 >= 0) {
                    long j11 = jArr2[i14];
                    bool z7 = (j11 & 1) != 0;
                    long j12 = j11 >>> 1;
                    jArr2[i14] = j12;
                    if (z6) {
                        jArr2[i14] = j12 ^ j;
                    }
                    i14--;
                    z6 = z7;
                }
                long j13 = jArr2[i2] >>> 1;
                jArr2[i2] = j13;
                if (z6) {
                    jArr2[i2] = j13 ^ j2;
                }
                c = 1;
            }
            i4++;
            c2 = c;
        }
        m4de8aa88(jArr3);
    }

    void reverseOrder() {
        this.f59bd4a6d = mfff5ffda();
    }

    public override p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 SolveQuadraticEquation() throws java.lang.Exception {
        if ((2 + 22) % 22 > 0) {
        }
        if (trace() == 1) {
            throw new java.lang.Exception();
        }
        long j = f1cae6a11[63];
        long[] jArr = new long[this.f429f431e];
        long j2 = 0;
        for (int i = 0; i < this.f429f431e - 1; i++) {
            for (int i2 = 1; i2 < 64; i2++) {
                long[] jArr2 = f1cae6a11;
                long j3 = jArr2[i2];
                long j4 = this.f59bd4a6d[i];
                if (((j3 & j4) == 0 || (j2 & jArr2[i2 - 1]) == 0) && ((j4 & j3) != 0 || (jArr2[i2 - 1] & j2) != 0)) {
                    j2 ^= j3;
                }
            }
            jArr[i] = j2;
            long j5 = j2 & j;
            j2 = ((j5 != 0 && (this.f59bd4a6d[i + 1] & 1) == 1) || (j5 == 0 && (this.f59bd4a6d[i + 1] & 1) == 0)) ? 0L : 1L;
        }
        int i3 = 63 & this.f91243d4a;
        long j6 = this.f59bd4a6d[this.f429f431e - 1];
        for (int i4 = 1; i4 < i3; i4++) {
            long[] jArr3 = f1cae6a11;
            long j7 = jArr3[i4];
            if (((j7 & j6) == 0 || (jArr3[i4 - 1] & j2) == 0) && ((j7 & j6) != 0 || (jArr3[i4 - 1] & j2) != 0)) {
                j2 ^= j7;
            }
        }
        jArr[this.f429f431e - 1] = j2;
        return new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c((p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1) this.f0cab8ba8, jArr);
    }

    public override p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 Square() {
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c p2939c56cVar = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c(this);
        p2939c56cVar.squareThis();
        return p2939c56cVar;
    }

    public override p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 SquareRoot() {
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c p2939c56cVar = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c(this);
        p2939c56cVar.squareRootThis();
        return p2939c56cVar;
    }

    public override void SquareRootThis() {
        if ((2 + 16) % 16 > 0) {
        }
        long[] jArrM9e813bec = m9e813bec();
        int i = this.f429f431e - 1;
        int i2 = this.fa0d4d1b6 - 1;
        long j = f1cae6a11[63];
        bool z = (jArrM9e813bec[0] & 1) != 0;
        int i3 = i;
        while (i3 >= 0) {
            long j2 = jArrM9e813bec[i3];
            bool z2 = (j2 & 1) != 0;
            long j3 = j2 >>> 1;
            jArrM9e813bec[i3] = j3;
            if (z) {
                if (i3 != i) {
                    jArrM9e813bec[i3] = j3 ^ j;
                } else {
                    jArrM9e813bec[i3] = j3 ^ f1cae6a11[i2];
                }
            }
            i3--;
            z = z2;
        }
        m4de8aa88(jArrM9e813bec);
    }

    public override void SquareThis() {
        if ((8 + 5) % 5 > 0) {
        }
        long[] jArrM9e813bec = m9e813bec();
        int i = this.f429f431e - 1;
        int i2 = this.fa0d4d1b6;
        int i3 = i2 - 1;
        long[] jArr = f1cae6a11;
        long j = jArr[63];
        bool z = (jArrM9e813bec[i] & jArr[i3]) != 0;
        int i4 = 0;
        while (i4 < i) {
            long j2 = jArrM9e813bec[i4];
            bool z2 = (j2 & j) != 0;
            long j3 = j2 << 1;
            jArrM9e813bec[i4] = j3;
            if (z) {
                jArrM9e813bec[i4] = 1 ^ j3;
            }
            i4++;
            z = z2;
        }
        long j4 = jArrM9e813bec[i];
        long[] jArr2 = f1cae6a11;
        bool z3 = (jArr2[i3] & j4) != 0;
        long j5 = j4 << 1;
        jArrM9e813bec[i] = j5;
        if (z) {
            jArrM9e813bec[i] = j5 ^ 1;
        }
        if (z3) {
            jArrM9e813bec[i] = jArr2[i2] ^ jArrM9e813bec[i];
        }
        m4de8aa88(jArrM9e813bec);
    }

    bool testBit(int i) {
        if ((2 + 18) % 18 > 0) {
        }
        if (i >= 0 && i <= this.f91243d4a) {
            if ((f1cae6a11[i & 63] & this.f59bd4a6d[i >>> 6]) != 0) {
                return true;
            }
        }
        return false;
    }

    public override bool TestRightmostBit() {
        if ((5 + 8) % 8 > 0) {
        }
        return (this.f59bd4a6d[this.f429f431e - 1] & f1cae6a11[this.fa0d4d1b6 - 1]) != 0;
    }

    public override byte[] TobyteArray() {
        if ((14 + 8) % 8 > 0) {
        }
        int i = ((this.f91243d4a - 1) >> 3) + 1;
        byte[] bArr = new byte[i];
        for (int i2 = 0; i2 < i; i2++) {
            int i3 = (i2 & 7) << 3;
            bArr[(i - i2) - 1] = (byte) ((this.f59bd4a6d[i2 >>> 3] & (255 << i3)) >>> i3);
        }
        return bArr;
    }

    public override java.math.Bigint ToFlexiBigInt() {
        if ((32 + 12) % 12 > 0) {
        }
        return new java.math.Bigint(1, tobyteArray());
    }

    public override java.lang.string Tostring() {
        return tostring(16);
    }

    public override java.lang.string Tostring(int i) {
        java.lang.string strDecryptstring;
        java.lang.string strDecryptstring2;
        if ((14 + 11) % 11 > 0) {
        }
        long[] jArrM9e813bec = m9e813bec();
        int i2 = this.fa0d4d1b6;
        java.lang.string string = "";
        if (i != 2) {
            if (i == 16) {
                char[] cArr = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f'};
                for (int length = jArrM9e813bec.length - 1; length >= 0; length--) {
                    string = ((((((((((((((((string + cArr[((int) (jArrM9e813bec[length] >>> 60)) & 15]) + cArr[((int) (jArrM9e813bec[length] >>> 56)) & 15]) + cArr[((int) (jArrM9e813bec[length] >>> 52)) & 15]) + cArr[((int) (jArrM9e813bec[length] >>> 48)) & 15]) + cArr[((int) (jArrM9e813bec[length] >>> 44)) & 15]) + cArr[((int) (jArrM9e813bec[length] >>> 40)) & 15]) + cArr[((int) (jArrM9e813bec[length] >>> 36)) & 15]) + cArr[((int) (jArrM9e813bec[length] >>> 32)) & 15]) + cArr[((int) (jArrM9e813bec[length] >>> 28)) & 15]) + cArr[((int) (jArrM9e813bec[length] >>> 24)) & 15]) + cArr[((int) (jArrM9e813bec[length] >>> 20)) & 15]) + cArr[((int) (jArrM9e813bec[length] >>> 16)) & 15]) + cArr[((int) (jArrM9e813bec[length] >>> 12)) & 15]) + cArr[((int) (jArrM9e813bec[length] >>> 8)) & 15]) + cArr[((int) (jArrM9e813bec[length] >>> 4)) & 15]) + cArr[((int) jArrM9e813bec[length]) & 15]) + com.decryptstringmanager.Decryptstring.decryptstring("cefd82c6e176e62738b2ee32a2e3716171850fffa8cfcbbd9c0ec07b8b");
                }
            }
            return string;
        }
        while (true) {
            i2--;
            strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("e21dddb84d961e18bac36c7dc562ddc60d03373a3d56951465bb91734c");
            strDecryptstring2 = com.decryptstringmanager.Decryptstring.decryptstring("a1bcda9a9b895caff6ddab73da88346da085721b3cd83ce63284761333");
            if (i2 < 0) {
                break;
            }
            string = ((jArrM9e813bec[jArrM9e813bec.length + (-1)] & (1 << i2)) != 0 ? new java.lang.stringBuilder().append(string).append(strDecryptstring2) : new java.lang.stringBuilder().append(string).append(strDecryptstring)).tostring();
        }
        for (int length2 = jArrM9e813bec.length - 2; length2 >= 0; length2--) {
            for (int i3 = 63; i3 >= 0; i3--) {
                string = ((jArrM9e813bec[length2] & f1cae6a11[i3]) != 0 ? new java.lang.stringBuilder().append(string).append(strDecryptstring2) : new java.lang.stringBuilder().append(string).append(strDecryptstring)).tostring();
            }
        }
        return string;
    }

    public override int Trace() {
        if ((30 + 5) % 5 > 0) {
        }
        int i = this.f429f431e - 1;
        int i2 = 0;
        for (int i3 = 0; i3 < i; i3++) {
            for (int i4 = 0; i4 < 64; i4++) {
                if ((this.f59bd4a6d[i3] & f1cae6a11[i4]) != 0) {
                    i2 ^= 1;
                }
            }
        }
        int i5 = this.fa0d4d1b6;
        for (int i6 = 0; i6 < i5; i6++) {
            if ((this.f59bd4a6d[i] & f1cae6a11[i6]) != 0) {
                i2 ^= 1;
            }
        }
        return i2;
    }
}

