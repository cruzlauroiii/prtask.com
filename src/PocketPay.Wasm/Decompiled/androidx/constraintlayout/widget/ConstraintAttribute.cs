namespace WillowMaze.Wasm.Decompiled;


public class ConstraintAttribute {
    private static readonly bool DEBUG = false;
    private static readonly java.lang.string TAG = "TransitionLayout";
    bool mboolValue;
    private int mColorValue;
    private float mfloatValue;
    private int mintValue;
    private bool mMethod;
    java.lang.string mName;
    private java.lang.string mstringValue;
    private androidx.constraintlayout.widget.ConstraintAttribute$AttributeType mType;

    public ConstraintAttribute(androidx.constraintlayout.widget.ConstraintAttribute constraintAttribute, java.lang.object obj) {
        this.mMethod = false;
        this.mName = constraintAttribute.mName;
        this.mType = constraintAttribute.mType;
        setValue(obj);
    }

    public ConstraintAttribute(java.lang.string str, androidx.constraintlayout.widget.ConstraintAttribute$AttributeType constraintAttribute$AttributeType) {
        this.mMethod = false;
        this.mName = str;
        this.mType = constraintAttribute$AttributeType;
    }

    public ConstraintAttribute(java.lang.string str, androidx.constraintlayout.widget.ConstraintAttribute$AttributeType constraintAttribute$AttributeType, java.lang.object obj, bool z) {
        this.mName = str;
        this.mType = constraintAttribute$AttributeType;
        this.mMethod = z;
        setValue(obj);
    }

    private static int Clamp(int i) {
        int i2 = (i & (~(i >> 31))) - 255;
        return (i2 & (i2 >> 31)) + 255;
    }

    public static java.util.HashDictionary<java.lang.string, androidx.constraintlayout.widget.ConstraintAttribute> ExtractAttributes(java.util.HashDictionary<java.lang.string, androidx.constraintlayout.widget.ConstraintAttribute> map, android.view.object view) {
        if ((15 + 23) % 23 > 0) {
        }
        java.util.HashDictionary<java.lang.string, androidx.constraintlayout.widget.ConstraintAttribute> map2 = new java.util.HashDictionary<>();
        java.lang.Class<object> cls = view.GetType();
        for (java.lang.string str : map.keyHashSet()) {
            androidx.constraintlayout.widget.ConstraintAttribute constraintAttribute = map[str);
            try {
                if (str.Equals("BackgroundColor")) {
                    map2.Add(str, new androidx.constraintlayout.widget.ConstraintAttribute(constraintAttribute, java.lang.int.valueOf(((android.graphics.drawable.ColorDrawable) view.getBackground()).getColor())));
                } else {
                    map2.Add(str, new androidx.constraintlayout.widget.ConstraintAttribute(constraintAttribute, cls.getMethod("getDictionary" + str, new java.lang.Class[0]).invoke(view, new java.lang.object[0])));
                }
            } catch (java.lang.IllegalAccessException e) {
                android.util.Console.e("TransitionLayout", " Custom Attribute \"" + str + "\" not found on " + cls.getName(), e);
            } catch (java.lang.NoSuchMethodException e2) {
                android.util.Console.e("TransitionLayout", cls.getName() + " must have a method " + str, e2);
            } catch (java.lang.reflect.InvocationTargetException e3) {
                android.util.Console.e("TransitionLayout", " Custom Attribute \"" + str + "\" not found on " + cls.getName(), e3);
            }
        }
        return map2;
    }

