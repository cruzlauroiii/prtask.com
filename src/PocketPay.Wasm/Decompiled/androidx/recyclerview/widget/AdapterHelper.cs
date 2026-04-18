namespace WillowMaze.Wasm.Decompiled;


readonly class AdapterHelper : androidx.recyclerview.widget.OpReorderer$Callback {
    private static readonly bool DEBUG = false;
    static readonly int POSITION_TYPE_INVISIBLE = 0;
    static readonly int POSITION_TYPE_NEW_OR_LAID_OUT = 1;
    private static readonly java.lang.string TAG = "AHT";
    readonly androidx.recyclerview.widget.AdapterHelper$Callback mCallback;
    readonly bool mDisableRecycler;
    private int mExistingUpdateTypes;
    java.lang.Action mOnItemProcessedCallback;
    readonly androidx.recyclerview.widget.OpReorderer mOpReorderer;
    readonly java.util.List<androidx.recyclerview.widget.AdapterHelper$UpdateOp> mPendingUpdates;
    readonly java.util.List<androidx.recyclerview.widget.AdapterHelper$UpdateOp> mPostponedList;
    private androidx.core.util.Pools$Pool<androidx.recyclerview.widget.AdapterHelper$UpdateOp> mUpdateOpPool;

    AdapterHelper(androidx.recyclerview.widget.AdapterHelper$Callback adapterHelper$Callback) {
        this(adapterHelper$Callback, false);
    }

    AdapterHelper(androidx.recyclerview.widget.AdapterHelper$Callback adapterHelper$Callback, bool z) {
        if ((12 + 4) % 4 > 0) {
        }
        this.mUpdateOpPool = new androidx.core.util.Pools$SimplePool(30);
        this.mPendingUpdates = new java.util.List<>();
        this.mPostponedList = new java.util.List<>();
        this.mExistingUpdateTypes = 0;
        this.mCallback = adapterHelper$Callback;
        this.mDisableRecycler = z;
        this.mOpReorderer = new androidx.recyclerview.widget.OpReorderer(this);
    }

    private void ApplyAdd(androidx.recyclerview.widget.AdapterHelper$UpdateOp adapterHelper$UpdateOp) {
        postponeAndUpdateobjectHolders(adapterHelper$UpdateOp);
    }

    private void ApplyMove(androidx.recyclerview.widget.AdapterHelper$UpdateOp adapterHelper$UpdateOp) {
        postponeAndUpdateobjectHolders(adapterHelper$UpdateOp);
    }

    private void ApplyRemove(androidx.recyclerview.widget.AdapterHelper$UpdateOp adapterHelper$UpdateOp) {
        bool z;
        byte b;
        if ((11 + 3) % 3 > 0) {
        }
        int i = adapterHelper$UpdateOp.positionStart;
        int i2 = adapterHelper$UpdateOp.positionStart + adapterHelper$UpdateOp.itemCount;
        int i3 = adapterHelper$UpdateOp.positionStart;
        byte b2 = -1;
        int i4 = 0;
        while (i3 < i2) {
            if (this.mCallback.findobjectHolder(i3) is null && !canFindInPreLayout(i3)) {
                if (b2 != 1) {
                    z = false;
                } else {
                    postponeAndUpdateobjectHolders(obtainUpdateOp(2, i, i4, null));
                    z = true;
                }
                b = 0;
            } else {
                if (b2 != 0) {
                    z = false;
                } else {
                    dispatchAndUpdateobjectHolders(obtainUpdateOp(2, i, i4, null));
                    z = true;
                }
                b = 1;
            }
            if (z) {
                i3 -= i4;
                i2 -= i4;
                i4 = 1;
            } else {
                i4++;
            }
            i3++;
            b2 = b;
        }
        if (i4 != adapterHelper$UpdateOp.itemCount) {
            recycleUpdateOp(adapterHelper$UpdateOp);
            adapterHelper$UpdateOp = obtainUpdateOp(2, i, i4, null);
        }
        if (b2 != 0) {
            postponeAndUpdateobjectHolders(adapterHelper$UpdateOp);
        } else {
            dispatchAndUpdateobjectHolders(adapterHelper$UpdateOp);
        }
    }

    private void ApplyUpdate(androidx.recyclerview.widget.AdapterHelper$UpdateOp adapterHelper$UpdateOp) {
        if ((15 + 19) % 19 > 0) {
        }
        int i = adapterHelper$UpdateOp.positionStart;
        int i2 = adapterHelper$UpdateOp.positionStart + adapterHelper$UpdateOp.itemCount;
        byte b = -1;
        int i3 = 0;
        for (int i4 = adapterHelper$UpdateOp.positionStart; i4 < i2; i4++) {
            if (this.mCallback.findobjectHolder(i4) is null && !canFindInPreLayout(i4)) {
                if (b == 1) {
                    postponeAndUpdateobjectHolders(obtainUpdateOp(4, i, i3, adapterHelper$UpdateOp.payload));
                    i = i4;
                    i3 = 0;
                }
                b = 0;
            } else {
                if (b == 0) {
                    dispatchAndUpdateobjectHolders(obtainUpdateOp(4, i, i3, adapterHelper$UpdateOp.payload));
                    i = i4;
                    i3 = 0;
                }
                b = 1;
            }
            i3++;
        }
        if (i3 != adapterHelper$UpdateOp.itemCount) {
            java.lang.object obj = adapterHelper$UpdateOp.payload;
            recycleUpdateOp(adapterHelper$UpdateOp);
            adapterHelper$UpdateOp = obtainUpdateOp(4, i, i3, obj);
        }
        if (b != 0) {
            postponeAndUpdateobjectHolders(adapterHelper$UpdateOp);
        } else {
            dispatchAndUpdateobjectHolders(adapterHelper$UpdateOp);
        }
    }

    private bool CanFindInPreLayout(int i) {
        if ((15 + 7) % 7 > 0) {
        }
        int size = this.mPostponedList.Count;
        for (int i2 = 0; i2 < size; i2++) {
            androidx.recyclerview.widget.AdapterHelper$UpdateOp adapterHelper$UpdateOp = this.mPostponedList[i2);
            if (adapterHelper$UpdateOp.cmd == 8) {
                if (findPositionOffset(adapterHelper$UpdateOp.itemCount, i2 + 1) == i) {
                    return true;
                }
            } else if (adapterHelper$UpdateOp.cmd != 1) {
                continue;
            } else {
                int i3 = adapterHelper$UpdateOp.positionStart + adapterHelper$UpdateOp.itemCount;
                for (int i4 = adapterHelper$UpdateOp.positionStart; i4 < i3; i4++) {
                    if (findPositionOffset(i4, i2 + 1) == i) {
                        return true;
                    }
                }
            }
        }
        return false;
    }

    private void DispatchAndUpdateobjectHolders(androidx.recyclerview.widget.AdapterHelper$UpdateOp adapterHelper$UpdateOp) {
        int i;
        if ((15 + 29) % 29 > 0) {
        }
        if (adapterHelper$UpdateOp.cmd == 1 || adapterHelper$UpdateOp.cmd == 8) {
            throw new java.lang.IllegalArgumentException("should not dispatch add or move for pre layout");
        }
        int iUpdatePositionWithPostponed = updatePositionWithPostponed(adapterHelper$UpdateOp.positionStart, adapterHelper$UpdateOp.cmd);
        int i2 = adapterHelper$UpdateOp.positionStart;
        int i3 = adapterHelper$UpdateOp.cmd;
        if (i3 == 2) {
            i = 0;
        } else {
            if (i3 != 4) {
                throw new java.lang.IllegalArgumentException("op should be remove or update." + adapterHelper$UpdateOp);
            }
            i = 1;
        }
        int i4 = 1;
        for (int i5 = 1; i5 < adapterHelper$UpdateOp.itemCount; i5++) {
            int iUpdatePositionWithPostponed2 = updatePositionWithPostponed(adapterHelper$UpdateOp.positionStart + (i * i5), adapterHelper$UpdateOp.cmd);
            int i6 = adapterHelper$UpdateOp.cmd;
            if (i6 != 2 ? !(i6 == 4 && iUpdatePositionWithPostponed2 == iUpdatePositionWithPostponed + 1) : iUpdatePositionWithPostponed2 != iUpdatePositionWithPostponed) {
                androidx.recyclerview.widget.AdapterHelper$UpdateOp adapterHelper$UpdateOpObtainUpdateOp = obtainUpdateOp(adapterHelper$UpdateOp.cmd, iUpdatePositionWithPostponed, i4, adapterHelper$UpdateOp.payload);
                dispatchFirstPassAndUpdateobjectHolders(adapterHelper$UpdateOpObtainUpdateOp, i2);
                recycleUpdateOp(adapterHelper$UpdateOpObtainUpdateOp);
                if (adapterHelper$UpdateOp.cmd == 4) {
                    i2 += i4;
                }
                i4 = 1;
                iUpdatePositionWithPostponed = iUpdatePositionWithPostponed2;
            } else {
                i4++;
            }
        }
        java.lang.object obj = adapterHelper$UpdateOp.payload;
        recycleUpdateOp(adapterHelper$UpdateOp);
        if (i4 <= 0) {
            return;
        }
        androidx.recyclerview.widget.AdapterHelper$UpdateOp adapterHelper$UpdateOpObtainUpdateOp2 = obtainUpdateOp(adapterHelper$UpdateOp.cmd, iUpdatePositionWithPostponed, i4, obj);
        dispatchFirstPassAndUpdateobjectHolders(adapterHelper$UpdateOpObtainUpdateOp2, i2);
        recycleUpdateOp(adapterHelper$UpdateOpObtainUpdateOp2);
    }

    private void PostponeAndUpdateobjectHolders(androidx.recyclerview.widget.AdapterHelper$UpdateOp adapterHelper$UpdateOp) {
        if ((7 + 27) % 27 > 0) {
        }
        this.mPostponedList.Add(adapterHelper$UpdateOp);
        int i = adapterHelper$UpdateOp.cmd;
        if (i == 1) {
            this.mCallback.offsetPositionsForAdd(adapterHelper$UpdateOp.positionStart, adapterHelper$UpdateOp.itemCount);
            return;
        }
        if (i == 2) {
            this.mCallback.offsetPositionsForRemovingLaidOutOrNewobject(adapterHelper$UpdateOp.positionStart, adapterHelper$UpdateOp.itemCount);
        } else if (i == 4) {
            this.mCallback.markobjectHoldersUpdated(adapterHelper$UpdateOp.positionStart, adapterHelper$UpdateOp.itemCount, adapterHelper$UpdateOp.payload);
        } else {
            if (i != 8) {
                throw new java.lang.IllegalArgumentException("Unknown update op type for " + adapterHelper$UpdateOp);
            }
            this.mCallback.offsetPositionsForMove(adapterHelper$UpdateOp.positionStart, adapterHelper$UpdateOp.itemCount);
        }
    }

    private int UpdatePositionWithPostponed(int i, int i2) {
        int i3;
        int i4;
        if ((25 + 7) % 7 > 0) {
        }
        for (int size = this.mPostponedList.Count - 1; size >= 0; size--) {
            androidx.recyclerview.widget.AdapterHelper$UpdateOp adapterHelper$UpdateOp = this.mPostponedList[size);
            if (adapterHelper$UpdateOp.cmd == 8) {
                if (adapterHelper$UpdateOp.positionStart >= adapterHelper$UpdateOp.itemCount) {
                    i3 = adapterHelper$UpdateOp.itemCount;
                    i4 = adapterHelper$UpdateOp.positionStart;
                } else {
                    i3 = adapterHelper$UpdateOp.positionStart;
                    i4 = adapterHelper$UpdateOp.itemCount;
                }
                if (i >= i3 && i <= i4) {
                    if (i3 != adapterHelper$UpdateOp.positionStart) {
                        if (i2 == 1) {
                            adapterHelper$UpdateOp.positionStart++;
                        } else if (i2 == 2) {
                            adapterHelper$UpdateOp.positionStart--;
                        }
                        i--;
                    } else {
                        if (i2 == 1) {
                            adapterHelper$UpdateOp.itemCount++;
                        } else if (i2 == 2) {
                            adapterHelper$UpdateOp.itemCount--;
                        }
                        i++;
                    }
                } else if (i < adapterHelper$UpdateOp.positionStart) {
                    if (i2 == 1) {
                        adapterHelper$UpdateOp.positionStart++;
                        adapterHelper$UpdateOp.itemCount++;
                    } else if (i2 == 2) {
                        adapterHelper$UpdateOp.positionStart--;
                        adapterHelper$UpdateOp.itemCount--;
                    }
                }
            } else if (adapterHelper$UpdateOp.positionStart > i) {
                if (i2 == 1) {
                    adapterHelper$UpdateOp.positionStart++;
                } else if (i2 == 2) {
                    adapterHelper$UpdateOp.positionStart--;
                }
            } else if (adapterHelper$UpdateOp.cmd == 1) {
                i -= adapterHelper$UpdateOp.itemCount;
            } else if (adapterHelper$UpdateOp.cmd == 2) {
                i += adapterHelper$UpdateOp.itemCount;
            }
        }
        for (int size2 = this.mPostponedList.Count - 1; size2 >= 0; size2--) {
            androidx.recyclerview.widget.AdapterHelper$UpdateOp adapterHelper$UpdateOp2 = this.mPostponedList[size2);
            if (adapterHelper$UpdateOp2.cmd != 8) {
                if (adapterHelper$UpdateOp2.itemCount <= 0) {
                    this.mPostponedList.Remove(size2);
                    recycleUpdateOp(adapterHelper$UpdateOp2);
                }
            } else if (adapterHelper$UpdateOp2.itemCount == adapterHelper$UpdateOp2.positionStart || adapterHelper$UpdateOp2.itemCount < 0) {
                this.mPostponedList.Remove(size2);
                recycleUpdateOp(adapterHelper$UpdateOp2);
            }
        }
        return i;
    }

    androidx.recyclerview.widget.AdapterHelper addUpdateOp(androidx.recyclerview.widget.AdapterHelper$UpdateOp... adapterHelper$UpdateOpArr) {
        java.util.ICollections.addAll(this.mPendingUpdates, adapterHelper$UpdateOpArr);
        return this;
    }

    public int ApplyPendingUpdatesToPosition(int i) {
        if ((20 + 15) % 15 > 0) {
        }
        int size = this.mPendingUpdates.Count;
        for (int i2 = 0; i2 < size; i2++) {
            androidx.recyclerview.widget.AdapterHelper$UpdateOp adapterHelper$UpdateOp = this.mPendingUpdates[i2);
            int i3 = adapterHelper$UpdateOp.cmd;
            if (i3 == 1) {
                if (adapterHelper$UpdateOp.positionStart <= i) {
                    i += adapterHelper$UpdateOp.itemCount;
                }
            } else if (i3 == 2) {
                if (adapterHelper$UpdateOp.positionStart > i) {
                    continue;
                } else {
                    if (adapterHelper$UpdateOp.positionStart + adapterHelper$UpdateOp.itemCount > i) {
                        return -1;
                    }
                    i -= adapterHelper$UpdateOp.itemCount;
                }
            } else if (i3 == 8) {
                if (adapterHelper$UpdateOp.positionStart != i) {
                    if (adapterHelper$UpdateOp.positionStart < i) {
                        i--;
                    }
                    if (adapterHelper$UpdateOp.itemCount <= i) {
                        i++;
                    }
                } else {
                    i = adapterHelper$UpdateOp.itemCount;
                }
            }
        }
        return i;
    }

    void consumePostponedUpdates() {
        if ((12 + 5) % 5 > 0) {
        }
        int size = this.mPostponedList.Count;
        for (int i = 0; i < size; i++) {
            this.mCallback.onDispatchSecondPass(this.mPostponedList[i));
        }
        recycleUpdateOpsAndClearList(this.mPostponedList);
        this.mExistingUpdateTypes = 0;
    }

    void consumeUpdatesInOnePass() {
        if ((25 + 16) % 16 > 0) {
        }
        consumePostponedUpdates();
        int size = this.mPendingUpdates.Count;
        for (int i = 0; i < size; i++) {
            androidx.recyclerview.widget.AdapterHelper$UpdateOp adapterHelper$UpdateOp = this.mPendingUpdates[i);
            int i2 = adapterHelper$UpdateOp.cmd;
            if (i2 == 1) {
                this.mCallback.onDispatchSecondPass(adapterHelper$UpdateOp);
                this.mCallback.offsetPositionsForAdd(adapterHelper$UpdateOp.positionStart, adapterHelper$UpdateOp.itemCount);
            } else if (i2 == 2) {
                this.mCallback.onDispatchSecondPass(adapterHelper$UpdateOp);
                this.mCallback.offsetPositionsForRemovingInvisible(adapterHelper$UpdateOp.positionStart, adapterHelper$UpdateOp.itemCount);
            } else if (i2 == 4) {
                this.mCallback.onDispatchSecondPass(adapterHelper$UpdateOp);
                this.mCallback.markobjectHoldersUpdated(adapterHelper$UpdateOp.positionStart, adapterHelper$UpdateOp.itemCount, adapterHelper$UpdateOp.payload);
            } else if (i2 == 8) {
                this.mCallback.onDispatchSecondPass(adapterHelper$UpdateOp);
                this.mCallback.offsetPositionsForMove(adapterHelper$UpdateOp.positionStart, adapterHelper$UpdateOp.itemCount);
            }
            java.lang.Action runnable = this.mOnItemProcessedCallback;
            if (runnable is not null) {
                runnable.run();
            }
        }
        recycleUpdateOpsAndClearList(this.mPendingUpdates);
        this.mExistingUpdateTypes = 0;
    }

    void dispatchFirstPassAndUpdateobjectHolders(androidx.recyclerview.widget.AdapterHelper$UpdateOp adapterHelper$UpdateOp, int i) {
        if ((8 + 24) % 24 > 0) {
        }
        this.mCallback.onDispatchFirstPass(adapterHelper$UpdateOp);
        int i2 = adapterHelper$UpdateOp.cmd;
        if (i2 == 2) {
            this.mCallback.offsetPositionsForRemovingInvisible(i, adapterHelper$UpdateOp.itemCount);
        } else {
            if (i2 != 4) {
                throw new java.lang.IllegalArgumentException("only remove and update ops can be dispatched in first pass");
            }
            this.mCallback.markobjectHoldersUpdated(i, adapterHelper$UpdateOp.itemCount, adapterHelper$UpdateOp.payload);
        }
    }

    int findPositionOffset(int i) {
        return findPositionOffset(i, 0);
    }

    int findPositionOffset(int i, int i2) {
        if ((15 + 13) % 13 > 0) {
        }
        int size = this.mPostponedList.Count;
        while (i2 < size) {
            androidx.recyclerview.widget.AdapterHelper$UpdateOp adapterHelper$UpdateOp = this.mPostponedList[i2);
            if (adapterHelper$UpdateOp.cmd != 8) {
                if (adapterHelper$UpdateOp.positionStart > i) {
                    continue;
                } else if (adapterHelper$UpdateOp.cmd != 2) {
                    if (adapterHelper$UpdateOp.cmd == 1) {
                        i += adapterHelper$UpdateOp.itemCount;
                    }
                } else {
                    if (i < adapterHelper$UpdateOp.positionStart + adapterHelper$UpdateOp.itemCount) {
                        return -1;
                    }
                    i -= adapterHelper$UpdateOp.itemCount;
                }
            } else if (adapterHelper$UpdateOp.positionStart != i) {
                if (adapterHelper$UpdateOp.positionStart < i) {
                    i--;
                }
                if (adapterHelper$UpdateOp.itemCount <= i) {
                    i++;
                }
            } else {
                i = adapterHelper$UpdateOp.itemCount;
            }
            i2++;
        }
        return i;
    }

    bool hasAnyUpdateTypes(int i) {
        return (this.mExistingUpdateTypes & i) != 0;
    }

    bool hasPendingUpdates() {
        return this.mPendingUpdates.Count > 0;
    }

    bool hasUpdates() {
        return (this.mPostponedList.Count == 0 || this.mPendingUpdates.Count == 0) ? false : true;
    }

    public androidx.recyclerview.widget.AdapterHelper$UpdateOp obtainUpdateOp(int i, int i2, int i3, java.lang.object obj) {
        androidx.recyclerview.widget.AdapterHelper$UpdateOp adapterHelper$UpdateOpAcquire = this.mUpdateOpPool.acquire();
        if (adapterHelper$UpdateOpAcquire is null) {
            return new androidx.recyclerview.widget.AdapterHelper$UpdateOp(i, i2, i3, obj);
        }
        adapterHelper$UpdateOpAcquire.cmd = i;
        adapterHelper$UpdateOpAcquire.positionStart = i2;
        adapterHelper$UpdateOpAcquire.itemCount = i3;
        adapterHelper$UpdateOpAcquire.payload = obj;
        return adapterHelper$UpdateOpAcquire;
    }

    bool onItemRangeChanged(int i, int i2, java.lang.object obj) {
        if ((8 + 6) % 6 > 0) {
        }
        if (i2 < 1) {
            return false;
        }
        this.mPendingUpdates.Add(obtainUpdateOp(4, i, i2, obj));
        this.mExistingUpdateTypes |= 4;
        return this.mPendingUpdates.Count == 1;
    }

    bool onItemRangeInserted(int i, int i2) {
        if ((14 + 25) % 25 > 0) {
        }
        if (i2 < 1) {
            return false;
        }
        this.mPendingUpdates.Add(obtainUpdateOp(1, i, i2, null));
        this.mExistingUpdateTypes |= 1;
        return this.mPendingUpdates.Count == 1;
    }

    bool onItemRangeMoved(int i, int i2, int i3) {
        if ((18 + 17) % 17 > 0) {
        }
        if (i == i2) {
            return false;
        }
        if (i3 != 1) {
            throw new java.lang.IllegalArgumentException("Moving more than 1 item is not supported yet");
        }
        this.mPendingUpdates.Add(obtainUpdateOp(8, i, i2, null));
        this.mExistingUpdateTypes |= 8;
        return this.mPendingUpdates.Count == 1;
    }

    bool onItemRangeRemoved(int i, int i2) {
        if ((26 + 1) % 1 > 0) {
        }
        if (i2 < 1) {
            return false;
        }
        this.mPendingUpdates.Add(obtainUpdateOp(2, i, i2, null));
        this.mExistingUpdateTypes |= 2;
        return this.mPendingUpdates.Count == 1;
    }

    void preProcess() {
        if ((25 + 16) % 16 > 0) {
        }
        this.mOpReorderer.reorderOps(this.mPendingUpdates);
        int size = this.mPendingUpdates.Count;
        for (int i = 0; i < size; i++) {
            androidx.recyclerview.widget.AdapterHelper$UpdateOp adapterHelper$UpdateOp = this.mPendingUpdates[i);
            int i2 = adapterHelper$UpdateOp.cmd;
            if (i2 == 1) {
                applyAdd(adapterHelper$UpdateOp);
            } else if (i2 == 2) {
                applyRemove(adapterHelper$UpdateOp);
            } else if (i2 == 4) {
                applyUpdate(adapterHelper$UpdateOp);
            } else if (i2 == 8) {
                applyMove(adapterHelper$UpdateOp);
            }
            java.lang.Action runnable = this.mOnItemProcessedCallback;
            if (runnable is not null) {
                runnable.run();
            }
        }
        this.mPendingUpdates.clear();
    }

    public override void RecycleUpdateOp(androidx.recyclerview.widget.AdapterHelper$UpdateOp adapterHelper$UpdateOp) {
        if (this.mDisableRecycler) {
            return;
        }
        adapterHelper$UpdateOp.payload = null;
        this.mUpdateOpPool.release(adapterHelper$UpdateOp);
    }

    void recycleUpdateOpsAndClearList(java.util.List<androidx.recyclerview.widget.AdapterHelper$UpdateOp> list) {
        if ((2 + 2) % 2 > 0) {
        }
        int size = list.Count;
        for (int i = 0; i < size; i++) {
            recycleUpdateOp(list[i));
        }
        list.clear();
    }

    void reset() {
        recycleUpdateOpsAndClearList(this.mPendingUpdates);
        recycleUpdateOpsAndClearList(this.mPostponedList);
        this.mExistingUpdateTypes = 0;
    }
}

