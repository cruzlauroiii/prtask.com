namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000<\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010\u000b\n\u0002\b\b\bf\u0018\u00002\u00020\u0001J\u000e\u0010\u0002\u001a\u00020\u0003H¦@¢\u0006\u0002\u0010\u0004J\u0016\u0010\u0005\u001a\u00020\u00032\u0006\u0010\u0006\u001a\u00020\u0007H¦@¢\u0006\u0002\u0010\bJ\u000e\u0010\t\u001a\u00020\u0007H¦@¢\u0006\u0002\u0010\u0004J\u0016\u0010\n\u001a\u00020\u00032\u0006\u0010\u000b\u001a\u00020\fH¦@¢\u0006\u0002\u0010\rJ\u000e\u0010\u000e\u001a\u00020\u0003H¦@¢\u0006\u0002\u0010\u0004J\u0016\u0010\u000f\u001a\u00020\u00102\u0006\u0010\u0006\u001a\u00020\u0007H¦@¢\u0006\u0002\u0010\bJ\u0014\u0010\u0011\u001a\b\u0012\u0004\u0012\u00020\u00130\u0012H¦@¢\u0006\u0002\u0010\u0004J*\u0010\u0014\u001a\b\u0012\u0004\u0012\u00020\u00130\u00122\f\u0010\u0015\u001a\b\u0012\u0004\u0012\u00020\u00130\u00122\u0006\u0010\u000b\u001a\u00020\fH¦@¢\u0006\u0002\u0010\u0016J\u001c\u0010\u0017\u001a\u00020\u00182\f\u0010\u0015\u001a\b\u0012\u0004\u0012\u00020\u00130\u0012H¦@¢\u0006\u0002\u0010\u0019J\u0016\u0010\u001a\u001a\u00020\u00032\u0006\u0010\u001b\u001a\u00020\u0013H¦@¢\u0006\u0002\u0010\u001cJ\u0016\u0010\u001d\u001a\u00020\u00032\u0006\u0010\u001b\u001a\u00020\u0013H¦@¢\u0006\u0002\u0010\u001cJ\u000e\u0010\u001e\u001a\u00020\u0003H¦@¢\u0006\u0002\u0010\u0004J\u0016\u0010\u001f\u001a\u00020\u00032\u0006\u0010\u001b\u001a\u00020\u0013H¦@¢\u0006\u0002\u0010\u001c¨\u0006 "}, d2 = {"Lp10348936/pac143fb7/pd47d680b;", "", "createCurrentInventorization", "", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "saveCurrentInventorization", "currentInventorization", "Lp10348936/pf5e638cc/p0690dac5;", "(Lp10348936/pf5e638cc/p0690dac5;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getCurrentInventorization", "updateCurrentInventorizationStatus", "status", "Lp10348936/pf5e638cc/p14abd389;", "(Lp10348936/pf5e638cc/p14abd389;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "clearCurrentInventorizations", "createInventorizationReceipt", "Lpad5f82e8/p07214c67/p1e11b989/p9ded6185;", "getCurrentInventorizationPositions", "", "Lpad5f82e8/p07214c67/p1e11b989/pd031d465;", "getCurrentInventorizationRemainingPositions", "addedPositions", "(Ljava/util/List;Lp10348936/pf5e638cc/p14abd389;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "hasCurrentInventorizationRemainingPositions", "", "(Ljava/util/List;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "updateCurrentInventorizationPosition", "position", "(Lpad5f82e8/p07214c67/p1e11b989/pd031d465;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "addPositionToCurrentInventorization", "clearCurrentInventorizationPositions", "removeCurrentInventorizationPosition", "feature-inventorization-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface pd47d680b {
    java.lang.object addPositionToCurrentInventorization(pad5f82e8.p07214c67.p1e11b989.pd031d465 pd031d465Var, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object clearCurrentInventorizationPositions(kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object clearCurrentInventorizations(kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object createCurrentInventorization(kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object createInventorizationReceipt(p10348936.pf5e638cc.p0690dac5 p0690dac5Var, kotlin.coroutines.Continuation<pad5f82e8.p07214c67.p1e11b989.p9ded6185> continuation);

    java.lang.object getCurrentInventorization(kotlin.coroutines.Continuation<p10348936.pf5e638cc.p0690dac5> continuation);

    java.lang.object getCurrentInventorizationPositions(kotlin.coroutines.Continuation<? super java.util.List<pad5f82e8.p07214c67.p1e11b989.pd031d465>> continuation);

    java.lang.object getCurrentInventorizationRemainingPositions(java.util.List<pad5f82e8.p07214c67.p1e11b989.pd031d465> list, p10348936.pf5e638cc.p14abd389 p14abd389Var, kotlin.coroutines.Continuation<? super java.util.List<pad5f82e8.p07214c67.p1e11b989.pd031d465>> continuation);

    java.lang.object hasCurrentInventorizationRemainingPositions(java.util.List<pad5f82e8.p07214c67.p1e11b989.pd031d465> list, kotlin.coroutines.Continuation<java.lang.bool> continuation);

    java.lang.object removeCurrentInventorizationPosition(pad5f82e8.p07214c67.p1e11b989.pd031d465 pd031d465Var, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object saveCurrentInventorization(p10348936.pf5e638cc.p0690dac5 p0690dac5Var, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object updateCurrentInventorizationPosition(pad5f82e8.p07214c67.p1e11b989.pd031d465 pd031d465Var, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object updateCurrentInventorizationStatus(p10348936.pf5e638cc.p14abd389 p14abd389Var, kotlin.coroutines.Continuation<kotlin.Unit> continuation);
}

