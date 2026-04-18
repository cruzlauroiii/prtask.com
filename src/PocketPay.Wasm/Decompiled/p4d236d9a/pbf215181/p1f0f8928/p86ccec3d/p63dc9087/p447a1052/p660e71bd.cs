using Com.Decryptstringmanager;
using Java.Awt;
using Java.Awt.Color;
using Java.Awt.Image;
using Java.Io;
using Java.Util;
using Javax.Imageio;
using Javax.Imageio.Metadata;
using Javax.Imageio.Spi;
using Javax.Imageio.Stream;
using P4d236d9a.Pbf215181.P1f0f8928.P63dc9087.P447a1052;
using P4d236d9a.Pbf215181.P1f0f8928.P86ccec3d.P9efab239;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes20.dex */
public class p660e71bd : ImageWriter {
    private static readonly int f0718ef7e = 50;
    private static readonly int f0f214ce3 = 54;
    private static readonly int f17c9d2f3 = 50;
    private static readonly string f17d9010c = null;
    private static readonly int f17e706a5 = 53;
    private static byte[] f2295b6f1 = null;
    private static readonly int f23964e81 = 52;
    private static readonly string f343beb46 = null;
    private static readonly int f3c0a86c6 = 53;
    private static readonly int f453a2bfd = 32;
    private static readonly int f49cfc73d = 49;
    private static readonly int f4b05bc95 = 52;
    private static readonly int f50f91a9c = 50;
    private static readonly int f6506ae39 = 32;
    private static readonly int f8123ac2e = 54;
    private static readonly int f958adbd0 = 54;
    private static readonly int f9ae7e476 = 52;
    private static readonly int fa1658175 = 32;
    private static readonly int faf01c7dd = 54;
    private static readonly int faf37efd0 = 49;
    private static byte[] fb72f2ceb = null;
    private static readonly int fbf769214 = 50;
    private static readonly int fc460b02c = 51;
    private static readonly int fc6ef7f08 = 52;
    private static readonly string fccdeedf2 = null;
    private static readonly int fd0f01ae4 = 51;
    private static readonly int fe99b5c38 = 51;
    private static readonly int feb57c31b = 51;
    private static byte[] fedec887e;
    private static readonly string ff2cd320b = null;
    private int f10f911ab;
    private ImageStream f4185e669;
    private int f90cec142;
    private int faa7ac8cd;
    private int fda6aab2e;
    private int fe728b2d7;
    private ImageStream ff7b44cfa;

    static {
        ff2cd320b = YmWudxNcNlTIgmeK("f4ef092642a0a3adc87bdf090fedd6dcc7bf9448a656e258ea883ff7af806e91fce90475c44777e68f26f4bb8583727587c37ba1acb8f981691a187482619e23ca9673f2f827f3fd9330a554f0cd871f2d28");
        if (f2295b6f1 is null) goto L10;
        return;
    L10:
        f2295b6f1 = ucbuqVaJPsxqTjqh(hemleCUNwUMkDghW(QKNmlysjjULpljnQ("c6505df8c6b2701991f704ff97ded818258f2e681b08f03cc71678cc783ee51a8fc91ba0b4774d67377a")));
    }

    public p660e71bd(ImageWriterSpi r1) {
        super(r1);
        this.ff7b44cfa = null;
    }

    public static stringBuilder ASYOVkfVDuMdnpWf(stringBuilder r1, int r2) {
        return r1.append(r2);
    }

