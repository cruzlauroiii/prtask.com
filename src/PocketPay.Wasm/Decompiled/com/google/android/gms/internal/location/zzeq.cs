namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
public readonly class zzeq : com.google.android.gms.internal.location.zzep {
    public static void XUEUXQQzJAqaZORJ(java.lang.object r0, java.lang.object r1, short r2, byte r3, bool r4, float r5) {
            goto L26
        L4:
            return
        L5:
            goto L2d
        L9:
            int r2 = r0 * r1
            goto L15
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L15:
            int r3 = r2 + r1
            goto L1b
        L1b:
            double r0 = (double) r3
            goto L4
        L20:
            r0 = 42
            goto Lf
        L26:
            goto L5
        L29:
            goto L20
        L2d:
            goto L29
    }

    public static void XUEUXQQzJAqaZORJ(java.lang.object r0, java.lang.object r1, short r2, bool r3, float r4, byte r5) {
            goto L13
        L4:
            int r2 = r0 * r1
            goto L25
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L10:
            goto L16
        L13:
            goto L2c
        L16:
            goto L1f
        L1a:
            double r0 = (double) r3
            goto L2b
        L1f:
            r0 = 42
            goto La
        L25:
            int r3 = r2 + r1
            goto L1a
        L2b:
            return
        L2c:
            goto L10
    }

    public static void XUEUXQQzJAqaZORJ(java.lang.object r0, java.lang.object r1, bool r2, byte r3, float r4, short r5) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto L15
        La:
            double r0 = (double) r3
            goto L1b
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L15:
            int r3 = r2 + r1
            goto La
        L1b:
            return
        L1c:
            goto L26
        L20:
            r0 = 42
            goto Lf
        L26:
            goto L2c
        L29:
            goto L1c
        L2c:
            goto L20
    }

    public static bool XUEUXQQzJAqaZORJ(java.lang.object r1, java.lang.object r2) {
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
            bool r0 = r1.Equals(r2)
            goto Le
    }

    public static void Zza(java.lang.object r0, java.lang.object r1, byte r2, short r3, float r4, bool r5) {
            goto L13
        L4:
            goto L16
        L7:
            int r3 = r2 + r1
            goto L25
        Ld:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
        L13:
            goto L21
        L16:
            goto L2a
        L1a:
            int r2 = r0 * r1
            goto L7
        L20:
            return
        L21:
            goto L4
        L25:
            double r0 = (double) r3
            goto L20
        L2a:
            r0 = 42
            goto Ld
    }

    public static void Zza(java.lang.object r0, java.lang.object r1, float r2, short r3, byte r4, bool r5) {
            goto L15
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        La:
            return
        Lb:
            goto L1c
        Lf:
            int r3 = r2 + r1
            goto L2b
        L15:
            goto Lb
        L18:
            goto L25
        L1c:
            goto L18
        L1f:
            int r2 = r0 * r1
            goto Lf
        L25:
            r0 = 42
            goto L4
        L2b:
            double r0 = (double) r3
            goto La
    }

    public static void Zza(java.lang.object r0, java.lang.object r1, short r2, float r3, byte r4, bool r5) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
        La:
            goto L1e
        Ld:
            goto L2a
        L11:
            int r2 = r0 * r1
            goto L17
        L17:
            int r3 = r2 + r1
            goto L25
        L1d:
            return
        L1e:
            goto L22
        L22:
            goto Ld
        L25:
            double r0 = (double) r3
            goto L1d
        L2a:
            r0 = 42
            goto L4
    }

    public static bool Zza(@javax.annotation.CheckForNull java.lang.object r2, @javax.annotation.CheckForNull java.lang.object r3) {
            goto L29
        L4:
            goto L2c
        L7:
            goto L1e
        La:
            goto L76
        Le:
            if (r2 != 0) goto L13
            goto L5d
        L13:
            goto L5c
        L17:
            int r0 = r0 + r1
            goto L4f
        L1d:
            return r0
        L1e:
            goto L55
        L22:
            r0 = 2
            goto L6a
        L29:
            goto L58
        L2c:
            goto L22
        L30:
            if (r2 != r3) goto L35
            goto L3a
        L35:
            goto L71
        L39:
            return r1
        L3a:
            goto L1d
        L3e:
            bool r2 = xUEUXQQzJAqaZORJ(r2, r3)
            goto Le
        L46:
            if (r0 <= 0) goto L4b
            goto La
        L4b:
            goto L7
        L4f:
            int r0 = r0 % r1
            goto L46
        L55:
            goto La
        L58:
            goto L4
        L5c:
            return r0
        L5d:
            goto L39
        L61:
            if (r2 != 0) goto L66
            goto L5d
        L66:
            goto L3e
        L6a:
            r1 = 32
            goto L17
        L71:
            r1 = 0
            goto L61
        L76:
            r0 = 1
            goto L30
    }
}

