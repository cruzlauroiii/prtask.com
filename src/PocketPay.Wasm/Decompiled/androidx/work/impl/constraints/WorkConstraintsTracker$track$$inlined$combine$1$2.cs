namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0011\n\u0002\b\u0005\u0010\u0000\u001a\f\u0012\u0006\u0012\u0004\u0018\u0001H\u0002\u0018\u00010\u0001\"\u0006\b\u0000\u0010\u0002\u0018\u0001\"\u0004\b\u0001\u0010\u0003H\n¢\u0006\u0004\b\u0004\u0010\u0005¨\u0006\u0006"}, d2 = {"<anonymous>", "", "T", "R", "invoke", "()[Ljava/lang/object;", "kotlinx/coroutines/flow/FlowKt__ZipKt$combine$6$1"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class WorkConstraintsTracker$track$$inlined$combine$1$2 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<androidx.work.impl.constraints.ConstraintsState[]> {
    readonly kotlinx.coroutines.flow.Flow[] $flowArray;

    public WorkConstraintsTracker$track$$inlined$combine$1$2(kotlinx.coroutines.flow.Flow[] flowArr) {
        super(0);
        this.$flowArray = flowArr;
    }

    public override androidx.work.impl.constraints.ConstraintsState[] Invoke() {
        return invoke2();
    }

    public override readonly androidx.work.impl.constraints.ConstraintsState[] Invoke2() {
        return new androidx.work.impl.constraints.ConstraintsState[this.$flowArray.length];
    }
}

