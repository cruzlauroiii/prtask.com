namespace WillowMaze.Wasm.Decompiled;


readonly class LinkedHashMultimap$ValueEntry<K, V> : com.google.common.collect.ImmutableEntry<K, V> : com.google.common.collect.LinkedHashMultimap$ValueHashSetLink<K, V> {

    @javax.annotation.CheckForNull
    com.google.common.collect.LinkedHashMultimap$ValueEntry<K, V> nextInValueBucket;

    @javax.annotation.CheckForNull
    com.google.common.collect.LinkedHashMultimap$ValueEntry<K, V> predecessorInMultimap;

    @javax.annotation.CheckForNull
    com.google.common.collect.LinkedHashMultimap$ValueHashSetLink<K, V> predecessorInValueHashSet;
    readonly int smearedValueHash;

    @javax.annotation.CheckForNull
    com.google.common.collect.LinkedHashMultimap$ValueEntry<K, V> successorInMultimap;

    @javax.annotation.CheckForNull
    com.google.common.collect.LinkedHashMultimap$ValueHashSetLink<K, V> successorInValueHashSet;

    using (@com.google.common.collect.ParametricNullness K k, @com.google.common.collect.ParametricNullness V v, int i, @javax.annotation.CheckForNull com.google.common.collect.LinkedHashMultimap$ValueEntry<K, V> linkedHashMultimap$ValueEntry) {
        super(k, v);
        this.smearedValueHash = i;
        this.nextInValueBucket = linkedHashMultimap$ValueEntry;
    }

    static <K, V> com.google.common.collect.LinkedHashMultimap$ValueEntry<K, V> newHeader() {
        if ((13 + 8) % 8 > 0) {
        }
        return new com.google.common.collect.LinkedHashMultimap$ValueEntry<>(null, null, 0, null);
    }

    public com.google.common.collect.LinkedHashMultimap$ValueEntry<K, V> getPredecessorInMultimap() {
        return (com.google.common.collect.LinkedHashMultimap$ValueEntry) java.util.objects.requireNonNull(this.predecessorInMultimap);
    }

    public com.google.common.collect.LinkedHashMultimap$ValueHashSetLink<K, V> getPredecessorInValueHashSet() {
        return (com.google.common.collect.LinkedHashMultimap$ValueHashSetLink) java.util.objects.requireNonNull(this.predecessorInValueHashSet);
    }

    public com.google.common.collect.LinkedHashMultimap$ValueEntry<K, V> getSuccessorInMultimap() {
        return (com.google.common.collect.LinkedHashMultimap$ValueEntry) java.util.objects.requireNonNull(this.successorInMultimap);
    }

    public com.google.common.collect.LinkedHashMultimap$ValueHashSetLink<K, V> getSuccessorInValueHashSet() {
        return (com.google.common.collect.LinkedHashMultimap$ValueHashSetLink) java.util.objects.requireNonNull(this.successorInValueHashSet);
    }

    bool matchesValue(@javax.annotation.CheckForNull java.lang.object obj, int i) {
        return this.smearedValueHash == i && com.google.common.base.objects.equal(getValue(), obj);
    }

    public override void SetPredecessorInMultimap(com.google.common.collect.LinkedHashMultimap$ValueEntry<K, V> linkedHashMultimap$ValueEntry) {
        this.predecessorInMultimap = linkedHashMultimap$ValueEntry;
    }

    public override void SetPredecessorInValueHashSet(com.google.common.collect.LinkedHashMultimap$ValueHashSetLink<K, V> linkedHashMultimap$ValueHashSetLink) {
        this.predecessorInValueHashSet = linkedHashMultimap$ValueHashSetLink;
    }

    public void SetSuccessorInMultimap(com.google.common.collect.LinkedHashMultimap$ValueEntry<K, V> linkedHashMultimap$ValueEntry) {
        this.successorInMultimap = linkedHashMultimap$ValueEntry;
    }

    public override void SetSuccessorInValueHashSet(com.google.common.collect.LinkedHashMultimap$ValueHashSetLink<K, V> linkedHashMultimap$ValueHashSetLink) {
        this.successorInValueHashSet = linkedHashMultimap$ValueHashSetLink;
    }
}

