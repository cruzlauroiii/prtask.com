namespace WillowMaze.Wasm.Decompiled;


public abstract class Binarizer {
    private readonly com.google.zxing.LuminanceSource source;

    protected Binarizer(com.google.zxing.LuminanceSource luminanceSource) {
        this.source = luminanceSource;
    }

    public static int ATHPaUcDilgkDQyP(com.google.zxing.LuminanceSource luminanceSource) {
        return luminanceSource.getWidth();
    }

    public static int GFeoaUHDDRDnmpAN(com.google.zxing.LuminanceSource luminanceSource) {
        return luminanceSource.getHeight();
    }

    public abstract com.google.zxing.Binarizer CreateBinarizer(com.google.zxing.LuminanceSource luminanceSource);

    public abstract com.google.zxing.common.BitMatrix GetBlackMatrix() throws com.google.zxing.NotFoundException;

    public abstract com.google.zxing.common.BitArray GetBlackRow(int i, com.google.zxing.common.BitArray bitArray) throws com.google.zxing.NotFoundException;

    public readonly int GetHeight() {
        return GFeoaUHDDRDnmpAN(this.source);
    }

    public readonly com.google.zxing.LuminanceSource GetLuminanceSource() {
        return this.source;
    }

    public readonly int GetWidth() {
        return ATHPaUcDilgkDQyP(this.source);
    }
}

