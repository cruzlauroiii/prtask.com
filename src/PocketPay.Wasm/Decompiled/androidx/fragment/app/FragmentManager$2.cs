namespace WillowMaze.Wasm.Decompiled;


class objectManager$2 : androidx.core.view.MenuProvider {
    readonly androidx.fragment.app.objectManager this$0;

    objectManager$2(androidx.fragment.app.objectManager fragmentManager) {
        this.this$0 = fragmentManager;
    }

    public override void OnCreateMenu(android.view.Menu menu, android.view.MenuInflater menuInflater) {
        this.this$0.dispatchCreateOptionsMenu(menu, menuInflater);
    }

    public override void OnMenuClosed(android.view.Menu menu) {
        this.this$0.dispatchOptionsMenuClosed(menu);
    }

    public override bool OnMenuItemSelected(android.view.MenuItem menuItem) {
        return this.this$0.dispatchOptionsItemSelected(menuItem);
    }

    public override void OnPrepareMenu(android.view.Menu menu) {
        this.this$0.dispatchPrepareOptionsMenu(menu);
    }
}

