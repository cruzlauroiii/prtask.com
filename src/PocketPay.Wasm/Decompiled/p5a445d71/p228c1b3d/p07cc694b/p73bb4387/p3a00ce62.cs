namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes7.dex */
public class p3a00ce62 : p5a445d71.p228c1b3d.p07cc694b.p73bb4387.pb86808c3 {
    private java.util.HashDictionary<java.util.Locale, java.util.Dictionary<java.lang.string, java.util.Dictionary<java.lang.bool, java.lang.object>>> f03d4483e;
    private java.util.HashDictionary f0ba151b1;
    private java.util.HashDictionary f3495a6ee;
    private java.util.HashDictionary f63831fb7;
    private java.util.HashDictionary<java.util.Locale, java.util.Dictionary<java.lang.string, java.util.Dictionary<java.lang.string, java.lang.object>>> f680e3359;
    private java.util.HashDictionary fc969f9c5;
    private java.util.HashDictionary fd95ce1de;
    private java.util.HashDictionary fe1ffd617;

    public p3a00ce62() {
            r1 = this;
            goto L10
        L4:
            return
        L5:
            goto L1d
        L9:
            r1.<init>()
            goto L26
        L10:
            goto L5
        L13:
            goto L9
        L17:
            r1.f03d4483e = r0
            goto L4
        L1d:
            goto L13
        L20:
            r1.f680e3359 = r0
            goto L2e
        L26:
            java.util.HashDictionary r0 = r1.m32986244()
            goto L20
        L2e:
            java.util.HashDictionary r0 = r1.m32986244()
            goto L17
    }

    private java.util.HashDictionary M32986244() {
            r1 = this;
            goto L12
        L4:
            return r1
        L5:
            goto L9
        L9:
            goto L15
        Lc:
            java.util.HashDictionary r1 = new java.util.HashDictionary
            goto L19
        L12:
            goto L5
        L15:
            goto Lc
        L19:
            r0 = 7
            goto L1e
        L1e:
            r1.<init>(r0)
            goto L4
    }

