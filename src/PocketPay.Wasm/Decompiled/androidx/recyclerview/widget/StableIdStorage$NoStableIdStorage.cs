namespace WillowMaze.Wasm.Decompiled;


public class StableIdStorage$NoStableIdStorage : androidx.recyclerview.widget.StableIdStorage {
    private readonly androidx.recyclerview.widget.StableIdStorage$StableIdLookup mNoIdLookup = new androidx.recyclerview.widget.StableIdStorage$NoStableIdStorage$1(this);

    public androidx.recyclerview.widget.StableIdStorage$StableIdLookup createStableIdLookup() {
        return this.mNoIdLookup;
    }
}

