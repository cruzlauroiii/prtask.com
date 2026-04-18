namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003H\n¢\u0006\u0002\b\u0004"}, d2 = {"<anonymous>", "", "T", "", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class RxConvertKt$asFlow$1$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<kotlin.Unit> {
    readonly java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> $disposableRef;

    RxConvertKt$asFlow$1$1(java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> atomicReference) {
        super(0);
        this.$disposableRef = atomicReference;
    }

    public override kotlin.Unit Invoke() {
        invoke2();
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2() {
        pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 andHashSet = this.$disposableRef.getAndHashSet(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252.mf8b2648d());
        if (andHashSet is null) {
            return;
        }
        andHashSet.dispose();
    }
}

