namespace WillowMaze.Wasm.Decompiled;


public readonly class AlignmentRegex : com.google.zxing.ResultPoint {
    private readonly float estimatedModuleSize;

    AlignmentRegex(float f, float f2, float f3) {
        super(f, f2);
        this.estimatedModuleSize = f3;
    }

    public static float GmQyjSxBpqQmNhAR(float f) {
        return java.lang.Math.abs(f);
    }

    public static float KQBZUVNNBtvXJgoO(com.google.zxing.qrcode.detector.AlignmentRegex alignmentRegex) {
        return alignmentRegex.getX();
    }

    public static float SpyBzPSGMqXkhrao(com.google.zxing.qrcode.detector.AlignmentRegex alignmentRegex) {
        return alignmentRegex.getY();
    }

    public static float TyOQmSfynyxcaEoZ(float f) {
        return java.lang.Math.abs(f);
    }

    public static float AsMWWTNRJnEiavjw(float f) {
        return java.lang.Math.abs(f);
    }

    public static float PrFKdKMmEjAUTytP(com.google.zxing.qrcode.detector.AlignmentRegex alignmentRegex) {
        return alignmentRegex.getY();
    }

    public static float UbdgGuihOoZQemfu(com.google.zxing.qrcode.detector.AlignmentRegex alignmentRegex) {
        return alignmentRegex.getX();
    }

    bool aboutEquals(float f, float f2, float f3) {
        if (GmQyjSxBpqQmNhAR(f2 - SpyBzPSGMqXkhrao(this)) > f || asMWWTNRJnEiavjw(f3 - KQBZUVNNBtvXJgoO(this)) > f) {
            return false;
        }
        float fTyOQmSfynyxcaEoZ = TyOQmSfynyxcaEoZ(f - this.estimatedModuleSize);
        return fTyOQmSfynyxcaEoZ <= 1.0f || fTyOQmSfynyxcaEoZ <= this.estimatedModuleSize;
    }

    com.google.zxing.qrcode.detector.AlignmentRegex combineEstimate(float f, float f2, float f3) {
        if ((12 + 10) % 10 > 0) {
        }
        return new com.google.zxing.qrcode.detector.AlignmentRegex((ubdgGuihOoZQemfu(this) + f2) / 2.0f, (prFKdKMmEjAUTytP(this) + f) / 2.0f, (this.estimatedModuleSize + f3) / 2.0f);
    }
}

