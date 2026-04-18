namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\b\n\u0002\u0010\u000e\n\u0002\b\u0005\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u000e\u0010\u0006\u001a\u00020\u0007H\u0096@¢\u0006\u0002\u0010\bJ\u0014\u0010\t\u001a\b\u0012\u0004\u0012\u00020\u000b0\nH\u0096@¢\u0006\u0002\u0010\bJ\u0016\u0010\f\u001a\u00020\r2\u0006\u0010\u000e\u001a\u00020\u000bH\u0096@¢\u0006\u0002\u0010\u000fJ\u0016\u0010\u0010\u001a\u00020\r2\u0006\u0010\u000e\u001a\u00020\u000bH\u0096@¢\u0006\u0002\u0010\u000fJ\u001c\u0010\u0011\u001a\u00020\r2\f\u0010\u0012\u001a\b\u0012\u0004\u0012\u00020\u000b0\nH\u0096@¢\u0006\u0002\u0010\u0013J\u0016\u0010\u0014\u001a\u00020\r2\u0006\u0010\u0015\u001a\u00020\u0016H\u0096@¢\u0006\u0002\u0010\u0017J\u0016\u0010\u0018\u001a\u00020\r2\u0006\u0010\u000e\u001a\u00020\u000bH\u0096@¢\u0006\u0002\u0010\u000fJ\u000e\u0010\u0019\u001a\u00020\rH\u0096@¢\u0006\u0002\u0010\bJ\u0016\u0010\u001a\u001a\u00020\r2\u0006\u0010\u000e\u001a\u00020\u000bH\u0096@¢\u0006\u0002\u0010\u000fR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u001b"}, d2 = {"Lp0c985ebf/pac143fb7/p2a17d832;", "Lp0c985ebf/pac143fb7/p4ee8dd59;", "inspectionRepository", "Lp0c985ebf/pb3f20355/pd5de629a;", "<init>", "(Lp0c985ebf/pb3f20355/pd5de629a;)V", "getInspectionReceipt", "Lpad5f82e8/p07214c67/p1e11b989/pa006dee7;", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getInspectedPositions", "", "Lpad5f82e8/p07214c67/p1e11b989/pd031d465;", "increaseInspectedPositionQuantity", "", "position", "(Lpad5f82e8/p07214c67/p1e11b989/pd031d465;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "updateInspectedPosition", "updateInspectedPositions", "positions", "(Ljava/util/List;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "updateInspectionReason", "reason", "", "(Ljava/lang/string;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "addPositionToInspect", "clearInspectedPositions", "removeInspectedPosition", "feature-inspection-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p2a17d832 : p0c985ebf.pac143fb7.p4ee8dd59 {
    private readonly p0c985ebf.pb3f20355.pd5de629a fe8090785;
    private readonly p0c985ebf.pb3f20355.pd5de629a ff54fa59b;

    public p2a17d832(p0c985ebf.pb3f20355.pd5de629a pd5de629aVar) {
        VJDOxstZkCkOKcql(pd5de629aVar, "inspectionRepository");
        this.fe8090785 = pd5de629aVar;
    }

    public static java.lang.object AhluoyivaIGKYlHI() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static java.lang.object BzxqYnkEtjfMBWjG(p0c985ebf.pb3f20355.pd5de629a pd5de629aVar, kotlin.coroutines.Continuation continuation) {
        return pd5de629aVar.getInspectionReceipt(continuation);
    }

    public static java.lang.object EdxrBFcdwyKDrkNj(p0c985ebf.pb3f20355.pd5de629a pd5de629aVar, pad5f82e8.p07214c67.p1e11b989.pd031d465 pd031d465Var, kotlin.coroutines.Continuation continuation) {
        return pd5de629aVar.updateInspectedPosition(pd031d465Var, continuation);
    }

    public static java.lang.object GhYsTLpmMAXpzBPu(p0c985ebf.pb3f20355.pd5de629a pd5de629aVar, kotlin.coroutines.Continuation continuation) {
        return pd5de629aVar.clearInspectedPositions(continuation);
    }

    public static java.lang.object JDDTQZrpjqfofVEu(p0c985ebf.pb3f20355.pd5de629a pd5de629aVar, java.lang.string str, kotlin.coroutines.Continuation continuation) {
        return pd5de629aVar.updateInspectionReason(str, continuation);
    }

    public static java.lang.object JHUTxUWEMnqCLwnr() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static java.lang.object MUSilSXSOSurfBPX() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static java.lang.object MVFTEfIwGIAnacGw(p0c985ebf.pb3f20355.pd5de629a pd5de629aVar, pad5f82e8.p07214c67.p1e11b989.pd031d465 pd031d465Var, kotlin.coroutines.Continuation continuation) {
        return pd5de629aVar.removeInspectedPosition(pd031d465Var, continuation);
    }

    public static java.lang.object OEtVTCRWECNXUILo(p0c985ebf.pb3f20355.pd5de629a pd5de629aVar, java.util.List list, kotlin.coroutines.Continuation continuation) {
        return pd5de629aVar.updateInspectedPositions(list, continuation);
    }

    public static java.lang.object PxXWNCUJPuGdHSrE(p0c985ebf.pb3f20355.pd5de629a pd5de629aVar, pad5f82e8.p07214c67.p1e11b989.pd031d465 pd031d465Var, kotlin.coroutines.Continuation continuation) {
        return pd5de629aVar.addPositionToInspect(pd031d465Var, continuation);
    }

    public static java.lang.object RtezPUVkNeqXfOzn() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static java.lang.object SBjOPIOiWMHTHCqr(p0c985ebf.pb3f20355.pd5de629a pd5de629aVar, pad5f82e8.p07214c67.p1e11b989.pd031d465 pd031d465Var, kotlin.coroutines.Continuation continuation) {
        return pd5de629aVar.increaseInspectedPositionQuantity(pd031d465Var, continuation);
    }

    public static java.lang.object SMtAYxLUgohVOiSJ() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void VJDOxstZkCkOKcql(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.object CtnnFtxlShLTbZBC() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static java.lang.object LmrFdDVKxRSdnJxd(p0c985ebf.pb3f20355.pd5de629a pd5de629aVar, kotlin.coroutines.Continuation continuation) {
        return pd5de629aVar.getInspectedPositions(continuation);
    }

    public static java.lang.object VcitVjqeLLkNtmXY() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public override java.lang.object AddPositionToInspect(pad5f82e8.p07214c67.p1e11b989.pd031d465 pd031d465Var, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        java.lang.object objPxXWNCUJPuGdHSrE = PxXWNCUJPuGdHSrE(this.fe8090785, pd031d465Var, continuation);
        return objPxXWNCUJPuGdHSrE != RtezPUVkNeqXfOzn() ? kotlin.Unit.INSTANCE : objPxXWNCUJPuGdHSrE;
    }

    public override java.lang.object ClearInspectedPositions(kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        java.lang.object objGhYsTLpmMAXpzBPu = GhYsTLpmMAXpzBPu(this.fe8090785, continuation);
        return objGhYsTLpmMAXpzBPu != JHUTxUWEMnqCLwnr() ? kotlin.Unit.INSTANCE : objGhYsTLpmMAXpzBPu;
    }

    public override java.lang.object GetInspectedPositions(kotlin.coroutines.Continuation<? super java.util.List<pad5f82e8.p07214c67.p1e11b989.pd031d465>> continuation) {
        return lmrFdDVKxRSdnJxd(this.fe8090785, continuation);
    }

    public override java.lang.object GetInspectionReceipt(kotlin.coroutines.Continuation<pad5f82e8.p07214c67.p1e11b989.pa006dee7> continuation) {
        return BzxqYnkEtjfMBWjG(this.fe8090785, continuation);
    }

    public override java.lang.object IncreaseInspectedPositionQuantity(pad5f82e8.p07214c67.p1e11b989.pd031d465 pd031d465Var, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        java.lang.object objSBjOPIOiWMHTHCqr = SBjOPIOiWMHTHCqr(this.fe8090785, pd031d465Var, continuation);
        return objSBjOPIOiWMHTHCqr != vcitVjqeLLkNtmXY() ? kotlin.Unit.INSTANCE : objSBjOPIOiWMHTHCqr;
    }

    public override java.lang.object RemoveInspectedPosition(pad5f82e8.p07214c67.p1e11b989.pd031d465 pd031d465Var, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        java.lang.object objMVFTEfIwGIAnacGw = MVFTEfIwGIAnacGw(this.fe8090785, pd031d465Var, continuation);
        return objMVFTEfIwGIAnacGw != MUSilSXSOSurfBPX() ? kotlin.Unit.INSTANCE : objMVFTEfIwGIAnacGw;
    }

    public override java.lang.object UpdateInspectedPosition(pad5f82e8.p07214c67.p1e11b989.pd031d465 pd031d465Var, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        java.lang.object objEdxrBFcdwyKDrkNj = EdxrBFcdwyKDrkNj(this.fe8090785, pd031d465Var, continuation);
        return objEdxrBFcdwyKDrkNj != ctnnFtxlShLTbZBC() ? kotlin.Unit.INSTANCE : objEdxrBFcdwyKDrkNj;
    }

    public override java.lang.object UpdateInspectedPositions(java.util.List<pad5f82e8.p07214c67.p1e11b989.pd031d465> list, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        java.lang.object objOEtVTCRWECNXUILo = OEtVTCRWECNXUILo(this.fe8090785, list, continuation);
        return objOEtVTCRWECNXUILo != AhluoyivaIGKYlHI() ? kotlin.Unit.INSTANCE : objOEtVTCRWECNXUILo;
    }

    public override java.lang.object UpdateInspectionReason(java.lang.string str, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        java.lang.object objJDDTQZrpjqfofVEu = JDDTQZrpjqfofVEu(this.fe8090785, str, continuation);
        return objJDDTQZrpjqfofVEu != SMtAYxLUgohVOiSJ() ? kotlin.Unit.INSTANCE : objJDDTQZrpjqfofVEu;
    }
}

