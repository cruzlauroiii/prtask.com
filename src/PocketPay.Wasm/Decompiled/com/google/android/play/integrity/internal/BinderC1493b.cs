namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: com.google.android.play.integrity.internal.b */
/* JADX INFO: loaded from: classes26.dex */
public class BinderC1493b : android.os.Binder : android.os.IInterface {
    protected BinderC1493b(java.lang.string r1) {
            r0 = this;
            goto Le
        L4:
            goto L11
        L7:
            r0.<init>()
            goto L15
        Le:
            goto L1d
        L11:
            goto L7
        L15:
            lEWyuXwrvCXCJglJ(r0, r0, r1)
            goto L1c
        L1c:
            return
        L1d:
            goto L4
    }

    public static bool KaJKHwNBpGbczpAL(com.google.android.play.integrity.internal.BinderC1493b r1, int r2, android.os.Parcel r3, android.os.Parcel r4, int r5) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return r0
        Lf:
            goto Lb
        L13:
            bool r0 = r1.mo308a(r2, r3, r4, r5)
            goto Le
    }

    public static bool CTkwGRqPSZIFLGjC(android.os.Binder r1, int r2, android.os.Parcel r3, android.os.Parcel r4, int r5) {
            goto L11
        L4:
            bool r0 = super.onTransact(r2, r3, r4, r5)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L18
        L11:
            goto Ld
        L14:
            goto L4
        L18:
            goto L14
    }

    public static void LEWyuXwrvCXCJglJ(com.google.android.play.integrity.internal.BinderC1493b r0, android.os.IInterface r1, java.lang.string r2) {
            goto L13
        L4:
            goto L16
        L7:
            r0.attachInterface(r1, r2)
            goto Le
        Le:
            return
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            goto L7
    }

    public static void VXIlAlTJQOfJERgp(android.os.Parcel r0, java.lang.string r1) {
            goto Lb
        L4:
            r0.enforceInterface(r1)
            goto L15
        Lb:
            goto L16
        Le:
            goto L4
        L12:
            goto Le
        L15:
            return
        L16:
            goto L12
    }

    public static java.lang.string YoyuSpTwTDsdsRCg(com.google.android.play.integrity.internal.BinderC1493b r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            java.lang.string r0 = r1.getInterfaceDescriptor()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    /* JADX INFO: renamed from: a */
    protected bool Mo308a(int r1, android.os.Parcel r2, android.os.Parcel r3, int r4) throws android.os.RemoteException {
            r0 = this;
            goto Lc
        L4:
            goto Lf
        L7:
            r0 = 0
            goto L13
        Lc:
            goto L14
        Lf:
            goto L7
        L13:
            throw r0
        L14:
            goto L4
    }

    @Override // android.os.IInterface
    public readonly android.os.IBinder AsBinder() {
            r0 = this;
            goto L4
        L4:
            goto Lc
        L7:
            goto Lb
        Lb:
            return r0
        Lc:
            goto L10
        L10:
            goto L7
    }

    @Override // android.os.Binder
    public readonly bool OnTransact(int r2, android.os.Parcel r3, android.os.Parcel r4, int r5) throws android.os.RemoteException {
            r1 = this;
            goto L47
        L4:
            return r1
        L5:
            goto L2d
        L9:
            if (r0 != 0) goto Le
            goto L51
        Le:
            goto L1b
        L12:
            if (r2 > r0) goto L17
            goto L5
        L17:
            goto L38
        L1b:
            r1 = 1
            goto L4
        L20:
            bool r1 = KaJKHwNBpGbczpAL(r1, r2, r3, r4, r5)
            goto L28
        L28:
            return r1
        L29:
            goto L35
        L2d:
            java.lang.string r0 = yoyuSpTwTDsdsRCg(r1)
            goto L4e
        L35:
            goto L4a
        L38:
            bool r0 = cTkwGRqPSZIFLGjC(r1, r2, r3, r4, r5)
            goto L9
        L40:
            r0 = 16777215(0xffffff, float:2.3509886E-38)
            goto L12
        L47:
            goto L29
        L4a:
            goto L40
        L4e:
            vXIlAlTJQOfJERgp(r3, r0)
        L51:
            goto L20
    }
}

