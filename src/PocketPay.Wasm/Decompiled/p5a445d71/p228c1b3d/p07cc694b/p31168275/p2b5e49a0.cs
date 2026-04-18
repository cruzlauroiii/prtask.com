namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes7.dex */
class p2b5e49a0 {
    private p5a445d71.p228c1b3d.p07cc694b.p31168275.p2b5e49a0.pb948e8a0[] f05d035d7;
    private p5a445d71.p228c1b3d.p07cc694b.p31168275.p2b5e49a0.pb948e8a0[] f0d1d4b6d;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p31168275.p60ad5b1d[] f46b7e0f5;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p31168275.p60ad5b1d[] f4ebcf11d;
    private p5a445d71.p228c1b3d.p07cc694b.p31168275.p2b5e49a0.pb948e8a0[] f76bdf0aa;
    private p5a445d71.p228c1b3d.p07cc694b.p31168275.p2b5e49a0.pb948e8a0[] f8489be34;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p31168275.p60ad5b1d[] f9697a4d4;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p31168275.p60ad5b1d[] fdc5793c0;

    static class pb948e8a0 {
        readonly p5a445d71.p228c1b3d.p07cc694b.p31168275.p60ad5b1d f2dcf454a;
        readonly p5a445d71.p228c1b3d.p07cc694b.p31168275.p60ad5b1d f3cec1d2d;
        readonly java.lang.Class f60e8fe64;
        readonly java.lang.Class fbac99aeb;
        readonly java.lang.Class<object> fe00ef68a;
        readonly p5a445d71.p228c1b3d.p07cc694b.p31168275.p60ad5b1d fe42d32f1;
        readonly p5a445d71.p228c1b3d.p07cc694b.p31168275.p60ad5b1d ff7379e20;

        pb948e8a0(java.lang.Class<object> r1, p5a445d71.p228c1b3d.p07cc694b.p31168275.p60ad5b1d r2) {
                r0 = this;
                goto L1f
            L4:
                goto L22
            L7:
                return
            L8:
                goto L4
            Lc:
                r0.<init>()
                goto L19
            L13:
                r0.ff7379e20 = r2
                goto L7
            L19:
                r0.fe00ef68a = r1
                goto L13
            L1f:
                goto L8
            L22:
                goto Lc
        }
    }

    p2b5e49a0(p5a445d71.p228c1b3d.p07cc694b.p31168275.p60ad5b1d[] r1) {
            r0 = this;
            goto L14
        L4:
            r0.<init>()
            goto L2c
        Lb:
            p5a445d71.p228c1b3d.p07cc694b.p31168275.p2b5e49a0$pb948e8a0[] r1 = new p5a445d71.p228c1b3d.p07cc694b.p31168275.p2b5e49a0.pb948e8a0[r1]
            goto L1b
        L11:
            goto L17
        L14:
            goto L28
        L17:
            goto L4
        L1b:
            r0.f8489be34 = r1
            goto L27
        L21:
            r1 = 16
            goto Lb
        L27:
            return
        L28:
            goto L11
        L2c:
            r0.f9697a4d4 = r1
            goto L21
    }

