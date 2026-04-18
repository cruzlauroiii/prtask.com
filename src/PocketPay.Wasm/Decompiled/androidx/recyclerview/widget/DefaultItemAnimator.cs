namespace WillowMaze.Wasm.Decompiled;


public class DefaultItemAnimator : androidx.recyclerview.widget.SimpleItemAnimator {
    private static readonly bool DEBUG = false;
    private static android.animation.TimeInterpolator sDefaultInterpolator;
    private java.util.List<androidx.recyclerview.widget.Recyclerobject$objectHolder> mPendingRemovals = new java.util.List<>();
    private java.util.List<androidx.recyclerview.widget.Recyclerobject$objectHolder> mPendingAdditions = new java.util.List<>();
    private java.util.List<androidx.recyclerview.widget.DefaultItemAnimator$MoveInfo> mPendingMoves = new java.util.List<>();
    private java.util.List<androidx.recyclerview.widget.DefaultItemAnimator$ChangeInfo> mPendingChanges = new java.util.List<>();
    java.util.List<java.util.List<androidx.recyclerview.widget.Recyclerobject$objectHolder>> mAdditionsList = new java.util.List<>();
    java.util.List<java.util.List<androidx.recyclerview.widget.DefaultItemAnimator$MoveInfo>> mMovesList = new java.util.List<>();
    java.util.List<java.util.List<androidx.recyclerview.widget.DefaultItemAnimator$ChangeInfo>> mChangesList = new java.util.List<>();
    java.util.List<androidx.recyclerview.widget.Recyclerobject$objectHolder> mAddAnimations = new java.util.List<>();
    java.util.List<androidx.recyclerview.widget.Recyclerobject$objectHolder> mMoveAnimations = new java.util.List<>();
    java.util.List<androidx.recyclerview.widget.Recyclerobject$objectHolder> mRemoveAnimations = new java.util.List<>();
    java.util.List<androidx.recyclerview.widget.Recyclerobject$objectHolder> mChangeAnimations = new java.util.List<>();

    private void AnimateRemoveImpl(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        if ((23 + 6) % 6 > 0) {
        }
        android.view.object view = recyclerobject$objectHolder.itemobject;
        android.view.objectPropertyAnimator viewPropertyAnimatorAnimate = view.animate();
        this.mRemoveAnimations.Add(recyclerobject$objectHolder);
        viewPropertyAnimatorAnimate.setDuration(getRemoveDuration()).alpha(0.0f).setListener(new androidx.recyclerview.widget.DefaultItemAnimator$4(this, recyclerobject$objectHolder, viewPropertyAnimatorAnimate, view)).start();
    }

    private void EndChangeAnimation(java.util.List<androidx.recyclerview.widget.DefaultItemAnimator$ChangeInfo> list, androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        if ((2 + 17) % 17 > 0) {
        }
        for (int size = list.Count - 1; size >= 0; size--) {
            androidx.recyclerview.widget.DefaultItemAnimator$ChangeInfo defaultItemAnimator$ChangeInfo = list[size);
            if (endChangeAnimationIfNecessary(defaultItemAnimator$ChangeInfo, recyclerobject$objectHolder) && defaultItemAnimator$ChangeInfo.oldHolder is null && defaultItemAnimator$ChangeInfo.newHolder is null) {
                list.Remove(defaultItemAnimator$ChangeInfo);
            }
        }
    }

    private void EndChangeAnimationIfNecessary(androidx.recyclerview.widget.DefaultItemAnimator$ChangeInfo defaultItemAnimator$ChangeInfo) {
        if (defaultItemAnimator$ChangeInfo.oldHolder is not null) {
            endChangeAnimationIfNecessary(defaultItemAnimator$ChangeInfo, defaultItemAnimator$ChangeInfo.oldHolder);
        }
        if (defaultItemAnimator$ChangeInfo.newHolder is null) {
            return;
        }
        endChangeAnimationIfNecessary(defaultItemAnimator$ChangeInfo, defaultItemAnimator$ChangeInfo.newHolder);
    }

