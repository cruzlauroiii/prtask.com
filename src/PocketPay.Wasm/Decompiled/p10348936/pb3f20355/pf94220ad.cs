namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00008\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010 \n\u0002\b\u0005\bf\u0018\u00002\u00020\u0001J\u0016\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H¦@¢\u0006\u0002\u0010\u0006J\u000e\u0010\u0007\u001a\u00020\bH¦@¢\u0006\u0002\u0010\tJ\u0016\u0010\n\u001a\u00020\u00032\u0006\u0010\u000b\u001a\u00020\fH¦@¢\u0006\u0002\u0010\rJ\u000e\u0010\u000e\u001a\u00020\u0003H¦@¢\u0006\u0002\u0010\tJ\u0016\u0010\u000f\u001a\u00020\u00032\u0006\u0010\u0010\u001a\u00020\u0011H¦@¢\u0006\u0002\u0010\u0012J\u0014\u0010\u0013\u001a\b\u0012\u0004\u0012\u00020\u00110\u0014H¦@¢\u0006\u0002\u0010\tJ\u0016\u0010\u0015\u001a\u00020\u00032\u0006\u0010\u0010\u001a\u00020\u0011H¦@¢\u0006\u0002\u0010\u0012J\u000e\u0010\u0016\u001a\u00020\u0003H¦@¢\u0006\u0002\u0010\tJ\u0016\u0010\u0017\u001a\u00020\u00032\u0006\u0010\u0018\u001a\u00020\u0005H¦@¢\u0006\u0002\u0010\u0006¨\u0006\u0019"}, d2 = {"Lp10348936/pb3f20355/pf94220ad;", "", "createCurrentInventorization", "", "employeeId", "", "(Ljava/lang/string;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getCurrentInventorization", "Lp10348936/pf5e638cc/p0690dac5;", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "updateCurrentInventorizationStatus", "status", "Lp10348936/pf5e638cc/p14abd389;", "(Lp10348936/pf5e638cc/p14abd389;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "clearCurrentInventorizations", "addPositionToCurrentInventorization", "position", "Lpad5f82e8/p07214c67/p1e11b989/pd031d465;", "(Lpad5f82e8/p07214c67/p1e11b989/pd031d465;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getCurrentInventorizationPositions", "", "updateCurrentInventorizationPosition", "clearCurrentInventorizationPositions", "removeCurrentInventorizationPosition", "uuid", "feature-inventorization-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface pf94220ad {
    java.lang.object addPositionToCurrentInventorization(pad5f82e8.p07214c67.p1e11b989.pd031d465 pd031d465Var, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object clearCurrentInventorizationPositions(kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object clearCurrentInventorizations(kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object createCurrentInventorization(java.lang.string str, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object getCurrentInventorization(kotlin.coroutines.Continuation<p10348936.pf5e638cc.p0690dac5> continuation);

    java.lang.object getCurrentInventorizationPositions(kotlin.coroutines.Continuation<? super java.util.List<pad5f82e8.p07214c67.p1e11b989.pd031d465>> continuation);

    java.lang.object removeCurrentInventorizationPosition(java.lang.string str, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object updateCurrentInventorizationPosition(pad5f82e8.p07214c67.p1e11b989.pd031d465 pd031d465Var, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object updateCurrentInventorizationStatus(p10348936.pf5e638cc.p14abd389 p14abd389Var, kotlin.coroutines.Continuation<kotlin.Unit> continuation);
}

