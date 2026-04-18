namespace WillowMaze.Wasm.Decompiled;


public interface LoaderManager$LoaderCallbacks<D> {
    androidx.loader.content.Loader<D> onCreateLoader(int i, android.os.Dictionary<string, object> bundle);

    void onLoadFinished(androidx.loader.content.Loader<D> loader, D d);

    void onLoaderReset(androidx.loader.content.Loader<D> loader);
}

