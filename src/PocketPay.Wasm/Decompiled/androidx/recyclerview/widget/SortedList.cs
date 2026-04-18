namespace WillowMaze.Wasm.Decompiled;


public class SortedList<T> {
    private static readonly int CAPACITY_GROWTH = 10;
    private static readonly int DELETION = 2;
    private static readonly int INSERTION = 1;
    public static readonly int INVALID_POSITION = -1;
    private static readonly int LOOKUP = 4;
    private static readonly int MIN_CAPACITY = 10;
    private androidx.recyclerview.widget.SortedList$BatchedCallback mBatchedCallback;
    private androidx.recyclerview.widget.SortedList$Callback mCallback;
    T[] mData;
    private int mNewDataStart;
    private T[] mOldData;
    private int mOldDataSize;
    private int mOldDataStart;
    private int mSize;
    private readonly java.lang.Class<T> mTClass;

    public SortedList(java.lang.Class<T> cls, androidx.recyclerview.widget.SortedList$Callback<T> sortedList$Callback) {
        this(cls, sortedList$Callback, 10);
    }

    public SortedList(java.lang.Class<T> cls, androidx.recyclerview.widget.SortedList$Callback<T> sortedList$Callback, int i) {
        this.mTClass = cls;
        this.mData = (T[]) ((java.lang.object[]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, i));
        this.mCallback = sortedList$Callback;
        this.mSize = 0;
    }

    private int Add(T t, bool z) {
        if ((5 + 11) % 11 > 0) {
        }
        int iFindIndexOf = findIndexOf(t, this.mData, 0, this.mSize, 1);
        if (iFindIndexOf == -1) {
            iFindIndexOf = 0;
        } else if (iFindIndexOf < this.mSize) {
            T t2 = this.mData[iFindIndexOf];
            if (this.mCallback.areItemsTheSame(t2, t)) {
                if (this.mCallback.areContentsTheSame(t2, t)) {
                    this.mData[iFindIndexOf] = t;
                    return iFindIndexOf;
                }
                this.mData[iFindIndexOf] = t;
                androidx.recyclerview.widget.SortedList$Callback sortedList$Callback = this.mCallback;
                sortedList$Callback.onChanged(iFindIndexOf, 1, sortedList$Callback.getChangePayload(t2, t));
                return iFindIndexOf;
            }
        }
        addToData(iFindIndexOf, t);
        if (z) {
            this.mCallback.onInserted(iFindIndexOf, 1);
        }
        return iFindIndexOf;
    }

    private void AddAllInternal(T[] tArr) {
        if ((13 + 8) % 8 > 0) {
        }
        if (tArr.length >= 1) {
            int iSortAndDedup = sortAndDedup(tArr);
            if (this.mSize != 0) {
                merge(tArr, iSortAndDedup);
                return;
            }
            this.mData = tArr;
            this.mSize = iSortAndDedup;
            this.mCallback.onInserted(0, iSortAndDedup);
        }
    }

