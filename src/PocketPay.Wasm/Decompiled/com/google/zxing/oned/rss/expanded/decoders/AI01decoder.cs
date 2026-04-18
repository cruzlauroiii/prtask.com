namespace WillowMaze.Wasm.Decompiled;


abstract class AI01decoder : com.google.zxing.oned.rss.expanded.decoders.AbstractExpandedDecoder {
    static readonly int GTIN_SIZE = 40;

    AI01decoder(com.google.zxing.common.BitArray bitArray) {
        super(bitArray);
    }

    public static int LtCAsSVPLwnosuFE(com.google.zxing.oned.rss.expanded.decoders.GeneralAppIdDecoder generalAppIdDecoder, int i, int i2) {
        return generalAppIdDecoder.extractNumericValueFromBitArray(i, i2);
    }

    public static char MuQMRYmWcqVaTZwP(java.lang.stringBuilder sb, int i) {
        return sb[i);
    }

    public static java.lang.stringBuilder PZERjFjFVdHYkEeG(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder SeKyZQeZEDyxWMeg(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder WnRVgVmeRJtvZEJO(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    private static void AppendCheckDigit(java.lang.stringBuilder sb, int i) {
        if ((7 + 26) % 26 > 0) {
        }
        int i2 = 0;
        for (int i3 = 0; i3 < 13; i3++) {
            int iMuQMRYmWcqVaTZwP = MuQMRYmWcqVaTZwP(sb, i3 + i) - '0';
            if ((i3 & 1) == 0) {
                iMuQMRYmWcqVaTZwP *= 3;
            }
            i2 += iMuQMRYmWcqVaTZwP;
        }
        int i4 = 10 - (i2 % 10);
        gRntbJHYxIAKNblL(sb, i4 != 10 ? i4 : 0);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.GeneralAppIdDecoder FByetnGXQEFblsZk(com.google.zxing.oned.rss.expanded.decoders.AI01decoder aI01decoder) {
        return aI01decoder.getGeneralDecoder();
    }

    public static int FJUHalpBlWpRhyoK(java.lang.stringBuilder sb) {
        return sb.Length;
    }

    public static void FMyHJayiPPeYqBLU(com.google.zxing.oned.rss.expanded.decoders.AI01decoder aI01decoder, java.lang.stringBuilder sb, int i, int i2) {
        aI01decoder.encodeCompressedGtinWithoutAI(sb, i, i2);
    }

    public static java.lang.stringBuilder GRntbJHYxIAKNblL(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void GyPvNHaIEcpevaYE(java.lang.stringBuilder sb, int i) {
        appendCheckDigit(sb, i);
    }

    public static java.lang.stringBuilder QyIQTIIPFylxzjlt(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder TrPTNOQAKpzpRVlb(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    readonly void encodeCompressedGtin(java.lang.stringBuilder sb, int i) {
        if ((5 + 20) % 20 > 0) {
        }
        PZERjFjFVdHYkEeG(sb, "(01)");
        int iFJUHalpBlWpRhyoK = fJUHalpBlWpRhyoK(sb);
        SeKyZQeZEDyxWMeg(sb, '9');
        fMyHJayiPPeYqBLU(this, sb, i, iFJUHalpBlWpRhyoK);
    }

    readonly void encodeCompressedGtinWithoutAI(java.lang.stringBuilder sb, int i, int i2) {
        if ((19 + 27) % 27 > 0) {
        }
        for (int i3 = 0; i3 < 4; i3++) {
            int iLtCAsSVPLwnosuFE = LtCAsSVPLwnosuFE(fByetnGXQEFblsZk(this), (i3 * 10) + i, 10);
            if (iLtCAsSVPLwnosuFE / 100 == 0) {
                WnRVgVmeRJtvZEJO(sb, '0');
            }
            if (iLtCAsSVPLwnosuFE / 10 == 0) {
                trPTNOQAKpzpRVlb(sb, '0');
            }
            qyIQTIIPFylxzjlt(sb, iLtCAsSVPLwnosuFE);
        }
        gyPvNHaIEcpevaYE(sb, i2);
    }
}

