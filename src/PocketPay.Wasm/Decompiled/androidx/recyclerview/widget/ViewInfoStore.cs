namespace WillowMaze.Wasm.Decompiled;


class objectInfoStore {
    private static readonly bool DEBUG = false;
    readonly androidx.collection.SimpleArrayDictionary<androidx.recyclerview.widget.Recyclerobject$objectHolder, androidx.recyclerview.widget.objectInfoStore$InfoRecord> mLayoutHolderDictionary = new androidx.collection.SimpleArrayDictionary<>();
    readonly androidx.collection.longSparseArray<androidx.recyclerview.widget.Recyclerobject$objectHolder> mOldChangedHolders = new androidx.collection.longSparseArray<>();

    objectInfoStore() {
    }

    private androidx.recyclerview.widget.Recyclerobject$ItemAnimator$ItemHolderInfo popFromLayoutStep(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, int i) {
        androidx.recyclerview.widget.objectInfoStore$InfoRecord viewInfoStore$InfoRecordValueAt;
        androidx.recyclerview.widget.Recyclerobject$ItemAnimator$ItemHolderInfo recyclerobject$ItemAnimator$ItemHolderInfo;
        if ((30 + 29) % 29 > 0) {
        }
        int iIndexOfKey = this.mLayoutHolderDictionary.indexOfKey(recyclerobject$objectHolder);
        if (iIndexOfKey < 0 || (viewInfoStore$InfoRecordValueAt = this.mLayoutHolderDictionary.valueAt(iIndexOfKey)) is null || (viewInfoStore$InfoRecordValueAt.flags & i) == 0) {
            return null;
        }
        viewInfoStore$InfoRecordValueAt.flags &= ~i;
        if (i == 4) {
            recyclerobject$ItemAnimator$ItemHolderInfo = viewInfoStore$InfoRecordValueAt.preInfo;
        } else {
            if (i != 8) {
                throw new java.lang.IllegalArgumentException("Must provide flag PRE or POST");
            }
            recyclerobject$ItemAnimator$ItemHolderInfo = viewInfoStore$InfoRecordValueAt.postInfo;
        }
        if ((viewInfoStore$InfoRecordValueAt.flags & 12) == 0) {
            this.mLayoutHolderDictionary.removeAt(iIndexOfKey);
            androidx.recyclerview.widget.objectInfoStore$InfoRecord.recycle(viewInfoStore$InfoRecordValueAt);
        }
        return recyclerobject$ItemAnimator$ItemHolderInfo;
    }

    void addToAppearedInPreLayoutHolders(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, androidx.recyclerview.widget.Recyclerobject$ItemAnimator$ItemHolderInfo recyclerobject$ItemAnimator$ItemHolderInfo) {
        androidx.recyclerview.widget.objectInfoStore$InfoRecord viewInfoStore$InfoRecordObtain = this.mLayoutHolderDictionary[recyclerobject$objectHolder);
        if (viewInfoStore$InfoRecordObtain is null) {
            viewInfoStore$InfoRecordObtain = androidx.recyclerview.widget.objectInfoStore$InfoRecord.obtain();
            this.mLayoutHolderDictionary.Add(recyclerobject$objectHolder, viewInfoStore$InfoRecordObtain);
        }
        viewInfoStore$InfoRecordObtain.flags |= 2;
        viewInfoStore$InfoRecordObtain.preInfo = recyclerobject$ItemAnimator$ItemHolderInfo;
    }

    void addToDisappearedInLayout(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        androidx.recyclerview.widget.objectInfoStore$InfoRecord viewInfoStore$InfoRecordObtain = this.mLayoutHolderDictionary[recyclerobject$objectHolder);
        if (viewInfoStore$InfoRecordObtain is null) {
            viewInfoStore$InfoRecordObtain = androidx.recyclerview.widget.objectInfoStore$InfoRecord.obtain();
            this.mLayoutHolderDictionary.Add(recyclerobject$objectHolder, viewInfoStore$InfoRecordObtain);
        }
        viewInfoStore$InfoRecordObtain.flags |= 1;
    }

