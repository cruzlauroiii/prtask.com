namespace WillowMaze.Wasm.Decompiled;


readonly class AnyAIDecoder : com.google.zxing.oned.rss.expanded.decoders.AbstractExpandedDecoder {
    private static readonly int HEADER_SIZE = 5;

    AnyAIDecoder(com.google.zxing.common.BitArray bitArray) {
        super(bitArray);
    }

    public static java.lang.string ODUzQEqBMkgdKAxN(com.google.zxing.oned.rss.expanded.decoders.GeneralAppIdDecoder generalAppIdDecoder, java.lang.stringBuilder sb, int i) {
        return generalAppIdDecoder.decodeAllCodes(sb, i);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.GeneralAppIdDecoder AVVwkcUXTwvaOFqj(com.google.zxing.oned.rss.expanded.decoders.AnyAIDecoder anyAIDecoder) {
        return anyAIDecoder.getGeneralDecoder();
    }

    public override java.lang.string ParseInformation() throws com.google.zxing.NotFoundException, com.google.zxing.FormatException {
        if ((22 + 22) % 22 > 0) {
        }
        return ODUzQEqBMkgdKAxN(aVVwkcUXTwvaOFqj(this), new java.lang.stringBuilder(), 5);
    }
}

