namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: com.google.android.a.a */
/* JADX INFO: loaded from: classes20.dex */
public class C1112a : android.os.IInterface {

    /* JADX INFO: renamed from: a */
    private readonly android.os.IBinder f80a;

    /* JADX INFO: renamed from: b */
    private readonly java.lang.string f81b;

    protected C1112a(android.os.IBinder r1) {
            r0 = this;
            goto L22
        L4:
            return
        L5:
            goto L29
        L9:
            r0.<init>()
            goto L10
        L10:
            r0.f80a = r1
            goto L16
        L16:
            java.lang.string r1 = "com.google.android.finsky.externalreferrer.IGetInstallReferrerService"
            goto L1c
        L1c:
            r0.f81b = r1
            goto L4
        L22:
            goto L5
        L25:
            goto L9
        L29:
            goto L25
    }

    public static void XwMBzVJphAXODtWr(android.os.Parcel r0) {
            goto Lb
        L4:
            r0.recycle()
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

    public static void ZbFkOrzylqAYedZe(android.os.Parcel r0) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return
        Lf:
            goto Lb
        L13:
            r0.readException()
            goto Le
    }

    public static android.os.Parcel ApfnpkAswjZjSLTV() {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            android.os.Parcel r0 = android.os.Parcel.obtain()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static void JMIOAdqrNXIsamfh(android.os.Parcel r0, java.lang.string r1) {
            goto Le
        L4:
            r0.writeInterfaceToken(r1)
            goto L15
        Lb:
            goto L11
        Le:
            goto L16
        L11:
            goto L4
        L15:
            return
        L16:
            goto Lb
    }

    public static void LATWpSCGuRufECTF(android.os.Parcel r0) {
            goto L13
        L4:
            r0.recycle()
            goto Le
        Lb:
            goto L16
        Le:
            return
        Lf:
            goto Lb
        L13:
            goto Lf
        L16:
            goto L4
    }

    public static void MvvgSIhYGfwVAKGJ(android.os.Parcel r0) {
            goto L9
        L4:
            return
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            r0.recycle()
            goto L4
    }

    public static android.os.Parcel NyxEZwzPEvBwwqbt() {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            android.os.Parcel r0 = android.os.Parcel.obtain()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static bool TtYtLcTLXxWLtiNS(android.os.IBinder r1, int r2, android.os.Parcel r3, android.os.Parcel r4, int r5) {
            goto L11
        L4:
            bool r0 = r1.transact(r2, r3, r4, r5)
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

    /* JADX INFO: renamed from: a */
    protected readonly android.os.Parcel M50a() {
            r1 = this;
            goto Lc
        L4:
            android.os.Parcel r0 = apfnpkAswjZjSLTV()
            goto L22
        Lc:
            goto L14
        Lf:
            goto L4
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto Lf
        L1b:
            jMIOAdqrNXIsamfh(r0, r1)
            goto L13
        L22:
            java.lang.string r1 = r1.f81b
            goto L1b
    }

    @Override // android.os.IInterface
    public readonly android.os.IBinder AsBinder() {
            r0 = this;
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return r0
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            android.os.IBinder r0 = r0.f80a
            goto Lb
    }

    /* JADX INFO: renamed from: b */
    protected readonly android.os.Parcel M51b(android.os.Parcel r4) throws android.os.RemoteException {
            r3 = this;
            goto L3e
        L4:
            goto La
        L5:
            r3 = move-exception
            lATWpSCGuRufECTF(r0)     // Catch: java.lang.Exception -> L2d
            throw r3     // Catch: java.lang.Exception -> L2d
        La:
            goto L25
        Le:
            goto L41
        L11:
            goto L33
        L14:
            goto L59
        L18:
            goto L14
        L1b:
            goto Le
        L1f:
            int r0 = r0 % r1
            goto L6b
        L25:
            XwMBzVJphAXODtWr(r4)
            goto L32
        L2c:
            return r0
        L2d:
            r3 = move-exception
            goto L4
        L32:
            throw r3
        L33:
            goto L18
        L37:
            r0 = 7
            goto L45
        L3e:
            goto L1b
        L41:
            goto L37
        L45:
            r1 = 8
            goto L53
        L4c:
            mvvgSIhYGfwVAKGJ(r4)
            goto L2c
        L53:
            int r0 = r0 + r1
            goto L1f
        L59:
            android.os.Parcel r0 = nyxEZwzPEvBwwqbt()
            android.os.IBinder r3 = r3.f80a     // Catch: java.lang.Exception -> L5 java.lang.Exception -> L2d
            r1 = 1
            r2 = 0
            ttYtLcTLXxWLtiNS(r3, r1, r4, r0, r2)     // Catch: java.lang.Exception -> L5 java.lang.Exception -> L2d
            ZbFkOrzylqAYedZe(r0)     // Catch: java.lang.Exception -> L5 java.lang.Exception -> L2d
            goto L4c
        L6b:
            if (r0 <= 0) goto L70
            goto L14
        L70:
            goto L11
    }
}

