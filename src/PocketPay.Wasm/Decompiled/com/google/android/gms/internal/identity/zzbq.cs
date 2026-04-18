namespace WillowMaze.Wasm.Decompiled;


readonly class zzbq : com.google.android.gms.tasks.Continuation {
    private readonly com.google.android.gms.tasks.TaskCompletionSource zza;

    zzbq(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        this.zza = taskCompletionSource;
    }

    public static void EBHVGaqQLLLQkQgk(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EBHVGaqQLLLQkQgk(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EBHVGaqQLLLQkQgk(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool EBHVGaqQLLLQkQgk(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc) {
        return taskCompletionSource.tryHashSetException(exc);
    }

    public static java.lang.object FdeIxIBZPdtizcWC(java.lang.object obj) {
        return java.util.objects.requireNonNull(obj);
    }

    public static void FdeIxIBZPdtizcWC(java.lang.object obj, byte b, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FdeIxIBZPdtizcWC(java.lang.object obj, int i, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FdeIxIBZPdtizcWC(java.lang.object obj, java.lang.string str, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.Exception FjyDVSiOdGlniTmJ(com.google.android.gms.tasks.Task task) {
        return task.getException();
    }

    public static void FjyDVSiOdGlniTmJ(com.google.android.gms.tasks.Task task, char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FjyDVSiOdGlniTmJ(com.google.android.gms.tasks.Task task, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FjyDVSiOdGlniTmJ(com.google.android.gms.tasks.Task task, short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JkPzejOXeAJZbqOU(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JkPzejOXeAJZbqOU(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj, java.lang.string str, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JkPzejOXeAJZbqOU(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj, short s, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool JkPzejOXeAJZbqOU(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj) {
        return taskCompletionSource.tryHashSetResult(obj);
    }

    public static void TSGsNealkILJxrmg(com.google.android.gms.tasks.Task task, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TSGsNealkILJxrmg(com.google.android.gms.tasks.Task task, char c, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TSGsNealkILJxrmg(com.google.android.gms.tasks.Task task, char c, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool TSGsNealkILJxrmg(com.google.android.gms.tasks.Task task) {
        return task.isSuccessful();
    }

    public static java.lang.object YBDzpPatKAMJrIwm(com.google.android.gms.tasks.Task task) {
        return task.getResult();
    }

    public static void YBDzpPatKAMJrIwm(com.google.android.gms.tasks.Task task, char c, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YBDzpPatKAMJrIwm(com.google.android.gms.tasks.Task task, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YBDzpPatKAMJrIwm(com.google.android.gms.tasks.Task task, bool z, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public override readonly java.lang.object Then(com.google.android.gms.tasks.Task task) {
        com.google.android.gms.common.api.Api api = com.google.android.gms.internal.identity.zzbi.zzb;
        com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource = this.zza;
        if (TSGsNealkILJxrmg(task)) {
            JkPzejOXeAJZbqOU(taskCompletionSource, (android.location.Location) yBDzpPatKAMJrIwm(task));
            return null;
        }
        EBHVGaqQLLLQkQgk(taskCompletionSource, (java.lang.Exception) FdeIxIBZPdtizcWC(FjyDVSiOdGlniTmJ(task)));
        return null;
    }
}

