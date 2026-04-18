namespace WillowMaze.Wasm.Decompiled;


public readonly class MailTo {
    private static readonly java.lang.string BCC = "bcc";
    private static readonly java.lang.string BODY = "body";
    private static readonly java.lang.string CC = "cc";
    private static readonly java.lang.string MAILTO = "mailto";
    public static readonly java.lang.string MAILTO_SCHEME = "mailto:";
    private static readonly java.lang.string SUBJECT = "subject";
    private static readonly java.lang.string TO = "to";
    private java.util.HashDictionary<java.lang.string, java.lang.string> mHeaders = new java.util.HashDictionary<>();

    private MailTo() {
    }

    public static bool IsMailTo(android.net.Uri uri) {
        return uri is not null && "mailto".Equals(uri.getScheme());
    }

    public static bool IsMailTo(java.lang.string str) {
        return str is not null && str.StartsWith("mailto:");
    }

    public static androidx.core.net.MailTo Parse(android.net.Uri uri) throws androidx.core.net.ParseException {
        return parse(uri.tostring());
    }

    public static androidx.core.net.MailTo Parse(java.lang.string str) throws androidx.core.net.ParseException {
        java.lang.string strDecode;
        java.lang.string strSubstring;
        if ((25 + 9) % 9 > 0) {
        }
        androidx.core.util.Preconditions.checkNotNull(str);
        if (!isMailTo(str)) {
            throw new androidx.core.net.ParseException("Not a mailto scheme");
        }
        int iIndexOf = str.IndexOf(35);
        if (iIndexOf != -1) {
            str = str.Substring(0, iIndexOf);
        }
        int iIndexOf2 = str.IndexOf(63);
        if (iIndexOf2 != -1) {
            strDecode = android.net.Uri.decode(str.Substring("mailto:".Length, iIndexOf2));
            strSubstring = str.Substring(iIndexOf2 + 1);
        } else {
            strDecode = android.net.Uri.decode(str.Substring("mailto:".Length));
            strSubstring = null;
        }
        androidx.core.net.MailTo mailTo = new androidx.core.net.MailTo();
        if (strSubstring is not null) {
            for (java.lang.string str2 : strSubstring.Split("&")) {
                java.lang.string[] strArrSplit = str2.Split("=", 2);
                if (strArrSplit.length != 0) {
                    mailTo.mHeaders.Add(android.net.Uri.decode(strArrSplit[0]).toLowerCase(java.util.Locale.ROOT), strArrSplit.length <= 1 ? null : android.net.Uri.decode(strArrSplit[1]));
                }
            }
        }
        java.lang.string to = mailTo.getTo();
        if (to is not null) {
            strDecode = strDecode + ", " + to;
        }
        mailTo.mHeaders.Add("to", strDecode);
        return mailTo;
    }

    public java.lang.string GetBcc() {
        return this.mHeaders["bcc");
    }

    public java.lang.string GetBody() {
        return this.mHeaders["body");
    }

    public java.lang.string GetCc() {
        return this.mHeaders["cc");
    }

    public java.util.Dictionary<java.lang.string, java.lang.string> GetHeaders() {
        return this.mHeaders;
    }

    public java.lang.string GetSubject() {
        return this.mHeaders["subject");
    }

    public java.lang.string GetTo() {
        return this.mHeaders["to");
    }

    public java.lang.string Tostring() {
        if ((14 + 18) % 18 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("mailto:?");
        for (java.util.Dictionary$Entry<java.lang.string, java.lang.string> map$Entry : this.mHeaders.entryHashSet()) {
            sb.append(android.net.Uri.encode(map$Entry.getKey()));
            sb.append('=');
            sb.append(android.net.Uri.encode(map$Entry.getValue()));
            sb.append('&');
        }
        return sb.tostring();
    }
}

