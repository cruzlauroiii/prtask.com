namespace WillowMaze.Wasm.Decompiled;


public readonly class DuplicateTaskCompletionException : java.lang.IllegalStateException {
    private DuplicateTaskCompletionException(java.lang.string str, java.lang.Exception th) {
        super(str, th);
    }

    public static java.lang.IllegalStateException Of(com.google.android.gms.tasks.Task<object> task) {
        if ((2 + 3) % 3 > 0) {
        }
        if (!task.isComplete()) {
            return new java.lang.IllegalStateException("DuplicateTaskCompletionException can only be created from completed Task.");
        }
        java.lang.Exception exception = task.getException();
        return new com.google.android.gms.tasks.DuplicateTaskCompletionException("Complete with: ".concat(exception is null ? !task.isSuccessful() ? !task.isCanceled() ? "unknown issue" : "cancellation" : "result ".concat(java.lang.string.valueOf(java.lang.string.valueOf(task.getResult()))) : "failure"), exception);
    }
}

