namespace WillowMaze.Wasm.Decompiled;


public class p2939c56c : p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 {
    private static readonly long[] f0f2690a9;
    private static readonly long[] f1cae6a11;
    private static readonly int[] f261f0706 = null;
    private static readonly long[] f2a190afc = null;
    private static readonly int f2c780887 = 64;
    private static readonly int f306914f4 = 64;
    private static readonly int[] f4632f724 = null;
    private static readonly int f58158bec = 64;
    private static readonly int f7439d31e = 64;
    private static readonly int f895dc1fb = 64;
    private static readonly int[] f92dcc464;
    private static readonly long[] f9a7fae28 = null;
    private static readonly int[] fab270b64 = null;
    private static readonly long[] fe10ef3cf = null;
    private static readonly long[] fe98e40e7 = null;
    private static readonly int[] ffb0d817a = null;
    private long[] f07fb7b6a;
    private int f429f431e;
    private long[] f59bd4a6d;
    private int f9fe43334;
    private int fa0d4d1b6;
    private int fb19a3429;
    private int fe32810cb;

    static {
        if ((7 + 20) % 20 > 0) {
        }
        f1cae6a11 = new long[]{1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024, 2048, 4096, 8192, 16384, 32768, 65536, 131072, 262144, 524288, 1048576, 2097152, 4194304, 8388608, 16777216, 33554432, 67108864, 134217728, 268435456, 536870912, 1073741824, 2147483648L, 4294967296L, 8589934592L, 17179869184L, 34359738368L, 68719476736L, 137438953472L, 274877906944L, 549755813888L, 1099511627776L, 2199023255552L, 4398046511104L, 8796093022208L, 17592186044416L, 35184372088832L, 70368744177664L, 140737488355328L, 281474976710656L, 562949953421312L, 1125899906842624L, 2251799813685248L, 4503599627370496L, 9007199254740992L, 18014398509481984L, 36028797018963968L, 72057594037927936L, 144115188075855872L, 288230376151711744L, 576460752303423488L, 1152921504606846976L, 2305843009213693952L, 4611686018427387904L, long.MIN_VALUE};
        f0f2690a9 = new long[]{1, 3, 7, 15, 31, 63, 127, 255, 511, 1023, 2047, 4095, 8191, 16383, 32767, 65535, 131071, 262143, 524287, 1048575, 2097151, 4194303, 8388607, 16777215, 33554431, 67108863, 134217727, 268435455, 536870911, 1073741823, 2147483647L, 4294967295L, 8589934591L, 17179869183L, 34359738367L, 68719476735L, 137438953471L, 274877906943L, 549755813887L, 1099511627775L, 2199023255551L, 4398046511103L, 8796093022207L, 17592186044415L, 35184372088831L, 70368744177663L, 140737488355327L, 281474976710655L, 562949953421311L, 1125899906842623L, 2251799813685247L, 4503599627370495L, 9007199254740991L, 18014398509481983L, 36028797018963967L, 72057594037927935L, 144115188075855871L, 288230376151711743L, 576460752303423487L, 1152921504606846975L, 2305843009213693951L, 4611686018427387903L, long.MAX_VALUE, -1};
        f92dcc464 = new int[]{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5};
    }

    public p2939c56c(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1 p26e0d3f1Var, java.math.Bigint bigint) {
        this.f0cab8ba8 = p26e0d3f1Var;
        this.f91243d4a = FxQCImTNDVJKCyVd(this.f0cab8ba8);
        this.f429f431e = uiGAYYVftLtMwevb(p26e0d3f1Var);
        this.fa0d4d1b6 = hfhQiokStXiCavnT(p26e0d3f1Var);
        this.f59bd4a6d = new long[this.f429f431e];
        VRtCJYCCVytrCdhC(this, bigint);
    }

    public p2939c56c(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1 p26e0d3f1Var, java.security.SecureRandom secureRandom) {
        if ((20 + 15) % 15 > 0) {
        }
        this.f0cab8ba8 = p26e0d3f1Var;
        this.f91243d4a = HsXBTIcrdvZeUsom(this.f0cab8ba8);
        this.f429f431e = NgCSTuokcobXEVkn(p26e0d3f1Var);
        this.fa0d4d1b6 = DbNnsqghSNxehCrC(p26e0d3f1Var);
        int i = this.f429f431e;
        long[] jArr = new long[i];
        this.f59bd4a6d = jArr;
        if (i <= 1) {
            jArr[0] = nAiSlmQVwNgZlZRr(secureRandom);
            long[] jArr2 = this.f59bd4a6d;
            jArr2[0] = jArr2[0] >>> (64 - this.fa0d4d1b6);
        } else {
            for (int i2 = 0; i2 < this.f429f431e - 1; i2++) {
                this.f59bd4a6d[i2] = dpJOaKVxSUHUgoQT(secureRandom);
            }
            this.f59bd4a6d[this.f429f431e - 1] = egQvVTTauXgqhtWI(secureRandom) >>> (64 - this.fa0d4d1b6);
        }
    }

