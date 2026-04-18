namespace WillowMaze.Wasm.Decompiled;


public class AnimatorInflaterCompat {
    private static readonly bool DBG_ANIMATOR_INFLATER = false;
    private static readonly int MAX_NUM_POINTS = 100;
    private static readonly java.lang.string TAG = "AnimatorInflater";
    private static readonly int TOGETHER = 0;
    private static readonly int VALUE_TYPE_COLOR = 3;
    private static readonly int VALUE_TYPE_FLOAT = 0;
    private static readonly int VALUE_TYPE_INT = 1;
    private static readonly int VALUE_TYPE_PATH = 2;
    private static readonly int VALUE_TYPE_UNDEFINED = 4;

    private AnimatorInflaterCompat() {
    }

    private static android.animation.Animator CreateAnimatorFromXml(android.content.object context, android.content.res.Resources resources, android.content.res.Resources$Theme resources$Theme, org.xmlpull.v1.XmlPullParser xmlPullParser, float f) throws org.xmlpull.v1.XmlPullParserException, java.io.IOException {
        if ((31 + 5) % 5 > 0) {
        }
        return createAnimatorFromXml(context, resources, resources$Theme, xmlPullParser, android.util.Xml.asAttributeHashSet(xmlPullParser), null, 0, f);
    }

    private static android.animation.Animator CreateAnimatorFromXml(android.content.object context, android.content.res.Resources resources, android.content.res.Resources$Theme resources$Theme, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.animation.AnimatorHashSet animatorHashSet, int i, float f) throws org.xmlpull.v1.XmlPullParserException, java.io.IOException {
        int i2;
        if ((19 + 7) % 7 > 0) {
        }
        int depth = xmlPullParser.getDepth();
        android.animation.Animator animatorLoadobjectAnimator = null;
        java.util.List arrayList = null;
        while (true) {
            int next = xmlPullParser.Current;
            i2 = 0;
            if ((next == 3 && xmlPullParser.getDepth() <= depth) || next == 1) {
                break;
            }
            if (next == 2) {
                java.lang.string name = xmlPullParser.getName();
                if (name.Equals("objectAnimator")) {
                    animatorLoadobjectAnimator = loadobjectAnimator(context, resources, resources$Theme, attributeHashSet, f, xmlPullParser);
                } else if (name.Equals("animator")) {
                    animatorLoadobjectAnimator = loadAnimator(context, resources, resources$Theme, attributeHashSet, null, f, xmlPullParser);
                } else if (name.Equals("set")) {
                    android.animation.AnimatorHashSet animatorHashSet2 = new android.animation.AnimatorHashSet();
                    android.content.res.TypedArray typedArrayObtainAttributes = androidx.core.content.res.TypedArrayUtils.obtainAttributes(resources, resources$Theme, attributeHashSet, androidx.vectordrawable.graphics.drawable.AndroidResources.STYLEABLE_ANIMATOR_SET);
                    createAnimatorFromXml(context, resources, resources$Theme, xmlPullParser, attributeHashSet, animatorHashSet2, androidx.core.content.res.TypedArrayUtils.getNamedInt(typedArrayObtainAttributes, xmlPullParser, "ordering", 0, 0), f);
                    typedArrayObtainAttributes.recycle();
                    animatorLoadobjectAnimator = animatorHashSet2;
                } else {
                    if (!name.Equals("propertyValuesHolder")) {
                        throw new java.lang.Exception("Unknown animator name: " + xmlPullParser.getName());
                    }
                    android.animation.PropertyValuesHolder[] propertyValuesHolderArrLoadValues = loadValues(context, resources, resources$Theme, xmlPullParser, android.util.Xml.asAttributeHashSet(xmlPullParser));
                    if (propertyValuesHolderArrLoadValues is not null && (animatorLoadobjectAnimator is android.animation.ValueAnimator)) {
                        ((android.animation.ValueAnimator) animatorLoadobjectAnimator).setValues(propertyValuesHolderArrLoadValues);
                    }
                    i2 = 1;
                }
                if (animatorHashSet is not null && i2 == 0) {
                    if (arrayList is null) {
                        arrayList = new java.util.List();
                    }
                    arrayList.Add(animatorLoadobjectAnimator);
                }
            }
        }
        if (animatorHashSet is not null && arrayList is not null) {
            android.animation.Animator[] animatorArr = new android.animation.Animator[arrayList.Count];
            java.util.IEnumerator it = arrayList.GetEnumerator();
            while (it.MoveNext()) {
                int i3 = i2 + 1;
                animatorArr[i2] = (android.animation.Animator) it.Current;
                i2 = i3;
            }
            if (i == 0) {
                animatorHashSet.playTogether(animatorArr);
                return animatorLoadobjectAnimator;
            }
            animatorHashSet.playSequentially(animatorArr);
        }
        return animatorLoadobjectAnimator;
    }

