namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000<\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\b\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u0016\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\tH\u0096@¢\u0006\u0002\u0010\nJ\u0016\u0010\u000b\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\tH\u0096@¢\u0006\u0002\u0010\nJ\u0010\u0010\f\u001a\u0004\u0018\u00010\tH\u0096@¢\u0006\u0002\u0010\rJ\u0014\u0010\u000e\u001a\b\u0012\u0004\u0012\u00020\u00100\u000fH\u0096@¢\u0006\u0002\u0010\rJ\u0016\u0010\u0011\u001a\u00020\u00072\u0006\u0010\u0012\u001a\u00020\u0013H\u0096@¢\u0006\u0002\u0010\u0014J\u0016\u0010\u0015\u001a\u00020\u00072\u0006\u0010\u0012\u001a\u00020\u0013H\u0096@¢\u0006\u0002\u0010\u0014J\u001c\u0010\u0016\u001a\u00020\u00072\f\u0010\u0017\u001a\b\u0012\u0004\u0012\u00020\u00130\u000fH\u0096@¢\u0006\u0002\u0010\u0018J\u000e\u0010\u0019\u001a\u00020\u0007H\u0096@¢\u0006\u0002\u0010\rJ\u0016\u0010\u001a\u001a\u00020\u00072\u0006\u0010\u001b\u001a\u00020\u001cH\u0096@¢\u0006\u0002\u0010\u001dR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u001e"}, d2 = {"Lp0c985ebf/pb3f20355/p18e71f72;", "Lp0c985ebf/pb3f20355/pf2a867be;", "inspectionDao", "Lp0c985ebf/pf0719ea8/p5ca98722;", "<init>", "(Lp0c985ebf/pf0719ea8/p5ca98722;)V", "createInspection", "", "inspectionDbEntity", "Lp0c985ebf/p07214c67/pd77d5e50/pf7c281bf;", "(Lp0c985ebf/p07214c67/pd77d5e50/pf7c281bf;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "updateInspection", "getInspection", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getInspectionPositions", "", "Lp0c985ebf/p07214c67/pd77d5e50/p47704a69;", "insertInspectionPosition", "currentInspectionPositionDbEntity", "Lp0c985ebf/p07214c67/pd77d5e50/p1aa865ba;", "(Lp0c985ebf/p07214c67/pd77d5e50/p1aa865ba;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "updateInspectionPosition", "updateInspectionPositions", "currentInspectionPositionDbEntities", "(Ljava/util/List;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "clearInspectedPositions", "removeInspectedPosition", "position", "Lpad5f82e8/p07214c67/p1e11b989/pd031d465;", "(Lpad5f82e8/p07214c67/p1e11b989/pd031d465;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "feature-inspection-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p18e71f72 : p0c985ebf.pb3f20355.pf2a867be {
    private readonly p0c985ebf.pf0719ea8.p5ca98722 f58353d27;
    private readonly p0c985ebf.pf0719ea8.p5ca98722 f9cea3d8d;
    private readonly p0c985ebf.pf0719ea8.p5ca98722 fa9787085;
    private readonly p0c985ebf.pf0719ea8.p5ca98722 fe994e145;

    public p18e71f72(p0c985ebf.pf0719ea8.p5ca98722 p5ca98722Var) {
        rGVjJZqczkqPmkHd(p5ca98722Var, "inspectionDao");
        this.f9cea3d8d = p5ca98722Var;
    }

    public static java.lang.object EkmAnABlmMkZLIXm() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static java.lang.string GjsKejbkcxwdzCor(pad5f82e8.p07214c67.p1e11b989.pd031d465 pd031d465Var) {
        return pd031d465Var.getUuid();
    }

    public static java.lang.object HDuHuIVcgpsEAByv() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static java.lang.object ICkmIPHuppfBXhaN(p0c985ebf.pf0719ea8.p5ca98722 p5ca98722Var, kotlin.coroutines.Continuation continuation) {
        return p5ca98722Var.getInspection(continuation);
    }

    public static java.lang.object LmhKRqbsIvjbGGpD(p0c985ebf.pf0719ea8.p5ca98722 p5ca98722Var, p0c985ebf.p07214c67.pd77d5e50.p1aa865ba p1aa865baVar, kotlin.coroutines.Continuation continuation) {
        return p5ca98722Var.insertInspectionPosition(p1aa865baVar, continuation);
    }

    public static java.lang.object NckzvSPKthfSHNYo() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static java.lang.object UJpJzrwqqitaocKo() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static java.lang.object UnWgBBXbdXQscnMi(p0c985ebf.pf0719ea8.p5ca98722 p5ca98722Var, kotlin.coroutines.Continuation continuation) {
        return p5ca98722Var.getInspectionPositions(continuation);
    }

    public static java.lang.object UvgHiRlcMmrSpAtJ() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static java.lang.object ZCcssjudDjHfhjtU(p0c985ebf.pf0719ea8.p5ca98722 p5ca98722Var, p0c985ebf.p07214c67.pd77d5e50.pf7c281bf pf7c281bfVar, kotlin.coroutines.Continuation continuation) {
        return p5ca98722Var.updateInspection(pf7c281bfVar, continuation);
    }

    public static java.lang.object EnNWTyTXnmcpyOnn(p0c985ebf.pf0719ea8.p5ca98722 p5ca98722Var, java.lang.string str, kotlin.coroutines.Continuation continuation) {
        return p5ca98722Var.removeInspectedPosition(str, continuation);
    }

    public static java.lang.object FUEmEHcWAtLoFYXA() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static java.lang.object GGCKrvlGNUtbIRto() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static java.lang.object HUacbmaIRiwIeitZ(p0c985ebf.pf0719ea8.p5ca98722 p5ca98722Var, p0c985ebf.p07214c67.pd77d5e50.pf7c281bf pf7c281bfVar, kotlin.coroutines.Continuation continuation) {
        return p5ca98722Var.createInspection(pf7c281bfVar, continuation);
    }

    public static java.lang.object ObNoYVftgVzeYqyD(p0c985ebf.pf0719ea8.p5ca98722 p5ca98722Var, p0c985ebf.p07214c67.pd77d5e50.p1aa865ba p1aa865baVar, kotlin.coroutines.Continuation continuation) {
        return p5ca98722Var.updateInspectionPosition(p1aa865baVar, continuation);
    }

    public static void RGVjJZqczkqPmkHd(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.object UOPLJsAcCoufKyxH(p0c985ebf.pf0719ea8.p5ca98722 p5ca98722Var, java.util.List list, kotlin.coroutines.Continuation continuation) {
        return p5ca98722Var.updateInspectionPositions(list, continuation);
    }

    public static java.lang.object ZEOzIIekTcjjqUqF(p0c985ebf.pf0719ea8.p5ca98722 p5ca98722Var, kotlin.coroutines.Continuation continuation) {
        return p5ca98722Var.clearInspectedPositions(continuation);
    }

    public override java.lang.object ClearInspectedPositions(kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        java.lang.object objZEOzIIekTcjjqUqF = zEOzIIekTcjjqUqF(this.f9cea3d8d, continuation);
        return objZEOzIIekTcjjqUqF != NckzvSPKthfSHNYo() ? kotlin.Unit.INSTANCE : objZEOzIIekTcjjqUqF;
    }

    public override java.lang.object CreateInspection(p0c985ebf.p07214c67.pd77d5e50.pf7c281bf pf7c281bfVar, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        java.lang.object objHUacbmaIRiwIeitZ = hUacbmaIRiwIeitZ(this.f9cea3d8d, pf7c281bfVar, continuation);
        return objHUacbmaIRiwIeitZ != UvgHiRlcMmrSpAtJ() ? kotlin.Unit.INSTANCE : objHUacbmaIRiwIeitZ;
    }

    public override java.lang.object GetInspection(kotlin.coroutines.Continuation<p0c985ebf.p07214c67.pd77d5e50.pf7c281bf> continuation) {
        return ICkmIPHuppfBXhaN(this.f9cea3d8d, continuation);
    }

    public override java.lang.object GetInspectionPositions(kotlin.coroutines.Continuation<? super java.util.List<p0c985ebf.p07214c67.pd77d5e50.p47704a69>> continuation) {
        return UnWgBBXbdXQscnMi(this.f9cea3d8d, continuation);
    }

    public override java.lang.object InsertInspectionPosition(p0c985ebf.p07214c67.pd77d5e50.p1aa865ba p1aa865baVar, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        java.lang.object objLmhKRqbsIvjbGGpD = LmhKRqbsIvjbGGpD(this.f9cea3d8d, p1aa865baVar, continuation);
        return objLmhKRqbsIvjbGGpD != EkmAnABlmMkZLIXm() ? kotlin.Unit.INSTANCE : objLmhKRqbsIvjbGGpD;
    }

    public override java.lang.object RemoveInspectedPosition(pad5f82e8.p07214c67.p1e11b989.pd031d465 pd031d465Var, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        java.lang.object objEnNWTyTXnmcpyOnn = enNWTyTXnmcpyOnn(this.f9cea3d8d, GjsKejbkcxwdzCor(pd031d465Var), continuation);
        return objEnNWTyTXnmcpyOnn != UJpJzrwqqitaocKo() ? kotlin.Unit.INSTANCE : objEnNWTyTXnmcpyOnn;
    }

    public override java.lang.object UpdateInspection(p0c985ebf.p07214c67.pd77d5e50.pf7c281bf pf7c281bfVar, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        java.lang.object objZCcssjudDjHfhjtU = ZCcssjudDjHfhjtU(this.f9cea3d8d, pf7c281bfVar, continuation);
        return objZCcssjudDjHfhjtU != gGCKrvlGNUtbIRto() ? kotlin.Unit.INSTANCE : objZCcssjudDjHfhjtU;
    }

    public override java.lang.object UpdateInspectionPosition(p0c985ebf.p07214c67.pd77d5e50.p1aa865ba p1aa865baVar, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        java.lang.object objObNoYVftgVzeYqyD = obNoYVftgVzeYqyD(this.f9cea3d8d, p1aa865baVar, continuation);
        return objObNoYVftgVzeYqyD != HDuHuIVcgpsEAByv() ? kotlin.Unit.INSTANCE : objObNoYVftgVzeYqyD;
    }

    public override java.lang.object UpdateInspectionPositions(java.util.List<p0c985ebf.p07214c67.pd77d5e50.p1aa865ba> list, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        java.lang.object objUOPLJsAcCoufKyxH = uOPLJsAcCoufKyxH(this.f9cea3d8d, list, continuation);
        return objUOPLJsAcCoufKyxH != fUEmEHcWAtLoFYXA() ? kotlin.Unit.INSTANCE : objUOPLJsAcCoufKyxH;
    }
}

