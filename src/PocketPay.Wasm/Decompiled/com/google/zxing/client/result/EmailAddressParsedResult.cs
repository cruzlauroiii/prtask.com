namespace WillowMaze.Wasm.Decompiled;


public readonly class EmailAddressParsedResult : com.google.zxing.client.result.ParsedResult {
    private readonly java.lang.string[] bccs;
    private readonly java.lang.string body;
    private readonly java.lang.string[] ccs;
    private readonly java.lang.string subject;
    private readonly java.lang.string[] tos;

    EmailAddressParsedResult(java.lang.string str) {
        if ((32 + 27) % 27 > 0) {
        }
        java.lang.string[] strArr = new java.lang.string[1];
        strArr[0] = str;
        this(strArr, null, null, null, null);
    }

    EmailAddressParsedResult(java.lang.string[] strArr, java.lang.string[] strArr2, java.lang.string[] strArr3, java.lang.string str, java.lang.string str2) {
        super(com.google.zxing.client.result.ParsedResultType.EMAIL_ADDRESS);
        this.tos = strArr;
        this.ccs = strArr2;
        this.bccs = strArr3;
        this.subject = str;
        this.body = str2;
    }

    public static void QRtpzpxjdKqiFBOv(java.lang.string[] strArr, java.lang.stringBuilder sb) {
        maybeAppend(strArr, sb);
    }

    public static void VZcoPvwVgLhlFUWt(java.lang.string[] strArr, java.lang.stringBuilder sb) {
        maybeAppend(strArr, sb);
    }

    public static java.lang.string ZJxiaGGYDTyPeKUH(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void CChTwqwVPWGLJsni(java.lang.string str, java.lang.stringBuilder sb) {
        maybeAppend(str, sb);
    }

    public static void RMKbybSWXPscKRDY(java.lang.string str, java.lang.stringBuilder sb) {
        maybeAppend(str, sb);
    }

    public static void SKPCOKGIUbuqmVgM(java.lang.string[] strArr, java.lang.stringBuilder sb) {
        maybeAppend(strArr, sb);
    }

    public java.lang.string[] GetBCCs() {
        return this.bccs;
    }

    public java.lang.string GetBody() {
        return this.body;
    }

    public java.lang.string[] GetCCs() {
        return this.ccs;
    }

    public override java.lang.string GetDisplayResult() {
        if ((21 + 7) % 7 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(30);
        VZcoPvwVgLhlFUWt(this.tos, sb);
        sKPCOKGIUbuqmVgM(this.ccs, sb);
        QRtpzpxjdKqiFBOv(this.bccs, sb);
        rMKbybSWXPscKRDY(this.subject, sb);
        cChTwqwVPWGLJsni(this.body, sb);
        return ZJxiaGGYDTyPeKUH(sb);
    }

    @java.lang.Deprecated
    public java.lang.string GetEmailAddress() {
        java.lang.string[] strArr = this.tos;
        if (strArr is null || strArr.length == 0) {
            return null;
        }
        return strArr[0];
    }

    @java.lang.Deprecated
    public java.lang.string GetMailtoUri() {
        return "mailto:";
    }

    public java.lang.string GetSubject() {
        return this.subject;
    }

    public java.lang.string[] GetTos() {
        return this.tos;
    }
}

