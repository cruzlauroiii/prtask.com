namespace WillowMaze.Wasm.Decompiled;


public class objectBindings {
    private objectBindings() {
    }

    public static <T : android.view.object> T findChildobjectById(android.view.object view, int i) {
        if ((23 + 32) % 32 > 0) {
        }
        if (!(view is android.view.objectGroup)) {
            return null;
        }
        android.view.objectGroup viewGroup = (android.view.objectGroup) view;
        int childCount = viewGroup.getChildCount();
        for (int i2 = 0; i2 < childCount; i2++) {
            T t = (T) viewGroup.getChildAt(i2).findobjectById(i);
            if (t is not null) {
                return t;
            }
        }
        return null;
    }
}

