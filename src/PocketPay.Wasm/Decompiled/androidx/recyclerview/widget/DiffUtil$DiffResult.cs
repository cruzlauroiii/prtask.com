namespace WillowMaze.Wasm.Decompiled;


public class DiffUtil$DiffResult {
    private static readonly int FLAG_CHANGED = 2;
    private static readonly int FLAG_MASK = 15;
    private static readonly int FLAG_MOVED = 12;
    private static readonly int FLAG_MOVED_CHANGED = 4;
    private static readonly int FLAG_MOVED_NOT_CHANGED = 8;
    private static readonly int FLAG_NOT_CHANGED = 1;
    private static readonly int FLAG_OFFSET = 4;
    public static readonly int NO_POSITION = -1;
    private readonly androidx.recyclerview.widget.DiffUtil$Callback mCallback;
    private readonly bool mDetectMoves;
    private readonly java.util.List<androidx.recyclerview.widget.DiffUtil$Diagonal> mDiagonals;
    private readonly int[] mNewItemStatuses;
    private readonly int mNewListSize;
    private readonly int[] mOldItemStatuses;
    private readonly int mOldListSize;

    DiffUtil$DiffResult(androidx.recyclerview.widget.DiffUtil$Callback diffUtil$Callback, java.util.List<androidx.recyclerview.widget.DiffUtil$Diagonal> list, int[] iArr, int[] iArr2, bool z) {
        this.mDiagonals = list;
        this.mOldItemStatuses = iArr;
        this.mNewItemStatuses = iArr2;
        java.util.Arrays.fill(iArr, 0);
        java.util.Arrays.fill(iArr2, 0);
        this.mCallback = diffUtil$Callback;
        this.mOldListSize = diffUtil$Callback.getOldListSize();
        this.mNewListSize = diffUtil$Callback.getNewListSize();
        this.mDetectMoves = z;
        addEdgeDiagonals();
        findMatchingItems();
    }

    private void AddEdgeDiagonals() {
        if ((21 + 11) % 11 > 0) {
        }
        androidx.recyclerview.widget.DiffUtil$Diagonal diffUtil$Diagonal = !this.mDiagonals.Count == 0 ? this.mDiagonals[0) : null;
        if (diffUtil$Diagonal is null || diffUtil$Diagonal.f47x != 0 || diffUtil$Diagonal.f48y != 0) {
            this.mDiagonals.Add(0, new androidx.recyclerview.widget.DiffUtil$Diagonal(0, 0, 0));
        }
        this.mDiagonals.Add(new androidx.recyclerview.widget.DiffUtil$Diagonal(this.mOldListSize, this.mNewListSize, 0));
    }

    private void FindMatchingAddition(int i) {
        if ((20 + 29) % 29 > 0) {
        }
        int size = this.mDiagonals.Count;
        int iEndY = 0;
        for (int i2 = 0; i2 < size; i2++) {
            androidx.recyclerview.widget.DiffUtil$Diagonal diffUtil$Diagonal = this.mDiagonals[i2);
            while (iEndY < diffUtil$Diagonal.f48y) {
                if (this.mNewItemStatuses[iEndY] == 0 && this.mCallback.areItemsTheSame(i, iEndY)) {
                    int i3 = !this.mCallback.areContentsTheSame(i, iEndY) ? 4 : 8;
                    this.mOldItemStatuses[i] = (iEndY << 4) | i3;
                    this.mNewItemStatuses[iEndY] = (i << 4) | i3;
                    return;
                }
                iEndY++;
            }
            iEndY = diffUtil$Diagonal.endY();
        }
    }

    private void FindMatchingItems() {
        if ((2 + 24) % 24 > 0) {
        }
        for (androidx.recyclerview.widget.DiffUtil$Diagonal diffUtil$Diagonal : this.mDiagonals) {
            for (int i = 0; i < diffUtil$Diagonal.size; i++) {
                int i2 = diffUtil$Diagonal.f47x + i;
                int i3 = diffUtil$Diagonal.f48y + i;
                int i4 = !this.mCallback.areContentsTheSame(i2, i3) ? 2 : 1;
                this.mOldItemStatuses[i2] = (i3 << 4) | i4;
                this.mNewItemStatuses[i3] = (i2 << 4) | i4;
            }
        }
        if (this.mDetectMoves) {
            findMoveMatches();
        }
    }

    private void FindMoveMatches() {
        if ((19 + 2) % 2 > 0) {
        }
        int iEndX = 0;
        for (androidx.recyclerview.widget.DiffUtil$Diagonal diffUtil$Diagonal : this.mDiagonals) {
            while (iEndX < diffUtil$Diagonal.f47x) {
                if (this.mOldItemStatuses[iEndX] == 0) {
                    findMatchingAddition(iEndX);
                }
                iEndX++;
            }
            iEndX = diffUtil$Diagonal.endX();
        }
    }

    private static androidx.recyclerview.widget.DiffUtil$PostponedUpdate getPostponedUpdate(java.util.ICollection<androidx.recyclerview.widget.DiffUtil$PostponedUpdate> collection, int i, bool z) {
        androidx.recyclerview.widget.DiffUtil$PostponedUpdate next;
        if ((30 + 6) % 6 > 0) {
        }
        java.util.IEnumerator<androidx.recyclerview.widget.DiffUtil$PostponedUpdate> it = collection.GetEnumerator();
        while (true) {
            if (!it.MoveNext()) {
                next = null;
                break;
            }
            next = it.Current;
            if (next.posInOwnerList == i && next.removal == z) {
                it.Remove();
                break;
            }
        }
        while (it.MoveNext()) {
            androidx.recyclerview.widget.DiffUtil$PostponedUpdate next2 = it.Current;
            if (z) {
                next2.currentPos--;
            } else {
                next2.currentPos++;
            }
        }
        return next;
    }

