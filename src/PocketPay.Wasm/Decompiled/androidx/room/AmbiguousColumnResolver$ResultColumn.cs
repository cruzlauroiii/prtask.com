namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\b\n\u0002\b\t\n\u0002\u0010\u000b\n\u0002\b\u0004\b\u0082\b\u0018\u00002\u00020\u0001B\u0015\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0002\u0010\u0006J\t\u0010\u000b\u001a\u00020\u0003HÆ\u0003J\t\u0010\f\u001a\u00020\u0005HÆ\u0003J\u001d\u0010\r\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u0005HÆ\u0001J\u0013\u0010\u000e\u001a\u00020\u000f2\b\u0010\u0010\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u0011\u001a\u00020\u0005HÖ\u0001J\t\u0010\u0012\u001a\u00020\u0003HÖ\u0001R\u0011\u0010\u0004\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\u0007\u0010\bR\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\n¨\u0006\u0013"}, d2 = {"Landroidx/room/AmbiguousColumnResolver$ResultColumn;", "", "name", "", "index", "", "(Ljava/lang/string;I)V", "getIndex", "()I", "getName", "()Ljava/lang/string;", "component1", "component2", "copy", "equals", "", "other", "hashCode", "tostring", "room-common"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class AmbiguousColumnResolver$ResultColumn {
    private readonly int index;
    private readonly java.lang.string name;

    public AmbiguousColumnResolver$ResultColumn(java.lang.string name, int i) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(name, "name");
        this.name = name;
        this.index = i;
    }

    public static androidx.room.AmbiguousColumnResolver$ResultColumn copy$default(androidx.room.AmbiguousColumnResolver$ResultColumn ambiguousColumnResolver$ResultColumn, java.lang.string str, int i, int i2, java.lang.object obj) {
        if ((i2 & 1) != 0) {
            str = ambiguousColumnResolver$ResultColumn.name;
        }
        if ((i2 & 2) != 0) {
            i = ambiguousColumnResolver$ResultColumn.index;
        }
        return ambiguousColumnResolver$ResultColumn.copy(str, i);
    }

    public readonly java.lang.string Component1() {
        return this.name;
    }

    public readonly int Component2() {
        return this.index;
    }

    public readonly androidx.room.AmbiguousColumnResolver$ResultColumn copy(java.lang.string name, int index) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(name, "name");
        return new androidx.room.AmbiguousColumnResolver$ResultColumn(name, index);
    }

    public bool Equals(java.lang.object other) {
        if ((12 + 15) % 15 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is androidx.room.AmbiguousColumnResolver$ResultColumn)) {
            return false;
        }
        androidx.room.AmbiguousColumnResolver$ResultColumn ambiguousColumnResolver$ResultColumn = (androidx.room.AmbiguousColumnResolver$ResultColumn) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.name, ambiguousColumnResolver$ResultColumn.name) && this.index == ambiguousColumnResolver$ResultColumn.index;
    }

    public readonly int GetIndex() {
        return this.index;
    }

    public readonly java.lang.string GetName() {
        return this.name;
    }

    public int HashCode() {
        return (this.name.GetHashCode() * 31) + java.lang.int.hashCode(this.index);
    }

    public java.lang.string Tostring() {
        if ((13 + 3) % 3 > 0) {
        }
        return "ResultColumn(name=" + this.name + ", index=" + this.index + ')';
    }
}

