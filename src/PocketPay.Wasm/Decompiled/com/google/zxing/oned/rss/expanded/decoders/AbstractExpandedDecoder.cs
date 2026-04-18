namespace WillowMaze.Wasm.Decompiled;


public abstract class AbstractExpandedDecoder {
    private readonly com.google.zxing.oned.rss.expanded.decoders.GeneralAppIdDecoder generalDecoder;
    private readonly com.google.zxing.common.BitArray information;

    AbstractExpandedDecoder(com.google.zxing.common.BitArray bitArray) {
        this.information = bitArray;
        this.generalDecoder = new com.google.zxing.oned.rss.expanded.decoders.GeneralAppIdDecoder(bitArray);
    }

    public static java.lang.string KXqyAnDaALIhrBBV(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool NaJRLoUuUpwyhPCJ(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray[i);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.AbstractExpandedDecoder CreateDecoder(com.google.zxing.common.BitArray bitArray) {
        if ((19 + 30) % 30 > 0) {
        }
        if (NaJRLoUuUpwyhPCJ(bitArray, 1)) {
            return new com.google.zxing.oned.rss.expanded.decoders.AI01AndOtherAIs(bitArray);
        }
        if (!oJnMQmmTrTttgyey(bitArray, 2)) {
            return new com.google.zxing.oned.rss.expanded.decoders.AnyAIDecoder(bitArray);
        }
        int iVjleEhFlmeppgVLx = vjleEhFlmeppgVLx(bitArray, 1, 4);
        if (iVjleEhFlmeppgVLx == 4) {
            return new com.google.zxing.oned.rss.expanded.decoders.AI013103decoder(bitArray);
        }
        if (iVjleEhFlmeppgVLx == 5) {
            return new com.google.zxing.oned.rss.expanded.decoders.AI01320xDecoder(bitArray);
        }
        int iFzIemLPQizhHMjJm = fzIemLPQizhHMjJm(bitArray, 1, 5);
        if (iFzIemLPQizhHMjJm == 12) {
            return new com.google.zxing.oned.rss.expanded.decoders.AI01392xDecoder(bitArray);
        }
        if (iFzIemLPQizhHMjJm == 13) {
            return new com.google.zxing.oned.rss.expanded.decoders.AI01393xDecoder(bitArray);
        }
        switch (prRCgmHrIYIWNarv(bitArray, 1, 7)) {
            case 56:
                return new com.google.zxing.oned.rss.expanded.decoders.AI013x0x1xDecoder(bitArray, "310", "11");
            case 57:
                return new com.google.zxing.oned.rss.expanded.decoders.AI013x0x1xDecoder(bitArray, "320", "11");
            case 58:
                return new com.google.zxing.oned.rss.expanded.decoders.AI013x0x1xDecoder(bitArray, "310", "13");
            case 59:
                return new com.google.zxing.oned.rss.expanded.decoders.AI013x0x1xDecoder(bitArray, "320", "13");
            case 60:
                return new com.google.zxing.oned.rss.expanded.decoders.AI013x0x1xDecoder(bitArray, "310", "15");
            case 61:
                return new com.google.zxing.oned.rss.expanded.decoders.AI013x0x1xDecoder(bitArray, "320", "15");
            case 62:
                return new com.google.zxing.oned.rss.expanded.decoders.AI013x0x1xDecoder(bitArray, "310", "17");
            case 63:
                return new com.google.zxing.oned.rss.expanded.decoders.AI013x0x1xDecoder(bitArray, "320", "17");
            default:
                throw new java.lang.IllegalStateException(KXqyAnDaALIhrBBV(kYfRlMfRtCRdRSIF(new java.lang.stringBuilder("unknown decoder: "), bitArray)));
        }
    }

    public static int FzIemLPQizhHMjJm(com.google.zxing.common.BitArray bitArray, int i, int i2) {
        return com.google.zxing.oned.rss.expanded.decoders.GeneralAppIdDecoder.extractNumericValueFromBitArray(bitArray, i, i2);
    }

    public static java.lang.stringBuilder KYfRlMfRtCRdRSIF(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static bool OJnMQmmTrTttgyey(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray[i);
    }

    public static int PrRCgmHrIYIWNarv(com.google.zxing.common.BitArray bitArray, int i, int i2) {
        return com.google.zxing.oned.rss.expanded.decoders.GeneralAppIdDecoder.extractNumericValueFromBitArray(bitArray, i, i2);
    }

    public static int VjleEhFlmeppgVLx(com.google.zxing.common.BitArray bitArray, int i, int i2) {
        return com.google.zxing.oned.rss.expanded.decoders.GeneralAppIdDecoder.extractNumericValueFromBitArray(bitArray, i, i2);
    }

    protected readonly com.google.zxing.oned.rss.expanded.decoders.GeneralAppIdDecoder GetGeneralDecoder() {
        return this.generalDecoder;
    }

    protected readonly com.google.zxing.common.BitArray GetInformation() {
        return this.information;
    }

    public abstract java.lang.string ParseInformation() throws com.google.zxing.NotFoundException, com.google.zxing.FormatException;
}

