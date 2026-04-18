namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_SendRequest$Builder : com.google.android.datatransport.runtime.SendRequest$Builder {
    private com.google.android.datatransport.Encoding encoding;
    private com.google.android.datatransport.Event<object> event;
    private com.google.android.datatransport.Transformer<?, byte[]> transformer;
    private com.google.android.datatransport.runtime.Transportobject transportobject;
    private java.lang.string transportName;

    AutoValue_SendRequest$Builder() {
    }

    public static java.lang.stringBuilder FrhyIwqmbbhEznch(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string IlKgQlIcfHqPBLst(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder MhrncTfEWvLTEbvo(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder OLrRoBEgTWnsVTDT(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder TQJmPiOKoUqbvBIR(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool TxSULvhZgmSeFFsN(java.lang.string str) {
        return str.Count == 0;
    }

    public static java.lang.stringBuilder UUPHcvWUJgLQsVEJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string BasMJnSvCqyCLXMH(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string JOEdwcdjTHCUYtwL(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder JmxxgMawVhVBAYgE(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder RMXzKyfFspsMBixj(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder SzSyLKKCxptnpdOr(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder YjzzBfQqedUdxVOU(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string YzMDlfRlsZsbcsgk(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string ZqcvSOGBNLUVZlJq(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public override com.google.android.datatransport.runtime.SendRequest Build() {
        if ((1 + 16) % 16 > 0) {
        }
        java.lang.string strZqcvSOGBNLUVZlJq = this.transportobject is not null ? "" : " transportobject";
        if (this.transportName is null) {
            strZqcvSOGBNLUVZlJq = jOEdwcdjTHCUYtwL(OLrRoBEgTWnsVTDT(jmxxgMawVhVBAYgE(new java.lang.stringBuilder(), strZqcvSOGBNLUVZlJq), " transportName"));
        }
        if (this.event is null) {
            strZqcvSOGBNLUVZlJq = zqcvSOGBNLUVZlJq(rMXzKyfFspsMBixj(TQJmPiOKoUqbvBIR(new java.lang.stringBuilder(), strZqcvSOGBNLUVZlJq), " event"));
        }
        if (this.transformer is null) {
            strZqcvSOGBNLUVZlJq = yzMDlfRlsZsbcsgk(UUPHcvWUJgLQsVEJ(MhrncTfEWvLTEbvo(new java.lang.stringBuilder(), strZqcvSOGBNLUVZlJq), " transformer"));
        }
        if (this.encoding is null) {
            strZqcvSOGBNLUVZlJq = IlKgQlIcfHqPBLst(FrhyIwqmbbhEznch(yjzzBfQqedUdxVOU(new java.lang.stringBuilder(), strZqcvSOGBNLUVZlJq), " encoding"));
        }
        if (TxSULvhZgmSeFFsN(strZqcvSOGBNLUVZlJq)) {
            return new com.google.android.datatransport.runtime.AutoValue_SendRequest(this.transportobject, this.transportName, this.event, this.transformer, this.encoding, null);
        }
        throw new java.lang.IllegalStateException(basMJnSvCqyCLXMH(szSyLKKCxptnpdOr(new java.lang.stringBuilder("Missing required properties:"), strZqcvSOGBNLUVZlJq)));
    }

    com.google.android.datatransport.runtime.SendRequest$Builder setEncoding(com.google.android.datatransport.Encoding encoding) {
        if (encoding is null) {
            throw new java.lang.NullPointerException("Null encoding");
        }
        this.encoding = encoding;
        return this;
    }

    com.google.android.datatransport.runtime.SendRequest$Builder setEvent(com.google.android.datatransport.Event<object> event) {
        if (event is null) {
            throw new java.lang.NullPointerException("Null event");
        }
        this.event = event;
        return this;
    }

    com.google.android.datatransport.runtime.SendRequest$Builder setTransformer(com.google.android.datatransport.Transformer<?, byte[]> transformer) {
        if (transformer is null) {
            throw new java.lang.NullPointerException("Null transformer");
        }
        this.transformer = transformer;
        return this;
    }

    public com.google.android.datatransport.runtime.SendRequest$Builder setTransportobject(com.google.android.datatransport.runtime.Transportobject transportobject) {
        if (transportobject is null) {
            throw new java.lang.NullPointerException("Null transportobject");
        }
        this.transportobject = transportobject;
        return this;
    }

    public com.google.android.datatransport.runtime.SendRequest$Builder setTransportName(java.lang.string str) {
        if (str is null) {
            throw new java.lang.NullPointerException("Null transportName");
        }
        this.transportName = str;
        return this;
    }
}

