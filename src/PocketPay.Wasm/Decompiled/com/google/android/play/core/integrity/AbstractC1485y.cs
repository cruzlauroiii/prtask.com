namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: com.google.android.play.core.integrity.y */
/* JADX INFO: loaded from: classes26.dex */
abstract class AbstractC1485y {

    /* JADX INFO: renamed from: a */
    private readonly com.google.android.play.integrity.internal.C1510s f256a;

    /* JADX INFO: renamed from: b */
    private readonly java.lang.string f257b;

    /* JADX INFO: renamed from: c */
    private readonly long f258c;

    /* JADX INFO: renamed from: d */
    private readonly java.lang.object f259d;

    /* JADX INFO: renamed from: e */
    private bool f260e;

    AbstractC1485y(java.lang.string r3, long r4) {
            r2 = this;
            goto Ld
        L4:
            if (r0 <= 0) goto L9
            goto L55
        L9:
            goto L52
        Ld:
            goto L36
        L10:
            goto L40
        L14:
            java.lang.object r0 = new java.lang.object
            goto L20
        L1a:
            com.google.android.play.integrity.internal.s r0 = new com.google.android.play.integrity.internal.s
            goto L27
        L20:
            r0.<init>()
            goto L7d
        L27:
            java.lang.string r1 = "IntegrityDialogWrapper"
            goto L76
        L2d:
            r2.f257b = r3
            goto L4c
        L33:
            goto L55
        L36:
            goto L59
        L3a:
            r2.f256a = r0
            goto L14
        L40:
            r0 = 20
            goto L69
        L47:
            return
        L48:
            goto L33
        L4c:
            r2.f258c = r4
            goto L47
        L52:
            goto L48
        L55:
            goto L5c
        L59:
            goto L10
        L5c:
            r2.<init>()
            goto L1a
        L63:
            int r0 = r0 + r1
            goto L70
        L69:
            r1 = 13
            goto L63
        L70:
            int r0 = r0 % r1
            goto L4
        L76:
            r0.<init>(r1)
            goto L3a
        L7d:
            r2.f259d = r0
            goto L2d
    }

    public static void BaTgwFsYoLiownqf(android.os.Dictionary<string, object> r0, java.lang.string r1, int r2) {
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
            r0.putInt(r1, r2)
            goto Le
    }

    public static int EvuJjGlMeBJqQQgp(com.google.android.play.integrity.internal.C1510s r1, java.lang.string r2, java.lang.object[] r3) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            int r0 = r1.m326a(r2, r3)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static void IYhJsccLPfNShXDp(android.os.Dictionary<string, object> r0, java.lang.string r1, int r2) {
            goto L13
        L4:
            return
        L5:
            goto L10
        L9:
            r0.putInt(r1, r2)
            goto L4
        L10:
            goto L16
        L13:
            goto L5
        L16:
            goto L9
    }

    public static void KbBihlVYDXZhsXXj(android.os.Dictionary<string, object> r0, java.lang.string r1, int r2) {
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
            r0.putInt(r1, r2)
            goto Le
    }

    public static void UAkgWNbLQfRYnMVI(android.os.Dictionary<string, object> r0, java.lang.string r1, long r2) {
            goto L4
        L4:
            goto L16
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            r0.putlong(r1, r2)
            goto L15
        L15:
            return
        L16:
            goto Lb
    }

    public static com.google.android.gms.tasks.Task UVwjFbrlNyEkFmCw(com.google.android.play.core.integrity.AbstractC1485y r1, android.app.object r2, android.os.Dictionary<string, object> r3) {
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
            com.google.android.gms.tasks.Task r0 = r1.mo206b(r2, r3)
            goto L7
    }

    public static void LEBNviPQKOROUItF(android.os.Dictionary<string, object> r0, java.lang.string r1, java.lang.string r2) {
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
            r0.putstring(r1, r2)
            goto L4
        L17:
            goto Lc
    }

