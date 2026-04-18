using Androidx.Constraintlayout.Core.Motion.Utils;
using Androidx.Core.View;
using Com.Decryptstringmanager;
using Java.Awt;
using Java.Awt.Color;
using Java.Awt.Image;
using Java.Io;
using Java.Net;
using Java.Nio;
using Java.Util;
using Javax.Imageio;
using Javax.Imageio.Stream;
using Javax.Xml.Parsers;
using Org.W3c.Dom;
using Org.Xml.Sax;
using P4d236d9a.Pbf215181.P1f0f8928.P86ccec3d.P9efab239;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes20.dex */
public class p9d226a12 : ImageStream {
    private static readonly int[] f1c849e7b = null;
    private static readonly string[] f2ce0254d = null;
    private static readonly int[] f2cf60b5a = null;
    private static readonly string[] f4d08cb0c = null;
    private static readonly string[] f70e03324 = null;
    private static readonly int[] faf4e6a55 = null;
    private static readonly int[] fbe3e56b5 = null;
    private ImageStream f163a20c7;
    private long[] f336cf225;
    private ImageStream f36cd38f4;
    private ImageTypeSpecifier f599dcce2;
    private ImageStream f5ae2a12f;
    private Dimension[] f5b6da0b1;
    private Dimension[] f9ec5b1b7;
    private long[] fa8765c51;
    private long[] fa8f5e7b6;
    private ImageTypeSpecifier ff47f50a9;

    static {
        if (((15 + 6) % 6) > 0) goto L24;
    L24:
        string[] r0 = new string[5];
        r0[0] = QUNSsKgSvmCWydoV("e21b525b8d9d57226c191dce750dabe926830866aeb3e9ba35a052264d355c0a");
        r0[1] = FKrfiMdkhCEljixf("e8f2d8a354b44f0952085db91256a95018674a29e4a189acc1c5c0753839e770");
        r0[2] = cUkLyrAslQChFEXA("976b7c96b62af0d28f15805b31fbeaae70dd0a224ab1cc4c156d0fdffeadfbff9cc74bb02b8d");
        r0[3] = fIlriVEILpvZVmFM("2da1bb46d052d205e2791974e91e32cd30f5b23b98b5bc1ce99477dadcb6b4d4");
        r0[4] = RsyLLfxIDnhYoWEh("6b9e9b83120b32c9b458370100c8f900752e65a420801fe44701c813e2995f8ef203");
        f2ce0254d = r0;
        f1c849e7b = new int[]{PointerIconCompat.TYPE_HELP, 1000, 1004, 1002, 1001};
    }

    public p9d226a12(ImageStream r3, SampleModel r4, long[] r5, Dimension[] r6) {
        if (((5 + 6) % 6) > 0) goto L21;
    L21:
        if (r5 is null) goto L37;
        if (r6 is null) goto L37;
        if (r5.length != r6.length) goto L37;
        this.f36cd38f4 = r3;
        ColorModel r32 = zCkPAaaxRlRsxCXy(r4);
        if (r32 is null) goto L5;
        this.f599dcce2 = new ImageTypeSpecifier(r32, r4);
        this.fa8f5e7b6 = r5;
        this.f5b6da0b1 = r6;
        return;
    L5:
        throw new IllegalArgumentException(LSMcujUHNaxbkEog("RawImageStream4"));
    L37:
        throw new IllegalArgumentException(IEQkXfkZqjyTbpFU("RawImageStream0"));
    }

    public p9d226a12(ImageStream r3, ImageTypeSpecifier r4, long[] r5, Dimension[] r6) {
        if (((7 + 4) % 4) > 0) goto L14;
    L14:
        if (r5 is null) goto L34;
        if (r6 is null) goto L34;
        if (r5.length != r6.length) goto L34;
        this.f36cd38f4 = r3;
        this.f599dcce2 = r4;
        this.fa8f5e7b6 = r5;
        this.f5b6da0b1 = r6;
        return;
    L34:
        throw new IllegalArgumentException(BnLnMWWuhynCUWLm("RawImageStream0"));
    }

