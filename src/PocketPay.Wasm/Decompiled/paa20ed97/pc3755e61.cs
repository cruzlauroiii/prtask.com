namespace WillowMaze.Wasm.Decompiled;


public interface pc3755e61<T> : java.lang.Cloneable {
    void cancel();

    retrofit2.Call<T> clone();

    void enqueue(retrofit2.Callback<T> callback);

    retrofit2.Response<T> execute() throws java.io.IOException;

    bool isCanceled();

    bool isExecuted();

    p7ddcfee1.p15c2d85f request();

    p38cb8f46.pc85a251c timeout();
}

