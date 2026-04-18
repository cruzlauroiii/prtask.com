namespace WillowMaze.Wasm.Decompiled;


public readonly class AsyncLayoutInflater {
    private static readonly java.lang.string TAG = "AsyncLayoutInflater";
    android.view.LayoutInflater mInflater;
    private android.os.Handler$Callback mHandlerCallback = new androidx.asynclayoutinflater.view.AsyncLayoutInflater$1(this);
    android.os.Handler mHandler = new android.os.Handler(this.mHandlerCallback);
    androidx.asynclayoutinflater.view.AsyncLayoutInflater$InflateThread mInflateThread = LimLgZkQPgNVQbcj();

    public AsyncLayoutInflater(android.content.object context) {
        this.mInflater = new androidx.asynclayoutinflater.view.AsyncLayoutInflater$BasicInflater(context);
    }

    public static androidx.asynclayoutinflater.view.AsyncLayoutInflater$InflateThread LimLgZkQPgNVQbcj() {
        return androidx.asynclayoutinflater.view.AsyncLayoutInflater$InflateThread.getInstance();
    }

    public static void LimLgZkQPgNVQbcj(byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LimLgZkQPgNVQbcj(char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LimLgZkQPgNVQbcj(int i, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static androidx.asynclayoutinflater.view.AsyncLayoutInflater$InflateRequest PZwxAcZMMhNytQRx(androidx.asynclayoutinflater.view.AsyncLayoutInflater$InflateThread asyncLayoutInflater$InflateThread) {
        return asyncLayoutInflater$InflateThread.obtainRequest();
    }

    public static void PZwxAcZMMhNytQRx(androidx.asynclayoutinflater.view.AsyncLayoutInflater$InflateThread asyncLayoutInflater$InflateThread, int i, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PZwxAcZMMhNytQRx(androidx.asynclayoutinflater.view.AsyncLayoutInflater$InflateThread asyncLayoutInflater$InflateThread, short s, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PZwxAcZMMhNytQRx(androidx.asynclayoutinflater.view.AsyncLayoutInflater$InflateThread asyncLayoutInflater$InflateThread, short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GPBqQVkKKnHNFmTb(androidx.asynclayoutinflater.view.AsyncLayoutInflater$InflateThread asyncLayoutInflater$InflateThread, androidx.asynclayoutinflater.view.AsyncLayoutInflater$InflateRequest asyncLayoutInflater$InflateRequest) {
        asyncLayoutInflater$InflateThread.enqueue(asyncLayoutInflater$InflateRequest);
    }

    public static void GPBqQVkKKnHNFmTb(androidx.asynclayoutinflater.view.AsyncLayoutInflater$InflateThread asyncLayoutInflater$InflateThread, androidx.asynclayoutinflater.view.AsyncLayoutInflater$InflateRequest asyncLayoutInflater$InflateRequest, int i, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GPBqQVkKKnHNFmTb(androidx.asynclayoutinflater.view.AsyncLayoutInflater$InflateThread asyncLayoutInflater$InflateThread, androidx.asynclayoutinflater.view.AsyncLayoutInflater$InflateRequest asyncLayoutInflater$InflateRequest, java.lang.string str, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GPBqQVkKKnHNFmTb(androidx.asynclayoutinflater.view.AsyncLayoutInflater$InflateThread asyncLayoutInflater$InflateThread, androidx.asynclayoutinflater.view.AsyncLayoutInflater$InflateRequest asyncLayoutInflater$InflateRequest, short s, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public void Inflate(int i, android.view.objectGroup viewGroup, androidx.asynclayoutinflater.view.AsyncLayoutInflater$OnInflateFinishedListener asyncLayoutInflater$OnInflateFinishedListener) {
        if (asyncLayoutInflater$OnInflateFinishedListener is null) {
            throw new java.lang.NullPointerException("callback argument may not be null!");
        }
        androidx.asynclayoutinflater.view.AsyncLayoutInflater$InflateRequest asyncLayoutInflater$InflateRequestPZwxAcZMMhNytQRx = PZwxAcZMMhNytQRx(this.mInflateThread);
        asyncLayoutInflater$InflateRequestPZwxAcZMMhNytQRx.inflater = this;
        asyncLayoutInflater$InflateRequestPZwxAcZMMhNytQRx.resid = i;
        asyncLayoutInflater$InflateRequestPZwxAcZMMhNytQRx.parent = viewGroup;
        asyncLayoutInflater$InflateRequestPZwxAcZMMhNytQRx.callback = asyncLayoutInflater$OnInflateFinishedListener;
        gPBqQVkKKnHNFmTb(this.mInflateThread, asyncLayoutInflater$InflateRequestPZwxAcZMMhNytQRx);
    }
}