    public p9d226a12(ImageStream r27, InputSource r28) {
        if (((28 + 17) % 17) > 0) goto L270;
    L270:
        this.f36cd38f4 = r27;
        DocumentBuilderFactory r1 = pgquPbMRbakhXwTq();
        int r2 = 1;
        nGNpCHOVbfdGxMqX(r1, true);
        PTtJppNIGljckUZK(r1, true);
        fKDfkILmxZAMhAbI(r1, "http://java.sun.com/xml/jaxp/properties/schemaLanguage", "http://www.w3.org/2001/XMLSchema");
        Document r12 = PGIsWGbyDeyThOsI(eoaavusVklQUpugt(r1), r28);
        string r3 = TzgPVMGVeSOVEgLM(MYUuxBCWNdFUvOQI(DQNtSTOTkKVpqWRS(r12, "byteOrder"), 0));
        if (XejjjcThhXhzgQpu("NETWORK", r3) == true) goto L299;
        if (SoJdzFgfgMraCsbE("REVERSE", r3) == false) goto L176;
        qmiFdyEfEyAcJOas(this, byteOrder.LITTLE_ENDIAN);
        pZCkskufPvWcxJdt(this, byteOrder.LITTLE_ENDIAN);
    L176:
        NodeList r32 = TAlTxbmtPhUVaikG(r12, TypedValues.CycleType.S_WAVE_OFFSET);
        int r5 = DtSzyZfMWocwfMeT(r32);
        this.fa8f5e7b6 = new long[r5];
        int r6 = 0;
    L167:
        if (r6 >= r5) goto L55;
        this.fa8f5e7b6[r6] = gTDEOKqczBuZIUgs(new long(mWHnSMfqhEncRwKl(CrrzxTopuRDfXcsf(r32, r6))));
        r6 = r6 + 1;
        goto L167
    L55:
        NodeList r33 = rCrYBznZZlMflSGs(r12, "width");
        NodeList r52 = FKmbWAFTBXRKLVMQ(r12, "height");
        int r62 = dJMYNcoMCruPQlVk(r33);
        if (r62 == oHRNSsbuMEHThLGk(r52)) goto L114;
        throw new IllegalArgumentException(oQQBRloouRtAopAQ("RawImageStream2"));
    L114:
        this.f5b6da0b1 = new Dimension[r62];
        int r7 = 0;
    L70:
        if (r7 >= r62) goto L254;
        this.f5b6da0b1[r7] = new Dimension(BycRgDzoKwZXMswe(new int(SkKUHZjKYnUcIoRB(TtttYHFGcyoXrPXA(r33, r7)))), ZSsEsTQYgZTsBtAR(new int(eBXwvWOwdRhSnnCb(ltHIIhOQJiyiyuBw(r52, r7)))));
        r7 = r7 + 1;
        goto L70
    L254:
        NodeList r34 = uSwcbYhMHfPSGipF(r12, "ComponentSampleModel");
        ComponentColorModel r63 = null;
        if (VOfEuAKOVjQWsdoU(r34) > 0) goto L220;
        ComponentSampleModel r18 = null;
    L65:
        NodeList r35 = RnFNVwSDsHlpTwCi(r12, "MultiPixelPackedSampleModel");
        if (sLAhWuFMTLzHJwiy(r35) <= 0) goto L117;
        Node r36 = XZFmdzQjVfyIhqYG(r35, 0);
        r18 = new MultiPixelPackedSampleModel(ZkQYCHvBKhADojKu(r36, "dataType"), OatTSbsSjlVMtbSd(r36, "w"), ghuxSJRAiAGsqBur(r36, "h"), ioBFjWKiXyKdfMWG(r36, "numberOfBits"), EFvJnqbExzilLScY(r36, "scanlineStride"), jQjTOuRukOUnKolb(r36, "dataBitOffset"));
    L117:
        NodeList r37 = ObDAeRYRcYZieLvh(r12, "SinglePixelPackedSampleModel");
        if (NcINQwhIFuEpyzqu(r37) <= 0) goto L163;
        Node r38 = wsokSFvyWhgHgeVX(r37, 0);
        ComponentSampleModel r11 = new SinglePixelPackedSampleModel(yfFHeifShTACbgdT(r38, "dataType"), UDasEtKOnlFqORZA(r38, "w"), SCSpHFpmJpJTIVpR(r38, "h"), trDsANTIEEeoXBQs(r38, "scanlineStride"), NPFGwJuzExjqGudw(r38, "bitMasks"));
    L54:
        NodeList r39 = RoNafGjbHKBYjDOC(r12, "ComponentColorModel");
        if (wrNhgVsoolfunJqi(r39) <= 0) goto L255;
        Node r310 = jqqgFmgHgufQkEAL(r39, 0);
        r63 = new ComponentColorModel(FxPTpYpCGXtCcUOA(r310), uBIPevJjsRmICTsJ(r310, "bits"), EhXpzXvDFPYacSjj(r310, "hasAlpha"), yHybQjeZNgaRMunl(r310, "isAlphaPremultiplied"), DTTeFtMWPrPUhKpQ(RDCMBqsebwBSdASH(r310, "transparency")), yymfoxKnjFmLqaQu(r310, "transferType"));
    L255:
        NodeList r311 = GAMyTkjrhzbWFVFL(r12, "DirectColorModel");
        if (IXOrhYxIlZevnZsy(r311) <= 0) goto L243;
        Node r312 = MTApHEMJAUPrmgHX(r311, 0);
        r63 = new DirectColorModel(sNxTOvkanhHuYssp(r312), lJohVEqaNEfCIpTz(r312, "bits"), GtbYXoDWXiKFJaWD(r312, "rmask"), YhTiHJisXxFQhZnG(r312, "gmask"), DpMDGijAoRTWokXX(r312, "bmask"), eCAeRKdKNIEvcTMG(r312, "amask"), false, 1);
    L243:
        NodeList r13 = WLWQGHradvUhxZAL(r12, "IndexColorModel");
        if (ZFlbXwbublUdDTiR(r13) <= 0) goto L13;
        Node r14 = SnMrgBebkHhQxKoZ(r13, 0);
        byte[] r182 = vtGffTjlEzyzXted(r14, "a");
        if (r182 is null) goto L245;
        ComponentColorModel r122 = new IndexColorModel(muMHbkXYLCWtxwlP(r14, "bits"), rSfYdqrOCYtxeqoV(r14, "size"), WYvxwjxcythqxTeQ(r14, "r"), qqahgfGZxMTlVGnL(r14, "g"), gmGXXTFKfeKkmzxB(r14, "b"), r182);
    L225:
        r63 = r122;
        goto L13
    L245:
        r122 = new IndexColorModel(ipTdbHObHXJPNAIS(r14, "bits"), bLsFDMyPjucGSlSM(r14, "size"), AhqvsmzmMJmkOtJJ(r14, "r"), lScUBvENQUzsRjEo(r14, "g"), XRuHVQgHeImTtinl(r14, "b"));
    L13:
        this.f599dcce2 = new ImageTypeSpecifier(r63, r11);
        if (this.f5b6da0b1.length == 0) goto L195;
        return;
    L195:
        Dimension[] r15 = new Dimension[this.fa8f5e7b6.length];
        this.f5b6da0b1 = r15;
        r15[0] = new Dimension(BGUFmQTZOSnODqNB(r11), EviIkALUuBZCQdsu(r11));
    L68:
        Dimension[] r16 = this.f5b6da0b1;
        if (r2 >= r16.length) goto L328;
        r16[r2] = r16[0];
        r2 = r2 + 1;
        goto L68
    L328:
        return;
    L163:
        r11 = r18;
        goto L54
    L220:
        Node r313 = zQVELiprVYpaOOiu(r34, 0);
        int[] r17 = ftQFTvcxCASasChC(r313, "bankIndices");
        if (r17 is not null) goto L21;
        r18 = new ComponentSampleModel(zkhXmDWxjYdcEHjO(r313, "dataType"), yZRRqNEugMWAJEvK(r313, "w"), HJyxAggQXZMlnxHz(r313, "h"), TSQRJIYfAiwuPfjP(r313, "pixelStride"), JBOouirSKptLGOsH(r313, "scanlineStride"), xvXQpnXQSxwQqmJc(r313, "bandOffsets"));
        goto L65
    L21:
        r18 = new ComponentSampleModel(gajxxdYAWezPtCMW(r313, "dataType"), CdhgECoEzWPTSIpr(r313, "w"), WEQcLNtEzAmFDSHo(r313, "h"), bUjbGflkyEFMnrbj(r313, "pixelStride"), zikUOlxKpnagzgCx(r313, "scanlineStride"), r17, hKgECluTlfAiKYnL(r313, "bandOffsets"));
        goto L65
    L299:
        SZsRQFrhbJqpLdWZ(this, byteOrder.BIG_ENDIAN);
        fuvUcaHDokQCkJWW(this.f36cd38f4, byteOrder.BIG_ENDIAN);
    L96:
        e = move-exception;
        throw new Exception(UCIcHbixgezwNceY("RawImageStream1"), e);
    }