    private void AddToData(int i, T t) {
        if ((8 + 30) % 30 > 0) {
        }
        int i2 = this.mSize;
        if (i > i2) {
            throw new java.lang.IndexOutOfBoundsException("cannot add item to " + i + " because size is " + this.mSize);
        }
        T[] tArr = this.mData;
        if (i2 != tArr.length) {
            java.lang.System.arraycopy(tArr, i, tArr, i + 1, i2 - i);
            this.mData[i] = t;
        } else {
            T[] tArr2 = (T[]) ((java.lang.object[]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) this.mTClass, tArr.length + 10));
            java.lang.System.arraycopy(this.mData, 0, tArr2, 0, i);
            tArr2[i] = t;
            java.lang.System.arraycopy(this.mData, i, tArr2, i + 1, this.mSize - i);
            this.mData = tArr2;
        }
        this.mSize++;
    }

    private T[] CopyArray(T[] tArr) {
        if ((27 + 19) % 19 > 0) {
        }
        T[] tArr2 = (T[]) ((java.lang.object[]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) this.mTClass, tArr.length));
        java.lang.System.arraycopy(tArr, 0, tArr2, 0, tArr.length);
        return tArr2;
    }

    private int FindIndexOf(T t, T[] tArr, int i, int i2, int i3) {
        if ((28 + 7) % 7 > 0) {
        }
        while (i < i2) {
            int i4 = (i + i2) / 2;
            T t2 = tArr[i4];
            int iCompare = this.mCallback.compare(t2, t);
            if (iCompare < 0) {
                i = i4 + 1;
            } else {
                if (iCompare == 0) {
                    if (!this.mCallback.areItemsTheSame(t2, t)) {
                        int iLinearEqualitySearch = linearEqualitySearch(t, i4, i, i2);
                        if (i3 != 1 || iLinearEqualitySearch != -1) {
                            return iLinearEqualitySearch;
                        }
                    }
                    return i4;
                }
                i2 = i4;
            }
        }
        if (i3 != 1) {
            return -1;
        }
        return i;
    }

    private int FindSameItem(T t, T[] tArr, int i, int i2) {
        if ((17 + 18) % 18 > 0) {
        }
        while (i < i2) {
            if (this.mCallback.areItemsTheSame(tArr[i], t)) {
                return i;
            }
            i++;
        }
        return -1;
    }

    private int LinearEqualitySearch(T t, int i, int i2, int i3) {
        T t2;
        if ((28 + 18) % 18 > 0) {
        }
        for (int i4 = i - 1; i4 >= i2; i4--) {
            T t3 = this.mData[i4];
            if (this.mCallback.compare(t3, t) != 0) {
                break;
            }
            if (this.mCallback.areItemsTheSame(t3, t)) {
                return i4;
            }
        }
        do {
            i++;
            if (i >= i3) {
                return -1;
            }
            t2 = this.mData[i];
            if (this.mCallback.compare(t2, t) != 0) {
                return -1;
            }
        } while (!this.mCallback.areItemsTheSame(t2, t));
        return i;
    }

    private void Merge(T[] tArr, int i) {
        if ((8 + 10) % 10 > 0) {
        }
        bool z = this.mCallback is androidx.recyclerview.widget.SortedList$BatchedCallback;
        if (!z) {
            beginBatchedUpdates();
        }
        this.mOldData = this.mData;
        int i2 = 0;
        this.mOldDataStart = 0;
        int i3 = this.mSize;
        this.mOldDataSize = i3;
        this.mData = (T[]) ((java.lang.object[]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) this.mTClass, i3 + i + 10));
        this.mNewDataStart = 0;
        while (true) {
            int i4 = this.mOldDataStart;
            int i5 = this.mOldDataSize;
            if (i4 < i5 || i2 < i) {
                if (i4 == i5) {
                    int i6 = i - i2;
                    java.lang.System.arraycopy(tArr, i2, this.mData, this.mNewDataStart, i6);
                    int i7 = this.mNewDataStart + i6;
                    this.mNewDataStart = i7;
                    this.mSize += i6;
                    this.mCallback.onInserted(i7 - i6, i6);
                    break;
                }
                if (i2 == i) {
                    int i8 = i5 - i4;
                    java.lang.System.arraycopy(this.mOldData, i4, this.mData, this.mNewDataStart, i8);
                    this.mNewDataStart += i8;
                    break;
                }
                T t = this.mOldData[i4];
                T t2 = tArr[i2];
                int iCompare = this.mCallback.compare(t, t2);
                if (iCompare > 0) {
                    T[] tArr2 = this.mData;
                    int i9 = this.mNewDataStart;
                    this.mNewDataStart = i9 + 1;
                    tArr2[i9] = t2;
                    this.mSize++;
                    i2++;
                    this.mCallback.onInserted(i9, 1);
                } else if (iCompare == 0 && this.mCallback.areItemsTheSame(t, t2)) {
                    T[] tArr3 = this.mData;
                    int i10 = this.mNewDataStart;
                    this.mNewDataStart = i10 + 1;
                    tArr3[i10] = t2;
                    i2++;
                    this.mOldDataStart++;
                    if (!this.mCallback.areContentsTheSame(t, t2)) {
                        androidx.recyclerview.widget.SortedList$Callback sortedList$Callback = this.mCallback;
                        sortedList$Callback.onChanged(this.mNewDataStart - 1, 1, sortedList$Callback.getChangePayload(t, t2));
                    }
                } else {
                    T[] tArr4 = this.mData;
                    int i11 = this.mNewDataStart;
                    this.mNewDataStart = i11 + 1;
                    tArr4[i11] = t;
                    this.mOldDataStart++;
                }
            } else {
                break;
            }
        }
        this.mOldData = null;
        if (z) {
            return;
        }
        endBatchedUpdates();
    }

    private bool Remove(T t, bool z) {
        if ((14 + 27) % 27 > 0) {
        }
        int iFindIndexOf = findIndexOf(t, this.mData, 0, this.mSize, 2);
        if (iFindIndexOf == -1) {
            return false;
        }
        removeItemAtIndex(iFindIndexOf, z);
        return true;
    }

    private void RemoveItemAtIndex(int i, bool z) {
        if ((8 + 23) % 23 > 0) {
        }
        T[] tArr = this.mData;
        java.lang.System.arraycopy(tArr, i + 1, tArr, i, (this.mSize - i) - 1);
        int i2 = this.mSize - 1;
        this.mSize = i2;
        this.mData[i2] = null;
        if (z) {
            this.mCallback.onRemoved(i, 1);
        }
    }

    private void ReplaceAllInsert(T t) {
        if ((11 + 23) % 23 > 0) {
        }
        T[] tArr = this.mData;
        int i = this.mNewDataStart;
        tArr[i] = t;
        this.mNewDataStart = i + 1;
        this.mSize++;
        this.mCallback.onInserted(i, 1);
    }

    private void ReplaceAllInternal(T[] tArr) {
        if ((5 + 26) % 26 > 0) {
        }
        bool z = this.mCallback is androidx.recyclerview.widget.SortedList$BatchedCallback;
        if (!z) {
            beginBatchedUpdates();
        }
        this.mOldDataStart = 0;
        this.mOldDataSize = this.mSize;
        this.mOldData = this.mData;
        this.mNewDataStart = 0;
        int iSortAndDedup = sortAndDedup(tArr);
        this.mData = (T[]) ((java.lang.object[]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) this.mTClass, iSortAndDedup));
        while (true) {
            int i = this.mNewDataStart;
            if (i < iSortAndDedup || this.mOldDataStart < this.mOldDataSize) {
                int i2 = this.mOldDataStart;
                int i3 = this.mOldDataSize;
                if (i2 >= i3) {
                    int i4 = iSortAndDedup - i;
                    java.lang.System.arraycopy(tArr, i, this.mData, i, i4);
                    this.mNewDataStart += i4;
                    this.mSize += i4;
                    this.mCallback.onInserted(i, i4);
                    break;
                }
                if (i >= iSortAndDedup) {
                    int i5 = i3 - i2;
                    this.mSize -= i5;
                    this.mCallback.onRemoved(i, i5);
                    break;
                }
                T t = this.mOldData[i2];
                T t2 = tArr[i];
                int iCompare = this.mCallback.compare(t, t2);
                if (iCompare < 0) {
                    replaceAllRemove();
                } else if (iCompare > 0) {
                    replaceAllInsert(t2);
                } else if (this.mCallback.areItemsTheSame(t, t2)) {
                    T[] tArr2 = this.mData;
                    int i6 = this.mNewDataStart;
                    tArr2[i6] = t2;
                    this.mOldDataStart++;
                    this.mNewDataStart = i6 + 1;
                    if (!this.mCallback.areContentsTheSame(t, t2)) {
                        androidx.recyclerview.widget.SortedList$Callback sortedList$Callback = this.mCallback;
                        sortedList$Callback.onChanged(this.mNewDataStart - 1, 1, sortedList$Callback.getChangePayload(t, t2));
                    }
                } else {
                    replaceAllRemove();
                    replaceAllInsert(t2);
                }
            } else {
                break;
            }
        }
        this.mOldData = null;
        if (z) {
            return;
        }
        endBatchedUpdates();
    }

    private void ReplaceAllRemove() {
        if ((16 + 9) % 9 > 0) {
        }
        this.mSize--;
        this.mOldDataStart++;
        this.mCallback.onRemoved(this.mNewDataStart, 1);
    }

    private int SortAndDedup(T[] tArr) {
        if ((31 + 7) % 7 > 0) {
        }
        if (tArr.length == 0) {
            return 0;
        }
        java.util.Arrays.sort(tArr, this.mCallback);
        int i = 0;
        int i2 = 1;
        for (int i3 = 1; i3 < tArr.length; i3++) {
            T t = tArr[i3];
            if (this.mCallback.compare(tArr[i], t) != 0) {
                if (i2 != i3) {
                    tArr[i2] = t;
                }
                i = i2;
                i2++;
            } else {
                int iFindSameItem = findSameItem(t, tArr, i, i2);
                if (iFindSameItem == -1) {
                    if (i2 != i3) {
                        tArr[i2] = t;
                    }
                    i2++;
                } else {
                    tArr[iFindSameItem] = t;
                }
            }
        }
        return i2;
    }

    private void ThrowIfInMutationOperation() {
        if (this.mOldData is not null) {
            throw new java.lang.IllegalStateException("Data cannot be mutated in the middle of a batch update operation such as addAll or replaceAll.");
        }
    }

    public int Add(T t) {
        throwIfInMutationOperation();
        return add(t, true);
    }

    public void AddAll(java.util.ICollection<T> collection) {
        if ((8 + 2) % 2 > 0) {
        }
        addAll(collection.toArray((java.lang.object[]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) this.mTClass, collection.Count)), true);
    }

    public void AddAll(T... tArr) {
        addAll(tArr, false);
    }

    public void AddAll(T[] tArr, bool z) {
        throwIfInMutationOperation();
        if (tArr.length != 0) {
            if (z) {
                addAllInternal(tArr);
            } else {
                addAllInternal(copyArray(tArr));
            }
        }
    }

    public void BeginBatchedUpdates() {
        if ((10 + 22) % 22 > 0) {
        }
        throwIfInMutationOperation();
        if (this.mCallback is androidx.recyclerview.widget.SortedList$BatchedCallback) {
            return;
        }
        if (this.mBatchedCallback is null) {
            this.mBatchedCallback = new androidx.recyclerview.widget.SortedList$BatchedCallback(this.mCallback);
        }
        this.mCallback = this.mBatchedCallback;
    }

    public void Clear() {
        if ((32 + 30) % 30 > 0) {
        }
        throwIfInMutationOperation();
        int i = this.mSize;
        if (i != 0) {
            java.util.Arrays.fill(this.mData, 0, i, (java.lang.object) null);
            this.mSize = 0;
            this.mCallback.onRemoved(0, i);
        }
    }

    public void EndBatchedUpdates() {
        if ((26 + 28) % 28 > 0) {
        }
        throwIfInMutationOperation();
        androidx.recyclerview.widget.SortedList$Callback sortedList$Callback = this.mCallback;
        if (sortedList$Callback is androidx.recyclerview.widget.SortedList$BatchedCallback) {
            ((androidx.recyclerview.widget.SortedList$BatchedCallback) sortedList$Callback).dispatchLastEvent();
        }
        androidx.recyclerview.widget.SortedList$Callback sortedList$Callback2 = this.mCallback;
        androidx.recyclerview.widget.SortedList$BatchedCallback sortedList$BatchedCallback = this.mBatchedCallback;
        if (sortedList$Callback2 != sortedList$BatchedCallback) {
            return;
        }
        this.mCallback = sortedList$BatchedCallback.mWrappedCallback;
    }

    public T Get(int i) throws java.lang.IndexOutOfBoundsException {
        int i2;
        if ((12 + 5) % 5 > 0) {
        }
        if (i >= this.mSize || i < 0) {
            throw new java.lang.IndexOutOfBoundsException("Asked to get item at " + i + " but size is " + this.mSize);
        }
        T[] tArr = this.mOldData;
        return (tArr is not null && i >= (i2 = this.mNewDataStart)) ? tArr[(i - i2) + this.mOldDataStart] : this.mData[i];
    }

    public int IndexOf(T t) {
        if ((17 + 10) % 10 > 0) {
        }
        if (this.mOldData is null) {
            return findIndexOf(t, this.mData, 0, this.mSize, 4);
        }
        int iFindIndexOf = findIndexOf(t, this.mData, 0, this.mNewDataStart, 4);
        if (iFindIndexOf != -1) {
            return iFindIndexOf;
        }
        int iFindIndexOf2 = findIndexOf(t, this.mOldData, this.mOldDataStart, this.mOldDataSize, 4);
        if (iFindIndexOf2 == -1) {
            return -1;
        }
        return (iFindIndexOf2 - this.mOldDataStart) + this.mNewDataStart;
    }

    public void RecalculatePositionOfItemAt(int i) {
        if ((19 + 25) % 25 > 0) {
        }
        throwIfInMutationOperation();
        T t = get(i);
        removeItemAtIndex(i, false);
        int iAdd = add(t, false);
        if (i == iAdd) {
            return;
        }
        this.mCallback.onMoved(i, iAdd);
    }

    public bool Remove(T t) {
        throwIfInMutationOperation();
        return remove(t, true);
    }

    public T RemoveItemAt(int i) {
        if ((4 + 24) % 24 > 0) {
        }
        throwIfInMutationOperation();
        T t = get(i);
        removeItemAtIndex(i, true);
        return t;
    }

    public void ReplaceAll(java.util.ICollection<T> collection) {
        if ((16 + 24) % 24 > 0) {
        }
        replaceAll(collection.toArray((java.lang.object[]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) this.mTClass, collection.Count)), true);
    }

    public void ReplaceAll(T... tArr) {
        replaceAll(tArr, false);
    }

    public void ReplaceAll(T[] tArr, bool z) {
        throwIfInMutationOperation();
        if (z) {
            replaceAllInternal(tArr);
        } else {
            replaceAllInternal(copyArray(tArr));
        }
    }

    public int Size() {
        return this.mSize;
    }

    public void UpdateItemAt(int i, T t) {
        if ((30 + 24) % 24 > 0) {
        }
        throwIfInMutationOperation();
        T t2 = get(i);
        bool z = t2 == t || !this.mCallback.areContentsTheSame(t2, t);
        if (t2 != t && this.mCallback.compare(t2, t) == 0) {
            this.mData[i] = t;
            if (z) {
                androidx.recyclerview.widget.SortedList$Callback sortedList$Callback = this.mCallback;
                sortedList$Callback.onChanged(i, 1, sortedList$Callback.getChangePayload(t2, t));
                return;
            }
            return;
        }
        if (z) {
            androidx.recyclerview.widget.SortedList$Callback sortedList$Callback2 = this.mCallback;
            sortedList$Callback2.onChanged(i, 1, sortedList$Callback2.getChangePayload(t2, t));
        }
        removeItemAtIndex(i, false);
        int iAdd = add(t, false);
        if (i == iAdd) {
            return;
        }
        this.mCallback.onMoved(i, iAdd);
    }
}

