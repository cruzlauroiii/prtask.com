namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\bf\u0018\u00002\u00020\u0001J$\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\f\u0010\u0006\u001a\b\u0012\u0004\u0012\u00020\b0\u0007H¦@¢\u0006\u0002\u0010\tJ\u0014\u0010\n\u001a\b\u0012\u0004\u0012\u00020\u000b0\u0007H¦@¢\u0006\u0002\u0010\fJ\u000e\u0010\r\u001a\u00020\u000eH¦@¢\u0006\u0002\u0010\f¨\u0006\u000f"}, d2 = {"Lp10348936/pb3f20355/pba03ea40;", "", "saveInventorization", "", "inventorizationDbEntity", "Lp10348936/pf5e638cc/pd77d5e50/p4582d01f;", "inventorizationPositionDbEntities", "", "Lp10348936/pf5e638cc/pd77d5e50/p555020e1;", "(Lp10348936/pf5e638cc/pd77d5e50/p4582d01f;Ljava/util/List;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getInventorizations", "Lp10348936/pf5e638cc/pd77d5e50/p649d38da;", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getLastInventorizationNumber", "", "feature-inventorization-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface pba03ea40 {
    java.lang.object getInventorizations(kotlin.coroutines.Continuation<? super java.util.List<p10348936.pf5e638cc.pd77d5e50.p649d38da>> continuation);

    java.lang.object getLastInventorizationNumber(kotlin.coroutines.Continuation<java.lang.int> continuation);

    java.lang.object saveInventorization(p10348936.pf5e638cc.pd77d5e50.p4582d01f p4582d01fVar, java.util.List<p10348936.pf5e638cc.pd77d5e50.p555020e1> list, kotlin.coroutines.Continuation<kotlin.Unit> continuation);
}

