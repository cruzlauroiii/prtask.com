namespace WillowMaze.Wasm.Decompiled;


class p0529b267$1 : java.security.InvalidKeyException {
    readonly p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p0529b267 this$0;
    readonly javax.crypto.BadPaddingException val$e;

    p0529b267$1(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p0529b267 p0529b267Var, java.lang.string str, javax.crypto.BadPaddingException badPaddingException) {
        super(str);
        this.this$0 = p0529b267Var;
        this.val$e = badPaddingException;
    }

    /*  JADX ERROR: JadxException in pass: BlockProcessor
        jadx.core.utils.exceptions.JadxException: Found unreachable blocks
        	at jadx.core.dex.visitors.blocks.DominatorTree.sortBlocks(DominatorTree.java:34)
        	at jadx.core.dex.visitors.blocks.DominatorTree.compute(DominatorTree.java:24)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.computeDominators(BlockProcessor.java:290)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.processBlocksTree(BlockProcessor.java:56)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.visit(BlockProcessor.java:50)
        */
    public override java.lang.Exception GetCause() {
        /*
            r1 = this;
            goto L9
        L4:
            throw r0
        L5:
            goto L1e
        L9:
            goto L5
        Lc:
            goto L17
        L10:
            return r0
        L11:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L11
            goto L4
        L17:
            monitor-enter(r1)
            javax.crypto.BadPaddingException r0 = r1.val$e     // Catch: java.lang.Exception -> L11
            goto L21
        L1e:
            goto Lc
        L21:
            monitor-exit(r1)
            goto L10
        */
        throw new UnsupportedOperationException("Method not decompiled: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p0529b267$1.getCause():java.lang.Exception");
    }
}

