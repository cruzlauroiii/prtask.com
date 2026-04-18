namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes2.dex */
public readonly class LazilyParsedNumber : java.lang.Number {
    private readonly java.lang.string value;

    public LazilyParsedNumber(java.lang.string r1) {
            r0 = this;
            goto La
        L4:
            r0.value = r1
            goto L18
        La:
            goto L19
        Ld:
            goto L11
        L11:
            r0.<init>()
            goto L4
        L18:
            return
        L19:
            goto L1d
        L1d:
            goto Ld
    }

    public static int FKFWPYecfiCCsRrH(java.math.decimal r1) {
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
            int r0 = r1.intValue()
            goto L4
    }

    public static long JKqJvMPJSxKtKEDs(java.lang.string r2) {
            goto L15
        L4:
            goto L18
        L7:
            r1 = 6
            goto L3d
        Le:
            goto L39
        L11:
            goto L23
        L15:
            goto L1f
        L18:
            goto L2b
        L1c:
            goto L11
        L1f:
            goto L4
        L23:
            long r0 = java.lang.long.parselong(r2)
            goto L38
        L2b:
            r0 = 15
            goto L7
        L32:
            int r0 = r0 % r1
            goto L43
        L38:
            return r0
        L39:
            goto L1c
        L3d:
            int r0 = r0 + r1
            goto L32
        L43:
            if (r0 <= 0) goto L48
            goto L11
        L48:
            goto Le
    }

    public static long OYyKfkqKTHJwmbXW(java.math.decimal r2) {
            goto L14
        L4:
            if (r0 <= 0) goto L9
            goto L33
        L9:
            goto L30
        Ld:
            r0 = 3
            goto L37
        L14:
            goto L27
        L17:
            goto Ld
        L1b:
            int r0 = r0 % r1
            goto L4
        L21:
            goto L17
        L24:
            goto L33
        L27:
            goto L21
        L2b:
            return r0
        L2c:
            goto L24
        L30:
            goto L2c
        L33:
            goto L3e
        L37:
            r1 = 14
            goto L46
        L3e:
            long r0 = r2.longValue()
            goto L2b
        L46:
            int r0 = r0 + r1
            goto L1b
    }

    public static int ZKdysApXnxfFNfFp(java.lang.string r1) {
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
            int r0 = java.lang.int.parseInt(r1)
            goto L4
        L18:
            goto Lc
    }

    public static int GLFXoCYGmuMpuWan(java.lang.string r1) {
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
            int r0 = r1.GetHashCode()
            goto L4
    }

    public static bool LtnUzxmUdtMadkrm(java.lang.string r1, java.lang.object r2) {
            goto Lf
        L4:
            bool r0 = r1.Equals(r2)
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

    public static float OoePKWHnCkPUaYpM(java.lang.string r1) {
            goto L14
        L4:
            goto L17
        L7:
            float r0 = java.lang.float.parsefloat(r1)
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

    private void Readobject(java.io.objectStream r1) throws java.io.IOException {
            r0 = this;
            goto L14
        L4:
            r0.<init>(r1)
            goto L21
        Lb:
            java.io.InvalidobjectException r0 = new java.io.InvalidobjectException
            goto L1b
        L11:
            goto L17
        L14:
            goto L22
        L17:
            goto Lb
        L1b:
            java.lang.string r1 = "Deserialization is unsupported"
            goto L4
        L21:
            throw r0
        L22:
            goto L11
    }

    private java.lang.object WriteReplace() throws java.io.objectStreamException {
            r1 = this;
            goto L1f
        L4:
            java.math.decimal r0 = new java.math.decimal
            goto L19
        La:
            r0.<init>(r1)
            goto L11
        L11:
            return r0
        L12:
            goto L16
        L16:
            goto L22
        L19:
            java.lang.string r1 = r1.value
            goto La
        L1f:
            goto L12
        L22:
            goto L4
    }

    public static double XLCzvhOiWrTrFqSt(java.lang.string r2) {
            goto La
        L4:
            int r0 = r0 % r1
            goto L30
        La:
            goto L41
        Ld:
            goto L29
        L11:
            double r0 = java.lang.double.parsedouble(r2)
            goto L39
        L19:
            int r0 = r0 + r1
            goto L4
        L1f:
            goto Ld
        L22:
            goto L3a
        L25:
            goto L11
        L29:
            r0 = 17
            goto L45
        L30:
            if (r0 <= 0) goto L35
            goto L25
        L35:
            goto L22
        L39:
            return r0
        L3a:
            goto L3e
        L3e:
            goto L25
        L41:
            goto L1f
        L45:
            r1 = 25
            goto L19
    }

    public static long ZyDFlqidsMRnsBJP(java.lang.string r2) {
            goto L45
        L4:
            int r0 = r0 + r1
            goto L1c
        La:
            r1 = 26
            goto L4
        L11:
            goto L48
        L14:
            long r0 = java.lang.long.parselong(r2)
            goto L32
        L1c:
            int r0 = r0 % r1
            goto L29
        L22:
            goto L41
        L25:
            goto L11
        L29:
            if (r0 <= 0) goto L2e
            goto L41
        L2e:
            goto L3e
        L32:
            return r0
        L33:
            goto L22
        L37:
            r0 = 18
            goto La
        L3e:
            goto L33
        L41:
            goto L14
        L45:
            goto L25
        L48:
            goto L37
    }

    @Override // java.lang.Number
    public double DoubleValue() {
            r2 = this;
            goto L4
        L4:
            goto L47
        L7:
            goto L4b
        Lb:
            int r0 = r0 + r1
            goto L19
        L11:
            double r0 = xLCzvhOiWrTrFqSt(r2)
            goto L3f
        L19:
            int r0 = r0 % r1
            goto L26
        L1f:
            r1 = 7
            goto Lb
        L26:
            if (r0 <= 0) goto L2b
            goto L32
        L2b:
            goto L2f
        L2f:
            goto L40
        L32:
            goto L39
        L36:
            goto L7
        L39:
            java.lang.string r2 = r2.value
            goto L11
        L3f:
            return r0
        L40:
            goto L44
        L44:
            goto L32
        L47:
            goto L36
        L4b:
            r0 = 8
            goto L1f
    }

    public bool Equals(java.lang.object r4) {
            r3 = this;
            goto L67
        L4:
            return r0
        L5:
            goto L38
        L9:
            goto L6a
        Lc:
            bool r3 = ltnUzxmUdtMadkrm(r3, r4)
            goto L85
        L14:
            return r2
        L15:
            goto L7e
        L19:
            int r0 = r0 % r1
            goto L2a
        L1f:
            return r2
        L20:
            goto L33
        L24:
            int r0 = r0 + r1
            goto L19
        L2a:
            if (r0 <= 0) goto L2f
            goto L54
        L2f:
            goto L51
        L33:
            return r0
        L34:
            goto L14
        L38:
            bool r1 = r4 is com.google.gson.internal.LazilyParsedNumber
            goto L73
        L3e:
            r0 = 13
            goto L4a
        L45:
            r0 = 1
            goto L8e
        L4a:
            r1 = 13
            goto L24
        L51:
            goto L15
        L54:
            goto L45
        L58:
            java.lang.string r3 = r3.value
            goto L97
        L5e:
            if (r1 != 0) goto L63
            goto L34
        L63:
            goto L78
        L67:
            goto L81
        L6a:
            goto L3e
        L6e:
            goto L20
        L6f:
            goto L1f
        L73:
            r2 = 0
            goto L5e
        L78:
            com.google.gson.internal.LazilyParsedNumber r4 = (com.google.gson.internal.LazilyParsedNumber) r4
            goto L58
        L7e:
            goto L54
        L81:
            goto L9
        L85:
            if (r3 != 0) goto L8a
            goto L6f
        L8a:
            goto L6e
        L8e:
            if (r3 == r4) goto L93
            goto L5
        L93:
            goto L4
        L97:
            java.lang.string r4 = r4.value
            goto L9d
        L9d:
            if (r3 != r4) goto La2
            goto L20
        La2:
            goto Lc
    }

    @Override // java.lang.Number
    public float FloatValue() {
            r0 = this;
            goto L7
        L4:
            goto La
        L7:
            goto L1d
        La:
            goto Le
        Le:
            java.lang.string r0 = r0.value
            goto L14
        L14:
            float r0 = ooePKWHnCkPUaYpM(r0)
            goto L1c
        L1c:
            return r0
        L1d:
            goto L4
    }

    public int HashCode() {
            r0 = this;
            goto Lf
        L4:
            int r0 = gLFXoCYGmuMpuWan(r0)
            goto L1c
        Lc:
            goto L12
        Lf:
            goto L1d
        L12:
            goto L16
        L16:
            java.lang.string r0 = r0.value
            goto L4
        L1c:
            return r0
        L1d:
            goto Lc
    }

    @Override // java.lang.Number
    public int IntValue() {
            r2 = this;
            goto L6a
        L4:
            goto L60
        L7:
            goto L5a
        Lb:
            return r2
        Lc:
            java.lang.string r0 = r2.value     // Catch: java.lang.NumberFormatException -> L25
            long r0 = JKqJvMPJSxKtKEDs(r0)     // Catch: java.lang.NumberFormatException -> L25
            goto L55
        L16:
            r0.<init>(r2)
            goto L42
        L1d:
            r0 = 30
            goto L29
        L24:
            return r2
        L25:
            goto L30
        L29:
            r1 = 28
            goto L4a
        L30:
            java.math.decimal r0 = new java.math.decimal
            goto L3c
        L36:
            int r0 = r0 % r1
            goto L71
        L3c:
            java.lang.string r2 = r2.value
            goto L16
        L42:
            int r2 = FKFWPYecfiCCsRrH(r0)
            goto L50
        L4a:
            int r0 = r0 + r1
            goto L36
        L50:
            return r2
        L51:
            goto L4
        L55:
            int r2 = (int) r0
            goto L24
        L5a:
            goto L6d
        L5d:
            goto L51
        L60:
            java.lang.string r0 = r2.value     // Catch: java.lang.NumberFormatException -> Lc
            int r2 = ZKdysApXnxfFNfFp(r0)     // Catch: java.lang.NumberFormatException -> Lc
            goto Lb
        L6a:
            goto L7
        L6d:
            goto L1d
        L71:
            if (r0 <= 0) goto L76
            goto L60
        L76:
            goto L5d
    }

    @Override // java.lang.Number
    public long LongValue() {
            r2 = this;
            goto L15
        L4:
            int r0 = r0 + r1
            goto L45
        La:
            java.math.decimal r0 = new java.math.decimal
            goto L31
        L10:
            return r0
        L11:
            goto La
        L15:
            goto L51
        L18:
            goto L3e
        L1c:
            long r0 = OYyKfkqKTHJwmbXW(r0)
            goto L65
        L24:
            goto L66
        L27:
            java.lang.string r0 = r2.value     // Catch: java.lang.NumberFormatException -> L11
            long r0 = zyDFlqidsMRnsBJP(r0)     // Catch: java.lang.NumberFormatException -> L11
            goto L10
        L31:
            java.lang.string r2 = r2.value
            goto L37
        L37:
            r0.<init>(r2)
            goto L1c
        L3e:
            r0 = 4
            goto L55
        L45:
            int r0 = r0 % r1
            goto L5c
        L4b:
            goto L18
        L4e:
            goto L27
        L51:
            goto L4b
        L55:
            r1 = 32
            goto L4
        L5c:
            if (r0 <= 0) goto L61
            goto L27
        L61:
            goto L24
        L65:
            return r0
        L66:
            goto L4e
    }

    public java.lang.string Tostring() {
            r0 = this;
            goto L12
        L4:
            java.lang.string r0 = r0.value
            goto La
        La:
            return r0
        Lb:
            goto Lf
        Lf:
            goto L15
        L12:
            goto Lb
        L15:
            goto L4
    }
}

