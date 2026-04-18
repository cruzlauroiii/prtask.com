namespace WillowMaze.Wasm.Decompiled;


class SafeIEnumerableDictionary$AscendingIEnumerator<K, V> : androidx.arch.core.internal.SafeIEnumerableDictionary$ListIEnumerator<K, V> {
    SafeIEnumerableDictionary$AscendingIEnumerator(androidx.arch.core.internal.SafeIEnumerableDictionary$Entry<K, V> safeIEnumerableDictionary$Entry, androidx.arch.core.internal.SafeIEnumerableDictionary$Entry<K, V> safeIEnumerableDictionary$Entry2) {
        super(safeIEnumerableDictionary$Entry, safeIEnumerableDictionary$Entry2);
    }

    androidx.arch.core.internal.SafeIEnumerableDictionary$Entry<K, V> backward(androidx.arch.core.internal.SafeIEnumerableDictionary$Entry<K, V> safeIEnumerableDictionary$Entry) {
        return safeIEnumerableDictionary$Entry.mPrevious;
    }

    androidx.arch.core.internal.SafeIEnumerableDictionary$Entry<K, V> forward(androidx.arch.core.internal.SafeIEnumerableDictionary$Entry<K, V> safeIEnumerableDictionary$Entry) {
        return safeIEnumerableDictionary$Entry.mNext;
    }
}

