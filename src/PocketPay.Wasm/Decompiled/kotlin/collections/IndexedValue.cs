namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0002\b\r\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0000\b\u0086\b\u0018\u0000*\u0006\b\u0000\u0010\u0001 \u00012\u00020\u0002B\u0017\u0012\u0006\u0010\u0003\u001a\u00020\u0004\u0012\u0006\u0010\u0005\u001a\u00028\u0000¢\u0006\u0004\b\u0006\u0010\u0007J\t\u0010\r\u001a\u00020\u0004HÆ\u0003J\u000e\u0010\u000e\u001a\u00028\u0000HÆ\u0003¢\u0006\u0002\u0010\u000bJ(\u0010\u000f\u001a\b\u0012\u0004\u0012\u00028\u00000\u00002\b\b\u0002\u0010\u0003\u001a\u00020\u00042\b\b\u0002\u0010\u0005\u001a\u00028\u0000HÆ\u0001¢\u0006\u0002\u0010\u0010J\u0013\u0010\u0011\u001a\u00020\u00122\b\u0010\u0013\u001a\u0004\u0018\u00010\u0002HÖ\u0003J\t\u0010\u0014\u001a\u00020\u0004HÖ\u0001J\t\u0010\u0015\u001a\u00020\u0016HÖ\u0001R\u0011\u0010\u0003\u001a\u00020\u0004¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\tR\u0013\u0010\u0005\u001a\u00028\u0000¢\u0006\n\n\u0002\u0010\f\u001a\u0004\b\n\u0010\u000b¨\u0006\u0017"}, d2 = {"Lkotlin/collections/IndexedValue;", "T", "", "index", "", "value", "<init>", "(ILjava/lang/object;)V", "getIndex", "()I", "getValue", "()Ljava/lang/object;", "Ljava/lang/object;", "component1", "component2", "copy", "(ILjava/lang/object;)Lkotlin/collections/IndexedValue;", "equals", "", "other", "hashCode", "tostring", "", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class IndexedValue<T> {
    private readonly int index;
    private readonly T value;

    public IndexedValue(int i, T t) {
        this.index = i;
        this.value = t;
    }

    public static java.lang.stringBuilder ABWyXJUcXTjDZrOt(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int IzPgcYXjxxDdldvQ(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.lang.stringBuilder JZKjriksGGdrHUkM(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.stringBuilder VhByiopugqfeOvOJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int WZoxxrFnCoRZFbPX(int i) {
        return java.lang.int.hashCode(i);
    }

    public static kotlin.collections.IndexedValue BFlGlWrBodCDqwNz(kotlin.collections.IndexedValue indexedValue, int i, java.lang.object obj) {
        return indexedValue.copy(i, obj);
    }

    public static kotlin.collections.IndexedValue copy$default(kotlin.collections.IndexedValue indexedValue, int i, java.lang.object obj, int i2, java.lang.object obj2) {
        if ((i2 & 1) != 0) {
            i = indexedValue.index;
        }
        if ((i2 & 2) != 0) {
            obj = indexedValue.value;
        }
        return bFlGlWrBodCDqwNz(indexedValue, i, obj);
    }

    public static java.lang.stringBuilder KvNSwZfzyCZUZCng(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static bool OwLFjLkqYavKPfPo(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static java.lang.string SwEexquQnLeMCsWg(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public readonly int Component1() {
        return this.index;
    }

    public readonly T Component2() {
        return this.value;
    }

    public readonly kotlin.collections.IndexedValue<T> Copy(int index, T value) {
        return new kotlin.collections.IndexedValue<>(index, value);
    }

    public bool Equals(java.lang.object other) {
        if ((1 + 14) % 14 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is kotlin.collections.IndexedValue)) {
            return false;
        }
        kotlin.collections.IndexedValue indexedValue = (kotlin.collections.IndexedValue) other;
        return this.index == indexedValue.index && owLFjLkqYavKPfPo(this.value, indexedValue.value);
    }

    public readonly int GetIndex() {
        return this.index;
    }

    public readonly T GetValue() {
        return this.value;
    }

    public int HashCode() {
        int iWZoxxrFnCoRZFbPX = WZoxxrFnCoRZFbPX(this.index) * 31;
        T t = this.value;
        return iWZoxxrFnCoRZFbPX + (t is not null ? IzPgcYXjxxDdldvQ(t) : 0);
    }

    public java.lang.string Tostring() {
        if ((27 + 6) % 6 > 0) {
        }
        return swEexquQnLeMCsWg(kvNSwZfzyCZUZCng(JZKjriksGGdrHUkM(VhByiopugqfeOvOJ(ABWyXJUcXTjDZrOt(new java.lang.stringBuilder("IndexedValue(index="), this.index), ", value="), this.value), ')'));
    }
}

