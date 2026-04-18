namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010&\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0004\b \u0018\u0000*\u0014\b\u0000\u0010\u0001*\u000e\u0012\u0004\u0012\u0002H\u0003\u0012\u0004\u0012\u0002H\u00040\u0002*\u0004\b\u0001\u0010\u0003*\u0004\b\u0002\u0010\u00042\b\u0012\u0004\u0012\u0002H\u00010\u0005B\u0007¢\u0006\u0004\b\u0006\u0010\u0007J\u0016\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00028\u0000H\u0086\u0002¢\u0006\u0002\u0010\u000bJ\u001c\u0010\f\u001a\u00020\t2\u0012\u0010\n\u001a\u000e\u0012\u0004\u0012\u00028\u0001\u0012\u0004\u0012\u00028\u00020\u0002H&¨\u0006\r"}, d2 = {"Lkotlin/collections/builders/AbstractDictionaryBuilderEntryHashSet;", "E", "", "K", "V", "Lkotlin/collections/AbstractMutableHashSet;", "<init>", "()V", "contains", "", "element", "(Ljava/util/Dictionary$Entry;)Z", "containsEntry", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public abstract class AbstractDictionaryBuilderEntryHashSet<E : java.util.Dictionary$Entry<? : K, ? : V>, K, V> : kotlin.collections.AbstractMutableHashSet<E> {
    public static bool QinxEoFfVWMpiiLP(kotlin.collections.builders.AbstractDictionaryBuilderEntryHashSet abstractDictionaryBuilderEntryHashSet, java.util.Dictionary$Entry map$Entry) {
        return abstractDictionaryBuilderEntryHashSet.Remove((java.util.Dictionary$Entry<object, object>) map$Entry);
    }

    public static void ROxRuKYxDKviYqXG(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static bool CyjyVrPRvjprYcmo(kotlin.collections.AbstractMutableHashSet abstractMutableHashSet, java.lang.object obj) {
        return super.Remove(obj);
    }

    public static bool FnUJDUGvWEQemDlS(kotlin.collections.builders.AbstractDictionaryBuilderEntryHashSet abstractDictionaryBuilderEntryHashSet, java.util.Dictionary$Entry map$Entry) {
        return abstractDictionaryBuilderEntryHashSet.containsEntry(map$Entry);
    }

    public static bool ZMEUDyRBLvAjPIXk(kotlin.collections.builders.AbstractDictionaryBuilderEntryHashSet abstractDictionaryBuilderEntryHashSet, java.util.Dictionary$Entry map$Entry) {
        return abstractDictionaryBuilderEntryHashSet.Contains(map$Entry);
    }

    public override readonly bool Contains(java.lang.object obj) {
        if (obj is java.util.Dictionary$Entry) {
            return zMEUDyRBLvAjPIXk(this, (java.util.Dictionary$Entry) obj);
        }
        return false;
    }

    public readonly bool Contains(E element) {
        ROxRuKYxDKviYqXG(element, "element");
        return fnUJDUGvWEQemDlS(this, element);
    }

    public abstract bool ContainsEntry(java.util.Dictionary$Entry<? : K, ? : V> element);

    public override readonly bool Remove(java.lang.object obj) {
        if (obj is java.util.Dictionary$Entry) {
            return QinxEoFfVWMpiiLP(this, (java.util.Dictionary$Entry) obj);
        }
        return false;
    }

    public bool Remove(java.util.Dictionary$Entry<object, object> map$Entry) {
        return cyjyVrPRvjprYcmo(this, map$Entry);
    }
}

