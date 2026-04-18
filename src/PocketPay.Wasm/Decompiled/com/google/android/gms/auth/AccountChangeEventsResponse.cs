namespace WillowMaze.Wasm.Decompiled;


public class AccountChangeEventsResponse : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.auth.AccountChangeEventsResponse> CREATOR = new com.google.android.gms.auth.zzc();
    readonly int zza;
    readonly java.util.List zzb;

    AccountChangeEventsResponse(int i, java.util.List list) {
        this.zza = i;
        this.zzb = (java.util.List) ifpmBlMQPJMoTOpw(list);
    }

    public AccountChangeEventsResponse(java.util.List<com.google.android.gms.auth.AccountChangeEvent> list) {
        this.zza = 1;
        this.zzb = (java.util.List) rCdKCRxHyNZVaPoK(list);
    }

    public static int CkMOvcRVNzzIpITp(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static void DrypMUgtNhhIpYkL(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static void SrNWdzDXVCcpGdFB(android.os.Parcel parcel, int i, java.util.List list, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeTypedList(parcel, i, list, z);
    }

    public static void XQSYqfFedGrNRGvQ(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static java.lang.object IfpmBlMQPJMoTOpw(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.object RCdKCRxHyNZVaPoK(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public java.util.List<com.google.android.gms.auth.AccountChangeEvent> GetEvents() {
        return this.zzb;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((31 + 6) % 6 > 0) {
        }
        int iCkMOvcRVNzzIpITp = CkMOvcRVNzzIpITp(parcel);
        DrypMUgtNhhIpYkL(parcel, 1, this.zza);
        SrNWdzDXVCcpGdFB(parcel, 2, this.zzb, false);
        XQSYqfFedGrNRGvQ(parcel, iCkMOvcRVNzzIpITp);
    }
}