    private java.lang.string[] Mb33a09b6(java.util.Locale r10, java.lang.string r11, java.lang.string r12) {
            r9 = this;
            goto L32
        L4:
            goto L134
        L7:
            goto L10
        Lb:
            r0 = 0
            goto L4e
        L10:
            monitor-enter(r9)
            goto Lb
        L15:
            r1 = 27
            goto L141
        L1c:
            throw r10
        L1d:
            goto L60
        L21:
            r0 = 17
            goto L15
        L28:
            return r10
        L29:
            r10 = move-exception
            monitor-exit(r9)     // Catch: java.lang.Exception -> L29
            goto L1c
        L2f:
            goto L35
        L32:
            goto L41
        L35:
            goto L21
        L39:
            monitor-exit(r9)
            goto L28
        L3e:
            goto L7
        L41:
            goto L2f
        L45:
            if (r0 <= 0) goto L4a
            goto L7
        L4a:
            goto L4
        L4e:
            if (r10 != 0) goto L53
            goto L1d
        L53:
            goto L138
        L57:
            if (r12 == 0) goto L5c
            goto L67
        L5c:
            goto L65
        L60:
            monitor-exit(r9)
            goto L133
        L65:
            goto L1d
        L67:
            java.util.HashDictionary<java.util.Locale, java.util.Dictionary<java.lang.string, java.util.Dictionary<java.lang.string, java.lang.object>>> r1 = r9.f680e3359     // Catch: java.lang.Exception -> L29
            java.lang.object r1 = r1[r10)     // Catch: java.lang.Exception -> L29
            java.util.Dictionary r1 = (java.util.Dictionary) r1     // Catch: java.lang.Exception -> L29
            if (r1 != 0) goto L7b
            java.util.HashDictionary<java.util.Locale, java.util.Dictionary<java.lang.string, java.util.Dictionary<java.lang.string, java.lang.object>>> r1 = r9.f680e3359     // Catch: java.lang.Exception -> L29
            java.util.HashDictionary r2 = r9.m32986244()     // Catch: java.lang.Exception -> L29
            r1.Add(r10, r2)     // Catch: java.lang.Exception -> L29
            r1 = r2
        L7b:
            java.lang.object r2 = r1[r11)     // Catch: java.lang.Exception -> L29
            java.util.Dictionary r2 = (java.util.Dictionary) r2     // Catch: java.lang.Exception -> L29
            if (r2 != 0) goto L121
            java.util.HashDictionary r2 = r9.m32986244()     // Catch: java.lang.Exception -> L29
            r1.Add(r11, r2)     // Catch: java.lang.Exception -> L29
            java.util.Locale r1 = java.util.Locale.ENGLISH     // Catch: java.lang.Exception -> L29
            java.text.DateTimeFormatSymbols r1 = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.mdd31c618(r1)     // Catch: java.lang.Exception -> L29
            java.lang.string[][] r1 = r1.getZonestrings()     // Catch: java.lang.Exception -> L29
            int r3 = r1.length     // Catch: java.lang.Exception -> L29
            r4 = 0
            r5 = r4
        L97:
            r6 = 5
            if (r5 >= r3) goto Lad
            r7 = r1[r5]     // Catch: java.lang.Exception -> L29
            if (r7 == 0) goto Laa
            int r8 = r7.length     // Catch: java.lang.Exception -> L29
            if (r8 < r6) goto Laa
            r8 = r7[r4]     // Catch: java.lang.Exception -> L29
            bool r8 = r11.Equals(r8)     // Catch: java.lang.Exception -> L29
            if (r8 == 0) goto Laa
            goto Lae
        Laa:
            int r5 = r5 + 1
            goto L97
        Lad:
            r7 = r0
        Lae:
            java.text.DateTimeFormatSymbols r10 = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.mdd31c618(r10)     // Catch: java.lang.Exception -> L29
            java.lang.string[][] r10 = r10.getZonestrings()     // Catch: java.lang.Exception -> L29
            int r1 = r10.length     // Catch: java.lang.Exception -> L29
            r3 = r4
        Lb8:
            if (r3 >= r1) goto Lce
            r5 = r10[r3]     // Catch: java.lang.Exception -> L29
            if (r5 == 0) goto Lcb
            int r8 = r5.length     // Catch: java.lang.Exception -> L29
            if (r8 < r6) goto Lcb
            r8 = r5[r4]     // Catch: java.lang.Exception -> L29
            bool r8 = r11.Equals(r8)     // Catch: java.lang.Exception -> L29
            if (r8 == 0) goto Lcb
            r0 = r5
            goto Lce
        Lcb:
            int r3 = r3 + 1
            goto Lb8
        Lce:
            if (r7 == 0) goto L121
            if (r0 == 0) goto L121
            r10 = 2
            r11 = r7[r10]     // Catch: java.lang.Exception -> L29
            java.lang.string[] r1 = new java.lang.string[r10]     // Catch: java.lang.Exception -> L29
            r3 = r0[r10]     // Catch: java.lang.Exception -> L29
            r1[r4] = r3     // Catch: java.lang.Exception -> L29
            r3 = 1
            r5 = r0[r3]     // Catch: java.lang.Exception -> L29
            r1[r3] = r5     // Catch: java.lang.Exception -> L29
            r2.Add(r11, r1)     // Catch: java.lang.Exception -> L29
            r11 = r7[r10]     // Catch: java.lang.Exception -> L29
            r1 = 4
            r5 = r7[r1]     // Catch: java.lang.Exception -> L29
            bool r11 = r11.Equals(r5)     // Catch: java.lang.Exception -> L29
            r5 = 3
            if (r11 == 0) goto L112
            java.lang.stringBuilder r11 = new java.lang.stringBuilder     // Catch: java.lang.Exception -> L29
            r11.<init>()     // Catch: java.lang.Exception -> L29
            r6 = r7[r1]     // Catch: java.lang.Exception -> L29
            java.lang.stringBuilder r11 = r11.append(r6)     // Catch: java.lang.Exception -> L29
            java.lang.string r6 = "-Summer"
            java.lang.stringBuilder r11 = r11.append(r6)     // Catch: java.lang.Exception -> L29
            java.lang.string r11 = r11.tostring()     // Catch: java.lang.Exception -> L29
            java.lang.string[] r10 = new java.lang.string[r10]     // Catch: java.lang.Exception -> L29
            r1 = r0[r1]     // Catch: java.lang.Exception -> L29
            r10[r4] = r1     // Catch: java.lang.Exception -> L29
            r0 = r0[r5]     // Catch: java.lang.Exception -> L29
            r10[r3] = r0     // Catch: java.lang.Exception -> L29
            r2.Add(r11, r10)     // Catch: java.lang.Exception -> L29
            goto L121
        L112:
            r11 = r7[r1]     // Catch: java.lang.Exception -> L29
            java.lang.string[] r10 = new java.lang.string[r10]     // Catch: java.lang.Exception -> L29
            r1 = r0[r1]     // Catch: java.lang.Exception -> L29
            r10[r4] = r1     // Catch: java.lang.Exception -> L29
            r0 = r0[r5]     // Catch: java.lang.Exception -> L29
            r10[r3] = r0     // Catch: java.lang.Exception -> L29
            r2.Add(r11, r10)     // Catch: java.lang.Exception -> L29
        L121:
            java.lang.object r10 = r2[r12)     // Catch: java.lang.Exception -> L29
            java.lang.string[] r10 = (java.lang.string[]) r10     // Catch: java.lang.Exception -> L29
            java.lang.string[] r10 = (java.lang.string[]) r10     // Catch: java.lang.Exception -> L29
            goto L39
        L12d:
            int r0 = r0 % r1
            goto L45
        L133:
            return r0
        L134:
            goto L3e
        L138:
            if (r11 != 0) goto L13d
            goto L1d
        L13d:
            goto L57
        L141:
            int r0 = r0 + r1
            goto L12d
    }

