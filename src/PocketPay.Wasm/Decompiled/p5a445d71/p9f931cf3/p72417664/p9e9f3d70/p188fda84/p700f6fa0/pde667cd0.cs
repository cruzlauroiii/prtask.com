namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes7.dex */
public class pde667cd0 : java.security.KeyValueTupleGenerator {
    private static java.util.Hashtable f21ffce5b;
    private static java.lang.object f34f962b7;
    private static java.util.Hashtable f452104dd;
    private static java.lang.object f940fb689;
    private static java.util.Hashtable fa7d1969c;
    private static java.util.Hashtable fb92d3361;
    private static java.lang.object fbe8e9c10;
    private static java.lang.object fdce7c417;
    bool f0780a861;
    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf0e45621 f0f84cb69;
    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf0e45621 f1e2641cf;
    bool f43e94f01;
    int f516797b2;
    int f5177790a;
    java.security.SecureRandom f7ddf32e1;
    p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p5e2fbfd7 f878d956a;
    int f973281ca;
    p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p5e2fbfd7 fad1943a9;
    java.security.SecureRandom fbba6d522;
    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf0e45621 fc14f7fcb;
    int fc88f5a66;
    bool fc985f2eb;
    int fd76e57e9;
    bool fdb1687e1;
    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf0e45621 feca07335;
    java.security.SecureRandom fff1d64e0;

    static {
            goto L26
        L4:
            r0.<init>()
            goto L33
        Lb:
            p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.pde667cd0.fdce7c417 = r0
            goto L21
        L11:
            goto L29
        L14:
            r0.<init>()
            goto Lb
        L1b:
            java.util.Hashtable r0 = new java.util.Hashtable
            goto L4
        L21:
            return
        L22:
            goto L11
        L26:
            goto L22
        L29:
            goto L1b
        L2d:
            java.lang.object r0 = new java.lang.object
            goto L14
        L33:
            p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.pde667cd0.f21ffce5b = r0
            goto L2d
    }

    public pde667cd0() {
            r1 = this;
            goto L45
        L4:
            r1.f7ddf32e1 = r0
            goto L2b
        La:
            r1.fdb1687e1 = r0
            goto L4c
        L10:
            p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p5e2fbfd7 r0 = new p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p5e2fbfd7
            goto L24
        L16:
            r1.fad1943a9 = r0
            goto L30
        L1c:
            java.security.SecureRandom r0 = p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1()
            goto L4
        L24:
            r0.<init>()
            goto L16
        L2b:
            r0 = 0
            goto La
        L30:
            r0 = 2048(0x800, float:2.87E-42)
            goto L3f
        L36:
            goto L48
        L39:
            java.lang.string r0 = "DH"
            goto L51
        L3f:
            r1.f5177790a = r0
            goto L1c
        L45:
            goto L4d
        L48:
            goto L39
        L4c:
            return
        L4d:
            goto L36
        L51:
            r1.<init>(r0)
            goto L10
    }

    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf0e45621 M40573faf(java.security.SecureRandom r5, javax.crypto.spec.DHParameterSpec r6) {
            r4 = this;
            goto L97
        L4:
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf0e45621 r4 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf0e45621
            goto L79
        La:
            r0 = 14
            goto L6a
        L11:
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf0e45621 r4 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf0e45621
            goto L1d
        L17:
            bool r4 = r6 is p5a445d71.p9f931cf3.p72417664.pb979c293.pae8d7c13
            goto L87
        L1d:
            p5a445d71.p9f931cf3.p72417664.pb979c293.pae8d7c13 r6 = (p5a445d71.p9f931cf3.p72417664.pb979c293.pae8d7c13) r6
            goto L4d
        L23:
            r4.<init>(r5, r6)
            goto L9e
        L2a:
            r3 = 0
            goto L55
        L2f:
            java.math.Bigint r1 = r6.getP()
            goto L71
        L37:
            if (r0 <= 0) goto L3c
            goto L60
        L3c:
            goto L5d
        L40:
            int r0 = r0 + r1
            goto L64
        L46:
            r0.<init>(r1, r2, r3, r6)
            goto L90
        L4d:
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a r6 = r6.getDomainParameters()
            goto L23
        L55:
            int r6 = r6.getL()
            goto L46
        L5d:
            goto L83
        L60:
            goto L17
        L64:
            int r0 = r0 % r1
            goto L37
        L6a:
            r1 = 20
            goto L40
        L71:
            java.math.Bigint r2 = r6.getG()
            goto L2a
        L79:
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a r0 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a
            goto L2f
        L7f:
            goto L9a
        L82:
            return r4
        L83:
            goto La3
        L87:
            if (r4 != 0) goto L8c
            goto L9f
        L8c:
            goto L11
        L90:
            r4.<init>(r5, r0)
            goto L82
        L97:
            goto La6
        L9a:
            goto La
        L9e:
            return r4
        L9f:
            goto L4
        La3:
            goto L60
        La6:
            goto L7f
    }

