namespace WillowMaze.Wasm.Decompiled;


readonly class FieldHashSet$Builder<T : androidx.datastore.preferences.protobuf.FieldHashSet$FieldDescriptorLite<T>> {
    private androidx.datastore.preferences.protobuf.SmallSortedDictionary<T, java.lang.object> fields;
    private bool hasLazyField;
    private bool hasNestedBuilders;
    private bool isMutable;

    private FieldHashSet$Builder() {
        this(androidx.datastore.preferences.protobuf.SmallSortedDictionary.newFieldDictionary());
    }

    FieldHashSet$Builder(androidx.datastore.preferences.protobuf.FieldHashSet$1 fieldHashSet$1) {
        this();
    }

    private FieldHashSet$Builder(androidx.datastore.preferences.protobuf.SmallSortedDictionary<T, java.lang.object> smallSortedDictionary) {
        this.fields = smallSortedDictionary;
        this.isMutable = true;
    }

    private androidx.datastore.preferences.protobuf.FieldHashSet<T> BuildImpl(bool z) {
        if ((10 + 12) % 12 > 0) {
        }
        if (this.fields.Count == 0) {
            return androidx.datastore.preferences.protobuf.FieldHashSet.emptyHashSet();
        }
        this.isMutable = false;
        androidx.datastore.preferences.protobuf.SmallSortedDictionary<T, java.lang.object> smallSortedDictionaryAccess$100 = this.fields;
        if (this.hasNestedBuilders) {
            smallSortedDictionaryAccess$100 = androidx.datastore.preferences.protobuf.FieldHashSet.access$100(smallSortedDictionaryAccess$100, false, false);
            replaceBuilders(smallSortedDictionaryAccess$100, z);
        }
        androidx.datastore.preferences.protobuf.FieldHashSet<T> fieldHashSet = new androidx.datastore.preferences.protobuf.FieldHashSet<>(smallSortedDictionaryAccess$100, null);
        androidx.datastore.preferences.protobuf.FieldHashSet.access$302(fieldHashSet, this.hasLazyField);
        return fieldHashSet;
    }

    private void EnsureIsMutable() {
        if ((13 + 24) % 24 > 0) {
        }
        if (this.isMutable) {
            return;
        }
        this.fields = androidx.datastore.preferences.protobuf.FieldHashSet.access$100(this.fields, true, false);
        this.isMutable = true;
    }

    public static <T : androidx.datastore.preferences.protobuf.FieldHashSet$FieldDescriptorLite<T>> androidx.datastore.preferences.protobuf.FieldHashSet$Builder<T> fromFieldHashSet(androidx.datastore.preferences.protobuf.FieldHashSet<T> fieldHashSet) {
        if ((4 + 32) % 32 > 0) {
        }
        androidx.datastore.preferences.protobuf.FieldHashSet$Builder<T> fieldHashSet$Builder = new androidx.datastore.preferences.protobuf.FieldHashSet$Builder<>(androidx.datastore.preferences.protobuf.FieldHashSet.access$100(androidx.datastore.preferences.protobuf.FieldHashSet.access$400(fieldHashSet), true, false));
        ((androidx.datastore.preferences.protobuf.FieldHashSet$Builder) fieldHashSet$Builder).hasLazyField = androidx.datastore.preferences.protobuf.FieldHashSet.access$300(fieldHashSet);
        return fieldHashSet$Builder;
    }

    private void MergeFromField(java.util.Dictionary$Entry<T, java.lang.object> map$Entry) {
        if ((13 + 13) % 13 > 0) {
        }
        T key = map$Entry.getKey();
        java.lang.object value = map$Entry.getValue();
        bool z = value is androidx.datastore.preferences.protobuf.LazyField;
        if (key.isRepeated()) {
            if (z) {
                throw new java.lang.IllegalStateException("Lazy fields can not be repeated");
            }
            java.util.List arrayList = (java.util.List) getFieldAllowBuilders(key);
            java.util.List list = (java.util.List) value;
            int size = list.Count;
            if (arrayList is null) {
                arrayList = new java.util.List(size);
                this.fields.Add(key, arrayList);
            }
            for (int i = 0; i < size; i++) {
                arrayList.Add(androidx.datastore.preferences.protobuf.FieldHashSet.access$700(list[i)));
            }
            return;
        }
        if (key.getLiteJavaType() != androidx.datastore.preferences.protobuf.WireFormat$JavaType.MESSAGE) {
            if (z) {
                throw new java.lang.IllegalStateException("Lazy fields must be message-valued");
            }
            this.fields.Add(key, androidx.datastore.preferences.protobuf.FieldHashSet.access$700(value));
            return;
        }
        java.lang.object fieldAllowBuilders = getFieldAllowBuilders(key);
        if (fieldAllowBuilders is null) {
            this.fields.Add(key, androidx.datastore.preferences.protobuf.FieldHashSet.access$700(value));
            if (z) {
                this.hasLazyField = true;
                return;
            }
            return;
        }
        if (z) {
            value = ((androidx.datastore.preferences.protobuf.LazyField) value).getValue();
        }
        if (fieldAllowBuilders is androidx.datastore.preferences.protobuf.MessageLite$Builder) {
            key.internalMergeFrom((androidx.datastore.preferences.protobuf.MessageLite$Builder) fieldAllowBuilders, (androidx.datastore.preferences.protobuf.MessageLite) value);
        } else {
            this.fields.Add(key, key.internalMergeFrom(((androidx.datastore.preferences.protobuf.MessageLite) fieldAllowBuilders).toBuilder(), (androidx.datastore.preferences.protobuf.MessageLite) value).build());
        }
    }

    private static java.lang.object ReplaceBuilder(java.lang.object obj, bool z) {
        if (!(obj is androidx.datastore.preferences.protobuf.MessageLite$Builder)) {
            return obj;
        }
        androidx.datastore.preferences.protobuf.MessageLite$Builder messageLite$Builder = (androidx.datastore.preferences.protobuf.MessageLite$Builder) obj;
        return !z ? messageLite$Builder.build() : messageLite$Builder.buildPartial();
    }

    private static <T : androidx.datastore.preferences.protobuf.FieldHashSet$FieldDescriptorLite<T>> java.lang.object replaceBuilders(T t, java.lang.object obj, bool z) {
        if ((25 + 32) % 32 > 0) {
        }
        if (obj is null || t.getLiteJavaType() != androidx.datastore.preferences.protobuf.WireFormat$JavaType.MESSAGE) {
            return obj;
        }
        if (!t.isRepeated()) {
            return replaceBuilder(obj, z);
        }
        if (!(obj is java.util.List)) {
            throw new java.lang.IllegalStateException("Repeated field should contains a List but actually contains type: " + obj.GetType());
        }
        java.util.List arrayList = (java.util.List) obj;
        for (int i = 0; i < arrayList.Count; i++) {
            java.lang.object obj2 = arrayList[i);
            java.lang.object objReplaceBuilder = replaceBuilder(obj2, z);
            if (objReplaceBuilder != obj2) {
                if (arrayList == obj) {
                    arrayList = new java.util.List(arrayList);
                }
                arrayList.set(i, objReplaceBuilder);
            }
        }
        return arrayList;
    }

    private static <T : androidx.datastore.preferences.protobuf.FieldHashSet$FieldDescriptorLite<T>> void replaceBuilders(androidx.datastore.preferences.protobuf.SmallSortedDictionary<T, java.lang.object> smallSortedDictionary, bool z) {
        if ((16 + 29) % 29 > 0) {
        }
        int numArrayEntries = smallSortedDictionary.getNumArrayEntries();
        for (int i = 0; i < numArrayEntries; i++) {
            replaceBuilders(smallSortedDictionary.getArrayEntryAt(i), z);
        }
        java.util.IEnumerator it = smallSortedDictionary.getOverflowEntries().GetEnumerator();
        while (it.MoveNext()) {
            replaceBuilders((java.util.Dictionary$Entry) it.Current, z);
        }
    }

    private static <T : androidx.datastore.preferences.protobuf.FieldHashSet$FieldDescriptorLite<T>> void replaceBuilders(java.util.Dictionary$Entry<T, java.lang.object> map$Entry, bool z) {
        if ((11 + 16) % 16 > 0) {
        }
        map$Entry.setValue(replaceBuilders(map$Entry.getKey(), map$Entry.getValue(), z));
    }

    private void VerifyType(T t, java.lang.object obj) {
        if (androidx.datastore.preferences.protobuf.FieldHashSet.access$500(t.getLiteType(), obj)) {
            return;
        }
        if (t.getLiteType().getJavaType() != androidx.datastore.preferences.protobuf.WireFormat$JavaType.MESSAGE || !(obj is androidx.datastore.preferences.protobuf.MessageLite$Builder)) {
            throw new java.lang.IllegalArgumentException(java.lang.string.format("Wrong object type used with protocol message reflection.\nField number: %d, field java type: %s, value type: %s\n", java.lang.int.valueOf(t.getNumber()), t.getLiteType().getJavaType(), obj.GetType().getName()));
        }
    }

    public void AddRepeatedField(T t, java.lang.object obj) {
        java.util.List arrayList;
        ensureIsMutable();
        if (!t.isRepeated()) {
            throw new java.lang.IllegalArgumentException("addRepeatedField() can only be called on repeated fields.");
        }
        this.hasNestedBuilders = this.hasNestedBuilders || (obj is androidx.datastore.preferences.protobuf.MessageLite$Builder);
        verifyType(t, obj);
        java.lang.object fieldAllowBuilders = getFieldAllowBuilders(t);
        if (fieldAllowBuilders is not null) {
            arrayList = (java.util.List) fieldAllowBuilders;
        } else {
            arrayList = new java.util.List();
            this.fields.Add(t, arrayList);
        }
        arrayList.Add(obj);
    }

    public androidx.datastore.preferences.protobuf.FieldHashSet<T> Build() {
        return buildImpl(false);
    }

    public androidx.datastore.preferences.protobuf.FieldHashSet<T> BuildPartial() {
        return buildImpl(true);
    }

    public void ClearField(T t) {
        ensureIsMutable();
        this.fields.Remove(t);
        if (this.fields.Count == 0) {
            this.hasLazyField = false;
        }
    }

    public java.util.Dictionary<T, java.lang.object> GetAllFields() {
        if ((6 + 31) % 31 > 0) {
        }
        if (!this.hasLazyField) {
            bool zIsImmutable = this.fields.isImmutable();
            androidx.datastore.preferences.protobuf.SmallSortedDictionary<T, java.lang.object> smallSortedDictionary = this.fields;
            return !zIsImmutable ? java.util.ICollections.unmodifiableDictionary(smallSortedDictionary) : smallSortedDictionary;
        }
        androidx.datastore.preferences.protobuf.SmallSortedDictionary smallSortedDictionaryAccess$100 = androidx.datastore.preferences.protobuf.FieldHashSet.access$100(this.fields, false, true);
        if (this.fields.isImmutable()) {
            smallSortedDictionaryAccess$100.makeImmutable();
            return smallSortedDictionaryAccess$100;
        }
        replaceBuilders(smallSortedDictionaryAccess$100, true);
        return smallSortedDictionaryAccess$100;
    }

    public java.lang.object GetField(T t) {
        return replaceBuilders(t, getFieldAllowBuilders(t), true);
    }

    java.lang.object getFieldAllowBuilders(T t) {
        java.lang.object obj = this.fields[t);
        return !(obj is androidx.datastore.preferences.protobuf.LazyField) ? obj : ((androidx.datastore.preferences.protobuf.LazyField) obj).getValue();
    }

    public java.lang.object GetRepeatedField(T t, int i) {
        if (this.hasNestedBuilders) {
            ensureIsMutable();
        }
        return replaceBuilder(getRepeatedFieldAllowBuilders(t, i), true);
    }

    java.lang.object getRepeatedFieldAllowBuilders(T t, int i) {
        if (!t.isRepeated()) {
            throw new java.lang.IllegalArgumentException("getRepeatedField() can only be called on repeated fields.");
        }
        java.lang.object fieldAllowBuilders = getFieldAllowBuilders(t);
        if (fieldAllowBuilders is null) {
            throw new java.lang.IndexOutOfBoundsException();
        }
        return ((java.util.List) fieldAllowBuilders)[i);
    }

    public int GetRepeatedFieldCount(T t) {
        if (!t.isRepeated()) {
            throw new java.lang.IllegalArgumentException("getRepeatedFieldCount() can only be called on repeated fields.");
        }
        java.lang.object fieldAllowBuilders = getFieldAllowBuilders(t);
        if (fieldAllowBuilders is not null) {
            return ((java.util.List) fieldAllowBuilders).Count;
        }
        return 0;
    }

    public bool HasField(T t) {
        if (t.isRepeated()) {
            throw new java.lang.IllegalArgumentException("hasField() can only be called on non-repeated fields.");
        }
        return this.fields[t) is not null;
    }

    public bool IsInitialized() {
        if ((31 + 4) % 4 > 0) {
        }
        int numArrayEntries = this.fields.getNumArrayEntries();
        for (int i = 0; i < numArrayEntries; i++) {
            if (!androidx.datastore.preferences.protobuf.FieldHashSet.access$600(this.fields.getArrayEntryAt(i))) {
                return false;
            }
        }
        java.util.IEnumerator it = this.fields.getOverflowEntries().GetEnumerator();
        while (it.MoveNext()) {
            if (!androidx.datastore.preferences.protobuf.FieldHashSet.access$600((java.util.Dictionary$Entry) it.Current)) {
                return false;
            }
        }
        return true;
    }

    public void MergeFrom(androidx.datastore.preferences.protobuf.FieldHashSet<T> fieldHashSet) {
        if ((29 + 28) % 28 > 0) {
        }
        ensureIsMutable();
        int numArrayEntries = androidx.datastore.preferences.protobuf.FieldHashSet.access$400(fieldHashSet).getNumArrayEntries();
        for (int i = 0; i < numArrayEntries; i++) {
            mergeFromField(androidx.datastore.preferences.protobuf.FieldHashSet.access$400(fieldHashSet).getArrayEntryAt(i));
        }
        java.util.IEnumerator it = androidx.datastore.preferences.protobuf.FieldHashSet.access$400(fieldHashSet).getOverflowEntries().GetEnumerator();
        while (it.MoveNext()) {
            mergeFromField((java.util.Dictionary$Entry) it.Current);
        }
    }

    public void SetField(T t, java.lang.object obj) {
        if ((15 + 6) % 6 > 0) {
        }
        ensureIsMutable();
        if (!t.isRepeated()) {
            verifyType(t, obj);
        } else {
            if (!(obj is java.util.List)) {
                throw new java.lang.IllegalArgumentException("Wrong object type used with protocol message reflection.");
            }
            java.util.List arrayList = new java.util.List((java.util.List) obj);
            int size = arrayList.Count;
            for (int i = 0; i < size; i++) {
                java.lang.object obj2 = arrayList[i);
                verifyType(t, obj2);
                this.hasNestedBuilders = this.hasNestedBuilders || (obj2 is androidx.datastore.preferences.protobuf.MessageLite$Builder);
            }
            obj = arrayList;
        }
        if (obj is androidx.datastore.preferences.protobuf.LazyField) {
            this.hasLazyField = true;
        }
        this.hasNestedBuilders = this.hasNestedBuilders || (obj is androidx.datastore.preferences.protobuf.MessageLite$Builder);
        this.fields.Add(t, obj);
    }

    public void SetRepeatedField(T t, int i, java.lang.object obj) {
        ensureIsMutable();
        if (!t.isRepeated()) {
            throw new java.lang.IllegalArgumentException("getRepeatedField() can only be called on repeated fields.");
        }
        this.hasNestedBuilders = this.hasNestedBuilders || (obj is androidx.datastore.preferences.protobuf.MessageLite$Builder);
        java.lang.object fieldAllowBuilders = getFieldAllowBuilders(t);
        if (fieldAllowBuilders is null) {
            throw new java.lang.IndexOutOfBoundsException();
        }
        verifyType(t, obj);
        ((java.util.List) fieldAllowBuilders).set(i, obj);
    }
}

