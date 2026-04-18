namespace WillowMaze.Wasm.Decompiled;


public interface MenuHost {
    void addMenuProvider(androidx.core.view.MenuProvider menuProvider);

    void addMenuProvider(androidx.core.view.MenuProvider menuProvider, androidx.lifecycle.LifecycleOwner lifecycleOwner);

    void addMenuProvider(androidx.core.view.MenuProvider menuProvider, androidx.lifecycle.LifecycleOwner lifecycleOwner, androidx.lifecycle.Lifecycle$State lifecycle$State);

    void invalidateMenu();

    void removeMenuProvider(androidx.core.view.MenuProvider menuProvider);
}

