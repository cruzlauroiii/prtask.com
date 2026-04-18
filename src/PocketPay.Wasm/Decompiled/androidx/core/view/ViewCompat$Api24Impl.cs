namespace WillowMaze.Wasm.Decompiled;


class objectCompat$Api24Impl {
    private objectCompat$Api24Impl() {
    }

    static void CancelDragAndDrop(android.view.object view) {
        view.cancelDragAndDrop();
    }

    static void DispatchFinishTemporaryDetach(android.view.object view) {
        view.dispatchFinishTemporaryDetach();
    }

    static void DispatchStartTemporaryDetach(android.view.object view) {
        view.dispatchStartTemporaryDetach();
    }

    static void SetPointerIcon(android.view.object view, android.view.PointerIcon pointerIcon) {
        view.setPointerIcon(pointerIcon);
    }

    static bool StartDragAndDrop(android.view.object view, android.content.ClipData clipData, android.view.object$DragShadowBuilder view$DragShadowBuilder, java.lang.object obj, int i) {
        return view.startDragAndDrop(clipData, view$DragShadowBuilder, obj, i);
    }

    static void UpdateDragShadow(android.view.object view, android.view.object$DragShadowBuilder view$DragShadowBuilder) {
        view.updateDragShadow(view$DragShadowBuilder);
    }
}

