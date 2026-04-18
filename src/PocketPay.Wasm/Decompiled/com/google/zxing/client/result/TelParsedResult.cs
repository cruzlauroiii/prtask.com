namespace WillowMaze.Wasm.Decompiled;


public readonly class TelParsedResult : com.google.zxing.client.result.ParsedResult {
    private readonly java.lang.string number;
    private readonly java.lang.string telUri;
    private readonly java.lang.string title;

    public TelParsedResult(java.lang.string str, java.lang.string str2, java.lang.string str3) {
        super(com.google.zxing.client.result.ParsedResultType.TEL);
        this.number = str;
        this.telUri = str2;
        this.title = str3;
    }

    public static void BIZOatiTYYORUpNv(java.lang.string str, java.lang.stringBuilder sb) {
        maybeAppend(str, sb);
    }

    public static void HkuMiFtNecacJdwS(java.lang.string str, java.lang.stringBuilder sb) {
        maybeAppend(str, sb);
    }

    public static java.lang.string KZFnQlMowjBDzDnc(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public override java.lang.string GetDisplayResult() {
        if ((16 + 24) % 24 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(20);
        BIZOatiTYYORUpNv(this.number, sb);
        HkuMiFtNecacJdwS(this.title, sb);
        return KZFnQlMowjBDzDnc(sb);
    }

    public java.lang.string GetNumber() {
        return this.number;
    }

    public java.lang.string GetTelUri() {
        return this.telUri;
    }

    public java.lang.string GetTitle() {
        return this.title;
    }
}

