namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: com.google.android.a.c */
/* JADX INFO: loaded from: classes20.dex */
public readonly class C1114c {
    static {
            goto La
        L4:
            java.lang.Class<com.google.android.a.c> r0 = com.google.android.p006a.C1114c.class
            goto L19
        La:
            goto L12
        Ld:
            goto L4
        L11:
            return
        L12:
            goto L16
        L16:
            goto Ld
        L19:
            hRtAdQKZTSswMhVu(r0)
            goto L11
    }

    private C1114c() {
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

    public static int LQSGrVonRYLfUGyC(android.os.Parcel r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            int r0 = r1.readInt()
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static void LwAyOvEgTxOnPkTk(android.os.Parcel r0, int r1) {
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
            r0.writeInt(r1)
            goto L4
    }

    public static java.lang.object OjwFwPrTmOSENzIh(android.os.Parcelable.Creator r1, android.os.Parcel r2) {
            goto Lc
        L4:
            java.lang.object r0 = r1.createFromParcel(r2)
            goto L16
        Lc:
            goto L17
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            return r0
        L17:
            goto L13
    }

    public static void TRMYQwTMYaGYIuEz(android.os.Parcel r0, int r1) {
            goto Lc
        L4:
            goto Lf
        L7:
            return
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            r0.writeInt(r1)
            goto L7
    }

    /* JADX INFO: renamed from: a */
    public static <T : android.os.Parcelable> T m53a(android.os.Parcel r1, android.os.Parcelable.Creator<T> r2) {
            goto L4
        L4:
            goto L2a
        L7:
            goto L21
        Lb:
            if (r0 == 0) goto L10
            goto L1a
        L10:
            goto L14
        L14:
            r1 = 0
            goto L19
        L19:
            return r1
        L1a:
            goto L34
        L1e:
            goto L7
        L21:
            int r0 = LQSGrVonRYLfUGyC(r1)
            goto Lb
        L29:
            return r1
        L2a:
            goto L1e
        L2e:
            android.os.Parcelable r1 = (android.os.Parcelable) r1
            goto L29
        L34:
            java.lang.object r1 = OjwFwPrTmOSENzIh(r2, r1)
            goto L2e
    }

    /* JADX INFO: renamed from: b */
    public static void M54b(android.os.Parcel r1, android.os.Parcelable r2) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L26
        Lb:
            return
        Lc:
            goto L1c
        L10:
            pHxhtcmzoWtJcbTG(r2, r1, r0)
            goto Lb
        L17:
            r0 = 0
            goto L10
        L1c:
            goto L7
        L1f:
            bsfjytCHpiFOApnG(r1, r0)
            goto L17
        L26:
            r0 = 1
            goto L1f
    }

    public static void BsfjytCHpiFOApnG(android.os.Parcel r0, int r1) {
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
            r0.writeInt(r1)
            goto Le
    }

    /* JADX INFO: renamed from: c */
    public static void M55c(android.os.Parcel r1, android.os.Parcelable r2) {
            goto L1f
        L4:
            return
        L5:
            goto L9
        L9:
            goto L22
        Lc:
            LwAyOvEgTxOnPkTk(r1, r0)
            goto L34
        L13:
            TRMYQwTMYaGYIuEz(r1, r2)
            goto L2f
        L1a:
            r0 = 1
            goto Lc
        L1f:
            goto L5
        L22:
            goto L26
        L26:
            if (r2 == 0) goto L2b
            goto L30
        L2b:
            goto L3b
        L2f:
            return
        L30:
            goto L1a
        L34:
            cUvsOdfCEAnCOuPJ(r2, r1, r0)
            goto L4
        L3b:
            r2 = 0
            goto L13
    }

    public static void CUvsOdfCEAnCOuPJ(android.os.Parcelable r0, android.os.Parcel r1, int r2) {
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
            r0.writeToParcel(r1, r2)
            goto Lb
        L17:
            goto L7
    }

    public static java.lang.ClassLoader HRtAdQKZTSswMhVu(java.lang.Class r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            java.lang.ClassLoader r0 = r1.getClassLoader()
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static void PHxhtcmzoWtJcbTG(android.os.Parcelable r0, android.os.Parcel r1, int r2) {
            goto L4
        L4:
            goto L16
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            r0.writeToParcel(r1, r2)
            goto L15
        L15:
            return
        L16:
            goto Lb
    }
}