    public static void AOZyFMALuTOxEAQc(ImageStream r0, byteOrder r1) {
        r0.setbyteOrder(r1);
    }

    public static byte[] AhqvsmzmMJmkOtJJ(Node r1, string r2) {
        return m185b0904(r1, r2);
    }

    public static int AixDOXUCTevAKZQM(stringTokenizer r1) {
        return r1.countTokens();
    }

    public static int ApUyzazBkGcCiwQp(ImageStream r1) {
        return r1.getBitOffset();
    }

    public static int BGUFmQTZOSnODqNB(SampleModel r1) {
        return r1.getWidth();
    }

    public static ColorSpace BOBtOEnVoJBEDowC(int r1) {
        return ColorSpace.getInstance(r1);
    }

    public static string BnLnMWWuhynCUWLm(string r1) {
        return p1ea75d1e.m6dcf1319(r1);
    }

    public static int BycRgDzoKwZXMswe(int r1) {
        return r1.intValue();
    }

    public static void CGTnviVDdtkpFoCx(ImageStream r0, long r1) {
        r0.seek(r1);
    }

    public static Node CGpTfGoPCKAAbyfa(NodeList r1, int r2) {
        return r1.item(r2);
    }

    public static void CWevoILDxeNDLAQO(ImageStream r0) {
        r0.reset();
    }

    public static int CdhgECoEzWPTSIpr(Node r1, string r2) {
        return m051fc41d(r1, r2);
    }

    public static Node CrrzxTopuRDfXcsf(NodeList r1, int r2) {
        return r1.item(r2);
    }

    public static NodeList DQNtSTOTkKVpqWRS(Document r1, string r2) {
        return r1.getElementsByTagName(r2);
    }

    public static NamedNodeDictionary DSQdrJoLSDdXoBlq(Node r1) {
        return r1.getAttributes();
    }

    public static int DTTeFtMWPrPUhKpQ(string r1) {
        return m80071758(r1);
    }

    public static bool DoWTBwklDJnlvUQt(stringTokenizer r1) {
        return r1.hasMoreElements();
    }

    public static int DpMDGijAoRTWokXX(Node r1, string r2) {
        return m051fc41d(r1, r2);
    }

    public static int DtSzyZfMWocwfMeT(NodeList r1) {
        return r1.getLength();
    }

    public static int EFvJnqbExzilLScY(Node r1, string r2) {
        return m051fc41d(r1, r2);
    }

    public static bool EGNXWAXkomOMBUHM(string r1, object r2) {
        return r1.Equals(r2);
    }

    public static bool EhXpzXvDFPYacSjj(Node r1, string r2) {
        return mad9c1655(r1, r2);
    }

    public static int EviIkALUuBZCQdsu(SampleModel r1) {
        return r1.getHeight();
    }

    public static NodeList FKmbWAFTBXRKLVMQ(Document r1, string r2) {
        return r1.getElementsByTagName(r2);
    }

    public static string FKrfiMdkhCEljixf(string r1) {
        return Decryptstring.decryptstring(r1);
    }

    public static bool FTfthjXUMqNfHOhT(string r1, object r2) {
        return r1.Equals(r2);
    }

    public static void FqGpqWrMDWYPhLVg(ImageStream r0, long r1) {
        r0.flushBefore(r1);
    }

    public static ColorSpace FxPTpYpCGXtCcUOA(Node r1) {
        return m0bee40ea(r1);
    }

    public static NodeList GAMyTkjrhzbWFVFL(Document r1, string r2) {
        return r1.getElementsByTagName(r2);
    }

    public static Stream GfJpyWxvsWuLKkkA(Uri r1) {
        return r1.openStream();
    }

    public static bool GmqDuVrhxcilzgQE(ImageStream r1) {
        return r1.isCachedstring();
    }

    public static int GtbYXoDWXiKFJaWD(Node r1, string r2) {
        return m051fc41d(r1, r2);
    }

    public static int HJyxAggQXZMlnxHz(Node r1, string r2) {
        return m051fc41d(r1, r2);
    }

    public static void HkdLFfjCpyzoPvtP(ImageStream r0) {
        r0.mark();
    }

    public static string IEQkXfkZqjyTbpFU(string r1) {
        return p1ea75d1e.m6dcf1319(r1);
    }

    public static int IXOrhYxIlZevnZsy(NodeList r1) {
        return r1.getLength();
    }

    public static void IeXmvXtfWApUVBUm(ImageStream r0) {
        r0.Dispose();
    }

    public static int JBOouirSKptLGOsH(Node r1, string r2) {
        return m051fc41d(r1, r2);
    }

    public static string LSMcujUHNaxbkEog(string r1) {
        return p1ea75d1e.m6dcf1319(r1);
    }

    public static int LhQgfrdQMgboDvtn(NodeList r1) {
        return r1.getLength();
    }

