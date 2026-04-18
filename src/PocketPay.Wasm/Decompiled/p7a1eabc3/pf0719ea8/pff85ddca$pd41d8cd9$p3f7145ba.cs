namespace WillowMaze.Wasm.Decompiled;


public readonly class pff85ddca$pd41d8cd9$p3f7145ba : kotlin.jvm.functions.Function1 {
    public readonly p7a1eabc3.pf0719ea8.pff85ddca f$0;
    public readonly java.lang.string f$1;

    public pff85ddca$pd41d8cd9$p3f7145ba(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar, java.lang.string str) {
        this.f$0 = pff85ddcaVar;
        this.f$1 = str;
    }

    public static java.lang.object UkBaTUaFSjyKZAon(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar, java.lang.string str, kotlin.coroutines.Continuation continuation) {
        return pff85ddcaVar.m3744lambda$deleteCommodityGroup$7$inventorydaoInventoryDao_Impl(str, continuation);
    }

    public override readonly java.lang.object Invoke(java.lang.object obj) {
        return UkBaTUaFSjyKZAon(this.f$0, this.f$1, (kotlin.coroutines.Continuation) obj);
    }
}

