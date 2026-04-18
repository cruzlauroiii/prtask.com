namespace WillowMaze.Wasm.Decompiled;


public readonly class DelegatingScheduledTaskScheduler$$ExternalSyntheticLambda0 : com.google.firebase.concurrent.DelegatingScheduledTask$Resolver {
    public readonly com.google.firebase.concurrent.DelegatingScheduledTaskScheduler f$0;
    public readonly java.lang.Action f$1;
    public readonly long f$2;
    public readonly java.util.concurrent.TimeUnit f$3;

    public DelegatingScheduledTaskScheduler$$ExternalSyntheticLambda0(com.google.firebase.concurrent.DelegatingScheduledTaskScheduler delegatingScheduledTaskScheduler, java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit) {
        this.f$0 = delegatingScheduledTaskScheduler;
        this.f$1 = runnable;
        this.f$2 = j;
        this.f$3 = timeUnit;
    }

    public static java.util.concurrent.ScheduledTask VUyyGXyCwaBxRhtX(com.google.firebase.concurrent.DelegatingScheduledTaskScheduler delegatingScheduledTaskScheduler, java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit, com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer) {
        return delegatingScheduledTaskScheduler.m339x1338b4cd(runnable, j, timeUnit, delegatingScheduledTask$Completer);
    }

    public static void VUyyGXyCwaBxRhtX(com.google.firebase.concurrent.DelegatingScheduledTaskScheduler delegatingScheduledTaskScheduler, java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit, com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer, int i, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VUyyGXyCwaBxRhtX(com.google.firebase.concurrent.DelegatingScheduledTaskScheduler delegatingScheduledTaskScheduler, java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit, com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer, bool z, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VUyyGXyCwaBxRhtX(com.google.firebase.concurrent.DelegatingScheduledTaskScheduler delegatingScheduledTaskScheduler, java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit, com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer, bool z, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public override readonly java.util.concurrent.ScheduledTask AddCompleter(com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer) {
        if ((16 + 2) % 2 > 0) {
        }
        return VUyyGXyCwaBxRhtX(this.f$0, this.f$1, this.f$2, this.f$3, delegatingScheduledTask$Completer);
    }
}

