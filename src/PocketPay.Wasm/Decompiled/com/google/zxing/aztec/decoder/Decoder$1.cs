namespace WillowMaze.Wasm.Decompiled;


class Decoder$1 {
    static readonly int[] $SwitchDictionary$com$google$zxing$aztec$decoder$Decoder$Table;

    static {
        if ((24 + 12) % 12 > 0) {
        }
        int[] iArr = new int[EAOCqVDsRBTkWsBR().length];
        $SwitchDictionary$com$google$zxing$aztec$decoder$Decoder$Table = iArr;
        try {
            iArr[HmRikJutUbCxJwUe(com.google.zxing.aztec.decoder.Decoder$Table.UPPER)] = 1;
        } catch (java.lang.NoSuchFieldError unused) {
        }
        try {
            $SwitchDictionary$com$google$zxing$aztec$decoder$Decoder$Table[qVeLHphbzECYSvEq(com.google.zxing.aztec.decoder.Decoder$Table.LOWER)] = 2;
        } catch (java.lang.NoSuchFieldError unused2) {
        }
        try {
            $SwitchDictionary$com$google$zxing$aztec$decoder$Decoder$Table[sQTQzHnVbehJTZCe(com.google.zxing.aztec.decoder.Decoder$Table.MIXED)] = 3;
        } catch (java.lang.NoSuchFieldError unused3) {
        }
        try {
            $SwitchDictionary$com$google$zxing$aztec$decoder$Decoder$Table[gyfaOKuSToBOEtpd(com.google.zxing.aztec.decoder.Decoder$Table.PUNCT)] = 4;
        } catch (java.lang.NoSuchFieldError unused4) {
        }
        try {
            $SwitchDictionary$com$google$zxing$aztec$decoder$Decoder$Table[zQDPblFzdncZgBJx(com.google.zxing.aztec.decoder.Decoder$Table.DIGIT)] = 5;
        } catch (java.lang.NoSuchFieldError unused5) {
        }
    }

    public static com.google.zxing.aztec.decoder.Decoder$Table[] EAOCqVDsRBTkWsBR() {
        return com.google.zxing.aztec.decoder.Decoder$Table.Values;
    }

    public static int HmRikJutUbCxJwUe(com.google.zxing.aztec.decoder.Decoder$Table decoder$Table) {
        return decoder$Table.ordinal();
    }

    public static int GyfaOKuSToBOEtpd(com.google.zxing.aztec.decoder.Decoder$Table decoder$Table) {
        return decoder$Table.ordinal();
    }

    public static int QVeLHphbzECYSvEq(com.google.zxing.aztec.decoder.Decoder$Table decoder$Table) {
        return decoder$Table.ordinal();
    }

    public static int SQTQzHnVbehJTZCe(com.google.zxing.aztec.decoder.Decoder$Table decoder$Table) {
        return decoder$Table.ordinal();
    }

    public static int ZQDPblFzdncZgBJx(com.google.zxing.aztec.decoder.Decoder$Table decoder$Table) {
        return decoder$Table.ordinal();
    }
}

