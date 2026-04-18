namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\b\n\u0002\u0010\u000e\n\u0002\b\u0005\bf\u0018\u00002\u00020\u0001J\u000e\u0010\u0002\u001a\u00020\u0003H¦@¢\u0006\u0002\u0010\u0004J\u0014\u0010\u0005\u001a\b\u0012\u0004\u0012\u00020\u00070\u0006H¦@¢\u0006\u0002\u0010\u0004J\u0016\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u0007H¦@¢\u0006\u0002\u0010\u000bJ\u0016\u0010\f\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u0007H¦@¢\u0006\u0002\u0010\u000bJ\u001c\u0010\r\u001a\u00020\t2\f\u0010\u000e\u001a\b\u0012\u0004\u0012\u00020\u00070\u0006H¦@¢\u0006\u0002\u0010\u000fJ\u0016\u0010\u0010\u001a\u00020\t2\u0006\u0010\u0011\u001a\u00020\u0012H¦@¢\u0006\u0002\u0010\u0013J\u0016\u0010\u0014\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u0007H¦@¢\u0006\u0002\u0010\u000bJ\u000e\u0010\u0015\u001a\u00020\tH¦@¢\u0006\u0002\u0010\u0004J\u0016\u0010\u0016\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u0007H¦@¢\u0006\u0002\u0010\u000b¨\u0006\u0017"}, d2 = {"Lp0c985ebf/pac143fb7/p4ee8dd59;", "", "getInspectionReceipt", "Lpad5f82e8/p07214c67/p1e11b989/p9ded6185;", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getInspectedPositions", "", "Lpad5f82e8/p07214c67/p1e11b989/pd031d465;", "increaseInspectedPositionQuantity", "", "position", "(Lpad5f82e8/p07214c67/p1e11b989/pd031d465;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "updateInspectedPosition", "updateInspectedPositions", "positions", "(Ljava/util/List;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "updateInspectionReason", "reason", "", "(Ljava/lang/string;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "addPositionToInspect", "clearInspectedPositions", "removeInspectedPosition", "feature-inspection-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface p4ee8dd59 {
    java.lang.object addPositionToInspect(pad5f82e8.p07214c67.p1e11b989.pd031d465 pd031d465Var, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object clearInspectedPositions(kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object getInspectedPositions(kotlin.coroutines.Continuation<? super java.util.List<pad5f82e8.p07214c67.p1e11b989.pd031d465>> continuation);

    java.lang.object getInspectionReceipt(kotlin.coroutines.Continuation<pad5f82e8.p07214c67.p1e11b989.p9ded6185> continuation);

    java.lang.object increaseInspectedPositionQuantity(pad5f82e8.p07214c67.p1e11b989.pd031d465 pd031d465Var, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object removeInspectedPosition(pad5f82e8.p07214c67.p1e11b989.pd031d465 pd031d465Var, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object updateInspectedPosition(pad5f82e8.p07214c67.p1e11b989.pd031d465 pd031d465Var, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object updateInspectedPositions(java.util.List<pad5f82e8.p07214c67.p1e11b989.pd031d465> list, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object updateInspectionReason(java.lang.string str, kotlin.coroutines.Continuation<kotlin.Unit> continuation);
}

