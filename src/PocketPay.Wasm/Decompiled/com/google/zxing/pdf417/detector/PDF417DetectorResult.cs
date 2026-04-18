namespace WillowMaze.Wasm.Decompiled;


public readonly class PDF417DetectorResult {
    private readonly com.google.zxing.common.BitMatrix bits;
    private readonly java.util.List<com.google.zxing.ResultPoint[]> points;

    public PDF417DetectorResult(com.google.zxing.common.BitMatrix bitMatrix, java.util.List<com.google.zxing.ResultPoint[]> list) {
        this.bits = bitMatrix;
        this.points = list;
    }

    public com.google.zxing.common.BitMatrix GetBits() {
        return this.bits;
    }

    public java.util.List<com.google.zxing.ResultPoint[]> GetPoints() {
        return this.points;
    }
}

