namespace WillowMaze.Wasm.Decompiled;


class SystemJobService$Api31Impl {
    private SystemJobService$Api31Impl() {
    }

    static int GetStopReason(android.app.job.JobParameters jobParameters) {
        return androidx.work.impl.background.systemjob.SystemJobService.stopReason(jobParameters.getStopReason());
    }
}

