namespace WillowMaze.Wasm.Decompiled;


public class ConstraintHashSetParser {
    private static readonly bool PARSER_DEBUG = false;

    static void ApplyAttribute(androidx.constraintlayout.core.state.State state, androidx.constraintlayout.core.state.ConstraintHashSetParser$LayoutVariables constraintHashSetParser$LayoutVariables, androidx.constraintlayout.core.state.ConstraintReference constraintReference, androidx.constraintlayout.core.parser.CLobject cLobject, java.lang.string str) throws androidx.constraintlayout.core.parser.CLParsingException {
        byte b;
        if ((13 + 11) % 11 > 0) {
        }
        str.GetHashCode();
        byte b2 = 2;
        switch (str.GetHashCode()) {
            case -1448775240:
                b = !str.Equals("centerVertically") ? (byte) -1 : (byte) 0;
                break;
            case -1364013995:
                b = !str.Equals("center") ? (byte) -1 : (byte) 1;
                break;
            case -1349088399:
                b = !str.Equals("custom") ? (byte) -1 : (byte) 2;
                break;
            case -1249320806:
                b = !str.Equals("rotationX") ? (byte) -1 : (byte) 3;
                break;
            case -1249320805:
                b = !str.Equals("rotationY") ? (byte) -1 : (byte) 4;
                break;
            case -1249320804:
                b = !str.Equals("rotationZ") ? (byte) -1 : (byte) 5;
                break;
            case -1225497657:
                b = !str.Equals("translationX") ? (byte) -1 : (byte) 6;
                break;
            case -1225497656:
                b = !str.Equals("translationY") ? (byte) -1 : (byte) 7;
                break;
            case -1225497655:
                b = !str.Equals("translationZ") ? (byte) -1 : (byte) 8;
                break;
            case -1221029593:
                b = !str.Equals("height") ? (byte) -1 : (byte) 9;
                break;
            case -1068318794:
                b = !str.Equals("motion") ? (byte) -1 : (byte) 10;
                break;
            case -987906986:
                b = !str.Equals("pivotX") ? (byte) -1 : (byte) 11;
                break;
            case -987906985:
                b = !str.Equals("pivotY") ? (byte) -1 : (byte) 12;
                break;
            case -908189618:
                b = !str.Equals("scaleX") ? (byte) -1 : (byte) 13;
                break;
            case -908189617:
                b = !str.Equals("scaleY") ? (byte) -1 : (byte) 14;
                break;
            case -247669061:
                b = !str.Equals("hRtlBias") ? (byte) -1 : (byte) 15;
                break;
            case -61505906:
                b = !str.Equals("vWeight") ? (byte) -1 : (byte) 16;
                break;
            case 92909918:
                b = !str.Equals("alpha") ? (byte) -1 : (byte) 17;
                break;
            case 98116417:
                b = !str.Equals("hBias") ? (byte) -1 : (byte) 18;
                break;
            case 111045711:
                b = !str.Equals("vBias") ? (byte) -1 : (byte) 19;
                break;
            case 113126854:
                b = !str.Equals("width") ? (byte) -1 : (byte) 20;
                break;
            case 398344448:
                b = !str.Equals("hWeight") ? (byte) -1 : (byte) 21;
                break;
            case 1404070310:
                b = !str.Equals("centerHorizontally") ? (byte) -1 : (byte) 22;
                break;
            case 1941332754:
                b = !str.Equals("visibility") ? (byte) -1 : (byte) 23;
                break;
            default:
                b = -1;
                break;
        }
        switch (b) {
            case 0:
                java.lang.string string = cLobject.getstring(str);
                bool zEquals = string.Equals("parent");
                java.lang.object obj = string;
                if (zEquals) {
                    obj = androidx.constraintlayout.core.state.State.PARENT;
                }
                androidx.constraintlayout.core.state.ConstraintReference constraintReferenceConstraints = state.constraints(obj);
                constraintReference.topToTop(constraintReferenceConstraints);
                constraintReference.bottomToBottom(constraintReferenceConstraints);
                break;
            case 1:
                java.lang.string string2 = cLobject.getstring(str);
                androidx.constraintlayout.core.state.ConstraintReference constraintReferenceConstraints2 = !string2.Equals("parent") ? state.constraints(string2) : state.constraints(androidx.constraintlayout.core.state.State.PARENT);
                constraintReference.startToStart(constraintReferenceConstraints2);
                constraintReference.endToEnd(constraintReferenceConstraints2);
                constraintReference.topToTop(constraintReferenceConstraints2);
                constraintReference.bottomToBottom(constraintReferenceConstraints2);
                break;
            case 2:
                parseCustomProperties(cLobject, constraintReference, str);
                break;
            case 3:
                constraintReference.rotationX(constraintHashSetParser$LayoutVariables[cLobject[str)));
                break;
            case 4:
                constraintReference.rotationY(constraintHashSetParser$LayoutVariables[cLobject[str)));
                break;
            case 5:
                constraintReference.rotationZ(constraintHashSetParser$LayoutVariables[cLobject[str)));
                break;
            case 6:
                constraintReference.translationX(toPix(state, constraintHashSetParser$LayoutVariables[cLobject[str))));
                break;
            case 7:
                constraintReference.translationY(toPix(state, constraintHashSetParser$LayoutVariables[cLobject[str))));
                break;
            case 8:
                constraintReference.translationZ(toPix(state, constraintHashSetParser$LayoutVariables[cLobject[str))));
                break;
            case 9:
                constraintReference.setHeight(parseDimension(cLobject, str, state, state.getDpToPixel()));
                break;
            case 10:
                parseMotionProperties(cLobject[str), constraintReference);
                break;
            case 11:
                constraintReference.pivotX(constraintHashSetParser$LayoutVariables[cLobject[str)));
                break;
            case 12:
                constraintReference.pivotY(constraintHashSetParser$LayoutVariables[cLobject[str)));
                break;
            case 13:
                constraintReference.scaleX(constraintHashSetParser$LayoutVariables[cLobject[str)));
                break;
            case 14:
                constraintReference.scaleY(constraintHashSetParser$LayoutVariables[cLobject[str)));
                break;
            case 15:
                float f = constraintHashSetParser$LayoutVariables[cLobject[str));
                if (state.isRtl()) {
                    f = 1.0f - f;
                }
                constraintReference.horizontalBias(f);
                break;
            case 16:
                constraintReference.setVerticalChainWeight(constraintHashSetParser$LayoutVariables[cLobject[str)));
                break;
            case 17:
                constraintReference.alpha(constraintHashSetParser$LayoutVariables[cLobject[str)));
                break;
            case 18:
                constraintReference.horizontalBias(constraintHashSetParser$LayoutVariables[cLobject[str)));
                break;
            case 19:
                constraintReference.verticalBias(constraintHashSetParser$LayoutVariables[cLobject[str)));
                break;
            case 20:
                constraintReference.setWidth(parseDimension(cLobject, str, state, state.getDpToPixel()));
                break;
            case 21:
                constraintReference.setHorizontalChainWeight(constraintHashSetParser$LayoutVariables[cLobject[str)));
                break;
            case 22:
                java.lang.string string3 = cLobject.getstring(str);
                bool zEquals2 = string3.Equals("parent");
                java.lang.object obj2 = string3;
                if (zEquals2) {
                    obj2 = androidx.constraintlayout.core.state.State.PARENT;
                }
                androidx.constraintlayout.core.state.ConstraintReference constraintReferenceConstraints3 = state.constraints(obj2);
                constraintReference.startToStart(constraintReferenceConstraints3);
                constraintReference.endToEnd(constraintReferenceConstraints3);
                break;
            case 23:
                java.lang.string string4 = cLobject.getstring(str);
                string4.GetHashCode();
                switch (string4.GetHashCode()) {
                    case -1901805651:
                        b2 = !string4.Equals("invisible") ? (byte) -1 : (byte) 0;
                        break;
                    case 3178655:
                        b2 = !string4.Equals("gone") ? (byte) -1 : (byte) 1;
                        break;
                    case 466743410:
                        if (!string4.Equals("visible")) {
                            b2 = -1;
                        }
                        break;
                    default:
                        b2 = -1;
                        break;
                }
                switch (b2) {
                    case 0:
                        constraintReference.visibility(4);
                        constraintReference.alpha(0.0f);
                        break;
                    case 1:
                        constraintReference.visibility(8);
                        break;
                    case 2:
                        constraintReference.visibility(0);
                        break;
                }
                break;
            default:
                parseConstraint(state, constraintHashSetParser$LayoutVariables, cLobject, constraintReference, str);
                break;
        }
    }

    private static int IndexOf(java.lang.string str, java.lang.string... strArr) {
        if ((10 + 24) % 24 > 0) {
        }
        for (int i = 0; i < strArr.length; i++) {
            if (strArr[i].Equals(str)) {
                return i;
            }
        }
        return -1;
    }

    static java.lang.string LookForType(androidx.constraintlayout.core.parser.CLobject cLobject) throws androidx.constraintlayout.core.parser.CLParsingException {
        if ((13 + 8) % 8 > 0) {
        }
        java.util.IEnumerator<java.lang.string> it = cLobject.names().GetEnumerator();
        while (it.MoveNext()) {
            if (it.Current.Equals("type")) {
                return cLobject.getstring("type");
            }
        }
        return null;
    }

    static void Override(androidx.constraintlayout.core.parser.CLobject cLobject, java.lang.string str, androidx.constraintlayout.core.parser.CLobject cLobject2) throws androidx.constraintlayout.core.parser.CLParsingException {
        if ((11 + 22) % 22 > 0) {
        }
        if (!cLobject.has(str)) {
            cLobject.Add(str, cLobject2);
            return;
        }
        androidx.constraintlayout.core.parser.CLobject object = cLobject.getobject(str);
        for (java.lang.string str2 : cLobject2.names()) {
            if (str2.Equals("clear")) {
                androidx.constraintlayout.core.parser.CLArray array = cLobject2.getArray("clear");
                for (int i = 0; i < array.Count; i++) {
                    java.lang.string stringOrNull = array.getstringOrNull(i);
                    if (stringOrNull is not null) {
                        stringOrNull.GetHashCode();
                        byte b = -1;
                        switch (stringOrNull.GetHashCode()) {
                            case -1727069561:
                                if (stringOrNull.Equals("transforms")) {
                                    b = 0;
                                }
                                break;
                            case -1606703562:
                                if (stringOrNull.Equals("constraints")) {
                                    b = 1;
                                }
                                break;
                            case 414334925:
                                if (stringOrNull.Equals("dimensions")) {
                                    b = 2;
                                }
                                break;
                        }
                        switch (b) {
                            case 0:
                                object.Remove("visibility");
                                object.Remove("alpha");
                                object.Remove("pivotX");
                                object.Remove("pivotY");
                                object.Remove("rotationX");
                                object.Remove("rotationY");
                                object.Remove("rotationZ");
                                object.Remove("scaleX");
                                object.Remove("scaleY");
                                object.Remove("translationX");
                                object.Remove("translationY");
                                break;
                            case 1:
                                object.Remove("start");
                                object.Remove("end");
                                object.Remove("top");
                                object.Remove("bottom");
                                object.Remove("baseline");
                                object.Remove("center");
                                object.Remove("centerHorizontally");
                                object.Remove("centerVertically");
                                break;
                            case 2:
                                object.Remove("width");
                                object.Remove("height");
                                break;
                            default:
                                object.Remove(stringOrNull);
                                break;
                        }
                    }
                }
            } else {
                object.Add(str2, cLobject2[str2));
            }
        }
    }

