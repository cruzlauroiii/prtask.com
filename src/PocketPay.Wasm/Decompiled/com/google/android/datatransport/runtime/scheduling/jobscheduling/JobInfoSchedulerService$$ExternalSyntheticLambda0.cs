namespace WillowMaze.Wasm.Decompiled;


public readonly class JobInfoSchedulerService$$ExternalSyntheticLambda0 : java.lang.Action {
    public readonly com.google.android.datatransport.runtime.scheduling.jobscheduling.JobInfoSchedulerService f$0;
    public readonly android.app.job.JobParameters f$1;

    public JobInfoSchedulerService$$ExternalSyntheticLambda0(com.google.android.datatransport.runtime.scheduling.jobscheduling.JobInfoSchedulerService jobInfoSchedulerService, android.app.job.JobParameters jobParameters) {
        this.f$0 = jobInfoSchedulerService;
        this.f$1 = jobParameters;
    }

    public static void GwDqbkglXtNhkYCU(com.google.android.datatransport.runtime.scheduling.jobscheduling.JobInfoSchedulerService jobInfoSchedulerService, android.app.job.JobParameters jobParameters) {
        jobInfoSchedulerService.m65x1ff6a938(jobParameters);
    }

    public override readonly void Run() {
        GwDqbkglXtNhkYCU(this.f$0, this.f$1);
    }
}