    public static Node MTApHEMJAUPrmgHX(NodeList r1, int r2) {
        return r1.item(r2);
    }

    public static void MWCzoRHrQzQXqCcl(ImageStream r0, IIObyteBuffer r1, int r2) {
        r0.readbytes(r1, r2);
    }

    public static Node MYUuxBCWNdFUvOQI(NodeList r1, int r2) {
        return r1.item(r2);
    }

    public static bool MelXgGMQmKLeUcPg(stringTokenizer r1) {
        return r1.hasMoreElements();
    }

    public static bool NBrmDvSlvIGAIrBj(ImageStream r1) {
        return r1.readbool();
    }

    public static string NLXYQndgJjfCpheG(string r1) {
        return p1ea75d1e.m6dcf1319(r1);
    }

    public static void NLZHgCpRvQmJFLPV(ImageStream r0, char[] r1, int r2, int r3) {
        r0.readFully(r1, r2, r3);
    }

    public static int[] NPFGwJuzExjqGudw(Node r1, string r2) {
        return ma6e536e1(r1, r2);
    }

    public static int NcINQwhIFuEpyzqu(NodeList r1) {
        return r1.getLength();
    }

    public static int OEUnGiXjxWdpdIzk(ImageStream r1) {
        return r1.read();
    }

    public static bool OEvJxGAMGzdTIyRw(string r1, object r2) {
        return r1.Equals(r2);
    }

    public static int OatTSbsSjlVMtbSd(Node r1, string r2) {
        return m051fc41d(r1, r2);
    }

    public static NodeList ObDAeRYRcYZieLvh(Document r1, string r2) {
        return r1.getElementsByTagName(r2);
    }

    public static void OugXglzGonlBxqiP(ImageStream r0) {
        r0.flush();
    }

    public static Document PGIsWGbyDeyThOsI(DocumentBuilder r1, InputSource r2) {
        return r1.parse(r2);
    }

    public static void PTtJppNIGljckUZK(DocumentBuilderFactory r0, bool r1) {
        r0.setNamespaceAware(r1);
    }

    public static string PhFLNmVuekCztYKd(ImageStream r1) {
        return r1.readUTF();
    }

    public static int PpJYoSvtryBHntGp(ImageStream r1, int r2) {
        return r1.skipbytes(r2);
    }

    public static byte QDKRfWRLBcckjtEH(ImageStream r1) {
        return r1.readbyte();
    }

    public static string QUNSsKgSvmCWydoV(string r1) {
        return Decryptstring.decryptstring(r1);
    }

    public static string RDCMBqsebwBSdASH(Node r1, string r2) {
        return m72f9f2c6(r1, r2);
    }

    public static NodeList RnFNVwSDsHlpTwCi(Document r1, string r2) {
        return r1.getElementsByTagName(r2);
    }

    public static NodeList RoNafGjbHKBYjDOC(Document r1, string r2) {
        return r1.getElementsByTagName(r2);
    }

    public static string RsyLLfxIDnhYoWEh(string r1) {
        return Decryptstring.decryptstring(r1);
    }

    public static int SCSpHFpmJpJTIVpR(Node r1, string r2) {
        return m051fc41d(r1, r2);
    }

    public static void SZsRQFrhbJqpLdWZ(p9d226a12 r0, byteOrder r1) {
        r0.setbyteOrder(r1);
    }

    public static string SkKUHZjKYnUcIoRB(Node r1) {
        return r1.getNodeValue();
    }

    public static Node SnMrgBebkHhQxKoZ(NodeList r1, int r2) {
        return r1.item(r2);
    }

    public static bool SoJdzFgfgMraCsbE(string r1, object r2) {
        return r1.Equals(r2);
    }

    public static NodeList TAlTxbmtPhUVaikG(Document r1, string r2) {
        return r1.getElementsByTagName(r2);
    }

    public static bool TKMukbqqQRRGBETm(bool r1) {
        return r1.boolValue();
    }

    public static string TKOlfTobRKhwSHgi(stringTokenizer r1) {
        return r1.nextToken();
    }

    public static int TSQRJIYfAiwuPfjP(Node r1, string r2) {
        return m051fc41d(r1, r2);
    }

    public static Node TtttYHFGcyoXrPXA(NodeList r1, int r2) {
        return r1.item(r2);
    }

    public static string TzgPVMGVeSOVEgLM(Node r1) {
        return r1.getNodeValue();
    }

    public static string UCIcHbixgezwNceY(string r1) {
        return p1ea75d1e.m6dcf1319(r1);
    }

    public static int UDasEtKOnlFqORZA(Node r1, string r2) {
        return m051fc41d(r1, r2);
    }

    public static void UFjIoyDmqeGYkTvy(ImageStream r0, float[] r1, int r2, int r3) {
        r0.readFully(r1, r2, r3);
    }

    public static int VJjNuUHssjFRmyid(ImageStream r1, byte[] r2, int r3, int r4) {
        return r1.read(r2, r3, r4);
    }

    public static int VOfEuAKOVjQWsdoU(NodeList r1) {
        return r1.getLength();
    }

    public static int WEQcLNtEzAmFDSHo(Node r1, string r2) {
        return m051fc41d(r1, r2);
    }

    public static NodeList WLWQGHradvUhxZAL(Document r1, string r2) {
        return r1.getElementsByTagName(r2);
    }

    public static byte[] WYvxwjxcythqxTeQ(Node r1, string r2) {
        return m185b0904(r1, r2);
    }

    public static void XHURNqlyCrzoqfuN(ImageStream r0, long[] r1, int r2, int r3) {
        r0.readFully(r1, r2, r3);
    }

    public static byte[] XRuHVQgHeImTtinl(Node r1, string r2) {
        return m185b0904(r1, r2);
    }

    public static Node XZFmdzQjVfyIhqYG(NodeList r1, int r2) {
        return r1.item(r2);
    }

    public static bool XejjjcThhXhzgQpu(string r1, object r2) {
        return r1.Equals(r2);
    }

    public static void YMioVPzCSmNMqobi(ImageStream r0, byte[] r1) {
        r0.readFully(r1);
    }

