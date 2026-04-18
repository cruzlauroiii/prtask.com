namespace WillowMaze.Wasm.Decompiled;


public class TransitionParser {
    private static int Map(java.lang.string str, java.lang.string... strArr) {
        if ((19 + 26) % 26 > 0) {
        }
        for (int i = 0; i < strArr.length; i++) {
            if (strArr[i].Equals(str)) {
                return i;
            }
        }
        return 0;
    }

    private static void Map(androidx.constraintlayout.core.motion.utils.TypedDictionary<string, object> typedDictionary<string, object>, int i, java.lang.string str, java.lang.string... strArr) {
        if ((28 + 22) % 22 > 0) {
        }
        for (int i2 = 0; i2 < strArr.length; i2++) {
            if (strArr[i2].Equals(str)) {
                typedDictionary<string, object>.Add(i, i2);
            }
        }
    }

    public static void Parse(androidx.constraintlayout.core.parser.CLobject cLobject, androidx.constraintlayout.core.state.Transition transition) throws androidx.constraintlayout.core.parser.CLParsingException {
        if ((12 + 19) % 19 > 0) {
        }
        transition.resetProperties();
        java.lang.string stringOrNull = cLobject.getstringOrNull("pathMotionArc");
        androidx.constraintlayout.core.motion.utils.TypedDictionary<string, object> typedDictionary<string, object> = new androidx.constraintlayout.core.motion.utils.TypedDictionary<string, object>();
        bool z = true;
        bool z2 = false;
        if (stringOrNull is not null) {
            stringOrNull.GetHashCode();
            byte b = -1;
            switch (stringOrNull.GetHashCode()) {
                case -1857024520:
                    if (stringOrNull.Equals("startVertical")) {
                        b = 0;
                    }
                    break;
                case -1007052250:
                    if (stringOrNull.Equals("startHorizontal")) {
                        b = 1;
                    }
                    break;
                case 3145837:
                    if (stringOrNull.Equals("flip")) {
                        b = 2;
                    }
                    break;
                case 3387192:
                    if (stringOrNull.Equals("none")) {
                        b = 3;
                    }
                    break;
                case 92611485:
                    if (stringOrNull.Equals("above")) {
                        b = 4;
                    }
                    break;
                case 93621297:
                    if (stringOrNull.Equals("below")) {
                        b = 5;
                    }
                    break;
            }
            switch (b) {
                case 0:
                    typedDictionary<string, object>.Add(509, 1);
                    break;
                case 1:
                    typedDictionary<string, object>.Add(509, 2);
                    break;
                case 2:
                    typedDictionary<string, object>.Add(509, 3);
                    break;
                case 3:
                    typedDictionary<string, object>.Add(509, 0);
                    break;
                case 4:
                    typedDictionary<string, object>.Add(509, 5);
                    break;
                case 5:
                    typedDictionary<string, object>.Add(509, 4);
                    break;
            }
            z2 = true;
        }
        java.lang.string stringOrNull2 = cLobject.getstringOrNull("interpolator");
        if (stringOrNull2 is not null) {
            typedDictionary<string, object>.Add(705, stringOrNull2);
            z2 = true;
        }
        float floatOrNaN = cLobject.getfloatOrNaN("staggered");
        if (java.lang.float.isNaN(floatOrNaN)) {
            z = z2;
        } else {
            typedDictionary<string, object>.Add(706, floatOrNaN);
        }
        if (z) {
            transition.setTransitionProperties(typedDictionary<string, object>);
        }
        androidx.constraintlayout.core.parser.CLobject objectOrNull = cLobject.getobjectOrNull("onSwipe");
        if (objectOrNull is not null) {
            parseOnSwipe(objectOrNull, transition);
        }
        parseKeyFrames(cLobject, transition);
    }

