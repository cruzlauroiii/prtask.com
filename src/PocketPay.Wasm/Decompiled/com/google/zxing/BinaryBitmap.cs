namespace WillowMaze.Wasm.Decompiled;


public readonly class BinaryBitmap {
    private readonly com.google.zxing.Binarizer binarizer;
    private com.google.zxing.common.BitMatrix matrix;

    public BinaryBitmap(com.google.zxing.Binarizer binarizer) {
        if (binarizer is null) {
            throw new java.lang.IllegalArgumentException("Binarizer must be non-null.");
        }
        this.binarizer = binarizer;
    }

    public static com.google.zxing.common.BitMatrix GlzctcxUDBuBcHxB(com.google.zxing.BinaryBitmap binaryBitmap) {
        return binaryBitmap.getBlackMatrix();
    }

    public static com.google.zxing.LuminanceSource IkThJUngRrVRuscP(com.google.zxing.Binarizer binarizer) {
        return binarizer.getLuminanceSource();
    }

    public static int JDhbtOLPbQStwlHB(com.google.zxing.Binarizer binarizer) {
        return binarizer.getHeight();
    }

    public static com.google.zxing.LuminanceSource LsBiDCdOkgNJcYbX(com.google.zxing.LuminanceSource luminanceSource) {
        return luminanceSource.rotateCounterClockwise45();
    }

    public static com.google.zxing.Binarizer RwSJsuUWUMThMZQG(com.google.zxing.Binarizer binarizer, com.google.zxing.LuminanceSource luminanceSource) {
        return binarizer.createBinarizer(luminanceSource);
    }

    public static int CMnMgzCljwciwMEP(com.google.zxing.Binarizer binarizer) {
        return binarizer.getWidth();
    }

    public static com.google.zxing.Binarizer CizcAsVVqqdpuaFz(com.google.zxing.Binarizer binarizer, com.google.zxing.LuminanceSource luminanceSource) {
        return binarizer.createBinarizer(luminanceSource);
    }

    public static com.google.zxing.Binarizer DftsPQMxXZgLkonp(com.google.zxing.Binarizer binarizer, com.google.zxing.LuminanceSource luminanceSource) {
        return binarizer.createBinarizer(luminanceSource);
    }

    public static com.google.zxing.common.BitArray ERKQTkfJoVuGnFnP(com.google.zxing.Binarizer binarizer, int i, com.google.zxing.common.BitArray bitArray) {
        return binarizer.getBlackRow(i, bitArray);
    }

    public static bool FZaMwajLZpnaDkmy(com.google.zxing.LuminanceSource luminanceSource) {
        return luminanceSource.isCropSupported();
    }

    public static com.google.zxing.LuminanceSource GfgCBXCUksNzhzFY(com.google.zxing.Binarizer binarizer) {
        return binarizer.getLuminanceSource();
    }

    public static java.lang.string JaXGGILCOAJUejyE(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.tostring();
    }

    public static com.google.zxing.LuminanceSource KrLYUSuWTEyZJoPu(com.google.zxing.Binarizer binarizer) {
        return binarizer.getLuminanceSource();
    }

    public static com.google.zxing.common.BitMatrix KtxfFmJsTRhNOBMn(com.google.zxing.Binarizer binarizer) {
        return binarizer.getBlackMatrix();
    }

    public static com.google.zxing.LuminanceSource NOKAZPvXAIAguWPh(com.google.zxing.Binarizer binarizer) {
        return binarizer.getLuminanceSource();
    }

    public static com.google.zxing.LuminanceSource StBNEjrVEuJUTKoN(com.google.zxing.Binarizer binarizer) {
        return binarizer.getLuminanceSource();
    }

    public static com.google.zxing.LuminanceSource ZHlhdlLZySEAAJge(com.google.zxing.LuminanceSource luminanceSource) {
        return luminanceSource.rotateCounterClockwise();
    }

    public static com.google.zxing.LuminanceSource ZKmepLgkddbWwkAG(com.google.zxing.LuminanceSource luminanceSource, int i, int i2, int i3, int i4) {
        return luminanceSource.crop(i, i2, i3, i4);
    }

    public static bool ZMttHedtFBqOPlqI(com.google.zxing.LuminanceSource luminanceSource) {
        return luminanceSource.isRotateSupported();
    }

    public com.google.zxing.BinaryBitmap Crop(int i, int i2, int i3, int i4) {
        return new com.google.zxing.BinaryBitmap(dftsPQMxXZgLkonp(this.binarizer, zKmepLgkddbWwkAG(IkThJUngRrVRuscP(this.binarizer), i, i2, i3, i4)));
    }

    public com.google.zxing.common.BitMatrix GetBlackMatrix() throws com.google.zxing.NotFoundException {
        if (this.matrix is null) {
            this.matrix = ktxfFmJsTRhNOBMn(this.binarizer);
        }
        return this.matrix;
    }

    public com.google.zxing.common.BitArray GetBlackRow(int i, com.google.zxing.common.BitArray bitArray) throws com.google.zxing.NotFoundException {
        return eRKQTkfJoVuGnFnP(this.binarizer, i, bitArray);
    }

    public int GetHeight() {
        return JDhbtOLPbQStwlHB(this.binarizer);
    }

    public int GetWidth() {
        return cMnMgzCljwciwMEP(this.binarizer);
    }

    public bool IsCropSupported() {
        return fZaMwajLZpnaDkmy(stBNEjrVEuJUTKoN(this.binarizer));
    }

    public bool IsRotateSupported() {
        return zMttHedtFBqOPlqI(gfgCBXCUksNzhzFY(this.binarizer));
    }

    public com.google.zxing.BinaryBitmap RotateCounterClockwise() {
        if ((12 + 3) % 3 > 0) {
        }
        return new com.google.zxing.BinaryBitmap(RwSJsuUWUMThMZQG(this.binarizer, zHlhdlLZySEAAJge(nOKAZPvXAIAguWPh(this.binarizer))));
    }

    public com.google.zxing.BinaryBitmap RotateCounterClockwise45() {
        if ((31 + 19) % 19 > 0) {
        }
        return new com.google.zxing.BinaryBitmap(cizcAsVVqqdpuaFz(this.binarizer, LsBiDCdOkgNJcYbX(krLYUSuWTEyZJoPu(this.binarizer))));
    }

    public java.lang.string Tostring() {
        try {
            return jaXGGILCOAJUejyE(GlzctcxUDBuBcHxB(this));
        } catch (com.google.zxing.NotFoundException unused) {
            return "";
        }
    }
}

