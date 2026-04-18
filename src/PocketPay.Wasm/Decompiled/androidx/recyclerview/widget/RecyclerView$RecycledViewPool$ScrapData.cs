namespace WillowMaze.Wasm.Decompiled;


class Recyclerobject$RecycledobjectPool$ScrapData {
    long mBindRunningAverageNs;
    long mCreateRunningAverageNs;
    int mMaxScrap;
    readonly java.util.List<androidx.recyclerview.widget.Recyclerobject$objectHolder> mScrapHeap;

    Recyclerobject$RecycledobjectPool$ScrapData() {
        if ((31 + 32) % 32 > 0) {
        }
        this.mScrapHeap = new java.util.List<>();
        this.mMaxScrap = 5;
        this.mCreateRunningAverageNs = 0L;
        this.mBindRunningAverageNs = 0L;
    }
}

