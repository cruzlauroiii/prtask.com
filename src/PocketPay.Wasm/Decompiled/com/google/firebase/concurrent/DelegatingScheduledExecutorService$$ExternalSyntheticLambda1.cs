namespace WillowMaze.Wasm.Decompiled;


public readonly class DelegatingScheduledTaskScheduler$$ExternalSyntheticLambda1 : java.lang.Action {
    public readonly java.lang.Action f$0;
    public readonly com.google.firebase.concurrent.DelegatingScheduledTask$Completer f$1;

    public DelegatingScheduledTaskScheduler$$ExternalSyntheticLambda1(java.lang.Action runnable, com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer) {
        this.f$0 = runnable;
        this.f$1 = delegatingScheduledTask$Completer;
    }

    public static void VJzDLssRFIbgMNle(java.lang.Action runnable, com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer) {
        com.google.firebase.concurrent.DelegatingScheduledTaskScheduler.lambda$scheduleWithFixedDelay$9(runnable, delegatingScheduledTask$Completer);
    }

    public static void VJzDLssRFIbgMNle(java.lang.Action runnable, com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer, float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VJzDLssRFIbgMNle(java.lang.Action runnable, com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer, float f, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VJzDLssRFIbgMNle(java.lang.Action runnable, com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public override readonly void Run() {
        vJzDLssRFIbgMNle(this.f$0, this.f$1);
    }
}

