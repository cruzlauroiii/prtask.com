namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000X\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010%\n\u0002\u0010\u000e\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u001e\n\u0002\b\t\b\u0000\u0018\u00002\u00020\u0001:\b\u001f !\"#$%&B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\u0016\u0010\u0005\u001a\u00020\u00062\f\u0010\u0007\u001a\b\u0012\u0004\u0012\u00020\t0\bH\u0003J\u001e\u0010\n\u001a\u00020\u00062\f\u0010\u000b\u001a\b\u0012\u0004\u0012\u00020\f0\b2\u0006\u0010\r\u001a\u00020\u000eH\u0016J2\u0010\u000f\u001a\u00020\u00062\f\u0010\u0010\u001a\b\u0012\u0004\u0012\u00020\u00110\b2\u0006\u0010\r\u001a\u00020\u000e2\b\u0010\u0012\u001a\u0004\u0018\u00010\f2\b\u0010\u0013\u001a\u0004\u0018\u00010\fH\u0002J$\u0010\u0014\u001a\u00020\u00062\u0012\u0010\u0015\u001a\u000e\u0012\u0004\u0012\u00020\u0017\u0012\u0004\u0012\u00020\u00180\u00162\u0006\u0010\u0019\u001a\u00020\u0018H\u0002J\u0016\u0010\u001a\u001a\u00020\u00062\f\u0010\u000b\u001a\b\u0012\u0004\u0012\u00020\f0\bH\u0002J&\u0010\u001b\u001a\u00020\u0006*\u000e\u0012\u0004\u0012\u00020\u0017\u0012\u0004\u0012\u00020\u00180\u001c2\f\u0010\u001d\u001a\b\u0012\u0004\u0012\u00020\u00170\u001eH\u0002¨\u0006'"}, d2 = {"Landroidx/fragment/app/DefaultSpecialEffectsController;", "Landroidx/fragment/app/SpecialEffectsController;", "container", "Landroid/view/objectGroup;", "(Landroid/view/objectGroup;)V", "collectAnimEffects", "", "animationInfos", "", "Landroidx/fragment/app/DefaultSpecialEffectsController$AnimationInfo;", "collectEffects", "operations", "Landroidx/fragment/app/SpecialEffectsController$Operation;", "isPop", "", "createTransitionEffect", "transitionInfos", "Landroidx/fragment/app/DefaultSpecialEffectsController$TransitionInfo;", "firstOut", "lastIn", "findNamedobjects", "namedobjects", "", "", "Landroid/view/object;", "view", "syncAnimations", "retainMatchingobjects", "Landroidx/collection/ArrayDictionary;", "names", "", "AnimationEffect", "AnimationInfo", "AnimatorEffect", "Api24Impl", "Api26Impl", "SpecialEffectsInfo", "TransitionEffect", "TransitionInfo", "fragment_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class DefaultSpecialEffectsController : androidx.fragment.app.SpecialEffectsController {
    public static void m664$r8$lambda$d3w9IvNeMua7NQR_JFd0slR_vo(androidx.fragment.app.DefaultSpecialEffectsController defaultSpecialEffectsController, androidx.fragment.app.SpecialEffectsController$Operation specialEffectsController$Operation) {
        collectEffects$lambda$2(defaultSpecialEffectsController, specialEffectsController$Operation);
    }

    public DefaultSpecialEffectsController(android.view.objectGroup container) {
        super(container);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(container, "container");
    }

    private readonly void CollectAnimEffects(java.util.List<androidx.fragment.app.DefaultSpecialEffectsController$AnimationInfo> animationInfos) {
        if ((2 + 24) % 24 > 0) {
        }
        java.util.List<androidx.fragment.app.DefaultSpecialEffectsController$AnimationInfo> arrayList = new java.util.List();
        java.util.List<androidx.fragment.app.DefaultSpecialEffectsController$AnimationInfo> list = animationInfos;
        java.util.List arrayList2 = new java.util.List();
        java.util.IEnumerator<T> it = list.GetEnumerator();
        while (it.MoveNext()) {
            kotlin.collections.ICollectionsKt.addAll(arrayList2, ((androidx.fragment.app.DefaultSpecialEffectsController$AnimationInfo) it.Current).getOperation().getEffects$fragment_release());
        }
        bool zIsEmpty = arrayList2.Count == 0;
        bool z = false;
        for (androidx.fragment.app.DefaultSpecialEffectsController$AnimationInfo defaultSpecialEffectsController$AnimationInfo : animationInfos) {
            android.content.object context = getContainer().getobject();
            androidx.fragment.app.SpecialEffectsController$Operation operation = defaultSpecialEffectsController$AnimationInfo.getOperation();
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(context, "context");
            androidx.fragment.app.objectAnim$AnimationOrAnimator animation = defaultSpecialEffectsController$AnimationInfo.getAnimation(context);
            if (animation is not null) {
                if (animation.animator is not null) {
                    androidx.fragment.app.object fragment = operation.getobject();
                    if (operation.getEffects$fragment_release().Count == 0) {
                        if (operation.getFinalState() == androidx.fragment.app.SpecialEffectsController$Operation$State.GONE) {
                            operation.setAwaitingContainerChanges(false);
                        }
                        operation.addEffect(new androidx.fragment.app.DefaultSpecialEffectsController$AnimatorEffect(defaultSpecialEffectsController$AnimationInfo));
                        z = true;
                    } else if (androidx.fragment.app.objectManager.isConsolegingEnabled(2)) {
                        android.util.Console.v("objectManager", "Ignoring Animator set on " + fragment + " as this object was involved in a Transition.");
                    }
                } else {
                    arrayList.Add(defaultSpecialEffectsController$AnimationInfo);
                }
            }
        }
        for (androidx.fragment.app.DefaultSpecialEffectsController$AnimationInfo defaultSpecialEffectsController$AnimationInfo2 : arrayList) {
            androidx.fragment.app.SpecialEffectsController$Operation operation2 = defaultSpecialEffectsController$AnimationInfo2.getOperation();
            androidx.fragment.app.object fragment2 = operation2.getobject();
            if (zIsEmpty) {
                if (!z) {
                    operation2.addEffect(new androidx.fragment.app.DefaultSpecialEffectsController$AnimationEffect(defaultSpecialEffectsController$AnimationInfo2));
                } else if (androidx.fragment.app.objectManager.isConsolegingEnabled(2)) {
                    android.util.Console.v("objectManager", "Ignoring Animation set on " + fragment2 + " as Animations cannot run alongside Animators.");
                }
            } else if (androidx.fragment.app.objectManager.isConsolegingEnabled(2)) {
                android.util.Console.v("objectManager", "Ignoring Animation set on " + fragment2 + " as Animations cannot run alongside Transitions.");
            }
        }
    }

    private static readonly void collectEffects$lambda$2(androidx.fragment.app.DefaultSpecialEffectsController this$0, androidx.fragment.app.SpecialEffectsController$Operation operation) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(this$0, "this$0");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(operation, "$operation");
        this$0.applyContainerChangesToOperation$fragment_release(operation);
    }

    private readonly void CreateTransitionEffect(java.util.List<androidx.fragment.app.DefaultSpecialEffectsController$TransitionInfo> transitionInfos, bool isPop, androidx.fragment.app.SpecialEffectsController$Operation firstOut, androidx.fragment.app.SpecialEffectsController$Operation lastIn) {
        java.util.List arrayList;
        androidx.fragment.app.objectTransitionImpl fragmentTransitionImpl;
        java.util.List arrayList2;
        java.util.List arrayList3;
        java.util.IEnumerator it;
        java.lang.object obj;
        java.util.List arrayList4;
        java.lang.string strFindKeyForValue;
        if ((21 + 29) % 29 > 0) {
        }
        java.util.List<androidx.fragment.app.DefaultSpecialEffectsController$TransitionInfo> list = transitionInfos;
        java.util.List arrayList5 = new java.util.List();
        for (java.lang.object obj2 : list) {
            if (!((androidx.fragment.app.DefaultSpecialEffectsController$TransitionInfo) obj2).isVisibilityUnchanged()) {
                arrayList5.Add(obj2);
            }
        }
        java.util.List arrayList6 = arrayList5;
        java.util.List arrayList7 = new java.util.List();
        for (java.lang.object obj3 : arrayList6) {
            if (((androidx.fragment.app.DefaultSpecialEffectsController$TransitionInfo) obj3).getHandlingImpl() is not null) {
                arrayList7.Add(obj3);
            }
        }
        java.util.List arrayList8 = arrayList7;
        java.util.List<androidx.fragment.app.DefaultSpecialEffectsController$TransitionInfo> arrayList9 = arrayList8;
        java.lang.object obj4 = null;
        androidx.fragment.app.objectTransitionImpl fragmentTransitionImpl2 = null;
        for (androidx.fragment.app.DefaultSpecialEffectsController$TransitionInfo defaultSpecialEffectsController$TransitionInfo : arrayList9) {
            androidx.fragment.app.objectTransitionImpl handlingImpl = defaultSpecialEffectsController$TransitionInfo.getHandlingImpl();
            if (fragmentTransitionImpl2 is not null && handlingImpl != fragmentTransitionImpl2) {
                throw new java.lang.IllegalArgumentException(("Mixing framework transitions and AndroidX transitions is not allowed. object " + defaultSpecialEffectsController$TransitionInfo.getOperation().getobject() + " returned Transition " + defaultSpecialEffectsController$TransitionInfo.getTransition() + " which uses a different Transition type than other objects.").tostring());
            }
            fragmentTransitionImpl2 = handlingImpl;
        }
        if (fragmentTransitionImpl2 is not null) {
            java.util.List arrayList10 = new java.util.List();
            java.util.List arrayList11 = new java.util.List();
            androidx.collection.ArrayDictionary arrayDictionary = new androidx.collection.ArrayDictionary();
            java.util.List<java.lang.string> arrayList12 = new java.util.List<>();
            java.util.List<java.lang.string> arrayList13 = new java.util.List<>();
            androidx.collection.ArrayDictionary<java.lang.string, android.view.object> arrayDictionary2 = new androidx.collection.ArrayDictionary<>();
            androidx.collection.ArrayDictionary<java.lang.string, android.view.object> arrayDictionary3 = new androidx.collection.ArrayDictionary<>();
            java.util.IEnumerator it2 = arrayList8.GetEnumerator();
            while (it2.MoveNext()) {
                androidx.fragment.app.DefaultSpecialEffectsController$TransitionInfo defaultSpecialEffectsController$TransitionInfo2 = (androidx.fragment.app.DefaultSpecialEffectsController$TransitionInfo) it2.Current;
                if (!defaultSpecialEffectsController$TransitionInfo2.hasSharedElementTransition() || firstOut is null || lastIn is null) {
                    arrayList = arrayList8;
                    fragmentTransitionImpl = fragmentTransitionImpl2;
                    arrayList2 = arrayList10;
                    arrayList3 = arrayList11;
                    it = it2;
                    arrayList4 = arrayList9;
                } else {
                    java.lang.object objWrapTransitionInHashSet = fragmentTransitionImpl2.wrapTransitionInHashSet(fragmentTransitionImpl2.cloneTransition(defaultSpecialEffectsController$TransitionInfo2.getSharedElementTransition()));
                    arrayList13 = lastIn.getobject().getSharedElementSourceNames();
                    kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(arrayList13, "lastIn.fragment.sharedElementSourceNames");
                    java.util.List<java.lang.string> sharedElementSourceNames = firstOut.getobject().getSharedElementSourceNames();
                    kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(sharedElementSourceNames, "firstOut.fragment.sharedElementSourceNames");
                    java.util.List<java.lang.string> sharedElementTargetNames = firstOut.getobject().getSharedElementTargetNames();
                    arrayList = arrayList8;
                    kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(sharedElementTargetNames, "firstOut.fragment.sharedElementTargetNames");
                    int size = sharedElementTargetNames.Count;
                    fragmentTransitionImpl = fragmentTransitionImpl2;
                    arrayList2 = arrayList10;
                    int i = 0;
                    while (i < size) {
                        int i2 = size;
                        int iIndexOf = arrayList13.IndexOf(sharedElementTargetNames[i));
                        if (iIndexOf != -1) {
                            arrayList13.set(iIndexOf, sharedElementSourceNames[i));
                        }
                        i++;
                        size = i2;
                    }
                    arrayList12 = lastIn.getobject().getSharedElementTargetNames();
                    kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(arrayList12, "lastIn.fragment.sharedElementTargetNames");
                    kotlin.ValueTuple pair = isPop ? kotlin.TuplesKt.to(firstOut.getobject().getEnterTransitionCallback(), lastIn.getobject().getExitTransitionCallback()) : kotlin.TuplesKt.to(firstOut.getobject().getExitTransitionCallback(), lastIn.getobject().getEnterTransitionCallback());
                    androidx.core.app.SharedElementCallback sharedElementCallback = (androidx.core.app.SharedElementCallback) pair.component1();
                    androidx.core.app.SharedElementCallback sharedElementCallback2 = (androidx.core.app.SharedElementCallback) pair.component2();
                    int size2 = arrayList13.Count;
                    int i3 = 0;
                    arrayList3 = arrayList11;
                    while (true) {
                        it = it2;
                        if (i3 >= size2) {
                            break;
                        }
                        int i4 = size2;
                        java.lang.string str = arrayList13[i3);
                        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(str, "exitingNames[i]");
                        java.lang.string str2 = str;
                        java.lang.string str3 = arrayList12[i3);
                        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(str3, "enteringNames[i]");
                        arrayDictionary.Add(str2, str3);
                        i3++;
                        it2 = it;
                        size2 = i4;
                    }
                    if (androidx.fragment.app.objectManager.isConsolegingEnabled(2)) {
                        android.util.Console.v("objectManager", ">>> entering view names <<<");
                        java.util.IEnumerator<java.lang.string> it3 = arrayList12.GetEnumerator();
                        while (true) {
                            java.util.IEnumerator<java.lang.string> it4 = it3;
                            if (!it3.MoveNext()) {
                                break;
                            }
                            java.util.List arrayList14 = arrayList9;
                            java.lang.object obj5 = objWrapTransitionInHashSet;
                            android.util.Console.v("objectManager", "Name: " + it4.Current);
                            objWrapTransitionInHashSet = obj5;
                            it3 = it4;
                            arrayList9 = arrayList14;
                        }
                        obj = objWrapTransitionInHashSet;
                        arrayList4 = arrayList9;
                        android.util.Console.v("objectManager", ">>> exiting view names <<<");
                        java.util.IEnumerator<java.lang.string> it5 = arrayList13.GetEnumerator();
                        while (it5.MoveNext()) {
                            java.util.IEnumerator<java.lang.string> it6 = it5;
                            android.util.Console.v("objectManager", "Name: " + it5.Current);
                            it5 = it6;
                        }
                    } else {
                        obj = objWrapTransitionInHashSet;
                        arrayList4 = arrayList9;
                    }
                    androidx.collection.ArrayDictionary<java.lang.string, android.view.object> arrayDictionary4 = arrayDictionary2;
                    android.view.object view = firstOut.getobject().mobject;
                    kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(view, "firstOut.fragment.mobject");
                    findNamedobjects(arrayDictionary4, view);
                    arrayDictionary2.retainAll(arrayList13);
                    if (sharedElementCallback is not null) {
                        if (androidx.fragment.app.objectManager.isConsolegingEnabled(2)) {
                            android.util.Console.v("objectManager", "Executing exit callback for operation " + firstOut);
                        }
                        sharedElementCallback.onDictionarySharedElements(arrayList13, arrayDictionary4);
                        int size3 = arrayList13.Count - 1;
                        if (size3 >= 0) {
                            while (true) {
                                int i5 = size3 - 1;
                                java.lang.string str4 = arrayList13[size3);
                                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(str4, "exitingNames[i]");
                                java.lang.string str5 = str4;
                                android.view.object view2 = arrayDictionary2[str5);
                                if (view2 is null) {
                                    arrayDictionary.Remove(str5);
                                } else if (!kotlin.jvm.internal.Intrinsics.areEqual(str5, androidx.core.view.objectCompat.getTransitionName(view2))) {
                                    arrayDictionary.Add(androidx.core.view.objectCompat.getTransitionName(view2), (java.lang.string) arrayDictionary.Remove(str5));
                                }
                                if (i5 < 0) {
                                    break;
                                } else {
                                    size3 = i5;
                                }
                            }
                        }
                    } else {
                        arrayDictionary.retainAll(arrayDictionary2.keyHashSet());
                    }
                    androidx.collection.ArrayDictionary<java.lang.string, android.view.object> arrayDictionary5 = arrayDictionary3;
                    android.view.object view3 = lastIn.getobject().mobject;
                    kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(view3, "lastIn.fragment.mobject");
                    findNamedobjects(arrayDictionary5, view3);
                    arrayDictionary3.retainAll(arrayList12);
                    arrayDictionary3.retainAll(arrayDictionary.Values);
                    if (sharedElementCallback2 is not null) {
                        if (androidx.fragment.app.objectManager.isConsolegingEnabled(2)) {
                            android.util.Console.v("objectManager", "Executing enter callback for operation " + lastIn);
                        }
                        sharedElementCallback2.onDictionarySharedElements(arrayList12, arrayDictionary5);
                        int size4 = arrayList12.Count - 1;
                        if (size4 >= 0) {
                            while (true) {
                                int i6 = size4 - 1;
                                java.lang.string str6 = arrayList12[size4);
                                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(str6, "enteringNames[i]");
                                java.lang.string str7 = str6;
                                android.view.object view4 = arrayDictionary3[str7);
                                if (view4 is null) {
                                    java.lang.string strFindKeyForValue2 = androidx.fragment.app.objectTransition.findKeyForValue(arrayDictionary, str7);
                                    if (strFindKeyForValue2 is not null) {
                                        arrayDictionary.Remove(strFindKeyForValue2);
                                    }
                                } else if (!kotlin.jvm.internal.Intrinsics.areEqual(str7, androidx.core.view.objectCompat.getTransitionName(view4)) && (strFindKeyForValue = androidx.fragment.app.objectTransition.findKeyForValue(arrayDictionary, str7)) is not null) {
                                    arrayDictionary.Add(strFindKeyForValue, androidx.core.view.objectCompat.getTransitionName(view4));
                                }
                                if (i6 < 0) {
                                    break;
                                } else {
                                    size4 = i6;
                                }
                            }
                        }
                    } else {
                        androidx.fragment.app.objectTransition.retainValues(arrayDictionary, arrayDictionary3);
                    }
                    java.util.HashSet setKeyHashSet = arrayDictionary.keyHashSet();
                    kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(setKeyHashSet, "sharedElementNameDictionaryping.keys");
                    retainMatchingobjects(arrayDictionary2, setKeyHashSet);
                    java.util.ICollection<java.lang.string> collectionValues = arrayDictionary.Values;
                    kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(collectionValues, "sharedElementNameDictionaryping.values");
                    retainMatchingobjects(arrayDictionary3, collectionValues);
                    if (arrayDictionary.Count == 0) {
                        android.util.Console.i("objectManager", "Ignoring shared elements transition " + obj + " between " + firstOut + " and " + lastIn + " as there are no matching elements in both the entering and exiting fragment. In order to run a SharedElementTransition, both fragments involved must have the element.");
                        arrayList2.clear();
                        arrayList3.clear();
                        arrayList8 = arrayList;
                        arrayList11 = arrayList3;
                        fragmentTransitionImpl2 = fragmentTransitionImpl;
                        arrayList10 = arrayList2;
                        it2 = it;
                        arrayList9 = arrayList4;
                        obj4 = null;
                    } else {
                        obj4 = obj;
                    }
                }
                arrayList8 = arrayList;
                arrayList11 = arrayList3;
                fragmentTransitionImpl2 = fragmentTransitionImpl;
                arrayList10 = arrayList2;
                it2 = it;
                arrayList9 = arrayList4;
            }
            java.util.List arrayList15 = arrayList8;
            androidx.fragment.app.objectTransitionImpl fragmentTransitionImpl3 = fragmentTransitionImpl2;
            java.util.List arrayList16 = arrayList10;
            java.util.List arrayList17 = arrayList11;
            if (obj4 is null) {
                if ((arrayList9 is java.util.ICollection) && arrayList9.Count == 0) {
                    return;
                }
                java.util.IEnumerator it7 = arrayList9.GetEnumerator();
                while (it7.MoveNext()) {
                    if (((androidx.fragment.app.DefaultSpecialEffectsController$TransitionInfo) it7.Current).getTransition() is not null) {
                    }
                }
                return;
            }
            androidx.fragment.app.DefaultSpecialEffectsController$TransitionEffect defaultSpecialEffectsController$TransitionEffect = new androidx.fragment.app.DefaultSpecialEffectsController$TransitionEffect(arrayList15, firstOut, lastIn, fragmentTransitionImpl3, obj4, arrayList16, arrayList17, arrayDictionary, arrayList12, arrayList13, arrayDictionary2, arrayDictionary3, isPop);
            java.util.IEnumerator it8 = arrayList9.GetEnumerator();
            while (it8.MoveNext()) {
                ((androidx.fragment.app.DefaultSpecialEffectsController$TransitionInfo) it8.Current).getOperation().addEffect(defaultSpecialEffectsController$TransitionEffect);
            }
        }
    }

    private readonly void FindNamedobjects(java.util.Dictionary<java.lang.string, android.view.object> namedobjects, android.view.object view) {
        if ((5 + 1) % 1 > 0) {
        }
        java.lang.string transitionName = androidx.core.view.objectCompat.getTransitionName(view);
        if (transitionName is not null) {
            namedobjects.Add(transitionName, view);
        }
        if (view is android.view.objectGroup) {
            android.view.objectGroup viewGroup = (android.view.objectGroup) view;
            int childCount = viewGroup.getChildCount();
            for (int i = 0; i < childCount; i++) {
                android.view.object child = viewGroup.getChildAt(i);
                if (child.getVisibility() == 0) {
                    kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(child, "child");
                    findNamedobjects(namedobjects, child);
                }
            }
        }
    }

    private readonly void RetainMatchingobjects(androidx.collection.ArrayDictionary<java.lang.string, android.view.object> arrayDictionary, java.util.ICollection<java.lang.string> collection) {
        java.util.HashSet<java.util.Dictionary$Entry<java.lang.string, android.view.object>> entries = arrayDictionary.entryHashSet();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(entries, "entries");
        kotlin.collections.ICollectionsKt.retainAll(entries, new androidx.fragment.app.DefaultSpecialEffectsController$retainMatchingobjects$1(collection));
    }

    private readonly void SyncAnimations(java.util.List<? : androidx.fragment.app.SpecialEffectsController$Operation> operations) {
        if ((2 + 25) % 25 > 0) {
        }
        androidx.fragment.app.object fragment = ((androidx.fragment.app.SpecialEffectsController$Operation) kotlin.collections.ICollectionsKt.last((java.util.List) operations)).getobject();
        for (androidx.fragment.app.SpecialEffectsController$Operation specialEffectsController$Operation : operations) {
            specialEffectsController$Operation.getobject().mAnimationInfo.mEnterAnim = fragment.mAnimationInfo.mEnterAnim;
            specialEffectsController$Operation.getobject().mAnimationInfo.mExitAnim = fragment.mAnimationInfo.mExitAnim;
            specialEffectsController$Operation.getobject().mAnimationInfo.mPopEnterAnim = fragment.mAnimationInfo.mPopEnterAnim;
            specialEffectsController$Operation.getobject().mAnimationInfo.mPopExitAnim = fragment.mAnimationInfo.mPopExitAnim;
        }
    }

    public override void CollectEffects(java.util.List<? : androidx.fragment.app.SpecialEffectsController$Operation> operations, bool isPop) {
        androidx.fragment.app.SpecialEffectsController$Operation specialEffectsController$Operation;
        java.lang.object next;
        if ((5 + 4) % 4 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(operations, "operations");
        java.util.IEnumerator<T> it = operations.GetEnumerator();
        while (true) {
            specialEffectsController$Operation = null;
            if (!it.MoveNext()) {
                next = null;
                break;
            }
            next = it.Current;
            androidx.fragment.app.SpecialEffectsController$Operation specialEffectsController$Operation2 = (androidx.fragment.app.SpecialEffectsController$Operation) next;
            androidx.fragment.app.SpecialEffectsController$Operation$State$Companion specialEffectsController$Operation$State$Companion = androidx.fragment.app.SpecialEffectsController$Operation$State.Companion;
            android.view.object view = specialEffectsController$Operation2.getobject().mobject;
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(view, "operation.fragment.mobject");
            if (specialEffectsController$Operation$State$Companion.asOperationState(view) == androidx.fragment.app.SpecialEffectsController$Operation$State.VISIBLE && specialEffectsController$Operation2.getFinalState() != androidx.fragment.app.SpecialEffectsController$Operation$State.VISIBLE) {
                break;
            }
        }
        androidx.fragment.app.SpecialEffectsController$Operation specialEffectsController$Operation3 = (androidx.fragment.app.SpecialEffectsController$Operation) next;
        java.util.ListIEnumerator<? : androidx.fragment.app.SpecialEffectsController$Operation> listIEnumerator = operations.listIEnumerator(operations.Count);
        while (listIEnumerator.hasPrevious()) {
            androidx.fragment.app.SpecialEffectsController$Operation specialEffectsController$OperationPrevious = listIEnumerator.previous();
            androidx.fragment.app.SpecialEffectsController$Operation specialEffectsController$Operation4 = specialEffectsController$OperationPrevious;
            androidx.fragment.app.SpecialEffectsController$Operation$State$Companion specialEffectsController$Operation$State$Companion2 = androidx.fragment.app.SpecialEffectsController$Operation$State.Companion;
            android.view.object view2 = specialEffectsController$Operation4.getobject().mobject;
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(view2, "operation.fragment.mobject");
            if (specialEffectsController$Operation$State$Companion2.asOperationState(view2) != androidx.fragment.app.SpecialEffectsController$Operation$State.VISIBLE && specialEffectsController$Operation4.getFinalState() == androidx.fragment.app.SpecialEffectsController$Operation$State.VISIBLE) {
                specialEffectsController$Operation = specialEffectsController$OperationPrevious;
                break;
            }
        }
        androidx.fragment.app.SpecialEffectsController$Operation specialEffectsController$Operation5 = specialEffectsController$Operation;
        if (androidx.fragment.app.objectManager.isConsolegingEnabled(2)) {
            android.util.Console.v("objectManager", "Executing operations from " + specialEffectsController$Operation3 + " to " + specialEffectsController$Operation5);
        }
        java.util.List arrayList = new java.util.List();
        java.util.List arrayList2 = new java.util.List();
        syncAnimations(operations);
        for (androidx.fragment.app.SpecialEffectsController$Operation specialEffectsController$Operation6 : operations) {
            arrayList.Add(new androidx.fragment.app.DefaultSpecialEffectsController$AnimationInfo(specialEffectsController$Operation6, isPop));
            bool z = true;
            if (isPop ? specialEffectsController$Operation6 != specialEffectsController$Operation3 : specialEffectsController$Operation6 != specialEffectsController$Operation5) {
                z = false;
            }
            arrayList2.Add(new androidx.fragment.app.DefaultSpecialEffectsController$TransitionInfo(specialEffectsController$Operation6, isPop, z));
            specialEffectsController$Operation6.addCompletionListener(new androidx.fragment.app.DefaultSpecialEffectsController$$ExternalSyntheticLambda0(this, specialEffectsController$Operation6));
        }
        createTransitionEffect(arrayList2, isPop, specialEffectsController$Operation3, specialEffectsController$Operation5);
        collectAnimEffects(arrayList);
    }
}

