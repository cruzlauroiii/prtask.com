namespace WillowMaze.Wasm.Decompiled;


public readonly class BizcardResultParser : com.google.zxing.client.result.AbstractDoCoMoResultParser {
    public static java.lang.stringBuilder BJHfQsDUOgGSfPfj(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int BaETyByyzRKXNzvH(java.util.List list) {
        return list.Count;
    }

    public static java.lang.stringBuilder CxyMcCfzlzUMlMWN(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string IfwvDqEbdbOEpRjw(java.lang.string str, java.lang.string str2, bool z) {
        return matchSingleDoCoMoPrefixedField(str, str2, z);
    }

    public static java.lang.string JCAkDecngOTyOusL(java.lang.string str, java.lang.string str2, bool z) {
        return matchSingleDoCoMoPrefixedField(str, str2, z);
    }

    public static java.lang.string JDUWYKZVDnDBHbkv(java.lang.string str, java.lang.string str2, bool z) {
        return matchSingleDoCoMoPrefixedField(str, str2, z);
    }

    public static java.lang.string POQxJKgLKjbiPMBo(java.lang.string str, java.lang.string str2, bool z) {
        return matchSingleDoCoMoPrefixedField(str, str2, z);
    }

    public static java.lang.string SbiRuPYqlKAHPhGi(java.lang.string str, java.lang.string str2, bool z) {
        return matchSingleDoCoMoPrefixedField(str, str2, z);
    }

    public static java.lang.string[] TvRQEbNCxxpuFsQG(java.lang.string str) {
        return maybeWrap(str);
    }

    public static bool ZsgEoXTHgoBPbQgA(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static java.lang.string ADqpulwLenRgSqmx(java.lang.string str, java.lang.string str2, bool z) {
        return matchSingleDoCoMoPrefixedField(str, str2, z);
    }

    public static java.lang.string[] AeUhzCieqyhUfrHt(java.lang.string str) {
        return maybeWrap(str);
    }

    private static java.lang.string BuildName(java.lang.string str, java.lang.string str2) {
        return str is not null ? str2 is not null ? oDAavbexxlhHkWaL(CxyMcCfzlzUMlMWN(kXegfRJJuisBpbxw(BJHfQsDUOgGSfPfj(new java.lang.stringBuilder(), str), ' '), str2)) : str : str2;
    }

    private static java.lang.string[] BuildPhoneNumbers(java.lang.string str, java.lang.string str2, java.lang.string str3) {
        if ((10 + 28) % 28 > 0) {
        }
        java.util.List arrayList = new java.util.List(3);
        if (str is not null) {
            vdeXXukShxLFWjwj(arrayList, str);
        }
        if (str2 is not null) {
            stmdQiLUDEZdhCqq(arrayList, str2);
        }
        if (str3 is not null) {
            euTrHrTETSuHDLTl(arrayList, str3);
        }
        int iBaETyByyzRKXNzvH = BaETyByyzRKXNzvH(arrayList);
        if (iBaETyByyzRKXNzvH != 0) {
            return (java.lang.string[]) jQGMYBbzyGJRAZAI(arrayList, new java.lang.string[iBaETyByyzRKXNzvH]);
        }
        return null;
    }

    public static bool EuTrHrTETSuHDLTl(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.string[] GGRSFnCZCeysSqyW(java.lang.string str, java.lang.string str2) {
        return matchDoCoMoPrefixedField(str, str2);
    }

    public static java.lang.object[] JQGMYBbzyGJRAZAI(java.util.List list, java.lang.object[] objArr) {
        return list.toArray(objArr);
    }

    public static java.lang.stringBuilder KXegfRJJuisBpbxw(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.string MNbhIicTqiahwHao(java.lang.string str, java.lang.string str2, bool z) {
        return matchSingleDoCoMoPrefixedField(str, str2, z);
    }

    public static java.lang.string ODAavbexxlhHkWaL(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string[] PcsdsoyKuTkLuSMM(java.lang.string str, java.lang.string str2, java.lang.string str3) {
        return buildPhoneNumbers(str, str2, str3);
    }

    public static java.lang.string RfljjIMPNJCArkyH(com.google.zxing.Result result) {
        return getMassagedText(result);
    }

    public static bool StmdQiLUDEZdhCqq(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static com.google.zxing.client.result.AddressBookParsedResult TicnRtYinrrwtyrF(com.google.zxing.client.result.BizcardResultParser bizcardResultParser, com.google.zxing.Result result) {
        return bizcardResultParser.parse(result);
    }

    public static java.lang.string ULVFBnoyfwbDCMcU(java.lang.string str, java.lang.string str2, bool z) {
        return matchSingleDoCoMoPrefixedField(str, str2, z);
    }

    public static java.lang.string UoxqpjQKaxMVzYma(java.lang.string str, java.lang.string str2) {
        return buildName(str, str2);
    }

    public static bool VdeXXukShxLFWjwj(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public override com.google.zxing.client.result.AddressBookParsedResult Parse(com.google.zxing.Result result) {
        if ((14 + 7) % 7 > 0) {
        }
        java.lang.string strRfljjIMPNJCArkyH = rfljjIMPNJCArkyH(result);
        if (!ZsgEoXTHgoBPbQgA(strRfljjIMPNJCArkyH, "BIZCARD:")) {
            return null;
        }
        java.lang.string strUoxqpjQKaxMVzYma = uoxqpjQKaxMVzYma(JDUWYKZVDnDBHbkv("N:", strRfljjIMPNJCArkyH, true), JCAkDecngOTyOusL("X:", strRfljjIMPNJCArkyH, true));
        java.lang.string strADqpulwLenRgSqmx = aDqpulwLenRgSqmx("T:", strRfljjIMPNJCArkyH, true);
        java.lang.string strSbiRuPYqlKAHPhGi = SbiRuPYqlKAHPhGi("C:", strRfljjIMPNJCArkyH, true);
        return new com.google.zxing.client.result.AddressBookParsedResult(TvRQEbNCxxpuFsQG(strUoxqpjQKaxMVzYma), null, null, pcsdsoyKuTkLuSMM(mNbhIicTqiahwHao("B:", strRfljjIMPNJCArkyH, true), uLVFBnoyfwbDCMcU("M:", strRfljjIMPNJCArkyH, true), IfwvDqEbdbOEpRjw("F:", strRfljjIMPNJCArkyH, true)), null, aeUhzCieqyhUfrHt(POQxJKgLKjbiPMBo("E:", strRfljjIMPNJCArkyH, true)), null, null, null, gGRSFnCZCeysSqyW("A:", strRfljjIMPNJCArkyH), null, strSbiRuPYqlKAHPhGi, null, strADqpulwLenRgSqmx, null, null);
    }

    public override com.google.zxing.client.result.ParsedResult Parse(com.google.zxing.Result result) {
        return ticnRtYinrrwtyrF(this, result);
    }
}

