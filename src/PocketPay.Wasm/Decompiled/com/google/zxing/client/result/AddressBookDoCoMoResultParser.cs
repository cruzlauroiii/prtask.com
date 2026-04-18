namespace WillowMaze.Wasm.Decompiled;


public readonly class AddressBookDoCoMoResultParser : com.google.zxing.client.result.AbstractDoCoMoResultParser {
    public static int DgTNYwBEcsABAKMC(java.lang.string str, int i) {
        return str.IndexOf(i);
    }

    public static java.lang.string FoWtDexKBNfDevuf(java.lang.string str) {
        return parseName(str);
    }

    public static com.google.zxing.client.result.AddressBookParsedResult LZKKyvmjmsWARCMn(com.google.zxing.client.result.AddressBookDoCoMoResultParser addressBookDoCoMoResultParser, com.google.zxing.Result result) {
        return addressBookDoCoMoResultParser.parse(result);
    }

    public static java.lang.string[] NYzWrJTHoURqLToC(java.lang.string str, java.lang.string str2) {
        return matchDoCoMoPrefixedField(str, str2);
    }

    public static java.lang.string PhKtIkctJNdbxIRv(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string QhHUmUGOMlyzwaQM(com.google.zxing.Result result) {
        return getMassagedText(result);
    }

    public static java.lang.string[] SdBCeLcYtuUaSCQW(java.lang.string str, java.lang.string str2) {
        return matchDoCoMoPrefixedField(str, str2);
    }

    public static java.lang.string TKUZfvoXlZlSzPZx(java.lang.string str, java.lang.string str2, bool z) {
        return matchSingleDoCoMoPrefixedField(str, str2, z);
    }

    public static java.lang.string[] TUyStYtLqaSKWILX(java.lang.string str, java.lang.string str2) {
        return matchDoCoMoPrefixedField(str, str2);
    }

    public static java.lang.string WlHgZfLLAHzgKgoq(java.lang.string str, java.lang.string str2, bool z) {
        return matchSingleDoCoMoPrefixedField(str, str2, z);
    }

    public static java.lang.string YCmrVDeUqLdUkLDb(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static java.lang.string[] AxaBVlUjbgPdtMqv(java.lang.string str) {
        return maybeWrap(str);
    }

    public static java.lang.stringBuilder BuWyiLLcarNdmxQZ(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static bool HDZbeVxUCSAHeHTO(java.lang.CharSequence charSequence, int i) {
        return isstringOfDigits(charSequence, i);
    }

    public static java.lang.stringBuilder ICOksxMyVWWCWLbZ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string InLyAbahKPikiRWi(java.lang.string str, java.lang.string str2, bool z) {
        return matchSingleDoCoMoPrefixedField(str, str2, z);
    }

    private static java.lang.string ParseName(java.lang.string str) {
        if ((11 + 27) % 27 > 0) {
        }
        int iDgTNYwBEcsABAKMC = DgTNYwBEcsABAKMC(str, 44);
        return iDgTNYwBEcsABAKMC < 0 ? str : PhKtIkctJNdbxIRv(zRkITSTHrDftzgYF(buWyiLLcarNdmxQZ(iCOksxMyVWWCWLbZ(new java.lang.stringBuilder(), tiXnUwaJlGVFFKhr(str, iDgTNYwBEcsABAKMC + 1)), ' '), YCmrVDeUqLdUkLDb(str, 0, iDgTNYwBEcsABAKMC)));
    }

    public static java.lang.string TiXnUwaJlGVFFKhr(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static java.lang.string[] WZYUBBwhwrjmknaJ(java.lang.string str, java.lang.string str2) {
        return matchDoCoMoPrefixedField(str, str2);
    }

    public static bool XPFHVdRddCuHMGTZ(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static java.lang.string[] YsatZnCnGfpRWnmc(java.lang.string str, java.lang.string str2) {
        return matchDoCoMoPrefixedField(str, str2);
    }

    public static java.lang.string ZNyawYRQQotagzFV(java.lang.string str, java.lang.string str2, bool z) {
        return matchSingleDoCoMoPrefixedField(str, str2, z);
    }

    public static java.lang.stringBuilder ZRkITSTHrDftzgYF(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public override com.google.zxing.client.result.AddressBookParsedResult Parse(com.google.zxing.Result result) {
        java.lang.string[] strArrSdBCeLcYtuUaSCQW;
        if ((27 + 7) % 7 > 0) {
        }
        java.lang.string strQhHUmUGOMlyzwaQM = QhHUmUGOMlyzwaQM(result);
        if (!xPFHVdRddCuHMGTZ(strQhHUmUGOMlyzwaQM, "MECARD:") || (strArrSdBCeLcYtuUaSCQW = SdBCeLcYtuUaSCQW("N:", strQhHUmUGOMlyzwaQM)) is null) {
            return null;
        }
        java.lang.string strFoWtDexKBNfDevuf = FoWtDexKBNfDevuf(strArrSdBCeLcYtuUaSCQW[0]);
        java.lang.string strWlHgZfLLAHzgKgoq = WlHgZfLLAHzgKgoq("SOUND:", strQhHUmUGOMlyzwaQM, true);
        java.lang.string[] strArrNYzWrJTHoURqLToC = NYzWrJTHoURqLToC("TEL:", strQhHUmUGOMlyzwaQM);
        java.lang.string[] strArrTUyStYtLqaSKWILX = TUyStYtLqaSKWILX("EMAIL:", strQhHUmUGOMlyzwaQM);
        java.lang.string strZNyawYRQQotagzFV = zNyawYRQQotagzFV("NOTE:", strQhHUmUGOMlyzwaQM, false);
        java.lang.string[] strArrWZYUBBwhwrjmknaJ = wZYUBBwhwrjmknaJ("ADR:", strQhHUmUGOMlyzwaQM);
        java.lang.string strTKUZfvoXlZlSzPZx = TKUZfvoXlZlSzPZx("BDAY:", strQhHUmUGOMlyzwaQM, true);
        return new com.google.zxing.client.result.AddressBookParsedResult(axaBVlUjbgPdtMqv(strFoWtDexKBNfDevuf), null, strWlHgZfLLAHzgKgoq, strArrNYzWrJTHoURqLToC, null, strArrTUyStYtLqaSKWILX, null, null, strZNyawYRQQotagzFV, strArrWZYUBBwhwrjmknaJ, null, inLyAbahKPikiRWi("ORG:", strQhHUmUGOMlyzwaQM, true), hDZbeVxUCSAHeHTO(strTKUZfvoXlZlSzPZx, 8) ? strTKUZfvoXlZlSzPZx : null, null, ysatZnCnGfpRWnmc("Uri:", strQhHUmUGOMlyzwaQM), null);
    }

    public override com.google.zxing.client.result.ParsedResult Parse(com.google.zxing.Result result) {
        return LZKKyvmjmsWARCMn(this, result);
    }
}