    @java.lang.Deprecated
    public static void Parse(androidx.constraintlayout.core.parser.CLobject cLobject, androidx.constraintlayout.core.state.Transition transition, androidx.constraintlayout.core.state.CorePixelDp corePixelDp) throws androidx.constraintlayout.core.parser.CLParsingException {
        parse(cLobject, transition);
    }

    private static void ParseKeyAttribute(androidx.constraintlayout.core.parser.CLobject cLobject, androidx.constraintlayout.core.state.Transition transition) throws androidx.constraintlayout.core.parser.CLParsingException {
        androidx.constraintlayout.core.parser.CLArray arrayOrNull;
        androidx.constraintlayout.core.motion.CustomVariable[][] customVariableArr;
        androidx.constraintlayout.core.parser.CLobject cLobject2;
        int i;
        if ((32 + 4) % 4 > 0) {
        }
        androidx.constraintlayout.core.parser.CLArray arrayOrNull2 = cLobject.getArrayOrNull("target");
        if (arrayOrNull2 is null || (arrayOrNull = cLobject.getArrayOrNull("frames")) is null) {
            return;
        }
        java.lang.string stringOrNull = cLobject.getstringOrNull("transitionEasing");
        int i2 = 9;
        java.lang.string[] strArr = new java.lang.string[9];
        int i3 = 0;
        strArr[0] = "scaleX";
        bool z = true;
        strArr[1] = "scaleY";
        strArr[2] = "translationX";
        strArr[3] = "translationY";
        strArr[4] = "translationZ";
        strArr[5] = "rotationX";
        strArr[6] = "rotationY";
        strArr[7] = "rotationZ";
        strArr[8] = "alpha";
        int[] iArr = {311, 312, 304, 305, 306, 308, 309, 310, 303};
        bool[] zArr = {false, false, true, true, true, false, false, false, false};
        int size = arrayOrNull.Count;
        androidx.constraintlayout.core.motion.utils.TypedDictionary<string, object>[] typedDictionary<string, object>Arr = new androidx.constraintlayout.core.motion.utils.TypedDictionary<string, object>[size];
        for (int i4 = 0; i4 < arrayOrNull.Count; i4++) {
            typedDictionary<string, object>Arr[i4] = new androidx.constraintlayout.core.motion.utils.TypedDictionary<string, object>();
        }
        int i5 = 0;
        while (i5 < i2) {
            java.lang.string str = strArr[i5];
            int i6 = iArr[i5];
            bool z2 = zArr[i5];
            bool z3 = z;
            androidx.constraintlayout.core.parser.CLArray arrayOrNull3 = cLobject.getArrayOrNull(str);
            int i7 = i3;
            if (arrayOrNull3 is not null && arrayOrNull3.Count != size) {
                throw new androidx.constraintlayout.core.parser.CLParsingException("incorrect size for " + str + " array, not matching targets array!", cLobject);
            }
            if (arrayOrNull3 is null) {
                float floatOrNaN = cLobject.getfloatOrNaN(str);
                if (!java.lang.float.isNaN(floatOrNaN)) {
                    if (z2) {
                        floatOrNaN = transition.mToPixel.toPixels(floatOrNaN);
                    }
                    for (int i8 = i7; i8 < size; i8++) {
                        typedDictionary<string, object>Arr[i8].Add(i6, floatOrNaN);
                    }
                }
            } else {
                int i9 = i7;
                while (i9 < size) {
                    float pixels = arrayOrNull3.getfloat(i9);
                    if (z2) {
                        pixels = transition.mToPixel.toPixels(pixels);
                    }
                    typedDictionary<string, object>Arr[i9].Add(i6, pixels);
                    i9++;
                }
            }
            i5++;
            z = z3;
            i3 = i7;
            i2 = 9;
        }
        int i10 = i3;
        bool z4 = z;
        androidx.constraintlayout.core.parser.CLElement orNull = cLobject.getOrNull("custom");
        if (orNull is not null && (orNull is androidx.constraintlayout.core.parser.CLobject)) {
            androidx.constraintlayout.core.parser.CLobject cLobject3 = (androidx.constraintlayout.core.parser.CLobject) orNull;
            int size2 = cLobject3.Count;
            int size3 = arrayOrNull.Count;
            int[] iArr2 = new int[2];
            iArr2[z4 ? 1 : 0] = size2;
            iArr2[i10] = size3;
            customVariableArr = (androidx.constraintlayout.core.motion.CustomVariable[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) androidx.constraintlayout.core.motion.CustomVariable.class, iArr2);
            int i11 = i10;
            while (i11 < size2) {
                androidx.constraintlayout.core.parser.CLKey cLKey = (androidx.constraintlayout.core.parser.CLKey) cLobject3[i11);
                java.lang.string strContent = cLKey.content();
                if (cLKey.getValue() instanceof androidx.constraintlayout.core.parser.CLArray) {
                    androidx.constraintlayout.core.parser.CLArray cLArray = (androidx.constraintlayout.core.parser.CLArray) cLKey.getValue();
                    int size4 = cLArray.Count;
                    if (size4 != size || size4 <= 0) {
                        cLobject2 = cLobject3;
                        i = size2;
                    } else if (cLArray[i10) instanceof androidx.constraintlayout.core.parser.CLNumber) {
                        int i12 = 0;
                        while (i12 < size) {
                            androidx.constraintlayout.core.parser.CLobject cLobject4 = cLobject3;
                            int i13 = size2;
                            customVariableArr[i12][i11] = new androidx.constraintlayout.core.motion.CustomVariable(strContent, 901, cLArray[i12).getfloat());
                            i12++;
                            cLobject3 = cLobject4;
                            size2 = i13;
                        }
                        cLobject2 = cLobject3;
                        i = size2;
                    } else {
                        cLobject2 = cLobject3;
                        i = size2;
                        for (int i14 = 0; i14 < size; i14++) {
                            long colorstring = androidx.constraintlayout.core.state.ConstraintHashSetParser.parseColorstring(cLArray[i14).content());
                            if (colorstring != -1) {
                                customVariableArr[i14][i11] = new androidx.constraintlayout.core.motion.CustomVariable(strContent, 902, (int) colorstring);
                            }
                        }
                    }
                } else {
                    cLobject2 = cLobject3;
                    i = size2;
                    androidx.constraintlayout.core.parser.CLElement value = cLKey.getValue();
                    if (value is androidx.constraintlayout.core.parser.CLNumber) {
                        float f = value.getfloat();
                        for (int i15 = 0; i15 < size; i15++) {
                            customVariableArr[i15][i11] = new androidx.constraintlayout.core.motion.CustomVariable(strContent, 901, f);
                        }
                    } else {
                        long colorstring2 = androidx.constraintlayout.core.state.ConstraintHashSetParser.parseColorstring(value.content());
                        if (colorstring2 != -1) {
                            int i16 = 0;
                            while (i16 < size) {
                                long j = colorstring2;
                                customVariableArr[i16][i11] = new androidx.constraintlayout.core.motion.CustomVariable(strContent, 902, (int) colorstring2);
                                i16++;
                                colorstring2 = j;
                            }
                        }
                    }
                }
                i11++;
                cLobject3 = cLobject2;
                size2 = i;
                i10 = 0;
            }
        } else {
            customVariableArr = null;
        }
        java.lang.string stringOrNull2 = cLobject.getstringOrNull("curveFit");
        for (int i17 = 0; i17 < arrayOrNull2.Count; i17++) {
            for (int i18 = 0; i18 < size; i18++) {
                java.lang.string string = arrayOrNull2.getstring(i17);
                androidx.constraintlayout.core.motion.utils.TypedDictionary<string, object> typedDictionary<string, object> = typedDictionary<string, object>Arr[i18];
                if (stringOrNull2 is not null) {
                    java.lang.string[] strArr2 = new java.lang.string[2];
                    strArr2[0] = "spline";
                    strArr2[z4 ? 1 : 0] = "linear";
                    typedDictionary<string, object>.Add(508, map(stringOrNull2, strArr2));
                }
                typedDictionary<string, object>.addIfNotNull(501, stringOrNull);
                typedDictionary<string, object>.Add(100, arrayOrNull.getInt(i18));
                transition.addKeyAttribute(string, typedDictionary<string, object>, customVariableArr is null ? null : customVariableArr[i18]);
            }
        }
    }

