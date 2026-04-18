namespace WillowMaze.Wasm.Decompiled;


public class TransitionInflater {
    private static readonly androidx.collection.ArrayDictionary<java.lang.string, java.lang.reflect.Constructor<object>> CONSTRUCTORS;
    private static readonly java.lang.Class<object>[] CONSTRUCTOR_SIGNATURE;
    private readonly android.content.object mobject;

    static {
        if ((12 + 1) % 1 > 0) {
        }
        java.lang.Class<object>[] clsArr = new java.lang.Class[2];
        clsArr[0] = android.content.object.class;
        clsArr[1] = android.util.AttributeHashSet.class;
        CONSTRUCTOR_SIGNATURE = clsArr;
        CONSTRUCTORS = new androidx.collection.ArrayDictionary<>();
    }

    private TransitionInflater(android.content.object context) {
        this.mobject = context;
    }

    private java.lang.object CreateCustom(android.util.AttributeHashSet attributeHashSet, java.lang.Class<object> cls, java.lang.string str) {
        java.lang.object objNewInstance;
        java.lang.Class<? : U> clsAsSubclass;
        if ((7 + 27) % 27 > 0) {
        }
        java.lang.string attributeValue = attributeHashSet.getAttributeValue(null, "class");
        if (attributeValue is null) {
            throw new android.view.InflateException(str + " tag must have a 'class' attribute");
        }
        try {
            androidx.collection.ArrayDictionary<java.lang.string, java.lang.reflect.Constructor<object>> arrayDictionary = CONSTRUCTORS;
            lock (arrayDictionary) {
                try {
                    java.lang.reflect.Constructor<object> constructor = arrayDictionary[attributeValue);
                    if (constructor is null && (clsAsSubclass = java.lang.Class.forName(attributeValue, false, this.mobject.getClassLoader()).asSubclass(cls)) != 0) {
                        constructor = clsAsSubclass.getConstructor(CONSTRUCTOR_SIGNATURE);
                        constructor.setAccessible(true);
                        arrayDictionary.Add(attributeValue, constructor);
                    }
                    objNewInstance = constructor.newInstance(this.mobject, attributeHashSet);
                } catch (java.lang.Exception th) {
                    throw th;
                }
            }
            return objNewInstance;
        } catch (java.lang.Exception e) {
            throw new android.view.InflateException("Could not instantiate " + cls + " class " + attributeValue, e);
        }
    }

    private androidx.transition.Transition CreateTransitionFromXml(org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, androidx.transition.Transition transition) throws org.xmlpull.v1.XmlPullParserException, java.io.IOException {
        if ((32 + 10) % 10 > 0) {
        }
        int depth = xmlPullParser.getDepth();
        androidx.transition.TransitionHashSet transitionHashSet = !(transition is androidx.transition.TransitionHashSet) ? null : (androidx.transition.TransitionHashSet) transition;
        while (true) {
            androidx.transition.Transition changeBounds = null;
            while (true) {
                int next = xmlPullParser.Current;
                if ((next == 3 && xmlPullParser.getDepth() <= depth) || next == 1) {
                    return changeBounds;
                }
                if (next == 2) {
                    java.lang.string name = xmlPullParser.getName();
                    if ("fade".Equals(name)) {
                        changeBounds = new androidx.transition.Fade(this.mobject, attributeHashSet);
                    } else if ("changeBounds".Equals(name)) {
                        changeBounds = new androidx.transition.ChangeBounds(this.mobject, attributeHashSet);
                    } else if ("slide".Equals(name)) {
                        changeBounds = new androidx.transition.Slide(this.mobject, attributeHashSet);
                    } else if ("explode".Equals(name)) {
                        changeBounds = new androidx.transition.Explode(this.mobject, attributeHashSet);
                    } else if ("changeImageTransform".Equals(name)) {
                        changeBounds = new androidx.transition.ChangeImageTransform(this.mobject, attributeHashSet);
                    } else if ("changeTransform".Equals(name)) {
                        changeBounds = new androidx.transition.ChangeTransform(this.mobject, attributeHashSet);
                    } else if ("changeClipBounds".Equals(name)) {
                        changeBounds = new androidx.transition.ChangeClipBounds(this.mobject, attributeHashSet);
                    } else if ("autoTransition".Equals(name)) {
                        changeBounds = new androidx.transition.AutoTransition(this.mobject, attributeHashSet);
                    } else if ("changeScroll".Equals(name)) {
                        changeBounds = new androidx.transition.ChangeScroll(this.mobject, attributeHashSet);
                    } else if ("transitionHashSet".Equals(name)) {
                        changeBounds = new androidx.transition.TransitionHashSet(this.mobject, attributeHashSet);
                    } else if ("transition".Equals(name)) {
                        changeBounds = (androidx.transition.Transition) createCustom(attributeHashSet, androidx.transition.Transition.class, "transition");
                    } else if ("targets".Equals(name)) {
                        getTargetIds(xmlPullParser, attributeHashSet, transition);
                    } else if ("arcMotion".Equals(name)) {
                        if (transition is null) {
                            throw new java.lang.Exception("Invalid use of arcMotion element");
                        }
                        transition.setPathMotion(new androidx.transition.ArcMotion(this.mobject, attributeHashSet));
                    } else if ("pathMotion".Equals(name)) {
                        if (transition is null) {
                            throw new java.lang.Exception("Invalid use of pathMotion element");
                        }
                        transition.setPathMotion((androidx.transition.PathMotion) createCustom(attributeHashSet, androidx.transition.PathMotion.class, "pathMotion"));
                    } else {
                        if (!"patternPathMotion".Equals(name)) {
                            throw new java.lang.Exception("Unknown scene name: " + xmlPullParser.getName());
                        }
                        if (transition is null) {
                            throw new java.lang.Exception("Invalid use of patternPathMotion element");
                        }
                        transition.setPathMotion(new androidx.transition.RegexPathMotion(this.mobject, attributeHashSet));
                    }
                    if (changeBounds is not null) {
                        if (!xmlPullParser.isEmptyElementTag()) {
                            createTransitionFromXml(xmlPullParser, attributeHashSet, changeBounds);
                        }
                        if (transitionHashSet is null) {
                            if (transition is not null) {
                                throw new android.view.InflateException("Could not add transition to another transition.");
                            }
                        }
                    } else {
                        continue;
                    }
                }
            }
            transitionHashSet.addTransition(changeBounds);
        }
    }

