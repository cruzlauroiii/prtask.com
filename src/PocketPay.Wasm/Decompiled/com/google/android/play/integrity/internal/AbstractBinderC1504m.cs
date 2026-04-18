namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: com.google.android.play.integrity.internal.m */
/* JADX INFO: loaded from: classes26.dex */
public abstract class AbstractBinderC1504m : com.google.android.play.integrity.internal.BinderC1493b : com.google.android.play.integrity.internal.InterfaceC1505n {
    public static android.os.IInterface RfoeKcwlFTVoLWAL(android.os.IBinder r1, java.lang.string r2) {
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
            android.os.IInterface r0 = r1.queryLocalInterface(r2)
            goto L7
    }

    /* JADX INFO: renamed from: b */
    public static com.google.android.play.integrity.internal.InterfaceC1505n M324b(android.os.IBinder r2) {
            goto L4e
        L4:
            com.google.android.play.integrity.internal.n r0 = (com.google.android.play.integrity.internal.InterfaceC1505n) r0
            goto L79
        La:
            goto L4a
        Ld:
            goto L70
        L11:
            return r0
        L12:
            goto La
        L16:
            bool r1 = r0 is com.google.android.play.integrity.internal.InterfaceC1505n
            goto L35
        L1c:
            r0 = 8
            goto L28
        L23:
            return r2
        L24:
            goto L86
        L28:
            r1 = 27
            goto L73
        L2f:
            com.google.android.play.integrity.internal.l r0 = new com.google.android.play.integrity.internal.l
            goto L69
        L35:
            if (r1 != 0) goto L3a
            goto L7a
        L3a:
            goto L4
        L3e:
            if (r2 == 0) goto L43
            goto L24
        L43:
            goto L5e
        L47:
            goto L12
        L4a:
            goto L3e
        L4e:
            goto Ld
        L51:
            goto L1c
        L55:
            if (r0 <= 0) goto L5a
            goto L4a
        L5a:
            goto L47
        L5e:
            r2 = 0
            goto L23
        L63:
            int r0 = r0 % r1
            goto L55
        L69:
            r0.<init>(r2)
            goto L11
        L70:
            goto L51
        L73:
            int r0 = r0 + r1
            goto L63
        L79:
            return r0
        L7a:
            goto L2f
        L7e:
            android.os.IInterface r0 = RfoeKcwlFTVoLWAL(r2, r0)
            goto L16
        L86:
            java.lang.string r0 = "com.google.android.play.core.integrity.protocol.IIntegrityService"
            goto L7e
    }
}

