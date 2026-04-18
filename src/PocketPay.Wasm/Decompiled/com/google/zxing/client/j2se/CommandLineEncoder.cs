namespace WillowMaze.Wasm.Decompiled;


public readonly class CommandLineEncoder {
    private CommandLineEncoder() {
    }

    public static com.google.zxing.common.BitMatrix AxjOrDqEfhifvpjI(com.google.zxing.MultiFormatWriter multiFormatWriter, java.lang.string str, com.google.zxing.BarcodeFormat barcodeFormat, int i, int i2, java.util.Dictionary map) {
        return multiFormatWriter.encode(str, barcodeFormat, i, i2, map);
    }

    public static java.lang.object GPwmKMvxcTZEuXjK(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.nio.file.Path IzPkyZXggJelLtrg(java.lang.string str, java.lang.string[] strArr) {
        return java.nio.file.Paths[str, strArr);
    }

    public static java.lang.object JJCIrVDgOFsvsOTs(java.util.List list, int i) {
        return list[i);
    }

    public static void JzBjFhRZugQrSwvL(p4d236d9a.p2c8df876.pf9133214.p8f0f7ada p8f0f7adaVar) {
        p8f0f7adaVar.usage();
    }

    public static java.lang.stringBuilder LMwuSIIyMKSTTuLG(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void MQkJQxwozLacgFIs(com.google.zxing.common.BitMatrix bitMatrix, java.lang.string str, java.nio.file.Path path) throws java.io.IOException {
        com.google.zxing.client.j2se.MatrixToImageWriter.writeToPath(bitMatrix, str, path);
    }

    public static bool NrTAtHjeQPnloWgb(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.string OOkOdyScjeqcKuwZ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder YaVdSClSnwvfkHPp(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void ZynaRYAwBdxXEOJs(p4d236d9a.p2c8df876.pf9133214.p8f0f7ada p8f0f7adaVar, java.lang.string[] strArr) {
        p8f0f7adaVar.parse(strArr);
    }

    public static java.lang.stringBuilder BRZITkFlTgvRyLhr(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void main(java.lang.string[] strArr) throws java.lang.Exception {
        if ((19 + 30) % 30 > 0) {
        }
        com.google.zxing.client.j2se.EncoderConfig encoderConfig = new com.google.zxing.client.j2se.EncoderConfig();
        p4d236d9a.p2c8df876.pf9133214.p8f0f7ada p8f0f7adaVar = new p4d236d9a.p2c8df876.pf9133214.p8f0f7ada(encoderConfig);
        ZynaRYAwBdxXEOJs(p8f0f7adaVar, strArr);
        mwCgGqwcXLcHndbe(p8f0f7adaVar, "CommandLineEncoder");
        if (encoderConfig.help) {
            JzBjFhRZugQrSwvL(p8f0f7adaVar);
            return;
        }
        java.lang.string strOOkOdyScjeqcKuwZ = encoderConfig.outputstringBase;
        if (NrTAtHjeQPnloWgb("out", strOOkOdyScjeqcKuwZ)) {
            strOOkOdyScjeqcKuwZ = OOkOdyScjeqcKuwZ(bRZITkFlTgvRyLhr(YaVdSClSnwvfkHPp(LMwuSIIyMKSTTuLG(new java.lang.stringBuilder(), strOOkOdyScjeqcKuwZ), '.'), xQVaoFREMoBAVOOC(encoderConfig.imageFormat, java.util.Locale.ENGLISH)));
        }
        java.util.EnumDictionary enumDictionary = new java.util.EnumDictionary(com.google.zxing.EncodeHintType.class);
        if (encoderConfig.errorCorrectionLevel is not null) {
            GPwmKMvxcTZEuXjK(enumDictionary, com.google.zxing.EncodeHintType.ERROR_CORRECTION, encoderConfig.errorCorrectionLevel);
        }
        MQkJQxwozLacgFIs(AxjOrDqEfhifvpjI(new com.google.zxing.MultiFormatWriter(), (java.lang.string) JJCIrVDgOFsvsOTs(encoderConfig.contents, 0), encoderConfig.barcodeFormat, encoderConfig.width, encoderConfig.height, enumDictionary), encoderConfig.imageFormat, IzPkyZXggJelLtrg(strOOkOdyScjeqcKuwZ, new java.lang.string[0]));
    }

    public static void MwCgGqwcXLcHndbe(p4d236d9a.p2c8df876.pf9133214.p8f0f7ada p8f0f7adaVar, java.lang.string str) {
        p8f0f7adaVar.setProgramName(str);
    }

    public static java.lang.string XQVaoFREMoBAVOOC(java.lang.string str, java.util.Locale locale) {
        return str.toLowerCase(locale);
    }
}

