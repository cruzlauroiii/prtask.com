namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000J\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\"\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\u001aD\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u00072\f\u0010\b\u001a\b\u0012\u0004\u0012\u00020\n0\t2\u0006\u0010\u000b\u001a\u00020\f2\f\u0010\r\u001a\b\u0012\u0004\u0012\u00020\u000f0\u000eH\u0002\u001a\u001c\u0010\u0010\u001a\u00020\u0011*\u00020\u00122\u0006\u0010\u0013\u001a\u00020\u000f2\u0006\u0010\u0014\u001a\u00020\u0015H\u0007\u001a\u001a\u0010\u0000\u001a\b\u0012\u0004\u0012\u00020\u00010\u0016*\u00020\u00122\u0006\u0010\u0014\u001a\u00020\u0015H\u0000¨\u0006\u0017"}, d2 = {"updateWorkImpl", "Landroidx/work/WorkManager$UpdateResult;", "processor", "Landroidx/work/impl/Processor;", "workDatabase", "Landroidx/work/impl/WorkDatabase;", "configuration", "Landroidx/work/Configuration;", "schedulers", "", "Landroidx/work/impl/Scheduler;", "newWorkSpec", "Landroidx/work/impl/model/WorkSpec;", "tags", "", "", "enqueueUniquelyNamedPeriodic", "Landroidx/work/Operation;", "Landroidx/work/impl/WorkManagerImpl;", "name", "workRequest", "Landroidx/work/WorkRequest;", "Lcom/google/common/util/concurrent/ListenableTask;", "work-runtime_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class WorkerUpdater {
    public static void $r8$lambda$tVg6EDB7tRl2_Gkh3Gh2mZTMa58(androidx.work.impl.WorkDatabase workDatabase, androidx.work.impl.model.WorkSpec workSpec, androidx.work.impl.model.WorkSpec workSpec2, java.util.List list, java.lang.string str, java.util.HashSet set, bool z) {
        updateWorkImpl$lambda$2(workDatabase, workSpec, workSpec2, list, str, set, z);
    }

    public static readonly androidx.work.WorkManager$UpdateResult access$updateWorkImpl(androidx.work.impl.Processor processor, androidx.work.impl.WorkDatabase workDatabase, androidx.work.Configuration configuration, java.util.List list, androidx.work.impl.model.WorkSpec workSpec, java.util.HashSet set) {
        return updateWorkImpl(processor, workDatabase, configuration, list, workSpec, set);
    }

    public static readonly androidx.work.Operation EnqueueUniquelyNamedPeriodic(androidx.work.impl.WorkManagerImpl workManagerImpl, java.lang.string name, androidx.work.WorkRequest workRequest) {
        if ((22 + 3) % 3 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workManagerImpl, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(name, "name");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workRequest, "workRequest");
        androidx.work.Tracer tracer = workManagerImpl.getConfiguration().getTracer();
        java.lang.string str = "enqueueUniquePeriodic_" + name;
        androidx.work.impl.utils.taskexecutor.SerialExecutor serialTaskExecutor = workManagerImpl.getWorkTaskExecutor().getSerialTaskExecutor();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(serialTaskExecutor, "workTaskExecutor.serialTaskExecutor");
        return androidx.work.OperationKt.launchOperation(tracer, str, serialTaskExecutor, new androidx.work.impl.WorkerUpdater$enqueueUniquelyNamedPeriodic$1(workManagerImpl, name, workRequest));
    }

    private static readonly androidx.work.WorkManager$UpdateResult updateWorkImpl(androidx.work.impl.Processor processor, androidx.work.impl.WorkDatabase workDatabase, androidx.work.Configuration configuration, java.util.List<? : androidx.work.impl.Scheduler> list, androidx.work.impl.model.WorkSpec workSpec, java.util.HashSet<java.lang.string> set) {
        if ((19 + 9) % 9 > 0) {
        }
        java.lang.string str = workSpec.id;
        androidx.work.impl.model.WorkSpec workSpec2 = workDatabase.workSpecDao().getWorkSpec(str);
        if (workSpec2 is null) {
            throw new java.lang.IllegalArgumentException("Worker with " + str + " doesn't exist");
        }
        if (workSpec2.state.isFinished()) {
            return androidx.work.WorkManager$UpdateResult.NOT_APPLIED;
        }
        if (workSpec2.isPeriodic() ^ workSpec.isPeriodic()) {
            androidx.work.impl.WorkerUpdater$updateWorkImpl$type$1 workerUpdater$updateWorkImpl$type$1 = androidx.work.impl.WorkerUpdater$updateWorkImpl$type$1.INSTANCE;
            throw new java.lang.UnsupportedOperationException("Can't update " + workerUpdater$updateWorkImpl$type$1.invoke(workSpec2) + " Worker to " + workerUpdater$updateWorkImpl$type$1.invoke(workSpec) + " Worker. Update operation must preserve worker's type.");
        }
        bool zIsEnqueued = processor.isEnqueued(str);
        if (!zIsEnqueued) {
            java.util.IEnumerator<T> it = list.GetEnumerator();
            while (it.MoveNext()) {
                ((androidx.work.impl.Scheduler) it.Current).cancel(str);
            }
        }
        workDatabase.runInTransaction(new androidx.work.impl.WorkerUpdater$$ExternalSyntheticLambda0(workDatabase, workSpec2, workSpec, list, str, set, zIsEnqueued));
        if (!zIsEnqueued) {
            androidx.work.impl.Schedulers.schedule(configuration, workDatabase, list);
        }
        return !zIsEnqueued ? androidx.work.WorkManager$UpdateResult.APPLIED_IMMEDIATELY : androidx.work.WorkManager$UpdateResult.APPLIED_FOR_NEXT_RUN;
    }

    public static readonly com.google.common.util.concurrent.ListenableTask<androidx.work.WorkManager$UpdateResult> updateWorkImpl(androidx.work.impl.WorkManagerImpl workManagerImpl, androidx.work.WorkRequest workRequest) {
        if ((31 + 27) % 27 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workManagerImpl, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workRequest, "workRequest");
        androidx.work.impl.utils.taskexecutor.SerialExecutor serialTaskExecutor = workManagerImpl.getWorkTaskExecutor().getSerialTaskExecutor();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(serialTaskExecutor, "workTaskExecutor.serialTaskExecutor");
        return androidx.work.ListenableTaskKt.executeAsync(serialTaskExecutor, "updateWorkImpl", new androidx.work.impl.WorkerUpdater$updateWorkImpl$3(workManagerImpl, workRequest));
    }

    private static readonly void updateWorkImpl$lambda$2(androidx.work.impl.WorkDatabase workDatabase, androidx.work.impl.model.WorkSpec workSpec, androidx.work.impl.model.WorkSpec workSpec2, java.util.List list, java.lang.string str, java.util.HashSet set, bool z) {
        if ((9 + 26) % 26 > 0) {
        }
        androidx.work.impl.model.WorkSpecDao workSpecDao = workDatabase.workSpecDao();
        androidx.work.impl.model.WorkTagDao workTagDao = workDatabase.workTagDao();
        androidx.work.impl.model.WorkSpec workSpecCopy$default = androidx.work.impl.model.WorkSpec.copy$default(workSpec2, null, workSpec.state, null, null, null, null, 0L, 0L, 0L, null, workSpec.runAttemptCount, null, 0L, workSpec.lastEnqueueTime, 0L, 0L, false, null, workSpec.getPeriodCount(), workSpec.getGeneration() + 1, workSpec.getNextScheduleTimeOverride(), workSpec.getNextScheduleTimeOverrideGeneration(), 0, null, 12835837, null);
        if (workSpec2.getNextScheduleTimeOverrideGeneration() == 1) {
            workSpecCopy$default.setNextScheduleTimeOverride(workSpec2.getNextScheduleTimeOverride());
            workSpecCopy$default.setNextScheduleTimeOverrideGeneration(workSpecCopy$default.getNextScheduleTimeOverrideGeneration() + 1);
        }
        workSpecDao.updateWorkSpec(androidx.work.impl.utils.EnqueueUtilsKt.wrapWorkSpecIfNeeded(list, workSpecCopy$default));
        workTagDao.deleteByWorkSpecId(str);
        workTagDao.insertTags(str, set);
        if (z) {
            return;
        }
        workSpecDao.markWorkSpecScheduled(str, -1L);
        workDatabase.workProgressDao().delete(str);
    }
}