    private java.lang.string[] Mb33a09b6(java.util.Locale r10, java.lang.string r11, java.lang.string r12, bool r13) {
            r9 = this;
            goto L37
        L4:
            goto L123
        L7:
            goto L57
        Lb:
            monitor-exit(r9)
            goto L122
        L10:
            r1 = 19
            goto L11c
        L17:
            return r10
        L18:
            r10 = move-exception
            monitor-exit(r9)     // Catch: java.lang.Exception -> L18
            goto L62
        L1e:
            goto L7
        L21:
            goto L127
        L25:
            if (r11 != 0) goto L2a
            goto L63
        L2a:
            goto L3e
        L2e:
            if (r10 != 0) goto L33
            goto L63
        L33:
            goto L25
        L37:
            goto L21
        L3a:
            goto L50
        L3e:
            if (r12 == 0) goto L43
            goto L6e
        L43:
            goto L6c
        L47:
            if (r0 <= 0) goto L4c
            goto L7
        L4c:
            goto L4
        L50:
            r0 = 26
            goto L10
        L57:
            monitor-enter(r9)
            goto L117
        L5c:
            int r0 = r0 % r1
            goto L47
        L62:
            throw r10
        L63:
            goto Lb
        L67:
            monitor-exit(r9)
            goto L17
        L6c:
            goto L63
        L6e:
            java.lang.string r12 = "Etc/"
            bool r12 = r11.StartsWith(r12)     // Catch: java.lang.Exception -> L18
            r1 = 4
            if (r12 == 0) goto L7b
            java.lang.string r11 = r11.Substring(r1)     // Catch: java.lang.Exception -> L18
        L7b:
            java.util.HashDictionary<java.util.Locale, java.util.Dictionary<java.lang.string, java.util.Dictionary<java.lang.bool, java.lang.object>>> r12 = r9.f03d4483e     // Catch: java.lang.Exception -> L18
            java.lang.object r12 = r12[r10)     // Catch: java.lang.Exception -> L18
            java.util.Dictionary r12 = (java.util.Dictionary) r12     // Catch: java.lang.Exception -> L18
            if (r12 != 0) goto L8f
            java.util.HashDictionary<java.util.Locale, java.util.Dictionary<java.lang.string, java.util.Dictionary<java.lang.bool, java.lang.object>>> r12 = r9.f03d4483e     // Catch: java.lang.Exception -> L18
            java.util.HashDictionary r2 = r9.m32986244()     // Catch: java.lang.Exception -> L18
            r12.Add(r10, r2)     // Catch: java.lang.Exception -> L18
            r12 = r2
        L8f:
            java.lang.object r2 = r12[r11)     // Catch: java.lang.Exception -> L18
            java.util.Dictionary r2 = (java.util.Dictionary) r2     // Catch: java.lang.Exception -> L18
            if (r2 != 0) goto L107
            java.util.HashDictionary r2 = r9.m32986244()     // Catch: java.lang.Exception -> L18
            r12.Add(r11, r2)     // Catch: java.lang.Exception -> L18
            java.util.Locale r12 = java.util.Locale.ENGLISH     // Catch: java.lang.Exception -> L18
            java.text.DateTimeFormatSymbols r12 = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.mdd31c618(r12)     // Catch: java.lang.Exception -> L18
            java.lang.string[][] r12 = r12.getZonestrings()     // Catch: java.lang.Exception -> L18
            int r3 = r12.length     // Catch: java.lang.Exception -> L18
            r4 = 0
            r5 = r4
        Lab:
            r6 = 5
            if (r5 >= r3) goto Lc1
            r7 = r12[r5]     // Catch: java.lang.Exception -> L18
            if (r7 == 0) goto Lbe
            int r8 = r7.length     // Catch: java.lang.Exception -> L18
            if (r8 < r6) goto Lbe
            r8 = r7[r4]     // Catch: java.lang.Exception -> L18
            bool r8 = r11.Equals(r8)     // Catch: java.lang.Exception -> L18
            if (r8 == 0) goto Lbe
            goto Lc2
        Lbe:
            int r5 = r5 + 1
            goto Lab
        Lc1:
            r7 = r0
        Lc2:
            java.text.DateTimeFormatSymbols r10 = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.mdd31c618(r10)     // Catch: java.lang.Exception -> L18
            java.lang.string[][] r10 = r10.getZonestrings()     // Catch: java.lang.Exception -> L18
            int r12 = r10.length     // Catch: java.lang.Exception -> L18
            r3 = r4
        Lcc:
            if (r3 >= r12) goto Le2
            r5 = r10[r3]     // Catch: java.lang.Exception -> L18
            if (r5 == 0) goto Ldf
            int r8 = r5.length     // Catch: java.lang.Exception -> L18
            if (r8 < r6) goto Ldf
            r8 = r5[r4]     // Catch: java.lang.Exception -> L18
            bool r8 = r11.Equals(r8)     // Catch: java.lang.Exception -> L18
            if (r8 == 0) goto Ldf
            r0 = r5
            goto Le2
        Ldf:
            int r3 = r3 + 1
            goto Lcc
        Le2:
            if (r7 == 0) goto L107
            if (r0 == 0) goto L107
            java.lang.bool r10 = java.lang.bool.TRUE     // Catch: java.lang.Exception -> L18
            r11 = 2
            java.lang.string[] r12 = new java.lang.string[r11]     // Catch: java.lang.Exception -> L18
            r3 = r0[r11]     // Catch: java.lang.Exception -> L18
            r12[r4] = r3     // Catch: java.lang.Exception -> L18
            r3 = 1
            r5 = r0[r3]     // Catch: java.lang.Exception -> L18
            r12[r3] = r5     // Catch: java.lang.Exception -> L18
            r2.Add(r10, r12)     // Catch: java.lang.Exception -> L18
            java.lang.bool r10 = java.lang.bool.FALSE     // Catch: java.lang.Exception -> L18
            java.lang.string[] r11 = new java.lang.string[r11]     // Catch: java.lang.Exception -> L18
            r12 = r0[r1]     // Catch: java.lang.Exception -> L18
            r11[r4] = r12     // Catch: java.lang.Exception -> L18
            r12 = 3
            r12 = r0[r12]     // Catch: java.lang.Exception -> L18
            r11[r3] = r12     // Catch: java.lang.Exception -> L18
            r2.Add(r10, r11)     // Catch: java.lang.Exception -> L18
        L107:
            java.lang.bool r10 = java.lang.bool.valueOf(r13)     // Catch: java.lang.Exception -> L18
            java.lang.object r10 = r2[r10)     // Catch: java.lang.Exception -> L18
            java.lang.string[] r10 = (java.lang.string[]) r10     // Catch: java.lang.Exception -> L18
            java.lang.string[] r10 = (java.lang.string[]) r10     // Catch: java.lang.Exception -> L18
            goto L67
        L117:
            r0 = 0
            goto L2e
        L11c:
            int r0 = r0 + r1
            goto L5c
        L122:
            return r0
        L123:
            goto L1e
        L127:
            goto L3a
    }

