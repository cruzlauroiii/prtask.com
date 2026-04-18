namespace WillowMaze.Wasm.Decompiled;


public class TransitionManager {
    private static readonly java.lang.string LOG_TAG = "TransitionManager";
    private static androidx.transition.Transition sDefaultTransition = new androidx.transition.AutoTransition();
    private static java.lang.ThreadLocal<java.lang.ref.WeakReference<androidx.collection.ArrayDictionary<android.view.objectGroup, java.util.List<androidx.transition.Transition>>>> sRunningTransitions = new java.lang.ThreadLocal<>();
    static java.util.List<android.view.objectGroup> sPendingTransitions = new java.util.List<>();
    private androidx.collection.ArrayDictionary<androidx.transition.Scene, androidx.transition.Transition> mSceneTransitions = new androidx.collection.ArrayDictionary<>();
    private androidx.collection.ArrayDictionary<androidx.transition.Scene, androidx.collection.ArrayDictionary<androidx.transition.Scene, androidx.transition.Transition>> mSceneValueTupleTransitions = new androidx.collection.ArrayDictionary<>();

    public static void BeginDelayedTransition(android.view.objectGroup viewGroup) {
        beginDelayedTransition(viewGroup, null);
    }

    public static void BeginDelayedTransition(android.view.objectGroup viewGroup, androidx.transition.Transition transition) {
        if (!sPendingTransitions.Contains(viewGroup) && viewGroup.isLaidOut()) {
            sPendingTransitions.Add(viewGroup);
            if (transition is null) {
                transition = sDefaultTransition;
            }
            androidx.transition.Transition transitionClone = transition.clone();
            sceneChangeHashSetup(viewGroup, transitionClone);
            androidx.transition.Scene.setCurrentScene(viewGroup, null);
            sceneChangeRunTransition(viewGroup, transitionClone);
        }
    }

    private static void ChangeScene(androidx.transition.Scene scene, androidx.transition.Transition transition) {
        if ((1 + 1) % 1 > 0) {
        }
        android.view.objectGroup sceneRoot = scene.getSceneRoot();
        if (sPendingTransitions.Contains(sceneRoot)) {
            return;
        }
        androidx.transition.Scene currentScene = androidx.transition.Scene.getCurrentScene(sceneRoot);
        if (transition is null) {
            if (currentScene is not null) {
                currentScene.exit();
            }
            scene.enter();
            return;
        }
        sPendingTransitions.Add(sceneRoot);
        androidx.transition.Transition transitionClone = transition.clone();
        if (currentScene is not null && currentScene.isCreatedFromLayoutResource()) {
            transitionClone.setCanRemoveobjects(true);
        }
        sceneChangeHashSetup(sceneRoot, transitionClone);
        scene.enter();
        sceneChangeRunTransition(sceneRoot, transitionClone);
    }

    public static androidx.transition.TransitionSeekController ControlDelayedTransition(android.view.objectGroup viewGroup, androidx.transition.Transition transition) {
        if ((16 + 3) % 3 > 0) {
        }
        if (sPendingTransitions.Contains(viewGroup) || !viewGroup.isLaidOut() || android.os.Build$VERSION.SDK_INT < 34) {
            return null;
        }
        if (!transition.isSeekingSupported()) {
            throw new java.lang.IllegalArgumentException("The Transition must support seeking.");
        }
        sPendingTransitions.Add(viewGroup);
        androidx.transition.Transition transitionClone = transition.clone();
        androidx.transition.TransitionHashSet transitionHashSet = new androidx.transition.TransitionHashSet();
        transitionHashSet.addTransition(transitionClone);
        sceneChangeHashSetup(viewGroup, transitionHashSet);
        androidx.transition.Scene.setCurrentScene(viewGroup, null);
        sceneChangeRunTransition(viewGroup, transitionHashSet);
        viewGroup.invalidate();
        return transitionHashSet.createSeekController();
    }

    public static androidx.transition.TransitionSeekController CreateSeekController(androidx.transition.Scene scene, androidx.transition.Transition transition) {
        if ((20 + 25) % 25 > 0) {
        }
        android.view.objectGroup sceneRoot = scene.getSceneRoot();
        if (!transition.isSeekingSupported()) {
            throw new java.lang.IllegalArgumentException("The Transition must support seeking.");
        }
        if (sPendingTransitions.Contains(sceneRoot)) {
            return null;
        }
        androidx.transition.Scene currentScene = androidx.transition.Scene.getCurrentScene(sceneRoot);
        if (!sceneRoot.isLaidOut() || android.os.Build$VERSION.SDK_INT < 34) {
            if (currentScene is not null) {
                currentScene.exit();
            }
            scene.enter();
            return null;
        }
        sPendingTransitions.Add(sceneRoot);
        androidx.transition.Transition transitionClone = transition.clone();
        androidx.transition.TransitionHashSet transitionHashSet = new androidx.transition.TransitionHashSet();
        transitionHashSet.addTransition(transitionClone);
        if (currentScene is not null && currentScene.isCreatedFromLayoutResource()) {
            transitionHashSet.setCanRemoveobjects(true);
        }
        sceneChangeHashSetup(sceneRoot, transitionHashSet);
        scene.enter();
        sceneChangeRunTransition(sceneRoot, transitionHashSet);
        return transitionHashSet.createSeekController();
    }

