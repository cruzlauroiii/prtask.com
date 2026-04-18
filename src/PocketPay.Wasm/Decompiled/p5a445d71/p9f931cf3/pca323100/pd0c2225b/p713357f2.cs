namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes7.dex */
public class p713357f2 : p5a445d71.p9f931cf3.pca323100.p54252eff {
    private p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa f07ec528c;
    private p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa f4a8a08f0;
    private p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f f503d4fdb;
    private p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa f5c48fb1d;
    private p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa f70554e4f;
    private p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f f83878c91;
    private readonly p5a445d71.p9f931cf3.pca323100.p11b04310 f84bea1f0;
    private p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa f8c338015;
    private readonly p5a445d71.p9f931cf3.pca323100.p11b04310 fd11f552d;

    public p713357f2(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f r2, bool r3) {
            r1 = this;
            goto Lc
        L4:
            byte[] r2 = r2.getEncoded(r3)
            goto L35
        Lc:
            goto L31
        Lf:
            goto L3c
        L13:
            goto Lf
        L16:
            r1.f83878c91 = r0
            goto L2a
        L1c:
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f r0 = r2.normalize()
            goto L16
        L24:
            r1.f84bea1f0 = r0
            goto L30
        L2a:
            p5a445d71.p9f931cf3.pca323100.p6f0e511c r0 = new p5a445d71.p9f931cf3.pca323100.p6f0e511c
            goto L4
        L30:
            return
        L31:
            goto L13
        L35:
            r0.<init>(r2)
            goto L24
        L3c:
            r1.<init>()
            goto L1c
    }

    public p713357f2(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa r1, p5a445d71.p9f931cf3.pca323100.p11b04310 r2) {
            r0 = this;
            goto L4
        L4:
            goto L1e
        L7:
            goto L12
        Lb:
            r0.<init>(r1, r2)
            goto L1d
        L12:
            byte[] r2 = r2.getOctets()
            goto Lb
        L1a:
            goto L7
        L1d:
            return
        L1e:
            goto L1a
    }

    public p713357f2(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa r1, byte[] r2) {
            r0 = this;
            goto L1f
        L4:
            r1.<init>(r2)
            goto L35
        Lb:
            return
        Lc:
            goto L26
        L10:
            r0.<init>()
            goto L2f
        L17:
            byte[] r2 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(r2)
            goto L4
        L1f:
            goto Lc
        L22:
            goto L10
        L26:
            goto L22
        L29:
            p5a445d71.p9f931cf3.pca323100.p6f0e511c r1 = new p5a445d71.p9f931cf3.pca323100.p6f0e511c
            goto L17
        L2f:
            r0.f4a8a08f0 = r1
            goto L29
        L35:
            r0.f84bea1f0 = r1
            goto Lb
    }

    public p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f GetPoint() {
            r2 = this;
            goto L21
        L4:
            return r0
        L5:
            r0 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L5
            goto Le
        Lb:
            goto L24
        Le:
            throw r0
        Lf:
            goto L1a
        L13:
            r1 = 10
            goto L67
        L1a:
            goto L5a
        L1d:
            goto Lb
        L21:
            goto L1d
        L24:
            goto L50
        L28:
            int r0 = r0 % r1
            goto L5e
        L2e:
            monitor-enter(r2)
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f r0 = r2.f83878c91     // Catch: java.lang.Exception -> L5
            if (r0 != 0) goto L45
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa r0 = r2.f4a8a08f0     // Catch: java.lang.Exception -> L5
            p5a445d71.p9f931cf3.pca323100.p11b04310 r1 = r2.f84bea1f0     // Catch: java.lang.Exception -> L5
            byte[] r1 = r1.getOctets()     // Catch: java.lang.Exception -> L5
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f r0 = r0.decodePoint(r1)     // Catch: java.lang.Exception -> L5
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f r0 = r0.normalize()     // Catch: java.lang.Exception -> L5
            r2.f83878c91 = r0     // Catch: java.lang.Exception -> L5
        L45:
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f r0 = r2.f83878c91     // Catch: java.lang.Exception -> L5
            goto L4b
        L4b:
            monitor-exit(r2)
            goto L4
        L50:
            r0 = 8
            goto L13
        L57:
            goto Lf
        L5a:
            goto L2e
        L5e:
            if (r0 <= 0) goto L63
            goto L5a
        L63:
            goto L57
        L67:
            int r0 = r0 + r1
            goto L28
    }

    public byte[] GetPointEncoding() {
            r0 = this;
            goto L1a
        L4:
            goto L1d
        L7:
            return r0
        L8:
            goto L4
        Lc:
            p5a445d71.p9f931cf3.pca323100.p11b04310 r0 = r0.f84bea1f0
            goto L12
        L12:
            byte[] r0 = r0.getOctets()
            goto L21
        L1a:
            goto L8
        L1d:
            goto Lc
        L21:
            byte[] r0 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(r0)
            goto L7
    }

    public bool IsPointCompressed() {
            r2 = this;
            goto L3a
        L4:
            r2 = r2[r0]
            goto L8e
        La:
            goto L3d
        Ld:
            goto L15
        L10:
            goto L19
        L14:
            return r0
        L15:
            goto L93
        L19:
            p5a445d71.p9f931cf3.pca323100.p11b04310 r2 = r2.f84bea1f0
            goto L6a
        L1f:
            int r0 = r0 + r1
            goto L41
        L25:
            if (r1 > 0) goto L2a
            goto L2f
        L2a:
            goto L4
        L2e:
            return r2
        L2f:
            goto L14
        L33:
            r1 = 6
            goto L1f
        L3a:
            goto L96
        L3d:
            goto L55
        L41:
            int r0 = r0 % r1
            goto L85
        L47:
            if (r2 != 0) goto L4c
            goto L2f
        L4c:
            goto L65
        L50:
            r1 = 3
            goto L5c
        L55:
            r0 = 23
            goto L33
        L5c:
            if (r2 == r1) goto L61
            goto L2f
        L61:
            goto L77
        L65:
            int r1 = r2.length
            goto L25
        L6a:
            byte[] r2 = r2.getOctets()
            goto L72
        L72:
            r0 = 0
            goto L47
        L77:
            r2 = 1
            goto L2e
        L7c:
            if (r2 != r1) goto L81
            goto L61
        L81:
            goto L50
        L85:
            if (r0 <= 0) goto L8a
            goto L10
        L8a:
            goto Ld
        L8e:
            r1 = 2
            goto L7c
        L93:
            goto L10
        L96:
            goto La
    }

    @Override // p5a445d71.p9f931cf3.pca323100.p54252eff, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1
    public p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
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
            p5a445d71.p9f931cf3.pca323100.p11b04310 r0 = r0.f84bea1f0
            goto Lb
    }
}