    public static void ASYOVkfVDuMdnpWf(stringBuilder r0, int r1, byte r2, string r3, short r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void ASYOVkfVDuMdnpWf(stringBuilder r0, int r1, byte r2, short r3, string r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void ASYOVkfVDuMdnpWf(stringBuilder r0, int r1, bool r2, string r3, short r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static ImageTypeSpecifier ATWnApwPituNlrVV(int r1, int r2, bool r3) {
        return ImageTypeSpecifier.createGrayscale(r1, r2, r3);
    }

    public static void ATWnApwPituNlrVV(int r0, int r1, bool r2, float r3, int r4, short r5, string r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void ATWnApwPituNlrVV(int r0, int r1, bool r2, short r3, float r4, int r5, string r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void ATWnApwPituNlrVV(int r0, int r1, bool r2, short r3, float r4, string r5, int r6) {
        double r02 = (42 * 210) + 210;
    }

    public static int AXyXVFgzwadQQail(Raster r1) {
        return r1.getMinX();
    }

    public static void AXyXVFgzwadQQail(Raster r0, byte r1, string r2, short r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void AXyXVFgzwadQQail(Raster r0, string r1, bool r2, short r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void AXyXVFgzwadQQail(Raster r0, bool r1, byte r2, string r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static Rectangle AaJjcCEVKfBqUZqz(ImageWriteParam r1) {
        return r1.getSourceRegion();
    }

    public static void AaJjcCEVKfBqUZqz(ImageWriteParam r0, byte r1, bool r2, short r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void AaJjcCEVKfBqUZqz(ImageWriteParam r0, short r1, int r2, byte r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void AaJjcCEVKfBqUZqz(ImageWriteParam r0, bool r1, byte r2, int r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int AneXWkXinpdUXyhD(RenderedImage r1) {
        return r1.getHeight();
    }

    public static void AneXWkXinpdUXyhD(RenderedImage r0, int r1, byte r2, float r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void AneXWkXinpdUXyhD(RenderedImage r0, int r1, float r2, byte r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void AneXWkXinpdUXyhD(RenderedImage r0, string r1, int r2, float r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static IIOMetadata BAXrkYsQxKxQPTWj(p660e71bd r1, ImageTypeSpecifier r2, ImageWriteParam r3) {
        return r1.getDefaultImageMetadata(r2, r3);
    }

    public static void BAXrkYsQxKxQPTWj(p660e71bd r0, ImageTypeSpecifier r1, ImageWriteParam r2, float r3, short r4, int r5, string r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void BAXrkYsQxKxQPTWj(p660e71bd r0, ImageTypeSpecifier r1, ImageWriteParam r2, int r3, float r4, string r5, short r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void BAXrkYsQxKxQPTWj(p660e71bd r0, ImageTypeSpecifier r1, ImageWriteParam r2, string r3, int r4, float r5, short r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void BRLmiLVhpbNlVaDu(p660e71bd r0, ImageStream r1, int r2) {
        r0.mc6da42a2(r1, r2);
    }

    public static void BRLmiLVhpbNlVaDu(p660e71bd r0, ImageStream r1, int r2, byte r3, float r4, bool r5, int r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void BRLmiLVhpbNlVaDu(p660e71bd r0, ImageStream r1, int r2, float r3, int r4, byte r5, bool r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void BRLmiLVhpbNlVaDu(p660e71bd r0, ImageStream r1, int r2, float r3, bool r4, int r5, byte r6) {
        double r02 = (42 * 210) + 210;
    }

    public static string CVXojIuraDGRUFAA(stringBuilder r1) {
        return r1.tostring();
    }

    public static void CVXojIuraDGRUFAA(stringBuilder r0, float r1, short r2, int r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void CVXojIuraDGRUFAA(stringBuilder r0, int r1, short r2, byte r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void CVXojIuraDGRUFAA(stringBuilder r0, short r1, float r2, int r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void CftCrWCOfQxifRBy(p660e71bd r0) {
        r0.clearAbortRequest();
    }

    public static void CftCrWCOfQxifRBy(p660e71bd r0, char r1, short r2, int r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void CftCrWCOfQxifRBy(p660e71bd r0, int r1, byte r2, char r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void CftCrWCOfQxifRBy(p660e71bd r0, int r1, short r2, byte r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int CjNzGTzTlpwsPORa(RenderedImage r1) {
        return r1.getMinX();
    }

    public static void CjNzGTzTlpwsPORa(RenderedImage r0, char r1, byte r2, bool r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void CjNzGTzTlpwsPORa(RenderedImage r0, bool r1, byte r2, char r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void CjNzGTzTlpwsPORa(RenderedImage r0, bool r1, short r2, byte r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int CkwXZnFIMsGwZnns(p7c608cb0 r1) {
        return r1.getMaxValue();
    }

    public static void CkwXZnFIMsGwZnns(p7c608cb0 r0, byte r1, string r2, char r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void CkwXZnFIMsGwZnns(p7c608cb0 r0, char r1, int r2, string r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void CkwXZnFIMsGwZnns(p7c608cb0 r0, char r1, string r2, int r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static stringBuilder DQnaebbFoyhyIbpW(stringBuilder r1, string r2) {
        return r1.append(r2);
    }

    public static void DQnaebbFoyhyIbpW(stringBuilder r0, string r1, string r2, bool r3, int r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void DQnaebbFoyhyIbpW(stringBuilder r0, string r1, short r2, bool r3, string r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void DQnaebbFoyhyIbpW(stringBuilder r0, string r1, bool r2, short r3, string r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void DdngADgubgWsqopQ(ImageStream r0, byte[] r1, int r2, int r3) {
        r0.write(r1, r2, r3);
    }

    public static void DdngADgubgWsqopQ(ImageStream r0, byte[] r1, int r2, int r3, int r4, short r5, float r6, bool r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void DdngADgubgWsqopQ(ImageStream r0, byte[] r1, int r2, int r3, short r4, int r5, float r6, bool r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void DdngADgubgWsqopQ(ImageStream r0, byte[] r1, int r2, int r3, bool r4, int r5, float r6, short r7) {
        double r02 = (42 * 210) + 210;
    }

    public static int DjXewvExDJysGUYd(Raster r1) {
        return r1.getSampleModelTranslateY();
    }

    public static void DjXewvExDJysGUYd(Raster r0, bool r1, byte r2, char r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void DjXewvExDJysGUYd(Raster r0, bool r1, char r2, byte r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void DjXewvExDJysGUYd(Raster r0, bool r1, int r2, char r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void DvDqpMBDdQQyblsG(ImageStream r0, int r1) {
        r0.write(r1);
    }

    public static void DvDqpMBDdQQyblsG(ImageStream r0, int r1, float r2, short r3, bool r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void DvDqpMBDdQQyblsG(ImageStream r0, int r1, bool r2, byte r3, float r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void DvDqpMBDdQQyblsG(ImageStream r0, int r1, bool r2, byte r3, short r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static string EyIkQHkeSDjDWFwn(string r1) {
        return Decryptstring.decryptstring(r1);
    }

    public static void EyIkQHkeSDjDWFwn(string r0, char r1, bool r2, string r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void EyIkQHkeSDjDWFwn(string r0, string r1, char r2, float r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void EyIkQHkeSDjDWFwn(string r0, bool r1, string r2, char r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void EynokvUXQcwsudrO(ImageStream r0, byte[] r1) {
        r0.write(r1);
    }

    public static void EynokvUXQcwsudrO(ImageStream r0, byte[] r1, char r2, int r3, string r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void EynokvUXQcwsudrO(ImageStream r0, byte[] r1, char r2, string r3, int r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void EynokvUXQcwsudrO(ImageStream r0, byte[] r1, string r2, char r3, bool r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int FCYuesdquYsHLNfJ(RenderedImage r1) {
        return r1.getMinX();
    }

    public static void FCYuesdquYsHLNfJ(RenderedImage r0, char r1, byte r2, float r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void FCYuesdquYsHLNfJ(RenderedImage r0, int r1, byte r2, char r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void FCYuesdquYsHLNfJ(RenderedImage r0, int r1, char r2, byte r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void GATYgmOcgnmxRCPU(p660e71bd r0, byte r1, char r2, float r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void GATYgmOcgnmxRCPU(p660e71bd r0, char r1, int r2, byte r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void GATYgmOcgnmxRCPU(p660e71bd r0, float r1, int r2, byte r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static bool GATYgmOcgnmxRCPU(p660e71bd r1) {
        return r1.abortRequested();
    }

    public static object GDVzMVHtMGLglJrr(p7c608cb0 r1) {
        return r1.clone();
    }

    public static void GDVzMVHtMGLglJrr(p7c608cb0 r0, char r1, float r2, string r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void GDVzMVHtMGLglJrr(p7c608cb0 r0, char r1, string r2, float r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void GDVzMVHtMGLglJrr(p7c608cb0 r0, string r1, char r2, bool r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void GIvHQwpuZPoomAqz(ImageStream r0, byte[] r1) {
        r0.write(r1);
    }

    public static void GIvHQwpuZPoomAqz(ImageStream r0, byte[] r1, byte r2, short r3, int r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void GIvHQwpuZPoomAqz(ImageStream r0, byte[] r1, char r2, int r3, byte r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void GIvHQwpuZPoomAqz(ImageStream r0, byte[] r1, int r2, byte r3, char r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void GnVyDoeuHoNPZLyV(p1b6e7799 r0, byte r1, char r2, int r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void GnVyDoeuHoNPZLyV(p1b6e7799 r0, char r1, short r2, int r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void GnVyDoeuHoNPZLyV(p1b6e7799 r0, int r1, byte r2, short r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static bool GnVyDoeuHoNPZLyV(p1b6e7799 r1) {
        return r1.getRaw();
    }

    public static void HIKyKgRcypCsnfAs(p660e71bd r0) {
        r0.processWriteAborted();
    }

    public static void HIKyKgRcypCsnfAs(p660e71bd r0, byte r1, int r2, char r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void HIKyKgRcypCsnfAs(p660e71bd r0, char r1, short r2, byte r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void HIKyKgRcypCsnfAs(p660e71bd r0, short r1, int r2, byte r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void HaTIzHadgOZcdraA(ImageWriter r0, ColorModel r1, SampleModel r2) {
        p86eb00ea.mc4ae29ee(r0, r1, r2);
    }

    public static void HaTIzHadgOZcdraA(ImageWriter r0, ColorModel r1, SampleModel r2, float r3, byte r4, bool r5, short r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void HaTIzHadgOZcdraA(ImageWriter r0, ColorModel r1, SampleModel r2, short r3, byte r4, bool r5, float r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void HaTIzHadgOZcdraA(ImageWriter r0, ColorModel r1, SampleModel r2, bool r3, float r4, short r5, byte r6) {
        double r02 = (42 * 210) + 210;
    }

    public static Raster HcjedMdQNDrlYvVV(RenderedImage r1, Rectangle r2) {
        return r1.getData(r2);
    }

    public static void HcjedMdQNDrlYvVV(RenderedImage r0, Rectangle r1, char r2, string r3, bool r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void HcjedMdQNDrlYvVV(RenderedImage r0, Rectangle r1, string r2, short r3, char r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void HcjedMdQNDrlYvVV(RenderedImage r0, Rectangle r1, bool r2, short r3, char r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void HncPrnSbzLTXPBBR(p660e71bd r0, int r1, char r2, float r3, int r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void HncPrnSbzLTXPBBR(p660e71bd r0, int r1, char r2, int r3, byte r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void HncPrnSbzLTXPBBR(p660e71bd r0, int r1, float r2, byte r3, char r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static bool HncPrnSbzLTXPBBR(p660e71bd r1, int r2) {
        return r1.m5501218a(r2);
    }

    public static void IXdWhJetgoJOHkBA(ComponentSampleModel r0, byte r1, int r2, bool r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void IXdWhJetgoJOHkBA(ComponentSampleModel r0, byte r1, bool r2, string r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void IXdWhJetgoJOHkBA(ComponentSampleModel r0, bool r1, byte r2, string r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int[] IXdWhJetgoJOHkBA(ComponentSampleModel r1) {
        return r1.getBandOffsets();
    }

    public static int ItdkHnwzncwjJLIf(ImageWriteParam r1) {
        return r1.getSubsamplingXOffset();
    }

    public static void ItdkHnwzncwjJLIf(ImageWriteParam r0, byte r1, string r2, float r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ItdkHnwzncwjJLIf(ImageWriteParam r0, byte r1, short r2, string r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ItdkHnwzncwjJLIf(ImageWriteParam r0, string r1, float r2, short r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static ImageTypeSpecifier JEXmELDVjzRXqekG(ColorSpace r1, int[] r2, int r3, bool r4, bool r5) {
        return ImageTypeSpecifier.createInterleaved(r1, r2, r3, r4, r5);
    }

    public static void JEXmELDVjzRXqekG(ColorSpace r0, int[] r1, int r2, bool r3, bool r4, char r5, bool r6, string r7, byte r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void JEXmELDVjzRXqekG(ColorSpace r0, int[] r1, int r2, bool r3, bool r4, string r5, bool r6, byte r7, char r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void JEXmELDVjzRXqekG(ColorSpace r0, int[] r1, int r2, bool r3, bool r4, string r5, bool r6, char r7, byte r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void JbsiudOvsdKwJVQj(Rectangle r0, float r1, bool r2, char r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void JbsiudOvsdKwJVQj(Rectangle r0, short r1, char r2, bool r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void JbsiudOvsdKwJVQj(Rectangle r0, short r1, float r2, bool r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static bool JbsiudOvsdKwJVQj(Rectangle r1) {
        return r1.Count == 0;
    }

    public static void KAkQvsLyxGWLzihi(ImageStream r0, byte[] r1) {
        r0.write(r1);
    }

    public static void KAkQvsLyxGWLzihi(ImageStream r0, byte[] r1, int r2, float r3, string r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void KAkQvsLyxGWLzihi(ImageStream r0, byte[] r1, short r2, float r3, int r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void KAkQvsLyxGWLzihi(ImageStream r0, byte[] r1, short r2, string r3, float r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int KLNwboFfxnvFXKoj(ImageWriteParam r1) {
        return r1.getSourceYSubsampling();
    }

    public static void KLNwboFfxnvFXKoj(ImageWriteParam r0, byte r1, char r2, float r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void KLNwboFfxnvFXKoj(ImageWriteParam r0, char r1, float r2, byte r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void KLNwboFfxnvFXKoj(ImageWriteParam r0, float r1, byte r2, char r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void KSHeSHpLqnSVzBUO(ImageStream r0, int r1) {
        r0.writebyte(r1);
    }

    public static void KSHeSHpLqnSVzBUO(ImageStream r0, int r1, byte r2, int r3, short r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void KSHeSHpLqnSVzBUO(ImageStream r0, int r1, char r2, int r3, byte r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void KSHeSHpLqnSVzBUO(ImageStream r0, int r1, short r2, int r3, byte r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int KhjyUJpkXTmQLwYl(SampleModel r1) {
        return r1.getWidth();
    }

    public static void KhjyUJpkXTmQLwYl(SampleModel r0, byte r1, int r2, char r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void KhjyUJpkXTmQLwYl(SampleModel r0, float r1, byte r2, int r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void KhjyUJpkXTmQLwYl(SampleModel r0, int r1, float r2, byte r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void LYmikDfPrZbxuCAj(ImageStream r0, byte[] r1, int r2, int r3) {
        r0.write(r1, r2, r3);
    }

    public static void LYmikDfPrZbxuCAj(ImageStream r0, byte[] r1, int r2, int r3, string r4, byte r5, bool r6, short r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void LYmikDfPrZbxuCAj(ImageStream r0, byte[] r1, int r2, int r3, bool r4, byte r5, string r6, short r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void LYmikDfPrZbxuCAj(ImageStream r0, byte[] r1, int r2, int r3, bool r4, short r5, byte r6, string r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void LsGPVNsZaQnTmCiR(ImageStream r0, int r1) {
        r0.writebyte(r1);
    }

    public static void LsGPVNsZaQnTmCiR(ImageStream r0, int r1, int r2, string r3, bool r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void LsGPVNsZaQnTmCiR(ImageStream r0, int r1, string r2, char r3, int r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void LsGPVNsZaQnTmCiR(ImageStream r0, int r1, string r2, bool r3, char r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void MDArmHDyqmVALrcJ(p7c608cb0 r0, ImageTypeSpecifier r1, ImageWriteParam r2) {
        r0.initialize(r1, r2);
    }

    public static void MDArmHDyqmVALrcJ(p7c608cb0 r0, ImageTypeSpecifier r1, ImageWriteParam r2, float r3, char r4, short r5, bool r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void MDArmHDyqmVALrcJ(p7c608cb0 r0, ImageTypeSpecifier r1, ImageWriteParam r2, float r3, char r4, bool r5, short r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void MDArmHDyqmVALrcJ(p7c608cb0 r0, ImageTypeSpecifier r1, ImageWriteParam r2, short r3, bool r4, float r5, char r6) {
        double r02 = (42 * 210) + 210;
    }

    public static int MuhiyZAMeBSoCNOz(MultiPixelPackedSampleModel r1, int r2, int r3) {
        return r1.getOffset(r2, r3);
    }

    public static void MuhiyZAMeBSoCNOz(MultiPixelPackedSampleModel r0, int r1, int r2, string r3, char r4, short r5, bool r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void MuhiyZAMeBSoCNOz(MultiPixelPackedSampleModel r0, int r1, int r2, string r3, short r4, char r5, bool r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void MuhiyZAMeBSoCNOz(MultiPixelPackedSampleModel r0, int r1, int r2, bool r3, char r4, string r5, short r6) {
        double r02 = (42 * 210) + 210;
    }

    public static stringBuilder MyqbYXZqbJLWblpc(stringBuilder r1, string r2) {
        return r1.append(r2);
    }

    public static void MyqbYXZqbJLWblpc(stringBuilder r0, string r1, float r2, int r3, char r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void MyqbYXZqbJLWblpc(stringBuilder r0, string r1, int r2, char r3, byte r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void MyqbYXZqbJLWblpc(stringBuilder r0, string r1, int r2, float r3, char r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void NFYzTqcAvXMDKcJW(ImageStream r0, byte[] r1) {
        r0.write(r1);
    }

    public static void NFYzTqcAvXMDKcJW(ImageStream r0, byte[] r1, byte r2, bool r3, string r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void NFYzTqcAvXMDKcJW(ImageStream r0, byte[] r1, bool r2, byte r3, string r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void NFYzTqcAvXMDKcJW(ImageStream r0, byte[] r1, bool r2, string r3, byte r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void NNKKyhkOZbQMtphP(ImageWriter r0, object r1) {
        super.setOutput(r1);
    }

    public static void NNKKyhkOZbQMtphP(ImageWriter r0, object r1, int r2, short r3, string r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void NNKKyhkOZbQMtphP(ImageWriter r0, object r1, bool r2, int r3, string r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void NNKKyhkOZbQMtphP(ImageWriter r0, object r1, bool r2, string r3, int r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void NnvthqyEzecxzzqT(ImageStream r0, byte[] r1) {
        r0.write(r1);
    }

    public static void NnvthqyEzecxzzqT(ImageStream r0, byte[] r1, float r2, int r3, string r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void NnvthqyEzecxzzqT(ImageStream r0, byte[] r1, string r2, short r3, float r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void NnvthqyEzecxzzqT(ImageStream r0, byte[] r1, short r2, float r3, int r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void OKULIPrfsicOetGI(string r0, byte r1, int r2, bool r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void OKULIPrfsicOetGI(string r0, int r1, float r2, byte r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void OKULIPrfsicOetGI(string r0, bool r1, byte r2, float r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static byte[] OKULIPrfsicOetGI(string r1) {
        return r1.getbytes();
    }

    public static int OktjjkvEtgBvopjs(ComponentSampleModel r1) {
        return r1.getPixelStride();
    }

    public static void OktjjkvEtgBvopjs(ComponentSampleModel r0, byte r1, char r2, float r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void OktjjkvEtgBvopjs(ComponentSampleModel r0, char r1, byte r2, float r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void OktjjkvEtgBvopjs(ComponentSampleModel r0, int r1, char r2, byte r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static string PVrlBUzYMKaGewyL(string r1) {
        return p1ea75d1e.m6dcf1319(r1);
    }

    public static void PVrlBUzYMKaGewyL(string r0, float r1, int r2, short r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void PVrlBUzYMKaGewyL(string r0, int r1, float r2, short r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void PVrlBUzYMKaGewyL(string r0, string r1, short r2, int r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static Raster PlnuerDkXzvScsfg(IIOImage r1) {
        return r1.getRaster();
    }

    public static void PlnuerDkXzvScsfg(IIOImage r0, byte r1, float r2, short r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void PlnuerDkXzvScsfg(IIOImage r0, string r1, byte r2, float r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void PlnuerDkXzvScsfg(IIOImage r0, short r1, float r2, byte r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static string PyoEcSdcXNEBPXeP(string r1) {
        return p1ea75d1e.m6dcf1319(r1);
    }

    public static void PyoEcSdcXNEBPXeP(string r0, byte r1, char r2, bool r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void PyoEcSdcXNEBPXeP(string r0, char r1, byte r2, bool r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void PyoEcSdcXNEBPXeP(string r0, bool r1, char r2, byte r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static string QKNmlysjjULpljnQ(string r1) {
        return Decryptstring.decryptstring(r1);
    }

    public static void QKNmlysjjULpljnQ(string r0, char r1, float r2, bool r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void QKNmlysjjULpljnQ(string r0, int r1, bool r2, char r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void QKNmlysjjULpljnQ(string r0, bool r1, int r2, char r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void QVfnWqcnnPSGAKMR(IndexColorModel r0, byte[] r1) {
        r0.getGreens(r1);
    }

    public static void QVfnWqcnnPSGAKMR(IndexColorModel r0, byte[] r1, int r2, char r3, short r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void QVfnWqcnnPSGAKMR(IndexColorModel r0, byte[] r1, int r2, short r3, char r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void QVfnWqcnnPSGAKMR(IndexColorModel r0, byte[] r1, short r2, bool r3, char r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int RHfZMApaCnLaeyZy(Raster r1) {
        return r1.getMinX();
    }

    public static void RHfZMApaCnLaeyZy(Raster r0, int r1, byte r2, string r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void RHfZMApaCnLaeyZy(Raster r0, short r1, byte r2, string r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void RHfZMApaCnLaeyZy(Raster r0, short r1, string r2, byte r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static Rectangle RIfiwApwEEWrKGJD(Raster r1) {
        return r1.getBounds();
    }

    public static void RIfiwApwEEWrKGJD(Raster r0, string r1, short r2, bool r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void RIfiwApwEEWrKGJD(Raster r0, short r1, byte r2, string r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void RIfiwApwEEWrKGJD(Raster r0, short r1, string r2, bool r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void RXWQJbHCkzSKITOS(Rectangle r0, int r1, int r2) {
        r0.translate(r1, r2);
    }

    public static void RXWQJbHCkzSKITOS(Rectangle r0, int r1, int r2, byte r3, float r4, short r5, char r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void RXWQJbHCkzSKITOS(Rectangle r0, int r1, int r2, byte r3, short r4, char r5, float r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void RXWQJbHCkzSKITOS(Rectangle r0, int r1, int r2, char r3, byte r4, float r5, short r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void SGjSIykIuUBsYSuO(p660e71bd r0, ImageStream r1, int r2) {
        r0.mc6da42a2(r1, r2);
    }

    public static void SGjSIykIuUBsYSuO(p660e71bd r0, ImageStream r1, int r2, char r3, int r4, short r5, bool r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void SGjSIykIuUBsYSuO(p660e71bd r0, ImageStream r1, int r2, char r3, short r4, int r5, bool r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void SGjSIykIuUBsYSuO(p660e71bd r0, ImageStream r1, int r2, int r3, bool r4, char r5, short r6) {
        double r02 = (42 * 210) + 210;
    }

    public static ColorSpace SYLVXMjEGVbwugRI(int r1) {
        return ColorSpace.getInstance(r1);
    }

    public static void SYLVXMjEGVbwugRI(int r0, string r1, int r2, bool r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void SYLVXMjEGVbwugRI(int r0, string r1, bool r2, int r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void SYLVXMjEGVbwugRI(int r0, bool r1, string r2, int r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void TEJEjpLSPflTgxRo(p660e71bd r0, ImageStream r1, int r2) {
        r0.mc6da42a2(r1, r2);
    }

    public static void TEJEjpLSPflTgxRo(p660e71bd r0, ImageStream r1, int r2, float r3, int r4, short r5, char r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void TEJEjpLSPflTgxRo(p660e71bd r0, ImageStream r1, int r2, float r3, short r4, char r5, int r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void TEJEjpLSPflTgxRo(p660e71bd r0, ImageStream r1, int r2, int r3, short r4, float r5, char r6) {
        double r02 = (42 * 210) + 210;
    }

    public static string TqPNGRgpxwlsLmxi(byte r1) {
        return byte.tostring(r1);
    }

    public static void TqPNGRgpxwlsLmxi(byte r0, float r1, bool r2, byte r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void TqPNGRgpxwlsLmxi(byte r0, bool r1, byte r2, char r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void TqPNGRgpxwlsLmxi(byte r0, bool r1, float r2, char r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void UQqVgUmkSDhXzqxA(string r0, char r1, string r2, short r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void UQqVgUmkSDhXzqxA(string r0, int r1, string r2, short r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void UQqVgUmkSDhXzqxA(string r0, short r1, string r2, char r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static byte[] UQqVgUmkSDhXzqxA(string r1) {
        return r1.getbytes();
    }

    public static void UWVJhUtGXKlVwpcC(ImageStream r0, int r1) {
        r0.write(r1);
    }

    public static void UWVJhUtGXKlVwpcC(ImageStream r0, int r1, byte r2, float r3, int r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void UWVJhUtGXKlVwpcC(ImageStream r0, int r1, int r2, short r3, float r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void UWVJhUtGXKlVwpcC(ImageStream r0, int r1, short r2, float r3, int r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static SampleModel UrGaazlgNKmyOwPf(Raster r1) {
        return r1.getSampleModel();
    }

    public static void UrGaazlgNKmyOwPf(Raster r0, byte r1, short r2, bool r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void UrGaazlgNKmyOwPf(Raster r0, byte r1, bool r2, float r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void UrGaazlgNKmyOwPf(Raster r0, bool r1, byte r2, float r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void VIZPaKnsjSRsOfae(p660e71bd r0, int r1, string r2, short r3, int r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void VIZPaKnsjSRsOfae(p660e71bd r0, int r1, short r2, char r3, string r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void VIZPaKnsjSRsOfae(p660e71bd r0, int r1, short r2, string r3, char r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static bool VIZPaKnsjSRsOfae(p660e71bd r1, int r2) {
        return r1.m5501218a(r2);
    }

    public static void VcSApwNsoQEBzNte(IndexColorModel r0, byte[] r1) {
        r0.getReds(r1);
    }

    public static void VcSApwNsoQEBzNte(IndexColorModel r0, byte[] r1, byte r2, string r3, char r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void VcSApwNsoQEBzNte(IndexColorModel r0, byte[] r1, float r2, byte r3, string r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void VcSApwNsoQEBzNte(IndexColorModel r0, byte[] r1, string r2, byte r3, float r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void WFoVxilmSVztqYdB(p660e71bd r0) {
        r0.processImageComplete();
    }

    public static void WFoVxilmSVztqYdB(p660e71bd r0, char r1, byte r2, float r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void WFoVxilmSVztqYdB(p660e71bd r0, float r1, byte r2, short r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void WFoVxilmSVztqYdB(p660e71bd r0, float r1, char r2, short r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void WKnZUZvXvQxedbzX(ImageStream r0, byte[] r1) {
        r0.write(r1);
    }

    public static void WKnZUZvXvQxedbzX(ImageStream r0, byte[] r1, byte r2, int r3, char r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void WKnZUZvXvQxedbzX(ImageStream r0, byte[] r1, char r2, int r3, string r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void WKnZUZvXvQxedbzX(ImageStream r0, byte[] r1, int r2, string r3, byte r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void WdpFqaDCWLpmHxdk(p660e71bd r0) {
        r0.processImageComplete();
    }

    public static void WdpFqaDCWLpmHxdk(p660e71bd r0, string r1, short r2, byte r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void WdpFqaDCWLpmHxdk(p660e71bd r0, string r1, bool r2, byte r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void WdpFqaDCWLpmHxdk(p660e71bd r0, short r1, bool r2, byte r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int WgIZnXNSGpXsxTEe(Raster r1) {
        return r1.getSampleModelTranslateX();
    }

    public static void WgIZnXNSGpXsxTEe(Raster r0, byte r1, string r2, float r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void WgIZnXNSGpXsxTEe(Raster r0, bool r1, byte r2, string r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void WgIZnXNSGpXsxTEe(Raster r0, bool r1, float r2, string r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int WyaPYpVdvEXFpJbB(SampleModel r1) {
        return r1.getNumBands();
    }

    public static void WyaPYpVdvEXFpJbB(SampleModel r0, float r1, byte r2, short r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void WyaPYpVdvEXFpJbB(SampleModel r0, int r1, short r2, byte r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void WyaPYpVdvEXFpJbB(SampleModel r0, short r1, int r2, float r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void XItdpopQqbTyTrXW(ImageStream r0, byte[] r1) {
        r0.write(r1);
    }

    public static void XItdpopQqbTyTrXW(ImageStream r0, byte[] r1, byte r2, float r3, string r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void XItdpopQqbTyTrXW(ImageStream r0, byte[] r1, byte r2, float r3, short r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void XItdpopQqbTyTrXW(ImageStream r0, byte[] r1, short r2, string r3, byte r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int XTPyHfIJsRRuqmag(MultiPixelPackedSampleModel r1) {
        return r1.getPixelBitStride();
    }

    public static void XTPyHfIJsRRuqmag(MultiPixelPackedSampleModel r0, char r1, byte r2, int r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void XTPyHfIJsRRuqmag(MultiPixelPackedSampleModel r0, float r1, byte r2, char r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void XTPyHfIJsRRuqmag(MultiPixelPackedSampleModel r0, int r1, float r2, byte r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void XwgRylETUAmErDXl(string r0, short r1, int r2, char r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void XwgRylETUAmErDXl(string r0, short r1, bool r2, char r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void XwgRylETUAmErDXl(string r0, bool r1, char r2, short r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static byte[] XwgRylETUAmErDXl(string r1) {
        return r1.getbytes();
    }

    public static void YiWRBlFFemgyfyzR(ImageStream r0, byte[] r1, int r2, int r3) {
        r0.write(r1, r2, r3);
    }

    public static void YiWRBlFFemgyfyzR(ImageStream r0, byte[] r1, int r2, int r3, string r4, short r5, bool r6, byte r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void YiWRBlFFemgyfyzR(ImageStream r0, byte[] r1, int r2, int r3, string r4, bool r5, byte r6, short r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void YiWRBlFFemgyfyzR(ImageStream r0, byte[] r1, int r2, int r3, bool r4, string r5, byte r6, short r7) {
        double r02 = (42 * 210) + 210;
    }

    public static string YmWudxNcNlTIgmeK(string r1) {
        return Decryptstring.decryptstring(r1);
    }

    public static void YmWudxNcNlTIgmeK(string r0, float r1, char r2, byte r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void YmWudxNcNlTIgmeK(string r0, float r1, char r2, int r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void YmWudxNcNlTIgmeK(string r0, float r1, int r2, char r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int YtDZyZKekuRPhzhF(Raster r1) {
        return r1.getMinX();
    }

    public static void YtDZyZKekuRPhzhF(Raster r0, byte r1, short r2, int r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void YtDZyZKekuRPhzhF(Raster r0, int r1, char r2, short r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void YtDZyZKekuRPhzhF(Raster r0, short r1, char r2, byte r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZisXFEtOmibmaEPR(p660e71bd r0, int r1) {
        r0.processImageStarted(r1);
    }

    public static void ZisXFEtOmibmaEPR(p660e71bd r0, int r1, int r2, string r3, bool r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZisXFEtOmibmaEPR(p660e71bd r0, int r1, string r2, bool r3, short r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZisXFEtOmibmaEPR(p660e71bd r0, int r1, short r2, bool r3, string r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static IIOMetadata AOtkoIFYaFWwZSrH(p660e71bd r1, IIOMetadata r2, ImageTypeSpecifier r3, ImageWriteParam r4) {
        return r1.convertImageMetadata(r2, r3, r4);
    }

    public static void AOtkoIFYaFWwZSrH(p660e71bd r0, IIOMetadata r1, ImageTypeSpecifier r2, ImageWriteParam r3, float r4, char r5, int r6, string r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void AOtkoIFYaFWwZSrH(p660e71bd r0, IIOMetadata r1, ImageTypeSpecifier r2, ImageWriteParam r3, int r4, float r5, char r6, string r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void AOtkoIFYaFWwZSrH(p660e71bd r0, IIOMetadata r1, ImageTypeSpecifier r2, ImageWriteParam r3, int r4, string r5, char r6, float r7) {
        double r02 = (42 * 210) + 210;
    }

    public static int ASuaPRTQbsadfYpV(Raster r1) {
        return r1.getMinY();
    }

    public static void ASuaPRTQbsadfYpV(Raster r0, float r1, short r2, string r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ASuaPRTQbsadfYpV(Raster r0, float r1, bool r2, short r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ASuaPRTQbsadfYpV(Raster r0, string r1, short r2, bool r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int ATpYEndiombGKJOb(MultiPixelPackedSampleModel r1, int r2) {
        return r1.getBitOffset(r2);
    }

    public static void ATpYEndiombGKJOb(MultiPixelPackedSampleModel r0, int r1, char r2, string r3, short r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void ATpYEndiombGKJOb(MultiPixelPackedSampleModel r0, int r1, string r2, byte r3, short r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void ATpYEndiombGKJOb(MultiPixelPackedSampleModel r0, int r1, string r2, char r3, byte r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int AZbTYduZNoYlklHI(ImageWriteParam r1) {
        return r1.getSubsamplingYOffset();
    }

    public static void AZbTYduZNoYlklHI(ImageWriteParam r0, char r1, int r2, float r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void AZbTYduZNoYlklHI(ImageWriteParam r0, int r1, bool r2, float r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void AZbTYduZNoYlklHI(ImageWriteParam r0, bool r1, int r2, float r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int AftEKVCrFoBrZavL(RenderedImage r1) {
        return r1.getWidth();
    }

    public static void AftEKVCrFoBrZavL(RenderedImage r0, byte r1, string r2, int r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void AftEKVCrFoBrZavL(RenderedImage r0, float r1, int r2, string r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void AftEKVCrFoBrZavL(RenderedImage r0, string r1, byte r2, float r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static Raster AyfNDzSTSmsnqZdl(RenderedImage r1, Rectangle r2) {
        return r1.getData(r2);
    }

    public static void AyfNDzSTSmsnqZdl(RenderedImage r0, Rectangle r1, char r2, int r3, bool r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void AyfNDzSTSmsnqZdl(RenderedImage r0, Rectangle r1, int r2, bool r3, short r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void AyfNDzSTSmsnqZdl(RenderedImage r0, Rectangle r1, short r2, char r3, int r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static DataBuffer BDtBdSfJkxFlxOHw(Raster r1) {
        return r1.getDataBuffer();
    }

    public static void BDtBdSfJkxFlxOHw(Raster r0, char r1, bool r2, int r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void BDtBdSfJkxFlxOHw(Raster r0, int r1, byte r2, bool r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void BDtBdSfJkxFlxOHw(Raster r0, int r1, char r2, byte r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void BwpMqttQVBhtEVhB(p660e71bd r0, ImageStream r1, int r2) {
        r0.mc6da42a2(r1, r2);
    }

    public static void BwpMqttQVBhtEVhB(p660e71bd r0, ImageStream r1, int r2, byte r3, string r4, char r5, int r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void BwpMqttQVBhtEVhB(p660e71bd r0, ImageStream r1, int r2, int r3, byte r4, char r5, string r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void BwpMqttQVBhtEVhB(p660e71bd r0, ImageStream r1, int r2, int r3, byte r4, string r5, char r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void CpEurNgwnOGNHraS(ImageStream r0, byte[] r1) {
        r0.write(r1);
    }

    public static void CpEurNgwnOGNHraS(ImageStream r0, byte[] r1, char r2, byte r3, float r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void CpEurNgwnOGNHraS(ImageStream r0, byte[] r1, char r2, short r3, float r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void CpEurNgwnOGNHraS(ImageStream r0, byte[] r1, short r2, char r3, byte r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static Rectangle CruVwEulTFDLUfMT(Rectangle r1, Rectangle r2) {
        return r1.intersection(r2);
    }

    public static void CruVwEulTFDLUfMT(Rectangle r0, Rectangle r1, byte r2, float r3, string r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void CruVwEulTFDLUfMT(Rectangle r0, Rectangle r1, string r2, short r3, float r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void CruVwEulTFDLUfMT(Rectangle r0, Rectangle r1, short r2, byte r3, float r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object CxWmYieJwLFaUPoG(IEnumerator r1) {
        return r1.Current;
    }

    public static void CxWmYieJwLFaUPoG(IEnumerator r0, float r1, byte r2, string r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void CxWmYieJwLFaUPoG(IEnumerator r0, string r1, byte r2, float r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void CxWmYieJwLFaUPoG(IEnumerator r0, short r1, string r2, byte r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static Rectangle CxgoeVqaCIIZkngR(Raster r1) {
        return r1.getBounds();
    }

    public static void CxgoeVqaCIIZkngR(Raster r0, byte r1, char r2, bool r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void CxgoeVqaCIIZkngR(Raster r0, byte r1, bool r2, char r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void CxgoeVqaCIIZkngR(Raster r0, int r1, bool r2, char r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int DPsZYTBDtmBPQoAn(Raster r1) {
        return r1.getSampleModelTranslateY();
    }

    public static void DPsZYTBDtmBPQoAn(Raster r0, short r1, bool r2, char r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void DPsZYTBDtmBPQoAn(Raster r0, bool r1, int r2, char r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void DPsZYTBDtmBPQoAn(Raster r0, bool r1, short r2, char r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int DSDCXBdXPvVqfGDs(ImageWriteParam r1) {
        return r1.getSourceXSubsampling();
    }

    public static void DSDCXBdXPvVqfGDs(ImageWriteParam r0, byte r1, char r2, int r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void DSDCXBdXPvVqfGDs(ImageWriteParam r0, int r1, byte r2, short r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void DSDCXBdXPvVqfGDs(ImageWriteParam r0, short r1, int r2, char r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void DVuRRhygZsGdOBIi(p660e71bd r0, float r1) {
        r0.processImageProgress(r1);
    }

    public static void DVuRRhygZsGdOBIi(p660e71bd r0, float r1, string r2, short r3, bool r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void DVuRRhygZsGdOBIi(p660e71bd r0, float r1, short r2, bool r3, float r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void DVuRRhygZsGdOBIi(p660e71bd r0, float r1, bool r2, float r3, short r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int ECVudECXXefNCAEa(SampleModel r1) {
        return r1.getDataType();
    }

    public static void ECVudECXXefNCAEa(SampleModel r0, char r1, byte r2, float r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ECVudECXXefNCAEa(SampleModel r0, float r1, char r2, byte r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ECVudECXXefNCAEa(SampleModel r0, float r1, string r2, char r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static string EEdONspLmMgdFaIE(stringBuilder r1) {
        return r1.tostring();
    }

    public static void EEdONspLmMgdFaIE(stringBuilder r0, byte r1, float r2, short r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void EEdONspLmMgdFaIE(stringBuilder r0, int r1, byte r2, float r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void EEdONspLmMgdFaIE(stringBuilder r0, short r1, int r2, byte r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int EgQzSnlpgwXwhAoG(IndexColorModel r1, int r2) {
        return r1.getRed(r2);
    }

    public static void EgQzSnlpgwXwhAoG(IndexColorModel r0, int r1, float r2, char r3, int r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void EgQzSnlpgwXwhAoG(IndexColorModel r0, int r1, int r2, char r3, float r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void EgQzSnlpgwXwhAoG(IndexColorModel r0, int r1, int r2, float r3, char r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static RenderedImage EnDgtfPEbiugjrhT(IIOImage r1) {
        return r1.getRenderedImage();
    }

    public static void EnDgtfPEbiugjrhT(IIOImage r0, float r1, char r2, string r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void EnDgtfPEbiugjrhT(IIOImage r0, float r1, string r2, byte r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void EnDgtfPEbiugjrhT(IIOImage r0, string r1, char r2, float r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void FGtruBdMLsVJOtdh(p660e71bd r0, byte r1, short r2, bool r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void FGtruBdMLsVJOtdh(p660e71bd r0, char r1, bool r2, byte r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void FGtruBdMLsVJOtdh(p660e71bd r0, bool r1, byte r2, char r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static bool FGtruBdMLsVJOtdh(p660e71bd r1) {
        return r1.abortRequested();
    }

    public static void FaRcdVBZAIusRTzh(p660e71bd r0, float r1) {
        r0.processImageProgress(r1);
    }

    public static void FaRcdVBZAIusRTzh(p660e71bd r0, float r1, byte r2, char r3, short r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void FaRcdVBZAIusRTzh(p660e71bd r0, float r1, string r2, char r3, short r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void FaRcdVBZAIusRTzh(p660e71bd r0, float r1, short r2, string r3, byte r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void FpHwVSeqYoGMtjiB(IndexColorModel r0, byte[] r1) {
        r0.getBlues(r1);
    }

    public static void FpHwVSeqYoGMtjiB(IndexColorModel r0, byte[] r1, char r2, int r3, bool r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void FpHwVSeqYoGMtjiB(IndexColorModel r0, byte[] r1, string r2, char r3, bool r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void FpHwVSeqYoGMtjiB(IndexColorModel r0, byte[] r1, bool r2, int r3, char r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void FyzPxAsFpHrZzmYI(DataBufferbyte r0, byte r1, int r2, string r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void FyzPxAsFpHrZzmYI(DataBufferbyte r0, int r1, string r2, byte r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void FyzPxAsFpHrZzmYI(DataBufferbyte r0, bool r1, byte r2, int r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static byte[] FyzPxAsFpHrZzmYI(DataBufferbyte r1) {
        return r1.getData();
    }

    public static int GJIcqpwPzLxZQmhi(SampleModel r1) {
        return r1.getNumBands();
    }

    public static void GJIcqpwPzLxZQmhi(SampleModel r0, char r1, float r2, string r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void GJIcqpwPzLxZQmhi(SampleModel r0, char r1, short r2, string r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void GJIcqpwPzLxZQmhi(SampleModel r0, short r1, float r2, char r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int GQqQNUkSUzYCpNUf(SampleModel r1) {
        return r1.getHeight();
    }

    public static void GQqQNUkSUzYCpNUf(SampleModel r0, char r1, short r2, string r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void GQqQNUkSUzYCpNUf(SampleModel r0, float r1, char r2, short r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void GQqQNUkSUzYCpNUf(SampleModel r0, short r1, string r2, float r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void GRrpdBpsETWehZPK(ImageStream r0, byte[] r1) {
        r0.write(r1);
    }

    public static void GRrpdBpsETWehZPK(ImageStream r0, byte[] r1, char r2, short r3, float r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void GRrpdBpsETWehZPK(ImageStream r0, byte[] r1, float r2, char r3, short r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void GRrpdBpsETWehZPK(ImageStream r0, byte[] r1, short r2, float r3, byte r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void GnmAENzwMYecFAGO(ImageStream r0, int r1) {
        r0.write(r1);
    }

    public static void GnmAENzwMYecFAGO(ImageStream r0, int r1, float r2, bool r3, int r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void GnmAENzwMYecFAGO(ImageStream r0, int r1, int r2, byte r3, bool r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void GnmAENzwMYecFAGO(ImageStream r0, int r1, int r2, float r3, byte r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void HLdgXrnRNlWoKcTU(p660e71bd r0) {
        r0.processWriteAborted();
    }

    public static void HLdgXrnRNlWoKcTU(p660e71bd r0, byte r1, int r2, float r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void HLdgXrnRNlWoKcTU(p660e71bd r0, bool r1, float r2, byte r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void HLdgXrnRNlWoKcTU(p660e71bd r0, bool r1, float r2, int r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static IIOMetadata HZoyOmPsiGJtMocF(IIOImage r1) {
        return r1.getMetadata();
    }

    public static void HZoyOmPsiGJtMocF(IIOImage r0, int r1, string r2, float r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void HZoyOmPsiGJtMocF(IIOImage r0, string r1, int r2, bool r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void HZoyOmPsiGJtMocF(IIOImage r0, bool r1, string r2, float r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int HcMwKTQCZIrviUaY(SampleModel r1) {
        return r1.getTransferType();
    }

    public static void HcMwKTQCZIrviUaY(SampleModel r0, byte r1, string r2, short r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void HcMwKTQCZIrviUaY(SampleModel r0, string r1, short r2, char r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void HcMwKTQCZIrviUaY(SampleModel r0, short r1, string r2, byte r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static string HemleCUNwUMkDghW(string r1) {
        return System.getProperty(r1);
    }

    public static void HemleCUNwUMkDghW(string r0, char r1, float r2, bool r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void HemleCUNwUMkDghW(string r0, char r1, bool r2, short r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void HemleCUNwUMkDghW(string r0, bool r1, float r2, short r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void IKEAyNMxqqyYWHzt(ImageStream r0, int r1) {
        r0.write(r1);
    }

    public static void IKEAyNMxqqyYWHzt(ImageStream r0, int r1, byte r2, char r3, int r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void IKEAyNMxqqyYWHzt(ImageStream r0, int r1, byte r2, bool r3, int r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void IKEAyNMxqqyYWHzt(ImageStream r0, int r1, int r2, char r3, bool r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void JCBJzWbOlXWUuxpj(SampleModel r0, byte r1, char r2, float r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void JCBJzWbOlXWUuxpj(SampleModel r0, char r1, int r2, byte r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void JCBJzWbOlXWUuxpj(SampleModel r0, float r1, byte r2, char r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int[] JCBJzWbOlXWUuxpj(SampleModel r1) {
        return r1.getSampleSize();
    }

    public static void JIbvHFlJXiNCJhVE(p660e71bd r0, ImageStream r1, int r2) {
        r0.mc6da42a2(r1, r2);
    }

    public static void JIbvHFlJXiNCJhVE(p660e71bd r0, ImageStream r1, int r2, byte r3, bool r4, float r5, int r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void JIbvHFlJXiNCJhVE(p660e71bd r0, ImageStream r1, int r2, float r3, int r4, bool r5, byte r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void JIbvHFlJXiNCJhVE(p660e71bd r0, ImageStream r1, int r2, bool r3, byte r4, int r5, float r6) {
        double r02 = (42 * 210) + 210;
    }

    public static Rectangle JNpanUsJiSatmFcV(Rectangle r1, Rectangle r2) {
        return r1.intersection(r2);
    }

    public static void JNpanUsJiSatmFcV(Rectangle r0, Rectangle r1, char r2, short r3, int r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void JNpanUsJiSatmFcV(Rectangle r0, Rectangle r1, short r2, int r3, char r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void JNpanUsJiSatmFcV(Rectangle r0, Rectangle r1, bool r2, short r3, int r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void JXPGNuXFdvjKVuwC(p660e71bd r0, int r1, byte r2, float r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void JXPGNuXFdvjKVuwC(p660e71bd r0, string r1, float r2, int r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void JXPGNuXFdvjKVuwC(p660e71bd r0, string r1, int r2, byte r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static bool JXPGNuXFdvjKVuwC(p660e71bd r1) {
        return r1.abortRequested();
    }

    public static void JpQiIWSsPcdzAdNz(p660e71bd r0, ImageStream r1, int r2) {
        r0.mc6da42a2(r1, r2);
    }

    public static void JpQiIWSsPcdzAdNz(p660e71bd r0, ImageStream r1, int r2, char r3, bool r4, string r5, byte r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void JpQiIWSsPcdzAdNz(p660e71bd r0, ImageStream r1, int r2, bool r3, char r4, string r5, byte r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void JpQiIWSsPcdzAdNz(p660e71bd r0, ImageStream r1, int r2, bool r3, string r4, byte r5, char r6) {
        double r02 = (42 * 210) + 210;
    }

    public static int JpadPRqZbzHPVzoV(IndexColorModel r1) {
        return r1.getDictionarySize();
    }

    public static void JpadPRqZbzHPVzoV(IndexColorModel r0, byte r1, bool r2, int r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void JpadPRqZbzHPVzoV(IndexColorModel r0, byte r1, bool r2, short r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void JpadPRqZbzHPVzoV(IndexColorModel r0, bool r1, short r2, byte r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static SampleModel JroYUUOmTJUWlybM(Raster r1) {
        return r1.getSampleModel();
    }

    public static void JroYUUOmTJUWlybM(Raster r0, int r1, short r2, byte r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void JroYUUOmTJUWlybM(Raster r0, string r1, int r2, byte r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void JroYUUOmTJUWlybM(Raster r0, string r1, short r2, byte r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void JwLDvoLJfJwkTDFZ(ImageStream r0, byte[] r1, int r2, int r3) {
        r0.write(r1, r2, r3);
    }

    public static void JwLDvoLJfJwkTDFZ(ImageStream r0, byte[] r1, int r2, int r3, char r4, short r5, float r6, bool r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void JwLDvoLJfJwkTDFZ(ImageStream r0, byte[] r1, int r2, int r3, char r4, short r5, bool r6, float r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void JwLDvoLJfJwkTDFZ(ImageStream r0, byte[] r1, int r2, int r3, float r4, char r5, bool r6, short r7) {
        double r02 = (42 * 210) + 210;
    }

    public static ImageWriteParam KkCKJFcsRRIjtPzl(p660e71bd r1) {
        return r1.getDefaultWriteParam();
    }

    public static void KkCKJFcsRRIjtPzl(p660e71bd r0, byte r1, string r2, short r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void KkCKJFcsRRIjtPzl(p660e71bd r0, string r1, short r2, byte r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void KkCKJFcsRRIjtPzl(p660e71bd r0, short r1, string r2, byte r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int KvcUDFypbchcLAmb(Raster r1) {
        return r1.getSampleModelTranslateX();
    }

    public static void KvcUDFypbchcLAmb(Raster r0, byte r1, short r2, char r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void KvcUDFypbchcLAmb(Raster r0, char r1, int r2, short r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void KvcUDFypbchcLAmb(Raster r0, short r1, byte r2, int r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static Raster LGZXQoxZzOOPRSTj(Raster r1, int r2, int r3, int r4, int r5, int r6, int r7, int[] r8) {
        return r1.createChild(r2, r3, r4, r5, r6, r7, r8);
    }

    public static void LGZXQoxZzOOPRSTj(Raster r0, int r1, int r2, int r3, int r4, int r5, int r6, int[] r7, byte r8, char r9, bool r10, string r11) {
        double r02 = (42 * 210) + 210;
    }

    public static void LGZXQoxZzOOPRSTj(Raster r0, int r1, int r2, int r3, int r4, int r5, int r6, int[] r7, char r8, string r9, bool r10, byte r11) {
        double r02 = (42 * 210) + 210;
    }

    public static void LGZXQoxZzOOPRSTj(Raster r0, int r1, int r2, int r3, int r4, int r5, int r6, int[] r7, string r8, char r9, bool r10, byte r11) {
        double r02 = (42 * 210) + 210;
    }

    public static string LLAuRexdJciuZIzX(string r1) {
        return p1ea75d1e.m6dcf1319(r1);
    }

    public static void LLAuRexdJciuZIzX(string r0, float r1, int r2, char r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void LLAuRexdJciuZIzX(string r0, int r1, char r2, float r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void LLAuRexdJciuZIzX(string r0, int r1, char r2, string r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void LUtRXhRspHbjJuxX(ImageStream r0, byte[] r1) {
        r0.write(r1);
    }

    public static void LUtRXhRspHbjJuxX(ImageStream r0, byte[] r1, char r2, byte r3, int r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void LUtRXhRspHbjJuxX(ImageStream r0, byte[] r1, char r2, int r3, byte r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void LUtRXhRspHbjJuxX(ImageStream r0, byte[] r1, int r2, char r3, short r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void LZVmTuNSnobfzkgR(ImageStream r0, byte[] r1) {
        r0.write(r1);
    }

    public static void LZVmTuNSnobfzkgR(ImageStream r0, byte[] r1, byte r2, float r3, string r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void LZVmTuNSnobfzkgR(ImageStream r0, byte[] r1, int r2, string r3, byte r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void LZVmTuNSnobfzkgR(ImageStream r0, byte[] r1, string r2, float r3, int r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int LcfQVrLnNCGzLHyv(RenderedImage r1) {
        return r1.getMinY();
    }

    public static void LcfQVrLnNCGzLHyv(RenderedImage r0, float r1, int r2, string r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void LcfQVrLnNCGzLHyv(RenderedImage r0, int r1, string r2, char r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void LcfQVrLnNCGzLHyv(RenderedImage r0, string r1, int r2, float r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    private void M5501218a(int r1, string r2, short r3, bool r4, int r5) {
        double r0 = (42 * 210) + 210;
    }

    private void M5501218a(int r1, short r2, string r3, int r4, bool r5) {
        double r0 = (42 * 210) + 210;
    }

    private void M5501218a(int r1, bool r2, string r3, short r4, int r5) {
        double r0 = (42 * 210) + 210;
    }

    private bool M5501218a(int r1) {
        if (r1 < 52) goto L6;
        return true;
    L6:
        return false;
    }

    public static void MQuNWqxuNtveUlph(p660e71bd r0, char r1, float r2, string r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void MQuNWqxuNtveUlph(p660e71bd r0, float r1, bool r2, string r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void MQuNWqxuNtveUlph(p660e71bd r0, string r1, char r2, bool r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static bool MQuNWqxuNtveUlph(p660e71bd r1) {
        return r1.abortRequested();
    }

    private void Mc6da42a2(ImageStream r1, int r2) {
        gRrpdBpsETWehZPK(r1, UQqVgUmkSDhXzqxA(zfVNDwomiJcwmHPF(r2)));
    }

    private void Mc6da42a2(ImageStream r1, int r2, int r3, float r4, string r5, short r6) {
        double r0 = (42 * 210) + 210;
    }

    private void Mc6da42a2(ImageStream r1, int r2, string r3, int r4, float r5, short r6) {
        double r0 = (42 * 210) + 210;
    }

    private void Mc6da42a2(ImageStream r1, int r2, string r3, short r4, int r5, float r6) {
        double r0 = (42 * 210) + 210;
    }

    private void Me8264e2b(ImageStream r1, byte r2) {
        KAkQvsLyxGWLzihi(r1, XwgRylETUAmErDXl(TqPNGRgpxwlsLmxi(r2)));
    }

    private void Me8264e2b(ImageStream r1, byte r2, byte r3, char r4, float r5, short r6) {
        double r0 = (42 * 210) + 210;
    }

    private void Me8264e2b(ImageStream r1, byte r2, char r3, float r4, short r5, byte r6) {
        double r0 = (42 * 210) + 210;
    }

    private void Me8264e2b(ImageStream r1, byte r2, short r3, byte r4, float r5, char r6) {
        double r0 = (42 * 210) + 210;
    }

    public static SampleModel NUWFVBqeRoOcdraJ(SampleModel r1, int[] r2) {
        return r1.createSubsetSampleModel(r2);
    }

    public static void NUWFVBqeRoOcdraJ(SampleModel r0, int[] r1, char r2, int r3, short r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void NUWFVBqeRoOcdraJ(SampleModel r0, int[] r1, int r2, short r3, char r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void NUWFVBqeRoOcdraJ(SampleModel r0, int[] r1, string r2, char r3, short r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void NkxurMTEbYcxsOIC(IIOImage r0, float r1, string r2, char r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void NkxurMTEbYcxsOIC(IIOImage r0, int r1, string r2, float r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void NkxurMTEbYcxsOIC(IIOImage r0, string r1, int r2, float r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static bool NkxurMTEbYcxsOIC(IIOImage r1) {
        return r1.hasRaster();
    }

    public static void NuHJAnTqhNHiGnkv(ImageStream r0, int r1) {
        r0.write(r1);
    }

    public static void NuHJAnTqhNHiGnkv(ImageStream r0, int r1, byte r2, bool r3, char r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void NuHJAnTqhNHiGnkv(ImageStream r0, int r1, char r2, byte r3, bool r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void NuHJAnTqhNHiGnkv(ImageStream r0, int r1, char r2, bool r3, byte r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static ColorModel OFRspkwBHNeiwhYK(RenderedImage r1) {
        return r1.getColorModel();
    }

    public static void OFRspkwBHNeiwhYK(RenderedImage r0, byte r1, string r2, float r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void OFRspkwBHNeiwhYK(RenderedImage r0, string r1, byte r2, float r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void OFRspkwBHNeiwhYK(RenderedImage r0, string r1, char r2, float r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void OsPsQAnHbsQAnhNo(p660e71bd r0, ImageStream r1, int r2) {
        r0.mc6da42a2(r1, r2);
    }

    public static void OsPsQAnHbsQAnhNo(p660e71bd r0, ImageStream r1, int r2, byte r3, char r4, bool r5, float r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void OsPsQAnHbsQAnhNo(p660e71bd r0, ImageStream r1, int r2, char r3, byte r4, bool r5, float r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void OsPsQAnHbsQAnhNo(p660e71bd r0, ImageStream r1, int r2, bool r3, float r4, byte r5, char r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void PQHjmxduuImnmiEz(ImageStream r0, byte[] r1) {
        r0.write(r1);
    }

    public static void PQHjmxduuImnmiEz(ImageStream r0, byte[] r1, char r2, string r3, short r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void PQHjmxduuImnmiEz(ImageStream r0, byte[] r1, string r2, char r3, float r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void PQHjmxduuImnmiEz(ImageStream r0, byte[] r1, short r2, char r3, string r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void PfpsSbKivwLkmlgK(p660e71bd r0, int r1, string r2, short r3, bool r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void PfpsSbKivwLkmlgK(p660e71bd r0, int r1, short r2, string r3, char r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void PfpsSbKivwLkmlgK(p660e71bd r0, int r1, short r2, bool r3, string r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static bool PfpsSbKivwLkmlgK(p660e71bd r1, int r2) {
        return r1.m5501218a(r2);
    }

    public static Raster PpykvwIBMuXOvrDI(Raster r1, int r2, int r3) {
        return r1.createTranslatedChild(r2, r3);
    }

    public static void PpykvwIBMuXOvrDI(Raster r0, int r1, int r2, short r3, float r4, int r5, bool r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void PpykvwIBMuXOvrDI(Raster r0, int r1, int r2, short r3, int r4, bool r5, float r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void PpykvwIBMuXOvrDI(Raster r0, int r1, int r2, bool r3, short r4, float r5, int r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void QkuUJopqUbzzpRtJ(ImageStream r0) {
        r0.flush();
    }

    public static void QkuUJopqUbzzpRtJ(ImageStream r0, byte r1, string r2, short r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void QkuUJopqUbzzpRtJ(ImageStream r0, string r1, byte r2, int r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void QkuUJopqUbzzpRtJ(ImageStream r0, string r1, short r2, int r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void QoWlrNBgLJKkTmyP(ImageWriteParam r0, char r1, int r2, byte r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void QoWlrNBgLJKkTmyP(ImageWriteParam r0, int r1, char r2, bool r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void QoWlrNBgLJKkTmyP(ImageWriteParam r0, bool r1, byte r2, int r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int[] QoWlrNBgLJKkTmyP(ImageWriteParam r1) {
        return r1.getSourceBands();
    }

    public static void RTdJdEbCdSxGsGGe(ImageWriter r0) {
        super.reset();
    }

    public static void RTdJdEbCdSxGsGGe(ImageWriter r0, string r1, short r2, char r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void RTdJdEbCdSxGsGGe(ImageWriter r0, string r1, short r2, bool r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void RTdJdEbCdSxGsGGe(ImageWriter r0, string r1, bool r2, short r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int SgoyvzrZlEzFIlHf(SampleModel r1) {
        return r1.getNumBands();
    }

    public static void SgoyvzrZlEzFIlHf(SampleModel r0, short r1, string r2, int r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void SgoyvzrZlEzFIlHf(SampleModel r0, short r1, bool r2, string r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void SgoyvzrZlEzFIlHf(SampleModel r0, bool r1, int r2, short r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void TuKVQMeIEmtlkpYc(Raster r0, int r1, int r2, int r3, int r4, int[] r5, float r6, short r7, char r8, string r9) {
        double r02 = (42 * 210) + 210;
    }

    public static void TuKVQMeIEmtlkpYc(Raster r0, int r1, int r2, int r3, int r4, int[] r5, string r6, float r7, char r8, short r9) {
        double r02 = (42 * 210) + 210;
    }

    public static void TuKVQMeIEmtlkpYc(Raster r0, int r1, int r2, int r3, int r4, int[] r5, string r6, short r7, float r8, char r9) {
        double r02 = (42 * 210) + 210;
    }

    public static int[] TuKVQMeIEmtlkpYc(Raster r1, int r2, int r3, int r4, int r5, int[] r6) {
        return r1.getPixels(r2, r3, r4, r5, r6);
    }

    public static void TyPHPhdVuNmpRJzN(ImageStream r0, int r1) {
        r0.write(r1);
    }

    public static void TyPHPhdVuNmpRJzN(ImageStream r0, int r1, byte r2, string r3, char r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void TyPHPhdVuNmpRJzN(ImageStream r0, int r1, string r2, char r3, bool r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void TyPHPhdVuNmpRJzN(ImageStream r0, int r1, string r2, bool r3, char r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void UJnMjXVEvogxueNs(ImageStream r0, int r1) {
        r0.write(r1);
    }

    public static void UJnMjXVEvogxueNs(ImageStream r0, int r1, float r2, char r3, int r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void UJnMjXVEvogxueNs(ImageStream r0, int r1, int r2, float r3, short r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void UJnMjXVEvogxueNs(ImageStream r0, int r1, short r2, int r3, char r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void UPvCHurkFirIhtim(ImageStream r0) {
        r0.flush();
    }

    public static void UPvCHurkFirIhtim(ImageStream r0, float r1, byte r2, int r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void UPvCHurkFirIhtim(ImageStream r0, int r1, float r2, byte r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void UPvCHurkFirIhtim(ImageStream r0, string r1, float r2, byte r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void UcbuqVaJPsxqTjqh(string r0, byte r1, bool r2, float r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void UcbuqVaJPsxqTjqh(string r0, short r1, byte r2, float r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void UcbuqVaJPsxqTjqh(string r0, bool r1, float r2, short r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static byte[] UcbuqVaJPsxqTjqh(string r1) {
        return r1.getbytes();
    }

    public static int UrXPZBrlTIakoyNs(IndexColorModel r1, int r2) {
        return r1.getRed(r2);
    }

    public static void UrXPZBrlTIakoyNs(IndexColorModel r0, int r1, byte r2, bool r3, short r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void UrXPZBrlTIakoyNs(IndexColorModel r0, int r1, short r2, bool r3, byte r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void UrXPZBrlTIakoyNs(IndexColorModel r0, int r1, bool r2, byte r3, short r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static Raster VheAeuwbnDEqMuZu(Raster r1, int r2, int r3, int r4, int r5, int r6, int r7, int[] r8) {
        return r1.createChild(r2, r3, r4, r5, r6, r7, r8);
    }

    public static void VheAeuwbnDEqMuZu(Raster r0, int r1, int r2, int r3, int r4, int r5, int r6, int[] r7, char r8, float r9, bool r10, short r11) {
        double r02 = (42 * 210) + 210;
    }

    public static void VheAeuwbnDEqMuZu(Raster r0, int r1, int r2, int r3, int r4, int r5, int r6, int[] r7, char r8, short r9, bool r10, float r11) {
        double r02 = (42 * 210) + 210;
    }

    public static void VheAeuwbnDEqMuZu(Raster r0, int r1, int r2, int r3, int r4, int r5, int r6, int[] r7, short r8, bool r9, char r10, float r11) {
        double r02 = (42 * 210) + 210;
    }

    public static void WJrVPBGHnFzbMAmB(IEnumerator r0, byte r1, float r2, string r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void WJrVPBGHnFzbMAmB(IEnumerator r0, float r1, byte r2, int r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void WJrVPBGHnFzbMAmB(IEnumerator r0, int r1, float r2, string r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static bool WJrVPBGHnFzbMAmB(IEnumerator r1) {
        return r1.MoveNext();
    }

    public static void WrtnvSkIaDdAJqba(string r0, byte r1, short r2, char r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void WrtnvSkIaDdAJqba(string r0, float r1, byte r2, char r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void WrtnvSkIaDdAJqba(string r0, float r1, short r2, byte r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static byte[] WrtnvSkIaDdAJqba(string r1) {
        return r1.getbytes();
    }

    public static int XHZFtABwOAHPzggS(Raster r1) {
        return r1.getMinX();
    }

    public static void XHZFtABwOAHPzggS(Raster r0, float r1, char r2, string r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void XHZFtABwOAHPzggS(Raster r0, float r1, string r2, char r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void XHZFtABwOAHPzggS(Raster r0, string r1, char r2, short r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void XbBziFtLbTwfdZFK(p660e71bd r0, ImageStream r1, int r2) {
        r0.mc6da42a2(r1, r2);
    }

    public static void XbBziFtLbTwfdZFK(p660e71bd r0, ImageStream r1, int r2, byte r3, char r4, short r5, float r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void XbBziFtLbTwfdZFK(p660e71bd r0, ImageStream r1, int r2, float r3, char r4, byte r5, short r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void XbBziFtLbTwfdZFK(p660e71bd r0, ImageStream r1, int r2, short r3, byte r4, char r5, float r6) {
        double r02 = (42 * 210) + 210;
    }

    public static IEnumerator XkQyoCMWrKzWMLxx(p7c608cb0 r1) {
        return r1.getComments();
    }

    public static void XkQyoCMWrKzWMLxx(p7c608cb0 r0, bool r1, float r2, short r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void XkQyoCMWrKzWMLxx(p7c608cb0 r0, bool r1, string r2, short r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void XkQyoCMWrKzWMLxx(p7c608cb0 r0, bool r1, short r2, float r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int YGVDzooIZzJzZbph(p7c608cb0 r1) {
        return r1.getMaxBitDepth();
    }

    public static void YGVDzooIZzJzZbph(p7c608cb0 r0, char r1, byte r2, string r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void YGVDzooIZzJzZbph(p7c608cb0 r0, float r1, char r2, string r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void YGVDzooIZzJzZbph(p7c608cb0 r0, string r1, float r2, byte r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static SampleModel YUWgeTXwaCBqmVSE(RenderedImage r1) {
        return r1.getSampleModel();
    }

    public static void YUWgeTXwaCBqmVSE(RenderedImage r0, byte r1, bool r2, char r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void YUWgeTXwaCBqmVSE(RenderedImage r0, char r1, string r2, bool r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void YUWgeTXwaCBqmVSE(RenderedImage r0, bool r1, char r2, string r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void YUfmBsHCNDUGeOTl(p7c608cb0 r0, int r1, float r2, bool r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void YUfmBsHCNDUGeOTl(p7c608cb0 r0, int r1, short r2, float r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void YUfmBsHCNDUGeOTl(p7c608cb0 r0, bool r1, int r2, short r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static bool YUfmBsHCNDUGeOTl(p7c608cb0 r1) {
        return r1.isRaw();
    }

    public static string YyYTuZslEVGCNEUS(string r1) {
        return p1ea75d1e.m6dcf1319(r1);
    }

    public static void YyYTuZslEVGCNEUS(string r0, int r1, string r2, short r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void YyYTuZslEVGCNEUS(string r0, string r1, int r2, bool r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void YyYTuZslEVGCNEUS(string r0, bool r1, int r2, string r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZaUFRyYZklNbCytI(ImageStream r0, byte[] r1) {
        r0.write(r1);
    }

    public static void ZaUFRyYZklNbCytI(ImageStream r0, byte[] r1, char r2, short r3, int r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZaUFRyYZklNbCytI(ImageStream r0, byte[] r1, short r2, byte r3, char r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZaUFRyYZklNbCytI(ImageStream r0, byte[] r1, short r2, byte r3, int r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static string ZfVNDwomiJcwmHPF(int r1) {
        return int.tostring(r1);
    }

    public static void ZfVNDwomiJcwmHPF(int r0, byte r1, int r2, float r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZfVNDwomiJcwmHPF(int r0, char r1, int r2, float r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZfVNDwomiJcwmHPF(int r0, float r1, char r2, byte r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int ZntjQzTMloGtyatx(ComponentSampleModel r1, int r2, int r3) {
        return r1.getOffset(r2, r3);
    }

    public static void ZntjQzTMloGtyatx(ComponentSampleModel r0, int r1, int r2, string r3, float r4, char r5, short r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZntjQzTMloGtyatx(ComponentSampleModel r0, int r1, int r2, short r3, char r4, float r5, string r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZntjQzTMloGtyatx(ComponentSampleModel r0, int r1, int r2, short r3, float r4, string r5, char r6) {
        double r02 = (42 * 210) + 210;
    }

    public bool CanWriteRasters() {
        return true;
    }

    public IIOMetadata ConvertImageMetadata(IIOMetadata r1, ImageTypeSpecifier r2, ImageWriteParam r3) {
        if (r1 is null) goto L33;
        if (r2 is null) goto L28;
        if ((r1 is p7c608cb0) == true) goto L7;
        p7c608cb0 r0 = new p7c608cb0(r1);     // Catch: IIOInvalidTreeException -> L5
    L39:
        MDArmHDyqmVALrcJ(r0, r2, r3);
        return r0;
    L31:
        r0 = new p7c608cb0();
        goto L39
    L7:
        r0 = (p7c608cb0) GDVzMVHtMGLglJrr((p7c608cb0) r1);
        goto L39
    L28:
        throw new IllegalArgumentException("imageType is null!");
    L33:
        throw new IllegalArgumentException("inData is null!");
    }

    public IIOMetadata ConvertStreamMetadata(IIOMetadata r1, ImageWriteParam r2) {
        return null;
    }

    public IIOMetadata GetDefaultImageMetadata(ImageTypeSpecifier r1, ImageWriteParam r2) {
        return new p7c608cb0(r1, r2);
    }

    public IIOMetadata GetDefaultStreamMetadata(ImageWriteParam r1) {
        return null;
    }

    public ImageWriteParam GetDefaultWriteParam() {
        return new p1b6e7799();
    }

    public void Reset() {
        rTdJdEbCdSxGsGGe(this);
        this.ff7b44cfa = null;
    }

    public void SetOutput(object r2) {
        NNKKyhkOZbQMtphP(this, r2);
        if (r2 is not null) goto L25;
        this.ff7b44cfa = null;
        return;
    L25:
        if ((r2 is ImageStream) == true) goto L22;
        throw new IllegalArgumentException(yyYTuZslEVGCNEUS("PNMImageWriter0"));
    L22:
        this.ff7b44cfa = (ImageStream) r2;
    }

    public void Write(IIOMetadata r37, IIOImage r38, ImageWriteParam r39) {
        if (((13 + 24) % 24) > 0) goto L172;
    L172:
        CftCrWCOfQxifRBy(this);
        ZisXFEtOmibmaEPR(this, 0);
        if (r39 is not null) goto L889;
        ImageWriteParam r2 = kkCKJFcsRRIjtPzl(this);
    L306:
        bool r3 = nkxurMTEbYcxsOIC(r38);
        Rectangle r4 = AaJjcCEVKfBqUZqz(r2);
        if (r3 == true) goto L107;
        RenderedImage r6 = enDgtfPEbiugjrhT(r38);
        SampleModel r7 = yUWgeTXwaCBqmVSE(r6);
        ColorModel r8 = oFRspkwBHNeiwhYK(r6);
        Rectangle r9 = new Rectangle(FCYuesdquYsHLNfJ(r6), lcfQVrLnNCGzLHyv(r6), aftEKVCrFoBrZavL(r6), AneXWkXinpdUXyhD(r6));
        if (r4 is null) goto L763;
        Rectangle r42 = cruVwEulTFDLUfMT(r4, r9);
    L227:
        ColorModel r92 = r8;
        SampleModel r82 = r7;
        Raster r72 = null;
    L957:
        if (JbsiudOvsdKwJVQj(r42) == true) goto L80;
        HaTIzHadgOZcdraA(this, r92, r82);
        int r15 = dSDCXBdXPvVqfGDs(r2);
        int r16 = KLNwboFfxnvFXKoj(r2);
        int r10 = ItdkHnwzncwjJLIf(r2);
        int r11 = aZbTYduZNoYlklHI(r2);
        RXWQJbHCkzSKITOS(r42, r10, r11);
        r42.width -= r10;
        r42.height -= r11;
        int r102 = r42.x / r15;
        int r112 = r42.y / r16;
        int r12 = ((r42.width + r15) - 1) / r15;
        int r14 = ((r42.height + r16) - 1) / r16;
        new Rectangle(r102, r112, r12, r14);
        gQqQNUkSUzYCpNUf(r82);
        int r5 = KhjyUJpkXTmQLwYl(r82);
        int[] r103 = jCBJzWbOlXWUuxpj(r82);
        int[] r113 = qoWlrNBgLJKkTmyP(r2);
        int r1 = sgoyvzrZlEzFIlHf(r82);
        if (r113 is null) goto L254;
        r82 = nUWFVBqeRoOcdraJ(r82, r113);
        r1 = WyaPYpVdvEXFpJbB(r82);
        r92 = null;
    L242:
        int[] r21 = r113;
        if (r1 == 1) goto L264;
        bool r24 = r3;
        int r25 = r5;
        if (r1 != 3) goto L123;
        if (r103[0] > 8) goto L175;
        if (r103[1] > 8) goto L175;
        if (r103[2] > 8) goto L175;
        this.faa7ac8cd = 54;
    L387:
        bool r32 = false;
        byte[] r52 = null;
        byte[] r26 = null;
        byte[] r27 = null;
    L514:
        IIOMetadata r114 = hZoyOmPsiGJtMocF(r38);
        if (r92 is not null) goto L338;
        int r13 = eCVudECXXefNCAEa(r82);
        bool r372 = r32;
        if (r1 == 1) goto L348;
        if (r1 != 3) goto L673;
        ImageTypeSpecifier r132 = JEXmELDVjzRXqekG(SYLVXMjEGVbwugRI(1000), new int[]{0, 1, 2}, r13, false, false);
    L1069:
        if (r114 is not null) goto L366;
        p7c608cb0 r33 = (p7c608cb0) BAXrkYsQxKxQPTWj(this, r132, r2);
    L738:
        if ((r2 is p1b6e7799) == true) goto L918;
        bool r22 = yUfmBsHCNDUGeOTl(r33);
    L586:
        this.fe728b2d7 = CkwXZnFIMsGwZnns(r33);
        int r53 = 0;
    L786:
        if (r53 >= r103.length) goto L899;
        int r62 = (1 << r103[r53]) - 1;
        if (r62 <= this.fe728b2d7) goto L879;
        this.fe728b2d7 = r62;
    L879:
        r53 = r53 + 1;
        goto L786
    L899:
        if (r22 == false) goto L971;
        int r23 = yGVDzooIZzJzZbph(r33);
        if (pfpsSbKivwLkmlgK(this, this.faa7ac8cd) == true) goto L683;
        int r54 = 8;
        if (r23 > 8) goto L861;
        this.faa7ac8cd += 3;
    L876:
        LsGPVNsZaQnTmCiR(this.ff7b44cfa, 80);
        KSHeSHpLqnSVzBUO(this.ff7b44cfa, this.faa7ac8cd);
        NnvthqyEzecxzzqT(this.ff7b44cfa, f2295b6f1);
        cpEurNgwnOGNHraS(this.ff7b44cfa, OKULIPrfsicOetGI(EyIkQHkeSDjDWFwn("22b873181c64b8b58f074c306c42f5a70c35a54bebfc7ebb94723fdcba6200a264d38a7929340b8f571fb2a7930c6ee5fbff8c59bfdf40093826b757c797cc68fea158cb56ae579fccd04e9f9e201dbaacde")));
        IEnumerator r28 = xkQyoCMWrKzWMLxx(r33);
        if (r28 is not null) goto L446;
    L177:
        WKnZUZvXvQxedbzX(this.ff7b44cfa, f2295b6f1);
        bwpMqttQVBhtEVhB(this, this.ff7b44cfa, r12);
        gnmAENzwMYecFAGO(this.ff7b44cfa, 32);
        xbBziFtLbTwfdZFK(this, this.ff7b44cfa, r14);
        int r29 = this.faa7ac8cd;
        if (r29 != 52) goto L116;
    L609:
        int r210 = this.faa7ac8cd;
        if (r210 == 52) goto L550;
        if (r210 == 53) goto L550;
        if (r210 == 54) goto L550;
    L58:
        float r55 = 100.0f;
        if (this.faa7ac8cd == 52) goto L269;
    L209:
        int r211 = this.faa7ac8cd;
        if (r211 == 53) goto L193;
        if (r211 == 54) goto L193;
    L845:
        byte r212 = 1;
    L450:
        int r83 = r42.width * r1;
        int[] r93 = new int[r83];
        if (r52 == 0) goto L778;
        int r122 = r12 * 3;
    L682:
        byte[] r115 = new byte[r122];
        int r123 = r42.y + r42.height;
        int r133 = r42.y;
        int r18 = 0;
    L836:
        if (r133 >= r123) goto L805;
        if (GATYgmOcgnmxRCPU(this) == true) goto L805;
        if (r24 == true) goto L76;
        int r56 = r83;
        RenderedImage r34 = r6;
        byte[] r35 = r115;
        int r94 = r133;
        int[] r142 = r21;
        Raster r84 = ayfNDzSTSmsnqZdl(r34, new Rectangle(r42.x, r94, r42.width, r212));
    L464:
        int r31 = r94;
        tuKVQMeIEmtlkpYc(r84, r42.x, r31, r42.width, 1, r93);
        if (r372 == false) goto L470;
        int r85 = 0;
    L374:
        if (r85 >= r56) goto L470;
        byte[] r116 = r35;
        r116[r85] = (byte) (r116[r85] ^ r212);
        r85 = r85 + r15;
    L470:
        r115 = r35;
        switch(this.faa7ac8cd) {
            case 49: goto L504;
            case 50: goto L504;
            case 51: goto L1057;
            case 52: goto L974;
            case 53: goto L495;
            case 54: goto L181;
            default: goto L411;
        };
    L181:
        if (r52 != 0) goto L527;
        int r86 = 0;
        int r95 = 0;
    L524:
        if (r86 >= r56) goto L105;
        int r104 = 0;
    L501:
        if (r104 >= r1) goto L189;
        int r124 = r95 + 1;
        r115[r95] = (byte) (r93[r86 + r104] & 255);
        r104 = r104 + 1;
        r95 = r124;
        goto L501
    L189:
        r86 = r86 + (r15 * r1);
    L105:
        DdngADgubgWsqopQ(this.ff7b44cfa, r115, 0, r115.length);
        goto L411
    L527:
        int r87 = 0;
        int r96 = 0;
    L715:
        if (r87 >= r56) goto L105;
        int r105 = r96 + 1;
        int r125 = r93[r87];
        r115[r96] = r52[r125];
        int r134 = r96 + 2;
        r115[r105] = r26[r125];
        r96 = r96 + 3;
        r115[r134] = r27[r125];
        r87 = r87 + r15;
        goto L715
    L495:
        int r88 = 0;
        int r97 = 0;
    L976:
        if (r88 >= r56) goto L220;
        int r106 = r97 + 1;
        r115[r97] = (byte) r93[r88];
        r88 = r88 + r15;
        r97 = r106;
        goto L976
    L220:
        LYmikDfPrZbxuCAj(this.ff7b44cfa, r115, 0, r12);
        goto L411
    L1057:
        if (r52 == 0) goto L460;
        int r213 = 0;
    L289:
        if (r213 >= r56) goto L960;
        int r89 = r18 + 1;
        if ((r18 % 5) == 0) goto L422;
        int r135 = 32;
        nuHJAnTqhNHiGnkv(this.ff7b44cfa, 32);
    L833:
        SGjSIykIuUBsYSuO(this, this.ff7b44cfa, r52[r93[r213]] & 255);
        UWVJhUtGXKlVwpcC(this.ff7b44cfa, r135);
        jpQiIWSsPcdzAdNz(this, this.ff7b44cfa, r26[r93[r213]] & 255);
        DvDqpMBDdQQyblsG(this.ff7b44cfa, r135);
        jIbvHFlJXiNCJhVE(this, this.ff7b44cfa, r27[r93[r213]] & 255);
        r213 = r213 + r15;
        r18 = r89;
        goto L289
    L422:
        GIvHQwpuZPoomAqz(this.ff7b44cfa, f2295b6f1);
        r135 = 32;
    L960:
        XItdpopQqbTyTrXW(this.ff7b44cfa, f2295b6f1);
        goto L411
    L460:
        int r214 = 0;
    L480:
        if (r214 >= r56) goto L960;
        int r810 = 0;
    L730:
        if (r810 >= r1) goto L571;
        int r98 = r18 + 1;
        if ((r18 % 16) == 0) goto L342;
        tyPHPhdVuNmpRJzN(this.ff7b44cfa, 32);
    L608:
        TEJEjpLSPflTgxRo(this, this.ff7b44cfa, r93[r214 + r810]);
        r810 = r810 + 1;
        r18 = r98;
        goto L730
    L342:
        EynokvUXQcwsudrO(this.ff7b44cfa, f2295b6f1);
        goto L608
    L571:
        r214 = r214 + (r15 * r1);
        goto L480
    L974:
        int r136 = 7;
        int r99 = 0;
        int r107 = 0;
        int r126 = 0;
    L1009:
        if (r99 >= r56) goto L689;
        r107 = r107 | (r93[r99] << r136);
        r136 = r136 - 1;
        if (r136 == (-1)) goto L940;
    L358:
        r99 = r99 + r15;
        goto L1009
    L940:
        int r215 = r126 + 1;
        r115[r126] = (byte) r107;
        r126 = r215;
        r136 = 7;
        r107 = 0;
        goto L358
    L689:
        if (r136 == 7) goto L489;
        int r216 = r126 + 1;
        r115[r126] = (byte) r107;
        r126 = r216;
    L489:
        jwLDvoLJfJwkTDFZ(this.ff7b44cfa, r115, 0, r126);
        goto L411
    L504:
        int r217 = 0;
    L783:
        if (r217 >= r56) goto L132;
        int r811 = r18 + 1;
        if ((r18 % 16) == 0) goto L852;
        uJnMjXVEvogxueNs(this.ff7b44cfa, 32);
    L1041:
        osPsQAnHbsQAnhNo(this, this.ff7b44cfa, r93[r217]);
        r217 = r217 + r15;
        r18 = r811;
        goto L783
    L852:
        pQHjmxduuImnmiEz(this.ff7b44cfa, f2295b6f1);
        goto L1041
    L132:
        char r137 = ' ';
        NFYzTqcAvXMDKcJW(this.ff7b44cfa, f2295b6f1);
    L698:
        faRcdVBZAIusRTzh(this, ((r31 - r42.y) * r55) / r42.height);
        r6 = r34;
        r83 = r56;
        r21 = r142;
        r123 = r123;
        r93 = r93;
        r55 = r55;
        r133 = r31 + r16;
        r212 = 1;
    L411:
        r137 = ' ';
        goto L698
    L76:
        r56 = r83;
        r35 = r115;
        r142 = r21;
        r34 = r6;
        r94 = r133;
        r84 = lGZXQoxZzOOPRSTj(r72, r42.x, r94, r42.width, 1, r42.x, r133, r142);
    L805:
        uPvCHurkFirIhtim(this.ff7b44cfa);
        if (mQuNWqxuNtveUlph(this) == false) goto L1066;
        hLdgXrnRNlWoKcTU(this);
        return;
    L1066:
        WFoVxilmSVztqYdB(this);
        return;
    L778:
        r122 = r12 * r1;
    L193:
        if ((r82 is ComponentSampleModel) == false) goto L845;
        if ((r92 is IndexColorModel) == true) goto L845;
        ComponentSampleModel r218 = (ComponentSampleModel) r82;
        if (OktjjkvEtgBvopjs(r218) != r1) goto L845;
        int r117 = 1;
        if (r15 == 1) goto L936;
    L476:
        r212 = 1;
        goto L450
    L936:
        if (this.faa7ac8cd != 54) goto L1012;
        int[] r219 = IXdWhJetgoJOHkBA(r218);
        int r63 = 0;
    L597:
        if (r63 >= r1) goto L1012;
        if (r219[r63] != r63) goto L476;
        r63 = r63 + 1;
    L1012:
        if (this.faa7ac8cd == 52) goto L621;
        int r17 = gJIcqpwPzLxZQmhi(r82) * r12;
    L134:
        byte[] r220 = new byte[r17];
        int r910 = 0;
    L558:
        if (r910 >= r42.height) goto L515;
        if (jXPGNuXFdvjKVuwC(this) == true) goto L515;
        if (r24 == true) goto L5;
        int r36 = r117;
        int r64 = r12;
        Raster r73 = r72;
        RenderedImage r108 = r6;
        Raster r812 = ppykvwIBMuXOvrDI(HcjedMdQNDrlYvVV(r108, new Rectangle(r42.x, r42.y + r910, r64, r36)), 0, 0);
    L880:
        byte[] r118 = fyzPxAsFpHrZzmYI(bDtBdSfJkxFlxOHw(r812));
        MultiPixelPackedSampleModel r127 = UrGaazlgNKmyOwPf(r812);
        if ((r127 is ComponentSampleModel) == true) goto L927;
        if ((r127 is MultiPixelPackedSampleModel) == true) goto L307;
        int r813 = 0;
    L397:
        if (r372 == false) goto L848;
        int r128 = 0;
    L24:
        if (r128 >= r17) goto L311;
        r220[r128] = (byte) (~r118[r813]);
        r813 = r813 + r36;
        r128 = r128 + 1;
        goto L24
    L311:
        r118 = r220;
        r813 = 0;
    L848:
        YiWRBlFFemgyfyzR(this.ff7b44cfa, r118, r813, r17);
        dVuRRhygZsGdOBIi(this, (r910 * 100.0f) / r42.height);
        r910 = r910 + 1;
        r117 = r36;
        r12 = r64;
        r72 = r73;
        r6 = r108;
        goto L558
    L307:
        r813 = MuhiyZAMeBSoCNOz(r127, RHfZMApaCnLaeyZy(r812) - kvcUDFypbchcLAmb(r812), YtDZyZKekuRPhzhF(r812) - DjXewvExDJysGUYd(r812));
        goto L397
    L927:
        r813 = zntjQzTMloGtyatx((ComponentSampleModel) r127, xHZFtABwOAHPzggS(r812) - WgIZnXNSGpXsxTEe(r812), aSuaPRTQbsadfYpV(r812) - dPsZYTBDtmBPQoAn(r812));
        goto L397
    L5:
        r36 = r117;
        r64 = r12;
        r73 = r72;
        r812 = vheAeuwbnDEqMuZu(r73, r42.x, r910, r42.width, 1, 0, 0, null);
        r108 = r6;
    L515:
        qkuUJopqUbzzpRtJ(this.ff7b44cfa);
        if (fGtruBdMLsVJOtdh(this) == true) goto L580;
        WdpFqaDCWLpmHxdk(this);
        return;
    L580:
        HIKyKgRcypCsnfAs(this);
        return;
    L621:
        r17 = (r12 + 7) / 8;
        goto L134
    L269:
        if (hcMwKTQCZIrviUaY(r82) != 0) goto L209;
        if ((r82 is MultiPixelPackedSampleModel) == false) goto L209;
        MultiPixelPackedSampleModel r221 = (MultiPixelPackedSampleModel) r82;
        if (r24 == false) goto L846;
        int r65 = AXyXVFgzwadQQail(r72);
    L247:
        if (aTpYEndiombGKJOb(r221, (r42.x - r65) % r25) != 0) goto L845;
        r117 = 1;
        if (XTPyHfIJsRRuqmag(r221) != 1) goto L845;
        if (r15 == 1) goto L1012;
    L846:
        r65 = CjNzGTzTlpwsPORa(r6);
    L550:
        iKEAyNMxqqyYWHzt(this.ff7b44cfa, 10);
        goto L58
    L116:
        if (r29 == 49) goto L609;
        zaUFRyYZklNbCytI(this.ff7b44cfa, f2295b6f1);
        BRLmiLVhpbNlVaDu(this, this.ff7b44cfa, this.fe728b2d7);
    L446:
        if (wJrVPBGHnFzbMAmB(r28) == false) goto L177;
        lZVmTuNSnobfzkgR(this.ff7b44cfa, f2295b6f1);
        lUtRXhRspHbjJuxX(this.ff7b44cfa, wrtnvSkIaDdAJqba(CVXojIuraDGRUFAA(MyqbYXZqbJLWblpc(new stringBuilder("# "), (string) cxWmYieJwLFaUPoG(r28)))));
    L861:
        if (VIZPaKnsjSRsOfae(this, this.faa7ac8cd) == false) goto L876;
        if (r23 <= r54) goto L876;
        this.faa7ac8cd -= 3;
        goto L876
    L683:
        r54 = 8;
        goto L861
    L971:
        if (HncPrnSbzLTXPBBR(this, this.faa7ac8cd) == false) goto L876;
        this.faa7ac8cd -= 3;
        goto L876
    L918:
        r22 = GnVyDoeuHoNPZLyV((p1b6e7799) r2);
        goto L586
    L366:
        r33 = (p7c608cb0) aOtkoIFYaFWwZSrH(this, r114, r132, r2);
        goto L738
    L673:
        throw new IIOException(eEdONspLmMgdFaIE(DQnaebbFoyhyIbpW(ASYOVkfVDuMdnpWf(new stringBuilder("Cannot encode image with "), r1), " bands!")));
    L348:
        r132 = ATWnApwPituNlrVV(r103[0], r13, false);
        goto L1069
    L338:
        r132 = new ImageTypeSpecifier(r92, r82);
        r372 = r32;
    L175:
        this.faa7ac8cd = 51;
        goto L387
    L123:
        throw new Exception(PVrlBUzYMKaGewyL("PNMImageWrite3"));
    L264:
        if ((r92 is IndexColorModel) == true) goto L437;
        r24 = r3;
        r25 = r5;
        int r310 = r103[0];
        if (r310 == 1) goto L237;
        if (r310 <= 8) goto L1060;
        this.faa7ac8cd = 50;
        goto L387
    L1060:
        this.faa7ac8cd = 53;
        goto L387
    L237:
        this.faa7ac8cd = 52;
        goto L387
    L437:
        IndexColorModel r138 = (IndexColorModel) r92;
        int r119 = jpadPRqZbzHPVzoV(r138);
        r24 = r3;
        int r311 = r103[0];
        r25 = r5;
        if (r119 >= (1 << r311)) goto L678;
        throw new Exception(PyoEcSdcXNEBPXeP("PNMImageWrite2"));
    L678:
        if (r311 == 1) goto L197;
        this.faa7ac8cd = 54;
        r52 = new byte[r119];
        byte[] r312 = new byte[r119];
        byte[] r1110 = new byte[r119];
        VcSApwNsoQEBzNte(r138, r52);
        QVfnWqcnnPSGAKMR(r138, r312);
        fpHwVSeqYoGMtjiB(r138, r1110);
        bool r139 = false;
    L40:
        r26 = r312;
        r27 = r1110;
        r32 = r139;
        goto L514
    L197:
        this.faa7ac8cd = 52;
        if (egQzSnlpgwXwhAoG(r138, 1) > urXPZBrlTIakoyNs(r138, 0)) goto L939;
        bool r313 = false;
    L157:
        r139 = r313;
        r312 = null;
        r52 = null;
        r1110 = null;
        goto L40
    L939:
        r313 = true;
        goto L157
    L254:
        r113 = new int[r1];
        int r1310 = 0;
    L205:
        if (r1310 >= r1) goto L242;
        r113[r1310] = r1310;
        r1310 = r1310 + 1;
        goto L205
    L80:
        throw new Exception(lLAuRexdJciuZIzX("PNMImageWrite1"));
    L763:
        r42 = r9;
        goto L227
    L107:
        Raster r66 = PlnuerDkXzvScsfg(r38);
        SampleModel r74 = jroYUUOmTJUWlybM(r66);
        if (r4 is not null) goto L1061;
        r42 = RIfiwApwEEWrKGJD(r66);
    L676:
        r82 = r74;
        r92 = null;
        r72 = r66;
        r6 = null;
        goto L957
    L1061:
        r42 = jNpanUsJiSatmFcV(r4, cxgoeVqaCIIZkngR(r66));
        goto L676
    L889:
        r2 = r39;
        goto L306
    }
}

