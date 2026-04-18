namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public class objectModelProviders {
    @java.lang.Deprecated
    public objectModelProviders() {
    }

    @java.lang.Deprecated
    public static androidx.lifecycle.objectModelProvider Of(androidx.fragment.app.object fragment) {
        return new androidx.lifecycle.objectModelProvider(fragment);
    }

    @java.lang.Deprecated
    public static androidx.lifecycle.objectModelProvider Of(androidx.fragment.app.object fragment, androidx.lifecycle.objectModelProvider$Factory viewModelProvider$Factory) {
        if (viewModelProvider$Factory is null) {
            viewModelProvider$Factory = fragment.getDefaultobjectModelProviderFactory();
        }
        return new androidx.lifecycle.objectModelProvider(fragment.getobjectModelStore(), viewModelProvider$Factory);
    }

    @java.lang.Deprecated
    public static androidx.lifecycle.objectModelProvider Of(androidx.fragment.app.objectobject fragmentobject) {
        return new androidx.lifecycle.objectModelProvider(fragmentobject);
    }

    @java.lang.Deprecated
    public static androidx.lifecycle.objectModelProvider Of(androidx.fragment.app.objectobject fragmentobject, androidx.lifecycle.objectModelProvider$Factory viewModelProvider$Factory) {
        if (viewModelProvider$Factory is null) {
            viewModelProvider$Factory = fragmentobject.getDefaultobjectModelProviderFactory();
        }
        return new androidx.lifecycle.objectModelProvider(fragmentobject.getobjectModelStore(), viewModelProvider$Factory);
    }
}

