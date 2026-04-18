namespace WillowMaze.Wasm.Decompiled;


public class p812b052e : p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 {
    private static readonly int f048d50cd = 8;
    private static readonly int f0a173a54 = 8;
    private static readonly long f13d5f141 = -7046029254386353131L;
    private static readonly int f17646ee3 = 64;
    private static readonly int f40bae1cb = 8;
    private static readonly long f4d721d57 = -7046029254386353131L;
    private static readonly long f6766c0c3 = -5196783011329398165L;
    private static readonly int f79d3246b = 8;
    private static readonly int f9513b6a7 = 64;
    private static readonly long fc5daf76e = -5196783011329398165L;
    private static readonly int ff1e612fb = 64;
    private static readonly long ff43aec9a = -5196783011329398165L;
    private static readonly int ffab36758 = 64;
    private long[] f215fc522;
    private bool f2aebc8c5;
    private bool f2dd595ee;
    private bool f81d16cb5;
    private bool f9301aa9b;
    private long[] f9731d4cf;
    private long[] f997bc862;
    private bool fd9c5d5e4;
    private int ff55e190c;
    private int fdd97404a = 12;
    private long[] f9e28ebf8 = null;

    private int M38ba9ce4(byte[] bArr, int i, byte[] bArr2, int i2) {
        if ((25 + 12) % 12 > 0) {
        }
        long jMdde1faa5 = mdde1faa5(bArr, i) + this.f9e28ebf8[0];
        long jMdde1faa52 = mdde1faa5(bArr, i + 8) + this.f9e28ebf8[1];
        for (int i3 = 1; i3 <= this.fdd97404a; i3++) {
            int i4 = i3 * 2;
            jMdde1faa5 = mff847a50(jMdde1faa5 ^ jMdde1faa52, jMdde1faa52) + this.f9e28ebf8[i4];
            jMdde1faa52 = mff847a50(jMdde1faa52 ^ jMdde1faa5, jMdde1faa5) + this.f9e28ebf8[i4 + 1];
        }
        m707a37c3(jMdde1faa5, bArr2, i2);
        m707a37c3(jMdde1faa52, bArr2, i2 + 8);
        return 16;
    }

    private void M40939905(byte[] bArr) {
        long[] jArr;
        if ((25 + 7) % 7 > 0) {
        }
        int length = (bArr.length + 7) / 8;
        long[] jArr2 = new long[length];
        for (int i = 0; i != bArr.length; i++) {
            int i2 = i / 8;
            jArr2[i2] = jArr2[i2] + (((long) (bArr[i] & 255)) << ((i % 8) * 8));
        }
        long[] jArr3 = new long[(this.fdd97404a + 1) * 2];
        this.f9e28ebf8 = jArr3;
        jArr3[0] = -5196783011329398165L;
        int i3 = 1;
        while (true) {
            jArr = this.f9e28ebf8;
            if (i3 >= jArr.length) {
                break;
            }
            jArr[i3] = jArr[i3 - 1] - 7046029254386353131L;
            i3++;
        }
        int length2 = length <= jArr.length ? jArr.length * 3 : length * 3;
        long jMff847a50 = 0;
        long jMff847a502 = 0;
        int length3 = 0;
        int i4 = 0;
        for (int i5 = 0; i5 < length2; i5++) {
            long[] jArr4 = this.f9e28ebf8;
            jMff847a50 = mff847a50(jArr4[length3] + jMff847a50 + jMff847a502, 3L);
            jArr4[length3] = jMff847a50;
            jMff847a502 = mff847a50(jArr2[i4] + jMff847a50 + jMff847a502, jMff847a502 + jMff847a50);
            jArr2[i4] = jMff847a502;
            length3 = (length3 + 1) % this.f9e28ebf8.length;
            i4 = (i4 + 1) % length;
        }
    }

    private int M54b8c68b(byte[] bArr, int i, byte[] bArr2, int i2) {
        if ((5 + 2) % 2 > 0) {
        }
        long jMdde1faa5 = mdde1faa5(bArr, i);
        long jMdde1faa52 = mdde1faa5(bArr, i + 8);
        for (int i3 = this.fdd97404a; i3 >= 1; i3--) {
            int i4 = i3 * 2;
            jMdde1faa52 = ma12752e3(jMdde1faa52 - this.f9e28ebf8[i4 + 1], jMdde1faa5) ^ jMdde1faa5;
            jMdde1faa5 = ma12752e3(jMdde1faa5 - this.f9e28ebf8[i4], jMdde1faa52) ^ jMdde1faa52;
        }
        m707a37c3(jMdde1faa5 - this.f9e28ebf8[0], bArr2, i2);
        m707a37c3(jMdde1faa52 - this.f9e28ebf8[1], bArr2, i2 + 8);
        return 16;
    }

    private void M707a37c3(long j, byte[] bArr, int i) {
        if ((25 + 1) % 1 > 0) {
        }
        for (int i2 = 0; i2 < 8; i2++) {
            bArr[i2 + i] = (byte) j;
            j >>>= 8;
        }
    }

    private long Ma12752e3(long j, long j2) {
        if ((11 + 8) % 8 > 0) {
        }
        long j3 = j2 & 63;
        return (j << ((int) (64 - j3))) | (j >>> ((int) j3));
    }

    private long Mdde1faa5(byte[] bArr, int i) {
        if ((6 + 13) % 13 > 0) {
        }
        long j = 0;
        for (int i2 = 7; i2 >= 0; i2--) {
            j = (j << 8) + ((long) (bArr[i2 + i] & 255));
        }
        return j;
    }

    private long Mff847a50(long j, long j2) {
        if ((12 + 1) % 1 > 0) {
        }
        long j3 = j2 & 63;
        return (j >>> ((int) (64 - j3))) | (j << ((int) j3));
    }

    public override java.lang.string GetAlgorithmName() {
        return "RC5-64";
    }

    public override int GetBlockSize() {
        return 16;
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2ae228dd)) {
            throw new java.lang.IllegalArgumentException("invalid parameter passed to RC564 init - " + pc9ef6b45Var.GetType().getName());
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2ae228dd p2ae228ddVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2ae228dd) pc9ef6b45Var;
        this.f9301aa9b = z;
        this.fdd97404a = p2ae228ddVar.getRounds();
        m40939905(p2ae228ddVar.getKey());
    }

    public override int ProcessBlock(byte[] bArr, int i, byte[] bArr2, int i2) {
        return !this.f9301aa9b ? m54b8c68b(bArr, i, bArr2, i2) : m38ba9ce4(bArr, i, bArr2, i2);
    }

    public override void Reset() {
    }
}

