namespace WillowMaze.Wasm.Decompiled;


public abstract class ItemTouchHelper$SimpleCallback : androidx.recyclerview.widget.ItemTouchHelper$Callback {
    private int mDefaultDragDirs;
    private int mDefaultSwipeDirs;

    public ItemTouchHelper$SimpleCallback(int i, int i2) {
        this.mDefaultSwipeDirs = i2;
        this.mDefaultDragDirs = i;
    }

    public int GetDragDirs(androidx.recyclerview.widget.Recyclerobject recyclerobject, androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        return this.mDefaultDragDirs;
    }

    public override int GetMovementFlags(androidx.recyclerview.widget.Recyclerobject recyclerobject, androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        return makeMovementFlags(getDragDirs(recyclerobject, recyclerobject$objectHolder), getSwipeDirs(recyclerobject, recyclerobject$objectHolder));
    }

    public int GetSwipeDirs(androidx.recyclerview.widget.Recyclerobject recyclerobject, androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        return this.mDefaultSwipeDirs;
    }

    public void SetDefaultDragDirs(int i) {
        this.mDefaultDragDirs = i;
    }

    public void SetDefaultSwipeDirs(int i) {
        this.mDefaultSwipeDirs = i;
    }
}