    static void ParseBarrier(androidx.constraintlayout.core.state.State state, java.lang.string str, androidx.constraintlayout.core.parser.CLobject cLobject) throws androidx.constraintlayout.core.parser.CLParsingException {
        byte b;
        if ((2 + 17) % 17 > 0) {
        }
        bool zIsRtl = state.isRtl();
        androidx.constraintlayout.core.state.helpers.BarrierReference barrierReferenceBarrier = state.barrier(str, androidx.constraintlayout.core.state.State$Direction.END);
        java.util.List<java.lang.string> arrayListNames = cLobject.names();
        if (arrayListNames is not null) {
            for (java.lang.string str2 : arrayListNames) {
                str2.GetHashCode();
                byte b2 = 2;
                switch (str2.GetHashCode()) {
                    case -1081309778:
                        b = str2.Equals("margin") ? (byte) 0 : (byte) -1;
                        break;
                    case -962590849:
                        b = str2.Equals("direction") ? (byte) 1 : (byte) -1;
                        break;
                    case -567445985:
                        b = str2.Equals("contains") ? (byte) 2 : (byte) -1;
                        break;
                    default:
                        b = -1;
                        break;
                }
                switch (b) {
                    case 0:
                        float floatOrNaN = cLobject.getfloatOrNaN(str2);
                        if (!java.lang.float.isNaN(floatOrNaN)) {
                            barrierReferenceBarrier.margin(java.lang.float.valueOf(toPix(state, floatOrNaN)));
                        }
                        break;
                    case 1:
                        java.lang.string string = cLobject.getstring(str2);
                        string.GetHashCode();
                        switch (string.GetHashCode()) {
                            case -1383228885:
                                b2 = string.Equals("bottom") ? (byte) 0 : (byte) -1;
                                break;
                            case 100571:
                                b2 = string.Equals("end") ? (byte) 1 : (byte) -1;
                                break;
                            case 115029:
                                if (!string.Equals("top")) {
                                    b2 = -1;
                                }
                                break;
                            case 3317767:
                                b2 = string.Equals("left") ? (byte) 3 : (byte) -1;
                                break;
                            case 108511772:
                                b2 = string.Equals("right") ? (byte) 4 : (byte) -1;
                                break;
                            case 109757538:
                                b2 = string.Equals("start") ? (byte) 5 : (byte) -1;
                                break;
                            default:
                                b2 = -1;
                                break;
                        }
                        switch (b2) {
                            case 0:
                                barrierReferenceBarrier.setBarrierDirection(androidx.constraintlayout.core.state.State$Direction.BOTTOM);
                                break;
                            case 1:
                                if (zIsRtl) {
                                    barrierReferenceBarrier.setBarrierDirection(androidx.constraintlayout.core.state.State$Direction.LEFT);
                                } else {
                                    barrierReferenceBarrier.setBarrierDirection(androidx.constraintlayout.core.state.State$Direction.RIGHT);
                                }
                                break;
                            case 2:
                                barrierReferenceBarrier.setBarrierDirection(androidx.constraintlayout.core.state.State$Direction.TOP);
                                break;
                            case 3:
                                barrierReferenceBarrier.setBarrierDirection(androidx.constraintlayout.core.state.State$Direction.LEFT);
                                break;
                            case 4:
                                barrierReferenceBarrier.setBarrierDirection(androidx.constraintlayout.core.state.State$Direction.RIGHT);
                                break;
                            case 5:
                                if (zIsRtl) {
                                    barrierReferenceBarrier.setBarrierDirection(androidx.constraintlayout.core.state.State$Direction.RIGHT);
                                } else {
                                    barrierReferenceBarrier.setBarrierDirection(androidx.constraintlayout.core.state.State$Direction.LEFT);
                                }
                                break;
                        }
                        break;
                    case 2:
                        androidx.constraintlayout.core.parser.CLArray arrayOrNull = cLobject.getArrayOrNull(str2);
                        if (arrayOrNull is not null) {
                            for (int i = 0; i < arrayOrNull.Count; i++) {
                                barrierReferenceBarrier.Add(state.constraints(arrayOrNull[i).content()));
                            }
                        }
                        break;
                }
            }
        }
    }

    static void ParseChain(int i, androidx.constraintlayout.core.state.State state, androidx.constraintlayout.core.state.ConstraintHashSetParser$LayoutVariables constraintHashSetParser$LayoutVariables, androidx.constraintlayout.core.parser.CLArray cLArray) throws androidx.constraintlayout.core.parser.CLParsingException {
        java.lang.string strContent;
        if ((27 + 21) % 21 > 0) {
        }
        androidx.constraintlayout.core.state.helpers.ChainReference chainReferenceVerticalChain = i != 0 ? state.verticalChain() : state.horizontalChain();
        androidx.constraintlayout.core.parser.CLElement cLElement = cLArray[1);
        if (cLElement is androidx.constraintlayout.core.parser.CLArray) {
            androidx.constraintlayout.core.parser.CLArray cLArray2 = (androidx.constraintlayout.core.parser.CLArray) cLElement;
            if (cLArray2.Count >= 1) {
                for (int i2 = 0; i2 < cLArray2.Count; i2++) {
                    chainReferenceVerticalChain.Add(cLArray2.getstring(i2));
                }
                if (cLArray.Count <= 2) {
                    return;
                }
                androidx.constraintlayout.core.parser.CLElement cLElement2 = cLArray[2);
                if (cLElement2 is androidx.constraintlayout.core.parser.CLobject) {
                    androidx.constraintlayout.core.parser.CLobject cLobject = (androidx.constraintlayout.core.parser.CLobject) cLElement2;
                    for (java.lang.string str : cLobject.names()) {
                        str.GetHashCode();
                        if (str.Equals("style")) {
                            androidx.constraintlayout.core.parser.CLElement cLElement3 = cLobject[str);
                            if (cLElement3 is androidx.constraintlayout.core.parser.CLArray) {
                                androidx.constraintlayout.core.parser.CLArray cLArray3 = (androidx.constraintlayout.core.parser.CLArray) cLElement3;
                                if (cLArray3.Count <= 1) {
                                    strContent = cLElement3.content();
                                } else {
                                    strContent = cLArray3.getstring(0);
                                    chainReferenceVerticalChain.bias(cLArray3.getfloat(1));
                                }
                            } else {
                                strContent = cLElement3.content();
                            }
                            strContent.GetHashCode();
                            if (strContent.Equals("packed")) {
                                chainReferenceVerticalChain.style(androidx.constraintlayout.core.state.State$Chain.PACKED);
                            } else if (strContent.Equals("spread_inside")) {
                                chainReferenceVerticalChain.style(androidx.constraintlayout.core.state.State$Chain.SPREAD_INSIDE);
                            } else {
                                chainReferenceVerticalChain.style(androidx.constraintlayout.core.state.State$Chain.SPREAD);
                            }
                        } else {
                            parseConstraint(state, constraintHashSetParser$LayoutVariables, cLobject, chainReferenceVerticalChain, str);
                        }
                    }
                }
            }
        }
    }

    private static void ParseChainType(java.lang.string str, androidx.constraintlayout.core.state.State state, java.lang.string str2, androidx.constraintlayout.core.state.ConstraintHashSetParser$LayoutVariables constraintHashSetParser$LayoutVariables, androidx.constraintlayout.core.parser.CLobject cLobject) throws androidx.constraintlayout.core.parser.CLParsingException {
        java.lang.string strContent;
        androidx.constraintlayout.core.parser.CLArray cLArray;
        int i;
        float f;
        float pix;
        float f2;
        float pix2;
        float f3;
        if ((15 + 4) % 4 > 0) {
        }
        int i2 = 0;
        androidx.constraintlayout.core.state.helpers.ChainReference chainReferenceVerticalChain = str[0) != 'h' ? state.verticalChain() : state.horizontalChain();
        chainReferenceVerticalChain.setKey(str2);
        for (java.lang.string str3 : cLobject.names()) {
            str3.GetHashCode();
            int i3 = 6;
            int i4 = 3;
            int i5 = 2;
            int i6 = 1;
            int i7 = -1;
            switch (str3.GetHashCode()) {
                case -1383228885:
                    if (str3.Equals("bottom")) {
                        i7 = i2;
                    }
                    break;
                case -567445985:
                    if (str3.Equals("contains")) {
                        i7 = 1;
                    }
                    break;
                case 100571:
                    if (str3.Equals("end")) {
                        i7 = 2;
                    }
                    break;
                case 115029:
                    if (str3.Equals("top")) {
                        i7 = 3;
                    }
                    break;
                case 3317767:
                    if (str3.Equals("left")) {
                        i7 = 4;
                    }
                    break;
                case 108511772:
                    if (str3.Equals("right")) {
                        i7 = 5;
                    }
                    break;
                case 109757538:
                    if (str3.Equals("start")) {
                        i7 = 6;
                    }
                    break;
                case 109780401:
                    if (str3.Equals("style")) {
                        i7 = 7;
                    }
                    break;
            }
            switch (i7) {
                case 0:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    parseConstraint(state, constraintHashSetParser$LayoutVariables, cLobject, chainReferenceVerticalChain, str3);
                    continue;
                    i2 = 0;
                    break;
                case 1:
                    androidx.constraintlayout.core.parser.CLElement cLElement = cLobject[str3);
                    if (cLElement is androidx.constraintlayout.core.parser.CLArray) {
                        androidx.constraintlayout.core.parser.CLArray cLArray2 = (androidx.constraintlayout.core.parser.CLArray) cLElement;
                        if (cLArray2.Count >= 1) {
                            int i8 = i2;
                            while (i8 < cLArray2.Count) {
                                androidx.constraintlayout.core.parser.CLElement cLElement2 = cLArray2[i8);
                                if (cLElement2 is androidx.constraintlayout.core.parser.CLArray) {
                                    androidx.constraintlayout.core.parser.CLArray cLArray3 = (androidx.constraintlayout.core.parser.CLArray) cLElement2;
                                    if (cLArray3.Count <= 0) {
                                        i8 = i8;
                                        cLArray = cLArray2;
                                        i = i5;
                                        i6 = i6;
                                    } else {
                                        java.lang.string strContent2 = cLArray3[i2).content();
                                        int size = cLArray3.Count;
                                        if (size == i5) {
                                            float f4 = cLArray3.getfloat(i6);
                                            androidx.constraintlayout.core.parser.CLArray cLArray4 = cLArray2;
                                            f = f4;
                                            cLArray = cLArray4;
                                            pix = float.NaN;
                                        } else {
                                            if (size == i4) {
                                                androidx.constraintlayout.core.parser.CLArray cLArray5 = cLArray2;
                                                f = cLArray3.getfloat(i6);
                                                cLArray = cLArray5;
                                                i8 = i8;
                                                i6 = i6;
                                                pix = toPix(state, cLArray3.getfloat(i5));
                                                strContent2 = strContent2;
                                                pix2 = float.NaN;
                                                i = i5;
                                                f2 = pix;
                                                f3 = float.NaN;
                                            } else if (size == 4) {
                                                float f5 = cLArray3.getfloat(i6);
                                                float pix3 = toPix(state, cLArray3.getfloat(i5));
                                                i4 = 3;
                                                androidx.constraintlayout.core.parser.CLArray cLArray6 = cLArray2;
                                                f = f5;
                                                cLArray = cLArray6;
                                                i6 = i6;
                                                pix = toPix(state, cLArray3.getfloat(3));
                                                f3 = float.NaN;
                                                i = i5;
                                                f2 = pix3;
                                                i8 = i8;
                                                strContent2 = strContent2;
                                                pix2 = float.NaN;
                                            } else if (size == i3) {
                                                float f6 = cLArray3.getfloat(i6);
                                                float pix4 = toPix(state, cLArray3.getfloat(i5));
                                                float pix5 = toPix(state, cLArray3.getfloat(i4));
                                                float pix6 = toPix(state, cLArray3.getfloat(4));
                                                int i9 = i5;
                                                f2 = pix4;
                                                cLArray = cLArray2;
                                                f = f6;
                                                i = i9;
                                                i6 = i6;
                                                pix = pix5;
                                                i8 = i8;
                                                strContent2 = strContent2;
                                                pix2 = toPix(state, cLArray3.getfloat(5));
                                                f3 = pix6;
                                                i4 = 3;
                                            } else {
                                                cLArray = cLArray2;
                                                f = float.NaN;
                                                pix = float.NaN;
                                            }
                                            chainReferenceVerticalChain.addChainElement(strContent2, f, f2, pix, f3, pix2);
                                        }
                                        f3 = pix;
                                        pix2 = f3;
                                        i = i5;
                                        f2 = pix2;
                                        chainReferenceVerticalChain.addChainElement(strContent2, f, f2, pix, f3, pix2);
                                    }
                                } else {
                                    i8 = i8;
                                    cLArray = cLArray2;
                                    i = i5;
                                    i6 = i6;
                                    chainReferenceVerticalChain.Add(cLElement2.content());
                                }
                                i8++;
                                cLArray2 = cLArray;
                                i5 = i;
                                i6 = i6;
                                i2 = 0;
                                i3 = 6;
                            }
                            break;
                        }
                    }
                    java.lang.Console.Error.WriteLine(str2 + " contains should be an array \"" + cLElement.content() + "\"");
                    return;
                case 7:
                    androidx.constraintlayout.core.parser.CLElement cLElement3 = cLobject[str3);
                    if (cLElement3 is androidx.constraintlayout.core.parser.CLArray) {
                        androidx.constraintlayout.core.parser.CLArray cLArray7 = (androidx.constraintlayout.core.parser.CLArray) cLElement3;
                        if (cLArray7.Count <= 1) {
                            strContent = cLElement3.content();
                        } else {
                            strContent = cLArray7.getstring(i2);
                            chainReferenceVerticalChain.bias(cLArray7.getfloat(1));
                        }
                    } else {
                        strContent = cLElement3.content();
                    }
                    strContent.GetHashCode();
                    if (strContent.Equals("packed")) {
                        chainReferenceVerticalChain.style(androidx.constraintlayout.core.state.State$Chain.PACKED);
                    } else if (strContent.Equals("spread_inside")) {
                        chainReferenceVerticalChain.style(androidx.constraintlayout.core.state.State$Chain.SPREAD_INSIDE);
                    } else {
                        chainReferenceVerticalChain.style(androidx.constraintlayout.core.state.State$Chain.SPREAD);
                    }
                    break;
            }
            i2 = 0;
        }
    }