    private static p5a445d71.p228c1b3d.p07cc694b.p31168275.p60ad5b1d M221dcd7d(p5a445d71.p228c1b3d.p07cc694b.p31168275.p2b5e49a0 r9, java.lang.Class<object> r10) {
            goto L118
        L4:
            if (r10 != 0) goto L9
            goto Lbd
        L9:
            goto L1f8
        Ld:
            p5a445d71.p228c1b3d.p07cc694b.p31168275.p60ad5b1d[] r0 = r9.f9697a4d4
            goto L104
        L13:
            r0 = 17
            goto L19e
        L1a:
            r10 = r3
            goto L5e
        L1f:
            java.lang.string r10 = "\" from remaining set: "
            goto L160
        L25:
            r9.<init>(r2)
            goto L1ab
        L2c:
            r5 = r2
        L2d:
            goto L1e1
        L31:
            java.lang.Class r5 = r4.getSupportedType()
            goto L217
        L39:
            int r2 = r7 + (-1)
            goto L3f
        L3f:
            goto Lee
        L41:
            goto L1b9
        L45:
            p5a445d71.p228c1b3d.p07cc694b.p31168275.p2b5e49a0 r9 = r9.Remove(r5, r3)
            goto L1d0
        L4d:
            if (r4 == 0) goto L52
            goto Lbd
        L52:
            goto L131
        L56:
            bool r8 = r8.isAssignableFrom(r6)
            goto La4
        L5e:
            goto L1f4
        L60:
            goto L1f0
        L64:
            if (r10 != 0) goto L69
            goto L1cc
        L69:
            goto Lcf
        L6d:
            java.lang.string r9 = r9.tostring()
            goto L12a
        L75:
            int r7 = r0.length
            goto L39
        L7a:
            if (r2 >= 0) goto L7f
            goto L1a7
        L7f:
            goto L1be
        L83:
            java.lang.string r10 = r10.getName()
            goto L17b
        L8b:
            r9.append(r10)
            goto L1f
        L92:
            if (r5 == r4) goto L97
            goto Lc5
        L97:
            goto Lc9
        L9b:
            if (r0 <= 0) goto La0
            goto L195
        La0:
            goto L192
        La4:
            if (r8 != 0) goto La9
            goto Lee
        La9:
            goto L45
        Lad:
            if (r1 < r5) goto Lb2
            goto Lfa
        Lb2:
            goto L16d
        Lb6:
            r10 = 91
            goto L1c4
        Lbc:
            r2 = r1
        Lbd:
            goto L18c
        Lc1:
            goto L11b
        Lc4:
            return r9
        Lc5:
            goto L220
        Lc9:
            r9 = r0[r1]
            goto Lc4
        Lcf:
            if (r2 == 0) goto Ld4
            goto Lda
        Ld4:
            goto Ld8
        Ld8:
            goto L1cc
        Lda:
            goto L13f
        Lde:
            java.lang.Class r8 = r8.getSupportedType()
            goto L56
        Le6:
            r9.append(r10)
            goto L24a
        Led:
            r7 = r5
        Lee:
            goto L167
        Lf2:
            r9.append(r10)
            goto L144
        Lf9:
            goto L163
        Lfa:
            goto L1d6
        Lfe:
            int r0 = r0 % r1
            goto L9b
        L104:
            int r2 = r0.length
            goto L11f
        L109:
            r8 = r0[r5]
            goto Lde
        L10f:
            if (r1 >= 0) goto L114
            goto L120
        L114:
            goto L211
        L118:
            goto L156
        L11b:
            goto L13
        L11f:
            goto Lbd
        L120:
            goto L64
        L124:
            int r0 = r0 + r1
            goto Lfe
        L12a:
            r10.<init>(r9)
            goto L1cb
        L131:
            p5a445d71.p228c1b3d.p07cc694b.p31168275.p2b5e49a0 r9 = r9.Remove(r1, r3)
            goto Ld
        L139:
            p5a445d71.p228c1b3d.p07cc694b.p31168275.p60ad5b1d[] r0 = r9.f9697a4d4
            goto L23d
        L13f:
            r1 = 0
            goto L187
        L144:
            int r1 = r1 + 1
            goto Lf9
        L14a:
            if (r5 != r2) goto L14f
            goto Lee
        L14f:
            goto L109
        L153:
            goto L195
        L156:
            goto Lc1
        L15a:
            r9 = r0[r1]
            goto L22f
        L160:
            r9.append(r10)
        L163:
            goto Lad
        L167:
            int r5 = r5 + (-1)
            goto L1e7
        L16d:
            r10 = r0[r1]
            goto L173
        L173:
            java.lang.Class r2 = r10.getSupportedType()
            goto L242
        L17b:
            r9.append(r10)
            goto Lb6
        L182:
            return r3
        L183:
            goto L153
        L187:
            r4 = 1
            goto L226
        L18c:
            int r1 = r1 + (-1)
            goto L199
        L192:
            goto L183
        L195:
            goto L139
        L199:
            r3 = 0
            goto L10f
        L19e:
            r1 = 16
            goto L124
        L1a5:
            goto L2d
        L1a7:
            goto L92
        L1ab:
            java.lang.string r10 = r10.getName()
            goto L8b
        L1b3:
            java.lang.string r2 = "Unable to find best converter for type \""
            goto L25
        L1b9:
            r5 = r7
            goto L1a5
        L1be:
            r6 = r0[r2]
            goto L209
        L1c4:
            r9.append(r10)
            goto L234
        L1cb:
            throw r10
        L1cc:
            goto L182
        L1d0:
            p5a445d71.p228c1b3d.p07cc694b.p31168275.p60ad5b1d[] r0 = r9.f9697a4d4
            goto L75
        L1d6:
            java.lang.IllegalStateException r10 = new java.lang.IllegalStateException
            goto L6d
        L1dc:
            return r4
        L1dd:
            goto L200
        L1e1:
            int r2 = r2 + (-1)
            goto L7a
        L1e7:
            if (r5 >= 0) goto L1ec
            goto L41
        L1ec:
            goto L14a
        L1f0:
            java.lang.string r10 = r2.getName()
        L1f4:
            goto Le6
        L1f8:
            bool r4 = r5.isAssignableFrom(r10)
            goto L4d
        L200:
            if (r5 != 0) goto L205
            goto L52
        L205:
            goto L4
        L209:
            java.lang.Class r6 = r6.getSupportedType()
            goto Led
        L211:
            r4 = r0[r1]
            goto L31
        L217:
            if (r5 == r10) goto L21c
            goto L1dd
        L21c:
            goto L1dc
        L220:
            java.lang.stringBuilder r9 = new java.lang.stringBuilder
            goto L1b3
        L226:
            if (r2 == r4) goto L22b
            goto L230
        L22b:
            goto L15a
        L22f:
            return r9
        L230:
            goto L2c
        L234:
            if (r2 == 0) goto L239
            goto L60
        L239:
            goto L1a
        L23d:
            int r1 = r0.length
            goto Lbc
        L242:
            java.lang.Class r10 = r10.GetType()
            goto L83
        L24a:
            java.lang.string r10 = "], "
            goto Lf2
    }

