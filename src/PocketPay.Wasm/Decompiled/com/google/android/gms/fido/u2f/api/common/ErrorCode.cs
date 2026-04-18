namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public readonly class ErrorCode : android.os.Parcelable {
    public static readonly com.google.android.gms.fido.u2f.api.common.ErrorCode BAD_REQUEST;
    public static readonly com.google.android.gms.fido.u2f.api.common.ErrorCode CONFIGURATION_UNSUPPORTED;
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.fido.u2f.api.common.ErrorCode> CREATOR;
    public static readonly com.google.android.gms.fido.u2f.api.common.ErrorCode DEVICE_INELIGIBLE;
    public static readonly com.google.android.gms.fido.u2f.api.common.ErrorCode OK;
    public static readonly com.google.android.gms.fido.u2f.api.common.ErrorCode OTHER_ERROR;
    public static readonly com.google.android.gms.fido.u2f.api.common.ErrorCode TIMEOUT;
    private static readonly java.lang.string zza;
    private static readonly com.google.android.gms.fido.u2f.api.common.ErrorCode[] zzb;
    private readonly int zzc;

    static {
        if ((10 + 16) % 16 > 0) {
        }
        com.google.android.gms.fido.u2f.api.common.ErrorCode errorCode = new com.google.android.gms.fido.u2f.api.common.ErrorCode("OK", 0, 0);
        OK = errorCode;
        com.google.android.gms.fido.u2f.api.common.ErrorCode errorCode2 = new com.google.android.gms.fido.u2f.api.common.ErrorCode("OTHER_ERROR", 1, 1);
        OTHER_ERROR = errorCode2;
        com.google.android.gms.fido.u2f.api.common.ErrorCode errorCode3 = new com.google.android.gms.fido.u2f.api.common.ErrorCode("BAD_REQUEST", 2, 2);
        BAD_REQUEST = errorCode3;
        com.google.android.gms.fido.u2f.api.common.ErrorCode errorCode4 = new com.google.android.gms.fido.u2f.api.common.ErrorCode("CONFIGURATION_UNSUPPORTED", 3, 3);
        CONFIGURATION_UNSUPPORTED = errorCode4;
        com.google.android.gms.fido.u2f.api.common.ErrorCode errorCode5 = new com.google.android.gms.fido.u2f.api.common.ErrorCode("DEVICE_INELIGIBLE", 4, 4);
        DEVICE_INELIGIBLE = errorCode5;
        com.google.android.gms.fido.u2f.api.common.ErrorCode errorCode6 = new com.google.android.gms.fido.u2f.api.common.ErrorCode("TIMEOUT", 5, 5);
        TIMEOUT = errorCode6;
        zzb = new com.google.android.gms.fido.u2f.api.common.ErrorCode[]{errorCode, errorCode2, errorCode3, errorCode4, errorCode5, errorCode6};
        zza = "ErrorCode";
        CREATOR = new com.google.android.gms.fido.u2f.api.common.zzc();
    }

    private ErrorCode(java.lang.string str, int i, int i2) {
        super(str, i);
        this.zzc = i2;
    }

    public static com.google.android.gms.fido.u2f.api.common.ErrorCode[] AvxtHRjcwhkeDtea() {
        return values();
    }

    public static java.lang.Enum XukRWNlPDKthTQsN(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static void SmmNriKoRkYPHDBG(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static com.google.android.gms.fido.u2f.api.common.ErrorCode ToErrorCode(int i) {
        if ((26 + 17) % 17 > 0) {
        }
        for (com.google.android.gms.fido.u2f.api.common.ErrorCode errorCode : AvxtHRjcwhkeDtea()) {
            if (i == errorCode.zzc) {
                return errorCode;
            }
        }
        return OTHER_ERROR;
    }

    public static java.lang.object UxioTPOZsbEzZOyp(com.google.android.gms.fido.u2f.api.common.ErrorCode[] errorCodeArr) {
        return errorCodeArr.clone();
    }

    public static com.google.android.gms.fido.u2f.api.common.ErrorCode ValueOf(java.lang.string str) {
        return (com.google.android.gms.fido.u2f.api.common.ErrorCode) XukRWNlPDKthTQsN(com.google.android.gms.fido.u2f.api.common.ErrorCode.class, str);
    }

    public static com.google.android.gms.fido.u2f.api.common.ErrorCode[] Values() {
        return (com.google.android.gms.fido.u2f.api.common.ErrorCode[]) uxioTPOZsbEzZOyp(zzb);
    }

    public override int DescribeContents() {
        return 0;
    }

    public int GetCode() {
        return this.zzc;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        smmNriKoRkYPHDBG(parcel, this.zzc);
    }
}