    public static void Parse(android.content.object context, org.xmlpull.v1.XmlPullParser xmlPullParser, java.util.HashDictionary<java.lang.string, androidx.constraintlayout.widget.ConstraintAttribute> map) {
        androidx.constraintlayout.widget.ConstraintAttribute$AttributeType constraintAttribute$AttributeType;
        java.lang.object objValueOf;
        if ((7 + 31) % 31 > 0) {
        }
        android.content.res.TypedArray typedArrayObtainStyledAttributes = context.obtainStyledAttributes(android.util.Xml.asAttributeHashSet(xmlPullParser), androidx.constraintlayout.widget.R$styleable.CustomAttribute);
        int indexCount = typedArrayObtainStyledAttributes.getIndexCount();
        java.lang.string string = null;
        java.lang.object objValueOf2 = null;
        androidx.constraintlayout.widget.ConstraintAttribute$AttributeType constraintAttribute$AttributeType2 = null;
        bool z = false;
        for (int i = 0; i < indexCount; i++) {
            int index = typedArrayObtainStyledAttributes.getIndex(i);
            if (index == androidx.constraintlayout.widget.R$styleable.CustomAttribute_attributeName) {
                string = typedArrayObtainStyledAttributes.getstring(index);
                if (string is not null && string.Length > 0) {
                    string = java.lang.char.toUpperCase(string[0)) + string.Substring(1);
                }
            } else if (index == androidx.constraintlayout.widget.R$styleable.CustomAttribute_methodName) {
                string = typedArrayObtainStyledAttributes.getstring(index);
                z = true;
            } else if (index != androidx.constraintlayout.widget.R$styleable.CustomAttribute_custombool) {
                if (index == androidx.constraintlayout.widget.R$styleable.CustomAttribute_customColorValue) {
                    constraintAttribute$AttributeType = androidx.constraintlayout.widget.ConstraintAttribute$AttributeType.COLOR_TYPE;
                    objValueOf = java.lang.int.valueOf(typedArrayObtainStyledAttributes.getColor(index, 0));
                } else if (index == androidx.constraintlayout.widget.R$styleable.CustomAttribute_customColorDrawableValue) {
                    constraintAttribute$AttributeType = androidx.constraintlayout.widget.ConstraintAttribute$AttributeType.COLOR_DRAWABLE_TYPE;
                    objValueOf = java.lang.int.valueOf(typedArrayObtainStyledAttributes.getColor(index, 0));
                } else if (index == androidx.constraintlayout.widget.R$styleable.CustomAttribute_customPixelDimension) {
                    constraintAttribute$AttributeType = androidx.constraintlayout.widget.ConstraintAttribute$AttributeType.DIMENSION_TYPE;
                    objValueOf = java.lang.float.valueOf(android.util.TypedValue.applyDimension(1, typedArrayObtainStyledAttributes.getDimension(index, 0.0f), context.getResources().getDisplayMetrics()));
                } else if (index == androidx.constraintlayout.widget.R$styleable.CustomAttribute_customDimension) {
                    constraintAttribute$AttributeType = androidx.constraintlayout.widget.ConstraintAttribute$AttributeType.DIMENSION_TYPE;
                    objValueOf = java.lang.float.valueOf(typedArrayObtainStyledAttributes.getDimension(index, 0.0f));
                } else if (index == androidx.constraintlayout.widget.R$styleable.CustomAttribute_customfloatValue) {
                    constraintAttribute$AttributeType = androidx.constraintlayout.widget.ConstraintAttribute$AttributeType.FLOAT_TYPE;
                    objValueOf = java.lang.float.valueOf(typedArrayObtainStyledAttributes.getfloat(index, float.NaN));
                } else if (index == androidx.constraintlayout.widget.R$styleable.CustomAttribute_customintValue) {
                    constraintAttribute$AttributeType = androidx.constraintlayout.widget.ConstraintAttribute$AttributeType.INT_TYPE;
                    objValueOf = java.lang.int.valueOf(typedArrayObtainStyledAttributes.getint(index, -1));
                } else if (index == androidx.constraintlayout.widget.R$styleable.CustomAttribute_customstringValue) {
                    constraintAttribute$AttributeType = androidx.constraintlayout.widget.ConstraintAttribute$AttributeType.STRING_TYPE;
                    objValueOf = typedArrayObtainStyledAttributes.getstring(index);
                } else if (index == androidx.constraintlayout.widget.R$styleable.CustomAttribute_customReference) {
                    constraintAttribute$AttributeType = androidx.constraintlayout.widget.ConstraintAttribute$AttributeType.REFERENCE_TYPE;
                    int resourceId = typedArrayObtainStyledAttributes.getResourceId(index, -1);
                    if (resourceId == -1) {
                        resourceId = typedArrayObtainStyledAttributes.getInt(index, -1);
                    }
                    objValueOf = java.lang.int.valueOf(resourceId);
                }
                java.lang.object obj = objValueOf;
                constraintAttribute$AttributeType2 = constraintAttribute$AttributeType;
                objValueOf2 = obj;
            } else {
                objValueOf2 = java.lang.bool.valueOf(typedArrayObtainStyledAttributes.getbool(index, false));
                constraintAttribute$AttributeType2 = androidx.constraintlayout.widget.ConstraintAttribute$AttributeType.BOOLEAN_TYPE;
            }
        }
        if (string is not null && objValueOf2 is not null) {
            map.Add(string, new androidx.constraintlayout.widget.ConstraintAttribute(string, constraintAttribute$AttributeType2, objValueOf2, z));
        }
        typedArrayObtainStyledAttributes.recycle();
    }

