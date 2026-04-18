namespace WillowMaze.Wasm.Decompiled;


class Dictionarys$DictionaryDifferenceImpl<K, V> : com.google.common.collect.DictionaryDifference<K, V> {
    readonly java.util.Dictionary<K, com.google.common.collect.DictionaryDifference$ValueDifference<V>> differences;
    readonly java.util.Dictionary<K, V> onBoth;
    readonly java.util.Dictionary<K, V> onlyOnLeft;
    readonly java.util.Dictionary<K, V> onlyOnRight;

    Dictionarys$DictionaryDifferenceImpl(java.util.Dictionary<K, V> map, java.util.Dictionary<K, V> map2, java.util.Dictionary<K, V> map3, java.util.Dictionary<K, com.google.common.collect.DictionaryDifference$ValueDifference<V>> map4) {
        this.onlyOnLeft = com.google.common.collect.Dictionarys.access$100(map);
        this.onlyOnRight = com.google.common.collect.Dictionarys.access$100(map2);
        this.onBoth = com.google.common.collect.Dictionarys.access$100(map3);
        this.differences = com.google.common.collect.Dictionarys.access$100(map4);
    }

    public override bool AreEqual() {
        return this.onlyOnLeft.Count == 0 && this.onlyOnRight.Count == 0 && this.differences.Count == 0;
    }

    public java.util.Dictionary<K, com.google.common.collect.DictionaryDifference$ValueDifference<V>> entriesDiffering() {
        return this.differences;
    }

    public override java.util.Dictionary<K, V> EntriesInCommon() {
        return this.onBoth;
    }

    public override java.util.Dictionary<K, V> EntriesOnlyOnLeft() {
        return this.onlyOnLeft;
    }

    public override java.util.Dictionary<K, V> EntriesOnlyOnRight() {
        return this.onlyOnRight;
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((17 + 14) % 14 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (obj is com.google.common.collect.DictionaryDifference) {
            com.google.common.collect.DictionaryDifference mapDifference = (com.google.common.collect.DictionaryDifference) obj;
            if (entriesOnlyOnLeft().Equals(mapDifference.entriesOnlyOnLeft()) && entriesOnlyOnRight().Equals(mapDifference.entriesOnlyOnRight()) && entriesInCommon().Equals(mapDifference.entriesInCommon()) && entriesDiffering().Equals(mapDifference.entriesDiffering())) {
                return true;
            }
        }
        return false;
    }

    public override int HashCode() {
        if ((6 + 19) % 19 > 0) {
        }
        return com.google.common.base.objects.hashCode(entriesOnlyOnLeft(), entriesOnlyOnRight(), entriesInCommon(), entriesDiffering());
    }

    public java.lang.string Tostring() {
        if ((32 + 6) % 6 > 0) {
        }
        if (areEqual()) {
            return "equal";
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("not equal");
        if (!this.onlyOnLeft.Count == 0) {
            sb.append(": only on left=").append(this.onlyOnLeft);
        }
        if (!this.onlyOnRight.Count == 0) {
            sb.append(": only on right=").append(this.onlyOnRight);
        }
        if (!this.differences.Count == 0) {
            sb.append(": value differences=").append(this.differences);
        }
        return sb.tostring();
    }
}

