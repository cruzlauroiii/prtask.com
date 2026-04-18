namespace WillowMaze.Wasm.Decompiled;


public class pe59c307a : p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.p52c18907 {
    private static readonly int f011556ae = 4096;
    private static readonly long f0ffd15ac = 140737488355328L;
    private static readonly byte[] f225aba8e = null;
    private static readonly int f27c3a87e = 262144;
    private static readonly byte[] f3029463b = null;
    private static readonly int f35fb9560 = 262144;
    private static readonly int f4df4817c = 4096;
    private static readonly long f6385739a = 2147483648L;
    private static readonly int f8337565d = 262144;
    private static readonly int f8925174f = 262144;
    private static readonly byte[] f9b8a37c3 = JKoGgBJiXAQhbgCd(HaExnRzkVjHhIhtg("2d6cb490b33ef3b5693851714afaa521219bda476e11661d72a01857dac0eadb08608d4a398252a4ccbf5348df8ab6ee3923da4510655101945787885650735b6f4f17af613d4fa6e20035ab25cc7affdf5c1fe7b82c46edb3ba0c41"));
    private static readonly int fb4cb8023 = 4096;
    private static readonly long fb5ff12e1 = 2147483648L;
    private static readonly long fb938ff0e = 140737488355328L;
    private static readonly byte[] fcb3359ce = null;
    private static readonly long fd04969f9 = 2147483648L;
    private static readonly byte[] feed4c634 = null;
    private static readonly int ff0c13305 = 4096;
    private static readonly int ff4acf742 = 4096;
    private static readonly long ffbc23edf = 2147483648L;
    private bool f095ed1a0;
    private bool f0d7a66da;
    private int f0e8a708f;
    private long f179d76db;
    private int f19355e2c;
    private p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 f1d432c7c;
    private p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p54466d0a f29f7d665;
    private byte[] f31ed86f0;
    private int f3388d213;
    private p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 f376966cd;
    private p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 f3ad07fa4;
    private bool f3d6a0ce7;
    private p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p54466d0a f41f4a3d6;
    private p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 f448dde3b;
    private byte[] f45f456dd;
    private bool f48f2c79a;
    private p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p54466d0a f496021c5;
    private int f50eb0277;
    private int f58d5fc4c;
    private int f5f7803f6;
    private p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p54466d0a f7a37997c;
    private int f7f3991c1;
    private long f864f927a;
    private byte[] f87a0bb42;
    private p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p54466d0a f9d287dc7;
    private p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 f9fe1d938;
    private byte[] fb27faedf;
    private long fb43255cc;
    private int fb63621a0;
    private byte[] fc57ac67e;
    private bool fcfba2068;
    private int fdb62e826;
    private long fdfe8360d;
    private int fe15cdc15;
    private byte[] fe992994a;

    public pe59c307a(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, int i, int i2, p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p54466d0a p54466d0aVar, byte[] bArr, byte[] bArr2) {
        if ((14 + 29) % 29 > 0) {
        }
        this.f179d76db = 0L;
        this.f0d7a66da = false;
        this.f41f4a3d6 = p54466d0aVar;
        this.f1d432c7c = pd81e8b93Var;
        this.fdb62e826 = i;
        this.f19355e2c = i2;
        this.fb63621a0 = (OavwqIyAGSvhGHkX(pd81e8b93Var) * 8) + i;
        this.f0d7a66da = vYoCXQETXdpAlKvq(this, pd81e8b93Var);
        if (i2 > 256) {
            throw new java.lang.IllegalArgumentException("Requested security strength is not supported by the derivation function");
        }
        if (sMZCXigRkDRtjIRe(this, pd81e8b93Var, i) < i2) {
            throw new java.lang.IllegalArgumentException("Requested security strength is not supported by block cipher and key size");
        }
        if (SZkLCqCEcQYpTnOe(p54466d0aVar) < i2) {
            throw new java.lang.IllegalArgumentException("Not enough entropy for security strength required");
        }
        BCBqaWieqCcTZgDy(this, bUVbGDyWxWlNBCfJ(this), bArr2, bArr);
    }