    p5a445d71.p228c1b3d.p07cc694b.p31168275.p2b5e49a0 add(p5a445d71.p228c1b3d.p07cc694b.p31168275.p60ad5b1d r8, p5a445d71.p228c1b3d.p07cc694b.p31168275.p60ad5b1d[] r9) {
            r7 = this;
            goto L57
        L4:
            java.lang.Class r4 = r8.getSupportedType()
            goto Lf5
        Lc:
            r7[r1] = r8
            goto Ld4
        L12:
            p5a445d71.p228c1b3d.p07cc694b.p31168275.p2b5e49a0 r8 = new p5a445d71.p228c1b3d.p07cc694b.p31168275.p2b5e49a0
            goto L8b
        L18:
            r6 = r0[r4]
            goto L2f
        L1e:
            return r7
        L1f:
            goto L4
        L23:
            goto L5a
        L26:
            if (r9 != 0) goto L2b
            goto Ldf
        L2b:
            goto Ldd
        L2f:
            r7[r4] = r6
            goto Lc2
        L35:
            r8.<init>(r7)
            goto L12e
        L3c:
            if (r4 == r6) goto L41
            goto L46
        L41:
            goto L10e
        L45:
            return r8
        L46:
            goto Lce
        L4a:
            r9[r2] = r4
        L4c:
            goto L1e
        L50:
            r0 = 2
            goto Laf
        L57:
            goto L61
        L5a:
            goto L50
        L5e:
            goto L10a
        L61:
            goto L23
        L65:
            int r0 = r0 % r1
            goto L92
        L6b:
            int r4 = r4 + 1
            goto Laa
        L71:
            if (r4 != r3) goto L76
            goto Lc3
        L76:
            goto L18
        L7a:
            r2 = 0
            goto L102
        L7f:
            r9[r2] = r4
        L81:
            goto Lbc
        L85:
            int r0 = r0 + r1
            goto L65
        L8b:
            r8.<init>(r7)
            goto L45
        L92:
            if (r0 <= 0) goto L97
            goto L10a
        L97:
            goto L107
        L9b:
            if (r9 != 0) goto La0
            goto L4c
        La0:
            goto L4a
        La4:
            p5a445d71.p228c1b3d.p07cc694b.p31168275.p60ad5b1d[] r7 = new p5a445d71.p228c1b3d.p07cc694b.p31168275.p60ad5b1d[r7]
            goto Lc7
        Laa:
            goto L121
        Lab:
            goto L26
        Laf:
            r1 = 19
            goto L85
        Lb6:
            r7[r4] = r8
        Lb8:
            goto L6b
        Lbc:
            p5a445d71.p228c1b3d.p07cc694b.p31168275.p2b5e49a0 r8 = new p5a445d71.p228c1b3d.p07cc694b.p31168275.p2b5e49a0
            goto L35
        Lc2:
            goto Lb8
        Lc3:
            goto Lb6
        Lc7:
            java.lang.System.arraycopy(r0, r2, r7, r2, r1)
            goto Lc
        Lce:
            int r3 = r3 + 1
            goto L133
        Ld4:
            if (r9 != 0) goto Ld9
            goto L81
        Ld9:
            goto L7f
        Ldd:
            r9[r2] = r5
        Ldf:
            goto L12
        Le3:
            if (r3 < r1) goto Le8
            goto L134
        Le8:
            goto L140
        Lec:
            if (r4 < r1) goto Lf1
            goto Lab
        Lf1:
            goto L71
        Lf5:
            java.lang.Class r6 = r5.getSupportedType()
            goto L3c
        Lfd:
            int r1 = r0.length
            goto L7a
        L102:
            r3 = r2
        L103:
            goto L146
        L107:
            goto L12f
        L10a:
            goto L114
        L10e:
            p5a445d71.p228c1b3d.p07cc694b.p31168275.p60ad5b1d[] r7 = new p5a445d71.p228c1b3d.p07cc694b.p31168275.p60ad5b1d[r1]
            goto L120
        L114:
            p5a445d71.p228c1b3d.p07cc694b.p31168275.p60ad5b1d[] r0 = r7.f9697a4d4
            goto Lfd
        L11a:
            int r7 = r1 + 1
            goto La4
        L120:
            r4 = r2
        L121:
            goto Lec
        L125:
            if (r6 != 0) goto L12a
            goto L1f
        L12a:
            goto L9b
        L12e:
            return r8
        L12f:
            goto L5e
        L133:
            goto L103
        L134:
            goto L11a
        L138:
            bool r6 = r8.Equals(r5)
            goto L125
        L140:
            r5 = r0[r3]
            goto L138
        L146:
            r4 = 0
            goto Le3
    }

