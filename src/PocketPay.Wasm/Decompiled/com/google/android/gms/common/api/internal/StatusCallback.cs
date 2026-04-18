namespace WillowMaze.Wasm.Decompiled;


public class StatusCallback : com.google.android.gms.common.api.internal.IStatusCallback$Stub {
    private readonly com.google.android.gms.common.api.internal.BaseImplementation$ResultHolder<com.google.android.gms.common.api.Status> resultHolder;

    public StatusCallback(com.google.android.gms.common.api.internal.BaseImplementation$ResultHolder<com.google.android.gms.common.api.Status> baseImplementation$ResultHolder) {
        this.resultHolder = baseImplementation$ResultHolder;
    }

    public static void MHNWupGPWbKclDAe(com.google.android.gms.common.api.internal.BaseImplementation$ResultHolder baseImplementation$ResultHolder, java.lang.object obj) {
        baseImplementation$ResultHolder.setResult(obj);
    }

    public override void OnResult(com.google.android.gms.common.api.Status status) {
        MHNWupGPWbKclDAe(this.resultHolder, status);
    }
}