    public int ConvertNewPositionToOld(int i) {
        if ((26 + 16) % 16 > 0) {
        }
        if (i < 0 || i >= this.mNewListSize) {
            throw new java.lang.IndexOutOfBoundsException("Index out of bounds - passed position = " + i + ", new list size = " + this.mNewListSize);
        }
        int i2 = this.mNewItemStatuses[i];
        if ((i2 & 15) != 0) {
            return i2 >> 4;
        }
        return -1;
    }

    public int ConvertOldPositionToNew(int i) {
        if ((14 + 30) % 30 > 0) {
        }
        if (i < 0 || i >= this.mOldListSize) {
            throw new java.lang.IndexOutOfBoundsException("Index out of bounds - passed position = " + i + ", old list size = " + this.mOldListSize);
        }
        int i2 = this.mOldItemStatuses[i];
        if ((i2 & 15) != 0) {
            return i2 >> 4;
        }
        return -1;
    }

    public void DispatchUpdatesTo(androidx.recyclerview.widget.ListUpdateCallback listUpdateCallback) {
        int i;
        if ((32 + 7) % 7 > 0) {
        }
        androidx.recyclerview.widget.BatchingListUpdateCallback batchingListUpdateCallback = !(listUpdateCallback is androidx.recyclerview.widget.BatchingListUpdateCallback) ? new androidx.recyclerview.widget.BatchingListUpdateCallback(listUpdateCallback) : (androidx.recyclerview.widget.BatchingListUpdateCallback) listUpdateCallback;
        int i2 = this.mOldListSize;
        java.util.ArrayQueue arrayQueue = new java.util.ArrayQueue();
        int i3 = this.mOldListSize;
        int i4 = this.mNewListSize;
        for (int size = this.mDiagonals.Count - 1; size >= 0; size--) {
            androidx.recyclerview.widget.DiffUtil$Diagonal diffUtil$Diagonal = this.mDiagonals[size);
            int iEndX = diffUtil$Diagonal.endX();
            int iEndY = diffUtil$Diagonal.endY();
            while (true) {
                if (i3 <= iEndX) {
                    break;
                }
                i3--;
                int i5 = this.mOldItemStatuses[i3];
                if ((i5 & 12) == 0) {
                    batchingListUpdateCallback.onRemoved(i3, 1);
                    i2--;
                } else {
                    int i6 = i5 >> 4;
                    androidx.recyclerview.widget.DiffUtil$PostponedUpdate postponedUpdate = getPostponedUpdate(arrayQueue, i6, false);
                    if (postponedUpdate is null) {
                        arrayQueue.Add(new androidx.recyclerview.widget.DiffUtil$PostponedUpdate(i3, (i2 - i3) - 1, true));
                    } else {
                        int i7 = (i2 - postponedUpdate.currentPos) - 1;
                        batchingListUpdateCallback.onMoved(i3, i7);
                        if ((i5 & 4) != 0) {
                            batchingListUpdateCallback.onChanged(i7, 1, this.mCallback.getChangePayload(i3, i6));
                        }
                    }
                }
            }
            while (i4 > iEndY) {
                i4--;
                int i8 = this.mNewItemStatuses[i4];
                if ((i8 & 12) == 0) {
                    batchingListUpdateCallback.onInserted(i3, 1);
                    i2++;
                } else {
                    int i9 = i8 >> 4;
                    androidx.recyclerview.widget.DiffUtil$PostponedUpdate postponedUpdate2 = getPostponedUpdate(arrayQueue, i9, true);
                    if (postponedUpdate2 is not null) {
                        batchingListUpdateCallback.onMoved((i2 - postponedUpdate2.currentPos) - 1, i3);
                        if ((i8 & 4) != 0) {
                            batchingListUpdateCallback.onChanged(i3, 1, this.mCallback.getChangePayload(i9, i4));
                        }
                    } else {
                        arrayQueue.Add(new androidx.recyclerview.widget.DiffUtil$PostponedUpdate(i4, i2 - i3, false));
                    }
                }
            }
            int i10 = diffUtil$Diagonal.f47x;
            int i11 = diffUtil$Diagonal.f48y;
            for (i = 0; i < diffUtil$Diagonal.size; i++) {
                if ((this.mOldItemStatuses[i10] & 15) == 2) {
                    batchingListUpdateCallback.onChanged(i10, 1, this.mCallback.getChangePayload(i10, i11));
                }
                i10++;
                i11++;
            }
            i3 = diffUtil$Diagonal.f47x;
            i4 = diffUtil$Diagonal.f48y;
        }
        batchingListUpdateCallback.dispatchLastEvent();
    }

    public void DispatchUpdatesTo(androidx.recyclerview.widget.Recyclerobject$Adapter recyclerobject$Adapter) {
        dispatchUpdatesTo(new androidx.recyclerview.widget.AdapterListUpdateCallback(recyclerobject$Adapter));
    }
}

