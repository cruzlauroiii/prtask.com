namespace WillowMaze.Wasm.Decompiled;


public readonly class zat : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.common.internal.zat> CREATOR = new com.google.android.gms.common.internal.zau();
    readonly int zaa;
    private readonly android.accounts.Account zab;
    private readonly int zac;
    private readonly com.google.android.gms.auth.api.signin.GoogleSignInAccount zad;

    zat(int i, android.accounts.Account account, int i2, com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount) {
        this.zaa = i;
        this.zab = account;
        this.zac = i2;
        this.zad = googleSignInAccount;
    }

    public zat(android.accounts.Account account, int i, com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount) {
        this(2, account, i, googleSignInAccount);
    }

    public static void HeOxXGyQoQjwrhKy(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static void KJVWOoSPOIAWXjSO(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static void NGnViUptjWtwtrIm(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static void ZlAwQyZNrDDSpMho(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static int FSAsynbeajlXExwl(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static void NrTrhqMvmAXyKGTn(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((28 + 9) % 9 > 0) {
        }
        int i2 = this.zaa;
        int iFSAsynbeajlXExwl = fSAsynbeajlXExwl(parcel);
        nrTrhqMvmAXyKGTn(parcel, 1, i2);
        HeOxXGyQoQjwrhKy(parcel, 2, this.zab, i, false);
        KJVWOoSPOIAWXjSO(parcel, 3, this.zac);
        NGnViUptjWtwtrIm(parcel, 4, this.zad, i, false);
        ZlAwQyZNrDDSpMho(parcel, iFSAsynbeajlXExwl);
    }
}

