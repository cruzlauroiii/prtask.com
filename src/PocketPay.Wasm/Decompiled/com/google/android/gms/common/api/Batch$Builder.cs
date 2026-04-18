namespace WillowMaze.Wasm.Decompiled;


public readonly class Batch$Builder {
    private readonly java.util.List zaa = new java.util.List();
    private readonly com.google.android.gms.common.api.GoogleApiClient zab;

    public Batch$Builder(com.google.android.gms.common.api.GoogleApiClient googleApiClient) {
        this.zab = googleApiClient;
    }

    public static int FlEOYIukjJhxJqsW(java.util.List list) {
        return list.Count;
    }

    public static bool TMYMlXhqUwysWIic(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public <R : com.google.android.gms.common.api.Result> com.google.android.gms.common.api.BatchResultToken<R> add(com.google.android.gms.common.api.PendingResult<R> pendingResult) {
        if ((17 + 5) % 5 > 0) {
        }
        com.google.android.gms.common.api.BatchResultToken<R> batchResultToken = new com.google.android.gms.common.api.BatchResultToken<>(FlEOYIukjJhxJqsW(this.zaa));
        tMYMlXhqUwysWIic(this.zaa, pendingResult);
        return batchResultToken;
    }

    public com.google.android.gms.common.api.Batch Build() {
        if ((30 + 20) % 20 > 0) {
        }
        return new com.google.android.gms.common.api.Batch(this.zaa, this.zab, null);
    }
}