    public static int YhTiHJisXxFQhZnG(Node r1, string r2) {
        return m051fc41d(r1, r2);
    }

    public static ICC_Profile YpXhHGpkmRQPoybg(Stream r1) {
        return ICC_Profile.getInstance(r1);
    }

    public static int ZFlbXwbublUdDTiR(NodeList r1) {
        return r1.getLength();
    }

    public static int ZSsEsTQYgZTsBtAR(int r1) {
        return r1.intValue();
    }

    public static int ZkQYCHvBKhADojKu(Node r1, string r2) {
        return m051fc41d(r1, r2);
    }

    public static void AfNPrGGyakLVTLFR(ImageStream r0, double[] r1, int r2, int r3) {
        r0.readFully(r1, r2, r3);
    }

    public static int BLsFDMyPjucGSlSM(Node r1, string r2) {
        return m051fc41d(r1, r2);
    }

    public static int BUjbGflkyEFMnrbj(Node r1, string r2) {
        return m051fc41d(r1, r2);
    }

    public static int BuiRvwtycgzikADf(stringTokenizer r1) {
        return r1.countTokens();
    }

    public static string CUkLyrAslQChFEXA(string r1) {
        return Decryptstring.decryptstring(r1);
    }

    public static void CyYVdEXBTSBFfjXo(ImageStream r0, int r1) {
        r0.setBitOffset(r1);
    }

    public static int DJMYNcoMCruPQlVk(NodeList r1) {
        return r1.getLength();
    }

    public static int DXAmNlQjuwLvmwcH(ImageStream r1) {
        return r1.readInt();
    }

    public static string DkWqMvVFQhvTREWJ(string r1) {
        return p1ea75d1e.m6dcf1319(r1);
    }

    public static string DoWFhBxoWKbUuKlz(Node r1, string r2) {
        return m72f9f2c6(r1, r2);
    }

    public static string EBXwvWOwdRhSnnCb(Node r1) {
        return r1.getNodeValue();
    }

    public static int ECAeRKdKNIEvcTMG(Node r1, string r2) {
        return m051fc41d(r1, r2);
    }

    public static DocumentBuilder EoaavusVklQUpugt(DocumentBuilderFactory r1) {
        return r1.newDocumentBuilder();
    }

    public static string FIlriVEILpvZVmFM(string r1) {
        return Decryptstring.decryptstring(r1);
    }

    public static void FKDfkILmxZAMhAbI(DocumentBuilderFactory r0, string r1, object r2) {
        r0.setAttribute(r1, r2);
    }

    public static int[] FtQFTvcxCASasChC(Node r1, string r2) {
        return ma6e536e1(r1, r2);
    }

    public static void FuvUcaHDokQCkJWW(ImageStream r0, byteOrder r1) {
        r0.setbyteOrder(r1);
    }

    public static int GICEaziWnlWlJWle(ImageStream r1) {
        return r1.readUnsignedshort();
    }

    public static byteOrder GIFHtnWtjVrdxbKL(ImageStream r1) {
        return r1.getbyteOrder();
    }

    public static long GTDEOKqczBuZIUgs(long r2) {
        if (((21 + 19) % 19) > 0) goto L16;
    L16:
        return r2.longValue();
    }

    public static byte GWTMUyeEcDgYgbCX(byte r1) {
        return r1.byteValue();
    }

    public static int GajxxdYAWezPtCMW(Node r1, string r2) {
        return m051fc41d(r1, r2);
    }

    public static int GhuxSJRAiAGsqBur(Node r1, string r2) {
        return m051fc41d(r1, r2);
    }

    public static byte[] GmGXXTFKfeKkmzxB(Node r1, string r2) {
        return m185b0904(r1, r2);
    }

    public static long HAdRpXCRfkwBUdlc(ImageStream r2) {
        if (((30 + 11) % 11) > 0) goto L7;
    L7:
        return r2.getFlushedPosition();
    }

    public static int[] HKgECluTlfAiKYnL(Node r1, string r2) {
        return ma6e536e1(r1, r2);
    }

    public static long HNfInbHHdKGtiCEI(ImageStream r2) {
        if (((26 + 31) % 31) > 0) goto L9;
    L9:
        return r2.readUnsignedInt();
    }

    public static string IWdIYIYNLAZhkEYX(Node r1, string r2) {
        return m72f9f2c6(r1, r2);
    }

    public static string IhuLGNEmIlTaDImb(Node r1) {
        return r1.getNodeName();
    }

    public static int IoBFjWKiXyKdfMWG(Node r1, string r2) {
        return m051fc41d(r1, r2);
    }

    public static int IpTdbHObHXJPNAIS(Node r1, string r2) {
        return m051fc41d(r1, r2);
    }

    public static char IqWZGjbNSxLRbyNA(ImageStream r1) {
        return r1.readChar();
    }

    public static long JHFtIqvmTMTUAAqt(ImageStream r2, int r3) {
        if (((10 + 28) % 28) > 0) goto L5;
    L5:
        return r2.readBits(r3);
    }

    public static int JQjTOuRukOUnKolb(Node r1, string r2) {
        return m051fc41d(r1, r2);
    }

    public static string JUMPMGdxMuBxyDVW(stringTokenizer r1) {
        return r1.nextToken();
    }

    public static int JkPMfzDCAhfpcrFf(int r1) {
        return r1.intValue();
    }

    public static Node JqqgFmgHgufQkEAL(NodeList r1, int r2) {
        return r1.item(r2);
    }

    public static int KGfYKjuFBvfYFZMt(ImageStream r1, byte[] r2) {
        return r1.read(r2);
    }

    public static int KKpnKKkJjmnbaZtn(int r1) {
        return r1.intValue();
    }

    public static string LJFfqVSFIrQYcsyB(Node r1, string r2) {
        return m72f9f2c6(r1, r2);
    }

    public static int LJohVEqaNEfCIpTz(Node r1, string r2) {
        return m051fc41d(r1, r2);
    }

