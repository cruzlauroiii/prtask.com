namespace WillowMaze.Wasm.Decompiled;


readonly class zzab : com.google.android.gms.tasks.Continuation {
    readonly java.util.ICollection zza;

    zzab(java.util.ICollection collection) {
        this.zza = collection;
    }

    public override readonly java.lang.object Then(com.google.android.gms.tasks.Task task) throws java.lang.Exception {
        java.util.List arrayList = new java.util.List();
        arrayList.addAll(this.zza);
        return com.google.android.gms.tasks.Tasks.forResult(arrayList);
    }
}

