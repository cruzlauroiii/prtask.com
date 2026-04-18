namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes7.dex */
public class p511d6594 : p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pcc0037e2 : p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p64e649e3 {
    private java.util.List<p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d> f14f802e1;
    private long f188de01a;
    private java.util.List f1dfe94af;
    private readonly long f2b00e85c;
    private readonly int f2db95e8e;
    private java.util.List<p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f> f3311842a;
    private readonly long f3d3b0a93;
    private readonly int f4865f96c;
    private java.util.List f542a135a;
    private readonly long f5d97b6b8;
    private readonly bool f67f7e3f5;
    private readonly bool f695aaee5;
    private long f6a992d55;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe32c2c6b f6b11e9c8;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe32c2c6b f97f85610;
    private readonly int f9e3bdbea;
    private java.util.List f9f9b292f;
    private readonly long fac5befe0;
    private readonly int fb475e65b;
    private readonly bool fb6d4cfd3;
    private readonly bool fbe948ccb;
    private java.util.List fbef46962;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe32c2c6b fc36853ea;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe32c2c6b fc5368bd9;
    private long fc769a5b2;
    private readonly bool fce32bd21;
    private java.util.List fce42e41e;
    private long fdf74dd64;
    private java.util.List fe2cfc0e5;
    private long ff64e00be;

    public p511d6594(int r3, java.util.List<p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d> r4, java.util.List<p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f> r5, long r6, long r8) {
            r2 = this;
            goto L38
        L4:
            r2.<init>(r0)
            goto L12
        Lb:
            r0 = 3
            goto L6a
        L12:
            r0 = 0
            goto L71
        L18:
            r2.f3d3b0a93 = r8
            goto L26
        L1e:
            java.util.List r3 = java.util.ICollections.unmodifiableList(r5)
            goto L5e
        L26:
            r3 = 0
            goto L7f
        L2b:
            goto L48
        L2e:
            goto L8a
        L32:
            int r0 = r0 % r1
            goto L8d
        L38:
            goto L2e
        L3b:
            goto Lb
        L3f:
            int r0 = r0 + r1
            goto L32
        L45:
            goto L5a
        L48:
            goto L85
        L4c:
            r2.f2db95e8e = r3
            goto L77
        L52:
            r2.resetKeyToIndex()
            goto L59
        L59:
            return
        L5a:
            goto L2b
        L5e:
            r2.f3311842a = r3
            goto L96
        L64:
            r2.f14f802e1 = r3
            goto L1e
        L6a:
            r1 = 13
            goto L3f
        L71:
            r2.f6a992d55 = r0
            goto L4c
        L77:
            java.util.List r3 = java.util.ICollections.unmodifiableList(r4)
            goto L64
        L7f:
            r2.f695aaee5 = r3
            goto L52
        L85:
            r0 = 1
            goto L4
        L8a:
            goto L3b
        L8d:
            if (r0 <= 0) goto L92
            goto L48
        L92:
            goto L45
        L96:
            r2.f6a992d55 = r6
            goto L18
    }

    private p511d6594(int r3, java.util.List<p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d> r4, java.util.List<p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f> r5, long r6, long r8, bool r10) {
            r2 = this;
            goto L83
        L4:
            r2.f14f802e1 = r3
            goto L50
        La:
            r0 = 14
            goto L67
        L11:
            goto L33
        L14:
            goto L5e
        L18:
            int r0 = r0 % r1
            goto L6e
        L1e:
            r2.f6a992d55 = r0
            goto L3c
        L24:
            return
        L25:
            goto L11
        L29:
            r2.<init>(r0)
            goto L7d
        L30:
            goto L25
        L33:
            goto L37
        L37:
            r0 = 1
            goto L29
        L3c:
            r2.f2db95e8e = r3
            goto L42
        L42:
            java.util.List r3 = java.util.ICollections.unmodifiableList(r4)
            goto L4
        L4a:
            r2.f6a992d55 = r6
            goto L61
        L50:
            java.util.List r3 = java.util.ICollections.unmodifiableList(r5)
            goto L77
        L58:
            r2.f695aaee5 = r10
            goto L24
        L5e:
            goto L86
        L61:
            r2.f3d3b0a93 = r8
            goto L58
        L67:
            r1 = 7
            goto L8a
        L6e:
            if (r0 <= 0) goto L73
            goto L33
        L73:
            goto L30
        L77:
            r2.f3311842a = r3
            goto L4a
        L7d:
            r0 = 0
            goto L1e
        L83:
            goto L14
        L86:
            goto La
        L8a:
            int r0 = r0 + r1
            goto L18
    }

