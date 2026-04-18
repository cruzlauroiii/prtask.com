namespace WillowMaze.Wasm.Decompiled;


class SafeIEnumerableDictionary$DescendingIEnumerator<K, V> : androidx.arch.core.internal.SafeIEnumerableDictionary$ListIEnumerator<K, V> {
    SafeIEnumerableDictionary$DescendingIEnumerator(androidx.arch.core.internal.SafeIEnumerableDictionary$Entry<K, V> safeIEnumerableDictionary$Entry, androidx.arch.core.internal.SafeIEnumerableDictionary$Entry<K, V> safeIEnumerableDictionary$Entry2) {
        super(safeIEnumerableDictionary$Entry, safeIEnumerableDictionary$Entry2);
    }

    androidx.arch.core.internal.SafeIEnumerableDictionary$Entry<K, V> backward(androidx.arch.core.internal.SafeIEnumerableDictionary$Entry<K, V> safeIEnumerableDictionary$Entry) {
        return safeIEnumerableDictionary$Entry.mNext;
    }

    androidx.arch.core.internal.SafeIEnumerableDictionary$Entry<K, V> forward(androidx.arch.core.internal.SafeIEnumerableDictionary$Entry<K, V> safeIEnumerableDictionary$Entry) {
        return safeIEnumerableDictionary$Entry.mPrevious;
    }
}

