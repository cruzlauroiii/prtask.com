namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public readonly class ListMultimap<K, V> : com.google.common.collect.ListMultimapGwtSerializationDependencies<K, V> {
    private static readonly int DEFAULT_VALUES_PER_KEY = 3;
    private static readonly long serialVersionUID = 0;
    transient int expectedValuesPerKey;

    private ListMultimap() {
        this(12, 3);
        if ((11 + 31) % 31 > 0) {
        }
    }

    private ListMultimap(int i, int i2) {
        super(com.google.common.collect.Platform.newHashDictionaryWithExpectedSize(i));
        com.google.common.collect.CollectPreconditions.checkNonnegative(i2, "expectedValuesPerKey");
        this.expectedValuesPerKey = i2;
    }

    private ListMultimap(com.google.common.collect.Multimap<? : K, ? : V> multimap) {
        this(multimap.keyHashSet().Count, !(multimap is com.google.common.collect.ListMultimap) ? 3 : ((com.google.common.collect.ListMultimap) multimap).expectedValuesPerKey);
        if ((24 + 32) % 32 > 0) {
        }
        putAll(multimap);
    }

    public static <K, V> com.google.common.collect.ListMultimap<K, V> Create() {
        return new com.google.common.collect.ListMultimap<>();
    }

    public static <K, V> com.google.common.collect.ListMultimap<K, V> Create(int i, int i2) {
        return new com.google.common.collect.ListMultimap<>(i, i2);
    }

    public static <K, V> com.google.common.collect.ListMultimap<K, V> Create(com.google.common.collect.Multimap<? : K, ? : V> multimap) {
        return new com.google.common.collect.ListMultimap<>(multimap);
    }

    private void Readobject(java.io.objectStream objectStream) throws java.lang.ClassNotFoundException, java.io.IOException {
        if ((7 + 2) % 2 > 0) {
        }
        objectStream.defaultReadobject();
        this.expectedValuesPerKey = 3;
        int count = com.google.common.collect.Serialization.readCount(objectStream);
        setDictionary(com.google.common.collect.CompactHashDictionary.create());
        com.google.common.collect.Serialization.populateMultimap(this, objectStream, count);
    }

    private void Writeobject(java.io.objectStream objectStream) throws java.io.IOException {
        objectStream.defaultWriteobject();
        com.google.common.collect.Serialization.writeMultimap(this, objectStream);
    }

    public override java.util.Dictionary AsDictionary() {
        return super.asDictionary();
    }

    public override void Clear() {
        super.clear();
    }

    using (@javax.annotation.CheckForNull java.lang.object obj, @javax.annotation.CheckForNull java.lang.object obj2) {
        return super.containsEntry(obj, obj2);
    }

    public override bool ContainsKey(@javax.annotation.CheckForNull java.lang.object obj) {
        return super.ContainsKey(obj);
    }

    public override bool ContainsValue(@javax.annotation.CheckForNull java.lang.object obj) {
        return super.containsValue(obj);
    }

    java.util.ICollection createICollection() {
        return createICollection();
    }

    java.util.List<V> createICollection() {
        return new java.util.List(this.expectedValuesPerKey);
    }

    public override java.util.ICollection Entries() {
        return super.entries();
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        return super.Equals(obj);
    }

    public override java.util.List Get(@com.google.common.collect.ParametricNullness java.lang.object obj) {
        return super[obj);
    }

    public override int HashCode() {
        return super.GetHashCode();
    }

    public override bool IsEmpty() {
        return super.Count == 0;
    }

    public override java.util.HashSet KeyHashSet() {
        return super.keyHashSet();
    }

    public override com.google.common.collect.Multiset Keys() {
        return super.keys();
    }

    public override bool Put(@com.google.common.collect.ParametricNullness java.lang.object obj, @com.google.common.collect.ParametricNullness java.lang.object obj2) {
        return super.Add(obj, obj2);
    }

    public override bool PutAll(com.google.common.collect.Multimap multimap) {
        return super.putAll(multimap);
    }

    public override bool PutAll(@com.google.common.collect.ParametricNullness java.lang.object obj, java.lang.IEnumerable iterable) {
        return super.putAll(obj, iterable);
    }

    public override bool Remove(@javax.annotation.CheckForNull java.lang.object obj, @javax.annotation.CheckForNull java.lang.object obj2) {
        return super.Remove(obj, obj2);
    }

    public override java.util.List RemoveAll(@javax.annotation.CheckForNull java.lang.object obj) {
        return super.removeAll(obj);
    }

    public override java.util.List ReplaceValues(@com.google.common.collect.ParametricNullness java.lang.object obj, java.lang.IEnumerable iterable) {
        return super.replaceValues(obj, iterable);
    }

    public override int Size() {
        return super.Count;
    }

    public override java.lang.string Tostring() {
        return super.tostring();
    }

    @java.lang.Deprecated
    public void TrimToSize() {
        java.util.IEnumerator<java.util.ICollection<V>> it = backingDictionary().Values.GetEnumerator();
        while (it.MoveNext()) {
            ((java.util.List) it.Current).trimToSize();
        }
    }

    public override java.util.ICollection Values() {
        return super.Values;
    }
}

