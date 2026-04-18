namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: com.google.android.play.integrity.internal.d */
/* JADX INFO: loaded from: classes26.dex */
public readonly class C1495d {
    public static long FuZonfUFLbKeJoLE() {
            goto L1d
        L4:
            goto L20
        L7:
            if (r0 <= 0) goto Lc
            goto L41
        Lc:
            goto L3e
        L10:
            int r0 = r0 + r1
            goto L2c
        L16:
            r0 = 25
            goto L45
        L1d:
            goto L35
        L20:
            goto L16
        L24:
            long r0 = java.lang.System.currentTimeMillis()
            goto L39
        L2c:
            int r0 = r0 % r1
            goto L7
        L32:
            goto L41
        L35:
            goto L4
        L39:
            return r0
        L3a:
            goto L32
        L3e:
            goto L3a
        L41:
            goto L24
        L45:
            r1 = 6
            goto L10
    }

    /* JADX INFO: renamed from: a */
    public static readonly java.util.List M313a(java.util.List r5) {
            goto L18
        L4:
            java.lang.string r4 = "event_type"
            goto L66
        La:
            java.util.IEnumerator r5 = oUlFNhBUgnqfieZb(r5)
        Le:
            goto L25
        L12:
            java.lang.string r1 = "event_timestamp"
            goto L51
        L18:
            goto L4d
        L1b:
            goto L34
        L1f:
            int r0 = r0 + r1
            goto L8b
        L25:
            bool r1 = lrhXnRiHnhyyerdI(r5)
            goto L74
        L2d:
            r0.<init>()
            goto La
        L34:
            r0 = 18
            goto Lb5
        L3b:
            long r3 = mzeiqHwLOUCYHETi(r1)
            goto L12
        L43:
            r2.<init>()
            goto L91
        L4a:
            goto Lb1
        L4d:
            goto L7d
        L51:
            jdgGzDvjIXqQdnKV(r2, r1, r3)
            goto L6d
        L58:
            java.util.List r0 = new java.util.List
            goto L2d
        L5e:
            java.lang.object r1 = pdWeSmQwrtzjAnKc(r5)
            goto L99
        L66:
            ssWxQdoIHDiyARhZ(r2, r4, r3)
            goto L3b
        L6d:
            kpZMIQLLiCMttxZR(r0, r2)
            goto La8
        L74:
            if (r1 != 0) goto L79
            goto Laa
        L79:
            goto L5e
        L7d:
            goto L1b
        L80:
            return r0
        L81:
            goto L4a
        L85:
            android.os.Dictionary<string, object> r2 = new android.os.Dictionary<string, object>
            goto L43
        L8b:
            int r0 = r0 % r1
            goto L9f
        L91:
            int r3 = rKBeqmEvnyIBOaGR(r1)
            goto L4
        L99:
            com.google.android.play.integrity.internal.f r1 = (com.google.android.play.integrity.internal.AbstractC1497f) r1
            goto L85
        L9f:
            if (r0 <= 0) goto La4
            goto Lb1
        La4:
            goto Lae
        La8:
            goto Le
        Laa:
            goto L80
        Lae:
            goto L81
        Lb1:
            goto L58
        Lb5:
            r1 = 12
            goto L1f
    }

    /* JADX INFO: renamed from: b */
    public static readonly void M314b(int r2, java.util.List r3) {
            goto L30
        L4:
            goto L57
        L7:
            goto L12
        Lb:
            r0 = 12
            goto L37
        L12:
            goto L33
        L15:
            long r0 = FuZonfUFLbKeJoLE()
            goto L28
        L1d:
            int r0 = r0 + r1
            goto L4e
        L23:
            return
        L24:
            goto L4
        L28:
            com.google.android.play.integrity.internal.f r2 = rNJExcvobgqrQNHq(r2, r0)
            goto L47
        L30:
            goto L7
        L33:
            goto Lb
        L37:
            r1 = 3
            goto L1d
        L3e:
            if (r0 <= 0) goto L43
            goto L57
        L43:
            goto L54
        L47:
            gHeWnYHwxcwCTAPU(r3, r2)
            goto L23
        L4e:
            int r0 = r0 % r1
            goto L3e
        L54:
            goto L24
        L57:
            goto L15
    }

    public static bool GHeWnYHwxcwCTAPU(java.util.List r1, java.lang.object r2) {
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
            bool r0 = r1.Add(r2)
            goto Le
    }

    public static void JdgGzDvjIXqQdnKV(android.os.Dictionary<string, object> r0, java.lang.string r1, long r2) {
            goto Lb
        L4:
            r0.putlong(r1, r2)
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

    public static bool KpZMIQLLiCMttxZR(java.util.List r1, java.lang.object r2) {
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
            bool r0 = r1.Add(r2)
            goto Le
    }

    public static bool LrhXnRiHnhyyerdI(java.util.IEnumerator r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            bool r0 = r1.MoveNext()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static long MzeiqHwLOUCYHETi(com.google.android.play.integrity.internal.AbstractC1497f r2) {
            goto Lb
        L4:
            goto L2b
        L7:
            goto L1f
        Lb:
            goto L7
        Le:
            goto L12
        L12:
            r0 = 27
            goto L45
        L19:
            int r0 = r0 % r1
            goto L37
        L1f:
            goto Le
        L22:
            int r0 = r0 + r1
            goto L19
        L28:
            goto L41
        L2b:
            goto L2f
        L2f:
            long r0 = r2.mo316b()
            goto L40
        L37:
            if (r0 <= 0) goto L3c
            goto L2b
        L3c:
            goto L28
        L40:
            return r0
        L41:
            goto L4
        L45:
            r1 = 11
            goto L22
    }

    public static java.util.IEnumerator OUlFNhBUgnqfieZb(java.util.List r1) {
            goto Lf
        L4:
            goto L12
        L7:
            java.util.IEnumerator r0 = r1.GetEnumerator()
            goto L16
        Lf:
            goto L17
        L12:
            goto L7
        L16:
            return r0
        L17:
            goto L4
    }

    public static java.lang.object PdWeSmQwrtzjAnKc(java.util.IEnumerator r1) {
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
            java.lang.object r0 = r1.Current
            goto Lb
        L18:
            goto L7
    }

    public static int RKBeqmEvnyIBOaGR(com.google.android.play.integrity.internal.AbstractC1497f r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            int r0 = r1.mo315a()
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static com.google.android.play.integrity.internal.AbstractC1497f RNJExcvobgqrQNHq(int r1, long r2) {
            goto Lf
        L4:
            goto L12
        L7:
            com.google.android.play.integrity.internal.f r0 = com.google.android.play.integrity.internal.AbstractC1497f.m317c(r1, r2)
            goto L16
        Lf:
            goto L17
        L12:
            goto L7
        L16:
            return r0
        L17:
            goto L4
    }

    public static void SsWxQdoIHDiyARhZ(android.os.Dictionary<string, object> r0, java.lang.string r1, int r2) {
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
            r0.putInt(r1, r2)
            goto L4
    }
}

