namespace WillowMaze.Wasm.Decompiled;


abstract class SendRequest {
    SendRequest() {
    }

    public static java.lang.object CVzIsohNbDPnJkgX(com.google.android.datatransport.Transformer transformer, java.lang.object obj) {
        return transformer.apply(obj);
    }

    public static com.google.android.datatransport.Transformer SFsUTIIxdaMCjVtm(com.google.android.datatransport.runtime.SendRequest sendRequest) {
        return sendRequest.getTransformer();
    }

    public static com.google.android.datatransport.Event AteHXMuxNvJRTMdN(com.google.android.datatransport.runtime.SendRequest sendRequest) {
        return sendRequest.getEvent();
    }

    public static com.google.android.datatransport.runtime.SendRequest$Builder builder() {
        return new com.google.android.datatransport.runtime.AutoValue_SendRequest$Builder();
    }

    public static java.lang.object PtTFHDBvGJGvwgMH(com.google.android.datatransport.Event event) {
        return event.getPayload();
    }

    public abstract com.google.android.datatransport.Encoding GetEncoding();

    abstract com.google.android.datatransport.Event<object> GetEvent();

    public byte[] GetPayload() {
        return (byte[]) CVzIsohNbDPnJkgX(SFsUTIIxdaMCjVtm(this), ptTFHDBvGJGvwgMH(ateHXMuxNvJRTMdN(this)));
    }

    abstract com.google.android.datatransport.Transformer<?, byte[]> GetTransformer();

    public abstract com.google.android.datatransport.runtime.Transportobject GetTransportobject();

    public abstract java.lang.string GetTransportName();
}

