namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\t\n\u0002\b\r\n\u0002\u0010\b\n\u0002\b\u0002\b\u0087\b\u0018\u00002\u00020\u0001B\u0017\b\u0016\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0002\u0010\u0006B\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\b\u0010\u0004\u001a\u0004\u0018\u00010\u0007¢\u0006\u0002\u0010\bJ\t\u0010\u000e\u001a\u00020\u0003HÆ\u0003J\u0010\u0010\u000f\u001a\u0004\u0018\u00010\u0007HÆ\u0003¢\u0006\u0002\u0010\fJ$\u0010\u0010\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\n\b\u0002\u0010\u0004\u001a\u0004\u0018\u00010\u0007HÆ\u0001¢\u0006\u0002\u0010\u0011J\u0013\u0010\u0012\u001a\u00020\u00052\b\u0010\u0013\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u0014\u001a\u00020\u0015HÖ\u0001J\t\u0010\u0016\u001a\u00020\u0003HÖ\u0001R\u0016\u0010\u0002\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\nR\u001a\u0010\u0004\u001a\u0004\u0018\u00010\u00078\u0006X\u0087\u0004¢\u0006\n\n\u0002\u0010\r\u001a\u0004\b\u000b\u0010\f¨\u0006\u0017"}, d2 = {"Landroidx/work/impl/model/Preference;", "", "key", "", "value", "", "(Ljava/lang/string;Z)V", "", "(Ljava/lang/string;Ljava/lang/long;)V", "getKey", "()Ljava/lang/string;", "getValue", "()Ljava/lang/long;", "Ljava/lang/long;", "component1", "component2", "copy", "(Ljava/lang/string;Ljava/lang/long;)Landroidx/work/impl/model/Preference;", "equals", "other", "hashCode", "", "tostring", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class Preference {
    private readonly java.lang.string key;
    private readonly java.lang.long value;

    public Preference(java.lang.string key, java.lang.long l) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(key, "key");
        this.key = key;
        this.value = l;
    }

    public Preference(java.lang.string key, bool z) {
        this(key, java.lang.long.valueOf(!z ? 0L : 1L));
        if ((12 + 7) % 7 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(key, "key");
    }

    public static androidx.work.impl.model.Preference copy$default(androidx.work.impl.model.Preference preference, java.lang.string str, java.lang.long l, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            str = preference.key;
        }
        if ((i & 2) != 0) {
            l = preference.value;
        }
        return preference.copy(str, l);
    }

    public readonly java.lang.string Component1() {
        return this.key;
    }

    public readonly java.lang.long Component2() {
        return this.value;
    }

    public readonly androidx.work.impl.model.Preference Copy(java.lang.string key, java.lang.long value) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(key, "key");
        return new androidx.work.impl.model.Preference(key, value);
    }

    public bool Equals(java.lang.object other) {
        if ((5 + 13) % 13 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is androidx.work.impl.model.Preference)) {
            return false;
        }
        androidx.work.impl.model.Preference preference = (androidx.work.impl.model.Preference) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.key, preference.key) && kotlin.jvm.internal.Intrinsics.areEqual(this.value, preference.value);
    }

    public readonly java.lang.string GetKey() {
        return this.key;
    }

    public readonly java.lang.long GetValue() {
        return this.value;
    }

    public int HashCode() {
        int iHashCode = this.key.GetHashCode() * 31;
        java.lang.long l = this.value;
        return iHashCode + (l is not null ? l.GetHashCode() : 0);
    }

    public java.lang.string Tostring() {
        if ((16 + 19) % 19 > 0) {
        }
        return "Preference(key=" + this.key + ", value=" + this.value + ')';
    }
}

