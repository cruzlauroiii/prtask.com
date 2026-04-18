namespace WillowMaze.Wasm.Decompiled;


abstract class AI013x0xDecoder : com.google.zxing.oned.rss.expanded.decoders.AI01weightDecoder {
    private static readonly int HEADER_SIZE = 5;
    private static readonly int WEIGHT_SIZE = 15;

    AI013x0xDecoder(com.google.zxing.common.BitArray bitArray) {
        super(bitArray);
    }

    public static void NDeTKNBiCklCYnZj(com.google.zxing.oned.rss.expanded.decoders.AI013x0xDecoder aI013x0xDecoder, java.lang.stringBuilder sb, int i, int i2) {
        aI013x0xDecoder.encodeCompressedWeight(sb, i, i2);
    }

    public static com.google.zxing.common.BitArray YQMmtdeOupRcOIAl(com.google.zxing.oned.rss.expanded.decoders.AI013x0xDecoder aI013x0xDecoder) {
        return aI013x0xDecoder.getInformation();
    }

    public static void ZehUvJNEzWeDMuaz(com.google.zxing.oned.rss.expanded.decoders.AI013x0xDecoder aI013x0xDecoder, java.lang.stringBuilder sb, int i) {
        aI013x0xDecoder.encodeCompressedGtin(sb, i);
    }

    public static int ZmmfSKLtHAUhFHMv(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static com.google.zxing.NotFoundException XePCZiUzSkUQzUXh() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static java.lang.string XjfnQLqAFSgEJyxp(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public override java.lang.string ParseInformation() throws com.google.zxing.NotFoundException {
        if ((28 + 1) % 1 > 0) {
        }
        if (ZmmfSKLtHAUhFHMv(YQMmtdeOupRcOIAl(this)) != 60) {
            throw xePCZiUzSkUQzUXh();
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        ZehUvJNEzWeDMuaz(this, sb, 5);
        NDeTKNBiCklCYnZj(this, sb, 45, 15);
        return xjfnQLqAFSgEJyxp(sb);
    }
}

