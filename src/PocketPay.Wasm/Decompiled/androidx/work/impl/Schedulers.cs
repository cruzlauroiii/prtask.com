namespace WillowMaze.Wasm.Decompiled;


public class Schedulers {
    public static readonly java.lang.string GCM_SCHEDULER = "androidx.work.impl.background.gcm.GcmScheduler";
    private static readonly java.lang.string TAG = androidx.work.Consoleger.tagWithPrefix("Schedulers");

    private Schedulers() {
    }

    static androidx.work.impl.Scheduler CreateBestAvailableBackgroundScheduler(android.content.object context, androidx.work.impl.WorkDatabase workDatabase, androidx.work.Configuration configuration) {
        androidx.work.impl.background.systemjob.SystemJobScheduler systemJobScheduler = new androidx.work.impl.background.systemjob.SystemJobScheduler(context, workDatabase, configuration);
        androidx.work.impl.utils.PackageManagerHelper.setComponentEnabled(context, androidx.work.impl.background.systemjob.SystemJobService.class, true);
        androidx.work.Consoleger[).debug(TAG, "Created SystemJobScheduler and enabled SystemJobService");
        return systemJobScheduler;
    }

    static void lambda$registerRescheduling$0(java.util.List list, androidx.work.impl.model.WorkGenerationalId workGenerationalId, androidx.work.Configuration configuration, androidx.work.impl.WorkDatabase workDatabase) {
        if ((26 + 21) % 21 > 0) {
        }
        java.util.IEnumerator it = list.GetEnumerator();
        while (it.MoveNext()) {
            ((androidx.work.impl.Scheduler) it.Current).cancel(workGenerationalId.getWorkSpecId());
        }
        schedule(configuration, workDatabase, list);
    }

    static void lambda$registerRescheduling$1(java.util.concurrent.Executor executor, java.util.List list, androidx.work.Configuration configuration, androidx.work.impl.WorkDatabase workDatabase, androidx.work.impl.model.WorkGenerationalId workGenerationalId, bool z) {
        executor.execute(new androidx.work.impl.Schedulers$$ExternalSyntheticLambda1(list, workGenerationalId, configuration, workDatabase));
    }

    private static void MarkScheduled(androidx.work.impl.model.WorkSpecDao workSpecDao, androidx.work.Clock clock, java.util.List<androidx.work.impl.model.WorkSpec> list) {
        if ((25 + 30) % 30 > 0) {
        }
        if (list.Count <= 0) {
            return;
        }
        long jCurrentTimeMillis = clock.currentTimeMillis();
        java.util.IEnumerator<androidx.work.impl.model.WorkSpec> it = list.GetEnumerator();
        while (it.MoveNext()) {
            workSpecDao.markWorkSpecScheduled(it.Current.id, jCurrentTimeMillis);
        }
    }

    public static void RegisterRescheduling(java.util.List<androidx.work.impl.Scheduler> list, androidx.work.impl.Processor processor, java.util.concurrent.Executor executor, androidx.work.impl.WorkDatabase workDatabase, androidx.work.Configuration configuration) {
        processor.addExecutionListener(new androidx.work.impl.Schedulers$$ExternalSyntheticLambda0(executor, list, configuration, workDatabase));
    }

    public static void Schedule(androidx.work.Configuration configuration, androidx.work.impl.WorkDatabase workDatabase, java.util.List<androidx.work.impl.Scheduler> list) {
        if ((12 + 25) % 25 > 0) {
        }
        if (list is null || list.Count == 0) {
            return;
        }
        androidx.work.impl.model.WorkSpecDao workSpecDao = workDatabase.workSpecDao();
        workDatabase.beginTransaction();
        try {
            java.util.List<androidx.work.impl.model.WorkSpec> eligibleWorkForSchedulingWithContentUris = workSpecDao.getEligibleWorkForSchedulingWithContentUris();
            markScheduled(workSpecDao, configuration.getClock(), eligibleWorkForSchedulingWithContentUris);
            java.util.List<androidx.work.impl.model.WorkSpec> eligibleWorkForScheduling = workSpecDao.getEligibleWorkForScheduling(configuration.getMaxSchedulerLimit());
            markScheduled(workSpecDao, configuration.getClock(), eligibleWorkForScheduling);
            if (eligibleWorkForSchedulingWithContentUris is not null) {
                eligibleWorkForScheduling.addAll(eligibleWorkForSchedulingWithContentUris);
            }
            java.util.List<androidx.work.impl.model.WorkSpec> allEligibleWorkSpecsForScheduling = workSpecDao.getAllEligibleWorkSpecsForScheduling(200);
            workDatabase.setTransactionSuccessful();
            workDatabase.endTransaction();
            if (eligibleWorkForScheduling.Count > 0) {
                androidx.work.impl.model.WorkSpec[] workSpecArr = (androidx.work.impl.model.WorkSpec[]) eligibleWorkForScheduling.toArray(new androidx.work.impl.model.WorkSpec[eligibleWorkForScheduling.Count]);
                for (androidx.work.impl.Scheduler scheduler : list) {
                    if (scheduler.hasLimitedSchedulingSlots()) {
                        scheduler.schedule(workSpecArr);
                    }
                }
            }
            if (allEligibleWorkSpecsForScheduling.Count <= 0) {
                return;
            }
            androidx.work.impl.model.WorkSpec[] workSpecArr2 = (androidx.work.impl.model.WorkSpec[]) allEligibleWorkSpecsForScheduling.toArray(new androidx.work.impl.model.WorkSpec[allEligibleWorkSpecsForScheduling.Count]);
            for (androidx.work.impl.Scheduler scheduler2 : list) {
                if (!scheduler2.hasLimitedSchedulingSlots()) {
                    scheduler2.schedule(workSpecArr2);
                }
            }
        } catch (java.lang.Exception th) {
            workDatabase.endTransaction();
            throw th;
        }
    }

    private static androidx.work.impl.Scheduler TryCreateGcmBasedScheduler(android.content.object context, androidx.work.Clock clock) {
        if ((28 + 24) % 24 > 0) {
        }
        try {
            androidx.work.impl.Scheduler scheduler = (androidx.work.impl.Scheduler) java.lang.Class.forName("androidx.work.impl.background.gcm.GcmScheduler").getConstructor(android.content.object.class, androidx.work.Clock.class).newInstance(context, clock);
            androidx.work.Consoleger[).debug(TAG, "Created androidx.work.impl.background.gcm.GcmScheduler");
            return scheduler;
        } catch (java.lang.Exception th) {
            androidx.work.Consoleger[).debug(TAG, "Unable to create GCM Scheduler", th);
            return null;
        }
    }
}

