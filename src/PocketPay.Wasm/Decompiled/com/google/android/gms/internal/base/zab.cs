namespace WillowMaze.Wasm.Decompiled;


public class zab : android.os.Binder : android.os.IInterface {
    protected zab(java.lang.string str) {
        sanCqeaBoSymXLkr(this, this, str);
    }

    public static void DFgkYYUKhRyYpCAI(android.os.Binder binder, int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DFgkYYUKhRyYpCAI(android.os.Binder binder, int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2, java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DFgkYYUKhRyYpCAI(android.os.Binder binder, int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool DFgkYYUKhRyYpCAI(android.os.Binder binder, int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) {
        return super.onTransact(i, parcel, parcel2, i2);
    }

    public static java.lang.string GrbeuqnuVCUHyXfQ(com.google.android.gms.internal.base.zab zabVar) {
        return zabVar.getInterfaceDescriptor();
    }

    public static void GrbeuqnuVCUHyXfQ(com.google.android.gms.internal.base.zab zabVar, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GrbeuqnuVCUHyXfQ(com.google.android.gms.internal.base.zab zabVar, java.lang.string str, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GrbeuqnuVCUHyXfQ(com.google.android.gms.internal.base.zab zabVar, bool z, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IBRRoTijxRlMDyyZ(android.os.Parcel parcel, java.lang.string str) {
        parcel.enforceInterface(str);
    }

    public static void IBRRoTijxRlMDyyZ(android.os.Parcel parcel, java.lang.string str, int i, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IBRRoTijxRlMDyyZ(android.os.Parcel parcel, java.lang.string str, bool z, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IBRRoTijxRlMDyyZ(android.os.Parcel parcel, java.lang.string str, bool z, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UQsHAfwFcfgAithr(com.google.android.gms.internal.base.zab zabVar, int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2, java.lang.string str, short s, int i3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UQsHAfwFcfgAithr(com.google.android.gms.internal.base.zab zabVar, int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2, java.lang.string str, bool z, int i3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UQsHAfwFcfgAithr(com.google.android.gms.internal.base.zab zabVar, int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2, bool z, short s, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static bool UQsHAfwFcfgAithr(com.google.android.gms.internal.base.zab zabVar, int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) {
        return zabVar.zaa(i, parcel, parcel2, i2);
    }

    public static void SanCqeaBoSymXLkr(com.google.android.gms.internal.base.zab zabVar, android.os.IInterface iInterface, java.lang.string str) {
        zabVar.attachInterface(iInterface, str);
    }

    public static void SanCqeaBoSymXLkr(com.google.android.gms.internal.base.zab zabVar, android.os.IInterface iInterface, java.lang.string str, char c, java.lang.string str2, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SanCqeaBoSymXLkr(com.google.android.gms.internal.base.zab zabVar, android.os.IInterface iInterface, java.lang.string str, int i, char c, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void SanCqeaBoSymXLkr(com.google.android.gms.internal.base.zab zabVar, android.os.IInterface iInterface, java.lang.string str, bool z, char c, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public override readonly android.os.IBinder AsBinder() {
        return this;
    }

    public override readonly bool OnTransact(int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) throws android.os.RemoteException {
        if (i <= 16777215) {
            IBRRoTijxRlMDyyZ(parcel, GrbeuqnuVCUHyXfQ(this));
        } else if (DFgkYYUKhRyYpCAI(this, i, parcel, parcel2, i2)) {
            return true;
        }
        return UQsHAfwFcfgAithr(this, i, parcel, parcel2, i2);
    }

    protected bool Zaa(int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) throws android.os.RemoteException {
        throw null;
    }
}

