namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes2.dex */
public readonly class ByQuadrantReader : com.google.zxing.Reader {
    private readonly com.google.zxing.Reader delegate;

    public ByQuadrantReader(com.google.zxing.Reader r1) {
            r0 = this;
            goto Ld
        L4:
            goto L10
        L7:
            r0.delegate = r1
            goto L1b
        Ld:
            goto L1c
        L10:
            goto L14
        L14:
            r0.<init>()
            goto L7
        L1b:
            return
        L1c:
            goto L4
    }

    public static void GEhbpSmAOQMNYRKp(com.google.zxing.ResultPoint[] r0, int r1, int r2) {
            goto L13
        L4:
            makeAbsolute(r0, r1, r2)
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

    public static float OEcfvNdnXvpyICMM(com.google.zxing.ResultPoint r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            float r0 = r1.getX()
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static com.google.zxing.Result QurJcFezamGQxdBb(com.google.zxing.Reader r1, com.google.zxing.BinaryBitmap r2, java.util.Dictionary r3) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            com.google.zxing.Result r0 = r1.decode(r2, r3)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static com.google.zxing.Result SQRsWGzqbOIBhCoM(com.google.zxing.multi.ByQuadrantReader r1, com.google.zxing.BinaryBitmap r2, java.util.Dictionary r3) {
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
            com.google.zxing.Result r0 = r1.decode(r2, r3)
            goto L4
    }

    public static com.google.zxing.BinaryBitmap SwuVLahuorEhpizX(com.google.zxing.BinaryBitmap r1, int r2, int r3, int r4, int r5) {
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
            com.google.zxing.BinaryBitmap r0 = r1.crop(r2, r3, r4, r5)
            goto L7
    }

    public static com.google.zxing.ResultPoint[] VGKcUjSyRvFoyuJS(com.google.zxing.Result r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            com.google.zxing.ResultPoint[] r0 = r1.getResultPoints()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static com.google.zxing.ResultPoint[] XOfsFyndGDAgqajb(com.google.zxing.Result r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            com.google.zxing.ResultPoint[] r0 = r1.getResultPoints()
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static int ARMiIZULYohykSey(com.google.zxing.BinaryBitmap r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            int r0 = r1.getHeight()
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static com.google.zxing.Result DYOskbPHLjQUTTmK(com.google.zxing.Reader r1, com.google.zxing.BinaryBitmap r2, java.util.Dictionary r3) {
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
            com.google.zxing.Result r0 = r1.decode(r2, r3)
            goto L4
    }

    public static com.google.zxing.Result DnGYdDWsARNZHLAv(com.google.zxing.Reader r1, com.google.zxing.BinaryBitmap r2, java.util.Dictionary r3) {
            goto Lf
        L4:
            goto L12
        L7:
            com.google.zxing.Result r0 = r1.decode(r2, r3)
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

    public static void EXwVVgUiFULxXMMh(com.google.zxing.ResultPoint[] r0, int r1, int r2) {
            goto L4
        L4:
            goto L13
        L7:
            goto Lb
        Lb:
            makeAbsolute(r0, r1, r2)
            goto L12
        L12:
            return
        L13:
            goto L17
        L17:
            goto L7
    }

    public static com.google.zxing.BinaryBitmap FjkXTwHfAgUevmFf(com.google.zxing.BinaryBitmap r1, int r2, int r3, int r4, int r5) {
            goto Lf
        L4:
            com.google.zxing.BinaryBitmap r0 = r1.crop(r2, r3, r4, r5)
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

    public static int JMjsbXJQQIigMAaX(com.google.zxing.BinaryBitmap r1) {
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
            int r0 = r1.getWidth()
            goto Lb
    }

    public static com.google.zxing.Result LLmkJLHeZiouOofb(com.google.zxing.Reader r1, com.google.zxing.BinaryBitmap r2, java.util.Dictionary r3) {
            goto Lf
        L4:
            com.google.zxing.Result r0 = r1.decode(r2, r3)
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

    public static com.google.zxing.BinaryBitmap LVxdjupbtbcSgugW(com.google.zxing.BinaryBitmap r1, int r2, int r3, int r4, int r5) {
            goto Lf
        L4:
            com.google.zxing.BinaryBitmap r0 = r1.crop(r2, r3, r4, r5)
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

    private static void MakeAbsolute(com.google.zxing.ResultPoint[] r5, int r6, int r7) {
            goto L46
        L4:
            r5[r0] = r2
        L6:
            goto La0
        La:
            r0 = 28
            goto L90
        L11:
            float r1 = r1 + r4
            goto L4d
        L16:
            goto L25
        L17:
            goto Lac
        L1b:
            if (r0 <= 0) goto L20
            goto L3f
        L20:
            goto L3c
        L24:
            r0 = 0
        L25:
            goto L62
        L29:
            float r4 = (float) r7
            goto L11
        L2e:
            float r3 = OEcfvNdnXvpyICMM(r1)
            goto L54
        L36:
            int r0 = r0 + r1
            goto La6
        L3c:
            goto Lad
        L3f:
            goto L59
        L43:
            goto L49
        L46:
            goto L6a
        L49:
            goto La
        L4d:
            r2.<init>(r3, r1)
            goto L4
        L54:
            float r4 = (float) r6
            goto L7d
        L59:
            if (r5 != 0) goto L5e
            goto L17
        L5e:
            goto L24
        L62:
            int r1 = r5.length
            goto L97
        L67:
            goto L3f
        L6a:
            goto L43
        L6e:
            if (r1 != 0) goto L73
            goto L6
        L73:
            goto L77
        L77:
            com.google.zxing.ResultPoint r2 = new com.google.zxing.ResultPoint
            goto L2e
        L7d:
            float r3 = r3 + r4
            goto L88
        L82:
            r1 = r5[r0]
            goto L6e
        L88:
            float r1 = pmWyLlqUqikAAfNr(r1)
            goto L29
        L90:
            r1 = 17
            goto L36
        L97:
            if (r0 < r1) goto L9c
            goto L17
        L9c:
            goto L82
        La0:
            int r0 = r0 + 1
            goto L16
        La6:
            int r0 = r0 % r1
            goto L1b
        Lac:
            return
        Lad:
            goto L67
    }

    public static com.google.zxing.BinaryBitmap PPmKlSMqQWVekvHk(com.google.zxing.BinaryBitmap r1, int r2, int r3, int r4, int r5) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            com.google.zxing.BinaryBitmap r0 = r1.crop(r2, r3, r4, r5)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static float PmWyLlqUqikAAfNr(com.google.zxing.ResultPoint r1) {
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
            float r0 = r1.getY()
            goto Le
    }

    public static com.google.zxing.ResultPoint[] TtWlOXynDoQdOsJZ(com.google.zxing.Result r1) {
            goto Lc
        L4:
            com.google.zxing.ResultPoint[] r0 = r1.getResultPoints()
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

    public static com.google.zxing.BinaryBitmap UUTJQRYjHOmdwDbt(com.google.zxing.BinaryBitmap r1, int r2, int r3, int r4, int r5) {
            goto Lc
        L4:
            com.google.zxing.BinaryBitmap r0 = r1.crop(r2, r3, r4, r5)
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

    public static com.google.zxing.ResultPoint[] VbwmchkQkwxTlADU(com.google.zxing.Result r1) {
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
            com.google.zxing.ResultPoint[] r0 = r1.getResultPoints()
            goto Lb
        L18:
            goto L7
    }

    public static void XgWcMSoqQhvSyQEc(com.google.zxing.ResultPoint[] r0, int r1, int r2) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            makeAbsolute(r0, r1, r2)
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public static void YHZqdAHnPSPjGACe(com.google.zxing.ResultPoint[] r0, int r1, int r2) {
            goto Lc
        L4:
            goto Lf
        L7:
            return
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            makeAbsolute(r0, r1, r2)
            goto L7
    }

    public static void ZQhGzJSXawKsLoDP(com.google.zxing.Reader r0) {
            goto Le
        L4:
            goto L11
        L7:
            r0.reset()
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

    public static com.google.zxing.Result ZehZoCxUizDDdRHj(com.google.zxing.Reader r1, com.google.zxing.BinaryBitmap r2, java.util.Dictionary r3) {
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
            com.google.zxing.Result r0 = r1.decode(r2, r3)
            goto L4
    }

    @Override // com.google.zxing.Reader
    public com.google.zxing.Result Decode(com.google.zxing.BinaryBitmap r2) throws com.google.zxing.NotFoundException, com.google.zxing.ChecksumException, com.google.zxing.FormatException {
            r1 = this;
            goto L4
        L4:
            goto L11
        L7:
            goto Lb
        Lb:
            r0 = 0
            goto L18
        L10:
            return r1
        L11:
            goto L15
        L15:
            goto L7
        L18:
            com.google.zxing.Result r1 = SQRsWGzqbOIBhCoM(r1, r2, r0)
            goto L10
    }

    @Override // com.google.zxing.Reader
    public com.google.zxing.Result Decode(com.google.zxing.BinaryBitmap r6, java.util.Dictionary<com.google.zxing.DecodeHintType, ?> r7) throws com.google.zxing.NotFoundException, com.google.zxing.ChecksumException, com.google.zxing.FormatException {
            r5 = this;
            goto La
        L4:
            int r0 = r0 + r1
            goto L85
        La:
            goto Lc7
        Ld:
            goto L36
        L11:
            goto L6f
        L14:
            goto Lbc
        L18:
            int r1 = aRMiIZULYohykSey(r6)
            goto L4c
        L20:
            return r3
        L21:
            com.google.zxing.Reader r3 = r5.delegate     // Catch: com.google.zxing.NotFoundException -> L59
            com.google.zxing.BinaryBitmap r4 = fjkXTwHfAgUevmFf(r6, r2, r1, r0, r1)     // Catch: com.google.zxing.NotFoundException -> L59
            com.google.zxing.Result r3 = dYOskbPHLjQUTTmK(r3, r4, r7)     // Catch: com.google.zxing.NotFoundException -> L59
            com.google.zxing.ResultPoint[] r4 = vbwmchkQkwxTlADU(r3)     // Catch: com.google.zxing.NotFoundException -> L59
            eXwVVgUiFULxXMMh(r4, r2, r1)     // Catch: com.google.zxing.NotFoundException -> L59
            goto L58
        L36:
            r0 = 10
            goto L8e
        L3d:
            r2 = 0
            com.google.zxing.Reader r3 = r5.delegate     // Catch: com.google.zxing.NotFoundException -> L96
            com.google.zxing.BinaryBitmap r4 = SwuVLahuorEhpizX(r6, r2, r2, r0, r1)     // Catch: com.google.zxing.NotFoundException -> L96
            com.google.zxing.Result r5 = QurJcFezamGQxdBb(r3, r4, r7)     // Catch: com.google.zxing.NotFoundException -> L96
            goto L95
        L4c:
            int r0 = r0 / 2
            goto L73
        L52:
            int r2 = r0 / 2
            goto Lcb
        L58:
            return r3
        L59:
            com.google.zxing.Reader r2 = r5.delegate     // Catch: com.google.zxing.NotFoundException -> L7a
            com.google.zxing.BinaryBitmap r3 = pPmKlSMqQWVekvHk(r6, r0, r1, r0, r1)     // Catch: com.google.zxing.NotFoundException -> L7a
            com.google.zxing.Result r2 = lLmkJLHeZiouOofb(r2, r3, r7)     // Catch: com.google.zxing.NotFoundException -> L7a
            com.google.zxing.ResultPoint[] r3 = VGKcUjSyRvFoyuJS(r2)     // Catch: com.google.zxing.NotFoundException -> L7a
            xgWcMSoqQhvSyQEc(r3, r0, r1)     // Catch: com.google.zxing.NotFoundException -> L7a
            goto L79
        L6e:
            return r5
        L6f:
            goto Lc4
        L73:
            int r1 = r1 / 2
            goto L3d
        L79:
            return r2
        L7a:
            goto L52
        L7e:
            yHZqdAHnPSPjGACe(r6, r2, r3)
            goto L6e
        L85:
            int r0 = r0 % r1
            goto Lab
        L8b:
            goto Ld
        L8e:
            r1 = 3
            goto L4
        L95:
            return r5
        L96:
            com.google.zxing.Reader r3 = r5.delegate     // Catch: com.google.zxing.NotFoundException -> L21
            com.google.zxing.BinaryBitmap r4 = uUTJQRYjHOmdwDbt(r6, r0, r2, r0, r1)     // Catch: com.google.zxing.NotFoundException -> L21
            com.google.zxing.Result r3 = zehZoCxUizDDdRHj(r3, r4, r7)     // Catch: com.google.zxing.NotFoundException -> L21
            com.google.zxing.ResultPoint[] r4 = XOfsFyndGDAgqajb(r3)     // Catch: com.google.zxing.NotFoundException -> L21
            GEhbpSmAOQMNYRKp(r4, r0, r2)     // Catch: com.google.zxing.NotFoundException -> L21
            goto L20
        Lab:
            if (r0 <= 0) goto Lb0
            goto L14
        Lb0:
            goto L11
        Lb4:
            com.google.zxing.BinaryBitmap r6 = lVxdjupbtbcSgugW(r6, r2, r3, r0, r1)
            goto Ld9
        Lbc:
            int r0 = jMjsbXJQQIigMAaX(r6)
            goto L18
        Lc4:
            goto L14
        Lc7:
            goto L8b
        Lcb:
            int r3 = r1 / 2
            goto Lb4
        Ld1:
            com.google.zxing.Result r5 = dnGYdDWsARNZHLAv(r5, r6, r7)
            goto Ldf
        Ld9:
            com.google.zxing.Reader r5 = r5.delegate
            goto Ld1
        Ldf:
            com.google.zxing.ResultPoint[] r6 = ttWlOXynDoQdOsJZ(r5)
            goto L7e
    }

    @Override // com.google.zxing.Reader
    public void Reset() {
            r0 = this;
            goto L4
        L4:
            goto L1c
        L7:
            goto L15
        Lb:
            goto L7
        Le:
            zQhGzJSXawKsLoDP(r0)
            goto L1b
        L15:
            com.google.zxing.Reader r0 = r0.delegate
            goto Le
        L1b:
            return
        L1c:
            goto Lb
    }
}

