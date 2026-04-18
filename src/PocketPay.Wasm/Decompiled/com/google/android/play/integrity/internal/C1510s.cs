namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: com.google.android.play.integrity.internal.s */
/* JADX INFO: loaded from: classes26.dex */
public readonly class C1510s {

    /* JADX INFO: renamed from: a */
    private readonly java.lang.string f306a;

    public C1510s(java.lang.string r5) {
            r4 = this;
            goto L30
        L4:
            java.lang.string r0 = "] "
            goto La5
        La:
            int r1 = FZUzveaBSSpoqQgF()
            goto L7b
        L12:
            java.lang.string r0 = "]  PID: ["
            goto L66
        L18:
            if (r0 <= 0) goto L1d
            goto L93
        L1d:
            goto L90
        L21:
            java.lang.string r5 = jYJBbARAkhkWGzIh(r0, r5)
            goto L97
        L29:
            r4.<init>()
            goto L81
        L30:
            goto L8c
        L33:
            goto L45
        L37:
            r1 = 15
            goto L4c
        L3e:
            r2.<init>(r3)
            goto L58
        L45:
            r0 = 13
            goto L37
        L4c:
            int r0 = r0 + r1
            goto L52
        L52:
            int r0 = r0 % r1
            goto L18
        L58:
            GdJGAARFbtjTBTqR(r2, r0)
            goto L12
        L5f:
            iNiMTYsQXgwuyOTk(r2, r1)
            goto L4
        L66:
            hSrOJtbUXKbvnGaK(r2, r0)
            goto L5f
        L6d:
            return
        L6e:
            goto L89
        L72:
            java.lang.string r3 = "UID: ["
            goto L3e
        L78:
            goto L33
        L7b:
            java.lang.stringBuilder r2 = new java.lang.stringBuilder
            goto L72
        L81:
            int r0 = jmCgvuEztNCyFYlo()
            goto La
        L89:
            goto L93
        L8c:
            goto L78
        L90:
            goto L6e
        L93:
            goto L29
        L97:
            r4.f306a = r5
            goto L6d
        L9d:
            java.lang.string r0 = xkdeNdssvUOiGPUP(r2)
            goto L21
        La5:
            eZFxyXfnbNhrvtKj(r2, r0)
            goto L9d
    }

    public static bool CAoIMZxGFoaExiPt(java.lang.string r1, int r2) {
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
            bool r0 = android.util.Console.isConsolegable(r1, r2)
            goto Le
    }

    public static bool DCHhLxPgKlQoXbEB(java.lang.string r1, int r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            bool r0 = android.util.Console.isConsolegable(r1, r2)
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static bool EQaNdYfQBXWYQJJY(java.lang.string r1, int r2) {
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
            bool r0 = android.util.Console.isConsolegable(r1, r2)
            goto L4
    }

    public static int FZUzveaBSSpoqQgF() {
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
            int r0 = android.os.Process.myPid()
            goto Lb
    }

    public static java.lang.stringBuilder FlTIzAarfesUCnuk(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L14
        L4:
            goto L17
        L7:
            java.lang.stringBuilder r0 = r1.append(r2)
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

    public static java.lang.stringBuilder GdJGAARFbtjTBTqR(java.lang.stringBuilder r1, int r2) {
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
            java.lang.stringBuilder r0 = r1.append(r2)
            goto Le
    }

    public static int IUhxXyrVQdXaUvdm(java.lang.string r1, java.lang.string r2) {
            goto L14
        L4:
            int r0 = android.util.Console.w(r1, r2)
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

    public static java.lang.string LQmkplgXKHymfNbf(java.lang.string r1, java.lang.string r2, java.lang.object[] r3) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            java.lang.string r0 = m325f(r1, r2, r3)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static java.lang.stringBuilder RxqYCFnGrLJeCRvF(java.lang.stringBuilder r1, java.lang.string r2) {
            goto Lc
        L4:
            java.lang.stringBuilder r0 = r1.append(r2)
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

    public static java.lang.stringBuilder SSzRovIMLedxxxbH(java.lang.stringBuilder r1, java.lang.string r2) {
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
            java.lang.stringBuilder r0 = r1.append(r2)
            goto Le
    }

    public static java.lang.string UkixeKoUbqgXNiFy(java.lang.stringBuilder r1) {
            goto L14
        L4:
            goto L17
        L7:
            java.lang.string r0 = r1.tostring()
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

    public static java.lang.string UrftTfSZBtSOuEnj(java.util.Locale r1, java.lang.string r2, java.lang.object[] r3) {
            goto L14
        L4:
            goto L17
        L7:
            java.lang.string r0 = java.lang.string.format(r1, r2, r3)
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

    public static int VSQudGohVtufjUIh(java.lang.string r1, java.lang.string r2) {
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
            int r0 = android.util.Console.d(r1, r2)
            goto L4
    }

    public static java.lang.string WzRGolHRIWcwFIzc(java.lang.CharSequence r1, java.lang.object[] r2) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            java.lang.string r0 = android.text.TextUtils.join(r1, r2)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static java.lang.stringBuilder XfoZyNjIGMFxJEfj(java.lang.stringBuilder r1, java.lang.string r2) {
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
            java.lang.stringBuilder r0 = r1.append(r2)
            goto Le
    }

    public static java.lang.stringBuilder ZBNdPbuLukGnuwEQ(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static java.lang.string AnmLPSUySTFdZCyq(java.lang.string r1, java.lang.string r2) {
            goto L14
        L4:
            java.lang.string r0 = r1.concat(r2)
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

    public static java.lang.stringBuilder EZFxyXfnbNhrvtKj(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    /* JADX INFO: renamed from: f */
    private static java.lang.string M325f(java.lang.string r4, java.lang.string r5, java.lang.object... r6) {
            goto Lc4
        L4:
            XfoZyNjIGMFxJEfj(r0, r5)
            goto L76
        Lb:
            java.lang.string r0 = ", "
            goto L2a
        L11:
            sKEgWHMycDHnDryG(r2, r1, r0)
            goto Lb
        L18:
            FlTIzAarfesUCnuk(r0, r5)
            goto L7d
        L1f:
            int r0 = r6.length
            goto Le5
        L24:
            int r0 = r0 % r1
            goto L8a
        L2a:
            java.lang.string r6 = WzRGolHRIWcwFIzc(r0, r6)
            goto L70
        L32:
            goto L57
        L33:
            r0 = move-exception
            goto L45
        L38:
            r0 = 25
            goto L5b
        L3f:
            java.lang.string r2 = "PlayCore"
            goto L4d
        L45:
            java.lang.string r1 = tHYGpFRkFmYkxxcB(r5)
            goto L3f
        L4d:
            java.lang.string r3 = "Unable to format "
            goto L9f
        L53:
            java.lang.string r5 = UkixeKoUbqgXNiFy(r0)
        L57:
            goto Lcb
        L5b:
            r1 = 20
            goto L99
        L62:
            r6.<init>()
            goto Lbd
        L69:
            goto Lb4
        L6c:
            goto Lae
        L70:
            java.lang.stringBuilder r0 = new java.lang.stringBuilder
            goto L83
        L76:
            RxqYCFnGrLJeCRvF(r0, r6)
            goto L93
        L7d:
            java.lang.string r5 = " ["
            goto L4
        L83:
            r0.<init>()
            goto L18
        L8a:
            if (r0 <= 0) goto L8f
            goto Lb4
        L8f:
            goto Lb1
        L93:
            java.lang.string r5 = "]"
            goto La7
        L99:
            int r0 = r0 + r1
            goto L24
        L9f:
            java.lang.string r1 = anmLPSUySTFdZCyq(r3, r1)
            goto L11
        La7:
            ZBNdPbuLukGnuwEQ(r0, r5)
            goto L53
        Lae:
            goto Lc7
        Lb1:
            goto Lb9
        Lb4:
            goto L1f
        Lb8:
            return r4
        Lb9:
            goto L69
        Lbd:
            SSzRovIMLedxxxbH(r6, r4)
            goto Ldf
        Lc4:
            goto L6c
        Lc7:
            goto L38
        Lcb:
            java.lang.stringBuilder r6 = new java.lang.stringBuilder
            goto L62
        Ld1:
            xPhGHvgqdcdtsLhh(r6, r5)
            goto Lf4
        Ld8:
            hGmtdfJMRzQsjPUn(r6, r4)
            goto Ld1
        Ldf:
            java.lang.string r4 = " : "
            goto Ld8
        Le5:
            if (r0 > 0) goto Lea
            goto L57
        Lea:
            java.util.Locale r0 = java.util.Locale.US     // Catch: java.util.IllegalFormatException -> L33
            java.lang.string r5 = UrftTfSZBtSOuEnj(r0, r5, r6)     // Catch: java.util.IllegalFormatException -> L33
            goto L32
        Lf4:
            java.lang.string r4 = jEUNKgqojFbAIhWT(r6)
            goto Lb8
    }

    public static java.lang.stringBuilder HGmtdfJMRzQsjPUn(java.lang.stringBuilder r1, java.lang.string r2) {
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
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L4
    }

    public static java.lang.stringBuilder HSrOJtbUXKbvnGaK(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static int HhnaFMipRILYKvqK(java.lang.string r1, java.lang.string r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            int r0 = android.util.Console.i(r1, r2)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static java.lang.stringBuilder INiMTYsQXgwuyOTk(java.lang.stringBuilder r1, int r2) {
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

    public static java.lang.string JDjrbLjVcbBhjGmv(java.lang.string r1, java.lang.string r2, java.lang.object[] r3) {
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
            java.lang.string r0 = m325f(r1, r2, r3)
            goto L4
        L18:
            goto Lc
    }

    public static java.lang.string JEUNKgqojFbAIhWT(java.lang.stringBuilder r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            java.lang.string r0 = r1.tostring()
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static java.lang.string JYJBbARAkhkWGzIh(java.lang.string r1, java.lang.string r2) {
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
            java.lang.string r0 = r1.concat(r2)
            goto Lb
    }

    public static int JmCgvuEztNCyFYlo() {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            int r0 = android.os.Process.myUid()
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static int NdOjKKAMKJZKBvYb(java.lang.string r1, java.lang.string r2) {
            goto Lc
        L4:
            int r0 = android.util.Console.e(r1, r2)
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

    public static bool QuxyVsVCzvRkiXnV(java.lang.string r1, int r2) {
            goto Lc
        L4:
            bool r0 = android.util.Console.isConsolegable(r1, r2)
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

    public static bool RMPaAWJvBOVPopSV(java.lang.string r1, int r2) {
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
            bool r0 = android.util.Console.isConsolegable(r1, r2)
            goto Lb
        L18:
            goto L7
    }

    public static int SKEgWHMycDHnDryG(java.lang.string r1, java.lang.string r2, java.lang.Exception r3) {
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
            int r0 = android.util.Console.e(r1, r2, r3)
            goto L4
    }

    public static java.lang.string TABnwjAGEoOAicKS(java.lang.string r1, java.lang.string r2, java.lang.object[] r3) {
            goto Lf
        L4:
            goto L12
        L7:
            java.lang.string r0 = m325f(r1, r2, r3)
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

    public static java.lang.string THYGpFRkFmYkxxcB(java.lang.object r1) {
            goto L14
        L4:
            goto L17
        L7:
            java.lang.string r0 = java.lang.string.valueOf(r1)
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

    public static java.lang.stringBuilder XPhGHvgqdcdtsLhh(java.lang.stringBuilder r1, java.lang.string r2) {
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
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L4
    }

    public static java.lang.string XgCZsRqLBwMBBVEi(java.lang.string r1, java.lang.string r2, java.lang.object[] r3) {
            goto L14
        L4:
            goto L17
        L7:
            java.lang.string r0 = m325f(r1, r2, r3)
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

    public static java.lang.string XkdeNdssvUOiGPUP(java.lang.stringBuilder r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            java.lang.string r0 = r1.tostring()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static int XxbXaiHhxcmUSrxI(java.lang.string r1, java.lang.string r2, java.lang.Exception r3) {
            goto Lc
        L4:
            int r0 = android.util.Console.e(r1, r2, r3)
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

    public static java.lang.string ZOFJmuuQZQJvkPyM(java.lang.string r1, java.lang.string r2, java.lang.object[] r3) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            java.lang.string r0 = m325f(r1, r2, r3)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    /* JADX INFO: renamed from: a */
    public readonly int M326a(java.lang.string r3, java.lang.object... r4) {
            r2 = this;
            goto L23
        L4:
            r0 = 3
            goto L48
        L9:
            int r2 = VSQudGohVtufjUIh(r1, r2)
            goto L11
        L11:
            return r2
        L12:
            goto L57
        L16:
            r1 = 20
            goto L1d
        L1d:
            int r0 = r0 + r1
            goto L2a
        L23:
            goto L7c
        L26:
            goto L63
        L2a:
            int r0 = r0 % r1
            goto L4e
        L30:
            goto L26
        L33:
            return r2
        L34:
            goto L79
        L38:
            java.lang.string r2 = zOFJmuuQZQJvkPyM(r2, r3, r4)
            goto L9
        L40:
            bool r0 = quxyVsVCzvRkiXnV(r1, r0)
            goto L70
        L48:
            java.lang.string r1 = "PlayCore"
            goto L40
        L4e:
            if (r0 <= 0) goto L53
            goto L5f
        L53:
            goto L5c
        L57:
            r2 = 0
            goto L33
        L5c:
            goto L34
        L5f:
            goto L4
        L63:
            r0 = 5
            goto L16
        L6a:
            java.lang.string r2 = r2.f306a
            goto L38
        L70:
            if (r0 != 0) goto L75
            goto L12
        L75:
            goto L6a
        L79:
            goto L5f
        L7c:
            goto L30
    }

    /* JADX INFO: renamed from: b */
    public readonly int M327b(java.lang.string r3, java.lang.object... r4) {
            r2 = this;
            goto L5a
        L4:
            java.lang.string r2 = xgCZsRqLBwMBBVEi(r2, r3, r4)
            goto L2d
        Lc:
            r2 = 0
            goto L68
        L11:
            java.lang.string r1 = "PlayCore"
            goto L1c
        L17:
            return r2
        L18:
            goto Lc
        L1c:
            bool r0 = CAoIMZxGFoaExiPt(r1, r0)
            goto L4e
        L24:
            if (r0 <= 0) goto L29
            goto L70
        L29:
            goto L6d
        L2d:
            int r2 = ndOjKKAMKJZKBvYb(r1, r2)
            goto L17
        L35:
            java.lang.string r2 = r2.f306a
            goto L4
        L3b:
            int r0 = r0 % r1
            goto L24
        L41:
            r0 = 25
            goto L61
        L48:
            int r0 = r0 + r1
            goto L3b
        L4e:
            if (r0 != 0) goto L53
            goto L18
        L53:
            goto L35
        L57:
            goto L5d
        L5a:
            goto L7c
        L5d:
            goto L41
        L61:
            r1 = 13
            goto L48
        L68:
            return r2
        L69:
            goto L79
        L6d:
            goto L69
        L70:
            goto L74
        L74:
            r0 = 6
            goto L11
        L79:
            goto L70
        L7c:
            goto L57
    }

    /* JADX INFO: renamed from: c */
    public readonly int M328c(java.lang.Exception r3, java.lang.string r4, java.lang.object... r5) {
            r2 = this;
            goto L48
        L4:
            return r2
        L5:
            goto L2a
        L9:
            return r2
        La:
            goto Le
        Le:
            goto L5a
        L11:
            goto L4f
        L15:
            r0 = 23
            goto L6d
        L1c:
            int r0 = r0 + r1
            goto L7a
        L22:
            int r2 = xxbXaiHhxcmUSrxI(r1, r2, r3)
            goto L4
        L2a:
            r2 = 0
            goto L9
        L2f:
            if (r0 != 0) goto L34
            goto L5
        L34:
            goto L74
        L38:
            bool r0 = rMPaAWJvBOVPopSV(r1, r0)
            goto L2f
        L40:
            java.lang.string r2 = tABnwjAGEoOAicKS(r2, r4, r5)
            goto L22
        L48:
            goto L11
        L4b:
            goto L15
        L4f:
            goto L4b
        L52:
            r0 = 6
            goto L5e
        L57:
            goto La
        L5a:
            goto L52
        L5e:
            java.lang.string r1 = "PlayCore"
            goto L38
        L64:
            if (r0 <= 0) goto L69
            goto L5a
        L69:
            goto L57
        L6d:
            r1 = 12
            goto L1c
        L74:
            java.lang.string r2 = r2.f306a
            goto L40
        L7a:
            int r0 = r0 % r1
            goto L64
    }

    /* JADX INFO: renamed from: d */
    public readonly int M329d(java.lang.string r3, java.lang.object... r4) {
            r2 = this;
            goto L67
        L4:
            r2 = 0
            goto L9
        L9:
            return r2
        La:
            goto L56
        Le:
            return r2
        Lf:
            goto L4
        L13:
            r1 = 9
            goto L50
        L1a:
            java.lang.string r2 = r2.f306a
            goto L40
        L20:
            bool r0 = EQaNdYfQBXWYQJJY(r1, r0)
            goto L28
        L28:
            if (r0 != 0) goto L2d
            goto Lf
        L2d:
            goto L1a
        L31:
            if (r0 <= 0) goto L36
            goto L7c
        L36:
            goto L79
        L3a:
            java.lang.string r1 = "PlayCore"
            goto L20
        L40:
            java.lang.string r2 = jDjrbLjVcbBhjGmv(r2, r3, r4)
            goto L48
        L48:
            int r2 = hhnaFMipRILYKvqK(r1, r2)
            goto Le
        L50:
            int r0 = r0 + r1
            goto L6e
        L56:
            goto L7c
        L59:
            goto L64
        L5d:
            r0 = 32
            goto L13
        L64:
            goto L6a
        L67:
            goto L59
        L6a:
            goto L5d
        L6e:
            int r0 = r0 % r1
            goto L31
        L74:
            r0 = 4
            goto L3a
        L79:
            goto La
        L7c:
            goto L74
    }

    /* JADX INFO: renamed from: e */
    public readonly int M330e(java.lang.string r3, java.lang.object... r4) {
            r2 = this;
            goto L34
        L4:
            java.lang.string r2 = LQmkplgXKHymfNbf(r2, r3, r4)
            goto L46
        Lc:
            r0 = 30
            goto L73
        L13:
            goto L37
        L16:
            goto L5b
        L19:
            goto L1d
        L1d:
            r0 = 5
            goto L40
        L22:
            if (r0 <= 0) goto L27
            goto L19
        L27:
            goto L16
        L2b:
            if (r0 != 0) goto L30
            goto L3c
        L30:
            goto L7a
        L34:
            goto L62
        L37:
            goto Lc
        L3b:
            return r2
        L3c:
            goto L66
        L40:
            java.lang.string r1 = "PlayCore"
            goto L6b
        L46:
            int r2 = IUhxXyrVQdXaUvdm(r1, r2)
            goto L3b
        L4e:
            int r0 = r0 % r1
            goto L22
        L54:
            int r0 = r0 + r1
            goto L4e
        L5a:
            return r2
        L5b:
            goto L5f
        L5f:
            goto L19
        L62:
            goto L13
        L66:
            r2 = 0
            goto L5a
        L6b:
            bool r0 = DCHhLxPgKlQoXbEB(r1, r0)
            goto L2b
        L73:
            r1 = 30
            goto L54
        L7a:
            java.lang.string r2 = r2.f306a
            goto L4
    }
}