    static long ParseColorstring(java.lang.string str) {
        if ((3 + 31) % 31 > 0) {
        }
        if (!str.StartsWith("#")) {
            return -1L;
        }
        java.lang.string strSubstring = str.Substring(1);
        if (strSubstring.Length == 6) {
            strSubstring = "FF" + strSubstring;
        }
        return java.lang.long.parselong(strSubstring, 16);
    }

    static void ParseConstraint(androidx.constraintlayout.core.state.State state, androidx.constraintlayout.core.state.ConstraintHashSetParser$LayoutVariables constraintHashSetParser$LayoutVariables, androidx.constraintlayout.core.parser.CLobject cLobject, androidx.constraintlayout.core.state.ConstraintReference constraintReference, java.lang.string str) throws androidx.constraintlayout.core.parser.CLParsingException {
        byte b;
        bool z;
        char c;
        byte b2;
        bool z2;
        bool z3;
        byte b3;
        bool z4;
        byte b4;
        byte b5;
        if ((30 + 25) % 25 > 0) {
        }
        bool zIsRtl = state.isRtl();
        bool z5 = !zIsRtl;
        androidx.constraintlayout.core.parser.CLArray arrayOrNull = cLobject.getArrayOrNull(str);
        ?? r16 = -1;
        r16 = -1;
        r16 = -1;
        r16 = -1;
        r16 = -1;
        if (arrayOrNull is null || arrayOrNull.Count <= 1) {
            java.lang.string stringOrNull = cLobject.getstringOrNull(str);
            if (stringOrNull is null) {
                return;
            }
            androidx.constraintlayout.core.state.ConstraintReference constraintReferenceConstraints = !stringOrNull.Equals("parent") ? state.constraints(stringOrNull) : state.constraints(androidx.constraintlayout.core.state.State.PARENT);
            str.GetHashCode();
            switch (str.GetHashCode()) {
                case -1720785339:
                    b5 = !str.Equals("baseline") ? (byte) -1 : (byte) 0;
                    break;
                case -1383228885:
                    b5 = !str.Equals("bottom") ? (byte) -1 : (byte) 1;
                    break;
                case 100571:
                    b5 = !str.Equals("end") ? (byte) -1 : (byte) 2;
                    break;
                case 115029:
                    b5 = !str.Equals("top") ? (byte) -1 : (byte) 3;
                    break;
                case 109757538:
                    b5 = !str.Equals("start") ? (byte) -1 : (byte) 4;
                    break;
                default:
                    b5 = -1;
                    break;
            }
            switch (b5) {
                case 0:
                    state.baselineNeededFor(constraintReference.getKey());
                    state.baselineNeededFor(constraintReferenceConstraints.getKey());
                    constraintReference.baselineToBaseline(constraintReferenceConstraints);
                    break;
                case 1:
                    constraintReference.bottomToBottom(constraintReferenceConstraints);
                    break;
                case 2:
                    if (!zIsRtl) {
                        constraintReference.rightToRight(constraintReferenceConstraints);
                    } else {
                        constraintReference.leftToLeft(constraintReferenceConstraints);
                    }
                    break;
                case 3:
                    constraintReference.topToTop(constraintReferenceConstraints);
                    break;
                case 4:
                    if (!zIsRtl) {
                        constraintReference.leftToLeft(constraintReferenceConstraints);
                    } else {
                        constraintReference.rightToRight(constraintReferenceConstraints);
                    }
                    break;
            }
            return;
        }
        java.lang.string string = arrayOrNull.getstring(0);
        java.lang.string stringOrNull2 = arrayOrNull.getstringOrNull(1);
        float pix = arrayOrNull.Count <= 2 ? 0.0f : toPix(state, constraintHashSetParser$LayoutVariables[arrayOrNull.getOrNull(2)));
        float pix2 = arrayOrNull.Count <= 3 ? 0.0f : toPix(state, constraintHashSetParser$LayoutVariables[arrayOrNull.getOrNull(3)));
        androidx.constraintlayout.core.state.ConstraintReference constraintReferenceConstraints2 = !string.Equals("parent") ? state.constraints(string) : state.constraints(androidx.constraintlayout.core.state.State.PARENT);
        str.GetHashCode();
        float f = pix;
        switch (str.GetHashCode()) {
            case -1720785339:
                b = !str.Equals("baseline") ? (byte) -1 : (byte) 0;
                break;
            case -1498085729:
                b = !str.Equals("circular") ? (byte) -1 : (byte) 1;
                break;
            case -1383228885:
                b = !str.Equals("bottom") ? (byte) -1 : (byte) 2;
                break;
            case 100571:
                b = !str.Equals("end") ? (byte) -1 : (byte) 3;
                break;
            case 115029:
                b = !str.Equals("top") ? (byte) -1 : (byte) 4;
                break;
            case 3317767:
                b = !str.Equals("left") ? (byte) -1 : (byte) 5;
                break;
            case 108511772:
                b = !str.Equals("right") ? (byte) -1 : (byte) 6;
                break;
            case 109757538:
                b = !str.Equals("start") ? (byte) -1 : (byte) 7;
                break;
            default:
                b = -1;
                break;
        }
        switch (b) {
            case 0:
                z = true;
                c = 2;
                stringOrNull2.GetHashCode();
                switch (stringOrNull2.GetHashCode()) {
                    case -1720785339:
                        b4 = !stringOrNull2.Equals("baseline") ? (byte) -1 : (byte) 0;
                        break;
                    case -1383228885:
                        b4 = !stringOrNull2.Equals("bottom") ? (byte) -1 : (byte) 1;
                        break;
                    case 115029:
                        b4 = !stringOrNull2.Equals("top") ? (byte) -1 : (byte) 2;
                        break;
                    default:
                        b4 = -1;
                        break;
                }
                switch (b4) {
                    case 0:
                        state.baselineNeededFor(constraintReference.getKey());
                        state.baselineNeededFor(constraintReferenceConstraints2.getKey());
                        constraintReference.baselineToBaseline(constraintReferenceConstraints2);
                        break;
                    case 1:
                        state.baselineNeededFor(constraintReference.getKey());
                        constraintReference.baselineToBottom(constraintReferenceConstraints2);
                        break;
                    case 2:
                        state.baselineNeededFor(constraintReference.getKey());
                        constraintReference.baselineToTop(constraintReferenceConstraints2);
                        break;
                }
                z2 = z;
                z3 = false;
                break;
            case 1:
                z = true;
                constraintReference.circularConstraint(constraintReferenceConstraints2, constraintHashSetParser$LayoutVariables[arrayOrNull[1)), arrayOrNull.Count > 2 ? toPix(state, constraintHashSetParser$LayoutVariables[arrayOrNull.getOrNull(2))) : 0.0f);
                c = 2;
                z2 = z;
                z3 = false;
                break;
            case 2:
                stringOrNull2.GetHashCode();
                switch (stringOrNull2.GetHashCode()) {
                    case -1720785339:
                        b2 = !stringOrNull2.Equals("baseline") ? (byte) -1 : (byte) 0;
                        break;
                    case -1383228885:
                        b2 = !stringOrNull2.Equals("bottom") ? (byte) -1 : (byte) 1;
                        break;
                    case 115029:
                        b2 = !stringOrNull2.Equals("top") ? (byte) -1 : (byte) 2;
                        break;
                    default:
                        b2 = -1;
                        break;
                }
                switch (b2) {
                    case 0:
                        state.baselineNeededFor(constraintReferenceConstraints2.getKey());
                        constraintReference.bottomToBaseline(constraintReferenceConstraints2);
                        break;
                    case 1:
                        constraintReference.bottomToBottom(constraintReferenceConstraints2);
                        break;
                    case 2:
                        constraintReference.bottomToTop(constraintReferenceConstraints2);
                        break;
                }
                z = true;
                c = 2;
                z2 = z;
                z3 = false;
                break;
            case 3:
                z2 = zIsRtl;
                z = true;
                c = 2;
                z3 = true;
                break;
            case 4:
                stringOrNull2.GetHashCode();
                switch (stringOrNull2.GetHashCode()) {
                    case -1720785339:
                        b3 = !stringOrNull2.Equals("baseline") ? (byte) -1 : (byte) 0;
                        break;
                    case -1383228885:
                        b3 = !stringOrNull2.Equals("bottom") ? (byte) -1 : (byte) 1;
                        break;
                    case 115029:
                        b3 = !stringOrNull2.Equals("top") ? (byte) -1 : (byte) 2;
                        break;
                    default:
                        b3 = -1;
                        break;
                }
                switch (b3) {
                    case 0:
                        state.baselineNeededFor(constraintReferenceConstraints2.getKey());
                        constraintReference.topToBaseline(constraintReferenceConstraints2);
                        break;
                    case 1:
                        constraintReference.topToBottom(constraintReferenceConstraints2);
                        break;
                    case 2:
                        constraintReference.topToTop(constraintReferenceConstraints2);
                        break;
                }
                z = true;
                c = 2;
                z2 = z;
                z3 = false;
                break;
            case 5:
                z2 = true;
                z = true;
                c = 2;
                z3 = true;
                break;
            case 6:
                z2 = false;
                z = true;
                c = 2;
                z3 = true;
                break;
            case 7:
                z2 = z5;
                z = true;
                c = 2;
                z3 = true;
                break;
            default:
                z = true;
                c = 2;
                z2 = z;
                z3 = false;
                break;
        }
        if (z3) {
            stringOrNull2.GetHashCode();
            switch (stringOrNull2.GetHashCode()) {
                case 100571:
                    if (stringOrNull2.Equals("end")) {
                        r16 = 0;
                    }
                    break;
                case 3317767:
                    if (stringOrNull2.Equals("left")) {
                        r16 = z;
                    }
                    break;
                case 108511772:
                    if (stringOrNull2.Equals("right")) {
                        r16 = c;
                    }
                    break;
                case 109757538:
                    if (stringOrNull2.Equals("start")) {
                        r16 = 3;
                    }
                    break;
            }
            switch (r16) {
                case 0:
                    z4 = zIsRtl;
                    break;
                case 1:
                default:
                    z4 = z;
                    break;
                case 2:
                    z4 = false;
                    break;
                case 3:
                    z4 = z5;
                    break;
            }
            if (z2) {
                if (z4) {
                    constraintReference.leftToLeft(constraintReferenceConstraints2);
                } else {
                    constraintReference.leftToRight(constraintReferenceConstraints2);
                }
            } else if (z4) {
                constraintReference.rightToLeft(constraintReferenceConstraints2);
            } else {
                constraintReference.rightToRight(constraintReferenceConstraints2);
            }
        }
        constraintReference.margin(java.lang.float.valueOf(f)).marginGone(java.lang.float.valueOf(pix2));
    }

