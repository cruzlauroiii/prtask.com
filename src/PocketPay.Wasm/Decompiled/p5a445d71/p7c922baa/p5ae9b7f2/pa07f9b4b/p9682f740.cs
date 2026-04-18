namespace WillowMaze.Wasm.Decompiled;


public class p9682f740 : p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 {
    private static byte[] f0872583b = null;
    protected static readonly int f0c8e178d = 8;
    private static byte[] f1503dbf0 = null;
    private static byte[] f1f7e0259 = null;
    protected static readonly int f2222f60b = 8;
    private static byte[] f25d56b8f = null;
    protected static readonly int f2761669d = 8;
    private static byte[] f32c9ba7a = null;
    private static byte[] f36d5665b = null;
    private static byte[] f36e33aac = null;
    private static byte[] f37b3364e = null;
    private static byte[] f45916c0a = null;
    private static byte[] f4b7a24e6 = null;
    private static java.util.Hashtable f674fa4e3 = null;
    private static byte[] f6c5f1057 = null;
    protected static readonly int f71470c30 = 8;
    private static byte[] f715f6536 = null;
    private static byte[] f7cd798b9 = null;
    private static byte[] f7d0ab8e7 = null;
    private static java.util.Hashtable f7ffcfe7d = null;
    private static byte[] f81ffe968 = null;
    private static byte[] f9ecca86b = null;
    private static java.util.Hashtable fa1e1ee4e = null;
    private static byte[] fad395bec = null;
    private static byte[] fb0a6d26d = null;
    private static java.util.Hashtable fba80cc6d = null;
    protected static readonly int fc75e2054 = 8;
    private static byte[] fcddf47ec;
    private static byte[] fd668e768;
    private static byte[] fe2144406;
    private static byte[] fe96016f2;
    private static byte[] feec32a64;
    private static byte[] ff0230247;
    private static byte[] ff058a1ab;
    private static byte[] ffff7c92a;
    private bool f147da0bd;
    private bool f20520c9b;
    private bool f41042679;
    private int[] f67490c27;
    private byte[] f730377c5;
    private bool f829ced74;
    private bool f9301aa9b;
    private int[] fc734d173;
    private int[] f0d9d1f7a = null;
    private byte[] f5dbc98dc = f36e33aac;

