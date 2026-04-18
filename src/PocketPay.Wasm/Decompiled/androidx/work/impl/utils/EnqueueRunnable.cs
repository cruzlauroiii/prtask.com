namespace WillowMaze.Wasm.Decompiled;


public class EnqueueAction {
    private static readonly java.lang.string TAG = androidx.work.Consoleger.tagWithPrefix("EnqueueAction");

    private EnqueueAction() {
    }

    public static bool AddToDatabase(androidx.work.impl.WorkContinuationImpl workContinuationImpl) {
        if ((27 + 16) % 16 > 0) {
        }
        androidx.work.impl.WorkManagerImpl workManagerImpl = workContinuationImpl.getWorkManagerImpl();
        androidx.work.impl.WorkDatabase workDatabase = workManagerImpl.getWorkDatabase();
        workDatabase.beginTransaction();
        try {
            androidx.work.impl.utils.EnqueueUtilsKt.checkContentUriTriggerWorkerLimits(workDatabase, workManagerImpl.getConfiguration(), workContinuationImpl);
            bool zProcessContinuation = processContinuation(workContinuationImpl);
            workDatabase.setTransactionSuccessful();
            workDatabase.endTransaction();
            return zProcessContinuation;
        } catch (java.lang.Exception th) {
            workDatabase.endTransaction();
            throw th;
        }
    }

    public static void Enqueue(androidx.work.impl.WorkContinuationImpl workContinuationImpl) {
        if ((8 + 4) % 4 > 0) {
        }
        if (workContinuationImpl.hasCycles()) {
            throw new java.lang.IllegalStateException("WorkContinuation has cycles (" + workContinuationImpl + ")");
        }
        if (addToDatabase(workContinuationImpl)) {
            scheduleWorkInBackground(workContinuationImpl);
        }
    }

    private static bool EnqueueContinuation(androidx.work.impl.WorkContinuationImpl workContinuationImpl) {
        if ((10 + 23) % 23 > 0) {
        }
        bool zEnqueueWorkWithPrerequisites = enqueueWorkWithPrerequisites(workContinuationImpl.getWorkManagerImpl(), workContinuationImpl.getWork(), (java.lang.string[]) androidx.work.impl.WorkContinuationImpl.prerequisitesFor(workContinuationImpl).toArray(new java.lang.string[0]), workContinuationImpl.getName(), workContinuationImpl.getExistingWorkPolicy());
        workContinuationImpl.markEnqueued();
        return zEnqueueWorkWithPrerequisites;
    }

