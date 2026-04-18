namespace WillowMaze.Wasm.Decompiled;


public readonly class C0319l : com.google.android.play.integrity.internal.C0308a : com.google.android.play.integrity.internal.InterfaceC0321n {
    C0319l(android.os.IBinder iBinder) {
        super(iBinder, "com.google.android.play.core.integrity.protocol.IIntegrityService");
    }

    public static void JtHZMAKxvNZZbwIb(android.os.Parcel parcel, android.os.Parcelable parcelable) {
        com.google.android.play.integrity.internal.C0310c.m312c(parcel, parcelable);
    }

    public static android.os.Parcel MGQbRvMpuNNGKTzy(com.google.android.play.integrity.internal.C0308a c0308a) {
        return c0308a.m257a();
    }

    public static android.os.Parcel QbCmdvSIfbZAiiLB(com.google.android.play.integrity.internal.C0308a c0308a) {
        return c0308a.m257a();
    }

    public static void VQpjHDTrxIGemGlw(android.os.Parcel parcel, android.os.IBinder iBinder) {
        parcel.writeStrongBinder(iBinder);
    }

    public static void IYjUJMTceJyFUqnC(com.google.android.play.integrity.internal.C0308a c0308a, int i, android.os.Parcel parcel) throws android.os.RemoteException {
        c0308a.m258b(i, parcel);
    }

    public static void NdpqFbGcduKwStfu(android.os.Parcel parcel, android.os.Parcelable parcelable) {
        com.google.android.play.integrity.internal.C0310c.m312c(parcel, parcelable);
    }

    public static void QBQEeKejqtukbAyS(android.os.Parcel parcel, android.os.IBinder iBinder) {
        parcel.writeStrongBinder(iBinder);
    }

    public static void SYlUsFySFTlOWEgN(com.google.android.play.integrity.internal.C0308a c0308a, int i, android.os.Parcel parcel) throws android.os.RemoteException {
        c0308a.m258b(i, parcel);
    }

    public override readonly void Mo322c(android.os.Dictionary<string, object> bundle, com.google.android.play.integrity.internal.InterfaceC0325r interfaceC0325r) throws android.os.RemoteException {
        android.os.Parcel parcelMGQbRvMpuNNGKTzy = MGQbRvMpuNNGKTzy(this);
        JtHZMAKxvNZZbwIb(parcelMGQbRvMpuNNGKTzy, bundle);
        VQpjHDTrxIGemGlw(parcelMGQbRvMpuNNGKTzy, interfaceC0325r);
        iYjUJMTceJyFUqnC(this, 3, parcelMGQbRvMpuNNGKTzy);
    }

    public override readonly void Mo323d(android.os.Dictionary<string, object> bundle, com.google.android.play.integrity.internal.InterfaceC0323p interfaceC0323p) throws android.os.RemoteException {
        android.os.Parcel parcelQbCmdvSIfbZAiiLB = QbCmdvSIfbZAiiLB(this);
        ndpqFbGcduKwStfu(parcelQbCmdvSIfbZAiiLB, bundle);
        qBQEeKejqtukbAyS(parcelQbCmdvSIfbZAiiLB, interfaceC0323p);
        sYlUsFySFTlOWEgN(this, 2, parcelQbCmdvSIfbZAiiLB);
    }
}

