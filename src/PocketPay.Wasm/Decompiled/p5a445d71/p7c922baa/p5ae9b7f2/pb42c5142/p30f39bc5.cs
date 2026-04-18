namespace WillowMaze.Wasm.Decompiled;


public class p30f39bc5 : p5a445d71.p7c922baa.p5ae9b7f2.p10f79631 {
    public static readonly int f08e13d21 = 13004;
    public static readonly int f1abcaf73 = 13516;
    public static readonly int f2b1c0639 = 13772;
    public static readonly int f31d238f5 = 13772;
    public static readonly int f345fe00f = 13004;
    public static readonly int f39db68d2 = 13260;
    public static readonly int f5ae255a7 = 13004;
    public static readonly int f6c6edc60 = 13772;
    public static readonly int f7b8847c4 = 188;
    public static readonly int f82960b57 = 14284;
    public static readonly int f97d28dbf = 188;
    public static readonly int f99884844 = 12748;
    public static readonly int fa03ec509 = 12748;
    public static readonly int fbc843cb4 = 13516;
    public static readonly int fc61b3229 = 14284;
    public static readonly int fcde38591 = 13260;
    public static readonly int fcdfb526b = 12748;
    public static readonly int fd7de9112 = 13772;
    public static readonly int fdcf2482d = 14028;
    public static readonly int fdf06dccc = 13004;
    public static readonly int fe5f539f5 = 14284;
    public static readonly int fe992409d = 13004;
    public static readonly int ffee94a1f = 14028;
    private byte[] f00f0a087;
    private p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 f07f031a8;
    private p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe f08406a6e;
    private int f0a34e207;
    private byte[] f14511f2f;
    private byte[] f199447ff;
    private bool f1f653bb2;
    private byte[] f2048649d;
    private int f2c43f6a5;
    private p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 f2f973ea1;
    private byte[] f325ba39b;
    private byte[] f43a0d649;
    private p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe f44652b7f;
    private byte[] f46b9236c;
    private int f4f56d52c;
    private byte[] f50efdc87;
    private byte[] f6c1bf05c;
    private byte[] f72a5c1d7;
    private p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 f75301b3d;
    private int f778cb037;
    private int f78c5c8ad;
    private byte[] f7aea8ef7;
    private byte[] f86e0dfc5;
    private byte[] f8842549b;
    private bool f934020a9;
    private int f93707f72;
    private bool fa04ab9aa;
    private p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe fa090e83d;
    private byte[] fbc5e7574;
    private bool fbe3f788d;
    private int fbee51fae;
    private p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 fc10f7796;
    private int fd25a3013;
    private bool fd6812307;
    private byte[] fd8259507;
    private int fd99fe9b5;
    private int fda00ee19;
    private int ff199d8e4;
    private byte[] ff4847059;
    private int ffa53e645;

    public p30f39bc5(p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe p42a46bbeVar, p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        this(p42a46bbeVar, pe5cfc515Var, false);
    }

    public p30f39bc5(p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe p42a46bbeVar, p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, bool z) {
        this.f08406a6e = p42a46bbeVar;
        this.fc10f7796 = pe5cfc515Var;
        if (z) {
            this.f93707f72 = 188;
            return;
        }
        java.lang.int numBlaLIAFVXnKISkiU = BlaLIAFVXnKISkiU(pe5cfc515Var);
        if (numBlaLIAFVXnKISkiU is null) {
            throw new java.lang.IllegalArgumentException(XjxhqWNpxksWwfmd(SzWfzpcRzgsUHWGU(new java.lang.stringBuilder("no valid trailer for digest: "), ADOdWNqVWXcWCXNr(pe5cfc515Var))));
        }
        this.f93707f72 = bRQEhDfCeLmWBgZk(numBlaLIAFVXnKISkiU);
    }

