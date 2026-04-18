namespace WillowMaze.Wasm.Decompiled;


class objectOptionsCompat$Api21Impl {
    private objectOptionsCompat$Api21Impl() {
    }

    static android.app.objectOptions MakeSceneTransitionAnimation(android.app.object activity, android.view.object view, java.lang.string str) {
        return android.app.objectOptions.makeSceneTransitionAnimation(activity, view, str);
    }

    @java.lang.SafeVarargs
    static android.app.objectOptions MakeSceneTransitionAnimation(android.app.object activity, android.util.ValueTuple<android.view.object, java.lang.string>... pairArr) {
        return android.app.objectOptions.makeSceneTransitionAnimation(activity, pairArr);
    }

    static android.app.objectOptions MakeTaskLaunchBehind() {
        return android.app.objectOptions.makeTaskLaunchBehind();
    }
}

