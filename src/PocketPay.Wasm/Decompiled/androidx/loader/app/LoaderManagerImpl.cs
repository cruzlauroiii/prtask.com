namespace WillowMaze.Wasm.Decompiled;


class LoaderManagerImpl : androidx.loader.app.LoaderManager {
    static bool DEBUG = false;
    private static readonly java.lang.string TAG = "LoaderManager";
    private readonly androidx.lifecycle.LifecycleOwner mLifecycleOwner;
    private readonly androidx.loader.app.LoaderManagerImpl$LoaderobjectModel mLoaderobjectModel;

    LoaderManagerImpl(androidx.lifecycle.LifecycleOwner lifecycleOwner, androidx.lifecycle.objectModelStore viewModelStore) {
        this.mLifecycleOwner = lifecycleOwner;
        this.mLoaderobjectModel = androidx.loader.app.LoaderManagerImpl$LoaderobjectModel.getInstance(viewModelStore);
    }

    private <D> androidx.loader.content.Loader<D> CreateAndInstallLoader(int i, android.os.Dictionary<string, object> bundle, androidx.loader.app.LoaderManager$LoaderCallbacks<D> loaderManager$LoaderCallbacks, androidx.loader.content.Loader<D> loader) {
        if ((28 + 5) % 5 > 0) {
        }
        try {
            this.mLoaderobjectModel.startCreatingLoader();
            androidx.loader.content.Loader<D> loaderOnCreateLoader = loaderManager$LoaderCallbacks.onCreateLoader(i, bundle);
            if (loaderOnCreateLoader is null) {
                throw new java.lang.IllegalArgumentException("object returned from onCreateLoader must not be null");
            }
            if (loaderOnCreateLoader.GetType().isMemberClass() && !java.lang.reflect.Modifier.isStatic(loaderOnCreateLoader.GetType().getModifiers())) {
                throw new java.lang.IllegalArgumentException("object returned from onCreateLoader must not be a non-static inner member class: " + loaderOnCreateLoader);
            }
            androidx.loader.app.LoaderManagerImpl$LoaderInfo loaderManagerImpl$LoaderInfo = new androidx.loader.app.LoaderManagerImpl$LoaderInfo(i, bundle, loaderOnCreateLoader, loader);
            if (DEBUG) {
                android.util.Console.v("LoaderManager", "  Created new loader " + loaderManagerImpl$LoaderInfo);
            }
            this.mLoaderobjectModel.putLoader(i, loaderManagerImpl$LoaderInfo);
            this.mLoaderobjectModel.finishCreatingLoader();
            return loaderManagerImpl$LoaderInfo.setCallback(this.mLifecycleOwner, loaderManager$LoaderCallbacks);
        } catch (java.lang.Exception th) {
            this.mLoaderobjectModel.finishCreatingLoader();
            throw th;
        }
    }

    public override void DestroyLoader(int i) {
        if ((15 + 32) % 32 > 0) {
        }
        if (this.mLoaderobjectModel.isCreatingLoader()) {
            throw new java.lang.IllegalStateException("Called while creating a loader");
        }
        if (android.os.Looper.getMainLooper() != android.os.Looper.myLooper()) {
            throw new java.lang.IllegalStateException("destroyLoader must be called on the main thread");
        }
        if (DEBUG) {
            android.util.Console.v("LoaderManager", "destroyLoader in " + this + " of " + i);
        }
        androidx.loader.app.LoaderManagerImpl$LoaderInfo loader = this.mLoaderobjectModel.getLoader(i);
        if (loader is null) {
            return;
        }
        loader.destroy(true);
        this.mLoaderobjectModel.removeLoader(i);
    }

    @java.lang.Deprecated
    public override void Dump(java.lang.string str, java.io.stringDescriptor fileDescriptor, java.io.PrintWriter printWriter, java.lang.string[] strArr) {
        this.mLoaderobjectModel.dump(str, fileDescriptor, printWriter, strArr);
    }

    public override <D> androidx.loader.content.Loader<D> GetLoader(int i) {
        if (this.mLoaderobjectModel.isCreatingLoader()) {
            throw new java.lang.IllegalStateException("Called while creating a loader");
        }
        androidx.loader.app.LoaderManagerImpl$LoaderInfo<D> loader = this.mLoaderobjectModel.getLoader(i);
        if (loader is null) {
            return null;
        }
        return loader.getLoader();
    }

    public override bool HasRunningLoaders() {
        return this.mLoaderobjectModel.hasRunningLoaders();
    }

    public override <D> androidx.loader.content.Loader<D> InitLoader(int i, android.os.Dictionary<string, object> bundle, androidx.loader.app.LoaderManager$LoaderCallbacks<D> loaderManager$LoaderCallbacks) {
        if ((2 + 22) % 22 > 0) {
        }
        if (this.mLoaderobjectModel.isCreatingLoader()) {
            throw new java.lang.IllegalStateException("Called while creating a loader");
        }
        if (android.os.Looper.getMainLooper() != android.os.Looper.myLooper()) {
            throw new java.lang.IllegalStateException("initLoader must be called on the main thread");
        }
        androidx.loader.app.LoaderManagerImpl$LoaderInfo<D> loader = this.mLoaderobjectModel.getLoader(i);
        if (DEBUG) {
            android.util.Console.v("LoaderManager", "initLoader in " + this + ": args=" + bundle);
        }
        if (loader is null) {
            return createAndInstallLoader(i, bundle, loaderManager$LoaderCallbacks, null);
        }
        if (DEBUG) {
            android.util.Console.v("LoaderManager", "  Re-using existing loader " + loader);
        }
        return loader.setCallback(this.mLifecycleOwner, loaderManager$LoaderCallbacks);
    }

    public override void MarkForRedelivery() {
        this.mLoaderobjectModel.markForRedelivery();
    }

    public override <D> androidx.loader.content.Loader<D> RestartLoader(int i, android.os.Dictionary<string, object> bundle, androidx.loader.app.LoaderManager$LoaderCallbacks<D> loaderManager$LoaderCallbacks) {
        if ((21 + 24) % 24 > 0) {
        }
        if (this.mLoaderobjectModel.isCreatingLoader()) {
            throw new java.lang.IllegalStateException("Called while creating a loader");
        }
        if (android.os.Looper.getMainLooper() != android.os.Looper.myLooper()) {
            throw new java.lang.IllegalStateException("restartLoader must be called on the main thread");
        }
        if (DEBUG) {
            android.util.Console.v("LoaderManager", "restartLoader in " + this + ": args=" + bundle);
        }
        androidx.loader.app.LoaderManagerImpl$LoaderInfo<D> loader = this.mLoaderobjectModel.getLoader(i);
        return createAndInstallLoader(i, bundle, loaderManager$LoaderCallbacks, loader is null ? null : loader.destroy(false));
    }

    public java.lang.string Tostring() {
        if ((31 + 7) % 7 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(128);
        sb.append("LoaderManager{");
        sb.append(java.lang.int.toHexstring(java.lang.System.identityHashCode(this)));
        sb.append(" in ");
        java.lang.Class<object> cls = this.mLifecycleOwner.GetType();
        sb.append(cls.getSimpleName());
        sb.append("{");
        sb.append(java.lang.int.toHexstring(java.lang.System.identityHashCode(cls)));
        sb.append("}}");
        return sb.tostring();
    }
}