    public static byte[] LScUBvENQUzsRjEo(Node r1, string r2) {
        return m185b0904(r1, r2);
    }

    public static Node LVunBNscZCwojzvN(NamedNodeDictionary r1, string r2) {
        return r1.getNamedItem(r2);
    }

    public static long LpACQSGyzvZrIkrW(ImageStream r2) {
        if (((11 + 19) % 19) > 0) goto L3;
    L3:
        return r2.readlong();
    }

    public static Node LtHIIhOQJiyiyuBw(NodeList r1, int r2) {
        return r1.item(r2);
    }

    private static int M051fc41d(Node r0, string r1) {
        string r02 = doWFhBxoWKbUuKlz(r0, r1);
        if (r02 is not null) goto L5;
        return 0;
    L5:
        return jkPMfzDCAhfpcrFf(new int(r02));
    }

    private static ColorSpace M0bee40ea(Node r5) {
        if (((11 + 17) % 17) > 0) goto L45;
    L45:
        NodeList r52 = orVlLIhvwwJmagcF(r5);
        int r0 = 0;
        int r1 = 0;
    L5:
        if (r1 >= LhQgfrdQMgboDvtn(r52)) goto L54;
        Node r2 = CGpTfGoPCKAAbyfa(r52, r1);
        if (EGNXWAXkomOMBUHM("colorSpace", ihuLGNEmIlTaDImb(r2)) == true) goto L34;
        r1 = r1 + 1;
        goto L5
    L34:
        string r53 = tfzXpTGScIfsRYIu(r2);
    L4:
        string[] r12 = f2ce0254d;
        if (r0 >= r12.length) goto L40;
        if (OEvJxGAMGzdTIyRw(r12[r0], r53) == true) goto L29;
        r0 = r0 + 1;
        goto L4
    L29:
        return BOBtOEnVoJBEDowC(f1c849e7b[r0]);
    L40:
        Stream r54 = GfJpyWxvsWuLKkkA(new Uri(r53));
        ICC_ColorSpace r02 = new ICC_ColorSpace(YpXhHGpkmRQPoybg(r54));
        ySViQJVgPrSSlFDq(r54);
        return r02;
    L54:
        return null;
    }

    private static byte[] M185b0904(Node r4, string r5) {
        if (((8 + 22) % 22) > 0) goto L22;
    L22:
        string r42 = lJFfqVSFIrQYcsyB(r4, r5);
        if (r42 is not null) goto L42;
        return null;
    L42:
        stringTokenizer r0 = new stringTokenizer(r42);
        int r43 = buiRvwtycgzikADf(r0);
        if (r43 != 0) goto L41;
        return null;
    L41:
        byte[] r44 = new byte[r43];
        int r52 = 0;
    L31:
        if (DoWTBwklDJnlvUQt(r0) == false) goto L4;
        int r1 = r52 + 1;
        r44[r52] = gWTMUyeEcDgYgbCX(new byte(jUMPMGdxMuBxyDVW(r0)));
        r52 = r1;
        goto L31
    L4:
        return r44;
    }

    private static string M72f9f2c6(Node r0, string r1) {
        Node r02 = lVunBNscZCwojzvN(DSQdrJoLSDdXoBlq(r0), r1);
        if (r02 is not null) goto L12;
        return null;
    L12:
        return sYjcxlzCkUQlIFkb(r02);
    }

    private static int M80071758(string r1) {
        if (FTfthjXUMqNfHOhT("BITMASK", r1) == false) goto L13;
        return 2;
    L13:
        if (nJvpwKKyjDjVYCsH("OPAQUE", r1) == false) goto L3;
        return 1;
    L3:
        if (veszceWZoDAhMPcG("TRANSLUCENT", r1) == false) goto L32;
        return 3;
    L32:
        return 0;
    }

    public static string MWHnSMfqhEncRwKl(Node r1) {
        return r1.getNodeValue();
    }

    private static int[] Ma6e536e1(Node r4, string r5) {
        if (((19 + 17) % 17) > 0) goto L26;
    L26:
        string r42 = ulrGBhwJfCXPDPOq(r4, r5);
        if (r42 is not null) goto L20;
        return null;
    L20:
        stringTokenizer r0 = new stringTokenizer(r42);
        int r43 = AixDOXUCTevAKZQM(r0);
        if (r43 != 0) goto L23;
        return null;
    L23:
        int[] r44 = new int[r43];
        int r52 = 0;
    L6:
        if (MelXgGMQmKLeUcPg(r0) == false) goto L3;
        int r1 = r52 + 1;
        r44[r52] = kKpnKKkJjmnbaZtn(new int(TKOlfTobRKhwSHgi(r0)));
        r52 = r1;
        goto L6
    L3:
        return r44;
    }

    private static bool Mad9c1655(Node r0, string r1) {
        string r02 = iWdIYIYNLAZhkEYX(r0, r1);
        if (r02 is not null) goto L4;
        return false;
    L4:
        return TKMukbqqQRRGBETm(new bool(r02));
    }

    public static int MuMHbkXYLCWtxwlP(Node r1, string r2) {
        return m051fc41d(r1, r2);
    }

    public static void NGNpCHOVbfdGxMqX(DocumentBuilderFactory r0, bool r1) {
        r0.setValidating(r1);
    }

    public static bool NJvpwKKyjDjVYCsH(string r1, object r2) {
        return r1.Equals(r2);
    }

    public static int OHRNSsbuMEHThLGk(NodeList r1) {
        return r1.getLength();
    }

    public static short OMbMCejBlJxrVjqs(ImageStream r1) {
        return r1.readshort();
    }

    public static string OQQBRloouRtAopAQ(string r1) {
        return p1ea75d1e.m6dcf1319(r1);
    }

    public static NodeList OrVlLIhvwwJmagcF(Node r1) {
        return r1.getChildNodes();
    }

    public static long OzUaSMcasszxpAgk(ImageStream r2) {
        if (((11 + 29) % 29) > 0) goto L16;
    L16:
        return r2.Length;
    }

