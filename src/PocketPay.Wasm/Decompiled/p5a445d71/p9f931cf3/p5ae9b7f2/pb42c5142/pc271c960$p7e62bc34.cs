namespace WillowMaze.Wasm.Decompiled;


class pc271c960$p7e62bc34 : java.io.byteArrayStream {
    private pc271c960$p7e62bc34() {
    }

    pc271c960$p7e62bc34(p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pc271c960$1 pc271c960_1) {
        this();
    }

    /*  JADX ERROR: JadxException in pass: BlockProcessor
        jadx.core.utils.exceptions.JadxException: Found unreachable blocks
        	at jadx.core.dex.visitors.blocks.DominatorTree.sortBlocks(DominatorTree.java:34)
        	at jadx.core.dex.visitors.blocks.DominatorTree.compute(DominatorTree.java:24)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.computeDominators(BlockProcessor.java:290)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.processBlocksTree(BlockProcessor.java:56)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.visit(BlockProcessor.java:50)
        */
    synchronized byte[] GenerateSignature(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe1b9a0e1 r10, byte[] r11) {
        /*
            r9 = this;
            goto L48
        L4:
            monitor-enter(r9)
            goto L55
        L9:
            r1 = 27
            goto L42
        L10:
            goto L4b
        L13:
            r0 = 8
            goto L9
        L1a:
            if (r0 <= 0) goto L1f
            goto L31
        L1f:
            goto L2e
        L23:
            monitor-exit(r9)
            goto L35
        L28:
            int r0 = r0 % r1
            goto L1a
        L2e:
            goto L6d
        L31:
            goto L4
        L35:
            return r7
        L36:
            r0 = move-exception
            goto L4f
        L3b:
            goto L31
        L3e:
            goto L10
        L42:
            int r0 = r0 + r1
            goto L28
        L48:
            goto L3e
        L4b:
            goto L13
        L4f:
            r10 = r0
            monitor-exit(r9)     // Catch: java.lang.Exception -> L36
            goto L6c
        L55:
            r0 = 64
            byte[] r7 = new byte[r0]     // Catch: java.lang.Exception -> L36
            byte[] r4 = r9.fcb7e52b2     // Catch: java.lang.Exception -> L36
            int r6 = r9.fe2942a04     // Catch: java.lang.Exception -> L36
            r8 = 0
            r2 = 1
            r5 = 0
            r1 = r10
            r3 = r11
            r1.sign(r2, r3, r4, r5, r6, r7, r8)     // Catch: java.lang.Exception -> L36
            r9.reset()     // Catch: java.lang.Exception -> L36
            goto L23
        L6c:
            throw r10
        L6d:
            goto L3b
        */
        throw new UnsupportedOperationException("Method not decompiled: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pc271c960$p7e62bc34.generateSignature(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe1b9a0e1, byte[]):byte[]");
    }

    public override void Reset() {
        if ((5 + 9) % 9 > 0) {
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

    synchronized bool VerifySignature(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p070794c1 p070794c1Var, byte[] bArr, byte[] bArr2) {
        if ((30 + 22) % 22 > 0) {
        }
        lock (this) {
            try {
                if (64 != bArr2.length) {
                    reset();
                    return false;
                }
                bool zMe8418d1d = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p1454896a.p9edc4d6f.me8418d1d(bArr2, 0, p070794c1Var.getEncoded(), 0, bArr, this.fcb7e52b2, 0, this.fe2942a04);
                reset();
                return zMe8418d1d;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

