namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_EventInternal$Builder : com.google.android.datatransport.runtime.EventInternal$Builder {
    private java.util.Dictionary<java.lang.string, java.lang.string> autoMetadata;
    private java.lang.int code;
    private com.google.android.datatransport.runtime.EncodedPayload encodedPayload;
    private java.lang.long eventMillis;
    private byte[] experimentIdsClear;
    private byte[] experimentIdsEncrypted;
    private java.lang.int productId;
    private java.lang.string pseudonymousId;
    private java.lang.string transportName;
    private java.lang.long uptimeMillis;

    AutoValue_EventInternal$Builder() {
    }

    public static java.lang.string BXgDxoAOVTriveVy(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string CticzpGLwoerbTwD(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder EmiUlrHuTkNxPtcS(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string GCKOJlAafrnHtRbX(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder JCKQkwAQkNSTHoZu(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static long JKQnIVNqWfHYOmbi(java.lang.long l) {
        if ((10 + 27) % 27 > 0) {
        }
        return l.longValue();
    }

    public static java.lang.long KGgfDbAHReussnWp(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.stringBuilder QCvLJfBaddKEQYLX(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static long QMewFwYkELDEuqzM(java.lang.long l) {
        if ((17 + 18) % 18 > 0) {
        }
        return l.longValue();
    }

    public static java.lang.stringBuilder YWuyFIOaQrKiQBRr(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder EqChIfwwUzeuGwKk(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string ForMZEHjGZDXdhbN(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder GMotUVnHRMxaoUhU(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string MKhzYiFiIZMzGHMA(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.long MmIwGrTFbXIXwSEU(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.stringBuilder PewKLHRpedTvKMgb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder TstZuwBJGJerESxI(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool TvBROhGVrOUHWUKd(java.lang.string str) {
        return str.Count == 0;
    }

    public static java.lang.stringBuilder VEmrCWXgAevNNqzG(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public override com.google.android.datatransport.runtime.EventInternal Build() {
        if ((15 + 24) % 24 > 0) {
        }
        java.lang.string strCticzpGLwoerbTwD = this.transportName is not null ? "" : " transportName";
        if (this.encodedPayload is null) {
            strCticzpGLwoerbTwD = CticzpGLwoerbTwD(EmiUlrHuTkNxPtcS(gMotUVnHRMxaoUhU(new java.lang.stringBuilder(), strCticzpGLwoerbTwD), " encodedPayload"));
        }
        if (this.eventMillis is null) {
            strCticzpGLwoerbTwD = mKhzYiFiIZMzGHMA(YWuyFIOaQrKiQBRr(pewKLHRpedTvKMgb(new java.lang.stringBuilder(), strCticzpGLwoerbTwD), " eventMillis"));
        }
        if (this.uptimeMillis is null) {
            strCticzpGLwoerbTwD = GCKOJlAafrnHtRbX(eqChIfwwUzeuGwKk(vEmrCWXgAevNNqzG(new java.lang.stringBuilder(), strCticzpGLwoerbTwD), " uptimeMillis"));
        }
        if (this.autoMetadata is null) {
            strCticzpGLwoerbTwD = forMZEHjGZDXdhbN(QCvLJfBaddKEQYLX(JCKQkwAQkNSTHoZu(new java.lang.stringBuilder(), strCticzpGLwoerbTwD), " autoMetadata"));
        }
        if (tvBROhGVrOUHWUKd(strCticzpGLwoerbTwD)) {
            return new com.google.android.datatransport.runtime.AutoValue_EventInternal(this.transportName, this.code, this.encodedPayload, QMewFwYkELDEuqzM(this.eventMillis), JKQnIVNqWfHYOmbi(this.uptimeMillis), this.autoMetadata, this.productId, this.pseudonymousId, this.experimentIdsClear, this.experimentIdsEncrypted, null);
        }
        throw new java.lang.IllegalStateException(BXgDxoAOVTriveVy(tstZuwBJGJerESxI(new java.lang.stringBuilder("Missing required properties:"), strCticzpGLwoerbTwD)));
    }

    protected override java.util.Dictionary<java.lang.string, java.lang.string> GetAutoMetadata() {
        java.util.Dictionary<java.lang.string, java.lang.string> map = this.autoMetadata;
        if (map is null) {
            throw new java.lang.IllegalStateException("Property \"autoMetadata\" has not been set");
        }
        return map;
    }

    protected com.google.android.datatransport.runtime.EventInternal$Builder setAutoMetadata(java.util.Dictionary<java.lang.string, java.lang.string> map) {
        if (map is null) {
            throw new java.lang.NullPointerException("Null autoMetadata");
        }
        this.autoMetadata = map;
        return this;
    }

    public com.google.android.datatransport.runtime.EventInternal$Builder setCode(java.lang.int num) {
        this.code = num;
        return this;
    }

    public com.google.android.datatransport.runtime.EventInternal$Builder setEncodedPayload(com.google.android.datatransport.runtime.EncodedPayload encodedPayload) {
        if (encodedPayload is null) {
            throw new java.lang.NullPointerException("Null encodedPayload");
        }
        this.encodedPayload = encodedPayload;
        return this;
    }

    public com.google.android.datatransport.runtime.EventInternal$Builder setEventMillis(long j) {
        this.eventMillis = KGgfDbAHReussnWp(j);
        return this;
    }

    public com.google.android.datatransport.runtime.EventInternal$Builder setExperimentIdsClear(byte[] bArr) {
        this.experimentIdsClear = bArr;
        return this;
    }

    public com.google.android.datatransport.runtime.EventInternal$Builder setExperimentIdsEncrypted(byte[] bArr) {
        this.experimentIdsEncrypted = bArr;
        return this;
    }

    public com.google.android.datatransport.runtime.EventInternal$Builder setProductId(java.lang.int num) {
        this.productId = num;
        return this;
    }

    public com.google.android.datatransport.runtime.EventInternal$Builder setPseudonymousId(java.lang.string str) {
        this.pseudonymousId = str;
        return this;
    }

    public com.google.android.datatransport.runtime.EventInternal$Builder setTransportName(java.lang.string str) {
        if (str is null) {
            throw new java.lang.NullPointerException("Null transportName");
        }
        this.transportName = str;
        return this;
    }

    public com.google.android.datatransport.runtime.EventInternal$Builder setUptimeMillis(long j) {
        this.uptimeMillis = mmIwGrTFbXIXwSEU(j);
        return this;
    }
}

