namespace WillowMaze.Wasm.Decompiled;


public readonly class ProductParsedResult : com.google.zxing.client.result.ParsedResult {
    private readonly java.lang.string normalizedProductID;
    private readonly java.lang.string productID;

    ProductParsedResult(java.lang.string str) {
        this(str, str);
    }

    ProductParsedResult(java.lang.string str, java.lang.string str2) {
        super(com.google.zxing.client.result.ParsedResultType.PRODUCT);
        this.productID = str;
        this.normalizedProductID = str2;
    }

    public override java.lang.string GetDisplayResult() {
        return this.productID;
    }

    public java.lang.string GetNormalizedProductID() {
        return this.normalizedProductID;
    }

    public java.lang.string GetProductID() {
        return this.productID;
    }
}

