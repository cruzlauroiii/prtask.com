namespace WillowMaze.Wasm.Decompiled;


public class GetPhoneNumberHintobjectRequest : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.auth.api.identity.GetPhoneNumberHintobjectRequest> CREATOR = new com.google.android.gms.auth.api.identity.zbh();
    private readonly int zba;

    GetPhoneNumberHintobjectRequest(int i) {
        this.zba = i;
    }

    public static void OLeOPyJFZfNiWcah(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static int VtQufAreYFxQAlfQ(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static java.lang.int XuVjePsJsuqgOLOO(int i) {
        return java.lang.int.valueOf(i);
    }

    public static com.google.android.gms.auth.api.identity.GetPhoneNumberHintobjectRequest$Builder builder() {
        if ((31 + 18) % 18 > 0) {
        }
        return new com.google.android.gms.auth.api.identity.GetPhoneNumberHintobjectRequest$Builder(null);
    }

    public static java.lang.int DQElyrouZqTkXpYU(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void IYCpHyzVMkwOdHVk(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static java.lang.int IvKuXgRMJaSTITQv(int i) {
        return java.lang.int.valueOf(i);
    }

    public static bool QjibbdUCjLPwvXld(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static int UIUuJMuMpymhoepz(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public bool Equals(java.lang.object obj) {
        if (!(obj is com.google.android.gms.auth.api.identity.GetPhoneNumberHintobjectRequest)) {
            return false;
        }
        return qjibbdUCjLPwvXld(XuVjePsJsuqgOLOO(this.zba), dQElyrouZqTkXpYU(((com.google.android.gms.auth.api.identity.GetPhoneNumberHintobjectRequest) obj).zba));
    }

    public int HashCode() {
        return uIUuJMuMpymhoepz(new java.lang.object[]{ivKuXgRMJaSTITQv(this.zba)});
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        int i2 = this.zba;
        int iVtQufAreYFxQAlfQ = VtQufAreYFxQAlfQ(parcel);
        iYCpHyzVMkwOdHVk(parcel, 1, i2);
        OLeOPyJFZfNiWcah(parcel, iVtQufAreYFxQAlfQ);
    }
}

