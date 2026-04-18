namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: com.google.android.play.integrity.internal.c */
/* JADX INFO: loaded from: classes26.dex */
public readonly class C1494c {
    static {
            goto L14
        L4:
            java.lang.Class<com.google.android.play.integrity.internal.c> r0 = com.google.android.play.integrity.internal.C1494c.class
            goto Ld
        La:
            goto L17
        Ld:
            RjhfyEyBDzYXAVxE(r0)
            goto L1b
        L14:
            goto L1c
        L17:
            goto L4
        L1b:
            return
        L1c:
            goto La
    }

    private C1494c() {
            r0 = this;
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
            r0.<init>()
            goto L4
        L17:
            goto Lc
    }

    public static java.lang.stringBuilder BTBsCHirSTljKHuO(java.lang.stringBuilder r1, int r2) {
            goto L14
        L4:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto Lf
        Lc:
            goto L17
        Lf:
            return r0
        L10:
            goto Lc
        L14:
            goto L10
        L17:
            goto L4
    }

    public static java.lang.object BTVURvDnDPYpwKGU(android.os.Parcelable.Creator r1, android.os.Parcel r2) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            java.lang.object r0 = r1.createFromParcel(r2)
            goto Le
    }

    public static java.lang.ClassLoader RjhfyEyBDzYXAVxE(java.lang.Class r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return r0
        Lc:
            goto L18
        L10:
            java.lang.ClassLoader r0 = r1.getClassLoader()
            goto Lb
        L18:
            goto L7
    }

    public static void XSskFIKsNEdBnpXg(android.os.Parcel r0, int r1) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            r0.writeInt(r1)
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public static void XmUGPgQTfJaLiRgJ(android.os.Parcelable r0, android.os.Parcel r1, int r2) {
            goto L4
        L4:
            goto L13
        L7:
            goto Lb
        Lb:
            r0.writeToParcel(r1, r2)
            goto L12
        L12:
            return
        L13:
            goto L17
        L17:
            goto L7
    }

    /* JADX INFO: renamed from: a */
    public static android.os.Parcelable M310a(android.os.Parcel r1, android.os.Parcelable.Creator r2) {
            goto L11
        L4:
            int r0 = eTnxyRynjbAXpVeN(r1)
            goto L23
        Lc:
            r1 = 0
            goto L2f
        L11:
            goto L19
        L14:
            goto L4
        L18:
            return r1
        L19:
            goto L2c
        L1d:
            android.os.Parcelable r1 = (android.os.Parcelable) r1
            goto L18
        L23:
            if (r0 == 0) goto L28
            goto L30
        L28:
            goto Lc
        L2c:
            goto L14
        L2f:
            return r1
        L30:
            goto L34
        L34:
            java.lang.object r1 = BTVURvDnDPYpwKGU(r2, r1)
            goto L1d
    }

    /* JADX INFO: renamed from: b */
    public static void M311b(android.os.Parcel r3) {
            goto L25
        L4:
            goto L76
        L7:
            goto L81
        Lb:
            return
        Lc:
            goto L2c
        L10:
            goto L7
        L13:
            goto L4f
        L17:
            java.lang.string r2 = "Parcel data not fully consumed, unread size: "
            goto L48
        L1d:
            java.lang.string r3 = oqkAdWpzhLxdStGz(r1)
            goto L41
        L25:
            goto L13
        L28:
            goto L6e
        L2c:
            android.os.BadParcelableException r0 = new android.os.BadParcelableException
            goto L52
        L32:
            int r0 = r0 % r1
            goto L38
        L38:
            if (r0 <= 0) goto L3d
            goto L7
        L3d:
            goto L4
        L41:
            r0.<init>(r3)
            goto L75
        L48:
            r1.<init>(r2)
            goto L67
        L4f:
            goto L28
        L52:
            java.lang.stringBuilder r1 = new java.lang.stringBuilder
            goto L17
        L58:
            if (r3 <= 0) goto L5d
            goto Lc
        L5d:
            goto Lb
        L61:
            int r0 = r0 + r1
            goto L32
        L67:
            BTBsCHirSTljKHuO(r1, r3)
            goto L1d
        L6e:
            r0 = 19
            goto L7a
        L75:
            throw r0
        L76:
            goto L10
        L7a:
            r1 = 30
            goto L61
        L81:
            int r3 = zARyjjJsLLNgBBsl(r3)
            goto L58
    }

    /* JADX INFO: renamed from: c */
    public static void M312c(android.os.Parcel r1, android.os.Parcelable r2) {
            goto L1a
        L4:
            r0 = 0
            goto L9
        L9:
            XmUGPgQTfJaLiRgJ(r2, r1, r0)
            goto L26
        L10:
            XSskFIKsNEdBnpXg(r1, r0)
            goto L4
        L17:
            goto L1d
        L1a:
            goto L27
        L1d:
            goto L21
        L21:
            r0 = 1
            goto L10
        L26:
            return
        L27:
            goto L17
    }

    public static int ETnxyRynjbAXpVeN(android.os.Parcel r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            int r0 = r1.readInt()
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static java.lang.string OqkAdWpzhLxdStGz(java.lang.stringBuilder r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            java.lang.string r0 = r1.tostring()
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static int ZARyjjJsLLNgBBsl(android.os.Parcel r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            int r0 = r1.dataAvail()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }
}

