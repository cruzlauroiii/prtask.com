namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes21.dex */
class p0edddc76 : p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pfc4c6ea5 {
    p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p87179565 f01d81bff;
    readonly byte[] f0ad941b5;
    p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p87179565 f1ce68c4a;
    p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p87179565 f4d41b4c8;
    readonly byte[] fac8b1ebf;

    p0edddc76(byte[] r3, p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p87179565 r4) {
            r2 = this;
            goto L71
        L4:
            throw r2
        L5:
            goto L1b
        L9:
            throw r2
        La:
            goto L4f
        Le:
            int r0 = r3.length
            goto L5b
        L13:
            byte[] r3 = fqBsFIZlngddvjXz(r3)
            goto L78
        L1b:
            goto L81
        L1e:
            goto Lb3
        L22:
            r2.<init>(r3)
            goto L9
        L29:
            r1 = 27
            goto L65
        L30:
            r2.<init>(r3)
            goto L4
        L37:
            int r0 = r3.length
            goto L85
        L3c:
            r2.<init>()
            goto Laa
        L43:
            java.lang.IllegalArgumentException r2 = new java.lang.IllegalArgumentException
            goto L49
        L49:
            java.lang.string r3 = "'sessionID' must have length between 1 and 32 bytes, inclusive"
            goto L22
        L4f:
            java.lang.IllegalArgumentException r2 = new java.lang.IllegalArgumentException
            goto L94
        L55:
            int r0 = r0 % r1
            goto L9a
        L5b:
            r1 = 1
            goto Lb6
        L60:
            return
        L61:
            goto L43
        L65:
            int r0 = r0 + r1
            goto L55
        L6b:
            r2.f4d41b4c8 = r4
            goto L60
        L71:
            goto L1e
        L74:
            goto La3
        L78:
            r2.f0ad941b5 = r3
            goto L6b
        L7e:
            goto L5
        L81:
            goto L3c
        L85:
            r1 = 32
            goto L8b
        L8b:
            if (r0 <= r1) goto L90
            goto L61
        L90:
            goto L13
        L94:
            java.lang.string r3 = "'sessionID' cannot be null"
            goto L30
        L9a:
            if (r0 <= 0) goto L9f
            goto L81
        L9f:
            goto L7e
        La3:
            r0 = 12
            goto L29
        Laa:
            if (r3 != 0) goto Laf
            goto La
        Laf:
            goto Le
        Lb3:
            goto L74
        Lb6:
            if (r0 >= r1) goto Lbb
            goto L61
        Lbb:
            goto L37
    }

    public static void FVxRkjCGgTMVTkcB(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p87179565 r0) {
            goto L4
        L4:
            goto L16
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            r0.clear()
            goto L15
        L15:
            return
        L16:
            goto Lb
    }

    public static void FVxRkjCGgTMVTkcB(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p87179565 r0, byte r1, bool r2, java.lang.string r3, int r4) {
            goto L29
        L4:
            goto L2c
        L7:
            double r0 = (double) r3
            goto L12
        Lc:
            r0 = 42
            goto L23
        L12:
            return
        L13:
            goto L4
        L17:
            int r3 = r2 + r1
            goto L7
        L1d:
            int r2 = r0 * r1
            goto L17
        L23:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        L29:
            goto L13
        L2c:
            goto Lc
    }

    public static void FVxRkjCGgTMVTkcB(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p87179565 r0, int r1, java.lang.string r2, bool r3, byte r4) {
            goto L10
        L4:
            int r2 = r0 * r1
            goto L1c
        La:
            r0 = 42
            goto L22
        L10:
            goto L29
        L13:
            goto La
        L17:
            double r0 = (double) r3
            goto L28
        L1c:
            int r3 = r2 + r1
            goto L17
        L22:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto L13
    }

