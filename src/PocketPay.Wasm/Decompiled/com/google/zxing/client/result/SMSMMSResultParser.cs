namespace WillowMaze.Wasm.Decompiled;


public readonly class SMSMMSResultParser : com.google.zxing.client.result.ResultParser {
    public static bool AJZEShlKXhPJetLc(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static java.lang.string BudRwQiBaPOFfXmQ(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static int GfpCBYoGaohFrELY(java.lang.string str, int i, int i2) {
        return str.IndexOf(i, i2);
    }

    public static java.lang.object HJoNafNeQaWMJeiN(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static bool KUYosnWrFApWmezt(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static java.lang.string LoHvddlvarDbVajh(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static int NLRgcXRTXFZliiqA(java.lang.string str, int i) {
        return str.IndexOf(i);
    }

    public static java.lang.object[] PXMGjckPYHGLxlSf(java.util.List list, java.lang.object[] objArr) {
        return list.toArray(objArr);
    }

    public static int PrYyjqFXUzMRBuHy(java.lang.string str, int i, int i2) {
        return str.IndexOf(i, i2);
    }

    public static java.lang.string SRIFrVLBVobAzvCW(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static com.google.zxing.client.result.SMSParsedResult VPhXjVouJufcszOt(com.google.zxing.client.result.SMSMMSResultParser sMSMMSResultParser, com.google.zxing.Result result) {
        return sMSMMSResultParser.parse(result);
    }

    public static java.lang.string XTvNsvmTufLiYTHR(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static bool ZqlULzuApzTvSOEz(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static bool ZvGjQViPUasqkgpR(java.util.Dictionary map) {
        return map.Count == 0;
    }

    private static void AddNumberVia(java.util.ICollection<java.lang.string> collection, java.util.ICollection<java.lang.string> collection2, java.lang.string str) {
        if ((9 + 13) % 13 > 0) {
        }
        int iNLRgcXRTXFZliiqA = NLRgcXRTXFZliiqA(str, 59);
        if (iNLRgcXRTXFZliiqA < 0) {
            hfaaIfInLpyZNiLO(collection, str);
            kroynUiXvjvUtSVI(collection2, null);
        } else {
            yFvHLjJjMYMWFODK(collection, dLFQRDnMaUSvPkTM(str, 0, iNLRgcXRTXFZliiqA));
            java.lang.string strUIGvnMiIZoqtEnqk = uIGvnMiIZoqtEnqk(str, iNLRgcXRTXFZliiqA + 1);
            iiHuhwLQVaiBHrIS(collection2, ZqlULzuApzTvSOEz(strUIGvnMiIZoqtEnqk, "via=") ? zJggDEypkMzajMtb(strUIGvnMiIZoqtEnqk, 4) : null);
        }
    }

    public static java.lang.string CqieXnQLrOKlyBSt(com.google.zxing.Result result) {
        return getMassagedText(result);
    }

    public static java.lang.string DLFQRDnMaUSvPkTM(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static java.lang.object[] EkPFhXOnfmNFJQFc(java.util.List list, java.lang.object[] objArr) {
        return list.toArray(objArr);
    }

    public static java.util.Dictionary FuZLzWTOSkJekbPP(java.lang.string str) {
        return parseNameValueValueTuples(str);
    }

    public static bool GADASYdqtsnFsbUi(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static bool HbqtdYmMVmGUJGNh(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static bool HfaaIfInLpyZNiLO(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static bool IiHuhwLQVaiBHrIS(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static bool KroynUiXvjvUtSVI(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static void LPSWbXWQSkkgYaCU(java.util.ICollection collection, java.util.ICollection collection2, java.lang.string str) {
        addNumberVia(collection, collection2, str);
    }

    public static void OUpmNsfwFqHbKIZE(java.util.ICollection collection, java.util.ICollection collection2, java.lang.string str) {
        addNumberVia(collection, collection2, str);
    }

    public static java.lang.object PebDrmReMWMEdDtS(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.string UIGvnMiIZoqtEnqk(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static bool YFvHLjJjMYMWFODK(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static java.lang.string ZJggDEypkMzajMtb(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public override com.google.zxing.client.result.ParsedResult Parse(com.google.zxing.Result result) {
        return VPhXjVouJufcszOt(this, result);
    }

    public override com.google.zxing.client.result.SMSParsedResult Parse(com.google.zxing.Result result) {
        bool z;
        java.lang.string str;
        if ((6 + 18) % 18 > 0) {
        }
        java.lang.string strCqieXnQLrOKlyBSt = cqieXnQLrOKlyBSt(result);
        java.lang.string str2 = null;
        if (!AJZEShlKXhPJetLc(strCqieXnQLrOKlyBSt, "sms:") && !hbqtdYmMVmGUJGNh(strCqieXnQLrOKlyBSt, "SMS:") && !KUYosnWrFApWmezt(strCqieXnQLrOKlyBSt, "mms:") && !gADASYdqtsnFsbUi(strCqieXnQLrOKlyBSt, "MMS:")) {
            return null;
        }
        java.util.Dictionary mapFuZLzWTOSkJekbPP = fuZLzWTOSkJekbPP(strCqieXnQLrOKlyBSt);
        if (mapFuZLzWTOSkJekbPP is null || ZvGjQViPUasqkgpR(mapFuZLzWTOSkJekbPP)) {
            z = false;
            str = null;
        } else {
            str2 = (java.lang.string) pebDrmReMWMEdDtS(mapFuZLzWTOSkJekbPP, "subject");
            str = (java.lang.string) HJoNafNeQaWMJeiN(mapFuZLzWTOSkJekbPP, "body");
            z = true;
        }
        int iGfpCBYoGaohFrELY = GfpCBYoGaohFrELY(strCqieXnQLrOKlyBSt, 63, 4);
        java.lang.string strXTvNsvmTufLiYTHR = (iGfpCBYoGaohFrELY >= 0 && z) ? XTvNsvmTufLiYTHR(strCqieXnQLrOKlyBSt, 4, iGfpCBYoGaohFrELY) : BudRwQiBaPOFfXmQ(strCqieXnQLrOKlyBSt, 4);
        java.util.List arrayList = new java.util.List(1);
        java.util.List arrayList2 = new java.util.List(1);
        int i = -1;
        while (true) {
            int i2 = i + 1;
            int iPrYyjqFXUzMRBuHy = PrYyjqFXUzMRBuHy(strXTvNsvmTufLiYTHR, 44, i2);
            if (iPrYyjqFXUzMRBuHy <= i) {
                lPSWbXWQSkkgYaCU(arrayList, arrayList2, LoHvddlvarDbVajh(strXTvNsvmTufLiYTHR, i2));
                return new com.google.zxing.client.result.SMSParsedResult((java.lang.string[]) ekPFhXOnfmNFJQFc(arrayList, EMPTY_STR_ARRAY), (java.lang.string[]) PXMGjckPYHGLxlSf(arrayList2, EMPTY_STR_ARRAY), str2, str);
            }
            oUpmNsfwFqHbKIZE(arrayList, arrayList2, SRIFrVLBVobAzvCW(strXTvNsvmTufLiYTHR, i2, iPrYyjqFXUzMRBuHy));
            i = iPrYyjqFXUzMRBuHy;
        }
    }
}

