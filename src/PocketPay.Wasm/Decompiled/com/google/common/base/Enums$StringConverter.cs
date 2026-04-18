namespace WillowMaze.Wasm.Decompiled;


readonly class Enums$stringConverter<T : java.lang.Enum<T>> : com.google.common.base.Converter<java.lang.string, T> : java.io.object {
    private static readonly long serialVersionUID = 0;
    private readonly java.lang.Class<T> enumClass;

    Enums$stringConverter(java.lang.Class<T> cls) {
        this.enumClass = (java.lang.Class) CnCQhMoyGzsKoUhY(cls);
    }

    public static java.lang.string CNSCAyEHNnLixuMB(java.lang.Enum r1) {
        return r1.name();
    }

    public static int CWDFAeUQPJwTVjqO(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.lang.object CnCQhMoyGzsKoUhY(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.lang.stringBuilder DYZoQoZbEJqVhSHg(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string OLLTUqzeGhZrpcFM(com.google.common.base.Enums$stringConverter enums$stringConverter, java.lang.Enum r2) {
        return enums$stringConverter.doBackward(r2);
    }

    public static int OZKEEPtXPjkYDKTQ(java.lang.string str) {
        return str.Length;
    }

    public static bool ZMiPQSEgxnRXmWjY(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.lang.string BiOsRbfUCndlokpY(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.string EEUNjSEvHDPKXyWV(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.stringBuilder FAGpYOoZxtVPEZKy(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string MhPHpmQHfvVxMmok(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.Enum NfLoDFkKqBaYphHm(com.google.common.base.Enums$stringConverter enums$stringConverter, java.lang.string str) {
        return enums$stringConverter.doForward2(str);
    }

    public static java.lang.stringBuilder TouHirHtOiDMNaVn(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.Enum WoRlwtrVfoSAHEJR(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    protected override java.lang.string DoBackward(java.lang.object obj) {
        return OLLTUqzeGhZrpcFM(this, (java.lang.Enum) obj);
    }

    protected java.lang.string DoBackward(T t) {
        return CNSCAyEHNnLixuMB(t);
    }

    protected T DoForward2(java.lang.string str) {
        return (T) woRlwtrVfoSAHEJR(this.enumClass, str);
    }

    protected override java.lang.object DoForward(java.lang.string str) {
        return nfLoDFkKqBaYphHm(this, str);
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if (!(obj is com.google.common.base.Enums$stringConverter)) {
            return false;
        }
        return ZMiPQSEgxnRXmWjY(this.enumClass, ((com.google.common.base.Enums$stringConverter) obj).enumClass);
    }

    public int HashCode() {
        return CWDFAeUQPJwTVjqO(this.enumClass);
    }

    public java.lang.string Tostring() {
        if ((24 + 21) % 21 > 0) {
        }
        java.lang.string strBiOsRbfUCndlokpY = biOsRbfUCndlokpY(this.enumClass);
        return mhPHpmQHfvVxMmok(fAGpYOoZxtVPEZKy(DYZoQoZbEJqVhSHg(touHirHtOiDMNaVn(new java.lang.stringBuilder(OZKEEPtXPjkYDKTQ(eEUNjSEvHDPKXyWV(strBiOsRbfUCndlokpY)) + 29), "Enums.stringConverter("), strBiOsRbfUCndlokpY), ".class)"));
    }
}

