namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: com.google.android.play.integrity.internal.q */
/* JADX INFO: loaded from: classes26.dex */
public abstract class AbstractBinderC1508q : com.google.android.play.integrity.internal.BinderC1493b : com.google.android.play.integrity.internal.InterfaceC1509r {
    public AbstractBinderC1508q() {
            r1 = this;
            goto L13
        L4:
            goto L16
        L7:
            r1.<init>(r0)
            goto Le
        Le:
            return
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            goto L1a
        L1a:
            java.lang.string r0 = "com.google.android.play.core.integrity.protocol.IRequestDialogCallback"
            goto L7
    }

    public static void HQNCWvBUVyKeLLOz(android.os.Parcel r0) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return
        Lc:
            goto L17
        L10:
            com.google.android.play.integrity.internal.C1494c.m311b(r0)
            goto Lb
        L17:
            goto L7
    }

    public static android.os.Parcelable IJFygYJMxQVkJydJ(android.os.Parcel r1, android.os.Parcelable.Creator r2) {
            goto L9
        L4:
            return r0
        L5:
            goto L18
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            android.os.Parcelable r0 = com.google.android.play.integrity.internal.C1494c.m310a(r1, r2)
            goto L4
        L18:
            goto Lc
    }

    public static void TlpiyrYhjJksRHnP(com.google.android.play.integrity.internal.AbstractBinderC1508q r0, android.os.Dictionary<string, object> r1) {
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
            r0.mo216b(r1)
            goto Le
    }

    @Override // com.google.android.play.integrity.internal.BinderC1493b
    /* JADX INFO: renamed from: a */
    protected readonly bool Mo308a(int r1, android.os.Parcel r2, android.os.Parcel r3, int r4) throws android.os.RemoteException {
            r0 = this;
            goto L4b
        L4:
            tlpiyrYhjJksRHnP(r0, r1)
            goto L36
        Lb:
            r0 = 0
            goto L2a
        L10:
            return r0
        L11:
            goto Lb
        L15:
            android.os.Dictionary<string, object> r1 = (android.os.Dictionary<string, object>) r1
            goto L2f
        L1b:
            if (r1 == r3) goto L20
            goto L11
        L20:
            goto L24
        L24:
            android.os.Parcelable$Creator r1 = android.os.Dictionary<string, object>.CREATOR
            goto L3e
        L2a:
            return r0
        L2b:
            goto L3b
        L2f:
            HQNCWvBUVyKeLLOz(r2)
            goto L4
        L36:
            r0 = 1
            goto L10
        L3b:
            goto L4e
        L3e:
            android.os.Parcelable r1 = iJFygYJMxQVkJydJ(r2, r1)
            goto L15
        L46:
            r3 = 2
            goto L1b
        L4b:
            goto L2b
        L4e:
            goto L46
    }
}

