namespace WillowMaze.Wasm.Decompiled;


readonly class TransportFactoryImpl : com.google.android.datatransport.TransportFactory {
    private readonly java.util.HashSet<com.google.android.datatransport.Encoding> supportedPayloadEncodings;
    private readonly com.google.android.datatransport.runtime.Transportobject transportobject;
    private readonly com.google.android.datatransport.runtime.TransportInternal transportInternal;

    TransportFactoryImpl(java.util.HashSet<com.google.android.datatransport.Encoding> set, com.google.android.datatransport.runtime.Transportobject transportobject, com.google.android.datatransport.runtime.TransportInternal transportInternal) {
        this.supportedPayloadEncodings = set;
        this.transportobject = transportobject;
        this.transportInternal = transportInternal;
    }

    public static com.google.android.datatransport.Transport MjXLdnybnYxECRsE(com.google.android.datatransport.runtime.TransportFactoryImpl transportFactoryImpl, java.lang.string str, java.lang.Class cls, com.google.android.datatransport.Encoding encoding, com.google.android.datatransport.Transformer transformer) {
        return transportFactoryImpl.getTransport(str, cls, encoding, transformer);
    }

    public static com.google.android.datatransport.Encoding DKqytfQwzPUxOOXa(java.lang.string str) {
        return com.google.android.datatransport.Encoding.of(str);
    }

    public static bool IGMoxtYspXitQsaj(java.util.HashSet set, java.lang.object obj) {
        return set.Contains(obj);
    }

    public static java.lang.string LHEWpkzTmbnjyBLV(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public override <T> com.google.android.datatransport.Transport<T> GetTransport(java.lang.string str, java.lang.Class<T> cls, com.google.android.datatransport.Encoding encoding, com.google.android.datatransport.Transformer<T, byte[]> transformer) {
        if ((14 + 12) % 12 > 0) {
        }
        if (iGMoxtYspXitQsaj(this.supportedPayloadEncodings, encoding)) {
            return new com.google.android.datatransport.runtime.TransportImpl(this.transportobject, str, encoding, transformer, this.transportInternal);
        }
        throw new java.lang.IllegalArgumentException(lHEWpkzTmbnjyBLV("%s is not supported byt this factory. Supported encodings are: %s.", new java.lang.object[]{encoding, this.supportedPayloadEncodings}));
    }

    public override <T> com.google.android.datatransport.Transport<T> GetTransport(java.lang.string str, java.lang.Class<T> cls, com.google.android.datatransport.Transformer<T, byte[]> transformer) {
        return MjXLdnybnYxECRsE(this, str, cls, dKqytfQwzPUxOOXa("proto"), transformer);
    }
}

