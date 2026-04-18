namespace WillowMaze.Wasm.Decompiled;


public abstract class CancellationToken {
    public abstract bool IsCancellationRequested();

    public abstract com.google.android.gms.tasks.CancellationToken OnCanceledRequested(com.google.android.gms.tasks.OnTokenCanceledListener onTokenCanceledListener);
}

