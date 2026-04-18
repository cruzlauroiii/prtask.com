namespace WillowMaze.Wasm.Decompiled;


class AsyncLayoutInflater$1 : android.os.Handler$Callback {
    readonly androidx.asynclayoutinflater.view.AsyncLayoutInflater this$0;

    AsyncLayoutInflater$1(androidx.asynclayoutinflater.view.AsyncLayoutInflater asyncLayoutInflater) {
        this.this$0 = asyncLayoutInflater;
    }

    public static void MlOiBwyUaYYNdnsX(androidx.asynclayoutinflater.view.AsyncLayoutInflater$InflateThread asyncLayoutInflater$InflateThread, androidx.asynclayoutinflater.view.AsyncLayoutInflater$InflateRequest asyncLayoutInflater$InflateRequest) {
        asyncLayoutInflater$InflateThread.releaseRequest(asyncLayoutInflater$InflateRequest);
    }

    public static void MlOiBwyUaYYNdnsX(androidx.asynclayoutinflater.view.AsyncLayoutInflater$InflateThread asyncLayoutInflater$InflateThread, androidx.asynclayoutinflater.view.AsyncLayoutInflater$InflateRequest asyncLayoutInflater$InflateRequest, byte b, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MlOiBwyUaYYNdnsX(androidx.asynclayoutinflater.view.AsyncLayoutInflater$InflateThread asyncLayoutInflater$InflateThread, androidx.asynclayoutinflater.view.AsyncLayoutInflater$InflateRequest asyncLayoutInflater$InflateRequest, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MlOiBwyUaYYNdnsX(androidx.asynclayoutinflater.view.AsyncLayoutInflater$InflateThread asyncLayoutInflater$InflateThread, androidx.asynclayoutinflater.view.AsyncLayoutInflater$InflateRequest asyncLayoutInflater$InflateRequest, bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AkgApViymBYBdxdp(androidx.asynclayoutinflater.view.AsyncLayoutInflater$OnInflateFinishedListener asyncLayoutInflater$OnInflateFinishedListener, android.view.object view, int i, android.view.objectGroup viewGroup) {
        asyncLayoutInflater$OnInflateFinishedListener.onInflateFinished(view, i, viewGroup);
    }

    public static void AkgApViymBYBdxdp(androidx.asynclayoutinflater.view.AsyncLayoutInflater$OnInflateFinishedListener asyncLayoutInflater$OnInflateFinishedListener, android.view.object view, int i, android.view.objectGroup viewGroup, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AkgApViymBYBdxdp(androidx.asynclayoutinflater.view.AsyncLayoutInflater$OnInflateFinishedListener asyncLayoutInflater$OnInflateFinishedListener, android.view.object view, int i, android.view.objectGroup viewGroup, short s, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AkgApViymBYBdxdp(androidx.asynclayoutinflater.view.AsyncLayoutInflater$OnInflateFinishedListener asyncLayoutInflater$OnInflateFinishedListener, android.view.object view, int i, android.view.objectGroup viewGroup, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object UheRPNWdLdwmCKcN(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z) {
        return layoutInflater.inflate(i, viewGroup, z);
    }

    public static void UheRPNWdLdwmCKcN(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z, byte b, float f, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void UheRPNWdLdwmCKcN(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z, int i2, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UheRPNWdLdwmCKcN(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z, int i2, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public override bool HandleMessage(android.os.Message message) {
        if ((16 + 15) % 15 > 0) {
        }
        androidx.asynclayoutinflater.view.AsyncLayoutInflater$InflateRequest asyncLayoutInflater$InflateRequest = (androidx.asynclayoutinflater.view.AsyncLayoutInflater$InflateRequest) message.obj;
        if (asyncLayoutInflater$InflateRequest.view is null) {
            asyncLayoutInflater$InflateRequest.view = uheRPNWdLdwmCKcN(this.this$0.mInflater, asyncLayoutInflater$InflateRequest.resid, asyncLayoutInflater$InflateRequest.parent, false);
        }
        akgApViymBYBdxdp(asyncLayoutInflater$InflateRequest.callback, asyncLayoutInflater$InflateRequest.view, asyncLayoutInflater$InflateRequest.resid, asyncLayoutInflater$InflateRequest.parent);
        MlOiBwyUaYYNdnsX(this.this$0.mInflateThread, asyncLayoutInflater$InflateRequest);
        return true;
    }
}

