namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0000\b\u0082\u0004\u0018\u00002\u00020\u0001B\u0005¢\u0006\u0002\u0010\u0002J\b\u0010\u0007\u001a\u00020\bH\u0016J\b\u0010\t\u001a\u00020\bH\u0016J\b\u0010\u0005\u001a\u00020\nH\u0016J\u0018\u0010\u000b\u001a\u00020\b2\u0006\u0010\f\u001a\u00020\r2\u0006\u0010\u000e\u001a\u00020\u000fH\u0016R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0005\u001a\u00020\u0006X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0010"}, d2 = {"Lp7ddcfee1/pd1efad72/pf3387e2d/p2bfb7a6c$pcb5f53af;", "Lp38cb8f46/p1eb558b5;", "(Lp7ddcfee1/pd1efad72/pf3387e2d/p2bfb7a6c;)V", "closed", "", "timeout", "Lp38cb8f46/p911250bb;", "close", "", "flush", "Lp38cb8f46/pc85a251c;", "write", "source", "Lp38cb8f46/p7e62bc34;", "byteCount", "", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
readonly class p2bfb7a6c$pcb5f53af : p38cb8f46.p1eb558b5 {
    private bool f04ae1554;
    private readonly p38cb8f46.p911250bb f14d02a06;
    private readonly p38cb8f46.p911250bb f14f3de0f;
    private readonly p38cb8f46.p911250bb f1bce6e76;
    private bool f349e6863;
    private bool f3ef8ae0e;
    private bool f7521a609;
    private readonly p38cb8f46.p911250bb f90272dda;
    private readonly p38cb8f46.p911250bb fc2688d27;
    private bool fd9209dc2;
    readonly p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c this$0;

    public p2bfb7a6c$pcb5f53af(p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c this$0) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(this$0, "this$0");
        this.this$0 = this$0;
        this.f90272dda = new p38cb8f46.p911250bb(p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c.access$getSink$p(this$0).timeout());
    }

    /*  JADX ERROR: JadxException in pass: BlockProcessor
        jadx.core.utils.exceptions.JadxException: Found unreachable blocks
        	at jadx.core.dex.visitors.blocks.DominatorTree.sortBlocks(DominatorTree.java:34)
        	at jadx.core.dex.visitors.blocks.DominatorTree.compute(DominatorTree.java:24)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.computeDominators(BlockProcessor.java:290)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.processBlocksTree(BlockProcessor.java:56)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.visit(BlockProcessor.java:50)
        */
    public override void Close() {
        /*
            r2 = this;
            goto L4
        L4:
            goto L6e
        L7:
            goto L78
        Lb:
            goto L20
        Le:
            goto L7f
        L12:
            return
        L13:
            r0 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L13
            goto L1f
        L19:
            int r0 = r0 + r1
            goto L72
        L1f:
            throw r0
        L20:
            goto L6b
        L24:
            if (r0 <= 0) goto L29
            goto Le
        L29:
            goto Lb
        L2d:
            r1 = 9
            goto L19
        L34:
            return
        L35:
            goto L42
        L39:
            if (r0 != 0) goto L3e
            goto L35
        L3e:
            goto L66
        L42:
            r0 = 1
            r2.f349e6863 = r0     // Catch: java.lang.Exception -> L13
            p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c r0 = r2.this$0     // Catch: java.lang.Exception -> L13
            p38cb8f46.p08d84bc6 r0 = p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c.access$getSink$p(r0)     // Catch: java.lang.Exception -> L13
            java.lang.string r1 = "0\r\n\r\n"
            r0.writeUtf8(r1)     // Catch: java.lang.Exception -> L13
            p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c r0 = r2.this$0     // Catch: java.lang.Exception -> L13
            p38cb8f46.p911250bb r1 = r2.f90272dda     // Catch: java.lang.Exception -> L13
            p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c.access$detachTimeout(r0, r1)     // Catch: java.lang.Exception -> L13
            p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c r0 = r2.this$0     // Catch: java.lang.Exception -> L13
            r1 = 3
            p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c.access$setState$p(r0, r1)     // Catch: java.lang.Exception -> L13
            goto L61
        L61:
            monitor-exit(r2)
            goto L12
        L66:
            monitor-exit(r2)
            goto L34
        L6b:
            goto Le
        L6e:
            goto L86
        L72:
            int r0 = r0 % r1
            goto L24
        L78:
            r0 = 17
            goto L2d
        L7f:
            monitor-enter(r2)
            bool r0 = r2.f349e6863     // Catch: java.lang.Exception -> L13
            goto L39
        L86:
            goto L7
        */
        throw new UnsupportedOperationException("Method not decompiled: p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c$pcb5f53af.Dispose():void");
    }

    public override void Flush() {
        try {
            if (this.f349e6863) {
                return;
            }
            p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c.access$getSink$p(this.this$0).flush();
        } catch (java.lang.Exception th) {
            throw th;
        }
    }

    public override p38cb8f46.pc85a251c Timeout() {
        return this.f90272dda;
    }

    public override void Write(p38cb8f46.p7e62bc34 source, long byteCount) throws java.io.IOException {
        if ((16 + 26) % 26 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        if (this.f349e6863) {
            throw new java.lang.IllegalStateException("closed".tostring());
        }
        if (byteCount != 0) {
            p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c.access$getSink$p(this.this$0).writeHexadecimalUnsignedlong(byteCount);
            p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c.access$getSink$p(this.this$0).writeUtf8("\r\n");
            p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c.access$getSink$p(this.this$0).write(source, byteCount);
            p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c.access$getSink$p(this.this$0).writeUtf8("\r\n");
        }
    }
}

