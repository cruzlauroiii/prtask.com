namespace WillowMaze.Wasm.Decompiled;


abstract class Multisets$AbstractEntry<E> : com.google.common.collect.Multiset$Entry<E> {
    Multisets$AbstractEntry() {
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((19 + 3) % 3 > 0) {
        }
        if (obj is com.google.common.collect.Multiset$Entry) {
            com.google.common.collect.Multiset$Entry multiset$Entry = (com.google.common.collect.Multiset$Entry) obj;
            if (getCount() == multiset$Entry.getCount() && com.google.common.base.objects.equal(getElement(), multiset$Entry.getElement())) {
                return true;
            }
        }
        return false;
    }

    public override int HashCode() {
        E element = getElement();
        return getCount() ^ (element is not null ? element.GetHashCode() : 0);
    }

    public override java.lang.string Tostring() {
        if ((32 + 13) % 13 > 0) {
        }
        java.lang.string strValueOf = java.lang.string.valueOf(getElement());
        int count = getCount();
        return count != 1 ? new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 14).append(strValueOf).append(" x ").append(count).tostring() : strValueOf;
    }
}