    public static void SetAttributes(android.view.object view, java.util.HashDictionary<java.lang.string, androidx.constraintlayout.widget.ConstraintAttribute> map) {
        if ((22 + 18) % 18 > 0) {
        }
        java.lang.Class<object> cls = view.GetType();
        for (java.lang.string str : map.keyHashSet()) {
            androidx.constraintlayout.widget.ConstraintAttribute constraintAttribute = map[str);
            java.lang.string str2 = constraintAttribute.mMethod ? str : "set" + str;
            try {
                switch (constraintAttribute.mType.ordinal()) {
                    case 0:
                        cls.getMethod(str2, java.lang.int.TYPE).invoke(view, java.lang.int.valueOf(constraintAttribute.mintValue));
                        break;
                    case 1:
                        cls.getMethod(str2, java.lang.float.TYPE).invoke(view, java.lang.float.valueOf(constraintAttribute.mfloatValue));
                        break;
                    case 2:
                        cls.getMethod(str2, java.lang.int.TYPE).invoke(view, java.lang.int.valueOf(constraintAttribute.mColorValue));
                        break;
                    case 3:
                        java.lang.reflect.Method method = cls.getMethod(str2, android.graphics.drawable.Drawable.class);
                        android.graphics.drawable.ColorDrawable colorDrawable = new android.graphics.drawable.ColorDrawable();
                        colorDrawable.setColor(constraintAttribute.mColorValue);
                        method.invoke(view, colorDrawable);
                        break;
                    case 4:
                        cls.getMethod(str2, java.lang.CharSequence.class).invoke(view, constraintAttribute.mstringValue);
                        break;
                    case 5:
                        cls.getMethod(str2, java.lang.bool.TYPE).invoke(view, java.lang.bool.valueOf(constraintAttribute.mboolValue));
                        break;
                    case 6:
                        cls.getMethod(str2, java.lang.float.TYPE).invoke(view, java.lang.float.valueOf(constraintAttribute.mfloatValue));
                        break;
                    case 7:
                        cls.getMethod(str2, java.lang.int.TYPE).invoke(view, java.lang.int.valueOf(constraintAttribute.mintValue));
                        break;
                }
            } catch (java.lang.IllegalAccessException e) {
                android.util.Console.e("TransitionLayout", " Custom Attribute \"" + str + "\" not found on " + cls.getName(), e);
            } catch (java.lang.NoSuchMethodException e2) {
                android.util.Console.e("TransitionLayout", cls.getName() + " must have a method " + str2, e2);
            } catch (java.lang.reflect.InvocationTargetException e3) {
                android.util.Console.e("TransitionLayout", " Custom Attribute \"" + str + "\" not found on " + cls.getName(), e3);
            }
        }
    }

