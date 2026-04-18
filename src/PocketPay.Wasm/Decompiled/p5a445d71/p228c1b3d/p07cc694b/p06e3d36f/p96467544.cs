namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes7.dex */
public readonly class p96467544 : p5a445d71.p228c1b3d.p07cc694b.p5636e72f : java.io.object {
    private static readonly long f04a1f7f7 = -6390301302770925357L;
    private static readonly long f04e23784 = -6390301302770925357L;
    private static java.util.HashDictionary f38481f4f = null;
    private static java.util.HashDictionary<p5a445d71.p228c1b3d.p07cc694b.pd5950989, p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p96467544> f53dc78f3 = null;
    private static readonly long f702bb471 = -6390301302770925357L;
    private static java.util.HashDictionary f7316813c = null;
    private static readonly long fc6e1e520 = -6390301302770925357L;
    private static readonly long fd481620f = -6390301302770925357L;
    private readonly p5a445d71.p228c1b3d.p07cc694b.pd5950989 f895e5861;
    private readonly p5a445d71.p228c1b3d.p07cc694b.pd5950989 fae5ba10e;
    private readonly p5a445d71.p228c1b3d.p07cc694b.pd5950989 fe00ef68a;

    private p96467544(p5a445d71.p228c1b3d.p07cc694b.pd5950989 r1) {
            r0 = this;
            goto L10
        L4:
            return
        L5:
            goto L17
        L9:
            r0.<init>()
            goto L1a
        L10:
            goto L5
        L13:
            goto L9
        L17:
            goto L13
        L1a:
            r0.fe00ef68a = r1
            goto L4
    }

    private java.lang.UnsupportedOperationException M723c2587() {
            r2 = this;
            goto L6b
        L4:
            java.lang.UnsupportedOperationException r0 = new java.lang.UnsupportedOperationException
            goto L3b
        La:
            p5a445d71.p228c1b3d.p07cc694b.pd5950989 r2 = r2.fe00ef68a
            goto L10
        L10:
            java.lang.stringBuilder r2 = r1.append(r2)
            goto L2e
        L18:
            java.lang.string r2 = r2.tostring()
            goto L48
        L20:
            int r0 = r0 % r1
            goto L72
        L26:
            java.lang.stringBuilder r2 = r2.append(r1)
            goto L18
        L2e:
            java.lang.string r1 = " field is unsupported"
            goto L26
        L34:
            goto L57
        L37:
            goto L61
        L3b:
            java.lang.stringBuilder r1 = new java.lang.stringBuilder
            goto L7b
        L41:
            r1 = 3
            goto L5b
        L48:
            r0.<init>(r2)
            goto L4f
        L4f:
            return r0
        L50:
            goto L34
        L54:
            goto L50
        L57:
            goto L4
        L5b:
            int r0 = r0 + r1
            goto L20
        L61:
            goto L6e
        L64:
            r0 = 14
            goto L41
        L6b:
            goto L37
        L6e:
            goto L64
        L72:
            if (r0 <= 0) goto L77
            goto L57
        L77:
            goto L54
        L7b:
            r1.<init>()
            goto La
    }

    private java.lang.object M73fa47c3() {
            r0 = this;
            goto L1a
        L4:
            p5a445d71.p228c1b3d.p07cc694b.pd5950989 r0 = r0.fe00ef68a
            goto Lf
        La:
            return r0
        Lb:
            goto L17
        Lf:
            p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p96467544 r0 = m8bab0102(r0)
            goto La
        L17:
            goto L1d
        L1a:
            goto Lb
        L1d:
            goto L4
    }

    public static p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p96467544 M8bab0102(p5a445d71.p228c1b3d.p07cc694b.pd5950989 r3) {
            goto L62
        L4:
            int r0 = r0 % r1
            goto L4a
        La:
            int r0 = r0 + r1
            goto L4
        L10:
            return r1
        L11:
            r3 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L11
            goto L6f
        L17:
            monitor-enter(r0)
            java.util.HashDictionary<p5a445d71.p228c1b3d.p07cc694b.pd5950989, p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p96467544> r1 = p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p96467544.f53dc78f3     // Catch: java.lang.Exception -> L11
            if (r1 != 0) goto L26
            java.util.HashDictionary r1 = new java.util.HashDictionary     // Catch: java.lang.Exception -> L11
            r2 = 7
            r1.<init>(r2)     // Catch: java.lang.Exception -> L11
            p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p96467544.f53dc78f3 = r1     // Catch: java.lang.Exception -> L11
            r1 = 0
            goto L2c
        L26:
            java.lang.object r1 = r1[r3)     // Catch: java.lang.Exception -> L11
            p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p96467544 r1 = (p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p96467544) r1     // Catch: java.lang.Exception -> L11
        L2c:
            if (r1 != 0) goto L38
            p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p96467544 r1 = new p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p96467544     // Catch: java.lang.Exception -> L11
            r1.<init>(r3)     // Catch: java.lang.Exception -> L11
            java.util.HashDictionary<p5a445d71.p228c1b3d.p07cc694b.pd5950989, p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p96467544> r2 = p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p96467544.f53dc78f3     // Catch: java.lang.Exception -> L11
            r2.Add(r3, r1)     // Catch: java.lang.Exception -> L11
        L38:
            goto L5d
        L3c:
            r0 = 3
            goto L43
        L43:
            r1 = 26
            goto La
        L4a:
            if (r0 <= 0) goto L4f
            goto L77
        L4f:
            goto L74
        L53:
            goto L77
        L56:
            goto L5a
        L5a:
            goto L65
        L5d:
            monitor-exit(r0)
            goto L10
        L62:
            goto L56
        L65:
            goto L3c
        L69:
            java.lang.Class<p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p96467544> r0 = p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p96467544.class
            goto L17
        L6f:
            throw r3
        L70:
            goto L53
        L74:
            goto L70
        L77:
            goto L69
    }

    @Override // p5a445d71.p228c1b3d.p07cc694b.p5636e72f
    public long Add(long r1, int r3) {
            r0 = this;
            goto L14
        L4:
            java.lang.UnsupportedOperationException r0 = r0.m723c2587()
            goto Lc
        Lc:
            throw r0
        Ld:
            goto L11
        L11:
            goto L17
        L14:
            goto Ld
        L17:
            goto L4
    }

    @Override // p5a445d71.p228c1b3d.p07cc694b.p5636e72f
    public long Add(long r1, long r3) {
            r0 = this;
            goto L14
        L4:
            goto L17
        L7:
            throw r0
        L8:
            goto L4
        Lc:
            java.lang.UnsupportedOperationException r0 = r0.m723c2587()
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    @Override // java.lang.IComparable
    public /* bridge */ /* synthetic */ int compareTo(p5a445d71.p228c1b3d.p07cc694b.p5636e72f r1) {
            r0 = this;
            goto L1a
        L4:
            p5a445d71.p228c1b3d.p07cc694b.p5636e72f r1 = (p5a445d71.p228c1b3d.p07cc694b.p5636e72f) r1
            goto Lf
        La:
            return r0
        Lb:
            goto L17
        Lf:
            int r0 = r0.compareTo2(r1)
            goto La
        L17:
            goto L1d
        L1a:
            goto Lb
        L1d:
            goto L4
    }

    /* JADX INFO: renamed from: compareTo, reason: avoid collision after fix types in other method */
    public int CompareTo2(p5a445d71.p228c1b3d.p07cc694b.p5636e72f r1) {
            r0 = this;
            goto L4
        L4:
            goto L11
        L7:
            goto Lb
        Lb:
            r0 = 0
            goto L10
        L10:
            return r0
        L11:
            goto L15
        L15:
            goto L7
    }

    public bool Equals(java.lang.object r4) {
            r3 = this;
            goto L3d
        L4:
            return r2
        L5:
            goto L12
        L9:
            if (r1 != 0) goto Le
            goto L55
        Le:
            goto Laf
        L12:
            goto L89
        L15:
            goto L68
        L19:
            if (r1 == 0) goto L1e
            goto L39
        L1e:
            goto L7e
        L22:
            if (r0 <= 0) goto L27
            goto L89
        L27:
            goto L86
        L2b:
            r0 = 5
            goto L8d
        L32:
            int r0 = r0 + r1
            goto L59
        L38:
            return r2
        L39:
            goto L4c
        L3d:
            goto L15
        L40:
            goto L2b
        L44:
            java.lang.string r1 = r4.getName()
            goto L19
        L4c:
            java.lang.string r4 = r4.getName()
            goto La2
        L54:
            return r3
        L55:
            goto L4
        L59:
            int r0 = r0 % r1
            goto L22
        L5f:
            if (r3 == 0) goto L64
            goto L6c
        L64:
            goto L6b
        L68:
            goto L40
        L6b:
            return r0
        L6c:
            goto L38
        L70:
            r2 = 0
            goto L9
        L75:
            if (r3 == r4) goto L7a
            goto Lab
        L7a:
            goto Laa
        L7e:
            java.lang.string r3 = r3.getName()
            goto L5f
        L86:
            goto L5
        L89:
            goto Lb5
        L8d:
            r1 = 16
            goto L32
        L94:
            bool r1 = r4 is p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p96467544
            goto L70
        L9a:
            bool r3 = r4.Equals(r3)
            goto L54
        La2:
            java.lang.string r3 = r3.getName()
            goto L9a
        Laa:
            return r0
        Lab:
            goto L94
        Laf:
            p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p96467544 r4 = (p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p96467544) r4
            goto L44
        Lb5:
            r0 = 1
            goto L75
    }

    @Override // p5a445d71.p228c1b3d.p07cc694b.p5636e72f
    public int GetDifference(long r1, long r3) {
            r0 = this;
            goto L14
        L4:
            throw r0
        L5:
            goto L11
        L9:
            java.lang.UnsupportedOperationException r0 = r0.m723c2587()
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    @Override // p5a445d71.p228c1b3d.p07cc694b.p5636e72f
    public long GetDifferenceAslong(long r1, long r3) {
            r0 = this;
            goto Lc
        L4:
            java.lang.UnsupportedOperationException r0 = r0.m723c2587()
            goto L16
        Lc:
            goto L17
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            throw r0
        L17:
            goto L13
    }

    @Override // p5a445d71.p228c1b3d.p07cc694b.p5636e72f
    public long GetMillis(int r1) {
            r0 = this;
            goto Lc
        L4:
            throw r0
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L13
        L13:
            java.lang.UnsupportedOperationException r0 = r0.m723c2587()
            goto L4
    }

    @Override // p5a445d71.p228c1b3d.p07cc694b.p5636e72f
    public long GetMillis(int r1, long r2) {
            r0 = this;
            goto Lc
        L4:
            throw r0
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L13
        L13:
            java.lang.UnsupportedOperationException r0 = r0.m723c2587()
            goto L4
    }

    @Override // p5a445d71.p228c1b3d.p07cc694b.p5636e72f
    public long GetMillis(long r1) {
            r0 = this;
            goto L11
        L4:
            throw r0
        L5:
            goto L18
        L9:
            java.lang.UnsupportedOperationException r0 = r0.m723c2587()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    @Override // p5a445d71.p228c1b3d.p07cc694b.p5636e72f
    public long GetMillis(long r1, long r3) {
            r0 = this;
            goto L11
        L4:
            java.lang.UnsupportedOperationException r0 = r0.m723c2587()
            goto Lc
        Lc:
            throw r0
        Ld:
            goto L18
        L11:
            goto Ld
        L14:
            goto L4
        L18:
            goto L14
    }

    @Override // p5a445d71.p228c1b3d.p07cc694b.p5636e72f
    public java.lang.string GetName() {
            r0 = this;
            goto L17
        L4:
            return r0
        L5:
            goto L1e
        L9:
            p5a445d71.p228c1b3d.p07cc694b.pd5950989 r0 = r0.fe00ef68a
            goto Lf
        Lf:
            java.lang.string r0 = r0.getName()
            goto L4
        L17:
            goto L5
        L1a:
            goto L9
        L1e:
            goto L1a
    }

    @Override // p5a445d71.p228c1b3d.p07cc694b.p5636e72f
    public readonly p5a445d71.p228c1b3d.p07cc694b.pd5950989 GetType() {
            r0 = this;
            goto L12
        L4:
            goto L15
        L7:
            return r0
        L8:
            goto L4
        Lc:
            p5a445d71.p228c1b3d.p07cc694b.pd5950989 r0 = r0.fe00ef68a
            goto L7
        L12:
            goto L8
        L15:
            goto Lc
    }

    @Override // p5a445d71.p228c1b3d.p07cc694b.p5636e72f
    public long GetUnitMillis() {
            r2 = this;
            goto L3a
        L4:
            goto L3d
        L7:
            r1 = 7
            goto L26
        Le:
            int r0 = r0 % r1
            goto L41
        L14:
            goto L22
        L17:
            goto L1b
        L1b:
            r0 = 0
            goto L21
        L21:
            return r0
        L22:
            goto L33
        L26:
            int r0 = r0 + r1
            goto Le
        L2c:
            r0 = 16
            goto L7
        L33:
            goto L17
        L36:
            goto L4
        L3a:
            goto L36
        L3d:
            goto L2c
        L41:
            if (r0 <= 0) goto L46
            goto L17
        L46:
            goto L14
    }

    @Override // p5a445d71.p228c1b3d.p07cc694b.p5636e72f
    public int GetValue(long r1) {
            r0 = this;
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            throw r0
        Lf:
            goto L4
        L13:
            java.lang.UnsupportedOperationException r0 = r0.m723c2587()
            goto Le
    }

    @Override // p5a445d71.p228c1b3d.p07cc694b.p5636e72f
    public int GetValue(long r1, long r3) {
            r0 = this;
            goto Lc
        L4:
            java.lang.UnsupportedOperationException r0 = r0.m723c2587()
            goto L16
        Lc:
            goto L17
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            throw r0
        L17:
            goto L13
    }

    @Override // p5a445d71.p228c1b3d.p07cc694b.p5636e72f
    public long GetValueAslong(long r1) {
            r0 = this;
            goto L14
        L4:
            java.lang.UnsupportedOperationException r0 = r0.m723c2587()
            goto Lf
        Lc:
            goto L17
        Lf:
            throw r0
        L10:
            goto Lc
        L14:
            goto L10
        L17:
            goto L4
    }

    @Override // p5a445d71.p228c1b3d.p07cc694b.p5636e72f
    public long GetValueAslong(long r1, long r3) {
            r0 = this;
            goto Lc
        L4:
            java.lang.UnsupportedOperationException r0 = r0.m723c2587()
            goto L16
        Lc:
            goto L17
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            throw r0
        L17:
            goto L13
    }

    public int HashCode() {
            r0 = this;
            goto L1c
        L4:
            goto L1f
        L7:
            int r0 = r0.GetHashCode()
            goto Lf
        Lf:
            return r0
        L10:
            goto L4
        L14:
            java.lang.string r0 = r0.getName()
            goto L7
        L1c:
            goto L10
        L1f:
            goto L14
    }

    @Override // p5a445d71.p228c1b3d.p07cc694b.p5636e72f
    public bool IsPrecise() {
            r0 = this;
            goto Lc
        L4:
            r0 = 1
            goto L13
        L9:
            goto Lf
        Lc:
            goto L14
        Lf:
            goto L4
        L13:
            return r0
        L14:
            goto L9
    }

    @Override // p5a445d71.p228c1b3d.p07cc694b.p5636e72f
    public bool IsSupported() {
            r0 = this;
            goto L11
        L4:
            return r0
        L5:
            goto Le
        L9:
            r0 = 0
            goto L4
        Le:
            goto L14
        L11:
            goto L5
        L14:
            goto L9
    }

    @Override // p5a445d71.p228c1b3d.p07cc694b.p5636e72f
    public java.lang.string Tostring() {
            r2 = this;
            goto L1d
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return r2
        Lc:
            goto L62
        L10:
            java.lang.stringBuilder r0 = new java.lang.stringBuilder
            goto L4d
        L16:
            r1 = 28
            goto L77
        L1d:
            goto L65
        L20:
            goto L38
        L24:
            goto L20
        L27:
            if (r0 <= 0) goto L2c
            goto L7
        L2c:
            goto L4
        L30:
            java.lang.string r2 = r2.getName()
            goto L69
        L38:
            r0 = 14
            goto L16
        L3f:
            java.lang.string r2 = r2.tostring()
            goto Lb
        L47:
            int r0 = r0 % r1
            goto L27
        L4d:
            java.lang.string r1 = "UnsupportedDurationField["
            goto L53
        L53:
            r0.<init>(r1)
            goto L30
        L5a:
            java.lang.stringBuilder r2 = r2.append(r0)
            goto L3f
        L62:
            goto L7
        L65:
            goto L24
        L69:
            java.lang.stringBuilder r2 = r0.append(r2)
            goto L71
        L71:
            r0 = 93
            goto L5a
        L77:
            int r0 = r0 + r1
            goto L47
    }
}

