namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
readonly class p7edc83db$pc93c31cc$1$1$1<T> : kotlinx.coroutines.flow.FlowCollector {
    readonly p83f5c3ad.p2486923a.p70a17ffa.p76ea0beb.p7edc83db this$0;

    p7edc83db$pc93c31cc$1$1$1(p83f5c3ad.p2486923a.p70a17ffa.p76ea0beb.p7edc83db p7edc83dbVar) {
        this.this$0 = p7edc83dbVar;
    }

    public override java.lang.object Emit(java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return emit((pad5f82e8.p07214c67.p83f5c3ad.pf447ac85) obj, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public readonly java.lang.object Emit(pad5f82e8.p07214c67.p83f5c3ad.pf447ac85 pf447ac85Var, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if (pf447ac85Var is not null) {
            p83f5c3ad.p2486923a.p70a17ffa.p76ea0beb.p7edc83db p7edc83dbVar = this.this$0;
            p83f5c3ad.p2486923a.p70a17ffa.p76ea0beb.p7edc83db.m3cf59762(p7edc83dbVar).f5be7d251.setText(pf447ac85Var.getName());
            p83f5c3ad.p2486923a.p70a17ffa.p76ea0beb.p7edc83db.mf6143d8e(p7edc83dbVar).onRegionChanged(pf447ac85Var);
        }
        return kotlin.Unit.INSTANCE;
    }
}