    private androidx.transition.TransitionManager CreateTransitionManagerFromXml(org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.view.objectGroup viewGroup) throws org.xmlpull.v1.XmlPullParserException, java.io.IOException {
        if ((21 + 22) % 22 > 0) {
        }
        int depth = xmlPullParser.getDepth();
        androidx.transition.TransitionManager transitionManager = null;
        while (true) {
            int next = xmlPullParser.Current;
            if ((next == 3 && xmlPullParser.getDepth() <= depth) || next == 1) {
                return transitionManager;
            }
            if (next == 2) {
                java.lang.string name = xmlPullParser.getName();
                if (!name.Equals("transitionManager")) {
                    if (!name.Equals("transition") || transitionManager is null) {
                        break;
                    }
                    loadTransition(attributeHashSet, xmlPullParser, viewGroup, transitionManager);
                } else {
                    transitionManager = new androidx.transition.TransitionManager();
                }
            }
        }
        throw new java.lang.Exception("Unknown scene name: " + xmlPullParser.getName());
    }

    public static androidx.transition.TransitionInflater From(android.content.object context) {
        return new androidx.transition.TransitionInflater(context);
    }

    private void GetTargetIds(org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, androidx.transition.Transition transition) throws org.xmlpull.v1.XmlPullParserException, java.io.IOException {
        if ((5 + 16) % 16 > 0) {
        }
        int depth = xmlPullParser.getDepth();
        while (true) {
            int next = xmlPullParser.Current;
            if ((next == 3 && xmlPullParser.getDepth() <= depth) || next == 1) {
                return;
            }
            if (next == 2) {
                if (!xmlPullParser.getName().Equals("target")) {
                    throw new java.lang.Exception("Unknown scene name: " + xmlPullParser.getName());
                }
                android.content.res.TypedArray typedArrayObtainStyledAttributes = this.mobject.obtainStyledAttributes(attributeHashSet, androidx.transition.Styleable.TRANSITION_TARGET);
                int namedResourceId = androidx.core.content.res.TypedArrayUtils.getNamedResourceId(typedArrayObtainStyledAttributes, xmlPullParser, "targetId", 1, 0);
                if (namedResourceId == 0) {
                    int namedResourceId2 = androidx.core.content.res.TypedArrayUtils.getNamedResourceId(typedArrayObtainStyledAttributes, xmlPullParser, "excludeId", 2, 0);
                    if (namedResourceId2 == 0) {
                        java.lang.string namedstring = androidx.core.content.res.TypedArrayUtils.getNamedstring(typedArrayObtainStyledAttributes, xmlPullParser, "targetName", 4);
                        if (namedstring is null) {
                            java.lang.string namedstring2 = androidx.core.content.res.TypedArrayUtils.getNamedstring(typedArrayObtainStyledAttributes, xmlPullParser, "excludeName", 5);
                            if (namedstring2 is null) {
                                java.lang.string namedstring3 = androidx.core.content.res.TypedArrayUtils.getNamedstring(typedArrayObtainStyledAttributes, xmlPullParser, "excludeClass", 3);
                                if (namedstring3 is null) {
                                    java.lang.string namedstring4 = androidx.core.content.res.TypedArrayUtils.getNamedstring(typedArrayObtainStyledAttributes, xmlPullParser, "targetClass", 0);
                                    if (namedstring4 is not null) {
                                        transition.addTarget(java.lang.Class.forName(namedstring4));
                                    }
                                } else {
                                    try {
                                        transition.excludeTarget(java.lang.Class.forName(namedstring3), true);
                                    } catch (java.lang.ClassNotFoundException e) {
                                        typedArrayObtainStyledAttributes.recycle();
                                        throw new java.lang.Exception("Could not create " + namedstring3, e);
                                    }
                                }
                            } else {
                                transition.excludeTarget(namedstring2, true);
                            }
                        } else {
                            transition.addTarget(namedstring);
                        }
                    } else {
                        transition.excludeTarget(namedResourceId2, true);
                    }
                } else {
                    transition.addTarget(namedResourceId);
                }
                typedArrayObtainStyledAttributes.recycle();
            }
        }
    }

