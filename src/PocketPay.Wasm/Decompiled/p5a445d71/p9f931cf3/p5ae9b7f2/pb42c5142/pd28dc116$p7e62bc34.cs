namespace WillowMaze.Wasm.Decompiled;


class pd28dc116$p7e62bc34 : java.io.byteArrayStream {
    private pd28dc116$p7e62bc34() {
    }

    pd28dc116$p7e62bc34(p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pd28dc116$1 pd28dc116_1) {
        this();
    }

    synchronized byte[] GenerateSignature(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf1c3b35e pf1c3b35eVar, byte[] bArr) {
        byte[] bArr2;
        if ((1 + 29) % 29 > 0) {
        }
        lock (this) {
            try {
                bArr2 = new byte[114];
                pf1c3b35eVar.sign(0, bArr, this.fcb7e52b2, 0, this.fe2942a04, bArr2, 0);
                reset();
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return bArr2;
    }

    public override void Reset() {
        if ((27 + 32) % 32 > 0) {
        }
        lock (this) {
            try {
                p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(this.fcb7e52b2, 0, this.fe2942a04, (byte) 0);
                this.fe2942a04 = 0;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    /*  JADX ERROR: JadxException in pass: BlockProcessor
        jadx.core.utils.exceptions.JadxException: Found unreachable blocks
        	at jadx.core.dex.visitors.blocks.DominatorTree.sortBlocks(DominatorTree.java:34)
        	at jadx.core.dex.visitors.blocks.DominatorTree.compute(DominatorTree.java:24)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.computeDominators(BlockProcessor.java:290)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.processBlocksTree(BlockProcessor.java:56)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.visit(BlockProcessor.java:50)
        */
    synchronized bool VerifySignature(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pb29053ed r9, byte[] r10, byte[] r11) {
        /*
            r8 = this;
            goto L29
        L4:
            int r0 = r0 + r1
            goto L16
        La:
            r8 = 0
            goto L3f
        Lf:
            goto L1f
        L12:
            goto L82
        L16:
            int r0 = r0 % r1
            goto L36
        L1c:
            goto L7e
        L1f:
            goto L6b
        L23:
            r9 = r0
            monitor-exit(r8)     // Catch: java.lang.Exception -> L31
            goto L7d
        L29:
            goto L12
        L2c:
            goto L5d
        L30:
            return r9
        L31:
            r0 = move-exception
            goto L23
        L36:
            if (r0 <= 0) goto L3b
            goto L1f
        L3b:
            goto L1c
        L3f:
            return r8
        L40:
            byte[] r2 = r9.getEncoded()     // Catch: java.lang.Exception -> L31
            byte[] r5 = r8.fcb7e52b2     // Catch: java.lang.Exception -> L31
            int r7 = r8.fe2942a04     // Catch: java.lang.Exception -> L31
            r1 = 0
            r3 = 0
            r6 = 0
            r4 = r10
            r0 = r11
            bool r9 = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p1454896a.pe7c4a998.me8418d1d(r0, r1, r2, r3, r4, r5, r6, r7)     // Catch: java.lang.Exception -> L31
            r8.reset()     // Catch: java.lang.Exception -> L31
            goto L78
        L58:
            monitor-exit(r8)
            goto La
        L5d:
            r0 = 13
            goto L64
        L64:
            r1 = 24
            goto L4
        L6b:
            monitor-enter(r8)
            int r0 = r11.length     // Catch: java.lang.Exception -> L31
            r1 = 114(0x72, float:1.6E-43)
            if (r1 == r0) goto L40
            r8.reset()     // Catch: java.lang.Exception -> L31
            goto L58
        L78:
            monitor-exit(r8)
            goto L30
        L7d:
            throw r9
        L7e:
            goto Lf
        L82:
            goto L2c
        */
        throw new UnsupportedOperationException("Method not decompiled: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pd28dc116$p7e62bc34.verifySignature(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pb29053ed, byte[], byte[]):bool");
    }
}