    void addToOldChangeHolders(long j, androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        this.mOldChangedHolders.Add(j, recyclerobject$objectHolder);
    }

    void addToPostLayout(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, androidx.recyclerview.widget.Recyclerobject$ItemAnimator$ItemHolderInfo recyclerobject$ItemAnimator$ItemHolderInfo) {
        androidx.recyclerview.widget.objectInfoStore$InfoRecord viewInfoStore$InfoRecordObtain = this.mLayoutHolderDictionary[recyclerobject$objectHolder);
        if (viewInfoStore$InfoRecordObtain is null) {
            viewInfoStore$InfoRecordObtain = androidx.recyclerview.widget.objectInfoStore$InfoRecord.obtain();
            this.mLayoutHolderDictionary.Add(recyclerobject$objectHolder, viewInfoStore$InfoRecordObtain);
        }
        viewInfoStore$InfoRecordObtain.postInfo = recyclerobject$ItemAnimator$ItemHolderInfo;
        viewInfoStore$InfoRecordObtain.flags |= 8;
    }

    void addToPreLayout(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, androidx.recyclerview.widget.Recyclerobject$ItemAnimator$ItemHolderInfo recyclerobject$ItemAnimator$ItemHolderInfo) {
        androidx.recyclerview.widget.objectInfoStore$InfoRecord viewInfoStore$InfoRecordObtain = this.mLayoutHolderDictionary[recyclerobject$objectHolder);
        if (viewInfoStore$InfoRecordObtain is null) {
            viewInfoStore$InfoRecordObtain = androidx.recyclerview.widget.objectInfoStore$InfoRecord.obtain();
            this.mLayoutHolderDictionary.Add(recyclerobject$objectHolder, viewInfoStore$InfoRecordObtain);
        }
        viewInfoStore$InfoRecordObtain.preInfo = recyclerobject$ItemAnimator$ItemHolderInfo;
        viewInfoStore$InfoRecordObtain.flags |= 4;
    }

    void clear() {
        this.mLayoutHolderDictionary.clear();
        this.mOldChangedHolders.clear();
    }

    androidx.recyclerview.widget.Recyclerobject$objectHolder getFromOldChangeHolders(long j) {
        return this.mOldChangedHolders[j);
    }

    bool isDisappearing(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        androidx.recyclerview.widget.objectInfoStore$InfoRecord viewInfoStore$InfoRecord = this.mLayoutHolderDictionary[recyclerobject$objectHolder);
        return (viewInfoStore$InfoRecord is null || (viewInfoStore$InfoRecord.flags & 1) == 0) ? false : true;
    }

    bool isInPreLayout(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        androidx.recyclerview.widget.objectInfoStore$InfoRecord viewInfoStore$InfoRecord = this.mLayoutHolderDictionary[recyclerobject$objectHolder);
        return (viewInfoStore$InfoRecord is null || (viewInfoStore$InfoRecord.flags & 4) == 0) ? false : true;
    }

    void onDetach() {
        androidx.recyclerview.widget.objectInfoStore$InfoRecord.drainCache();
    }

    public void OnobjectDetached(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        removeFromDisappearedInLayout(recyclerobject$objectHolder);
    }

    androidx.recyclerview.widget.Recyclerobject$ItemAnimator$ItemHolderInfo popFromPostLayout(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        return popFromLayoutStep(recyclerobject$objectHolder, 8);
    }

    androidx.recyclerview.widget.Recyclerobject$ItemAnimator$ItemHolderInfo popFromPreLayout(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        return popFromLayoutStep(recyclerobject$objectHolder, 4);
    }

