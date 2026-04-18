namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: com.google.android.play.integrity.internal.a */
/* JADX INFO: loaded from: classes26.dex */
public class C1492a : android.os.IInterface {

    /* JADX INFO: renamed from: a */
    private readonly android.os.IBinder f262a;

    /* JADX INFO: renamed from: b */
    private readonly java.lang.string f263b;

    protected C1492a(android.os.IBinder r1, java.lang.string r2) {
            r0 = this;
            goto Ld
        L4:
            goto L10
        L7:
            r0.f262a = r1
            goto L20
        Ld:
            goto L15
        L10:
            goto L19
        L14:
            return
        L15:
            goto L4
        L19:
            r0.<init>()
            goto L7
        L20:
            r0.f263b = r2
            goto L14
    }

    public static android.os.Parcel DiTtPiOfjIcxAiWn() {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            android.os.Parcel r0 = android.os.Parcel.obtain()
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static bool KLYbjPJCrebsZLmJ(android.os.IBinder r1, int r2, android.os.Parcel r3, android.os.Parcel r4, int r5) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            bool r0 = r1.transact(r2, r3, r4, r5)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static void ZUYHtlJwQDQJtQiR(android.os.Parcel r0, java.lang.string r1) {
            goto L9
        L4:
            return
        L5:
            goto L17
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            r0.writeInterfaceToken(r1)
            goto L4
        L17:
            goto Lc
    }

    public static void OEzBeaHYfNhliDUd(android.os.Parcel r0) {
            goto L9
        L4:
            return
        L5:
            goto L17
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            r0.recycle()
            goto L4
        L17:
            goto Lc
    }

    public static void VeVFuMLbbhzXWVYc(android.os.Parcel r0) {
            goto L7
        L4:
            goto La
        L7:
            goto L16
        La:
            goto Le
        Le:
            r0.recycle()
            goto L15
        L15:
            return
        L16:
            goto L4
    }

    /* JADX INFO: renamed from: a */
    protected readonly android.os.Parcel M257a() {
            r1 = this;
            goto Le
        L4:
            ZUYHtlJwQDQJtQiR(r0, r1)
            goto L15
        Lb:
            goto L11
        Le:
            goto L16
        L11:
            goto L1a
        L15:
            return r0
        L16:
            goto Lb
        L1a:
            android.os.Parcel r0 = DiTtPiOfjIcxAiWn()
            goto L22
        L22:
            java.lang.string r1 = r1.f263b
            goto L4
    }

    @Override // android.os.IInterface
    public readonly android.os.IBinder AsBinder() {
            r0 = this;
            goto L12
        L4:
            return r0
        L5:
            goto Lf
        L9:
            android.os.IBinder r0 = r0.f262a
            goto L4
        Lf:
            goto L15
        L12:
            goto L5
        L15:
            goto L9
    }

    /* JADX INFO: renamed from: b */
    protected readonly void M258b(int r3, android.os.Parcel r4) throws android.os.RemoteException {
            r2 = this;
            goto L15
        L4:
            goto L2d
        L7:
            goto L12
        Lb:
            r0 = 19
            goto L45
        L12:
            goto L18
        L15:
            goto L7
        L18:
            goto Lb
        L1c:
            throw r2
        L1d:
            goto L4
        L21:
            if (r0 <= 0) goto L26
            goto L2d
        L26:
            goto L2a
        L2a:
            goto L1d
        L2d:
            android.os.IBinder r2 = r2.f262a     // Catch: java.lang.Exception -> L54
            r0 = 0
            r1 = 1
            KLYbjPJCrebsZLmJ(r2, r3, r4, r0, r1)     // Catch: java.lang.Exception -> L54
            goto L3e
        L38:
            int r0 = r0 + r1
            goto L59
        L3e:
            oEzBeaHYfNhliDUd(r4)
            goto L53
        L45:
            r1 = 27
            goto L38
        L4c:
            veVFuMLbbhzXWVYc(r4)
            goto L1c
        L53:
            return
        L54:
            r2 = move-exception
            goto L4c
        L59:
            int r0 = r0 % r1
            goto L21
    }
}