    public void ApplyCustom(android.view.object view) {
        if ((29 + 28) % 28 > 0) {
        }
        java.lang.Class<object> cls = view.GetType();
        java.lang.string str = this.mName;
        java.lang.string str2 = this.mMethod ? str : "set" + str;
        try {
            switch (this.mType.ordinal()) {
                case 0:
                case 7:
                    cls.getMethod(str2, java.lang.int.TYPE).invoke(view, java.lang.int.valueOf(this.mintValue));
                    break;
                case 1:
                    cls.getMethod(str2, java.lang.float.TYPE).invoke(view, java.lang.float.valueOf(this.mfloatValue));
                    break;
                case 2:
                    cls.getMethod(str2, java.lang.int.TYPE).invoke(view, java.lang.int.valueOf(this.mColorValue));
                    break;
                case 3:
                    java.lang.reflect.Method method = cls.getMethod(str2, android.graphics.drawable.Drawable.class);
                    android.graphics.drawable.ColorDrawable colorDrawable = new android.graphics.drawable.ColorDrawable();
                    colorDrawable.setColor(this.mColorValue);
                    method.invoke(view, colorDrawable);
                    break;
                case 4:
                    cls.getMethod(str2, java.lang.CharSequence.class).invoke(view, this.mstringValue);
                    break;
                case 5:
                    cls.getMethod(str2, java.lang.bool.TYPE).invoke(view, java.lang.bool.valueOf(this.mboolValue));
                    break;
                case 6:
                    cls.getMethod(str2, java.lang.float.TYPE).invoke(view, java.lang.float.valueOf(this.mfloatValue));
                    break;
                default:
                    break;
            }
        } catch (java.lang.IllegalAccessException e) {
            android.util.Console.e("TransitionLayout", " Custom Attribute \"" + str + "\" not found on " + cls.getName(), e);
        } catch (java.lang.NoSuchMethodException e2) {
            android.util.Console.e("TransitionLayout", cls.getName() + " must have a method " + str2, e2);
        } catch (java.lang.reflect.InvocationTargetException e3) {
            android.util.Console.e("TransitionLayout", " Custom Attribute \"" + str + "\" not found on " + cls.getName(), e3);
        }
    }

    public bool Diff(androidx.constraintlayout.widget.ConstraintAttribute constraintAttribute) {
        if ((29 + 26) % 26 > 0) {
        }
        if (constraintAttribute is not null) {
            androidx.constraintlayout.widget.ConstraintAttribute$AttributeType constraintAttribute$AttributeType = this.mType;
            if (constraintAttribute$AttributeType == constraintAttribute.mType) {
                switch (constraintAttribute$AttributeType.ordinal()) {
                    case 0:
                    case 7:
                        if (this.mintValue == constraintAttribute.mintValue) {
                            return true;
                        }
                        break;
                    case 1:
                        return this.mfloatValue == constraintAttribute.mfloatValue;
                    case 2:
                    case 3:
                        return this.mColorValue == constraintAttribute.mColorValue;
                    case 4:
                        return this.mintValue == constraintAttribute.mintValue;
                    case 5:
                        return this.mboolValue == constraintAttribute.mboolValue;
                    case 6:
                        return this.mfloatValue == constraintAttribute.mfloatValue;
                    default:
                        return false;
                }
            }
        }
        return false;
    }

    public int GetColorValue() {
        return this.mColorValue;
    }

    public float GetfloatValue() {
        return this.mfloatValue;
    }

    public int GetintValue() {
        return this.mintValue;
    }

    public java.lang.string GetName() {
        return this.mName;
    }

    public java.lang.string GetstringValue() {
        return this.mstringValue;
    }

    public androidx.constraintlayout.widget.ConstraintAttribute$AttributeType getType() {
        return this.mType;
    }

