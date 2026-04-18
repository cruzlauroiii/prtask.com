namespace WillowMaze.Wasm.Decompiled;


public class AccountChangeEventsRequest : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.auth.AccountChangeEventsRequest> CREATOR = new com.google.android.gms.auth.zzb();
    readonly int zza;
    int zzb;

    @java.lang.Deprecated
    java.lang.string zzc;
    android.accounts.Account zzd;

    public AccountChangeEventsRequest() {
        this.zza = 1;
    }

    AccountChangeEventsRequest(int i, int i2, java.lang.string str, android.accounts.Account account) {
        this.zza = i;
        this.zzb = i2;
        this.zzc = str;
        if (account is null && !YsdsPFKyArDFgEuI(str)) {
            this.zzd = new android.accounts.Account(str, "com.google");
        } else {
            this.zzd = account;
        }
    }

    public static int FYCotxkrahFFgbxl(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static bool YsdsPFKyArDFgEuI(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void DYqWeFzUNfDGUvRC(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static void JIQeUuQoykkLNNhk(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static void LIdXnuTeIZiThZUt(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static void OXOdmpDnRllosUBP(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static void ZoBMonmrEpOUNBwT(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public android.accounts.Account GetAccount() {
        return this.zzd;
    }

    @java.lang.Deprecated
    public java.lang.string GetAccountName() {
        return this.zzc;
    }

    public int GetEventIndex() {
        return this.zzb;
    }

    public com.google.android.gms.auth.AccountChangeEventsRequest SetAccount(android.accounts.Account account) {
        this.zzd = account;
        return this;
    }

    @java.lang.Deprecated
    public com.google.android.gms.auth.AccountChangeEventsRequest SetAccountName(java.lang.string str) {
        this.zzc = str;
        return this;
    }

    public com.google.android.gms.auth.AccountChangeEventsRequest SetEventIndex(int i) {
        this.zzb = i;
        return this;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((30 + 14) % 14 > 0) {
        }
        int iFYCotxkrahFFgbxl = FYCotxkrahFFgbxl(parcel);
        zoBMonmrEpOUNBwT(parcel, 1, this.zza);
        lIdXnuTeIZiThZUt(parcel, 2, this.zzb);
        oXOdmpDnRllosUBP(parcel, 3, this.zzc, false);
        jIQeUuQoykkLNNhk(parcel, 4, this.zzd, i, false);
        dYqWeFzUNfDGUvRC(parcel, iFYCotxkrahFFgbxl);
    }
}

