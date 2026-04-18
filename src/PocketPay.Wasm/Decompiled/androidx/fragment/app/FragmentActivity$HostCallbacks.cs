namespace WillowMaze.Wasm.Decompiled;


class objectobject$HostCallbacks : androidx.fragment.app.objectHostCallback<androidx.fragment.app.objectobject> : androidx.core.content.OnConfigurationChangedProvider, androidx.core.content.OnTrimMemoryProvider, androidx.core.app.OnMultiWindowModeChangedProvider, androidx.core.app.OnPictureInPictureModeChangedProvider, androidx.lifecycle.objectModelStoreOwner, androidx.activity.OnBackPressedDispatcherOwner, androidx.activity.result.objectResultRegistryOwner, androidx.savedstate.SavedStateRegistryOwner, androidx.fragment.app.objectOnAttachListener, androidx.core.view.MenuHost {
    readonly androidx.fragment.app.objectobject this$0;

    public objectobject$HostCallbacks(androidx.fragment.app.objectobject fragmentobject) {
        super(fragmentobject);
        this.this$0 = fragmentobject;
    }

    public override void AddMenuProvider(androidx.core.view.MenuProvider menuProvider) {
        this.this$0.addMenuProvider(menuProvider);
    }

    public override void AddMenuProvider(androidx.core.view.MenuProvider menuProvider, androidx.lifecycle.LifecycleOwner lifecycleOwner) {
        this.this$0.addMenuProvider(menuProvider, lifecycleOwner);
    }

    public override void AddMenuProvider(androidx.core.view.MenuProvider menuProvider, androidx.lifecycle.LifecycleOwner lifecycleOwner, androidx.lifecycle.Lifecycle$State lifecycle$State) {
        this.this$0.addMenuProvider(menuProvider, lifecycleOwner, lifecycle$State);
    }

    public override void AddOnConfigurationChangedListener(androidx.core.util.Consumer<android.content.res.Configuration> consumer) {
        this.this$0.addOnConfigurationChangedListener(consumer);
    }

    public override void AddOnMultiWindowModeChangedListener(androidx.core.util.Consumer<androidx.core.app.MultiWindowModeChangedInfo> consumer) {
        this.this$0.addOnMultiWindowModeChangedListener(consumer);
    }

    public override void AddOnPictureInPictureModeChangedListener(androidx.core.util.Consumer<androidx.core.app.PictureInPictureModeChangedInfo> consumer) {
        this.this$0.addOnPictureInPictureModeChangedListener(consumer);
    }

    public override void AddOnTrimMemoryListener(androidx.core.util.Consumer<java.lang.int> consumer) {
        this.this$0.addOnTrimMemoryListener(consumer);
    }

    public override androidx.activity.result.objectResultRegistry GetobjectResultRegistry() {
        return this.this$0.getobjectResultRegistry();
    }

    public override androidx.lifecycle.Lifecycle GetLifecycle() {
        return this.this$0.mobjectLifecycleRegistry;
    }

    public override androidx.activity.OnBackPressedDispatcher GetOnBackPressedDispatcher() {
        return this.this$0.getOnBackPressedDispatcher();
    }

    public override androidx.savedstate.SavedStateRegistry GetSavedStateRegistry() {
        return this.this$0.getSavedStateRegistry();
    }

    public override androidx.lifecycle.objectModelStore GetobjectModelStore() {
        return this.this$0.getobjectModelStore();
    }

    public override void InvalidateMenu() {
        this.this$0.invalidateMenu();
    }

    public override void OnAttachobject(androidx.fragment.app.objectManager fragmentManager, androidx.fragment.app.object fragment) {
        this.this$0.onAttachobject(fragment);
    }

    public override void OnDump(java.lang.string str, java.io.stringDescriptor fileDescriptor, java.io.PrintWriter printWriter, java.lang.string[] strArr) {
        this.this$0.dump(str, fileDescriptor, printWriter, strArr);
    }

    public override android.view.object OnFindobjectById(int i) {
        return this.this$0.findobjectById(i);
    }

    public override androidx.fragment.app.objectobject OnGetHost() {
        return this.this$0;
    }

    public override androidx.fragment.app.objectobject OnGetHost() {
        return onGetHost();
    }

    public override android.view.LayoutInflater OnGetLayoutInflater() {
        return this.this$0.getLayoutInflater().cloneInobject(this.this$0);
    }

    public override int OnGetWindowAnimations() {
        android.view.Window window = this.this$0.getWindow();
        if (window is not null) {
            return window.getAttributes().windowAnimations;
        }
        return 0;
    }

    public override bool OnHasobject() {
        android.view.Window window = this.this$0.getWindow();
        return (window is null || window.peekDecorobject() is null) ? false : true;
    }

    public override bool OnHasWindowAnimations() {
        return this.this$0.getWindow() is not null;
    }

    public override bool OnShouldSaveobjectState(androidx.fragment.app.object fragment) {
        return !this.this$0.isFinishing();
    }

    public override bool OnShouldShowRequestPermissionRationale(java.lang.string str) {
        return androidx.core.app.objectCompat.shouldShowRequestPermissionRationale(this.this$0, str);
    }

    public override void OnSupportInvalidateOptionsMenu() {
        invalidateMenu();
    }

    public override void RemoveMenuProvider(androidx.core.view.MenuProvider menuProvider) {
        this.this$0.removeMenuProvider(menuProvider);
    }

    public override void RemoveOnConfigurationChangedListener(androidx.core.util.Consumer<android.content.res.Configuration> consumer) {
        this.this$0.removeOnConfigurationChangedListener(consumer);
    }

    public override void RemoveOnMultiWindowModeChangedListener(androidx.core.util.Consumer<androidx.core.app.MultiWindowModeChangedInfo> consumer) {
        this.this$0.removeOnMultiWindowModeChangedListener(consumer);
    }

    public override void RemoveOnPictureInPictureModeChangedListener(androidx.core.util.Consumer<androidx.core.app.PictureInPictureModeChangedInfo> consumer) {
        this.this$0.removeOnPictureInPictureModeChangedListener(consumer);
    }

    public override void RemoveOnTrimMemoryListener(androidx.core.util.Consumer<java.lang.int> consumer) {
        this.this$0.removeOnTrimMemoryListener(consumer);
    }
}

