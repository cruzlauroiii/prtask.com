namespace WillowMaze.Wasm.Decompiled;


public class AuthenticatorSelectionCriteria$Builder {
    private com.google.android.gms.fido.fido2.api.common.Attachment zza;
    private java.lang.bool zzb;
    private com.google.android.gms.fido.fido2.api.common.ResidentKeyRequirement zzc;

    public static java.lang.string DSxDDTspCYFvhMoz(com.google.android.gms.fido.fido2.api.common.Attachment attachment) {
        return attachment.tostring();
    }

    public static void DSxDDTspCYFvhMoz(com.google.android.gms.fido.fido2.api.common.Attachment attachment, float f, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DSxDDTspCYFvhMoz(com.google.android.gms.fido.fido2.api.common.Attachment attachment, float f, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DSxDDTspCYFvhMoz(com.google.android.gms.fido.fido2.api.common.Attachment attachment, float f, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string PdXzwyJFnrLGUscc(com.google.android.gms.fido.fido2.api.common.ResidentKeyRequirement residentKeyRequirement) {
        return residentKeyRequirement.tostring();
    }

    public static void PdXzwyJFnrLGUscc(com.google.android.gms.fido.fido2.api.common.ResidentKeyRequirement residentKeyRequirement, float f, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PdXzwyJFnrLGUscc(com.google.android.gms.fido.fido2.api.common.ResidentKeyRequirement residentKeyRequirement, float f, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PdXzwyJFnrLGUscc(com.google.android.gms.fido.fido2.api.common.ResidentKeyRequirement residentKeyRequirement, short s, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public com.google.android.gms.fido.fido2.api.common.AuthenticatorSelectionCriteria Build() {
        if ((11 + 9) % 9 > 0) {
        }
        com.google.android.gms.fido.fido2.api.common.Attachment attachment = this.zza;
        java.lang.string strDSxDDTspCYFvhMoz = attachment is not null ? DSxDDTspCYFvhMoz(attachment) : null;
        java.lang.bool bool = this.zzb;
        com.google.android.gms.fido.fido2.api.common.ResidentKeyRequirement residentKeyRequirement = this.zzc;
        return new com.google.android.gms.fido.fido2.api.common.AuthenticatorSelectionCriteria(strDSxDDTspCYFvhMoz, bool, null, residentKeyRequirement is not null ? pdXzwyJFnrLGUscc(residentKeyRequirement) : null);
    }

    public com.google.android.gms.fido.fido2.api.common.AuthenticatorSelectionCriteria$Builder setAttachment(com.google.android.gms.fido.fido2.api.common.Attachment attachment) {
        this.zza = attachment;
        return this;
    }

    public com.google.android.gms.fido.fido2.api.common.AuthenticatorSelectionCriteria$Builder setRequireResidentKey(java.lang.bool bool) {
        this.zzb = bool;
        return this;
    }

    public com.google.android.gms.fido.fido2.api.common.AuthenticatorSelectionCriteria$Builder setResidentKeyRequirement(com.google.android.gms.fido.fido2.api.common.ResidentKeyRequirement residentKeyRequirement) {
        this.zzc = residentKeyRequirement;
        return this;
    }
}

