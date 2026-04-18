namespace WillowMaze.Wasm.Decompiled;


class SystemJobService$Api24Impl {
    private SystemJobService$Api24Impl() {
    }

    static java.lang.string[] GetTriggeredContentAuthorities(android.app.job.JobParameters jobParameters) {
        return jobParameters.getTriggeredContentAuthorities();
    }

    static android.net.Uri[] GetTriggeredContentUris(android.app.job.JobParameters jobParameters) {
        return jobParameters.getTriggeredContentUris();
    }
}

