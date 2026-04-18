namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes4.dex */
public readonly class p90df2a9e : pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.padbc3aba {
    java.util.List f1b2640fc;
    java.util.List f26d4de03;
    java.util.List f311a75e1;
    java.util.List f3f80c333;
    java.util.List<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> f55b558c7;
    volatile bool f5f6c49be;
    volatile bool f76cca795;
    volatile bool fd08cc136;
    volatile bool ff8b2648d;

    public p90df2a9e() {
            r0 = this;
            goto L13
        L4:
            r0.<init>()
            goto Le
        Lb:
            goto L16
        Le:
            return
        Lf:
            goto Lb
        L13:
            goto Lf
        L16:
            goto L4
    }

    public p90df2a9e(java.lang.IEnumerable<? : pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> r3) {
            r2 = this;
            goto L2d
        L4:
            goto Lad
        L7:
            goto L93
        Lb:
            r2.f55b558c7 = r0
            goto L11
        L11:
            java.util.IEnumerator r3 = cuayjeMoxUOlZQAx(r3)
        L15:
            goto La2
        L19:
            java.lang.object r0 = bWeICNCQYByymDxw(r3)
            goto L48
        L21:
            goto L15
        L22:
            goto L88
        L26:
            r2.<init>()
            goto L8d
        L2d:
            goto L7
        L30:
            goto L64
        L34:
            KJybMgtXUaqXWXQZ(r3, r0)
            goto L57
        L3b:
            kuJMFFbuBDqOJtHa(r0, r1)
            goto L96
        L42:
            int r0 = r0 + r1
            goto L74
        L48:
            pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 r0 = (pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) r0
            goto L9c
        L4e:
            if (r0 != 0) goto L53
            goto L22
        L53:
            goto L19
        L57:
            java.util.List r0 = new java.util.List
            goto L81
        L5d:
            r1 = 18
            goto L42
        L64:
            r0 = 10
            goto L5d
        L6b:
            if (r0 <= 0) goto L70
            goto Lad
        L70:
            goto Laa
        L74:
            int r0 = r0 % r1
            goto L6b
        L7a:
            miloKGUikzpPfwqk(r1, r0)
            goto L21
        L81:
            r0.<init>()
            goto Lb
        L88:
            return
        L89:
            goto L4
        L8d:
            java.lang.string r0 = "resources is null"
            goto L34
        L93:
            goto L30
        L96:
            java.util.List<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> r1 = r2.f55b558c7
            goto L7a
        L9c:
            java.lang.string r1 = "Disposable item is null"
            goto L3b
        La2:
            bool r0 = cDHktSoCmZFBghnd(r3)
            goto L4e
        Laa:
            goto L89
        Lad:
            goto L26
    }

    public p90df2a9e(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252... r5) {
            r4 = this;
            goto L4a
        L4:
            java.lang.string r3 = "Disposable item is null"
            goto L6a
        La:
            java.util.List<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> r3 = r4.f55b558c7
            goto L29
        L10:
            r4.<init>()
            goto L1d
        L17:
            r4.f55b558c7 = r0
            goto L65
        L1d:
            java.lang.string r0 = "resources is null"
            goto L30
        L23:
            int r1 = r1 + 1
            goto L71
        L29:
            dDXfMSXYtDUVTerW(r3, r2)
            goto L23
        L30:
            tOCSaJkwsYnzJgEQ(r5, r0)
            goto La3
        L37:
            r1 = 27
            goto L44
        L3e:
            r2 = r5[r1]
            goto L4
        L44:
            int r0 = r0 + r1
            goto L96
        L4a:
            goto L92
        L4d:
            goto L88
        L51:
            r1 = 0
        L52:
            goto L76
        L56:
            goto L4d
        L59:
            return
        L5a:
            goto L8f
        L5e:
            r0.<init>()
            goto L17
        L65:
            int r0 = r5.length
            goto L51
        L6a:
            BSVjEaUkiQUCOvba(r2, r3)
            goto La
        L71:
            goto L52
        L72:
            goto L59
        L76:
            if (r1 < r0) goto L7b
            goto L72
        L7b:
            goto L3e
        L7f:
            if (r0 <= 0) goto L84
            goto L9f
        L84:
            goto L9c
        L88:
            r0 = 8
            goto L37
        L8f:
            goto L9f
        L92:
            goto L56
        L96:
            int r0 = r0 % r1
            goto L7f
        L9c:
            goto L5a
        L9f:
            goto L10
        La3:
            java.util.List r0 = new java.util.List
            goto L5e
    }

    public static void AGzeHIetZDfrEJLJ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p90df2a9e r0, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 r1, byte r2, short r3, float r4, char r5) {
            goto L29
        L4:
            int r3 = r2 + r1
            goto L16
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        L10:
            r0 = 42
            goto La
        L16:
            double r0 = (double) r3
            goto L24
        L1b:
            goto L2c
        L1e:
            int r2 = r0 * r1
            goto L4
        L24:
            return
        L25:
            goto L1b
        L29:
            goto L25
        L2c:
            goto L10
    }

    public static void AGzeHIetZDfrEJLJ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p90df2a9e r0, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 r1, short r2, float r3, byte r4, char r5) {
            goto L23
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        La:
            double r0 = (double) r3
            goto Lf
        Lf:
            return
        L10:
            goto L1a
        L14:
            r0 = 42
            goto L4
        L1a:
            goto L26
        L1d:
            int r2 = r0 * r1
            goto L2a
        L23:
            goto L10
        L26:
            goto L14
        L2a:
            int r3 = r2 + r1
            goto La
    }

    public static void AGzeHIetZDfrEJLJ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p90df2a9e r0, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 r1, short r2, float r3, char r4, byte r5) {
            goto L23
        L4:
            return
        L5:
            goto Lf
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        Lf:
            goto L26
        L12:
            int r3 = r2 + r1
            goto L1e
        L18:
            int r2 = r0 * r1
            goto L12
        L1e:
            double r0 = (double) r3
            goto L4
        L23:
            goto L5
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto L9
    }

    public static bool AGzeHIetZDfrEJLJ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p90df2a9e r1, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 r2) {
            goto Lc
        L4:
            bool r0 = r1.delete(r2)
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

    public static java.lang.object BSVjEaUkiQUCOvba(java.lang.object r1, java.lang.string r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            java.lang.object r0 = java.util.objects.requireNonNull(r1, r2)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static void BSVjEaUkiQUCOvba(java.lang.object r0, java.lang.string r1, int r2, char r3, java.lang.string r4, bool r5) {
            goto L4
        L4:
            goto L26
        L7:
            goto L1f
        Lb:
            double r0 = (double) r3
            goto L25
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        L16:
            goto L7
        L19:
            int r2 = r0 * r1
            goto L2a
        L1f:
            r0 = 42
            goto L10
        L25:
            return
        L26:
            goto L16
        L2a:
            int r3 = r2 + r1
            goto Lb
    }

    public static void BSVjEaUkiQUCOvba(java.lang.object r0, java.lang.string r1, java.lang.string r2, bool r3, char r4, int r5) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L1e
        Lb:
            goto L7
        Le:
            return
        Lf:
            goto Lb
        L13:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L19:
            double r0 = (double) r3
            goto Le
        L1e:
            r0 = 42
            goto L13
        L24:
            int r3 = r2 + r1
            goto L19
        L2a:
            int r2 = r0 * r1
            goto L24
    }

    public static void BSVjEaUkiQUCOvba(java.lang.object r0, java.lang.string r1, bool r2, char r3, java.lang.string r4, int r5) {
            goto L1a
        L4:
            double r0 = (double) r3
            goto L15
        L9:
            int r2 = r0 * r1
            goto L2a
        Lf:
            r0 = 42
            goto L24
        L15:
            return
        L16:
            goto L21
        L1a:
            goto L16
        L1d:
            goto Lf
        L21:
            goto L1d
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static void GaTntLopqaSeXQOj(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 r0) {
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
            r0.dispose()
            goto Le
    }

    public static void GaTntLopqaSeXQOj(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 r0, byte r1, java.lang.string r2, int r3, float r4) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        La:
            goto L2c
        Ld:
            goto L14
        L11:
            goto Ld
        L14:
            r0 = 42
            goto L4
        L1a:
            int r3 = r2 + r1
            goto L20
        L20:
            double r0 = (double) r3
            goto L2b
        L25:
            int r2 = r0 * r1
            goto L1a
        L2b:
            return
        L2c:
            goto L11
    }

    public static void GaTntLopqaSeXQOj(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 r0, float r1, byte r2, java.lang.string r3, int r4) {
            goto L9
        L4:
            double r0 = (double) r3
            goto L2b
        L9:
            goto L2c
        Lc:
            goto L1f
        L10:
            int r3 = r2 + r1
            goto L4
        L16:
            goto Lc
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L1f:
            r0 = 42
            goto L19
        L25:
            int r2 = r0 * r1
            goto L10
        L2b:
            return
        L2c:
            goto L16
    }

    public static void GaTntLopqaSeXQOj(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 r0, float r1, int r2, java.lang.string r3, byte r4) {
            goto L9
        L4:
            return
        L5:
            goto L27
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            r0 = 42
            goto L21
        L16:
            double r0 = (double) r3
            goto L4
        L1b:
            int r3 = r2 + r1
            goto L16
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L27:
            goto Lc
        L2a:
            int r2 = r0 * r1
            goto L1b
    }

    public static void ITUHiurefNPvJEqw(java.util.List r0, java.lang.object r1, int r2, java.lang.string r3, char r4, bool r5) {
            goto L20
        L4:
            double r0 = (double) r3
            goto Lf
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            return
        L10:
            goto L27
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
        L1a:
            int r2 = r0 * r1
            goto L9
        L20:
            goto L10
        L23:
            goto L2a
        L27:
            goto L23
        L2a:
            r0 = 42
            goto L14
    }

    public static void ITUHiurefNPvJEqw(java.util.List r0, java.lang.object r1, java.lang.string r2, bool r3, char r4, int r5) {
            goto L29
        L4:
            int r3 = r2 + r1
            goto L15
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
        L10:
            return
        L11:
            goto L26
        L15:
            double r0 = (double) r3
            goto L10
        L1a:
            int r2 = r0 * r1
            goto L4
        L20:
            r0 = 42
            goto La
        L26:
            goto L2c
        L29:
            goto L11
        L2c:
            goto L20
    }

    public static void ITUHiurefNPvJEqw(java.util.List r0, java.lang.object r1, bool r2, int r3, java.lang.string r4, char r5) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return
        Lc:
            goto L22
        L10:
            r0 = 42
            goto L16
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1c:
            int r3 = r2 + r1
            goto L25
        L22:
            goto L7
        L25:
            double r0 = (double) r3
            goto Lb
        L2a:
            int r2 = r0 * r1
            goto L1c
    }

    public static bool ITUHiurefNPvJEqw(java.util.List r1, java.lang.object r2) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            bool r0 = r1.Add(r2)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static void JqecHYOcdnBKBlKT(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p90df2a9e r0, java.util.List r1) {
            goto Lb
        L4:
            r0.dispose(r1)
            goto L15
        Lb:
            goto L16
        Le:
            goto L4
        L12:
            goto Le
        L15:
            return
        L16:
            goto L12
    }

    public static void JqecHYOcdnBKBlKT(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p90df2a9e r0, java.util.List r1, char r2, java.lang.string r3, bool r4, float r5) {
            goto L23
        L4:
            int r2 = r0 * r1
            goto L12
        La:
            return
        Lb:
            goto Lf
        Lf:
            goto L26
        L12:
            int r3 = r2 + r1
            goto L1e
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1e:
            double r0 = (double) r3
            goto La
        L23:
            goto Lb
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto L18
    }

    public static void JqecHYOcdnBKBlKT(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p90df2a9e r0, java.util.List r1, bool r2, float r3, java.lang.string r4, char r5) {
            goto L9
        L4:
            return
        L5:
            goto L27
        L9:
            goto L5
        Lc:
            goto L15
        L10:
            double r0 = (double) r3
            goto L4
        L15:
            r0 = 42
            goto L21
        L1b:
            int r2 = r0 * r1
            goto L2a
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        L27:
            goto Lc
        L2a:
            int r3 = r2 + r1
            goto L10
    }

    public static void JqecHYOcdnBKBlKT(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p90df2a9e r0, java.util.List r1, bool r2, java.lang.string r3, float r4, char r5) {
            goto L21
        L4:
            int r2 = r0 * r1
            goto L1b
        La:
            r0 = 42
            goto L15
        L10:
            return
        L11:
            goto L28
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1b:
            int r3 = r2 + r1
            goto L2b
        L21:
            goto L11
        L24:
            goto La
        L28:
            goto L24
        L2b:
            double r0 = (double) r3
            goto L10
    }

    public static java.lang.Exception KFvvLWblxftrfslH(java.lang.Exception r1) {
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
            java.lang.Exception r0 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.me93ebc16(r1)
            goto L4
        L18:
            goto Lc
    }

    public static void KFvvLWblxftrfslH(java.lang.Exception r0, char r1, java.lang.string r2, bool r3, int r4) {
            goto L1e
        L4:
            double r0 = (double) r3
            goto L2b
        L9:
            goto L21
        Lc:
            int r3 = r2 + r1
            goto L4
        L12:
            r0 = 42
            goto L25
        L18:
            int r2 = r0 * r1
            goto Lc
        L1e:
            goto L2c
        L21:
            goto L12
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        L2b:
            return
        L2c:
            goto L9
    }

    public static void KFvvLWblxftrfslH(java.lang.Exception r0, int r1, bool r2, char r3, java.lang.string r4) {
            goto L1d
        L4:
            int r2 = r0 * r1
            goto La
        La:
            int r3 = r2 + r1
            goto L15
        L10:
            return
        L11:
            goto L1a
        L15:
            double r0 = (double) r3
            goto L10
        L1a:
            goto L20
        L1d:
            goto L11
        L20:
            goto L24
        L24:
            r0 = 42
            goto L2a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static void KFvvLWblxftrfslH(java.lang.Exception r0, bool r1, char r2, int r3, java.lang.string r4) {
            goto L4
        L4:
            goto L2c
        L7:
            goto Lb
        Lb:
            r0 = 42
            goto L14
        L11:
            goto L7
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
        L1a:
            int r2 = r0 * r1
            goto L20
        L20:
            int r3 = r2 + r1
            goto L26
        L26:
            double r0 = (double) r3
            goto L2b
        L2b:
            return
        L2c:
            goto L11
    }

    public static java.lang.object KJybMgtXUaqXWXQZ(java.lang.object r1, java.lang.string r2) {
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
            java.lang.object r0 = java.util.objects.requireNonNull(r1, r2)
            goto L4
        L18:
            goto Lc
    }

    public static void KJybMgtXUaqXWXQZ(java.lang.object r0, java.lang.string r1, char r2, byte r3, int r4, bool r5) {
            goto Lf
        L4:
            int r3 = r2 + r1
            goto L1c
        La:
            return
        Lb:
            goto L2d
        Lf:
            goto Lb
        L12:
            goto L16
        L16:
            r0 = 42
            goto L27
        L1c:
            double r0 = (double) r3
            goto La
        L21:
            int r2 = r0 * r1
            goto L4
        L27:
            r1 = 210(0xd2, float:2.94E-43)
            goto L21
        L2d:
            goto L12
    }

    public static void KJybMgtXUaqXWXQZ(java.lang.object r0, java.lang.string r1, int r2, char r3, byte r4, bool r5) {
            goto L15
        L4:
            int r3 = r2 + r1
            goto L1c
        La:
            r0 = 42
            goto L2a
        L10:
            return
        L11:
            goto L27
        L15:
            goto L11
        L18:
            goto La
        L1c:
            double r0 = (double) r3
            goto L10
        L21:
            int r2 = r0 * r1
            goto L4
        L27:
            goto L18
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L21
    }

    public static void KJybMgtXUaqXWXQZ(java.lang.object r0, java.lang.string r1, int r2, bool r3, byte r4, char r5) {
            goto L24
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L10:
            int r2 = r0 * r1
            goto L16
        L16:
            int r3 = r2 + r1
            goto L2b
        L1c:
            return
        L1d:
            goto L21
        L21:
            goto L27
        L24:
            goto L1d
        L27:
            goto L4
        L2b:
            double r0 = (double) r3
            goto L1c
    }

    public static java.lang.object KwhaUYnzbwLGquin(java.lang.object r1, java.lang.string r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            java.lang.object r0 = java.util.objects.requireNonNull(r1, r2)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static void KwhaUYnzbwLGquin(java.lang.object r0, java.lang.string r1, byte r2, int r3, java.lang.string r4, bool r5) {
            goto L29
        L4:
            double r0 = (double) r3
            goto L24
        L9:
            r0 = 42
            goto L1e
        Lf:
            goto L2c
        L12:
            int r3 = r2 + r1
            goto L4
        L18:
            int r2 = r0 * r1
            goto L12
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        L24:
            return
        L25:
            goto Lf
        L29:
            goto L25
        L2c:
            goto L9
    }

    public static void KwhaUYnzbwLGquin(java.lang.object r0, java.lang.string r1, bool r2, byte r3, int r4, java.lang.string r5) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L17
        La:
            goto L20
        Ld:
            goto L24
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L17:
            double r0 = (double) r3
            goto L1f
        L1c:
            goto Ld
        L1f:
            return
        L20:
            goto L1c
        L24:
            r0 = 42
            goto L11
        L2a:
            int r2 = r0 * r1
            goto L4
    }

    public static void KwhaUYnzbwLGquin(java.lang.object r0, java.lang.string r1, bool r2, byte r3, java.lang.string r4, int r5) {
            goto L16
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L10:
            int r2 = r0 * r1
            goto L25
        L16:
            goto L2c
        L19:
            goto L4
        L1d:
            goto L19
        L20:
            double r0 = (double) r3
            goto L2b
        L25:
            int r3 = r2 + r1
            goto L20
        L2b:
            return
        L2c:
            goto L1d
    }

    public static void OkDVwlJniRPXlPmn(java.util.IEnumerator r0, byte r1, short r2, float r3, bool r4) {
            goto L1e
        L4:
            goto L21
        L7:
            int r3 = r2 + r1
            goto L25
        Ld:
            int r2 = r0 * r1
            goto L7
        L13:
            return
        L14:
            goto L4
        L18:
            r0 = 42
            goto L2a
        L1e:
            goto L14
        L21:
            goto L18
        L25:
            double r0 = (double) r3
            goto L13
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
    }

    public static void OkDVwlJniRPXlPmn(java.util.IEnumerator r0, short r1, bool r2, float r3, byte r4) {
            goto L14
        L4:
            double r0 = (double) r3
            goto L9
        L9:
            return
        La:
            goto L1b
        Le:
            int r3 = r2 + r1
            goto L4
        L14:
            goto La
        L17:
            goto L1e
        L1b:
            goto L17
        L1e:
            r0 = 42
            goto L2a
        L24:
            int r2 = r0 * r1
            goto Le
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
    }

    public static void OkDVwlJniRPXlPmn(java.util.IEnumerator r0, bool r1, short r2, float r3, byte r4) {
            goto L24
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
        La:
            int r3 = r2 + r1
            goto L2b
        L10:
            goto L27
        L13:
            int r2 = r0 * r1
            goto La
        L19:
            return
        L1a:
            goto L10
        L1e:
            r0 = 42
            goto L4
        L24:
            goto L1a
        L27:
            goto L1e
        L2b:
            double r0 = (double) r3
            goto L19
    }

    public static bool OkDVwlJniRPXlPmn(java.util.IEnumerator r1) {
            goto L14
        L4:
            goto L17
        L7:
            bool r0 = r1.MoveNext()
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

    public static void RpuJjWyQHRjedHqV(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 r0) {
            goto L4
        L4:
            goto L13
        L7:
            goto Lb
        Lb:
            r0.dispose()
            goto L12
        L12:
            return
        L13:
            goto L17
        L17:
            goto L7
    }

    public static void RpuJjWyQHRjedHqV(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 r0, char r1, int r2, bool r3, byte r4) {
            goto L16
        L4:
            r0 = 42
            goto L10
        La:
            int r2 = r0 * r1
            goto L1d
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L16:
            goto L2c
        L19:
            goto L4
        L1d:
            int r3 = r2 + r1
            goto L26
        L23:
            goto L19
        L26:
            double r0 = (double) r3
            goto L2b
        L2b:
            return
        L2c:
            goto L23
    }

    public static void RpuJjWyQHRjedHqV(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 r0, bool r1, byte r2, int r3, char r4) {
            goto L10
        L4:
            int r2 = r0 * r1
            goto La
        La:
            int r3 = r2 + r1
            goto L22
        L10:
            goto L18
        L13:
            goto L1c
        L17:
            return
        L18:
            goto L27
        L1c:
            r0 = 42
            goto L2a
        L22:
            double r0 = (double) r3
            goto L17
        L27:
            goto L13
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static void RpuJjWyQHRjedHqV(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 r0, bool r1, char r2, int r3, byte r4) {
            goto Lc
        L4:
            goto Lf
        L7:
            double r0 = (double) r3
            goto L2b
        Lc:
            goto L2c
        Lf:
            goto L13
        L13:
            r0 = 42
            goto L1f
        L19:
            int r2 = r0 * r1
            goto L25
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        L25:
            int r3 = r2 + r1
            goto L7
        L2b:
            return
        L2c:
            goto L4
    }

    public static void UkqmTElhAjcoEiTL(java.util.List r0, java.lang.object r1, char r2, short r3, float r4, int r5) {
            goto L24
        L4:
            return
        L5:
            goto L21
        L9:
            int r3 = r2 + r1
            goto L2b
        Lf:
            int r2 = r0 * r1
            goto L9
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L1b:
            r0 = 42
            goto L15
        L21:
            goto L27
        L24:
            goto L5
        L27:
            goto L1b
        L2b:
            double r0 = (double) r3
            goto L4
    }

    public static void UkqmTElhAjcoEiTL(java.util.List r0, java.lang.object r1, int r2, float r3, char r4, short r5) {
            goto L23
        L4:
            double r0 = (double) r3
            goto L18
        L9:
            goto L26
        Lc:
            int r3 = r2 + r1
            goto L4
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        L18:
            return
        L19:
            goto L9
        L1d:
            int r2 = r0 * r1
            goto Lc
        L23:
            goto L19
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto L12
    }

    public static void UkqmTElhAjcoEiTL(java.util.List r0, java.lang.object r1, short r2, float r3, int r4, char r5) {
            goto L20
        L4:
            r0 = 42
            goto L15
        La:
            int r2 = r0 * r1
            goto L27
        L10:
            double r0 = (double) r3
            goto L1b
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L1b:
            return
        L1c:
            goto L2d
        L20:
            goto L1c
        L23:
            goto L4
        L27:
            int r3 = r2 + r1
            goto L10
        L2d:
            goto L23
    }

    public static bool UkqmTElhAjcoEiTL(java.util.List r1, java.lang.object r2) {
            goto L9
        L4:
            return r0
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            bool r0 = r1.Add(r2)
            goto L4
    }

    public static void YbLfBWpUULXcUALB(java.util.List r0, java.lang.object r1, byte r2, int r3, char r4, java.lang.string r5) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L22
        La:
            goto L18
        Ld:
            goto L1c
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L17:
            return
        L18:
            goto L2d
        L1c:
            r0 = 42
            goto L11
        L22:
            int r3 = r2 + r1
            goto L28
        L28:
            double r0 = (double) r3
            goto L17
        L2d:
            goto Ld
    }

    public static void YbLfBWpUULXcUALB(java.util.List r0, java.lang.object r1, byte r2, int r3, java.lang.string r4, char r5) {
            goto L7
        L4:
            goto La
        L7:
            goto L26
        La:
            goto L14
        Le:
            int r2 = r0 * r1
            goto L1a
        L14:
            r0 = 42
            goto L2a
        L1a:
            int r3 = r2 + r1
            goto L20
        L20:
            double r0 = (double) r3
            goto L25
        L25:
            return
        L26:
            goto L4
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Le
    }

    public static void YbLfBWpUULXcUALB(java.util.List r0, java.lang.object r1, int r2, char r3, java.lang.string r4, byte r5) {
            goto Ld
        L4:
            int r2 = r0 * r1
            goto L14
        La:
            goto L10
        Ld:
            goto L26
        L10:
            goto L1a
        L14:
            int r3 = r2 + r1
            goto L20
        L1a:
            r0 = 42
            goto L2a
        L20:
            double r0 = (double) r3
            goto L25
        L25:
            return
        L26:
            goto La
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static bool YbLfBWpUULXcUALB(java.util.List r1, java.lang.object r2) {
            goto L9
        L4:
            return r0
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            bool r0 = r1.Add(r2)
            goto L4
    }

    public static void ALajSIkfKjpNUiNg(java.util.List r0, java.lang.object r1, char r2, byte r3, float r4, bool r5) {
            goto L24
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        La:
            int r3 = r2 + r1
            goto L13
        L10:
            goto L27
        L13:
            double r0 = (double) r3
            goto L2b
        L18:
            r0 = 42
            goto L4
        L1e:
            int r2 = r0 * r1
            goto La
        L24:
            goto L2c
        L27:
            goto L18
        L2b:
            return
        L2c:
            goto L10
    }

    public static void ALajSIkfKjpNUiNg(java.util.List r0, java.lang.object r1, float r2, byte r3, char r4, bool r5) {
            goto Ld
        L4:
            goto L10
        L7:
            r0 = 42
            goto L2a
        Ld:
            goto L20
        L10:
            goto L7
        L14:
            int r2 = r0 * r1
            goto L24
        L1a:
            double r0 = (double) r3
            goto L1f
        L1f:
            return
        L20:
            goto L4
        L24:
            int r3 = r2 + r1
            goto L1a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
    }

    public static void ALajSIkfKjpNUiNg(java.util.List r0, java.lang.object r1, float r2, char r3, bool r4, byte r5) {
            goto L18
        L4:
            return
        L5:
            goto L15
        L9:
            r0 = 42
            goto L2a
        Lf:
            int r2 = r0 * r1
            goto L1f
        L15:
            goto L1b
        L18:
            goto L5
        L1b:
            goto L9
        L1f:
            int r3 = r2 + r1
            goto L25
        L25:
            double r0 = (double) r3
            goto L4
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
    }

    public static bool ALajSIkfKjpNUiNg(java.util.List r1, java.lang.object r2) {
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
            bool r0 = r1.Remove(r2)
            goto Le
    }

    public static void AhqnLQvhfcdXhjCI(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p90df2a9e r0, java.util.List r1) {
            goto L10
        L4:
            return
        L5:
            goto L17
        L9:
            r0.dispose(r1)
            goto L4
        L10:
            goto L5
        L13:
            goto L9
        L17:
            goto L13
    }

    public static void AhqnLQvhfcdXhjCI(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p90df2a9e r0, java.util.List r1, byte r2, char r3, float r4, java.lang.string r5) {
            goto L15
        L4:
            double r0 = (double) r3
            goto L2b
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        L15:
            goto L2c
        L18:
            goto L25
        L1c:
            int r2 = r0 * r1
            goto L9
        L22:
            goto L18
        L25:
            r0 = 42
            goto Lf
        L2b:
            return
        L2c:
            goto L22
    }

    public static void AhqnLQvhfcdXhjCI(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p90df2a9e r0, java.util.List r1, byte r2, java.lang.string r3, float r4, char r5) {
            goto L15
        L4:
            return
        L5:
            goto L21
        L9:
            int r2 = r0 * r1
            goto Lf
        Lf:
            int r3 = r2 + r1
            goto L1c
        L15:
            goto L5
        L18:
            goto L2a
        L1c:
            double r0 = (double) r3
            goto L4
        L21:
            goto L18
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L2a:
            r0 = 42
            goto L24
    }

    public static void AhqnLQvhfcdXhjCI(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p90df2a9e r0, java.util.List r1, char r2, float r3, java.lang.string r4, byte r5) {
            goto L29
        L4:
            int r3 = r2 + r1
            goto L1b
        La:
            return
        Lb:
            goto L26
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        L15:
            int r2 = r0 * r1
            goto L4
        L1b:
            double r0 = (double) r3
            goto La
        L20:
            r0 = 42
            goto Lf
        L26:
            goto L2c
        L29:
            goto Lb
        L2c:
            goto L20
    }

    public static java.lang.object BWeICNCQYByymDxw(java.util.IEnumerator r1) {
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
            java.lang.object r0 = r1.Current
            goto L4
        L18:
            goto Lc
    }

    public static void BWeICNCQYByymDxw(java.util.IEnumerator r0, java.lang.string r1, int r2, bool r3, short r4) {
            goto L9
        L4:
            return
        L5:
            goto L1b
        L9:
            goto L5
        Lc:
            goto L2a
        L10:
            int r2 = r0 * r1
            goto L24
        L16:
            double r0 = (double) r3
            goto L4
        L1b:
            goto Lc
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L24:
            int r3 = r2 + r1
            goto L16
        L2a:
            r0 = 42
            goto L1e
    }

    public static void BWeICNCQYByymDxw(java.util.IEnumerator r0, short r1, int r2, bool r3, java.lang.string r4) {
            goto L12
        L4:
            goto L15
        L7:
            int r3 = r2 + r1
            goto L1f
        Ld:
            return
        Le:
            goto L4
        L12:
            goto Le
        L15:
            goto L19
        L19:
            r0 = 42
            goto L24
        L1f:
            double r0 = (double) r3
            goto Ld
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L2a:
            int r2 = r0 * r1
            goto L7
    }

    public static void BWeICNCQYByymDxw(java.util.IEnumerator r0, bool r1, short r2, java.lang.string r3, int r4) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L1e
        Le:
            return
        Lf:
            goto L4
        L13:
            int r3 = r2 + r1
            goto L19
        L19:
            double r0 = (double) r3
            goto Le
        L1e:
            r0 = 42
            goto L2a
        L24:
            int r2 = r0 * r1
            goto L13
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
    }

    public static void CDHktSoCmZFBghnd(java.util.IEnumerator r0, short r1, bool r2, char r3, int r4) {
            goto Lf
        L4:
            double r0 = (double) r3
            goto L1f
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        Lf:
            goto L20
        L12:
            goto L2a
        L16:
            goto L12
        L19:
            int r2 = r0 * r1
            goto L24
        L1f:
            return
        L20:
            goto L16
        L24:
            int r3 = r2 + r1
            goto L4
        L2a:
            r0 = 42
            goto L9
    }

    public static void CDHktSoCmZFBghnd(java.util.IEnumerator r0, bool r1, int r2, short r3, char r4) {
            goto L1d
        L4:
            double r0 = (double) r3
            goto L18
        L9:
            int r2 = r0 * r1
            goto L24
        Lf:
            goto L20
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L18:
            return
        L19:
            goto Lf
        L1d:
            goto L19
        L20:
            goto L2a
        L24:
            int r3 = r2 + r1
            goto L4
        L2a:
            r0 = 42
            goto L12
    }

    public static void CDHktSoCmZFBghnd(java.util.IEnumerator r0, bool r1, short r2, char r3, int r4) {
            goto L18
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            r0 = 42
            goto L25
        L10:
            return
        L11:
            goto L15
        L15:
            goto L1b
        L18:
            goto L11
        L1b:
            goto La
        L1f:
            int r2 = r0 * r1
            goto L4
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L2b:
            double r0 = (double) r3
            goto L10
    }

    public static bool CDHktSoCmZFBghnd(java.util.IEnumerator r1) {
            goto Lf
        L4:
            bool r0 = r1.MoveNext()
            goto L16
        Lc:
            goto L12
        Lf:
            goto L17
        L12:
            goto L4
        L16:
            return r0
        L17:
            goto Lc
    }

    public static java.util.IEnumerator CuayjeMoxUOlZQAx(java.lang.IEnumerable r1) {
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
            java.util.IEnumerator r0 = r1.GetEnumerator()
            goto L4
        L18:
            goto Lc
    }

    public static void CuayjeMoxUOlZQAx(java.lang.IEnumerable r0, char r1, byte r2, float r3, bool r4) {
            goto L1e
        L4:
            r0 = 42
            goto L15
        La:
            int r3 = r2 + r1
            goto L25
        L10:
            return
        L11:
            goto L1b
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1b:
            goto L21
        L1e:
            goto L11
        L21:
            goto L4
        L25:
            double r0 = (double) r3
            goto L10
        L2a:
            int r2 = r0 * r1
            goto La
    }

    public static void CuayjeMoxUOlZQAx(java.lang.IEnumerable r0, float r1, char r2, bool r3, byte r4) {
            goto L23
        L4:
            double r0 = (double) r3
            goto L9
        L9:
            return
        La:
            goto L1a
        Le:
            int r2 = r0 * r1
            goto L2a
        L14:
            r0 = 42
            goto L1d
        L1a:
            goto L26
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto Le
        L23:
            goto La
        L26:
            goto L14
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static void CuayjeMoxUOlZQAx(java.lang.IEnumerable r0, bool r1, char r2, float r3, byte r4) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L1f
        La:
            goto L12
        Ld:
            goto L24
        L11:
            return
        L12:
            goto L16
        L16:
            goto Ld
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1f:
            double r0 = (double) r3
            goto L11
        L24:
            r0 = 42
            goto L19
        L2a:
            int r2 = r0 * r1
            goto L4
    }

    public static void DDXfMSXYtDUVTerW(java.util.List r0, java.lang.object r1, byte r2, bool r3, char r4, java.lang.string r5) {
            goto L1b
        L4:
            int r2 = r0 * r1
            goto L27
        La:
            return
        Lb:
            goto L2d
        Lf:
            r0 = 42
            goto L15
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1b:
            goto Lb
        L1e:
            goto Lf
        L22:
            double r0 = (double) r3
            goto La
        L27:
            int r3 = r2 + r1
            goto L22
        L2d:
            goto L1e
    }

    public static void DDXfMSXYtDUVTerW(java.util.List r0, java.lang.object r1, char r2, bool r3, java.lang.string r4, byte r5) {
            goto L15
        L4:
            double r0 = (double) r3
            goto L2b
        L9:
            int r2 = r0 * r1
            goto Lf
        Lf:
            int r3 = r2 + r1
            goto L4
        L15:
            goto L2c
        L18:
            goto L25
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L22:
            goto L18
        L25:
            r0 = 42
            goto L1c
        L2b:
            return
        L2c:
            goto L22
    }

    public static void DDXfMSXYtDUVTerW(java.util.List r0, java.lang.object r1, bool r2, byte r3, java.lang.string r4, char r5) {
            goto L9
        L4:
            return
        L5:
            goto L2d
        L9:
            goto L5
        Lc:
            goto L22
        L10:
            int r3 = r2 + r1
            goto L28
        L16:
            int r2 = r0 * r1
            goto L10
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L22:
            r0 = 42
            goto L1c
        L28:
            double r0 = (double) r3
            goto L4
        L2d:
            goto Lc
    }

    public static bool DDXfMSXYtDUVTerW(java.util.List r1, java.lang.object r2) {
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
            bool r0 = r1.Add(r2)
            goto Le
    }

    public static java.lang.object DVYUMOmJxKLvGbsI(java.lang.object r1, java.lang.string r2) {
            goto L9
        L4:
            return r0
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            java.lang.object r0 = java.util.objects.requireNonNull(r1, r2)
            goto L4
    }

    public static void DVYUMOmJxKLvGbsI(java.lang.object r0, java.lang.string r1, byte r2, java.lang.string r3, short r4, int r5) {
            goto L1e
        L4:
            int r3 = r2 + r1
            goto L25
        La:
            r0 = 42
            goto L2a
        L10:
            int r2 = r0 * r1
            goto L4
        L16:
            goto L21
        L19:
            return
        L1a:
            goto L16
        L1e:
            goto L1a
        L21:
            goto La
        L25:
            double r0 = (double) r3
            goto L19
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
    }

    public static void DVYUMOmJxKLvGbsI(java.lang.object r0, java.lang.string r1, int r2, byte r3, java.lang.string r4, short r5) {
            goto L4
        L4:
            goto L11
        L7:
            goto L15
        Lb:
            double r0 = (double) r3
            goto L10
        L10:
            return
        L11:
            goto L27
        L15:
            r0 = 42
            goto L1b
        L1b:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L21:
            int r3 = r2 + r1
            goto Lb
        L27:
            goto L7
        L2a:
            int r2 = r0 * r1
            goto L21
    }

    public static void DVYUMOmJxKLvGbsI(java.lang.object r0, java.lang.string r1, short r2, java.lang.string r3, byte r4, int r5) {
            goto L29
        L4:
            goto L2c
        L7:
            int r2 = r0 * r1
            goto Ld
        Ld:
            int r3 = r2 + r1
            goto L19
        L13:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L19:
            double r0 = (double) r3
            goto L24
        L1e:
            r0 = 42
            goto L13
        L24:
            return
        L25:
            goto L4
        L29:
            goto L25
        L2c:
            goto L1e
    }

    public static java.lang.object EKxrPuJxegMzaePW(java.lang.object r1, java.lang.string r2) {
            goto Lc
        L4:
            java.lang.object r0 = java.util.objects.requireNonNull(r1, r2)
            goto L13
        Lc:
            goto L14
        Lf:
            goto L4
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto Lf
    }

    public static void EKxrPuJxegMzaePW(java.lang.object r0, java.lang.string r1, byte r2, java.lang.string r3, char r4, bool r5) {
            goto L18
        L4:
            return
        L5:
            goto L9
        L9:
            goto L1b
        Lc:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L12:
            r0 = 42
            goto Lc
        L18:
            goto L5
        L1b:
            goto L12
        L1f:
            int r3 = r2 + r1
            goto L25
        L25:
            double r0 = (double) r3
            goto L4
        L2a:
            int r2 = r0 * r1
            goto L1f
    }

    public static void EKxrPuJxegMzaePW(java.lang.object r0, java.lang.string r1, java.lang.string r2, bool r3, byte r4, char r5) {
            goto L15
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L21
        La:
            int r3 = r2 + r1
            goto L10
        L10:
            double r0 = (double) r3
            goto L1c
        L15:
            goto L1d
        L18:
            goto L27
        L1c:
            return
        L1d:
            goto L2d
        L21:
            int r2 = r0 * r1
            goto La
        L27:
            r0 = 42
            goto L4
        L2d:
            goto L18
    }

    public static void EKxrPuJxegMzaePW(java.lang.object r0, java.lang.string r1, java.lang.string r2, bool r3, char r4, byte r5) {
            goto L1a
        L4:
            double r0 = (double) r3
            goto L15
        L9:
            int r2 = r0 * r1
            goto L2a
        Lf:
            r0 = 42
            goto L21
        L15:
            return
        L16:
            goto L27
        L1a:
            goto L16
        L1d:
            goto Lf
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L27:
            goto L1d
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static java.lang.object KuJMFFbuBDqOJtHa(java.lang.object r1, java.lang.string r2) {
            goto L9
        L4:
            return r0
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            java.lang.object r0 = java.util.objects.requireNonNull(r1, r2)
            goto L4
    }

    public static void KuJMFFbuBDqOJtHa(java.lang.object r0, java.lang.string r1, java.lang.string r2, short r3, bool r4, char r5) {
            goto L24
        L4:
            return
        L5:
            goto L9
        L9:
            goto L27
        Lc:
            r0 = 42
            goto L1e
        L12:
            int r3 = r2 + r1
            goto L2b
        L18:
            int r2 = r0 * r1
            goto L12
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        L24:
            goto L5
        L27:
            goto Lc
        L2b:
            double r0 = (double) r3
            goto L4
    }

    public static void KuJMFFbuBDqOJtHa(java.lang.object r0, java.lang.string r1, java.lang.string r2, bool r3, char r4, short r5) {
            goto L1c
        L4:
            int r3 = r2 + r1
            goto L23
        La:
            int r2 = r0 * r1
            goto L4
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L16:
            r0 = 42
            goto L10
        L1c:
            goto L2c
        L1f:
            goto L16
        L23:
            double r0 = (double) r3
            goto L2b
        L28:
            goto L1f
        L2b:
            return
        L2c:
            goto L28
    }

    public static void KuJMFFbuBDqOJtHa(java.lang.object r0, java.lang.string r1, java.lang.string r2, bool r3, short r4, char r5) {
            goto Ld
        L4:
            goto L10
        L7:
            r0 = 42
            goto L14
        Ld:
            goto L1b
        L10:
            goto L7
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L1a:
            return
        L1b:
            goto L4
        L1f:
            int r2 = r0 * r1
            goto L25
        L25:
            int r3 = r2 + r1
            goto L2b
        L2b:
            double r0 = (double) r3
            goto L1a
    }

    public static void MiloKGUikzpPfwqk(java.util.List r0, java.lang.object r1, char r2, int r3, java.lang.string r4, short r5) {
            goto L4
        L4:
            goto L18
        L7:
            goto L1f
        Lb:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
        L11:
            int r2 = r0 * r1
            goto L25
        L17:
            return
        L18:
            goto L1c
        L1c:
            goto L7
        L1f:
            r0 = 42
            goto Lb
        L25:
            int r3 = r2 + r1
            goto L2b
        L2b:
            double r0 = (double) r3
            goto L17
    }

    public static void MiloKGUikzpPfwqk(java.util.List r0, java.lang.object r1, java.lang.string r2, int r3, char r4, short r5) {
            goto L23
        L4:
            int r3 = r2 + r1
            goto La
        La:
            double r0 = (double) r3
            goto L1b
        Lf:
            int r2 = r0 * r1
            goto L4
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L1b:
            return
        L1c:
            goto L20
        L20:
            goto L26
        L23:
            goto L1c
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto L15
    }

    public static void MiloKGUikzpPfwqk(java.util.List r0, java.lang.object r1, short r2, char r3, int r4, java.lang.string r5) {
            goto L23
        L4:
            return
        L5:
            goto L15
        L9:
            int r3 = r2 + r1
            goto L1e
        Lf:
            int r2 = r0 * r1
            goto L9
        L15:
            goto L26
        L18:
            r0 = 42
            goto L2a
        L1e:
            double r0 = (double) r3
            goto L4
        L23:
            goto L5
        L26:
            goto L18
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
    }

    public static bool MiloKGUikzpPfwqk(java.util.List r1, java.lang.object r2) {
            goto Lf
        L4:
            bool r0 = r1.Add(r2)
            goto L16
        Lc:
            goto L12
        Lf:
            goto L17
        L12:
            goto L4
        L16:
            return r0
        L17:
            goto Lc
    }

    public static java.lang.object PZvbhVzJNKUHsUAw(java.util.IEnumerator r1) {
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
            java.lang.object r0 = r1.Current
            goto Le
    }

    public static void PZvbhVzJNKUHsUAw(java.util.IEnumerator r0, char r1, short r2, bool r3, java.lang.string r4) {
            goto L19
        L4:
            r0 = 42
            goto L20
        La:
            goto L1c
        Ld:
            int r3 = r2 + r1
            goto L26
        L13:
            int r2 = r0 * r1
            goto Ld
        L19:
            goto L2c
        L1c:
            goto L4
        L20:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
        L26:
            double r0 = (double) r3
            goto L2b
        L2b:
            return
        L2c:
            goto La
    }

    public static void PZvbhVzJNKUHsUAw(java.util.IEnumerator r0, bool r1, char r2, short r3, java.lang.string r4) {
            goto L18
        L4:
            goto L1b
        L7:
            double r0 = (double) r3
            goto L2b
        Lc:
            int r2 = r0 * r1
            goto L12
        L12:
            int r3 = r2 + r1
            goto L7
        L18:
            goto L2c
        L1b:
            goto L25
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lc
        L25:
            r0 = 42
            goto L1f
        L2b:
            return
        L2c:
            goto L4
    }

    public static void PZvbhVzJNKUHsUAw(java.util.IEnumerator r0, bool r1, java.lang.string r2, short r3, char r4) {
            goto Ld
        L4:
            goto L10
        L7:
            r0 = 42
            goto L19
        Ld:
            goto L15
        L10:
            goto L7
        L14:
            return
        L15:
            goto L4
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L1f:
            double r0 = (double) r3
            goto L14
        L24:
            int r2 = r0 * r1
            goto L2a
        L2a:
            int r3 = r2 + r1
            goto L1f
    }

    public static void PzINASPhstzeUoZf(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 r0) {
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
            r0.dispose()
            goto Lb
        L17:
            goto L7
    }

    public static void PzINASPhstzeUoZf(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 r0, char r1, java.lang.string r2, byte r3, int r4) {
            goto L23
        L4:
            goto L26
        L7:
            int r2 = r0 * r1
            goto L2a
        Ld:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L13:
            r0 = 42
            goto Ld
        L19:
            double r0 = (double) r3
            goto L1e
        L1e:
            return
        L1f:
            goto L4
        L23:
            goto L1f
        L26:
            goto L13
        L2a:
            int r3 = r2 + r1
            goto L19
    }

    public static void PzINASPhstzeUoZf(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 r0, int r1, char r2, java.lang.string r3, byte r4) {
            goto L1f
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            r0 = 42
            goto L16
        L10:
            int r2 = r0 * r1
            goto L4
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L1c:
            goto L22
        L1f:
            goto L27
        L22:
            goto La
        L26:
            return
        L27:
            goto L1c
        L2b:
            double r0 = (double) r3
            goto L26
    }

    public static void PzINASPhstzeUoZf(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 r0, java.lang.string r1, byte r2, int r3, char r4) {
            goto L4
        L4:
            goto L12
        L7:
            goto L1c
        Lb:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L11:
            return
        L12:
            goto L2d
        L16:
            int r2 = r0 * r1
            goto L22
        L1c:
            r0 = 42
            goto Lb
        L22:
            int r3 = r2 + r1
            goto L28
        L28:
            double r0 = (double) r3
            goto L11
        L2d:
            goto L7
    }

    public static java.lang.object TOCSaJkwsYnzJgEQ(java.lang.object r1, java.lang.string r2) {
            goto L14
        L4:
            goto L17
        L7:
            java.lang.object r0 = java.util.objects.requireNonNull(r1, r2)
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

    public static void TOCSaJkwsYnzJgEQ(java.lang.object r0, java.lang.string r1, int r2, char r3, short r4, bool r5) {
            goto L29
        L4:
            return
        L5:
            goto L26
        L9:
            int r2 = r0 * r1
            goto L20
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L15:
            double r0 = (double) r3
            goto L4
        L1a:
            r0 = 42
            goto Lf
        L20:
            int r3 = r2 + r1
            goto L15
        L26:
            goto L2c
        L29:
            goto L5
        L2c:
            goto L1a
    }

    public static void TOCSaJkwsYnzJgEQ(java.lang.object r0, java.lang.string r1, int r2, bool r3, short r4, char r5) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L1f
        La:
            goto L18
        Ld:
            goto L11
        L11:
            r0 = 42
            goto L2a
        L17:
            return
        L18:
            goto L1c
        L1c:
            goto Ld
        L1f:
            double r0 = (double) r3
            goto L17
        L24:
            int r2 = r0 * r1
            goto L4
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
    }

    public static void TOCSaJkwsYnzJgEQ(java.lang.object r0, java.lang.string r1, bool r2, short r3, int r4, char r5) {
            goto L9
        L4:
            return
        L5:
            goto L2d
        L9:
            goto L5
        Lc:
            goto L1c
        L10:
            int r3 = r2 + r1
            goto L28
        L16:
            int r2 = r0 * r1
            goto L10
        L1c:
            r0 = 42
            goto L22
        L22:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L28:
            double r0 = (double) r3
            goto L4
        L2d:
            goto Lc
    }

    public static int UWjiOctiTIDIIoTR(java.util.List r1) {
            goto Lc
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L13
        L13:
            int r0 = r1.Count
            goto L4
    }

    public static void UWjiOctiTIDIIoTR(java.util.List r0, int r1, byte r2, short r3, java.lang.string r4) {
            goto La
        L4:
            r0 = 42
            goto L11
        La:
            goto L1d
        Ld:
            goto L4
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L17:
            double r0 = (double) r3
            goto L1c
        L1c:
            return
        L1d:
            goto L27
        L21:
            int r3 = r2 + r1
            goto L17
        L27:
            goto Ld
        L2a:
            int r2 = r0 * r1
            goto L21
    }

    public static void UWjiOctiTIDIIoTR(java.util.List r0, java.lang.string r1, int r2, short r3, byte r4) {
            goto La
        L4:
            r0 = 42
            goto L2a
        La:
            goto L20
        Ld:
            goto L4
        L11:
            int r2 = r0 * r1
            goto L24
        L17:
            goto Ld
        L1a:
            double r0 = (double) r3
            goto L1f
        L1f:
            return
        L20:
            goto L17
        L24:
            int r3 = r2 + r1
            goto L1a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
    }

    public static void UWjiOctiTIDIIoTR(java.util.List r0, short r1, int r2, byte r3, java.lang.string r4) {
            goto L18
        L4:
            r0 = 42
            goto L25
        La:
            return
        Lb:
            goto Lf
        Lf:
            goto L1b
        L12:
            int r2 = r0 * r1
            goto L1f
        L18:
            goto Lb
        L1b:
            goto L4
        L1f:
            int r3 = r2 + r1
            goto L2b
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
        L2b:
            double r0 = (double) r3
            goto La
    }

    public static java.util.IEnumerator VWMOdEzwqktWrmof(java.util.List r1) {
            goto Lc
        L4:
            java.util.IEnumerator r0 = r1.GetEnumerator()
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

    public static void VWMOdEzwqktWrmof(java.util.List r0, byte r1, java.lang.string r2, char r3, bool r4) {
            goto L24
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        La:
            int r2 = r0 * r1
            goto L19
        L10:
            r0 = 42
            goto L4
        L16:
            goto L27
        L19:
            int r3 = r2 + r1
            goto L2b
        L1f:
            return
        L20:
            goto L16
        L24:
            goto L20
        L27:
            goto L10
        L2b:
            double r0 = (double) r3
            goto L1f
    }

    public static void VWMOdEzwqktWrmof(java.util.List r0, byte r1, bool r2, java.lang.string r3, char r4) {
            goto Lc
        L4:
            double r0 = (double) r3
            goto L13
        L9:
            goto Lf
        Lc:
            goto L14
        Lf:
            goto L24
        L13:
            return
        L14:
            goto L9
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        L1e:
            int r2 = r0 * r1
            goto L2a
        L24:
            r0 = 42
            goto L18
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static void VWMOdEzwqktWrmof(java.util.List r0, bool r1, java.lang.string r2, char r3, byte r4) {
            goto L1b
        L4:
            int r3 = r2 + r1
            goto L16
        La:
            int r2 = r0 * r1
            goto L4
        L10:
            r0 = 42
            goto L2a
        L16:
            double r0 = (double) r3
            goto L25
        L1b:
            goto L26
        L1e:
            goto L10
        L22:
            goto L1e
        L25:
            return
        L26:
            goto L22
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
    }

    public static void VdJGBPwUgEIfJgwd(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 r0) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            r0.dispose()
            goto Lb
    }

    public static void VdJGBPwUgEIfJgwd(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 r0, int r1, java.lang.string r2, bool r3, float r4) {
            goto La
        L4:
            r0 = 42
            goto L2a
        La:
            goto L26
        Ld:
            goto L4
        L11:
            goto Ld
        L14:
            int r2 = r0 * r1
            goto L1a
        L1a:
            int r3 = r2 + r1
            goto L20
        L20:
            double r0 = (double) r3
            goto L25
        L25:
            return
        L26:
            goto L11
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
    }

    public static void VdJGBPwUgEIfJgwd(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 r0, java.lang.string r1, float r2, int r3, bool r4) {
            goto L16
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        La:
            int r2 = r0 * r1
            goto L10
        L10:
            int r3 = r2 + r1
            goto L1d
        L16:
            goto L2c
        L19:
            goto L22
        L1d:
            double r0 = (double) r3
            goto L2b
        L22:
            r0 = 42
            goto L4
        L28:
            goto L19
        L2b:
            return
        L2c:
            goto L28
    }

    public static void VdJGBPwUgEIfJgwd(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 r0, bool r1, java.lang.string r2, int r3, float r4) {
            goto L21
        L4:
            int r2 = r0 * r1
            goto L10
        La:
            r0 = 42
            goto L16
        L10:
            int r3 = r2 + r1
            goto L1c
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1c:
            double r0 = (double) r3
            goto L2b
        L21:
            goto L2c
        L24:
            goto La
        L28:
            goto L24
        L2b:
            return
        L2c:
            goto L28
    }

    public static java.lang.object WonzMTHOCzNNzwQq(java.util.List r1, int r2) {
            goto L14
        L4:
            java.lang.object r0 = r1[r2)
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

    public static void WonzMTHOCzNNzwQq(java.util.List r0, int r1, byte r2, int r3, bool r4, java.lang.string r5) {
            goto L12
        L4:
            return
        L5:
            goto L9
        L9:
            goto L15
        Lc:
            int r3 = r2 + r1
            goto L2b
        L12:
            goto L5
        L15:
            goto L19
        L19:
            r0 = 42
            goto L1f
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L25:
            int r2 = r0 * r1
            goto Lc
        L2b:
            double r0 = (double) r3
            goto L4
    }

    public static void WonzMTHOCzNNzwQq(java.util.List r0, int r1, int r2, java.lang.string r3, bool r4, byte r5) {
            goto L15
        L4:
            double r0 = (double) r3
            goto L1c
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            int r2 = r0 * r1
            goto L9
        L15:
            goto L1d
        L18:
            goto L21
        L1c:
            return
        L1d:
            goto L27
        L21:
            r0 = 42
            goto L2a
        L27:
            goto L18
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
    }

    public static void WonzMTHOCzNNzwQq(java.util.List r0, int r1, bool r2, byte r3, java.lang.string r4, int r5) {
            goto L1d
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        La:
            double r0 = (double) r3
            goto L18
        Lf:
            goto L20
        L12:
            r0 = 42
            goto L4
        L18:
            return
        L19:
            goto Lf
        L1d:
            goto L19
        L20:
            goto L12
        L24:
            int r2 = r0 * r1
            goto L2a
        L2a:
            int r3 = r2 + r1
            goto La
    }

    public static java.lang.object WxNvaFAdqWLpUKAa(java.lang.object r1, java.lang.string r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            java.lang.object r0 = java.util.objects.requireNonNull(r1, r2)
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static void WxNvaFAdqWLpUKAa(java.lang.object r0, java.lang.string r1, byte r2, short r3, int r4, char r5) {
            goto L15
        L4:
            return
        L5:
            goto L2d
        L9:
            r0 = 42
            goto L22
        Lf:
            int r2 = r0 * r1
            goto L1c
        L15:
            goto L5
        L18:
            goto L9
        L1c:
            int r3 = r2 + r1
            goto L28
        L22:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L28:
            double r0 = (double) r3
            goto L4
        L2d:
            goto L18
    }

    public static void WxNvaFAdqWLpUKAa(java.lang.object r0, java.lang.string r1, int r2, char r3, short r4, byte r5) {
            goto L29
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        L10:
            double r0 = (double) r3
            goto L1e
        L15:
            int r2 = r0 * r1
            goto L23
        L1b:
            goto L2c
        L1e:
            return
        L1f:
            goto L1b
        L23:
            int r3 = r2 + r1
            goto L10
        L29:
            goto L1f
        L2c:
            goto L4
    }

    public static void WxNvaFAdqWLpUKAa(java.lang.object r0, java.lang.string r1, short r2, byte r3, char r4, int r5) {
            goto L1d
        L4:
            double r0 = (double) r3
            goto Lc
        L9:
            goto L20
        Lc:
            return
        Ld:
            goto L9
        L11:
            int r2 = r0 * r1
            goto L17
        L17:
            int r3 = r2 + r1
            goto L4
        L1d:
            goto Ld
        L20:
            goto L24
        L24:
            r0 = 42
            goto L2a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
    }

    public static void ZOAQyayKGaotMmUU(java.lang.Exception r0) {
            goto L13
        L4:
            goto L16
        L7:
            return
        L8:
            goto L4
        Lc:
            pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(r0)
            goto L7
        L13:
            goto L8
        L16:
            goto Lc
    }

    public static void ZOAQyayKGaotMmUU(java.lang.Exception r0, byte r1, float r2, java.lang.string r3, bool r4) {
            goto L16
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        L10:
            int r3 = r2 + r1
            goto L22
        L16:
            goto L1e
        L19:
            goto L4
        L1d:
            return
        L1e:
            goto L2d
        L22:
            double r0 = (double) r3
            goto L1d
        L27:
            int r2 = r0 * r1
            goto L10
        L2d:
            goto L19
    }

    public static void ZOAQyayKGaotMmUU(java.lang.Exception r0, byte r1, float r2, bool r3, java.lang.string r4) {
            goto L29
        L4:
            int r3 = r2 + r1
            goto L16
        La:
            int r2 = r0 * r1
            goto L4
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L16:
            double r0 = (double) r3
            goto L1e
        L1b:
            goto L2c
        L1e:
            return
        L1f:
            goto L1b
        L23:
            r0 = 42
            goto L10
        L29:
            goto L1f
        L2c:
            goto L23
    }

    public static void ZOAQyayKGaotMmUU(java.lang.Exception r0, float r1, bool r2, byte r3, java.lang.string r4) {
            goto L17
        L4:
            return
        L5:
            goto Lf
        L9:
            r0 = 42
            goto L1e
        Lf:
            goto L1a
        L12:
            double r0 = (double) r3
            goto L4
        L17:
            goto L5
        L1a:
            goto L9
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L24:
            int r2 = r0 * r1
            goto L2a
        L2a:
            int r3 = r2 + r1
            goto L12
    }

    @Override // pf98ed07a.pa30d0e7f.p90676d7c.p52905679.padbc3aba
    public bool Add(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 r2) {
            r1 = this;
            goto L3b
        L4:
            throw r2
        L5:
            goto L57
        L9:
            goto L3e
        Lc:
            monitor-enter(r1)
            bool r0 = r1.ff8b2648d     // Catch: java.lang.Exception -> L24
            if (r0 != 0) goto L22
            java.util.List<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> r0 = r1.f55b558c7     // Catch: java.lang.Exception -> L24
            if (r0 != 0) goto L1c
            java.util.List r0 = new java.util.List     // Catch: java.lang.Exception -> L24
            r0.<init>()     // Catch: java.lang.Exception -> L24
            r1.f55b558c7 = r0     // Catch: java.lang.Exception -> L24
        L1c:
            YbLfBWpUULXcUALB(r0, r2)     // Catch: java.lang.Exception -> L24
            r2 = 1
            monitor-exit(r1)     // Catch: java.lang.Exception -> L24
            return r2
        L22:
            monitor-exit(r1)     // Catch: java.lang.Exception -> L24
            goto L5
        L24:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L24
            goto L4
        L2a:
            java.lang.string r0 = "d is null"
            goto L50
        L30:
            bool r0 = r1.ff8b2648d
            goto L47
        L36:
            return r1
        L37:
            goto L9
        L3b:
            goto L37
        L3e:
            goto L2a
        L42:
            r1 = 0
            goto L36
        L47:
            if (r0 == 0) goto L4c
            goto L5
        L4c:
            goto Lc
        L50:
            eKxrPuJxegMzaePW(r2, r0)
            goto L30
        L57:
            pzINASPhstzeUoZf(r2)
            goto L42
    }

    public bool AddAll(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252... r6) {
            r5 = this;
            goto La0
        L4:
            goto La3
        L7:
            int r0 = r0 + r1
            goto L1e
        Ld:
            int r0 = r0 + 1
            goto Lad
        L13:
            r0 = r1
        L14:
            goto L80
        L18:
            java.lang.string r0 = "ds is null"
            goto L99
        L1e:
            int r0 = r0 % r1
            goto L90
        L24:
            goto L8c
        L27:
            goto L4
        L2b:
            return r1
        L2c:
            goto L24
        L30:
            r0 = 3
            goto L37
        L37:
            r1 = 22
            goto L7
        L3e:
            monitor-enter(r5)
            bool r0 = r5.ff8b2648d     // Catch: java.lang.Exception -> L63
            if (r0 != 0) goto L61
            java.util.List<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> r0 = r5.f55b558c7     // Catch: java.lang.Exception -> L63
            if (r0 != 0) goto L4e
            java.util.List r0 = new java.util.List     // Catch: java.lang.Exception -> L63
            r0.<init>()     // Catch: java.lang.Exception -> L63
            r5.f55b558c7 = r0     // Catch: java.lang.Exception -> L63
        L4e:
            int r2 = r6.length     // Catch: java.lang.Exception -> L63
        L4f:
            if (r1 >= r2) goto L5e
            r3 = r6[r1]     // Catch: java.lang.Exception -> L63
            java.lang.string r4 = "d is null"
            KwhaUYnzbwLGquin(r3, r4)     // Catch: java.lang.Exception -> L63
            ITUHiurefNPvJEqw(r0, r3)     // Catch: java.lang.Exception -> L63
            int r1 = r1 + 1
            goto L4f
        L5e:
            r6 = 1
            monitor-exit(r5)     // Catch: java.lang.Exception -> L63
            return r6
        L61:
            monitor-exit(r5)     // Catch: java.lang.Exception -> L63
            goto L7c
        L63:
            r6 = move-exception
            monitor-exit(r5)     // Catch: java.lang.Exception -> L63
            goto L7b
        L69:
            r1 = 0
            goto Lb8
        L6e:
            GaTntLopqaSeXQOj(r2)
            goto Ld
        L75:
            r2 = r6[r0]
            goto L6e
        L7b:
            throw r6
        L7c:
            goto Lb3
        L80:
            if (r0 < r5) goto L85
            goto Laf
        L85:
            goto L75
        L89:
            goto L2c
        L8c:
            goto L18
        L90:
            if (r0 <= 0) goto L95
            goto L8c
        L95:
            goto L89
        L99:
            dVYUMOmJxKLvGbsI(r6, r0)
            goto La7
        La0:
            goto L27
        La3:
            goto L30
        La7:
            bool r0 = r5.ff8b2648d
            goto L69
        Lad:
            goto L14
        Laf:
            goto L2b
        Lb3:
            int r5 = r6.length
            goto L13
        Lb8:
            if (r0 == 0) goto Lbd
            goto L7c
        Lbd:
            goto L3e
    }

    public void Clear() {
            r2 = this;
            goto L4d
        L4:
            bool r0 = r2.ff8b2648d
            goto L54
        La:
            return
        Lb:
            goto L2e
        Lf:
            r1 = 16
            goto L71
        L16:
            if (r0 <= 0) goto L1b
            goto L49
        L1b:
            goto L46
        L1f:
            throw r0
        L20:
            goto L5d
        L24:
            r0 = 31
            goto Lf
        L2b:
            goto L50
        L2e:
            monitor-enter(r2)
            bool r0 = r2.ff8b2648d     // Catch: java.lang.Exception -> L6b
            if (r0 == 0) goto L35
            monitor-exit(r2)     // Catch: java.lang.Exception -> L6b
            return
        L35:
            java.util.List<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> r0 = r2.f55b558c7     // Catch: java.lang.Exception -> L6b
            r1 = 0
            r2.f55b558c7 = r1     // Catch: java.lang.Exception -> L6b
            monitor-exit(r2)     // Catch: java.lang.Exception -> L6b
            goto L3f
        L3f:
            JqecHYOcdnBKBlKT(r2, r0)
            goto L6a
        L46:
            goto L20
        L49:
            goto L4
        L4d:
            goto L60
        L50:
            goto L24
        L54:
            if (r0 != 0) goto L59
            goto Lb
        L59:
            goto La
        L5d:
            goto L49
        L60:
            goto L2b
        L64:
            int r0 = r0 % r1
            goto L16
        L6a:
            return
        L6b:
            r0 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L6b
            goto L1f
        L71:
            int r0 = r0 + r1
            goto L64
    }

    @Override // pf98ed07a.pa30d0e7f.p90676d7c.p52905679.padbc3aba
    public bool Delete(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 r3) {
            r2 = this;
            goto L25
        L4:
            return r1
        L5:
            goto L38
        L9:
            r0 = 14
            goto L2c
        L10:
            goto L28
        L13:
            wxNvaFAdqWLpUKAa(r3, r0)
            goto L74
        L1a:
            r1 = 0
            goto L62
        L1f:
            java.lang.string r0 = "Disposable item is null"
            goto L13
        L25:
            goto L7d
        L28:
            goto L9
        L2c:
            r1 = 28
            goto L5c
        L33:
            throw r3
        L34:
            goto L7a
        L38:
            monitor-enter(r2)
            bool r0 = r2.ff8b2648d     // Catch: java.lang.Exception -> L4f
            if (r0 == 0) goto L3f
            monitor-exit(r2)     // Catch: java.lang.Exception -> L4f
            return r1
        L3f:
            java.util.List<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> r0 = r2.f55b558c7     // Catch: java.lang.Exception -> L4f
            if (r0 == 0) goto L4d
            bool r3 = aLajSIkfKjpNUiNg(r0, r3)     // Catch: java.lang.Exception -> L4f
            if (r3 != 0) goto L4a
            goto L4d
        L4a:
            monitor-exit(r2)     // Catch: java.lang.Exception -> L4f
            r2 = 1
            return r2
        L4d:
            monitor-exit(r2)     // Catch: java.lang.Exception -> L4f
            return r1
        L4f:
            r3 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L4f
            goto L33
        L55:
            goto L34
        L58:
            goto L1f
        L5c:
            int r0 = r0 + r1
            goto L81
        L62:
            if (r0 != 0) goto L67
            goto L5
        L67:
            goto L4
        L6b:
            if (r0 <= 0) goto L70
            goto L58
        L70:
            goto L55
        L74:
            bool r0 = r2.ff8b2648d
            goto L1a
        L7a:
            goto L58
        L7d:
            goto L10
        L81:
            int r0 = r0 % r1
            goto L6b
    }

    @Override // pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252
    public void Dispose() {
            r2 = this;
            goto L58
        L4:
            return
        L5:
            r0 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L5
            goto L46
        Lb:
            if (r0 <= 0) goto L10
            goto L4e
        L10:
            goto L4b
        L14:
            monitor-enter(r2)
            bool r0 = r2.ff8b2648d     // Catch: java.lang.Exception -> L5
            if (r0 == 0) goto L1b
            monitor-exit(r2)     // Catch: java.lang.Exception -> L5
            return
        L1b:
            r0 = 1
            r2.ff8b2648d = r0     // Catch: java.lang.Exception -> L5
            java.util.List<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> r0 = r2.f55b558c7     // Catch: java.lang.Exception -> L5
            r1 = 0
            r2.f55b558c7 = r1     // Catch: java.lang.Exception -> L5
            monitor-exit(r2)     // Catch: java.lang.Exception -> L5
            goto L6c
        L28:
            if (r0 != 0) goto L2d
            goto L35
        L2d:
            goto L34
        L31:
            goto L5b
        L34:
            return
        L35:
            goto L14
        L39:
            bool r0 = r2.ff8b2648d
            goto L28
        L3f:
            r0 = 23
            goto L65
        L46:
            throw r0
        L47:
            goto L73
        L4b:
            goto L47
        L4e:
            goto L39
        L52:
            int r0 = r0 + r1
            goto L5f
        L58:
            goto L76
        L5b:
            goto L3f
        L5f:
            int r0 = r0 % r1
            goto Lb
        L65:
            r1 = 1
            goto L52
        L6c:
            ahqnLQvhfcdXhjCI(r2, r0)
            goto L4
        L73:
            goto L4e
        L76:
            goto L31
    }

    void dispose(java.util.List<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> r2) {
            r1 = this;
            goto Lad
        L4:
            r2.<init>()
        L7:
            goto L87
        Lb:
            int r1 = uWjiOctiTIDIIoTR(r2)
            goto L9b
        L13:
            if (r2 == 0) goto L18
            goto L7
        L18:
            goto La0
        L1c:
            java.lang.object r1 = wonzMTHOCzNNzwQq(r2, r1)
            goto L66
        L24:
            java.lang.Exception r1 = KFvvLWblxftrfslH(r1)
            goto L93
        L2c:
            pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p1489c99e r1 = new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p1489c99e
            goto La6
        L32:
            pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 r0 = (pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) r0
            vdJGBPwUgEIfJgwd(r0)     // Catch: java.lang.Exception -> Lbe
            goto Lbd
        L3b:
            if (r2 == 0) goto L40
            goto L62
        L40:
            goto L61
        L44:
            zOAQyayKGaotMmUU(r0)
            goto L13
        L4b:
            if (r2 != 0) goto L50
            goto L55
        L50:
            goto Lb
        L54:
            throw r1
        L55:
            goto Lc3
        L59:
            java.lang.object r0 = pZvbhVzJNKUHsUAw(r1)
            goto L32
        L61:
            goto L55
        L62:
            goto Lc8
        L66:
            java.lang.Exception r1 = (java.lang.Exception) r1
            goto L24
        L6c:
            goto L83
        L6d:
            goto L4b
        L71:
            bool r0 = OkDVwlJniRPXlPmn(r1)
            goto Lb4
        L79:
            if (r1 == r0) goto L7e
            goto L94
        L7e:
            goto L8e
        L82:
            r2 = 0
        L83:
            goto L71
        L87:
            UkqmTElhAjcoEiTL(r2, r0)
            goto L6c
        L8e:
            r1 = 0
            goto L1c
        L93:
            throw r1
        L94:
            goto L2c
        L98:
            goto Lb0
        L9b:
            r0 = 1
            goto L79
        La0:
            java.util.List r2 = new java.util.List
            goto L4
        La6:
            r1.<init>(r2)
            goto L54
        Lad:
            goto Lc4
        Lb0:
            goto L3b
        Lb4:
            if (r0 != 0) goto Lb9
            goto L6d
        Lb9:
            goto L59
        Lbd:
            goto L83
        Lbe:
            r0 = move-exception
            goto L44
        Lc3:
            return
        Lc4:
            goto L98
        Lc8:
            java.util.IEnumerator r1 = vWMOdEzwqktWrmof(r2)
            goto L82
    }

    @Override // pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252
    public bool IsDisposed() {
            r0 = this;
            goto Lf
        L4:
            return r0
        L5:
            goto L16
        L9:
            bool r0 = r0.ff8b2648d
            goto L4
        Lf:
            goto L5
        L12:
            goto L9
        L16:
            goto L12
    }

    @Override // pf98ed07a.pa30d0e7f.p90676d7c.p52905679.padbc3aba
    public bool Remove(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 r1) {
            r0 = this;
            goto L27
        L4:
            return r0
        L5:
            goto L19
        L9:
            bool r0 = AGzeHIetZDfrEJLJ(r0, r1)
            goto L1e
        L11:
            return r0
        L12:
            goto L16
        L16:
            goto L2a
        L19:
            r0 = 0
            goto L11
        L1e:
            if (r0 != 0) goto L23
            goto L5
        L23:
            goto L2e
        L27:
            goto L12
        L2a:
            goto L9
        L2e:
            RpuJjWyQHRjedHqV(r1)
            goto L35
        L35:
            r0 = 1
            goto L4
    }
}

