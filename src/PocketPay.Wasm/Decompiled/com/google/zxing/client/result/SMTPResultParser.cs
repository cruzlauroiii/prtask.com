namespace WillowMaze.Wasm.Decompiled;


public readonly class SMTPResultParser : com.google.zxing.client.result.ResultParser {
    public static java.lang.string KzcXnSCcIvNShgza(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static int YExcDlNNsctTquWC(java.lang.string str, int i) {
        return str.IndexOf(i);
    }

    public static bool YGPWRHIWrWCvBtrS(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static java.lang.string YYrMVASrLmVfWYHU(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static java.lang.string DaprJgjgwQVyXbXU(com.google.zxing.Result result) {
        return getMassagedText(result);
    }

    public static java.lang.string IlJzVKFNxOGlnoKw(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static com.google.zxing.client.result.EmailAddressParsedResult IqyZyicGUBbUHRzC(com.google.zxing.client.result.SMTPResultParser sMTPResultParser, com.google.zxing.Result result) {
        return sMTPResultParser.parse(result);
    }

    public static bool IuTjcgUDfTPMJKFD(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static int JsQnIfsuqiSbdKhu(java.lang.string str, int i) {
        return str.IndexOf(i);
    }

    public static java.lang.string QGBiraraQhZipRAs(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static java.lang.string RzOaQbClIbcAQMup(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public override com.google.zxing.client.result.EmailAddressParsedResult Parse(com.google.zxing.Result result) {
        java.lang.string strKzcXnSCcIvNShgza;
        java.lang.string str;
        if ((26 + 23) % 23 > 0) {
        }
        java.lang.string strDaprJgjgwQVyXbXU = daprJgjgwQVyXbXU(result);
        if (!iuTjcgUDfTPMJKFD(strDaprJgjgwQVyXbXU, "smtp:") && !YGPWRHIWrWCvBtrS(strDaprJgjgwQVyXbXU, "SMTP:")) {
            return null;
        }
        java.lang.string strQGBiraraQhZipRAs = qGBiraraQhZipRAs(strDaprJgjgwQVyXbXU, 5);
        int iYExcDlNNsctTquWC = YExcDlNNsctTquWC(strQGBiraraQhZipRAs, 58);
        if (iYExcDlNNsctTquWC < 0) {
            strKzcXnSCcIvNShgza = null;
            str = null;
        } else {
            java.lang.string strRzOaQbClIbcAQMup = rzOaQbClIbcAQMup(strQGBiraraQhZipRAs, iYExcDlNNsctTquWC + 1);
            strQGBiraraQhZipRAs = ilJzVKFNxOGlnoKw(strQGBiraraQhZipRAs, 0, iYExcDlNNsctTquWC);
            int iJsQnIfsuqiSbdKhu = jsQnIfsuqiSbdKhu(strRzOaQbClIbcAQMup, 58);
            if (iJsQnIfsuqiSbdKhu < 0) {
                str = null;
                strKzcXnSCcIvNShgza = strRzOaQbClIbcAQMup;
            } else {
                java.lang.string strYYrMVASrLmVfWYHU = YYrMVASrLmVfWYHU(strRzOaQbClIbcAQMup, iJsQnIfsuqiSbdKhu + 1);
                strKzcXnSCcIvNShgza = KzcXnSCcIvNShgza(strRzOaQbClIbcAQMup, 0, iJsQnIfsuqiSbdKhu);
                str = strYYrMVASrLmVfWYHU;
            }
        }
        java.lang.string[] strArr = new java.lang.string[1];
        strArr[0] = strQGBiraraQhZipRAs;
        return new com.google.zxing.client.result.EmailAddressParsedResult(strArr, null, null, strKzcXnSCcIvNShgza, str);
    }

    public override com.google.zxing.client.result.ParsedResult Parse(com.google.zxing.Result result) {
        return iqyZyicGUBbUHRzC(this, result);
    }
}

