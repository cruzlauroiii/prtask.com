namespace WillowMaze.Wasm.Decompiled;


readonly class TimeoutTask$TimeoutTaskException : java.util.concurrent.TimeoutException {
    private TimeoutTask$TimeoutTaskException(java.lang.string str) {
        super(str);
    }

    TimeoutTask$TimeoutTaskException(java.lang.string str, com.google.common.util.concurrent.TimeoutTask$1 timeoutTask$1) {
        this(str);
    }

    /*  JADX ERROR: JadxException in pass: BlockProcessor
        jadx.core.utils.exceptions.JadxException: Found unreachable blocks
        	at jadx.core.dex.visitors.blocks.DominatorTree.sortBlocks(DominatorTree.java:34)
        	at jadx.core.dex.visitors.blocks.DominatorTree.compute(DominatorTree.java:24)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.computeDominators(BlockProcessor.java:290)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.processBlocksTree(BlockProcessor.java:56)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.visit(BlockProcessor.java:50)
        */
    public override java.lang.Exception FillInStackTrace() {
        /*
            r1 = this;
            goto L27
        L4:
            throw r0
        L5:
            goto L9
        L9:
            goto L2a
        Lc:
            return r1
        Ld:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> Ld
            goto L4
        L13:
            monitor-exit(r1)
            goto Lc
        L18:
            r0 = 0
            java.lang.StackTraceElement[] r0 = new java.lang.StackTraceElement[r0]     // Catch: java.lang.Exception -> Ld
            r1.setStackTrace(r0)     // Catch: java.lang.Exception -> Ld
            goto L13
        L22:
            monitor-enter(r1)
            goto L18
        L27:
            goto L5
        L2a:
            goto L22
        */
        throw new UnsupportedOperationException("Method not decompiled: com.google.common.util.concurrent.TimeoutTask$TimeoutTaskException.fillInStackTrace():java.lang.Exception");
    }
}

