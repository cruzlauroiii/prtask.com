namespace WillowMaze.Wasm.Decompiled;


readonly class zzea : com.google.android.gms.tasks.OnCompleteListener {
    private readonly com.google.android.gms.tasks.TaskCompletionSource zza;

    zzea(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        this.zza = taskCompletionSource;
    }

    public static void PdJAjoxbqaMUjYrF(com.google.android.gms.tasks.Task task, short s, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PdJAjoxbqaMUjYrF(com.google.android.gms.tasks.Task task, bool z, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PdJAjoxbqaMUjYrF(com.google.android.gms.tasks.Task task, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool PdJAjoxbqaMUjYrF(com.google.android.gms.tasks.Task task) {
        return task.isSuccessful();
    }

    public static java.lang.object TRgGkodNeegeKlyJ(java.lang.object obj) {
        return java.util.objects.requireNonNull(obj);
    }

    public static void TRgGkodNeegeKlyJ(java.lang.object obj, char c, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TRgGkodNeegeKlyJ(java.lang.object obj, char c, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TRgGkodNeegeKlyJ(java.lang.object obj, int i, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.Exception LczpeqZTksyexAST(com.google.android.gms.tasks.Task task) {
        return task.getException();
    }

    public static void LczpeqZTksyexAST(com.google.android.gms.tasks.Task task, char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LczpeqZTksyexAST(com.google.android.gms.tasks.Task task, java.lang.string str, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LczpeqZTksyexAST(com.google.android.gms.tasks.Task task, short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TNhWwwQOwDhKAvqI(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc, float f, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TNhWwwQOwDhKAvqI(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TNhWwwQOwDhKAvqI(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc, bool z, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool TNhWwwQOwDhKAvqI(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc) {
        return taskCompletionSource.tryHashSetException(exc);
    }

    public override readonly void OnComplete(com.google.android.gms.tasks.Task task) {
        int i = com.google.android.gms.internal.identity.zzdz.zze;
        if (PdJAjoxbqaMUjYrF(task)) {
            return;
        }
        tNhWwwQOwDhKAvqI(this.zza, (java.lang.Exception) TRgGkodNeegeKlyJ(lczpeqZTksyexAST(task)));
    }
}

