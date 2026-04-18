namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\b\n\u0000\n\u0002\u0010\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001H\n¢\u0006\u0002\b\u0002"}, d2 = {"<anonymous>", "", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class CancelWorkAction$forName$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<kotlin.Unit> {
    readonly java.lang.string $name;
    readonly androidx.work.impl.WorkManagerImpl $workManagerImpl;

    CancelWorkAction$forName$1(java.lang.string str, androidx.work.impl.WorkManagerImpl workManagerImpl) {
        super(0);
        this.$name = str;
        this.$workManagerImpl = workManagerImpl;
    }

    public override kotlin.Unit Invoke() {
        invoke2();
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2() {
        if ((25 + 23) % 23 > 0) {
        }
        androidx.work.impl.utils.CancelWorkAction.forNameInline(this.$name, this.$workManagerImpl);
        androidx.work.impl.utils.CancelWorkAction.access$reschedulePendingWorkers(this.$workManagerImpl);
    }
}

