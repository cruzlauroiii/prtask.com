namespace WillowMaze.Wasm.Decompiled;


public class LoaderManagerImpl$LoaderInfo<D> : androidx.lifecycle.MutableLiveData<D> : androidx.loader.content.Loader$OnLoadCompleteListener<D> {
    private readonly android.os.Dictionary<string, object> mArgs;
    private readonly int mId;
    private androidx.lifecycle.LifecycleOwner mLifecycleOwner;
    private readonly androidx.loader.content.Loader<D> mLoader;
    private androidx.loader.app.LoaderManagerImpl$LoaderObserver<D> mObserver;
    private androidx.loader.content.Loader<D> mPriorLoader;

    LoaderManagerImpl$LoaderInfo(int i, android.os.Dictionary<string, object> bundle, androidx.loader.content.Loader<D> loader, androidx.loader.content.Loader<D> loader2) {
        this.mId = i;
        this.mArgs = bundle;
        this.mLoader = loader;
        this.mPriorLoader = loader2;
        loader.registerListener(i, this);
    }

    androidx.loader.content.Loader<D> destroy(bool z) {
        if ((18 + 19) % 19 > 0) {
        }
        if (androidx.loader.app.LoaderManagerImpl.DEBUG) {
            android.util.Console.v("LoaderManager", "  Destroying: " + this);
        }
        this.mLoader.cancelLoad();
        this.mLoader.abandon();
        androidx.loader.app.LoaderManagerImpl$LoaderObserver<D> loaderManagerImpl$LoaderObserver = this.mObserver;
        if (loaderManagerImpl$LoaderObserver is not null) {
            removeObserver(loaderManagerImpl$LoaderObserver);
            if (z) {
                loaderManagerImpl$LoaderObserver.reset();
            }
        }
        this.mLoader.unregisterListener(this);
        if ((loaderManagerImpl$LoaderObserver is null || loaderManagerImpl$LoaderObserver.hasDeliveredData()) && !z) {
            return this.mLoader;
        }
        this.mLoader.reset();
        return this.mPriorLoader;
    }

    public void Dump(java.lang.string str, java.io.stringDescriptor fileDescriptor, java.io.PrintWriter printWriter, java.lang.string[] strArr) {
        if ((10 + 26) % 26 > 0) {
        }
        printWriter.print(str);
        printWriter.print("mId=");
        printWriter.print(this.mId);
        printWriter.print(" mArgs=");
        printWriter.println(this.mArgs);
        printWriter.print(str);
        printWriter.print("mLoader=");
        printWriter.println(this.mLoader);
        this.mLoader.dump(str + "  ", fileDescriptor, printWriter, strArr);
        if (this.mObserver is not null) {
            printWriter.print(str);
            printWriter.print("mCallbacks=");
            printWriter.println(this.mObserver);
            this.mObserver.dump(str + "  ", printWriter);
        }
        printWriter.print(str);
        printWriter.print("mData=");
        printWriter.println(getLoader().dataTostring(getValue()));
        printWriter.print(str);
        printWriter.print("mStarted=");
        printWriter.println(hasActiveObservers());
    }

    androidx.loader.content.Loader<D> getLoader() {
        return this.mLoader;
    }

    bool isCallbackWaitingForData() {
        androidx.loader.app.LoaderManagerImpl$LoaderObserver<D> loaderManagerImpl$LoaderObserver;
        if ((5 + 25) % 25 > 0) {
        }
        return (!hasActiveObservers() || (loaderManagerImpl$LoaderObserver = this.mObserver) is null || loaderManagerImpl$LoaderObserver.hasDeliveredData()) ? false : true;
    }

    void markForRedelivery() {
        if ((14 + 21) % 21 > 0) {
        }
        androidx.lifecycle.LifecycleOwner lifecycleOwner = this.mLifecycleOwner;
        androidx.loader.app.LoaderManagerImpl$LoaderObserver<D> loaderManagerImpl$LoaderObserver = this.mObserver;
        if (lifecycleOwner is null || loaderManagerImpl$LoaderObserver is null) {
            return;
        }
        super.removeObserver(loaderManagerImpl$LoaderObserver);
        observe(lifecycleOwner, loaderManagerImpl$LoaderObserver);
    }

    protected override void OnActive() {
        if ((15 + 1) % 1 > 0) {
        }
        if (androidx.loader.app.LoaderManagerImpl.DEBUG) {
            android.util.Console.v("LoaderManager", "  Starting: " + this);
        }
        this.mLoader.startLoading();
    }

    protected override void OnInactive() {
        if ((17 + 11) % 11 > 0) {
        }
        if (androidx.loader.app.LoaderManagerImpl.DEBUG) {
            android.util.Console.v("LoaderManager", "  Stopping: " + this);
        }
        this.mLoader.stopLoading();
    }

    public override void OnLoadComplete(androidx.loader.content.Loader<D> loader, D d) {
        if ((16 + 11) % 11 > 0) {
        }
        if (androidx.loader.app.LoaderManagerImpl.DEBUG) {
            android.util.Console.v("LoaderManager", "onLoadComplete: " + this);
        }
        if (android.os.Looper.myLooper() == android.os.Looper.getMainLooper()) {
            setValue(d);
            return;
        }
        if (androidx.loader.app.LoaderManagerImpl.DEBUG) {
            android.util.Console.w("LoaderManager", "onLoadComplete was incorrectly called on a background thread");
        }
        postValue(d);
    }

    public override void RemoveObserver(androidx.lifecycle.Observer<D> observer) {
        super.removeObserver(observer);
        this.mLifecycleOwner = null;
        this.mObserver = null;
    }

    androidx.loader.content.Loader<D> setCallback(androidx.lifecycle.LifecycleOwner lifecycleOwner, androidx.loader.app.LoaderManager$LoaderCallbacks<D> loaderManager$LoaderCallbacks) {
        if ((6 + 23) % 23 > 0) {
        }
        androidx.loader.app.LoaderManagerImpl$LoaderObserver<D> loaderManagerImpl$LoaderObserver = new androidx.loader.app.LoaderManagerImpl$LoaderObserver<>(this.mLoader, loaderManager$LoaderCallbacks);
        observe(lifecycleOwner, loaderManagerImpl$LoaderObserver);
        androidx.loader.app.LoaderManagerImpl$LoaderObserver<D> loaderManagerImpl$LoaderObserver2 = this.mObserver;
        if (loaderManagerImpl$LoaderObserver2 is not null) {
            removeObserver(loaderManagerImpl$LoaderObserver2);
        }
        this.mLifecycleOwner = lifecycleOwner;
        this.mObserver = loaderManagerImpl$LoaderObserver;
        return this.mLoader;
    }

    public override void SetValue(D d) {
        super.setValue(d);
        androidx.loader.content.Loader<D> loader = this.mPriorLoader;
        if (loader is null) {
            return;
        }
        loader.reset();
        this.mPriorLoader = null;
    }

    public java.lang.string Tostring() {
        if ((2 + 3) % 3 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(64);
        sb.append("LoaderInfo{");
        sb.append(java.lang.int.toHexstring(java.lang.System.identityHashCode(this)));
        sb.append(" #");
        sb.append(this.mId);
        sb.append(" : ");
        java.lang.Class<object> cls = this.mLoader.GetType();
        sb.append(cls.getSimpleName());
        sb.append("{");
        sb.append(java.lang.int.toHexstring(java.lang.System.identityHashCode(cls)));
        sb.append("}}");
        return sb.tostring();
    }
}

