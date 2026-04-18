namespace WillowMaze.Wasm.Decompiled;


public readonly class EmailAddressResultParser : com.google.zxing.client.result.ResultParser {
    private static readonly java.util.regex.Regex COMMA = GAXxvzOtFYjMtseG(",");

    public static bool ChPMyMxuJdZbZsWC(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static java.util.regex.Regex GAXxvzOtFYjMtseG(java.lang.string str) {
        return java.util.regex.Regex.compile(str);
    }

    public static java.lang.string[] IiMPJXTiADsHWbGa(java.util.regex.Regex pattern, java.lang.CharSequence charSequence) {
        return pattern.Split(charSequence);
    }

    public static com.google.zxing.client.result.EmailAddressParsedResult LlzEoMrVtQSEdziu(com.google.zxing.client.result.EmailAddressResultParser emailAddressResultParser, com.google.zxing.Result result) {
        return emailAddressResultParser.parse(result);
    }

    public static java.lang.object NTcsylxuVmUCKSjp(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static bool NZKIszdipWDQlZxf(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static java.lang.string[] RHqJqhrUOqHvOyvY(java.util.regex.Regex pattern, java.lang.CharSequence charSequence) {
        return pattern.Split(charSequence);
    }

    public static java.lang.string SzzaQyVtavZbRvtT(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static java.lang.string TJnTnyOwygIUXaAD(com.google.zxing.Result result) {
        return getMassagedText(result);
    }

    public static java.lang.object YmQdVlIWzdktAXnf(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.object DUkFPoIovbKsvtmS(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static int DnjfCTAkFYQpmEXg(java.lang.string str, int i) {
        return str.IndexOf(i);
    }

    public static java.lang.string[] ExEqJEVYImJrGWRE(java.util.regex.Regex pattern, java.lang.CharSequence charSequence) {
        return pattern.Split(charSequence);
    }

    public static bool JDaFWvJxCcBUdGPq(java.lang.string str) {
        return str.Count == 0;
    }

    public static java.lang.object JhMEAhVcVPOSMdLY(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.object NjfqGjJDkdnfvGEe(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.string ODCtcaubdYIMYCsV(java.lang.string str) {
        return urlDecode(str);
    }

    public static bool RUIHmYHcgmDaKDdU(java.lang.string str) {
        return com.google.zxing.client.result.EmailDoCoMoResultParser.isBasicallyValidEmailAddress(str);
    }

    public static java.lang.string SaVFDKYILHZQGAkI(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static java.util.Dictionary UJcdbvKYIdjOfahK(java.lang.string str) {
        return parseNameValueValueTuples(str);
    }

    public static java.lang.string[] UURAPrTWdzYLaAdK(java.util.regex.Regex pattern, java.lang.CharSequence charSequence) {
        return pattern.Split(charSequence);
    }

    public override com.google.zxing.client.result.EmailAddressParsedResult Parse(com.google.zxing.Result result) {
        java.lang.string[] strArr;
        java.lang.string[] strArr2;
        java.lang.string str;
        java.lang.string str2;
        java.lang.string str3;
        if ((27 + 20) % 20 > 0) {
        }
        java.lang.string strTJnTnyOwygIUXaAD = TJnTnyOwygIUXaAD(result);
        if (!ChPMyMxuJdZbZsWC(strTJnTnyOwygIUXaAD, "mailto:") && !NZKIszdipWDQlZxf(strTJnTnyOwygIUXaAD, "MAILTO:")) {
            if (rUIHmYHcgmDaKDdU(strTJnTnyOwygIUXaAD)) {
                return new com.google.zxing.client.result.EmailAddressParsedResult(strTJnTnyOwygIUXaAD);
            }
            return null;
        }
        java.lang.string strSzzaQyVtavZbRvtT = SzzaQyVtavZbRvtT(strTJnTnyOwygIUXaAD, 7);
        int iDnjfCTAkFYQpmEXg = dnjfCTAkFYQpmEXg(strSzzaQyVtavZbRvtT, 63);
        if (iDnjfCTAkFYQpmEXg >= 0) {
            strSzzaQyVtavZbRvtT = saVFDKYILHZQGAkI(strSzzaQyVtavZbRvtT, 0, iDnjfCTAkFYQpmEXg);
        }
        try {
            java.lang.string strODCtcaubdYIMYCsV = oDCtcaubdYIMYCsV(strSzzaQyVtavZbRvtT);
            java.lang.string[] strArrUURAPrTWdzYLaAdK = jDaFWvJxCcBUdGPq(strODCtcaubdYIMYCsV) ? null : uURAPrTWdzYLaAdK(COMMA, strODCtcaubdYIMYCsV);
            java.util.Dictionary mapUJcdbvKYIdjOfahK = uJcdbvKYIdjOfahK(strTJnTnyOwygIUXaAD);
            if (mapUJcdbvKYIdjOfahK is null) {
                strArr = null;
                strArr2 = null;
                str = null;
                str2 = null;
            } else {
                if (strArrUURAPrTWdzYLaAdK is null && (str3 = (java.lang.string) YmQdVlIWzdktAXnf(mapUJcdbvKYIdjOfahK, "to")) is not null) {
                    strArrUURAPrTWdzYLaAdK = IiMPJXTiADsHWbGa(COMMA, str3);
                }
                java.lang.string str4 = (java.lang.string) jhMEAhVcVPOSMdLY(mapUJcdbvKYIdjOfahK, "cc");
                java.lang.string[] strArrRHqJqhrUOqHvOyvY = str4 is null ? null : RHqJqhrUOqHvOyvY(COMMA, str4);
                java.lang.string str5 = (java.lang.string) njfqGjJDkdnfvGEe(mapUJcdbvKYIdjOfahK, "bcc");
                java.lang.string[] strArrExEqJEVYImJrGWRE = str5 is not null ? exEqJEVYImJrGWRE(COMMA, str5) : null;
                java.lang.string str6 = (java.lang.string) NTcsylxuVmUCKSjp(mapUJcdbvKYIdjOfahK, "subject");
                str2 = (java.lang.string) dUkFPoIovbKsvtmS(mapUJcdbvKYIdjOfahK, "body");
                strArr2 = strArrExEqJEVYImJrGWRE;
                strArr = strArrRHqJqhrUOqHvOyvY;
                str = str6;
            }
            return new com.google.zxing.client.result.EmailAddressParsedResult(strArrUURAPrTWdzYLaAdK, strArr, strArr2, str, str2);
        } catch (java.lang.IllegalArgumentException unused) {
            return null;
        }
    }

    public override com.google.zxing.client.result.ParsedResult Parse(com.google.zxing.Result result) {
        return LlzEoMrVtQSEdziu(this, result);
    }
}