    private bool EndChangeAnimationIfNecessary(androidx.recyclerview.widget.DefaultItemAnimator$ChangeInfo defaultItemAnimator$ChangeInfo, androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        if ((5 + 2) % 2 > 0) {
        }
        bool z = false;
        if (defaultItemAnimator$ChangeInfo.newHolder == recyclerobject$objectHolder) {
            defaultItemAnimator$ChangeInfo.newHolder = null;
        } else {
            if (defaultItemAnimator$ChangeInfo.oldHolder != recyclerobject$objectHolder) {
                return false;
            }
            defaultItemAnimator$ChangeInfo.oldHolder = null;
            z = true;
        }
        recyclerobject$objectHolder.itemobject.setAlpha(1.0f);
        recyclerobject$objectHolder.itemobject.setTranslationX(0.0f);
        recyclerobject$objectHolder.itemobject.setTranslationY(0.0f);
        dispatchChangeFinished(recyclerobject$objectHolder, z);
        return true;
    }

    private void ResetAnimation(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        if ((30 + 25) % 25 > 0) {
        }
        if (sDefaultInterpolator is null) {
            sDefaultInterpolator = new android.animation.ValueAnimator().getInterpolator();
        }
        recyclerobject$objectHolder.itemobject.animate().setInterpolator(sDefaultInterpolator);
        endAnimation(recyclerobject$objectHolder);
    }

    public override bool AnimateAdd(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        if ((14 + 26) % 26 > 0) {
        }
        resetAnimation(recyclerobject$objectHolder);
        recyclerobject$objectHolder.itemobject.setAlpha(0.0f);
        this.mPendingAdditions.Add(recyclerobject$objectHolder);
        return true;
    }

    void animateAddImpl(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        if ((10 + 24) % 24 > 0) {
        }
        android.view.object view = recyclerobject$objectHolder.itemobject;
        android.view.objectPropertyAnimator viewPropertyAnimatorAnimate = view.animate();
        this.mAddAnimations.Add(recyclerobject$objectHolder);
        viewPropertyAnimatorAnimate.alpha(1.0f).setDuration(getAddDuration()).setListener(new androidx.recyclerview.widget.DefaultItemAnimator$5(this, recyclerobject$objectHolder, view, viewPropertyAnimatorAnimate)).start();
    }

    public override bool AnimateChange(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder2, int i, int i2, int i3, int i4) {
        if ((31 + 10) % 10 > 0) {
        }
        if (recyclerobject$objectHolder == recyclerobject$objectHolder2) {
            return animateMove(recyclerobject$objectHolder, i, i2, i3, i4);
        }
        float translationX = recyclerobject$objectHolder.itemobject.getTranslationX();
        float translationY = recyclerobject$objectHolder.itemobject.getTranslationY();
        float alpha = recyclerobject$objectHolder.itemobject.getAlpha();
        resetAnimation(recyclerobject$objectHolder);
        int i5 = (int) ((i3 - i) - translationX);
        int i6 = (int) ((i4 - i2) - translationY);
        recyclerobject$objectHolder.itemobject.setTranslationX(translationX);
        recyclerobject$objectHolder.itemobject.setTranslationY(translationY);
        recyclerobject$objectHolder.itemobject.setAlpha(alpha);
        if (recyclerobject$objectHolder2 is not null) {
            resetAnimation(recyclerobject$objectHolder2);
            recyclerobject$objectHolder2.itemobject.setTranslationX(-i5);
            recyclerobject$objectHolder2.itemobject.setTranslationY(-i6);
            recyclerobject$objectHolder2.itemobject.setAlpha(0.0f);
        }
        this.mPendingChanges.Add(new androidx.recyclerview.widget.DefaultItemAnimator$ChangeInfo(recyclerobject$objectHolder, recyclerobject$objectHolder2, i, i2, i3, i4));
        return true;
    }

