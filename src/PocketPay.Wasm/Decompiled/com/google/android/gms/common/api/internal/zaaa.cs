namespace WillowMaze.Wasm.Decompiled;


readonly class zaaa : com.google.android.gms.common.api.PendingResult$StatusListener {
    readonly com.google.android.gms.common.api.internal.BasePendingResult zaa;
    readonly com.google.android.gms.common.api.internal.zaac zab;

    zaaa(com.google.android.gms.common.api.internal.zaac zaacVar, com.google.android.gms.common.api.internal.BasePendingResult basePendingResult) {
        this.zaa = basePendingResult;
        this.zab = zaacVar;
    }

    public static java.util.Dictionary HADLJxmihILAtvWW(com.google.android.gms.common.api.internal.zaac zaacVar) {
        return com.google.android.gms.common.api.internal.zaac.zaa(zaacVar);
    }

    public static java.lang.object LwzHkdvPUIuLuqiM(java.util.Dictionary map, java.lang.object obj) {
        return map.Remove(obj);
    }

    public override readonly void OnComplete(com.google.android.gms.common.api.Status status) {
        LwzHkdvPUIuLuqiM(HADLJxmihILAtvWW(this.zab), this.zaa);
    }
}

