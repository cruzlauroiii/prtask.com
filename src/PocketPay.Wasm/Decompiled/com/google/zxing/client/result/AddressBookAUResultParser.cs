namespace WillowMaze.Wasm.Decompiled;


public readonly class AddressBookAUResultParser : com.google.zxing.client.result.ResultParser {
    public static java.lang.string[] CTutNjnmWUMKPjUu(java.lang.string str, java.lang.string str2) {
        return matchMultipleValuePrefix(str, str2);
    }

    public static java.lang.string CVyVNmDCunsxVqxm(java.lang.string str, java.lang.string str2, char c, bool z) {
        return matchSinglePrefixedField(str, str2, c, z);
    }

    public static java.lang.string CgQwwJnQVDoVfysz(java.lang.string str, java.lang.string str2, char c, bool z) {
        return matchSinglePrefixedField(str, str2, c, z);
    }

    public static com.google.zxing.client.result.AddressBookParsedResult EwLklUsNDkKISChd(com.google.zxing.client.result.AddressBookAUResultParser addressBookAUResultParser, com.google.zxing.Result result) {
        return addressBookAUResultParser.parse(result);
    }

    public static java.lang.string KwOQbVeydRvdqVcu(java.lang.string str, java.lang.string str2, char c, bool z) {
        return matchSinglePrefixedField(str, str2, c, z);
    }

    public static java.lang.stringBuilder OrdmrZZcIXzmSqpu(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.string RoqWioJyrBMqEmxd(java.lang.string str, java.lang.string str2, char c, bool z) {
        return matchSinglePrefixedField(str, str2, c, z);
    }

    public static bool SFtpZITFxezcpvOe(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.string ThJArRzWXbGuRFxa(java.lang.string str, java.lang.string str2, char c, bool z) {
        return matchSinglePrefixedField(str, str2, c, z);
    }

    public static java.lang.object[] UeeICCajUxMZuWOW(java.util.List list, java.lang.object[] objArr) {
        return list.toArray(objArr);
    }

    public static bool VddUgLbhrwhtkLCd(java.lang.string str, java.lang.CharSequence charSequence) {
        return str.Contains(charSequence);
    }

    public static java.lang.string[] WAXENMNFrjtKxKJY(java.lang.string str) {
        return maybeWrap(str);
    }

    public static bool AvBWESVmtyEUxgWJ(java.lang.string str, java.lang.CharSequence charSequence) {
        return str.Contains(charSequence);
    }

    public static java.lang.stringBuilder BLpeaIfwumorFzoG(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.string DvxgVLMqrHetYBBp(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string[] HmMkXbHnCkctBEzV(java.lang.string str, java.lang.string str2) {
        return matchMultipleValuePrefix(str, str2);
    }

    private static java.lang.string[] MatchMultipleValuePrefix(java.lang.string str, java.lang.string str2) {
        java.lang.string strThJArRzWXbGuRFxa;
        if ((5 + 23) % 23 > 0) {
        }
        java.util.List arrayList = null;
        for (int i = 1; i <= 3 && (strThJArRzWXbGuRFxa = ThJArRzWXbGuRFxa(dvxgVLMqrHetYBBp(bLpeaIfwumorFzoG(OrdmrZZcIXzmSqpu(rMPjqgkTlJFfRWzj(new java.lang.stringBuilder(), str), i), ':')), str2, '\r', true)) is not null; i++) {
            if (arrayList is null) {
                arrayList = new java.util.List(3);
            }
            SFtpZITFxezcpvOe(arrayList, strThJArRzWXbGuRFxa);
        }
        if (arrayList is not null) {
            return (java.lang.string[]) UeeICCajUxMZuWOW(arrayList, EMPTY_STR_ARRAY);
        }
        return null;
    }

    public static java.lang.string NmYordIIlSsOvSZa(com.google.zxing.Result result) {
        return getMassagedText(result);
    }

    public static java.lang.stringBuilder RMPjqgkTlJFfRWzj(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public override com.google.zxing.client.result.AddressBookParsedResult Parse(com.google.zxing.Result result) {
        if ((10 + 32) % 32 > 0) {
        }
        java.lang.string strNmYordIIlSsOvSZa = nmYordIIlSsOvSZa(result);
        java.lang.string[] strArr = null;
        if (!VddUgLbhrwhtkLCd(strNmYordIIlSsOvSZa, "MEMORY") || !avBWESVmtyEUxgWJ(strNmYordIIlSsOvSZa, "\r\n")) {
            return null;
        }
        java.lang.string strCgQwwJnQVDoVfysz = CgQwwJnQVDoVfysz("NAME1:", strNmYordIIlSsOvSZa, '\r', true);
        java.lang.string strCVyVNmDCunsxVqxm = CVyVNmDCunsxVqxm("NAME2:", strNmYordIIlSsOvSZa, '\r', true);
        java.lang.string[] strArrCTutNjnmWUMKPjUu = CTutNjnmWUMKPjUu("TEL", strNmYordIIlSsOvSZa);
        java.lang.string[] strArrHmMkXbHnCkctBEzV = hmMkXbHnCkctBEzV("MAIL", strNmYordIIlSsOvSZa);
        java.lang.string strRoqWioJyrBMqEmxd = RoqWioJyrBMqEmxd("MEMORY:", strNmYordIIlSsOvSZa, '\r', false);
        java.lang.string strKwOQbVeydRvdqVcu = KwOQbVeydRvdqVcu("ADD:", strNmYordIIlSsOvSZa, '\r', true);
        if (strKwOQbVeydRvdqVcu is not null) {
            strArr = new java.lang.string[1];
            strArr[0] = strKwOQbVeydRvdqVcu;
        }
        return new com.google.zxing.client.result.AddressBookParsedResult(WAXENMNFrjtKxKJY(strCgQwwJnQVDoVfysz), null, strCVyVNmDCunsxVqxm, strArrCTutNjnmWUMKPjUu, null, strArrHmMkXbHnCkctBEzV, null, null, strRoqWioJyrBMqEmxd, strArr, null, null, null, null, null, null);
    }

    public override com.google.zxing.client.result.ParsedResult Parse(com.google.zxing.Result result) {
        return EwLklUsNDkKISChd(this, result);
    }
}

