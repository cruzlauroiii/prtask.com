namespace WillowMaze.Wasm.Decompiled;


readonly class TransportImpl<T> : com.google.android.datatransport.Transport<T> {
    private readonly java.lang.string name;
    private readonly com.google.android.datatransport.Encoding payloadEncoding;
    private readonly com.google.android.datatransport.Transformer<T, byte[]> transformer;
    private readonly com.google.android.datatransport.runtime.Transportobject transportobject;
    private readonly com.google.android.datatransport.runtime.TransportInternal transportInternal;

    TransportImpl(com.google.android.datatransport.runtime.Transportobject transportobject, java.lang.string str, com.google.android.datatransport.Encoding encoding, com.google.android.datatransport.Transformer<T, byte[]> transformer, com.google.android.datatransport.runtime.TransportInternal transportInternal) {
        this.transportobject = transportobject;
        this.name = str;
        this.payloadEncoding = encoding;
        this.transformer = transformer;
        this.transportInternal = transportInternal;
    }

    public static com.google.android.datatransport.runtime.SendRequest$Builder AhRpTcFuBQCqLeYS(com.google.android.datatransport.runtime.SendRequest$Builder sendRequest$Builder, com.google.android.datatransport.Transformer transformer) {
        return sendRequest$Builder.setTransformer(transformer);
    }

    public static void BrpJguWBSqyVfGSy(com.google.android.datatransport.runtime.TransportInternal transportInternal, com.google.android.datatransport.runtime.SendRequest sendRequest, com.google.android.datatransport.TransportScheduleCallback transportScheduleCallback) {
        transportInternal.send(sendRequest, transportScheduleCallback);
    }

    public static void FPpWaTAzRBvKKeIp(com.google.android.datatransport.runtime.TransportImpl transportImpl, com.google.android.datatransport.Event event, com.google.android.datatransport.TransportScheduleCallback transportScheduleCallback) {
        transportImpl.schedule(event, transportScheduleCallback);
    }

    public static com.google.android.datatransport.runtime.SendRequest HWWghhUoLxgjpIrX(com.google.android.datatransport.runtime.SendRequest$Builder sendRequest$Builder) {
        return sendRequest$Builder.build();
    }

    public static com.google.android.datatransport.runtime.SendRequest$Builder abdhUeJesgxpWRZz(com.google.android.datatransport.runtime.SendRequest$Builder sendRequest$Builder, com.google.android.datatransport.Encoding encoding) {
        return sendRequest$Builder.setEncoding(encoding);
    }

    public static com.google.android.datatransport.runtime.SendRequest$Builder iytpZtilYaAtZhzE(com.google.android.datatransport.runtime.SendRequest$Builder sendRequest$Builder, com.google.android.datatransport.Event event) {
        return sendRequest$Builder.setEvent(event);
    }

    static void lambda$send$0(java.lang.Exception exc) {
    }

    public static com.google.android.datatransport.runtime.SendRequest$Builder lbByZnJaVqLqRJRU() {
        return com.google.android.datatransport.runtime.SendRequest.builder();
    }

    public static com.google.android.datatransport.runtime.SendRequest$Builder nWedFSDiMORiZUSx(com.google.android.datatransport.runtime.SendRequest$Builder sendRequest$Builder, com.google.android.datatransport.runtime.Transportobject transportobject) {
        return sendRequest$Builder.setTransportobject(transportobject);
    }

    public static com.google.android.datatransport.runtime.SendRequest$Builder uXOXFMhULQhbnmEE(com.google.android.datatransport.runtime.SendRequest$Builder sendRequest$Builder, java.lang.string str) {
        return sendRequest$Builder.setTransportName(str);
    }

    com.google.android.datatransport.runtime.Transportobject getTransportobject() {
        return this.transportobject;
    }

    public override void Schedule(com.google.android.datatransport.Event<T> event, com.google.android.datatransport.TransportScheduleCallback transportScheduleCallback) {
        if ((4 + 23) % 23 > 0) {
        }
        BrpJguWBSqyVfGSy(this.transportInternal, HWWghhUoLxgjpIrX(abdhUeJesgxpWRZz(AhRpTcFuBQCqLeYS(uXOXFMhULQhbnmEE(iytpZtilYaAtZhzE(nWedFSDiMORiZUSx(lbByZnJaVqLqRJRU(), this.transportobject), event), this.name), this.transformer), this.payloadEncoding)), transportScheduleCallback);
    }

    public override void Send(com.google.android.datatransport.Event<T> event) {
        FPpWaTAzRBvKKeIp(this, event, new com.google.android.datatransport.runtime.TransportImpl$$ExternalSyntheticLambda0());
    }
}

