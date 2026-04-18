namespace WillowMaze.Wasm.Decompiled;


public class p561f0331 : p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 {
    private static readonly int f054c754e = 16;
    private static int[] f058df6ab = null;
    private static readonly int f0a067fa9 = 2;
    private static readonly int f18b9f073 = 80;
    private static int[] f1e2cf6e8 = null;
    private static readonly long f1e348d9c = 2004413935125273122L;
    private static readonly int f21036548 = 2;
    private static readonly int f261ddcc1 = 80;
    private static readonly int f39e78372 = 80;
    private static readonly int f3b123302 = 72;
    private static readonly int f3e955a91 = 16;
    private static readonly int f47bc1b87 = 80;
    private static readonly int f495d3a1d = 72;
    private static readonly int f4b1620e0 = 16;
    public static readonly int f4b595ae3 = 1024;
    private static int[] f57044dbb = null;
    public static readonly int f57d4cef6 = 256;
    private static int[] f5fed848d = null;
    private static readonly long f776c2f87 = 2004413935125273122L;
    private static readonly int f7b4790df = 72;
    private static int[] f7fddece2 = null;
    private static int[] f87fdd48a = null;
    private static readonly int f88d0ce8c = 16;
    private static int[] f95a36326 = null;
    private static int[] f96da83af = null;
    private static readonly int f979fba3d = 16;
    private static int[] f98b2f4e4 = null;
    private static readonly int fa0234283 = 80;
    private static readonly int fa1b59bec = 2;
    public static readonly int fb5213b8b = 512;
    private static readonly int fb6cc2bd0 = 72;
    private static readonly int fb8b6550b = 72;
    public static readonly int fbee3b54a = 256;
    public static readonly int fbf498841 = 1024;
    private static int[] fc76fbf87 = null;
    public static readonly int fc961a313 = 512;
    private static int[] fcc92f35a = null;
    private static readonly int fccdf0fae = 72;
    private static int[] fd61c2a68 = null;
    private static readonly long fd9e2d96c = 2004413935125273122L;
    private static readonly int fe4736d5d = 80;
    private static readonly int fe6191b22 = 72;
    private static readonly long ff1a97336 = 2004413935125273122L;
    private static readonly int ffd3604ab = 72;
    private static int[] fff8be74e;
    private long[] f035c0265;
    private long[] f048685d9;
    private p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p561f0331$pd57d920c f08406a6e;
    private int f0e22b455;
    private long[] f0f8c7b59;
    private long[] f29caaed1;
    private p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p561f0331$pd57d920c f2eaae323;
    private long[] f367f2f3b;
    private long[] f374c16e1;
    private p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p561f0331$pd57d920c f43cf1d87;
    private long[] f59718ec4;
    private bool f59bf74fa;
    private long[] f7dbdb788;
    private bool f7def9aab;
    private bool f9301aa9b;
    private int f9f6f7f8e;
    private long[] faeed65ce;
    private int fbd496dbb;
    private bool fc9091952;
    private long[] fe358efa4;
    private int feaeda304;
    private long[] fec81a708;
    private bool fed3ff115;
    private int ff01a67a1;
    private long[] ffd3dccb8;
    private p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p561f0331$pd57d920c fff86b373;
    private long[] fffbcfad9;

