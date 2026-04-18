namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
readonly class zzey : com.google.android.gms.internal.location.zzex {
    static readonly com.google.android.gms.internal.location.zzex zza = null;
    readonly java.lang.object[] zzb;
    private readonly int zzc;

    static {
            goto L5b
        L4:
            goto L1b
        L7:
            goto L2b
        Lb:
            r0 = 10
            goto L3e
        L12:
            int r0 = r0 + r1
            goto L45
        L18:
            goto L35
        L1b:
            goto L25
        L1f:
            com.google.android.gms.internal.location.zzey.zza = r0
            goto L34
        L25:
            com.google.android.gms.internal.location.zzey r0 = new com.google.android.gms.internal.location.zzey
            goto L39
        L2b:
            goto L5e
        L2e:
            java.lang.object[] r2 = new java.lang.object[r1]
            goto L4b
        L34:
            return
        L35:
            goto L4
        L39:
            r1 = 0
            goto L2e
        L3e:
            r1 = 23
            goto L12
        L45:
            int r0 = r0 % r1
            goto L52
        L4b:
            r0.<init>(r2, r1)
            goto L1f
        L52:
            if (r0 <= 0) goto L57
            goto L1b
        L57:
            goto L18
        L5b:
            goto L7
        L5e:
            goto Lb
    }

    zzey(java.lang.object[] r1, int r2) {
            r0 = this;
            goto L1c
        L4:
            r0.zzc = r2
            goto L11
        La:
            r0.<init>()
            goto L16
        L11:
            return
        L12:
            goto L23
        L16:
            r0.zzb = r1
            goto L4
        L1c:
            goto L12
        L1f:
            goto La
        L23:
            goto L1f
    }

    public static void DZPEvltskrgBInKr(java.lang.object r0, int r1, java.lang.object r2, int r3, int r4) {
            goto L4
        L4:
            goto L13
        L7:
            goto Lb
        Lb:
            java.lang.System.arraycopy(r0, r1, r2, r3, r4)
            goto L12
        L12:
            return
        L13:
            goto L17
        L17:
            goto L7
    }

    public static void DZPEvltskrgBInKr(java.lang.object r0, int r1, java.lang.object r2, int r3, int r4, int r5, short r6, byte r7, java.lang.string r8) {
            goto L16
        L4:
            int r2 = r0 * r1
            goto La
        La:
            int r3 = r2 + r1
            goto L25
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L16:
            goto L21
        L19:
            goto L2a
        L1d:
            goto L19
        L20:
            return
        L21:
            goto L1d
        L25:
            double r0 = (double) r3
            goto L20
        L2a:
            r0 = 42
            goto L10
    }

    public static void DZPEvltskrgBInKr(java.lang.object r0, int r1, java.lang.object r2, int r3, int r4, java.lang.string r5, short r6, int r7, byte r8) {
            goto L23
        L4:
            double r0 = (double) r3
            goto L1e
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        L15:
            goto L26
        L18:
            int r2 = r0 * r1
            goto L9
        L1e:
            return
        L1f:
            goto L15
        L23:
            goto L1f
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto Lf
    }

    public static void DZPEvltskrgBInKr(java.lang.object r0, int r1, java.lang.object r2, int r3, int r4, short r5, byte r6, int r7, java.lang.string r8) {
            goto L4
        L4:
            goto L26
        L7:
            goto L11
        Lb:
            int r2 = r0 * r1
            goto L1c
        L11:
            r0 = 42
            goto L2a
        L17:
            double r0 = (double) r3
            goto L25
        L1c:
            int r3 = r2 + r1
            goto L17
        L22:
            goto L7
        L25:
            return
        L26:
            goto L22
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lb
    }

    public static java.lang.object FmkhlnxTYMqCkcpf(java.lang.object r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            java.lang.object r0 = java.util.objects.requireNonNull(r1)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static void FmkhlnxTYMqCkcpf(java.lang.object r0, byte r1, float r2, short r3, char r4) {
            goto L1d
        L4:
            double r0 = (double) r3
            goto L15
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            r0 = 42
            goto L24
        L15:
            return
        L16:
            goto L1a
        L1a:
            goto L20
        L1d:
            goto L16
        L20:
            goto Lf
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L2a:
            int r2 = r0 * r1
            goto L9
    }

    public static void FmkhlnxTYMqCkcpf(java.lang.object r0, float r1, byte r2, short r3, char r4) {
            goto L29
        L4:
            double r0 = (double) r3
            goto Lf
        L9:
            int r2 = r0 * r1
            goto L23
        Lf:
            return
        L10:
            goto L1a
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L1a:
            goto L2c
        L1d:
            r0 = 42
            goto L14
        L23:
            int r3 = r2 + r1
            goto L4
        L29:
            goto L10
        L2c:
            goto L1d
    }

    public static void FmkhlnxTYMqCkcpf(java.lang.object r0, short r1, char r2, float r3, byte r4) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L25
        Lb:
            return
        Lc:
            goto L16
        L10:
            int r2 = r0 * r1
            goto L1f
        L16:
            goto L7
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L1f:
            int r3 = r2 + r1
            goto L2b
        L25:
            r0 = 42
            goto L19
        L2b:
            double r0 = (double) r3
            goto Lb
    }

    public static int WuobbzqAHMEZOEzR(int r1, int r2, java.lang.string r3) {
            goto L14
        L4:
            goto L17
        L7:
            int r0 = com.google.android.gms.internal.location.zzer.zzc(r1, r2, r3)
            goto Lf
        Lf:
            return r0
        L10:
            goto L4
        L14:
            goto L10
        L17:
            goto L7
    }

    public static void WuobbzqAHMEZOEzR(int r0, int r1, java.lang.string r2, byte r3, char r4, bool r5, java.lang.string r6) {
            goto L4
        L4:
            goto L18
        L7:
            goto L2a
        Lb:
            int r2 = r0 * r1
            goto L24
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lb
        L17:
            return
        L18:
            goto L21
        L1c:
            double r0 = (double) r3
            goto L17
        L21:
            goto L7
        L24:
            int r3 = r2 + r1
            goto L1c
        L2a:
            r0 = 42
            goto L11
    }

    public static void WuobbzqAHMEZOEzR(int r0, int r1, java.lang.string r2, java.lang.string r3, bool r4, byte r5, char r6) {
            goto L29
        L4:
            r0 = 42
            goto L1d
        La:
            goto L2c
        Ld:
            double r0 = (double) r3
            goto L18
        L12:
            int r2 = r0 * r1
            goto L23
        L18:
            return
        L19:
            goto La
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
        L23:
            int r3 = r2 + r1
            goto Ld
        L29:
            goto L19
        L2c:
            goto L4
    }

    public static void WuobbzqAHMEZOEzR(int r0, int r1, java.lang.string r2, bool r3, byte r4, java.lang.string r5, char r6) {
            goto L15
        L4:
            int r2 = r0 * r1
            goto L2a
        La:
            return
        Lb:
            goto L22
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L15:
            goto Lb
        L18:
            goto L1c
        L1c:
            r0 = 42
            goto Lf
        L22:
            goto L18
        L25:
            double r0 = (double) r3
            goto La
        L2a:
            int r3 = r2 + r1
            goto L25
    }

    @Override // java.util.List
    public readonly java.lang.object Get(int r3) {
            r2 = this;
            goto L34
        L4:
            java.lang.object[] r2 = r2.zzb
            goto L49
        La:
            if (r0 <= 0) goto Lf
            goto L67
        Lf:
            goto L64
        L13:
            r1 = 17
            goto L21
        L1a:
            goto L67
        L1d:
            goto L46
        L21:
            int r0 = r0 + r1
            goto L4f
        L27:
            wuobbzqAHMEZOEzR(r3, r0, r1)
            goto L4
        L2e:
            int r0 = r2.zzc
            goto L3b
        L34:
            goto L1d
        L37:
            goto L5d
        L3b:
            java.lang.string r1 = "index"
            goto L27
        L41:
            return r2
        L42:
            goto L1a
        L46:
            goto L37
        L49:
            r2 = r2[r3]
            goto L55
        L4f:
            int r0 = r0 % r1
            goto La
        L55:
            java.lang.object r2 = fmkhlnxTYMqCkcpf(r2)
            goto L41
        L5d:
            r0 = 19
            goto L13
        L64:
            goto L42
        L67:
            goto L2e
    }

    @Override // java.util.AbstractICollection, java.util.ICollection, java.util.List
    public readonly int Size() {
            r0 = this;
            goto L12
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L15
        Lc:
            int r0 = r0.zzc
            goto L4
        L12:
            goto L5
        L15:
            goto Lc
    }

    @Override // com.google.android.gms.internal.location.zzeu
    readonly java.lang.object[] zzb() {
            r0 = this;
            goto Lf
        L4:
            java.lang.object[] r0 = r0.zzb
            goto La
        La:
            return r0
        Lb:
            goto L16
        Lf:
            goto Lb
        L12:
            goto L4
        L16:
            goto L12
    }

    @Override // com.google.android.gms.internal.location.zzeu
    readonly int zzc() {
            r0 = this;
            goto L11
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L14
        Lc:
            r0 = 0
            goto L4
        L11:
            goto L5
        L14:
            goto Lc
    }

    @Override // com.google.android.gms.internal.location.zzeu
    readonly int zzd() {
            r0 = this;
            goto Lf
        L4:
            return r0
        L5:
            goto L16
        L9:
            int r0 = r0.zzc
            goto L4
        Lf:
            goto L5
        L12:
            goto L9
        L16:
            goto L12
    }

    @Override // com.google.android.gms.internal.location.zzeu
    readonly bool zzf() {
            r0 = this;
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return r0
        Lf:
            goto Lb
        L13:
            r0 = 0
            goto Le
    }

    @Override // com.google.android.gms.internal.location.zzex, com.google.android.gms.internal.location.zzeu
    readonly int zzg(java.lang.object[] r3, int r4) {
            r2 = this;
            goto L1c
        L4:
            java.lang.object[] r4 = r2.zzb
            goto L53
        La:
            int r0 = r0 + r1
            goto L37
        L10:
            dZPEvltskrgBInKr(r4, r0, r3, r0, r1)
            goto L3d
        L17:
            return r2
        L18:
            goto L5b
        L1c:
            goto L5e
        L1f:
            goto L43
        L23:
            int r1 = r2.zzc
            goto L10
        L29:
            goto L18
        L2c:
            goto L4
        L30:
            r1 = 23
            goto La
        L37:
            int r0 = r0 % r1
            goto L4a
        L3d:
            int r2 = r2.zzc
            goto L17
        L43:
            r0 = 9
            goto L30
        L4a:
            if (r0 <= 0) goto L4f
            goto L2c
        L4f:
            goto L29
        L53:
            r0 = 0
            goto L23
        L58:
            goto L1f
        L5b:
            goto L2c
        L5e:
            goto L58
    }
}

