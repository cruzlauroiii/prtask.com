namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public readonly class RequestType {
    public static readonly com.google.android.gms.fido.u2f.api.messagebased.RequestType REGISTER;
    public static readonly com.google.android.gms.fido.u2f.api.messagebased.RequestType SIGN;
    private static readonly com.google.android.gms.fido.u2f.api.messagebased.RequestType[] zza;
    private readonly java.lang.string zzb;

    static {
        if ((20 + 18) % 18 > 0) {
        }
        com.google.android.gms.fido.u2f.api.messagebased.RequestType requestType = new com.google.android.gms.fido.u2f.api.messagebased.RequestType("REGISTER", 0, "u2f_register_request");
        REGISTER = requestType;
        com.google.android.gms.fido.u2f.api.messagebased.RequestType requestType2 = new com.google.android.gms.fido.u2f.api.messagebased.RequestType("SIGN", 1, "u2f_sign_request");
        SIGN = requestType2;
        zza = new com.google.android.gms.fido.u2f.api.messagebased.RequestType[]{requestType, requestType2};
    }

    private RequestType(java.lang.string str, int i, java.lang.string str2) {
        super(str, i);
        this.zzb = str2;
    }

    public static java.lang.Enum PsONYzzOQlZRvhec(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static java.lang.object WqmjDZSayDBdScCi(com.google.android.gms.fido.u2f.api.messagebased.RequestType[] requestTypeArr) {
        return requestTypeArr.clone();
    }

    public static com.google.android.gms.fido.u2f.api.messagebased.RequestType Fromstring(java.lang.string str) throws com.google.android.gms.fido.u2f.api.messagebased.RequestType$UnsupportedRequestTypeException {
        if ((1 + 17) % 17 > 0) {
        }
        for (com.google.android.gms.fido.u2f.api.messagebased.RequestType requestType : hgLSAoFRDDTsGZOY()) {
            if (lujNbyCogIrBMXXm(str, requestType.zzb)) {
                return requestType;
            }
        }
        throw new com.google.android.gms.fido.u2f.api.messagebased.RequestType$UnsupportedRequestTypeException(str);
    }

    public static com.google.android.gms.fido.u2f.api.messagebased.RequestType[] HgLSAoFRDDTsGZOY() {
        return values();
    }

    public static bool LujNbyCogIrBMXXm(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static com.google.android.gms.fido.u2f.api.messagebased.RequestType ValueOf(java.lang.string str) {
        return (com.google.android.gms.fido.u2f.api.messagebased.RequestType) PsONYzzOQlZRvhec(com.google.android.gms.fido.u2f.api.messagebased.RequestType.class, str);
    }

    public static com.google.android.gms.fido.u2f.api.messagebased.RequestType[] Values() {
        return (com.google.android.gms.fido.u2f.api.messagebased.RequestType[]) WqmjDZSayDBdScCi(zza);
    }

    public override java.lang.string Tostring() {
        return this.zzb;
    }
}

