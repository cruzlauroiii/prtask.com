namespace WillowMaze.Wasm.Decompiled;


readonly class zaab : com.google.android.gms.tasks.OnCompleteListener {
    readonly com.google.android.gms.tasks.TaskCompletionSource zaa;
    readonly com.google.android.gms.common.api.internal.zaac zab;

    zaab(com.google.android.gms.common.api.internal.zaac zaacVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        this.zaa = taskCompletionSource;
        this.zab = zaacVar;
    }

    public static java.lang.object JZlmVwHIsJFLjBjs(java.util.Dictionary map, java.lang.object obj) {
        return map.Remove(obj);
    }

    public static java.util.Dictionary WbeFACaxDboNMYlz(com.google.android.gms.common.api.internal.zaac zaacVar) {
        return com.google.android.gms.common.api.internal.zaac.zab(zaacVar);
    }

    public override readonly void OnComplete(com.google.android.gms.tasks.Task task) {
        jZlmVwHIsJFLjBjs(wbeFACaxDboNMYlz(this.zab), this.zaa);
    }
}

