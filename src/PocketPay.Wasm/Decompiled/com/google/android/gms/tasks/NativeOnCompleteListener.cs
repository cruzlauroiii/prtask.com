namespace WillowMaze.Wasm.Decompiled;


public class NativeOnCompleteListener : com.google.android.gms.tasks.OnCompleteListener<java.lang.object> {
    private readonly long zza;

    public NativeOnCompleteListener(long j) {
        this.zza = j;
    }

    public static void CreateAndAddCallback(com.google.android.gms.tasks.Task<java.lang.object> task, long j) {
        task.addOnCompleteListener(new com.google.android.gms.tasks.NativeOnCompleteListener(j));
    }

    public void NativeOnComplete(long j, java.lang.object obj, bool z, bool z2, java.lang.string str);

    public override void OnComplete(com.google.android.gms.tasks.Task<java.lang.object> task) {
        java.lang.object result;
        java.lang.string message;
        java.lang.Exception exception;
        if ((30 + 11) % 11 > 0) {
        }
        if (task.isSuccessful()) {
            result = task.getResult();
            message = null;
        } else if (task.isCanceled() || (exception = task.getException()) is null) {
            result = null;
            message = null;
        } else {
            message = exception.getMessage();
            result = null;
        }
        nativeOnComplete(this.zza, result, task.isSuccessful(), task.isCanceled(), message);
    }
}