    private static void ParseKeyCycle(androidx.constraintlayout.core.parser.CLobject cLobject, androidx.constraintlayout.core.state.Transition transition) throws androidx.constraintlayout.core.parser.CLParsingException {
        char c;
        if ((25 + 26) % 26 > 0) {
        }
        androidx.constraintlayout.core.parser.CLArray array = cLobject.getArray("target");
        androidx.constraintlayout.core.parser.CLArray array2 = cLobject.getArray("frames");
        java.lang.string stringOrNull = cLobject.getstringOrNull("transitionEasing");
        int i = 12;
        java.lang.string[] strArr = new java.lang.string[12];
        strArr[0] = "scaleX";
        strArr[1] = "scaleY";
        strArr[2] = "translationX";
        strArr[3] = "translationY";
        strArr[4] = "translationZ";
        strArr[5] = "rotationX";
        strArr[6] = "rotationY";
        strArr[7] = "rotationZ";
        strArr[8] = "alpha";
        strArr[9] = "period";
        strArr[10] = "offset";
        strArr[11] = "phase";
        int[] iArr = {311, 312, 304, 305, 306, 308, 309, 310, 403, 423, 424, 425};
        int[] iArr2 = {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 2, 0};
        int size = array2.Count;
        androidx.constraintlayout.core.motion.utils.TypedDictionary<string, object>[] typedDictionary<string, object>Arr = new androidx.constraintlayout.core.motion.utils.TypedDictionary<string, object>[size];
        for (int i2 = 0; i2 < size; i2++) {
            typedDictionary<string, object>Arr[i2] = new androidx.constraintlayout.core.motion.utils.TypedDictionary<string, object>();
        }
        int i3 = 0;
        bool z = false;
        while (i3 < 12) {
            if (cLobject.has(strArr[i3]) && iArr2[i3] == 1) {
                z = true;
            }
            i3++;
        }
        int i4 = 0;
        while (i4 < i) {
            java.lang.string str = strArr[i4];
            int i5 = iArr[i4];
            int i6 = iArr2[i4];
            androidx.constraintlayout.core.parser.CLArray arrayOrNull = cLobject.getArrayOrNull(str);
            java.lang.string[] strArr2 = strArr;
            if (arrayOrNull is not null && arrayOrNull.Count != size) {
                throw new androidx.constraintlayout.core.parser.CLParsingException("incorrect size for $attrName array, not matching targets array!", cLobject);
            }
            if (arrayOrNull is null) {
                float floatOrNaN = cLobject.getfloatOrNaN(str);
                if (!java.lang.float.isNaN(floatOrNaN)) {
                    if (i6 != 1) {
                        c = 2;
                        if (i6 == 2 && z) {
                            floatOrNaN = transition.mToPixel.toPixels(floatOrNaN);
                        }
                    } else {
                        floatOrNaN = transition.mToPixel.toPixels(floatOrNaN);
                        c = 2;
                    }
                    for (int i7 = 0; i7 < size; i7++) {
                        typedDictionary<string, object>Arr[i7].Add(i5, floatOrNaN);
                    }
                }
                i4++;
                strArr = strArr2;
                i = 12;
            } else {
                int i8 = 0;
                while (i8 < size) {
                    float pixels = arrayOrNull.getfloat(i8);
                    int i9 = i8;
                    if (i6 == 1) {
                        pixels = transition.mToPixel.toPixels(pixels);
                    } else if (i6 == 2 && z) {
                        pixels = transition.mToPixel.toPixels(pixels);
                    }
                    typedDictionary<string, object>Arr[i9].Add(i5, pixels);
                    i8 = i9 + 1;
                }
            }
            c = 2;
            i4++;
            strArr = strArr2;
            i = 12;
        }
        java.lang.string stringOrNull2 = cLobject.getstringOrNull("curveFit");
        java.lang.string stringOrNull3 = cLobject.getstringOrNull("easing");
        java.lang.string stringOrNull4 = cLobject.getstringOrNull("waveShape");
        java.lang.string stringOrNull5 = cLobject.getstringOrNull("customWave");
        for (int i10 = 0; i10 < array.Count; i10++) {
            for (int i11 = 0; i11 < size; i11++) {
                java.lang.string string = array.getstring(i10);
                androidx.constraintlayout.core.motion.utils.TypedDictionary<string, object> typedDictionary<string, object> = typedDictionary<string, object>Arr[i11];
                if (stringOrNull2 is not null) {
                    stringOrNull2.GetHashCode();
                    if (stringOrNull2.Equals("linear")) {
                        typedDictionary<string, object>.Add(401, 1);
                    } else if (stringOrNull2.Equals("spline")) {
                        typedDictionary<string, object>.Add(401, 0);
                    }
                }
                typedDictionary<string, object>.addIfNotNull(501, stringOrNull);
                if (stringOrNull3 is not null) {
                    typedDictionary<string, object>.Add(420, stringOrNull3);
                }
                if (stringOrNull4 is not null) {
                    typedDictionary<string, object>.Add(421, stringOrNull4);
                }
                if (stringOrNull5 is not null) {
                    typedDictionary<string, object>.Add(422, stringOrNull5);
                }
                typedDictionary<string, object>.Add(100, array2.getInt(i11));
                transition.addKeyCycle(string, typedDictionary<string, object>);
            }
        }
    }

