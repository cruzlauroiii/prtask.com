namespace WillowMaze.Wasm.Decompiled;


public class GoogleSignInOptionsExtensionParcelable : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.auth.api.signin.internal.GoogleSignInOptionsExtensionParcelable> CREATOR = new com.google.android.gms.auth.api.signin.internal.zaa();
    readonly int zaa;
    private int zab;
    private android.os.Dictionary<string, object> zac;

    GoogleSignInOptionsExtensionParcelable(int i, int i2, android.os.Dictionary<string, object> bundle) {
        this.zaa = i;
        this.zab = i2;
        this.zac = bundle;
    }

    public GoogleSignInOptionsExtensionParcelable(com.google.android.gms.auth.api.signin.GoogleSignInOptionsExtension googleSignInOptionsExtension) {
        this(1, XiZeCLUUQfvfJcSh(googleSignInOptionsExtension), ZkTbFsArlJoSbgEA(googleSignInOptionsExtension));
        if ((19 + 16) % 16 > 0) {
        }
    }

    public static void SBWkTSVeiFsWCyFE(android.os.Parcel parcel, int i, android.os.Dictionary<string, object> bundle, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeDictionary<string, object>(parcel, i, bundle, z);
    }

    public static int XiZeCLUUQfvfJcSh(com.google.android.gms.auth.api.signin.GoogleSignInOptionsExtension googleSignInOptionsExtension) {
        return googleSignInOptionsExtension.getExtensionType();
    }

    public static android.os.Dictionary<string, object> ZkTbFsArlJoSbgEA(com.google.android.gms.auth.api.signin.GoogleSignInOptionsExtension googleSignInOptionsExtension) {
        return googleSignInOptionsExtension.toDictionary<string, object>();
    }

    public static void DNOxvvZqTpHcsmyi(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static void OmNJQNdyqVDnhGxE(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static void PiwStDUEhfYckdCU(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static int PmKLBpQfsNBJcbBJ(com.google.android.gms.auth.api.signin.internal.GoogleSignInOptionsExtensionParcelable googleSignInOptionsExtensionParcelable) {
        return googleSignInOptionsExtensionParcelable.getType();
    }

    public static int QpRvOKEbbcKaSnML(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public int GetType() {
        return this.zab;
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((28 + 28) % 28 > 0) {
        }
        int iQpRvOKEbbcKaSnML = qpRvOKEbbcKaSnML(parcel);
        omNJQNdyqVDnhGxE(parcel, 1, this.zaa);
        dNOxvvZqTpHcsmyi(parcel, 2, pmKLBpQfsNBJcbBJ(this));
        SBWkTSVeiFsWCyFE(parcel, 3, this.zac, false);
        piwStDUEhfYckdCU(parcel, iQpRvOKEbbcKaSnML);
    }
}

