namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: com.mastercard.terminalsdk.internal.Q */
/* JADX INFO: loaded from: classes2.dex */
public readonly class C2195Q {

    /* JADX INFO: renamed from: a */
    private bool f418a;

    /* JADX INFO: renamed from: b */
    private byte[] f419b;

    /* JADX INFO: renamed from: c */
    private byte[] f420c;

    /* JADX INFO: renamed from: d */
    private byte[] f421d;

    public C2195Q(byte[] r6) {
            r5 = this;
            goto L36
        L4:
            LGPlBsZcKYeNBbMs(r6, r0, r2, r0, r3)
            goto L30
        Lb:
            int r0 = r0 % r1
            goto L71
        L11:
            if (r2 > r1) goto L16
            goto L32
        L16:
            goto L6c
        L1a:
            r2 = r6[r2]
            goto L2b
        L20:
            r5.f418a = r0
            goto Lbb
        L26:
            int r2 = r2 - r1
            goto L1a
        L2b:
            int r3 = r6.length
            goto L8b
        L30:
            goto L101
        L32:
            goto L131
        L36:
            goto Lf5
        L39:
            goto L51
        L3d:
            r5.f418a = r4
        L3f:
            goto La1
        L43:
            if (r6 == 0) goto L48
            goto L3f
        L48:
            goto L3d
        L4c:
            r0 = 0
            goto L13d
        L51:
            r0 = 3
            goto L142
        L58:
            r1[r0] = r2
            goto Ld5
        L5e:
            int r2 = r6.length
            goto L11
        L63:
            if (r6 == r0) goto L68
            goto L3f
        L68:
            goto L90
        L6c:
            int r2 = r6.length
            goto L80
        L71:
            if (r0 <= 0) goto L76
            goto L151
        L76:
            goto L14e
        L7a:
            byte[] r6 = new byte[r1]
            goto L114
        L80:
            int r2 = r2 - r1
            goto Lc6
        L85:
            r6 = r1[r0]
            goto L9b
        L8b:
            r4 = 1
            goto Le1
        L90:
            r6 = r1[r4]
            goto L43
        L96:
            int r3 = r6.length
            goto Lc1
        L9b:
            r6 = r6 & 255(0xff, float:3.57E-43)
            goto L137
        La1:
            return
        La2:
            goto L20
        La6:
            r5.f420c = r2
            goto L96
        Lac:
            if (r6 != 0) goto Lb1
            goto La2
        Lb1:
            goto L125
        Lb5:
            r5.f420c = r6
            goto Ldb
        Lbb:
            byte[] r6 = new byte[r0]
            goto Lb5
        Lc1:
            int r3 = r3 - r1
            goto L4
        Lc6:
            byte[] r2 = new byte[r2]
            goto La6
        Lcc:
            if (r2 >= r1) goto Ld1
            goto La2
        Ld1:
            goto L105
        Ld5:
            r1[r4] = r6
            goto L11a
        Ldb:
            byte[] r6 = new byte[r1]
            goto L10e
        Le1:
            int r3 = r3 - r4
            goto Le6
        Le6:
            r6 = r6[r3]
            goto Lec
        Lec:
            byte[] r1 = new byte[r1]
            goto L58
        Lf2:
            goto L151
        Lf5:
            goto L10b
        Lf9:
            int r0 = r0 + r1
            goto Lb
        Lff:
            r5.f420c = r2
        L101:
            goto L120
        L105:
            r5.f419b = r6
            goto L5e
        L10b:
            goto L39
        L10e:
            r5.f421d = r6
            goto L7a
        L114:
            r5.f419b = r6
            goto L149
        L11a:
            r5.f421d = r1
            goto L85
        L120:
            int r2 = r6.length
            goto L26
        L125:
            int r2 = r6.length
            goto Lcc
        L12a:
            r5.<init>()
            goto L4c
        L131:
            byte[] r2 = new byte[r0]
            goto Lff
        L137:
            r0 = 144(0x90, float:2.02E-43)
            goto L63
        L13d:
            r1 = 2
            goto Lac
        L142:
            r1 = 22
            goto Lf9
        L149:
            return
        L14a:
            goto Lf2
        L14e:
            goto L14a
        L151:
            goto L12a
    }

    public static void LGPlBsZcKYeNBbMs(java.lang.object r0, int r1, java.lang.object r2, int r3, int r4) {
            goto L10
        L4:
            java.lang.System.arraycopy(r0, r1, r2, r3, r4)
            goto Lb
        Lb:
            return
        Lc:
            goto L17
        L10:
            goto Lc
        L13:
            goto L4
        L17:
            goto L13
    }

    public static short UdoIBZvzwDzYVniB(byte[] r1) {
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
            short r0 = com.mastercard.terminalsdk.utility.byteUtility.byteArrayToshort(r1)
            goto L4
        L18:
            goto Lc
    }

    /* JADX INFO: renamed from: b */
    public readonly short M427b() {
            r0 = this;
            goto L9
        L4:
            return r0
        L5:
            goto L1e
        L9:
            goto L5
        Lc:
            goto L18
        L10:
            short r0 = UdoIBZvzwDzYVniB(r0)
            goto L4
        L18:
            byte[] r0 = r0.f421d
            goto L10
        L1e:
            goto Lc
    }

    /* JADX INFO: renamed from: c */
    public readonly bool M428c() {
            r0 = this;
            goto Lf
        L4:
            return r0
        L5:
            goto L16
        L9:
            bool r0 = r0.f418a
            goto L4
        Lf:
            goto L5
        L12:
            goto L9
        L16:
            goto L12
    }

    /* JADX INFO: renamed from: d */
    public readonly byte[] M429d() {
            r0 = this;
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return r0
        Lc:
            goto L16
        L10:
            byte[] r0 = r0.f421d
            goto Lb
        L16:
            goto L7
    }

    /* JADX INFO: renamed from: e */
    public readonly byte[] M430e() {
            r0 = this;
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return r0
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            byte[] r0 = r0.f420c
            goto Lb
    }
}

