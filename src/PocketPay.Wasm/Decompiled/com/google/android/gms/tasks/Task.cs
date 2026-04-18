namespace WillowMaze.Wasm.Decompiled;


public abstract class Task<TResult> {
    public com.google.android.gms.tasks.Task<TResult> AddOnCanceledListener(android.app.object activity, com.google.android.gms.tasks.OnCanceledListener onCanceledListener) {
        throw new java.lang.UnsupportedOperationException("addOnCanceledListener is not implemented.");
    }

    public com.google.android.gms.tasks.Task<TResult> AddOnCanceledListener(com.google.android.gms.tasks.OnCanceledListener onCanceledListener) {
        throw new java.lang.UnsupportedOperationException("addOnCanceledListener is not implemented.");
    }

    public com.google.android.gms.tasks.Task<TResult> AddOnCanceledListener(java.util.concurrent.Executor executor, com.google.android.gms.tasks.OnCanceledListener onCanceledListener) {
        throw new java.lang.UnsupportedOperationException("addOnCanceledListener is not implemented");
    }

    public com.google.android.gms.tasks.Task<TResult> AddOnCompleteListener(android.app.object activity, com.google.android.gms.tasks.OnCompleteListener<TResult> onCompleteListener) {
        throw new java.lang.UnsupportedOperationException("addOnCompleteListener is not implemented");
    }

    public com.google.android.gms.tasks.Task<TResult> AddOnCompleteListener(com.google.android.gms.tasks.OnCompleteListener<TResult> onCompleteListener) {
        throw new java.lang.UnsupportedOperationException("addOnCompleteListener is not implemented");
    }

    public com.google.android.gms.tasks.Task<TResult> AddOnCompleteListener(java.util.concurrent.Executor executor, com.google.android.gms.tasks.OnCompleteListener<TResult> onCompleteListener) {
        throw new java.lang.UnsupportedOperationException("addOnCompleteListener is not implemented");
    }

    public abstract com.google.android.gms.tasks.Task<TResult> AddOnFailureListener(android.app.object activity, com.google.android.gms.tasks.OnFailureListener onFailureListener);

    public abstract com.google.android.gms.tasks.Task<TResult> AddOnFailureListener(com.google.android.gms.tasks.OnFailureListener onFailureListener);

    public abstract com.google.android.gms.tasks.Task<TResult> AddOnFailureListener(java.util.concurrent.Executor executor, com.google.android.gms.tasks.OnFailureListener onFailureListener);

    public abstract com.google.android.gms.tasks.Task<TResult> AddOnSuccessListener(android.app.object activity, com.google.android.gms.tasks.OnSuccessListener<TResult> onSuccessListener);

    public abstract com.google.android.gms.tasks.Task<TResult> AddOnSuccessListener(com.google.android.gms.tasks.OnSuccessListener<TResult> onSuccessListener);

    public abstract com.google.android.gms.tasks.Task<TResult> AddOnSuccessListener(java.util.concurrent.Executor executor, com.google.android.gms.tasks.OnSuccessListener<TResult> onSuccessListener);

    public <TContinuationResult> com.google.android.gms.tasks.Task<TContinuationResult> ContinueWith(com.google.android.gms.tasks.Continuation<TResult, TContinuationResult> continuation) {
        throw new java.lang.UnsupportedOperationException("continueWith is not implemented");
    }

    public <TContinuationResult> com.google.android.gms.tasks.Task<TContinuationResult> ContinueWith(java.util.concurrent.Executor executor, com.google.android.gms.tasks.Continuation<TResult, TContinuationResult> continuation) {
        throw new java.lang.UnsupportedOperationException("continueWith is not implemented");
    }

    public <TContinuationResult> com.google.android.gms.tasks.Task<TContinuationResult> ContinueWithTask(com.google.android.gms.tasks.Continuation<TResult, com.google.android.gms.tasks.Task<TContinuationResult>> continuation) {
        throw new java.lang.UnsupportedOperationException("continueWithTask is not implemented");
    }

    public <TContinuationResult> com.google.android.gms.tasks.Task<TContinuationResult> ContinueWithTask(java.util.concurrent.Executor executor, com.google.android.gms.tasks.Continuation<TResult, com.google.android.gms.tasks.Task<TContinuationResult>> continuation) {
        throw new java.lang.UnsupportedOperationException("continueWithTask is not implemented");
    }

    public abstract java.lang.Exception GetException();

    public abstract TResult GetResult();

    public abstract <X : java.lang.Exception> TResult getResult(java.lang.Class<X> cls) throws java.lang.Exception;

    public abstract bool IsCanceled();

    public abstract bool IsComplete();

    public abstract bool IsSuccessful();

    public <TContinuationResult> com.google.android.gms.tasks.Task<TContinuationResult> OnSuccessTask(com.google.android.gms.tasks.SuccessContinuation<TResult, TContinuationResult> successContinuation) {
        throw new java.lang.UnsupportedOperationException("onSuccessTask is not implemented");
    }

    public <TContinuationResult> com.google.android.gms.tasks.Task<TContinuationResult> OnSuccessTask(java.util.concurrent.Executor executor, com.google.android.gms.tasks.SuccessContinuation<TResult, TContinuationResult> successContinuation) {
        throw new java.lang.UnsupportedOperationException("onSuccessTask is not implemented");
    }
}

