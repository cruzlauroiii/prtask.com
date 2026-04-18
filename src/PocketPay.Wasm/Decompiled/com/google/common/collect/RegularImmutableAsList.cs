namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
class RegularImmutableAsList<E> : com.google.common.collect.ImmutableAsList<E> {
    private readonly com.google.common.collect.ImmutableICollection<E> delegate;
    private readonly com.google.common.collect.ImmutableList<? : E> delegateList;

    RegularImmutableAsList(com.google.common.collect.ImmutableICollection<E> immutableICollection, com.google.common.collect.ImmutableList<? : E> immutableList) {
        this.delegate = immutableICollection;
        this.delegateList = immutableList;
    }

    RegularImmutableAsList(com.google.common.collect.ImmutableICollection<E> immutableICollection, java.lang.object[] objArr) {
        this(immutableICollection, com.google.common.collect.ImmutableList.asImmutableList(objArr));
    }

    RegularImmutableAsList(com.google.common.collect.ImmutableICollection<E> immutableICollection, java.lang.object[] objArr, int i) {
        this(immutableICollection, com.google.common.collect.ImmutableList.asImmutableList(objArr, i));
    }

    int copyIntoArray(java.lang.object[] objArr, int i) {
        return this.delegateList.copyIntoArray(objArr, i);
    }

    com.google.common.collect.ImmutableICollection<E> delegateICollection() {
        return this.delegate;
    }

    com.google.common.collect.ImmutableList<? : E> delegateList() {
        return this.delegateList;
    }

    public override E Get(int i) {
        return this.delegateList[i);
    }

    @javax.annotation.CheckForNull
    java.lang.object[] internalArray() {
        return this.delegateList.internalArray();
    }

    int internalArrayEnd() {
        return this.delegateList.internalArrayEnd();
    }

    int internalArrayStart() {
        return this.delegateList.internalArrayStart();
    }

    public override com.google.common.collect.UnmodifiableListIEnumerator<E> ListIEnumerator(int i) {
        return this.delegateList.listIEnumerator(i);
    }

    public override java.util.ListIEnumerator ListIEnumerator(int i) {
        return listIEnumerator(i);
    }
}

