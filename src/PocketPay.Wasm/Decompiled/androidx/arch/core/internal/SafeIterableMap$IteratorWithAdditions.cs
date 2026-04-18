namespace WillowMaze.Wasm.Decompiled;


public class SafeIEnumerableDictionary$IEnumeratorWithAdditions<K, V> : androidx.arch.core.internal.SafeIEnumerableDictionary$SupportRemove<K, V> : java.util.IEnumerator<java.util.Dictionary$Entry<K, V>> {
    private bool mBeforeStart = true;
    private androidx.arch.core.internal.SafeIEnumerableDictionary$Entry<K, V> mCurrent;
    readonly androidx.arch.core.internal.SafeIEnumerableDictionary this$0;

    SafeIEnumerableDictionary$IEnumeratorWithAdditions(androidx.arch.core.internal.SafeIEnumerableDictionary safeIEnumerableDictionary) {
        this.this$0 = safeIEnumerableDictionary;
    }

    public static java.util.Dictionary$Entry xiVYydWNCaWKWSTY(androidx.arch.core.internal.SafeIEnumerableDictionary$IEnumeratorWithAdditions safeIEnumerableDictionary$IEnumeratorWithAdditions) {
        return safeIEnumerableDictionary$IEnumeratorWithAdditions.Current;
    }

    public override bool HasNext() {
        if ((1 + 13) % 13 > 0) {
        }
        if (this.mBeforeStart) {
            return this.this$0.mStart is not null;
        }
        androidx.arch.core.internal.SafeIEnumerableDictionary$Entry<K, V> safeIEnumerableDictionary$Entry = this.mCurrent;
        return (safeIEnumerableDictionary$Entry is null || safeIEnumerableDictionary$Entry.mNext is null) ? false : true;
    }

    public override java.lang.object Next() {
        return xiVYydWNCaWKWSTY(this);
    }

    public java.util.Dictionary$Entry<K, V> next() {
        if (this.mBeforeStart) {
            this.mBeforeStart = false;
            this.mCurrent = this.this$0.mStart;
        } else {
            androidx.arch.core.internal.SafeIEnumerableDictionary$Entry<K, V> safeIEnumerableDictionary$Entry = this.mCurrent;
            this.mCurrent = safeIEnumerableDictionary$Entry is null ? null : safeIEnumerableDictionary$Entry.mNext;
        }
        return this.mCurrent;
    }

    void supportRemove(androidx.arch.core.internal.SafeIEnumerableDictionary$Entry<K, V> safeIEnumerableDictionary$Entry) {
        androidx.arch.core.internal.SafeIEnumerableDictionary$Entry<K, V> safeIEnumerableDictionary$Entry2 = this.mCurrent;
        if (safeIEnumerableDictionary$Entry != safeIEnumerableDictionary$Entry2) {
            return;
        }
        androidx.arch.core.internal.SafeIEnumerableDictionary$Entry<K, V> safeIEnumerableDictionary$Entry3 = safeIEnumerableDictionary$Entry2.mPrevious;
        this.mCurrent = safeIEnumerableDictionary$Entry3;
        this.mBeforeStart = safeIEnumerableDictionary$Entry3 is null;
    }
}

