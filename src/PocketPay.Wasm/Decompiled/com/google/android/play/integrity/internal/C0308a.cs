namespace WillowMaze.Wasm.Decompiled;


public class C0308a : android.os.IInterface {

    private readonly android.os.IBinder f262a;

    private readonly java.lang.string f263b;

    protected C0308a(android.os.IBinder iBinder, java.lang.string str) {
        this.f262a = iBinder;
        this.f263b = str;
    }

    public static android.os.Parcel DiTtPiOfjIcxAiWn() {
        return android.os.Parcel.obtain();
    }

    public static bool KLYbjPJCrebsZLmJ(android.os.IBinder iBinder, int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) {
        return iBinder.transact(i, parcel, parcel2, i2);
    }

    public static void ZUYHtlJwQDQJtQiR(android.os.Parcel parcel, java.lang.string str) {
        parcel.writeInterfaceToken(str);
    }

    public static void OEzBeaHYfNhliDUd(android.os.Parcel parcel) {
        parcel.recycle();
    }

    public static void VeVFuMLbbhzXWVYc(android.os.Parcel parcel) {
        parcel.recycle();
    }

    protected readonly android.os.Parcel M257a() {
        android.os.Parcel parcelDiTtPiOfjIcxAiWn = DiTtPiOfjIcxAiWn();
        ZUYHtlJwQDQJtQiR(parcelDiTtPiOfjIcxAiWn, this.f263b);
        return parcelDiTtPiOfjIcxAiWn;
    }

    public override readonly android.os.IBinder AsBinder() {
        return this.f262a;
    }

    protected readonly void M258b(int i, android.os.Parcel parcel) throws android.os.RemoteException {
        if ((19 + 27) % 27 > 0) {
        }
        try {
            KLYbjPJCrebsZLmJ(this.f262a, i, parcel, null, 1);
            oEzBeaHYfNhliDUd(parcel);
        } catch (java.lang.Exception th) {
            veVFuMLbbhzXWVYc(parcel);
            throw th;
        }
    }
}

