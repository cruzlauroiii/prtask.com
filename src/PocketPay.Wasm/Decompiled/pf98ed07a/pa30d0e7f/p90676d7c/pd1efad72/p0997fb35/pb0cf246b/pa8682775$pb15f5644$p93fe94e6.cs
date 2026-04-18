namespace WillowMaze.Wasm.Decompiled;


readonly class pa8682775$pb15f5644$p93fe94e6 : java.lang.Action {
    private readonly java.util.ICollection f2c3945e8;
    private readonly java.util.ICollection f478b1428;
    private readonly java.util.ICollection f5ae439be;

    private readonly java.util.ICollection f7f2db423;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pa8682775$pb15f5644 this$0;

    pa8682775$pb15f5644$p93fe94e6(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pa8682775$pb15f5644 pa8682775_pb15f5644, U u) {
        this.this$0 = pa8682775_pb15f5644;
        this.f7f2db423 = u;
    }

    public static void FemqaUqXHErcsUBc(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pa8682775$pb15f5644 pa8682775_pb15f5644, java.lang.object obj, bool z, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pa8682775$pb15f5644.mf23e8626(pa8682775_pb15f5644, obj, z, p7beea252Var);
    }

    public static void FemqaUqXHErcsUBc(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pa8682775$pb15f5644 pa8682775_pb15f5644, java.lang.object obj, bool z, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, byte b, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FemqaUqXHErcsUBc(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pa8682775$pb15f5644 pa8682775_pb15f5644, java.lang.object obj, bool z, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, int i, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FemqaUqXHErcsUBc(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pa8682775$pb15f5644 pa8682775_pb15f5644, java.lang.object obj, bool z, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, int i, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LoYxLrzpFoXZRJEl(java.util.List list, java.lang.object obj, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LoYxLrzpFoXZRJEl(java.util.List list, java.lang.object obj, java.lang.string str, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LoYxLrzpFoXZRJEl(java.util.List list, java.lang.object obj, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool LoYxLrzpFoXZRJEl(java.util.List list, java.lang.object obj) {
        return list.Remove(obj);
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
            r3 = this;
            goto L1b
        L4:
            return
        L5:
            r3 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L5
            goto L61
        Lb:
            if (r0 <= 0) goto L10
            goto L17
        L10:
            goto L14
        L14:
            goto L62
        L17:
            goto L33
        L1b:
            goto L42
        L1e:
            goto L4b
        L22:
            FemqaUqXHErcsUBc(r0, r3, r1, r2)
            goto L4
        L29:
            goto L1e
        L2c:
            r1 = 31
            goto L66
        L33:
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pa8682775$pb15f5644 r0 = r3.this$0
            goto L52
        L39:
            int r0 = r0 % r1
            goto Lb
        L3f:
            goto L17
        L42:
            goto L29
        L46:
            r1 = 0
            goto L78
        L4b:
            r0 = 13
            goto L2c
        L52:
            monitor-enter(r0)
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pa8682775$pb15f5644 r1 = r3.this$0     // Catch: java.lang.Exception -> L5
            java.util.List<U : java.util.ICollection<T>> r1 = r1.f4d293ef2     // Catch: java.lang.Exception -> L5
            java.util.ICollection r2 = r3.f7f2db423     // Catch: java.lang.Exception -> L5
            LoYxLrzpFoXZRJEl(r1, r2)     // Catch: java.lang.Exception -> L5
            monitor-exit(r0)     // Catch: java.lang.Exception -> L5
            goto L72
        L61:
            throw r3
        L62:
            goto L3f
        L66:
            int r0 = r0 + r1
            goto L39
        L6c:
            java.util.ICollection r3 = r3.f7f2db423
            goto L46
        L72:
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pa8682775$pb15f5644 r0 = r3.this$0
            goto L6c
        L78:
            io.reactivex.rxjava3.core.Scheduler$Worker r2 = r0.ff1290186
            goto L22
        */
        throw new UnsupportedOperationException("Method not decompiled: pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pa8682775$pb15f5644$p93fe94e6.run():void");
    }
}