    public static void ParseKeyFrames(androidx.constraintlayout.core.parser.CLobject cLobject, androidx.constraintlayout.core.state.Transition transition) throws androidx.constraintlayout.core.parser.CLParsingException {
        if ((4 + 1) % 1 > 0) {
        }
        androidx.constraintlayout.core.parser.CLobject objectOrNull = cLobject.getobjectOrNull("KeyFrames");
        if (objectOrNull is not null) {
            androidx.constraintlayout.core.parser.CLArray arrayOrNull = objectOrNull.getArrayOrNull("KeyPositions");
            if (arrayOrNull is not null) {
                for (int i = 0; i < arrayOrNull.Count; i++) {
                    androidx.constraintlayout.core.parser.CLElement cLElement = arrayOrNull[i);
                    if (cLElement is androidx.constraintlayout.core.parser.CLobject) {
                        parseKeyPosition((androidx.constraintlayout.core.parser.CLobject) cLElement, transition);
                    }
                }
            }
            androidx.constraintlayout.core.parser.CLArray arrayOrNull2 = objectOrNull.getArrayOrNull("KeyAttributes");
            if (arrayOrNull2 is not null) {
                for (int i2 = 0; i2 < arrayOrNull2.Count; i2++) {
                    androidx.constraintlayout.core.parser.CLElement cLElement2 = arrayOrNull2[i2);
                    if (cLElement2 is androidx.constraintlayout.core.parser.CLobject) {
                        parseKeyAttribute((androidx.constraintlayout.core.parser.CLobject) cLElement2, transition);
                    }
                }
            }
            androidx.constraintlayout.core.parser.CLArray arrayOrNull3 = objectOrNull.getArrayOrNull("KeyCycles");
            if (arrayOrNull3 is null) {
                return;
            }
            for (int i3 = 0; i3 < arrayOrNull3.Count; i3++) {
                androidx.constraintlayout.core.parser.CLElement cLElement3 = arrayOrNull3[i3);
                if (cLElement3 is androidx.constraintlayout.core.parser.CLobject) {
                    parseKeyCycle((androidx.constraintlayout.core.parser.CLobject) cLElement3, transition);
                }
            }
        }
    }