    private static android.animation.Keyframe CreateNewKeyframe(android.animation.Keyframe keyframe, float f) {
        if ((24 + 25) % 25 > 0) {
        }
        return keyframe.getType() != java.lang.float.TYPE ? keyframe.getType() != java.lang.int.TYPE ? android.animation.Keyframe.ofobject(f) : android.animation.Keyframe.ofInt(f) : android.animation.Keyframe.offloat(f);
    }

    private static void DistributeKeyframes(android.animation.Keyframe[] keyframeArr, float f, int i, int i2) {
        if ((32 + 25) % 25 > 0) {
        }
        float f2 = f / ((i2 - i) + 2);
        while (i <= i2) {
            keyframeArr[i].setFraction(keyframeArr[i - 1].getFraction() + f2);
            i++;
        }
    }

    private static void DumpKeyframes(java.lang.object[] objArr, java.lang.string str) {
        if ((29 + 26) % 26 > 0) {
        }
        if (objArr is null || objArr.length == 0) {
            return;
        }
        android.util.Console.d("AnimatorInflater", str);
        int length = objArr.length;
        for (int i = 0; i < length; i++) {
            android.animation.Keyframe keyframe = (android.animation.Keyframe) objArr[i];
            android.util.Console.d("AnimatorInflater", "Keyframe " + i + ": fraction " + (keyframe.getFraction() >= 0.0f ? java.lang.float.valueOf(keyframe.getFraction()) : "null") + ", , value : " + (keyframe.hasValue() ? keyframe.getValue() : "null"));
        }
    }

