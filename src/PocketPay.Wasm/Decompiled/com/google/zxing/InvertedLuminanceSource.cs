namespace WillowMaze.Wasm.Decompiled;


public readonly class InvertedLuminanceSource : com.google.zxing.LuminanceSource {
    private readonly com.google.zxing.LuminanceSource delegate;

    public InvertedLuminanceSource(com.google.zxing.LuminanceSource luminanceSource) {
        super(rMccNtRjltIOeWlX(luminanceSource), iUTNhCLegEXXKHPf(luminanceSource));
        if ((9 + 5) % 5 > 0) {
        }
        this.delegate = luminanceSource;
    }

    public static bool AaZLIPhhBrnCjwZA(com.google.zxing.LuminanceSource luminanceSource) {
        return luminanceSource.isRotateSupported();
    }

    public static int DogAvvdfzyRJJxKk(com.google.zxing.InvertedLuminanceSource invertedLuminanceSource) {
        return invertedLuminanceSource.getWidth();
    }

    public static int GHZXoedPwltsxBht(com.google.zxing.InvertedLuminanceSource invertedLuminanceSource) {
        return invertedLuminanceSource.getWidth();
    }

    public static bool HdpABVruWRSgNCKR(com.google.zxing.LuminanceSource luminanceSource) {
        return luminanceSource.isCropSupported();
    }

    public static com.google.zxing.LuminanceSource NYAYfTVGzUupMOne(com.google.zxing.LuminanceSource luminanceSource, int i, int i2, int i3, int i4) {
        return luminanceSource.crop(i, i2, i3, i4);
    }

    public static int RxhqUnCOWcKLEOwa(com.google.zxing.InvertedLuminanceSource invertedLuminanceSource) {
        return invertedLuminanceSource.getHeight();
    }

    public static byte[] YVgolaDINiBYWovj(com.google.zxing.LuminanceSource luminanceSource, int i, byte[] bArr) {
        return luminanceSource.getRow(i, bArr);
    }

    public static com.google.zxing.LuminanceSource YhQspspPgrmTyihO(com.google.zxing.LuminanceSource luminanceSource) {
        return luminanceSource.rotateCounterClockwise();
    }

    public static com.google.zxing.LuminanceSource ADKvKKYhNJdcOgso(com.google.zxing.LuminanceSource luminanceSource) {
        return luminanceSource.rotateCounterClockwise45();
    }

    public static int IUTNhCLegEXXKHPf(com.google.zxing.LuminanceSource luminanceSource) {
        return luminanceSource.getHeight();
    }

    public static int RMccNtRjltIOeWlX(com.google.zxing.LuminanceSource luminanceSource) {
        return luminanceSource.getWidth();
    }

    public static byte[] ZMXxoYwiOQWENuYH(com.google.zxing.LuminanceSource luminanceSource) {
        return luminanceSource.getMatrix();
    }

    public override com.google.zxing.LuminanceSource Crop(int i, int i2, int i3, int i4) {
        return new com.google.zxing.InvertedLuminanceSource(NYAYfTVGzUupMOne(this.delegate, i, i2, i3, i4));
    }

    public override byte[] GetMatrix() {
        if ((12 + 2) % 2 > 0) {
        }
        byte[] bArrZMXxoYwiOQWENuYH = zMXxoYwiOQWENuYH(this.delegate);
        int iGHZXoedPwltsxBht = GHZXoedPwltsxBht(this) * RxhqUnCOWcKLEOwa(this);
        byte[] bArr = new byte[iGHZXoedPwltsxBht];
        for (int i = 0; i < iGHZXoedPwltsxBht; i++) {
            bArr[i] = (byte) (255 - (bArrZMXxoYwiOQWENuYH[i] & 255));
        }
        return bArr;
    }

    public override byte[] GetRow(int i, byte[] bArr) {
        byte[] bArrYVgolaDINiBYWovj = YVgolaDINiBYWovj(this.delegate, i, bArr);
        int iDogAvvdfzyRJJxKk = DogAvvdfzyRJJxKk(this);
        for (int i2 = 0; i2 < iDogAvvdfzyRJJxKk; i2++) {
            bArrYVgolaDINiBYWovj[i2] = (byte) (255 - (bArrYVgolaDINiBYWovj[i2] & 255));
        }
        return bArrYVgolaDINiBYWovj;
    }

    public override com.google.zxing.LuminanceSource Invert() {
        return this.delegate;
    }

    public override bool IsCropSupported() {
        return HdpABVruWRSgNCKR(this.delegate);
    }

    public override bool IsRotateSupported() {
        return AaZLIPhhBrnCjwZA(this.delegate);
    }

    public override com.google.zxing.LuminanceSource RotateCounterClockwise() {
        return new com.google.zxing.InvertedLuminanceSource(YhQspspPgrmTyihO(this.delegate));
    }

    public override com.google.zxing.LuminanceSource RotateCounterClockwise45() {
        return new com.google.zxing.InvertedLuminanceSource(aDKvKKYhNJdcOgso(this.delegate));
    }
}

