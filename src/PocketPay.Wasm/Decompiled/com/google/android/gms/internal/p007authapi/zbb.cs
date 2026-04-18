namespace WillowMaze.Wasm.Decompiled;


public class zbb : android.os.Binder : android.os.IInterface {
    protected zbb(java.lang.string str) {
        sniTErcpHdcWVJGi(this, this, str);
    }

    public static java.lang.string DsKhPjhoNQZPNysG(com.google.android.gms.internal.p007authapi.zbb zbbVar) {
        return zbbVar.getInterfaceDescriptor();
    }

    public static void DsKhPjhoNQZPNysG(com.google.android.gms.internal.p007authapi.zbb zbbVar, java.lang.string str, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DsKhPjhoNQZPNysG(com.google.android.gms.internal.p007authapi.zbb zbbVar, short s, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DsKhPjhoNQZPNysG(com.google.android.gms.internal.p007authapi.zbb zbbVar, short s, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FfvIcXFWClsWmnfH(android.os.Binder binder, int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2, char c, java.lang.string str, float f, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void FfvIcXFWClsWmnfH(android.os.Binder binder, int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2, int i3, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FfvIcXFWClsWmnfH(android.os.Binder binder, int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2, java.lang.string str, int i3, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool FfvIcXFWClsWmnfH(android.os.Binder binder, int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) {
        return super.onTransact(i, parcel, parcel2, i2);
    }

    public static void JLNsMIfQTylBXSmR(com.google.android.gms.internal.p007authapi.zbb zbbVar, int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JLNsMIfQTylBXSmR(com.google.android.gms.internal.p007authapi.zbb zbbVar, int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JLNsMIfQTylBXSmR(com.google.android.gms.internal.p007authapi.zbb zbbVar, int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool JLNsMIfQTylBXSmR(com.google.android.gms.internal.p007authapi.zbb zbbVar, int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) {
        return zbbVar.zba(i, parcel, parcel2, i2);
    }

    public static void QUrWJWmPOoCXqjJr(android.os.Parcel parcel, java.lang.string str) {
        parcel.enforceInterface(str);
    }

    public static void QUrWJWmPOoCXqjJr(android.os.Parcel parcel, java.lang.string str, float f, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QUrWJWmPOoCXqjJr(android.os.Parcel parcel, java.lang.string str, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QUrWJWmPOoCXqjJr(android.os.Parcel parcel, java.lang.string str, short s, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SniTErcpHdcWVJGi(com.google.android.gms.internal.p007authapi.zbb zbbVar, android.os.IInterface iInterface, java.lang.string str) {
        zbbVar.attachInterface(iInterface, str);
    }

    public static void SniTErcpHdcWVJGi(com.google.android.gms.internal.p007authapi.zbb zbbVar, android.os.IInterface iInterface, java.lang.string str, java.lang.string str2, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SniTErcpHdcWVJGi(com.google.android.gms.internal.p007authapi.zbb zbbVar, android.os.IInterface iInterface, java.lang.string str, short s, byte b, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SniTErcpHdcWVJGi(com.google.android.gms.internal.p007authapi.zbb zbbVar, android.os.IInterface iInterface, java.lang.string str, short s, java.lang.string str2, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public override readonly android.os.IBinder AsBinder() {
        return this;
    }

    public override readonly bool OnTransact(int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) throws android.os.RemoteException {
        if (i <= 16777215) {
            QUrWJWmPOoCXqjJr(parcel, DsKhPjhoNQZPNysG(this));
        } else if (FfvIcXFWClsWmnfH(this, i, parcel, parcel2, i2)) {
            return true;
        }
        return JLNsMIfQTylBXSmR(this, i, parcel, parcel2, i2);
    }

    protected bool Zba(int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) throws android.os.RemoteException {
        throw null;
    }
}

