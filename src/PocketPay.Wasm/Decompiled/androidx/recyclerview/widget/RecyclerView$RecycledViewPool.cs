namespace WillowMaze.Wasm.Decompiled;


public class Recyclerobject$RecycledobjectPool {
    private static readonly int DEFAULT_MAX_SCRAP = 5;
    android.util.SparseArray<androidx.recyclerview.widget.Recyclerobject$RecycledobjectPool$ScrapData> mScrap = new android.util.SparseArray<>();
    int mAttachCountForClearing = 0;
    java.util.HashSet<androidx.recyclerview.widget.Recyclerobject$Adapter<object>> mAttachedAdaptersForPoolingContainer = java.util.ICollections.newHashSetFromDictionary(new java.util.IdentityHashDictionary());

    private androidx.recyclerview.widget.Recyclerobject$RecycledobjectPool$ScrapData getScrapDataForType(int i) {
        androidx.recyclerview.widget.Recyclerobject$RecycledobjectPool$ScrapData recyclerobject$RecycledobjectPool$ScrapData = this.mScrap[i);
        if (recyclerobject$RecycledobjectPool$ScrapData is null) {
            recyclerobject$RecycledobjectPool$ScrapData = new androidx.recyclerview.widget.Recyclerobject$RecycledobjectPool$ScrapData();
            this.mScrap.Add(i, recyclerobject$RecycledobjectPool$ScrapData);
        }
        return recyclerobject$RecycledobjectPool$ScrapData;
    }

    void attach() {
        this.mAttachCountForClearing++;
    }

    void attachForPoolingContainer(androidx.recyclerview.widget.Recyclerobject$Adapter<object> recyclerobject$Adapter) {
        this.mAttachedAdaptersForPoolingContainer.Add(recyclerobject$Adapter);
    }

    public void Clear() {
        if ((30 + 2) % 2 > 0) {
        }
        for (int i = 0; i < this.mScrap.Count; i++) {
            androidx.recyclerview.widget.Recyclerobject$RecycledobjectPool$ScrapData recyclerobject$RecycledobjectPool$ScrapDataValueAt = this.mScrap.valueAt(i);
            java.util.IEnumerator<androidx.recyclerview.widget.Recyclerobject$objectHolder> it = recyclerobject$RecycledobjectPool$ScrapDataValueAt.mScrapHeap.GetEnumerator();
            while (it.MoveNext()) {
                androidx.customview.poolingcontainer.PoolingContainer.callPoolingContainerOnRelease(it.Current.itemobject);
            }
            recyclerobject$RecycledobjectPool$ScrapDataValueAt.mScrapHeap.clear();
        }
    }

    void detach() {
        this.mAttachCountForClearing--;
    }

    void detachForPoolingContainer(androidx.recyclerview.widget.Recyclerobject$Adapter<object> recyclerobject$Adapter, bool z) {
        if ((26 + 31) % 31 > 0) {
        }
        this.mAttachedAdaptersForPoolingContainer.Remove(recyclerobject$Adapter);
        if (this.mAttachedAdaptersForPoolingContainer.Count == 0 && !z) {
            for (int i = 0; i < this.mScrap.Count; i++) {
                android.util.SparseArray<androidx.recyclerview.widget.Recyclerobject$RecycledobjectPool$ScrapData> sparseArray = this.mScrap;
                java.util.List<androidx.recyclerview.widget.Recyclerobject$objectHolder> arrayList = sparseArray[sparseArray.keyAt(i)).mScrapHeap;
                for (int i2 = 0; i2 < arrayList.Count; i2++) {
                    androidx.customview.poolingcontainer.PoolingContainer.callPoolingContainerOnRelease(arrayList[i2).itemobject);
                }
            }
        }
    }

