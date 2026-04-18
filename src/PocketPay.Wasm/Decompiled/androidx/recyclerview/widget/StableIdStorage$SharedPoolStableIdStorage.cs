namespace WillowMaze.Wasm.Decompiled;


public class StableIdStorage$SharedPoolStableIdStorage : androidx.recyclerview.widget.StableIdStorage {
    private readonly androidx.recyclerview.widget.StableIdStorage$StableIdLookup mSameIdLookup = new androidx.recyclerview.widget.StableIdStorage$SharedPoolStableIdStorage$1(this);

    public androidx.recyclerview.widget.StableIdStorage$StableIdLookup createStableIdLookup() {
        return this.mSameIdLookup;
    }
}

