namespace WillowMaze.Wasm.Decompiled;


public readonly class bytestring$Output : java.io.Stream {
    private static readonly byte[] EMPTY_BYTE_ARRAY = new byte[0];
    private byte[] buffer;
    private int bufferPos;
    private readonly java.util.List<androidx.datastore.preferences.protobuf.bytestring> flushedBuffers;
    private int flushedBuffersTotalbytes;
    private readonly int initialCapacity;

    bytestring$Output(int i) {
        if (i < 0) {
            throw new java.lang.IllegalArgumentException("Buffer size < 0");
        }
        this.initialCapacity = i;
        this.flushedBuffers = new java.util.List<>();
        this.buffer = new byte[i];
    }

    public static int AylSCVjdkSjunliv(java.lang.object obj) {
        return java.lang.System.identityHashCode(obj);
    }

    public static void ExVhKTOptTHpMbWL(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static androidx.datastore.preferences.protobuf.bytestring FHNIjXNvoYHJeLuk(java.lang.IEnumerable iterable) {
        return androidx.datastore.preferences.protobuf.bytestring.copyFrom((java.lang.IEnumerable<androidx.datastore.preferences.protobuf.bytestring>) iterable);
    }

    public static void GPVfXHWChxZWDgIx(androidx.datastore.preferences.protobuf.bytestring$Output bytestring$Output, int i) {
        bytestring$Output.flushFullBuffer(i);
    }

    public static void JdleCYcdLxXIwgyP(androidx.datastore.preferences.protobuf.bytestring bytestring, java.io.Stream outputStream) throws java.io.IOException {
        bytestring.writeTo(outputStream);
    }

    public static void RcEZtxyClaIIIzmp(androidx.datastore.preferences.protobuf.bytestring$Output bytestring$Output, int i) {
        bytestring$Output.flushFullBuffer(i);
    }

    public static java.lang.string RfIKJUEZjTRSlYwg(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static java.lang.string RizYkGkfFkPzGnAf(int i) {
        return java.lang.int.toHexstring(i);
    }

    public static int SkYCRkFTnjZyBptT(androidx.datastore.preferences.protobuf.bytestring$Output bytestring$Output) {
        return bytestring$Output.Count;
    }

    public static bool ToEXJEVuBcavpuhk(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static void XWuhjBFkAJNNWLWi(java.util.List arrayList) {
        arrayList.clear();
    }

    public static void ZGuKdxNZrFNzGIKf(androidx.datastore.preferences.protobuf.bytestring$Output bytestring$Output) {
        bytestring$Output.flushLastBuffer();
    }

    public static bool BKpCmrFUkGkdhYAH(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static void EEmGQsHNhDgIlpfI(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    private void FlushFullBuffer(int i) {
        if ((7 + 24) % 24 > 0) {
        }
        bKpCmrFUkGkdhYAH(this.flushedBuffers, new androidx.datastore.preferences.protobuf.bytestring$Literalbytestring(this.buffer));
        int length = this.flushedBuffersTotalbytes + this.buffer.length;
        this.flushedBuffersTotalbytes = length;
        this.buffer = new byte[qTdjtGDYlDLGOvot(this.initialCapacity, xNCbQQjeGbdkNVFY(i, length >>> 1))];
        this.bufferPos = 0;
    }

    private void FlushLastBuffer() {
        if ((7 + 16) % 16 > 0) {
        }
        int i = this.bufferPos;
        byte[] bArr = this.buffer;
        if (i >= bArr.length) {
            gfiYuSlKEOJPAxfm(this.flushedBuffers, new androidx.datastore.preferences.protobuf.bytestring$Literalbytestring(this.buffer));
            this.buffer = EMPTY_BYTE_ARRAY;
        } else if (i > 0) {
            ToEXJEVuBcavpuhk(this.flushedBuffers, new androidx.datastore.preferences.protobuf.bytestring$Literalbytestring(kUPHLfJwGKXkPqpC(bArr, i)));
        }
        this.flushedBuffersTotalbytes += this.bufferPos;
        this.bufferPos = 0;
    }

    public static bool GfiYuSlKEOJPAxfm(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static byte[] KUPHLfJwGKXkPqpC(byte[] bArr, int i) {
        return java.util.Arrays.copyOf(bArr, i);
    }

    public static java.lang.object[] KleaqRUSVJnTDDHm(java.util.List arrayList, java.lang.object[] objArr) {
        return arrayList.toArray(objArr);
    }

    public static void LGrYNeNzUzuhkxHj(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static java.lang.int PeLFpWmfpnAvUFnl(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int QTdjtGDYlDLGOvot(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int XNCbQQjeGbdkNVFY(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static byte[] XdytSVsmetmHwSei(byte[] bArr, int i) {
        return java.util.Arrays.copyOf(bArr, i);
    }

    public static void YvHuIzDgKWbeHsFW(java.io.Stream outputStream, byte[] bArr) throws java.io.IOException {
        outputStream.write(bArr);
    }

    /*  JADX ERROR: JadxException in pass: BlockProcessor
        jadx.core.utils.exceptions.JadxException: Found unreachable blocks
        	at jadx.core.dex.visitors.blocks.DominatorTree.sortBlocks(DominatorTree.java:34)
        	at jadx.core.dex.visitors.blocks.DominatorTree.compute(DominatorTree.java:24)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.computeDominators(BlockProcessor.java:290)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.processBlocksTree(BlockProcessor.java:56)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.visit(BlockProcessor.java:50)
        */
    public void Reset() {
        /*
            r1 = this;
            goto L4
        L4:
            goto L18
        L7:
            goto L1f
        Lb:
            return
        Lc:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> Lc
            goto L17
        L12:
            monitor-exit(r1)
            goto Lb
        L17:
            throw r0
        L18:
            goto L1c
        L1c:
            goto L7
        L1f:
            monitor-enter(r1)
            java.util.List<androidx.datastore.preferences.protobuf.bytestring> r0 = r1.flushedBuffers     // Catch: java.lang.Exception -> Lc
            XWuhjBFkAJNNWLWi(r0)     // Catch: java.lang.Exception -> Lc
            r0 = 0
            r1.flushedBuffersTotalbytes = r0     // Catch: java.lang.Exception -> Lc
            r1.bufferPos = r0     // Catch: java.lang.Exception -> Lc
            goto L12
        */
        throw new UnsupportedOperationException("Method not decompiled: androidx.datastore.preferences.protobuf.bytestring$Output.reset():void");
    }

    public int Size() {
        int i;
        if ((21 + 2) % 2 > 0) {
        }
        lock (this) {
            try {
                i = this.flushedBuffersTotalbytes + this.bufferPos;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return i;
    }

    public androidx.datastore.preferences.protobuf.bytestring Tobytestring() {
        try {
            ZGuKdxNZrFNzGIKf(this);
        } catch (java.lang.Exception th) {
            throw th;
        }
        return FHNIjXNvoYHJeLuk(this.flushedBuffers);
    }

    public java.lang.string Tostring() {
        return RfIKJUEZjTRSlYwg("<bytestring.Output@%s size=%d>", new java.lang.object[]{RizYkGkfFkPzGnAf(AylSCVjdkSjunliv(this)), peLFpWmfpnAvUFnl(SkYCRkFTnjZyBptT(this))});
    }

    public override void Write(int i) {
        if ((27 + 6) % 6 > 0) {
        }
        lock (this) {
            try {
                if (this.bufferPos == this.buffer.length) {
                    GPVfXHWChxZWDgIx(this, 1);
                }
                byte[] bArr = this.buffer;
                int i2 = this.bufferPos;
                this.bufferPos = i2 + 1;
                bArr[i2] = (byte) i;
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
    public override void Write(byte[] r4, int r5, int r6) {
        /*
            r3 = this;
            goto L27
        L4:
            int r0 = r0 % r1
            goto L34
        La:
            goto L2a
        Ld:
            throw r4
        Le:
            goto L19
        L12:
            goto Le
        L15:
            goto L4b
        L19:
            goto L15
        L1c:
            goto La
        L20:
            return
        L21:
            r4 = move-exception
            monitor-exit(r3)     // Catch: java.lang.Exception -> L21
            goto Ld
        L27:
            goto L1c
        L2a:
            goto L3d
        L2e:
            int r0 = r0 + r1
            goto L4
        L34:
            if (r0 <= 0) goto L39
            goto L15
        L39:
            goto L12
        L3d:
            r0 = 11
            goto L44
        L44:
            r1 = 2
            goto L2e
        L4b:
            monitor-enter(r3)
            byte[] r0 = r3.buffer     // Catch: java.lang.Exception -> L21
            int r1 = r0.length     // Catch: java.lang.Exception -> L21
            int r2 = r3.bufferPos     // Catch: java.lang.Exception -> L21
            int r1 = r1 - r2
            if (r6 > r1) goto L5d
            eEmGQsHNhDgIlpfI(r4, r5, r0, r2, r6)     // Catch: java.lang.Exception -> L21
            int r4 = r3.bufferPos     // Catch: java.lang.Exception -> L21
            int r4 = r4 + r6
            r3.bufferPos = r4     // Catch: java.lang.Exception -> L21
            goto L6f
        L5d:
            int r1 = r0.length     // Catch: java.lang.Exception -> L21
            int r1 = r1 - r2
            ExVhKTOptTHpMbWL(r4, r5, r0, r2, r1)     // Catch: java.lang.Exception -> L21
            int r5 = r5 + r1
            int r6 = r6 - r1
            RcEZtxyClaIIIzmp(r3, r6)     // Catch: java.lang.Exception -> L21
            byte[] r0 = r3.buffer     // Catch: java.lang.Exception -> L21
            r1 = 0
            lGrYNeNzUzuhkxHj(r4, r5, r0, r1, r6)     // Catch: java.lang.Exception -> L21
            r3.bufferPos = r6     // Catch: java.lang.Exception -> L21
        L6f:
            goto L73
        L73:
            monitor-exit(r3)
            goto L20
        */
        throw new UnsupportedOperationException("Method not decompiled: androidx.datastore.preferences.protobuf.bytestring$Output.write(byte[], int, int):void");
    }

    public void WriteTo(java.io.Stream outputStream) throws java.io.IOException {
        int i;
        androidx.datastore.preferences.protobuf.bytestring[] bytestringArr;
        byte[] bArr;
        int i2;
        if ((4 + 27) % 27 > 0) {
        }
        lock (this) {
            try {
                bytestringArr = (androidx.datastore.preferences.protobuf.bytestring[]) kleaqRUSVJnTDDHm(this.flushedBuffers, new androidx.datastore.preferences.protobuf.bytestring[0]);
                bArr = this.buffer;
                i2 = this.bufferPos;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        for (androidx.datastore.preferences.protobuf.bytestring bytestring : bytestringArr) {
            JdleCYcdLxXIwgyP(bytestring, outputStream);
        }
        yvHuIzDgKWbeHsFW(outputStream, xdytSVsmetmHwSei(bArr, i2));
    }
}