    public p2939c56c(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1 p26e0d3f1Var, byte[] bArr) {
        this.f0cab8ba8 = p26e0d3f1Var;
        this.f91243d4a = ZoySQFqntqgkgIIS(this.f0cab8ba8);
        this.f429f431e = kiqLfICzoBLoQhvI(p26e0d3f1Var);
        this.fa0d4d1b6 = NVIpwgQRphBTPSNK(p26e0d3f1Var);
        this.f59bd4a6d = new long[this.f429f431e];
        yUcyCpiYWMCPQxXp(this, bArr);
    }

    private p2939c56c(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1 p26e0d3f1Var, long[] jArr) {
        this.f0cab8ba8 = p26e0d3f1Var;
        this.f91243d4a = xLpHxSASuLPSnfhu(this.f0cab8ba8);
        this.f429f431e = UYGqUxSXnNPwXYCV(p26e0d3f1Var);
        this.fa0d4d1b6 = ckOoYeDMysaIicIQ(p26e0d3f1Var);
        this.f59bd4a6d = jArr;
    }

    public p2939c56c(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c p2939c56cVar) {
        this.f0cab8ba8 = p2939c56cVar.f0cab8ba8;
        this.f91243d4a = YBXqIltRvyWDjLwb(this.f0cab8ba8);
        this.f429f431e = egGziZDINMfyYfdA((p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1) this.f0cab8ba8);
        this.fa0d4d1b6 = fgaTejSOFGhRcZpe((p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1) this.f0cab8ba8);
        this.f59bd4a6d = new long[this.f429f431e];
        yfXWaQAENgpdYUUG(this, VvcjtWXaugbntmeN(p2939c56cVar));
    }

