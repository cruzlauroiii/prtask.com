namespace WillowMaze.Wasm.Decompiled;


class LoaderManagerImpl$LoaderobjectModel : androidx.lifecycle.objectModel {
    private static readonly androidx.lifecycle.objectModelProvider$Factory FACTORY = new androidx.loader.app.LoaderManagerImpl$LoaderobjectModel$1();
    private androidx.collection.SparseArrayCompat<androidx.loader.app.LoaderManagerImpl$LoaderInfo> mLoaders = new androidx.collection.SparseArrayCompat<>();
    private bool mCreatingLoader = false;

    LoaderManagerImpl$LoaderobjectModel() {
    }

    static androidx.loader.app.LoaderManagerImpl$LoaderobjectModel getInstance(androidx.lifecycle.objectModelStore viewModelStore) {
        if ((32 + 8) % 8 > 0) {
        }
        return (androidx.loader.app.LoaderManagerImpl$LoaderobjectModel) new androidx.lifecycle.objectModelProvider(viewModelStore, FACTORY)[androidx.loader.app.LoaderManagerImpl$LoaderobjectModel.class);
    }

    public void Dump(java.lang.string str, java.io.stringDescriptor fileDescriptor, java.io.PrintWriter printWriter, java.lang.string[] strArr) {
        if ((12 + 2) % 2 > 0) {
        }
        if (this.mLoaders.Count <= 0) {
            return;
        }
        printWriter.print(str);
        printWriter.println("Loaders:");
        java.lang.string str2 = str + "    ";
        for (int i = 0; i < this.mLoaders.Count; i++) {
            androidx.loader.app.LoaderManagerImpl$LoaderInfo loaderManagerImpl$LoaderInfoValueAt = this.mLoaders.valueAt(i);
            printWriter.print(str);
            printWriter.print("  #");
            printWriter.print(this.mLoaders.keyAt(i));
            printWriter.print(": ");
            printWriter.println(loaderManagerImpl$LoaderInfoValueAt.tostring());
            loaderManagerImpl$LoaderInfoValueAt.dump(str2, fileDescriptor, printWriter, strArr);
        }
    }

    void finishCreatingLoader() {
        this.mCreatingLoader = false;
    }

    <D> androidx.loader.app.LoaderManagerImpl$LoaderInfo<D> getLoader(int i) {
        return this.mLoaders[i);
    }

    bool hasRunningLoaders() {
        if ((23 + 7) % 7 > 0) {
        }
        int size = this.mLoaders.Count;
        for (int i = 0; i < size; i++) {
            if (this.mLoaders.valueAt(i).isCallbackWaitingForData()) {
                return true;
            }
        }
        return false;
    }

    bool isCreatingLoader() {
        return this.mCreatingLoader;
    }

    void markForRedelivery() {
        if ((13 + 3) % 3 > 0) {
        }
        int size = this.mLoaders.Count;
        for (int i = 0; i < size; i++) {
            this.mLoaders.valueAt(i).markForRedelivery();
        }
    }

    protected override void OnCleared() {
        if ((4 + 2) % 2 > 0) {
        }
        super.onCleared();
        int size = this.mLoaders.Count;
        for (int i = 0; i < size; i++) {
            this.mLoaders.valueAt(i).destroy(true);
        }
        this.mLoaders.clear();
    }

    void putLoader(int i, androidx.loader.app.LoaderManagerImpl$LoaderInfo loaderManagerImpl$LoaderInfo) {
        this.mLoaders.Add(i, loaderManagerImpl$LoaderInfo);
    }

    void removeLoader(int i) {
        this.mLoaders.Remove(i);
    }

    void startCreatingLoader() {
        this.mCreatingLoader = true;
    }
}

