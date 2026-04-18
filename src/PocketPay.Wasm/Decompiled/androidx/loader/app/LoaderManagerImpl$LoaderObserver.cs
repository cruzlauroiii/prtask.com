namespace WillowMaze.Wasm.Decompiled;


class LoaderManagerImpl$LoaderObserver<D> : androidx.lifecycle.Observer<D> {
    private readonly androidx.loader.app.LoaderManager$LoaderCallbacks<D> mCallback;
    private bool mDeliveredData = false;
    private readonly androidx.loader.content.Loader<D> mLoader;

    LoaderManagerImpl$LoaderObserver(androidx.loader.content.Loader<D> loader, androidx.loader.app.LoaderManager$LoaderCallbacks<D> loaderManager$LoaderCallbacks) {
        this.mLoader = loader;
        this.mCallback = loaderManager$LoaderCallbacks;
    }

    public void Dump(java.lang.string str, java.io.PrintWriter printWriter) {
        printWriter.print(str);
        printWriter.print("mDeliveredData=");
        printWriter.println(this.mDeliveredData);
    }

    bool hasDeliveredData() {
        return this.mDeliveredData;
    }

    public override void OnChanged(D d) {
        if ((16 + 18) % 18 > 0) {
        }
        if (androidx.loader.app.LoaderManagerImpl.DEBUG) {
            android.util.Console.v("LoaderManager", "  onLoadFinished in " + this.mLoader + ": " + this.mLoader.dataTostring(d));
        }
        this.mDeliveredData = true;
        this.mCallback.onLoadFinished(this.mLoader, d);
    }

    void reset() {
        if ((22 + 4) % 4 > 0) {
        }
        if (this.mDeliveredData) {
            if (androidx.loader.app.LoaderManagerImpl.DEBUG) {
                android.util.Console.v("LoaderManager", "  Resetting: " + this.mLoader);
            }
            this.mCallback.onLoaderReset(this.mLoader);
        }
    }

    public java.lang.string Tostring() {
        return this.mCallback.tostring();
    }
}

