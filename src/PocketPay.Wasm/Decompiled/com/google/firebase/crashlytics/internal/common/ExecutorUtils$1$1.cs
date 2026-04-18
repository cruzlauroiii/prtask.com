namespace WillowMaze.Wasm.Decompiled;


class ExecutorUtils$1$1 : com.google.firebase.crashlytics.internal.common.BackgroundPriorityAction {
    readonly com.google.firebase.crashlytics.internal.common.ExecutorUtils$1 this$0;
    readonly java.lang.Action val$runnable;

    ExecutorUtils$1$1(com.google.firebase.crashlytics.internal.common.ExecutorUtils$1 executorUtils$1, java.lang.Action runnable) {
        this.this$0 = executorUtils$1;
        this.val$runnable = runnable;
    }

    public static void WOaJkRaDBFWLCpSM(java.lang.Action runnable) {
        runnable.run();
    }

    public static void WOaJkRaDBFWLCpSM(java.lang.Action runnable, byte b, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WOaJkRaDBFWLCpSM(java.lang.Action runnable, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WOaJkRaDBFWLCpSM(java.lang.Action runnable, int i, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public override void OnRun() {
        WOaJkRaDBFWLCpSM(this.val$runnable);
    }
}

