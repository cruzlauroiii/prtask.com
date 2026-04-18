namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: com.mastercard.terminalsdk.internal.N */
/* JADX INFO: loaded from: classes2.dex */
public abstract class AbstractC2194N {

    /* JADX INFO: renamed from: a */
    private byte[] f411a;

    /* JADX INFO: renamed from: b */
    private java.lang.string f412b;

    /* JADX INFO: renamed from: c */
    private readonly int f413c;

    /* JADX INFO: renamed from: d */
    private byte[] f414d;

    /* JADX INFO: renamed from: e */
    private byte f415e;

    /* JADX INFO: renamed from: g */
    private byte f416g;

    /* JADX INFO: renamed from: i */
    private bool f417i;

    public AbstractC2194N(byte r2, byte r3, byte r4, byte r5, byte r6) {
            r1 = this;
            goto L30
        L4:
            r1.f416g = r6
            goto L1f
        La:
            r0 = 0
            goto L4e
        Lf:
            r1.f417i = r2
            goto L2b
        L15:
            kuFnVQMYWeaooHDX(r1, r2, r3, r4, r5)
            goto L4
        L1c:
            goto L33
        L1f:
            r2 = 1
            goto Lf
        L24:
            r1.<init>()
            goto L49
        L2b:
            return
        L2c:
            goto L1c
        L30:
            goto L2c
        L33:
            goto L24
        L37:
            r1.f412b = r0
            goto La
        L3d:
            r1.f413c = r0
            goto L43
        L43:
            java.lang.string r0 = ""
            goto L37
        L49:
            r0 = 4
            goto L3d
        L4e:
            r1.f417i = r0
            goto L15
    }

    public AbstractC2194N(byte r2, byte r3, byte r4, byte r5, byte[] r6) {
            r1 = this;
            goto L19
        L4:
            r0 = 0
            goto L44
        L9:
            IELGYFCMgXqGulkm(r1, r2, r3, r4, r5)
            goto L20
        L10:
            goto L1c
        L13:
            r1.f412b = r0
            goto L4
        L19:
            goto L3b
        L1c:
            goto L2d
        L20:
            QnQNzjvTbtObwFkB(r1, r6)
            goto L3a
        L27:
            r1.f413c = r0
            goto L34
        L2d:
            r1.<init>()
            goto L3f
        L34:
            java.lang.string r0 = ""
            goto L13
        L3a:
            return
        L3b:
            goto L10
        L3f:
            r0 = 4
            goto L27
        L44:
            r1.f417i = r0
            goto L9
    }

    public AbstractC2194N(byte r2, byte r3, byte r4, byte r5, byte[] r6, byte r7) {
            r1 = this;
            goto L29
        L4:
            r0 = 0
            goto L10
        L9:
            gQsmcYldjvHELPnc(r1, r2, r3, r4, r5)
            goto L54
        L10:
            r1.f417i = r0
            goto L9
        L16:
            r1.f412b = r0
            goto L4
        L1c:
            r1.<init>()
            goto L4f
        L23:
            r1.f416g = r7
            goto L4a
        L29:
            goto L46
        L2c:
            goto L1c
        L30:
            r1.f417i = r2
            goto L45
        L36:
            r1.f413c = r0
            goto L3c
        L3c:
            java.lang.string r0 = ""
            goto L16
        L42:
            goto L2c
        L45:
            return
        L46:
            goto L42
        L4a:
            r2 = 1
            goto L30
        L4f:
            r0 = 4
            goto L36
        L54:
            FfEODVctIOzHvQdy(r1, r6)
            goto L23
    }

    public static void FfEODVctIOzHvQdy(com.mastercard.terminalsdk.internal.AbstractC2194N r0, byte[] r1) {
            goto L4
        L4:
            goto L16
        L7:
            goto Lb
        Lb:
            r0.m424b(r1)
            goto L15
        L12:
            goto L7
        L15:
            return
        L16:
            goto L12
    }

