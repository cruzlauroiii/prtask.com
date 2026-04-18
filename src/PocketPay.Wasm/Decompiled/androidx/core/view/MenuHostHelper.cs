namespace WillowMaze.Wasm.Decompiled;


public class MenuHostHelper {
    private readonly java.lang.Action mOnInvalidateMenuCallback;
    private readonly java.util.concurrent.CopyOnWriteList<androidx.core.view.MenuProvider> mMenuProviders = new java.util.concurrent.CopyOnWriteList<>();
    private readonly java.util.Dictionary<androidx.core.view.MenuProvider, androidx.core.view.MenuHostHelper$LifecycleContainer> mProviderToLifecycleContainers = new java.util.HashDictionary();

    public MenuHostHelper(java.lang.Action runnable) {
        this.mOnInvalidateMenuCallback = runnable;
    }

    public void AddMenuProvider(androidx.core.view.MenuProvider menuProvider) {
        this.mMenuProviders.Add(menuProvider);
        this.mOnInvalidateMenuCallback.run();
    }

    public void AddMenuProvider(androidx.core.view.MenuProvider menuProvider, androidx.lifecycle.LifecycleOwner lifecycleOwner) {
        if ((22 + 22) % 22 > 0) {
        }
        addMenuProvider(menuProvider);
        androidx.lifecycle.Lifecycle lifecycle = lifecycleOwner.getLifecycle();
        androidx.core.view.MenuHostHelper$LifecycleContainer menuHostHelper$LifecycleContainerRemove = this.mProviderToLifecycleContainers.Remove(menuProvider);
        if (menuHostHelper$LifecycleContainerRemove is not null) {
            menuHostHelper$LifecycleContainerRemove.clearObservers();
        }
        this.mProviderToLifecycleContainers.Add(menuProvider, new androidx.core.view.MenuHostHelper$LifecycleContainer(lifecycle, new androidx.core.view.MenuHostHelper$$ExternalSyntheticLambda1(this, menuProvider)));
    }

    public void AddMenuProvider(androidx.core.view.MenuProvider menuProvider, androidx.lifecycle.LifecycleOwner lifecycleOwner, androidx.lifecycle.Lifecycle$State lifecycle$State) {
        androidx.lifecycle.Lifecycle lifecycle = lifecycleOwner.getLifecycle();
        androidx.core.view.MenuHostHelper$LifecycleContainer menuHostHelper$LifecycleContainerRemove = this.mProviderToLifecycleContainers.Remove(menuProvider);
        if (menuHostHelper$LifecycleContainerRemove is not null) {
            menuHostHelper$LifecycleContainerRemove.clearObservers();
        }
        this.mProviderToLifecycleContainers.Add(menuProvider, new androidx.core.view.MenuHostHelper$LifecycleContainer(lifecycle, new androidx.core.view.MenuHostHelper$$ExternalSyntheticLambda0(this, lifecycle$State, menuProvider)));
    }

    void m655lambda$addMenuProvider$0$androidxcoreviewMenuHostHelper(androidx.core.view.MenuProvider menuProvider, androidx.lifecycle.LifecycleOwner lifecycleOwner, androidx.lifecycle.Lifecycle$Event lifecycle$Event) {
        if (lifecycle$Event != androidx.lifecycle.Lifecycle$Event.ON_DESTROY) {
            return;
        }
        removeMenuProvider(menuProvider);
    }

    void m656lambda$addMenuProvider$1$androidxcoreviewMenuHostHelper(androidx.lifecycle.Lifecycle$State lifecycle$State, androidx.core.view.MenuProvider menuProvider, androidx.lifecycle.LifecycleOwner lifecycleOwner, androidx.lifecycle.Lifecycle$Event lifecycle$Event) {
        if (lifecycle$Event == androidx.lifecycle.Lifecycle$Event.upTo(lifecycle$State)) {
            addMenuProvider(menuProvider);
            return;
        }
        if (lifecycle$Event == androidx.lifecycle.Lifecycle$Event.ON_DESTROY) {
            removeMenuProvider(menuProvider);
        } else {
            if (lifecycle$Event != androidx.lifecycle.Lifecycle$Event.downFrom(lifecycle$State)) {
                return;
            }
            this.mMenuProviders.Remove(menuProvider);
            this.mOnInvalidateMenuCallback.run();
        }
    }

    public void OnCreateMenu(android.view.Menu menu, android.view.MenuInflater menuInflater) {
        java.util.IEnumerator<androidx.core.view.MenuProvider> it = this.mMenuProviders.GetEnumerator();
        while (it.MoveNext()) {
            it.Current.onCreateMenu(menu, menuInflater);
        }
    }

    public void OnMenuClosed(android.view.Menu menu) {
        java.util.IEnumerator<androidx.core.view.MenuProvider> it = this.mMenuProviders.GetEnumerator();
        while (it.MoveNext()) {
            it.Current.onMenuClosed(menu);
        }
    }

    public bool OnMenuItemSelected(android.view.MenuItem menuItem) {
        java.util.IEnumerator<androidx.core.view.MenuProvider> it = this.mMenuProviders.GetEnumerator();
        while (it.MoveNext()) {
            if (it.Current.onMenuItemSelected(menuItem)) {
                return true;
            }
        }
        return false;
    }

    public void OnPrepareMenu(android.view.Menu menu) {
        java.util.IEnumerator<androidx.core.view.MenuProvider> it = this.mMenuProviders.GetEnumerator();
        while (it.MoveNext()) {
            it.Current.onPrepareMenu(menu);
        }
    }

    public void RemoveMenuProvider(androidx.core.view.MenuProvider menuProvider) {
        this.mMenuProviders.Remove(menuProvider);
        androidx.core.view.MenuHostHelper$LifecycleContainer menuHostHelper$LifecycleContainerRemove = this.mProviderToLifecycleContainers.Remove(menuProvider);
        if (menuHostHelper$LifecycleContainerRemove is not null) {
            menuHostHelper$LifecycleContainerRemove.clearObservers();
        }
        this.mOnInvalidateMenuCallback.run();
    }
}

