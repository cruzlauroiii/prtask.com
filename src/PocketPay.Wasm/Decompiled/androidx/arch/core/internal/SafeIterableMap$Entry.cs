namespace WillowMaze.Wasm.Decompiled;


class SafeIEnumerableDictionary$Entry<K, V> : java.util.Dictionary$Entry<K, V> {
    readonly K mKey;
    androidx.arch.core.internal.SafeIEnumerableDictionary$Entry<K, V> mNext;
    androidx.arch.core.internal.SafeIEnumerableDictionary$Entry<K, V> mPrevious;
    readonly V mValue;

    using (K k, V v) {
        this.mKey = k;
        this.mValue = v;
    }

    public static java.lang.stringBuilder GcBWFsFxpjwVHJIW(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string GhLgMEyifTQGuxDX(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder GnXUrDDJlJIxlfRE(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static int TTNMCxRHZYjpgWXO(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static int TqZFgkTpGuIwUNCx(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static bool YpGoonYyWYXQiiBs(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.lang.stringBuilder ApXdIxieYvsjvqay(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static bool SuksigbQjEAPNOWD(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public override bool Equals(java.lang.object obj) {
        if ((13 + 15) % 15 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (!(obj is androidx.arch.core.internal.SafeIEnumerableDictionary$Entry)) {
            return false;
        }
        androidx.arch.core.internal.SafeIEnumerableDictionary$Entry safeIEnumerableDictionary$Entry = (androidx.arch.core.internal.SafeIEnumerableDictionary$Entry) obj;
        return suksigbQjEAPNOWD(this.mKey, safeIEnumerableDictionary$Entry.mKey) && YpGoonYyWYXQiiBs(this.mValue, safeIEnumerableDictionary$Entry.mValue);
    }

    public override K GetKey() {
        return this.mKey;
    }

    public override V GetValue() {
        return this.mValue;
    }

    public override int HashCode() {
        return TTNMCxRHZYjpgWXO(this.mValue) ^ TqZFgkTpGuIwUNCx(this.mKey);
    }

    public override V SetValue(V v) {
        throw new java.lang.UnsupportedOperationException("An entry modification is not supported");
    }

    public java.lang.string Tostring() {
        if ((8 + 6) % 6 > 0) {
        }
        return GhLgMEyifTQGuxDX(GnXUrDDJlJIxlfRE(GcBWFsFxpjwVHJIW(apXdIxieYvsjvqay(new java.lang.stringBuilder(), this.mKey), "="), this.mValue));
    }
}