    static {
        if ((23 + 17) % 17 > 0) {
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
        if ((6 + 20) % 20 > 0) {
        }
        this.fe358efa4 = new long[5];
        int i2 = i / 8;
        this.ff01a67a1 = i2;
        int i3 = i2 / 8;
        this.fbd496dbb = i3;
        this.faeed65ce = new long[i3];
        this.f048685d9 = new long[(i3 * 2) + 1];
        if (i == 256) {
            this.f08406a6e = new p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p561f0331$p8711f551(this.f048685d9, this.fe358efa4);
        } else if (i == 512) {
            this.f08406a6e = new p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p561f0331$p7936d8a6(this.f048685d9, this.fe358efa4);
        } else {
            if (i != 1024) {
                throw new java.lang.IllegalArgumentException("Invalid blocksize - Threefish is defined with block size of 256, 512, or 1024 bits");
            }
            this.f08406a6e = new p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p561f0331$p84890e12(this.f048685d9, this.fe358efa4);
        }
    }

    public static void CkxSnskOpUtsxUiR(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p561f0331 p561f0331Var, long[] jArr) {
        p561f0331Var.m40939905(jArr);
    }

    public static void CkxSnskOpUtsxUiR(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p561f0331 p561f0331Var, long[] jArr, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CkxSnskOpUtsxUiR(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p561f0331 p561f0331Var, long[] jArr, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CkxSnskOpUtsxUiR(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p561f0331 p561f0331Var, long[] jArr, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DoNNHCkmJceYRkTl(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p561f0331$pd57d920c p561f0331_pd57d920c, long[] jArr, long[] jArr2) {
        p561f0331_pd57d920c.decryptBlock(jArr, jArr2);
    }

    public static void DoNNHCkmJceYRkTl(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p561f0331$pd57d920c p561f0331_pd57d920c, long[] jArr, long[] jArr2, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DoNNHCkmJceYRkTl(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p561f0331$pd57d920c p561f0331_pd57d920c, long[] jArr, long[] jArr2, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DoNNHCkmJceYRkTl(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p561f0331$pd57d920c p561f0331_pd57d920c, long[] jArr, long[] jArr2, bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IskdzMNTkXfyfmBI(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p7b2e7111 p7b2e7111Var, char c, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IskdzMNTkXfyfmBI(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p7b2e7111 p7b2e7111Var, int i, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IskdzMNTkXfyfmBI(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p7b2e7111 p7b2e7111Var, int i, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static byte[] IskdzMNTkXfyfmBI(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p7b2e7111 p7b2e7111Var) {
        return p7b2e7111Var.getTweak();
    }

    public static java.lang.stringBuilder JLLHyLWPEOkATcyw(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void JLLHyLWPEOkATcyw(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JLLHyLWPEOkATcyw(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JLLHyLWPEOkATcyw(java.lang.stringBuilder sb, java.lang.string str, short s, float f, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LSWBGXLntzAhJwEA(long j, byte[] bArr, int i) {
        m707a37c3(j, bArr, i);
    }

    public static void LSWBGXLntzAhJwEA(long j, byte[] bArr, int i, java.lang.string str, int i2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LSWBGXLntzAhJwEA(long j, byte[] bArr, int i, java.lang.string str, short s, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void LSWBGXLntzAhJwEA(long j, byte[] bArr, int i, java.lang.string str, short s, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder NWKeGCrFFXKJiMXb(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void NWKeGCrFFXKJiMXb(java.lang.stringBuilder sb, int i, float f, int i2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NWKeGCrFFXKJiMXb(java.lang.stringBuilder sb, int i, float f, short s, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void NWKeGCrFFXKJiMXb(java.lang.stringBuilder sb, int i, float f, short s, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string OVNvePDyMbZuzWhW(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void OVNvePDyMbZuzWhW(java.lang.stringBuilder sb, byte b, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OVNvePDyMbZuzWhW(java.lang.stringBuilder sb, char c, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OVNvePDyMbZuzWhW(java.lang.stringBuilder sb, int i, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string OxxbteNnQeSIEjWL(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void OxxbteNnQeSIEjWL(java.lang.stringBuilder sb, short s, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OxxbteNnQeSIEjWL(java.lang.stringBuilder sb, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OxxbteNnQeSIEjWL(java.lang.stringBuilder sb, short s, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string OzYSlZhrTFRcFtvX(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void OzYSlZhrTFRcFtvX(java.lang.stringBuilder sb, java.lang.string str, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OzYSlZhrTFRcFtvX(java.lang.stringBuilder sb, short s, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OzYSlZhrTFRcFtvX(java.lang.stringBuilder sb, bool z, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static long PIowBRYFJiLtSdIV(byte[] bArr, int i) {
        if ((18 + 2) % 2 > 0) {
        }
        return mdde1faa5(bArr, i);
    }

    public static void PIowBRYFJiLtSdIV(byte[] bArr, int i, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PIowBRYFJiLtSdIV(byte[] bArr, int i, char c, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PIowBRYFJiLtSdIV(byte[] bArr, int i, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SRslSdKXlxaleJTS(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p561f0331$pd57d920c p561f0331_pd57d920c, long[] jArr, long[] jArr2) {
        p561f0331_pd57d920c.encryptBlock(jArr, jArr2);
    }

    public static void SRslSdKXlxaleJTS(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p561f0331$pd57d920c p561f0331_pd57d920c, long[] jArr, long[] jArr2, java.lang.string str, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SRslSdKXlxaleJTS(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p561f0331$pd57d920c p561f0331_pd57d920c, long[] jArr, long[] jArr2, java.lang.string str, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SRslSdKXlxaleJTS(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p561f0331$pd57d920c p561f0331_pd57d920c, long[] jArr, long[] jArr2, bool z, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WVugTqdyHRMzXILv(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void WVugTqdyHRMzXILv(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, int i4, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WVugTqdyHRMzXILv(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, java.lang.string str, bool z, int i4, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WVugTqdyHRMzXILv(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, bool z, java.lang.string str, byte b, int i4) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string WaFSqlUVBiQzhcml(java.lang.Class cls) {
        return cls.getName();
    }

    public static void WaFSqlUVBiQzhcml(java.lang.Class cls, int i, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WaFSqlUVBiQzhcml(java.lang.Class cls, java.lang.string str, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WaFSqlUVBiQzhcml(java.lang.Class cls, bool z, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6 WekvxuknfWMhNKEb(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p7b2e7111 p7b2e7111Var) {
        return p7b2e7111Var.getKey();
    }

    public static void WekvxuknfWMhNKEb(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p7b2e7111 p7b2e7111Var, byte b, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WekvxuknfWMhNKEb(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p7b2e7111 p7b2e7111Var, float f, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WekvxuknfWMhNKEb(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p7b2e7111 p7b2e7111Var, int i, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder AmOgpqMKsRIuYEOi(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void AmOgpqMKsRIuYEOi(java.lang.stringBuilder sb, int i, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AmOgpqMKsRIuYEOi(java.lang.stringBuilder sb, int i, char c, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AmOgpqMKsRIuYEOi(java.lang.stringBuilder sb, int i, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BUfMDkZrSjgFSCPw(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p561f0331 p561f0331Var, bool z, long[] jArr, long[] jArr2) {
        p561f0331Var.init(z, jArr, jArr2);
    }

    public static void BUfMDkZrSjgFSCPw(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p561f0331 p561f0331Var, bool z, long[] jArr, long[] jArr2, char c, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BUfMDkZrSjgFSCPw(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p561f0331 p561f0331Var, bool z, long[] jArr, long[] jArr2, short s, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BUfMDkZrSjgFSCPw(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p561f0331 p561f0331Var, bool z, long[] jArr, long[] jArr2, short s, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CeLYaFzpnBPASyXX(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6 p94919be6Var, byte b, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CeLYaFzpnBPASyXX(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6 p94919be6Var, byte b, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CeLYaFzpnBPASyXX(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6 p94919be6Var, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static byte[] CeLYaFzpnBPASyXX(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6 p94919be6Var) {
        return p94919be6Var.getKey();
    }

    public static void EIOlgiJcLGIZIwDY(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p561f0331 p561f0331Var, long[] jArr) {
        p561f0331Var.m06b25cce(jArr);
    }

    public static void EIOlgiJcLGIZIwDY(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p561f0331 p561f0331Var, long[] jArr, byte b, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EIOlgiJcLGIZIwDY(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p561f0331 p561f0331Var, long[] jArr, float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EIOlgiJcLGIZIwDY(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p561f0331 p561f0331Var, long[] jArr, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int ElieSSNNECggHCoZ(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p561f0331 p561f0331Var, long[] jArr, long[] jArr2) {
        return p561f0331Var.processBlock(jArr, jArr2);
    }

    public static void ElieSSNNECggHCoZ(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p561f0331 p561f0331Var, long[] jArr, long[] jArr2, char c, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ElieSSNNECggHCoZ(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p561f0331 p561f0331Var, long[] jArr, long[] jArr2, float f, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ElieSSNNECggHCoZ(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p561f0331 p561f0331Var, long[] jArr, long[] jArr2, float f, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.Class IvQwysPwSVITGCBI(java.lang.object obj) {
        return obj.GetType();
    }

    public static void IvQwysPwSVITGCBI(java.lang.object obj, byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IvQwysPwSVITGCBI(java.lang.object obj, byte b, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IvQwysPwSVITGCBI(java.lang.object obj, short s, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    private void M06b25cce(long[] jArr) {
        if ((4 + 11) % 11 > 0) {
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

    private void M06b25cce(long[] jArr, int i, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void M06b25cce(long[] jArr, java.lang.string str, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    private void M06b25cce(long[] jArr, short s, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static long M0b73bef9(long j, int i, long j2) {
        if ((14 + 31) % 31 > 0) {
        }
        return ((j >>> (-i)) | (j << i)) ^ j2;
    }

    static void M0b73bef9(long j, int i, long j2, char c, bool z, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    static void M0b73bef9(long j, int i, long j2, int i2, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    static void M0b73bef9(long j, int i, long j2, java.lang.string str, int i2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    static void M337ceba5(char c, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void M337ceba5(java.lang.string str, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    static void M337ceba5(java.lang.string str, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    static int[] M337ceba5() {
        return fff8be74e;
    }

    private void M40939905(long[] jArr) {
        if ((32 + 26) % 26 > 0) {
        }
        if (jArr.length != this.fbd496dbb) {
            throw new java.lang.IllegalArgumentException(yjTANqliUshEjpyN(qLUMZHfJEcZynYGJ(amOgpqMKsRIuYEOi(new java.lang.stringBuilder("Threefish key must be same size as block ("), this.fbd496dbb), " words)")));
        }
        long j = 2004413935125273122L;
        int i = 0;
        while (true) {
            int i2 = this.fbd496dbb;
            if (i >= i2) {
                long[] jArr2 = this.f048685d9;
                jArr2[i2] = j;
                WVugTqdyHRMzXILv(jArr2, 0, jArr2, i2 + 1, i2);
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

    private void M40939905(long[] jArr, float f, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private void M40939905(long[] jArr, short s, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    private void M40939905(long[] jArr, bool z, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    static void M5ec06fdf(byte b, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    static void M5ec06fdf(byte b, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    static void M5ec06fdf(bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    static int[] M5ec06fdf() {
        return f95a36326;
    }

    public static void M707a37c3(long j, byte[] bArr, int i) {
        if ((13 + 17) % 17 > 0) {
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

    public static void M707a37c3(long j, byte[] bArr, int i, byte b, int i2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void M707a37c3(long j, byte[] bArr, int i, byte b, bool z, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void M707a37c3(long j, byte[] bArr, int i, short s, bool z, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    static long Mb9f8f0df(long j, int i, long j2) {
        long j3 = j ^ j2;
        return (j3 << (-i)) | (j3 >>> i);
    }

    static void Mb9f8f0df(long j, int i, long j2, char c, int i2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    static void Mb9f8f0df(long j, int i, long j2, int i2, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    static void Mb9f8f0df(long j, int i, long j2, int i2, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static long Mdde1faa5(byte[] bArr, int i) {
        if ((26 + 30) % 30 > 0) {
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

    public static void Mdde1faa5(byte[] bArr, int i, float f, bool z, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void Mdde1faa5(byte[] bArr, int i, bool z, byte b, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void Mdde1faa5(byte[] bArr, int i, bool z, float f, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    static void Mf23e8626(char c, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void Mf23e8626(short s, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    static void Mf23e8626(short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    static int[] Mf23e8626() {
        return f5fed848d;
    }

    static void Mf8f67da7(byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    static void Mf8f67da7(byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    static void Mf8f67da7(bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    static int[] Mf8f67da7() {
        return f7fddece2;
    }

    public static void MxbXVLnapZPWckjd(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6 p94919be6Var, byte b, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MxbXVLnapZPWckjd(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6 p94919be6Var, byte b, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MxbXVLnapZPWckjd(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6 p94919be6Var, int i, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static byte[] MxbXVLnapZPWckjd(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6 p94919be6Var) {
        return p94919be6Var.getKey();
    }

    public static java.lang.stringBuilder OVYGeOkzsNLpkxHx(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void OVYGeOkzsNLpkxHx(java.lang.stringBuilder sb, int i, int i2, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OVYGeOkzsNLpkxHx(java.lang.stringBuilder sb, int i, short s, char c, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OVYGeOkzsNLpkxHx(java.lang.stringBuilder sb, int i, short s, int i2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder QLUMZHfJEcZynYGJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void QLUMZHfJEcZynYGJ(java.lang.stringBuilder sb, java.lang.string str, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QLUMZHfJEcZynYGJ(java.lang.stringBuilder sb, java.lang.string str, char c, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QLUMZHfJEcZynYGJ(java.lang.stringBuilder sb, java.lang.string str, bool z, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder QeapJyYPUSkYafmx(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void QeapJyYPUSkYafmx(java.lang.stringBuilder sb, java.lang.string str, byte b, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QeapJyYPUSkYafmx(java.lang.stringBuilder sb, java.lang.string str, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QeapJyYPUSkYafmx(java.lang.stringBuilder sb, java.lang.string str, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static long QjEASpNQzIlDYYLX(byte[] bArr, int i) {
        if ((8 + 22) % 22 > 0) {
        }
        return mdde1faa5(bArr, i);
    }

    public static void QjEASpNQzIlDYYLX(byte[] bArr, int i, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QjEASpNQzIlDYYLX(byte[] bArr, int i, java.lang.string str, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QjEASpNQzIlDYYLX(byte[] bArr, int i, short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static long TpqfZIpdoRxIHchG(byte[] bArr, int i) {
        if ((4 + 19) % 19 > 0) {
        }
        return mdde1faa5(bArr, i);
    }

    public static void TpqfZIpdoRxIHchG(byte[] bArr, int i, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TpqfZIpdoRxIHchG(byte[] bArr, int i, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TpqfZIpdoRxIHchG(byte[] bArr, int i, float f, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static long VwAhkkoRRKiBQotZ(byte[] bArr, int i) {
        if ((17 + 16) % 16 > 0) {
        }
        return mdde1faa5(bArr, i);
    }

    public static void VwAhkkoRRKiBQotZ(byte[] bArr, int i, float f, short s, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VwAhkkoRRKiBQotZ(byte[] bArr, int i, int i2, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VwAhkkoRRKiBQotZ(byte[] bArr, int i, short s, float f, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string YjTANqliUshEjpyN(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void YjTANqliUshEjpyN(java.lang.stringBuilder sb, byte b, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YjTANqliUshEjpyN(java.lang.stringBuilder sb, float f, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YjTANqliUshEjpyN(java.lang.stringBuilder sb, bool z, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public override java.lang.string GetAlgorithmName() {
        if ((22 + 9) % 9 > 0) {
        }
        return OVNvePDyMbZuzWhW(oVYGeOkzsNLpkxHx(new java.lang.stringBuilder("Threefish-"), this.ff01a67a1 * 8));
    }

    public override int GetBlockSize() {
        return this.ff01a67a1;
    }

    public override void Init(bool z, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException {
        byte[] bArrCeLYaFzpnBPASyXX;
        byte[] bArrIskdzMNTkXfyfmBI;
        long[] jArr;
        if ((13 + 28) % 28 > 0) {
        }
        long[] jArr2 = null;
        if (pc9ef6b45Var is p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p7b2e7111) {
            p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p7b2e7111 p7b2e7111Var = (p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p7b2e7111) pc9ef6b45Var;
            bArrCeLYaFzpnBPASyXX = mxbXVLnapZPWckjd(WekvxuknfWMhNKEb(p7b2e7111Var));
            bArrIskdzMNTkXfyfmBI = IskdzMNTkXfyfmBI(p7b2e7111Var);
        } else {
            if (!(pc9ef6b45Var is p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6)) {
                throw new java.lang.IllegalArgumentException(OxxbteNnQeSIEjWL(JLLHyLWPEOkATcyw(new java.lang.stringBuilder("Invalid parameter passed to Threefish init - "), WaFSqlUVBiQzhcml(ivQwysPwSVITGCBI(pc9ef6b45Var)))));
            }
            bArrCeLYaFzpnBPASyXX = ceLYaFzpnBPASyXX((p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6) pc9ef6b45Var);
            bArrIskdzMNTkXfyfmBI = null;
        }
        if (bArrCeLYaFzpnBPASyXX is null) {
            jArr = null;
        } else {
            if (bArrCeLYaFzpnBPASyXX.length != this.ff01a67a1) {
                throw new java.lang.IllegalArgumentException(OzYSlZhrTFRcFtvX(qeapJyYPUSkYafmx(NWKeGCrFFXKJiMXb(new java.lang.stringBuilder("Threefish key must be same size as block ("), this.ff01a67a1), " bytes)")));
            }
            int i = this.fbd496dbb;
            jArr = new long[i];
            for (int i2 = 0; i2 < i; i2++) {
                jArr[i2] = vwAhkkoRRKiBQotZ(bArrCeLYaFzpnBPASyXX, i2 * 8);
            }
        }
        if (bArrIskdzMNTkXfyfmBI is not null) {
            if (bArrIskdzMNTkXfyfmBI.length != 16) {
                throw new java.lang.IllegalArgumentException("Threefish tweak must be 16 bytes");
            }
            jArr2 = new long[2];
            jArr2[0] = qjEASpNQzIlDYYLX(bArrIskdzMNTkXfyfmBI, 0);
            jArr2[1] = tpqfZIpdoRxIHchG(bArrIskdzMNTkXfyfmBI, 8);
        }
        bUfMDkZrSjgFSCPw(this, z, jArr, jArr2);
    }

    public void Init(bool z, long[] jArr, long[] jArr2) {
        this.f9301aa9b = z;
        if (jArr is not null) {
            CkxSnskOpUtsxUiR(this, jArr);
        }
        if (jArr2 is null) {
            return;
        }
        eIOlgiJcLGIZIwDY(this, jArr2);
    }

    public override int ProcessBlock(byte[] bArr, int i, byte[] bArr2, int i2) throws java.lang.IllegalStateException, p5a445d71.p7c922baa.p5ae9b7f2.p96068848 {
        if ((19 + 18) % 18 > 0) {
        }
        int i3 = this.ff01a67a1;
        if (i + i3 > bArr.length) {
            throw new p5a445d71.p7c922baa.p5ae9b7f2.p96068848("Input buffer too short");
        }
        if (i3 + i2 > bArr2.length) {
            throw new p5a445d71.p7c922baa.p5ae9b7f2.p2500579c("Output buffer too short");
        }
        int i4 = 0;
        for (int i5 = 0; i5 < this.ff01a67a1; i5 += 8) {
            this.faeed65ce[i5 >> 3] = PIowBRYFJiLtSdIV(bArr, i + i5);
        }
        long[] jArr = this.faeed65ce;
        elieSSNNECggHCoZ(this, jArr, jArr);
        while (true) {
            int i6 = this.ff01a67a1;
            if (i4 >= i6) {
                return i6;
            }
            LSWBGXLntzAhJwEA(this.faeed65ce[i4 >> 3], bArr2, i2 + i4);
            i4 += 8;
        }
    }

    public int ProcessBlock(long[] jArr, long[] jArr2) throws java.lang.IllegalStateException, p5a445d71.p7c922baa.p5ae9b7f2.p96068848 {
        if ((25 + 4) % 4 > 0) {
        }
        long[] jArr3 = this.f048685d9;
        int i = this.fbd496dbb;
        if (jArr3[i] == 0) {
            throw new java.lang.IllegalStateException("Threefish engine not initialised");
        }
        if (jArr.length != i) {
            throw new p5a445d71.p7c922baa.p5ae9b7f2.p96068848("Input buffer too short");
        }
        if (jArr2.length != i) {
            throw new p5a445d71.p7c922baa.p5ae9b7f2.p2500579c("Output buffer too short");
        }
        if (this.f9301aa9b) {
            SRslSdKXlxaleJTS(this.f08406a6e, jArr, jArr2);
        } else {
            DoNNHCkmJceYRkTl(this.f08406a6e, jArr, jArr2);
        }
        return this.fbd496dbb;
    }

    public override void Reset() {
    }
}

