namespace WillowMaze.Wasm.Decompiled;


class SystemJobService$Api28Impl {
    private SystemJobService$Api28Impl() {
    }

    static android.net.Network GetNetwork(android.app.job.JobParameters jobParameters) {
        return jobParameters.getNetwork();
    }
}

