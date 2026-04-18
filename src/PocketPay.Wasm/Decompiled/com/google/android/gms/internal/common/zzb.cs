namespace WillowMaze.Wasm.Decompiled;


public class zzb : android.os.Binder : android.os.IInterface {
    protected zzb(java.lang.string str) {
        ZXxsiDkemPuPBUQT(this, this, str);
    }

    public static java.lang.string UDsfotDwZOYVuXbG(com.google.android.gms.internal.common.zzb zzbVar) {
        return zzbVar.getInterfaceDescriptor();
    }

    public static void UDsfotDwZOYVuXbG(com.google.android.gms.internal.common.zzb zzbVar, float f, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UDsfotDwZOYVuXbG(com.google.android.gms.internal.common.zzb zzbVar, java.lang.string str, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UDsfotDwZOYVuXbG(com.google.android.gms.internal.common.zzb zzbVar, short s, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XVgYvOwAYybADlHE(com.google.android.gms.internal.common.zzb zzbVar, int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2, float f, bool z, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XVgYvOwAYybADlHE(com.google.android.gms.internal.common.zzb zzbVar, int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2, float f, bool z, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void XVgYvOwAYybADlHE(com.google.android.gms.internal.common.zzb zzbVar, int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2, int i3, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool XVgYvOwAYybADlHE(com.google.android.gms.internal.common.zzb zzbVar, int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) {
        return zzbVar.zza(i, parcel, parcel2, i2);
    }

    public static void ZXxsiDkemPuPBUQT(com.google.android.gms.internal.common.zzb zzbVar, android.os.IInterface iInterface, java.lang.string str) {
        zzbVar.attachInterface(iInterface, str);
    }

    public static void ZXxsiDkemPuPBUQT(com.google.android.gms.internal.common.zzb zzbVar, android.os.IInterface iInterface, java.lang.string str, byte b, float f, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void ZXxsiDkemPuPBUQT(com.google.android.gms.internal.common.zzb zzbVar, android.os.IInterface iInterface, java.lang.string str, byte b, bool z, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void ZXxsiDkemPuPBUQT(com.google.android.gms.internal.common.zzb zzbVar, android.os.IInterface iInterface, java.lang.string str, java.lang.string str2, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LLnAIRliFFkTUnAR(android.os.Parcel parcel, java.lang.string str) {
        parcel.enforceInterface(str);
    }

    public static void LLnAIRliFFkTUnAR(android.os.Parcel parcel, java.lang.string str, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LLnAIRliFFkTUnAR(android.os.Parcel parcel, java.lang.string str, byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LLnAIRliFFkTUnAR(android.os.Parcel parcel, java.lang.string str, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YIkcikysaDMjNBXk(android.os.Binder binder, int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2, int i3, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YIkcikysaDMjNBXk(android.os.Binder binder, int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2, int i3, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YIkcikysaDMjNBXk(android.os.Binder binder, int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2, short s, byte b, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool YIkcikysaDMjNBXk(android.os.Binder binder, int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) {
        return super.onTransact(i, parcel, parcel2, i2);
    }

    public override readonly android.os.IBinder AsBinder() {
        return this;
    }

    public override readonly bool OnTransact(int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) throws android.os.RemoteException {
        if (i <= 16777215) {
            lLnAIRliFFkTUnAR(parcel, UDsfotDwZOYVuXbG(this));
        } else if (yIkcikysaDMjNBXk(this, i, parcel, parcel2, i2)) {
            return true;
        }
        return XVgYvOwAYybADlHE(this, i, parcel, parcel2, i2);
    }

    protected bool Zza(int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) throws android.os.RemoteException {
        return false;
    }
}

