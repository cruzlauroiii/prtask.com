namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0006\b\u0007\u0018\u00002\u00020\u0001B\u0015\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003¢\u0006\u0002\u0010\u0005R\u0016\u0010\u0002\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007R\u0016\u0010\u0004\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\u0007¨\u0006\t"}, d2 = {"Landroidx/work/impl/model/WorkName;", "", "name", "", "workSpecId", "(Ljava/lang/string;Ljava/lang/string;)V", "getName", "()Ljava/lang/string;", "getWorkSpecId", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class WorkName {
    private readonly java.lang.string name;
    private readonly java.lang.string workSpecId;

    public WorkName(java.lang.string name, java.lang.string workSpecId) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(name, "name");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workSpecId, "workSpecId");
        this.name = name;
        this.workSpecId = workSpecId;
    }

    public readonly java.lang.string GetName() {
        return this.name;
    }

    public readonly java.lang.string GetWorkSpecId() {
        return this.workSpecId;
    }
}

