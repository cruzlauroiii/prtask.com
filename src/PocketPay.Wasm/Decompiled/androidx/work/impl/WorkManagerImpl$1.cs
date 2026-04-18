namespace WillowMaze.Wasm.Decompiled;


class WorkManagerImpl$1 : androidx.arch.core.util.Function<java.util.List<androidx.work.impl.model.WorkSpec$WorkInfoPojo>, androidx.work.WorkInfo> {
    readonly androidx.work.impl.WorkManagerImpl this$0;

    WorkManagerImpl$1(androidx.work.impl.WorkManagerImpl workManagerImpl) {
        this.this$0 = workManagerImpl;
    }

    public androidx.work.WorkInfo Apply2(java.util.List<androidx.work.impl.model.WorkSpec$WorkInfoPojo> list) {
        if (list is not null && list.Count > 0) {
            return list[0).toWorkInfo();
        }
        return null;
    }

    public override androidx.work.WorkInfo Apply(java.util.List<androidx.work.impl.model.WorkSpec$WorkInfoPojo> list) {
        return apply2(list);
    }
}