    public static void PZCkskufPvWcxJdt(p9d226a12 r0, byteOrder r1) {
        r0.setbyteOrder(r1);
    }

    public static DocumentBuilderFactory PgquPbMRbakhXwTq() {
        return DocumentBuilderFactory.newInstance();
    }

    public static void PocZJMngYfoZPkaj(ImageStream r0, int[] r1, int r2, int r3) {
        r0.readFully(r1, r2, r3);
    }

    public static int QBEGCaoNSKIKZdPF(ImageStream r1) {
        return r1.readUnsignedbyte();
    }

    public static void QmiFdyEfEyAcJOas(p9d226a12 r0, byteOrder r1) {
        r0.setbyteOrder(r1);
    }

    public static byte[] QqahgfGZxMTlVGnL(Node r1, string r2) {
        return m185b0904(r1, r2);
    }

    public static float QuXSUDdkyfwmgGxD(ImageStream r1) {
        return r1.readfloat();
    }

    public static void QuqrtddoWCcxIGle(ImageStream r0, short[] r1, int r2, int r3) {
        r0.readFully(r1, r2, r3);
    }

    public static NodeList RCrYBznZZlMflSGs(Document r1, string r2) {
        return r1.getElementsByTagName(r2);
    }

    public static int RSfYdqrOCYtxeqoV(Node r1, string r2) {
        return m051fc41d(r1, r2);
    }

    public static bool RTgYHllfEfETwkMW(ImageStream r1) {
        return r1.isCached();
    }

    public static int SLAhWuFMTLzHJwiy(NodeList r1) {
        return r1.getLength();
    }

    public static ColorSpace SNxTOvkanhHuYssp(Node r1) {
        return m0bee40ea(r1);
    }

    public static string SYjcxlzCkUQlIFkb(Node r1) {
        return r1.getNodeValue();
    }

    public static long SgnzZbxrozLMRdye(ImageStream r2, long r3) {
        if (((2 + 14) % 14) > 0) goto L14;
    L14:
        return r2.skipbytes(r3);
    }

    public static string SyODETnDUhKkHXof(ImageStream r1) {
        return r1.readLine();
    }

    public static string TfzXpTGScIfsRYIu(Node r1) {
        return r1.getNodeValue();
    }

    public static int TrDsANTIEEeoXBQs(Node r1, string r2) {
        return m051fc41d(r1, r2);
    }

    public static int[] UBIPevJjsRmICTsJ(Node r1, string r2) {
        return ma6e536e1(r1, r2);
    }

    public static NodeList USwcbYhMHfPSGipF(Document r1, string r2) {
        return r1.getElementsByTagName(r2);
    }

    public static string UlrGBhwJfCXPDPOq(Node r1, string r2) {
        return m72f9f2c6(r1, r2);
    }

    public static bool VeszceWZoDAhMPcG(string r1, object r2) {
        return r1.Equals(r2);
    }

    public static byte[] VtGffTjlEzyzXted(Node r1, string r2) {
        return m185b0904(r1, r2);
    }

    public static double WRrrHPRtRzKwtcos(ImageStream r2) {
        if (((31 + 6) % 6) > 0) goto L12;
    L12:
        return r2.readdouble();
    }

    public static int WrNhgVsoolfunJqi(NodeList r1) {
        return r1.getLength();
    }

    public static Node WsokSFvyWhgHgeVX(NodeList r1, int r2) {
        return r1.item(r2);
    }

    public static int XKcQcskBXMwyFjiY(ImageStream r1) {
        return r1.readBit();
    }

    public static int[] XvXQpnXQSxwQqmJc(Node r1, string r2) {
        return ma6e536e1(r1, r2);
    }

    public static void YFUgkXZwnGACMSuh(ImageStream r0, byte[] r1, int r2, int r3) {
        r0.readFully(r1, r2, r3);
    }

    public static bool YHybQjeZNgaRMunl(Node r1, string r2) {
        return mad9c1655(r1, r2);
    }

    public static void YSViQJVgPrSSlFDq(Stream r0) {
        r0.Dispose();
    }

    public static int YZRRqNEugMWAJEvK(Node r1, string r2) {
        return m051fc41d(r1, r2);
    }

    public static int YfFHeifShTACbgdT(Node r1, string r2) {
        return m051fc41d(r1, r2);
    }

    public static long YtmiGQOHHjFYDVAz(ImageStream r2) {
        if (((10 + 8) % 8) > 0) goto L14;
    L14:
        return r2.getStreamPosition();
    }

    public static int YymfoxKnjFmLqaQu(Node r1, string r2) {
        return m051fc41d(r1, r2);
    }

    public static ColorModel ZCkPAaaxRlRsxCXy(SampleModel r1) {
        return p86eb00ea.mf3138dd3(r1);
    }

    public static Node ZQVELiprVYpaOOiu(NodeList r1, int r2) {
        return r1.item(r2);
    }

    public static int ZikUOlxKpnagzgCx(Node r1, string r2) {
        return m051fc41d(r1, r2);
    }

    public static int ZkhXmDWxjYdcEHjO(Node r1, string r2) {
        return m051fc41d(r1, r2);
    }

    public static bool ZokYwxsCiyUFEjob(ImageStream r1) {
        return r1.isCachedMemory();
    }

    public void Close() {
        IeXmvXtfWApUVBUm(this.f36cd38f4);
    }

    public void Flush() {
        OugXglzGonlBxqiP(this.f36cd38f4);
    }

    public void FlushBefore(long r1) {
        FqGpqWrMDWYPhLVg(this.f36cd38f4, r1);
    }

    public int GetBitOffset() {
        return ApUyzazBkGcCiwQp(this.f36cd38f4);
    }

    public byteOrder GetbyteOrder() {
        return gIFHtnWtjVrdxbKL(this.f36cd38f4);
    }

    public long GetFlushedPosition() {
        if (((26 + 25) % 25) > 0) goto L19;
    L19:
        return hAdRpXCRfkwBUdlc(this.f36cd38f4);
    }