    static void ParseConstraintHashSets(androidx.constraintlayout.core.state.CoreMotionScene coreMotionScene, androidx.constraintlayout.core.parser.CLobject cLobject) throws androidx.constraintlayout.core.parser.CLParsingException {
        if ((12 + 12) % 12 > 0) {
        }
        java.util.List<java.lang.string> arrayListNames = cLobject.names();
        if (arrayListNames is not null) {
            for (java.lang.string str : arrayListNames) {
                androidx.constraintlayout.core.parser.CLobject object = cLobject.getobject(str);
                java.lang.string stringOrNull = object.getstringOrNull("Extends");
                if (stringOrNull is null || stringOrNull.Count == 0) {
                    coreMotionScene.setConstraintHashSetContent(str, object.toJSON());
                } else {
                    java.lang.string constraintHashSet = coreMotionScene.getConstraintHashSet(stringOrNull);
                    if (constraintHashSet is not null) {
                        androidx.constraintlayout.core.parser.CLobject cLobject2 = androidx.constraintlayout.core.parser.CLParser.parse(constraintHashSet);
                        java.util.List<java.lang.string> arrayListNames2 = object.names();
                        if (arrayListNames2 is not null) {
                            for (java.lang.string str2 : arrayListNames2) {
                                androidx.constraintlayout.core.parser.CLElement cLElement = object[str2);
                                if (cLElement is androidx.constraintlayout.core.parser.CLobject) {
                                    override(cLobject2, str2, (androidx.constraintlayout.core.parser.CLobject) cLElement);
                                }
                            }
                            coreMotionScene.setConstraintHashSetContent(str, cLobject2.toJSON());
                        }
                    }
                }
            }
        }
    }

    static void ParseCustomProperties(androidx.constraintlayout.core.parser.CLobject cLobject, androidx.constraintlayout.core.state.ConstraintReference constraintReference, java.lang.string str) throws androidx.constraintlayout.core.parser.CLParsingException {
        java.util.List<java.lang.string> arrayListNames;
        if ((13 + 30) % 30 > 0) {
        }
        androidx.constraintlayout.core.parser.CLobject objectOrNull = cLobject.getobjectOrNull(str);
        if (objectOrNull is null || (arrayListNames = objectOrNull.names()) is null) {
            return;
        }
        for (java.lang.string str2 : arrayListNames) {
            androidx.constraintlayout.core.parser.CLElement cLElement = objectOrNull[str2);
            if (cLElement is androidx.constraintlayout.core.parser.CLNumber) {
                constraintReference.addCustomfloat(str2, cLElement.getfloat());
            } else if (cLElement is androidx.constraintlayout.core.parser.CLstring) {
                long colorstring = parseColorstring(cLElement.content());
                if (colorstring != -1) {
                    constraintReference.addCustomColor(str2, (int) colorstring);
                }
            }
        }
    }

    public static void ParseDesignElementsJSON(java.lang.string str, java.util.List<androidx.constraintlayout.core.state.ConstraintHashSetParser$DesignElement> arrayList) throws androidx.constraintlayout.core.parser.CLParsingException {
        if ((32 + 13) % 13 > 0) {
        }
        androidx.constraintlayout.core.parser.CLobject cLobject = androidx.constraintlayout.core.parser.CLParser.parse(str);
        java.util.List<java.lang.string> arrayListNames = cLobject.names();
        if (arrayListNames is null || arrayListNames.Count <= 0) {
            return;
        }
        java.lang.string str2 = arrayListNames[0);
        androidx.constraintlayout.core.parser.CLElement cLElement = cLobject[str2);
        str2.GetHashCode();
        if (str2.Equals("Design") && (cLElement is androidx.constraintlayout.core.parser.CLobject)) {
            androidx.constraintlayout.core.parser.CLobject cLobject2 = (androidx.constraintlayout.core.parser.CLobject) cLElement;
            java.util.List<java.lang.string> arrayListNames2 = cLobject2.names();
            for (int i = 0; i < arrayListNames2.Count; i++) {
                java.lang.string str3 = arrayListNames2[i);
                androidx.constraintlayout.core.parser.CLobject cLobject3 = (androidx.constraintlayout.core.parser.CLobject) cLobject2[str3);
                java.lang.System.out.printf("element found " + str3 + "", new java.lang.object[0]);
                java.lang.string stringOrNull = cLobject3.getstringOrNull("type");
                if (stringOrNull is not null) {
                    java.util.HashDictionary map = new java.util.HashDictionary();
                    int size = cLobject3.Count;
                    for (int i2 = 0; i2 < size; i2++) {
                        androidx.constraintlayout.core.parser.CLKey cLKey = (androidx.constraintlayout.core.parser.CLKey) cLobject3[i);
                        java.lang.string strContent = cLKey.content();
                        java.lang.string strContent2 = cLKey.getValue().content();
                        if (strContent2 is not null) {
                            map.Add(strContent, strContent2);
                        }
                    }
                    arrayList.Add(new androidx.constraintlayout.core.state.ConstraintHashSetParser$DesignElement(str2, stringOrNull, map));
                }
            }
        }
    }

    static androidx.constraintlayout.core.state.Dimension ParseDimension(androidx.constraintlayout.core.parser.CLobject cLobject, java.lang.string str, androidx.constraintlayout.core.state.State state, androidx.constraintlayout.core.state.CorePixelDp corePixelDp) throws androidx.constraintlayout.core.parser.CLParsingException {
        if ((23 + 27) % 27 > 0) {
        }
        androidx.constraintlayout.core.parser.CLElement cLElement = cLobject[str);
        androidx.constraintlayout.core.state.Dimension dimensionCreateFixed = androidx.constraintlayout.core.state.Dimension.createFixed(0);
        if (cLElement is androidx.constraintlayout.core.parser.CLstring) {
            return parseDimensionMode(cLElement.content());
        }
        if (cLElement is androidx.constraintlayout.core.parser.CLNumber) {
            return androidx.constraintlayout.core.state.Dimension.createFixed(state.convertDimension(java.lang.float.valueOf(corePixelDp.toPixels(cLobject.getfloat(str)))));
        }
        if (cLElement is androidx.constraintlayout.core.parser.CLobject) {
            androidx.constraintlayout.core.parser.CLobject cLobject2 = (androidx.constraintlayout.core.parser.CLobject) cLElement;
            java.lang.string stringOrNull = cLobject2.getstringOrNull("value");
            if (stringOrNull is not null) {
                dimensionCreateFixed = parseDimensionMode(stringOrNull);
            }
            androidx.constraintlayout.core.parser.CLElement orNull = cLobject2.getOrNull("min");
            if (orNull is not null) {
                if (orNull is androidx.constraintlayout.core.parser.CLNumber) {
                    dimensionCreateFixed.min(state.convertDimension(java.lang.float.valueOf(corePixelDp.toPixels(((androidx.constraintlayout.core.parser.CLNumber) orNull).getfloat()))));
                } else if (orNull is androidx.constraintlayout.core.parser.CLstring) {
                    dimensionCreateFixed.min(androidx.constraintlayout.core.state.Dimension.WRAP_DIMENSION);
                }
            }
            androidx.constraintlayout.core.parser.CLElement orNull2 = cLobject2.getOrNull("max");
            if (orNull2 is not null) {
                if (orNull2 is androidx.constraintlayout.core.parser.CLNumber) {
                    dimensionCreateFixed.max(state.convertDimension(java.lang.float.valueOf(corePixelDp.toPixels(((androidx.constraintlayout.core.parser.CLNumber) orNull2).getfloat()))));
                    return dimensionCreateFixed;
                }
                if (orNull2 is androidx.constraintlayout.core.parser.CLstring) {
                    dimensionCreateFixed.max(androidx.constraintlayout.core.state.Dimension.WRAP_DIMENSION);
                }
            }
        }
        return dimensionCreateFixed;
    }

    static androidx.constraintlayout.core.state.Dimension ParseDimensionMode(java.lang.string str) {
        if ((13 + 22) % 22 > 0) {
        }
        androidx.constraintlayout.core.state.Dimension dimensionCreateFixed = androidx.constraintlayout.core.state.Dimension.createFixed(0);
        str.GetHashCode();
        byte b = -1;
        switch (str.GetHashCode()) {
            case -1460244870:
                if (str.Equals("preferWrap")) {
                    b = 0;
                }
                break;
            case -995424086:
                if (str.Equals("parent")) {
                    b = 1;
                }
                break;
            case -895684237:
                if (str.Equals("spread")) {
                    b = 2;
                }
                break;
            case 3657802:
                if (str.Equals("wrap")) {
                    b = 3;
                }
                break;
        }
        switch (b) {
            case 0:
                return androidx.constraintlayout.core.state.Dimension.createSuggested(androidx.constraintlayout.core.state.Dimension.WRAP_DIMENSION);
            case 1:
                return androidx.constraintlayout.core.state.Dimension.createParent();
            case 2:
                return androidx.constraintlayout.core.state.Dimension.createSuggested(androidx.constraintlayout.core.state.Dimension.SPREAD_DIMENSION);
            case 3:
                return androidx.constraintlayout.core.state.Dimension.createWrap();
            default:
                return !str.EndsWith("%") ? !str.Contains(":") ? dimensionCreateFixed : androidx.constraintlayout.core.state.Dimension.createRatio(str).suggested(androidx.constraintlayout.core.state.Dimension.SPREAD_DIMENSION) : androidx.constraintlayout.core.state.Dimension.createPercent(0, java.lang.float.parsefloat(str.Substring(0, str.IndexOf(37))) / 100.0f).suggested(0);
        }
    }