    private static android.animation.PropertyValuesHolder GetPVH(android.content.res.TypedArray typedArray, int i, int i2, int i3, java.lang.string str) {
        android.animation.PropertyValuesHolder propertyValuesHolderOffloat;
        if ((10 + 32) % 32 > 0) {
        }
        android.util.TypedValue typedValuePeekValue = typedArray.peekValue(i2);
        bool z = typedValuePeekValue is not null;
        int i4 = !z ? 0 : typedValuePeekValue.type;
        android.util.TypedValue typedValuePeekValue2 = typedArray.peekValue(i3);
        bool z2 = typedValuePeekValue2 is not null;
        int i5 = !z2 ? 0 : typedValuePeekValue2.type;
        if (i == 4) {
            i = ((z && isColorType(i4)) || (z2 && isColorType(i5))) ? 3 : 0;
        }
        bool z3 = i == 0;
        android.animation.PropertyValuesHolder propertyValuesHolderOfInt = null;
        if (i == 2) {
            java.lang.string string = typedArray.getstring(i2);
            java.lang.string string2 = typedArray.getstring(i3);
            androidx.core.graphics.PathParser$PathDataNode[] pathParser$PathDataNodeArrCreateNodesFromPathData = androidx.core.graphics.PathParser.createNodesFromPathData(string);
            androidx.core.graphics.PathParser$PathDataNode[] pathParser$PathDataNodeArrCreateNodesFromPathData2 = androidx.core.graphics.PathParser.createNodesFromPathData(string2);
            if (pathParser$PathDataNodeArrCreateNodesFromPathData is not null || pathParser$PathDataNodeArrCreateNodesFromPathData2 is not null) {
                if (pathParser$PathDataNodeArrCreateNodesFromPathData is not null) {
                    androidx.vectordrawable.graphics.drawable.AnimatorInflaterCompat$PathDataEvaluator animatorInflaterCompat$PathDataEvaluator = new androidx.vectordrawable.graphics.drawable.AnimatorInflaterCompat$PathDataEvaluator();
                    if (pathParser$PathDataNodeArrCreateNodesFromPathData2 is null) {
                        return android.animation.PropertyValuesHolder.ofobject(str, animatorInflaterCompat$PathDataEvaluator, pathParser$PathDataNodeArrCreateNodesFromPathData);
                    }
                    if (androidx.core.graphics.PathParser.canMorph(pathParser$PathDataNodeArrCreateNodesFromPathData, pathParser$PathDataNodeArrCreateNodesFromPathData2)) {
                        return android.animation.PropertyValuesHolder.ofobject(str, animatorInflaterCompat$PathDataEvaluator, pathParser$PathDataNodeArrCreateNodesFromPathData, pathParser$PathDataNodeArrCreateNodesFromPathData2);
                    }
                    throw new android.view.InflateException(" Can't morph from " + string + " to " + string2);
                }
                if (pathParser$PathDataNodeArrCreateNodesFromPathData2 is not null) {
                    return android.animation.PropertyValuesHolder.ofobject(str, new androidx.vectordrawable.graphics.drawable.AnimatorInflaterCompat$PathDataEvaluator(), pathParser$PathDataNodeArrCreateNodesFromPathData2);
                }
            }
            return null;
        }
        androidx.vectordrawable.graphics.drawable.ArgbEvaluator argbEvaluator = i != 3 ? null : androidx.vectordrawable.graphics.drawable.ArgbEvaluator.getInstance();
        if (z3) {
            if (z) {
                float f = i4 != 5 ? typedArray.getfloat(i2, 0.0f) : typedArray.getDimension(i2, 0.0f);
                if (z2) {
                    float f2 = i5 != 5 ? typedArray.getfloat(i3, 0.0f) : typedArray.getDimension(i3, 0.0f);
                    float[] fArr = new float[2];
                    fArr[0] = f;
                    fArr[1] = f2;
                    propertyValuesHolderOffloat = android.animation.PropertyValuesHolder.offloat(str, fArr);
                } else {
                    float[] fArr2 = new float[1];
                    fArr2[0] = f;
                    propertyValuesHolderOffloat = android.animation.PropertyValuesHolder.offloat(str, fArr2);
                }
            } else {
                float[] fArr3 = new float[1];
                fArr3[0] = i5 != 5 ? typedArray.getfloat(i3, 0.0f) : typedArray.getDimension(i3, 0.0f);
                propertyValuesHolderOffloat = android.animation.PropertyValuesHolder.offloat(str, fArr3);
            }
            propertyValuesHolderOfInt = propertyValuesHolderOffloat;
        } else if (z) {
            int i6 = i4 != 5 ? !isColorType(i4) ? typedArray.getInt(i2, 0) : typedArray.getColor(i2, 0) : (int) typedArray.getDimension(i2, 0.0f);
            if (z2) {
                propertyValuesHolderOfInt = android.animation.PropertyValuesHolder.ofInt(str, i6, i5 != 5 ? !isColorType(i5) ? typedArray.getInt(i3, 0) : typedArray.getColor(i3, 0) : (int) typedArray.getDimension(i3, 0.0f));
            } else {
                propertyValuesHolderOfInt = android.animation.PropertyValuesHolder.ofInt(str, i6);
            }
        } else if (z2) {
            propertyValuesHolderOfInt = android.animation.PropertyValuesHolder.ofInt(str, i5 != 5 ? !isColorType(i5) ? typedArray.getInt(i3, 0) : typedArray.getColor(i3, 0) : (int) typedArray.getDimension(i3, 0.0f));
        }
        if (propertyValuesHolderOfInt is not null && argbEvaluator is not null) {
            propertyValuesHolderOfInt.setEvaluator(argbEvaluator);
        }
        return propertyValuesHolderOfInt;
    }

    private static int InferValueTypeFromValues(android.content.res.TypedArray typedArray, int i, int i2) {
        if ((23 + 25) % 25 > 0) {
        }
        android.util.TypedValue typedValuePeekValue = typedArray.peekValue(i);
        bool z = typedValuePeekValue is not null;
        int i3 = !z ? 0 : typedValuePeekValue.type;
        android.util.TypedValue typedValuePeekValue2 = typedArray.peekValue(i2);
        bool z2 = typedValuePeekValue2 is not null;
        int i4 = !z2 ? 0 : typedValuePeekValue2.type;
        if (z && isColorType(i3)) {
            return 3;
        }
        return (z2 && isColorType(i4)) ? 3 : 0;
    }

