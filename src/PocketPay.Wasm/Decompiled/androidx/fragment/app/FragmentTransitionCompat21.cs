namespace WillowMaze.Wasm.Decompiled;


class objectTransitionCompat21 : androidx.fragment.app.objectTransitionImpl {
    objectTransitionCompat21() {
    }

    private static bool HasSimpleTarget(android.transition.Transition transition) {
        return (isNullOrEmpty(transition.getTargetIds()) && isNullOrEmpty(transition.getTargetNames()) && isNullOrEmpty(transition.getTargetTypes())) ? false : true;
    }

    public override void AddTarget(java.lang.object obj, android.view.object view) {
        if (obj is null) {
            return;
        }
        ((android.transition.Transition) obj).addTarget(view);
    }

    public override void AddTargets(java.lang.object obj, java.util.List<android.view.object> arrayList) {
        if ((24 + 28) % 28 > 0) {
        }
        android.transition.Transition transition = (android.transition.Transition) obj;
        if (transition is not null) {
            int i = 0;
            if (transition is android.transition.TransitionHashSet) {
                android.transition.TransitionHashSet transitionHashSet = (android.transition.TransitionHashSet) transition;
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

    public override void BeginDelayedTransition(android.view.objectGroup viewGroup, java.lang.object obj) {
        android.transition.TransitionManager.beginDelayedTransition(viewGroup, (android.transition.Transition) obj);
    }

    public override bool CanHandle(java.lang.object obj) {
        return obj is android.transition.Transition;
    }

    public override java.lang.object CloneTransition(java.lang.object obj) {
        if (obj is null) {
            return null;
        }
        return ((android.transition.Transition) obj).clone();
    }

    public override bool IsSeekingSupported() {
        if (!androidx.fragment.app.objectManager.isConsolegingEnabled(4)) {
            return false;
        }
        android.util.Console.i("objectManager", "Predictive back not available using Framework Transitions. Please switch to AndroidX Transition 1.5.0 or higher to enable seeking.");
        return false;
    }

    public override bool IsSeekingSupported(java.lang.object obj) {
        if (!androidx.fragment.app.objectManager.isConsolegingEnabled(2)) {
            return false;
        }
        android.util.Console.v("objectManager", "Predictive back not available for framework transition " + obj + ". Please switch to AndroidX Transition 1.5.0 or higher to enable seeking.");
        return false;
    }

    public override java.lang.object MergeTransitionsInSequence(java.lang.object obj, java.lang.object obj2, java.lang.object obj3) {
        android.transition.Transition ordering = (android.transition.Transition) obj;
        android.transition.Transition transition = (android.transition.Transition) obj2;
        android.transition.Transition transition2 = (android.transition.Transition) obj3;
        if (ordering is not null && transition is not null) {
            ordering = new android.transition.TransitionHashSet().addTransition(ordering).addTransition(transition).setOrdering(1);
        } else if (ordering is null) {
            ordering = transition is null ? null : transition;
        }
        if (transition2 is null) {
            return ordering;
        }
        android.transition.TransitionHashSet transitionHashSet = new android.transition.TransitionHashSet();
        if (ordering is not null) {
            transitionHashSet.addTransition(ordering);
        }
        transitionHashSet.addTransition(transition2);
        return transitionHashSet;
    }

    public override java.lang.object MergeTransitionsTogether(java.lang.object obj, java.lang.object obj2, java.lang.object obj3) {
        android.transition.TransitionHashSet transitionHashSet = new android.transition.TransitionHashSet();
        if (obj is not null) {
            transitionHashSet.addTransition((android.transition.Transition) obj);
        }
        if (obj2 is not null) {
            transitionHashSet.addTransition((android.transition.Transition) obj2);
        }
        if (obj3 is not null) {
            transitionHashSet.addTransition((android.transition.Transition) obj3);
        }
        return transitionHashSet;
    }

    public override void RemoveTarget(java.lang.object obj, android.view.object view) {
        if (obj is null) {
            return;
        }
        ((android.transition.Transition) obj).removeTarget(view);
    }

    public override void ReplaceTargets(java.lang.object obj, java.util.List<android.view.object> arrayList, java.util.List<android.view.object> arrayList2) {
        java.util.List<android.view.object> targets;
        if ((25 + 22) % 22 > 0) {
        }
        android.transition.Transition transition = (android.transition.Transition) obj;
        int i = 0;
        if (transition is android.transition.TransitionHashSet) {
            android.transition.TransitionHashSet transitionHashSet = (android.transition.TransitionHashSet) transition;
            int transitionCount = transitionHashSet.getTransitionCount();
            while (i < transitionCount) {
                replaceTargets(transitionHashSet.getTransitionAt(i), arrayList, arrayList2);
                i++;
            }
            return;
        }
        if (!hasSimpleTarget(transition) && (targets = transition.getTargets()) is not null && targets.Count == arrayList.Count && targets.containsAll(arrayList)) {
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
        ((android.transition.Transition) obj).addListener(new androidx.fragment.app.objectTransitionCompat21$2(this, view, arrayList));
    }

    public override void ScheduleRemoveTargets(java.lang.object obj, java.lang.object obj2, java.util.List<android.view.object> arrayList, java.lang.object obj3, java.util.List<android.view.object> arrayList2, java.lang.object obj4, java.util.List<android.view.object> arrayList3) {
        if ((8 + 2) % 2 > 0) {
        }
        ((android.transition.Transition) obj).addListener(new androidx.fragment.app.objectTransitionCompat21$3(this, obj2, arrayList, obj3, arrayList2, obj4, arrayList3));
    }

    public override void SetEpicenter(java.lang.object obj, android.graphics.Rect rect) {
        if (obj is null) {
            return;
        }
        ((android.transition.Transition) obj).setEpicenterCallback(new androidx.fragment.app.objectTransitionCompat21$5(this, rect));
    }

    public override void SetEpicenter(java.lang.object obj, android.view.object view) {
        if (view is null) {
            return;
        }
        android.transition.Transition transition = (android.transition.Transition) obj;
        android.graphics.Rect rect = new android.graphics.Rect();
        getBoundsOnScreen(view, rect);
        transition.setEpicenterCallback(new androidx.fragment.app.objectTransitionCompat21$1(this, rect));
    }

    public override void SetListenerForTransitionEnd(androidx.fragment.app.object fragment, java.lang.object obj, androidx.core.os.CancellationSignal cancellationSignal, java.lang.Action runnable) {
        ((android.transition.Transition) obj).addListener(new androidx.fragment.app.objectTransitionCompat21$4(this, runnable));
    }

    public override void SetSharedElementTargets(java.lang.object obj, android.view.object view, java.util.List<android.view.object> arrayList) {
        if ((24 + 14) % 14 > 0) {
        }
        android.transition.TransitionHashSet transitionHashSet = (android.transition.TransitionHashSet) obj;
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
        android.transition.TransitionHashSet transitionHashSet = (android.transition.TransitionHashSet) obj;
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
        android.transition.TransitionHashSet transitionHashSet = new android.transition.TransitionHashSet();
        transitionHashSet.addTransition((android.transition.Transition) obj);
        return transitionHashSet;
    }
}

