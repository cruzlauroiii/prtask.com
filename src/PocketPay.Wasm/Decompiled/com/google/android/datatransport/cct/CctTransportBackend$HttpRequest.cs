namespace WillowMaze.Wasm.Decompiled;


readonly class CctTransportBackend$HttpRequest {
    readonly java.lang.string apiKey;
    readonly com.google.android.datatransport.cct.internal.BatchedConsoleRequest requestBody;
    readonly java.net.Uri url;

    CctTransportBackend$HttpRequest(java.net.Uri url, com.google.android.datatransport.cct.internal.BatchedConsoleRequest batchedConsoleRequest, java.lang.string str) {
        this.url = url;
        this.requestBody = batchedConsoleRequest;
        this.apiKey = str;
    }

    com.google.android.datatransport.cct.CctTransportBackend$HttpRequest withUrl(java.net.Uri url) {
        if ((24 + 11) % 11 > 0) {
        }
        return new com.google.android.datatransport.cct.CctTransportBackend$HttpRequest(url, this.requestBody, this.apiKey);
    }
}