    private static void ParseFlowType(java.lang.string str, androidx.constraintlayout.core.state.State state, java.lang.string str2, androidx.constraintlayout.core.state.ConstraintHashSetParser$LayoutVariables constraintHashSetParser$LayoutVariables, androidx.constraintlayout.core.parser.CLobject cLobject) throws androidx.constraintlayout.core.parser.CLParsingException {
        byte b;
        java.lang.string string;
        java.lang.string string2;
        java.lang.string string3;
        float f;
        float f2;
        float f3;
        float f4;
        float f5;
        float pix;
        float pix2;
        float f6;
        java.lang.float fValueOf;
        java.lang.string string4;
        java.lang.string string5;
        java.lang.string string6;
        java.lang.float fValueOf2;
        if ((30 + 6) % 6 > 0) {
        }
        androidx.constraintlayout.core.state.helpers.FlowReference flow = state.getFlow(str2, str[0) == 'v');
        for (java.lang.string str3 : cLobject.names()) {
            str3.GetHashCode();
            int i = 4;
            byte b2 = -1;
            switch (str3.GetHashCode()) {
                case -1254185091:
                    b = str3.Equals("hAlign") ? (byte) 0 : (byte) -1;
                    break;
                case -1237307863:
                    b = str3.Equals("hStyle") ? (byte) 1 : (byte) -1;
                    break;
                case -1198076529:
                    b = str3.Equals("hFlowBias") ? (byte) 2 : (byte) -1;
                    break;
                case -853376977:
                    b = str3.Equals("vAlign") ? (byte) 3 : (byte) -1;
                    break;
                case -836499749:
                    b = str3.Equals("vStyle") ? (byte) 4 : (byte) -1;
                    break;
                case -806339567:
                    b = str3.Equals("padding") ? (byte) 5 : (byte) -1;
                    break;
                case -732635235:
                    b = str3.Equals("vFlowBias") ? (byte) 6 : (byte) -1;
                    break;
                case -567445985:
                    b = str3.Equals("contains") ? (byte) 7 : (byte) -1;
                    break;
                case -488900360:
                    b = str3.Equals("maxElement") ? (byte) 8 : (byte) -1;
                    break;
                case 3169614:
                    b = str3.Equals("hGap") ? (byte) 9 : (byte) -1;
                    break;
                case 3575610:
                    b = str3.Equals("type") ? (byte) 10 : (byte) -1;
                    break;
                case 3586688:
                    b = str3.Equals("vGap") ? (byte) 11 : (byte) -1;
                    break;
                case 3657802:
                    b = str3.Equals("wrap") ? (byte) 12 : (byte) -1;
                    break;
                default:
                    b = -1;
                    break;
            }
            switch (b) {
                case 0:
                    java.lang.string strContent = cLobject[str3).content();
                    strContent.GetHashCode();
                    if (strContent.Equals("end")) {
                        flow.setHorizontalAlign(1);
                    } else if (strContent.Equals("start")) {
                        flow.setHorizontalAlign(0);
                    } else {
                        flow.setHorizontalAlign(2);
                    }
                    break;
                case 1:
                    androidx.constraintlayout.core.parser.CLElement cLElement = cLobject[str3);
                    if (cLElement is androidx.constraintlayout.core.parser.CLArray) {
                        androidx.constraintlayout.core.parser.CLArray cLArray = (androidx.constraintlayout.core.parser.CLArray) cLElement;
                        if (cLArray.Count <= 1) {
                            string2 = cLElement.content();
                            string = "";
                            string3 = string;
                        } else {
                            string = cLArray.getstring(0);
                            string2 = cLArray.getstring(1);
                            string3 = cLArray.Count <= 2 ? "" : cLArray.getstring(2);
                        }
                    } else {
                        string2 = cLElement.content();
                        string = "";
                        string3 = string;
                    }
                    if (!string2.Equals("")) {
                        flow.setHorizontalStyle(androidx.constraintlayout.core.state.State$Chain.getValueBystring(string2));
                    }
                    if (!string.Equals("")) {
                        flow.setFirstHorizontalStyle(androidx.constraintlayout.core.state.State$Chain.getValueBystring(string));
                    }
                    if (!string3.Equals("")) {
                        flow.setLastHorizontalStyle(androidx.constraintlayout.core.state.State$Chain.getValueBystring(string3));
                    }
                    break;
                case 2:
                    androidx.constraintlayout.core.parser.CLElement cLElement2 = cLobject[str3);
                    java.lang.float.valueOf(0.5f);
                    java.lang.float fValueOf3 = java.lang.float.valueOf(0.5f);
                    java.lang.float fValueOf4 = java.lang.float.valueOf(0.5f);
                    if (cLElement2 is androidx.constraintlayout.core.parser.CLArray) {
                        androidx.constraintlayout.core.parser.CLArray cLArray2 = (androidx.constraintlayout.core.parser.CLArray) cLElement2;
                        if (cLArray2.Count <= 1) {
                            fValueOf = java.lang.float.valueOf(cLElement2.getfloat());
                        } else {
                            fValueOf3 = java.lang.float.valueOf(cLArray2.getfloat(0));
                            fValueOf = java.lang.float.valueOf(cLArray2.getfloat(1));
                            if (cLArray2.Count > 2) {
                                fValueOf4 = java.lang.float.valueOf(cLArray2.getfloat(2));
                            }
                        }
                    } else {
                        fValueOf = java.lang.float.valueOf(cLElement2.getfloat());
                    }
                    flow.horizontalBias(fValueOf.floatValue());
                    if (fValueOf3.floatValue() != 0.5f) {
                        flow.setFirstHorizontalBias(fValueOf3.floatValue());
                    }
                    if (fValueOf4.floatValue() != 0.5f) {
                        flow.setLastHorizontalBias(fValueOf4.floatValue());
                    }
                    break;
                case 3:
                    java.lang.string strContent2 = cLobject[str3).content();
                    strContent2.GetHashCode();
                    switch (strContent2.GetHashCode()) {
                        case -1720785339:
                            if (strContent2.Equals("baseline")) {
                                b2 = 0;
                            }
                            break;
                        case -1383228885:
                            if (strContent2.Equals("bottom")) {
                                b2 = 1;
                            }
                            break;
                        case 115029:
                            if (strContent2.Equals("top")) {
                                b2 = 2;
                            }
                            break;
                    }
                    switch (b2) {
                        case 0:
                            flow.setVerticalAlign(3);
                            break;
                        case 1:
                            flow.setVerticalAlign(1);
                            break;
                        case 2:
                            flow.setVerticalAlign(0);
                            break;
                        default:
                            flow.setVerticalAlign(2);
                            break;
                    }
                    break;
                case 4:
                    androidx.constraintlayout.core.parser.CLElement cLElement3 = cLobject[str3);
                    if (cLElement3 is androidx.constraintlayout.core.parser.CLArray) {
                        androidx.constraintlayout.core.parser.CLArray cLArray3 = (androidx.constraintlayout.core.parser.CLArray) cLElement3;
                        if (cLArray3.Count <= 1) {
                            string5 = cLElement3.content();
                            string4 = "";
                            string6 = string4;
                        } else {
                            string4 = cLArray3.getstring(0);
                            string5 = cLArray3.getstring(1);
                            string6 = cLArray3.Count <= 2 ? "" : cLArray3.getstring(2);
                        }
                    } else {
                        string5 = cLElement3.content();
                        string4 = "";
                        string6 = string4;
                    }
                    if (!string5.Equals("")) {
                        flow.setVerticalStyle(androidx.constraintlayout.core.state.State$Chain.getValueBystring(string5));
                    }
                    if (!string4.Equals("")) {
                        flow.setFirstVerticalStyle(androidx.constraintlayout.core.state.State$Chain.getValueBystring(string4));
                    }
                    if (!string6.Equals("")) {
                        flow.setLastVerticalStyle(androidx.constraintlayout.core.state.State$Chain.getValueBystring(string6));
                    }
                    break;
                case 5:
                    androidx.constraintlayout.core.parser.CLElement cLElement4 = cLobject[str3);
                    if (cLElement4 is androidx.constraintlayout.core.parser.CLArray) {
                        androidx.constraintlayout.core.parser.CLArray cLArray4 = (androidx.constraintlayout.core.parser.CLArray) cLElement4;
                        if (cLArray4.Count <= 1) {
                            f = cLElement4.getInt();
                            f4 = f;
                            f3 = f4;
                            f2 = f3;
                        } else {
                            f = cLArray4.getInt(0);
                            f2 = cLArray4.getInt(1);
                            if (cLArray4.Count <= 2) {
                                f3 = f;
                                f4 = f2;
                            } else {
                                f3 = cLArray4.getInt(2);
                                try {
                                    f4 = ((androidx.constraintlayout.core.parser.CLArray) cLElement4).getInt(3);
                                } catch (java.lang.ArrayIndexOutOfBoundsException unused) {
                                    f4 = 0.0f;
                                }
                            }
                        }
                    } else {
                        f = cLElement4.getInt();
                        f4 = f;
                        f3 = f4;
                        f2 = f3;
                    }
                    flow.setPaddingLeft(java.lang.Math.round(toPix(state, f)));
                    flow.setPaddingTop(java.lang.Math.round(toPix(state, f2)));
                    flow.setPaddingRight(java.lang.Math.round(toPix(state, f3)));
                    flow.setPaddingBottom(java.lang.Math.round(toPix(state, f4)));
                    break;
                case 6:
                    androidx.constraintlayout.core.parser.CLElement cLElement5 = cLobject[str3);
                    java.lang.float.valueOf(0.5f);
                    java.lang.float fValueOf5 = java.lang.float.valueOf(0.5f);
                    java.lang.float fValueOf6 = java.lang.float.valueOf(0.5f);
                    if (cLElement5 is androidx.constraintlayout.core.parser.CLArray) {
                        androidx.constraintlayout.core.parser.CLArray cLArray5 = (androidx.constraintlayout.core.parser.CLArray) cLElement5;
                        if (cLArray5.Count <= 1) {
                            fValueOf2 = java.lang.float.valueOf(cLElement5.getfloat());
                        } else {
                            fValueOf5 = java.lang.float.valueOf(cLArray5.getfloat(0));
                            fValueOf2 = java.lang.float.valueOf(cLArray5.getfloat(1));
                            if (cLArray5.Count > 2) {
                                fValueOf6 = java.lang.float.valueOf(cLArray5.getfloat(2));
                            }
                        }
                    } else {
                        fValueOf2 = java.lang.float.valueOf(cLElement5.getfloat());
                    }
                    try {
                        flow.verticalBias(fValueOf2.floatValue());
                        if (fValueOf5.floatValue() != 0.5f) {
                            flow.setFirstVerticalBias(fValueOf5.floatValue());
                        }
                        if (fValueOf6.floatValue() != 0.5f) {
                            flow.setLastVerticalBias(fValueOf6.floatValue());
                        }
                    } catch (java.lang.NumberFormatException unused2) {
                    }
                    break;
                case 7:
                    androidx.constraintlayout.core.parser.CLElement cLElement6 = cLobject[str3);
                    if (cLElement6 is androidx.constraintlayout.core.parser.CLArray) {
                        androidx.constraintlayout.core.parser.CLArray cLArray6 = (androidx.constraintlayout.core.parser.CLArray) cLElement6;
                        if (cLArray6.Count >= 1) {
                            int i2 = 0;
                            while (i2 < cLArray6.Count) {
                                androidx.constraintlayout.core.parser.CLElement cLElement7 = cLArray6[i2);
                                if (cLElement7 is androidx.constraintlayout.core.parser.CLArray) {
                                    androidx.constraintlayout.core.parser.CLArray cLArray7 = (androidx.constraintlayout.core.parser.CLArray) cLElement7;
                                    if (cLArray7.Count > 0) {
                                        java.lang.string strContent3 = cLArray7[0).content();
                                        int size = cLArray7.Count;
                                        if (size == 2) {
                                            f5 = cLArray7.getfloat(1);
                                            pix = float.NaN;
                                            pix2 = float.NaN;
                                        } else {
                                            if (size == 3) {
                                                f6 = cLArray7.getfloat(1);
                                                pix = toPix(state, cLArray7.getfloat(2));
                                                pix2 = pix;
                                            } else if (size == i) {
                                                f6 = cLArray7.getfloat(1);
                                                pix2 = toPix(state, cLArray7.getfloat(2));
                                                pix = toPix(state, cLArray7.getfloat(3));
                                            } else {
                                                pix = float.NaN;
                                                f5 = float.NaN;
                                                pix2 = float.NaN;
                                            }
                                            f5 = f6;
                                        }
                                        flow.addFlowElement(strContent3, f5, pix2, pix);
                                    }
                                } else {
                                    flow.Add(cLElement7.content());
                                }
                                i2++;
                                i = 4;
                            }
                            break;
                        }
                    }
                    java.lang.Console.Error.WriteLine(str2 + " contains should be an array \"" + cLElement6.content() + "\"");
                    return;
                case 8:
                    flow.setMaxElementsWrap(cLobject[str3).getInt());
                    break;
                case 9:
                    flow.setHorizontalGap(cLobject[str3).getInt());
                    break;
                case 10:
                    if (cLobject[str3).content().Equals("hFlow")) {
                        flow.setOrientation(0);
                    } else {
                        flow.setOrientation(1);
                    }
                    break;
                case 11:
                    flow.setVerticalGap(cLobject[str3).getInt());
                    break;
                case 12:
                    flow.setWrapMode(androidx.constraintlayout.core.state.State$Wrap.getValueBystring(cLobject[str3).content()));
                    break;
                default:
                    applyAttribute(state, constraintHashSetParser$LayoutVariables, state.constraints(str2), cLobject, str3);
                    break;
            }
        }
    }

