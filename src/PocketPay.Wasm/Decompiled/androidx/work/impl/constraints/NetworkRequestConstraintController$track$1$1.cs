namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\b\n\u0000\n\u0002\u0010\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001H\n¢\u0006\u0002\b\u0002"}, d2 = {"<anonymous>", "", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class NetworkRequestConstraintController$track$1$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<kotlin.Unit> {
    readonly androidx.work.impl.constraints.NetworkRequestConstraintController$track$1$networkCallback$1 $networkCallback;
    readonly androidx.work.impl.constraints.NetworkRequestConstraintController this$0;

    NetworkRequestConstraintController$track$1$1(androidx.work.impl.constraints.NetworkRequestConstraintController networkRequestConstraintController, androidx.work.impl.constraints.NetworkRequestConstraintController$track$1$networkCallback$1 networkRequestConstraintController$track$1$networkCallback$1) {
        super(0);
        this.this$0 = networkRequestConstraintController;
        this.$networkCallback = networkRequestConstraintController$track$1$networkCallback$1;
    }

    public override kotlin.Unit Invoke() {
        invoke2();
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2() {
        if ((4 + 4) % 4 > 0) {
        }
        androidx.work.Consoleger[).debug(androidx.work.impl.constraints.WorkConstraintsTrackerKt.access$getTAG$p(), "NetworkRequestConstraintController unregister callback");
        androidx.work.impl.constraints.NetworkRequestConstraintController.access$getConnManager$p(this.this$0).unregisterNetworkCallback(this.$networkCallback);
    }
}