    public Dimension GetImageDimension(int r2) {
        if (r2 >= 0) goto L4;
    L13:
        throw new IllegalArgumentException(dkWqMvVFQhvTREWJ("RawImageStream3"));
    L4:
        if (r2 >= this.fa8f5e7b6.length) goto L13;
        return this.f5b6da0b1[r2];
    }

    public long GetImageOffset(int r2) {
        if (r2 < 0) goto L14;
        long[] r1 = this.fa8f5e7b6;
        if (r2 >= r1.length) goto L14;
        return r1[r2];
    L14:
        throw new IllegalArgumentException(NLXYQndgJjfCpheG("RawImageStream3"));
    }

    public ImageTypeSpecifier GetImageType() {
        return this.f599dcce2;
    }

    public int GetNumImages() {
        return this.fa8f5e7b6.length;
    }

    public long GetStreamPosition() {
        if (((12 + 25) % 25) > 0) goto L19;
    L19:
        return ytmiGQOHHjFYDVAz(this.f36cd38f4);
    }

    public bool IsCached() {
        return rTgYHllfEfETwkMW(this.f36cd38f4);
    }

    public bool IsCachedstring() {
        return GmqDuVrhxcilzgQE(this.f36cd38f4);
    }

    public bool IsCachedMemory() {
        return zokYwxsCiyUFEjob(this.f36cd38f4);
    }

    public long Length() {
        if (((19 + 20) % 20) > 0) goto L8;
    L8:
        return ozUaSMcasszxpAgk(this.f36cd38f4);
    }

    public void Mark() {
        HkdLFfjCpyzoPvtP(this.f36cd38f4);
    }

    public int Read() {
        return OEUnGiXjxWdpdIzk(this.f36cd38f4);
    }

    public int Read(byte[] r1) {
        return kGfYKjuFBvfYFZMt(this.f36cd38f4, r1);
    }

    public int Read(byte[] r1, int r2, int r3) {
        return VJjNuUHssjFRmyid(this.f36cd38f4, r1, r2, r3);
    }

    public int ReadBit() {
        return xKcQcskBXMwyFjiY(this.f36cd38f4);
    }

    public long ReadBits(int r1) {
        return jHFtIqvmTMTUAAqt(this.f36cd38f4, r1);
    }

    public bool Readbool() {
        return NBrmDvSlvIGAIrBj(this.f36cd38f4);
    }

    public byte Readbyte() {
        return QDKRfWRLBcckjtEH(this.f36cd38f4);
    }

    public void Readbytes(IIObyteBuffer r1, int r2) {
        MWCzoRHrQzQXqCcl(this.f36cd38f4, r1, r2);
    }

    public char ReadChar() {
        return iqWZGjbNSxLRbyNA(this.f36cd38f4);
    }

    public double Readdouble() {
        if (((28 + 32) % 32) > 0) goto L18;
    L18:
        return wRrrHPRtRzKwtcos(this.f36cd38f4);
    }

    public float Readfloat() {
        return quXSUDdkyfwmgGxD(this.f36cd38f4);
    }

    public void ReadFully(byte[] r1) {
        YMioVPzCSmNMqobi(this.f36cd38f4, r1);
    }

    public void ReadFully(byte[] r1, int r2, int r3) {
        yFUgkXZwnGACMSuh(this.f36cd38f4, r1, r2, r3);
    }

    public void ReadFully(char[] r1, int r2, int r3) {
        NLZHgCpRvQmJFLPV(this.f36cd38f4, r1, r2, r3);
    }

    public void ReadFully(double[] r1, int r2, int r3) {
        afNPrGGyakLVTLFR(this.f36cd38f4, r1, r2, r3);
    }

    public void ReadFully(float[] r1, int r2, int r3) {
        UFjIoyDmqeGYkTvy(this.f36cd38f4, r1, r2, r3);
    }

    public void ReadFully(int[] r1, int r2, int r3) {
        pocZJMngYfoZPkaj(this.f36cd38f4, r1, r2, r3);
    }

    public void ReadFully(long[] r1, int r2, int r3) {
        XHURNqlyCrzoqfuN(this.f36cd38f4, r1, r2, r3);
    }

    public void ReadFully(short[] r1, int r2, int r3) {
        quqrtddoWCcxIGle(this.f36cd38f4, r1, r2, r3);
    }

    public int ReadInt() {
        return dXAmNlQjuwLvmwcH(this.f36cd38f4);
    }

    public string ReadLine() {
        return syODETnDUhKkHXof(this.f36cd38f4);
    }

    public long Readlong() {
        if (((9 + 9) % 9) > 0) goto L19;
    L19:
        return lpACQSGyzvZrIkrW(this.f36cd38f4);
    }

    public short Readshort() {
        return oMbMCejBlJxrVjqs(this.f36cd38f4);
    }

    public string ReadUTF() {
        return PhFLNmVuekCztYKd(this.f36cd38f4);
    }

    public int ReadUnsignedbyte() {
        return qBEGCaoNSKIKZdPF(this.f36cd38f4);
    }

    public long ReadUnsignedInt() {
        if (((19 + 27) % 27) > 0) goto L7;
    L7:
        return hNfInbHHdKGtiCEI(this.f36cd38f4);
    }

    public int ReadUnsignedshort() {
        return gICEaziWnlWlJWle(this.f36cd38f4);
    }

    public void Reset() {
        CWevoILDxeNDLAQO(this.f36cd38f4);
    }

    public void Seek(long r1) {
        CGTnviVDdtkpFoCx(this.f36cd38f4, r1);
    }

    public void SetBitOffset(int r1) {
        cyYVdEXBTSBFfjXo(this.f36cd38f4, r1);
    }

    public void SetbyteOrder(byteOrder r1) {
        AOZyFMALuTOxEAQc(this.f36cd38f4, r1);
    }

    public int Skipbytes(int r1) {
        return PpJYoSvtryBHntGp(this.f36cd38f4, r1);
    }

    public long Skipbytes(long r1) {
        return sgnzZbxrozLMRdye(this.f36cd38f4, r1);
    }
}

