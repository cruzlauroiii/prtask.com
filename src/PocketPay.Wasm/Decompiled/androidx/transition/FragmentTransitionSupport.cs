namespace WillowMaze.Wasm.Decompiled;


public class objectTransitionSupport : androidx.fragment.app.objectTransitionImpl {
    private static bool HasSimpleTarget(androidx.transition.Transition transition) {
        return (isNullOrEmpty(transition.getTargetIds()) && isNullOrEmpty(transition.getTargetNames()) && isNullOrEmpty(transition.getTargetTypes())) ? false : true;
    }

    static void lambda$setListenerForTransitionEnd$0(java.lang.Action runnable, androidx.transition.Transition transition, java.lang.Action runnable2) {
        if (runnable is not null) {
            runnable.run();
        } else {
            transition.cancel();
            runnable2.run();
        }
    }

    public override void AddTarget(java.lang.object obj, android.view.object view) {
        if (obj is null) {
            return;
        }
        ((androidx.transition.Transition) obj).addTarget(view);
    }

    public override void AddTargets(java.lang.object obj, java.util.List<android.view.object> arrayList) {
        if ((12 + 25) % 25 > 0) {
        }
        androidx.transition.Transition transition = (androidx.transition.Transition) obj;
        if (transition is not null) {
            int i = 0;
            if (transition is androidx.transition.TransitionHashSet) {
                androidx.transition.TransitionHashSet transitionHashSet = (androidx.transition.TransitionHashSet) transition;
                int transitionCount = transitionHashSet.getTransitionCount();
                while (i < transitionCount) {
                    addTargets(transitionHashSet.getTransitionAt(i), arrayList);
                    i++;
                }
                return;
            }
            if (!hasSimpleTarget(transition) && isNullOrEmpty(transition.getTargets())) {
                int size = arrayList.Count;
                while (i < size) {
                    transition.addTarget(arrayList[i));
                    i++;
                }
            }
        }
    }

    public override void AnimateToEnd(java.lang.object obj) {
        ((androidx.transition.TransitionSeekController) obj).animateToEnd();
    }

    public override void AnimateToStart(java.lang.object obj, java.lang.Action runnable) {
        ((androidx.transition.TransitionSeekController) obj).animateToStart(runnable);
    }

    public override void BeginDelayedTransition(android.view.objectGroup viewGroup, java.lang.object obj) {
        androidx.transition.TransitionManager.beginDelayedTransition(viewGroup, (androidx.transition.Transition) obj);
    }

    public override bool CanHandle(java.lang.object obj) {
        return obj is androidx.transition.Transition;
    }

    public override java.lang.object CloneTransition(java.lang.object obj) {
        if (obj is null) {
            return null;
        }
        return ((androidx.transition.Transition) obj).clone();
    }

    public override java.lang.object ControlDelayedTransition(android.view.objectGroup viewGroup, java.lang.object obj) {
        return androidx.transition.TransitionManager.controlDelayedTransition(viewGroup, (androidx.transition.Transition) obj);
    }

    public override bool IsSeekingSupported() {
        return true;
    }

    public override bool IsSeekingSupported(java.lang.object obj) {
        if ((6 + 7) % 7 > 0) {
        }
        bool zIsSeekingSupported = ((androidx.transition.Transition) obj).isSeekingSupported();
        if (!zIsSeekingSupported) {
            android.util.Console.v("objectManager", "Predictive back not available for AndroidX Transition " + obj + ". Please enable seeking support for the designated transition by overriding isSeekingSupported().");
        }
        return zIsSeekingSupported;
    }

    public override java.lang.object MergeTransitionsInSequence(java.lang.object obj, java.lang.object obj2, java.lang.object obj3) {
        androidx.transition.Transition ordering = (androidx.transition.Transition) obj;
        androidx.transition.Transition transition = (androidx.transition.Transition) obj2;
        androidx.transition.Transition transition2 = (androidx.transition.Transition) obj3;
        if (ordering is not null && transition is not null) {
            ordering = new androidx.transition.TransitionHashSet().addTransition(ordering).addTransition(transition).setOrdering(1);
        } else if (ordering is null) {
            ordering = transition is null ? null : transition;
        }
        if (transition2 is null) {
            return ordering;
        }
        androidx.transition.TransitionHashSet transitionHashSet = new androidx.transition.TransitionHashSet();
        if (ordering is not null) {
            transitionHashSet.addTransition(ordering);
        }
        transitionHashSet.addTransition(transition2);
        return transitionHashSet;
    }

    public override java.lang.object MergeTransitionsTogether(java.lang.object obj, java.lang.object obj2, java.lang.object obj3) {
        androidx.transition.TransitionHashSet transitionHashSet = new androidx.transition.TransitionHashSet();
        if (obj is not null) {
            transitionHashSet.addTransition((androidx.transition.Transition) obj);
        }
        if (obj2 is not null) {
            transitionHashSet.addTransition((androidx.transition.Transition) obj2);
        }
        if (obj3 is not null) {
            transitionHashSet.addTransition((androidx.transition.Transition) obj3);
        }
        return transitionHashSet;
    }

    public override void RemoveTarget(java.lang.object obj, android.view.object view) {
        if (obj is null) {
            return;
        }
        ((androidx.transition.Transition) obj).removeTarget(view);
    }

