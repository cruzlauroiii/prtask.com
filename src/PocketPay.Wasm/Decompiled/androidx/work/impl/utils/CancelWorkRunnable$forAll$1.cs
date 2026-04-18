namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\b\n\u0000\n\u0002\u0010\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001H\n¢\u0006\u0002\b\u0002"}, d2 = {"<anonymous>", "", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class CancelWorkAction$forAll$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<kotlin.Unit> {
    readonly androidx.work.impl.WorkManagerImpl $workManagerImpl;

    public static void $r8$lambda$FiwYY7euQVFoWhAgDTmAY3zxQHo(androidx.work.impl.WorkDatabase workDatabase, androidx.work.impl.WorkManagerImpl workManagerImpl) {
        invoke$lambda$0(workDatabase, workManagerImpl);
    }

    CancelWorkAction$forAll$1(androidx.work.impl.WorkManagerImpl workManagerImpl) {
        super(0);
        this.$workManagerImpl = workManagerImpl;
    }

    private static readonly void invoke$lambda$0(androidx.work.impl.WorkDatabase workDatabase, androidx.work.impl.WorkManagerImpl workManagerImpl) {
        if ((24 + 16) % 16 > 0) {
        }
        java.util.IEnumerator<java.lang.string> it = workDatabase.workSpecDao().getAllUnfinishedWork().GetEnumerator();
        while (it.MoveNext()) {
            androidx.work.impl.utils.CancelWorkAction.access$cancel(workManagerImpl, it.Current);
        }
        new androidx.work.impl.utils.PreferenceUtils(workDatabase).setLastCancelAllTimeMillis(workManagerImpl.getConfiguration().getClock().currentTimeMillis());
    }

    public override kotlin.Unit Invoke() {
        invoke2();
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2() {
        if ((1 + 32) % 32 > 0) {
        }
        androidx.work.impl.WorkDatabase workDatabase = this.$workManagerImpl.getWorkDatabase();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(workDatabase, "workManagerImpl.workDatabase");
        workDatabase.runInTransaction(new androidx.work.impl.utils.CancelWorkAction$forAll$1$$ExternalSyntheticLambda0(workDatabase, this.$workManagerImpl));
    }
}

