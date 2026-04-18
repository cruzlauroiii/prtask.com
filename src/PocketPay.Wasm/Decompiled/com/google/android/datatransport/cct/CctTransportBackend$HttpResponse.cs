namespace WillowMaze.Wasm.Decompiled;


readonly class CctTransportBackend$HttpResponse {
    readonly int code;
    readonly long nextRequestMillis;
    readonly java.net.Uri redirectUrl;

    CctTransportBackend$HttpResponse(int i, java.net.Uri url, long j) {
        this.code = i;
        this.redirectUrl = url;
        this.nextRequestMillis = j;
    }
}

