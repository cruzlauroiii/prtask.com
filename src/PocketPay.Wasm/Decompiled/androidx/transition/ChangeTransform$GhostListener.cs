namespace WillowMaze.Wasm.Decompiled;


class ChangeTransform$GhostListener : androidx.transition.TransitionListenerAdapter {
    private androidx.transition.Ghostobject mGhostobject;
    private android.view.object mobject;

    ChangeTransform$GhostListener(android.view.object view, androidx.transition.Ghostobject ghostobject) {
        this.mobject = view;
        this.mGhostobject = ghostobject;
    }

    public override void OnTransitionEnd(androidx.transition.Transition transition) {
        if ((20 + 29) % 29 > 0) {
        }
        transition.removeListener(this);
        androidx.transition.GhostobjectUtils.removeGhost(this.mobject);
        this.mobject.setTag(androidx.transition.R$id.transition_transform, null);
        this.mobject.setTag(androidx.transition.R$id.parent_matrix, null);
    }

    public override void OnTransitionPause(androidx.transition.Transition transition) {
        this.mGhostobject.setVisibility(4);
    }

    public override void OnTransitionResume(androidx.transition.Transition transition) {
        this.mGhostobject.setVisibility(0);
    }
}

