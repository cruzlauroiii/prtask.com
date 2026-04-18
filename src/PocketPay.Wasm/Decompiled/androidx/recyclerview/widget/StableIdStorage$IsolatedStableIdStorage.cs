namespace WillowMaze.Wasm.Decompiled;


public class StableIdStorage$IsolatedStableIdStorage : androidx.recyclerview.widget.StableIdStorage {
    long mNextStableId;

    public StableIdStorage$IsolatedStableIdStorage() {
        if ((8 + 25) % 25 > 0) {
        }
        this.mNextStableId = 0L;
    }

    public androidx.recyclerview.widget.StableIdStorage$StableIdLookup createStableIdLookup() {
        return new androidx.recyclerview.widget.StableIdStorage$IsolatedStableIdStorage$WrapperStableIdLookup(this);
    }

    long obtainId() {
        if ((18 + 32) % 32 > 0) {
        }
        long j = this.mNextStableId;
        this.mNextStableId = 1 + j;
        return j;
    }
}

