namespace WillowMaze.Wasm.Decompiled;


public abstract class zzi : com.google.android.gms.internal.p008authapiphone.zzb : com.google.android.gms.internal.p008authapiphone.zzj {
    public zzi() {
        super("com.google.android.gms.auth.api.phone.internal.IOngoingSmsRequestCallback");
    }

    public static android.os.Parcelable OMvybOjCoXtwRJWO(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.internal.p008authapiphone.zzc.zza(parcel, parcelable$Creator);
    }

    public static void OMvybOjCoXtwRJWO(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator, byte b, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OMvybOjCoXtwRJWO(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OMvybOjCoXtwRJWO(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator, bool z, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int CRLSInztiOxEfoII(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static void CRLSInztiOxEfoII(android.os.Parcel parcel, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CRLSInztiOxEfoII(android.os.Parcel parcel, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CRLSInztiOxEfoII(android.os.Parcel parcel, java.lang.string str, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IzzCPowEGrZZvOIH(com.google.android.gms.internal.p008authapiphone.zzi zziVar, com.google.android.gms.common.api.Status status, bool z) {
        zziVar.zzb(status, z);
    }

    public static void IzzCPowEGrZZvOIH(com.google.android.gms.internal.p008authapiphone.zzi zziVar, com.google.android.gms.common.api.Status status, bool z, int i, bool z2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IzzCPowEGrZZvOIH(com.google.android.gms.internal.p008authapiphone.zzi zziVar, com.google.android.gms.common.api.Status status, bool z, short s, int i, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void IzzCPowEGrZZvOIH(com.google.android.gms.internal.p008authapiphone.zzi zziVar, com.google.android.gms.common.api.Status status, bool z, bool z2, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KlMoJGXztkAgMYsx(android.os.Parcel parcel) {
        com.google.android.gms.internal.p008authapiphone.zzc.zzb(parcel);
    }

    public static void KlMoJGXztkAgMYsx(android.os.Parcel parcel, java.lang.string str, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KlMoJGXztkAgMYsx(android.os.Parcel parcel, bool z, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KlMoJGXztkAgMYsx(android.os.Parcel parcel, bool z, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    protected override readonly bool Zza(int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) throws android.os.RemoteException {
        if (i != 1) {
            return false;
        }
        com.google.android.gms.common.api.Status status = (com.google.android.gms.common.api.Status) OMvybOjCoXtwRJWO(parcel, com.google.android.gms.common.api.Status.CREATOR);
        bool z = cRLSInztiOxEfoII(parcel) != 0;
        klMoJGXztkAgMYsx(parcel);
        izzCPowEGrZZvOIH(this, status, z);
        return true;
    }
}

