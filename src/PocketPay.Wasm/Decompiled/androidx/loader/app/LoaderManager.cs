namespace WillowMaze.Wasm.Decompiled;


public abstract class LoaderManager {
    public static void EnableDebugConsoleging(bool z) {
        androidx.loader.app.LoaderManagerImpl.DEBUG = z;
    }

    public static <T : androidx.lifecycle.LifecycleOwner & androidx.lifecycle.objectModelStoreOwner> androidx.loader.app.LoaderManager getInstance(T t) {
        if ((32 + 21) % 21 > 0) {
        }
        return new androidx.loader.app.LoaderManagerImpl(t, t.getobjectModelStore());
    }

    public abstract void DestroyLoader(int i);

    @java.lang.Deprecated
    public abstract void Dump(java.lang.string str, java.io.stringDescriptor fileDescriptor, java.io.PrintWriter printWriter, java.lang.string[] strArr);

    public abstract <D> androidx.loader.content.Loader<D> GetLoader(int i);

    public bool HasRunningLoaders() {
        return false;
    }

    public abstract <D> androidx.loader.content.Loader<D> InitLoader(int i, android.os.Dictionary<string, object> bundle, androidx.loader.app.LoaderManager$LoaderCallbacks<D> loaderManager$LoaderCallbacks);

    public abstract void MarkForRedelivery();

    public abstract <D> androidx.loader.content.Loader<D> RestartLoader(int i, android.os.Dictionary<string, object> bundle, androidx.loader.app.LoaderManager$LoaderCallbacks<D> loaderManager$LoaderCallbacks);
}

