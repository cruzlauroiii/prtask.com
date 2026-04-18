namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\b\n\u0002\u0018\u0002\n\u0002\b\u0002\bf\u0018\u00002\u00020\u0001J\u0016\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H¦@¢\u0006\u0002\u0010\u0006J\u0016\u0010\u0007\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H¦@¢\u0006\u0002\u0010\u0006J\u0010\u0010\b\u001a\u0004\u0018\u00010\u0005H¦@¢\u0006\u0002\u0010\tJ\u0014\u0010\n\u001a\b\u0012\u0004\u0012\u00020\f0\u000bH¦@¢\u0006\u0002\u0010\tJ\u0016\u0010\r\u001a\u00020\u00032\u0006\u0010\u000e\u001a\u00020\u000fH¦@¢\u0006\u0002\u0010\u0010J\u0016\u0010\u0011\u001a\u00020\u00032\u0006\u0010\u000e\u001a\u00020\u000fH¦@¢\u0006\u0002\u0010\u0010J\u001c\u0010\u0012\u001a\u00020\u00032\f\u0010\u0013\u001a\b\u0012\u0004\u0012\u00020\u000f0\u000bH¦@¢\u0006\u0002\u0010\u0014J\u000e\u0010\u0015\u001a\u00020\u0003H¦@¢\u0006\u0002\u0010\tJ\u0016\u0010\u0016\u001a\u00020\u00032\u0006\u0010\u0017\u001a\u00020\u0018H¦@¢\u0006\u0002\u0010\u0019¨\u0006\u001a"}, d2 = {"Lp0c985ebf/pb3f20355/pf2a867be;", "", "createInspection", "", "inspectionDbEntity", "Lp0c985ebf/p07214c67/pd77d5e50/pf7c281bf;", "(Lp0c985ebf/p07214c67/pd77d5e50/pf7c281bf;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "updateInspection", "getInspection", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getInspectionPositions", "", "Lp0c985ebf/p07214c67/pd77d5e50/p47704a69;", "insertInspectionPosition", "currentInspectionPositionDbEntity", "Lp0c985ebf/p07214c67/pd77d5e50/p1aa865ba;", "(Lp0c985ebf/p07214c67/pd77d5e50/p1aa865ba;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "updateInspectionPosition", "updateInspectionPositions", "currentInspectionPositionDbEntities", "(Ljava/util/List;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "clearInspectedPositions", "removeInspectedPosition", "position", "Lpad5f82e8/p07214c67/p1e11b989/pd031d465;", "(Lpad5f82e8/p07214c67/p1e11b989/pd031d465;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "feature-inspection-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface pf2a867be {
    java.lang.object clearInspectedPositions(kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object createInspection(p0c985ebf.p07214c67.pd77d5e50.pf7c281bf pf7c281bfVar, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object getInspection(kotlin.coroutines.Continuation<p0c985ebf.p07214c67.pd77d5e50.pf7c281bf> continuation);

    java.lang.object getInspectionPositions(kotlin.coroutines.Continuation<? super java.util.List<p0c985ebf.p07214c67.pd77d5e50.p47704a69>> continuation);

    java.lang.object insertInspectionPosition(p0c985ebf.p07214c67.pd77d5e50.p1aa865ba p1aa865baVar, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object removeInspectedPosition(pad5f82e8.p07214c67.p1e11b989.pd031d465 pd031d465Var, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object updateInspection(p0c985ebf.p07214c67.pd77d5e50.pf7c281bf pf7c281bfVar, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object updateInspectionPosition(p0c985ebf.p07214c67.pd77d5e50.p1aa865ba p1aa865baVar, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object updateInspectionPositions(java.util.List<p0c985ebf.p07214c67.pd77d5e50.p1aa865ba> list, kotlin.coroutines.Continuation<kotlin.Unit> continuation);
}