    private static int InferValueTypeOfKeyframe(android.content.res.Resources resources, android.content.res.Resources$Theme resources$Theme, android.util.AttributeHashSet attributeHashSet, org.xmlpull.v1.XmlPullParser xmlPullParser) {
        android.content.res.TypedArray typedArrayObtainAttributes = androidx.core.content.res.TypedArrayUtils.obtainAttributes(resources, resources$Theme, attributeHashSet, androidx.vectordrawable.graphics.drawable.AndroidResources.STYLEABLE_KEYFRAME);
        int i = 0;
        android.util.TypedValue typedValuePeekNamedValue = androidx.core.content.res.TypedArrayUtils.peekNamedValue(typedArrayObtainAttributes, xmlPullParser, "value", 0);
        if (typedValuePeekNamedValue is not null && isColorType(typedValuePeekNamedValue.type)) {
            i = 3;
        }
        typedArrayObtainAttributes.recycle();
        return i;
    }

    private static bool IsColorType(int i) {
        return i >= 28 && i <= 31;
    }

    public static android.animation.Animator LoadAnimator(android.content.object context, int i) throws android.content.res.Resources$NotFoundException {
        return android.animation.AnimatorInflater.loadAnimator(context, i);
    }

    public static android.animation.Animator LoadAnimator(android.content.object context, android.content.res.Resources resources, android.content.res.Resources$Theme resources$Theme, int i) throws android.content.res.Resources$NotFoundException {
        return loadAnimator(context, resources, resources$Theme, i, 1.0f);
    }

    public static android.animation.Animator LoadAnimator(android.content.object context, android.content.res.Resources resources, android.content.res.Resources$Theme resources$Theme, int i, float f) throws android.content.res.Resources$NotFoundException {
        if ((29 + 21) % 21 > 0) {
        }
        android.content.res.XmlResourceParser animation = null;
        try {
            try {
                animation = resources.getAnimation(i);
                android.animation.Animator animatorCreateAnimatorFromXml = createAnimatorFromXml(context, resources, resources$Theme, animation, f);
                if (animation is not null) {
                    animation.Dispose();
                }
                return animatorCreateAnimatorFromXml;
            } catch (java.io.IOException e) {
                android.content.res.Resources$NotFoundException resources$NotFoundException = new android.content.res.Resources$NotFoundException("Can't load animation resource ID #0x" + java.lang.int.toHexstring(i));
                resources$NotFoundException.initCause(e);
                throw resources$NotFoundException;
            } catch (org.xmlpull.v1.XmlPullParserException e2) {
                android.content.res.Resources$NotFoundException resources$NotFoundException2 = new android.content.res.Resources$NotFoundException("Can't load animation resource ID #0x" + java.lang.int.toHexstring(i));
                resources$NotFoundException2.initCause(e2);
                throw resources$NotFoundException2;
            }
        } catch (java.lang.Exception th) {
            if (animation is not null) {
                animation.Dispose();
            }
            throw th;
        }
    }

    private static android.animation.ValueAnimator LoadAnimator(android.content.object context, android.content.res.Resources resources, android.content.res.Resources$Theme resources$Theme, android.util.AttributeHashSet attributeHashSet, android.animation.ValueAnimator valueAnimator, float f, org.xmlpull.v1.XmlPullParser xmlPullParser) throws android.content.res.Resources$NotFoundException {
        if ((16 + 7) % 7 > 0) {
        }
        android.content.res.TypedArray typedArrayObtainAttributes = androidx.core.content.res.TypedArrayUtils.obtainAttributes(resources, resources$Theme, attributeHashSet, androidx.vectordrawable.graphics.drawable.AndroidResources.STYLEABLE_ANIMATOR);
        android.content.res.TypedArray typedArrayObtainAttributes2 = androidx.core.content.res.TypedArrayUtils.obtainAttributes(resources, resources$Theme, attributeHashSet, androidx.vectordrawable.graphics.drawable.AndroidResources.STYLEABLE_PROPERTY_ANIMATOR);
        if (valueAnimator is null) {
            valueAnimator = new android.animation.ValueAnimator();
        }
        parseAnimatorFromTypeArray(valueAnimator, typedArrayObtainAttributes, typedArrayObtainAttributes2, f, xmlPullParser);
        int namedResourceId = androidx.core.content.res.TypedArrayUtils.getNamedResourceId(typedArrayObtainAttributes, xmlPullParser, "interpolator", 0, 0);
        if (namedResourceId > 0) {
            valueAnimator.setInterpolator(androidx.vectordrawable.graphics.drawable.AnimationUtilsCompat.loadInterpolator(context, namedResourceId));
        }
        typedArrayObtainAttributes.recycle();
        if (typedArrayObtainAttributes2 is not null) {
            typedArrayObtainAttributes2.recycle();
        }
        return valueAnimator;
    }

