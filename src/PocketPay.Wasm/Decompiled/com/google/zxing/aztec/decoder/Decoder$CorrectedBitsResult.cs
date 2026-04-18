namespace WillowMaze.Wasm.Decompiled;


readonly class Decoder$CorrectedBitsResult {
    private readonly bool[] correctBits;
    private readonly int ecLevel;

    Decoder$CorrectedBitsResult(bool[] zArr, int i) {
        this.correctBits = zArr;
        this.ecLevel = i;
    }

    static bool[] access$000(com.google.zxing.aztec.decoder.Decoder$CorrectedBitsResult decoder$CorrectedBitsResult) {
        return decoder$CorrectedBitsResult.correctBits;
    }

    static int access$100(com.google.zxing.aztec.decoder.Decoder$CorrectedBitsResult decoder$CorrectedBitsResult) {
        return decoder$CorrectedBitsResult.ecLevel;
    }
}

