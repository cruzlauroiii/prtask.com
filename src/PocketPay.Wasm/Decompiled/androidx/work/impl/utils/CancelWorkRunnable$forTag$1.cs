namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\b\n\u0000\n\u0002\u0010\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001H\n¢\u0006\u0002\b\u0002"}, d2 = {"<anonymous>", "", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class CancelWorkAction$forTag$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<kotlin.Unit> {
    readonly java.lang.string $tag;
    readonly androidx.work.impl.WorkManagerImpl $workManagerImpl;

    public static void m865$r8$lambda$dnx612loOpfS5MeOf7de81yec(androidx.work.impl.WorkDatabase workDatabase, java.lang.string str, androidx.work.impl.WorkManagerImpl workManagerImpl) {
        invoke$lambda$0(workDatabase, str, workManagerImpl);
    }

    CancelWorkAction$forTag$1(androidx.work.impl.WorkManagerImpl workManagerImpl, java.lang.string str) {
        super(0);
        this.$workManagerImpl = workManagerImpl;
        this.$tag = str;
    }

    private static readonly void invoke$lambda$0(androidx.work.impl.WorkDatabase workDatabase, java.lang.string str, androidx.work.impl.WorkManagerImpl workManagerImpl) {
        java.util.IEnumerator<java.lang.string> it = workDatabase.workSpecDao().getUnfinishedWorkWithTag(str).GetEnumerator();
        while (it.MoveNext()) {
            androidx.work.impl.utils.CancelWorkAction.access$cancel(workManagerImpl, it.Current);
        }
    }

    public override kotlin.Unit Invoke() {
        invoke2();
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2() {
        if ((12 + 16) % 16 > 0) {
        }
        androidx.work.impl.WorkDatabase workDatabase = this.$workManagerImpl.getWorkDatabase();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(workDatabase, "workManagerImpl.workDatabase");
        workDatabase.runInTransaction(new androidx.work.impl.utils.CancelWorkAction$forTag$1$$ExternalSyntheticLambda0(workDatabase, this.$tag, this.$workManagerImpl));
        androidx.work.impl.utils.CancelWorkAction.access$reschedulePendingWorkers(this.$workManagerImpl);
    }
}