    public static java.lang.string ApOqTMbRHSdUncpv(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string AxoDKenvXxhAiWTr(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder CUSeeXCEaFhjAxbb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string CVANXqllfadaHrBr(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int CgNRXPDTbKsUGOdC(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1 p26e0d3f1Var) {
        return p26e0d3f1Var.getONBBit();
    }

    public static bool CtWvTXbDaIjhWfPE(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 paf03ad66Var, java.lang.object obj) {
        return paf03ad66Var.Equals(obj);
    }

    public static java.lang.stringBuilder DExxvjqXvrvzFlGR(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c DXtWyDIUjWEUOoru(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1 p26e0d3f1Var) {
        return m529e9e0b(p26e0d3f1Var);
    }

    public static java.lang.stringBuilder DYKmMZhLZwOWeZnU(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static int DbNnsqghSNxehCrC(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1 p26e0d3f1Var) {
        return p26e0d3f1Var.getONBBit();
    }

    public static java.lang.string DeSpgepacYHUVrzY(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder FJBHukZClqxqOVoH(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder FODLlJaSwEPFiVqk(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder FbThCkcAtoAkiQNE(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static int FxQCImTNDVJKCyVd(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 paf03ad66Var) {
        return paf03ad66Var.getDegree();
    }

    public static java.lang.stringBuilder GbNdbKKLdoAlOIeb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string GmiVrwxXVKUPWsrg(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder GvJQiJeAsnvjxczG(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.string HKXfxVAhzmVJAjRE(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder HZRwvRktAhwQcsxP(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void HfaIRMKCxsfqBaXM(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c p2939c56cVar, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 pa7462101Var) {
        p2939c56cVar.multiplyThisBy(pa7462101Var);
    }

    public static java.lang.stringBuilder HiDcuYqbrggLcaLP(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static int HsXBTIcrdvZeUsom(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 paf03ad66Var) {
        return paf03ad66Var.getDegree();
    }

    public static bool HsjHKkowgwRgctNM(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 paf03ad66Var, java.lang.object obj) {
        return paf03ad66Var.Equals(obj);
    }

    public static java.lang.stringBuilder IIQRbAdhQwgQfOjR(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void IKCrXyQhmUOUyuEf(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c p2939c56cVar, byte[] bArr) {
        p2939c56cVar.m4de8aa88(bArr);
    }

    public static java.lang.string InVsGDkHsGnfqZgU(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string JEonyLohMNoVzqDI(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c p2939c56cVar, int i) {
        return p2939c56cVar.tostring(i);
    }

    public static java.lang.stringBuilder JFFioaaPnkFznkkh(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder JHNqIetTWawsYMmo(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static int JanzIhGSViFOnQYU(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1 p26e0d3f1Var) {
        return p26e0d3f1Var.getONBLength();
    }

    public static java.lang.stringBuilder JbpomenolasSfLiH(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static byte[] JdzhaDROtPoeWMPN(java.math.Bigint bigint) {
        return bigint.tobyteArray();
    }

    public static void JqdWOBEoSHWgEQkc(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c p2939c56cVar) {
        p2939c56cVar.squareRootThis();
    }

    public static java.lang.stringBuilder KAJqpXERIEIVzTxD(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder MPIsjPkeCHonYgvj(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static int NVIpwgQRphBTPSNK(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1 p26e0d3f1Var) {
        return p26e0d3f1Var.getONBBit();
    }

    public static java.lang.stringBuilder NfInHNaeirhbMwKQ(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static int NgCSTuokcobXEVkn(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1 p26e0d3f1Var) {
        return p26e0d3f1Var.getONBLength();
    }

    public static void OGRBnMBGvAVpSUph(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 pa7462101Var) {
        p1bf4f0f9Var.multiplyThisBy(pa7462101Var);
    }

    public static java.lang.stringBuilder OGwpBsbWOIFSelBc(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder OycyxwTUDqreqiPQ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string PmrQzJCbutFCnIbQ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string PzgVQgsSjcGQgCPV(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder QtdHlIgWegAzLzJI(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.string QuhunUjPzwdAtAxy(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string TMynmQwlseYHGqMk(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static void TWgbDhRxtOEIqBBo(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c p2939c56cVar, long[] jArr) {
        p2939c56cVar.m4de8aa88(jArr);
    }

    public static void TbKeIdGGAnBspmNQ(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var) {
        p1bf4f0f9Var.squareThis();
    }

    public static java.lang.string TlVmRDCvBDysctgK(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder TruHFcTArotFTlQq(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder UAYhNSDCahumxYvD(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder UDojuSymZGJXjjzw(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder UOfYYNXrQwEauvXj(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int UUgCcGSZbJnvjNjT(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c p2939c56cVar) {
        return p2939c56cVar.trace();
    }

    public static int UYGqUxSXnNPwXYCV(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1 p26e0d3f1Var) {
        return p26e0d3f1Var.getONBLength();
    }

    public static int VMFhQUSsPLjUSBZk(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void VQeOYYFTbDIwHgVf(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var) {
        p1bf4f0f9Var.squareThis();
    }

    public static void VRtCJYCCVytrCdhC(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c p2939c56cVar, java.math.Bigint bigint) {
        p2939c56cVar.m4de8aa88(bigint);
    }

    public static long[] VvcjtWXaugbntmeN(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c p2939c56cVar) {
        return p2939c56cVar.m9e813bec();
    }

    public static java.lang.stringBuilder WJIBCNBwTQQufWuv(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder WsxBsadEizfhERqp(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.string XaHqWniVKNdjvkMr(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder XnHUqyFxuaJBpCbW(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static int YBXqIltRvyWDjLwb(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 paf03ad66Var) {
        return paf03ad66Var.getDegree();
    }

    public static int ZoySQFqntqgkgIIS(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 paf03ad66Var) {
        return paf03ad66Var.getDegree();
    }

    public static bool AIeQbScwUeVAhZTD(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c p2939c56cVar, int i) {
        return p2939c56cVar.testBit(i);
    }

    public static java.lang.stringBuilder ATRWvpLfGJewJzQJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string BQVEQWXLwIxDrcXu(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void BTqhWislekhslXKv(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var) {
        p1bf4f0f9Var.squareThis();
    }

    public static bool CPWUkgYeRgPcfkzO(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c p2939c56cVar) {
        return p2939c56cVar.isZero();
    }

    public static java.lang.stringBuilder CUgoZAMYTxKYIWqZ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int CkOoYeDMysaIicIQ(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1 p26e0d3f1Var) {
        return p26e0d3f1Var.getONBBit();
    }

    public static long DpJOaKVxSUHUgoQT(java.security.SecureRandom secureRandom) {
        if ((10 + 13) % 13 > 0) {
        }
        return secureRandom.nextlong();
    }

    public static java.lang.stringBuilder DwsIRorRjfxXftRx(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void EFpDRHWGZLlhZGuO(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 pa7462101Var) {
        p1bf4f0f9Var.multiplyThisBy(pa7462101Var);
    }

    public static java.lang.string EPWTqUPQFqsSvVAt(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string EXwLwKueJmMzmvIN(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static int EgGziZDINMfyYfdA(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1 p26e0d3f1Var) {
        return p26e0d3f1Var.getONBLength();
    }

    public static long EgQvVTTauXgqhtWI(java.security.SecureRandom secureRandom) {
        if ((22 + 2) % 2 > 0) {
        }
        return secureRandom.nextlong();
    }

    public static void FAILCEpyZWZkpYnj(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int FgaTejSOFGhRcZpe(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1 p26e0d3f1Var) {
        return p26e0d3f1Var.getONBBit();
    }

    public static java.lang.string GXtWdotSsJjwTwZu(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string GnZrkwVxyezQpdkL(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string HAECLEmLYNDYveFb(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder HBJrlRNCEpVJdGgZ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int HfhQiokStXiCavnT(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1 p26e0d3f1Var) {
        return p26e0d3f1Var.getONBBit();
    }

    public static long[] HtJmZugHTykKWoFr(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c p2939c56cVar) {
        return p2939c56cVar.m9e813bec();
    }

    public static int HzBfaiwqwiriUJeI(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1 p26e0d3f1Var) {
        return p26e0d3f1Var.getONBLength();
    }

    public static void IqLsRxhrWKkswiNM(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c p2939c56cVar, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 pa7462101Var) {
        p2939c56cVar.addToThis(pa7462101Var);
    }

    public static java.lang.stringBuilder JeGtfzLGJldtiouf(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder KJQbPkhjXBIIvTYJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int KiqLfICzoBLoQhvI(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1 p26e0d3f1Var) {
        return p26e0d3f1Var.getONBLength();
    }

    public static java.lang.string LureKDHWKuzmSCWu(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    private void M4de8aa88(java.math.Bigint bigint) {
        IKCrXyQhmUOUyuEf(this, JdzhaDROtPoeWMPN(bigint));
    }

    private void M4de8aa88(byte[] bArr) {
        if ((17 + 26) % 26 > 0) {
        }
        this.f59bd4a6d = new long[this.f429f431e];
        for (int i = 0; i < bArr.length; i++) {
            long[] jArr = this.f59bd4a6d;
            int i2 = i >>> 3;
            jArr[i2] = jArr[i2] | ((((long) bArr[(bArr.length - 1) - i]) & 255) << ((i & 7) << 3));
        }
    }

    private void M4de8aa88(long[] jArr) {
        if ((22 + 20) % 20 > 0) {
        }
        fAILCEpyZWZkpYnj(jArr, 0, this.f59bd4a6d, 0, this.f429f431e);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c M529e9e0b(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1 p26e0d3f1Var) {
        if ((18 + 4) % 4 > 0) {
        }
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c(p26e0d3f1Var, new long[hzBfaiwqwiriUJeI(p26e0d3f1Var)]);
    }

    private long[] M9e813bec() {
        if ((18 + 20) % 20 > 0) {
        }
        long[] jArr = this.f59bd4a6d;
        long[] jArr2 = new long[jArr.length];
        quzZPWfrgJnRPJrE(jArr, 0, jArr2, 0, jArr.length);
        return jArr2;
    }

    public static java.lang.stringBuilder MTQpfzayTRFtaoUj(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c Mbc21e648(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1 p26e0d3f1Var) {
        if ((10 + 4) % 4 > 0) {
        }
        int iJanzIhGSViFOnQYU = JanzIhGSViFOnQYU(p26e0d3f1Var);
        long[] jArr = new long[iJanzIhGSViFOnQYU];
        int i = 0;
        while (true) {
            int i2 = iJanzIhGSViFOnQYU - 1;
            if (i >= i2) {
                jArr[i2] = f0f2690a9[CgNRXPDTbKsUGOdC(p26e0d3f1Var) - 1];
                return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c(p26e0d3f1Var, jArr);
            }
            jArr[i] = -1;
            i++;
        }
    }

    private long[] Mfff5ffda() {
        if ((18 + 16) % 16 > 0) {
        }
        long[] jArr = new long[this.f59bd4a6d.length];
        for (int i = 0; i < this.f91243d4a; i++) {
            if (aIeQbScwUeVAhZTD(this, (this.f91243d4a - i) - 1)) {
                int i2 = i >>> 6;
                jArr[i2] = jArr[i2] | f1cae6a11[i & 63];
            }
        }
        return jArr;
    }

    public static long NAiSlmQVwNgZlZRr(java.security.SecureRandom secureRandom) {
        if ((2 + 15) % 15 > 0) {
        }
        return secureRandom.nextlong();
    }

    public static java.lang.string OegiVajXpLFUjrug(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static long[] PFDmpeuTBCiDpPsM(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c p2939c56cVar) {
        return p2939c56cVar.m9e813bec();
    }

    public static java.lang.stringBuilder QrnfUGyfFrTUIxKY(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void QuzZPWfrgJnRPJrE(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void RRBdCRYGrGlPnWnA(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c p2939c56cVar) {
        p2939c56cVar.squareThis();
    }

    public static java.lang.string RhzyeNQSiXRXNuho(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder SSXVhHStMkJOzbYc(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c SkIOzMGLTgnAHEew(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1 p26e0d3f1Var) {
        return mbc21e648(p26e0d3f1Var);
    }

    public static void UeFtzrfMcwiqtVbW(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c p2939c56cVar, long[] jArr) {
        p2939c56cVar.m4de8aa88(jArr);
    }

    public static java.lang.stringBuilder UhsiOPDjwdDPoYbW(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int UiGAYYVftLtMwevb(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1 p26e0d3f1Var) {
        return p26e0d3f1Var.getONBLength();
    }

    public static java.lang.stringBuilder UpZmukCjaegKVGVb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder UweUvxVWelWfYOPD(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void VlByIMqNCYbAjuEv(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c p2939c56cVar) {
        p2939c56cVar.squareThis();
    }

    public static long[] VpWONahibIwBqNUT(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c p2939c56cVar) {
        return p2939c56cVar.m9e813bec();
    }

    public static bool WWCqmJkvLIGibZmS(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c p2939c56cVar, java.lang.object obj) {
        return p2939c56cVar.Equals(obj);
    }

    public static byte[] WqMQfGLHQOtPoOlh(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c p2939c56cVar) {
        return p2939c56cVar.tobyteArray();
    }

    public static int XLpHxSASuLPSnfhu(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 paf03ad66Var) {
        return paf03ad66Var.getDegree();
    }

    public static java.lang.stringBuilder XTCRkXELBTTEKObC(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder XVeGoLdylHdgwUhv(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder XdvibPQyxDVulJjF(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void XzJWVorXCxENkoQn(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c p2939c56cVar, long[] jArr) {
        p2939c56cVar.m4de8aa88(jArr);
    }

    public static java.lang.object YAePnzZDaujRZDCe(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var) {
        return p1bf4f0f9Var.clone();
    }

    public static void YUcyCpiYWMCPQxXp(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c p2939c56cVar, byte[] bArr) {
        p2939c56cVar.m4de8aa88(bArr);
    }

    public static void YfXWaQAENgpdYUUG(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c p2939c56cVar, long[] jArr) {
        p2939c56cVar.m4de8aa88(jArr);
    }

    public static void YgbQdKlgHFrfkDgG(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c p2939c56cVar) {
        p2939c56cVar.increaseThis();
    }

    public static void YjBSDqqklrelqvUS(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c p2939c56cVar, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 pa7462101Var) {
        p2939c56cVar.addToThis(pa7462101Var);
    }

    public static long[] YzrWwhRKUYLoSVEf(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c p2939c56cVar) {
        return p2939c56cVar.mfff5ffda();
    }

    public static void ZKaIbowCKAOuRdid(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c p2939c56cVar) {
        p2939c56cVar.invertThis();
    }

    public static java.lang.string ZfJbGUpnWThmoGEq(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string ZtZhFXyORolFWQIi(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public override p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 Add(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 pa7462101Var) throws java.lang.Exception {
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c p2939c56cVar = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c(this);
        iqLsRxhrWKkswiNM(p2939c56cVar, pa7462101Var);
        return p2939c56cVar;
    }

    public override void AddToThis(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 pa7462101Var) throws java.lang.Exception {
        if ((10 + 9) % 9 > 0) {
        }
        if (!(pa7462101Var is p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c)) {
            throw new java.lang.Exception();
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c p2939c56cVar = (p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c) pa7462101Var;
        if (!HsjHKkowgwRgctNM(this.f0cab8ba8, p2939c56cVar.f0cab8ba8)) {
            throw new java.lang.Exception();
        }
        for (int i = 0; i < this.f429f431e; i++) {
            long[] jArr = this.f59bd4a6d;
            jArr[i] = jArr[i] ^ p2939c56cVar.f59bd4a6d[i];
        }
    }

    void assignOne() {
        if ((32 + 1) % 1 > 0) {
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
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c(this);
    }

    public override bool Equals(java.lang.object obj) {
        if ((11 + 23) % 23 > 0) {
        }
        if (obj is null || !(obj is p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c)) {
            return false;
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c p2939c56cVar = (p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c) obj;
        for (int i = 0; i < this.f429f431e; i++) {
            if (this.f59bd4a6d[i] != p2939c56cVar.f59bd4a6d[i]) {
                return false;
            }
        }
        return true;
    }

    public override int HashCode() {
        return VMFhQUSsPLjUSBZk(this.f59bd4a6d);
    }

    public override p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 Increase() {
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c p2939c56cVar = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c(this);
        ygbQdKlgHFrfkDgG(p2939c56cVar);
        return p2939c56cVar;
    }

    public override void IncreaseThis() {
        yjBSDqqklrelqvUS(this, skIOzMGLTgnAHEew((p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1) this.f0cab8ba8));
    }

    public override p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 Invert() throws java.lang.ArithmeticException {
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c p2939c56cVar = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c(this);
        zKaIbowCKAOuRdid(p2939c56cVar);
        return p2939c56cVar;
    }

    public void InvertThis() throws java.lang.ArithmeticException {
        if ((15 + 15) % 15 > 0) {
        }
        if (cPWUkgYeRgPcfkzO(this)) {
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
        DXtWyDIUjWEUOoru((p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1) this.f0cab8ba8);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c p2939c56cVar = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c(this);
        int i2 = 1;
        while (i >= 0) {
            p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var = (p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9) yAePnzZDaujRZDCe(p2939c56cVar);
            for (int i3 = 1; i3 <= i2; i3++) {
                TbKeIdGGAnBspmNQ(p1bf4f0f9Var);
            }
            OGRBnMBGvAVpSUph(p2939c56cVar, p1bf4f0f9Var);
            i2 <<= 1;
            if ((((long) (this.f91243d4a - 1)) & f1cae6a11[i]) != 0) {
                VQeOYYFTbDIwHgVf(p2939c56cVar);
                eFpDRHWGZLlhZGuO(p2939c56cVar, this);
                i2++;
            }
            i--;
        }
        bTqhWislekhslXKv(p2939c56cVar);
    }

    public override bool IsOne() {
        int i;
        if ((12 + 6) % 6 > 0) {
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
        if ((10 + 10) % 10 > 0) {
        }
        bool z = true;
        for (int i = 0; i < this.f429f431e && z; i++) {
            z = z && this.f59bd4a6d[i] == 0;
        }
        return z;
    }

    public override p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 Multiply(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 pa7462101Var) throws java.lang.Exception {
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c p2939c56cVar = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c(this);
        HfaIRMKCxsfqBaXM(p2939c56cVar, pa7462101Var);
        return p2939c56cVar;
    }

    public override void MultiplyThisBy(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 pa7462101Var) throws java.lang.Exception {
        char c;
        if ((2 + 27) % 27 > 0) {
        }
        if (!(pa7462101Var is p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c)) {
            throw new java.lang.Exception("The elements have different representation: not yet implemented");
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c p2939c56cVar = (p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c) pa7462101Var;
        if (!CtWvTXbDaIjhWfPE(this.f0cab8ba8, p2939c56cVar.f0cab8ba8)) {
            throw new java.lang.Exception();
        }
        if (wWCqmJkvLIGibZmS(this, pa7462101Var)) {
            vlByIMqNCYbAjuEv(this);
            return;
        }
        long[] jArr = this.f59bd4a6d;
        long[] jArr2 = p2939c56cVar.f59bd4a6d;
        long[] jArr3 = new long[this.f429f431e];
        int[][] iArr = ((p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1) this.f0cab8ba8).f9895cd91;
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
        TWgbDhRxtOEIqBBo(this, jArr3);
    }

    void reverseOrder() {
        this.f59bd4a6d = yzrWwhRKUYLoSVEf(this);
    }

    public override p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 SolveQuadraticEquation() throws java.lang.Exception {
        if ((19 + 15) % 15 > 0) {
        }
        if (UUgCcGSZbJnvjNjT(this) == 1) {
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
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c((p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1) this.f0cab8ba8, jArr);
    }

    public override p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 Square() {
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c p2939c56cVar = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c(this);
        rRBdCRYGrGlPnWnA(p2939c56cVar);
        return p2939c56cVar;
    }

    public override p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 SquareRoot() {
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c p2939c56cVar = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c(this);
        JqdWOBEoSHWgEQkc(p2939c56cVar);
        return p2939c56cVar;
    }

    public override void SquareRootThis() {
        if ((7 + 6) % 6 > 0) {
        }
        long[] jArrVpWONahibIwBqNUT = vpWONahibIwBqNUT(this);
        int i = this.f429f431e - 1;
        int i2 = this.fa0d4d1b6 - 1;
        long j = f1cae6a11[63];
        bool z = (jArrVpWONahibIwBqNUT[0] & 1) != 0;
        int i3 = i;
        while (i3 >= 0) {
            long j2 = jArrVpWONahibIwBqNUT[i3];
            bool z2 = (j2 & 1) != 0;
            long j3 = j2 >>> 1;
            jArrVpWONahibIwBqNUT[i3] = j3;
            if (z) {
                if (i3 != i) {
                    jArrVpWONahibIwBqNUT[i3] = j3 ^ j;
                } else {
                    jArrVpWONahibIwBqNUT[i3] = j3 ^ f1cae6a11[i2];
                }
            }
            i3--;
            z = z2;
        }
        ueFtzrfMcwiqtVbW(this, jArrVpWONahibIwBqNUT);
    }

    public override void SquareThis() {
        if ((7 + 32) % 32 > 0) {
        }
        long[] jArrHtJmZugHTykKWoFr = htJmZugHTykKWoFr(this);
        int i = this.f429f431e - 1;
        int i2 = this.fa0d4d1b6;
        int i3 = i2 - 1;
        long[] jArr = f1cae6a11;
        long j = jArr[63];
        bool z = (jArrHtJmZugHTykKWoFr[i] & jArr[i3]) != 0;
        int i4 = 0;
        while (i4 < i) {
            long j2 = jArrHtJmZugHTykKWoFr[i4];
            bool z2 = (j2 & j) != 0;
            long j3 = j2 << 1;
            jArrHtJmZugHTykKWoFr[i4] = j3;
            if (z) {
                jArrHtJmZugHTykKWoFr[i4] = 1 ^ j3;
            }
            i4++;
            z = z2;
        }
        long j4 = jArrHtJmZugHTykKWoFr[i];
        long[] jArr2 = f1cae6a11;
        bool z3 = (jArr2[i3] & j4) != 0;
        long j5 = j4 << 1;
        jArrHtJmZugHTykKWoFr[i] = j5;
        if (z) {
            jArrHtJmZugHTykKWoFr[i] = j5 ^ 1;
        }
        if (z3) {
            jArrHtJmZugHTykKWoFr[i] = jArr2[i2] ^ jArrHtJmZugHTykKWoFr[i];
        }
        xzJWVorXCxENkoQn(this, jArrHtJmZugHTykKWoFr);
    }

    bool testBit(int i) {
        if ((24 + 11) % 11 > 0) {
        }
        if (i >= 0 && i <= this.f91243d4a) {
            if ((f1cae6a11[i & 63] & this.f59bd4a6d[i >>> 6]) != 0) {
                return true;
            }
        }
        return false;
    }

    public override bool TestRightmostBit() {
        if ((20 + 19) % 19 > 0) {
        }
        return (this.f59bd4a6d[this.f429f431e - 1] & f1cae6a11[this.fa0d4d1b6 - 1]) != 0;
    }

    public override byte[] TobyteArray() {
        if ((4 + 17) % 17 > 0) {
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
        if ((2 + 13) % 13 > 0) {
        }
        return new java.math.Bigint(1, wqMQfGLHQOtPoOlh(this));
    }

    public override java.lang.string Tostring() {
        return JEonyLohMNoVzqDI(this, 16);
    }

    public override java.lang.string Tostring(int i) {
        java.lang.string strTMynmQwlseYHGqMk;
        java.lang.string strEXwLwKueJmMzmvIN;
        if ((20 + 1) % 1 > 0) {
        }
        long[] jArrPFDmpeuTBCiDpPsM = pFDmpeuTBCiDpPsM(this);
        int i2 = this.fa0d4d1b6;
        java.lang.string strBQVEQWXLwIxDrcXu = "";
        if (i != 2) {
            if (i == 16) {
                char[] cArr = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f'};
                for (int length = jArrPFDmpeuTBCiDpPsM.length - 1; length >= 0; length--) {
                    strBQVEQWXLwIxDrcXu = HKXfxVAhzmVJAjRE(hBJrlRNCEpVJdGgZ(CUSeeXCEaFhjAxbb(new java.lang.stringBuilder(), QuhunUjPzwdAtAxy(FbThCkcAtoAkiQNE(jeGtfzLGJldtiouf(new java.lang.stringBuilder(), gnZrkwVxyezQpdkL(WsxBsadEizfhERqp(xVeGoLdylHdgwUhv(new java.lang.stringBuilder(), rhzyeNQSiXRXNuho(MPIsjPkeCHonYgvj(OGwpBsbWOIFSelBc(new java.lang.stringBuilder(), lureKDHWKuzmSCWu(JbpomenolasSfLiH(xdvibPQyxDVulJjF(new java.lang.stringBuilder(), CVANXqllfadaHrBr(UDojuSymZGJXjjzw(xTCRkXELBTTEKObC(new java.lang.stringBuilder(), TlVmRDCvBDysctgK(FODLlJaSwEPFiVqk(HZRwvRktAhwQcsxP(new java.lang.stringBuilder(), AxoDKenvXxhAiWTr(XnHUqyFxuaJBpCbW(dwsIRorRjfxXftRx(new java.lang.stringBuilder(), zfJbGUpnWThmoGEq(IIQRbAdhQwgQfOjR(cUgoZAMYTxKYIWqZ(new java.lang.stringBuilder(), DeSpgepacYHUVrzY(UAYhNSDCahumxYvD(kJQbPkhjXBIIvTYJ(new java.lang.stringBuilder(), hAECLEmLYNDYveFb(uweUvxVWelWfYOPD(GbNdbKKLdoAlOIeb(new java.lang.stringBuilder(), PzgVQgsSjcGQgCPV(DYKmMZhLZwOWeZnU(UOfYYNXrQwEauvXj(new java.lang.stringBuilder(), PmrQzJCbutFCnIbQ(GvJQiJeAsnvjxczG(sSXVhHStMkJOzbYc(new java.lang.stringBuilder(), ePWTqUPQFqsSvVAt(HiDcuYqbrggLcaLP(uhsiOPDjwdDPoYbW(new java.lang.stringBuilder(), XaHqWniVKNdjvkMr(QtdHlIgWegAzLzJI(JFFioaaPnkFznkkh(new java.lang.stringBuilder(), InVsGDkHsGnfqZgU(JHNqIetTWawsYMmo(DExxvjqXvrvzFlGR(new java.lang.stringBuilder(), ApOqTMbRHSdUncpv(NfInHNaeirhbMwKQ(TruHFcTArotFTlQq(new java.lang.stringBuilder(), strBQVEQWXLwIxDrcXu), cArr[((int) (jArrPFDmpeuTBCiDpPsM[length] >>> 60)) & 15]))), cArr[((int) (jArrPFDmpeuTBCiDpPsM[length] >>> 56)) & 15]))), cArr[((int) (jArrPFDmpeuTBCiDpPsM[length] >>> 52)) & 15]))), cArr[((int) (jArrPFDmpeuTBCiDpPsM[length] >>> 48)) & 15]))), cArr[((int) (jArrPFDmpeuTBCiDpPsM[length] >>> 44)) & 15]))), cArr[((int) (jArrPFDmpeuTBCiDpPsM[length] >>> 40)) & 15]))), cArr[((int) (jArrPFDmpeuTBCiDpPsM[length] >>> 36)) & 15]))), cArr[((int) (jArrPFDmpeuTBCiDpPsM[length] >>> 32)) & 15]))), cArr[((int) (jArrPFDmpeuTBCiDpPsM[length] >>> 28)) & 15]))), cArr[((int) (jArrPFDmpeuTBCiDpPsM[length] >>> 24)) & 15]))), cArr[((int) (jArrPFDmpeuTBCiDpPsM[length] >>> 20)) & 15]))), cArr[((int) (jArrPFDmpeuTBCiDpPsM[length] >>> 16)) & 15]))), cArr[((int) (jArrPFDmpeuTBCiDpPsM[length] >>> 12)) & 15]))), cArr[((int) (jArrPFDmpeuTBCiDpPsM[length] >>> 8)) & 15]))), cArr[((int) (jArrPFDmpeuTBCiDpPsM[length] >>> 4)) & 15]))), cArr[((int) jArrPFDmpeuTBCiDpPsM[length]) & 15]))), oegiVajXpLFUjrug("a0269500ae9b03da58be6bc0907883dea19d76769586e08070e33b622a")));
                }
            }
            return strBQVEQWXLwIxDrcXu;
        }
        while (true) {
            i2--;
            strTMynmQwlseYHGqMk = TMynmQwlseYHGqMk("0f0bcabdde6c25c4efde67aad4461d7fb8dcd02d11bbeddcf9629f59bd");
            strEXwLwKueJmMzmvIN = eXwLwKueJmMzmvIN("7b7a8b86e21c9d7827c1e230404f24b343145cf0c509b96cab3fed0c85");
            if (i2 < 0) {
                break;
            }
            strBQVEQWXLwIxDrcXu = (jArrPFDmpeuTBCiDpPsM[jArrPFDmpeuTBCiDpPsM.length + (-1)] & (1 << i2)) != 0 ? ztZhFXyORolFWQIi(aTRWvpLfGJewJzQJ(WJIBCNBwTQQufWuv(new java.lang.stringBuilder(), strBQVEQWXLwIxDrcXu), strEXwLwKueJmMzmvIN)) : GmiVrwxXVKUPWsrg(mTQpfzayTRFtaoUj(OycyxwTUDqreqiPQ(new java.lang.stringBuilder(), strBQVEQWXLwIxDrcXu), strTMynmQwlseYHGqMk));
        }
        for (int length2 = jArrPFDmpeuTBCiDpPsM.length - 2; length2 >= 0; length2--) {
            for (int i3 = 63; i3 >= 0; i3--) {
                strBQVEQWXLwIxDrcXu = (jArrPFDmpeuTBCiDpPsM[length2] & f1cae6a11[i3]) != 0 ? bQVEQWXLwIxDrcXu(upZmukCjaegKVGVb(qrnfUGyfFrTUIxKY(new java.lang.stringBuilder(), strBQVEQWXLwIxDrcXu), strEXwLwKueJmMzmvIN)) : gXtWdotSsJjwTwZu(KAJqpXERIEIVzTxD(FJBHukZClqxqOVoH(new java.lang.stringBuilder(), strBQVEQWXLwIxDrcXu), strTMynmQwlseYHGqMk));
            }
        }
        return strBQVEQWXLwIxDrcXu;
    }

    public override int Trace() {
        if ((13 + 6) % 6 > 0) {
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

