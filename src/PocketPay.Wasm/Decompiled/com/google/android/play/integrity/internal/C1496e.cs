namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: com.google.android.play.integrity.internal.e */
/* JADX INFO: loaded from: classes26.dex */
readonly class C1496e : com.google.android.play.integrity.internal.AbstractC1497f {

    /* JADX INFO: renamed from: a */
    private readonly int f304a;

    /* JADX INFO: renamed from: b */
    private readonly long f305b;

    C1496e(int r1, long r2) {
            r0 = this;
            goto L4
        L4:
            goto L19
        L7:
            goto Lb
        Lb:
            r0.<init>()
            goto L12
        L12:
            r0.f304a = r1
            goto L1d
        L18:
            return
        L19:
            goto L23
        L1d:
            r0.f305b = r2
            goto L18
        L23:
            goto L7
    }

    public static java.lang.string EZKyltIgXAHQDESc(java.lang.stringBuilder r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            java.lang.string r0 = r1.tostring()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static java.lang.stringBuilder LNTIFKUOGUWUXiZq(java.lang.stringBuilder r1, java.lang.string r2) {
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

    public static java.lang.stringBuilder MEuhKQwYDYzkrJtM(java.lang.stringBuilder r1, int r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static int PzVLmZCPSMYFddbg(com.google.android.play.integrity.internal.AbstractC1497f r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            int r0 = r1.mo315a()
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static java.lang.stringBuilder EwhAAhXHonwAuVWI(java.lang.stringBuilder r1, long r2) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static long FZJhxHfKcPUmTSdt(com.google.android.play.integrity.internal.AbstractC1497f r2) {
            goto L26
        L4:
            r1 = 30
            goto L39
        Lb:
            if (r0 <= 0) goto L10
            goto L48
        L10:
            goto L45
        L14:
            goto L29
        L17:
            r0 = 1
            goto L4
        L1e:
            long r0 = r2.mo316b()
            goto L2d
        L26:
            goto L35
        L29:
            goto L17
        L2d:
            return r0
        L2e:
            goto L32
        L32:
            goto L48
        L35:
            goto L14
        L39:
            int r0 = r0 + r1
            goto L3f
        L3f:
            int r0 = r0 % r1
            goto Lb
        L45:
            goto L2e
        L48:
            goto L1e
    }

    public static java.lang.stringBuilder PyIJhSHXrONJuPoU(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L14
        L4:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L11
        L11:
            goto L17
        L14:
            goto Ld
        L17:
            goto L4
    }

    @Override // com.google.android.play.integrity.internal.AbstractC1497f
    /* JADX INFO: renamed from: a */
    public readonly int Mo315a() {
            r0 = this;
            goto L12
        L4:
            int r0 = r0.f304a
            goto Ld
        La:
            goto L15
        Ld:
            return r0
        Le:
            goto La
        L12:
            goto Le
        L15:
            goto L4
    }

    @Override // com.google.android.play.integrity.internal.AbstractC1497f
    /* JADX INFO: renamed from: b */
    public readonly long Mo316b() {
            r2 = this;
            goto L24
        L4:
            long r0 = r2.f305b
            goto L11
        La:
            r0 = 20
            goto L3a
        L11:
            return r0
        L12:
            goto L1d
        L16:
            goto L12
        L19:
            goto L4
        L1d:
            goto L19
        L20:
            goto L2b
        L24:
            goto L20
        L27:
            goto La
        L2b:
            goto L27
        L2e:
            int r0 = r0 + r1
            goto L34
        L34:
            int r0 = r0 % r1
            goto L41
        L3a:
            r1 = 17
            goto L2e
        L41:
            if (r0 <= 0) goto L46
            goto L19
        L46:
            goto L16
    }

    public readonly bool Equals(java.lang.object r6) {
            r5 = this;
            goto L88
        L4:
            if (r1 != 0) goto L9
            goto L13
        L9:
            goto L8f
        Ld:
            r0 = 1
            goto L54
        L12:
            return r0
        L13:
            goto L17
        L17:
            return r2
        L18:
            goto L81
        L1c:
            long r5 = fZJhxHfKcPUmTSdt(r6)
            goto L95
        L24:
            if (r0 <= 0) goto L29
            goto L47
        L29:
            goto L44
        L2d:
            int r0 = r0 + r1
            goto L5d
        L33:
            return r0
        L34:
            goto L75
        L38:
            if (r5 == 0) goto L3d
            goto L13
        L3d:
            goto L12
        L41:
            goto L8b
        L44:
            goto L18
        L47:
            goto Ld
        L4b:
            if (r1 == r3) goto L50
            goto L13
        L50:
            goto L68
        L54:
            if (r6 == r5) goto L59
            goto L34
        L59:
            goto L33
        L5d:
            int r0 = r0 % r1
            goto L24
        L63:
            r2 = 0
            goto L4
        L68:
            long r3 = r5.f305b
            goto L1c
        L6e:
            r0 = 20
            goto L9b
        L75:
            bool r1 = r6 is com.google.android.play.integrity.internal.AbstractC1497f
            goto L63
        L7b:
            int r1 = r5.f304a
            goto La2
        L81:
            goto L47
        L84:
            goto L41
        L88:
            goto L84
        L8b:
            goto L6e
        L8f:
            com.google.android.play.integrity.internal.f r6 = (com.google.android.play.integrity.internal.AbstractC1497f) r6
            goto L7b
        L95:
            int r5 = (r3 > r5 ? 1 : (r3 == r5 ? 0 : -1))
            goto L38
        L9b:
            r1 = 13
            goto L2d
        La2:
            int r3 = PzVLmZCPSMYFddbg(r6)
            goto L4b
    }

    public readonly int HashCode() {
            r4 = this;
            goto L10
        L4:
            r0 = 15
            goto L2d
        Lb:
            return r4
        Lc:
            goto L17
        L10:
            goto L1a
        L13:
            goto L4
        L17:
            goto L37
        L1a:
            goto L1e
        L1e:
            goto L13
        L21:
            int r0 = r0 % r1
            goto L73
        L27:
            r2 = 32
            goto L4b
        L2d:
            r1 = 12
            goto L6d
        L34:
            goto Lc
        L37:
            goto L62
        L3b:
            r4 = r4 ^ r2
            goto L5d
        L40:
            int r4 = r4.f304a
            goto L27
        L46:
            int r0 = (int) r0
            goto L68
        L4b:
            long r2 = r0 >>> r2
            goto L58
        L51:
            r2 = 1000003(0xf4243, float:1.401303E-39)
            goto L3b
        L58:
            long r0 = r0 ^ r2
            goto L51
        L5d:
            int r4 = r4 * r2
            goto L46
        L62:
            long r0 = r4.f305b
            goto L40
        L68:
            r4 = r4 ^ r0
            goto Lb
        L6d:
            int r0 = r0 + r1
            goto L21
        L73:
            if (r0 <= 0) goto L78
            goto L37
        L78:
            goto L34
    }

    public readonly java.lang.string Tostring() {
            r3 = this;
            goto L78
        L4:
            goto L7b
        L7:
            pyIJhSHXrONJuPoU(r0, r1)
            goto L32
        Le:
            if (r0 <= 0) goto L13
            goto L21
        L13:
            goto L1e
        L17:
            r0 = 4
            goto L63
        L1e:
            goto L45
        L21:
            goto L49
        L25:
            int r0 = r0 % r1
            goto Le
        L2b:
            r0.<init>(r1)
            goto L86
        L32:
            long r1 = r3.f305b
            goto L7f
        L38:
            int r0 = r0 + r1
            goto L25
        L3e:
            java.lang.string r3 = "}"
            goto L71
        L44:
            return r3
        L45:
            goto L8c
        L49:
            java.lang.stringBuilder r0 = new java.lang.stringBuilder
            goto L5d
        L4f:
            java.lang.string r1 = ", eventTimestamp="
            goto L7
        L55:
            java.lang.string r3 = EZKyltIgXAHQDESc(r0)
            goto L44
        L5d:
            java.lang.string r1 = "EventRecord{eventType="
            goto L2b
        L63:
            r1 = 18
            goto L38
        L6a:
            MEuhKQwYDYzkrJtM(r0, r1)
            goto L4f
        L71:
            LNTIFKUOGUWUXiZq(r0, r3)
            goto L55
        L78:
            goto L8f
        L7b:
            goto L17
        L7f:
            ewhAAhXHonwAuVWI(r0, r1)
            goto L3e
        L86:
            int r1 = r3.f304a
            goto L6a
        L8c:
            goto L21
        L8f:
            goto L4
    }
}

