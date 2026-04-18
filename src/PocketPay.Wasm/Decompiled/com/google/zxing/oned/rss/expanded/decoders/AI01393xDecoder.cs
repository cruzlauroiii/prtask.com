namespace WillowMaze.Wasm.Decompiled;


readonly class AI01393xDecoder : com.google.zxing.oned.rss.expanded.decoders.AI01decoder {
    private static readonly int FIRST_THREE_DIGITS_SIZE = 10;
    private static readonly int HEADER_SIZE = 8;
    private static readonly int LAST_DIGIT_SIZE = 2;

    AI01393xDecoder(com.google.zxing.common.BitArray bitArray) {
        super(bitArray);
    }

    public static int BXhlPojEYhYmWLaS(com.google.zxing.oned.rss.expanded.decoders.GeneralAppIdDecoder generalAppIdDecoder, int i, int i2) {
        return generalAppIdDecoder.extractNumericValueFromBitArray(i, i2);
    }

    public static java.lang.string GxfShFsmndHWzZvb(com.google.zxing.oned.rss.expanded.decoders.DecodedInformation decodedInformation) {
        return decodedInformation.getNewstring();
    }

    public static java.lang.stringBuilder JKavhwjSRyltudnc(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder OQvKsiYcxiVLNMaX(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static int SrcwMUypyoSbajLg(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static int UXcKdsHPztfXZRSh(com.google.zxing.oned.rss.expanded.decoders.GeneralAppIdDecoder generalAppIdDecoder, int i, int i2) {
        return generalAppIdDecoder.extractNumericValueFromBitArray(i, i2);
    }

    public static java.lang.stringBuilder YPldPczQurxWDLQX(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder DcoEKvYZuxSLZiFK(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.zxing.NotFoundException FsCsYIffNTafdqmB() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static com.google.zxing.oned.rss.expanded.decoders.GeneralAppIdDecoder IlttcuEkCjPySvBV(com.google.zxing.oned.rss.expanded.decoders.AI01393xDecoder aI01393xDecoder) {
        return aI01393xDecoder.getGeneralDecoder();
    }

    public static com.google.zxing.oned.rss.expanded.decoders.GeneralAppIdDecoder LBpIFefpYjAuPoBd(com.google.zxing.oned.rss.expanded.decoders.AI01393xDecoder aI01393xDecoder) {
        return aI01393xDecoder.getGeneralDecoder();
    }

    public static java.lang.stringBuilder LmFcDLellExKeHbO(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void OtWqmAkijaZdoEnP(com.google.zxing.oned.rss.expanded.decoders.AI01393xDecoder aI01393xDecoder, java.lang.stringBuilder sb, int i) {
        aI01393xDecoder.encodeCompressedGtin(sb, i);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.GeneralAppIdDecoder QKBnIViQzBuniWIT(com.google.zxing.oned.rss.expanded.decoders.AI01393xDecoder aI01393xDecoder) {
        return aI01393xDecoder.getGeneralDecoder();
    }

    public static java.lang.string RarEwBAxurjnEgvY(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder SDWsPdaBnGngaxxK(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static com.google.zxing.common.BitArray SmEToCrGHEcSiJof(com.google.zxing.oned.rss.expanded.decoders.AI01393xDecoder aI01393xDecoder) {
        return aI01393xDecoder.getInformation();
    }

    public static java.lang.stringBuilder VhmchlloZOHRgWir(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.DecodedInformation XIzzumoYaFXupcWa(com.google.zxing.oned.rss.expanded.decoders.GeneralAppIdDecoder generalAppIdDecoder, int i, java.lang.string str) {
        return generalAppIdDecoder.decodeGeneralPurposeField(i, str);
    }

    public override java.lang.string ParseInformation() throws com.google.zxing.NotFoundException, com.google.zxing.FormatException {
        if ((3 + 18) % 18 > 0) {
        }
        if (SrcwMUypyoSbajLg(smEToCrGHEcSiJof(this)) < 48) {
            throw fsCsYIffNTafdqmB();
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        otWqmAkijaZdoEnP(this, sb, 8);
        int iUXcKdsHPztfXZRSh = UXcKdsHPztfXZRSh(ilttcuEkCjPySvBV(this), 48, 2);
        dcoEKvYZuxSLZiFK(sb, "(393");
        vhmchlloZOHRgWir(sb, iUXcKdsHPztfXZRSh);
        OQvKsiYcxiVLNMaX(sb, ')');
        int iBXhlPojEYhYmWLaS = BXhlPojEYhYmWLaS(lBpIFefpYjAuPoBd(this), 50, 10);
        if (iBXhlPojEYhYmWLaS / 100 == 0) {
            lmFcDLellExKeHbO(sb, '0');
        }
        if (iBXhlPojEYhYmWLaS / 10 == 0) {
            sDWsPdaBnGngaxxK(sb, '0');
        }
        JKavhwjSRyltudnc(sb, iBXhlPojEYhYmWLaS);
        YPldPczQurxWDLQX(sb, GxfShFsmndHWzZvb(xIzzumoYaFXupcWa(qKBnIViQzBuniWIT(this), 60, null)));
        return rarEwBAxurjnEgvY(sb);
    }
}

