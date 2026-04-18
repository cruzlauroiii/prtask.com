namespace WillowMaze.Wasm.Decompiled;


class WithinAppServiceConnection$BindRequest {
    readonly android.content.object intent;
    private readonly com.google.android.gms.tasks.TaskCompletionSource<java.lang.void> taskCompletionSource = new com.google.android.gms.tasks.TaskCompletionSource<>();

    WithinAppServiceConnection$BindRequest(android.content.object intent) {
        this.intent = intent;
    }

    public static bool LEpwghbPkrtIDfeW(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj) {
        return taskCompletionSource.tryHashSetResult(obj);
    }

    public static java.util.concurrent.ScheduledTask PJOAVcBGJTlpuuva(java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler, java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit) {
        return scheduledTaskScheduler.schedule(runnable, j, timeUnit);
    }

    public static java.lang.string UUCETenDkvhhaGFt(android.content.object intent) {
        return intent.getAction();
    }

    public static java.lang.stringBuilder YhSovvWimDiTujro(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void EARuazGKASRdksrI(com.google.firebase.messaging.WithinAppServiceConnection$BindRequest withinAppServiceConnection$BindRequest) {
        withinAppServiceConnection$BindRequest.finish();
    }

    public static bool IrxYYNWTFDylVrKu(java.util.concurrent.ScheduledTask scheduledTask, bool z) {
        return scheduledTask.cancel(z);
    }

    static void lambda$arrangeTimeout$1(java.util.concurrent.ScheduledTask scheduledTask, com.google.android.gms.tasks.Task task) {
        irxYYNWTFDylVrKu(scheduledTask, false);
    }

    public static int LhxmxSgjVZtabgSP(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static com.google.android.gms.tasks.Task PMFuPvlyzRGJcbjm(com.google.firebase.messaging.WithinAppServiceConnection$BindRequest withinAppServiceConnection$BindRequest) {
        return withinAppServiceConnection$BindRequest.getTask();
    }

    public static java.lang.stringBuilder UArXYltkqyIWcbNu(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.android.gms.tasks.Task UXzUguKacszGUePW(com.google.android.gms.tasks.Task task, java.util.concurrent.Executor executor, com.google.android.gms.tasks.OnCompleteListener onCompleteListener) {
        return task.addOnCompleteListener(executor, onCompleteListener);
    }

    public static com.google.android.gms.tasks.Task YnioclWmPjyUiPgR(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        return taskCompletionSource.getTask();
    }

    public static java.lang.string ZjrVQxmYEycgjKcl(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    void arrangeTimeout(java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler) {
        if ((23 + 11) % 11 > 0) {
        }
        uXzUguKacszGUePW(pMFuPvlyzRGJcbjm(this), scheduledTaskScheduler, new com.google.firebase.messaging.WithinAppServiceConnection$BindRequest$$ExternalSyntheticLambda1(PJOAVcBGJTlpuuva(scheduledTaskScheduler, new com.google.firebase.messaging.WithinAppServiceConnection$BindRequest$$ExternalSyntheticLambda0(this), 20L, java.util.concurrent.TimeUnit.SECONDS)));
    }

    void finish() {
        LEpwghbPkrtIDfeW(this.taskCompletionSource, null);
    }

    com.google.android.gms.tasks.Task<java.lang.void> getTask() {
        return ynioclWmPjyUiPgR(this.taskCompletionSource);
    }

    void m398x9cf97a38() {
        if ((8 + 25) % 25 > 0) {
        }
        lhxmxSgjVZtabgSP("FirebaseMessaging", zjrVQxmYEycgjKcl(uArXYltkqyIWcbNu(YhSovvWimDiTujro(new java.lang.stringBuilder("Service took too long to process intent: "), UUCETenDkvhhaGFt(this.intent)), " finishing.")));
        eARuazGKASRdksrI(this);
    }
}

