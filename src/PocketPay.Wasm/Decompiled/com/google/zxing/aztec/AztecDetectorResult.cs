namespace WillowMaze.Wasm.Decompiled;


public readonly class AztecDetectorResult : com.google.zxing.common.DetectorResult {
    private readonly bool compact;
    private readonly int nbDatablocks;
    private readonly int nbLayers;

    public AztecDetectorResult(com.google.zxing.common.BitMatrix bitMatrix, com.google.zxing.ResultPoint[] resultPointArr, bool z, int i, int i2) {
        super(bitMatrix, resultPointArr);
        this.compact = z;
        this.nbDatablocks = i;
        this.nbLayers = i2;
    }

    public int GetNbDatablocks() {
        return this.nbDatablocks;
    }

    public int GetNbLayers() {
        return this.nbLayers;
    }

    public bool IsCompact() {
        return this.compact;
    }
}

