namespace WillowMaze.Wasm.Decompiled;


public readonly class PDF417HighLevelEncoderTestAdapter {
    private PDF417HighLevelEncoderTestAdapter() {
    }

    public static java.lang.string EncodeHighLevel(java.lang.string str, com.google.zxing.pdf417.encoder.Compaction compaction, java.nio.charset.Charset charset, bool z) throws com.google.zxing.WriterException {
        return laOQLBAETUlrPJor(str, compaction, charset, z);
    }

    public static java.lang.string LaOQLBAETUlrPJor(java.lang.string str, com.google.zxing.pdf417.encoder.Compaction compaction, java.nio.charset.Charset charset, bool z) {
        return com.google.zxing.pdf417.encoder.PDF417HighLevelEncoder.encodeHighLevel(str, compaction, charset, z);
    }
}

