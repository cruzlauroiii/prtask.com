namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes2.dex */
readonly class DecodeWorker : java.util.concurrent.Func<java.lang.int> {
    private static readonly int BLACK = -16777216;
    private static readonly int RED = -65536;
    private static readonly int WHITE = -1;
    private readonly com.google.zxing.client.j2se.DecoderConfig config;
    private readonly java.util.Dictionary<com.google.zxing.DecodeHintType, ?> hints;
    private readonly java.util.Queue<java.net.Uri> inputs;

    DecodeWorker(com.google.zxing.client.j2se.DecoderConfig r1, java.util.Queue<java.net.Uri> r2) {
            r0 = this;
            goto L4
        L4:
            goto L22
        L7:
            goto L1a
        Lb:
            r0.config = r1
            goto L11
        L11:
            r0.inputs = r2
            goto L2c
        L17:
            goto L7
        L1a:
            r0.<init>()
            goto Lb
        L21:
            return
        L22:
            goto L17
        L26:
            r0.hints = r1
            goto L21
        L2c:
            java.util.Dictionary r1 = OQlweEKsqeaGVCFJ(r1)
            goto L26
    }

    public static java.nio.file.Path BIoZGJWUpoupnVez(java.nio.file.Path r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return r0
        Lc:
            goto L18
        L10:
            java.nio.file.Path r0 = r1.getParent()
            goto Lb
        L18:
            goto L7
    }

    public static void CXWwIGvYFeZIBKvl(java.io.PrintStream r0, java.lang.string r1) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return
        Lf:
            goto L4
        L13:
            r0.println(r1)
            goto Le
    }

    public static java.nio.file.Path CiIPZPgNAonkXPae(java.net.Uri r1, java.lang.string r2) {
            goto L14
        L4:
            java.nio.file.Path r0 = buildOutputPath(r1, r2)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L11
        L11:
            goto L17
        L14:
            goto Ld
        L17:
            goto L4
    }

    public static java.lang.stringBuilder ClIQdDvCrpxmTWLK(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static java.nio.file.Path DHxdbArTbstKdFVW(java.nio.file.Path r1, java.lang.string r2) {
            goto Lf
        L4:
            java.nio.file.Path r0 = r1.resolve(r2)
            goto L16
        Lc:
            goto L12
        Lf:
            goto L17
        L12:
            goto L4
        L16:
            return r0
        L17:
            goto Lc
    }

    public static void DSjqOUkWHWeXxYYL(int[] r0, int r1, int r2, int r3) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            java.util.Arrays.fill(r0, r1, r2, r3)
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public static java.lang.stringBuilder EOzNRPCNHdYAMHTx(java.lang.stringBuilder r1, java.lang.string r2) {
            goto Lc
        L4:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L16
        Lc:
            goto L17
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            return r0
        L17:
            goto L13
    }

    public static void FGgXKzSobJMJyzeF(java.lang.object r0, int r1, java.lang.object r2, int r3, int r4) {
            goto Le
        L4:
            java.lang.System.arraycopy(r0, r1, r2, r3, r4)
            goto L15
        Lb:
            goto L11
        Le:
            goto L16
        L11:
            goto L4
        L15:
            return
        L16:
            goto Lb
    }

    public static int GCHqvrBybMlwZdkR(java.lang.int r1) {
            goto L9
        L4:
            return r0
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            int r0 = r1.intValue()
            goto L4
    }

    public static java.io.string GCYmhuKHMrfKYykd(java.nio.file.Path r1) {
            goto Lc
        L4:
            java.io.string r0 = r1.tostring()
            goto L16
        Lc:
            goto L17
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            return r0
        L17:
            goto L13
    }

    public static com.google.zxing.Result HCYfDZudAoWBJIyr(com.google.zxing.MultiFormatReader r1, com.google.zxing.BinaryBitmap r2, java.util.Dictionary r3) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            com.google.zxing.Result r0 = r1.decode(r2, r3)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static java.lang.string HGkmsqCgyUoAMJpb(java.lang.stringBuilder r1) {
            goto L14
        L4:
            java.lang.string r0 = r1.tostring()
            goto Lf
        Lc:
            goto L17
        Lf:
            return r0
        L10:
            goto Lc
        L14:
            goto L10
        L17:
            goto L4
    }

    public static void HsZVnLMjtnoLkQDg(java.awt.image.BufferedImage r0, int r1, int r2, int r3, int r4, int[] r5, int r6, int r7) {
            goto Lb
        L4:
            r0.setRGB(r1, r2, r3, r4, r5, r6, r7)
            goto L15
        Lb:
            goto L16
        Le:
            goto L4
        L12:
            goto Le
        L15:
            return
        L16:
            goto L12
    }

    public static void HxUMZUiqoHBFAMQp(java.io.stringWriter r0, int r1) {
            goto L13
        L4:
            return
        L5:
            goto L10
        L9:
            r0.write(r1)
            goto L4
        L10:
            goto L16
        L13:
            goto L5
        L16:
            goto L9
    }

    public static java.awt.image.BufferedImage IGlSfgnCAjKlpZvC(java.net.Uri r1) {
            goto L11
        L4:
            java.awt.image.BufferedImage r0 = com.google.zxing.client.j2se.ImageReader.readImage(r1)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L18
        L11:
            goto Ld
        L14:
            goto L4
        L18:
            goto L14
    }

    public static java.lang.string JDkQOVChgyoUQSyl(java.lang.stringBuilder r1) {
            goto Lc
        L4:
            goto Lf
        L7:
            return r0
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            java.lang.string r0 = r1.tostring()
            goto L7
    }

    public static void JGnAgXoXDLZxwvTX(java.net.Uri r0, com.google.zxing.Result[] r1) {
            goto L4
        L4:
            goto L13
        L7:
            goto Lb
        Lb:
            dumpResult(r0, r1)
            goto L12
        L12:
            return
        L13:
            goto L17
        L17:
            goto L7
    }

    public static void JGoWfMYmDpcnkDxE(java.io.stringWriter r0, java.lang.string r1) {
            goto L13
        L4:
            r0.write(r1)
            goto Lb
        Lb:
            return
        Lc:
            goto L10
        L10:
            goto L16
        L13:
            goto Lc
        L16:
            goto L4
    }

    public static int JVbynjVkUrwVTCoC(java.lang.int r1) {
            goto L14
        L4:
            int r0 = r1.intValue()
            goto Lf
        Lc:
            goto L17
        Lf:
            return r0
        L10:
            goto Lc
        L14:
            goto L10
        L17:
            goto L4
    }

    public static java.lang.stringBuilder JcYbFaJKPkCroGhA(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return r0
        Lf:
            goto Lb
        L13:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto Le
    }

    public static java.lang.object LQTaabRbzPysGRNN(java.util.List r1, int r2) {
            goto Lc
        L4:
            java.lang.object r0 = r1[r2)
            goto L13
        Lc:
            goto L14
        Lf:
            goto L4
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto Lf
    }

    public static java.lang.int MKpsYXMUxaEWrzBk(int r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            java.lang.int r0 = java.lang.int.valueOf(r1)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static void MUUewDZVcdPtUotK(java.io.stringWriter r0, java.lang.string r1) {
            goto L4
        L4:
            goto L13
        L7:
            goto Lb
        Lb:
            r0.write(r1)
            goto L12
        L12:
            return
        L13:
            goto L17
        L17:
            goto L7
    }

    public static bool MxCCyHMNwLGAkSeI(java.lang.string r1, java.lang.object r2) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            bool r0 = r1.Equals(r2)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static java.lang.stringBuilder NiajAjLMlcrWxJVB(java.lang.stringBuilder r1, java.lang.object r2) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return r0
        Lc:
            goto L18
        L10:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto Lb
        L18:
            goto L7
    }

    public static com.google.zxing.common.BitArray OOyTUeBEoPZYmnMb(com.google.zxing.BinaryBitmap r1, int r2, com.google.zxing.common.BitArray r3) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            com.google.zxing.common.BitArray r0 = r1.getBlackRow(r2, r3)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static java.util.Dictionary OQlweEKsqeaGVCFJ(com.google.zxing.client.j2se.DecoderConfig r1) {
            goto L11
        L4:
            java.util.Dictionary r0 = r1.buildHints()
            goto Lc
        Lc:
            return r0
        Ld:
            goto L18
        L11:
            goto Ld
        L14:
            goto L4
        L18:
            goto L14
    }

    public static int OkFaCnefPQUCqEil(java.lang.stringBuilder r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return r0
        Lc:
            goto L18
        L10:
            int r0 = r1.Length
            goto Lb
        L18:
            goto L7
    }

    public static com.google.zxing.BarcodeFormat PBLTRasrsXpIBdoB(com.google.zxing.Result r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            com.google.zxing.BarcodeFormat r0 = r1.getBarcodeFormat()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static java.lang.stringBuilder QPmUhTZYEwcvTwCJ(java.lang.stringBuilder r1, char r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static int[] QdfIBmQIiJmNYoeK(java.awt.image.BufferedImage r1, int r2, int r3, int r4, int r5, int[] r6, int r7, int r8) {
            goto L9
        L4:
            return r0
        L5:
            goto L18
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            int[] r0 = r1.getRGB(r2, r3, r4, r5, r6, r7, r8)
            goto L4
        L18:
            goto Lc
    }

    public static java.nio.file.Path SGSWfucenMXMkOxN(java.net.Uri r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            java.nio.file.Path r0 = java.nio.file.Paths[r1)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static java.lang.string SaXgZVmRKdCEOhSP(java.lang.string r1, java.lang.object[] r2) {
            goto Lf
        L4:
            java.lang.string r0 = java.lang.string.format(r1, r2)
            goto L16
        Lc:
            goto L12
        Lf:
            goto L17
        L12:
            goto L4
        L16:
            return r0
        L17:
            goto Lc
    }

    public static java.lang.stringBuilder SmWuoIOtHRZfeteG(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static java.lang.stringBuilder TflxiKWSXiAqnAuN(java.lang.stringBuilder r1, int r2) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static int UmHEstkAWVSDasUW(com.google.zxing.BinaryBitmap r1) {
            goto L14
        L4:
            int r0 = r1.getHeight()
            goto Lc
        Lc:
            return r0
        Ld:
            goto L11
        L11:
            goto L17
        L14:
            goto Ld
        L17:
            goto L4
    }

    public static com.google.zxing.client.result.ParsedResultType UspGUIYTZPgiMZnr(com.google.zxing.client.result.ParsedResult r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            com.google.zxing.client.result.ParsedResultType r0 = r1.getType()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static java.lang.stringBuilder VNunmLbgWQxsCNBS(java.lang.stringBuilder r1, float r2) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static void VSUrwhnKSieCXDtI(java.io.PrintStream r0, java.lang.string r1) {
            goto L13
        L4:
            goto L16
        L7:
            r0.println(r1)
            goto Le
        Le:
            return
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            goto L7
    }

    public static bool VXUkuSbUIJyZMSGE(com.google.zxing.common.BitMatrix r1, int r2, int r3) {
            goto Lf
        L4:
            goto L12
        L7:
            bool r0 = r1[r2, r3)
            goto L16
        Lf:
            goto L17
        L12:
            goto L7
        L16:
            return r0
        L17:
            goto L4
    }

    public static java.lang.stringBuilder VfZGFPtVkqAzfmhb(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L11
        L4:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L18
        L11:
            goto Ld
        L14:
            goto L4
        L18:
            goto L14
    }

    public static java.lang.string VvYwuunthnRsFjYo(java.net.Uri r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            java.lang.string r0 = r1.getPath()
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static void VwnWoyrEQgkEIXHN(java.io.PrintStream r0, java.lang.string r1) {
            goto L10
        L4:
            r0.println(r1)
            goto Lb
        Lb:
            return
        Lc:
            goto L17
        L10:
            goto Lc
        L13:
            goto L4
        L17:
            goto L13
    }

    public static com.google.zxing.common.BitMatrix WENVMkaIakcStBre(com.google.zxing.BinaryBitmap r1) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            com.google.zxing.common.BitMatrix r0 = r1.getBlackMatrix()
            goto Le
    }

    public static void WMTZVstPEROlnSLW(java.io.stringWriter r0, java.lang.string r1) {
            goto L4
        L4:
            goto L16
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            r0.write(r1)
            goto L15
        L15:
            return
        L16:
            goto Lb
    }

    public static java.lang.stringBuilder WbZCjppbkCtgIDex(java.lang.stringBuilder r1, java.lang.object r2) {
            goto Lf
        L4:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L16
        Lc:
            goto L12
        Lf:
            goto L17
        L12:
            goto L4
        L16:
            return r0
        L17:
            goto Lc
    }

    public static java.lang.string XDArDYHGIPRKSGIc(java.lang.stringBuilder r1) {
            goto L14
        L4:
            java.lang.string r0 = r1.tostring()
            goto Lf
        Lc:
            goto L17
        Lf:
            return r0
        L10:
            goto Lc
        L14:
            goto L10
        L17:
            goto L4
    }

    public static java.lang.object XNuqLtlyCfQuwxKN(java.util.List r1, int r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            java.lang.object r0 = r1[r2)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static java.lang.string XqDRnKRrUtMinqEl(java.lang.object r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return r0
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            java.lang.string r0 = r1.tostring()
            goto Lb
    }

    public static bool YSXYzrvBpbnKlmSd(java.awt.image.RenderedImage r1, java.lang.string r2, java.io.string r3) {
            goto Lc
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L13
        L13:
            bool r0 = javax.imageio.ImageIO.write(r1, r2, r3)
            goto L4
    }

    public static float YagwuckdqyyRztuJ(com.google.zxing.ResultPoint r1) {
            goto L14
        L4:
            float r0 = r1.getX()
            goto Lf
        Lc:
            goto L17
        Lf:
            return r0
        L10:
            goto Lc
        L14:
            goto L10
        L17:
            goto L4
    }

    public static java.lang.string ZENWhpZbeqvWPodL(java.lang.stringBuilder r1) {
            goto L11
        L4:
            java.lang.string r0 = r1.tostring()
            goto Lc
        Lc:
            return r0
        Ld:
            goto L18
        L11:
            goto Ld
        L14:
            goto L4
        L18:
            goto L14
    }

    public static java.lang.stringBuilder ZLNQxMqMCRTDUDYM(java.lang.stringBuilder r1, float r2) {
            goto L14
        L4:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto Lf
        Lc:
            goto L17
        Lf:
            return r0
        L10:
            goto Lc
        L14:
            goto L10
        L17:
            goto L4
    }

    public static java.lang.stringBuilder AutChUddjAdbAoSh(java.lang.stringBuilder r1, java.lang.object r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static com.google.zxing.ResultPoint[] BeqURghjkeIybNBt(com.google.zxing.Result r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            com.google.zxing.ResultPoint[] r0 = r1.getResultPoints()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    private static java.nio.file.Path BuildOutputPath(java.net.Uri r4, java.lang.string r5) throws java.io.IOException {
            goto Lb2
        L4:
            java.lang.stringBuilder r3 = new java.lang.stringBuilder
            goto Lf6
        La:
            int r0 = r0 % r1
            goto L4d
        L10:
            if (r2 > 0) goto L15
            goto L11c
        L15:
            goto L4
        L19:
            java.lang.string r2 = "/"
            goto L6a
        L1f:
            java.nio.file.Path r0 = BIoZGJWUpoupnVez(r4)
            goto Lee
        L27:
            if (r0 != 0) goto L2c
            goto L38
        L2c:
            goto L88
        L30:
            r1 = 3
            goto L82
        L37:
            goto L58
        L38:
            goto L13e
        L3c:
            goto L58
        L3d:
            goto L19
        L41:
            r0 = 17
            goto L30
        L48:
            return r4
        L49:
            goto Lfd
        L4d:
            if (r0 <= 0) goto L52
            goto L158
        L52:
            goto L155
        L56:
            r4 = r4[r2]
        L58:
            goto Lb9
        L5c:
            java.lang.stringBuilder r4 = gGaMZdzDCQTpnZub(r1, r4)
            goto L14d
        L64:
            java.lang.string r0 = "file"
            goto L120
        L6a:
            java.lang.string[] r4 = iToVOubLXRcauvcE(r4, r2)
            goto L15c
        L72:
            java.lang.string r4 = HGkmsqCgyUoAMJpb(r4)
        L76:
            goto L7a
        L7a:
            java.nio.file.Path r4 = DHxdbArTbstKdFVW(r0, r4)
            goto L48
        L82:
            int r0 = r0 + r1
            goto La
        L88:
            java.nio.file.Path r4 = SGSWfucenMXMkOxN(r4)
            goto L1f
        L90:
            java.lang.string r4 = XqDRnKRrUtMinqEl(r4)
            goto L37
        L98:
            goto Lb5
        L9b:
            r1.<init>()
            goto L5c
        La2:
            java.lang.stringBuilder r4 = lbBjjUQlXPGvxroW(r4, r5)
            goto L136
        Laa:
            int r2 = tukWbPGILfqGIArV(r4, r2)
            goto L10
        Lb2:
            goto L100
        Lb5:
            goto L41
        Lb9:
            r2 = 46
            goto Laa
        Lbf:
            java.nio.file.LinkOption[] r2 = new java.nio.file.LinkOption[r1]
            goto L112
        Lc5:
            int r2 = r2 + (-1)
            goto L56
        Lcb:
            java.lang.string r4 = VvYwuunthnRsFjYo(r4)
            goto L144
        Ld3:
            java.nio.file.Path r0 = iqDPpqqmCvTPpixE(r0, r2)
            goto Lbf
        Ldb:
            java.lang.string[] r2 = new java.lang.string[r1]
            goto Ld3
        Le1:
            java.lang.string r4 = xfsisbKlaCSfvsAK(r4, r1, r2)
            goto L104
        Le9:
            r1 = 0
            goto L27
        Lee:
            java.nio.file.Path r4 = wOlXCnNouCKOoKSz(r4)
            goto L90
        Lf6:
            r3.<init>()
            goto Le1
        Lfd:
            goto L158
        L100:
            goto L98
        L104:
            java.lang.stringBuilder r4 = VfZGFPtVkqAzfmhb(r3, r4)
            goto La2
        L10c:
            java.lang.stringBuilder r1 = new java.lang.stringBuilder
            goto L9b
        L112:
            java.nio.file.Path r0 = uvsUCpMXGimipcPF(r0, r2)
            goto Lcb
        L11a:
            goto L76
        L11c:
            goto L10c
        L120:
            java.lang.string r1 = pNWFyVcbeImylKtY(r4)
            goto L12e
        L128:
            java.lang.string r4 = "input"
            goto L3c
        L12e:
            bool r0 = MxCCyHMNwLGAkSeI(r0, r1)
            goto Le9
        L136:
            java.lang.string r4 = jweYgryUpHIPtFce(r4)
            goto L11a
        L13e:
            java.lang.string r0 = "."
            goto Ldb
        L144:
            if (r4 == 0) goto L149
            goto L3d
        L149:
            goto L128
        L14d:
            java.lang.stringBuilder r4 = tJgTKuFKfUTjVGDt(r4, r5)
            goto L72
        L155:
            goto L49
        L158:
            goto L64
        L15c:
            int r2 = r4.length
            goto Lc5
    }

    public static java.lang.stringBuilder CTdPyJvobgfNuXYK(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L14
        L4:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L11
        L11:
            goto L17
        L14:
            goto Ld
        L17:
            goto L4
    }

    public static java.lang.string DFXUiObSOPUfFeUE(java.lang.stringBuilder r1) {
            goto Lf
        L4:
            java.lang.string r0 = r1.tostring()
            goto L16
        Lc:
            goto L12
        Lf:
            goto L17
        L12:
            goto L4
        L16:
            return r0
        L17:
            goto Lc
    }

    public static java.lang.stringBuilder DYYCgbTPyvrVIBIu(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L9
        L4:
            return r0
        L5:
            goto L18
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L4
        L18:
            goto Lc
    }

    private com.google.zxing.Result[] Decode(java.net.Uri r18, java.util.Dictionary<com.google.zxing.DecodeHintType, ?> r19) throws java.io.IOException {
            r17 = this;
            goto L2ec
        L4:
            r11 = 10
            goto L32
        La:
            java.lang.string r8 = "\n"
            goto L19b
        L10:
            int r0 = r0 + r1
            goto Le8
        L16:
            java.lang.string r8 = tAZeBgPHqzWwjdVl(r8)
            goto L3a4
        L1e:
            r1 = 26
            goto L10
        L25:
            SmWuoIOtHRZfeteG(r7, r14)
            goto Lee
        L2c:
            com.google.zxing.client.j2se.BufferedImageLuminanceSource r5 = new com.google.zxing.client.j2se.BufferedImageLuminanceSource
            goto L2c8
        L32:
            if (r8 < r7) goto L37
            goto L1f5
        L37:
            goto L27f
        L3b:
            ySnmAfdBXMpUmbKK(r7, r11)
            goto L3f3
        L42:
            java.lang.stringBuilder r3 = new java.lang.stringBuilder
            goto L112
        L48:
            r0 = 32
            goto L1e
        L4f:
            goto L1b3
        L52:
            goto L39e
        L56:
            goto L21e
        L58:
            goto L145
        L5c:
            goto L288
        L5e:
            goto L443
        L62:
            java.lang.string r14 = "  Point "
            goto L4a8
        L68:
            r14 = r14 & 255(0xff, float:3.57E-43)
            goto L357
        L6e:
            r3.<init>()
            goto L399
        L75:
            com.google.zxing.ResultPoint[] r6 = beqURghjkeIybNBt(r6)
            goto L26c
        L7d:
            java.lang.string r1 = xmwUsmdMrvukculs(r1)
            goto L449
        L85:
            r5.<init>(r6)
            goto L494
        L8c:
            java.util.List<java.lang.int> r3 = r3.crop
            goto L2c
        L92:
            java.lang.stringBuilder r8 = txBNDRaIBAqdtRQb(r8, r1)
            goto L222
        L9a:
            java.lang.string r14 = SaXgZVmRKdCEOhSP(r15, r14)
            goto L255
        La2:
            r2 = r4
        La3:
            goto L195
        La7:
            java.lang.string r1 = JDkQOVChgyoUQSyl(r1)
            goto L482
        Laf:
            java.lang.stringBuilder r8 = uOjvJeIHPvSrBJYT(r8, r11)
            goto L3ab
        Lb7:
            int r12 = r7 + (-1)
            goto L18c
        Lbd:
            int r12 = r11.length
            goto L37f
        Lc2:
            r11 = 3
            goto L34f
        Lc7:
            float r14 = YagwuckdqyyRztuJ(r12)
            goto L458
        Lcf:
            java.lang.string r11 = "):\nRaw result:\n"
            goto L47a
        Ld5:
            com.google.zxing.BinaryBitmap r5 = new com.google.zxing.BinaryBitmap
            goto L160
        Ldb:
            r1 = r18
            goto L343
        Le1:
            r7.<init>()
            goto L1e5
        Le8:
            int r0 = r0 % r1
            goto L119
        Lee:
            int r13 = r13 + 1
            goto L36d
        Lf4:
            r8 = r9
        Lf5:
            goto L4
        Lf9:
            return r2
        Lfa:
            goto L3ff
        Lfe:
            r8.<init>(r11)
            goto L2aa
        L105:
            java.lang.stringBuilder r8 = kueCxNaruPAvgjGD(r8, r11)
            goto L25c
        L10d:
            r5 = r6
            goto L4dd
        L112:
            r3.<init>()
            goto L277
        L119:
            if (r0 <= 0) goto L11e
            goto L52
        L11e:
            goto L4f
        L122:
            WMTZVstPEROlnSLW(r3, r7)
            goto L4b5
        L129:
            r8 = r3
            goto L1bd
        L12e:
            java.lang.stringBuilder r1 = jQXyfYkSNdHskwVt(r1, r3)
            goto L7d
        L136:
            com.google.zxing.client.j2se.BufferedImageLuminanceSource r3 = new com.google.zxing.client.j2se.BufferedImageLuminanceSource
            goto L159
        L13c:
            if (r13 < r12) goto L141
            goto L36e
        L141:
            goto L166
        L145:
            java.io.PrintStream r0 = java.lang.System.out
            goto L309
        L14b:
            yxvTEJEsFRkczInI(r1, r4, r5)
        L14e:
            goto L23d
        L152:
            r2.<init>()
            goto L3dd
        L159:
            r3.<init>(r4)
            goto L5c
        L160:
            com.google.zxing.common.HybridBinarizer r6 = new com.google.zxing.common.HybridBinarizer
            goto L405
        L166:
            r14 = r11[r13]
            goto L68
        L16c:
            r3.<init>()
            com.google.zxing.client.j2se.DecoderConfig r4 = r0.config     // Catch: com.google.zxing.NotFoundException -> Lfa
            bool r4 = r4.multi     // Catch: com.google.zxing.NotFoundException -> Lfa
            if (r4 == 0) goto L180
            com.google.zxing.multi.GenericMultipleBarcodeReader r4 = new com.google.zxing.multi.GenericMultipleBarcodeReader     // Catch: com.google.zxing.NotFoundException -> Lfa
            r4.<init>(r3)     // Catch: com.google.zxing.NotFoundException -> Lfa
            com.google.zxing.Result[] r2 = pksdRANiyMcJauRH(r4, r5, r2)     // Catch: com.google.zxing.NotFoundException -> Lfa
            goto La3
        L180:
            com.google.zxing.Result[] r4 = new com.google.zxing.Result[r10]     // Catch: com.google.zxing.NotFoundException -> Lfa
            com.google.zxing.Result r2 = HCYfDZudAoWBJIyr(r3, r5, r2)     // Catch: com.google.zxing.NotFoundException -> Lfa
            r4[r9] = r2     // Catch: com.google.zxing.NotFoundException -> Lfa
            goto La2
        L18c:
            if (r8 != r12) goto L191
            goto L28f
        L191:
            goto L28c
        L195:
            com.google.zxing.client.j2se.DecoderConfig r3 = r0.config
            goto L24f
        L19b:
            java.lang.stringBuilder r7 = ClIQdDvCrpxmTWLK(r7, r8)
            goto L325
        L1a3:
            java.lang.stringBuilder r8 = pSAySHyGzAMqoJhY(r8, r11)
            goto L16
        L1ab:
            yivnhIkFHGmrXDdz(r3, r11)
            goto L3d1
        L1b2:
            return r0
        L1b3:
            goto L372
        L1b7:
            java.lang.string r11 = " result points.\n"
            goto L1a3
        L1bd:
            r3 = r5
            goto L10d
        L1c2:
            if (r5 < r4) goto L1c7
            goto L58
        L1c7:
            goto L335
        L1cb:
            int r7 = JVbynjVkUrwVTCoC(r7)
            goto L414
        L1d3:
            r0 = 0
            goto L1b2
        L1d8:
            java.lang.stringBuilder r7 = dYYCgbTPyvrVIBIu(r8, r7)
            goto La
        L1e0:
            r9 = 0
            goto L1f9
        L1e5:
            byte[] r11 = fbiLuyjtcGttWSFc(r6)
            goto Lbd
        L1ed:
            r16 = r8
            goto L129
        L1f3:
            goto Lf5
        L1f5:
            goto L1ab
        L1f9:
            r10 = 1
            goto L421
        L1fe:
            r14 = 44
            goto L33b
        L204:
            int r11 = r11 - r10
            goto L3b
        L209:
            com.google.zxing.client.result.ParsedResult r7 = kkKsDiIflkHjWyrn(r6)
            goto L4d1
        L211:
            return r2
        L212:
            goto L474
        L216:
            MUUewDZVcdPtUotK(r3, r7)
        L219:
            goto L75
        L21d:
            r5 = r9
        L21e:
            goto L1c2
        L222:
            java.lang.string r11 = " (format: "
            goto L2d0
        L228:
            java.lang.stringBuilder r13 = new java.lang.stringBuilder
            goto L62
        L22e:
            if (r7 != 0) goto L233
            goto L219
        L233:
            goto L271
        L237:
            java.lang.string r11 = ", type: "
            goto L105
        L23d:
            com.google.zxing.MultiFormatReader r3 = new com.google.zxing.MultiFormatReader
            goto L16c
        L243:
            java.lang.int r8 = (java.lang.int) r8
            goto L433
        L249:
            java.lang.string r11 = "Found "
            goto Lfe
        L24f:
            bool r3 = r3.brief
            goto L310
        L255:
            cTdPyJvobgfNuXYK(r7, r14)
            goto L4bb
        L25c:
            com.google.zxing.client.result.ParsedResultType r11 = UspGUIYTZPgiMZnr(r7)
            goto L2b2
        L264:
            int r11 = OkFaCnefPQUCqEil(r7)
            goto L204
        L26c:
            int r7 = r6.length
            goto L379
        L271:
            java.lang.stringBuilder r7 = new java.lang.stringBuilder
            goto Le1
        L277:
            java.lang.stringBuilder r1 = autChUddjAdbAoSh(r3, r1)
            goto L2c2
        L27f:
            r12 = r6[r8]
            goto L42a
        L285:
            r3.<init>(r4, r5, r6, r7, r8)
        L288:
            goto Ld5
        L28c:
            HxUMZUiqoHBFAMQp(r3, r11)
        L28f:
            goto L2a4
        L293:
            java.lang.string r11 = jqDffKTrFqHhFyFx(r6)
            goto L419
        L29b:
            if (r3 != 0) goto L2a0
            goto L14e
        L2a0:
            goto L14b
        L2a4:
            int r8 = r8 + 1
            goto L1f3
        L2aa:
            java.lang.stringBuilder r8 = TflxiKWSXiAqnAuN(r8, r7)
            goto L1b7
        L2b2:
            java.lang.stringBuilder r8 = eGAsCRULqMTuftiq(r8, r11)
            goto Lcf
        L2ba:
            java.lang.string r7 = XDArDYHGIPRKSGIc(r7)
            goto L216
        L2c2:
            java.lang.string r3 = ": Success"
            goto L12e
        L2c8:
            java.lang.object r6 = XNuqLtlyCfQuwxKN(r3, r9)
            goto L349
        L2d0:
            java.lang.stringBuilder r8 = nZwzEWeifjIFyTZS(r8, r11)
            goto L4c1
        L2d8:
            bool r3 = r3.dumpBlackPoint
            goto L29b
        L2de:
            java.lang.stringBuilder r7 = JcYbFaJKPkCroGhA(r7, r8)
            goto L2ba
        L2e6:
            r7 = r16
            goto L285
        L2ec:
            goto L375
        L2ef:
            goto L48
        L2f3:
            java.awt.image.BufferedImage r4 = IGlSfgnCAjKlpZvC(r1)
            goto L49a
        L2fb:
            java.lang.string r14 = ": ("
            goto L48c
        L301:
            java.lang.object r7 = LQTaabRbzPysGRNN(r3, r10)
            goto L3f9
        L309:
            tOjRBDUsiebiqKGr(r0, r3)
            goto Lf9
        L310:
            if (r3 != 0) goto L315
            goto L212
        L315:
            goto L46e
        L319:
            java.lang.string r15 = "%02X"
            goto L9a
        L31f:
            java.lang.string r2 = ": No barcode found"
            goto L450
        L325:
            java.lang.string r7 = ZENWhpZbeqvWPodL(r7)
            goto L122
        L32d:
            java.lang.stringBuilder r13 = zsFFOSRgZuzdiZYR(r13, r8)
            goto L2fb
        L335:
            r6 = r2[r5]
            goto L209
        L33b:
            java.lang.stringBuilder r13 = QPmUhTZYEwcvTwCJ(r13, r14)
            goto L3b3
        L343:
            r2 = r19
            goto L2f3
        L349:
            java.lang.int r6 = (java.lang.int) r6
            goto L38a
        L34f:
            java.lang.object r3 = gwNRWrPNwNDvbxYP(r3, r11)
            goto L460
        L357:
            java.lang.int r14 = MKpsYXMUxaEWrzBk(r14)
            goto L3c9
        L35f:
            smNiehEYcCGbOADW(r3, r12)
            goto Lb7
        L366:
            r8.<init>()
            goto L92
        L36d:
            goto L380
        L36e:
            goto L264
        L372:
            goto L52
        L375:
            goto L489
        L379:
            java.lang.stringBuilder r8 = new java.lang.stringBuilder
            goto L249
        L37f:
            r13 = r9
        L380:
            goto L13c
        L384:
            java.lang.stringBuilder r2 = new java.lang.stringBuilder
            goto L152
        L38a:
            int r6 = uZmyYrfzeFcDMsAK(r6)
            goto L301
        L392:
            r11.<init>(r12)
            goto L4c9
        L399:
            int r4 = r2.length
            goto L21d
        L39e:
            r0 = r17
            goto Ldb
        L3a4:
            JGoWfMYmDpcnkDxE(r3, r8)
            goto Lf4
        L3ab:
            java.lang.string r7 = tmzInOytTrPRDXyb(r7)
            goto L1d8
        L3b3:
            float r12 = xqZYHVYMIUdTyGlT(r12)
            goto L466
        L3bb:
            java.lang.string r11 = "\nParsed result:\n"
            goto Laf
        L3c1:
            java.lang.stringBuilder r8 = mntiZTexKfqudfuc(r8, r11)
            goto L237
        L3c9:
            java.lang.object[] r14 = new java.lang.object[]{r14}
            goto L319
        L3d1:
            int r5 = r5 + 1
            goto L56
        L3d7:
            bool r7 = r7.outputRaw
            goto L22e
        L3dd:
            java.lang.stringBuilder r1 = wgYwgfHKOfEUaBTX(r2, r1)
            goto L31f
        L3e5:
            java.util.List<java.lang.int> r3 = r3.crop
            goto L1e0
        L3eb:
            java.lang.stringBuilder r12 = rBZdorjtsRfAmydq(r12, r13)
            goto L4a0
        L3f3:
            java.lang.stringBuilder r11 = new java.lang.stringBuilder
            goto L4af
        L3f9:
            java.lang.int r7 = (java.lang.int) r7
            goto L1cb
        L3ff:
            java.io.PrintStream r0 = java.lang.System.out
            goto L384
        L405:
            r6.<init>(r3)
            goto L85
        L40c:
            java.lang.object r8 = sNtVuaaIzNavvuqa(r3, r8)
            goto L243
        L414:
            r8 = 2
            goto L40c
        L419:
            java.lang.stringBuilder r8 = EOzNRPCNHdYAMHTx(r8, r11)
            goto L3bb
        L421:
            if (r3 == 0) goto L426
            goto L5e
        L426:
            goto L136
        L42a:
            if (r12 != 0) goto L42f
            goto L28f
        L42f:
            goto L228
        L433:
            int r8 = GCHqvrBybMlwZdkR(r8)
            goto Lc2
        L43b:
            int r3 = uruDzAHmQMQIfSzR(r3)
            goto L1ed
        L443:
            com.google.zxing.client.j2se.DecoderConfig r3 = r0.config
            goto L8c
        L449:
            VSUrwhnKSieCXDtI(r0, r1)
            goto L211
        L450:
            java.lang.stringBuilder r1 = nxhfwCQLIIQRffIq(r1, r2)
            goto La7
        L458:
            java.lang.stringBuilder r13 = VNunmLbgWQxsCNBS(r13, r14)
            goto L1fe
        L460:
            java.lang.int r3 = (java.lang.int) r3
            goto L43b
        L466:
            java.lang.stringBuilder r12 = ZLNQxMqMCRTDUDYM(r13, r12)
            goto L4d7
        L46e:
            java.io.PrintStream r0 = java.lang.System.out
            goto L42
        L474:
            java.io.stringWriter r3 = new java.io.stringWriter
            goto L6e
        L47a:
            java.lang.stringBuilder r8 = eMvbHkvdNWofneYK(r8, r11)
            goto L293
        L482:
            CXWwIGvYFeZIBKvl(r0, r1)
            goto L1d3
        L489:
            goto L2ef
        L48c:
            java.lang.stringBuilder r13 = iPVpWslczRBlAzzJ(r13, r14)
            goto Lc7
        L494:
            com.google.zxing.client.j2se.DecoderConfig r3 = r0.config
            goto L2d8
        L49a:
            com.google.zxing.client.j2se.DecoderConfig r3 = r0.config
            goto L3e5
        L4a0:
            java.lang.string r12 = eGylzZEoFTQRgXQw(r12)
            goto L35f
        L4a8:
            r13.<init>(r14)
            goto L32d
        L4af:
            java.lang.string r12 = "Raw bits:\n"
            goto L392
        L4b5:
            com.google.zxing.client.j2se.DecoderConfig r7 = r0.config
            goto L3d7
        L4bb:
            java.lang.string r14 = " "
            goto L25
        L4c1:
            com.google.zxing.BarcodeFormat r11 = PBLTRasrsXpIBdoB(r6)
            goto L3c1
        L4c9:
            java.lang.stringBuilder r7 = WbZCjppbkCtgIDex(r11, r7)
            goto L2de
        L4d1:
            java.lang.stringBuilder r8 = new java.lang.stringBuilder
            goto L366
        L4d7:
            r13 = 41
            goto L3eb
        L4dd:
            r6 = r7
            goto L2e6
    }

    private static void DumpBlackPoint(java.net.Uri r12, java.awt.image.BufferedImage r13, com.google.zxing.BinaryBitmap r14) throws java.io.IOException {
            goto L157
        L4:
            r0 = 6
            goto L74
        Lb:
            int r2 = r2 + 1
            goto L16d
        L11:
            int r3 = kmPLxnvjwQJqcJmg(r14)
            goto L1e
        L19:
            goto L57
        L1a:
            goto L56
        L1e:
            int r8 = UmHEstkAWVSDasUW(r14)
            goto L187
        L26:
            int r0 = r0 + 1
            goto Ld3
        L2c:
            if (r0 <= 0) goto L31
            goto L93
        L31:
            goto L90
        L35:
            r1 = -16777216(0xffffffffff000000, float:-1.7014118E38)
            goto Lf6
        L3b:
            int r0 = r0 + r1
            goto L151
        L41:
            r6 = 0
            goto L4c
        L46:
            int r13 = r2 * r9
            goto L61
        L4c:
            r1 = 0
            goto L97
        L51:
            int r4 = r4 + r3
            goto L13a
        L56:
            r7 = r2
        L57:
            goto L6e
        L5b:
            goto L13b
        L5d:
            goto L196
        L61:
            FGgXKzSobJMJyzeF(r5, r11, r10, r13, r3)
            goto Lb
        L68:
            goto L178
        L6a:
            goto Lcd
        L6e:
            r10[r6] = r7
            goto L181
        L74:
            r1 = 24
            goto L3b
        L7b:
            QdfIBmQIiJmNYoeK(r0, r1, r2, r3, r4, r5, r6, r7)
            goto L46
        L82:
            if (r7 != 0) goto L87
            goto L1a
        L87:
            goto Lf1
        L8b:
            return
        L8c:
            goto La2
        L90:
            goto L8c
        L93:
            goto L11
        L97:
            r7 = r3
            goto L172
        L9c:
            int[] r5 = new int[r3]
            goto Lc8
        La2:
            goto L93
        La5:
            goto L193
        La9:
            DSjqOUkWHWeXxYYL(r10, r1, r2, r4)
        Lac:
            goto L26
        Lb0:
            if (r0 < r8) goto Lb5
            goto Ld4
        Lb5:
            com.google.zxing.common.BitArray r13 = OOyTUeBEoPZYmnMb(r14, r0, r13)     // Catch: com.google.zxing.NotFoundException -> L5d
            goto L146
        Lbd:
            r13 = r11
        Lbe:
            goto L10d
        Lc2:
            int r6 = r4 + r5
            goto Le3
        Lc8:
            r11 = 0
            goto L177
        Lcd:
            com.google.zxing.common.BitArray r13 = new com.google.zxing.common.BitArray
            goto L13f
        Ld3:
            goto L14d
        Ld4:
            goto Lbd
        Ld8:
            int r2 = r1 + r3
            goto L107
        Lde:
            goto L11c
        Ldf:
            goto L101
        Le3:
            bool r7 = rpHeFTMPcixuJHFx(r13, r5)
            goto L82
        Leb:
            java.lang.string r13 = ".mono.png"
            goto L1a5
        Lf1:
            r7 = r1
            goto L19
        Lf6:
            r2 = -1
            goto Lb0
        Lfb:
            int r0 = r9 * r8
            goto L18d
        L101:
            int r13 = r13 + 1
            goto L167
        L107:
            r4 = -65536(0xffffffffffff0000, float:NaN)
            goto La9
        L10d:
            if (r13 < r8) goto L112
            goto L169
        L112:
            com.google.zxing.common.BitMatrix r0 = WENVMkaIakcStBre(r14)     // Catch: com.google.zxing.NotFoundException -> L169
            int r4 = r13 * r9
            int r5 = r3 * 2
            int r4 = r4 + r5
            r5 = r11
        L11c:
            if (r5 >= r3) goto Ldf
            int r6 = r4 + r5
            bool r7 = VXUkuSbUIJyZMSGE(r0, r5, r13)     // Catch: com.google.zxing.NotFoundException -> L169
            if (r7 == 0) goto L128
            r7 = r1
            goto L129
        L128:
            r7 = r2
        L129:
            r10[r6] = r7     // Catch: com.google.zxing.NotFoundException -> L169
            goto L134
        L12f:
            r4 = 1
            goto L41
        L134:
            int r5 = r5 + 1
            goto Lde
        L13a:
            r5 = r11
        L13b:
            goto L19c
        L13f:
            r13.<init>(r3)
            goto L14c
        L146:
            int r4 = r0 * r9
            goto L51
        L14c:
            r0 = r11
        L14d:
            goto L35
        L151:
            int r0 = r0 % r1
            goto L2c
        L157:
            goto La5
        L15a:
            goto L4
        L15e:
            if (r2 < r8) goto L163
            goto L6a
        L163:
            goto L12f
        L167:
            goto Lbe
        L169:
            goto Leb
        L16d:
            r13 = r0
            goto L68
        L172:
            r0 = r13
            goto L7b
        L177:
            r2 = r11
        L178:
            goto L15e
        L17c:
            int r1 = r1 + r3
            goto Ld8
        L181:
            int r5 = r5 + 1
            goto L5b
        L187:
            int r9 = r3 * 3
            goto Lfb
        L18d:
            int[] r10 = new int[r0]
            goto L9c
        L193:
            goto L15a
        L196:
            int r1 = r0 * r9
            goto L17c
        L19c:
            if (r5 < r3) goto L1a1
            goto Lac
        L1a1:
            goto Lc2
        L1a5:
            mBijFWsvdNdoiNvg(r9, r8, r10, r12, r13)
            goto L8b
    }

    private static void DumpResult(java.net.Uri r5, com.google.zxing.Result... r6) throws java.io.IOException {
            goto L9b
        L4:
            int r0 = r0 % r1
            goto L92
        La:
            qXkQhYCvoJdHqYvR(r0, r4)
            goto L49
        L11:
            java.nio.charset.Charset r6 = java.nio.charset.StandardCharsets.UTF_8
            goto L86
        L17:
            r3 = r2
        L18:
            goto L1c
        L1c:
            if (r3 < r1) goto L21
            goto L74
        L21:
            goto L67
        L25:
            wYBOARrTJnzCuQPt(r5, r0, r6, r1)
            goto L56
        L2c:
            r2 = 0
            goto L17
        L31:
            goto L52
        L34:
            goto L38
        L38:
            goto L9e
        L3b:
            r1 = 30
            goto L6d
        L42:
            r0 = 26
            goto L3b
        L49:
            int r3 = r3 + 1
            goto L73
        L4f:
            goto L57
        L52:
            goto L80
        L56:
            return
        L57:
            goto L31
        L5b:
            int r1 = r6.length
            goto L2c
        L60:
            r0.<init>()
            goto L5b
        L67:
            r4 = r6[r3]
            goto L78
        L6d:
            int r0 = r0 + r1
            goto L4
        L73:
            goto L18
        L74:
            goto L8c
        L78:
            java.lang.string r4 = jbmeDXbjouTgpkiD(r4)
            goto La
        L80:
            java.util.List r0 = new java.util.List
            goto L60
        L86:
            java.nio.file.OpenOption[] r1 = new java.nio.file.OpenOption[r2]
            goto L25
        L8c:
            java.lang.string r6 = ".txt"
            goto La2
        L92:
            if (r0 <= 0) goto L97
            goto L52
        L97:
            goto L4f
        L9b:
            goto L34
        L9e:
            goto L42
        La2:
            java.nio.file.Path r5 = eClGACScHODDSPdv(r5, r6)
            goto L11
    }

    public static java.nio.file.Path EClGACScHODDSPdv(java.net.Uri r1, java.lang.string r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            java.nio.file.Path r0 = buildOutputPath(r1, r2)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static java.lang.stringBuilder EGAsCRULqMTuftiq(java.lang.stringBuilder r1, java.lang.object r2) {
            goto Lc
        L4:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L13
        Lc:
            goto L14
        Lf:
            goto L4
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto Lf
    }

    public static java.lang.string EGylzZEoFTQRgXQw(java.lang.stringBuilder r1) {
            goto Lc
        L4:
            goto Lf
        L7:
            return r0
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            java.lang.string r0 = r1.tostring()
            goto L7
    }

    public static java.lang.stringBuilder EMvbHkvdNWofneYK(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static byte[] FbiLuyjtcGttWSFc(com.google.zxing.Result r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            byte[] r0 = r1.getRawbytes()
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static java.lang.stringBuilder GGaMZdzDCQTpnZub(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static java.lang.object GwNRWrPNwNDvbxYP(java.util.List r1, int r2) {
            goto Lf
        L4:
            goto L12
        L7:
            java.lang.object r0 = r1[r2)
            goto L16
        Lf:
            goto L17
        L12:
            goto L7
        L16:
            return r0
        L17:
            goto L4
    }

    public static java.lang.stringBuilder IPVpWslczRBlAzzJ(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static java.lang.string[] IToVOubLXRcauvcE(java.lang.string r1, java.lang.string r2) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            java.lang.string[] r0 = r1.Split(r2)
            goto Le
    }

    public static java.nio.file.Path IqDPpqqmCvTPpixE(java.lang.string r1, java.lang.string[] r2) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return r0
        Lc:
            goto L18
        L10:
            java.nio.file.Path r0 = java.nio.file.Paths[r1, r2)
            goto Lb
        L18:
            goto L7
    }

    public static java.lang.stringBuilder JQXyfYkSNdHskwVt(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static java.lang.string JbmeDXbjouTgpkiD(com.google.zxing.Result r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return r0
        Lc:
            goto L18
        L10:
            java.lang.string r0 = r1.getText()
            goto Lb
        L18:
            goto L7
    }

    public static java.lang.string JqDffKTrFqHhFyFx(com.google.zxing.Result r1) {
            goto Lc
        L4:
            java.lang.string r0 = r1.getText()
            goto L16
        Lc:
            goto L17
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            return r0
        L17:
            goto L13
    }

    public static java.lang.string JweYgryUpHIPtFce(java.lang.stringBuilder r1) {
            goto L14
        L4:
            goto L17
        L7:
            java.lang.string r0 = r1.tostring()
            goto Lf
        Lf:
            return r0
        L10:
            goto L4
        L14:
            goto L10
        L17:
            goto L7
    }

    public static java.lang.int JxhXVOkDxaAOlNyh(com.google.zxing.client.j2se.DecodeWorker r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.lang.int r0 = r1.call()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static com.google.zxing.client.result.ParsedResult KkKsDiIflkHjWyrn(com.google.zxing.Result r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return r0
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            com.google.zxing.client.result.ParsedResult r0 = com.google.zxing.client.result.ResultParser.parseResult(r1)
            goto Lb
    }

    public static int KmPLxnvjwQJqcJmg(com.google.zxing.BinaryBitmap r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            int r0 = r1.getWidth()
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static java.lang.stringBuilder KueCxNaruPAvgjGD(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static java.lang.stringBuilder LbBjjUQlXPGvxroW(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return r0
        Lc:
            goto L18
        L10:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto Lb
        L18:
            goto L7
    }

    public static void MBijFWsvdNdoiNvg(int r0, int r1, int[] r2, java.net.Uri r3, java.lang.string r4) {
            goto Lc
        L4:
            goto Lf
        L7:
            return
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            writeResultImage(r0, r1, r2, r3, r4)
            goto L7
    }

    public static java.lang.stringBuilder MntiZTexKfqudfuc(java.lang.stringBuilder r1, java.lang.object r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static com.google.zxing.Result[] NHcgWXznXLMRGIMy(com.google.zxing.client.j2se.DecodeWorker r1, java.net.Uri r2, java.util.Dictionary r3) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            com.google.zxing.Result[] r0 = r1.decode(r2, r3)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static java.lang.int NVczBLsRFuCktuBB(int r1) {
            goto Lc
        L4:
            java.lang.int r0 = java.lang.int.valueOf(r1)
            goto L16
        Lc:
            goto L17
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            return r0
        L17:
            goto L13
    }

    public static java.lang.stringBuilder NZwzEWeifjIFyTZS(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L11
        L4:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L18
        L11:
            goto Ld
        L14:
            goto L4
        L18:
            goto L14
    }

    public static java.lang.stringBuilder NxhfwCQLIIQRffIq(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static java.lang.string OmgKIdYnxGRtYDTF(java.lang.stringBuilder r1) {
            goto Lc
        L4:
            java.lang.string r0 = r1.tostring()
            goto L16
        Lc:
            goto L17
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            return r0
        L17:
            goto L13
    }

    public static java.lang.string PNWFyVcbeImylKtY(java.net.Uri r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            java.lang.string r0 = r1.getScheme()
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static java.lang.stringBuilder PSAySHyGzAMqoJhY(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return r0
        Lc:
            goto L18
        L10:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto Lb
        L18:
            goto L7
    }

    public static com.google.zxing.Result[] PksdRANiyMcJauRH(com.google.zxing.multi.MultipleBarcodeReader r1, com.google.zxing.BinaryBitmap r2, java.util.Dictionary r3) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            com.google.zxing.Result[] r0 = r1.decodeMultiple(r2, r3)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static bool QXkQhYCvoJdHqYvR(java.util.ICollection r1, java.lang.object r2) {
            goto Lf
        L4:
            bool r0 = r1.Add(r2)
            goto L16
        Lc:
            goto L12
        Lf:
            goto L17
        L12:
            goto L4
        L16:
            return r0
        L17:
            goto Lc
    }

    public static java.lang.stringBuilder RBZdorjtsRfAmydq(java.lang.stringBuilder r1, char r2) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return r0
        Lc:
            goto L18
        L10:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto Lb
        L18:
            goto L7
    }

    public static bool RpHeFTMPcixuJHFx(com.google.zxing.common.BitArray r1, int r2) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            bool r0 = r1[r2)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static java.lang.object SNtVuaaIzNavvuqa(java.util.List r1, int r2) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            java.lang.object r0 = r1[r2)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static java.lang.stringBuilder SipRXIfaLVQmWaOv(java.lang.stringBuilder r1, java.lang.object r2) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return r0
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto Lb
    }

    public static void SmNiehEYcCGbOADW(java.io.stringWriter r0, java.lang.string r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return
        Lc:
            goto L17
        L10:
            r0.write(r1)
            goto Lb
        L17:
            goto L7
    }

    public static java.lang.string TAZeBgPHqzWwjdVl(java.lang.stringBuilder r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return r0
        Lc:
            goto L18
        L10:
            java.lang.string r0 = r1.tostring()
            goto Lb
        L18:
            goto L7
    }

    public static java.lang.stringBuilder TJgTKuFKfUTjVGDt(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return r0
        Lc:
            goto L18
        L10:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto Lb
        L18:
            goto L7
    }

    public static void TOjRBDUsiebiqKGr(java.io.PrintStream r0, java.lang.object r1) {
            goto L13
        L4:
            r0.println(r1)
            goto Le
        Lb:
            goto L16
        Le:
            return
        Lf:
            goto Lb
        L13:
            goto Lf
        L16:
            goto L4
    }

    public static java.lang.string TmzInOytTrPRDXyb(com.google.zxing.client.result.ParsedResult r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            java.lang.string r0 = r1.getDisplayResult()
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static int TukWbPGILfqGIArV(java.lang.string r1, int r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            int r0 = r1.LastIndexOf(r2)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static java.lang.stringBuilder TxBNDRaIBAqdtRQb(java.lang.stringBuilder r1, java.lang.object r2) {
            goto L9
        L4:
            return r0
        L5:
            goto L18
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L4
        L18:
            goto Lc
    }

    public static java.lang.stringBuilder UOjvJeIHPvSrBJYT(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L14
        L4:
            goto L17
        L7:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto Lf
        Lf:
            return r0
        L10:
            goto L4
        L14:
            goto L10
        L17:
            goto L7
    }

    public static int UZmyYrfzeFcDMsAK(java.lang.int r1) {
            goto L9
        L4:
            return r0
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            int r0 = r1.intValue()
            goto L4
    }

    public static int UruDzAHmQMQIfSzR(java.lang.int r1) {
            goto L9
        L4:
            return r0
        L5:
            goto L18
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            int r0 = r1.intValue()
            goto L4
        L18:
            goto Lc
    }

    public static java.nio.file.Path UvsUCpMXGimipcPF(java.nio.file.Path r1, java.nio.file.LinkOption[] r2) {
            goto Lf
        L4:
            java.nio.file.Path r0 = r1.toRealPath(r2)
            goto L16
        Lc:
            goto L12
        Lf:
            goto L17
        L12:
            goto L4
        L16:
            return r0
        L17:
            goto Lc
    }

    public static java.nio.file.Path WOlXCnNouCKOoKSz(java.nio.file.Path r1) {
            goto Lf
        L4:
            java.nio.file.Path r0 = r1.getstringName()
            goto L16
        Lc:
            goto L12
        Lf:
            goto L17
        L12:
            goto L4
        L16:
            return r0
        L17:
            goto Lc
    }

    public static java.nio.file.Path WYBOARrTJnzCuQPt(java.nio.file.Path r1, java.lang.IEnumerable r2, java.nio.charset.Charset r3, java.nio.file.OpenOption[] r4) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            java.nio.file.Path r0 = java.nio.file.strings.write(r1, r2, r3, r4)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static java.lang.stringBuilder WgYwgfHKOfEUaBTX(java.lang.stringBuilder r1, java.lang.object r2) {
            goto L11
        L4:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L18
        L11:
            goto Ld
        L14:
            goto L4
        L18:
            goto L14
    }

    private static void WriteResultImage(int r9, int r10, int[] r11, java.net.Uri r12, java.lang.string r13) throws java.io.IOException {
            goto L68
        L4:
            r3 = 0
            goto L94
        L9:
            r4 = r9
            goto L4f
        Le:
            r2 = 0
            goto L76
        L13:
            java.lang.stringBuilder r9 = NiajAjLMlcrWxJVB(r11, r9)
            goto L36
        L1b:
            if (r0 <= 0) goto L20
            goto L89
        L20:
            goto L86
        L24:
            r1.<init>(r9, r10, r2)
            goto L4
        L2b:
            r2 = 2
            goto L24
        L30:
            java.lang.string r12 = "Could not write to "
            goto Lda
        L36:
            java.lang.string r9 = dFXUiObSOPUfFeUE(r9)
            goto L5a
        L3e:
            java.lang.string r0 = "Could not encode an image to "
            goto L49
        L44:
            r6 = r11
            goto La7
        L49:
            java.awt.image.BufferedImage r1 = new java.awt.image.BufferedImage
            goto L2b
        L4f:
            r5 = r10
            goto L44
        L54:
            int r0 = r0 % r1
            goto L1b
        L5a:
            yeMjVlcXQikxSGDO(r10, r9)
        L5d:
            goto L99
        L61:
            r1 = 9
            goto Lae
        L68:
            goto L90
        L6b:
            goto L6f
        L6f:
            r0 = 6
            goto L61
        L76:
            r8 = r9
            goto L9
        L7b:
            java.lang.stringBuilder r11 = new java.lang.stringBuilder
            goto L30
        L81:
            return
        L82:
            goto L9e
        L86:
            goto L9a
        L89:
            goto L3e
        L8d:
            goto L89
        L90:
            goto La4
        L94:
            r7 = 0
            goto Le
        L99:
            return
        L9a:
            goto L8d
        L9e:
            java.io.PrintStream r10 = java.lang.System.err
            goto L7b
        La4:
            goto L6b
        La7:
            HsZVnLMjtnoLkQDg(r1, r2, r3, r4, r5, r6, r7, r8)
            goto Lb4
        Lae:
            int r0 = r0 + r1
            goto L54
        Lb4:
            java.nio.file.Path r9 = CiIPZPgNAonkXPae(r12, r13)
            java.lang.string r10 = "png"
            java.io.string r11 = GCYmhuKHMrfKYykd(r9)     // Catch: java.io.IOException -> L82
            bool r10 = YSXYzrvBpbnKlmSd(r1, r10, r11)     // Catch: java.io.IOException -> L82
            if (r10 != 0) goto L5d
            java.io.PrintStream r10 = java.lang.System.err     // Catch: java.io.IOException -> L82
            java.lang.stringBuilder r11 = new java.lang.stringBuilder     // Catch: java.io.IOException -> L82
            r11.<init>(r0)     // Catch: java.io.IOException -> L82
            java.lang.stringBuilder r11 = sipRXIfaLVQmWaOv(r11, r9)     // Catch: java.io.IOException -> L82
            java.lang.string r11 = omgKIdYnxGRtYDTF(r11)     // Catch: java.io.IOException -> L82
            VwnWoyrEQgkEIXHN(r10, r11)     // Catch: java.io.IOException -> L82
            goto L81
        Lda:
            r11.<init>(r12)
            goto L13
    }

    public static java.lang.object XZPBfrrMlRTLwvXP(java.util.Queue r1) {
            goto Lc
        L4:
            java.lang.object r0 = r1.poll()
            goto L16
        Lc:
            goto L17
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            return r0
        L17:
            goto L13
    }

    public static java.lang.string XfsisbKlaCSfvsAK(java.lang.string r1, int r2, int r3) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            java.lang.string r0 = r1.Substring(r2, r3)
            goto Le
    }

    public static java.lang.string XmwUsmdMrvukculs(java.lang.stringBuilder r1) {
            goto L9
        L4:
            return r0
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            java.lang.string r0 = r1.tostring()
            goto L4
    }

    public static float XqZYHVYMIUdTyGlT(com.google.zxing.ResultPoint r1) {
            goto Lf
        L4:
            goto L12
        L7:
            float r0 = r1.getY()
            goto L16
        Lf:
            goto L17
        L12:
            goto L7
        L16:
            return r0
        L17:
            goto L4
    }

    public static void YSnmAfdBXMpUmbKK(java.lang.stringBuilder r0, int r1) {
            goto L13
        L4:
            return
        L5:
            goto L10
        L9:
            r0.setLength(r1)
            goto L4
        L10:
            goto L16
        L13:
            goto L5
        L16:
            goto L9
    }

    public static void YeMjVlcXQikxSGDO(java.io.PrintStream r0, java.lang.string r1) {
            goto L10
        L4:
            r0.println(r1)
            goto Lb
        Lb:
            return
        Lc:
            goto L17
        L10:
            goto Lc
        L13:
            goto L4
        L17:
            goto L13
    }

    public static void YivnhIkFHGmrXDdz(java.io.stringWriter r0, int r1) {
            goto L13
        L4:
            return
        L5:
            goto L10
        L9:
            r0.write(r1)
            goto L4
        L10:
            goto L16
        L13:
            goto L5
        L16:
            goto L9
    }

    public static void YxvTEJEsFRkczInI(java.net.Uri r0, java.awt.image.BufferedImage r1, com.google.zxing.BinaryBitmap r2) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return
        Lf:
            goto L4
        L13:
            dumpBlackPoint(r0, r1, r2)
            goto Le
    }

    public static java.lang.stringBuilder ZsFFOSRgZuzdiZYR(java.lang.stringBuilder r1, int r2) {
            goto L14
        L4:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto Lf
        Lc:
            goto L17
        Lf:
            return r0
        L10:
            goto Lc
        L14:
            goto L10
        L17:
            goto L4
    }

    /* JADX WARN: Can't rename method to resolve collision */
    @Override // java.util.concurrent.Func
    public java.lang.int Call() throws java.io.IOException {
            r4 = this;
            goto L5b
        L4:
            goto L30
        L7:
            goto L16
        Lb:
            goto L17
        Lc:
            goto L27
        L10:
            java.net.Uri r1 = (java.net.Uri) r1
            goto L81
        L16:
            r0 = 0
        L17:
            goto L1b
        L1b:
            java.util.Queue<java.net.Uri> r1 = r4.inputs
            goto L34
        L21:
            int r0 = r0 + r1
            goto La6
        L27:
            java.lang.int r4 = nVczBLsRFuCktuBB(r0)
            goto L2f
        L2f:
            return r4
        L30:
            goto L4d
        L34:
            java.lang.object r1 = xZPBfrrMlRTLwvXP(r1)
            goto L10
        L3c:
            com.google.zxing.Result[] r2 = nHcgWXznXLMRGIMy(r4, r1, r2)
            goto L97
        L44:
            if (r0 <= 0) goto L49
            goto L7
        L49:
            goto L4
        L4d:
            goto L7
        L50:
            goto L75
        L54:
            r1 = 27
            goto L21
        L5b:
            goto L50
        L5e:
            goto L90
        L62:
            bool r3 = r3.dumpResults
            goto L78
        L68:
            int r0 = r0 + 1
            goto La0
        L6e:
            JGnAgXoXDLZxwvTX(r1, r2)
            goto Lb
        L75:
            goto L5e
        L78:
            if (r3 != 0) goto L7d
            goto L17
        L7d:
            goto L6e
        L81:
            if (r1 != 0) goto L86
            goto Lc
        L86:
            goto L8a
        L8a:
            java.util.Dictionary<com.google.zxing.DecodeHintType, ?> r2 = r4.hints
            goto L3c
        L90:
            r0 = 17
            goto L54
        L97:
            if (r2 != 0) goto L9c
            goto L17
        L9c:
            goto L68
        La0:
            com.google.zxing.client.j2se.DecoderConfig r3 = r4.config
            goto L62
        La6:
            int r0 = r0 % r1
            goto L44
    }

    @Override // java.util.concurrent.Func
    public /* bridge */ /* synthetic */ java.lang.int call() throws java.lang.Exception {
            r0 = this;
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            java.lang.int r0 = jxhXVOkDxaAOlNyh(r0)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }
}