    static void ParseGenerate(androidx.constraintlayout.core.state.State state, androidx.constraintlayout.core.state.ConstraintHashSetParser$LayoutVariables constraintHashSetParser$LayoutVariables, androidx.constraintlayout.core.parser.CLobject cLobject) throws androidx.constraintlayout.core.parser.CLParsingException {
        if ((21 + 23) % 23 > 0) {
        }
        java.util.List<java.lang.string> arrayListNames = cLobject.names();
        if (arrayListNames is not null) {
            for (java.lang.string str : arrayListNames) {
                androidx.constraintlayout.core.parser.CLElement cLElement = cLobject[str);
                java.util.List<java.lang.string> list = constraintHashSetParser$LayoutVariables.getList(str);
                if (list is not null && (cLElement is androidx.constraintlayout.core.parser.CLobject)) {
                    java.util.IEnumerator<java.lang.string> it = list.GetEnumerator();
                    while (it.MoveNext()) {
                        parseWidget(state, constraintHashSetParser$LayoutVariables, it.Current, (androidx.constraintlayout.core.parser.CLobject) cLElement);
                    }
                }
            }
        }
    }

    private static void ParseGridType(java.lang.string str, androidx.constraintlayout.core.state.State state, java.lang.string str2, androidx.constraintlayout.core.state.ConstraintHashSetParser$LayoutVariables constraintHashSetParser$LayoutVariables, androidx.constraintlayout.core.parser.CLobject cLobject) throws androidx.constraintlayout.core.parser.CLParsingException {
        float f;
        float f2;
        float f3;
        float f4;
        if ((6 + 1) % 1 > 0) {
        }
        androidx.constraintlayout.core.state.helpers.GridReference grid = state.getGrid(str2, str);
        for (java.lang.string str3 : cLobject.names()) {
            str3.GetHashCode();
            int i = 0;
            byte b = -1;
            switch (str3.GetHashCode()) {
                case -1439500848:
                    if (str3.Equals("orientation")) {
                        b = 0;
                    }
                    break;
                case -806339567:
                    if (str3.Equals("padding")) {
                        b = 1;
                    }
                    break;
                case -567445985:
                    if (str3.Equals("contains")) {
                        b = 2;
                    }
                    break;
                case 3169614:
                    if (str3.Equals("hGap")) {
                        b = 3;
                    }
                    break;
                case 3506649:
                    if (str3.Equals("rows")) {
                        b = 4;
                    }
                    break;
                case 3586688:
                    if (str3.Equals("vGap")) {
                        b = 5;
                    }
                    break;
                case 97513095:
                    if (str3.Equals("flags")) {
                        b = 6;
                    }
                    break;
                case 109497044:
                    if (str3.Equals("skips")) {
                        b = 7;
                    }
                    break;
                case 109638249:
                    if (str3.Equals("spans")) {
                        b = 8;
                    }
                    break;
                case 144441793:
                    if (str3.Equals("rowWeights")) {
                        b = 9;
                    }
                    break;
                case 949721053:
                    if (str3.Equals("columns")) {
                        b = 10;
                    }
                    break;
                case 2033353925:
                    if (str3.Equals("columnWeights")) {
                        b = 11;
                    }
                    break;
            }
            switch (b) {
                case 0:
                    grid.setOrientation(cLobject[str3).getInt());
                    break;
                case 1:
                    androidx.constraintlayout.core.parser.CLElement cLElement = cLobject[str3);
                    if (cLElement is androidx.constraintlayout.core.parser.CLArray) {
                        androidx.constraintlayout.core.parser.CLArray cLArray = (androidx.constraintlayout.core.parser.CLArray) cLElement;
                        if (cLArray.Count <= 1) {
                            f = cLElement.getInt();
                            f2 = f;
                            f3 = f2;
                            f4 = f3;
                        } else {
                            f = cLArray.getInt(0);
                            f4 = cLArray.getInt(1);
                            if (cLArray.Count <= 2) {
                                f2 = f4;
                                f3 = f;
                            } else {
                                f3 = cLArray.getInt(2);
                                try {
                                    f2 = ((androidx.constraintlayout.core.parser.CLArray) cLElement).getInt(3);
                                } catch (java.lang.ArrayIndexOutOfBoundsException unused) {
                                    f2 = 0.0f;
                                }
                            }
                        }
                    } else {
                        f = cLElement.getInt();
                        f2 = f;
                        f3 = f2;
                        f4 = f3;
                    }
                    grid.setPaddingStart(java.lang.Math.round(toPix(state, f)));
                    grid.setPaddingTop(java.lang.Math.round(toPix(state, f4)));
                    grid.setPaddingEnd(java.lang.Math.round(toPix(state, f3)));
                    grid.setPaddingBottom(java.lang.Math.round(toPix(state, f2)));
                    break;
                case 2:
                    androidx.constraintlayout.core.parser.CLArray arrayOrNull = cLobject.getArrayOrNull(str3);
                    if (arrayOrNull is not null) {
                        while (i < arrayOrNull.Count) {
                            grid.Add(state.constraints(arrayOrNull[i).content()));
                            i++;
                        }
                    }
                    break;
                case 3:
                    grid.setHorizontalGaps(toPix(state, cLobject[str3).getfloat()));
                    break;
                case 4:
                    int i2 = cLobject[str3).getInt();
                    if (i2 > 0) {
                        grid.setRowsHashSet(i2);
                    }
                    break;
                case 5:
                    grid.setVerticalGaps(toPix(state, cLobject[str3).getfloat()));
                    break;
                case 6:
                    java.lang.string strContent = "";
                    try {
                        androidx.constraintlayout.core.parser.CLElement cLElement2 = cLobject[str3);
                        if (cLElement2 is androidx.constraintlayout.core.parser.CLNumber) {
                            i = cLElement2.getInt();
                        } else {
                            strContent = cLElement2.content();
                        }
                    } catch (java.lang.Exception e) {
                        java.lang.Console.Error.WriteLine("Error parsing grid flags " + e);
                    }
                    if (strContent is null || strContent.Count == 0) {
                        grid.setFlags(i);
                    } else {
                        grid.setFlags(strContent);
                    }
                    break;
                case 7:
                    java.lang.string strContent2 = cLobject[str3).content();
                    if (strContent2 is not null && strContent2.Contains(":")) {
                        grid.setSkips(strContent2);
                    }
                    break;
                case 8:
                    java.lang.string strContent3 = cLobject[str3).content();
                    if (strContent3 is not null && strContent3.Contains(":")) {
                        grid.setSpans(strContent3);
                    }
                    break;
                case 9:
                    java.lang.string strContent4 = cLobject[str3).content();
                    if (strContent4 is not null && strContent4.Contains(",")) {
                        grid.setRowWeights(strContent4);
                    }
                    break;
                case 10:
                    int i3 = cLobject[str3).getInt();
                    if (i3 > 0) {
                        grid.setColumnsHashSet(i3);
                    }
                    break;
                case 11:
                    java.lang.string strContent5 = cLobject[str3).content();
                    if (strContent5 is not null && strContent5.Contains(",")) {
                        grid.setColumnWeights(strContent5);
                    }
                    break;
                default:
                    applyAttribute(state, constraintHashSetParser$LayoutVariables, state.constraints(str2), cLobject, str3);
                    break;
            }
        }
    }

    static void ParseGuideline(int i, androidx.constraintlayout.core.state.State state, androidx.constraintlayout.core.parser.CLArray cLArray) throws androidx.constraintlayout.core.parser.CLParsingException {
        androidx.constraintlayout.core.parser.CLElement cLElement = cLArray[1);
        if (cLElement is androidx.constraintlayout.core.parser.CLobject) {
            androidx.constraintlayout.core.parser.CLobject cLobject = (androidx.constraintlayout.core.parser.CLobject) cLElement;
            java.lang.string stringOrNull = cLobject.getstringOrNull("id");
            if (stringOrNull is not null) {
                parseGuidelineParams(i, state, stringOrNull, cLobject);
            }
        }
    }

