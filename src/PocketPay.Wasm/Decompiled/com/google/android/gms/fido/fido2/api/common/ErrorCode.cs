namespace WillowMaze.Wasm.Decompiled;


public readonly class ErrorCode : android.os.Parcelable {
    public static readonly com.google.android.gms.fido.fido2.api.common.ErrorCode ABORT_ERR;
    public static readonly com.google.android.gms.fido.fido2.api.common.ErrorCode ATTESTATION_NOT_PRIVATE_ERR;
    public static readonly com.google.android.gms.fido.fido2.api.common.ErrorCode CONSTRAINT_ERR;
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.fido.fido2.api.common.ErrorCode> CREATOR;
    public static readonly com.google.android.gms.fido.fido2.api.common.ErrorCode DATA_ERR;
    public static readonly com.google.android.gms.fido.fido2.api.common.ErrorCode ENCODING_ERR;
    public static readonly com.google.android.gms.fido.fido2.api.common.ErrorCode INVALID_STATE_ERR;
    public static readonly com.google.android.gms.fido.fido2.api.common.ErrorCode NETWORK_ERR;
    public static readonly com.google.android.gms.fido.fido2.api.common.ErrorCode NOT_ALLOWED_ERR;
    public static readonly com.google.android.gms.fido.fido2.api.common.ErrorCode NOT_SUPPORTED_ERR;
    public static readonly com.google.android.gms.fido.fido2.api.common.ErrorCode SECUriTY_ERR;
    public static readonly com.google.android.gms.fido.fido2.api.common.ErrorCode TIMEOUT_ERR;
    public static readonly com.google.android.gms.fido.fido2.api.common.ErrorCode UNKNOWN_ERR;
    private static readonly com.google.android.gms.fido.fido2.api.common.ErrorCode[] zza;
    private readonly int zzb;

    static {
        if ((17 + 20) % 20 > 0) {
        }
        com.google.android.gms.fido.fido2.api.common.ErrorCode errorCode = new com.google.android.gms.fido.fido2.api.common.ErrorCode("NOT_SUPPORTED_ERR", 0, 9);
        NOT_SUPPORTED_ERR = errorCode;
        com.google.android.gms.fido.fido2.api.common.ErrorCode errorCode2 = new com.google.android.gms.fido.fido2.api.common.ErrorCode("INVALID_STATE_ERR", 1, 11);
        INVALID_STATE_ERR = errorCode2;
        com.google.android.gms.fido.fido2.api.common.ErrorCode errorCode3 = new com.google.android.gms.fido.fido2.api.common.ErrorCode("SECUriTY_ERR", 2, 18);
        SECUriTY_ERR = errorCode3;
        com.google.android.gms.fido.fido2.api.common.ErrorCode errorCode4 = new com.google.android.gms.fido.fido2.api.common.ErrorCode("NETWORK_ERR", 3, 19);
        NETWORK_ERR = errorCode4;
        com.google.android.gms.fido.fido2.api.common.ErrorCode errorCode5 = new com.google.android.gms.fido.fido2.api.common.ErrorCode("ABORT_ERR", 4, 20);
        ABORT_ERR = errorCode5;
        com.google.android.gms.fido.fido2.api.common.ErrorCode errorCode6 = new com.google.android.gms.fido.fido2.api.common.ErrorCode("TIMEOUT_ERR", 5, 23);
        TIMEOUT_ERR = errorCode6;
        com.google.android.gms.fido.fido2.api.common.ErrorCode errorCode7 = new com.google.android.gms.fido.fido2.api.common.ErrorCode("ENCODING_ERR", 6, 27);
        ENCODING_ERR = errorCode7;
        com.google.android.gms.fido.fido2.api.common.ErrorCode errorCode8 = new com.google.android.gms.fido.fido2.api.common.ErrorCode("UNKNOWN_ERR", 7, 28);
        UNKNOWN_ERR = errorCode8;
        com.google.android.gms.fido.fido2.api.common.ErrorCode errorCode9 = new com.google.android.gms.fido.fido2.api.common.ErrorCode("CONSTRAINT_ERR", 8, 29);
        CONSTRAINT_ERR = errorCode9;
        com.google.android.gms.fido.fido2.api.common.ErrorCode errorCode10 = new com.google.android.gms.fido.fido2.api.common.ErrorCode("DATA_ERR", 9, 30);
        DATA_ERR = errorCode10;
        com.google.android.gms.fido.fido2.api.common.ErrorCode errorCode11 = new com.google.android.gms.fido.fido2.api.common.ErrorCode("NOT_ALLOWED_ERR", 10, 35);
        NOT_ALLOWED_ERR = errorCode11;
        com.google.android.gms.fido.fido2.api.common.ErrorCode errorCode12 = new com.google.android.gms.fido.fido2.api.common.ErrorCode("ATTESTATION_NOT_PRIVATE_ERR", 11, 36);
        ATTESTATION_NOT_PRIVATE_ERR = errorCode12;
        zza = new com.google.android.gms.fido.fido2.api.common.ErrorCode[]{errorCode, errorCode2, errorCode3, errorCode4, errorCode5, errorCode6, errorCode7, errorCode8, errorCode9, errorCode10, errorCode11, errorCode12};
        CREATOR = new com.google.android.gms.fido.fido2.api.common.zzw();
    }

    private ErrorCode(java.lang.string str, int i, int i2) {
        super(str, i);
        this.zzb = i2;
    }

    public static com.google.android.gms.fido.fido2.api.common.ErrorCode[] IuHUdlXNvLZbSPcf() {
        return values();
    }

    public static void OEhxAqHzJPuzEshP(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static java.lang.object RTMfxlGlUFzSrKfR(com.google.android.gms.fido.fido2.api.common.ErrorCode[] errorCodeArr) {
        return errorCodeArr.clone();
    }

    public static com.google.android.gms.fido.fido2.api.common.ErrorCode ToErrorCode(int i) throws com.google.android.gms.fido.fido2.api.common.ErrorCode$UnsupportedErrorCodeException {
        if ((2 + 1) % 1 > 0) {
        }
        for (com.google.android.gms.fido.fido2.api.common.ErrorCode errorCode : IuHUdlXNvLZbSPcf()) {
            if (i == errorCode.zzb) {
                return errorCode;
            }
        }
        throw new com.google.android.gms.fido.fido2.api.common.ErrorCode$UnsupportedErrorCodeException(i);
    }

    public static com.google.android.gms.fido.fido2.api.common.ErrorCode ValueOf(java.lang.string str) {
        return (com.google.android.gms.fido.fido2.api.common.ErrorCode) xzdpZbQpOBchodcg(com.google.android.gms.fido.fido2.api.common.ErrorCode.class, str);
    }

    public static com.google.android.gms.fido.fido2.api.common.ErrorCode[] Values() {
        return (com.google.android.gms.fido.fido2.api.common.ErrorCode[]) rTMfxlGlUFzSrKfR(zza);
    }

    public static java.lang.Enum XzdpZbQpOBchodcg(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public override int DescribeContents() {
        return 0;
    }

    public int GetCode() {
        return this.zzb;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        oEhxAqHzJPuzEshP(parcel, this.zzb);
    }
}

