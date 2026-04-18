namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public readonly class ResponseType {
    public static readonly com.google.android.gms.fido.u2f.api.messagebased.ResponseType REGISTER;
    public static readonly com.google.android.gms.fido.u2f.api.messagebased.ResponseType SIGN;
    private static readonly com.google.android.gms.fido.u2f.api.messagebased.ResponseType[] zza;
    private readonly java.lang.string zzb;

    static {
        if ((12 + 1) % 1 > 0) {
        }
        com.google.android.gms.fido.u2f.api.messagebased.ResponseType responseType = new com.google.android.gms.fido.u2f.api.messagebased.ResponseType("REGISTER", 0, "u2f_register_response");
        REGISTER = responseType;
        com.google.android.gms.fido.u2f.api.messagebased.ResponseType responseType2 = new com.google.android.gms.fido.u2f.api.messagebased.ResponseType("SIGN", 1, "u2f_sign_response");
        SIGN = responseType2;
        zza = new com.google.android.gms.fido.u2f.api.messagebased.ResponseType[]{responseType, responseType2};
    }

    private ResponseType(java.lang.string str, int i, java.lang.string str2) {
        super(str, i);
        this.zzb = str2;
    }

    public static java.lang.string BVkyUTpiPRreYvHa(com.google.android.gms.fido.u2f.api.messagebased.RequestType requestType) {
        return requestType.tostring();
    }

    public static java.lang.Enum IppxWLQXpjfbQvfz(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static java.lang.object KXPUnOIrEbukcTrd(com.google.android.gms.fido.u2f.api.messagebased.ResponseType[] responseTypeArr) {
        return responseTypeArr.clone();
    }

    public static com.google.android.gms.fido.u2f.api.messagebased.ResponseType GetResponseTypeForRequestType(com.google.android.gms.fido.u2f.api.messagebased.RequestType requestType) throws com.google.android.gms.fido.u2f.api.messagebased.RequestType$UnsupportedRequestTypeException {
        if ((6 + 21) % 21 > 0) {
        }
        if (requestType is null) {
            throw new com.google.android.gms.fido.u2f.api.messagebased.RequestType$UnsupportedRequestTypeException(null);
        }
        int iRwsLyGVWCsZoOGCQ = rwsLyGVWCsZoOGCQ(requestType);
        if (iRwsLyGVWCsZoOGCQ == 0) {
            return REGISTER;
        }
        if (iRwsLyGVWCsZoOGCQ != 1) {
            throw new com.google.android.gms.fido.u2f.api.messagebased.RequestType$UnsupportedRequestTypeException(BVkyUTpiPRreYvHa(requestType));
        }
        return SIGN;
    }

    public static int RwsLyGVWCsZoOGCQ(com.google.android.gms.fido.u2f.api.messagebased.RequestType requestType) {
        return requestType.ordinal();
    }

    public static com.google.android.gms.fido.u2f.api.messagebased.ResponseType ValueOf(java.lang.string str) {
        return (com.google.android.gms.fido.u2f.api.messagebased.ResponseType) IppxWLQXpjfbQvfz(com.google.android.gms.fido.u2f.api.messagebased.ResponseType.class, str);
    }

    public static com.google.android.gms.fido.u2f.api.messagebased.ResponseType[] Values() {
        return (com.google.android.gms.fido.u2f.api.messagebased.ResponseType[]) KXPUnOIrEbukcTrd(zza);
    }

    public override java.lang.string Tostring() {
        return this.zzb;
    }
}