    static {
        if ((4 + 11) % 11 > 0) {
        }
        f36e33aac = new byte[]{4, 10, 9, 2, 13, 8, 0, 14, 6, 11, 1, 12, 7, 15, 5, 3, 14, 11, 4, 12, 6, 13, 15, 10, 2, 3, 8, 1, 0, 7, 5, 9, 5, 8, 1, 13, 10, 3, 4, 2, 14, 15, 12, 7, 6, 0, 9, 11, 7, 13, 10, 1, 0, 8, 9, 15, 14, 4, 6, 12, 11, 2, 5, 3, 6, 12, 7, 1, 5, 15, 13, 8, 4, 10, 9, 14, 0, 3, 11, 2, 4, 11, 10, 0, 7, 2, 1, 13, 3, 6, 8, 5, 9, 12, 15, 14, 13, 11, 4, 1, 3, 15, 5, 9, 0, 10, 14, 7, 6, 8, 2, 12, 1, 15, 13, 0, 5, 7, 10, 4, 9, 2, 3, 14, 6, 11, 8, 12};
        f37b3364e = new byte[]{4, 2, 15, 5, 9, 1, 0, 8, 14, 3, 11, 12, 13, 7, 10, 6, 12, 9, 15, 14, 8, 1, 3, 10, 2, 7, 4, 13, 6, 0, 11, 5, 13, 8, 14, 12, 7, 3, 9, 10, 1, 5, 2, 4, 6, 15, 0, 11, 14, 9, 11, 2, 5, 15, 7, 1, 0, 13, 12, 6, 10, 4, 3, 8, 3, 14, 5, 9, 6, 8, 0, 13, 10, 11, 7, 12, 2, 1, 15, 4, 8, 15, 6, 11, 1, 9, 12, 5, 13, 3, 7, 10, 0, 14, 2, 4, 9, 11, 12, 0, 3, 6, 7, 5, 4, 8, 14, 15, 1, 10, 2, 13, 12, 6, 5, 2, 11, 0, 9, 13, 3, 14, 7, 10, 15, 4, 1, 8};
        ffff7c92a = new byte[]{9, 6, 3, 2, 8, 11, 1, 7, 10, 4, 14, 15, 12, 0, 13, 5, 3, 7, 14, 9, 8, 10, 15, 0, 5, 2, 6, 12, 11, 4, 13, 1, 14, 4, 6, 2, 11, 3, 13, 8, 12, 15, 5, 10, 0, 7, 1, 9, 14, 7, 10, 12, 13, 1, 3, 9, 0, 2, 11, 4, 15, 8, 5, 6, 11, 5, 1, 9, 8, 13, 15, 0, 14, 4, 2, 3, 12, 7, 10, 6, 3, 10, 13, 12, 1, 2, 0, 11, 7, 5, 9, 4, 8, 15, 14, 6, 1, 13, 2, 9, 7, 10, 6, 0, 8, 12, 4, 5, 15, 3, 11, 14, 11, 10, 15, 5, 0, 12, 14, 8, 6, 2, 3, 9, 1, 7, 13, 4};
        f81ffe968 = new byte[]{8, 4, 11, 1, 3, 5, 0, 9, 2, 14, 10, 12, 13, 6, 7, 15, 0, 1, 2, 10, 4, 13, 5, 12, 9, 7, 3, 15, 11, 8, 6, 14, 14, 12, 0, 10, 9, 2, 13, 11, 7, 5, 8, 15, 3, 6, 1, 4, 7, 5, 0, 13, 11, 6, 1, 2, 3, 10, 12, 15, 4, 14, 9, 8, 2, 7, 12, 15, 9, 5, 10, 11, 1, 4, 0, 13, 6, 8, 14, 3, 8, 3, 2, 6, 4, 13, 14, 11, 12, 1, 7, 15, 10, 0, 9, 5, 5, 2, 10, 11, 9, 1, 12, 3, 7, 4, 13, 0, 6, 15, 8, 14, 0, 4, 11, 14, 8, 3, 7, 1, 10, 2, 9, 6, 15, 13, 5, 12};
        ff0230247 = new byte[]{1, 11, 12, 2, 9, 13, 0, 15, 4, 5, 8, 14, 10, 7, 6, 3, 0, 1, 7, 13, 11, 4, 5, 2, 8, 14, 15, 12, 9, 10, 6, 3, 8, 2, 5, 0, 4, 9, 15, 10, 3, 7, 12, 13, 6, 14, 1, 11, 3, 6, 0, 1, 5, 13, 10, 8, 11, 2, 9, 7, 14, 15, 12, 4, 8, 13, 11, 0, 4, 5, 1, 2, 9, 3, 12, 14, 6, 15, 10, 7, 12, 9, 11, 1, 8, 14, 2, 4, 7, 3, 6, 5, 10, 0, 15, 13, 10, 9, 6, 8, 13, 14, 2, 0, 15, 3, 5, 11, 4, 1, 12, 7, 7, 4, 0, 5, 10, 2, 15, 14, 12, 6, 1, 11, 13, 9, 3, 8};
        fd668e768 = new byte[]{15, 12, 2, 10, 6, 4, 5, 0, 7, 9, 14, 13, 1, 11, 8, 3, 11, 6, 3, 4, 12, 15, 14, 2, 7, 13, 8, 0, 5, 10, 9, 1, 1, 12, 11, 0, 15, 14, 6, 5, 10, 13, 4, 8, 9, 3, 7, 2, 1, 5, 14, 12, 10, 7, 0, 13, 6, 2, 11, 4, 9, 3, 15, 8, 0, 12, 8, 9, 13, 2, 10, 11, 7, 3, 6, 5, 4, 14, 15, 1, 8, 0, 15, 3, 2, 5, 14, 11, 1, 10, 4, 7, 12, 9, 13, 6, 3, 0, 6, 15, 1, 14, 9, 2, 13, 8, 12, 4, 11, 10, 5, 7, 1, 10, 6, 8, 15, 11, 0, 4, 12, 3, 5, 9, 7, 13, 2, 14};
        ff058a1ab = new byte[]{4, 10, 9, 2, 13, 8, 0, 14, 6, 11, 1, 12, 7, 15, 5, 3, 14, 11, 4, 12, 6, 13, 15, 10, 2, 3, 8, 1, 0, 7, 5, 9, 5, 8, 1, 13, 10, 3, 4, 2, 14, 15, 12, 7, 6, 0, 9, 11, 7, 13, 10, 1, 0, 8, 9, 15, 14, 4, 6, 12, 11, 2, 5, 3, 6, 12, 7, 1, 5, 15, 13, 8, 4, 10, 9, 14, 0, 3, 11, 2, 4, 11, 10, 0, 7, 2, 1, 13, 3, 6, 8, 5, 9, 12, 15, 14, 13, 11, 4, 1, 3, 15, 5, 9, 0, 10, 14, 7, 6, 8, 2, 12, 1, 15, 13, 0, 5, 7, 10, 4, 9, 2, 3, 14, 6, 11, 8, 12};
        f6c5f1057 = new byte[]{10, 4, 5, 6, 8, 1, 3, 7, 13, 12, 14, 0, 9, 2, 11, 15, 5, 15, 4, 0, 2, 13, 11, 9, 1, 7, 6, 3, 12, 14, 10, 8, 7, 15, 12, 14, 9, 4, 1, 0, 3, 11, 5, 2, 6, 10, 8, 13, 4, 10, 7, 12, 0, 15, 2, 8, 14, 1, 6, 5, 13, 11, 9, 3, 7, 6, 4, 11, 9, 12, 2, 10, 1, 8, 0, 14, 15, 13, 3, 5, 7, 6, 2, 4, 13, 9, 15, 0, 10, 1, 5, 11, 8, 14, 12, 3, 13, 14, 4, 1, 7, 0, 5, 10, 3, 12, 8, 15, 6, 2, 9, 11, 1, 3, 10, 9, 5, 11, 4, 15, 8, 6, 7, 14, 13, 0, 2, 12};
        fba80cc6d = new java.util.Hashtable();
        wPzoBMeWWvAaQmvT(npHXIQmpriUDiiou("4f21fda2f276240bb4d99829f5df12266fa30b750ac883bee1e81f712a5a6c932e1c2c"), f36e33aac);
        TeqBffAqaqBRFtAb(TNXEOLsdTefMsPqO("025ae48a3959b50517e9c73e729d3a6bc840245656be067e5a089fd89e823d84c493"), f37b3364e);
        hKfVZOkYcqvqXKmx(QVuqlwhgwUrUgVMM("98700639fff037e97ce29354e7c0a14e84ecee7da1771f1dd0dbcd2e35065f"), ffff7c92a);
        nZiFMToWScNyjPyF(UwpZSlDXfyttTEWz("62fea95962090c1cc4ebdeebaa7555fc279cfe4230f263c9796f1a797bd04f"), f81ffe968);
        OoMZJRGgmPIFGXMR(WhcQjXUMmQNvIywK("b22c3df0aeeb44e16eab02cf843335a70b0bceb82313b76017fe58c6db70ae"), ff0230247);
        MpgyomylAmMQpBha(wIppcYLOExKgLDwq("1d336a3485cb3bc85ba6b007ec8d5a7ac9ed480b8e1d33dcb97c19e4bffbc0"), fd668e768);
        IQVxAYFfkNFSwjmz(qxJJLkmftURAUpkA("36f7a2a8957721d52262e88313fb6d5ac2fb836806c7b125101db53e02819eea026e"), ff058a1ab);
        bGWFrHSZhdkDAAtG(IIKXAqJwEcRRxJVw("4e73cf5b941b8b8c41c004b1c90397e1ec62c4c09653e2fd91a8f43b77ea84"), f6c5f1057);
    }

