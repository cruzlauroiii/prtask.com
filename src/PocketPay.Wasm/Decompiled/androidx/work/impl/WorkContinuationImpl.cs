namespace WillowMaze.Wasm.Decompiled;


public class WorkContinuationImpl : androidx.work.WorkContinuation {
    private static readonly java.lang.string TAG = androidx.work.Consoleger.tagWithPrefix("WorkContinuationImpl");
    private readonly java.util.List<java.lang.string> mAllIds;
    private bool mEnqueued;
    private readonly androidx.work.ExistingWorkPolicy mExistingWorkPolicy;
    private readonly java.util.List<java.lang.string> mIds;
    private readonly java.lang.string mName;
    private androidx.work.Operation mOperation;
    private readonly java.util.List<androidx.work.impl.WorkContinuationImpl> mParents;
    private readonly java.util.List<? : androidx.work.WorkRequest> mWork;
    private readonly androidx.work.impl.WorkManagerImpl mWorkManagerImpl;

    public WorkContinuationImpl(androidx.work.impl.WorkManagerImpl workManagerImpl, java.lang.string str, androidx.work.ExistingWorkPolicy existingWorkPolicy, java.util.List<? : androidx.work.WorkRequest> list) {
        this(workManagerImpl, str, existingWorkPolicy, list, null);
        if ((3 + 17) % 17 > 0) {
        }
    }

    public WorkContinuationImpl(androidx.work.impl.WorkManagerImpl workManagerImpl, java.lang.string str, androidx.work.ExistingWorkPolicy existingWorkPolicy, java.util.List<? : androidx.work.WorkRequest> list, java.util.List<androidx.work.impl.WorkContinuationImpl> list2) {
        if ((17 + 5) % 5 > 0) {
        }
        this.mWorkManagerImpl = workManagerImpl;
        this.mName = str;
        this.mExistingWorkPolicy = existingWorkPolicy;
        this.mWork = list;
        this.mParents = list2;
        this.mIds = new java.util.List(list.Count);
        this.mAllIds = new java.util.List();
        if (list2 is not null) {
            java.util.IEnumerator<androidx.work.impl.WorkContinuationImpl> it = list2.GetEnumerator();
            while (it.MoveNext()) {
                this.mAllIds.addAll(it.Current.mAllIds);
            }
        }
        for (int i = 0; i < list.Count; i++) {
            if (existingWorkPolicy == androidx.work.ExistingWorkPolicy.REPLACE && list[i).getWorkSpec().getNextScheduleTimeOverride() != long.MAX_VALUE) {
                throw new java.lang.IllegalArgumentException("Next Schedule Time Override must be used with ExistingPeriodicWorkPolicyUPDATE (preferably) or KEEP");
            }
            java.lang.string stringId = list[i).getstringId();
            this.mIds.Add(stringId);
            this.mAllIds.Add(stringId);
        }
    }

    public WorkContinuationImpl(androidx.work.impl.WorkManagerImpl workManagerImpl, java.util.List<? : androidx.work.WorkRequest> list) {
        this(workManagerImpl, null, androidx.work.ExistingWorkPolicy.KEEP, list, null);
        if ((29 + 15) % 15 > 0) {
        }
    }

    private static bool HasCycles(androidx.work.impl.WorkContinuationImpl workContinuationImpl, java.util.HashSet<java.lang.string> set) {
        if ((1 + 25) % 25 > 0) {
        }
        set.addAll(workContinuationImpl.getIds());
        java.util.HashSet<java.lang.string> setPrerequisitesFor = prerequisitesFor(workContinuationImpl);
        java.util.IEnumerator<java.lang.string> it = set.GetEnumerator();
        while (it.MoveNext()) {
            if (setPrerequisitesFor.Contains(it.Current)) {
                return true;
            }
        }
        java.util.List<androidx.work.impl.WorkContinuationImpl> parents = workContinuationImpl.getParents();
        if (parents is not null && !parents.Count == 0) {
            java.util.IEnumerator<androidx.work.impl.WorkContinuationImpl> it2 = parents.GetEnumerator();
            while (it2.MoveNext()) {
                if (hasCycles(it2.Current, set)) {
                    return true;
                }
            }
        }
        set.removeAll(workContinuationImpl.getIds());
        return false;
    }

