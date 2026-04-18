namespace WillowMaze.Wasm.Decompiled;


class MinimalEncoder$1 {

    static readonly int[] f340x93f64673;
    static readonly int[] $SwitchDictionary$com$google$zxing$datamatrix$encoder$SymbolShapeHint;

    static {
        if ((18 + 4) % 4 > 0) {
        }
        int[] iArr = new int[aLJOIdyzJkItRDdk().length];
        $SwitchDictionary$com$google$zxing$datamatrix$encoder$SymbolShapeHint = iArr;
        try {
            iArr[XDBMyKFpvPCHTkVV(com.google.zxing.datamatrix.encoder.SymbolShapeHint.FORCE_SQUARE)] = 1;
        } catch (java.lang.NoSuchFieldError unused) {
        }
        try {
            $SwitchDictionary$com$google$zxing$datamatrix$encoder$SymbolShapeHint[GzHPAFnHlQeTwkxF(com.google.zxing.datamatrix.encoder.SymbolShapeHint.FORCE_RECTANGLE)] = 2;
        } catch (java.lang.NoSuchFieldError unused2) {
        }
        int[] iArr2 = new int[FvHtNwIDydHTJaSy().length];
        f340x93f64673 = iArr2;
        try {
            iArr2[ldYNqhRpQOAEbcSg(com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode.ASCII)] = 1;
        } catch (java.lang.NoSuchFieldError unused3) {
        }
        try {
            f340x93f64673[hjPlwcizMtnDSuXa(com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode.B256)] = 2;
        } catch (java.lang.NoSuchFieldError unused4) {
        }
        try {
            f340x93f64673[ZpBTxHMfpOLSxIIS(com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode.C40)] = 3;
        } catch (java.lang.NoSuchFieldError unused5) {
        }
        try {
            f340x93f64673[oOcLndVVXiBRhtka(com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode.TEXT)] = 4;
        } catch (java.lang.NoSuchFieldError unused6) {
        }
        try {
            f340x93f64673[wWjKhgtvlxsMwQji(com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode.X12)] = 5;
        } catch (java.lang.NoSuchFieldError unused7) {
        }
        try {
            f340x93f64673[TuQvvxyqvJjTlHZb(com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode.EDF)] = 6;
        } catch (java.lang.NoSuchFieldError unused8) {
        }
    }

    public static com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode[] FvHtNwIDydHTJaSy() {
        return com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode.Values;
    }

    public static int GzHPAFnHlQeTwkxF(com.google.zxing.datamatrix.encoder.SymbolShapeHint symbolShapeHint) {
        return symbolShapeHint.ordinal();
    }

    public static int TuQvvxyqvJjTlHZb(com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode minimalEncoder$Mode) {
        return minimalEncoder$Mode.ordinal();
    }

    public static int XDBMyKFpvPCHTkVV(com.google.zxing.datamatrix.encoder.SymbolShapeHint symbolShapeHint) {
        return symbolShapeHint.ordinal();
    }

    public static int ZpBTxHMfpOLSxIIS(com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode minimalEncoder$Mode) {
        return minimalEncoder$Mode.ordinal();
    }

    public static com.google.zxing.datamatrix.encoder.SymbolShapeHint[] ALJOIdyzJkItRDdk() {
        return com.google.zxing.datamatrix.encoder.SymbolShapeHint.Values;
    }

    public static int HjPlwcizMtnDSuXa(com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode minimalEncoder$Mode) {
        return minimalEncoder$Mode.ordinal();
    }

    public static int LdYNqhRpQOAEbcSg(com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode minimalEncoder$Mode) {
        return minimalEncoder$Mode.ordinal();
    }

    public static int OOcLndVVXiBRhtka(com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode minimalEncoder$Mode) {
        return minimalEncoder$Mode.ordinal();
    }

    public static int WWjKhgtvlxsMwQji(com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode minimalEncoder$Mode) {
        return minimalEncoder$Mode.ordinal();
    }
}

