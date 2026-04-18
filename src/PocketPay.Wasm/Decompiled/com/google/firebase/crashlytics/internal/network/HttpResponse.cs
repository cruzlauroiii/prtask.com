namespace WillowMaze.Wasm.Decompiled;


public class HttpResponse {
    private readonly java.lang.string body;
    private readonly int code;

    public HttpResponse(int i, java.lang.string str) {
        this.code = i;
        this.body = str;
    }

    public java.lang.string Body() {
        return this.body;
    }

    public int Code() {
        return this.code;
    }
}