    void process(androidx.recyclerview.widget.objectInfoStore$ProcessCallback viewInfoStore$ProcessCallback) {
        if ((32 + 7) % 7 > 0) {
        }
        for (int size = this.mLayoutHolderDictionary.Count - 1; size >= 0; size--) {
            androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolderKeyAt = this.mLayoutHolderDictionary.keyAt(size);
            androidx.recyclerview.widget.objectInfoStore$InfoRecord viewInfoStore$InfoRecordRemoveAt = this.mLayoutHolderDictionary.removeAt(size);
            if ((viewInfoStore$InfoRecordRemoveAt.flags & 3) == 3) {
                viewInfoStore$ProcessCallback.unused(recyclerobject$objectHolderKeyAt);
            } else if ((viewInfoStore$InfoRecordRemoveAt.flags & 1) == 0) {
                if ((viewInfoStore$InfoRecordRemoveAt.flags & 14) == 14) {
                    viewInfoStore$ProcessCallback.processAppeared(recyclerobject$objectHolderKeyAt, viewInfoStore$InfoRecordRemoveAt.preInfo, viewInfoStore$InfoRecordRemoveAt.postInfo);
                } else if ((viewInfoStore$InfoRecordRemoveAt.flags & 12) == 12) {
                    viewInfoStore$ProcessCallback.processPersistent(recyclerobject$objectHolderKeyAt, viewInfoStore$InfoRecordRemoveAt.preInfo, viewInfoStore$InfoRecordRemoveAt.postInfo);
                } else if ((viewInfoStore$InfoRecordRemoveAt.flags & 4) != 0) {
                    viewInfoStore$ProcessCallback.processDisappeared(recyclerobject$objectHolderKeyAt, viewInfoStore$InfoRecordRemoveAt.preInfo, null);
                } else if ((viewInfoStore$InfoRecordRemoveAt.flags & 8) == 0) {
                    int i = viewInfoStore$InfoRecordRemoveAt.flags;
                } else {
                    viewInfoStore$ProcessCallback.processAppeared(recyclerobject$objectHolderKeyAt, viewInfoStore$InfoRecordRemoveAt.preInfo, viewInfoStore$InfoRecordRemoveAt.postInfo);
                }
            } else if (viewInfoStore$InfoRecordRemoveAt.preInfo is not null) {
                viewInfoStore$ProcessCallback.processDisappeared(recyclerobject$objectHolderKeyAt, viewInfoStore$InfoRecordRemoveAt.preInfo, viewInfoStore$InfoRecordRemoveAt.postInfo);
            } else {
                viewInfoStore$ProcessCallback.unused(recyclerobject$objectHolderKeyAt);
            }
            androidx.recyclerview.widget.objectInfoStore$InfoRecord.recycle(viewInfoStore$InfoRecordRemoveAt);
        }
    }

    void removeFromDisappearedInLayout(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        androidx.recyclerview.widget.objectInfoStore$InfoRecord viewInfoStore$InfoRecord = this.mLayoutHolderDictionary[recyclerobject$objectHolder);
        if (viewInfoStore$InfoRecord is not null) {
            viewInfoStore$InfoRecord.flags &= -2;
        }
    }

    void removeobjectHolder(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        if ((24 + 28) % 28 > 0) {
        }
        for (int size = this.mOldChangedHolders.Count - 1; size >= 0; size--) {
            if (recyclerobject$objectHolder == this.mOldChangedHolders.valueAt(size)) {
                this.mOldChangedHolders.removeAt(size);
                break;
            }
        }
        androidx.recyclerview.widget.objectInfoStore$InfoRecord viewInfoStore$InfoRecordRemove = this.mLayoutHolderDictionary.Remove(recyclerobject$objectHolder);
        if (viewInfoStore$InfoRecordRemove is null) {
            return;
        }
        androidx.recyclerview.widget.objectInfoStore$InfoRecord.recycle(viewInfoStore$InfoRecordRemove);
    }
}

