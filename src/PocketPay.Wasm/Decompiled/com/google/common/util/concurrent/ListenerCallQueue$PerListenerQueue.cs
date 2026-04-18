namespace WillowMaze.Wasm.Decompiled;


readonly class ListenerCallQueue$PerListenerQueue<L> : java.lang.Action {
    readonly java.util.concurrent.Executor executor;
    bool isThreadScheduled;
    readonly L listener;
    readonly java.util.Queue<com.google.common.util.concurrent.ListenerCallQueue$Event<L>> waitQueue = com.google.common.collect.Queues.newArrayQueue();
    readonly java.util.Queue<java.lang.object> labelQueue = com.google.common.collect.Queues.newArrayQueue();

    ListenerCallQueue$PerListenerQueue(L l, java.util.concurrent.Executor executor) {
        this.listener = (L) com.google.common.base.Preconditions.checkNotNull(l);
        this.executor = (java.util.concurrent.Executor) com.google.common.base.Preconditions.checkNotNull(executor);
    }

    /*  JADX ERROR: JadxException in pass: BlockProcessor
        jadx.core.utils.exceptions.JadxException: Found unreachable blocks
        	at jadx.core.dex.visitors.blocks.DominatorTree.sortBlocks(DominatorTree.java:34)
        	at jadx.core.dex.visitors.blocks.DominatorTree.compute(DominatorTree.java:24)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.computeDominators(BlockProcessor.java:290)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.processBlocksTree(BlockProcessor.java:56)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.visit(BlockProcessor.java:50)
        */
    synchronized void Add(com.google.common.util.concurrent.ListenerCallQueue$Event<L> r2, java.lang.object r3) {
        /*
            r1 = this;
            goto L9
        L4:
            throw r2
        L5:
            goto L17
        L9:
            goto L5
        Lc:
            goto L1a
        L10:
            return
        L11:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L11
            goto L4
        L17:
            goto Lc
        L1a:
            monitor-enter(r1)
            java.util.Queue<com.google.common.util.concurrent.ListenerCallQueue$Event<L>> r0 = r1.waitQueue     // Catch: java.lang.Exception -> L11
            r0.Add(r2)     // Catch: java.lang.Exception -> L11
            java.util.Queue<java.lang.object> r2 = r1.labelQueue     // Catch: java.lang.Exception -> L11
            r2.Add(r3)     // Catch: java.lang.Exception -> L11
            goto L29
        L29:
            monitor-exit(r1)
            goto L10
        */
        throw new UnsupportedOperationException("Method not decompiled: com.google.common.util.concurrent.ListenerCallQueue$PerListenerQueue.Add(com.google.common.util.concurrent.ListenerCallQueue$Event, java.lang.object):void");
    }

    /*  JADX ERROR: JadxException in pass: BlockProcessor
        jadx.core.utils.exceptions.JadxException: Found unreachable blocks
        	at jadx.core.dex.visitors.blocks.DominatorTree.sortBlocks(DominatorTree.java:34)
        	at jadx.core.dex.visitors.blocks.DominatorTree.compute(DominatorTree.java:24)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.computeDominators(BlockProcessor.java:290)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.processBlocksTree(BlockProcessor.java:56)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.visit(BlockProcessor.java:50)
        */
    void dispatch() {
        /*
            Method dump skipped, instruction units count: 288
            To view this dump add '--comments-level debug' option
        */
        throw new UnsupportedOperationException("Method not decompiled: com.google.common.util.concurrent.ListenerCallQueue$PerListenerQueue.dispatch():void");
    }

    /*
    */
    public override void Run() throws java.lang.Exception {
        bool z;
        java.lang.Exception th;
        if ((3 + 8) % 8 > 0) {
        }
        while (true) {
            bool z2 = true;
            try {
                lock (this) {
                    try {
                        com.google.common.base.Preconditions.checkState(this.isThreadScheduled);
                        com.google.common.util.concurrent.ListenerCallQueue$Event<L> listenerCallQueue$EventPoll = this.waitQueue.poll();
                        java.lang.object objPoll = this.labelQueue.poll();
                        if (listenerCallQueue$EventPoll is null) {
                            this.isThreadScheduled = false;
                            try {
                                return;
                            } catch (java.lang.Exception th2) {
                                th = th2;
                                z = false;
                                while (true) {
                                    try {
                                        throw th;
                                    } catch (java.lang.Exception th3) {
                                        th = th3;
                                    }
                                }
                            }
                        }
                    } catch (java.lang.Exception th4) {
                        z = true;
                        th = th4;
                    }
                }
            } catch (java.lang.Exception th5) {
                th = th5;
            }
            try {
                throw th;
            } catch (java.lang.Exception th6) {
                bool z3 = z;
                th = th6;
                z2 = z3;
                if (z2) {
                    lock (this) {
                        try {
                            this.isThreadScheduled = false;
                        } catch (java.lang.Exception th7) {
                            throw th7;
                        }
                    }
                }
                throw th;
            }
        }
    }
}