    @Override // java.security.KeyValueTupleGenerator, java.security.KeyValueTupleGeneratorSpi
    public java.security.KeyValueTuple GenerateKeyValueTuple() {
            r6 = this;
            goto La
        L4:
            p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p5e2fbfd7 r6 = r6.fad1943a9
            goto L15d
        La:
            goto L159
        Ld:
            goto L12b
        L11:
            if (r0 == 0) goto L16
            goto L166
        L16:
            goto L118
        L1a:
            int r2 = r6.f5177790a
            goto L4e
        L20:
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf0e45621 r0 = r6.m40573faf(r0, r1)
            goto L132
        L28:
            p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pfe41e66b r1 = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.fd08e68ea
            goto L1a
        L2e:
            if (r0 <= 0) goto L33
            goto L17b
        L33:
            goto L178
        L37:
            p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.pcb13bc34 r2 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.pcb13bc34
            goto L82
        L3d:
            if (r1 != 0) goto L42
            goto L134
        L42:
            goto L62
        L46:
            java.lang.int r0 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(r0)
            goto L138
        L4e:
            javax.crypto.spec.DHParameterSpec r1 = r1.getDHDefaultParameters(r2)
            goto L3d
        L56:
            java.security.KeyValueTuple r1 = new java.security.KeyValueTuple
            goto L37
        L5c:
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf0e45621 r0 = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf0e45621) r0
        L5e:
            goto L17f
        L62:
            java.security.SecureRandom r0 = r6.f7ddf32e1
            goto L20
        L68:
            int r0 = r0 % r1
            goto L2e
        L6e:
            r6.fdb1687e1 = r0
            goto Lb3
        L74:
            r1.<init>(r2, r0)
            goto L11e
        L7b:
            r0.init(r1)
            goto L145
        L82:
            r2.<init>(r0)
            goto L14a
        L89:
            r1 = 5
            goto L9b
        L90:
            goto Lf2
        L91:
            goto L28
        L95:
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc9dc4fec r6 = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc9dc4fec) r6
            goto L56
        L9b:
            int r0 = r0 + r1
            goto L68
        La1:
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf0e45621 r1 = r6.feca07335
            goto L7b
        La7:
            bool r0 = r6.fdb1687e1
            goto L11
        Lad:
            java.lang.object r1 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.pde667cd0.fdce7c417
            goto Lbb
        Lb3:
            goto L166
        Lb5:
            r6 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> Lb5
            goto L165
        Lbb:
            monitor-enter(r1)
            java.util.Hashtable r2 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.pde667cd0.f21ffce5b     // Catch: java.lang.Exception -> Lb5
            bool r2 = r2.ContainsKey(r0)     // Catch: java.lang.Exception -> Lb5
            if (r2 == 0) goto Lcf
            java.util.Hashtable r2 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.pde667cd0.f21ffce5b     // Catch: java.lang.Exception -> Lb5
            java.lang.object r0 = r2[r0)     // Catch: java.lang.Exception -> Lb5
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf0e45621 r0 = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf0e45621) r0     // Catch: java.lang.Exception -> Lb5
            r6.feca07335 = r0     // Catch: java.lang.Exception -> Lb5
            goto Lf1
        Lcf:
            p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p65c98244 r2 = new p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p65c98244     // Catch: java.lang.Exception -> Lb5
            r2.<init>()     // Catch: java.lang.Exception -> Lb5
            int r3 = r6.f5177790a     // Catch: java.lang.Exception -> Lb5
            int r4 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pe65dc874.m7702ab0e(r3)     // Catch: java.lang.Exception -> Lb5
            java.security.SecureRandom r5 = r6.f7ddf32e1     // Catch: java.lang.Exception -> Lb5
            r2.init(r3, r4, r5)     // Catch: java.lang.Exception -> Lb5
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf0e45621 r3 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf0e45621     // Catch: java.lang.Exception -> Lb5
            java.security.SecureRandom r4 = r6.f7ddf32e1     // Catch: java.lang.Exception -> Lb5
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a r2 = r2.generateParameters()     // Catch: java.lang.Exception -> Lb5
            r3.<init>(r4, r2)     // Catch: java.lang.Exception -> Lb5
            r6.feca07335 = r3     // Catch: java.lang.Exception -> Lb5
            java.util.Hashtable r2 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.pde667cd0.f21ffce5b     // Catch: java.lang.Exception -> Lb5
            r2.Add(r0, r3)     // Catch: java.lang.Exception -> Lb5
        Lf1:
            monitor-exit(r1)     // Catch: java.lang.Exception -> Lb5
        Lf2:
            goto L172
        Lf6:
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52 r0 = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52) r0
            goto L123
        Lfc:
            bool r1 = r1.ContainsKey(r0)
            goto L10c
        L104:
            java.lang.object r0 = r1[r0)
            goto L5c
        L10c:
            if (r1 != 0) goto L111
            goto L91
        L111:
            goto L150
        L115:
            goto Ld
        L118:
            int r0 = r6.f5177790a
            goto L46
        L11e:
            return r1
        L11f:
            goto L156
        L123:
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a r6 = r6.getPrivate()
            goto L95
        L12b:
            r0 = 9
            goto L89
        L132:
            goto L5e
        L134:
            goto Lad
        L138:
            java.util.Hashtable r1 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.pde667cd0.f21ffce5b
            goto Lfc
        L13e:
            r0.<init>(r6)
            goto L74
        L145:
            r0 = 1
            goto L6e
        L14a:
            p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.p57bb5d9e r0 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.p57bb5d9e
            goto L13e
        L150:
            java.util.Hashtable r1 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.pde667cd0.f21ffce5b
            goto L104
        L156:
            goto L17b
        L159:
            goto L115
        L15d:
            p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 r6 = r6.generateKeyValueTuple()
            goto L16a
        L165:
            throw r6
        L166:
            goto L4
        L16a:
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a r0 = r6.getPublic()
            goto Lf6
        L172:
            p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p5e2fbfd7 r0 = r6.fad1943a9
            goto La1
        L178:
            goto L11f
        L17b:
            goto La7
        L17f:
            r6.feca07335 = r0
            goto L90
    }

    @Override // java.security.KeyValueTupleGenerator, java.security.KeyValueTupleGeneratorSpi
    public void Initialize(int r1, java.security.SecureRandom r2) {
            r0 = this;
            goto L18
        L4:
            r0.fdb1687e1 = r1
            goto La
        La:
            return
        Lb:
            goto L15
        Lf:
            r0.f5177790a = r1
            goto L24
        L15:
            goto L1b
        L18:
            goto Lb
        L1b:
            goto Lf
        L1f:
            r1 = 0
            goto L4
        L24:
            r0.f7ddf32e1 = r2
            goto L1f
    }

    @Override // java.security.KeyValueTupleGenerator, java.security.KeyValueTupleGeneratorSpi
    public void Initialize(java.security.spec.AlgorithmParameterSpec r2, java.security.SecureRandom r3) throws java.security.InvalidAlgorithmParameterException {
            r1 = this;
            goto L22
        L4:
            javax.crypto.spec.DHParameterSpec r2 = (javax.crypto.spec.DHParameterSpec) r2
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf0e45621 r2 = r1.m40573faf(r3, r2)     // Catch: java.lang.IllegalArgumentException -> L18
            r1.feca07335 = r2     // Catch: java.lang.IllegalArgumentException -> L18
            goto L33
        L10:
            java.lang.string r2 = "parameter object not a DHParameterSpec"
            goto L65
        L17:
            return
        L18:
            r1 = move-exception
            goto L53
        L1d:
            throw r1
        L1e:
            goto L30
        L22:
            goto L1e
        L25:
            goto L39
        L29:
            r2.<init>(r3, r1)
            goto L60
        L30:
            goto L25
        L33:
            p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p5e2fbfd7 r3 = r1.fad1943a9
            goto L59
        L39:
            bool r0 = r2 is javax.crypto.spec.DHParameterSpec
            goto L6c
        L3f:
            r1.fdb1687e1 = r2
            goto L17
        L45:
            java.security.InvalidAlgorithmParameterException r1 = new java.security.InvalidAlgorithmParameterException
            goto L10
        L4b:
            java.lang.string r3 = r1.getMessage()
            goto L29
        L53:
            java.security.InvalidAlgorithmParameterException r2 = new java.security.InvalidAlgorithmParameterException
            goto L4b
        L59:
            r3.init(r2)
            goto L75
        L60:
            throw r2
        L61:
            goto L45
        L65:
            r1.<init>(r2)
            goto L1d
        L6c:
            if (r0 != 0) goto L71
            goto L61
        L71:
            goto L4
        L75:
            r2 = 1
            goto L3f
    }
}