    void copyInto(p5a445d71.p228c1b3d.p07cc694b.p31168275.p60ad5b1d[] r3) {
            r2 = this;
            goto L48
        L4:
            r1 = 8
            goto L17
        Lb:
            int r1 = r2.length
            goto L10
        L10:
            java.lang.System.arraycopy(r2, r0, r3, r0, r1)
            goto L4f
        L17:
            int r0 = r0 + r1
            goto L42
        L1d:
            r0 = 29
            goto L4
        L24:
            p5a445d71.p228c1b3d.p07cc694b.p31168275.p60ad5b1d[] r2 = r2.f9697a4d4
            goto L34
        L2a:
            goto L4b
        L2d:
            goto L50
        L30:
            goto L24
        L34:
            r0 = 0
            goto Lb
        L39:
            if (r0 <= 0) goto L3e
            goto L30
        L3e:
            goto L2d
        L42:
            int r0 = r0 % r1
            goto L39
        L48:
            goto L57
        L4b:
            goto L1d
        L4f:
            return
        L50:
            goto L54
        L54:
            goto L30
        L57:
            goto L2a
    }

    p5a445d71.p228c1b3d.p07cc694b.p31168275.p2b5e49a0 remove(int r6, p5a445d71.p228c1b3d.p07cc694b.p31168275.p60ad5b1d[] r7) {
            r5 = this;
            goto L98
        L4:
            if (r0 <= 0) goto L9
            goto L3a
        L9:
            goto L37
        Ld:
            int r7 = r0 + (-1)
            goto Lab
        L13:
            goto L9b
        L16:
            r2 = r1
        L17:
            goto L6d
        L1b:
            p5a445d71.p228c1b3d.p07cc694b.p31168275.p60ad5b1d[] r5 = r5.f9697a4d4
            goto L68
        L21:
            r4 = r5[r1]
            goto La5
        L27:
            goto L3a
        L2a:
            goto L13
        L2e:
            if (r1 != r6) goto L33
            goto L5e
        L33:
            goto Ld1
        L37:
            goto L46
        L3a:
            goto L1b
        L3e:
            r5.<init>()
            goto L45
        L45:
            throw r5
        L46:
            goto L27
        L4a:
            r0 = 14
            goto L8c
        L51:
            int r0 = r0 % r1
            goto L4
        L57:
            p5a445d71.p228c1b3d.p07cc694b.p31168275.p2b5e49a0 r5 = new p5a445d71.p228c1b3d.p07cc694b.p31168275.p2b5e49a0
            goto L7c
        L5d:
            r2 = r3
        L5e:
            goto Lb6
        L62:
            int r0 = r0 + r1
            goto L51
        L68:
            int r0 = r5.length
            goto L83
        L6d:
            if (r1 < r0) goto L72
            goto La1
        L72:
            goto L2e
        L76:
            java.lang.IndexOutOfBoundsException r5 = new java.lang.IndexOutOfBoundsException
            goto L3e
        L7c:
            r5.<init>(r7)
            goto L93
        L83:
            if (r6 < r0) goto L88
            goto L94
        L88:
            goto Lb1
        L8c:
            r1 = 13
            goto L62
        L93:
            return r5
        L94:
            goto L76
        L98:
            goto L2a
        L9b:
            goto L4a
        L9f:
            goto L17
        La1:
            goto L57
        La5:
            r7[r2] = r4
            goto L5d
        Lab:
            p5a445d71.p228c1b3d.p07cc694b.p31168275.p60ad5b1d[] r7 = new p5a445d71.p228c1b3d.p07cc694b.p31168275.p60ad5b1d[r7]
            goto L16
        Lb1:
            r1 = 0
            goto Lc8
        Lb6:
            int r1 = r1 + 1
            goto L9f
        Lbc:
            r7[r1] = r2
        Lbe:
            goto Ld
        Lc2:
            r2 = r5[r6]
            goto Lbc
        Lc8:
            if (r7 != 0) goto Lcd
            goto Lbe
        Lcd:
            goto Lc2
        Ld1:
            int r3 = r2 + 1
            goto L21
    }