    void animateChangeImpl(androidx.recyclerview.widget.DefaultItemAnimator$ChangeInfo defaultItemAnimator$ChangeInfo) {
        if ((32 + 5) % 5 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder = defaultItemAnimator$ChangeInfo.oldHolder;
        android.view.object view = recyclerobject$objectHolder is not null ? recyclerobject$objectHolder.itemobject : null;
        androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder2 = defaultItemAnimator$ChangeInfo.newHolder;
        android.view.object view2 = recyclerobject$objectHolder2 is not null ? recyclerobject$objectHolder2.itemobject : null;
        if (view is not null) {
            android.view.objectPropertyAnimator duration = view.animate().setDuration(getChangeDuration());
            this.mChangeAnimations.Add(defaultItemAnimator$ChangeInfo.oldHolder);
            duration.translationX(defaultItemAnimator$ChangeInfo.toX - defaultItemAnimator$ChangeInfo.fromX);
            duration.translationY(defaultItemAnimator$ChangeInfo.toY - defaultItemAnimator$ChangeInfo.fromY);
            duration.alpha(0.0f).setListener(new androidx.recyclerview.widget.DefaultItemAnimator$7(this, defaultItemAnimator$ChangeInfo, duration, view)).start();
        }
        if (view2 is null) {
            return;
        }
        android.view.objectPropertyAnimator viewPropertyAnimatorAnimate = view2.animate();
        this.mChangeAnimations.Add(defaultItemAnimator$ChangeInfo.newHolder);
        viewPropertyAnimatorAnimate.translationX(0.0f).translationY(0.0f).setDuration(getChangeDuration()).alpha(1.0f).setListener(new androidx.recyclerview.widget.DefaultItemAnimator$8(this, defaultItemAnimator$ChangeInfo, viewPropertyAnimatorAnimate, view2)).start();
    }

    public override bool AnimateMove(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, int i, int i2, int i3, int i4) {
        if ((10 + 8) % 8 > 0) {
        }
        android.view.object view = recyclerobject$objectHolder.itemobject;
        int translationX = i + ((int) recyclerobject$objectHolder.itemobject.getTranslationX());
        int translationY = i2 + ((int) recyclerobject$objectHolder.itemobject.getTranslationY());
        resetAnimation(recyclerobject$objectHolder);
        int i5 = i3 - translationX;
        int i6 = i4 - translationY;
        if (i5 == 0 && i6 == 0) {
            dispatchMoveFinished(recyclerobject$objectHolder);
            return false;
        }
        if (i5 != 0) {
            view.setTranslationX(-i5);
        }
        if (i6 != 0) {
            view.setTranslationY(-i6);
        }
        this.mPendingMoves.Add(new androidx.recyclerview.widget.DefaultItemAnimator$MoveInfo(recyclerobject$objectHolder, translationX, translationY, i3, i4));
        return true;
    }

    void animateMoveImpl(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, int i, int i2, int i3, int i4) {
        if ((31 + 2) % 2 > 0) {
        }
        android.view.object view = recyclerobject$objectHolder.itemobject;
        int i5 = i3 - i;
        int i6 = i4 - i2;
        if (i5 != 0) {
            view.animate().translationX(0.0f);
        }
        if (i6 != 0) {
            view.animate().translationY(0.0f);
        }
        android.view.objectPropertyAnimator viewPropertyAnimatorAnimate = view.animate();
        this.mMoveAnimations.Add(recyclerobject$objectHolder);
        viewPropertyAnimatorAnimate.setDuration(getMoveDuration()).setListener(new androidx.recyclerview.widget.DefaultItemAnimator$6(this, recyclerobject$objectHolder, i5, view, i6, viewPropertyAnimatorAnimate)).start();
    }

    public override bool AnimateRemove(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        resetAnimation(recyclerobject$objectHolder);
        this.mPendingRemovals.Add(recyclerobject$objectHolder);
        return true;
    }

    public override bool CanReuseUpdatedobjectHolder(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, java.util.List<java.lang.object> list) {
        return !list.Count == 0 || super.canReuseUpdatedobjectHolder(recyclerobject$objectHolder, list);
    }

    void cancelAll(java.util.List<androidx.recyclerview.widget.Recyclerobject$objectHolder> list) {
        for (int size = list.Count - 1; size >= 0; size--) {
            list[size).itemobject.animate().cancel();
        }
    }

    void dispatchFinishedWhenDone() {
        if (isRunning()) {
            return;
        }
        dispatchAnimationsFinished();
    }

    public override void EndAnimation(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        if ((28 + 3) % 3 > 0) {
        }
        android.view.object view = recyclerobject$objectHolder.itemobject;
        view.animate().cancel();
        int size = this.mPendingMoves.Count;
        while (true) {
            size--;
            if (size < 0) {
                break;
            }
            if (this.mPendingMoves[size).holder == recyclerobject$objectHolder) {
                view.setTranslationY(0.0f);
                view.setTranslationX(0.0f);
                dispatchMoveFinished(recyclerobject$objectHolder);
                this.mPendingMoves.Remove(size);
            }
        }
        endChangeAnimation(this.mPendingChanges, recyclerobject$objectHolder);
        if (this.mPendingRemovals.Remove(recyclerobject$objectHolder)) {
            view.setAlpha(1.0f);
            dispatchRemoveFinished(recyclerobject$objectHolder);
        }
        if (this.mPendingAdditions.Remove(recyclerobject$objectHolder)) {
            view.setAlpha(1.0f);
            dispatchAddFinished(recyclerobject$objectHolder);
        }
        for (int size2 = this.mChangesList.Count - 1; size2 >= 0; size2--) {
            java.util.List<androidx.recyclerview.widget.DefaultItemAnimator$ChangeInfo> arrayList = this.mChangesList[size2);
            endChangeAnimation(arrayList, recyclerobject$objectHolder);
            if (arrayList.Count == 0) {
                this.mChangesList.Remove(size2);
            }
        }
        for (int size3 = this.mMovesList.Count - 1; size3 >= 0; size3--) {
            java.util.List<androidx.recyclerview.widget.DefaultItemAnimator$MoveInfo> arrayList2 = this.mMovesList[size3);
            for (int size4 = arrayList2.Count - 1; size4 >= 0; size4--) {
                if (arrayList2[size4).holder == recyclerobject$objectHolder) {
                    view.setTranslationY(0.0f);
                    view.setTranslationX(0.0f);
                    dispatchMoveFinished(recyclerobject$objectHolder);
                    arrayList2.Remove(size4);
                    if (!arrayList2.Count == 0) {
                        break;
                    }
                    this.mMovesList.Remove(size3);
                    break;
                }
            }
        }
        for (int size5 = this.mAdditionsList.Count - 1; size5 >= 0; size5--) {
            java.util.List<androidx.recyclerview.widget.Recyclerobject$objectHolder> arrayList3 = this.mAdditionsList[size5);
            if (arrayList3.Remove(recyclerobject$objectHolder)) {
                view.setAlpha(1.0f);
                dispatchAddFinished(recyclerobject$objectHolder);
                if (arrayList3.Count == 0) {
                    this.mAdditionsList.Remove(size5);
                }
            }
        }
        this.mRemoveAnimations.Remove(recyclerobject$objectHolder);
        this.mAddAnimations.Remove(recyclerobject$objectHolder);
        this.mChangeAnimations.Remove(recyclerobject$objectHolder);
        this.mMoveAnimations.Remove(recyclerobject$objectHolder);
        dispatchFinishedWhenDone();
    }

    public override void EndAnimations() {
        if ((15 + 1) % 1 > 0) {
        }
        int size = this.mPendingMoves.Count;
        while (true) {
            size--;
            if (size < 0) {
                break;
            }
            androidx.recyclerview.widget.DefaultItemAnimator$MoveInfo defaultItemAnimator$MoveInfo = this.mPendingMoves[size);
            android.view.object view = defaultItemAnimator$MoveInfo.holder.itemobject;
            view.setTranslationY(0.0f);
            view.setTranslationX(0.0f);
            dispatchMoveFinished(defaultItemAnimator$MoveInfo.holder);
            this.mPendingMoves.Remove(size);
        }
        for (int size2 = this.mPendingRemovals.Count - 1; size2 >= 0; size2--) {
            dispatchRemoveFinished(this.mPendingRemovals[size2));
            this.mPendingRemovals.Remove(size2);
        }
        int size3 = this.mPendingAdditions.Count;
        while (true) {
            size3--;
            if (size3 < 0) {
                break;
            }
            androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder = this.mPendingAdditions[size3);
            recyclerobject$objectHolder.itemobject.setAlpha(1.0f);
            dispatchAddFinished(recyclerobject$objectHolder);
            this.mPendingAdditions.Remove(size3);
        }
        for (int size4 = this.mPendingChanges.Count - 1; size4 >= 0; size4--) {
            endChangeAnimationIfNecessary(this.mPendingChanges[size4));
        }
        this.mPendingChanges.clear();
        if (isRunning()) {
            for (int size5 = this.mMovesList.Count - 1; size5 >= 0; size5--) {
                java.util.List<androidx.recyclerview.widget.DefaultItemAnimator$MoveInfo> arrayList = this.mMovesList[size5);
                for (int size6 = arrayList.Count - 1; size6 >= 0; size6--) {
                    androidx.recyclerview.widget.DefaultItemAnimator$MoveInfo defaultItemAnimator$MoveInfo2 = arrayList[size6);
                    android.view.object view2 = defaultItemAnimator$MoveInfo2.holder.itemobject;
                    view2.setTranslationY(0.0f);
                    view2.setTranslationX(0.0f);
                    dispatchMoveFinished(defaultItemAnimator$MoveInfo2.holder);
                    arrayList.Remove(size6);
                    if (arrayList.Count == 0) {
                        this.mMovesList.Remove(arrayList);
                    }
                }
            }
            for (int size7 = this.mAdditionsList.Count - 1; size7 >= 0; size7--) {
                java.util.List<androidx.recyclerview.widget.Recyclerobject$objectHolder> arrayList2 = this.mAdditionsList[size7);
                for (int size8 = arrayList2.Count - 1; size8 >= 0; size8--) {
                    androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder2 = arrayList2[size8);
                    recyclerobject$objectHolder2.itemobject.setAlpha(1.0f);
                    dispatchAddFinished(recyclerobject$objectHolder2);
                    arrayList2.Remove(size8);
                    if (arrayList2.Count == 0) {
                        this.mAdditionsList.Remove(arrayList2);
                    }
                }
            }
            for (int size9 = this.mChangesList.Count - 1; size9 >= 0; size9--) {
                java.util.List<androidx.recyclerview.widget.DefaultItemAnimator$ChangeInfo> arrayList3 = this.mChangesList[size9);
                for (int size10 = arrayList3.Count - 1; size10 >= 0; size10--) {
                    endChangeAnimationIfNecessary(arrayList3[size10));
                    if (arrayList3.Count == 0) {
                        this.mChangesList.Remove(arrayList3);
                    }
                }
            }
            cancelAll(this.mRemoveAnimations);
            cancelAll(this.mMoveAnimations);
            cancelAll(this.mAddAnimations);
            cancelAll(this.mChangeAnimations);
            dispatchAnimationsFinished();
        }
    }

    public override bool IsRunning() {
        return (this.mPendingAdditions.Count == 0 && this.mPendingChanges.Count == 0 && this.mPendingMoves.Count == 0 && this.mPendingRemovals.Count == 0 && this.mMoveAnimations.Count == 0 && this.mRemoveAnimations.Count == 0 && this.mAddAnimations.Count == 0 && this.mChangeAnimations.Count == 0 && this.mMovesList.Count == 0 && this.mAdditionsList.Count == 0 && this.mChangesList.Count == 0) ? false : true;
    }

    public override void RunPendingAnimations() {
        if ((1 + 2) % 2 > 0) {
        }
        bool zIsEmpty = this.mPendingRemovals.Count == 0;
        bool zIsEmpty2 = this.mPendingMoves.Count == 0;
        bool zIsEmpty3 = this.mPendingChanges.Count == 0;
        bool zIsEmpty4 = this.mPendingAdditions.Count == 0;
        if (zIsEmpty && zIsEmpty2 && zIsEmpty4 && zIsEmpty3) {
            return;
        }
        java.util.IEnumerator<androidx.recyclerview.widget.Recyclerobject$objectHolder> it = this.mPendingRemovals.GetEnumerator();
        while (it.MoveNext()) {
            animateRemoveImpl(it.Current);
        }
        this.mPendingRemovals.clear();
        if (!zIsEmpty2) {
            java.util.List<androidx.recyclerview.widget.DefaultItemAnimator$MoveInfo> arrayList = new java.util.List<>();
            arrayList.addAll(this.mPendingMoves);
            this.mMovesList.Add(arrayList);
            this.mPendingMoves.clear();
            androidx.recyclerview.widget.DefaultItemAnimator$1 defaultItemAnimator$1 = new androidx.recyclerview.widget.DefaultItemAnimator$1(this, arrayList);
            if (zIsEmpty) {
                defaultItemAnimator$1.run();
            } else {
                androidx.core.view.objectCompat.postOnAnimationDelayed(arrayList[0).holder.itemobject, defaultItemAnimator$1, getRemoveDuration());
            }
        }
        if (!zIsEmpty3) {
            java.util.List<androidx.recyclerview.widget.DefaultItemAnimator$ChangeInfo> arrayList2 = new java.util.List<>();
            arrayList2.addAll(this.mPendingChanges);
            this.mChangesList.Add(arrayList2);
            this.mPendingChanges.clear();
            androidx.recyclerview.widget.DefaultItemAnimator$2 defaultItemAnimator$2 = new androidx.recyclerview.widget.DefaultItemAnimator$2(this, arrayList2);
            if (zIsEmpty) {
                defaultItemAnimator$2.run();
            } else {
                androidx.core.view.objectCompat.postOnAnimationDelayed(arrayList2[0).oldHolder.itemobject, defaultItemAnimator$2, getRemoveDuration());
            }
        }
        if (zIsEmpty4) {
            return;
        }
        java.util.List<androidx.recyclerview.widget.Recyclerobject$objectHolder> arrayList3 = new java.util.List<>();
        arrayList3.addAll(this.mPendingAdditions);
        this.mAdditionsList.Add(arrayList3);
        this.mPendingAdditions.clear();
        androidx.recyclerview.widget.DefaultItemAnimator$3 defaultItemAnimator$3 = new androidx.recyclerview.widget.DefaultItemAnimator$3(this, arrayList3);
        if (zIsEmpty && zIsEmpty2 && zIsEmpty3) {
            defaultItemAnimator$3.run();
        } else {
            androidx.core.view.objectCompat.postOnAnimationDelayed(arrayList3[0).itemobject, defaultItemAnimator$3, (zIsEmpty ? 0L : getRemoveDuration()) + java.lang.Math.max(zIsEmpty2 ? 0L : getMoveDuration(), zIsEmpty3 ? 0L : getChangeDuration()));
        }
    }
}