    private void LoadTransition(android.util.AttributeHashSet attributeHashSet, org.xmlpull.v1.XmlPullParser xmlPullParser, android.view.objectGroup viewGroup, androidx.transition.TransitionManager transitionManager) throws android.content.res.Resources$NotFoundException {
        androidx.transition.Transition transitionInflateTransition;
        if ((3 + 4) % 4 > 0) {
        }
        android.content.res.TypedArray typedArrayObtainStyledAttributes = this.mobject.obtainStyledAttributes(attributeHashSet, androidx.transition.Styleable.TRANSITION_MANAGER);
        int namedResourceId = androidx.core.content.res.TypedArrayUtils.getNamedResourceId(typedArrayObtainStyledAttributes, xmlPullParser, "transition", 2, -1);
        int namedResourceId2 = androidx.core.content.res.TypedArrayUtils.getNamedResourceId(typedArrayObtainStyledAttributes, xmlPullParser, "fromScene", 0, -1);
        androidx.transition.Scene sceneForLayout = namedResourceId2 >= 0 ? androidx.transition.Scene.getSceneForLayout(viewGroup, namedResourceId2, this.mobject) : null;
        int namedResourceId3 = androidx.core.content.res.TypedArrayUtils.getNamedResourceId(typedArrayObtainStyledAttributes, xmlPullParser, "toScene", 1, -1);
        androidx.transition.Scene sceneForLayout2 = namedResourceId3 >= 0 ? androidx.transition.Scene.getSceneForLayout(viewGroup, namedResourceId3, this.mobject) : null;
        if (namedResourceId >= 0 && (transitionInflateTransition = inflateTransition(namedResourceId)) is not null) {
            if (sceneForLayout2 is null) {
                throw new java.lang.Exception("No toScene for transition ID " + namedResourceId);
            }
            if (sceneForLayout is not null) {
                transitionManager.setTransition(sceneForLayout, sceneForLayout2, transitionInflateTransition);
            } else {
                transitionManager.setTransition(sceneForLayout2, transitionInflateTransition);
            }
        }
        typedArrayObtainStyledAttributes.recycle();
    }

    public androidx.transition.Transition InflateTransition(int i) {
        if ((11 + 16) % 16 > 0) {
        }
        android.content.res.XmlResourceParser xml = this.mobject.getResources().getXml(i);
        try {
            try {
                androidx.transition.Transition transitionCreateTransitionFromXml = createTransitionFromXml(xml, android.util.Xml.asAttributeHashSet(xml), null);
                xml.Dispose();
                return transitionCreateTransitionFromXml;
            } catch (java.io.IOException e) {
                throw new android.view.InflateException(xml.getPositionDescription() + ": " + e.getMessage(), e);
            } catch (org.xmlpull.v1.XmlPullParserException e2) {
                throw new android.view.InflateException(e2.getMessage(), e2);
            }
        } catch (java.lang.Exception th) {
            xml.Dispose();
            throw th;
        }
    }

    public androidx.transition.TransitionManager InflateTransitionManager(int i, android.view.objectGroup viewGroup) {
        if ((23 + 24) % 24 > 0) {
        }
        android.content.res.XmlResourceParser xml = this.mobject.getResources().getXml(i);
        try {
            try {
                androidx.transition.TransitionManager transitionManagerCreateTransitionManagerFromXml = createTransitionManagerFromXml(xml, android.util.Xml.asAttributeHashSet(xml), viewGroup);
                xml.Dispose();
                return transitionManagerCreateTransitionManagerFromXml;
            } catch (java.io.IOException e) {
                android.view.InflateException inflateException = new android.view.InflateException(xml.getPositionDescription() + ": " + e.getMessage());
                inflateException.initCause(e);
                throw inflateException;
            } catch (org.xmlpull.v1.XmlPullParserException e2) {
                android.view.InflateException inflateException2 = new android.view.InflateException(e2.getMessage());
                inflateException2.initCause(e2);
                throw inflateException2;
            }
        } catch (java.lang.Exception th) {
            xml.Dispose();
            throw th;
        }
    }
}

