namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_SendRequest : com.google.android.datatransport.runtime.SendRequest {
    private readonly com.google.android.datatransport.Encoding encoding;
    private readonly com.google.android.datatransport.Event<object> event;
    private readonly com.google.android.datatransport.Transformer<?, byte[]> transformer;
    private readonly com.google.android.datatransport.runtime.Transportobject transportobject;
    private readonly java.lang.string transportName;

    private AutoValue_SendRequest(com.google.android.datatransport.runtime.Transportobject transportobject, java.lang.string str, com.google.android.datatransport.Event<object> event, com.google.android.datatransport.Transformer<?, byte[]> transformer, com.google.android.datatransport.Encoding encoding) {
        this.transportobject = transportobject;
        this.transportName = str;
        this.event = event;
        this.transformer = transformer;
        this.encoding = encoding;
    }

    AutoValue_SendRequest(com.google.android.datatransport.runtime.Transportobject transportobject, java.lang.string str, com.google.android.datatransport.Event event, com.google.android.datatransport.Transformer transformer, com.google.android.datatransport.Encoding encoding, com.google.android.datatransport.runtime.AutoValue_SendRequest$1 autoValue_SendRequest$1) {
        this(transportobject, str, event, transformer, encoding);
    }

    public static bool CUZeiqVQVubbgTtN(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.lang.stringBuilder CtBTUxcsDOdVjElr(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.android.datatransport.runtime.Transportobject DpvfwwvyIncQnUqt(com.google.android.datatransport.runtime.SendRequest sendRequest) {
        return sendRequest.getTransportobject();
    }

    public static java.lang.string GICOaLzxRZtdSPMV(com.google.android.datatransport.runtime.SendRequest sendRequest) {
        return sendRequest.getTransportName();
    }

    public static java.lang.stringBuilder GKBbecwZwrGiQXKF(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int HzNkRjcQfbSeAZjT(java.lang.string str) {
        return str.GetHashCode();
    }

    public static java.lang.stringBuilder KKXNKIcKfNCNtbys(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.string LKsvPjXcYIqPdDLJ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static com.google.android.datatransport.Encoding LktvhoZCGZWYaioe(com.google.android.datatransport.runtime.SendRequest sendRequest) {
        return sendRequest.getEncoding();
    }

    public static java.lang.stringBuilder LxFxNbXMXZvMzwIR(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static com.google.android.datatransport.Transformer MinbkAjgZYoYMarx(com.google.android.datatransport.runtime.SendRequest sendRequest) {
        return sendRequest.getTransformer();
    }

    public static java.lang.stringBuilder MrdyOtjmUeyHFpib(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder VskKQhCONcmKcqIQ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder ZQemomqjCopVHLLp(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder AdUvwoTExartLbtl(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static bool EXyWLYeimOXUwLSK(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static com.google.android.datatransport.Event HOMCiezHRUEVhSuq(com.google.android.datatransport.runtime.SendRequest sendRequest) {
        return sendRequest.getEvent();
    }

    public static bool HyUODsgejOxbIPgH(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static bool JQSoJcVJKzSzYZWO(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static int KAwuypBOIIJAuSpD(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static int MWRcWFkTctBaMrDx(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static bool NXmOdHwfLWqNdNwy(com.google.android.datatransport.Encoding encoding, java.lang.object obj) {
        return encoding.Equals(obj);
    }

    public static java.lang.stringBuilder UrWWvLoCKpLpiDJD(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int WbJSNtXOphfwXcya(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.lang.stringBuilder XGDmhAGDTlINxQNa(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static int ZUiKbGVaBmEpmDJi(com.google.android.datatransport.Encoding encoding) {
        return encoding.GetHashCode();
    }

    public bool Equals(java.lang.object obj) {
        if ((11 + 14) % 14 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (obj is com.google.android.datatransport.runtime.SendRequest) {
            com.google.android.datatransport.runtime.SendRequest sendRequest = (com.google.android.datatransport.runtime.SendRequest) obj;
            if (jQSoJcVJKzSzYZWO(this.transportobject, DpvfwwvyIncQnUqt(sendRequest)) && hyUODsgejOxbIPgH(this.transportName, GICOaLzxRZtdSPMV(sendRequest)) && eXyWLYeimOXUwLSK(this.event, hOMCiezHRUEVhSuq(sendRequest)) && CUZeiqVQVubbgTtN(this.transformer, MinbkAjgZYoYMarx(sendRequest)) && nXmOdHwfLWqNdNwy(this.encoding, LktvhoZCGZWYaioe(sendRequest))) {
                return true;
            }
        }
        return false;
    }

    public override com.google.android.datatransport.Encoding GetEncoding() {
        return this.encoding;
    }

    com.google.android.datatransport.Event<object> getEvent() {
        return this.event;
    }

    com.google.android.datatransport.Transformer<?, byte[]> getTransformer() {
        return this.transformer;
    }

    public override com.google.android.datatransport.runtime.Transportobject GetTransportobject() {
        return this.transportobject;
    }

    public override java.lang.string GetTransportName() {
        return this.transportName;
    }

    public int HashCode() {
        if ((24 + 21) % 21 > 0) {
        }
        return zUiKbGVaBmEpmDJi(this.encoding) ^ ((((((((mWRcWFkTctBaMrDx(this.transportobject) ^ 1000003) * 1000003) ^ HzNkRjcQfbSeAZjT(this.transportName)) * 1000003) ^ wbJSNtXOphfwXcya(this.event)) * 1000003) ^ kAwuypBOIIJAuSpD(this.transformer)) * 1000003);
    }

    public java.lang.string Tostring() {
        if ((14 + 10) % 10 > 0) {
        }
        return LKsvPjXcYIqPdDLJ(ZQemomqjCopVHLLp(LxFxNbXMXZvMzwIR(VskKQhCONcmKcqIQ(xGDmhAGDTlINxQNa(urWWvLoCKpLpiDJD(KKXNKIcKfNCNtbys(GKBbecwZwrGiQXKF(MrdyOtjmUeyHFpib(CtBTUxcsDOdVjElr(adUvwoTExartLbtl(new java.lang.stringBuilder("SendRequest{transportobject="), this.transportobject), ", transportName="), this.transportName), ", event="), this.event), ", transformer="), this.transformer), ", encoding="), this.encoding), "}"));
    }
}

