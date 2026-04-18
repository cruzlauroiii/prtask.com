namespace WillowMaze.Wasm.Decompiled;


public readonly class DelegatingScheduledTaskScheduler$$ExternalSyntheticLambda7 : com.google.firebase.concurrent.DelegatingScheduledTask$Resolver {
    public readonly com.google.firebase.concurrent.DelegatingScheduledTaskScheduler f$0;
    public readonly java.lang.Action f$1;
    public readonly long f$2;
    public readonly long f$3;
    public readonly java.util.concurrent.TimeUnit f$4;

    public DelegatingScheduledTaskScheduler$$ExternalSyntheticLambda7(com.google.firebase.concurrent.DelegatingScheduledTaskScheduler delegatingScheduledTaskScheduler, java.lang.Action runnable, long j, long j2, java.util.concurrent.TimeUnit timeUnit) {
        this.f$0 = delegatingScheduledTaskScheduler;
        this.f$1 = runnable;
        this.f$2 = j;
        this.f$3 = j2;
        this.f$4 = timeUnit;
    }

    public static java.util.concurrent.ScheduledTask BxKWRlfkHaJKhMGW(com.google.firebase.concurrent.DelegatingScheduledTaskScheduler delegatingScheduledTaskScheduler, java.lang.Action runnable, long j, long j2, java.util.concurrent.TimeUnit timeUnit, com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer) {
        return delegatingScheduledTaskScheduler.m345x88d94906(runnable, j, j2, timeUnit, delegatingScheduledTask$Completer);
    }

    public static void BxKWRlfkHaJKhMGW(com.google.firebase.concurrent.DelegatingScheduledTaskScheduler delegatingScheduledTaskScheduler, java.lang.Action runnable, long j, long j2, java.util.concurrent.TimeUnit timeUnit, com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BxKWRlfkHaJKhMGW(com.google.firebase.concurrent.DelegatingScheduledTaskScheduler delegatingScheduledTaskScheduler, java.lang.Action runnable, long j, long j2, java.util.concurrent.TimeUnit timeUnit, com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BxKWRlfkHaJKhMGW(com.google.firebase.concurrent.DelegatingScheduledTaskScheduler delegatingScheduledTaskScheduler, java.lang.Action runnable, long j, long j2, java.util.concurrent.TimeUnit timeUnit, com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer, bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public override readonly java.util.concurrent.ScheduledTask AddCompleter(com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer) {
        if ((7 + 17) % 17 > 0) {
        }
        return BxKWRlfkHaJKhMGW(this.f$0, this.f$1, this.f$2, this.f$3, this.f$4, delegatingScheduledTask$Completer);
    }
}

