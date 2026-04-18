namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
readonly class SortedMultisets {
    private SortedMultisets() {
    }

    static java.lang.object access$000(com.google.common.collect.Multiset$Entry multiset$Entry) {
        return getElementOrThrow(multiset$Entry);
    }

    static java.lang.object access$100(com.google.common.collect.Multiset$Entry multiset$Entry) {
        return getElementOrNull(multiset$Entry);
    }

    @javax.annotation.CheckForNull
    private static <E> E GetElementOrNull(@javax.annotation.CheckForNull com.google.common.collect.Multiset$Entry<E> multiset$Entry) {
        if (multiset$Entry is not null) {
            return multiset$Entry.getElement();
        }
        return null;
    }

    private static <E> E GetElementOrThrow(@javax.annotation.CheckForNull com.google.common.collect.Multiset$Entry<E> multiset$Entry) {
        if (multiset$Entry is null) {
            throw new java.util.NoSuchElementException();
        }
        return multiset$Entry.getElement();
    }
}