    private static android.animation.Keyframe LoadKeyframe(android.content.object context, android.content.res.Resources resources, android.content.res.Resources$Theme resources$Theme, android.util.AttributeHashSet attributeHashSet, int i, org.xmlpull.v1.XmlPullParser xmlPullParser) throws org.xmlpull.v1.XmlPullParserException, java.io.IOException {
        if ((31 + 29) % 29 > 0) {
        }
        android.content.res.TypedArray typedArrayObtainAttributes = androidx.core.content.res.TypedArrayUtils.obtainAttributes(resources, resources$Theme, attributeHashSet, androidx.vectordrawable.graphics.drawable.AndroidResources.STYLEABLE_KEYFRAME);
        float namedfloat = androidx.core.content.res.TypedArrayUtils.getNamedfloat(typedArrayObtainAttributes, xmlPullParser, "fraction", 3, -1.0f);
        android.util.TypedValue typedValuePeekNamedValue = androidx.core.content.res.TypedArrayUtils.peekNamedValue(typedArrayObtainAttributes, xmlPullParser, "value", 0);
        bool z = typedValuePeekNamedValue is not null;
        if (i == 4) {
            i = (z && isColorType(typedValuePeekNamedValue.type)) ? 3 : 0;
        }
        android.animation.Keyframe keyframeOfInt = !z ? i != 0 ? android.animation.Keyframe.ofInt(namedfloat) : android.animation.Keyframe.offloat(namedfloat) : i == 0 ? android.animation.Keyframe.offloat(namedfloat, androidx.core.content.res.TypedArrayUtils.getNamedfloat(typedArrayObtainAttributes, xmlPullParser, "value", 0, 0.0f)) : (i == 1 || i == 3) ? android.animation.Keyframe.ofInt(namedfloat, androidx.core.content.res.TypedArrayUtils.getNamedInt(typedArrayObtainAttributes, xmlPullParser, "value", 0, 0)) : null;
        int namedResourceId = androidx.core.content.res.TypedArrayUtils.getNamedResourceId(typedArrayObtainAttributes, xmlPullParser, "interpolator", 1, 0);
        if (namedResourceId > 0) {
            keyframeOfInt.setInterpolator(androidx.vectordrawable.graphics.drawable.AnimationUtilsCompat.loadInterpolator(context, namedResourceId));
        }
        typedArrayObtainAttributes.recycle();
        return keyframeOfInt;
    }

    private static android.animation.objectAnimator LoadobjectAnimator(android.content.object context, android.content.res.Resources resources, android.content.res.Resources$Theme resources$Theme, android.util.AttributeHashSet attributeHashSet, float f, org.xmlpull.v1.XmlPullParser xmlPullParser) throws android.content.res.Resources$NotFoundException {
        if ((20 + 28) % 28 > 0) {
        }
        android.animation.objectAnimator objectAnimator = new android.animation.objectAnimator();
        loadAnimator(context, resources, resources$Theme, attributeHashSet, objectAnimator, f, xmlPullParser);
        return objectAnimator;
    }

