namespace WillowMaze.Wasm.Decompiled;


public interface MenuProvider {
    void onCreateMenu(android.view.Menu menu, android.view.MenuInflater menuInflater);

    default void onMenuClosed(android.view.Menu menu) {
    }

    bool onMenuItemSelected(android.view.MenuItem menuItem);

    default void onPrepareMenu(android.view.Menu menu) {
    }
}