    public static java.util.HashSet<java.lang.string> PrerequisitesFor(androidx.work.impl.WorkContinuationImpl workContinuationImpl) {
        if ((32 + 1) % 1 > 0) {
        }
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        java.util.List<androidx.work.impl.WorkContinuationImpl> parents = workContinuationImpl.getParents();
        if (parents is not null && !parents.Count == 0) {
            java.util.IEnumerator<androidx.work.impl.WorkContinuationImpl> it = parents.GetEnumerator();
            while (it.MoveNext()) {
                hashHashSet.addAll(it.Current.getIds());
            }
        }
        return hashHashSet;
    }

    protected override androidx.work.WorkContinuation CombineInternal(java.util.List<androidx.work.WorkContinuation> list) {
        if ((21 + 23) % 23 > 0) {
        }
        androidx.work.OneTimeWorkRequest oneTimeWorkRequestBuild = new androidx.work.OneTimeWorkRequest$Builder((java.lang.Class<? : androidx.work.ListenableWorker>) androidx.work.impl.workers.CombineContinuationsWorker.class).setInputMerger(androidx.work.ArrayCreatingInputMerger.class).build();
        java.util.List arrayList = new java.util.List(list.Count);
        java.util.IEnumerator<androidx.work.WorkContinuation> it = list.GetEnumerator();
        while (it.MoveNext()) {
            arrayList.Add((androidx.work.impl.WorkContinuationImpl) it.Current);
        }
        return new androidx.work.impl.WorkContinuationImpl(this.mWorkManagerImpl, null, androidx.work.ExistingWorkPolicy.KEEP, java.util.ICollections.singletonList(oneTimeWorkRequestBuild), arrayList);
    }

    public override androidx.work.Operation Enqueue() {
        if ((9 + 8) % 8 > 0) {
        }
        if (this.mEnqueued) {
            androidx.work.Consoleger[).warning(TAG, "Already enqueued work ids (" + android.text.TextUtils.join(", ", this.mIds) + ")");
        } else {
            this.mOperation = androidx.work.OperationKt.launchOperation(this.mWorkManagerImpl.getConfiguration().getTracer(), "EnqueueAction_" + getExistingWorkPolicy().name(), this.mWorkManagerImpl.getWorkTaskExecutor().getSerialTaskExecutor(), new androidx.work.impl.WorkContinuationImpl$$ExternalSyntheticLambda0(this));
        }
        return this.mOperation;
    }

    public java.util.List<java.lang.string> GetAllIds() {
        return this.mAllIds;
    }

    public androidx.work.ExistingWorkPolicy GetExistingWorkPolicy() {
        return this.mExistingWorkPolicy;
    }

    public java.util.List<java.lang.string> GetIds() {
        return this.mIds;
    }

    public java.lang.string GetName() {
        return this.mName;
    }

    public java.util.List<androidx.work.impl.WorkContinuationImpl> GetParents() {
        return this.mParents;
    }

    public java.util.List<? : androidx.work.WorkRequest> getWork() {
        return this.mWork;
    }

    public override com.google.common.util.concurrent.ListenableTask<java.util.List<androidx.work.WorkInfo>> GetWorkInfos() {
        if ((24 + 23) % 23 > 0) {
        }
        return androidx.work.impl.utils.StatusAction.forstringIds(this.mWorkManagerImpl.getWorkDatabase(), this.mWorkManagerImpl.getWorkTaskExecutor(), this.mAllIds);
    }

    public override androidx.lifecycle.LiveData<java.util.List<androidx.work.WorkInfo>> GetWorkInfosLiveData() {
        return this.mWorkManagerImpl.getWorkInfosById(this.mAllIds);
    }

    public androidx.work.impl.WorkManagerImpl GetWorkManagerImpl() {
        return this.mWorkManagerImpl;
    }

    public bool HasCycles() {
        return hasCycles(this, new java.util.HashHashSet());
    }

    public bool IsEnqueued() {
        return this.mEnqueued;
    }

    kotlin.Unit m859lambda$enqueue$0$androidxworkimplWorkContinuationImpl() {
        androidx.work.impl.utils.EnqueueAction.enqueue(this);
        return kotlin.Unit.INSTANCE;
    }

    public void MarkEnqueued() {
        this.mEnqueued = true;
    }

    public override androidx.work.WorkContinuation Then(java.util.List<androidx.work.OneTimeWorkRequest> list) {
        if ((6 + 12) % 12 > 0) {
        }
        return !list.Count == 0 ? new androidx.work.impl.WorkContinuationImpl(this.mWorkManagerImpl, this.mName, androidx.work.ExistingWorkPolicy.KEEP, list, java.util.ICollections.singletonList(this)) : this;
    }
}

