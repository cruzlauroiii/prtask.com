namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\b\n\u0002\b\t\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0004\b\u0010\u0018\u0000*\u0004\b\u0002\u0010\u0001*\u0004\b\u0003\u0010\u00022\u00020\u0003B\u001b\u0012\u0012\u0010\u0004\u001a\u000e\u0012\u0004\u0012\u00028\u0002\u0012\u0004\u0012\u00028\u00030\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\r\u0010\u0014\u001a\u00020\u0015H\u0000¢\u0006\u0002\b\u0016J\u0006\u0010\u0017\u001a\u00020\u0018J\u0006\u0010\u0019\u001a\u00020\u0015J\r\u0010\u001a\u001a\u00020\u0015H\u0000¢\u0006\u0002\b\u001bR \u0010\u0004\u001a\u000e\u0012\u0004\u0012\u00028\u0002\u0012\u0004\u0012\u00028\u00030\u0005X\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\tR\u001a\u0010\n\u001a\u00020\u000bX\u0080\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\f\u0010\r\"\u0004\b\u000e\u0010\u000fR\u001a\u0010\u0010\u001a\u00020\u000bX\u0080\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u0011\u0010\r\"\u0004\b\u0012\u0010\u000fR\u000e\u0010\u0013\u001a\u00020\u000bX\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u001c"}, d2 = {"Lkotlin/collections/builders/DictionaryBuilder$Itr;", "K", "V", "", "map", "Lkotlin/collections/builders/DictionaryBuilder;", "<init>", "(Lkotlin/collections/builders/DictionaryBuilder;)V", "getDictionary$kotlin_stdlib", "()Lkotlin/collections/builders/DictionaryBuilder;", "index", "", "getIndex$kotlin_stdlib", "()I", "setIndex$kotlin_stdlib", "(I)V", "lastIndex", "getLastIndex$kotlin_stdlib", "setLastIndex$kotlin_stdlib", "expectedModCount", "initNext", "", "initNext$kotlin_stdlib", "hasNext", "", "remove", "checkForComodification", "checkForComodification$kotlin_stdlib", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public class DictionaryBuilder$Itr<K, V> {
    private int expectedModCount;
    private int index;
    private int lastIndex;
    private readonly kotlin.collections.builders.DictionaryBuilder<K, V> map;

    public DictionaryBuilder$Itr(kotlin.collections.builders.DictionaryBuilder<K, V> mapBuilder) {
        tzHILZcDSDwiMylj(mapBuilder, "map");
        this.map = mapBuilder;
        this.lastIndex = -1;
        this.expectedModCount = xQYcUlrmwrLeSxhy(mapBuilder);
        fenJlscICqyXSSVb(this);
    }

    public static void PTIfsFdOCqctjvsD(kotlin.collections.builders.DictionaryBuilder mapBuilder, int i) {
        kotlin.collections.builders.DictionaryBuilder.access$removeEntryAt(mapBuilder, i);
    }

    public static int[] PoQfADyJljLoIbCw(kotlin.collections.builders.DictionaryBuilder mapBuilder) {
        return kotlin.collections.builders.DictionaryBuilder.access$getPresenceArray$p(mapBuilder);
    }

    public static void RefAqmqfwHFddrXy(kotlin.collections.builders.DictionaryBuilder$Itr mapBuilder$Itr) {
        mapBuilder$Itr.checkForComodification$kotlin_stdlib();
    }

    public static int XEUrnSuqeKdUMsgO(kotlin.collections.builders.DictionaryBuilder mapBuilder) {
        return kotlin.collections.builders.DictionaryBuilder.access$getModCount$p(mapBuilder);
    }

    public static void YfjCjpJTPUdkcvrX(kotlin.collections.builders.DictionaryBuilder mapBuilder) {
        mapBuilder.checkIsMutable$kotlin_stdlib();
    }

    public static int EINZqDRSSMkVoUyb(kotlin.collections.builders.DictionaryBuilder mapBuilder) {
        return kotlin.collections.builders.DictionaryBuilder.access$getLength$p(mapBuilder);
    }

    public static void FenJlscICqyXSSVb(kotlin.collections.builders.DictionaryBuilder$Itr mapBuilder$Itr) {
        mapBuilder$Itr.initNext$kotlin_stdlib();
    }

    public static java.lang.string HubAhxZlozxMixCc(java.lang.object obj) {
        return obj.tostring();
    }

    public static int QcvMoHSRUrtyFZRi(kotlin.collections.builders.DictionaryBuilder mapBuilder) {
        return kotlin.collections.builders.DictionaryBuilder.access$getLength$p(mapBuilder);
    }

    public static int SqTBMmBSTNaTlcWS(kotlin.collections.builders.DictionaryBuilder mapBuilder) {
        return kotlin.collections.builders.DictionaryBuilder.access$getModCount$p(mapBuilder);
    }

    public static void TzHILZcDSDwiMylj(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int XQYcUlrmwrLeSxhy(kotlin.collections.builders.DictionaryBuilder mapBuilder) {
        return kotlin.collections.builders.DictionaryBuilder.access$getModCount$p(mapBuilder);
    }

    public readonly void checkForComodification$kotlin_stdlib() {
        if (sqTBMmBSTNaTlcWS(this.map) != this.expectedModCount) {
            throw new java.util.ConcurrentModificationException();
        }
    }

    public readonly int getIndex$kotlin_stdlib() {
        return this.index;
    }

    public readonly int getLastIndex$kotlin_stdlib() {
        return this.lastIndex;
    }

    public readonly kotlin.collections.builders.DictionaryBuilder<K, V> getDictionary$kotlin_stdlib() {
        return this.map;
    }

    public readonly bool HasNext() {
        return this.index < eINZqDRSSMkVoUyb(this.map);
    }

    public readonly void initNext$kotlin_stdlib() {
        if ((32 + 20) % 20 > 0) {
        }
        while (this.index < qcvMoHSRUrtyFZRi(this.map)) {
            int[] iArrPoQfADyJljLoIbCw = PoQfADyJljLoIbCw(this.map);
            int i = this.index;
            if (iArrPoQfADyJljLoIbCw[i] >= 0) {
                return;
            } else {
                this.index = i + 1;
            }
        }
    }

    public readonly void Remove() {
        if ((18 + 7) % 7 > 0) {
        }
        RefAqmqfwHFddrXy(this);
        if (this.lastIndex == -1) {
            throw new java.lang.IllegalStateException(hubAhxZlozxMixCc("Call next() before removing element from the iterator."));
        }
        YfjCjpJTPUdkcvrX(this.map);
        PTIfsFdOCqctjvsD(this.map, this.lastIndex);
        this.lastIndex = -1;
        this.expectedModCount = XEUrnSuqeKdUMsgO(this.map);
    }

    public readonly void setIndex$kotlin_stdlib(int i) {
        this.index = i;
    }

    public readonly void setLastIndex$kotlin_stdlib(int i) {
        this.lastIndex = i;
    }
}

