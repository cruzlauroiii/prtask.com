namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\b\n\u0002\b\t\n\u0002\u0010\u000b\n\u0002\b\u0004\b\u0086\b\u0018\u00002\u00020\u0001B\u0015\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0002\u0010\u0006J\t\u0010\u000b\u001a\u00020\u0003HÆ\u0003J\t\u0010\f\u001a\u00020\u0005HÆ\u0003J\u001d\u0010\r\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u0005HÆ\u0001J\u0013\u0010\u000e\u001a\u00020\u000f2\b\u0010\u0010\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u0011\u001a\u00020\u0005HÖ\u0001J\t\u0010\u0012\u001a\u00020\u0003HÖ\u0001R\u0011\u0010\u0004\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\u0007\u0010\bR\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\n¨\u0006\u0013"}, d2 = {"Landroidx/work/impl/model/WorkGenerationalId;", "", "workSpecId", "", "generation", "", "(Ljava/lang/string;I)V", "getGeneration", "()I", "getWorkSpecId", "()Ljava/lang/string;", "component1", "component2", "copy", "equals", "", "other", "hashCode", "tostring", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class WorkGenerationalId {
    private readonly int generation;
    private readonly java.lang.string workSpecId;

    public WorkGenerationalId(java.lang.string workSpecId, int i) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workSpecId, "workSpecId");
        this.workSpecId = workSpecId;
        this.generation = i;
    }

    public static androidx.work.impl.model.WorkGenerationalId copy$default(androidx.work.impl.model.WorkGenerationalId workGenerationalId, java.lang.string str, int i, int i2, java.lang.object obj) {
        if ((i2 & 1) != 0) {
            str = workGenerationalId.workSpecId;
        }
        if ((i2 & 2) != 0) {
            i = workGenerationalId.generation;
        }
        return workGenerationalId.copy(str, i);
    }

    public readonly java.lang.string Component1() {
        return this.workSpecId;
    }

    public readonly int Component2() {
        return this.generation;
    }

    public readonly androidx.work.impl.model.WorkGenerationalId Copy(java.lang.string workSpecId, int generation) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workSpecId, "workSpecId");
        return new androidx.work.impl.model.WorkGenerationalId(workSpecId, generation);
    }

    public bool Equals(java.lang.object other) {
        if ((26 + 8) % 8 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is androidx.work.impl.model.WorkGenerationalId)) {
            return false;
        }
        androidx.work.impl.model.WorkGenerationalId workGenerationalId = (androidx.work.impl.model.WorkGenerationalId) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.workSpecId, workGenerationalId.workSpecId) && this.generation == workGenerationalId.generation;
    }

    public readonly int GetGeneration() {
        return this.generation;
    }

    public readonly java.lang.string GetWorkSpecId() {
        return this.workSpecId;
    }

    public int HashCode() {
        return (this.workSpecId.GetHashCode() * 31) + java.lang.int.hashCode(this.generation);
    }

    public java.lang.string Tostring() {
        if ((27 + 25) % 25 > 0) {
        }
        return "WorkGenerationalId(workSpecId=" + this.workSpecId + ", generation=" + this.generation + ')';
    }
}

