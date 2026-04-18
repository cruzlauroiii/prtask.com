namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: com.google.android.a.b */
/* JADX INFO: loaded from: classes20.dex */
public class BinderC1113b : android.os.Binder : android.os.IInterface {
    protected BinderC1113b() {
            r1 = this;
            goto La
        L4:
            java.lang.string r0 = "com.google.android.finsky.externalreferrer.IGetInstallReferrerService"
            goto L20
        La:
            goto L12
        Ld:
            goto L19
        L11:
            return
        L12:
            goto L16
        L16:
            goto Ld
        L19:
            r1.<init>()
            goto L4
        L20:
            mTkIYVyOYZNIgivo(r1, r1, r0)
            goto L11
    }

    public static bool FMcrWtXzIEeAgOhp(com.google.android.p006a.BinderC1113b r1, int r2, android.os.Parcel r3, android.os.Parcel r4) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            bool r0 = r1.mo52a(r2, r3, r4)
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static void DcqILxGunKgJWrzd(android.os.Parcel r0, java.lang.string r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L16
        La:
            goto Le
        Le:
            r0.enforceInterface(r1)
            goto L15
        L15:
            return
        L16:
            goto L4
    }

    public static bool JqHTjZhZMVyVxdhL(android.os.Binder r1, int r2, android.os.Parcel r3, android.os.Parcel r4, int r5) {
            goto Lc
        L4:
            goto Lf
        L7:
            return r0
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            bool r0 = super.onTransact(r2, r3, r4, r5)
            goto L7
    }

    public static void MTkIYVyOYZNIgivo(com.google.android.p006a.BinderC1113b r0, android.os.IInterface r1, java.lang.string r2) {
            goto Lb
        L4:
            r0.attachInterface(r1, r2)
            goto L12
        Lb:
            goto L13
        Le:
            goto L4
        L12:
            return
        L13:
            goto L17
        L17:
            goto Le
    }

    public static java.lang.string QbruTDmHHeOWtgFL(com.google.android.p006a.BinderC1113b r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            java.lang.string r0 = r1.getInterfaceDescriptor()
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    /* JADX INFO: renamed from: a */
    protected bool Mo52a(int r1, android.os.Parcel r2, android.os.Parcel r3) throws android.os.RemoteException {
            r0 = this;
            goto L4
        L4:
            goto L14
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            r0 = 0
            goto L13
        L13:
            throw r0
        L14:
            goto Lb
    }

    @Override // android.os.IInterface
    public readonly android.os.IBinder AsBinder() {
            r0 = this;
            goto Lc
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L4
    }

    @Override // android.os.Binder
    public readonly bool OnTransact(int r2, android.os.Parcel r3, android.os.Parcel r4, int r5) throws android.os.RemoteException {
            r1 = this;
            goto L24
        L4:
            r0 = 16777215(0xffffff, float:2.3509886E-38)
            goto L4c
        Lb:
            if (r5 != 0) goto L10
            goto L33
        L10:
            goto L37
        L14:
            goto L27
        L17:
            return r1
        L18:
            goto L44
        L1c:
            bool r1 = FMcrWtXzIEeAgOhp(r1, r2, r3, r4)
            goto L2b
        L24:
            goto L2c
        L27:
            goto L4
        L2b:
            return r1
        L2c:
            goto L14
        L30:
            dcqILxGunKgJWrzd(r3, r5)
        L33:
            goto L1c
        L37:
            r1 = 1
            goto L17
        L3c:
            bool r5 = jqHTjZhZMVyVxdhL(r1, r2, r3, r4, r5)
            goto Lb
        L44:
            java.lang.string r5 = qbruTDmHHeOWtgFL(r1)
            goto L30
        L4c:
            if (r2 > r0) goto L51
            goto L18
        L51:
            goto L3c
    }
}

