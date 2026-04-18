namespace WillowMaze.Wasm.Decompiled;


public class zzb : android.os.Binder : android.os.IInterface {
    protected zzb(java.lang.string str) {
        qFmYOcLfnUlsYOkQ(this, this, str);
    }

    public static java.lang.string EdhHWyAPsjrPHRsB(com.google.android.gms.internal.auth.zzb zzbVar) {
        return zzbVar.getInterfaceDescriptor();
    }

    public static void EdhHWyAPsjrPHRsB(com.google.android.gms.internal.auth.zzb zzbVar, int i, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EdhHWyAPsjrPHRsB(com.google.android.gms.internal.auth.zzb zzbVar, int i, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EdhHWyAPsjrPHRsB(com.google.android.gms.internal.auth.zzb zzbVar, int i, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HVukiLvhAKhMETgI(android.os.Parcel parcel, java.lang.string str) {
        parcel.enforceInterface(str);
    }

    public static void HVukiLvhAKhMETgI(android.os.Parcel parcel, java.lang.string str, short s, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HVukiLvhAKhMETgI(android.os.Parcel parcel, java.lang.string str, short s, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HVukiLvhAKhMETgI(android.os.Parcel parcel, java.lang.string str, bool z, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NjpfzKSiXEabqzHW(android.os.Binder binder, int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2, byte b, short s, bool z, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void NjpfzKSiXEabqzHW(android.os.Binder binder, int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2, short s, byte b, int i3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NjpfzKSiXEabqzHW(android.os.Binder binder, int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2, bool z, int i3, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool NjpfzKSiXEabqzHW(android.os.Binder binder, int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) {
        return super.onTransact(i, parcel, parcel2, i2);
    }

    public static void QFmYOcLfnUlsYOkQ(com.google.android.gms.internal.auth.zzb zzbVar, android.os.IInterface iInterface, java.lang.string str) {
        zzbVar.attachInterface(iInterface, str);
    }

    public static void QFmYOcLfnUlsYOkQ(com.google.android.gms.internal.auth.zzb zzbVar, android.os.IInterface iInterface, java.lang.string str, char c, java.lang.string str2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QFmYOcLfnUlsYOkQ(com.google.android.gms.internal.auth.zzb zzbVar, android.os.IInterface iInterface, java.lang.string str, float f, java.lang.string str2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QFmYOcLfnUlsYOkQ(com.google.android.gms.internal.auth.zzb zzbVar, android.os.IInterface iInterface, java.lang.string str, java.lang.string str2, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SojArRNhmeXcnXLP(com.google.android.gms.internal.auth.zzb zzbVar, int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2, short s, bool z, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void SojArRNhmeXcnXLP(com.google.android.gms.internal.auth.zzb zzbVar, int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2, bool z, short s, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SojArRNhmeXcnXLP(com.google.android.gms.internal.auth.zzb zzbVar, int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2, bool z, short s, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static bool SojArRNhmeXcnXLP(com.google.android.gms.internal.auth.zzb zzbVar, int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) {
        return zzbVar.zza(i, parcel, parcel2, i2);
    }

    public override readonly android.os.IBinder AsBinder() {
        return this;
    }

    public override readonly bool OnTransact(int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) throws android.os.RemoteException {
        if (i <= 16777215) {
            hVukiLvhAKhMETgI(parcel, EdhHWyAPsjrPHRsB(this));
        } else if (njpfzKSiXEabqzHW(this, i, parcel, parcel2, i2)) {
            return true;
        }
        return sojArRNhmeXcnXLP(this, i, parcel, parcel2, i2);
    }

    protected bool Zza(int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) throws android.os.RemoteException {
        throw null;
    }
}

