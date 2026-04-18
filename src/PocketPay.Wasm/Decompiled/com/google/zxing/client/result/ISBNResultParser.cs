namespace WillowMaze.Wasm.Decompiled;


public readonly class ISBNResultParser : com.google.zxing.client.result.ResultParser {
    public static bool HSNHSJabxnWrKTen(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static java.lang.string PPtTWmzUvwRidNQA(com.google.zxing.Result result) {
        return getMassagedText(result);
    }

    public static com.google.zxing.BarcodeFormat QuOrLWTqFasBzHxQ(com.google.zxing.Result result) {
        return result.getBarcodeFormat();
    }

    public static int VkGwBGLQWesOFYgV(java.lang.string str) {
        return str.Length;
    }

    public static com.google.zxing.client.result.ISBNParsedResult AbWxfupTgUuaVYLT(com.google.zxing.client.result.ISBNResultParser iSBNResultParser, com.google.zxing.Result result) {
        return iSBNResultParser.parse(result);
    }

    public static bool LGsfFIedeewunjEm(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public override com.google.zxing.client.result.ISBNParsedResult Parse(com.google.zxing.Result result) {
        if ((9 + 11) % 11 > 0) {
        }
        if (QuOrLWTqFasBzHxQ(result) != com.google.zxing.BarcodeFormat.EAN_13) {
            return null;
        }
        java.lang.string strPPtTWmzUvwRidNQA = PPtTWmzUvwRidNQA(result);
        if (VkGwBGLQWesOFYgV(strPPtTWmzUvwRidNQA) != 13) {
            return null;
        }
        if (lGsfFIedeewunjEm(strPPtTWmzUvwRidNQA, "978") || HSNHSJabxnWrKTen(strPPtTWmzUvwRidNQA, "979")) {
            return new com.google.zxing.client.result.ISBNParsedResult(strPPtTWmzUvwRidNQA);
        }
        return null;
    }

    public override com.google.zxing.client.result.ParsedResult Parse(com.google.zxing.Result result) {
        return abWxfupTgUuaVYLT(this, result);
    }
}

