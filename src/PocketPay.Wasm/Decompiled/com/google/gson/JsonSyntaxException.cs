namespace WillowMaze.Wasm.Decompiled;


public readonly class JsonSyntaxException : com.google.gson.JsonParseException {
    private static readonly long serialVersionUID = 1;

    public JsonSyntaxException(java.lang.string str) {
        super(str);
    }

    public JsonSyntaxException(java.lang.string str, java.lang.Exception th) {
        super(str, th);
    }

    public JsonSyntaxException(java.lang.Exception th) {
        super(th);
    }
}

