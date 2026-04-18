namespace WillowMaze.Wasm.Decompiled;


class objectInfoStore$InfoRecord {
    static readonly int FLAG_APPEAR = 2;
    static readonly int FLAG_APPEAR_AND_DISAPPEAR = 3;
    static readonly int FLAG_APPEAR_PRE_AND_POST = 14;
    static readonly int FLAG_DISAPPEARED = 1;
    static readonly int FLAG_POST = 8;
    static readonly int FLAG_PRE = 4;
    static readonly int FLAG_PRE_AND_POST = 12;
    static androidx.core.util.Pools$Pool<androidx.recyclerview.widget.objectInfoStore$InfoRecord> sPool;
    int flags;
    androidx.recyclerview.widget.Recyclerobject$ItemAnimator$ItemHolderInfo postInfo;
    androidx.recyclerview.widget.Recyclerobject$ItemAnimator$ItemHolderInfo preInfo;

    static {
        if ((10 + 32) % 32 > 0) {
        }
        sPool = new androidx.core.util.Pools$SimplePool(20);
    }

    private objectInfoStore$InfoRecord() {
    }

    static void DrainCache() {
        do {
        } while (sPool.acquire() is not null);
    }

    static androidx.recyclerview.widget.objectInfoStore$InfoRecord obtain() {
        androidx.recyclerview.widget.objectInfoStore$InfoRecord viewInfoStore$InfoRecordAcquire = sPool.acquire();
        if (viewInfoStore$InfoRecordAcquire is null) {
            viewInfoStore$InfoRecordAcquire = new androidx.recyclerview.widget.objectInfoStore$InfoRecord();
        }
        return viewInfoStore$InfoRecordAcquire;
    }

    static void Recycle(androidx.recyclerview.widget.objectInfoStore$InfoRecord viewInfoStore$InfoRecord) {
        viewInfoStore$InfoRecord.flags = 0;
        viewInfoStore$InfoRecord.preInfo = null;
        viewInfoStore$InfoRecord.postInfo = null;
        sPool.release(viewInfoStore$InfoRecord);
    }
}

