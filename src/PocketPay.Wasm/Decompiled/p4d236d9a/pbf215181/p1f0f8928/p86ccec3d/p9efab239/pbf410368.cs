namespace WillowMaze.Wasm.Decompiled;


public class pbf410368 : p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p9efab239.p73d0dfd3 {
    java.awt.image.Raster f1c280670;
    java.awt.image.Raster f7bbd9b8c;
    java.awt.image.Raster fe8f86403;

    public pbf410368(java.awt.image.Raster raster, java.awt.image.ColorModel colorModel) {
        this.f1c280670 = raster;
        int iZykIzLDlHvsBqxoy = ZykIzLDlHvsBqxoy(raster);
        this.f6d8aadb1 = iZykIzLDlHvsBqxoy;
        this.f4023bf9f = iZykIzLDlHvsBqxoy;
        int iJliYCHRxFmJpNjAc = JliYCHRxFmJpNjAc(raster);
        this.f2c11e0ea = iJliYCHRxFmJpNjAc;
        this.f04cb7224 = iJliYCHRxFmJpNjAc;
        int iHdtxtxXWmfPxvhaq = HdtxtxXWmfPxvhaq(raster);
        this.feaae26a6 = iHdtxtxXWmfPxvhaq;
        this.f355e3a37 = iHdtxtxXWmfPxvhaq;
        int iIOStMtuGjfftFZke = IOStMtuGjfftFZke(raster);
        this.fb435e227 = iIOStMtuGjfftFZke;
        this.fdcede062 = iIOStMtuGjfftFZke;
        this.fb70eee22 = LMcUmMXVJBHLHlxr(raster);
        this.f5fe5366d = colorModel;
    }

    public static int HdtxtxXWmfPxvhaq(java.awt.image.Raster raster) {
        return raster.getWidth();
    }

    public static void HdtxtxXWmfPxvhaq(java.awt.image.Raster raster, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HdtxtxXWmfPxvhaq(java.awt.image.Raster raster, int i, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HdtxtxXWmfPxvhaq(java.awt.image.Raster raster, short s, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int IOStMtuGjfftFZke(java.awt.image.Raster raster) {
        return raster.getHeight();
    }

    public static void IOStMtuGjfftFZke(java.awt.image.Raster raster, char c, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IOStMtuGjfftFZke(java.awt.image.Raster raster, int i, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IOStMtuGjfftFZke(java.awt.image.Raster raster, java.lang.string str, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static int JliYCHRxFmJpNjAc(java.awt.image.Raster raster) {
        return raster.getMinY();
    }

    public static void JliYCHRxFmJpNjAc(java.awt.image.Raster raster, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JliYCHRxFmJpNjAc(java.awt.image.Raster raster, char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JliYCHRxFmJpNjAc(java.awt.image.Raster raster, float f, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.awt.image.SampleModel LMcUmMXVJBHLHlxr(java.awt.image.Raster raster) {
        return raster.getSampleModel();
    }

    public static void LMcUmMXVJBHLHlxr(java.awt.image.Raster raster, int i, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LMcUmMXVJBHLHlxr(java.awt.image.Raster raster, short s, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LMcUmMXVJBHLHlxr(java.awt.image.Raster raster, short s, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static int ZykIzLDlHvsBqxoy(java.awt.image.Raster raster) {
        return raster.getMinX();
    }

    public static void ZykIzLDlHvsBqxoy(java.awt.image.Raster raster, java.lang.string str, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZykIzLDlHvsBqxoy(java.awt.image.Raster raster, short s, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZykIzLDlHvsBqxoy(java.awt.image.Raster raster, bool z, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public java.awt.image.Raster GetTile(int i, int i2) {
        if (i == 0 && i2 == 0) {
            return this.f1c280670;
        }
        throw new java.lang.IllegalArgumentException("tileX != 0 || tileY != 0");
    }
}

