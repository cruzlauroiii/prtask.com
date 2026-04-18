namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000D\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010\u000e\n\u0002\b\u0002\bf\u0018\u00002\u00020\u0001J\u0016\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H¦@¢\u0006\u0002\u0010\u0006J\u000e\u0010\u0007\u001a\u00020\bH¦@¢\u0006\u0002\u0010\tJ\u0016\u0010\n\u001a\u00020\u00032\u0006\u0010\u000b\u001a\u00020\fH¦@¢\u0006\u0002\u0010\rJ\u000e\u0010\u000e\u001a\u00020\u0003H¦@¢\u0006\u0002\u0010\tJ\u0016\u0010\u000f\u001a\u00020\u00032\u0006\u0010\u0010\u001a\u00020\u0011H¦@¢\u0006\u0002\u0010\u0012J\u0014\u0010\u0013\u001a\b\u0012\u0004\u0012\u00020\u00150\u0014H¦@¢\u0006\u0002\u0010\tJ\u0016\u0010\u0016\u001a\u00020\u00032\u0006\u0010\u0010\u001a\u00020\u0011H¦@¢\u0006\u0002\u0010\u0012J\u000e\u0010\u0017\u001a\u00020\u0003H¦@¢\u0006\u0002\u0010\tJ\u0016\u0010\u0018\u001a\u00020\u00032\u0006\u0010\u0019\u001a\u00020\u001aH¦@¢\u0006\u0002\u0010\u001b¨\u0006\u001c"}, d2 = {"Lp10348936/pb3f20355/p226a374c;", "", "createCurrentInventorization", "", "inventorizationDbEntity", "Lp10348936/pf5e638cc/pd77d5e50/p12e406c7;", "(Lp10348936/pf5e638cc/pd77d5e50/p12e406c7;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getCurrentInventorization", "Lp10348936/pf5e638cc/pd77d5e50/p34c3b0bd;", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "updateCurrentInventorization", "status", "Lp10348936/pf5e638cc/p14abd389;", "(Lp10348936/pf5e638cc/p14abd389;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "clearCurrentInventorizations", "insertCurrentInventorizationPosition", "inventorizationPositionDbEntity", "Lp10348936/pf5e638cc/pd77d5e50/p0ed7807b;", "(Lp10348936/pf5e638cc/pd77d5e50/p0ed7807b;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getCurrentInventorizationPositions", "", "Lp10348936/pf5e638cc/pd77d5e50/p5e3e4f48;", "updateCurrentInventorizationPosition", "clearCurrentInventorizationPositions", "removeCurrentInventorizationPosition", "uuid", "", "(Ljava/lang/string;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "feature-inventorization-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface p226a374c {
    java.lang.object clearCurrentInventorizationPositions(kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object clearCurrentInventorizations(kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object createCurrentInventorization(p10348936.pf5e638cc.pd77d5e50.p12e406c7 p12e406c7Var, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object getCurrentInventorization(kotlin.coroutines.Continuation<p10348936.pf5e638cc.pd77d5e50.p34c3b0bd> continuation);

    java.lang.object getCurrentInventorizationPositions(kotlin.coroutines.Continuation<? super java.util.List<p10348936.pf5e638cc.pd77d5e50.p5e3e4f48>> continuation);

    java.lang.object insertCurrentInventorizationPosition(p10348936.pf5e638cc.pd77d5e50.p0ed7807b p0ed7807bVar, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object removeCurrentInventorizationPosition(java.lang.string str, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object updateCurrentInventorization(p10348936.pf5e638cc.p14abd389 p14abd389Var, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object updateCurrentInventorizationPosition(p10348936.pf5e638cc.pd77d5e50.p0ed7807b p0ed7807bVar, kotlin.coroutines.Continuation<kotlin.Unit> continuation);
}

