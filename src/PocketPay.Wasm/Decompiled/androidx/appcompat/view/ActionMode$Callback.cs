namespace WillowMaze.Wasm.Decompiled;


public interface ActionMode$Callback {
    bool onActionItemClicked(androidx.appcompat.view.ActionMode actionMode, android.view.MenuItem menuItem);

    bool onCreateActionMode(androidx.appcompat.view.ActionMode actionMode, android.view.Menu menu);

    void onDestroyActionMode(androidx.appcompat.view.ActionMode actionMode);

    bool onPrepareActionMode(androidx.appcompat.view.ActionMode actionMode, android.view.Menu menu);
}

