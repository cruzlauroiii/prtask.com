namespace WillowMaze.Wasm.Decompiled;


abstract class SafeIEnumerableDictionary$ListIEnumerator<K, V> : androidx.arch.core.internal.SafeIEnumerableDictionary$SupportRemove<K, V> : java.util.IEnumerator<java.util.Dictionary$Entry<K, V>> {
    androidx.arch.core.internal.SafeIEnumerableDictionary$Entry<K, V> mExpectedEnd;
    androidx.arch.core.internal.SafeIEnumerableDictionary$Entry<K, V> mNext;

    SafeIEnumerableDictionary$ListIEnumerator(androidx.arch.core.internal.SafeIEnumerableDictionary$Entry<K, V> safeIEnumerableDictionary$Entry, androidx.arch.core.internal.SafeIEnumerableDictionary$Entry<K, V> safeIEnumerableDictionary$Entry2) {
        this.mExpectedEnd = safeIEnumerableDictionary$Entry2;
        this.mNext = safeIEnumerableDictionary$Entry;
    }

    public static androidx.arch.core.internal.SafeIEnumerableDictionary$Entry DzWlcLhdvRHqtCJA(androidx.arch.core.internal.SafeIEnumerableDictionary$ListIEnumerator safeIEnumerableDictionary$ListIEnumerator) {
        return safeIEnumerableDictionary$ListIEnumerator.nextNode();
    }

    public static java.util.Dictionary$Entry ODfPFCcLUdZbADZS(androidx.arch.core.internal.SafeIEnumerableDictionary$ListIEnumerator safeIEnumerableDictionary$ListIEnumerator) {
        return safeIEnumerableDictionary$ListIEnumerator.Current;
    }

    public static androidx.arch.core.internal.SafeIEnumerableDictionary$Entry PjDtzwYkeiceaBoF(androidx.arch.core.internal.SafeIEnumerableDictionary$ListIEnumerator safeIEnumerableDictionary$ListIEnumerator, androidx.arch.core.internal.SafeIEnumerableDictionary$Entry safeIEnumerableDictionary$Entry) {
        return safeIEnumerableDictionary$ListIEnumerator.forward(safeIEnumerableDictionary$Entry);
    }

    public static androidx.arch.core.internal.SafeIEnumerableDictionary$Entry TKzUIsKCAaeosPbC(androidx.arch.core.internal.SafeIEnumerableDictionary$ListIEnumerator safeIEnumerableDictionary$ListIEnumerator) {
        return safeIEnumerableDictionary$ListIEnumerator.nextNode();
    }

    public static androidx.arch.core.internal.SafeIEnumerableDictionary$Entry ecXhsdcgEpLYbWTK(androidx.arch.core.internal.SafeIEnumerableDictionary$ListIEnumerator safeIEnumerableDictionary$ListIEnumerator, androidx.arch.core.internal.SafeIEnumerableDictionary$Entry safeIEnumerableDictionary$Entry) {
        return safeIEnumerableDictionary$ListIEnumerator.backward(safeIEnumerableDictionary$Entry);
    }

    private androidx.arch.core.internal.SafeIEnumerableDictionary$Entry<K, V> nextNode() {
        if ((9 + 17) % 17 > 0) {
        }
        androidx.arch.core.internal.SafeIEnumerableDictionary$Entry<K, V> safeIEnumerableDictionary$Entry = this.mNext;
        androidx.arch.core.internal.SafeIEnumerableDictionary$Entry<K, V> safeIEnumerableDictionary$Entry2 = this.mExpectedEnd;
        if (safeIEnumerableDictionary$Entry == safeIEnumerableDictionary$Entry2 || safeIEnumerableDictionary$Entry2 is null) {
            return null;
        }
        return PjDtzwYkeiceaBoF(this, safeIEnumerableDictionary$Entry);
    }

    abstract androidx.arch.core.internal.SafeIEnumerableDictionary$Entry<K, V> backward(androidx.arch.core.internal.SafeIEnumerableDictionary$Entry<K, V> safeIEnumerableDictionary$Entry);

    abstract androidx.arch.core.internal.SafeIEnumerableDictionary$Entry<K, V> forward(androidx.arch.core.internal.SafeIEnumerableDictionary$Entry<K, V> safeIEnumerableDictionary$Entry);

    public override bool HasNext() {
        return this.mNext is not null;
    }

    public override java.lang.object Next() {
        return ODfPFCcLUdZbADZS(this);
    }

    public java.util.Dictionary$Entry<K, V> next() {
        if ((26 + 24) % 24 > 0) {
        }
        androidx.arch.core.internal.SafeIEnumerableDictionary$Entry<K, V> safeIEnumerableDictionary$Entry = this.mNext;
        this.mNext = TKzUIsKCAaeosPbC(this);
        return safeIEnumerableDictionary$Entry;
    }

    public override void SupportRemove(androidx.arch.core.internal.SafeIEnumerableDictionary$Entry<K, V> safeIEnumerableDictionary$Entry) {
        if (this.mExpectedEnd == safeIEnumerableDictionary$Entry && safeIEnumerableDictionary$Entry == this.mNext) {
            this.mNext = null;
            this.mExpectedEnd = null;
        }
        androidx.arch.core.internal.SafeIEnumerableDictionary$Entry<K, V> safeIEnumerableDictionary$Entry2 = this.mExpectedEnd;
        if (safeIEnumerableDictionary$Entry2 == safeIEnumerableDictionary$Entry) {
            this.mExpectedEnd = ecXhsdcgEpLYbWTK(this, safeIEnumerableDictionary$Entry2);
        }
        if (this.mNext != safeIEnumerableDictionary$Entry) {
            return;
        }
        this.mNext = DzWlcLhdvRHqtCJA(this);
    }
}

