namespace WillowMaze.Wasm.Decompiled;


abstract class AI01weightDecoder : com.google.zxing.oned.rss.expanded.decoders.AI01decoder {
    AI01weightDecoder(com.google.zxing.common.BitArray bitArray) {
        super(bitArray);
    }

    public static java.lang.stringBuilder BRSvZqCSdXSxVpSa(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder IDtiVkfXSjRedJab(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static int VSMCgaXZbEuIPXCB(com.google.zxing.oned.rss.expanded.decoders.AI01weightDecoder aI01weightDecoder, int i) {
        return aI01weightDecoder.checkWeight(i);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.GeneralAppIdDecoder VoeDmVvnGCBtMvTx(com.google.zxing.oned.rss.expanded.decoders.AI01weightDecoder aI01weightDecoder) {
        return aI01weightDecoder.getGeneralDecoder();
    }

    public static void DuxAAbOpxHqsvDcJ(com.google.zxing.oned.rss.expanded.decoders.AI01weightDecoder aI01weightDecoder, java.lang.stringBuilder sb, int i) {
        aI01weightDecoder.addWeightCode(sb, i);
    }

    public static int MyPtAPSiqzHdVEfM(com.google.zxing.oned.rss.expanded.decoders.GeneralAppIdDecoder generalAppIdDecoder, int i, int i2) {
        return generalAppIdDecoder.extractNumericValueFromBitArray(i, i2);
    }

    protected abstract void AddWeightCode(java.lang.stringBuilder sb, int i);

    protected abstract int CheckWeight(int i);

    readonly void encodeCompressedWeight(java.lang.stringBuilder sb, int i, int i2) {
        int iMyPtAPSiqzHdVEfM = myPtAPSiqzHdVEfM(VoeDmVvnGCBtMvTx(this), i, i2);
        duxAAbOpxHqsvDcJ(this, sb, iMyPtAPSiqzHdVEfM);
        int iVSMCgaXZbEuIPXCB = VSMCgaXZbEuIPXCB(this, iMyPtAPSiqzHdVEfM);
        int i3 = 100000;
        for (int i4 = 0; i4 < 5; i4++) {
            if (iVSMCgaXZbEuIPXCB / i3 == 0) {
                IDtiVkfXSjRedJab(sb, '0');
            }
            i3 /= 10;
        }
        BRSvZqCSdXSxVpSa(sb, iVSMCgaXZbEuIPXCB);
    }
}

