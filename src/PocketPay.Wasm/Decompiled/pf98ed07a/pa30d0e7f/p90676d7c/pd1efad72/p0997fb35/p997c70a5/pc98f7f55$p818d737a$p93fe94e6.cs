namespace WillowMaze.Wasm.Decompiled;


readonly class pc98f7f55$p818d737a$p93fe94e6 : java.lang.Action {

    private readonly java.util.ICollection f92eb5ffe;
    private readonly java.util.ICollection fe2df891e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc98f7f55$p818d737a this$0;

    pc98f7f55$p818d737a$p93fe94e6(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc98f7f55$p818d737a pc98f7f55_p818d737a, U u) {
        this.this$0 = pc98f7f55_p818d737a;
        this.f92eb5ffe = u;
    }

    public static void MdiZzodDAGZNtaOO(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc98f7f55$p818d737a pc98f7f55_p818d737a, java.lang.object obj, bool z, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc98f7f55$p818d737a.mf23e8626(pc98f7f55_p818d737a, obj, z, p7beea252Var);
    }

    public static bool VcXXulzRscKVNCZA(java.util.List list, java.lang.object obj) {
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
            goto L64
        L4:
            goto L73
        L7:
            goto L39
        Lb:
            r1 = 0
            goto L4f
        L10:
            int r0 = r0 + r1
            goto L16
        L16:
            int r0 = r0 % r1
            goto L29
        L1c:
            return
        L1d:
            r3 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L1d
            goto L6b
        L23:
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc98f7f55$p818d737a r0 = r3.this$0
            goto L55
        L29:
            if (r0 <= 0) goto L2e
            goto L73
        L2e:
            goto L70
        L32:
            r1 = 31
            goto L10
        L39:
            goto L67
        L3c:
            java.util.ICollection r3 = r3.f92eb5ffe
            goto Lb
        L42:
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc98f7f55$p818d737a r0 = r3.this$0
            goto L3c
        L48:
            r0 = 27
            goto L32
        L4f:
            io.reactivex.rxjava3.core.Scheduler$Worker r2 = r0.ff1290186
            goto L77
        L55:
            monitor-enter(r0)
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc98f7f55$p818d737a r1 = r3.this$0     // Catch: java.lang.Exception -> L1d
            java.util.List<U : java.util.ICollection<T>> r1 = r1.f4d293ef2     // Catch: java.lang.Exception -> L1d
            java.util.ICollection r2 = r3.f92eb5ffe     // Catch: java.lang.Exception -> L1d
            vcXXulzRscKVNCZA(r1, r2)     // Catch: java.lang.Exception -> L1d
            monitor-exit(r0)     // Catch: java.lang.Exception -> L1d
            goto L42
        L64:
            goto L7
        L67:
            goto L48
        L6b:
            throw r3
        L6c:
            goto L4
        L70:
            goto L6c
        L73:
            goto L23
        L77:
            MdiZzodDAGZNtaOO(r0, r3, r1, r2)
            goto L1c
        */
        throw new UnsupportedOperationException("Method not decompiled: pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc98f7f55$p818d737a$p93fe94e6.run():void");
    }
}

