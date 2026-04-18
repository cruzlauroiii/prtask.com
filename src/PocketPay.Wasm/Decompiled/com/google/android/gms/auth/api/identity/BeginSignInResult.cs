namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public readonly class BeginSignInResult : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.auth.api.identity.BeginSignInResult> CREATOR = new com.google.android.gms.auth.api.identity.zbe();
    private readonly android.app.Pendingobject zba;

    public BeginSignInResult(android.app.Pendingobject pendingobject) {
        this.zba = (android.app.Pendingobject) ljFPmadUcoMeZxzy(pendingobject);
    }

    public static void CWnGoRRqDFTPofGs(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static void JwHwwiKbhgVsTdVg(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static android.app.Pendingobject IQnUbWZZZbRITjec(com.google.android.gms.auth.api.identity.BeginSignInResult beginSignInResult) {
        return beginSignInResult.getPendingobject();
    }

    public static java.lang.object LjFPmadUcoMeZxzy(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static int NYakaqDRjcNiEMNk(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public android.app.Pendingobject GetPendingobject() {
        return this.zba;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((29 + 4) % 4 > 0) {
        }
        int iNYakaqDRjcNiEMNk = nYakaqDRjcNiEMNk(parcel);
        CWnGoRRqDFTPofGs(parcel, 1, iQnUbWZZZbRITjec(this), i, false);
        JwHwwiKbhgVsTdVg(parcel, iNYakaqDRjcNiEMNk);
    }
}

