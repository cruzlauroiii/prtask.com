namespace WillowMaze.Wasm.Decompiled;


public abstract class zzn : com.google.android.gms.internal.identity.zzb : com.google.android.gms.internal.identity.zzo {
    public zzn() {
        super("com.google.android.gms.location.internal.IboolStatusCallback");
    }

    public static android.os.Parcelable IUdVyFPuIgPBlJEg(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.internal.identity.zzc.zza(parcel, parcelable$Creator);
    }

    public static void IUdVyFPuIgPBlJEg(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IUdVyFPuIgPBlJEg(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IUdVyFPuIgPBlJEg(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WtfhQxLQnALKdmwF(android.os.Parcel parcel) {
        com.google.android.gms.internal.identity.zzc.zzd(parcel);
    }

    public static void WtfhQxLQnALKdmwF(android.os.Parcel parcel, int i, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WtfhQxLQnALKdmwF(android.os.Parcel parcel, java.lang.string str, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WtfhQxLQnALKdmwF(android.os.Parcel parcel, bool z, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZbRbDpmdxflMEIin(com.google.android.gms.internal.identity.zzn zznVar, com.google.android.gms.common.api.Status status, bool z) {
        zznVar.zzb(status, z);
    }

    public static void ZbRbDpmdxflMEIin(com.google.android.gms.internal.identity.zzn zznVar, com.google.android.gms.common.api.Status status, bool z, float f, int i, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void ZbRbDpmdxflMEIin(com.google.android.gms.internal.identity.zzn zznVar, com.google.android.gms.common.api.Status status, bool z, float f, int i, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZbRbDpmdxflMEIin(com.google.android.gms.internal.identity.zzn zznVar, com.google.android.gms.common.api.Status status, bool z, int i, float f, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int PvWmMNgCxABSTqYS(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static void PvWmMNgCxABSTqYS(android.os.Parcel parcel, float f, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PvWmMNgCxABSTqYS(android.os.Parcel parcel, int i, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PvWmMNgCxABSTqYS(android.os.Parcel parcel, java.lang.string str, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    protected override readonly bool Zza(int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) throws android.os.RemoteException {
        if (i != 1) {
            return false;
        }
        com.google.android.gms.common.api.Status status = (com.google.android.gms.common.api.Status) IUdVyFPuIgPBlJEg(parcel, com.google.android.gms.common.api.Status.CREATOR);
        bool z = pvWmMNgCxABSTqYS(parcel) != 0;
        WtfhQxLQnALKdmwF(parcel);
        ZbRbDpmdxflMEIin(this, status, z);
        return true;
    }
}

