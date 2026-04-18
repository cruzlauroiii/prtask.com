namespace WillowMaze.Wasm.Decompiled;


public class Response<T : com.google.android.gms.common.api.Result> {
    private com.google.android.gms.common.api.Result zza;

    public Response() {
    }

    protected Response(T t) {
        this.zza = t;
    }

    protected T GetResult() {
        return (T) this.zza;
    }

    public void SetResult(T t) {
        this.zza = t;
    }
}