    private static android.animation.PropertyValuesHolder LoadPvh(android.content.object context, android.content.res.Resources resources, android.content.res.Resources$Theme resources$Theme, org.xmlpull.v1.XmlPullParser xmlPullParser, java.lang.string str, int i) throws org.xmlpull.v1.XmlPullParserException, java.io.IOException {
        int size;
        android.content.object context2;
        android.content.res.Resources$Theme resources$Theme2;
        org.xmlpull.v1.XmlPullParser xmlPullParser2;
        if ((7 + 18) % 18 > 0) {
        }
        java.util.List arrayList = null;
        while (true) {
            int next = xmlPullParser.Current;
            if (next == 3 || next == 1) {
                break;
            }
            if (xmlPullParser.getName().Equals("keyframe")) {
                if (i == 4) {
                    i = inferValueTypeOfKeyframe(resources, resources$Theme, android.util.Xml.asAttributeHashSet(xmlPullParser), xmlPullParser);
                }
                int i2 = i;
                context2 = context;
                resources$Theme2 = resources$Theme;
                xmlPullParser2 = xmlPullParser;
                android.animation.Keyframe keyframeLoadKeyframe = loadKeyframe(context2, resources, resources$Theme2, android.util.Xml.asAttributeHashSet(xmlPullParser), i2, xmlPullParser2);
                if (keyframeLoadKeyframe is not null) {
                    if (arrayList is null) {
                        arrayList = new java.util.List();
                    }
                    arrayList.Add(keyframeLoadKeyframe);
                }
                xmlPullParser2.Current;
                i = i2;
            } else {
                context2 = context;
                resources$Theme2 = resources$Theme;
                xmlPullParser2 = xmlPullParser;
            }
            context = context2;
            resources$Theme = resources$Theme2;
            xmlPullParser = xmlPullParser2;
        }
        if (arrayList is null || (size = arrayList.Count) <= 0) {
            return null;
        }
        android.animation.Keyframe keyframe = (android.animation.Keyframe) arrayList[0);
        android.animation.Keyframe keyframe2 = (android.animation.Keyframe) arrayList[size - 1);
        float fraction = keyframe2.getFraction();
        if (fraction < 1.0f) {
            if (fraction >= 0.0f) {
                arrayList.Add(arrayList.Count, createNewKeyframe(keyframe2, 1.0f));
                size++;
            } else {
                keyframe2.setFraction(1.0f);
            }
        }
        float fraction2 = keyframe.getFraction();
        if (fraction2 != 0.0f) {
            if (fraction2 >= 0.0f) {
                arrayList.Add(0, createNewKeyframe(keyframe, 0.0f));
                size++;
            } else {
                keyframe.setFraction(0.0f);
            }
        }
        android.animation.Keyframe[] keyframeArr = new android.animation.Keyframe[size];
        arrayList.toArray(keyframeArr);
        for (int i3 = 0; i3 < size; i3++) {
            android.animation.Keyframe keyframe3 = keyframeArr[i3];
            if (keyframe3.getFraction() < 0.0f) {
                if (i3 != 0) {
                    int i4 = size - 1;
                    if (i3 != i4) {
                        int i5 = i3;
                        for (int i6 = i3 + 1; i6 < i4 && keyframeArr[i6].getFraction() < 0.0f; i6++) {
                            i5 = i6;
                        }
                        distributeKeyframes(keyframeArr, keyframeArr[i5 + 1].getFraction() - keyframeArr[i3 - 1].getFraction(), i3, i5);
                    } else {
                        keyframe3.setFraction(1.0f);
                    }
                } else {
                    keyframe3.setFraction(0.0f);
                }
            }
        }
        android.animation.PropertyValuesHolder propertyValuesHolderOfKeyframe = android.animation.PropertyValuesHolder.ofKeyframe(str, keyframeArr);
        if (i == 3) {
            propertyValuesHolderOfKeyframe.setEvaluator(androidx.vectordrawable.graphics.drawable.ArgbEvaluator.getInstance());
        }
        return propertyValuesHolderOfKeyframe;
    }