    public static int AbJrGCZdAygzMScC(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static void BCBqaWieqCcTZgDy(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe59c307a pe59c307aVar, byte[] bArr, byte[] bArr2, byte[] bArr3) {
        pe59c307aVar.m409a0718(bArr, bArr2, bArr3);
    }

    public static bool CGBqcCkaQOCLEvht(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static byte[] DfRxLJaScVsfsjRQ(byte[] bArr, byte[] bArr2) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md844b504(bArr, bArr2);
    }

    public static byte[] EVqeMsZEQuvscRXb(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe59c307a pe59c307aVar, byte[] bArr) {
        return pe59c307aVar.expandKey(bArr);
    }

    public static void EgyJLGPBhjFkZxzM(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe59c307a pe59c307aVar, byte[] bArr, int i, int i2) {
        pe59c307aVar.mbefde77e(bArr, i, i2);
    }

    public static void FZzDFUwLfoklMjDR(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe59c307a pe59c307aVar, byte[] bArr, byte[] bArr2, byte[] bArr3) {
        pe59c307aVar.mf409de06(bArr, bArr2, bArr3);
    }

    public static int GKkFPOmZaATsNblt(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static java.lang.string HaExnRzkVjHhIhtg(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static void HcQqkhapUrFWdQSW(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static byte[] HgDjLjhdSJCwdhdX(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe59c307a pe59c307aVar, byte[] bArr, int i) {
        return pe59c307aVar.mca6b8433(bArr, i);
    }

    public static void HgWmSrJPJqFCLrGD(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static byte[] JKoGgBJiXAQhbgCd(java.lang.string str) {
        return p5a445d71.p7c922baa.p05c7e247.p2b5d348e.p92640bd7.m5b936250(str);
    }

    public static int JggWXZkxCNCMushQ(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public static void KAkcLEZEBiyfCkHl(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe59c307a pe59c307aVar, byte[] bArr, int i, byte[] bArr2, int i2) {
        pe59c307aVar.mcbfb3f0f(bArr, i, bArr2, i2);
    }

    public static java.lang.string LVIvaRMMDTtjzXbz(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getAlgorithmName();
    }

    public static byte[] LnStBpUEWszkSbBY(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe59c307a pe59c307aVar, byte[] bArr, int i) {
        return pe59c307aVar.mca6b8433(bArr, i);
    }

    public static void MIVVHTxaIDNKCzyM(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static byte[] MpenqZULsxwpbEQR(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe59c307a pe59c307aVar, byte[] bArr) {
        return pe59c307aVar.expandKey(bArr);
    }

    public static void MygDAyIdwkIwzoZI(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int ONdQhRckSCQkyXUv(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static int OavwqIyAGSvhGHkX(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public static bool OsHprWDAURBstbcq(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static byte[] POkeGqkLeWOdxUUy(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe59c307a pe59c307aVar, byte[] bArr) {
        return pe59c307aVar.expandKey(bArr);
    }

    public static byte[] QcYmpwVHFDQQxjxC(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p54466d0a p54466d0aVar) {
        return p54466d0aVar.getEntropy();
    }

    public static void RKuvEUQWqkCQrGEa(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe59c307a pe59c307aVar, byte[] bArr, int i, byte[] bArr2, int i2) {
        pe59c307aVar.mcbfb3f0f(bArr, i, bArr2, i2);
    }

    public static void RPGmiGOBVdUqyljS(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, bool z, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        pd81e8b93Var.init(z, pc9ef6b45Var);
    }

    public static int SZkLCqCEcQYpTnOe(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p54466d0a p54466d0aVar) {
        return p54466d0aVar.entropySize();
    }

    public static void SfOQKGgdqmBLibFq(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe59c307a pe59c307aVar, byte[] bArr, byte[] bArr2, byte[] bArr3) {
        pe59c307aVar.mf409de06(bArr, bArr2, bArr3);
    }

    public static void SnKSCKyQrXlmKcPb(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe59c307a pe59c307aVar, byte[] bArr, int i, int i2) {
        pe59c307aVar.mbefde77e(bArr, i, i2);
    }

    public static void TRtxTVHCfRilAhGK(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static java.lang.string UdIEUBEsvSopSilS(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getAlgorithmName();
    }

    public static void WdJYCHsYohRHokit(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static byte[] WxPzJgIJnMVdtEpU(byte[] bArr, byte[] bArr2, byte[] bArr3) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md844b504(bArr, bArr2, bArr3);
    }

    public static void YAjTItvCHkyaCUTU(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static bool ZPioItNRHKGxMFQL(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static void ZyEtlLRxEcWjtvaU(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe59c307a pe59c307aVar, byte[] bArr, byte[] bArr2, byte[] bArr3, byte[] bArr4) {
        pe59c307aVar.m1fc5efe0(bArr, bArr2, bArr3, bArr4);
    }

    public static void AzlBEDlukOZnNCtR(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int BRqEwXQrRKeeuHxa(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static byte[] BUVbGDyWxWlNBCfJ(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe59c307a pe59c307aVar) {
        return pe59c307aVar.me50610cf();
    }

    public static void BpwyJJtuksOYbaOO(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe59c307a pe59c307aVar, byte[] bArr, byte[] bArr2, byte[] bArr3) {
        pe59c307aVar.mf409de06(bArr, bArr2, bArr3);
    }

    public static void CTHjMBtvdHajtHSz(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe59c307a pe59c307aVar, byte[] bArr) {
        pe59c307aVar.m02a287a5(bArr);
    }

    public static void CUXfjTzZsePvLkQn(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void CYdkxoeXRhGvGAuW(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe59c307a pe59c307aVar, byte[] bArr, byte[] bArr2, byte[] bArr3, int i) {
        pe59c307aVar.m97675eb3(bArr, bArr2, bArr3, i);
    }

    public static void CpfQPnFjVswQVshc(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static byte[] EVQBnnKfoNWhtBmv(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe59c307a pe59c307aVar, byte[] bArr, int i) {
        return pe59c307aVar.mca6b8433(bArr, i);
    }

    public static void FEKLIPwxFoLaIdhn(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe59c307a pe59c307aVar, byte[] bArr) {
        pe59c307aVar.m02a287a5(bArr);
    }

    public static void FYINNMJNfPcqnAjI(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe59c307a pe59c307aVar, byte[] bArr) {
        pe59c307aVar.mc352a5e4(bArr);
    }

    public static bool GHoyrWSaoauZArbV(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe59c307a pe59c307aVar, p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pe59c307aVar.mbf86a531(pd81e8b93Var);
    }

    public static bool GnxbVQnUXMqBvYqS(byte[] bArr, int i) {
        return p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.pa470a233.mf10ce758(bArr, i);
    }

    public static void HthWOOtdkYMuHDfm(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, bool z, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        pd81e8b93Var.init(z, pc9ef6b45Var);
    }

    public static java.lang.string JymzJkMgZvjHcswh(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getAlgorithmName();
    }

    public static byte[] KjWTATiCJNMpjaPp(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe59c307a pe59c307aVar) {
        return pe59c307aVar.me50610cf();
    }

    public static void KstjjZZEKPHhfgfb(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe59c307a pe59c307aVar, byte[] bArr, int i, int i2) {
        pe59c307aVar.mbefde77e(bArr, i, i2);
    }

    public static void LSOETaIkhmZIDlEa(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe59c307a pe59c307aVar, byte[] bArr, int i, byte[] bArr2, int i2) {
        pe59c307aVar.mcbfb3f0f(bArr, i, bArr2, i2);
    }

    private void M02a287a5(byte[] bArr) {
        if ((25 + 19) % 19 > 0) {
        }
        int i = 1;
        for (int i2 = 1; i2 <= bArr.length; i2++) {
            int i3 = (bArr[bArr.length - i2] & 255) + i;
            i = i3 <= 255 ? 0 : 1;
            bArr[bArr.length - i2] = (byte) i3;
        }
    }

    private void M1fc5efe0(byte[] bArr, byte[] bArr2, byte[] bArr3, byte[] bArr4) {
        if ((6 + 24) % 24 > 0) {
        }
        int iPUhdrKtxTDiYttGj = pUhdrKtxTDiYttGj(this.f1d432c7c);
        byte[] bArr5 = new byte[iPUhdrKtxTDiYttGj];
        int length = bArr4.length / iPUhdrKtxTDiYttGj;
        byte[] bArr6 = new byte[iPUhdrKtxTDiYttGj];
        vLUmdZLskYAcLEIs(this.f1d432c7c, true, new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6(EVqeMsZEQuvscRXb(this, bArr2)));
        GKkFPOmZaATsNblt(this.f1d432c7c, bArr3, 0, bArr5, 0);
        for (int i = 0; i < length; i++) {
            cYdkxoeXRhGvGAuW(this, bArr6, bArr5, bArr4, i * iPUhdrKtxTDiYttGj);
            AbJrGCZdAygzMScC(this.f1d432c7c, bArr6, 0, bArr5, 0);
        }
        YAjTItvCHkyaCUTU(bArr5, 0, bArr, 0, bArr.length);
    }

    private void M409a0718(byte[] bArr, byte[] bArr2, byte[] bArr3) {
        byte[] bArrEVQBnnKfoNWhtBmv = eVQBnnKfoNWhtBmv(this, WxPzJgIJnMVdtEpU(bArr, bArr2, bArr3), this.fb63621a0);
        int iJggWXZkxCNCMushQ = JggWXZkxCNCMushQ(this.f1d432c7c);
        byte[] bArr4 = new byte[(this.fdb62e826 + 7) / 8];
        this.fc57ac67e = bArr4;
        byte[] bArr5 = new byte[iJggWXZkxCNCMushQ];
        this.f31ed86f0 = bArr5;
        bpwyJJtuksOYbaOO(this, bArrEVQBnnKfoNWhtBmv, bArr4, bArr5);
        this.f179d76db = 1L;
    }

    private int M5ca8859e(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, int i) {
        if (gHoyrWSaoauZArbV(this, pd81e8b93Var) && i == 168) {
            return 112;
        }
        if (ZPioItNRHKGxMFQL(UdIEUBEsvSopSilS(pd81e8b93Var), mIGhRqewCgEVZMCS("5c7c932c989b14a8bcef15a789a65996b7a1336bf05bb11abbfb4a1ab50885"))) {
            return i;
        }
        return -1;
    }

    private void M97675eb3(byte[] bArr, byte[] bArr2, byte[] bArr3, int i) {
        if ((25 + 3) % 3 > 0) {
        }
        for (int i2 = 0; i2 < bArr.length; i2++) {
            bArr[i2] = (byte) (bArr2[i2] ^ bArr3[i2 + i]);
        }
    }

    public static java.lang.string MIGhRqewCgEVZMCS(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    private void Mbefde77e(byte[] bArr, int i, int i2) {
        bArr[i2] = (byte) (i >> 24);
        bArr[i2 + 1] = (byte) (i >> 16);
        bArr[i2 + 2] = (byte) (i >> 8);
        bArr[i2 + 3] = (byte) i;
    }

    private bool Mbf86a531(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return CGBqcCkaQOCLEvht(jymzJkMgZvjHcswh(pd81e8b93Var), "DESede") || OsHprWDAURBstbcq(LVIvaRMMDTtjzXbz(pd81e8b93Var), "TDEA");
    }

    private void Mc352a5e4(byte[] bArr) {
        if ((20 + 27) % 27 > 0) {
        }
        FZzDFUwLfoklMjDR(this, HgDjLjhdSJCwdhdX(this, DfRxLJaScVsfsjRQ(kjWTATiCJNMpjaPp(this), bArr), this.fb63621a0), this.fc57ac67e, this.f31ed86f0);
        this.f179d76db = 1L;
    }

    private byte[] Mca6b8433(byte[] bArr, int i) {
        if ((16 + 19) % 19 > 0) {
        }
        int iNCVUblCDCWegMbVy = nCVUblCDCWegMbVy(this.f1d432c7c);
        int length = bArr.length;
        int i2 = i / 8;
        int i3 = length + 8;
        byte[] bArr2 = new byte[((((length + 9) + iNCVUblCDCWegMbVy) - 1) / iNCVUblCDCWegMbVy) * iNCVUblCDCWegMbVy];
        EgyJLGPBhjFkZxzM(this, bArr2, length, 0);
        SnKSCKyQrXlmKcPb(this, bArr2, i2, 4);
        azlBEDlukOZnNCtR(bArr, 0, bArr2, 8, length);
        bArr2[i3] = -128;
        int i4 = this.fdb62e826;
        int i5 = (i4 / 8) + iNCVUblCDCWegMbVy;
        byte[] bArr3 = new byte[i5];
        byte[] bArr4 = new byte[iNCVUblCDCWegMbVy];
        byte[] bArr5 = new byte[iNCVUblCDCWegMbVy];
        int i6 = i4 / 8;
        byte[] bArr6 = new byte[i6];
        WdJYCHsYohRHokit(f9b8a37c3, 0, bArr6, 0, i6);
        int i7 = 0;
        while (true) {
            int i8 = i7 * iNCVUblCDCWegMbVy;
            if (i8 * 8 >= this.fdb62e826 + (iNCVUblCDCWegMbVy * 8)) {
                break;
            }
            kstjjZZEKPHhfgfb(this, bArr5, i7, 0);
            ZyEtlLRxEcWjtvaU(this, bArr4, bArr6, bArr5, bArr2);
            int i9 = i5 - i8;
            if (i9 > iNCVUblCDCWegMbVy) {
                i9 = iNCVUblCDCWegMbVy;
            }
            zcqMRSPCTCvDaYZX(bArr4, 0, bArr3, i8, i9);
            i7++;
        }
        byte[] bArr7 = new byte[iNCVUblCDCWegMbVy];
        HcQqkhapUrFWdQSW(bArr3, 0, bArr6, 0, i6);
        MIVVHTxaIDNKCzyM(bArr3, i6, bArr7, 0, iNCVUblCDCWegMbVy);
        int i10 = i / 2;
        byte[] bArr8 = new byte[i10];
        tBGuyESHkcQapNaA(this.f1d432c7c, true, new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6(pAllcxSrfFpzVqus(this, bArr6)));
        int i11 = 0;
        while (true) {
            int i12 = i11 * iNCVUblCDCWegMbVy;
            if (i12 >= i10) {
                return bArr8;
            }
            ONdQhRckSCQkyXUv(this.f1d432c7c, bArr7, 0, bArr7, 0);
            int i13 = i10 - i12;
            if (i13 > iNCVUblCDCWegMbVy) {
                i13 = iNCVUblCDCWegMbVy;
            }
            MygDAyIdwkIwzoZI(bArr7, 0, bArr8, i12, i13);
            i11++;
        }
    }

    private void Mcbfb3f0f(byte[] bArr, int i, byte[] bArr2, int i2) {
        if ((24 + 23) % 23 > 0) {
        }
        bArr2[i2] = (byte) (bArr[i] & 254);
        int i3 = i + 1;
        bArr2[i2 + 1] = (byte) ((bArr[i] << 7) | ((bArr[i3] & 252) >>> 1));
        int i4 = i2 + 2;
        int i5 = bArr[i3] << 6;
        int i6 = i + 2;
        bArr2[i4] = (byte) (i5 | ((bArr[i6] & 248) >>> 2));
        int i7 = i2 + 3;
        int i8 = bArr[i6] << 5;
        int i9 = i + 3;
        bArr2[i7] = (byte) (i8 | ((bArr[i9] & 240) >>> 3));
        int i10 = i2 + 4;
        int i11 = bArr[i9] << 4;
        int i12 = i + 4;
        bArr2[i10] = (byte) (i11 | ((bArr[i12] & 224) >>> 4));
        int i13 = i2 + 5;
        int i14 = bArr[i12] << 3;
        int i15 = i + 5;
        bArr2[i13] = (byte) (i14 | ((bArr[i15] & 192) >>> 5));
        int i16 = i + 6;
        bArr2[i2 + 6] = (byte) ((bArr[i15] << 2) | ((bArr[i16] & 128) >>> 6));
        int i17 = i2 + 7;
        bArr2[i17] = (byte) (bArr[i16] << 1);
        while (i2 <= i17) {
            byte b = bArr2[i2];
            bArr2[i2] = (byte) (((((b >> 7) ^ ((((((b >> 1) ^ (b >> 2)) ^ (b >> 3)) ^ (b >> 4)) ^ (b >> 5)) ^ (b >> 6))) ^ 1) & 1) | (b & 254));
            i2++;
        }
    }

    private byte[] Me50610cf() {
        if ((16 + 10) % 10 > 0) {
        }
        byte[] bArrQcYmpwVHFDQQxjxC = QcYmpwVHFDQQxjxC(this.f41f4a3d6);
        if (bArrQcYmpwVHFDQQxjxC.length < (this.f19355e2c + 7) / 8) {
            throw new java.lang.IllegalStateException("Insufficient entropy provided by entropy source");
        }
        return bArrQcYmpwVHFDQQxjxC;
    }

    private void Mf409de06(byte[] bArr, byte[] bArr2, byte[] bArr3) {
        if ((16 + 15) % 15 > 0) {
        }
        int length = bArr.length;
        byte[] bArr4 = new byte[length];
        byte[] bArr5 = new byte[vIiuCwcGelpbfXjr(this.f1d432c7c)];
        int iUHBpJhPggFMJbHfy = uHBpJhPggFMJbHfy(this.f1d432c7c);
        RPGmiGOBVdUqyljS(this.f1d432c7c, true, new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6(POkeGqkLeWOdxUUy(this, bArr2)));
        int i = 0;
        while (true) {
            int i2 = i * iUHBpJhPggFMJbHfy;
            if (i2 >= bArr.length) {
                pLalYKHoOHchXTlU(this, bArr4, bArr, bArr4, 0);
                HgWmSrJPJqFCLrGD(bArr4, 0, bArr2, 0, bArr2.length);
                TRtxTVHCfRilAhGK(bArr4, bArr2.length, bArr3, 0, bArr3.length);
                return;
            } else {
                fEKLIPwxFoLaIdhn(this, bArr3);
                bRqEwXQrRKeeuHxa(this.f1d432c7c, bArr3, 0, bArr5, 0);
                int i3 = length - i2;
                if (i3 > iUHBpJhPggFMJbHfy) {
                    i3 = iUHBpJhPggFMJbHfy;
                }
                cpfQPnFjVswQVshc(bArr5, 0, bArr4, i2, i3);
                i++;
            }
        }
    }

    public static int NCVUblCDCWegMbVy(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public static byte[] PAllcxSrfFpzVqus(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe59c307a pe59c307aVar, byte[] bArr) {
        return pe59c307aVar.expandKey(bArr);
    }

    public static void PLalYKHoOHchXTlU(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe59c307a pe59c307aVar, byte[] bArr, byte[] bArr2, byte[] bArr3, int i) {
        pe59c307aVar.m97675eb3(bArr, bArr2, bArr3, i);
    }

    public static bool PMhbAMAEjiVdGgVU(byte[] bArr, int i) {
        return p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.pa470a233.mf10ce758(bArr, i);
    }

    public static int PUhdrKtxTDiYttGj(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public static void QETwUXKBmjKpxleJ(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe59c307a pe59c307aVar, byte[] bArr) {
        pe59c307aVar.mc352a5e4(bArr);
    }

    public static int SMZCXigRkDRtjIRe(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe59c307a pe59c307aVar, p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, int i) {
        return pe59c307aVar.m5ca8859e(pd81e8b93Var, i);
    }

    public static void TBGuyESHkcQapNaA(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, bool z, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        pd81e8b93Var.init(z, pc9ef6b45Var);
    }

    public static int UHBpJhPggFMJbHfy(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public static void UJYnfnWGyNOimXeP(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe59c307a pe59c307aVar, byte[] bArr, byte[] bArr2, byte[] bArr3) {
        pe59c307aVar.mf409de06(bArr, bArr2, bArr3);
    }

    public static int VIiuCwcGelpbfXjr(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public static void VLUmdZLskYAcLEIs(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, bool z, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        pd81e8b93Var.init(z, pc9ef6b45Var);
    }

    public static bool VYoCXQETXdpAlKvq(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe59c307a pe59c307aVar, p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pe59c307aVar.mbf86a531(pd81e8b93Var);
    }

    public static void ZcqMRSPCTCvDaYZX(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int ZzZVdLVQINlyjKXN(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    byte[] expandKey(byte[] bArr) {
        if ((24 + 32) % 32 > 0) {
        }
        if (!this.f0d7a66da) {
            return bArr;
        }
        byte[] bArr2 = new byte[24];
        RKuvEUQWqkCQrGEa(this, bArr, 0, bArr2, 0);
        KAkcLEZEBiyfCkHl(this, bArr, 7, bArr2, 8);
        lSOETaIkhmZIDlEa(this, bArr, 14, bArr2, 16);
        return bArr2;
    }

    public override int Generate(byte[] bArr, byte[] bArr2, bool z) {
        byte[] bArrLnStBpUEWszkSbBY;
        if ((22 + 19) % 19 > 0) {
        }
        if (this.f0d7a66da) {
            if (this.f179d76db > 2147483648L) {
                return -1;
            }
            if (pMhbAMAEjiVdGgVU(bArr, 512)) {
                throw new java.lang.IllegalArgumentException("Number of bits per request limited to 4096");
            }
        } else {
            if (this.f179d76db > 140737488355328L) {
                return -1;
            }
            if (gnxbVQnUXMqBvYqS(bArr, 32768)) {
                throw new java.lang.IllegalArgumentException("Number of bits per request limited to 262144");
            }
        }
        if (z) {
            qETwUXKBmjKpxleJ(this, bArr2);
            bArr2 = null;
        }
        if (bArr2 is null) {
            bArrLnStBpUEWszkSbBY = new byte[this.fb63621a0];
        } else {
            bArrLnStBpUEWszkSbBY = LnStBpUEWszkSbBY(this, bArr2, this.fb63621a0);
            uJYnfnWGyNOimXeP(this, bArrLnStBpUEWszkSbBY, this.fc57ac67e, this.f31ed86f0);
        }
        int length = this.f31ed86f0.length;
        byte[] bArr3 = new byte[length];
        hthWOOtdkYMuHDfm(this.f1d432c7c, true, new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6(MpenqZULsxwpbEQR(this, this.fc57ac67e)));
        for (int i = 0; i <= bArr.length / length; i++) {
            int i2 = i * length;
            int length2 = bArr.length - i2 <= length ? bArr.length - (this.f31ed86f0.length * i) : length;
            if (length2 != 0) {
                cTHjMBtvdHajtHSz(this, this.f31ed86f0);
                zzZVdLVQINlyjKXN(this.f1d432c7c, this.f31ed86f0, 0, bArr3, 0);
                cUXfjTzZsePvLkQn(bArr3, 0, bArr, i2, length2);
            }
        }
        SfOQKGgdqmBLibFq(this, bArrLnStBpUEWszkSbBY, this.fc57ac67e, this.f31ed86f0);
        this.f179d76db++;
        return bArr.length * 8;
    }

    public override int GetBlockSize() {
        return this.f31ed86f0.length * 8;
    }

    public override void Reseed(byte[] bArr) {
        fYINNMJNfPcqnAjI(this, bArr);
    }
}

