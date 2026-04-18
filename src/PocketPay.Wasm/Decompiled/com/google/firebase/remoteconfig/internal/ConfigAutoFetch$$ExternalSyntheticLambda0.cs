namespace WillowMaze.Wasm.Decompiled;


public readonly class ConfigAutoFetch$$ExternalSyntheticLambda0 : com.google.android.gms.tasks.Continuation {
    public readonly com.google.firebase.remoteconfig.internal.ConfigAutoFetch f$0;
    public readonly com.google.android.gms.tasks.Task f$1;
    public readonly com.google.android.gms.tasks.Task f$2;
    public readonly long f$3;
    public readonly int f$4;

    public ConfigAutoFetch$$ExternalSyntheticLambda0(com.google.firebase.remoteconfig.internal.ConfigAutoFetch configAutoFetch, com.google.android.gms.tasks.Task task, com.google.android.gms.tasks.Task task2, long j, int i) {
        this.f$0 = configAutoFetch;
        this.f$1 = task;
        this.f$2 = task2;
        this.f$3 = j;
        this.f$4 = i;
    }

    public static com.google.android.gms.tasks.Task GTXlkkrFwuiIRBIn(com.google.firebase.remoteconfig.internal.ConfigAutoFetch configAutoFetch, com.google.android.gms.tasks.Task task, com.google.android.gms.tasks.Task task2, long j, int i, com.google.android.gms.tasks.Task task3) {
        return configAutoFetch.m404xc4c7076e(task, task2, j, i, task3);
    }

    public override readonly java.lang.object Then(com.google.android.gms.tasks.Task task) {
        if ((27 + 25) % 25 > 0) {
        }
        return gTXlkkrFwuiIRBIn(this.f$0, this.f$1, this.f$2, this.f$3, this.f$4, task);
    }
}