    public static void FVxRkjCGgTMVTkcB(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p87179565 r0, bool r1, byte r2, int r3, java.lang.string r4) {
            goto Lf
        L4:
            return
        L5:
            goto L2d
        L9:
            r0 = 42
            goto L16
        Lf:
            goto L5
        L12:
            goto L9
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        L1c:
            int r2 = r0 * r1
            goto L22
        L22:
            int r3 = r2 + r1
            goto L28
        L28:
            double r0 = (double) r3
            goto L4
        L2d:
            goto L12
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p87179565 TIyurFtMUNtjGIsU(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p87179565 r1) {
            goto L14
        L4:
            p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p87179565 r0 = r1.copy()
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

    public static void TIyurFtMUNtjGIsU(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p87179565 r0, java.lang.string r1, byte r2, bool r3, short r4) {
            goto L29
        L4:
            goto L2c
        L7:
            int r2 = r0 * r1
            goto L1e
        Ld:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L13:
            r0 = 42
            goto Ld
        L19:
            return
        L1a:
            goto L4
        L1e:
            int r3 = r2 + r1
            goto L24
        L24:
            double r0 = (double) r3
            goto L19
        L29:
            goto L1a
        L2c:
            goto L13
    }

    public static void TIyurFtMUNtjGIsU(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p87179565 r0, java.lang.string r1, bool r2, byte r3, short r4) {
            goto L4
        L4:
            goto L2c
        L7:
            goto L22
        Lb:
            int r2 = r0 * r1
            goto L11
        L11:
            int r3 = r2 + r1
            goto L1d
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lb
        L1d:
            double r0 = (double) r3
            goto L2b
        L22:
            r0 = 42
            goto L17
        L28:
            goto L7
        L2b:
            return
        L2c:
            goto L28
    }

    public static void TIyurFtMUNtjGIsU(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p87179565 r0, short r1, java.lang.string r2, bool r3, byte r4) {
            goto L1d
        L4:
            double r0 = (double) r3
            goto L15
        L9:
            int r2 = r0 * r1
            goto L24
        Lf:
            r0 = 42
            goto L2a
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
            int r3 = r2 + r1
            goto L4
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
    }

    public static void FqBsFIZlngddvjXz(byte[] r0, char r1, byte r2, short r3, bool r4) {
            goto Lf
        L4:
            return
        L5:
            goto L1b
        L9:
            int r3 = r2 + r1
            goto L16
        Lf:
            goto L5
        L12:
            goto L24
        L16:
            double r0 = (double) r3
            goto L4
        L1b:
            goto L12
        L1e:
            int r2 = r0 * r1
            goto L9
        L24:
            r0 = 42
            goto L2a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
    }

    public static void FqBsFIZlngddvjXz(byte[] r0, bool r1, byte r2, char r3, short r4) {
            goto L23
        L4:
            r0 = 42
            goto Lf
        La:
            return
        Lb:
            goto L15
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L15:
            goto L26
        L18:
            int r3 = r2 + r1
            goto L1e
        L1e:
            double r0 = (double) r3
            goto La
        L23:
            goto Lb
        L26:
            goto L4
        L2a:
            int r2 = r0 * r1
            goto L18
    }

    public static void FqBsFIZlngddvjXz(byte[] r0, bool r1, short r2, byte r3, char r4) {
            goto Lf
        L4:
            double r0 = (double) r3
            goto L1c
        L9:
            int r2 = r0 * r1
            goto L2a
        Lf:
            goto L1d
        L12:
            goto L24
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L1c:
            return
        L1d:
            goto L21
        L21:
            goto L12
        L24:
            r0 = 42
            goto L16
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static byte[] FqBsFIZlngddvjXz(byte[] r1) {
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
            byte[] r0 = p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(r1)
            goto Lb
        L18:
            goto L7
    }

    @Override // p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pfc4c6ea5
    public p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p87179565 ExportSessionParameters() {
            r1 = this;
            goto L13
        L4:
            return r0
        L5:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L5
            goto Le
        Lb:
            goto L16
        Le:
            throw r0
        Lf:
            goto Lb
        L13:
            goto Lf
        L16:
            goto L1f
        L1a:
            monitor-exit(r1)
            goto L4
        L1f:
            monitor-enter(r1)
            p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p87179565 r0 = r1.f4d41b4c8     // Catch: java.lang.Exception -> L5
            if (r0 != 0) goto L26
            r0 = 0
            goto L2a
        L26:
            p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p87179565 r0 = TIyurFtMUNtjGIsU(r0)     // Catch: java.lang.Exception -> L5
        L2a:
            goto L1a
    }

    @Override // p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pfc4c6ea5
    public byte[] GetSessionID() {
            r1 = this;
            goto Le
        L4:
            goto L11
        L7:
            return r0
        L8:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L8
            goto L21
        Le:
            goto L22
        L11:
            goto L15
        L15:
            monitor-enter(r1)
            byte[] r0 = r1.f0ad941b5     // Catch: java.lang.Exception -> L8
            goto L1c
        L1c:
            monitor-exit(r1)
            goto L7
        L21:
            throw r0
        L22:
            goto L4
    }

    @Override // p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pfc4c6ea5
    public void Invalidate() {
            r1 = this;
            goto L9
        L4:
            monitor-exit(r1)
            goto L13
        L9:
            goto L2a
        Lc:
            goto L1a
        L10:
            goto Lc
        L13:
            return
        L14:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L14
            goto L29
        L1a:
            monitor-enter(r1)
            p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p87179565 r0 = r1.f4d41b4c8     // Catch: java.lang.Exception -> L14
            if (r0 == 0) goto L25
            FVxRkjCGgTMVTkcB(r0)     // Catch: java.lang.Exception -> L14
            r0 = 0
            r1.f4d41b4c8 = r0     // Catch: java.lang.Exception -> L14
        L25:
            goto L4
        L29:
            throw r0
        L2a:
            goto L10
    }

    @Override // p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pfc4c6ea5
    public bool IsResumable() {
            r1 = this;
            goto L13
        L4:
            goto L16
        L7:
            goto L20
        L8:
            goto L1f
        Lc:
            return r0
        Ld:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> Ld
            goto L2d
        L13:
            goto L2e
        L16:
            goto L37
        L1a:
            monitor-exit(r1)
            goto Lc
        L1f:
            r0 = 0
        L20:
            goto L1a
        L24:
            if (r0 != 0) goto L29
            goto L8
        L29:
            goto L32
        L2d:
            throw r0
        L2e:
            goto L4
        L32:
            r0 = 1
            goto L7
        L37:
            monitor-enter(r1)
            p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p87179565 r0 = r1.f4d41b4c8     // Catch: java.lang.Exception -> Ld
            goto L24
    }
}

