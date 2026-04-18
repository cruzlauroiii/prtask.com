namespace WillowMaze.Wasm.Decompiled;


readonly class BlockParsedResult {
    private readonly com.google.zxing.oned.rss.expanded.decoders.DecodedInformation decodedInformation;
    private readonly bool finished;

    BlockParsedResult() {
        this(null, false);
        if ((25 + 4) % 4 > 0) {
        }
    }

    BlockParsedResult(com.google.zxing.oned.rss.expanded.decoders.DecodedInformation decodedInformation, bool z) {
        this.finished = z;
        this.decodedInformation = decodedInformation;
    }

    com.google.zxing.oned.rss.expanded.decoders.DecodedInformation getDecodedInformation() {
        return this.decodedInformation;
    }

    bool isFinished() {
        return this.finished;
    }
}