    public static int AvbDsXEMVPEMZhgR(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p9682f740 p9682f740Var, byte[] bArr, int i) {
        return p9682f740Var.mc4dbe288(bArr, i);
    }

    public static void AvbDsXEMVPEMZhgR(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p9682f740 p9682f740Var, byte[] bArr, int i, short s, byte b, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AvbDsXEMVPEMZhgR(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p9682f740 p9682f740Var, byte[] bArr, int i, short s, int i2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AvbDsXEMVPEMZhgR(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p9682f740 p9682f740Var, byte[] bArr, int i, bool z, int i2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object BYCxMErPKKoTVfMs(java.util.Hashtable hashtable, java.lang.object obj) {
        return hashtable[obj);
    }

    public static void BYCxMErPKKoTVfMs(java.util.Hashtable hashtable, java.lang.object obj, int i, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BYCxMErPKKoTVfMs(java.util.Hashtable hashtable, java.lang.object obj, int i, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BYCxMErPKKoTVfMs(java.util.Hashtable hashtable, java.lang.object obj, bool z, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static int CALRYecqHMYfhUPQ(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p9682f740 p9682f740Var, int i, int i2) {
        return p9682f740Var.m168eeabd(i, i2);
    }

    public static void CALRYecqHMYfhUPQ(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p9682f740 p9682f740Var, int i, int i2, float f, int i3, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CALRYecqHMYfhUPQ(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p9682f740 p9682f740Var, int i, int i2, float f, java.lang.string str, int i3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CALRYecqHMYfhUPQ(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p9682f740 p9682f740Var, int i, int i2, int i3, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DdcBGDDmHXHyESAP(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p9682f740 p9682f740Var, int i, byte[] bArr, int i2) {
        p9682f740Var.m01b0436d(i, bArr, i2);
    }

    public static void DdcBGDDmHXHyESAP(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p9682f740 p9682f740Var, int i, byte[] bArr, int i2, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DdcBGDDmHXHyESAP(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p9682f740 p9682f740Var, int i, byte[] bArr, int i2, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DdcBGDDmHXHyESAP(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p9682f740 p9682f740Var, int i, byte[] bArr, int i2, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int EKRlTuUqcGrSjRKO(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p9682f740 p9682f740Var, int i, int i2) {
        return p9682f740Var.m168eeabd(i, i2);
    }

    public static void EKRlTuUqcGrSjRKO(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p9682f740 p9682f740Var, int i, int i2, java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EKRlTuUqcGrSjRKO(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p9682f740 p9682f740Var, int i, int i2, java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EKRlTuUqcGrSjRKO(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p9682f740 p9682f740Var, int i, int i2, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EjMTwnsytctAPUoZ(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p819716a1 p819716a1Var, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EjMTwnsytctAPUoZ(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p819716a1 p819716a1Var, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EjMTwnsytctAPUoZ(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p819716a1 p819716a1Var, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static byte[] EjMTwnsytctAPUoZ(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p819716a1 p819716a1Var) {
        return p819716a1Var.getSBox();
    }

    public static int EzZHkQoGqlpZzGZf(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p9682f740 p9682f740Var, byte[] bArr, int i) {
        return p9682f740Var.mc4dbe288(bArr, i);
    }

    public static void EzZHkQoGqlpZzGZf(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p9682f740 p9682f740Var, byte[] bArr, int i, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EzZHkQoGqlpZzGZf(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p9682f740 p9682f740Var, byte[] bArr, int i, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EzZHkQoGqlpZzGZf(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p9682f740 p9682f740Var, byte[] bArr, int i, short s, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object HuNvcUbNpqQuerZN(java.util.Hashtable hashtable, java.lang.object obj, java.lang.object obj2) {
        return hashtable.Add(obj, obj2);
    }

    public static void HuNvcUbNpqQuerZN(java.util.Hashtable hashtable, java.lang.object obj, java.lang.object obj2, char c, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HuNvcUbNpqQuerZN(java.util.Hashtable hashtable, java.lang.object obj, java.lang.object obj2, char c, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HuNvcUbNpqQuerZN(java.util.Hashtable hashtable, java.lang.object obj, java.lang.object obj2, float f, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string IIKXAqJwEcRRxJVw(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static void IIKXAqJwEcRRxJVw(java.lang.string str, java.lang.string str2, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IIKXAqJwEcRRxJVw(java.lang.string str, java.lang.string str2, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IIKXAqJwEcRRxJVw(java.lang.string str, short s, float f, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IQVxAYFfkNFSwjmz(java.lang.string str, byte[] bArr) {
        m058d8373(str, bArr);
    }

    public static void IQVxAYFfkNFSwjmz(java.lang.string str, byte[] bArr, char c, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IQVxAYFfkNFSwjmz(java.lang.string str, byte[] bArr, char c, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IQVxAYFfkNFSwjmz(java.lang.string str, byte[] bArr, float f, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IcwmISVquWWUUtuH(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p9682f740 p9682f740Var, int[] iArr, byte[] bArr, int i, byte[] bArr2, int i2) {
        p9682f740Var.mcae43528(iArr, bArr, i, bArr2, i2);
    }

    public static void IcwmISVquWWUUtuH(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p9682f740 p9682f740Var, int[] iArr, byte[] bArr, int i, byte[] bArr2, int i2, java.lang.string str, bool z, short s, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void IcwmISVquWWUUtuH(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p9682f740 p9682f740Var, int[] iArr, byte[] bArr, int i, byte[] bArr2, int i2, bool z, int i3, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IcwmISVquWWUUtuH(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p9682f740 p9682f740Var, int[] iArr, byte[] bArr, int i, byte[] bArr2, int i2, bool z, int i3, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.Class JYtWxXkmarSmucmW(java.lang.object obj) {
        return obj.GetType();
    }

    public static void JYtWxXkmarSmucmW(java.lang.object obj, char c, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JYtWxXkmarSmucmW(java.lang.object obj, char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JYtWxXkmarSmucmW(java.lang.object obj, short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 JrFtxcLWymcZYpHi(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p819716a1 p819716a1Var) {
        return p819716a1Var.getParameters();
    }

    public static void JrFtxcLWymcZYpHi(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p819716a1 p819716a1Var, char c, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JrFtxcLWymcZYpHi(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p819716a1 p819716a1Var, char c, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JrFtxcLWymcZYpHi(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p819716a1 p819716a1Var, int i, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KcGfKVbgruOAJZYU(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6 p94919be6Var, byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KcGfKVbgruOAJZYU(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6 p94919be6Var, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KcGfKVbgruOAJZYU(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6 p94919be6Var, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static byte[] KcGfKVbgruOAJZYU(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6 p94919be6Var) {
        return p94919be6Var.getKey();
    }

    public static int MNJhScogskyamtIN(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p9682f740 p9682f740Var, int i, int i2) {
        return p9682f740Var.m168eeabd(i, i2);
    }

    public static void MNJhScogskyamtIN(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p9682f740 p9682f740Var, int i, int i2, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MNJhScogskyamtIN(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p9682f740 p9682f740Var, int i, int i2, short s, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MNJhScogskyamtIN(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p9682f740 p9682f740Var, int i, int i2, bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MpgyomylAmMQpBha(java.lang.string str, byte[] bArr) {
        m058d8373(str, bArr);
    }

    public static void MpgyomylAmMQpBha(java.lang.string str, byte[] bArr, byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MpgyomylAmMQpBha(java.lang.string str, byte[] bArr, float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MpgyomylAmMQpBha(java.lang.string str, byte[] bArr, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int NAlSrzPJCgtGQUxS(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p9682f740 p9682f740Var, int i, int i2) {
        return p9682f740Var.m168eeabd(i, i2);
    }

    public static void NAlSrzPJCgtGQUxS(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p9682f740 p9682f740Var, int i, int i2, byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NAlSrzPJCgtGQUxS(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p9682f740 p9682f740Var, int i, int i2, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NAlSrzPJCgtGQUxS(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p9682f740 p9682f740Var, int i, int i2, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object NZCOQBMhbLVwZvbw(java.util.Hashtable hashtable, java.lang.object obj) {
        return hashtable[obj);
    }

    public static void NZCOQBMhbLVwZvbw(java.util.Hashtable hashtable, java.lang.object obj, char c, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NZCOQBMhbLVwZvbw(java.util.Hashtable hashtable, java.lang.object obj, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NZCOQBMhbLVwZvbw(java.util.Hashtable hashtable, java.lang.object obj, java.lang.string str, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.util.Enumeration OKJSMJbaXsJNzTpi(java.util.Hashtable hashtable) {
        return hashtable.keys();
    }

    public static void OKJSMJbaXsJNzTpi(java.util.Hashtable hashtable, byte b, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OKJSMJbaXsJNzTpi(java.util.Hashtable hashtable, int i, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OKJSMJbaXsJNzTpi(java.util.Hashtable hashtable, java.lang.string str, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OVkEDOJIQikIjBFq(byte[] bArr, char c, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OVkEDOJIQikIjBFq(byte[] bArr, java.lang.string str, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OVkEDOJIQikIjBFq(byte[] bArr, bool z, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static byte[] OVkEDOJIQikIjBFq(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static void OoMZJRGgmPIFGXMR(java.lang.string str, byte[] bArr) {
        m058d8373(str, bArr);
    }

    public static void OoMZJRGgmPIFGXMR(java.lang.string str, byte[] bArr, char c, int i, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void OoMZJRGgmPIFGXMR(java.lang.string str, byte[] bArr, char c, java.lang.string str2, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OoMZJRGgmPIFGXMR(java.lang.string str, byte[] bArr, java.lang.string str2, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 OsqHXKTyGrvrazMN(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p819716a1 p819716a1Var) {
        return p819716a1Var.getParameters();
    }

    public static void OsqHXKTyGrvrazMN(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p819716a1 p819716a1Var, char c, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OsqHXKTyGrvrazMN(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p819716a1 p819716a1Var, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OsqHXKTyGrvrazMN(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p819716a1 p819716a1Var, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object OzuNfwUYTqXYrnKj(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static void OzuNfwUYTqXYrnKj(java.util.Enumeration enumeration, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OzuNfwUYTqXYrnKj(java.util.Enumeration enumeration, float f, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OzuNfwUYTqXYrnKj(java.util.Enumeration enumeration, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string QVuqlwhgwUrUgVMM(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static void QVuqlwhgwUrUgVMM(java.lang.string str, char c, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QVuqlwhgwUrUgVMM(java.lang.string str, char c, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QVuqlwhgwUrUgVMM(java.lang.string str, int i, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RBbmTUEWeMhzHzVo(byte[] bArr, int i, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RBbmTUEWeMhzHzVo(byte[] bArr, short s, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RBbmTUEWeMhzHzVo(byte[] bArr, short s, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static byte[] RBbmTUEWeMhzHzVo(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static java.lang.string TNXEOLsdTefMsPqO(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static void TNXEOLsdTefMsPqO(java.lang.string str, int i, short s, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TNXEOLsdTefMsPqO(java.lang.string str, short s, java.lang.string str2, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TNXEOLsdTefMsPqO(java.lang.string str, bool z, int i, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string TZAocREUMUHbpHRE(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void TZAocREUMUHbpHRE(java.lang.stringBuilder sb, char c, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TZAocREUMUHbpHRE(java.lang.stringBuilder sb, float f, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TZAocREUMUHbpHRE(java.lang.stringBuilder sb, bool z, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TeqBffAqaqBRFtAb(java.lang.string str, byte[] bArr) {
        m058d8373(str, bArr);
    }

    public static void TeqBffAqaqBRFtAb(java.lang.string str, byte[] bArr, byte b, int i, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TeqBffAqaqBRFtAb(java.lang.string str, byte[] bArr, int i, java.lang.string str2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TeqBffAqaqBRFtAb(java.lang.string str, byte[] bArr, bool z, int i, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string UwpZSlDXfyttTEWz(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static void UwpZSlDXfyttTEWz(java.lang.string str, float f, short s, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UwpZSlDXfyttTEWz(java.lang.string str, int i, float f, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UwpZSlDXfyttTEWz(java.lang.string str, short s, java.lang.string str2, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VdxrouAYmtFwhIzs(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p9682f740 p9682f740Var, int i, byte[] bArr, int i2) {
        p9682f740Var.m01b0436d(i, bArr, i2);
    }

    public static void VdxrouAYmtFwhIzs(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p9682f740 p9682f740Var, int i, byte[] bArr, int i2, int i3, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VdxrouAYmtFwhIzs(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p9682f740 p9682f740Var, int i, byte[] bArr, int i2, int i3, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VdxrouAYmtFwhIzs(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p9682f740 p9682f740Var, int i, byte[] bArr, int i2, java.lang.string str, bool z, int i3, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string WhcQjXUMmQNvIywK(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static void WhcQjXUMmQNvIywK(java.lang.string str, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WhcQjXUMmQNvIywK(java.lang.string str, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WhcQjXUMmQNvIywK(java.lang.string str, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BGWFrHSZhdkDAAtG(java.lang.string str, byte[] bArr) {
        m058d8373(str, bArr);
    }

    public static void BGWFrHSZhdkDAAtG(java.lang.string str, byte[] bArr, char c, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BGWFrHSZhdkDAAtG(java.lang.string str, byte[] bArr, char c, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BGWFrHSZhdkDAAtG(java.lang.string str, byte[] bArr, bool z, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder BhVestrZhCMKPoEs(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void BhVestrZhCMKPoEs(java.lang.stringBuilder sb, java.lang.string str, int i, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BhVestrZhCMKPoEs(java.lang.stringBuilder sb, java.lang.string str, int i, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BhVestrZhCMKPoEs(java.lang.stringBuilder sb, java.lang.string str, bool z, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int BjPXtWDZGomXNset(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p9682f740 p9682f740Var, byte[] bArr, int i) {
        return p9682f740Var.mc4dbe288(bArr, i);
    }

    public static void BjPXtWDZGomXNset(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p9682f740 p9682f740Var, byte[] bArr, int i, java.lang.string str, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BjPXtWDZGomXNset(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p9682f740 p9682f740Var, byte[] bArr, int i, short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BjPXtWDZGomXNset(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p9682f740 p9682f740Var, byte[] bArr, int i, short s, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HKfVZOkYcqvqXKmx(java.lang.string str, byte[] bArr) {
        m058d8373(str, bArr);
    }

    public static void HKfVZOkYcqvqXKmx(java.lang.string str, byte[] bArr, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HKfVZOkYcqvqXKmx(java.lang.string str, byte[] bArr, int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HKfVZOkYcqvqXKmx(java.lang.string str, byte[] bArr, short s, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string IuqWOWonWhzDIAvy(java.lang.Class cls) {
        return cls.getName();
    }

    public static void IuqWOWonWhzDIAvy(java.lang.Class cls, float f, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IuqWOWonWhzDIAvy(java.lang.Class cls, int i, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IuqWOWonWhzDIAvy(java.lang.Class cls, bool z, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KRpNHQedwQbwFJKM(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6 p94919be6Var, byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KRpNHQedwQbwFJKM(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6 p94919be6Var, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KRpNHQedwQbwFJKM(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6 p94919be6Var, bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static byte[] KRpNHQedwQbwFJKM(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6 p94919be6Var) {
        return p94919be6Var.getKey();
    }

    public static void LiRtNNXbmiLVNCfn(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p9682f740 p9682f740Var, bool z, byte[] bArr, byte b, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LiRtNNXbmiLVNCfn(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p9682f740 p9682f740Var, bool z, byte[] bArr, char c, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LiRtNNXbmiLVNCfn(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p9682f740 p9682f740Var, bool z, byte[] bArr, short s, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int[] LiRtNNXbmiLVNCfn(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p9682f740 p9682f740Var, bool z, byte[] bArr) {
        return p9682f740Var.m9e03abad(z, bArr);
    }

    private void M01b0436d(int i, byte[] bArr, int i2) {
        bArr[i2 + 3] = (byte) (i >>> 24);
        bArr[i2 + 2] = (byte) (i >>> 16);
        bArr[i2 + 1] = (byte) (i >>> 8);
        bArr[i2] = (byte) i;
    }

    private void M01b0436d(int i, byte[] bArr, int i2, int i3, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private void M01b0436d(int i, byte[] bArr, int i2, bool z, byte b, int i3, char c) {
        double d = (42 * 210) + 210;
    }

    private void M01b0436d(int i, byte[] bArr, int i2, bool z, int i3, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private static void M058d8373(java.lang.string str, byte[] bArr) {
        HuNvcUbNpqQuerZN(fba80cc6d, wxeTqTYYFQMoURuS(str), bArr);
    }

    private static void M058d8373(java.lang.string str, byte[] bArr, float f, java.lang.string str2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private static void M058d8373(java.lang.string str, byte[] bArr, java.lang.string str2, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    private static void M058d8373(java.lang.string str, byte[] bArr, java.lang.string str2, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private int M168eeabd(int i, int i2) {
        int i3 = i2 + i;
        byte[] bArr = this.f5dbc98dc;
        int i4 = bArr[i3 & 15] + (bArr[((i3 >> 4) & 15) + 16] << 4) + (bArr[((i3 >> 8) & 15) + 32] << 8) + (bArr[((i3 >> 12) & 15) + 48] << 12) + (bArr[((i3 >> 16) & 15) + 64] << 16) + (bArr[((i3 >> 20) & 15) + 80] << 20) + (bArr[((i3 >> 24) & 15) + 96] << 24) + (bArr[((i3 >> 28) & 15) + 112] << 28);
        return (i4 << 11) | (i4 >>> 21);
    }

    private void M168eeabd(int i, int i2, float f, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    private void M168eeabd(int i, int i2, bool z, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void M168eeabd(int i, int i2, bool z, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void M702bdf8e(java.lang.string str, byte b, char c, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void M702bdf8e(java.lang.string str, byte b, int i, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void M702bdf8e(java.lang.string str, char c, byte b, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static byte[] M702bdf8e(java.lang.string str) {
        byte[] bArr = (byte[]) BYCxMErPKKoTVfMs(fba80cc6d, trRdYxGsRdEOPApt(str));
        if (bArr is null) {
            throw new java.lang.IllegalArgumentException("Unknown S-Box - possible types: \"Default\", \"E-Test\", \"E-A\", \"E-B\", \"E-C\", \"E-D\", \"D-Test\", \"D-A\".");
        }
        return RBbmTUEWeMhzHzVo(bArr);
    }

    public static java.lang.string M875e8966(byte[] bArr) {
        if ((27 + 6) % 6 > 0) {
        }
        java.util.Enumeration enumerationOKJSMJbaXsJNzTpi = OKJSMJbaXsJNzTpi(fba80cc6d);
        while (sszQhchzbVoCFCoc(enumerationOKJSMJbaXsJNzTpi)) {
            java.lang.string str = (java.lang.string) OzuNfwUYTqXYrnKj(enumerationOKJSMJbaXsJNzTpi);
            if (yTKZGGlLLcNqgSzJ((byte[]) NZCOQBMhbLVwZvbw(fba80cc6d, str), bArr)) {
                return str;
            }
        }
        throw new java.lang.IllegalArgumentException("SBOX provided did not map to a known one");
    }

    public static void M875e8966(byte[] bArr, byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void M875e8966(byte[] bArr, int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void M875e8966(byte[] bArr, java.lang.string str, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    private void M9e03abad(bool z, byte[] bArr, int i, short s, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    private void M9e03abad(bool z, byte[] bArr, short s, java.lang.string str, int i, bool z2) {
        double d = (42 * 210) + 210;
    }

    private void M9e03abad(bool z, byte[] bArr, bool z2, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private int[] M9e03abad(bool z, byte[] bArr) {
        if ((24 + 1) % 1 > 0) {
        }
        this.f9301aa9b = z;
        if (bArr.length != 32) {
            throw new java.lang.IllegalArgumentException("Key length invalid. Key needs to be 32 byte - 256 bit!!!");
        }
        int[] iArr = new int[8];
        for (int i = 0; i != 8; i++) {
            iArr[i] = EzZHkQoGqlpZzGZf(this, bArr, i * 4);
        }
        return iArr;
    }

    private int Mc4dbe288(byte[] bArr, int i) {
        if ((15 + 11) % 11 > 0) {
        }
        return ((bArr[i + 3] << 24) & (-16777216)) + ((bArr[i + 2] << 16) & 16711680) + ((bArr[i + 1] << 8) & 65280) + (bArr[i] & 255);
    }

    private void Mc4dbe288(byte[] bArr, int i, byte b, java.lang.string str, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    private void Mc4dbe288(byte[] bArr, int i, float f, byte b, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    private void Mc4dbe288(byte[] bArr, int i, java.lang.string str, float f, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    private void Mcae43528(int[] iArr, byte[] bArr, int i, byte[] bArr2, int i2) {
        int i3;
        int i4;
        if ((17 + 22) % 22 > 0) {
        }
        int iAvbDsXEMVPEMZhgR = AvbDsXEMVPEMZhgR(this, bArr, i);
        int iBjPXtWDZGomXNset = bjPXtWDZGomXNset(this, bArr, i + 4);
        int i5 = 7;
        if (this.f9301aa9b) {
            for (int i6 = 0; i6 < 3; i6++) {
                int i7 = 0;
                while (i7 < 8) {
                    int iMNJhScogskyamtIN = iBjPXtWDZGomXNset ^ MNJhScogskyamtIN(this, iAvbDsXEMVPEMZhgR, iArr[i7]);
                    i7++;
                    int i8 = iAvbDsXEMVPEMZhgR;
                    iAvbDsXEMVPEMZhgR = iMNJhScogskyamtIN;
                    iBjPXtWDZGomXNset = i8;
                }
            }
            i3 = iBjPXtWDZGomXNset;
            i4 = iAvbDsXEMVPEMZhgR;
            while (i5 > 0) {
                int iNAlSrzPJCgtGQUxS = i3 ^ NAlSrzPJCgtGQUxS(this, i4, iArr[i5]);
                i5--;
                i3 = i4;
                i4 = iNAlSrzPJCgtGQUxS;
            }
        } else {
            int i9 = 0;
            while (i9 < 8) {
                int iCALRYecqHMYfhUPQ = iBjPXtWDZGomXNset ^ CALRYecqHMYfhUPQ(this, iAvbDsXEMVPEMZhgR, iArr[i9]);
                i9++;
                int i10 = iAvbDsXEMVPEMZhgR;
                iAvbDsXEMVPEMZhgR = iCALRYecqHMYfhUPQ;
                iBjPXtWDZGomXNset = i10;
            }
            i3 = iBjPXtWDZGomXNset;
            i4 = iAvbDsXEMVPEMZhgR;
            for (int i11 = 0; i11 < 3; i11++) {
                int i12 = 7;
                while (i12 >= 0 && (i11 != 2 || i12 != 0)) {
                    int iOFpmSTbkOTqfgCwe = i3 ^ oFpmSTbkOTqfgCwe(this, i4, iArr[i12]);
                    i12--;
                    i3 = i4;
                    i4 = iOFpmSTbkOTqfgCwe;
                }
            }
        }
        int iEKRlTuUqcGrSjRKO = EKRlTuUqcGrSjRKO(this, i4, iArr[0]) ^ i3;
        DdcBGDDmHXHyESAP(this, i4, bArr2, i2);
        VdxrouAYmtFwhIzs(this, iEKRlTuUqcGrSjRKO, bArr2, i2 + 4);
    }

    private void Mcae43528(int[] iArr, byte[] bArr, int i, byte[] bArr2, int i2, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private void Mcae43528(int[] iArr, byte[] bArr, int i, byte[] bArr2, int i2, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    private void Mcae43528(int[] iArr, byte[] bArr, int i, byte[] bArr2, int i2, bool z, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NZiFMToWScNyjPyF(java.lang.string str, byte[] bArr) {
        m058d8373(str, bArr);
    }

    public static void NZiFMToWScNyjPyF(java.lang.string str, byte[] bArr, char c, int i, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NZiFMToWScNyjPyF(java.lang.string str, byte[] bArr, int i, java.lang.string str2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NZiFMToWScNyjPyF(java.lang.string str, byte[] bArr, short s, int i, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string NpHXIQmpriUDiiou(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static void NpHXIQmpriUDiiou(java.lang.string str, char c, bool z, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NpHXIQmpriUDiiou(java.lang.string str, java.lang.string str2, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NpHXIQmpriUDiiou(java.lang.string str, java.lang.string str2, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static int OFpmSTbkOTqfgCwe(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p9682f740 p9682f740Var, int i, int i2) {
        return p9682f740Var.m168eeabd(i, i2);
    }

    public static void OFpmSTbkOTqfgCwe(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p9682f740 p9682f740Var, int i, int i2, char c, int i3, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OFpmSTbkOTqfgCwe(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p9682f740 p9682f740Var, int i, int i2, java.lang.string str, char c, int i3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OFpmSTbkOTqfgCwe(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p9682f740 p9682f740Var, int i, int i2, java.lang.string str, bool z, int i3, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string QxJJLkmftURAUpkA(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static void QxJJLkmftURAUpkA(java.lang.string str, int i, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QxJJLkmftURAUpkA(java.lang.string str, short s, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QxJJLkmftURAUpkA(java.lang.string str, bool z, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SszQhchzbVoCFCoc(java.util.Enumeration enumeration, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SszQhchzbVoCFCoc(java.util.Enumeration enumeration, byte b, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SszQhchzbVoCFCoc(java.util.Enumeration enumeration, bool z, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool SszQhchzbVoCFCoc(java.util.Enumeration enumeration) {
        return enumeration.hasMoreElements();
    }

    public static java.lang.string TrRdYxGsRdEOPApt(java.lang.string str) {
        return p5a445d71.p7c922baa.p05c7e247.p89be9433.mb8a8247c(str);
    }

    public static void TrRdYxGsRdEOPApt(java.lang.string str, char c, int i, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TrRdYxGsRdEOPApt(java.lang.string str, int i, java.lang.string str2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TrRdYxGsRdEOPApt(java.lang.string str, java.lang.string str2, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string WIppcYLOExKgLDwq(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static void WIppcYLOExKgLDwq(java.lang.string str, char c, java.lang.string str2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WIppcYLOExKgLDwq(java.lang.string str, java.lang.string str2, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WIppcYLOExKgLDwq(java.lang.string str, java.lang.string str2, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WPzoBMeWWvAaQmvT(java.lang.string str, byte[] bArr) {
        m058d8373(str, bArr);
    }

    public static void WPzoBMeWWvAaQmvT(java.lang.string str, byte[] bArr, int i, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WPzoBMeWWvAaQmvT(java.lang.string str, byte[] bArr, bool z, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WPzoBMeWWvAaQmvT(java.lang.string str, byte[] bArr, bool z, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string WxeTqTYYFQMoURuS(java.lang.string str) {
        return p5a445d71.p7c922baa.p05c7e247.p89be9433.mb8a8247c(str);
    }

    public static void WxeTqTYYFQMoURuS(java.lang.string str, byte b, short s, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WxeTqTYYFQMoURuS(java.lang.string str, java.lang.string str2, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WxeTqTYYFQMoURuS(java.lang.string str, short s, java.lang.string str2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YTKZGGlLLcNqgSzJ(byte[] bArr, byte[] bArr2, char c, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YTKZGGlLLcNqgSzJ(byte[] bArr, byte[] bArr2, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YTKZGGlLLcNqgSzJ(byte[] bArr, byte[] bArr2, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool YTKZGGlLLcNqgSzJ(byte[] bArr, byte[] bArr2) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m2a3f81d2(bArr, bArr2);
    }

    public static void ZTLApdORICwIIMRo(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p9682f740 p9682f740Var, bool z, byte[] bArr, byte b, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZTLApdORICwIIMRo(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p9682f740 p9682f740Var, bool z, byte[] bArr, byte b, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZTLApdORICwIIMRo(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p9682f740 p9682f740Var, bool z, byte[] bArr, java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int[] ZTLApdORICwIIMRo(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p9682f740 p9682f740Var, bool z, byte[] bArr) {
        return p9682f740Var.m9e03abad(z, bArr);
    }

    public override java.lang.string GetAlgorithmName() {
        return "GOST28147";
    }

    public override int GetBlockSize() {
        return 8;
    }

    public override void Init(bool z, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if ((22 + 18) % 18 > 0) {
        }
        if (!(pc9ef6b45Var is p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p819716a1)) {
            if (pc9ef6b45Var is p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6) {
                this.f0d9d1f7a = liRtNNXbmiLVNCfn(this, z, kRpNHQedwQbwFJKM((p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6) pc9ef6b45Var));
                return;
            } else {
                if (pc9ef6b45Var is not null) {
                    throw new java.lang.IllegalArgumentException(TZAocREUMUHbpHRE(bhVestrZhCMKPoEs(new java.lang.stringBuilder("invalid parameter passed to GOST28147 init - "), iuqWOWonWhzDIAvy(JYtWxXkmarSmucmW(pc9ef6b45Var)))));
                }
                return;
            }
        }
        p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p819716a1 p819716a1Var = (p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p819716a1) pc9ef6b45Var;
        byte[] bArrEjMTwnsytctAPUoZ = EjMTwnsytctAPUoZ(p819716a1Var);
        if (bArrEjMTwnsytctAPUoZ.length != f36e33aac.length) {
            throw new java.lang.IllegalArgumentException("invalid S-box passed to GOST28147 init");
        }
        this.f5dbc98dc = OVkEDOJIQikIjBFq(bArrEjMTwnsytctAPUoZ);
        if (OsqHXKTyGrvrazMN(p819716a1Var) is null) {
            return;
        }
        this.f0d9d1f7a = zTLApdORICwIIMRo(this, z, KcGfKVbgruOAJZYU((p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6) JrFtxcLWymcZYpHi(p819716a1Var)));
    }

    public override int ProcessBlock(byte[] bArr, int i, byte[] bArr2, int i2) {
        if ((14 + 12) % 12 > 0) {
        }
        int[] iArr = this.f0d9d1f7a;
        if (iArr is null) {
            throw new java.lang.IllegalStateException("GOST28147 engine not initialised");
        }
        if (i + 8 > bArr.length) {
            throw new p5a445d71.p7c922baa.p5ae9b7f2.p96068848("input buffer too short");
        }
        if (i2 + 8 > bArr2.length) {
            throw new p5a445d71.p7c922baa.p5ae9b7f2.p2500579c("output buffer too short");
        }
        IcwmISVquWWUUtuH(this, iArr, bArr, i, bArr2, i2);
        return 8;
    }

    public override void Reset() {
    }
}