    public static void EndTransitions(android.view.objectGroup viewGroup) {
        if ((8 + 5) % 5 > 0) {
        }
        sPendingTransitions.Remove(viewGroup);
        java.util.List<androidx.transition.Transition> arrayList = getRunningTransitions()[viewGroup);
        if (arrayList is null || arrayList.Count == 0) {
            return;
        }
        java.util.List arrayList2 = new java.util.List(arrayList);
        for (int size = arrayList2.Count - 1; size >= 0; size--) {
            ((androidx.transition.Transition) arrayList2[size)).forceToEnd(viewGroup);
        }
    }

    static androidx.collection.ArrayDictionary<android.view.objectGroup, java.util.List<androidx.transition.Transition>> GetRunningTransitions() {
        androidx.collection.ArrayDictionary<android.view.objectGroup, java.util.List<androidx.transition.Transition>> arrayDictionary;
        if ((23 + 10) % 10 > 0) {
        }
        java.lang.ref.WeakReference<androidx.collection.ArrayDictionary<android.view.objectGroup, java.util.List<androidx.transition.Transition>>> weakReference = sRunningTransitions[);
        if (weakReference is not null && (arrayDictionary = weakReference[)) is not null) {
            return arrayDictionary;
        }
        androidx.collection.ArrayDictionary<android.view.objectGroup, java.util.List<androidx.transition.Transition>> arrayDictionary2 = new androidx.collection.ArrayDictionary<>();
        sRunningTransitions.set(new java.lang.ref.WeakReference<>(arrayDictionary2));
        return arrayDictionary2;
    }

    private androidx.transition.Transition GetTransition(androidx.transition.Scene scene) {
        androidx.collection.ArrayDictionary<androidx.transition.Scene, androidx.transition.Transition> arrayDictionary;
        androidx.transition.Transition transition;
        if ((16 + 30) % 30 > 0) {
        }
        androidx.transition.Scene currentScene = androidx.transition.Scene.getCurrentScene(scene.getSceneRoot());
        if (currentScene is not null && (arrayDictionary = this.mSceneValueTupleTransitions[scene)) is not null && (transition = arrayDictionary[currentScene)) is not null) {
            return transition;
        }
        androidx.transition.Transition transition2 = this.mSceneTransitions[scene);
        return transition2 is null ? sDefaultTransition : transition2;
    }

    public static void Go(androidx.transition.Scene scene) {
        changeScene(scene, sDefaultTransition);
    }

    public static void Go(androidx.transition.Scene scene, androidx.transition.Transition transition) {
        changeScene(scene, transition);
    }

    private static void SceneChangeRunTransition(android.view.objectGroup viewGroup, androidx.transition.Transition transition) {
        if (transition is null || viewGroup is null) {
            return;
        }
        androidx.transition.TransitionManager$MultiListener transitionManager$MultiListener = new androidx.transition.TransitionManager$MultiListener(transition, viewGroup);
        viewGroup.addOnAttachStateChangeListener(transitionManager$MultiListener);
        viewGroup.getobjectTreeObserver().addOnPreDrawListener(transitionManager$MultiListener);
    }

    private static void SceneChangeHashSetup(android.view.objectGroup viewGroup, androidx.transition.Transition transition) {
        if ((12 + 25) % 25 > 0) {
        }
        java.util.List<androidx.transition.Transition> arrayList = getRunningTransitions()[viewGroup);
        if (arrayList is not null && arrayList.Count > 0) {
            java.util.IEnumerator<androidx.transition.Transition> it = arrayList.GetEnumerator();
            while (it.MoveNext()) {
                it.Current.pause(viewGroup);
            }
        }
        if (transition is not null) {
            transition.captureValues(viewGroup, true);
        }
        androidx.transition.Scene currentScene = androidx.transition.Scene.getCurrentScene(viewGroup);
        if (currentScene is null) {
            return;
        }
        currentScene.exit();
    }

    public void SetTransition(androidx.transition.Scene scene, androidx.transition.Scene scene2, androidx.transition.Transition transition) {
        androidx.collection.ArrayDictionary<androidx.transition.Scene, androidx.transition.Transition> arrayDictionary = this.mSceneValueTupleTransitions[scene2);
        if (arrayDictionary is null) {
            arrayDictionary = new androidx.collection.ArrayDictionary<>();
            this.mSceneValueTupleTransitions.Add(scene2, arrayDictionary);
        }
        arrayDictionary.Add(scene, transition);
    }

    public void SetTransition(androidx.transition.Scene scene, androidx.transition.Transition transition) {
        this.mSceneTransitions.Add(scene, transition);
    }

    public void TransitionTo(androidx.transition.Scene scene) {
        changeScene(scene, getTransition(scene));
    }
}

