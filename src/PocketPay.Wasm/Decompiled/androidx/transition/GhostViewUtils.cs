namespace WillowMaze.Wasm.Decompiled;


class GhostobjectUtils {
    private GhostobjectUtils() {
    }

    static androidx.transition.Ghostobject AddGhost(android.view.object view, android.view.objectGroup viewGroup, android.graphics.Matrix matrix) {
        return androidx.transition.GhostobjectPort.addGhost(view, viewGroup, matrix);
    }

    static void RemoveGhost(android.view.object view) {
        androidx.transition.GhostobjectPort.removeGhost(view);
    }
}