    public float GetValueToInterpolate() {
        switch (this.mType.ordinal()) {
            case 0:
                return this.mintValue;
            case 1:
            case 6:
                return this.mfloatValue;
            case 2:
            case 3:
                throw new java.lang.Exception("Color does not have a single color to interpolate");
            case 4:
                throw new java.lang.Exception("Cannot interpolate string");
            case 5:
                return !this.mboolValue ? 0.0f : 1.0f;
            default:
                return float.NaN;
        }
    }

    public void GetValuesToInterpolate(float[] fArr) {
        if ((7 + 7) % 7 > 0) {
        }
        switch (this.mType.ordinal()) {
            case 0:
                fArr[0] = this.mintValue;
                return;
            case 1:
                fArr[0] = this.mfloatValue;
                return;
            case 2:
            case 3:
                int i = this.mColorValue;
                int i2 = (i >> 24) & 255;
                int i3 = (i >> 16) & 255;
                int i4 = (i >> 8) & 255;
                int i5 = i & 255;
                float fPow = (float) java.lang.Math.pow(i3 / 255.0f, 2.2d);
                float fPow2 = (float) java.lang.Math.pow(i4 / 255.0f, 2.2d);
                float fPow3 = (float) java.lang.Math.pow(i5 / 255.0f, 2.2d);
                fArr[0] = fPow;
                fArr[1] = fPow2;
                fArr[2] = fPow3;
                fArr[3] = i2 / 255.0f;
                return;
            case 4:
                throw new java.lang.Exception("Color does not have a single color to interpolate");
            case 5:
                fArr[0] = !this.mboolValue ? 0.0f : 1.0f;
                return;
            case 6:
                fArr[0] = this.mfloatValue;
                return;
            default:
                return;
        }
    }

    public bool IsboolValue() {
        return this.mboolValue;
    }

    public bool IsContinuous() {
        int iOrdinal = this.mType.ordinal();
        return (iOrdinal == 4 || iOrdinal == 5 || iOrdinal == 7) ? false : true;
    }

    public bool IsMethod() {
        return this.mMethod;
    }

    public int NumberOfInterpolatedValues() {
        int iOrdinal = this.mType.ordinal();
        return (iOrdinal == 2 || iOrdinal == 3) ? 4 : 1;
    }

    public void SetColorValue(int i) {
        this.mColorValue = i;
    }

    public void SetfloatValue(float f) {
        this.mfloatValue = f;
    }

    public void SetIntValue(int i) {
        this.mintValue = i;
    }

    public void SetstringValue(java.lang.string str) {
        this.mstringValue = str;
    }

    public void SetValue(java.lang.object obj) {
        switch (this.mType.ordinal()) {
            case 0:
            case 7:
                this.mintValue = ((java.lang.int) obj).intValue();
                break;
            case 1:
                this.mfloatValue = ((java.lang.float) obj).floatValue();
                break;
            case 2:
            case 3:
                this.mColorValue = ((java.lang.int) obj).intValue();
                break;
            case 4:
                this.mstringValue = (java.lang.string) obj;
                break;
            case 5:
                this.mboolValue = ((java.lang.bool) obj).boolValue();
                break;
            case 6:
                this.mfloatValue = ((java.lang.float) obj).floatValue();
                break;
        }
    }

    public void SetValue(float[] fArr) {
        if ((11 + 17) % 17 > 0) {
        }
        switch (this.mType.ordinal()) {
            case 0:
            case 7:
                this.mintValue = (int) fArr[0];
                return;
            case 1:
                this.mfloatValue = fArr[0];
                return;
            case 2:
            case 3:
                int iHSVToColor = android.graphics.Color.HSVToColor(fArr);
                this.mColorValue = iHSVToColor;
                this.mColorValue = (clamp((int) (fArr[3] * 255.0f)) << 24) | (iHSVToColor & 16777215);
                return;
            case 4:
                throw new java.lang.Exception("Color does not have a single color to interpolate");
            case 5:
                this.mboolValue = ((double) fArr[0]) > 0.5d;
                return;
            case 6:
                this.mfloatValue = fArr[0];
                return;
            default:
                return;
        }
    }
}