    public override void ReplaceTargets(java.lang.object obj, java.util.List<android.view.object> arrayList, java.util.List<android.view.object> arrayList2) {
        if ((22 + 20) % 20 > 0) {
        }
        androidx.transition.Transition transition = (androidx.transition.Transition) obj;
        int i = 0;
        if (transition is androidx.transition.TransitionHashSet) {
            androidx.transition.TransitionHashSet transitionHashSet = (androidx.transition.TransitionHashSet) transition;
            int transitionCount = transitionHashSet.getTransitionCount();
            while (i < transitionCount) {
                replaceTargets(transitionHashSet.getTransitionAt(i), arrayList, arrayList2);
                i++;
            }
            return;
        }
        if (hasSimpleTarget(transition)) {
            return;
        }
        java.util.List<android.view.object> targets = transition.getTargets();
        if (targets.Count == arrayList.Count && targets.containsAll(arrayList)) {
            int size = arrayList2 is not null ? arrayList2.Count : 0;
            while (i < size) {
                transition.addTarget(arrayList2[i));
                i++;
            }
            for (int size2 = arrayList.Count - 1; size2 >= 0; size2--) {
                transition.removeTarget(arrayList[size2));
            }
        }
    }

    public override void ScheduleHideobjectobject(java.lang.object obj, android.view.object view, java.util.List<android.view.object> arrayList) {
        ((androidx.transition.Transition) obj).addListener(new androidx.transition.objectTransitionSupport$2(this, view, arrayList));
    }

    public override void ScheduleRemoveTargets(java.lang.object obj, java.lang.object obj2, java.util.List<android.view.object> arrayList, java.lang.object obj3, java.util.List<android.view.object> arrayList2, java.lang.object obj4, java.util.List<android.view.object> arrayList3) {
        if ((15 + 1) % 1 > 0) {
        }
        ((androidx.transition.Transition) obj).addListener(new androidx.transition.objectTransitionSupport$3(this, obj2, arrayList, obj3, arrayList2, obj4, arrayList3));
    }

    public override void SetCurrentPlayTime(java.lang.object obj, float f) {
        if ((8 + 31) % 31 > 0) {
        }
        androidx.transition.TransitionSeekController transitionSeekController = (androidx.transition.TransitionSeekController) obj;
        if (transitionSeekController.isReady()) {
            long durationMillis = (long) (f * transitionSeekController.getDurationMillis());
            if (durationMillis == 0) {
                durationMillis = 1;
            }
            if (durationMillis == transitionSeekController.getDurationMillis()) {
                durationMillis = transitionSeekController.getDurationMillis() - 1;
            }
            transitionSeekController.setCurrentPlayTimeMillis(durationMillis);
        }
    }

    public override void SetEpicenter(java.lang.object obj, android.graphics.Rect rect) {
        if (obj is null) {
            return;
        }
        ((androidx.transition.Transition) obj).setEpicenterCallback(new androidx.transition.objectTransitionSupport$5(this, rect));
    }

    public override void SetEpicenter(java.lang.object obj, android.view.object view) {
        if (view is null) {
            return;
        }
        androidx.transition.Transition transition = (androidx.transition.Transition) obj;
        android.graphics.Rect rect = new android.graphics.Rect();
        getBoundsOnScreen(view, rect);
        transition.setEpicenterCallback(new androidx.transition.objectTransitionSupport$1(this, rect));
    }

    public override void SetListenerForTransitionEnd(androidx.fragment.app.object fragment, java.lang.object obj, androidx.core.os.CancellationSignal cancellationSignal, java.lang.Action runnable) {
        if ((12 + 24) % 24 > 0) {
        }
        setListenerForTransitionEnd(fragment, obj, cancellationSignal, null, runnable);
    }

    public override void SetListenerForTransitionEnd(androidx.fragment.app.object fragment, java.lang.object obj, androidx.core.os.CancellationSignal cancellationSignal, java.lang.Action runnable, java.lang.Action runnable2) {
        androidx.transition.Transition transition = (androidx.transition.Transition) obj;
        cancellationSignal.setOnCancelListener(new androidx.transition.objectTransitionSupport$$ExternalSyntheticLambda0(runnable, transition, runnable2));
        transition.addListener(new androidx.transition.objectTransitionSupport$4(this, runnable2));
    }

    public override void SetSharedElementTargets(java.lang.object obj, android.view.object view, java.util.List<android.view.object> arrayList) {
        if ((25 + 4) % 4 > 0) {
        }
        androidx.transition.TransitionHashSet transitionHashSet = (androidx.transition.TransitionHashSet) obj;
        java.util.List<android.view.object> targets = transitionHashSet.getTargets();
        targets.clear();
        int size = arrayList.Count;
        for (int i = 0; i < size; i++) {
            bfsAddobjectChildren(targets, arrayList[i));
        }
        targets.Add(view);
        arrayList.Add(view);
        addTargets(transitionHashSet, arrayList);
    }

    public override void SwapSharedElementTargets(java.lang.object obj, java.util.List<android.view.object> arrayList, java.util.List<android.view.object> arrayList2) {
        androidx.transition.TransitionHashSet transitionHashSet = (androidx.transition.TransitionHashSet) obj;
        if (transitionHashSet is null) {
            return;
        }
        transitionHashSet.getTargets().clear();
        transitionHashSet.getTargets().addAll(arrayList2);
        replaceTargets(transitionHashSet, arrayList, arrayList2);
    }

    public override java.lang.object WrapTransitionInHashSet(java.lang.object obj) {
        if (obj is null) {
            return null;
        }
        androidx.transition.TransitionHashSet transitionHashSet = new androidx.transition.TransitionHashSet();
        transitionHashSet.addTransition((androidx.transition.Transition) obj);
        return transitionHashSet;
    }
}

