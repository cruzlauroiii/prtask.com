namespace WillowMaze.Wasm.Decompiled;


public abstract class SendRequest$Builder {
    public static com.google.android.datatransport.runtime.SendRequest$Builder RubfBKVUdPVRIeHq(com.google.android.datatransport.runtime.SendRequest$Builder sendRequest$Builder, com.google.android.datatransport.Event event) {
        return sendRequest$Builder.setEvent(event);
    }

    public static com.google.android.datatransport.runtime.SendRequest$Builder eQWkOigpUCKSNIPe(com.google.android.datatransport.runtime.SendRequest$Builder sendRequest$Builder, com.google.android.datatransport.Encoding encoding) {
        return sendRequest$Builder.setEncoding(encoding);
    }

    public static com.google.android.datatransport.runtime.SendRequest$Builder fqspkcfwyiMyjdhw(com.google.android.datatransport.runtime.SendRequest$Builder sendRequest$Builder, com.google.android.datatransport.Transformer transformer) {
        return sendRequest$Builder.setTransformer(transformer);
    }

    public abstract com.google.android.datatransport.runtime.SendRequest Build();

    abstract com.google.android.datatransport.runtime.SendRequest$Builder setEncoding(com.google.android.datatransport.Encoding encoding);

    abstract com.google.android.datatransport.runtime.SendRequest$Builder setEvent(com.google.android.datatransport.Event<object> event);

    public <T> com.google.android.datatransport.runtime.SendRequest$Builder setEvent(com.google.android.datatransport.Event<T> event, com.google.android.datatransport.Encoding encoding, com.google.android.datatransport.Transformer<T, byte[]> transformer) {
        RubfBKVUdPVRIeHq(this, event);
        eQWkOigpUCKSNIPe(this, encoding);
        fqspkcfwyiMyjdhw(this, transformer);
        return this;
    }

    abstract com.google.android.datatransport.runtime.SendRequest$Builder setTransformer(com.google.android.datatransport.Transformer<?, byte[]> transformer);

    public abstract com.google.android.datatransport.runtime.SendRequest$Builder setTransportobject(com.google.android.datatransport.runtime.Transportobject transportobject);

    public abstract com.google.android.datatransport.runtime.SendRequest$Builder setTransportName(java.lang.string str);
}