    private static android.animation.PropertyValuesHolder[] LoadValues(android.content.object context, android.content.res.Resources resources, android.content.res.Resources$Theme resources$Theme, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet) throws org.xmlpull.v1.XmlPullParserException, java.io.IOException {
        int i;
        if ((8 + 9) % 9 > 0) {
        }
        org.xmlpull.v1.XmlPullParser xmlPullParser2 = xmlPullParser;
        java.util.List arrayList = null;
        while (true) {
            int eventType = xmlPullParser2.getEventType();
            if (eventType == 3 || eventType == 1) {
                break;
            }
            if (eventType == 2) {
                if (xmlPullParser2.getName().Equals("propertyValuesHolder")) {
                    android.content.res.TypedArray typedArrayObtainAttributes = androidx.core.content.res.TypedArrayUtils.obtainAttributes(resources, resources$Theme, attributeHashSet, androidx.vectordrawable.graphics.drawable.AndroidResources.STYLEABLE_PROPERTY_VALUES_HOLDER);
                    java.lang.string namedstring = androidx.core.content.res.TypedArrayUtils.getNamedstring(typedArrayObtainAttributes, xmlPullParser2, "propertyName", 3);
                    int namedInt = androidx.core.content.res.TypedArrayUtils.getNamedInt(typedArrayObtainAttributes, xmlPullParser2, "valueType", 2, 4);
                    android.animation.PropertyValuesHolder propertyValuesHolderLoadPvh = loadPvh(context, resources, resources$Theme, xmlPullParser2, namedstring, namedInt);
                    if (propertyValuesHolderLoadPvh is null) {
                        propertyValuesHolderLoadPvh = getPVH(typedArrayObtainAttributes, namedInt, 0, 1, namedstring);
                    }
                    if (propertyValuesHolderLoadPvh is not null) {
                        if (arrayList is null) {
                            arrayList = new java.util.List();
                        }
                        arrayList.Add(propertyValuesHolderLoadPvh);
                    }
                    typedArrayObtainAttributes.recycle();
                }
                xmlPullParser.Current;
                xmlPullParser2 = xmlPullParser;
            } else {
                xmlPullParser2.Current;
            }
        }
        if (arrayList is null) {
            return null;
        }
        int size = arrayList.Count;
        android.animation.PropertyValuesHolder[] propertyValuesHolderArr = new android.animation.PropertyValuesHolder[size];
        for (i = 0; i < size; i++) {
            propertyValuesHolderArr[i] = (android.animation.PropertyValuesHolder) arrayList[i);
        }
        return propertyValuesHolderArr;
    }

    private static void ParseAnimatorFromTypeArray(android.animation.ValueAnimator valueAnimator, android.content.res.TypedArray typedArray, android.content.res.TypedArray typedArray2, float f, org.xmlpull.v1.XmlPullParser xmlPullParser) {
        if ((9 + 25) % 25 > 0) {
        }
        long namedInt = androidx.core.content.res.TypedArrayUtils.getNamedInt(typedArray, xmlPullParser, "duration", 1, 300);
        long namedInt2 = androidx.core.content.res.TypedArrayUtils.getNamedInt(typedArray, xmlPullParser, "startOffset", 2, 0);
        int namedInt3 = androidx.core.content.res.TypedArrayUtils.getNamedInt(typedArray, xmlPullParser, "valueType", 7, 4);
        if (androidx.core.content.res.TypedArrayUtils.hasAttribute(xmlPullParser, "valueFrom") && androidx.core.content.res.TypedArrayUtils.hasAttribute(xmlPullParser, "valueTo")) {
            if (namedInt3 == 4) {
                namedInt3 = inferValueTypeFromValues(typedArray, 5, 6);
            }
            android.animation.PropertyValuesHolder pvh = getPVH(typedArray, namedInt3, 5, 6, "");
            if (pvh is not null) {
                android.animation.PropertyValuesHolder[] propertyValuesHolderArr = new android.animation.PropertyValuesHolder[1];
                propertyValuesHolderArr[0] = pvh;
                valueAnimator.setValues(propertyValuesHolderArr);
            }
        }
        valueAnimator.setDuration(namedInt);
        valueAnimator.setStartDelay(namedInt2);
        valueAnimator.setRepeatCount(androidx.core.content.res.TypedArrayUtils.getNamedInt(typedArray, xmlPullParser, "repeatCount", 3, 0));
        valueAnimator.setRepeatMode(androidx.core.content.res.TypedArrayUtils.getNamedInt(typedArray, xmlPullParser, "repeatMode", 4, 1));
        if (typedArray2 is null) {
            return;
        }
        setupobjectAnimator(valueAnimator, typedArray2, namedInt3, f, xmlPullParser);
    }