    p5a445d71.p228c1b3d.p07cc694b.p31168275.p2b5e49a0 remove(p5a445d71.p228c1b3d.p07cc694b.p31168275.p60ad5b1d r6, p5a445d71.p228c1b3d.p07cc694b.p31168275.p60ad5b1d[] r7) {
            r5 = this;
            goto L45
        L4:
            goto L41
        L5:
            goto L59
        L9:
            if (r3 < r1) goto Le
            goto L5
        Le:
            goto L27
        L12:
            p5a445d71.p228c1b3d.p07cc694b.p31168275.p60ad5b1d[] r0 = r5.f9697a4d4
            goto L2d
        L18:
            int r0 = r0 % r1
            goto L1e
        L1e:
            if (r0 <= 0) goto L23
            goto L55
        L23:
            goto L52
        L27:
            r4 = r0[r3]
            goto L6b
        L2d:
            int r1 = r0.length
            goto L78
        L32:
            r6 = 0
            goto L37
        L37:
            r7[r2] = r6
        L39:
            goto L92
        L3d:
            goto L48
        L40:
            r3 = r2
        L41:
            goto L9
        L45:
            goto L9a
        L48:
            goto L85
        L4c:
            int r3 = r3 + 1
            goto L4
        L52:
            goto L93
        L55:
            goto L12
        L59:
            if (r7 != 0) goto L5e
            goto L39
        L5e:
            goto L32
        L62:
            if (r4 != 0) goto L67
            goto L74
        L67:
            goto L7d
        L6b:
            bool r4 = r6.Equals(r4)
            goto L62
        L73:
            return r5
        L74:
            goto L4c
        L78:
            r2 = 0
            goto L40
        L7d:
            p5a445d71.p228c1b3d.p07cc694b.p31168275.p2b5e49a0 r5 = r5.Remove(r3, r7)
            goto L73
        L85:
            r0 = 30
            goto L9e
        L8c:
            int r0 = r0 + r1
            goto L18
        L92:
            return r5
        L93:
            goto L97
        L97:
            goto L55
        L9a:
            goto L3d
        L9e:
            r1 = 15
            goto L8c
    }

