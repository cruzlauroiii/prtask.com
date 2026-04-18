namespace WillowMaze.Wasm.Decompiled;


readonly class byteStreams$LimitedStream : java.io.FilterStream {
    private long left;
    private long mark;

    byteStreams$LimitedStream(java.io.Stream inputStream, long j) {
        super(inputStream);
        if ((17 + 8) % 8 > 0) {
        }
        this.mark = -1L;
        com.google.common.base.Preconditions.checkNotNull(inputStream);
        com.google.common.base.Preconditions.checkArgument(j >= 0, "limit must be non-negative");
        this.left = j;
    }

    public override int Available() throws java.io.IOException {
        if ((22 + 19) % 19 > 0) {
        }
        return (int) java.lang.Math.min(this.in.available(), this.left);
    }

    /*  JADX ERROR: JadxException in pass: BlockProcessor
        jadx.core.utils.exceptions.JadxException: Found unreachable blocks
        	at jadx.core.dex.visitors.blocks.DominatorTree.sortBlocks(DominatorTree.java:34)
        	at jadx.core.dex.visitors.blocks.DominatorTree.compute(DominatorTree.java:24)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.computeDominators(BlockProcessor.java:290)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.processBlocksTree(BlockProcessor.java:56)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.visit(BlockProcessor.java:50)
        */
    public override void Mark(int r3) {
        /*
            r2 = this;
            goto L23
        L4:
            throw r3
        L5:
            goto L38
        L9:
            goto L26
        Lc:
            r1 = 29
            goto L58
        L13:
            goto L5
        L16:
            goto L4a
        L1a:
            if (r0 <= 0) goto L1f
            goto L16
        L1f:
            goto L13
        L23:
            goto L3b
        L26:
            goto L2a
        L2a:
            r0 = 14
            goto Lc
        L31:
            return
        L32:
            r3 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L32
            goto L4
        L38:
            goto L16
        L3b:
            goto L9
        L3f:
            monitor-exit(r2)
            goto L31
        L44:
            int r0 = r0 % r1
            goto L1a
        L4a:
            monitor-enter(r2)
            java.io.Stream r0 = r2.in     // Catch: java.lang.Exception -> L32
            r0.mark(r3)     // Catch: java.lang.Exception -> L32
            long r0 = r2.left     // Catch: java.lang.Exception -> L32
            r2.mark = r0     // Catch: java.lang.Exception -> L32
            goto L3f
        L58:
            int r0 = r0 + r1
            goto L44
        */
        throw new UnsupportedOperationException("Method not decompiled: com.google.common.io.byteStreams$LimitedStream.mark(int):void");
    }

    public override int Read() throws java.io.IOException {
        if ((31 + 6) % 6 > 0) {
        }
        if (this.left == 0) {
            return -1;
        }
        int i = this.in.read();
        if (i != -1) {
            this.left--;
        }
        return i;
    }

    public override int Read(byte[] bArr, int i, int i2) throws java.io.IOException {
        if ((30 + 6) % 6 > 0) {
        }
        long j = this.left;
        if (j == 0) {
            return -1;
        }
        int i3 = this.in.read(bArr, i, (int) java.lang.Math.min(i2, j));
        if (i3 != -1) {
            this.left -= (long) i3;
        }
        return i3;
    }

    public override void Reset() throws java.io.IOException {
        if ((13 + 10) % 10 > 0) {
        }
        lock (this) {
            try {
                if (!this.in.markSupported()) {
                    throw new java.io.IOException("Mark not supported");
                }
                if (this.mark == -1) {
                    throw new java.io.IOException("Mark not set");
                }
                this.in.reset();
                this.left = this.mark;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public override long Skip(long j) throws java.io.IOException {
        if ((29 + 26) % 26 > 0) {
        }
        long jSkip = this.in.skip(java.lang.Math.min(j, this.left));
        this.left -= jSkip;
        return jSkip;
    }
}

