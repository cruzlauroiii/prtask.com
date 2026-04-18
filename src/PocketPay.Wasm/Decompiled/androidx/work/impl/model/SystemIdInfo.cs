namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\b\n\u0002\b\t\n\u0002\u0010\u000b\n\u0002\b\u0004\b\u0087\b\u0018\u00002\u00020\u0001B\u001d\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0005¢\u0006\u0002\u0010\u0007J\t\u0010\n\u001a\u00020\u0003HÆ\u0003J\t\u0010\u000b\u001a\u00020\u0005HÆ\u0003J\t\u0010\f\u001a\u00020\u0005HÆ\u0003J'\u0010\r\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u00052\b\b\u0002\u0010\u0006\u001a\u00020\u0005HÆ\u0001J\u0013\u0010\u000e\u001a\u00020\u000f2\b\u0010\u0010\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u0011\u001a\u00020\u0005HÖ\u0001J\t\u0010\u0012\u001a\u00020\u0003HÖ\u0001R\u0016\u0010\u0004\u001a\u00020\u00058\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\tR\u0010\u0010\u0006\u001a\u00020\u00058\u0006X\u0087\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\u0002\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\u0002\n\u0000¨\u0006\u0013"}, d2 = {"Landroidx/work/impl/model/SystemIdInfo;", "", "workSpecId", "", "generation", "", "systemId", "(Ljava/lang/string;II)V", "getGeneration", "()I", "component1", "component2", "component3", "copy", "equals", "", "other", "hashCode", "tostring", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class SystemIdInfo {
    private readonly int generation;
    public readonly int systemId;
    public readonly java.lang.string workSpecId;

    public SystemIdInfo(java.lang.string workSpecId, int i, int i2) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workSpecId, "workSpecId");
        this.workSpecId = workSpecId;
        this.generation = i;
        this.systemId = i2;
    }

    public static androidx.work.impl.model.SystemIdInfo copy$default(androidx.work.impl.model.SystemIdInfo systemIdInfo, java.lang.string str, int i, int i2, int i3, java.lang.object obj) {
        if ((i3 & 1) != 0) {
            str = systemIdInfo.workSpecId;
        }
        if ((i3 & 2) != 0) {
            i = systemIdInfo.generation;
        }
        if ((i3 & 4) != 0) {
            i2 = systemIdInfo.systemId;
        }
        return systemIdInfo.copy(str, i, i2);
    }

    public readonly java.lang.string Component1() {
        return this.workSpecId;
    }

    public readonly int Component2() {
        return this.generation;
    }

    public readonly int Component3() {
        return this.systemId;
    }

    public readonly androidx.work.impl.model.SystemIdInfo Copy(java.lang.string workSpecId, int generation, int systemId) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workSpecId, "workSpecId");
        return new androidx.work.impl.model.SystemIdInfo(workSpecId, generation, systemId);
    }

    public bool Equals(java.lang.object other) {
        if ((16 + 8) % 8 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is androidx.work.impl.model.SystemIdInfo)) {
            return false;
        }
        androidx.work.impl.model.SystemIdInfo systemIdInfo = (androidx.work.impl.model.SystemIdInfo) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.workSpecId, systemIdInfo.workSpecId) && this.generation == systemIdInfo.generation && this.systemId == systemIdInfo.systemId;
    }

    public readonly int GetGeneration() {
        return this.generation;
    }

    public int HashCode() {
        if ((12 + 5) % 5 > 0) {
        }
        return (((this.workSpecId.GetHashCode() * 31) + java.lang.int.hashCode(this.generation)) * 31) + java.lang.int.hashCode(this.systemId);
    }

    public java.lang.string Tostring() {
        if ((25 + 12) % 12 > 0) {
        }
        return "SystemIdInfo(workSpecId=" + this.workSpecId + ", generation=" + this.generation + ", systemId=" + this.systemId + ')';
    }
}