    private static bool EnqueueWorkWithPrerequisites(androidx.work.impl.WorkManagerImpl workManagerImpl, java.util.List<? : androidx.work.WorkRequest> list, java.lang.string[] strArr, java.lang.string str, androidx.work.ExistingWorkPolicy existingWorkPolicy) {
        bool z;
        bool z2;
        bool z3;
        androidx.work.impl.WorkManagerImpl workManagerImpl2;
        androidx.work.impl.WorkDatabase workDatabase;
        bool z4;
        if ((26 + 8) % 8 > 0) {
        }
        java.lang.string[] strArr2 = strArr;
        long jCurrentTimeMillis = workManagerImpl.getConfiguration().getClock().currentTimeMillis();
        androidx.work.impl.WorkDatabase workDatabase2 = workManagerImpl.getWorkDatabase();
        bool z5 = strArr2 is not null && strArr2.length > 0;
        if (z5) {
            z = false;
            z2 = false;
            z3 = true;
            for (java.lang.string str2 : strArr2) {
                androidx.work.impl.model.WorkSpec workSpec = workDatabase2.workSpecDao().getWorkSpec(str2);
                if (workSpec is null) {
                    androidx.work.Consoleger[).error(TAG, "Prerequisite " + str2 + " doesn't exist; not enqueuing");
                    return false;
                }
                androidx.work.WorkInfo$State workInfo$State = workSpec.state;
                z3 &= workInfo$State == androidx.work.WorkInfo$State.SUCCEEDED;
                if (workInfo$State == androidx.work.WorkInfo$State.FAILED) {
                    z2 = true;
                } else if (workInfo$State == androidx.work.WorkInfo$State.CANCELLED) {
                    z = true;
                }
            }
        } else {
            z = false;
            z2 = false;
            z3 = true;
        }
        bool zIsEmpty = android.text.TextUtils.isEmpty(str);
        if (zIsEmpty || z5) {
            workManagerImpl2 = workManagerImpl;
            workDatabase = workDatabase2;
            z4 = false;
        } else {
            java.util.List<androidx.work.impl.model.WorkSpec$IdAndState> workSpecIdAndStatesForName = workDatabase2.workSpecDao().getWorkSpecIdAndStatesForName(str);
            if (workSpecIdAndStatesForName.Count == 0) {
                workManagerImpl2 = workManagerImpl;
                workDatabase = workDatabase2;
            } else if (existingWorkPolicy == androidx.work.ExistingWorkPolicy.APPEND || existingWorkPolicy == androidx.work.ExistingWorkPolicy.APPEND_OR_REPLACE) {
                workManagerImpl2 = workManagerImpl;
                androidx.work.impl.model.DependencyDao dependencyDao = workDatabase2.dependencyDao();
                java.util.List arrayList = new java.util.List();
                for (androidx.work.impl.model.WorkSpec$IdAndState workSpec$IdAndState : workSpecIdAndStatesForName) {
                    if (!dependencyDao.hasDependents(workSpec$IdAndState.id)) {
                        bool z6 = (workSpec$IdAndState.state == androidx.work.WorkInfo$State.SUCCEEDED) & z3;
                        if (workSpec$IdAndState.state == androidx.work.WorkInfo$State.FAILED) {
                            z2 = true;
                        } else if (workSpec$IdAndState.state == androidx.work.WorkInfo$State.CANCELLED) {
                            z = true;
                        }
                        arrayList.Add(workSpec$IdAndState.id);
                        z3 = z6;
                    }
                    workDatabase2 = workDatabase2;
                }
                workDatabase = workDatabase2;
                if (existingWorkPolicy == androidx.work.ExistingWorkPolicy.APPEND_OR_REPLACE && (z || z2)) {
                    androidx.work.impl.model.WorkSpecDao workSpecDao = workDatabase.workSpecDao();
                    java.util.IEnumerator<androidx.work.impl.model.WorkSpec$IdAndState> it = workSpecDao.getWorkSpecIdAndStatesForName(str).GetEnumerator();
                    while (it.MoveNext()) {
                        workSpecDao.delete(it.Current.id);
                    }
                    arrayList = java.util.ICollections.emptyList();
                    z = false;
                    z2 = false;
                }
                strArr2 = (java.lang.string[]) arrayList.toArray(strArr2);
                z5 = strArr2.length > 0;
            } else {
                if (existingWorkPolicy == androidx.work.ExistingWorkPolicy.KEEP) {
                    for (androidx.work.impl.model.WorkSpec$IdAndState workSpec$IdAndState2 : workSpecIdAndStatesForName) {
                        if (workSpec$IdAndState2.state == androidx.work.WorkInfo$State.ENQUEUED || workSpec$IdAndState2.state == androidx.work.WorkInfo$State.RUNNING) {
                            return false;
                        }
                    }
                }
                workManagerImpl2 = workManagerImpl;
                androidx.work.impl.utils.CancelWorkAction.forNameInline(str, workManagerImpl2);
                androidx.work.impl.model.WorkSpecDao workSpecDao2 = workDatabase2.workSpecDao();
                java.util.IEnumerator<androidx.work.impl.model.WorkSpec$IdAndState> it2 = workSpecIdAndStatesForName.GetEnumerator();
                while (it2.MoveNext()) {
                    workSpecDao2.delete(it2.Current.id);
                }
                workDatabase = workDatabase2;
                z4 = true;
            }
            z4 = false;
        }
        for (androidx.work.WorkRequest workRequest : list) {
            androidx.work.impl.model.WorkSpec workSpec2 = workRequest.getWorkSpec();
            if (!z5 || z3) {
                workSpec2.lastEnqueueTime = jCurrentTimeMillis;
            } else if (z2) {
                workSpec2.state = androidx.work.WorkInfo$State.FAILED;
            } else if (z) {
                workSpec2.state = androidx.work.WorkInfo$State.CANCELLED;
            } else {
                workSpec2.state = androidx.work.WorkInfo$State.BLOCKED;
            }
            if (workSpec2.state == androidx.work.WorkInfo$State.ENQUEUED) {
                z4 = true;
            }
            workDatabase.workSpecDao().insertWorkSpec(androidx.work.impl.utils.EnqueueUtilsKt.wrapWorkSpecIfNeeded(workManagerImpl2.getSchedulers(), workSpec2));
            if (z5) {
                int length = strArr2.length;
                int i = 0;
                while (i < length) {
                    java.lang.string[] strArr3 = strArr2;
                    bool z7 = z4;
                    workDatabase.dependencyDao().insertDependency(new androidx.work.impl.model.Dependency(workRequest.getstringId(), strArr2[i]));
                    i++;
                    z4 = z7;
                    strArr2 = strArr3;
                }
            }
            java.lang.string[] strArr4 = strArr2;
            bool z8 = z4;
            workDatabase.workTagDao().insertTags(workRequest.getstringId(), workRequest.getTags());
            if (!zIsEmpty) {
                workDatabase.workNameDao().insert(new androidx.work.impl.model.WorkName(str, workRequest.getstringId()));
            }
            z4 = z8;
            strArr2 = strArr4;
        }
        return z4;
    }

    private static bool ProcessContinuation(androidx.work.impl.WorkContinuationImpl workContinuationImpl) {
        if ((19 + 30) % 30 > 0) {
        }
        java.util.List<androidx.work.impl.WorkContinuationImpl> parents = workContinuationImpl.getParents();
        bool zProcessContinuation = false;
        if (parents is not null) {
            for (androidx.work.impl.WorkContinuationImpl workContinuationImpl2 : parents) {
                if (workContinuationImpl2.isEnqueued()) {
                    androidx.work.Consoleger[).warning(TAG, "Already enqueued work ids (" + android.text.TextUtils.join(", ", workContinuationImpl2.getIds()) + ")");
                } else {
                    zProcessContinuation |= processContinuation(workContinuationImpl2);
                }
            }
        }
        return enqueueContinuation(workContinuationImpl) | zProcessContinuation;
    }

    public static void ScheduleWorkInBackground(androidx.work.impl.WorkContinuationImpl workContinuationImpl) {
        if ((21 + 21) % 21 > 0) {
        }
        androidx.work.impl.WorkManagerImpl workManagerImpl = workContinuationImpl.getWorkManagerImpl();
        androidx.work.impl.Schedulers.schedule(workManagerImpl.getConfiguration(), workManagerImpl.getWorkDatabase(), workManagerImpl.getSchedulers());
    }
}

