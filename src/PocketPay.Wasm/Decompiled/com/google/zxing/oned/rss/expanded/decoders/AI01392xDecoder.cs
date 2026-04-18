namespace WillowMaze.Wasm.Decompiled;


readonly class AI01392xDecoder : com.google.zxing.oned.rss.expanded.decoders.AI01decoder {
    private static readonly int HEADER_SIZE = 8;
    private static readonly int LAST_DIGIT_SIZE = 2;

    AI01392xDecoder(com.google.zxing.common.BitArray bitArray) {
        super(bitArray);
    }

    public static java.lang.stringBuilder McQPBxtKAjwoSYou(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.string NyCUrKoSylOAzKdb(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int PtFuCuoNWgdGkJwy(com.google.zxing.oned.rss.expanded.decoders.GeneralAppIdDecoder generalAppIdDecoder, int i, int i2) {
        return generalAppIdDecoder.extractNumericValueFromBitArray(i, i2);
    }

    public static java.lang.stringBuilder RxIxPXWzqRcPfoRw(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.GeneralAppIdDecoder TjHitSNMWTCiMLVv(com.google.zxing.oned.rss.expanded.decoders.AI01392xDecoder aI01392xDecoder) {
        return aI01392xDecoder.getGeneralDecoder();
    }

    public static void UqTLIUQenvRChLta(com.google.zxing.oned.rss.expanded.decoders.AI01392xDecoder aI01392xDecoder, java.lang.stringBuilder sb, int i) {
        aI01392xDecoder.encodeCompressedGtin(sb, i);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.DecodedInformation WsMsXnNlhdVFIezc(com.google.zxing.oned.rss.expanded.decoders.GeneralAppIdDecoder generalAppIdDecoder, int i, java.lang.string str) {
        return generalAppIdDecoder.decodeGeneralPurposeField(i, str);
    }

    public static java.lang.string YRMFCbVQIczjAIeS(com.google.zxing.oned.rss.expanded.decoders.DecodedInformation decodedInformation) {
        return decodedInformation.getNewstring();
    }

    public static java.lang.stringBuilder EWvsyKUGWLparBcd(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.GeneralAppIdDecoder PFCwfcDJMRyzGyDR(com.google.zxing.oned.rss.expanded.decoders.AI01392xDecoder aI01392xDecoder) {
        return aI01392xDecoder.getGeneralDecoder();
    }

    public static com.google.zxing.common.BitArray RqFeeyRtbJmPeRuP(com.google.zxing.oned.rss.expanded.decoders.AI01392xDecoder aI01392xDecoder) {
        return aI01392xDecoder.getInformation();
    }

    public static int SDnIGolcfWXqySZa(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static com.google.zxing.NotFoundException SKbMJpzzciOtihSx() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static java.lang.stringBuilder XIoPeIosOUKRezUi(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public override java.lang.string ParseInformation() throws com.google.zxing.NotFoundException, com.google.zxing.FormatException {
        if ((12 + 8) % 8 > 0) {
        }
        if (sDnIGolcfWXqySZa(rqFeeyRtbJmPeRuP(this)) < 48) {
            throw sKbMJpzzciOtihSx();
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        UqTLIUQenvRChLta(this, sb, 8);
        int iPtFuCuoNWgdGkJwy = PtFuCuoNWgdGkJwy(pFCwfcDJMRyzGyDR(this), 48, 2);
        xIoPeIosOUKRezUi(sb, "(392");
        McQPBxtKAjwoSYou(sb, iPtFuCuoNWgdGkJwy);
        RxIxPXWzqRcPfoRw(sb, ')');
        eWvsyKUGWLparBcd(sb, YRMFCbVQIczjAIeS(WsMsXnNlhdVFIezc(TjHitSNMWTCiMLVv(this), 50, null)));
        return NyCUrKoSylOAzKdb(sb);
    }
}