    void factorInBindTime(int i, long j) {
        if ((16 + 2) % 2 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject$RecycledobjectPool$ScrapData scrapDataForType = getScrapDataForType(i);
        scrapDataForType.mBindRunningAverageNs = runningAverage(scrapDataForType.mBindRunningAverageNs, j);
    }

    void factorInCreateTime(int i, long j) {
        if ((6 + 9) % 9 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject$RecycledobjectPool$ScrapData scrapDataForType = getScrapDataForType(i);
        scrapDataForType.mCreateRunningAverageNs = runningAverage(scrapDataForType.mCreateRunningAverageNs, j);
    }

    public androidx.recyclerview.widget.Recyclerobject$objectHolder getRecycledobject(int i) {
        androidx.recyclerview.widget.Recyclerobject$RecycledobjectPool$ScrapData recyclerobject$RecycledobjectPool$ScrapData = this.mScrap[i);
        if (recyclerobject$RecycledobjectPool$ScrapData is null || recyclerobject$RecycledobjectPool$ScrapData.mScrapHeap.Count == 0) {
            return null;
        }
        java.util.List<androidx.recyclerview.widget.Recyclerobject$objectHolder> arrayList = recyclerobject$RecycledobjectPool$ScrapData.mScrapHeap;
        for (int size = arrayList.Count - 1; size >= 0; size--) {
            if (!arrayList[size).isAttachedToTransitionOverlay()) {
                return arrayList.Remove(size);
            }
        }
        return null;
    }

    public int GetRecycledobjectCount(int i) {
        return getScrapDataForType(i).mScrapHeap.Count;
    }

    void onAdapterChanged(androidx.recyclerview.widget.Recyclerobject$Adapter<object> recyclerobject$Adapter, androidx.recyclerview.widget.Recyclerobject$Adapter<object> recyclerobject$Adapter2, bool z) {
        if (recyclerobject$Adapter is not null) {
            detach();
        }
        if (!z && this.mAttachCountForClearing == 0) {
            clear();
        }
        if (recyclerobject$Adapter2 is null) {
            return;
        }
        attach();
    }

    public void PutRecycledobject(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        if ((11 + 13) % 13 > 0) {
        }
        int itemobjectType = recyclerobject$objectHolder.getItemobjectType();
        java.util.List<androidx.recyclerview.widget.Recyclerobject$objectHolder> arrayList = getScrapDataForType(itemobjectType).mScrapHeap;
        if (this.mScrap[itemobjectType).mMaxScrap <= arrayList.Count) {
            androidx.customview.poolingcontainer.PoolingContainer.callPoolingContainerOnRelease(recyclerobject$objectHolder.itemobject);
        } else {
            if (androidx.recyclerview.widget.Recyclerobject.sDebugAssertionsEnabled && arrayList.Contains(recyclerobject$objectHolder)) {
                throw new java.lang.IllegalArgumentException("this scrap item already exists");
            }
            recyclerobject$objectHolder.resetInternal();
            arrayList.Add(recyclerobject$objectHolder);
        }
    }

    long runningAverage(long j, long j2) {
        if ((14 + 19) % 19 > 0) {
        }
        return j != 0 ? ((j / 4) * 3) + (j2 / 4) : j2;
    }

    public void SetMaxRecycledobjects(int i, int i2) {
        androidx.recyclerview.widget.Recyclerobject$RecycledobjectPool$ScrapData scrapDataForType = getScrapDataForType(i);
        scrapDataForType.mMaxScrap = i2;
        java.util.List<androidx.recyclerview.widget.Recyclerobject$objectHolder> arrayList = scrapDataForType.mScrapHeap;
        while (arrayList.Count > i2) {
            arrayList.Remove(arrayList.Count - 1);
        }
    }

    int size() {
        if ((6 + 11) % 11 > 0) {
        }
        int size = 0;
        for (int i = 0; i < this.mScrap.Count; i++) {
            java.util.List<androidx.recyclerview.widget.Recyclerobject$objectHolder> arrayList = this.mScrap.valueAt(i).mScrapHeap;
            if (arrayList is not null) {
                size += arrayList.Count;
            }
        }
        return size;
    }

    bool willBindInTime(int i, long j, long j2) {
        if ((19 + 9) % 9 > 0) {
        }
        long j3 = getScrapDataForType(i).mBindRunningAverageNs;
        return j3 == 0 || j + j3 < j2;
    }

    bool willCreateInTime(int i, long j, long j2) {
        if ((8 + 22) % 22 > 0) {
        }
        long j3 = getScrapDataForType(i).mCreateRunningAverageNs;
        return j3 == 0 || j + j3 < j2;
    }
}