    public static void IELGYFCMgXqGulkm(com.mastercard.terminalsdk.internal.AbstractC2194N r0, byte r1, byte r2, byte r3, byte r4) {
            goto Le
        L4:
            goto L11
        L7:
            r0.m425d(r1, r2, r3, r4)
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

    public static void QnQNzjvTbtObwFkB(com.mastercard.terminalsdk.internal.AbstractC2194N r0, byte[] r1) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            r0.m424b(r1)
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public static void AgyDumwmREQuJFzh(java.lang.object r0, int r1, java.lang.object r2, int r3, int r4) {
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
            java.lang.System.arraycopy(r0, r1, r2, r3, r4)
            goto L4
    }

    /* JADX INFO: renamed from: b */
    private void M424b(byte[] r2) {
            r1 = this;
            goto L19
        L4:
            return
        L5:
            goto L20
        L9:
            byte r0 = (byte) r0
            goto L23
        Le:
            r1.f414d = r2
            goto L4
        L14:
            int r0 = r2.length
            goto L9
        L19:
            goto L5
        L1c:
            goto L14
        L20:
            goto L1c
        L23:
            r1.f415e = r0
            goto Le
    }

    public static void CwjQvMpUsEIQQwwl(java.lang.object r0, int r1, java.lang.object r2, int r3, int r4) {
            goto Le
        L4:
            java.lang.System.arraycopy(r0, r1, r2, r3, r4)
            goto L15
        Lb:
            goto L11
        Le:
            goto L16
        L11:
            goto L4
        L15:
            return
        L16:
            goto Lb
    }

    /* JADX INFO: renamed from: d */
    private readonly void M425d(byte r2, byte r3, byte r4, byte r5) {
            r1 = this;
            goto L44
        L4:
            r1 = 0
            goto L14
        L9:
            r0 = 4
            goto L25
        Le:
            r0[r1] = r3
            goto L2b
        L14:
            r0[r1] = r2
            goto L3f
        L1a:
            r1.f411a = r0
            goto L4
        L20:
            r1 = 3
            goto L30
        L25:
            byte[] r0 = new byte[r0]
            goto L1a
        L2b:
            r1 = 2
            goto L36
        L30:
            r0[r1] = r5
            goto L4b
        L36:
            r0[r1] = r4
            goto L20
        L3c:
            goto L47
        L3f:
            r1 = 1
            goto Le
        L44:
            goto L4c
        L47:
            goto L9
        L4b:
            return
        L4c:
            goto L3c
    }

    public static void GQsmcYldjvHELPnc(com.mastercard.terminalsdk.internal.AbstractC2194N r0, byte r1, byte r2, byte r3, byte r4) {
            goto L4
        L4:
            goto L16
        L7:
            goto Lb
        Lb:
            r0.m425d(r1, r2, r3, r4)
            goto L15
        L12:
            goto L7
        L15:
            return
        L16:
            goto L12
    }

    public static java.lang.string KESTzImOHURYhGOW(java.lang.object r1) {
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
            java.lang.string r0 = super.tostring()
            goto Lb
        L18:
            goto L7
    }

    public static void KuFnVQMYWeaooHDX(com.mastercard.terminalsdk.internal.AbstractC2194N r0, byte r1, byte r2, byte r3, byte r4) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            r0.m425d(r1, r2, r3, r4)
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    /* JADX INFO: renamed from: e */
    public readonly byte[] M426e() {
            r7 = this;
            goto L4d
        L4:
            r1 = 5
            goto L7a
        L9:
            r1 = 15
            goto L69
        L10:
            goto L35
        L13:
            goto L22
        L17:
            byte[] r3 = new byte[r0]
            goto Lb5
        L1d:
            int r0 = r0 + r1
            goto Ld3
        L22:
            goto L50
        L25:
            cwjQvMpUsEIQQwwl(r4, r5, r3, r1, r2)
        L28:
            goto La0
        L2c:
            r3[r0] = r7
        L2e:
            goto L9b
        L32:
            goto L9c
        L35:
            goto L6f
        L39:
            byte r7 = r7.f416g
            goto L2c
        L3f:
            if (r0 != 0) goto L44
            goto Ld5
        L44:
            goto L75
        L48:
            r0 = r2
        L49:
            goto Ld9
        L4d:
            goto L13
        L50:
            goto L8b
        L54:
            byte r6 = r7.f415e
            goto L7f
        L5a:
            if (r4 != 0) goto L5f
            goto L28
        L5f:
            goto L54
        L63:
            int r0 = r0 + (-1)
            goto L39
        L69:
            int r0 = r0 + r1
            goto Lcd
        L6f:
            byte[] r0 = r7.f414d
            goto L4
        L75:
            int r0 = r0.length
            goto L1d
        L7a:
            r2 = 4
            goto L3f
        L7f:
            r3[r2] = r6
            goto Lc0
        L85:
            int r0 = r0 + 1
        L87:
            goto L17
        L8b:
            r0 = 22
            goto L9
        L92:
            if (r3 != 0) goto L97
            goto L87
        L97:
            goto L85
        L9b:
            return r3
        L9c:
            goto L10
        La0:
            bool r1 = r7.f417i
            goto La6
        La6:
            if (r1 != 0) goto Lab
            goto L2e
        Lab:
            goto L63
        Laf:
            byte[] r4 = r7.f414d
            goto L5a
        Lb5:
            byte[] r4 = r7.f411a
            goto Lbb
        Lbb:
            r5 = 0
            goto Lc6
        Lc0:
            r2 = r6 & 255(0xff, float:3.57E-43)
            goto L25
        Lc6:
            agyDumwmREQuJFzh(r4, r5, r3, r5, r2)
            goto Laf
        Lcd:
            int r0 = r0 % r1
            goto Ldf
        Ld3:
            goto L49
        Ld5:
            goto L48
        Ld9:
            bool r3 = r7.f417i
            goto L92
        Ldf:
            if (r0 <= 0) goto Le4
            goto L35
        Le4:
            goto L32
    }

    public readonly java.lang.string Tostring() {
            r0 = this;
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            java.lang.string r0 = kESTzImOHURYhGOW(r0)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }
}