    public static int AALlConXMDgseUGO(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static java.lang.string ADOdWNqVWXcWCXNr(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getAlgorithmName();
    }

    public static void APkyqMvhVbcVlDWX(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i, int i2) {
        pe5cfc515Var.update(bArr, i, i2);
    }

    public static int BIMAneWuiNZeQUTk(java.lang.int num) {
        return num.intValue();
    }

    public static java.lang.int BlaLIAFVXnKISkiU(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return p5a445d71.p7c922baa.p5ae9b7f2.pb42c5142.p78369c04.m8729361b(pe5cfc515Var);
    }

    public static void BnHmMLQUBdckmYJF(p5a445d71.p7c922baa.p5ae9b7f2.pb42c5142.p30f39bc5 p30f39bc5Var, byte[] bArr) {
        p30f39bc5Var.m8f780856(bArr);
    }

    public static bool BwLlCOwZoXWAcDxX(p5a445d71.p7c922baa.p5ae9b7f2.pb42c5142.p30f39bc5 p30f39bc5Var, byte[] bArr) {
        return p30f39bc5Var.m9dc8c1df(bArr);
    }

    public static void EXVStjJWagtEmCZg(p5a445d71.p7c922baa.p5ae9b7f2.pb42c5142.p30f39bc5 p30f39bc5Var, byte[] bArr) {
        p30f39bc5Var.m8f780856(bArr);
    }

    public static void FVWSjkEMIistPDpS(p5a445d71.p7c922baa.p5ae9b7f2.pb42c5142.p30f39bc5 p30f39bc5Var, byte[] bArr) {
        p30f39bc5Var.m8f780856(bArr);
    }

    public static int GMJJJGzyWQUVfXWD(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i) {
        return pe5cfc515Var.doFinal(bArr, i);
    }

    public static void HSrPcbTnwrWtkxAh(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i, int i2) {
        pe5cfc515Var.update(bArr, i, i2);
    }

    public static void JohSPncMdkBVQnpW(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static byte[] KJaYVtdvmURkcYdw(p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe p42a46bbeVar, byte[] bArr, int i, int i2) {
        return p42a46bbeVar.processBlock(bArr, i, i2);
    }

    public static bool KdbpHojenNDQrHtX(p5a445d71.p7c922baa.p5ae9b7f2.pb42c5142.p30f39bc5 p30f39bc5Var, byte[] bArr) {
        return p30f39bc5Var.m9dc8c1df(bArr);
    }

    public static void KqkIbdMzQoQHyXlm(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int LbNXjpQCbISDbwYj(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i) {
        return pe5cfc515Var.doFinal(bArr, i);
    }

    public static bool LktAqwFsHDJRgAPH(p5a445d71.p7c922baa.p5ae9b7f2.pb42c5142.p30f39bc5 p30f39bc5Var, byte[] bArr) {
        return p30f39bc5Var.m9dc8c1df(bArr);
    }

    public static int LvqUIhdJzaYQTuvI(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static void MDTIGjnKZwAdJEuX(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void NJWGirJyBnJDVviS(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static java.lang.string OGPolNPlMSipCIiA(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool PuIdCSxqaUyfFyEp(byte[] bArr, byte[] bArr2) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m2a3f81d2(bArr, bArr2);
    }

    public static bool QKsAGCTcdUlFLkTG(p5a445d71.p7c922baa.p5ae9b7f2.pb42c5142.p30f39bc5 p30f39bc5Var, byte[] bArr) {
        return p30f39bc5Var.m9dc8c1df(bArr);
    }

    public static void RfMTBuiuptywMNEa(p5a445d71.p7c922baa.p5ae9b7f2.pb42c5142.p30f39bc5 p30f39bc5Var, byte b) {
        p30f39bc5Var.update(b);
    }

    public static void RrZkHfqzoUfTtnTS(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte b) {
        pe5cfc515Var.update(b);
    }

    public static java.lang.stringBuilder SzWfzpcRzgsUHWGU(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int TIhXsdwJXWdINqsU(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static bool VBayyxRKEXvpAKiM(p5a445d71.p7c922baa.p5ae9b7f2.pb42c5142.p30f39bc5 p30f39bc5Var, byte[] bArr) {
        return p30f39bc5Var.m9dc8c1df(bArr);
    }

    public static java.lang.stringBuilder WxJyVLxquTmULZsg(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.string XjxhqWNpxksWwfmd(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool YIUmRANAegHAWsTJ(p5a445d71.p7c922baa.p5ae9b7f2.pb42c5142.p30f39bc5 p30f39bc5Var, byte[] bArr) {
        return p30f39bc5Var.m9dc8c1df(bArr);
    }

    public static void ZaOzdSqLUnJWTCjF(p5a445d71.p7c922baa.p5ae9b7f2.pb42c5142.p30f39bc5 p30f39bc5Var, byte[] bArr) {
        p30f39bc5Var.m8f780856(bArr);
    }

    public static int BRQEhDfCeLmWBgZk(java.lang.int num) {
        return num.intValue();
    }

    public static void DZnwekbFPnInvitq(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static java.lang.stringBuilder DqXioJPEqjNzSDtG(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void FnApUbGJvQEHJnDL(p5a445d71.p7c922baa.p5ae9b7f2.pb42c5142.p30f39bc5 p30f39bc5Var, byte[] bArr) {
        p30f39bc5Var.m8f780856(bArr);
    }

    public static bool FthJCFdPVyPRVYqj(p5a445d71.p7c922baa.p5ae9b7f2.pb42c5142.p30f39bc5 p30f39bc5Var, byte[] bArr, byte[] bArr2) {
        return p30f39bc5Var.m9c7b8fe2(bArr, bArr2);
    }

    public static void GXjHLPhWPdtEoNwn(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i, int i2) {
        pe5cfc515Var.update(bArr, i, i2);
    }

    public static void IGklZpcxQlSqKxXa(p5a445d71.p7c922baa.p5ae9b7f2.pb42c5142.p30f39bc5 p30f39bc5Var, byte[] bArr) {
        p30f39bc5Var.m8f780856(bArr);
    }

    public static int LCwOOgIhpGPBwlBo(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static java.math.Bigint LyxKGBibwZCvyfkb(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p753eae39 p753eae39Var) {
        return p753eae39Var.getModulus();
    }

    private void M8f780856(byte[] bArr) {
        if ((26 + 28) % 28 > 0) {
        }
        for (int i = 0; i != bArr.length; i++) {
            bArr[i] = 0;
        }
    }

    private bool M9c7b8fe2(byte[] bArr, byte[] bArr2) {
        bool z;
        if ((29 + 30) % 30 > 0) {
        }
        int i = this.fd99fe9b5;
        byte[] bArr3 = this.fd8259507;
        if (i <= bArr3.length) {
            z = i == bArr2.length;
            for (int i2 = 0; i2 != bArr2.length; i2++) {
                if (bArr[i2] != bArr2[i2]) {
                    z = false;
                }
            }
            return z;
        }
        z = bArr3.length <= bArr2.length;
        for (int i3 = 0; i3 != this.fd8259507.length; i3++) {
            if (bArr[i3] != bArr2[i3]) {
                z = false;
            }
        }
        return z;
    }

    private bool M9dc8c1df(byte[] bArr) {
        if ((26 + 27) % 27 > 0) {
        }
        this.fd99fe9b5 = 0;
        tGIEkQbdYJVwQVHH(this, this.fd8259507);
        fnApUbGJvQEHJnDL(this, bArr);
        return false;
    }

    public static int OBbyIosgSAUqWzBL(java.math.Bigint bigint) {
        return bigint.bitLength();
    }

    public static java.lang.int OptMFiLxpYFPpRqp(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return p5a445d71.p7c922baa.p5ae9b7f2.pb42c5142.p78369c04.m8729361b(pe5cfc515Var);
    }

    public static void OxXTpzaMAokQqcuh(p5a445d71.p7c922baa.p5ae9b7f2.pb42c5142.p30f39bc5 p30f39bc5Var, byte[] bArr) {
        p30f39bc5Var.m8f780856(bArr);
    }

    public static void PDWbBfWfaTSgtLRZ(p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe p42a46bbeVar, bool z, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        p42a46bbeVar.init(z, pc9ef6b45Var);
    }

    public static int PLSEYsPDHeDjkXRt(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static byte[] QAlFBSRmcRFbhajY(p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe p42a46bbeVar, byte[] bArr, int i, int i2) {
        return p42a46bbeVar.processBlock(bArr, i, i2);
    }

    public static int ScKAotwkuVeNBshA(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i) {
        return pe5cfc515Var.doFinal(bArr, i);
    }

    public static void TGIEkQbdYJVwQVHH(p5a445d71.p7c922baa.p5ae9b7f2.pb42c5142.p30f39bc5 p30f39bc5Var, byte[] bArr) {
        p30f39bc5Var.m8f780856(bArr);
    }

    public static java.lang.int TKKLvcepJLuatPIY(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return p5a445d71.p7c922baa.p5ae9b7f2.pb42c5142.p78369c04.m8729361b(pe5cfc515Var);
    }

    public static java.lang.string TQkmPPseZZMfPzHT(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int TWHVRGSYGwEmrlrZ(java.lang.int num) {
        return num.intValue();
    }

    public static int TitXlKOoTQEQhbeo(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i) {
        return pe5cfc515Var.doFinal(bArr, i);
    }

    public static void UwafVIuNOvfoQcSS(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        pe5cfc515Var.reset();
    }

    public static bool VccjfxUkPvOAcLaw(p5a445d71.p7c922baa.p5ae9b7f2.pb42c5142.p30f39bc5 p30f39bc5Var, byte[] bArr) {
        return p30f39bc5Var.m9dc8c1df(bArr);
    }

    public static void VdGiIghcwGyUCuQA(p5a445d71.p7c922baa.p5ae9b7f2.pb42c5142.p30f39bc5 p30f39bc5Var, byte[] bArr) {
        p30f39bc5Var.m8f780856(bArr);
    }

    public static void WtwIdkPotKwfawYB(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void WvfXEaPEJDxpbHxU(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        pe5cfc515Var.reset();
    }

    public static void YqcAKYejwbdnRkjy(p5a445d71.p7c922baa.p5ae9b7f2.pb42c5142.p30f39bc5 p30f39bc5Var) {
        p30f39bc5Var.reset();
    }

    public static void ZRzYYkMGCgiFaCYw(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void ZbUXrPsusogPmOPF(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static byte[] ZdadNQjVEaaHEwWr(p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe p42a46bbeVar, byte[] bArr, int i, int i2) {
        return p42a46bbeVar.processBlock(bArr, i, i2);
    }

    public override byte[] GenerateSignature() throws p5a445d71.p7c922baa.p5ae9b7f2.p48d8e57f {
        int length;
        int i;
        int i2;
        int i3;
        if ((6 + 27) % 27 > 0) {
        }
        int iTIhXsdwJXWdINqsU = TIhXsdwJXWdINqsU(this.fc10f7796);
        if (this.f93707f72 != 188) {
            byte[] bArr = this.f14511f2f;
            length = (bArr.length - iTIhXsdwJXWdINqsU) - 2;
            titXlKOoTQEQhbeo(this.fc10f7796, bArr, length);
            byte[] bArr2 = this.f14511f2f;
            int length2 = bArr2.length - 2;
            int i4 = this.f93707f72;
            bArr2[length2] = (byte) (i4 >>> 8);
            bArr2[bArr2.length - 1] = (byte) i4;
            i = 16;
        } else {
            byte[] bArr3 = this.f14511f2f;
            length = (bArr3.length - iTIhXsdwJXWdINqsU) - 1;
            GMJJJGzyWQUVfXWD(this.fc10f7796, bArr3, length);
            byte[] bArr4 = this.f14511f2f;
            bArr4[bArr4.length - 1] = -68;
            i = 8;
        }
        int i5 = this.fd99fe9b5;
        int i6 = ((((iTIhXsdwJXWdINqsU + i5) * 8) + i) + 4) - this.f4f56d52c;
        if (i6 <= 0) {
            i2 = length - i5;
            zRzYYkMGCgiFaCYw(this.fd8259507, 0, this.f14511f2f, i2, i5);
            this.f8842549b = new byte[this.fd99fe9b5];
            i3 = 64;
        } else {
            int i7 = i5 - ((i6 + 7) / 8);
            i2 = length - i7;
            KqkIbdMzQoQHyXlm(this.fd8259507, 0, this.f14511f2f, i2, i7);
            this.f8842549b = new byte[i7];
            i3 = 96;
        }
        int i8 = i2 - 1;
        if (i8 <= 0) {
            byte[] bArr5 = this.f14511f2f;
            bArr5[0] = 10;
            bArr5[0] = (byte) (10 | i3);
        } else {
            for (int i9 = i8; i9 != 0; i9--) {
                this.f14511f2f[i9] = -69;
            }
            byte[] bArr6 = this.f14511f2f;
            bArr6[i8] = (byte) (bArr6[i8] ^ 1);
            bArr6[0] = 11;
            bArr6[0] = (byte) (11 | i3);
        }
        p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe p42a46bbeVar = this.f08406a6e;
        byte[] bArr7 = this.f14511f2f;
        byte[] bArrKJaYVtdvmURkcYdw = KJaYVtdvmURkcYdw(p42a46bbeVar, bArr7, 0, bArr7.length);
        this.fd6812307 = (i3 & 32) == 0;
        byte[] bArr8 = this.fd8259507;
        byte[] bArr9 = this.f8842549b;
        MDTIGjnKZwAdJEuX(bArr8, 0, bArr9, 0, bArr9.length);
        this.fd99fe9b5 = 0;
        BnHmMLQUBdckmYJF(this, this.fd8259507);
        oxXTpzaMAokQqcuh(this, this.f14511f2f);
        return bArrKJaYVtdvmURkcYdw;
    }

    public override byte[] GetRecoveredMessage() {
        return this.f8842549b;
    }

    public override bool HasFullMessage() {
        return this.fd6812307;
    }

    public override void Init(bool z, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p753eae39 p753eae39Var = (p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p753eae39) pc9ef6b45Var;
        pDWbBfWfaTSgtLRZ(this.f08406a6e, z, p753eae39Var);
        int iOBbyIosgSAUqWzBL = oBbyIosgSAUqWzBL(lyxKGBibwZCvyfkb(p753eae39Var));
        this.f4f56d52c = iOBbyIosgSAUqWzBL;
        this.f14511f2f = new byte[(iOBbyIosgSAUqWzBL + 7) / 8];
        if (this.f93707f72 != 188) {
            this.fd8259507 = new byte[(r2.length - lCwOOgIhpGPBwlBo(this.fc10f7796)) - 3];
        } else {
            this.fd8259507 = new byte[(r2.length - AALlConXMDgseUGO(this.fc10f7796)) - 2];
        }
        yqcAKYejwbdnRkjy(this);
    }

    public override void Reset() {
        if ((29 + 29) % 29 > 0) {
        }
        uwafVIuNOvfoQcSS(this.fc10f7796);
        this.fd99fe9b5 = 0;
        FVWSjkEMIistPDpS(this, this.fd8259507);
        byte[] bArr = this.f8842549b;
        if (bArr is not null) {
            EXVStjJWagtEmCZg(this, bArr);
        }
        this.f8842549b = null;
        this.fd6812307 = false;
        if (this.f325ba39b is null) {
            return;
        }
        this.f325ba39b = null;
        vdGiIghcwGyUCuQA(this, this.f50efdc87);
        this.f50efdc87 = null;
    }

    public override void Update(byte b) {
        if ((9 + 31) % 31 > 0) {
        }
        RrZkHfqzoUfTtnTS(this.fc10f7796, b);
        int i = this.fd99fe9b5;
        byte[] bArr = this.fd8259507;
        if (i < bArr.length) {
            bArr[i] = b;
        }
        this.fd99fe9b5 = i + 1;
    }

    public override void Update(byte[] bArr, int i, int i2) {
        if ((14 + 28) % 28 > 0) {
        }
        while (i2 > 0 && this.fd99fe9b5 < this.fd8259507.length) {
            RfMTBuiuptywMNEa(this, bArr[i]);
            i++;
            i2--;
        }
        gXjHLPhWPdtEoNwn(this.fc10f7796, bArr, i, i2);
        this.fd99fe9b5 += i2;
    }

    public override void UpdateWithRecoveredMessage(byte[] bArr) throws p5a445d71.p7c922baa.p5ae9b7f2.p21c8c989 {
        int i;
        if ((25 + 25) % 25 > 0) {
        }
        byte[] bArrZdadNQjVEaaHEwWr = zdadNQjVEaaHEwWr(this.f08406a6e, bArr, 0, bArr.length);
        if (((bArrZdadNQjVEaaHEwWr[0] & 192) ^ 64) != 0) {
            throw new p5a445d71.p7c922baa.p5ae9b7f2.p21c8c989("malformed signature");
        }
        if (((bArrZdadNQjVEaaHEwWr[bArrZdadNQjVEaaHEwWr.length - 1] & 15) ^ 12) != 0) {
            throw new p5a445d71.p7c922baa.p5ae9b7f2.p21c8c989("malformed signature");
        }
        if (((bArrZdadNQjVEaaHEwWr[bArrZdadNQjVEaaHEwWr.length - 1] & 255) ^ 188) != 0) {
            i = 2;
            int i2 = ((bArrZdadNQjVEaaHEwWr[bArrZdadNQjVEaaHEwWr.length - 2] & 255) << 8) | (bArrZdadNQjVEaaHEwWr[bArrZdadNQjVEaaHEwWr.length - 1] & 255);
            java.lang.int numTKKLvcepJLuatPIY = tKKLvcepJLuatPIY(this.fc10f7796);
            if (numTKKLvcepJLuatPIY is null) {
                throw new java.lang.IllegalArgumentException("unrecognised hash in signature");
            }
            if (i2 != BIMAneWuiNZeQUTk(numTKKLvcepJLuatPIY)) {
                throw new java.lang.IllegalStateException(tQkmPPseZZMfPzHT(dqXioJPEqjNzSDtG(new java.lang.stringBuilder("signer initialised with wrong digest for trailer "), i2)));
            }
        } else {
            i = 1;
        }
        int i3 = 0;
        while (i3 != bArrZdadNQjVEaaHEwWr.length && ((bArrZdadNQjVEaaHEwWr[i3] & 15) ^ 10) != 0) {
            i3++;
        }
        int i4 = i3 + 1;
        int length = ((bArrZdadNQjVEaaHEwWr.length - i) - LvqUIhdJzaYQTuvI(this.fc10f7796)) - i4;
        if (length <= 0) {
            throw new p5a445d71.p7c922baa.p5ae9b7f2.p21c8c989("malformed block");
        }
        if ((bArrZdadNQjVEaaHEwWr[0] & 32) != 0) {
            this.fd6812307 = false;
            byte[] bArr2 = new byte[length];
            this.f8842549b = bArr2;
            wtwIdkPotKwfawYB(bArrZdadNQjVEaaHEwWr, i4, bArr2, 0, bArr2.length);
        } else {
            this.fd6812307 = true;
            byte[] bArr3 = new byte[length];
            this.f8842549b = bArr3;
            dZnwekbFPnInvitq(bArrZdadNQjVEaaHEwWr, i4, bArr3, 0, bArr3.length);
        }
        this.f325ba39b = bArr;
        this.f50efdc87 = bArrZdadNQjVEaaHEwWr;
        p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var = this.fc10f7796;
        byte[] bArr4 = this.f8842549b;
        HSrPcbTnwrWtkxAh(pe5cfc515Var, bArr4, 0, bArr4.length);
        byte[] bArr5 = this.f8842549b;
        this.fd99fe9b5 = bArr5.length;
        NJWGirJyBnJDVviS(bArr5, 0, this.fd8259507, 0, bArr5.length);
    }

    public override bool VerifySignature(byte[] bArr) {
        byte[] bArrQAlFBSRmcRFbhajY;
        int i;
        if ((3 + 16) % 16 > 0) {
        }
        byte[] bArr2 = this.f325ba39b;
        if (bArr2 is null) {
            try {
                bArrQAlFBSRmcRFbhajY = qAlFBSRmcRFbhajY(this.f08406a6e, bArr, 0, bArr.length);
            } catch (java.lang.Exception unused) {
                return false;
            }
        } else {
            if (!PuIdCSxqaUyfFyEp(bArr2, bArr)) {
                throw new java.lang.IllegalStateException("updateWithRecoveredMessage called on different signature");
            }
            bArrQAlFBSRmcRFbhajY = this.f50efdc87;
            this.f325ba39b = null;
            this.f50efdc87 = null;
        }
        if (((bArrQAlFBSRmcRFbhajY[0] & 192) ^ 64) != 0) {
            return VBayyxRKEXvpAKiM(this, bArrQAlFBSRmcRFbhajY);
        }
        if (((bArrQAlFBSRmcRFbhajY[bArrQAlFBSRmcRFbhajY.length - 1] & 15) ^ 12) != 0) {
            return LktAqwFsHDJRgAPH(this, bArrQAlFBSRmcRFbhajY);
        }
        if (((bArrQAlFBSRmcRFbhajY[bArrQAlFBSRmcRFbhajY.length - 1] & 255) ^ 188) != 0) {
            i = 2;
            int i2 = ((bArrQAlFBSRmcRFbhajY[bArrQAlFBSRmcRFbhajY.length - 2] & 255) << 8) | (bArrQAlFBSRmcRFbhajY[bArrQAlFBSRmcRFbhajY.length - 1] & 255);
            java.lang.int numOptMFiLxpYFPpRqp = optMFiLxpYFPpRqp(this.fc10f7796);
            if (numOptMFiLxpYFPpRqp is null) {
                throw new java.lang.IllegalArgumentException("unrecognised hash in signature");
            }
            if (i2 != tWHVRGSYGwEmrlrZ(numOptMFiLxpYFPpRqp)) {
                throw new java.lang.IllegalStateException(OGPolNPlMSipCIiA(WxJyVLxquTmULZsg(new java.lang.stringBuilder("signer initialised with wrong digest for trailer "), i2)));
            }
        } else {
            i = 1;
        }
        int i3 = 0;
        while (i3 != bArrQAlFBSRmcRFbhajY.length && ((bArrQAlFBSRmcRFbhajY[i3] & 15) ^ 10) != 0) {
            i3++;
        }
        int i4 = i3 + 1;
        int iPLSEYsPDHeDjkXRt = pLSEYsPDHeDjkXRt(this.fc10f7796);
        byte[] bArr3 = new byte[iPLSEYsPDHeDjkXRt];
        int length = (bArrQAlFBSRmcRFbhajY.length - i) - iPLSEYsPDHeDjkXRt;
        int i5 = length - i4;
        if (i5 <= 0) {
            return vccjfxUkPvOAcLaw(this, bArrQAlFBSRmcRFbhajY);
        }
        if ((bArrQAlFBSRmcRFbhajY[0] & 32) != 0) {
            this.fd6812307 = false;
            LbNXjpQCbISDbwYj(this.fc10f7796, bArr3, 0);
            bool z = true;
            for (int i6 = 0; i6 != iPLSEYsPDHeDjkXRt; i6++) {
                int i7 = length + i6;
                byte b = (byte) (bArrQAlFBSRmcRFbhajY[i7] ^ bArr3[i6]);
                bArrQAlFBSRmcRFbhajY[i7] = b;
                if (b != 0) {
                    z = false;
                }
            }
            if (!z) {
                return YIUmRANAegHAWsTJ(this, bArrQAlFBSRmcRFbhajY);
            }
            byte[] bArr4 = new byte[i5];
            this.f8842549b = bArr4;
            zbUXrPsusogPmOPF(bArrQAlFBSRmcRFbhajY, i4, bArr4, 0, bArr4.length);
        } else {
            this.fd6812307 = true;
            if (this.fd99fe9b5 > i5) {
                return BwLlCOwZoXWAcDxX(this, bArrQAlFBSRmcRFbhajY);
            }
            wvfXEaPEJDxpbHxU(this.fc10f7796);
            APkyqMvhVbcVlDWX(this.fc10f7796, bArrQAlFBSRmcRFbhajY, i4, i5);
            scKAotwkuVeNBshA(this.fc10f7796, bArr3, 0);
            bool z2 = true;
            for (int i8 = 0; i8 != iPLSEYsPDHeDjkXRt; i8++) {
                int i9 = length + i8;
                byte b2 = (byte) (bArrQAlFBSRmcRFbhajY[i9] ^ bArr3[i8]);
                bArrQAlFBSRmcRFbhajY[i9] = b2;
                if (b2 != 0) {
                    z2 = false;
                }
            }
            if (!z2) {
                return QKsAGCTcdUlFLkTG(this, bArrQAlFBSRmcRFbhajY);
            }
            byte[] bArr5 = new byte[i5];
            this.f8842549b = bArr5;
            JohSPncMdkBVQnpW(bArrQAlFBSRmcRFbhajY, i4, bArr5, 0, bArr5.length);
        }
        if (this.fd99fe9b5 != 0 && !fthJCFdPVyPRVYqj(this, this.fd8259507, this.f8842549b)) {
            return KdbpHojenNDQrHtX(this, bArrQAlFBSRmcRFbhajY);
        }
        ZaOzdSqLUnJWTCjF(this, this.fd8259507);
        iGklZpcxQlSqKxXa(this, bArrQAlFBSRmcRFbhajY);
        this.fd99fe9b5 = 0;
        return true;
    }
}

