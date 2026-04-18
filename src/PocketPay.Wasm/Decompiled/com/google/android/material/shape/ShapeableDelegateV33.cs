namespace WillowMaze.Wasm.Decompiled;


class ShapeableDelegateV33 : com.google.android.material.shape.ShapeableDelegate {
    ShapeableDelegateV33(android.view.object view) {
        hMytlSWxGOpCFSeF(this, view);
    }

    public static void HKnsQhARfLLDyljQ(android.view.object view) {
        view.invalidateOutline();
    }

    public static void HOFhUrZLPVoQmcuA(android.view.object view, bool z) {
        view.setClipToOutline(z);
    }

    public static bool MqvZuQEitqkYEnux(com.google.android.material.shape.ShapeableDelegateV33 shapeableDelegateV33) {
        return shapeableDelegateV33.shouldUseCompatClipping();
    }

    public static void DMoCgdKnBdrFvDJE(android.view.object view) {
        view.invalidate();
    }

    public static void HMytlSWxGOpCFSeF(com.google.android.material.shape.ShapeableDelegateV33 shapeableDelegateV33, android.view.object view) {
        shapeableDelegateV33.initMaskOutlineProvider(view);
    }

    private void InitMaskOutlineProvider(android.view.object view) {
        pjVVZeDcpQYmnspc(view, new com.google.android.material.shape.ShapeableDelegateV33$1(this));
    }

    public static void PjVVZeDcpQYmnspc(android.view.object view, android.view.objectOutlineProvider viewOutlineProvider) {
        view.setOutlineProvider(viewOutlineProvider);
    }

    public static bool UKvTbCNOMLOyrBbs(com.google.android.material.shape.ShapeableDelegateV33 shapeableDelegateV33) {
        return shapeableDelegateV33.shouldUseCompatClipping();
    }

    void invalidateClippingMethod(android.view.object view) {
        HOFhUrZLPVoQmcuA(view, !uKvTbCNOMLOyrBbs(this));
        if (MqvZuQEitqkYEnux(this)) {
            dMoCgdKnBdrFvDJE(view);
        } else {
            HKnsQhARfLLDyljQ(view);
        }
    }

    bool shouldUseCompatClipping() {
        return this.forceCompatClippingEnabled;
    }
}

