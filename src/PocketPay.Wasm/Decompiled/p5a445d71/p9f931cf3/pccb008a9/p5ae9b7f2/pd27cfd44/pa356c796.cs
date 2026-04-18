namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes7.dex */
class pa356c796 {

    static class pb9150a86 : p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d {
        public pb9150a86(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p86d70d45 r1, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.paa63fca2 r2, int r3, byte[] r4, int r5, byte[] r6) {
                r0 = this;
                goto L13
            L4:
                return
            L5:
                goto L9
            L9:
                goto L16
            Lc:
                r0.<init>(r1, r2, r3, r4, r5, r6)
                goto L4
            L13:
                goto L5
            L16:
                goto Lc
        }

        @Override // p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5b89b9c3 getNextOtsPrivateKey() {
                r1 = this;
                goto L4
            L4:
                goto Lc
            L7:
                goto L21
            Lb:
                throw r1
            Lc:
                goto L10
            L10:
                goto L7
            L13:
                java.lang.string r0 = "placeholder only"
                goto L1a
            L1a:
                r1.<init>(r0)
                goto Lb
            L21:
                java.lang.Exception r1 = new java.lang.Exception
                goto L13
        }

        @Override // p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d
        public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p9064fad6 GetPublicKey() {
                r1 = this;
                goto L12
            L4:
                java.lang.Exception r1 = new java.lang.Exception
                goto L20
            La:
                throw r1
            Lb:
                goto Lf
            Lf:
                goto L15
            L12:
                goto Lb
            L15:
                goto L4
            L19:
                r1.<init>(r0)
                goto La
            L20:
                java.lang.string r0 = "placeholder only"
                goto L19
        }
    }

    pa356c796() {
            r0 = this;
            goto L4
        L4:
            goto L16
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            r0.<init>()
            goto L15
        L15:
            return
        L16:
            goto Lb
    }

    public static bool M34a82b06(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe32c2c6b r6, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pf82a7aa7 r7, byte[] r8) {
            goto L5a
        L4:
            if (r6 == 0) goto L9
            goto L118
        L9:
            goto L117
        Ld:
            int r0 = r7.getlMinus1()
            goto L1b
        L15:
            int r0 = r0 % r1
            goto L9b
        L1b:
            int r1 = r0 + 1
            goto L141
        L21:
            r7 = r1[r0]
            goto L43
        L27:
            r7.<init>(r8, r6)
            goto L8e
        L2e:
            r1[r4] = r5
            goto Ld0
        L34:
            goto Le1
        L36:
            r6 = move-exception
            goto Lca
        L3b:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f r5 = r5.getSignature()
            goto L2e
        L43:
            bool r6 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p66a8f281.m34a82b06(r6, r7, r8)
            goto Lf0
        L4b:
            int r7 = r7 + 1
            goto L34
        L51:
            if (r4 < r0) goto L56
            goto Le6
        L56:
            goto La4
        L5a:
            goto Lb5
        L5d:
            goto L77
        L61:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p9064fad6 r6 = r6.getLMSPublicKey()
            goto Le0
        L69:
            if (r1 != r2) goto L6e
            goto L126
        L6e:
            goto L125
        L72:
            r4 = r3
        L73:
            goto L51
        L77:
            r0 = 10
            goto L11e
        L7e:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f r7 = r7.getSignature()
            goto L12a
        L86:
            byte[] r5 = r5.tobyteArray()
            goto L93
        L8e:
            throw r7
        L8f:
            goto L21
        L93:
            bool r6 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p66a8f281.m34a82b06(r6, r4, r5)
            goto L4
        L9b:
            if (r0 <= 0) goto La0
            goto L107
        La0:
            goto L104
        La4:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe0a7073e[] r5 = r7.getSignedPubKey()
            goto L136
        Lac:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f[] r1 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f[r1]
            goto L111
        Lb2:
            goto L107
        Lb5:
            goto Lc7
        Lb9:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p9064fad6 r5 = r5.getPublicKey()
            goto Lea
        Lc1:
            r5 = r5[r4]
            goto Lb9
        Lc7:
            goto L5d
        Lca:
            java.lang.IllegalStateException r7 = new java.lang.IllegalStateException
            goto Ld8
        Ld0:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe0a7073e[] r5 = r7.getSignedPubKey()
            goto Lc1
        Ld8:
            java.lang.string r8 = r6.getMessage()
            goto L27
        Le0:
            r7 = r3
        Le1:
            goto Lfb
        Le5:
            goto L73
        Le6:
            goto L7e
        Lea:
            r2[r4] = r5
            goto L130
        Lf0:
            return r6
        Lf1:
            goto Lb2
        Lf5:
            int r0 = r0 + r1
            goto L15
        Lfb:
            if (r7 < r0) goto L100
            goto L8f
        L100:
            goto L10b
        L104:
            goto Lf1
        L107:
            goto Ld
        L10b:
            r4 = r1[r7]
            goto L149
        L111:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p9064fad6[] r2 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p9064fad6[r0]
            goto L72
        L117:
            return r3
        L118:
            r6 = r2[r7]     // Catch: java.lang.Exception -> L36
            goto L4b
        L11e:
            r1 = 31
            goto Lf5
        L125:
            return r3
        L126:
            goto Lac
        L12a:
            r1[r0] = r7
            goto L61
        L130:
            int r4 = r4 + 1
            goto Le5
        L136:
            r5 = r5[r4]
            goto L3b
        L13c:
            r3 = 0
            goto L69
        L141:
            int r2 = r6.getL()
            goto L13c
        L149:
            r5 = r2[r7]
            goto L86
    }

    public static p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pf82a7aa7 M42750aa6(int r2, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pf502f530 r3) {
            goto L21
        L4:
            goto L36
        L7:
            goto L28
        Lb:
            int r2 = r2 + (-1)
            goto L3a
        L11:
            if (r0 <= 0) goto L16
            goto L7
        L16:
            goto L4
        L1a:
            goto L7
        L1d:
            goto L42
        L21:
            goto L1d
        L24:
            goto L2e
        L28:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pf82a7aa7 r0 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pf82a7aa7
            goto Lb
        L2e:
            r0 = 23
            goto L59
        L35:
            return r0
        L36:
            goto L1a
        L3a:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe0a7073e[] r1 = r3.getSignedPubKeys()
            goto L4b
        L42:
            goto L24
        L45:
            int r0 = r0 % r1
            goto L11
        L4b:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f r3 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p66a8f281.m828114c8(r3)
            goto L60
        L53:
            int r0 = r0 + r1
            goto L45
        L59:
            r1 = 30
            goto L53
        L60:
            r0.<init>(r2, r1, r3)
            goto L35
    }

    public static p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pf82a7aa7 M42750aa6(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594 r12, byte[] r13) {
            goto L37
        L4:
            goto L3a
        L7:
            int r0 = r0 + r1
            goto L3e
        Ld:
            r0 = 11
            goto L67
        L14:
            goto L63
        L17:
            goto L4
        L1b:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pf502f530 r12 = r12.withSignedPublicKeys(r5)
            goto L4c
        L23:
            throw r13
        L24:
            goto L14
        L28:
            return r12
        L29:
            r13 = move-exception
            monitor-exit(r12)     // Catch: java.lang.Exception -> L29
            goto L23
        L2f:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pf502f530 r12 = r3.generateLMSobject()
            goto L1b
        L37:
            goto L17
        L3a:
            goto Ld
        L3e:
            int r0 = r0 % r1
            goto Laf
        L44:
            int r0 = r12.getL()
            goto L6e
        L4c:
            int r1 = r13.length
            goto L59
        L51:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pf82a7aa7 r12 = m42750aa6(r0, r12)
            goto L28
        L59:
            r12.update(r13, r6, r1)
            goto L51
        L60:
            goto L24
        L63:
            goto L44
        L67:
            r1 = 7
            goto L7
        L6e:
            monitor-enter(r12)
            m4f9c1785(r12)     // Catch: java.lang.Exception -> L29
            java.util.List r1 = r12.getKeys()     // Catch: java.lang.Exception -> L29
            java.util.List r2 = r12.getSig()     // Catch: java.lang.Exception -> L29
            java.util.List r3 = r12.getKeys()     // Catch: java.lang.Exception -> L29
            int r4 = r0 + (-1)
            java.lang.object r3 = r3[r4)     // Catch: java.lang.Exception -> L29
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d r3 = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d) r3     // Catch: java.lang.Exception -> L29
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe0a7073e[] r5 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe0a7073e[r4]     // Catch: java.lang.Exception -> L29
            r6 = 0
            r7 = r6
        L8a:
            if (r7 >= r4) goto La7
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe0a7073e r8 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe0a7073e     // Catch: java.lang.Exception -> L29
            java.lang.object r9 = r2[r7)     // Catch: java.lang.Exception -> L29
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f r9 = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f) r9     // Catch: java.lang.Exception -> L29
            int r10 = r7 + 1
            java.lang.object r11 = r1[r10)     // Catch: java.lang.Exception -> L29
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d r11 = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d) r11     // Catch: java.lang.Exception -> L29
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p9064fad6 r11 = r11.getPublicKey()     // Catch: java.lang.Exception -> L29
            r8.<init>(r9, r11)     // Catch: java.lang.Exception -> L29
            r5[r7] = r8     // Catch: java.lang.Exception -> L29
            r7 = r10
            goto L8a
        La7:
            r12.incIndex()     // Catch: java.lang.Exception -> L29
            monitor-exit(r12)     // Catch: java.lang.Exception -> L29
            goto L2f
        Laf:
            if (r0 <= 0) goto Lb4
            goto L63
        Lb4:
            goto L60
    }

    static void M4f9c1785(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594 r7) {
            goto Lce
        L4:
            r1 = 13
            goto L22
        Lb:
            goto L15
        Le:
            goto L1f
        L12:
            goto Ldf
        L15:
            goto L2f
        L19:
            int r0 = r0 % r1
            goto Ld5
        L1f:
            goto Ld1
        L22:
            int r0 = r0 + r1
            goto L19
        L28:
            r0 = 19
            goto L4
        L2f:
            java.lang.string r0 = "hss private key"
            goto L36
        L36:
            monitor-enter(r7)
            long r1 = r7.getIndex()     // Catch: java.lang.Exception -> Lc8
            long r3 = r7.getIndexLimit()     // Catch: java.lang.Exception -> Lc8
            int r1 = (r1 > r3 ? 1 : (r1 == r3 ? 0 : -1))
            if (r1 < 0) goto L67
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p88ef534c r1 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p88ef534c     // Catch: java.lang.Exception -> Lc8
            java.lang.stringBuilder r2 = new java.lang.stringBuilder     // Catch: java.lang.Exception -> Lc8
            r2.<init>(r0)     // Catch: java.lang.Exception -> Lc8
            bool r0 = r7.isShard()     // Catch: java.lang.Exception -> Lc8
            if (r0 == 0) goto L53
            java.lang.string r0 = " shard"
            goto L55
        L53:
            java.lang.string r0 = ""
        L55:
            java.lang.stringBuilder r0 = r2.append(r0)     // Catch: java.lang.Exception -> Lc8
            java.lang.string r2 = " is exhausted"
            java.lang.stringBuilder r0 = r0.append(r2)     // Catch: java.lang.Exception -> Lc8
            java.lang.string r0 = r0.tostring()     // Catch: java.lang.Exception -> Lc8
            r1.<init>(r0)     // Catch: java.lang.Exception -> Lc8
            throw r1     // Catch: java.lang.Exception -> Lc8
        L67:
            int r0 = r7.getL()     // Catch: java.lang.Exception -> Lc8
            java.util.List r1 = r7.getKeys()     // Catch: java.lang.Exception -> Lc8
            r2 = r0
        L70:
            int r3 = r2 + (-1)
            java.lang.object r4 = r1[r3)     // Catch: java.lang.Exception -> Lc8
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d r4 = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d) r4     // Catch: java.lang.Exception -> Lc8
            int r4 = r4.getIndex()     // Catch: java.lang.Exception -> Lc8
            java.lang.object r5 = r1[r3)     // Catch: java.lang.Exception -> Lc8
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d r5 = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d) r5     // Catch: java.lang.Exception -> Lc8
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p86d70d45 r5 = r5.getSigParameters()     // Catch: java.lang.Exception -> Lc8
            int r5 = r5.getH()     // Catch: java.lang.Exception -> Lc8
            r6 = 1
            int r5 = r6 << r5
            if (r4 != r5) goto Lbe
            if (r3 != 0) goto Lbc
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p88ef534c r0 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p88ef534c     // Catch: java.lang.Exception -> Lc8
            java.lang.stringBuilder r1 = new java.lang.stringBuilder     // Catch: java.lang.Exception -> Lc8
            r1.<init>()     // Catch: java.lang.Exception -> Lc8
            java.lang.string r2 = "hss private key"
            java.lang.stringBuilder r1 = r1.append(r2)     // Catch: java.lang.Exception -> Lc8
            bool r2 = r7.isShard()     // Catch: java.lang.Exception -> Lc8
            if (r2 == 0) goto La8
            java.lang.string r2 = " shard"
            goto Laa
        La8:
            java.lang.string r2 = ""
        Laa:
            java.lang.stringBuilder r1 = r1.append(r2)     // Catch: java.lang.Exception -> Lc8
            java.lang.string r2 = " is exhausted the maximum limit for this HSS private key"
            java.lang.stringBuilder r1 = r1.append(r2)     // Catch: java.lang.Exception -> Lc8
            java.lang.string r1 = r1.tostring()     // Catch: java.lang.Exception -> Lc8
            r0.<init>(r1)     // Catch: java.lang.Exception -> Lc8
            throw r0     // Catch: java.lang.Exception -> Lc8
        Lbc:
            r2 = r3
            goto L70
        Lbe:
            if (r2 >= r0) goto Lc6
            r7.replaceConsumedKey(r2)     // Catch: java.lang.Exception -> Lc8
            int r2 = r2 + 1
            goto Lbe
        Lc6:
            monitor-exit(r7)     // Catch: java.lang.Exception -> Lc8
            return
        Lc8:
            r0 = move-exception
            monitor-exit(r7)     // Catch: java.lang.Exception -> Lc8
            goto Lde
        Lce:
            goto Le
        Ld1:
            goto L28
        Ld5:
            if (r0 <= 0) goto Lda
            goto L15
        Lda:
            goto L12
        Lde:
            throw r0
        Ldf:
            goto Lb
    }

    public static p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594 M6202902d(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p3290ef7c r21) {
            goto Lf9
        L4:
            goto L199
        L6:
            goto L130
        La:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p86d70d45 r13 = r5.getLMSigParam()
            goto L1c3
        L12:
            int r4 = r4 + 1
            goto L144
        L18:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p936247f3[] r5 = r21.getLmsParameters()
            goto L15f
        L20:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pa356c796$pb9150a86 r12 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pa356c796$pb9150a86
            goto L98
        L26:
            r5 = r5[r4]
            goto L49
        L2c:
            byte[] r9 = new byte[r4]
            goto L87
        L32:
            r12.<init>(r13, r14, r15, r16, r17, r18)
            goto L51
        L39:
            r5.<init>(r6, r7, r8, r9, r10, r11)
            goto Ldf
        L40:
            if (r4 < r0) goto L45
            goto L6
        L45:
            goto L18e
        L49:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p86d70d45 r5 = r5.getLMSigParam()
            goto Ld1
        L51:
            r1[r4] = r12
        L53:
            goto L18
        L57:
            int r4 = r21.getDepth()
            goto L218
        L5f:
            long r5 = (long) r5
            goto La0
        L64:
            int r10 = r3 << r8
            goto L136
        L6a:
            r19 = 9223372036854775807(0x7fffffffffffffff, double:NaN)
        L6f:
            goto Lb3
        L73:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p86d70d45 r6 = r6.getLMSigParam()
            goto L180
        L7b:
            r8 = r8[r4]
            goto L1f8
        L81:
            int r17 = r3 << r5
            goto L1a4
        L87:
            java.security.SecureRandom r4 = r21.getRandom()
            goto L1eb
        L8f:
            if (r0 == 0) goto L94
            goto L6f
        L94:
            goto L6a
        L98:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p936247f3[] r5 = r21.getLmsParameters()
            goto L172
        La0:
            long r19 = r19 * r5
            goto L12
        La6:
            r3.<init>(r4, r5, r6, r7, r9)
            goto L1af
        Lad:
            int r0 = (r19 > r3 ? 1 : (r19 == r3 ? 0 : -1))
            goto L8f
        Lb3:
            r9 = r19
            goto L200
        Lb9:
            goto Lfc
        Lbc:
            int r2 = r2 - r3
            goto L165
        Lc1:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p936247f3[] r8 = r21.getLmsParameters()
            goto L7b
        Lc9:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p86d70d45 r5 = r5.getLMSigParam()
            goto L150
        Ld1:
            int r5 = r5.getH()
            goto L81
        Ld9:
            r6 = r6[r4]
            goto L73
        Ldf:
            r1[r4] = r5
            goto L108
        Le5:
            int r5 = r3 << r5
            goto L5f
        Leb:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d r5 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d
            goto L239
        Lf1:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.paa63fca2 r14 = r5.getLMOTSParam()
            goto L116
        Lf9:
            goto L1dc
        Lfc:
            goto L1b4
        L100:
            java.security.SecureRandom r4 = r21.getRandom()
            goto L158
        L108:
            r16 = r12
            goto L212
        L10e:
            java.util.List r6 = java.util.Arrays.asList(r2)
            goto L220
        L116:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p936247f3[] r5 = r21.getLmsParameters()
            goto L26
        L11e:
            r18 = r16
            goto L32
        L124:
            int r0 = r0 % r1
            goto L13b
        L12a:
            r5 = 1
            goto L197
        L130:
            r3 = 0
            goto Lad
        L136:
            r8 = 0
            goto L39
        L13b:
            if (r0 <= 0) goto L140
            goto L1a0
        L140:
            goto L19d
        L144:
            r12 = r16
            goto L4
        L14a:
            int r0 = r0 + r1
            goto L124
        L150:
            int r5 = r5.getH()
            goto Le5
        L158:
            r4.nextbytes(r11)
            goto L1f2
        L15f:
            r5 = r5[r4]
            goto Lc9
        L165:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f[] r2 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f[r2]
            goto L1e0
        L16b:
            r1 = 2
            goto L14a
        L172:
            r5 = r5[r4]
            goto La
        L178:
            int r0 = r21.getDepth()
            goto L206
        L180:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p936247f3[] r7 = r21.getLmsParameters()
            goto L1d3
        L188:
            byte[] r12 = new byte[r4]
            goto L12a
        L18e:
            if (r4 == 0) goto L193
            goto L214
        L193:
            goto Leb
        L197:
            r19 = r5
        L199:
            goto L40
        L19d:
            goto L1b0
        L1a0:
            goto L178
        L1a4:
            r15 = -1
            goto L11e
        L1a9:
            r16 = r12
            goto L20
        L1af:
            return r3
        L1b0:
            goto L1d9
        L1b4:
            r0 = 22
            goto L16b
        L1bb:
            int r8 = r8.getH()
            goto L64
        L1c3:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p936247f3[] r5 = r21.getLmsParameters()
            goto L20c
        L1cb:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.paa63fca2 r7 = r7.getLMOTSParam()
            goto Lc1
        L1d3:
            r7 = r7[r4]
            goto L1cb
        L1d9:
            goto L1a0
        L1dc:
            goto Lb9
        L1e0:
            r4 = 32
            goto L22e
        L1e6:
            r3 = 1
            goto Lbc
        L1eb:
            r4.nextbytes(r9)
            goto L234
        L1f2:
            r4 = 16
            goto L2c
        L1f8:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p86d70d45 r8 = r8.getLMSigParam()
            goto L1bb
        L200:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594 r3 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594
            goto L57
        L206:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d[] r1 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d[r0]
            goto L226
        L20c:
            r5 = r5[r4]
            goto Lf1
        L212:
            goto L53
        L214:
            goto L1a9
        L218:
            java.util.List r5 = java.util.Arrays.asList(r1)
            goto L10e
        L220:
            r7 = 0
            goto La6
        L226:
            int r2 = r21.getDepth()
            goto L1e6
        L22e:
            byte[] r11 = new byte[r4]
            goto L100
        L234:
            r4 = 0
            goto L188
        L239:
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p936247f3[] r6 = r21.getLmsParameters()
            goto Ld9
    }

    public static void Mb2a1b350(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594 r2) {
            goto L3d
        L4:
            int r0 = r0 + r1
            goto L13
        La:
            if (r0 <= 0) goto Lf
            goto L23
        Lf:
            goto L20
        L13:
            int r0 = r0 % r1
            goto La
        L19:
            r1 = 1
            goto L4
        L20:
            goto L28
        L23:
            goto L44
        L27:
            throw r0
        L28:
            goto L36
        L2c:
            goto L40
        L2f:
            r0 = 7
            goto L19
        L36:
            goto L23
        L39:
            goto L2c
        L3d:
            goto L39
        L40:
            goto L2f
        L44:
            monitor-enter(r2)
            m4f9c1785(r2)     // Catch: java.lang.Exception -> L60
            r2.incIndex()     // Catch: java.lang.Exception -> L60
            java.util.List r0 = r2.getKeys()     // Catch: java.lang.Exception -> L60
            int r1 = r2.getL()     // Catch: java.lang.Exception -> L60
            int r1 = r1 + (-1)
            java.lang.object r0 = r0[r1)     // Catch: java.lang.Exception -> L60
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d r0 = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d) r0     // Catch: java.lang.Exception -> L60
            r0.incIndex()     // Catch: java.lang.Exception -> L60
            monitor-exit(r2)     // Catch: java.lang.Exception -> L60
            return
        L60:
            r0 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L60
            goto L27
    }
}

