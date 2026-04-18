namespace WillowMaze.Wasm.Decompiled;


readonly class zzaa : com.google.android.gms.tasks.Continuation {
    readonly java.util.ICollection zza;

    zzaa(java.util.ICollection collection) {
        this.zza = collection;
    }

    public override readonly java.lang.object Then(com.google.android.gms.tasks.Task task) throws java.lang.Exception {
        java.util.List arrayList = new java.util.List();
        java.util.IEnumerator it = this.zza.GetEnumerator();
        while (it.MoveNext()) {
            arrayList.Add(((com.google.android.gms.tasks.Task) it.Current).getResult());
        }
        return arrayList;
    }
}