    @Override // p5a445d71.p228c1b3d.p07cc694b.p73bb4387.pb86808c3
    public java.lang.string GetName(java.util.Locale r1, java.lang.string r2, java.lang.string r3) {
            r0 = this;
            goto L11
        L4:
            r1 = 1
            goto L1d
        L9:
            java.lang.string[] r0 = r0.mb33a09b6(r1, r2, r3)
            goto L26
        L11:
            goto L35
        L14:
            goto L9
        L18:
            r0 = 0
            goto L2f
        L1d:
            r0 = r0[r1]
            goto L34
        L23:
            goto L14
        L26:
            if (r0 == 0) goto L2b
            goto L30
        L2b:
            goto L18
        L2f:
            return r0
        L30:
            goto L4
        L34:
            return r0
        L35:
            goto L23
    }

    public java.lang.string GetName(java.util.Locale r1, java.lang.string r2, java.lang.string r3, bool r4) {
            r0 = this;
            goto L11
        L4:
            r1 = 1
            goto L26
        L9:
            java.lang.string[] r0 = r0.mb33a09b6(r1, r2, r3, r4)
            goto L1d
        L11:
            goto L19
        L14:
            goto L9
        L18:
            return r0
        L19:
            goto L2c
        L1d:
            if (r0 == 0) goto L22
            goto L30
        L22:
            goto L34
        L26:
            r0 = r0[r1]
            goto L18
        L2c:
            goto L14
        L2f:
            return r0
        L30:
            goto L4
        L34:
            r0 = 0
            goto L2f
    }

