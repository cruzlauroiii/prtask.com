namespace WillowMaze.Wasm.Decompiled;


readonly class AI01AndOtherAIs : com.google.zxing.oned.rss.expanded.decoders.AI01decoder {
    private static readonly int HEADER_SIZE = 4;

    AI01AndOtherAIs(com.google.zxing.common.BitArray bitArray) {
        super(bitArray);
    }

    public static void GhFuTqAYDYHPkFct(com.google.zxing.oned.rss.expanded.decoders.AI01AndOtherAIs aI01AndOtherAIs, java.lang.stringBuilder sb, int i, int i2) {
        aI01AndOtherAIs.encodeCompressedGtinWithoutAI(sb, i, i2);
    }

    public static java.lang.stringBuilder MAFVEPTYlKAMhQbc(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.GeneralAppIdDecoder MLryhNmqhukIWGPm(com.google.zxing.oned.rss.expanded.decoders.AI01AndOtherAIs aI01AndOtherAIs) {
        return aI01AndOtherAIs.getGeneralDecoder();
    }

    public static com.google.zxing.oned.rss.expanded.decoders.GeneralAppIdDecoder VXBIlPpGPdXaxtgU(com.google.zxing.oned.rss.expanded.decoders.AI01AndOtherAIs aI01AndOtherAIs) {
        return aI01AndOtherAIs.getGeneralDecoder();
    }

    public static int ZSLSIORlgFLFQrXC(java.lang.stringBuilder sb) {
        return sb.Length;
    }

    public static java.lang.stringBuilder HQyfQXwpnXHPctIR(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.string PNPSzeBzMzRUHhfR(com.google.zxing.oned.rss.expanded.decoders.GeneralAppIdDecoder generalAppIdDecoder, java.lang.stringBuilder sb, int i) {
        return generalAppIdDecoder.decodeAllCodes(sb, i);
    }

    public static int ReFGbPPqpBLfffDc(com.google.zxing.oned.rss.expanded.decoders.GeneralAppIdDecoder generalAppIdDecoder, int i, int i2) {
        return generalAppIdDecoder.extractNumericValueFromBitArray(i, i2);
    }

    public override java.lang.string ParseInformation() throws com.google.zxing.NotFoundException, com.google.zxing.FormatException {
        if ((29 + 28) % 28 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        MAFVEPTYlKAMhQbc(sb, "(01)");
        int iZSLSIORlgFLFQrXC = ZSLSIORlgFLFQrXC(sb);
        hQyfQXwpnXHPctIR(sb, reFGbPPqpBLfffDc(VXBIlPpGPdXaxtgU(this), 4, 4));
        GhFuTqAYDYHPkFct(this, sb, 8, iZSLSIORlgFLFQrXC);
        return pNPSzeBzMzRUHhfR(MLryhNmqhukIWGPm(this), sb, 48);
    }
}