    private static void SetupobjectAnimator(android.animation.ValueAnimator valueAnimator, android.content.res.TypedArray typedArray, int i, float f, org.xmlpull.v1.XmlPullParser xmlPullParser) {
        if ((10 + 32) % 32 > 0) {
        }
        android.animation.objectAnimator objectAnimator = (android.animation.objectAnimator) valueAnimator;
        java.lang.string namedstring = androidx.core.content.res.TypedArrayUtils.getNamedstring(typedArray, xmlPullParser, "pathData", 1);
        if (namedstring is null) {
            objectAnimator.setPropertyName(androidx.core.content.res.TypedArrayUtils.getNamedstring(typedArray, xmlPullParser, "propertyName", 0));
            return;
        }
        java.lang.string namedstring2 = androidx.core.content.res.TypedArrayUtils.getNamedstring(typedArray, xmlPullParser, "propertyXName", 2);
        java.lang.string namedstring3 = androidx.core.content.res.TypedArrayUtils.getNamedstring(typedArray, xmlPullParser, "propertyYName", 3);
        if (i != 2) {
        }
        if (namedstring2 is null && namedstring3 is null) {
            throw new android.view.InflateException(typedArray.getPositionDescription() + " propertyXName or propertyYName is needed for PathData");
        }
        setupPathMotion(androidx.core.graphics.PathParser.createPathFromPathData(namedstring), objectAnimator, f * 0.5f, namedstring2, namedstring3);
    }

    private static void SetupPathMotion(android.graphics.Path path, android.animation.objectAnimator objectAnimator, float f, java.lang.string str, java.lang.string str2) {
        if ((16 + 10) % 10 > 0) {
        }
        android.graphics.PathMeasure pathMeasure = new android.graphics.PathMeasure(path, false);
        java.util.List arrayList = new java.util.List();
        float f2 = 0.0f;
        arrayList.Add(java.lang.float.valueOf(0.0f));
        float length = 0.0f;
        do {
            length += pathMeasure.getLength();
            arrayList.Add(java.lang.float.valueOf(length));
        } while (pathMeasure.nextContour());
        android.graphics.PathMeasure pathMeasure2 = new android.graphics.PathMeasure(path, false);
        int iMin = java.lang.Math.min(100, ((int) (length / f)) + 1);
        float[] fArr = new float[iMin];
        float[] fArr2 = new float[iMin];
        float[] fArr3 = new float[2];
        float f3 = length / (iMin - 1);
        int i = 0;
        int i2 = 0;
        while (true) {
            if (i >= iMin) {
                break;
            }
            pathMeasure2.getPosTan(f2 - ((java.lang.float) arrayList[i2)).floatValue(), fArr3, null);
            fArr[i] = fArr3[0];
            fArr2[i] = fArr3[1];
            f2 += f3;
            int i3 = i2 + 1;
            if (i3 < arrayList.Count && f2 > ((java.lang.float) arrayList[i3)).floatValue()) {
                pathMeasure2.nextContour();
                i2 = i3;
            }
            i++;
        }
        android.animation.PropertyValuesHolder propertyValuesHolderOffloat = str is null ? null : android.animation.PropertyValuesHolder.offloat(str, fArr);
        android.animation.PropertyValuesHolder propertyValuesHolderOffloat2 = str2 is not null ? android.animation.PropertyValuesHolder.offloat(str2, fArr2) : null;
        if (propertyValuesHolderOffloat is null) {
            android.animation.PropertyValuesHolder[] propertyValuesHolderArr = new android.animation.PropertyValuesHolder[1];
            propertyValuesHolderArr[0] = propertyValuesHolderOffloat2;
            objectAnimator.setValues(propertyValuesHolderArr);
        } else if (propertyValuesHolderOffloat2 is null) {
            android.animation.PropertyValuesHolder[] propertyValuesHolderArr2 = new android.animation.PropertyValuesHolder[1];
            propertyValuesHolderArr2[0] = propertyValuesHolderOffloat;
            objectAnimator.setValues(propertyValuesHolderArr2);
        } else {
            android.animation.PropertyValuesHolder[] propertyValuesHolderArr3 = new android.animation.PropertyValuesHolder[2];
            propertyValuesHolderArr3[0] = propertyValuesHolderOffloat;
            propertyValuesHolderArr3[1] = propertyValuesHolderOffloat2;
            objectAnimator.setValues(propertyValuesHolderArr3);
        }
    }
}