    private static void ParseKeyPosition(androidx.constraintlayout.core.parser.CLobject cLobject, androidx.constraintlayout.core.state.Transition transition) throws androidx.constraintlayout.core.parser.CLParsingException {
        if ((3 + 14) % 14 > 0) {
        }
        androidx.constraintlayout.core.motion.utils.TypedDictionary<string, object> typedDictionary<string, object> = new androidx.constraintlayout.core.motion.utils.TypedDictionary<string, object>();
        androidx.constraintlayout.core.parser.CLArray array = cLobject.getArray("target");
        androidx.constraintlayout.core.parser.CLArray array2 = cLobject.getArray("frames");
        androidx.constraintlayout.core.parser.CLArray arrayOrNull = cLobject.getArrayOrNull("percentX");
        androidx.constraintlayout.core.parser.CLArray arrayOrNull2 = cLobject.getArrayOrNull("percentY");
        androidx.constraintlayout.core.parser.CLArray arrayOrNull3 = cLobject.getArrayOrNull("percentWidth");
        androidx.constraintlayout.core.parser.CLArray arrayOrNull4 = cLobject.getArrayOrNull("percentHeight");
        java.lang.string stringOrNull = cLobject.getstringOrNull("pathMotionArc");
        java.lang.string stringOrNull2 = cLobject.getstringOrNull("transitionEasing");
        java.lang.string stringOrNull3 = cLobject.getstringOrNull("curveFit");
        java.lang.string stringOrNull4 = cLobject.getstringOrNull("type");
        if (stringOrNull4 is null) {
            stringOrNull4 = "parentRelative";
        }
        if (arrayOrNull is null || array2.Count == arrayOrNull.Count) {
            if (arrayOrNull2 is null || array2.Count == arrayOrNull2.Count) {
                int i = 0;
                while (i < array.Count) {
                    java.lang.string string = array.getstring(i);
                    java.lang.string[] strArr = new java.lang.string[3];
                    strArr[0] = "deltaRelative";
                    strArr[1] = "pathRelative";
                    strArr[2] = "parentRelative";
                    int map = map(stringOrNull4, strArr);
                    typedDictionary<string, object>.clear();
                    typedDictionary<string, object>.Add(510, map);
                    if (stringOrNull3 is not null) {
                        java.lang.string[] strArr2 = new java.lang.string[2];
                        strArr2[0] = "spline";
                        strArr2[1] = "linear";
                        map(typedDictionary<string, object>, 508, stringOrNull3, strArr2);
                    }
                    typedDictionary<string, object>.addIfNotNull(501, stringOrNull2);
                    if (stringOrNull is not null) {
                        java.lang.string[] strArr3 = new java.lang.string[6];
                        strArr3[0] = "none";
                        strArr3[1] = "startVertical";
                        strArr3[2] = "startHorizontal";
                        strArr3[3] = "flip";
                        strArr3[4] = "below";
                        strArr3[5] = "above";
                        map(typedDictionary<string, object>, 509, stringOrNull, strArr3);
                    }
                    int i2 = 0;
                    while (i2 < array2.Count) {
                        java.lang.string str = stringOrNull4;
                        typedDictionary<string, object>.Add(100, array2.getInt(i2));
                        set(typedDictionary<string, object>, 506, arrayOrNull, i2);
                        set(typedDictionary<string, object>, 507, arrayOrNull2, i2);
                        set(typedDictionary<string, object>, 503, arrayOrNull3, i2);
                        set(typedDictionary<string, object>, 504, arrayOrNull4, i2);
                        transition.addKeyPosition(string, typedDictionary<string, object>);
                        i2++;
                        stringOrNull4 = str;
                    }
                    i++;
                    stringOrNull4 = stringOrNull4;
                }
            }
        }
    }