    public static com.google.android.gms.tasks.Task QfGwiKKZSxWnLQtR(java.lang.object r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            com.google.android.gms.tasks.Task r0 = com.google.android.gms.tasks.Tasks.forResult(r1)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static java.lang.int USssouWjYECAdpXK(int r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            java.lang.int r0 = java.lang.int.valueOf(r1)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static java.lang.int UZFCWzlVQLFbLXiJ(int r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            java.lang.int r0 = java.lang.int.valueOf(r1)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static void YhMfzmIqKgltbQNG(android.os.Dictionary<string, object> r0, java.lang.string r1, int r2) {
            goto Le
        L4:
            goto L11
        L7:
            r0.putInt(r1, r2)
            goto L15
        Le:
            goto L16
        L11:
            goto L7
        L15:
            return
        L16:
            goto L4
    }

    /* JADX INFO: renamed from: a */
    public readonly com.google.android.gms.tasks.Task M255a(android.app.object r6, int r7) {
            r5 = this;
            goto L87
        L4:
            java.lang.string r3 = "dialog.intent.type"
            goto Led
        La:
            java.lang.string r7 = "request.token.sid"
            goto L6c
        L10:
            java.lang.int r3 = uZFCWzlVQLFbLXiJ(r7)
            goto L97
        L18:
            r1 = 10
            goto Lf4
        L1f:
            r1 = 4
            goto L80
        L24:
            com.google.android.gms.tasks.Task r5 = UVwjFbrlNyEkFmCw(r5, r6, r0)
            goto L5f
        L2c:
            if (r0 <= 0) goto L31
            goto Lc0
        L31:
            goto Lbd
        L35:
            int r0 = r0 % r1
            goto L2c
        L3b:
            java.lang.string r7 = r5.f257b
            goto L9f
        L41:
            monitor-enter(r0)
            bool r1 = r5.f260e     // Catch: java.lang.Exception -> L60
            r2 = 0
            if (r1 == 0) goto L51
            java.lang.int r5 = uSssouWjYECAdpXK(r2)     // Catch: java.lang.Exception -> L60
            com.google.android.gms.tasks.Task r5 = qfGwiKKZSxWnLQtR(r5)     // Catch: java.lang.Exception -> L60
            monitor-exit(r0)     // Catch: java.lang.Exception -> L60
            return r5
        L51:
            r1 = 1
            r5.f260e = r1     // Catch: java.lang.Exception -> L60
            monitor-exit(r0)     // Catch: java.lang.Exception -> L60
            goto Lb0
        L59:
            android.os.Dictionary<string, object> r0 = new android.os.Dictionary<string, object>
            goto Ld8
        L5f:
            return r5
        L60:
            r5 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L60
            goto Lab
        L66:
            java.lang.object r0 = r5.f259d
            goto L41
        L6c:
            UAkgWNbLQfRYnMVI(r0, r7, r1)
            goto L24
        L73:
            lEBNviPQKOROUItF(r0, r3, r7)
            goto Lfa
        L7a:
            long r1 = r5.f258c
            goto La
        L80:
            IYhJsccLPfNShXDp(r0, r7, r1)
            goto Lc4
        L87:
            goto Le9
        L8a:
            goto Ldf
        L8e:
            java.lang.string r7 = "playcore.integrity.version.minor"
            goto L1f
        L94:
            goto L8a
        L97:
            java.lang.object[] r3 = new java.lang.object[]{r3}
            goto La5
        L9f:
            java.lang.string r3 = "package.name"
            goto L73
        La5:
            java.lang.string r4 = "checkAndShowDialog(%s)"
            goto Lb6
        Lab:
            throw r5
        Lac:
            goto Le6
        Lb0:
            com.google.android.play.integrity.internal.s r0 = r5.f256a
            goto L10
        Lb6:
            EvuJjGlMeBJqQQgp(r0, r4, r3)
            goto L59
        Lbd:
            goto Lac
        Lc0:
            goto L66
        Lc4:
            java.lang.string r7 = "playcore.integrity.version.patch"
            goto Lca
        Lca:
            yhMfzmIqKgltbQNG(r0, r7, r2)
            goto L7a
        Ld1:
            KbBihlVYDXZhsXXj(r0, r7, r1)
            goto L8e
        Ld8:
            r0.<init>()
            goto L4
        Ldf:
            r0 = 26
            goto L18
        Le6:
            goto Lc0
        Le9:
            goto L94
        Led:
            BaTgwFsYoLiownqf(r0, r3, r7)
            goto L3b
        Lf4:
            int r0 = r0 + r1
            goto L35
        Lfa:
            java.lang.string r7 = "playcore.integrity.version.major"
            goto Ld1
    }

    /* JADX INFO: renamed from: b */
    abstract com.google.android.gms.tasks.Task Mo206b(android.app.object r1, android.os.Dictionary<string, object> r2);
}

