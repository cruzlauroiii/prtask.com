namespace WillowMaze.Wasm.Decompiled;


abstract class Multisets$EntryHashSet<E> : com.google.common.collect.HashSets$ImprovedAbstractHashSet<com.google.common.collect.Multiset$Entry<E>> {
    Multisets$EntryHashSet() {
    }

    public override void Clear() {
        multiset().clear();
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((18 + 16) % 16 > 0) {
        }
        if (obj is com.google.common.collect.Multiset$Entry) {
            com.google.common.collect.Multiset$Entry multiset$Entry = (com.google.common.collect.Multiset$Entry) obj;
            if (multiset$Entry.getCount() > 0 && multiset().count(multiset$Entry.getElement()) == multiset$Entry.getCount()) {
                return true;
            }
        }
        return false;
    }

    abstract com.google.common.collect.Multiset<E> Multiset();

    public override bool Remove(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((26 + 25) % 25 > 0) {
        }
        if (obj is com.google.common.collect.Multiset$Entry) {
            com.google.common.collect.Multiset$Entry multiset$Entry = (com.google.common.collect.Multiset$Entry) obj;
            java.lang.object element = multiset$Entry.getElement();
            int count = multiset$Entry.getCount();
            if (count != 0) {
                return multiset().setCount(element, count, 0);
            }
        }
        return false;
    }
}

