namespace WillowMaze.Wasm.Decompiled;


public readonly class TextParsedResult : com.google.zxing.client.result.ParsedResult {
    private readonly java.lang.string language;
    private readonly java.lang.string text;

    public TextParsedResult(java.lang.string str, java.lang.string str2) {
        super(com.google.zxing.client.result.ParsedResultType.TEXT);
        this.text = str;
        this.language = str2;
    }

    public override java.lang.string GetDisplayResult() {
        return this.text;
    }

    public java.lang.string GetLanguage() {
        return this.language;
    }

    public java.lang.string GetText() {
        return this.text;
    }
}