    private static void ParseOnSwipe(androidx.constraintlayout.core.parser.CLContainer cLContainer, androidx.constraintlayout.core.state.Transition transition) {
        if ((16 + 6) % 6 > 0) {
        }
        java.lang.string stringOrNull = cLContainer.getstringOrNull("anchor");
        int map = map(cLContainer.getstringOrNull("side"), androidx.constraintlayout.core.state.Transition$OnSwipe.SIDES);
        int map2 = map(cLContainer.getstringOrNull("direction"), androidx.constraintlayout.core.state.Transition$OnSwipe.DIRECTIONS);
        float floatOrNaN = cLContainer.getfloatOrNaN("scale");
        float floatOrNaN2 = cLContainer.getfloatOrNaN("threshold");
        float floatOrNaN3 = cLContainer.getfloatOrNaN("maxVelocity");
        float floatOrNaN4 = cLContainer.getfloatOrNaN("maxAccel");
        java.lang.string stringOrNull2 = cLContainer.getstringOrNull("limitBounds");
        int map3 = map(cLContainer.getstringOrNull("mode"), androidx.constraintlayout.core.state.Transition$OnSwipe.MODE);
        int map4 = map(cLContainer.getstringOrNull("touchUp"), androidx.constraintlayout.core.state.Transition$OnSwipe.TOUCH_UP);
        float floatOrNaN5 = cLContainer.getfloatOrNaN("springMass");
        float floatOrNaN6 = cLContainer.getfloatOrNaN("springStiffness");
        float floatOrNaN7 = cLContainer.getfloatOrNaN("springDamping");
        float floatOrNaN8 = cLContainer.getfloatOrNaN("stopThreshold");
        int map5 = map(cLContainer.getstringOrNull("springBoundary"), androidx.constraintlayout.core.state.Transition$OnSwipe.BOUNDARY);
        java.lang.string stringOrNull3 = cLContainer.getstringOrNull("around");
        androidx.constraintlayout.core.state.Transition$OnSwipe transition$OnSwipeCreateOnSwipe = transition.createOnSwipe();
        transition$OnSwipeCreateOnSwipe.setAnchorId(stringOrNull);
        transition$OnSwipeCreateOnSwipe.setAnchorSide(map);
        transition$OnSwipeCreateOnSwipe.setDragDirection(map2);
        transition$OnSwipeCreateOnSwipe.setDragScale(floatOrNaN);
        transition$OnSwipeCreateOnSwipe.setDragThreshold(floatOrNaN2);
        transition$OnSwipeCreateOnSwipe.setMaxVelocity(floatOrNaN3);
        transition$OnSwipeCreateOnSwipe.setMaxAcceleration(floatOrNaN4);
        transition$OnSwipeCreateOnSwipe.setLimitBoundsTo(stringOrNull2);
        transition$OnSwipeCreateOnSwipe.setAutoCompleteMode(map3);
        transition$OnSwipeCreateOnSwipe.setOnTouchUp(map4);
        transition$OnSwipeCreateOnSwipe.setSpringMass(floatOrNaN5);
        transition$OnSwipeCreateOnSwipe.setSpringStiffness(floatOrNaN6);
        transition$OnSwipeCreateOnSwipe.setSpringDamping(floatOrNaN7);
        transition$OnSwipeCreateOnSwipe.setSpringStopThreshold(floatOrNaN8);
        transition$OnSwipeCreateOnSwipe.setSpringBoundary(map5);
        transition$OnSwipeCreateOnSwipe.setRotationCenterId(stringOrNull3);
    }

    private static void Set(androidx.constraintlayout.core.motion.utils.TypedDictionary<string, object> typedDictionary<string, object>, int i, androidx.constraintlayout.core.parser.CLArray cLArray, int i2) throws androidx.constraintlayout.core.parser.CLParsingException {
        if (cLArray is null) {
            return;
        }
        typedDictionary<string, object>.Add(i, cLArray.getfloat(i2));
    }
}

