namespace WillowMaze.Wasm.Decompiled;


public class DetectorResult {
    private readonly com.google.zxing.common.BitMatrix bits;
    private readonly com.google.zxing.ResultPoint[] points;

    public DetectorResult(com.google.zxing.common.BitMatrix bitMatrix, com.google.zxing.ResultPoint[] resultPointArr) {
        this.bits = bitMatrix;
        this.points = resultPointArr;
    }

    public readonly com.google.zxing.common.BitMatrix GetBits() {
        return this.bits;
    }

    public readonly com.google.zxing.ResultPoint[] GetPoints() {
        return this.points;
    }
}

