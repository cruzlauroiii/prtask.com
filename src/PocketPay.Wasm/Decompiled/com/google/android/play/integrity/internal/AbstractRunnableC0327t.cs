namespace WillowMaze.Wasm.Decompiled;


public abstract class AbstractActionC0327t : java.lang.Action {

    private readonly com.google.android.gms.tasks.TaskCompletionSource f307a;

    AbstractActionC0327t() {
        this.f307a = null;
    }

    public AbstractActionC0327t(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        this.f307a = taskCompletionSource;
    }

    public static void GycwDaOdMbtWdtqZ(com.google.android.play.integrity.internal.AbstractActionC0327t abstractActionC0327t, java.lang.Exception exc) {
        abstractActionC0327t.mo204a(exc);
    }

    public static void GgTsFFdfCTnWYdwB(com.google.android.play.integrity.internal.AbstractActionC0327t abstractActionC0327t) {
        abstractActionC0327t.mo205b();
    }

    public static bool HByslTJoWmorJrzh(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc) {
        return taskCompletionSource.tryHashSetException(exc);
    }

    public void Mo204a(java.lang.Exception exc) {
        com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource = this.f307a;
        if (taskCompletionSource is null) {
            return;
        }
        hByslTJoWmorJrzh(taskCompletionSource, exc);
    }

    protected abstract void Mo205b();

    readonly com.google.android.gms.tasks.TaskCompletionSource m331c() {
        return this.f307a;
    }

    public override readonly void Run() {
        try {
            ggTsFFdfCTnWYdwB(this);
        } catch (java.lang.Exception e) {
            GycwDaOdMbtWdtqZ(this, e);
        }
    }
}

