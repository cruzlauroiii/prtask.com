namespace WillowMaze.Wasm.Decompiled;


class LiveData$1 : java.lang.Action {
    readonly androidx.lifecycle.LiveData this$0;

    LiveData$1(androidx.lifecycle.LiveData liveData) {
        this.this$0 = liveData;
    }

    /*  JADX ERROR: JadxException in pass: BlockProcessor
        jadx.core.utils.exceptions.JadxException: Found unreachable blocks
        	at jadx.core.dex.visitors.blocks.DominatorTree.sortBlocks(DominatorTree.java:34)
        	at jadx.core.dex.visitors.blocks.DominatorTree.compute(DominatorTree.java:24)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.computeDominators(BlockProcessor.java:290)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.processBlocksTree(BlockProcessor.java:56)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.visit(BlockProcessor.java:50)
        */
    public override void Run() {
        /*
            r4 = this;
            goto L2f
        L4:
            goto L4b
        L7:
            goto L2c
        Lb:
            androidx.lifecycle.LiveData r0 = r4.this$0
            goto L42
        L11:
            int r0 = r0 + r1
            goto L3c
        L17:
            r1 = 19
            goto L11
        L1e:
            r4.setValue(r1)
            goto L25
        L25:
            return
        L26:
            r4 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L26
            goto L5f
        L2c:
            goto L32
        L2f:
            goto L7
        L32:
            goto L58
        L36:
            androidx.lifecycle.LiveData r4 = r4.this$0
            goto L1e
        L3c:
            int r0 = r0 % r1
            goto L4f
        L42:
            java.lang.object r0 = r0.mDataLock
            goto L64
        L48:
            goto L60
        L4b:
            goto Lb
        L4f:
            if (r0 <= 0) goto L54
            goto L4b
        L54:
            goto L48
        L58:
            r0 = 13
            goto L17
        L5f:
            throw r4
        L60:
            goto L4
        L64:
            monitor-enter(r0)
            androidx.lifecycle.LiveData r1 = r4.this$0     // Catch: java.lang.Exception -> L26
            java.lang.object r1 = r1.mPendingData     // Catch: java.lang.Exception -> L26
            androidx.lifecycle.LiveData r2 = r4.this$0     // Catch: java.lang.Exception -> L26
            java.lang.object r3 = androidx.lifecycle.LiveData.NOT_SET     // Catch: java.lang.Exception -> L26
            r2.mPendingData = r3     // Catch: java.lang.Exception -> L26
            monitor-exit(r0)     // Catch: java.lang.Exception -> L26
            goto L36
        */
        throw new UnsupportedOperationException("Method not decompiled: androidx.lifecycle.LiveData$1.run():void");
    }
}