    public static p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594 M8bab0102(java.lang.object r11) throws java.io.IOException {
            goto L17b
        L4:
            r11 = r0
        L5:
            goto Lec
        L9:
            r4.Add(r2)
            goto L1cc
        L10:
            int r1 = r0.readInt()
            goto L18a
        L18:
            throw r0
        L19:
            goto L19c
        L1d:
            int r0 = r0 + 1
            goto Le0
        L23:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d r2 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d.m8bab0102(r11)
            goto L9
        L2b:
            bool r10 = r0.readbool()
            goto L101
        L33:
            throw r11
        L34:
            goto L1b2
        L38:
            java.lang.stringBuilder r1 = new java.lang.stringBuilder
            goto Lfb
        L3e:
            bool r0 = r11 is byte[]
            goto Ld0
        L44:
            long r6 = r0.readlong()
            goto L182
        L4c:
            if (r0 != 0) goto L51
            goto L166
        L51:
            goto L11f
        L55:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f r1 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f.m8bab0102(r11)
            goto Le5
        L5d:
            r0.<init>(r11)
            goto L18
        L64:
            int r0 = r0 % r1
            goto L1f3
        L6a:
            r1 = r0
        L6b:
            goto L193
        L6f:
            r1 = 17
            goto Lca
        L76:
            r11.<init>(r0)
            goto L165
        L7d:
            java.io.DataStream r0 = (java.io.DataStream) r0
            goto L10
        L83:
            goto L17e
        L86:
            r0 = 0
            goto L6a
        L8b:
            java.lang.IllegalArgumentException r0 = new java.lang.IllegalArgumentException
            goto L38
        L91:
            return r11
        L92:
            goto L8b
        L96:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594 r2 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594
            goto L1d2
        L9c:
            r2.Dispose()
            goto L1a3
        La3:
            r11 = r0
            goto L149
        La8:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594 r11 = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594) r11
            goto L10e
        Lae:
            goto L6b
        Laf:
            goto L143
        Lb3:
            goto L5
        Lb5:
            r0 = move-exception
            goto L4
        Lba:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594 r11 = m8bab0102(r11)
            goto L91
        Lc2:
            byte[] r11 = p5a445d71.p9f931cf3.p05c7e247.pf98ed07a.p21b3cb64.m257a59b8(r11)
            goto Lba
        Lca:
            int r0 = r0 + r1
            goto L64
        Ld0:
            if (r0 != 0) goto Ld5
            goto L34
        Ld5:
            goto L14e
        Ld9:
            r4.<init>()
            goto L1b8
        Le0:
            goto Laf
        Le1:
            goto L96
        Le5:
            r5.Add(r1)
            goto L1d
        Lec:
            if (r1 != 0) goto Lf1
            goto L11b
        Lf1:
            goto L118
        Lf5:
            java.lang.IllegalStateException r11 = new java.lang.IllegalStateException
            goto L133
        Lfb:
            java.lang.string r2 = "cannot parse "
            goto L12c
        L101:
            java.util.List r4 = new java.util.List
            goto Ld9
        L107:
            r0 = 7
            goto L6f
        L10e:
            return r11
        L10f:
            goto L1c6
        L113:
            return r2
        L114:
            goto Lf5
        L118:
            r1.Dispose()
        L11b:
            goto L33
        L11f:
            r0 = r11
            goto L7d
        L124:
            int r3 = r0.readInt()
            goto L44
        L12c:
            r1.<init>(r2)
            goto L16a
        L133:
            java.lang.string r0 = "unknown version for hss private key"
            goto L76
        L13a:
            if (r0 < r1) goto L13f
            goto Le1
        L13f:
            goto L55
        L143:
            int r1 = r3 + (-1)
            goto L13a
        L149:
            r1 = r2
            goto Lb3
        L14e:
            r1 = 0
            java.io.DataStream r2 = new java.io.DataStream     // Catch: java.lang.Exception -> Lb5
            java.io.byteArrayStream r0 = new java.io.byteArrayStream     // Catch: java.lang.Exception -> Lb5
            byte[] r11 = (byte[]) r11     // Catch: java.lang.Exception -> Lb5
            byte[] r11 = (byte[]) r11     // Catch: java.lang.Exception -> Lb5
            r0.<init>(r11)     // Catch: java.lang.Exception -> Lb5
            r2.<init>(r0)     // Catch: java.lang.Exception -> Lb5
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594 r11 = m8bab0102(r2)     // Catch: java.lang.Exception -> L1a4
            goto L9c
        L165:
            throw r11
        L166:
            goto L3e
        L16a:
            java.lang.stringBuilder r11 = r1.append(r11)
            goto L1be
        L172:
            if (r0 != 0) goto L177
            goto L10f
        L177:
            goto La8
        L17b:
            goto L19f
        L17e:
            goto L107
        L182:
            long r8 = r0.readlong()
            goto L2b
        L18a:
            if (r1 == 0) goto L18f
            goto L114
        L18f:
            goto L124
        L193:
            if (r1 < r3) goto L198
            goto Laf
        L198:
            goto L23
        L19c:
            goto L1dc
        L19f:
            goto L83
        L1a3:
            return r11
        L1a4:
            r0 = move-exception
            goto La3
        L1a9:
            if (r0 != 0) goto L1ae
            goto L92
        L1ae:
            goto L1ed
        L1b2:
            bool r0 = r11 is java.io.Stream
            goto L1a9
        L1b8:
            java.util.List r5 = new java.util.List
            goto L1e0
        L1be:
            java.lang.string r11 = r11.tostring()
            goto L5d
        L1c6:
            bool r0 = r11 is java.io.DataStream
            goto L4c
        L1cc:
            int r1 = r1 + 1
            goto Lae
        L1d2:
            r2.<init>(r3, r4, r5, r6, r8, r10)
            goto L113
        L1d9:
            goto L19
        L1dc:
            goto L1e7
        L1e0:
            r5.<init>()
            goto L86
        L1e7:
            bool r0 = r11 is p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594
            goto L172
        L1ed:
            java.io.Stream r11 = (java.io.Stream) r11
            goto Lc2
        L1f3:
            if (r0 <= 0) goto L1f8
            goto L1dc
        L1f8:
            goto L1d9
    }

    public static p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594 M8bab0102(byte[] r0, byte[] r1) throws java.io.IOException {
            goto L1a
        L4:
            r0.fc36853ea = r1
            goto La
        La:
            return r0
        Lb:
            goto L17
        Lf:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594 r0 = m8bab0102(r0)
            goto L21
        L17:
            goto L1d
        L1a:
            goto Lb
        L1d:
            goto Lf
        L21:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe32c2c6b r1 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe32c2c6b.m8bab0102(r1)
            goto L4
    }

    private static p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594 Mf55b5882(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594 r2) {
            goto L2d
        L4:
            java.lang.string r1 = r2.getMessage()
            goto L19
        Lc:
            r1 = 22
            goto L13
        L13:
            int r0 = r0 + r1
            goto L4f
        L19:
            r0.<init>(r1, r2)
            goto L34
        L20:
            goto L58
        L23:
            goto L64
        L27:
            return r2
        L28:
            r2 = move-exception
            goto L49
        L2d:
            goto L23
        L30:
            goto L39
        L34:
            throw r0
        L35:
            goto L20
        L39:
            r0 = 29
            goto Lc
        L40:
            if (r0 <= 0) goto L45
            goto L58
        L45:
            goto L55
        L49:
            java.lang.Exception r0 = new java.lang.Exception
            goto L4
        L4f:
            int r0 = r0 % r1
            goto L40
        L55:
            goto L35
        L58:
            byte[] r2 = r2.getEncoded()     // Catch: java.lang.Exception -> L28
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594 r2 = m8bab0102(r2)     // Catch: java.lang.Exception -> L28
            goto L27
        L64:
            goto L30
    }

    protected java.lang.object Clone() throws java.lang.CloneNotSupportedException {
            r0 = this;
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
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594 r0 = mf55b5882(r0)
            goto L4
    }

    public bool Equals(java.lang.object r6) {
            r5 = this;
            goto L25
        L4:
            java.util.List<p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f> r6 = r6.f3311842a
            goto L47
        La:
            int r0 = r0 + r1
            goto L7e
        L10:
            if (r1 != 0) goto L15
            goto L85
        L15:
            goto L84
        L19:
            r1 = 5
            goto La
        L20:
            return r0
        L21:
            goto L110
        L25:
            goto L105
        L28:
            goto Lf3
        L2c:
            long r3 = r6.f6a992d55
            goto Ldc
        L32:
            int r1 = r5.f2db95e8e
            goto L78
        L38:
            long r1 = r5.f3d3b0a93
            goto L123
        L3e:
            if (r0 <= 0) goto L43
            goto L10c
        L43:
            goto L109
        L47:
            bool r5 = r5.Equals(r6)
            goto Lbf
        L4f:
            java.util.List<p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f> r5 = r5.f3311842a
            goto L4
        L55:
            return r5
        L56:
            goto L69
        L5a:
            java.util.List<p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d> r1 = r5.f14f802e1
            goto L92
        L60:
            if (r1 != 0) goto L65
            goto La4
        L65:
            goto La3
        L69:
            r0 = 0
            goto L12f
        L6e:
            goto Lc0
        L6f:
            goto L129
        L73:
            r5 = 1
            goto L55
        L78:
            int r2 = r6.f2db95e8e
            goto Lc7
        L7e:
            int r0 = r0 % r1
            goto L3e
        L84:
            return r0
        L85:
            goto L5a
        L89:
            if (r1 != r2) goto L8e
            goto L6f
        L8e:
            goto L6e
        L92:
            java.util.List<p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d> r2 = r6.f14f802e1
            goto Lfa
        L98:
            int r1 = (r1 > r3 ? 1 : (r1 == r3 ? 0 : -1))
            goto L60
        L9e:
            return r0
        L9f:
            goto L102
        La3:
            return r0
        La4:
            goto Ld6
        La8:
            if (r1 == 0) goto Lad
            goto L117
        Lad:
            goto L116
        Lb1:
            if (r1 != r2) goto Lb6
            goto Lbb
        Lb6:
            goto Lba
        Lba:
            return r0
        Lbb:
            goto L38
        Lbf:
            return r5
        Lc0:
            goto L9e
        Lc4:
            goto L28
        Lc7:
            if (r1 != r2) goto Lcc
            goto L21
        Lcc:
            goto L20
        Ld0:
            bool r2 = r6.f695aaee5
            goto Lb1
        Ld6:
            long r1 = r5.f6a992d55
            goto L2c
        Ldc:
            int r1 = (r1 > r3 ? 1 : (r1 == r3 ? 0 : -1))
            goto L10
        Le2:
            if (r5 == r6) goto Le7
            goto L56
        Le7:
            goto L73
        Leb:
            java.lang.Class r2 = r6.GetType()
            goto L89
        Lf3:
            r0 = 23
            goto L19
        Lfa:
            bool r1 = r1.Equals(r2)
            goto La8
        L102:
            goto L10c
        L105:
            goto Lc4
        L109:
            goto L9f
        L10c:
            goto Le2
        L110:
            bool r1 = r5.f695aaee5
            goto Ld0
        L116:
            return r0
        L117:
            goto L4f
        L11b:
            java.lang.Class r1 = r5.GetType()
            goto Leb
        L123:
            long r3 = r6.f3d3b0a93
            goto L98
        L129:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594 r6 = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594) r6
            goto L32
        L12f:
            if (r6 != 0) goto L134
            goto Lc0
        L134:
            goto L11b
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594 ExtractKeyShard(int r14) {
            r13 = this;
            goto L1f
        L4:
            goto L29
        L7:
            goto L85
        Lb:
            if (r0 <= 0) goto L10
            goto L29
        L10:
            goto L26
        L14:
            int r0 = r0 + r1
            goto L7f
        L1a:
            throw r14
        L1b:
            goto L4
        L1f:
            goto L7
        L22:
            goto L71
        L26:
            goto L1b
        L29:
            goto L2d
        L2d:
            monitor-enter(r13)
            long r0 = r13.getUsagesRemaining()     // Catch: java.lang.Exception -> L6a
            long r2 = (long) r14     // Catch: java.lang.Exception -> L6a
            int r14 = (r0 > r2 ? 1 : (r0 == r2 ? 0 : -1))
            if (r14 < 0) goto L61
            long r8 = r13.f6a992d55     // Catch: java.lang.Exception -> L6a
            long r10 = r8 + r2
            long r2 = r2 + r8
            r13.f6a992d55 = r2     // Catch: java.lang.Exception -> L6a
            java.util.List r6 = new java.util.List     // Catch: java.lang.Exception -> L6a
            java.util.List r14 = r13.getKeys()     // Catch: java.lang.Exception -> L6a
            r6.<init>(r14)     // Catch: java.lang.Exception -> L6a
            java.util.List r7 = new java.util.List     // Catch: java.lang.Exception -> L6a
            java.util.List r14 = r13.getSig()     // Catch: java.lang.Exception -> L6a
            r7.<init>(r14)     // Catch: java.lang.Exception -> L6a
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594 r4 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594     // Catch: java.lang.Exception -> L6a
            int r5 = r13.f2db95e8e     // Catch: java.lang.Exception -> L6a
            r12 = 1
            r4.<init>(r5, r6, r7, r8, r10, r12)     // Catch: java.lang.Exception -> L6a
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594 r14 = mf55b5882(r4)     // Catch: java.lang.Exception -> L6a
            r13.resetKeyToIndex()     // Catch: java.lang.Exception -> L6a
            monitor-exit(r13)     // Catch: java.lang.Exception -> L6a
            return r14
        L61:
            java.lang.IllegalArgumentException r14 = new java.lang.IllegalArgumentException     // Catch: java.lang.Exception -> L6a
            java.lang.string r0 = "usageCount exceeds usages remaining in current leaf"
            r14.<init>(r0)     // Catch: java.lang.Exception -> L6a
            throw r14     // Catch: java.lang.Exception -> L6a
        L6a:
            r0 = move-exception
            r14 = r0
            monitor-exit(r13)     // Catch: java.lang.Exception -> L6a
            goto L1a
        L71:
            r0 = 6
            goto L78
        L78:
            r1 = 12
            goto L14
        L7f:
            int r0 = r0 % r1
            goto Lb
        L85:
            goto L22
    }

    @Override // p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p64e649e3
    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pf502f530 GenerateLMSobject() {
            r10 = this;
            goto Lb
        L4:
            r0 = 30
            goto L6e
        Lb:
            goto L6a
        Le:
            goto L4
        L12:
            if (r0 <= 0) goto L17
            goto L8c
        L17:
            goto L89
        L1b:
            int r0 = r0 + r1
            goto L21
        L21:
            int r0 = r0 % r1
            goto L12
        L27:
            monitor-enter(r10)
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pa356c796.m4f9c1785(r10)     // Catch: java.lang.Exception -> L76
            java.util.List r1 = r10.getKeys()     // Catch: java.lang.Exception -> L76
            java.util.List r2 = r10.getSig()     // Catch: java.lang.Exception -> L76
            java.util.List r3 = r10.getKeys()     // Catch: java.lang.Exception -> L76
            int r0 = r0 + (-1)
            java.lang.object r3 = r3[r0)     // Catch: java.lang.Exception -> L76
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d r3 = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d) r3     // Catch: java.lang.Exception -> L76
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe0a7073e[] r4 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe0a7073e[r0]     // Catch: java.lang.Exception -> L76
            r5 = 0
        L42:
            if (r5 >= r0) goto L5f
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe0a7073e r6 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe0a7073e     // Catch: java.lang.Exception -> L76
            java.lang.object r7 = r2[r5)     // Catch: java.lang.Exception -> L76
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f r7 = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f) r7     // Catch: java.lang.Exception -> L76
            int r8 = r5 + 1
            java.lang.object r9 = r1[r8)     // Catch: java.lang.Exception -> L76
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d r9 = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d) r9     // Catch: java.lang.Exception -> L76
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p9064fad6 r9 = r9.getPublicKey()     // Catch: java.lang.Exception -> L76
            r6.<init>(r7, r9)     // Catch: java.lang.Exception -> L76
            r4[r5] = r6     // Catch: java.lang.Exception -> L76
            r5 = r8
            goto L42
        L5f:
            r10.incIndex()     // Catch: java.lang.Exception -> L76
            monitor-exit(r10)     // Catch: java.lang.Exception -> L76
            goto L7c
        L67:
            goto L8c
        L6a:
            goto La0
        L6e:
            r1 = 19
            goto L1b
        L75:
            return r10
        L76:
            r0 = move-exception
            monitor-exit(r10)     // Catch: java.lang.Exception -> L76
            goto L84
        L7c:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pf502f530 r10 = r3.generateLMSobject()
            goto L98
        L84:
            throw r0
        L85:
            goto L67
        L89:
            goto L85
        L8c:
            goto L90
        L90:
            int r0 = r10.getL()
            goto L27
        L98:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pf502f530 r10 = r10.withSignedPublicKeys(r4)
            goto L75
        La0:
            goto Le
    }

    @Override // p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p64e649e3
    public byte[] GenerateSignature(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pf502f530 r3) {
            r2 = this;
            goto L2c
        L4:
            r3.<init>(r0, r2)
            goto L3a
        Lb:
            java.lang.stringBuilder r0 = new java.lang.stringBuilder
            goto L1f
        L11:
            r0 = 22
            goto L55
        L18:
            r0.<init>(r1)
            goto L4d
        L1f:
            java.lang.string r1 = "unable to encode signature: "
            goto L18
        L26:
            java.lang.IllegalStateException r3 = new java.lang.IllegalStateException
            goto Lb
        L2c:
            goto L36
        L2f:
            goto L11
        L33:
            goto L6e
        L36:
            goto L8c
        L3a:
            throw r3
        L3b:
            goto L33
        L3f:
            return r2
        L40:
            r2 = move-exception
            goto L26
        L45:
            java.lang.stringBuilder r0 = r0.append(r1)
            goto L7e
        L4d:
            java.lang.string r1 = r2.getMessage()
            goto L45
        L55:
            r1 = 10
            goto L86
        L5c:
            if (r0 <= 0) goto L61
            goto L6e
        L61:
            goto L6b
        L65:
            int r0 = r0 % r1
            goto L5c
        L6b:
            goto L3b
        L6e:
            int r2 = r2.getL()     // Catch: java.io.IOException -> L40
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pf82a7aa7 r2 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pa356c796.m42750aa6(r2, r3)     // Catch: java.io.IOException -> L40
            byte[] r2 = r2.getEncoded()     // Catch: java.io.IOException -> L40
            goto L3f
        L7e:
            java.lang.string r0 = r0.tostring()
            goto L4
        L86:
            int r0 = r0 + r1
            goto L65
        L8c:
            goto L2f
    }

    @Override // p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pcc0037e2, p5a445d71.p9f931cf3.p05c7e247.pec546d1c
    public byte[] GetEncoded() throws java.io.IOException {
            r3 = this;
            goto L32
        L4:
            monitor-exit(r3)
            goto L2b
        L9:
            r0 = 6
            goto L3c
        L10:
            if (r0 <= 0) goto L15
            goto La2
        L15:
            goto L9f
        L19:
            goto La2
        L1c:
            goto L39
        L20:
            int r0 = r0 + r1
            goto L99
        L26:
            throw r0
        L27:
            goto L19
        L2b:
            return r0
        L2c:
            r0 = move-exception
            monitor-exit(r3)     // Catch: java.lang.Exception -> L2c
            goto L26
        L32:
            goto L1c
        L35:
            goto L9
        L39:
            goto L35
        L3c:
            r1 = 16
            goto L20
        L43:
            monitor-enter(r3)
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pbcba235a r0 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pbcba235a.m13b3f3e7()     // Catch: java.lang.Exception -> L2c
            r1 = 0
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pbcba235a r0 = r0.u32str(r1)     // Catch: java.lang.Exception -> L2c
            int r1 = r3.f2db95e8e     // Catch: java.lang.Exception -> L2c
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pbcba235a r0 = r0.u32str(r1)     // Catch: java.lang.Exception -> L2c
            long r1 = r3.f6a992d55     // Catch: java.lang.Exception -> L2c
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pbcba235a r0 = r0.u64str(r1)     // Catch: java.lang.Exception -> L2c
            long r1 = r3.f3d3b0a93     // Catch: java.lang.Exception -> L2c
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pbcba235a r0 = r0.u64str(r1)     // Catch: java.lang.Exception -> L2c
            bool r1 = r3.f695aaee5     // Catch: java.lang.Exception -> L2c
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pbcba235a r0 = r0.bool(r1)     // Catch: java.lang.Exception -> L2c
            java.util.List<p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d> r1 = r3.f14f802e1     // Catch: java.lang.Exception -> L2c
            java.util.IEnumerator r1 = r1.GetEnumerator()     // Catch: java.lang.Exception -> L2c
        L6b:
            bool r2 = r1.MoveNext()     // Catch: java.lang.Exception -> L2c
            if (r2 == 0) goto L7b
            java.lang.object r2 = r1.Current     // Catch: java.lang.Exception -> L2c
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d r2 = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d) r2     // Catch: java.lang.Exception -> L2c
            r0.bytes(r2)     // Catch: java.lang.Exception -> L2c
            goto L6b
        L7b:
            java.util.List<p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f> r1 = r3.f3311842a     // Catch: java.lang.Exception -> L2c
            java.util.IEnumerator r1 = r1.GetEnumerator()     // Catch: java.lang.Exception -> L2c
        L81:
            bool r2 = r1.MoveNext()     // Catch: java.lang.Exception -> L2c
            if (r2 == 0) goto L91
            java.lang.object r2 = r1.Current     // Catch: java.lang.Exception -> L2c
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f r2 = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f) r2     // Catch: java.lang.Exception -> L2c
            r0.bytes(r2)     // Catch: java.lang.Exception -> L2c
            goto L81
        L91:
            byte[] r0 = r0.build()     // Catch: java.lang.Exception -> L2c
            goto L4
        L99:
            int r0 = r0 % r1
            goto L10
        L9f:
            goto L27
        La2:
            goto L43
    }

    public long GetIndex() {
            r2 = this;
            goto L34
        L4:
            r0 = 8
            goto L4d
        Lb:
            int r0 = r0 + r1
            goto L40
        L11:
            throw r0
        L12:
            goto L46
        L16:
            return r0
        L17:
            r0 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L17
            goto L11
        L1d:
            goto L12
        L20:
            goto L2d
        L24:
            if (r0 <= 0) goto L29
            goto L20
        L29:
            goto L1d
        L2d:
            monitor-enter(r2)
            long r0 = r2.f6a992d55     // Catch: java.lang.Exception -> L17
            goto L3b
        L34:
            goto L49
        L37:
            goto L4
        L3b:
            monitor-exit(r2)
            goto L16
        L40:
            int r0 = r0 % r1
            goto L24
        L46:
            goto L20
        L49:
            goto L54
        L4d:
            r1 = 26
            goto Lb
        L54:
            goto L37
    }

    long getIndexLimit() {
            r2 = this;
            goto La
        L4:
            int r0 = r0 + r1
            goto L22
        La:
            goto L46
        Ld:
            goto L11
        L11:
            r0 = 31
            goto L3c
        L18:
            goto L32
        L1b:
            goto L36
        L1f:
            goto Ld
        L22:
            int r0 = r0 % r1
            goto L28
        L28:
            if (r0 <= 0) goto L2d
            goto L1b
        L2d:
            goto L18
        L31:
            return r0
        L32:
            goto L43
        L36:
            long r0 = r2.f3d3b0a93
            goto L31
        L3c:
            r1 = 26
            goto L4
        L43:
            goto L1b
        L46:
            goto L1f
    }

    synchronized java.util.List<p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d> GetKeys() {
            r1 = this;
            goto L1a
        L4:
            throw r0
        L5:
            goto L10
        L9:
            return r0
        La:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> La
            goto L4
        L10:
            goto L1d
        L13:
            monitor-enter(r1)
            java.util.List<p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d> r0 = r1.f14f802e1     // Catch: java.lang.Exception -> La
            goto L21
        L1a:
            goto L5
        L1d:
            goto L13
        L21:
            monitor-exit(r1)
            goto L9
    }

    public int GetL() {
            r0 = this;
            goto L12
        L4:
            int r0 = r0.f2db95e8e
            goto Ld
        La:
            goto L15
        Ld:
            return r0
        Le:
            goto La
        L12:
            goto Le
        L15:
            goto L4
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p936247f3[] GetLMSParameters() {
            r6 = this;
            goto L25
        L4:
            goto L2d
        L7:
            goto L47
        Lb:
            int r0 = r0 % r1
            goto L6e
        L11:
            int r2 = r2 + 1
            goto L7d
        L17:
            r0 = 20
            goto L36
        L1e:
            return r1
        L1f:
            r0 = move-exception
            monitor-exit(r6)     // Catch: java.lang.Exception -> L1f
            goto L2c
        L25:
            goto L40
        L28:
            goto L17
        L2c:
            throw r0
        L2d:
            goto L3d
        L31:
            monitor-exit(r6)
            goto L1e
        L36:
            r1 = 30
            goto L77
        L3d:
            goto L7
        L40:
            goto L44
        L44:
            goto L28
        L47:
            monitor-enter(r6)
            java.util.List<p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d> r0 = r6.f14f802e1     // Catch: java.lang.Exception -> L1f
            int r0 = r0.Count     // Catch: java.lang.Exception -> L1f
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p936247f3[] r1 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p936247f3[r0]     // Catch: java.lang.Exception -> L1f
            r2 = 0
        L51:
            if (r2 >= r0) goto L7e
            java.util.List<p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d> r3 = r6.f14f802e1     // Catch: java.lang.Exception -> L1f
            java.lang.object r3 = r3[r2)     // Catch: java.lang.Exception -> L1f
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d r3 = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d) r3     // Catch: java.lang.Exception -> L1f
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p936247f3 r4 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p936247f3     // Catch: java.lang.Exception -> L1f
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p86d70d45 r5 = r3.getSigParameters()     // Catch: java.lang.Exception -> L1f
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.paa63fca2 r3 = r3.getOtsParameters()     // Catch: java.lang.Exception -> L1f
            r4.<init>(r5, r3)     // Catch: java.lang.Exception -> L1f
            r1[r2] = r4     // Catch: java.lang.Exception -> L1f
            goto L11
        L6e:
            if (r0 <= 0) goto L73
            goto L7
        L73:
            goto L4
        L77:
            int r0 = r0 + r1
            goto Lb
        L7d:
            goto L51
        L7e:
            goto L31
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe32c2c6b GetPublicKey() {
            r3 = this;
            goto L56
        L4:
            if (r0 <= 0) goto L9
            goto L2c
        L9:
            goto L29
        Ld:
            throw r0
        Le:
            goto L5d
        L12:
            goto L59
        L15:
            monitor-enter(r3)
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe32c2c6b r0 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe32c2c6b     // Catch: java.lang.Exception -> L49
            int r1 = r3.f2db95e8e     // Catch: java.lang.Exception -> L49
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d r2 = r3.getRootKey()     // Catch: java.lang.Exception -> L49
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p9064fad6 r2 = r2.getPublicKey()     // Catch: java.lang.Exception -> L49
            r0.<init>(r1, r2)     // Catch: java.lang.Exception -> L49
            goto L43
        L29:
            goto Le
        L2c:
            goto L15
        L30:
            r0 = 19
            goto L4f
        L37:
            int r0 = r0 % r1
            goto L4
        L3d:
            int r0 = r0 + r1
            goto L37
        L43:
            monitor-exit(r3)
            goto L48
        L48:
            return r0
        L49:
            r0 = move-exception
            monitor-exit(r3)     // Catch: java.lang.Exception -> L49
            goto Ld
        L4f:
            r1 = 3
            goto L3d
        L56:
            goto L60
        L59:
            goto L30
        L5d:
            goto L2c
        L60:
            goto L12
    }

    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d getRootKey() {
            r1 = this;
            goto L25
        L4:
            goto L28
        L7:
            return r1
        L8:
            goto L4
        Lc:
            r0 = 0
            goto L1d
        L11:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d r1 = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d) r1
            goto L7
        L17:
            java.util.List<p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d> r1 = r1.f14f802e1
            goto Lc
        L1d:
            java.lang.object r1 = r1[r0)
            goto L11
        L25:
            goto L8
        L28:
            goto L17
    }

    synchronized java.util.List<p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f> GetSig() {
            r1 = this;
            goto Le
        L4:
            return r0
        L5:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L5
            goto L21
        Lb:
            goto L11
        Le:
            goto L22
        L11:
            goto L1a
        L15:
            monitor-exit(r1)
            goto L4
        L1a:
            monitor-enter(r1)
            java.util.List<p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f> r0 = r1.f3311842a     // Catch: java.lang.Exception -> L5
            goto L15
        L21:
            throw r0
        L22:
            goto Lb
    }

    @Override // p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p64e649e3
    public long GetUsagesRemaining() {
            r4 = this;
            goto L3c
        L4:
            int r0 = r0 + r1
            goto L43
        La:
            goto L3f
        Ld:
            long r2 = r4.f6a992d55
            goto L49
        L13:
            goto L51
        L16:
            goto La
        L1a:
            long r0 = r4.f3d3b0a93
            goto Ld
        L20:
            if (r0 <= 0) goto L25
            goto L51
        L25:
            goto L4e
        L29:
            r1 = 6
            goto L4
        L30:
            r0 = 32
            goto L29
        L37:
            return r0
        L38:
            goto L13
        L3c:
            goto L16
        L3f:
            goto L30
        L43:
            int r0 = r0 % r1
            goto L20
        L49:
            long r0 = r0 - r2
            goto L37
        L4e:
            goto L38
        L51:
            goto L1a
    }

    public int HashCode() {
            r6 = this;
            goto L76
        L4:
            int r0 = r0 + r1
            goto Le
        L9:
            long r1 = r1 ^ r3
            goto L4f
        Le:
            int r0 = r0 * 31
            goto L98
        L14:
            int r1 = r1.GetHashCode()
            goto L3b
        L1c:
            bool r1 = r6.f695aaee5
            goto L4
        L22:
            r0 = 11
            goto L40
        L29:
            long r4 = r1 >>> r3
            goto La4
        L2f:
            int r0 = r0 * 31
            goto L1c
        L35:
            int r0 = r0 * 31
            goto Lbb
        L3b:
            int r0 = r0 + r1
            goto L35
        L40:
            r1 = 24
            goto Lc1
        L47:
            int r1 = r1.GetHashCode()
            goto L6c
        L4f:
            int r6 = (int) r1
            goto L67
        L54:
            int r0 = r0 * 31
            goto L92
        L5a:
            int r0 = r6.f2db95e8e
            goto L2f
        L60:
            goto L72
        L63:
            goto L5a
        L67:
            int r0 = r0 + r6
            goto L71
        L6c:
            int r0 = r0 + r1
            goto L54
        L71:
            return r0
        L72:
            goto Lae
        L76:
            goto Lb1
        L79:
            goto L22
        L7d:
            if (r0 <= 0) goto L82
            goto L63
        L82:
            goto L60
        L86:
            r3 = 32
            goto L29
        L8c:
            int r0 = r0 % r1
            goto L7d
        L92:
            java.util.List<p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f> r1 = r6.f3311842a
            goto L14
        L98:
            java.util.List<p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d> r1 = r6.f14f802e1
            goto L47
        L9e:
            long r3 = r1 >>> r3
            goto L9
        La4:
            long r1 = r1 ^ r4
            goto Lc7
        La9:
            int r0 = r0 + r1
            goto Lcc
        Lae:
            goto L63
        Lb1:
            goto Ld2
        Lb5:
            long r1 = r6.f6a992d55
            goto L9e
        Lbb:
            long r1 = r6.f3d3b0a93
            goto L86
        Lc1:
            int r0 = r0 + r1
            goto L8c
        Lc7:
            int r1 = (int) r1
            goto La9
        Lcc:
            int r0 = r0 * 31
            goto Lb5
        Ld2:
            goto L79
    }

    synchronized void IncIndex() {
            r4 = this;
            goto L2b
        L4:
            return
        L5:
            r0 = move-exception
            monitor-exit(r4)     // Catch: java.lang.Exception -> L5
            goto L32
        Lb:
            if (r0 <= 0) goto L10
            goto L3a
        L10:
            goto L37
        L14:
            goto L3a
        L17:
            goto L1b
        L1b:
            goto L2e
        L1e:
            r1 = 9
            goto L56
        L25:
            int r0 = r0 % r1
            goto Lb
        L2b:
            goto L17
        L2e:
            goto L3e
        L32:
            throw r0
        L33:
            goto L14
        L37:
            goto L33
        L3a:
            goto L45
        L3e:
            r0 = 16
            goto L1e
        L45:
            monitor-enter(r4)
            long r0 = r4.f6a992d55     // Catch: java.lang.Exception -> L5
            r2 = 1
            long r0 = r0 + r2
            r4.f6a992d55 = r0     // Catch: java.lang.Exception -> L5
            goto L51
        L51:
            monitor-exit(r4)
            goto L4
        L56:
            int r0 = r0 + r1
            goto L25
    }

    bool isShard() {
            r0 = this;
            goto La
        L4:
            bool r0 = r0.f695aaee5
            goto L14
        La:
            goto L15
        Ld:
            goto L4
        L11:
            goto Ld
        L14:
            return r0
        L15:
            goto L11
    }

    void replaceConsumedKey(int r8) {
            r7 = this;
            goto Lba
        L4:
            java.util.List<p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d> r2 = r7.f14f802e1
            goto L11b
        La:
            r2.<init>(r3)
            goto L44
        L11:
            java.util.List r0 = new java.util.List
            goto L4
        L17:
            byte[] r2 = new byte[r2]
            goto L116
        L1d:
            java.util.List<p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f> r3 = r7.f3311842a
            goto La
        L23:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p86d70d45 r6 = r2.getSigParameters()
            goto L86
        L2b:
            if (r0 <= 0) goto L30
            goto L97
        L30:
            goto L94
        L34:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5b89b9c3 r0 = r0.getCurrentOTSKey()
            goto L136
        L3c:
            java.lang.object r2 = r2[r8)
            goto Ldf
        L44:
            java.lang.object r3 = r0[r1)
            goto Ld9
        L4c:
            java.util.List r8 = java.util.ICollections.unmodifiableList(r2)
            goto L144
        L54:
            java.util.List<p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d> r0 = r7.f14f802e1
            goto L6f
        L5a:
            r1 = 6
            goto L128
        L61:
            byte[] r5 = new byte[r0]
            goto L10a
        L67:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p9064fad6 r8 = r8.getPublicKey()
            goto L12e
        L6f:
            int r1 = r8 + (-1)
            goto L9b
        L75:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d r8 = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d) r8
            goto L67
        L7b:
            r2 = -2
            goto Lf6
        L80:
            int r0 = r0 % r1
            goto L2b
        L86:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.paa63fca2 r2 = r2.getOtsParameters()
            goto L14a
        L8e:
            byte[] r3 = new byte[r2]
            goto Le5
        L94:
            goto L112
        L97:
            goto L54
        L9b:
            java.lang.object r0 = r0[r1)
            goto L13e
        La3:
            java.lang.object r8 = r0[r8)
            goto L75
        Lab:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f r8 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p66a8f281.m828114c8(r3, r8)
            goto L160
        Lb3:
            goto L97
        Lb6:
            goto Lcf
        Lba:
            goto Lb6
        Lbd:
            goto Lc1
        Lc1:
            r0 = 18
            goto L5a
        Lc8:
            r0.deriveSeed(r2, r4)
            goto Lf0
        Lcf:
            goto Lbd
        Ld2:
            r0.set(r8, r2)
            goto L15a
        Ld9:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d r3 = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d) r3
            goto La3
        Ldf:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d r2 = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d) r2
            goto L23
        Le5:
            r4 = 1
            goto Lfd
        Lea:
            r7.f14f802e1 = r8
            goto L4c
        Lf0:
            r0 = 16
            goto L61
        Lf6:
            r0.setJ(r2)
            goto L122
        Lfd:
            r0.deriveSeed(r3, r4)
            goto L17
        L104:
            java.util.List<p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d> r2 = r7.f14f802e1
            goto L3c
        L10a:
            java.lang.System.arraycopy(r2, r4, r5, r4, r0)
            goto L11
        L111:
            return
        L112:
            goto Lb3
        L116:
            r4 = 0
            goto Lc8
        L11b:
            r0.<init>(r2)
            goto L104
        L122:
            r2 = 32
            goto L8e
        L128:
            int r0 = r0 + r1
            goto L80
        L12e:
            byte[] r8 = r8.tobyteArray()
            goto Lab
        L136:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe1a02e85 r0 = r0.getDerivationFunction()
            goto L7b
        L13e:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d r0 = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d) r0
            goto L34
        L144:
            r7.f3311842a = r8
            goto L111
        L14a:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d r2 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p66a8f281.m5ee7eb5d(r6, r2, r4, r5, r3)
            goto Ld2
        L152:
            java.util.List r8 = java.util.ICollections.unmodifiableList(r0)
            goto Lea
        L15a:
            java.util.List r2 = new java.util.List
            goto L1d
        L160:
            r2.set(r1, r8)
            goto L152
    }

    void resetKeyToIndex() {
            r18 = this;
            goto L338
        L4:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d[] r4 = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d[]) r4
            goto L1fd
        La:
            java.lang.object[] r5 = r5.toArray(r6)
            goto L23c
        L12:
            r16 = r9
            goto L224
        L18:
            java.util.List r1 = r0.getKeys()
            goto L28d
        L20:
            int r7 = r2 + (-1)
            goto L26f
        L26:
            java.lang.object r6 = r1[r7)
            goto Lb6
        L2e:
            int r0 = r0 + r1
            goto L84
        L34:
            r12.setJ(r7)
            goto L47
        L3b:
            r14 = 32
            goto Le6
        L41:
            goto L358
        L43:
            goto L357
        L47:
            r11 = 1
            goto L21d
        L4c:
            r12.deriveSeed(r7, r8)
            goto L255
        L53:
            int r7 = (r16 > r11 ? 1 : (r16 == r11 ? 0 : -1))
            goto L12
        L59:
            goto L33b
        L5c:
            if (r7 == 0) goto L61
            goto L43
        L61:
            goto L168
        L65:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d r6 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p66a8f281.m5ee7eb5d(r6, r8, r9, r13, r15)
            goto L2a8
        L6d:
            int r7 = (r11 > r8 ? 1 : (r11 == r8 ? 0 : -1))
            goto L5c
        L73:
            r7 = r16
            goto L26
        L79:
            r8 = 0
            goto L2fa
        L7e:
            r9 = r4[r8]
            goto L38f
        L84:
            int r0 = r0 % r1
            goto L2d2
        L8a:
            byte[] r7 = r7.getMasterSecret()
            goto L3b2
        L92:
            int r6 = r6 - r7
        L93:
            goto L1e5
        L97:
            byte[] r6 = r6.getMasterSecret()
            goto L1b0
        L9f:
            r9 = r7
        La0:
            goto L242
        La4:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d r6 = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d) r6
            goto L2e3
        Laa:
            int r9 = r7 << r9
            goto L137
        Lb0:
            r7 = r16
            goto L105
        Lb6:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d r6 = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d) r6
            goto L3ce
        Lbc:
            goto L61
        Lbd:
            goto L173
        Lc1:
            r8 = 0
            goto L4c
        Lc6:
            return
        Lc7:
            goto L260
        Lcb:
            r8 = r4[r10]
            goto L12f
        Ld1:
            goto L93
        Ld2:
            goto L155
        Ld6:
            byte[] r6 = r6.tobyteArray()
            goto L18a
        Lde:
            java.lang.object r6 = r1[r7)
            goto La4
        Le6:
            byte[] r15 = new byte[r14]
            goto L184
        Lec:
            int r9 = (int) r11
            goto L65
        Lf1:
            r16 = r9
            goto L25b
        Lf7:
            int r9 = r7 + 1
            goto L179
        Lfd:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p86d70d45 r9 = r6.getSigParameters()
            goto L20f
        L105:
            if (r8 == 0) goto L10a
            goto L365
        L10a:
            goto Lde
        L10e:
            r16 = r3[r9]
            goto L313
        L114:
            r4[r7] = r6
            goto L209
        L11a:
            r11 = r3[r8]
            goto L3df
        L120:
            p5a445d71.p9f931cf3.pca323100.p364bf33a r11 = r11.getDigestOID()
            goto L145
        L128:
            r12.<init>(r8, r14, r11)
            goto L16d
        L12f:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p9064fad6 r6 = r6.getPublicKey()
            goto Ld6
        L137:
            int r9 = r9 - r7
            goto L280
        L13c:
            if (r6 != 0) goto L141
            goto L19a
        L141:
            goto L197
        L145:
            p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 r11 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p69279707.me0825354(r11)
            goto L128
        L14d:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d r6 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p66a8f281.m5ee7eb5d(r6, r8, r9, r13, r15)
            goto L114
        L155:
            int r4 = r1.Count
            goto L2ae
        L15d:
            int r9 = r9 - r7
            goto L192
        L162:
            r7 = r4[r9]
            goto L3c0
        L168:
            r8 = 1
            goto L41
        L16d:
            r7 = r3[r10]
            goto L24b
        L173:
            r11 = r3[r9]
            goto L162
        L179:
            r7 = 1
            goto L79
        L17e:
            r7 = r4[r16]
            goto L8a
        L184:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe1a02e85 r12 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe1a02e85
            goto L3f9
        L18a:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f r6 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p66a8f281.m828114c8(r8, r6)
            goto L3ba
        L192:
            long r9 = (long) r9
            goto L19e
        L197:
            r0.updateHierarchy(r4, r5)
        L19a:
            goto Lc6
        L19e:
            r11 = r3[r8]
            goto L3e4
        L1a4:
            r11 = r4[r10]
            goto L295
        L1aa:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d r8 = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d) r8
            goto L1be
        L1b0:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d r6 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p66a8f281.m5ee7eb5d(r9, r10, r11, r12, r6)
            goto L308
        L1b8:
            r0 = r18
            goto L18
        L1be:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.paa63fca2 r8 = r8.getOtsParameters()
            goto L2a2
        L1c6:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d r8 = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d) r8
            goto L300
        L1cc:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d r8 = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d) r8
            goto L285
        L1d2:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d r6 = r0.getRootKey()
            goto L1f3
        L1da:
            r6 = r7
            goto L3f4
        L1df:
            int r6 = r6 + (-1)
            goto Ld1
        L1e5:
            if (r6 >= 0) goto L1ea
            goto Ld2
        L1ea:
            goto L22d
        L1ee:
            long r9 = r9 & r4
            goto L3ac
        L1f3:
            r8 = 0
            goto L7e
        L1f8:
            int r7 = r7 - r11
            goto L3ea
        L1fd:
            java.util.List<p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f> r5 = r0.f3311842a
            goto L278
        L203:
            byte[] r13 = new byte[r12]
            goto L3b
        L209:
            goto L3bc
        L20b:
            goto L73
        L20f:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.paa63fca2 r10 = r6.getOtsParameters()
            goto L11a
        L217:
            long[] r3 = new long[r2]
            goto L319
        L21d:
            r12.deriveSeed(r15, r11)
            goto L3c8
        L224:
            if (r7 == 0) goto L229
            goto L358
        L229:
            goto Lbc
        L22d:
            java.lang.object r8 = r1[r6)
            goto L1cc
        L235:
            r12.setQ(r7)
            goto L352
        L23c:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f[] r5 = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f[]) r5
            goto L1d2
        L242:
            if (r9 < r2) goto L247
            goto L2fc
        L247:
            goto L2b4
        L24b:
            int r7 = (int) r7
            goto L235
        L250:
            int r9 = (int) r9
            goto L14d
        L255:
            r12 = 16
            goto L36f
        L25b:
            long r8 = (long) r7
            goto L6d
        L260:
            goto L29e
        L263:
            goto L59
        L267:
            java.lang.object r8 = r1[r7)
            goto L1aa
        L26f:
            if (r9 < r7) goto L274
            goto Lbd
        L274:
            goto L10e
        L278:
            int r6 = r5.Count
            goto L39e
        L280:
            long r9 = (long) r9
            goto L1ee
        L285:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p86d70d45 r8 = r8.getSigParameters()
            goto L2ca
        L28d:
            int r2 = r1.Count
            goto L217
        L295:
            r12 = 16
            goto L203
        L29b:
            goto Lc7
        L29e:
            goto L1b8
        L2a2:
            r11 = r3[r7]
            goto Lec
        L2a8:
            r4[r7] = r6
            goto Lcb
        L2ae:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d[] r4 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d[r4]
            goto L344
        L2b4:
            int r10 = r9 + (-1)
            goto L1a4
        L2ba:
            byte[] r12 = r6.getI()
            goto L97
        L2c2:
            int r7 = r7.getIndex()
            goto L1f8
        L2ca:
            int r9 = r8.getH()
            goto Laa
        L2d2:
            if (r0 <= 0) goto L2d7
            goto L29e
        L2d7:
            goto L29b
        L2db:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.paa63fca2 r11 = r11.getOtsParameters()
            goto L120
        L2e3:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p86d70d45 r6 = r6.getSigParameters()
            goto L321
        L2eb:
            r1 = 19
            goto L2e
        L2f2:
            int r6 = r1.Count
            goto L30e
        L2fa:
            goto La0
        L2fc:
            goto L13c
        L300:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.paa63fca2 r8 = r8.getOtsParameters()
            goto L34c
        L308:
            r4[r8] = r6
            goto L1da
        L30e:
            r7 = 1
            goto L92
        L313:
            r7 = r4[r9]
            goto L2c2
        L319:
            long r4 = r0.getIndex()
            goto L2f2
        L321:
            java.lang.object r8 = r1[r7)
            goto L1c6
        L329:
            byte[] r7 = new byte[r7]
            goto Lc1
        L32f:
            if (r7 != 0) goto L334
            goto L20b
        L334:
            goto L17e
        L338:
            goto L263
        L33b:
            goto L397
        L33f:
            long r4 = r4 >>> r8
            goto L1df
        L344:
            java.lang.object[] r4 = r1.toArray(r4)
            goto L4
        L34c:
            r9 = r3[r7]
            goto L250
        L352:
            r7 = -2
            goto L34
        L357:
            r8 = 0
        L358:
            goto L369
        L35c:
            byte[] r14 = r11.getMasterSecret()
            goto L2db
        L364:
            r6 = 1
        L365:
            goto Lf7
        L369:
            r7 = r4[r16]
            goto L376
        L36f:
            java.lang.System.arraycopy(r7, r8, r13, r8, r12)
            goto L20
        L376:
            byte[] r7 = r7.getI()
            goto L3a4
        L37e:
            if (r7 != 0) goto L383
            goto L20b
        L383:
            goto Lb0
        L387:
            int r8 = r8.getH()
            goto L33f
        L38f:
            int r9 = r9.getIndex()
            goto L15d
        L397:
            r0 = 15
            goto L2eb
        L39e:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f[] r6 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f[r6]
            goto La
        L3a4:
            bool r7 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(r13, r7)
            goto L32f
        L3ac:
            r3[r6] = r9
            goto L387
        L3b2:
            bool r7 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(r15, r7)
            goto L37e
        L3ba:
            r5[r10] = r6
        L3bc:
            goto L364
        L3c0:
            int r7 = r7.getIndex()
            goto Lf1
        L3c8:
            r7 = 32
            goto L329
        L3ce:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p86d70d45 r6 = r6.getSigParameters()
            goto L267
        L3d6:
            if (r9 != 0) goto L3db
            goto L3f5
        L3db:
            goto Lfd
        L3df:
            int r11 = (int) r11
            goto L2ba
        L3e4:
            int r9 = (r9 > r11 ? 1 : (r9 == r11 ? 0 : -1))
            goto L3d6
        L3ea:
            long r11 = (long) r7
            goto L53
        L3ef:
            r6 = r8
        L3f0:
            goto L9f
        L3f4:
            goto L3f0
        L3f5:
            goto L3ef
        L3f9:
            byte[] r8 = r11.getI()
            goto L35c
    }

    protected void UpdateHierarchy(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d[] r1, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f[] r2) {
            r0 = this;
            goto L4
        L4:
            goto L2c
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            monitor-enter(r0)
            java.util.List r1 = java.util.Arrays.asList(r1)     // Catch: java.lang.Exception -> L25
            java.util.List r1 = java.util.ICollections.unmodifiableList(r1)     // Catch: java.lang.Exception -> L25
            r0.f14f802e1 = r1     // Catch: java.lang.Exception -> L25
            java.util.List r1 = java.util.Arrays.asList(r2)     // Catch: java.lang.Exception -> L25
            java.util.List r1 = java.util.ICollections.unmodifiableList(r1)     // Catch: java.lang.Exception -> L25
            r0.f3311842a = r1     // Catch: java.lang.Exception -> L25
            monitor-exit(r0)     // Catch: java.lang.Exception -> L25
            return
        L25:
            r1 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L25
            goto L2b
        L2b:
            throw r1
        L2c:
            goto Lb
    }
}

