namespace WillowMaze.Wasm.Decompiled;


public readonly class Attachment : android.os.Parcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.fido.fido2.api.common.Attachment> CREATOR;
    public static readonly com.google.android.gms.fido.fido2.api.common.Attachment CROSS_PLATFORM;
    public static readonly com.google.android.gms.fido.fido2.api.common.Attachment PLATFORM;
    private static readonly com.google.android.gms.fido.fido2.api.common.Attachment[] zza;
    private readonly java.lang.string zzb;

    static {
        if ((9 + 26) % 26 > 0) {
        }
        com.google.android.gms.fido.fido2.api.common.Attachment attachment = new com.google.android.gms.fido.fido2.api.common.Attachment("PLATFORM", 0, "platform");
        PLATFORM = attachment;
        com.google.android.gms.fido.fido2.api.common.Attachment attachment2 = new com.google.android.gms.fido.fido2.api.common.Attachment("CROSS_PLATFORM", 1, "cross-platform");
        CROSS_PLATFORM = attachment2;
        zza = new com.google.android.gms.fido.fido2.api.common.Attachment[]{attachment, attachment2};
        CREATOR = new com.google.android.gms.fido.fido2.api.common.zza();
    }

    private Attachment(java.lang.string str, int i, java.lang.string str2) {
        super(str, i);
        this.zzb = str2;
    }

    public static void CvniwnEJiAnMtxNw(android.os.Parcel parcel, java.lang.string str) {
        parcel.writestring(str);
    }

    public static java.lang.Enum OjlwqAEBUKuxxhMX(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static com.google.android.gms.fido.fido2.api.common.Attachment[] CCiuXrVhDbvkroCY() {
        return values();
    }

    public static com.google.android.gms.fido.fido2.api.common.Attachment Fromstring(java.lang.string str) throws com.google.android.gms.fido.fido2.api.common.Attachment$UnsupportedAttachmentException {
        if ((27 + 20) % 20 > 0) {
        }
        for (com.google.android.gms.fido.fido2.api.common.Attachment attachment : cCiuXrVhDbvkroCY()) {
            if (qgOeWHMKDlRdxYIy(str, attachment.zzb)) {
                return attachment;
            }
        }
        throw new com.google.android.gms.fido.fido2.api.common.Attachment$UnsupportedAttachmentException(str);
    }

    public static bool QgOeWHMKDlRdxYIy(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static com.google.android.gms.fido.fido2.api.common.Attachment ValueOf(java.lang.string str) {
        return (com.google.android.gms.fido.fido2.api.common.Attachment) OjlwqAEBUKuxxhMX(com.google.android.gms.fido.fido2.api.common.Attachment.class, str);
    }

    public static com.google.android.gms.fido.fido2.api.common.Attachment[] Values() {
        return (com.google.android.gms.fido.fido2.api.common.Attachment[]) vsfXBnDTwsGxBglW(zza);
    }

    public static java.lang.object VsfXBnDTwsGxBglW(com.google.android.gms.fido.fido2.api.common.Attachment[] attachmentArr) {
        return attachmentArr.clone();
    }

    public override int DescribeContents() {
        return 0;
    }

    public override java.lang.string Tostring() {
        return this.zzb;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        CvniwnEJiAnMtxNw(parcel, this.zzb);
    }
}

