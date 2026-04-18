namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: com.google.android.play.integrity.internal.h */
/* JADX INFO: loaded from: classes26.dex */
public abstract class AbstractBinderC1499h : com.google.android.play.integrity.internal.BinderC1493b : com.google.android.play.integrity.internal.InterfaceC1500i {
    /* JADX INFO: renamed from: b */
    public static com.google.android.play.integrity.internal.InterfaceC1500i M321b(android.os.IBinder r2) {
            goto L61
        L4:
            if (r1 != 0) goto L9
            goto L3f
        L9:
            goto L6d
        Ld:
            r0 = 2
            goto L14
        L14:
            r1 = 21
            goto L52
        L1b:
            return r2
        L1c:
            goto L2b
        L20:
            bool r1 = r0 is com.google.android.play.integrity.internal.InterfaceC1500i
            goto L4
        L26:
            r2 = 0
            goto L1b
        L2b:
            java.lang.string r0 = "com.google.android.play.core.integrity.protocol.IExpressIntegrityService"
            goto L4a
        L31:
            r0.<init>(r2)
            goto L68
        L38:
            com.google.android.play.integrity.internal.g r0 = new com.google.android.play.integrity.internal.g
            goto L31
        L3e:
            return r0
        L3f:
            goto L38
        L43:
            goto L69
        L46:
            goto L83
        L4a:
            android.os.IInterface r0 = gZGMaCPCutDIyPgs(r2, r0)
            goto L20
        L52:
            int r0 = r0 + r1
            goto L7a
        L58:
            if (r0 <= 0) goto L5d
            goto L46
        L5d:
            goto L43
        L61:
            goto L76
        L64:
            goto Ld
        L68:
            return r0
        L69:
            goto L73
        L6d:
            com.google.android.play.integrity.internal.i r0 = (com.google.android.play.integrity.internal.InterfaceC1500i) r0
            goto L3e
        L73:
            goto L46
        L76:
            goto L80
        L7a:
            int r0 = r0 % r1
            goto L58
        L80:
            goto L64
        L83:
            if (r2 == 0) goto L88
            goto L1c
        L88:
            goto L26
    }

    public static android.os.IInterface GZGMaCPCutDIyPgs(android.os.IBinder r1, java.lang.string r2) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            android.os.IInterface r0 = r1.queryLocalInterface(r2)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }
}

