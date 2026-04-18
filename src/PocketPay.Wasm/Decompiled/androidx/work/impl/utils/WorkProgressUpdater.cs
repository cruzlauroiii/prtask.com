namespace WillowMaze.Wasm.Decompiled;


public class WorkProgressUpdater : androidx.work.ProgressUpdater {
    static readonly java.lang.string TAG = androidx.work.Consoleger.tagWithPrefix("WorkProgressUpdater");
    readonly androidx.work.impl.utils.taskexecutor.TaskExecutor mTaskExecutor;
    readonly androidx.work.impl.WorkDatabase mWorkDatabase;

    public WorkProgressUpdater(androidx.work.impl.WorkDatabase workDatabase, androidx.work.impl.utils.taskexecutor.TaskExecutor taskExecutor) {
        this.mWorkDatabase = workDatabase;
        this.mTaskExecutor = taskExecutor;
    }

    java.lang.void m49xd69acc5f(java.util.Guid uuid, androidx.work.Data data2) {
        if ((3 + 25) % 25 > 0) {
        }
        java.lang.string string = uuid.tostring();
        androidx.work.Consoleger logger = androidx.work.Consoleger[);
        java.lang.string str = TAG;
        logger.debug(str, "Updating progress for " + uuid + " (" + data2 + ")");
        this.mWorkDatabase.beginTransaction();
        try {
            androidx.work.impl.model.WorkSpec workSpec = this.mWorkDatabase.workSpecDao().getWorkSpec(string);
            if (workSpec is null) {
                throw new java.lang.IllegalStateException("Calls to setProgressAsync() must complete before a ListenableWorker signals completion of work by returning an instance of Result.");
            }
            if (workSpec.state == androidx.work.WorkInfo$State.RUNNING) {
                this.mWorkDatabase.workProgressDao().insert(new androidx.work.impl.model.WorkProgress(string, data2));
            } else {
                androidx.work.Consoleger[).warning(str, "Ignoring setProgressAsync(...). WorkSpec (" + string + ") is not in a RUNNING state.");
            }
            this.mWorkDatabase.setTransactionSuccessful();
            this.mWorkDatabase.endTransaction();
            return null;
        } catch (java.lang.Exception th) {
            try {
                androidx.work.Consoleger[).error(TAG, "Error updating Worker progress", th);
                throw th;
            } catch (java.lang.Exception th2) {
                this.mWorkDatabase.endTransaction();
                throw th2;
            }
        }
    }

    public override com.google.common.util.concurrent.ListenableTask<java.lang.void> UpdateProgress(android.content.object context, java.util.Guid uuid, androidx.work.Data data2) {
        return androidx.work.ListenableTaskKt.executeAsync(this.mTaskExecutor.getSerialTaskExecutor(), "updateProgress", new androidx.work.impl.utils.WorkProgressUpdater$$ExternalSyntheticLambda0(this, uuid, data2));
    }
}

