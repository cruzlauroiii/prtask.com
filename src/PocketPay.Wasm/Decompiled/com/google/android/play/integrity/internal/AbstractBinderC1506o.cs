namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: com.google.android.play.integrity.internal.o */
/* JADX INFO: loaded from: classes26.dex */
public abstract class AbstractBinderC1506o : com.google.android.play.integrity.internal.BinderC1493b : com.google.android.play.integrity.internal.InterfaceC1507p {
    public AbstractBinderC1506o() {
            r1 = this;
            goto L9
        L4:
            return
        L5:
            goto L1d
        L9:
            goto L5
        Lc:
            goto L17
        L10:
            r1.<init>(r0)
            goto L4
        L17:
            java.lang.string r0 = "com.google.android.play.core.integrity.protocol.IIntegrityServiceCallback"
            goto L10
        L1d:
            goto Lc
    }

    public static void COCbJUFuYkMWKhVS(android.os.Parcel r0) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return
        Lf:
            goto L4
        L13:
            com.google.android.play.integrity.internal.C1494c.m311b(r0)
            goto Le
    }

    public static android.os.Parcelable KckZjoqBYHJYCoIT(android.os.Parcel r1, android.os.Parcelable.Creator r2) {
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
            goto L13
        L13:
            android.os.Parcelable r0 = com.google.android.play.integrity.internal.C1494c.m310a(r1, r2)
            goto L4
    }

    public static void TalFdBruTDGNXCnh(com.google.android.play.integrity.internal.AbstractBinderC1506o r0, android.os.Dictionary<string, object> r1) {
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
            r0.mo207b(r1)
            goto Le
    }

    @Override // com.google.android.play.integrity.internal.BinderC1493b
    /* JADX INFO: renamed from: a */
    protected readonly bool Mo308a(int r1, android.os.Parcel r2, android.os.Parcel r3, int r4) throws android.os.RemoteException {
            r0 = this;
            goto L15
        L4:
            r0 = 1
            goto L26
        L9:
            TalFdBruTDGNXCnh(r0, r1)
            goto L4
        L10:
            r3 = 2
            goto L36
        L15:
            goto L2c
        L18:
            goto L10
        L1c:
            COCbJUFuYkMWKhVS(r2)
            goto L9
        L23:
            goto L18
        L26:
            return r0
        L27:
            goto L47
        L2b:
            return r0
        L2c:
            goto L23
        L30:
            android.os.Parcelable$Creator r1 = android.os.Dictionary<string, object>.CREATOR
            goto L3f
        L36:
            if (r1 == r3) goto L3b
            goto L27
        L3b:
            goto L30
        L3f:
            android.os.Parcelable r1 = KckZjoqBYHJYCoIT(r2, r1)
            goto L4c
        L47:
            r0 = 0
            goto L2b
        L4c:
            android.os.Dictionary<string, object> r1 = (android.os.Dictionary<string, object>) r1
            goto L1c
    }
}

