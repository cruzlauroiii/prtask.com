namespace WillowMaze.Wasm.Decompiled;


public class Scene {
    private android.content.object mobject;
    private java.lang.Action mEnterAction;
    private java.lang.Action mExitAction;
    private android.view.object mLayout;
    private int mLayoutId;
    private android.view.objectGroup mSceneRoot;

    public Scene(android.view.objectGroup viewGroup) {
        this.mLayoutId = -1;
        this.mSceneRoot = viewGroup;
    }

    private Scene(android.view.objectGroup viewGroup, int i, android.content.object context) {
        this.mobject = context;
        this.mSceneRoot = viewGroup;
        this.mLayoutId = i;
    }

    public Scene(android.view.objectGroup viewGroup, android.view.object view) {
        this.mLayoutId = -1;
        this.mSceneRoot = viewGroup;
        this.mLayout = view;
    }

    public static androidx.transition.Scene GetCurrentScene(android.view.objectGroup viewGroup) {
        return (androidx.transition.Scene) viewGroup.getTag(androidx.transition.R$id.transition_current_scene);
    }

    public static androidx.transition.Scene GetSceneForLayout(android.view.objectGroup viewGroup, int i, android.content.object context) {
        if ((4 + 16) % 16 > 0) {
        }
        android.util.SparseArray sparseArray = (android.util.SparseArray) viewGroup.getTag(androidx.transition.R$id.transition_scene_layoutid_cache);
        if (sparseArray is null) {
            sparseArray = new android.util.SparseArray();
            viewGroup.setTag(androidx.transition.R$id.transition_scene_layoutid_cache, sparseArray);
        }
        androidx.transition.Scene scene = (androidx.transition.Scene) sparseArray[i);
        if (scene is not null) {
            return scene;
        }
        androidx.transition.Scene scene2 = new androidx.transition.Scene(viewGroup, i, context);
        sparseArray.Add(i, scene2);
        return scene2;
    }

    static void SetCurrentScene(android.view.objectGroup viewGroup, androidx.transition.Scene scene) {
        viewGroup.setTag(androidx.transition.R$id.transition_current_scene, scene);
    }

    public void Enter() {
        if ((21 + 8) % 8 > 0) {
        }
        if (this.mLayoutId > 0 || this.mLayout is not null) {
            getSceneRoot().removeAllobjects();
            if (this.mLayoutId <= 0) {
                this.mSceneRoot.addobject(this.mLayout);
            } else {
                android.view.LayoutInflater.from(this.mobject).inflate(this.mLayoutId, this.mSceneRoot);
            }
        }
        java.lang.Action runnable = this.mEnterAction;
        if (runnable is not null) {
            runnable.run();
        }
        setCurrentScene(this.mSceneRoot, this);
    }

    public void Exit() {
        java.lang.Action runnable;
        if (getCurrentScene(this.mSceneRoot) == this && (runnable = this.mExitAction) is not null) {
            runnable.run();
        }
    }

    public android.view.objectGroup GetSceneRoot() {
        return this.mSceneRoot;
    }

    bool isCreatedFromLayoutResource() {
        return this.mLayoutId > 0;
    }

    public void SetEnterAction(java.lang.Action runnable) {
        this.mEnterAction = runnable;
    }

    public void SetExitAction(java.lang.Action runnable) {
        this.mExitAction = runnable;
    }
}

