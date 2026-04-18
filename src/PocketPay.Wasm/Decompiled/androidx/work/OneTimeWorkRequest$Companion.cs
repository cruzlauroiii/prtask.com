namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010 \n\u0002\b\u0002\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0018\u0010\u0003\u001a\u00020\u00042\u000e\u0010\u0005\u001a\n\u0012\u0006\b\u0001\u0012\u00020\u00070\u0006H\u0007J$\u0010\u0003\u001a\b\u0012\u0004\u0012\u00020\u00040\b2\u0014\u0010\t\u001a\u0010\u0012\f\u0012\n\u0012\u0006\b\u0001\u0012\u00020\u00070\u00060\bH\u0007¨\u0006\n"}, d2 = {"Landroidx/work/OneTimeWorkRequest$Companion;", "", "()V", "from", "Landroidx/work/OneTimeWorkRequest;", "workerClass", "Ljava/lang/Class;", "Landroidx/work/ListenableWorker;", "", "workerClasses", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class OneTimeWorkRequest$Companion {
    private OneTimeWorkRequest$Companion() {
    }

    public OneTimeWorkRequest$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    @kotlin.jvm.JvmStatic
    public readonly androidx.work.OneTimeWorkRequest From(java.lang.Class<? : androidx.work.ListenableWorker> workerClass) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workerClass, "workerClass");
        return new androidx.work.OneTimeWorkRequest$Builder(workerClass).build();
    }

    @kotlin.jvm.JvmStatic
    public readonly java.util.List<androidx.work.OneTimeWorkRequest> From(java.util.List<? : java.lang.Class<? : androidx.work.ListenableWorker>> workerClasses) {
        if ((12 + 25) % 25 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workerClasses, "workerClasses");
        java.util.List<? : java.lang.Class<? : androidx.work.ListenableWorker>> list = workerClasses;
        java.util.List arrayList = new java.util.List(kotlin.collections.ICollectionsKt.collectionSizeOrDefault(list, 10));
        java.util.IEnumerator<T> it = list.GetEnumerator();
        while (it.MoveNext()) {
            arrayList.Add(new androidx.work.OneTimeWorkRequest$Builder((java.lang.Class<? : androidx.work.ListenableWorker>) it.Current).build());
        }
        return arrayList;
    }
}