    p5a445d71.p228c1b3d.p07cc694b.p31168275.p60ad5b1d select(java.lang.Class<object> r10) throws java.lang.IllegalStateException {
            r9 = this;
            goto Lbc
        L4:
            r0 = 11
            goto Lb
        Lb:
            r1 = 4
            goto Lb0
        L12:
            int r1 = r0.length
            goto L171
        L17:
            p5a445d71.p228c1b3d.p07cc694b.p31168275.p60ad5b1d r4 = m221dcd7d(r9, r10)
            goto Led
        L1f:
            return r9
        L20:
            goto L88
        L24:
            int r5 = r5 + 1
            goto L94
        L2a:
            goto L65
        L2b:
            goto L13c
        L2f:
            java.lang.Class<object> r7 = r6.fe00ef68a
            goto Lc3
        L35:
            if (r5 == r10) goto L3a
            goto L20
        L3a:
            goto Lb6
        L3e:
            r9.f8489be34 = r3
            goto L109
        L44:
            goto L5b
        L47:
            goto L10e
        L4b:
            int r3 = r10.GetHashCode()
            goto L117
        L53:
            r7 = r2
            goto L2a
        L58:
            goto L10a
        L5b:
            goto L16b
        L5f:
            r3 = r3 & r4
        L60:
            goto Le1
        L64:
            r7 = r7 & r8
        L65:
            goto L142
        L69:
            r5.<init>(r10, r4)
            goto L99
        L70:
            java.lang.Class<object> r5 = r4.fe00ef68a
            goto L35
        L76:
            if (r8 != 0) goto L7b
            goto L2b
        L7b:
            goto L111
        L7f:
            if (r5 < r1) goto L84
            goto L95
        L84:
            goto Lf8
        L88:
            int r3 = r3 + 1
            goto L197
        L8e:
            int r0 = r0 % r1
            goto L18e
        L94:
            goto L105
        L95:
            goto L3e
        L99:
            java.lang.object r10 = r0.clone()
            goto Lcc
        La1:
            if (r10 == 0) goto La6
            goto L149
        La6:
            goto L148
        Laa:
            p5a445d71.p228c1b3d.p07cc694b.p31168275.p2b5e49a0$pb948e8a0[] r10 = (p5a445d71.p228c1b3d.p07cc694b.p31168275.p2b5e49a0.pb948e8a0[]) r10
            goto L14d
        Lb0:
            int r0 = r0 + r1
            goto L8e
        Lb6:
            p5a445d71.p228c1b3d.p07cc694b.p31168275.p60ad5b1d r9 = r4.ff7379e20
            goto L1f
        Lbc:
            goto L47
        Lbf:
            goto L4
        Lc3:
            if (r7 == 0) goto Lc8
            goto L177
        Lc8:
            goto L176
        Lcc:
            p5a445d71.p228c1b3d.p07cc694b.p31168275.p2b5e49a0$pb948e8a0[] r10 = (p5a445d71.p228c1b3d.p07cc694b.p31168275.p2b5e49a0.pb948e8a0[]) r10
            goto Laa
        Ld2:
            int r8 = r0 + (-1)
            goto L64
        Ld8:
            if (r4 != 0) goto Ldd
            goto L185
        Ldd:
            goto L70
        Le1:
            r4 = r0[r3]
            goto Ld8
        Le7:
            p5a445d71.p228c1b3d.p07cc694b.p31168275.p2b5e49a0$pb948e8a0[] r3 = new p5a445d71.p228c1b3d.p07cc694b.p31168275.p2b5e49a0.pb948e8a0[r0]
            goto L104
        Led:
            p5a445d71.p228c1b3d.p07cc694b.p31168275.p2b5e49a0$pb948e8a0 r5 = new p5a445d71.p228c1b3d.p07cc694b.p31168275.p2b5e49a0$pb948e8a0
            goto L69
        Lf3:
            return r4
        Lf4:
            goto L126
        Lf8:
            r6 = r10[r5]
            goto L2f
        Lfe:
            r3 = r10[r0]
            goto L11d
        L104:
            r5 = r2
        L105:
            goto L7f
        L109:
            return r4
        L10a:
            goto L44
        L10e:
            goto Lbf
        L111:
            int r7 = r7 + 1
            goto L15c
        L117:
            int r4 = r1 + (-1)
            goto L5f
        L11d:
            if (r3 == 0) goto L122
            goto Lf4
        L122:
            goto L165
        L126:
            int r0 = r0 + 1
            goto L189
        L12c:
            int r0 = r1 << 1
            goto Le7
        L132:
            r3 = r2
            goto L183
        L137:
            r0 = r2
        L138:
            goto L153
        L13c:
            r3[r7] = r6
            goto L24
        L142:
            r8 = r3[r7]
            goto L76
        L148:
            goto L19c
        L149:
            goto L4b
        L14d:
            r10[r3] = r5
            goto L137
        L153:
            if (r0 < r1) goto L158
            goto L18a
        L158:
            goto Lfe
        L15c:
            if (r7 >= r0) goto L161
            goto L65
        L161:
            goto L53
        L165:
            r9.f8489be34 = r10
            goto Lf3
        L16b:
            p5a445d71.p228c1b3d.p07cc694b.p31168275.p2b5e49a0$pb948e8a0[] r0 = r9.f8489be34
            goto L12
        L171:
            r2 = 0
            goto La1
        L176:
            goto L161
        L177:
            goto L17b
        L17b:
            int r7 = r7.GetHashCode()
            goto Ld2
        L183:
            goto L60
        L185:
            goto L17
        L189:
            goto L138
        L18a:
            goto L12c
        L18e:
            if (r0 <= 0) goto L193
            goto L5b
        L193:
            goto L58
        L197:
            if (r3 >= r1) goto L19c
            goto L60
        L19c:
            goto L132
    }

    int size() {
            r0 = this;
            goto L14
        L4:
            return r0
        L5:
            goto L1b
        L9:
            p5a445d71.p228c1b3d.p07cc694b.p31168275.p60ad5b1d[] r0 = r0.f9697a4d4
            goto Lf
        Lf:
            int r0 = r0.length
            goto L4
        L14:
            goto L5
        L17:
            goto L9
        L1b:
            goto L17
    }
}

