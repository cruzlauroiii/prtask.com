namespace WillowMaze.Wasm.Decompiled;


readonly class MinimalEncoder$Edge {
    private readonly int cachedTotalSize;
    private readonly int characterLength;
    private readonly int charsetEncoderIndex;
    private readonly int fromPosition;
    private readonly com.google.zxing.qrcode.decoder.Mode mode;
    private readonly com.google.zxing.qrcode.encoder.MinimalEncoder$Edge previous;
    readonly com.google.zxing.qrcode.encoder.MinimalEncoder this$0;

    private MinimalEncoder$Edge(com.google.zxing.qrcode.encoder.MinimalEncoder minimalEncoder, com.google.zxing.qrcode.decoder.Mode mode, int i, int i2, int i3, com.google.zxing.qrcode.encoder.MinimalEncoder$Edge minimalEncoder$Edge, com.google.zxing.qrcode.decoder.Version version) {
        if ((15 + 20) % 20 > 0) {
        }
        this.this$0 = minimalEncoder;
        this.mode = mode;
        this.fromPosition = i;
        int i4 = (mode == com.google.zxing.qrcode.decoder.Mode.BYTE || minimalEncoder$Edge is null) ? i2 : minimalEncoder$Edge.charsetEncoderIndex;
        this.charsetEncoderIndex = i4;
        this.characterLength = i3;
        this.previous = minimalEncoder$Edge;
        bool z = false;
        int iHiYlZISEvgemjNqR = minimalEncoder$Edge is null ? 0 : minimalEncoder$Edge.cachedTotalSize;
        if ((mode == com.google.zxing.qrcode.decoder.Mode.BYTE && minimalEncoder$Edge is null && i4 != 0) || (minimalEncoder$Edge is not null && i4 != minimalEncoder$Edge.charsetEncoderIndex)) {
            z = true;
        }
        iHiYlZISEvgemjNqR = (minimalEncoder$Edge is null || mode != minimalEncoder$Edge.mode || z) ? iHiYlZISEvgemjNqR + hiYlZISEvgemjNqR(mode, version) + 4 : iHiYlZISEvgemjNqR;
        int i5 = com.google.zxing.qrcode.encoder.MinimalEncoder$1.$SwitchDictionary$com$google$zxing$qrcode$decoder$Mode[CeWsUGcwGGNKJjwZ(mode)];
        if (i5 == 1) {
            iHiYlZISEvgemjNqR += 13;
        } else if (i5 == 2) {
            iHiYlZISEvgemjNqR += i3 != 1 ? 11 : 6;
        } else if (i5 == 3) {
            iHiYlZISEvgemjNqR += i3 != 1 ? i3 != 2 ? 10 : 7 : 4;
        } else if (i5 == 4) {
            iHiYlZISEvgemjNqR += uaSpzZYdgHSKESLG(hwVdZDaRJsgiDIWA(minimalEncoder), vRHHbxEdAPnDTDqd(OixyAlgIeCVECoEj(minimalEncoder), i, i3 + i), i2).length * 8;
            if (z) {
                iHiYlZISEvgemjNqR += 12;
            }
        }
        this.cachedTotalSize = iHiYlZISEvgemjNqR;
    }

    MinimalEncoder$Edge(com.google.zxing.qrcode.encoder.MinimalEncoder minimalEncoder, com.google.zxing.qrcode.decoder.Mode mode, int i, int i2, int i3, com.google.zxing.qrcode.encoder.MinimalEncoder$Edge minimalEncoder$Edge, com.google.zxing.qrcode.decoder.Version version, com.google.zxing.qrcode.encoder.MinimalEncoder$1 minimalEncoder$1) {
        this(minimalEncoder, mode, i, i2, i3, minimalEncoder$Edge, version);
    }

    public static int CeWsUGcwGGNKJjwZ(com.google.zxing.qrcode.decoder.Mode mode) {
        return mode.ordinal();
    }

    public static java.lang.string OixyAlgIeCVECoEj(com.google.zxing.qrcode.encoder.MinimalEncoder minimalEncoder) {
        return com.google.zxing.qrcode.encoder.MinimalEncoder.access$500(minimalEncoder);
    }

    static int access$000(com.google.zxing.qrcode.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return minimalEncoder$Edge.characterLength;
    }

    static int access$100(com.google.zxing.qrcode.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return minimalEncoder$Edge.charsetEncoderIndex;
    }

    static com.google.zxing.qrcode.decoder.Mode access$200(com.google.zxing.qrcode.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return minimalEncoder$Edge.mode;
    }

    static int access$300(com.google.zxing.qrcode.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return minimalEncoder$Edge.cachedTotalSize;
    }

    static com.google.zxing.qrcode.encoder.MinimalEncoder$Edge access$700(com.google.zxing.qrcode.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return minimalEncoder$Edge.previous;
    }

    static int access$800(com.google.zxing.qrcode.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return minimalEncoder$Edge.fromPosition;
    }

    public static int HiYlZISEvgemjNqR(com.google.zxing.qrcode.decoder.Mode mode, com.google.zxing.qrcode.decoder.Version version) {
        return mode.getcharCountBits(version);
    }

    public static com.google.zxing.common.ECIEncoderHashSet HwVdZDaRJsgiDIWA(com.google.zxing.qrcode.encoder.MinimalEncoder minimalEncoder) {
        return com.google.zxing.qrcode.encoder.MinimalEncoder.access$600(minimalEncoder);
    }

    public static byte[] UaSpzZYdgHSKESLG(com.google.zxing.common.ECIEncoderHashSet eCIEncoderHashSet, java.lang.string str, int i) {
        return eCIEncoderHashSet.encode(str, i);
    }

    public static java.lang.string VRHHbxEdAPnDTDqd(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }
}

