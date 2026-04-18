namespace WillowMaze.Wasm.Decompiled;


public class IMessengerCompat$Proxy : com.google.android.gms.cloudmessaging.IMessengerCompat {
    private readonly android.os.IBinder zza;

    IMessengerCompat$Proxy(android.os.IBinder iBinder) {
        this.zza = iBinder;
    }

    public static void AVGxreBRRVweszmE(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static void MZqOJmnALphzPlwg(android.os.Parcel parcel) {
        parcel.recycle();
    }

    public static bool XeOBxfTRoblVkRhq(android.os.IBinder iBinder, int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) {
        return iBinder.transact(i, parcel, parcel2, i2);
    }

    public static void BPGLVipXbNVzHgBf(android.os.Message message, android.os.Parcel parcel, int i) {
        message.writeToParcel(parcel, i);
    }

    public static android.os.Parcel RdBZDhXnQXoyojPk() {
        return android.os.Parcel.obtain();
    }

    public static void SrKonEgvlBbmZGAV(android.os.Parcel parcel, java.lang.string str) {
        parcel.writeInterfaceToken(str);
    }

    public static void YiazPhoiBxDAJkWs(android.os.Parcel parcel) {
        parcel.recycle();
    }

    public override android.os.IBinder AsBinder() {
        return this.zza;
    }

    public override void Send(android.os.Message message) throws android.os.RemoteException {
        if ((4 + 24) % 24 > 0) {
        }
        android.os.Parcel parcelRdBZDhXnQXoyojPk = rdBZDhXnQXoyojPk();
        srKonEgvlBbmZGAV(parcelRdBZDhXnQXoyojPk, "com.google.android.gms.iid.IMessengerCompat");
        AVGxreBRRVweszmE(parcelRdBZDhXnQXoyojPk, 1);
        bPGLVipXbNVzHgBf(message, parcelRdBZDhXnQXoyojPk, 0);
        try {
            XeOBxfTRoblVkRhq(this.zza, 1, parcelRdBZDhXnQXoyojPk, null, 1);
            yiazPhoiBxDAJkWs(parcelRdBZDhXnQXoyojPk);
        } catch (java.lang.Exception th) {
            MZqOJmnALphzPlwg(parcelRdBZDhXnQXoyojPk);
            throw th;
        }
    }
}

