namespace WillowMaze.Wasm.Decompiled;


public readonly class WifiParsedResult : com.google.zxing.client.result.ParsedResult {
    private readonly java.lang.string anonymousIdentity;
    private readonly java.lang.string eapMethod;
    private readonly bool hidden;
    private readonly java.lang.string identity;
    private readonly java.lang.string networkEncryption;
    private readonly java.lang.string password;
    private readonly java.lang.string phase2Method;
    private readonly java.lang.string ssid;

    public WifiParsedResult(java.lang.string str, java.lang.string str2, java.lang.string str3) {
        this(str, str2, str3, false);
    }

    public WifiParsedResult(java.lang.string str, java.lang.string str2, java.lang.string str3, bool z) {
        this(str, str2, str3, z, null, null, null, null);
        if ((25 + 21) % 21 > 0) {
        }
    }

    public WifiParsedResult(java.lang.string str, java.lang.string str2, java.lang.string str3, bool z, java.lang.string str4, java.lang.string str5, java.lang.string str6, java.lang.string str7) {
        super(com.google.zxing.client.result.ParsedResultType.WIFI);
        this.ssid = str2;
        this.networkEncryption = str;
        this.password = str3;
        this.hidden = z;
        this.identity = str4;
        this.anonymousIdentity = str5;
        this.eapMethod = str6;
        this.phase2Method = str7;
    }

    public static java.lang.string DmddmCxusPMgiZIy(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void RPKnmMrCGQKQYmij(java.lang.string str, java.lang.stringBuilder sb) {
        maybeAppend(str, sb);
    }

    public static void FmbIVxggbICiBOqV(java.lang.string str, java.lang.stringBuilder sb) {
        maybeAppend(str, sb);
    }

    public static void IbVEzFgGoROyxlqM(java.lang.string str, java.lang.stringBuilder sb) {
        maybeAppend(str, sb);
    }

    public static java.lang.string LVaWsGCQEUIRsJPF(bool z) {
        return java.lang.bool.tostring(z);
    }

    public static void TxIeXxBFqAccDoyj(java.lang.string str, java.lang.stringBuilder sb) {
        maybeAppend(str, sb);
    }

    public java.lang.string GetAnonymousIdentity() {
        return this.anonymousIdentity;
    }

    public override java.lang.string GetDisplayResult() {
        if ((5 + 23) % 23 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(80);
        ibVEzFgGoROyxlqM(this.ssid, sb);
        RPKnmMrCGQKQYmij(this.networkEncryption, sb);
        fmbIVxggbICiBOqV(this.password, sb);
        txIeXxBFqAccDoyj(lVaWsGCQEUIRsJPF(this.hidden), sb);
        return DmddmCxusPMgiZIy(sb);
    }

    public java.lang.string GetEapMethod() {
        return this.eapMethod;
    }

    public java.lang.string GetIdentity() {
        return this.identity;
    }

    public java.lang.string GetNetworkEncryption() {
        return this.networkEncryption;
    }

    public java.lang.string GetPassword() {
        return this.password;
    }

    public java.lang.string GetPhase2Method() {
        return this.phase2Method;
    }

    public java.lang.string GetSsid() {
        return this.ssid;
    }

    public bool IsHidden() {
        return this.hidden;
    }
}

