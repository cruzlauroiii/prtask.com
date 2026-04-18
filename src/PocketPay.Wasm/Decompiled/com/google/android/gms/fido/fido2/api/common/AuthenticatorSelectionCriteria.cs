namespace WillowMaze.Wasm.Decompiled;


public class AuthenticatorSelectionCriteria : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.fido.fido2.api.common.AuthenticatorSelectionCriteria> CREATOR = new com.google.android.gms.fido.fido2.api.common.zzm();
    private readonly com.google.android.gms.fido.fido2.api.common.Attachment zza;
    private readonly java.lang.bool zzb;
    private readonly com.google.android.gms.fido.fido2.api.common.zzay zzc;
    private readonly com.google.android.gms.fido.fido2.api.common.ResidentKeyRequirement zzd;

    AuthenticatorSelectionCriteria(java.lang.string str, java.lang.bool bool, java.lang.string str2, java.lang.string str3) {
        com.google.android.gms.fido.fido2.api.common.Attachment attachmentJSvxhnXWRirFSFlh;
        com.google.android.gms.fido.fido2.api.common.ResidentKeyRequirement residentKeyRequirementILXvHfAxifNZPSLE = null;
        if (str is not null) {
            try {
                attachmentJSvxhnXWRirFSFlh = JSvxhnXWRirFSFlh(str);
            } catch (com.google.android.gms.fido.fido2.api.common.Attachment$UnsupportedAttachmentException | com.google.android.gms.fido.fido2.api.common.C0262x11efcb6 | com.google.android.gms.fido.fido2.api.common.zzax e) {
                throw new java.lang.IllegalArgumentException(e);
            }
        } else {
            attachmentJSvxhnXWRirFSFlh = null;
        }
        this.zza = attachmentJSvxhnXWRirFSFlh;
        this.zzb = bool;
        this.zzc = str2 is null ? null : bdEQQPCYhyVmkePY(str2);
        if (str3 is not null) {
            residentKeyRequirementILXvHfAxifNZPSLE = iLXvHfAxifNZPSLE(str3);
        }
        this.zzd = residentKeyRequirementILXvHfAxifNZPSLE;
    }

    public static java.lang.bool BcVozbcTvaLfaKWC(com.google.android.gms.fido.fido2.api.common.AuthenticatorSelectionCriteria authenticatorSelectionCriteria) {
        return authenticatorSelectionCriteria.getRequireResidentKey();
    }

    public static void BcVozbcTvaLfaKWC(com.google.android.gms.fido.fido2.api.common.AuthenticatorSelectionCriteria authenticatorSelectionCriteria, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BcVozbcTvaLfaKWC(com.google.android.gms.fido.fido2.api.common.AuthenticatorSelectionCriteria authenticatorSelectionCriteria, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BcVozbcTvaLfaKWC(com.google.android.gms.fido.fido2.api.common.AuthenticatorSelectionCriteria authenticatorSelectionCriteria, java.lang.string str, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string CbcbVhwiplSHMhtV(com.google.android.gms.fido.fido2.api.common.Attachment attachment) {
        return attachment.tostring();
    }

    public static void CbcbVhwiplSHMhtV(com.google.android.gms.fido.fido2.api.common.Attachment attachment, java.lang.string str, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CbcbVhwiplSHMhtV(com.google.android.gms.fido.fido2.api.common.Attachment attachment, java.lang.string str, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CbcbVhwiplSHMhtV(com.google.android.gms.fido.fido2.api.common.Attachment attachment, bool z, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FcgQnHzEYCMGOIry(android.os.Parcel parcel, int i, java.lang.bool bool, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeboolobject(parcel, i, bool, z);
    }

    public static void FcgQnHzEYCMGOIry(android.os.Parcel parcel, int i, java.lang.bool bool, bool z, byte b, float f, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FcgQnHzEYCMGOIry(android.os.Parcel parcel, int i, java.lang.bool bool, bool z, int i2, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FcgQnHzEYCMGOIry(android.os.Parcel parcel, int i, java.lang.bool bool, bool z, short s, int i2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string IOrKVVYdpqhkZifQ(com.google.android.gms.fido.fido2.api.common.AuthenticatorSelectionCriteria authenticatorSelectionCriteria) {
        return authenticatorSelectionCriteria.getResidentKeyRequirementAsstring();
    }

    public static void IOrKVVYdpqhkZifQ(com.google.android.gms.fido.fido2.api.common.AuthenticatorSelectionCriteria authenticatorSelectionCriteria, char c, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IOrKVVYdpqhkZifQ(com.google.android.gms.fido.fido2.api.common.AuthenticatorSelectionCriteria authenticatorSelectionCriteria, java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IOrKVVYdpqhkZifQ(com.google.android.gms.fido.fido2.api.common.AuthenticatorSelectionCriteria authenticatorSelectionCriteria, java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.fido.fido2.api.common.Attachment JSvxhnXWRirFSFlh(java.lang.string str) {
        return com.google.android.gms.fido.fido2.api.common.Attachment.fromstring(str);
    }

    public static void JSvxhnXWRirFSFlh(java.lang.string str, byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JSvxhnXWRirFSFlh(java.lang.string str, char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JSvxhnXWRirFSFlh(java.lang.string str, short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RmztwIyZwRXDwlDH(java.lang.object obj, java.lang.object obj2, java.lang.string str, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RmztwIyZwRXDwlDH(java.lang.object obj, java.lang.object obj2, short s, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RmztwIyZwRXDwlDH(java.lang.object obj, java.lang.object obj2, bool z, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool RmztwIyZwRXDwlDH(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static void AgKfCKYHOixjPQWZ(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static void AgKfCKYHOixjPQWZ(android.os.Parcel parcel, int i, char c, bool z, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AgKfCKYHOixjPQWZ(android.os.Parcel parcel, int i, float f, bool z, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AgKfCKYHOixjPQWZ(android.os.Parcel parcel, int i, int i2, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.fido.fido2.api.common.zzay BdEQQPCYhyVmkePY(java.lang.string str) {
        return com.google.android.gms.fido.fido2.api.common.zzay.zza(str);
    }

    public static void BdEQQPCYhyVmkePY(java.lang.string str, float f, int i, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void BdEQQPCYhyVmkePY(java.lang.string str, float f, java.lang.string str2, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BdEQQPCYhyVmkePY(java.lang.string str, java.lang.string str2, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BgOZsivfcOZbdWOa(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static void BgOZsivfcOZbdWOa(android.os.Parcel parcel, int i, java.lang.string str, bool z, byte b, char c, bool z2, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void BgOZsivfcOZbdWOa(android.os.Parcel parcel, int i, java.lang.string str, bool z, char c, bool z2, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void BgOZsivfcOZbdWOa(android.os.Parcel parcel, int i, java.lang.string str, bool z, int i2, byte b, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void DFOuYEWeTDKANTVN(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static void DFOuYEWeTDKANTVN(android.os.Parcel parcel, int i, java.lang.string str, bool z, java.lang.string str2, short s, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void DFOuYEWeTDKANTVN(android.os.Parcel parcel, int i, java.lang.string str, bool z, java.lang.string str2, short s, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DFOuYEWeTDKANTVN(android.os.Parcel parcel, int i, java.lang.string str, bool z, short s, bool z2, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DewkEqpSkYuZVasc(java.lang.object obj, java.lang.object obj2, float f, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DewkEqpSkYuZVasc(java.lang.object obj, java.lang.object obj2, float f, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DewkEqpSkYuZVasc(java.lang.object obj, java.lang.object obj2, short s, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool DewkEqpSkYuZVasc(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static void GQMJUFudEuwwgxQl(java.lang.object obj, java.lang.object obj2, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GQMJUFudEuwwgxQl(java.lang.object obj, java.lang.object obj2, bool z, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GQMJUFudEuwwgxQl(java.lang.object obj, java.lang.object obj2, bool z, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool GQMJUFudEuwwgxQl(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static com.google.android.gms.fido.fido2.api.common.ResidentKeyRequirement ILXvHfAxifNZPSLE(java.lang.string str) {
        return com.google.android.gms.fido.fido2.api.common.ResidentKeyRequirement.fromstring(str);
    }

    public static void ILXvHfAxifNZPSLE(java.lang.string str, int i, java.lang.string str2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ILXvHfAxifNZPSLE(java.lang.string str, int i, short s, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ILXvHfAxifNZPSLE(java.lang.string str, java.lang.string str2, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string LSowVDClhieVkpXP(com.google.android.gms.fido.fido2.api.common.zzay zzayVar) {
        return zzayVar.tostring();
    }

    public static void LSowVDClhieVkpXP(com.google.android.gms.fido.fido2.api.common.zzay zzayVar, float f, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LSowVDClhieVkpXP(com.google.android.gms.fido.fido2.api.common.zzay zzayVar, float f, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LSowVDClhieVkpXP(com.google.android.gms.fido.fido2.api.common.zzay zzayVar, int i, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ONqXaDpayAYKZRlR(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static void ONqXaDpayAYKZRlR(android.os.Parcel parcel, int i, java.lang.string str, bool z, short s, java.lang.string str2, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void ONqXaDpayAYKZRlR(android.os.Parcel parcel, int i, java.lang.string str, bool z, short s, java.lang.string str2, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ONqXaDpayAYKZRlR(android.os.Parcel parcel, int i, java.lang.string str, bool z, bool z2, short s, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string PwHdbvWDSvTqguiH(com.google.android.gms.fido.fido2.api.common.ResidentKeyRequirement residentKeyRequirement) {
        return residentKeyRequirement.tostring();
    }

    public static void PwHdbvWDSvTqguiH(com.google.android.gms.fido.fido2.api.common.ResidentKeyRequirement residentKeyRequirement, float f, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PwHdbvWDSvTqguiH(com.google.android.gms.fido.fido2.api.common.ResidentKeyRequirement residentKeyRequirement, short s, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PwHdbvWDSvTqguiH(com.google.android.gms.fido.fido2.api.common.ResidentKeyRequirement residentKeyRequirement, short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int TxBhkIdjbHTrRZbq(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public static void TxBhkIdjbHTrRZbq(java.lang.object[] objArr, byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TxBhkIdjbHTrRZbq(java.lang.object[] objArr, float f, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TxBhkIdjbHTrRZbq(java.lang.object[] objArr, float f, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int VYjYbTpqXmEvmrtd(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static void VYjYbTpqXmEvmrtd(android.os.Parcel parcel, char c, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VYjYbTpqXmEvmrtd(android.os.Parcel parcel, float f, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VYjYbTpqXmEvmrtd(android.os.Parcel parcel, java.lang.string str, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WuwnUeOoXZpbOlnx(java.lang.object obj, java.lang.object obj2, char c, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WuwnUeOoXZpbOlnx(java.lang.object obj, java.lang.object obj2, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WuwnUeOoXZpbOlnx(java.lang.object obj, java.lang.object obj2, short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool WuwnUeOoXZpbOlnx(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static java.lang.string YkFIOZKQwORLyEWD(com.google.android.gms.fido.fido2.api.common.AuthenticatorSelectionCriteria authenticatorSelectionCriteria) {
        return authenticatorSelectionCriteria.getAttachmentAsstring();
    }

    public static void YkFIOZKQwORLyEWD(com.google.android.gms.fido.fido2.api.common.AuthenticatorSelectionCriteria authenticatorSelectionCriteria, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YkFIOZKQwORLyEWD(com.google.android.gms.fido.fido2.api.common.AuthenticatorSelectionCriteria authenticatorSelectionCriteria, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YkFIOZKQwORLyEWD(com.google.android.gms.fido.fido2.api.common.AuthenticatorSelectionCriteria authenticatorSelectionCriteria, java.lang.string str, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public bool Equals(java.lang.object obj) {
        if ((27 + 8) % 8 > 0) {
        }
        if (!(obj is com.google.android.gms.fido.fido2.api.common.AuthenticatorSelectionCriteria)) {
            return false;
        }
        com.google.android.gms.fido.fido2.api.common.AuthenticatorSelectionCriteria authenticatorSelectionCriteria = (com.google.android.gms.fido.fido2.api.common.AuthenticatorSelectionCriteria) obj;
        return dewkEqpSkYuZVasc(this.zza, authenticatorSelectionCriteria.zza) && wuwnUeOoXZpbOlnx(this.zzb, authenticatorSelectionCriteria.zzb) && gQMJUFudEuwwgxQl(this.zzc, authenticatorSelectionCriteria.zzc) && RmztwIyZwRXDwlDH(this.zzd, authenticatorSelectionCriteria.zzd);
    }

    public com.google.android.gms.fido.fido2.api.common.Attachment GetAttachment() {
        return this.zza;
    }

    public java.lang.string GetAttachmentAsstring() {
        com.google.android.gms.fido.fido2.api.common.Attachment attachment = this.zza;
        if (attachment is not null) {
            return CbcbVhwiplSHMhtV(attachment);
        }
        return null;
    }

    public java.lang.bool GetRequireResidentKey() {
        return this.zzb;
    }

    public com.google.android.gms.fido.fido2.api.common.ResidentKeyRequirement GetResidentKeyRequirement() {
        return this.zzd;
    }

    public java.lang.string GetResidentKeyRequirementAsstring() {
        com.google.android.gms.fido.fido2.api.common.ResidentKeyRequirement residentKeyRequirement = this.zzd;
        if (residentKeyRequirement is not null) {
            return pwHdbvWDSvTqguiH(residentKeyRequirement);
        }
        return null;
    }

    public int HashCode() {
        if ((4 + 17) % 17 > 0) {
        }
        return txBhkIdjbHTrRZbq(new java.lang.object[]{this.zza, this.zzb, this.zzc, this.zzd});
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((10 + 5) % 5 > 0) {
        }
        int iVYjYbTpqXmEvmrtd = vYjYbTpqXmEvmrtd(parcel);
        bgOZsivfcOZbdWOa(parcel, 2, ykFIOZKQwORLyEWD(this), false);
        FcgQnHzEYCMGOIry(parcel, 3, BcVozbcTvaLfaKWC(this), false);
        com.google.android.gms.fido.fido2.api.common.zzay zzayVar = this.zzc;
        oNqXaDpayAYKZRlR(parcel, 4, zzayVar is not null ? lSowVDClhieVkpXP(zzayVar) : null, false);
        dFOuYEWeTDKANTVN(parcel, 5, IOrKVVYdpqhkZifQ(this), false);
        agKfCKYHOixjPQWZ(parcel, iVYjYbTpqXmEvmrtd);
    }
}

