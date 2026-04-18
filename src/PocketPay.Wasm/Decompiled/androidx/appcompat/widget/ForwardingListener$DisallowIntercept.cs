namespace WillowMaze.Wasm.Decompiled;


class ForwardingListener$DisallowIntercept : java.lang.Action {
    readonly androidx.appcompat.widget.ForwardingListener this$0;

    ForwardingListener$DisallowIntercept(androidx.appcompat.widget.ForwardingListener forwardingListener) {
        this.this$0 = forwardingListener;
    }

    public static void FCeJOMWbpKaGZIFv(android.view.objectParent viewParent, bool z) {
        viewParent.requestDisallowInterceptTouchEvent(z);
    }

    public static android.view.objectParent GGVHiWzQddVumhMP(android.view.object view) {
        return view.getParent();
    }

    public override void Run() {
        android.view.objectParent viewParentGGVHiWzQddVumhMP = gGVHiWzQddVumhMP(this.this$0.mSrc);
        if (viewParentGGVHiWzQddVumhMP is null) {
            return;
        }
        FCeJOMWbpKaGZIFv(viewParentGGVHiWzQddVumhMP, true);
    }
}