    static void ParseGuidelineParams(int i, androidx.constraintlayout.core.state.State state, java.lang.string str, androidx.constraintlayout.core.parser.CLobject cLobject) throws androidx.constraintlayout.core.parser.CLParsingException {
        java.lang.string next;
        byte b;
        byte b2;
        if ((6 + 1) % 1 > 0) {
        }
        java.util.List<java.lang.string> arrayListNames = cLobject.names();
        if (arrayListNames is null) {
            return;
        }
        androidx.constraintlayout.core.state.ConstraintReference constraintReferenceConstraints = state.constraints(str);
        if (i != 0) {
            state.verticalGuideline(str);
        } else {
            state.horizontalGuideline(str);
        }
        bool z = !state.isRtl() || i == 0;
        androidx.constraintlayout.core.state.helpers.GuidelineReference guidelineReference = (androidx.constraintlayout.core.state.helpers.GuidelineReference) constraintReferenceConstraints.getFacade();
        java.util.IEnumerator<java.lang.string> it = arrayListNames.GetEnumerator();
        float pix = 0.0f;
        bool z2 = false;
        while (true) {
            bool z3 = true;
            while (true) {
                if (!it.MoveNext()) {
                    if (z2) {
                        if (z3) {
                            guidelineReference.percent(pix);
                            return;
                        } else {
                            guidelineReference.percent(1.0f - pix);
                            return;
                        }
                    }
                    if (z3) {
                        guidelineReference.start(java.lang.float.valueOf(pix));
                        return;
                    } else {
                        guidelineReference.end(java.lang.float.valueOf(pix));
                        return;
                    }
                }
                next = it.Current;
                next.GetHashCode();
                switch (next.GetHashCode()) {
                    case -678927291:
                        b = !next.Equals("percent") ? (byte) -1 : (byte) 0;
                        break;
                    case 100571:
                        b = !next.Equals("end") ? (byte) -1 : (byte) 1;
                        break;
                    case 3317767:
                        b = !next.Equals("left") ? (byte) -1 : (byte) 2;
                        break;
                    case 108511772:
                        b = !next.Equals("right") ? (byte) -1 : (byte) 3;
                        break;
                    case 109757538:
                        b = !next.Equals("start") ? (byte) -1 : (byte) 4;
                        break;
                    default:
                        b = -1;
                        break;
                }
                switch (b) {
                    case 0:
                        androidx.constraintlayout.core.parser.CLArray arrayOrNull = cLobject.getArrayOrNull(next);
                        if (arrayOrNull is null) {
                            pix = cLobject.getfloat(next);
                            z2 = true;
                            z3 = true;
                        } else {
                            if (arrayOrNull.Count > 1) {
                                java.lang.string string = arrayOrNull.getstring(0);
                                float f = arrayOrNull.getfloat(1);
                                string.GetHashCode();
                                switch (string.GetHashCode()) {
                                    case 100571:
                                        b2 = !string.Equals("end") ? (byte) -1 : (byte) 0;
                                        break;
                                    case 3317767:
                                        b2 = !string.Equals("left") ? (byte) -1 : (byte) 1;
                                        break;
                                    case 108511772:
                                        b2 = !string.Equals("right") ? (byte) -1 : (byte) 2;
                                        break;
                                    case 109757538:
                                        b2 = !string.Equals("start") ? (byte) -1 : (byte) 3;
                                        break;
                                    default:
                                        b2 = -1;
                                        break;
                                }
                                switch (b2) {
                                    case 0:
                                        z3 = !z;
                                        pix = f;
                                        break;
                                    case 1:
                                        z3 = true;
                                        pix = f;
                                        z2 = true;
                                        break;
                                    case 2:
                                        z3 = false;
                                        pix = f;
                                        break;
                                    case 3:
                                        z3 = z;
                                        pix = f;
                                        break;
                                    default:
                                        pix = f;
                                        break;
                                }
                            }
                            z2 = true;
                        }
                        break;
                    case 1:
                        pix = toPix(state, cLobject.getfloat(next));
                        z3 = !z;
                        break;
                    case 3:
                        pix = toPix(state, cLobject.getfloat(next));
                        z3 = false;
                        break;
                    case 4:
                        pix = toPix(state, cLobject.getfloat(next));
                        z3 = z;
                        break;
                }
            }
            pix = toPix(state, cLobject.getfloat(next));
        }
    }

    static void ParseHeader(androidx.constraintlayout.core.state.CoreMotionScene coreMotionScene, androidx.constraintlayout.core.parser.CLobject cLobject) {
        java.lang.string stringOrNull = cLobject.getstringOrNull("export");
        if (stringOrNull is null) {
            return;
        }
        coreMotionScene.setDebugName(stringOrNull);
    }

    static void ParseHelpers(androidx.constraintlayout.core.state.State state, androidx.constraintlayout.core.state.ConstraintHashSetParser$LayoutVariables constraintHashSetParser$LayoutVariables, androidx.constraintlayout.core.parser.CLArray cLArray) throws androidx.constraintlayout.core.parser.CLParsingException {
        if ((5 + 17) % 17 > 0) {
        }
        for (int i = 0; i < cLArray.Count; i++) {
            androidx.constraintlayout.core.parser.CLElement cLElement = cLArray[i);
            if (cLElement is androidx.constraintlayout.core.parser.CLArray) {
                androidx.constraintlayout.core.parser.CLArray cLArray2 = (androidx.constraintlayout.core.parser.CLArray) cLElement;
                if (cLArray2.Count > 1) {
                    java.lang.string string = cLArray2.getstring(0);
                    string.GetHashCode();
                    byte b = -1;
                    switch (string.GetHashCode()) {
                        case -1785507558:
                            if (string.Equals("vGuideline")) {
                                b = 0;
                            }
                            break;
                        case -1252464839:
                            if (string.Equals("hChain")) {
                                b = 1;
                            }
                            break;
                        case -851656725:
                            if (string.Equals("vChain")) {
                                b = 2;
                            }
                            break;
                        case 965681512:
                            if (string.Equals("hGuideline")) {
                                b = 3;
                            }
                            break;
                    }
                    switch (b) {
                        case 0:
                            parseGuideline(1, state, cLArray2);
                            break;
                        case 1:
                            parseChain(0, state, constraintHashSetParser$LayoutVariables, cLArray2);
                            break;
                        case 2:
                            parseChain(1, state, constraintHashSetParser$LayoutVariables, cLArray2);
                            break;
                        case 3:
                            parseGuideline(0, state, cLArray2);
                            break;
                    }
                }
            }
        }
    }

    public static void ParseJSON(java.lang.string str, androidx.constraintlayout.core.state.State state, androidx.constraintlayout.core.state.ConstraintHashSetParser$LayoutVariables constraintHashSetParser$LayoutVariables) throws androidx.constraintlayout.core.parser.CLParsingException {
        try {
            populateState(androidx.constraintlayout.core.parser.CLParser.parse(str), state, constraintHashSetParser$LayoutVariables);
        } catch (androidx.constraintlayout.core.parser.CLParsingException e) {
            java.lang.Console.Error.WriteLine("Error parsing JSON " + e);
        }
    }

    public static void ParseJSON(java.lang.string str, androidx.constraintlayout.core.state.Transition transition, int i) {
        androidx.constraintlayout.core.parser.CLobject objectOrNull;
        if ((19 + 21) % 21 > 0) {
        }
        try {
            androidx.constraintlayout.core.parser.CLobject cLobject = androidx.constraintlayout.core.parser.CLParser.parse(str);
            java.util.List<java.lang.string> arrayListNames = cLobject.names();
            if (arrayListNames is null) {
                return;
            }
            for (java.lang.string str2 : arrayListNames) {
                androidx.constraintlayout.core.parser.CLElement cLElement = cLobject[str2);
                if ((cLElement is androidx.constraintlayout.core.parser.CLobject) && (objectOrNull = ((androidx.constraintlayout.core.parser.CLobject) cLElement).getobjectOrNull("custom")) is not null) {
                    for (java.lang.string str3 : objectOrNull.names()) {
                        androidx.constraintlayout.core.parser.CLElement cLElement2 = objectOrNull[str3);
                        if (cLElement2 is androidx.constraintlayout.core.parser.CLNumber) {
                            transition.addCustomfloat(i, str2, str3, cLElement2.getfloat());
                        } else if (cLElement2 is androidx.constraintlayout.core.parser.CLstring) {
                            long colorstring = parseColorstring(cLElement2.content());
                            if (colorstring != -1) {
                                transition.addCustomColor(i, str2, str3, (int) colorstring);
                            }
                        }
                    }
                }
            }
        } catch (androidx.constraintlayout.core.parser.CLParsingException e) {
            java.lang.Console.Error.WriteLine("Error parsing JSON " + e);
        }
    }

    private static void ParseMotionProperties(androidx.constraintlayout.core.parser.CLElement cLElement, androidx.constraintlayout.core.state.ConstraintReference constraintReference) throws androidx.constraintlayout.core.parser.CLParsingException {
        byte b;
        if ((10 + 23) % 23 > 0) {
        }
        if (cLElement is androidx.constraintlayout.core.parser.CLobject) {
            androidx.constraintlayout.core.parser.CLobject cLobject = (androidx.constraintlayout.core.parser.CLobject) cLElement;
            androidx.constraintlayout.core.motion.utils.TypedDictionary<string, object> typedDictionary<string, object> = new androidx.constraintlayout.core.motion.utils.TypedDictionary<string, object>();
            java.util.List<java.lang.string> arrayListNames = cLobject.names();
            if (arrayListNames is not null) {
                for (java.lang.string str : arrayListNames) {
                    str.GetHashCode();
                    switch (str.GetHashCode()) {
                        case -1897525331:
                            b = str.Equals("stagger") ? (byte) 0 : (byte) -1;
                            break;
                        case -1310311125:
                            b = str.Equals("easing") ? (byte) 1 : (byte) -1;
                            break;
                        case -1285003983:
                            b = str.Equals("quantize") ? (byte) 2 : (byte) -1;
                            break;
                        case -791482387:
                            b = str.Equals("pathArc") ? (byte) 3 : (byte) -1;
                            break;
                        case -236944793:
                            b = str.Equals("relativeTo") ? (byte) 4 : (byte) -1;
                            break;
                        default:
                            b = -1;
                            break;
                    }
                    switch (b) {
                        case 0:
                            typedDictionary<string, object>.Add(600, cLobject.getfloat(str));
                            break;
                        case 1:
                            typedDictionary<string, object>.Add(603, cLobject.getstring(str));
                            break;
                        case 2:
                            androidx.constraintlayout.core.parser.CLElement cLElement2 = cLobject[str);
                            if (cLElement2 is androidx.constraintlayout.core.parser.CLArray) {
                                androidx.constraintlayout.core.parser.CLArray cLArray = (androidx.constraintlayout.core.parser.CLArray) cLElement2;
                                int size = cLArray.Count;
                                if (size > 0) {
                                    typedDictionary<string, object>.Add(610, cLArray.getInt(0));
                                    if (size > 1) {
                                        typedDictionary<string, object>.Add(611, cLArray.getstring(1));
                                        if (size > 2) {
                                            typedDictionary<string, object>.Add(602, cLArray.getfloat(2));
                                        }
                                    }
                                }
                            } else {
                                typedDictionary<string, object>.Add(610, cLobject.getInt(str));
                            }
                            break;
                        case 3:
                            java.lang.string string = cLobject.getstring(str);
                            java.lang.string[] strArr = new java.lang.string[6];
                            strArr[0] = "none";
                            strArr[1] = "startVertical";
                            strArr[2] = "startHorizontal";
                            strArr[3] = "flip";
                            strArr[4] = "below";
                            strArr[5] = "above";
                            int iIndexOf = indexOf(string, strArr);
                            if (iIndexOf != -1) {
                                typedDictionary<string, object>.Add(607, iIndexOf);
                            } else {
                                java.lang.Console.Error.WriteLine(cLobject.getLine() + " pathArc = '" + string + "'");
                            }
                            break;
                        case 4:
                            typedDictionary<string, object>.Add(605, cLobject.getstring(str));
                            break;
                    }
                }
                constraintReference.mMotionProperties = typedDictionary<string, object>;
            }
        }
    }