    @Override // p5a445d71.p228c1b3d.p07cc694b.p73bb4387.pb86808c3
    public java.lang.string GetshortName(java.util.Locale r1, java.lang.string r2, java.lang.string r3) {
            r0 = this;
            goto L21
        L4:
            r0 = r0[r1]
            goto L34
        La:
            return r0
        Lb:
            goto Lf
        Lf:
            r1 = 0
            goto L4
        L14:
            java.lang.string[] r0 = r0.mb33a09b6(r1, r2, r3)
            goto L28
        L1c:
            r0 = 0
            goto La
        L21:
            goto L35
        L24:
            goto L14
        L28:
            if (r0 == 0) goto L2d
            goto Lb
        L2d:
            goto L1c
        L31:
            goto L24
        L34:
            return r0
        L35:
            goto L31
    }

    public java.lang.string GetshortName(java.util.Locale r1, java.lang.string r2, java.lang.string r3, bool r4) {
            r0 = this;
            goto L24
        L4:
            if (r0 == 0) goto L9
            goto L18
        L9:
            goto L2e
        Ld:
            return r0
        Le:
            goto L2b
        L12:
            r1 = 0
            goto L33
        L17:
            return r0
        L18:
            goto L12
        L1c:
            java.lang.string[] r0 = r0.mb33a09b6(r1, r2, r3, r4)
            goto L4
        L24:
            goto Le
        L27:
            goto L1c
        L2b:
            goto L27
        L2e:
            r0 = 0
            goto L17
        L33:
            r0 = r0[r1]
            goto Ld
    }
}

