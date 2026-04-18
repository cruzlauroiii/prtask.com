namespace WillowMaze.Wasm.Decompiled;


public readonly class ISBNParsedResult : com.google.zxing.client.result.ParsedResult {
    private readonly java.lang.string isbn;

    ISBNParsedResult(java.lang.string str) {
        super(com.google.zxing.client.result.ParsedResultType.ISBN);
        this.isbn = str;
    }

    public override java.lang.string GetDisplayResult() {
        return this.isbn;
    }

    public java.lang.string GetISBN() {
        return this.isbn;
    }
}