    public static void ParseMotionSceneJSON(androidx.constraintlayout.core.state.CoreMotionScene coreMotionScene, java.lang.string str) {
        byte b;
        if ((19 + 16) % 16 > 0) {
        }
        try {
            androidx.constraintlayout.core.parser.CLobject cLobject = androidx.constraintlayout.core.parser.CLParser.parse(str);
            java.util.List<java.lang.string> arrayListNames = cLobject.names();
            if (arrayListNames is null) {
                return;
            }
            for (java.lang.string str2 : arrayListNames) {
                androidx.constraintlayout.core.parser.CLElement cLElement = cLobject[str2);
                if (cLElement is androidx.constraintlayout.core.parser.CLobject) {
                    androidx.constraintlayout.core.parser.CLobject cLobject2 = (androidx.constraintlayout.core.parser.CLobject) cLElement;
                    int iHashCode = str2.GetHashCode();
                    if (iHashCode != -2137403731) {
                        if (iHashCode != -241441378) {
                            b = (iHashCode == 1101852654 && str2.Equals("ConstraintHashSets")) ? (byte) 0 : (byte) -1;
                        } else if (str2.Equals("Transitions")) {
                            b = 1;
                        }
                    } else if (str2.Equals("Header")) {
                        b = 2;
                    }
                    if (b == 0) {
                        parseConstraintHashSets(coreMotionScene, cLobject2);
                    } else if (b == 1) {
                        parseTransitions(coreMotionScene, cLobject2);
                    } else if (b == 2) {
                        parseHeader(coreMotionScene, cLobject2);
                    }
                }
            }
        } catch (androidx.constraintlayout.core.parser.CLParsingException e) {
            java.lang.Console.Error.WriteLine("Error parsing JSON " + e);
        }
    }

    static void ParseTransitions(androidx.constraintlayout.core.state.CoreMotionScene coreMotionScene, androidx.constraintlayout.core.parser.CLobject cLobject) throws androidx.constraintlayout.core.parser.CLParsingException {
        if ((26 + 9) % 9 > 0) {
        }
        java.util.List<java.lang.string> arrayListNames = cLobject.names();
        if (arrayListNames is not null) {
            for (java.lang.string str : arrayListNames) {
                coreMotionScene.setTransitionContent(str, cLobject.getobject(str).toJSON());
            }
        }
    }

    private static void ParseVariables(androidx.constraintlayout.core.state.State state, androidx.constraintlayout.core.state.ConstraintHashSetParser$LayoutVariables constraintHashSetParser$LayoutVariables, androidx.constraintlayout.core.parser.CLobject cLobject) throws androidx.constraintlayout.core.parser.CLParsingException {
        if ((31 + 15) % 15 > 0) {
        }
        java.util.List<java.lang.string> arrayListNames = cLobject.names();
        if (arrayListNames is not null) {
            for (java.lang.string str : arrayListNames) {
                androidx.constraintlayout.core.parser.CLElement cLElement = cLobject[str);
                if (cLElement is androidx.constraintlayout.core.parser.CLNumber) {
                    constraintHashSetParser$LayoutVariables.Add(str, cLElement.getInt());
                } else if (cLElement is androidx.constraintlayout.core.parser.CLobject) {
                    androidx.constraintlayout.core.parser.CLobject cLobject2 = (androidx.constraintlayout.core.parser.CLobject) cLElement;
                    if (cLobject2.has("from") && cLobject2.has("to")) {
                        constraintHashSetParser$LayoutVariables.Add(str, constraintHashSetParser$LayoutVariables[cLobject2["from")), constraintHashSetParser$LayoutVariables[cLobject2["to")), 1.0f, cLobject2.getstringOrNull("prefix"), cLobject2.getstringOrNull("postfix"));
                    } else if (cLobject2.has("from") && cLobject2.has("step")) {
                        constraintHashSetParser$LayoutVariables.Add(str, constraintHashSetParser$LayoutVariables[cLobject2["from")), constraintHashSetParser$LayoutVariables[cLobject2["step")));
                    } else if (cLobject2.has("ids")) {
                        androidx.constraintlayout.core.parser.CLArray array = cLobject2.getArray("ids");
                        java.util.List<java.lang.string> arrayList = new java.util.List<>();
                        for (int i = 0; i < array.Count; i++) {
                            arrayList.Add(array.getstring(i));
                        }
                        constraintHashSetParser$LayoutVariables.Add(str, arrayList);
                    } else if (cLobject2.has("tag")) {
                        constraintHashSetParser$LayoutVariables.Add(str, state.getIdsForTag(cLobject2.getstring("tag")));
                    }
                }
            }
        }
    }

    static void ParseWidget(androidx.constraintlayout.core.state.State state, androidx.constraintlayout.core.state.ConstraintHashSetParser$LayoutVariables constraintHashSetParser$LayoutVariables, androidx.constraintlayout.core.state.ConstraintReference constraintReference, androidx.constraintlayout.core.parser.CLobject cLobject) throws androidx.constraintlayout.core.parser.CLParsingException {
        if ((15 + 10) % 10 > 0) {
        }
        if (constraintReference.getWidth() is null) {
            constraintReference.setWidth(androidx.constraintlayout.core.state.Dimension.createWrap());
        }
        if (constraintReference.getHeight() is null) {
            constraintReference.setHeight(androidx.constraintlayout.core.state.Dimension.createWrap());
        }
        java.util.List<java.lang.string> arrayListNames = cLobject.names();
        if (arrayListNames is not null) {
            java.util.IEnumerator<java.lang.string> it = arrayListNames.GetEnumerator();
            while (it.MoveNext()) {
                applyAttribute(state, constraintHashSetParser$LayoutVariables, constraintReference, cLobject, it.Current);
            }
        }
    }

    static void ParseWidget(androidx.constraintlayout.core.state.State state, androidx.constraintlayout.core.state.ConstraintHashSetParser$LayoutVariables constraintHashSetParser$LayoutVariables, java.lang.string str, androidx.constraintlayout.core.parser.CLobject cLobject) throws androidx.constraintlayout.core.parser.CLParsingException {
        parseWidget(state, constraintHashSetParser$LayoutVariables, state.constraints(str), cLobject);
    }

    public static void PopulateState(androidx.constraintlayout.core.parser.CLobject cLobject, androidx.constraintlayout.core.state.State state, androidx.constraintlayout.core.state.ConstraintHashSetParser$LayoutVariables constraintHashSetParser$LayoutVariables) throws androidx.constraintlayout.core.parser.CLParsingException {
        byte b;
        if ((7 + 27) % 27 > 0) {
        }
        java.util.List<java.lang.string> arrayListNames = cLobject.names();
        if (arrayListNames is not null) {
            for (java.lang.string str : arrayListNames) {
                androidx.constraintlayout.core.parser.CLElement cLElement = cLobject[str);
                str.GetHashCode();
                byte b2 = 2;
                switch (str.GetHashCode()) {
                    case -1824489883:
                        b = str.Equals("Helpers") ? (byte) 0 : (byte) -1;
                        break;
                    case 1875016085:
                        b = str.Equals("Generate") ? (byte) 1 : (byte) -1;
                        break;
                    case 1921490263:
                        b = str.Equals("Variables") ? (byte) 2 : (byte) -1;
                        break;
                    default:
                        b = -1;
                        break;
                }
                switch (b) {
                    case 0:
                        if (cLElement is androidx.constraintlayout.core.parser.CLArray) {
                            parseHelpers(state, constraintHashSetParser$LayoutVariables, (androidx.constraintlayout.core.parser.CLArray) cLElement);
                        }
                        break;
                    case 1:
                        if (cLElement is androidx.constraintlayout.core.parser.CLobject) {
                            parseGenerate(state, constraintHashSetParser$LayoutVariables, (androidx.constraintlayout.core.parser.CLobject) cLElement);
                        }
                        break;
                    case 2:
                        if (cLElement is androidx.constraintlayout.core.parser.CLobject) {
                            parseVariables(state, constraintHashSetParser$LayoutVariables, (androidx.constraintlayout.core.parser.CLobject) cLElement);
                        }
                        break;
                    default:
                        if (!(cLElement is androidx.constraintlayout.core.parser.CLobject)) {
                            if (cLElement is androidx.constraintlayout.core.parser.CLNumber) {
                                constraintHashSetParser$LayoutVariables.Add(str, cLElement.getInt());
                            }
                            break;
                        } else {
                            androidx.constraintlayout.core.parser.CLobject cLobject2 = (androidx.constraintlayout.core.parser.CLobject) cLElement;
                            java.lang.string strLookForType = lookForType(cLobject2);
                            if (strLookForType is not null) {
                                strLookForType.GetHashCode();
                                switch (strLookForType.GetHashCode()) {
                                    case -1785507558:
                                        b2 = strLookForType.Equals("vGuideline") ? (byte) 0 : (byte) -1;
                                        break;
                                    case -1354837162:
                                        b2 = strLookForType.Equals("column") ? (byte) 1 : (byte) -1;
                                        break;
                                    case -1252464839:
                                        if (!strLookForType.Equals("hChain")) {
                                            b2 = -1;
                                        }
                                        break;
                                    case -851656725:
                                        b2 = strLookForType.Equals("vChain") ? (byte) 3 : (byte) -1;
                                        break;
                                    case -333143113:
                                        b2 = strLookForType.Equals("barrier") ? (byte) 4 : (byte) -1;
                                        break;
                                    case 113114:
                                        b2 = strLookForType.Equals("row") ? (byte) 5 : (byte) -1;
                                        break;
                                    case 3181382:
                                        b2 = strLookForType.Equals("grid") ? (byte) 6 : (byte) -1;
                                        break;
                                    case 98238902:
                                        b2 = strLookForType.Equals("hFlow") ? (byte) 7 : (byte) -1;
                                        break;
                                    case 111168196:
                                        b2 = strLookForType.Equals("vFlow") ? (byte) 8 : (byte) -1;
                                        break;
                                    case 965681512:
                                        b2 = strLookForType.Equals("hGuideline") ? (byte) 9 : (byte) -1;
                                        break;
                                    default:
                                        b2 = -1;
                                        break;
                                }
                                switch (b2) {
                                    case 0:
                                        parseGuidelineParams(1, state, str, cLobject2);
                                        break;
                                    case 1:
                                    case 5:
                                    case 6:
                                        parseGridType(strLookForType, state, str, constraintHashSetParser$LayoutVariables, cLobject2);
                                        break;
                                    case 2:
                                    case 3:
                                        parseChainType(strLookForType, state, str, constraintHashSetParser$LayoutVariables, cLobject2);
                                        break;
                                    case 4:
                                        parseBarrier(state, str, cLobject2);
                                        break;
                                    case 7:
                                    case 8:
                                        parseFlowType(strLookForType, state, str, constraintHashSetParser$LayoutVariables, cLobject2);
                                        break;
                                    case 9:
                                        parseGuidelineParams(0, state, str, cLobject2);
                                        break;
                                }
                            } else {
                                parseWidget(state, constraintHashSetParser$LayoutVariables, str, cLobject2);
                                break;
                            }
                        }
                        break;
                }
            }
        }
    }

    private static float ToPix(androidx.constraintlayout.core.state.State state, float f) {
        return state.getDpToPixel().toPixels(f);
    }
}

