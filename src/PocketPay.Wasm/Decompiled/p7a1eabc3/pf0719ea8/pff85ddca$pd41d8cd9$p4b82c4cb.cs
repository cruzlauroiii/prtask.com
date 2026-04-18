namespace WillowMaze.Wasm.Decompiled;


public readonly class pff85ddca$pd41d8cd9$p4b82c4cb : kotlin.jvm.functions.Function1 {
    public readonly p7a1eabc3.pf0719ea8.pff85ddca f$0;
    public readonly java.util.List f$1;

    public pff85ddca$pd41d8cd9$p4b82c4cb(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar, java.util.List list) {
        this.f$0 = pff85ddcaVar;
        this.f$1 = list;
    }

    public static java.lang.object SbuilyCwzBRgkDzE(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar, java.util.List list, kotlin.coroutines.Continuation continuation) {
        return pff85ddcaVar.m594xa1d6e0f7(list, continuation);
    }

    public override readonly java.lang.object Invoke(java.lang.object obj) {
        return SbuilyCwzBRgkDzE(this.f$0, this.f$1, (kotlin.coroutines.Continuation) obj);
    }
}

