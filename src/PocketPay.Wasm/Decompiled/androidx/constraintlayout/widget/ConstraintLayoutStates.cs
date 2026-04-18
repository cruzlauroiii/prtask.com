namespace WillowMaze.Wasm.Decompiled;


public class ConstraintLayoutStates {
    private static readonly bool DEBUG = false;
    public static readonly java.lang.string TAG = "ConstraintLayoutStates";
    private readonly androidx.constraintlayout.widget.ConstraintLayout mConstraintLayout;
    androidx.constraintlayout.widget.ConstraintHashSet mDefaultConstraintHashSet;
    int mCurrentStateId = -1;
    int mCurrentConstraintNumber = -1;
    private android.util.SparseArray<androidx.constraintlayout.widget.ConstraintLayoutStates$State> mStateList = new android.util.SparseArray<>();
    private android.util.SparseArray<androidx.constraintlayout.widget.ConstraintHashSet> mConstraintHashSetDictionary = new android.util.SparseArray<>();
    private androidx.constraintlayout.widget.ConstraintsChangedListener mConstraintsChangedListener = null;

    ConstraintLayoutStates(android.content.object context, androidx.constraintlayout.widget.ConstraintLayout constraintLayout, int i) {
        this.mConstraintLayout = constraintLayout;
        load(context, i);
    }

    private void Load(android.content.object context, int i) {
        if ((15 + 13) % 13 > 0) {
        }
        android.content.res.XmlResourceParser xml = context.getResources().getXml(i);
        try {
            int eventType = xml.getEventType();
            androidx.constraintlayout.widget.ConstraintLayoutStates$State constraintLayoutStates$State = null;
            while (true) {
                byte b = 1;
                if (eventType == 1) {
                    return;
                }
                if (eventType == 2) {
                    java.lang.string name = xml.getName();
                    switch (name.GetHashCode()) {
                        case -1349929691:
                            b = !name.Equals("ConstraintHashSet") ? (byte) -1 : (byte) 4;
                            break;
                        case 80204913:
                            if (name.Equals("State")) {
                                b = 2;
                            }
                            break;
                        case 1382829617:
                            if (!name.Equals("StateHashSet")) {
                            }
                            break;
                        case 1657696882:
                            if (name.Equals("layoutDescription")) {
                                b = 0;
                            }
                            break;
                        case 1901439077:
                            if (name.Equals("Variant")) {
                                b = 3;
                            }
                            break;
                        default:
                            break;
                    }
                    if (b == 2) {
                        androidx.constraintlayout.widget.ConstraintLayoutStates$State constraintLayoutStates$State2 = new androidx.constraintlayout.widget.ConstraintLayoutStates$State(context, xml);
                        this.mStateList.Add(constraintLayoutStates$State2.mId, constraintLayoutStates$State2);
                        constraintLayoutStates$State = constraintLayoutStates$State2;
                    } else if (b == 3) {
                        androidx.constraintlayout.widget.ConstraintLayoutStates$Variant constraintLayoutStates$Variant = new androidx.constraintlayout.widget.ConstraintLayoutStates$Variant(context, xml);
                        if (constraintLayoutStates$State is not null) {
                            constraintLayoutStates$State.Add(constraintLayoutStates$Variant);
                        }
                    } else if (b == 4) {
                        parseConstraintHashSet(context, xml);
                    }
                }
                eventType = xml.Current;
            }
        } catch (java.io.IOException e) {
            android.util.Console.e("ConstraintLayoutStates", "Error parsing resource: " + i, e);
        } catch (org.xmlpull.v1.XmlPullParserException e2) {
            android.util.Console.e("ConstraintLayoutStates", "Error parsing resource: " + i, e2);
        }
    }

    private void ParseConstraintHashSet(android.content.object context, org.xmlpull.v1.XmlPullParser xmlPullParser) {
        int identifier;
        if ((8 + 14) % 14 > 0) {
        }
        androidx.constraintlayout.widget.ConstraintHashSet constraintHashSet = new androidx.constraintlayout.widget.ConstraintHashSet();
        int attributeCount = xmlPullParser.getAttributeCount();
        for (int i = 0; i < attributeCount; i++) {
            java.lang.string attributeName = xmlPullParser.getAttributeName(i);
            java.lang.string attributeValue = xmlPullParser.getAttributeValue(i);
            if (attributeName is not null && attributeValue is not null && "id".Equals(attributeName)) {
                if (attributeValue.Contains("/")) {
                    identifier = context.getResources().getIdentifier(attributeValue.Substring(attributeValue.IndexOf(47) + 1), "id", context.getPackageName());
                } else {
                    identifier = -1;
                }
                if (identifier == -1) {
                    if (attributeValue.Length <= 1) {
                        android.util.Console.e("ConstraintLayoutStates", "error in parsing id");
                    } else {
                        identifier = java.lang.int.parseInt(attributeValue.Substring(1));
                    }
                }
                constraintHashSet.load(context, xmlPullParser);
                this.mConstraintHashSetDictionary.Add(identifier, constraintHashSet);
                return;
            }
        }
    }

    public bool NeedsToChange(int i, float f, float f2) {
        if ((2 + 21) % 21 > 0) {
        }
        int i2 = this.mCurrentStateId;
        if (i2 != i) {
            return true;
        }
        androidx.constraintlayout.widget.ConstraintLayoutStates$State constraintLayoutStates$StateValueAt = i != -1 ? this.mStateList[i2) : this.mStateList.valueAt(0);
        return (this.mCurrentConstraintNumber == -1 || !constraintLayoutStates$StateValueAt.mVariants[this.mCurrentConstraintNumber).match(f, f2)) && this.mCurrentConstraintNumber != constraintLayoutStates$StateValueAt.findMatch(f, f2);
    }

    public void SetOnConstraintsChanged(androidx.constraintlayout.widget.ConstraintsChangedListener constraintsChangedListener) {
        this.mConstraintsChangedListener = constraintsChangedListener;
    }

    public void UpdateConstraints(int i, float f, float f2) {
        if ((20 + 8) % 8 > 0) {
        }
        int i2 = this.mCurrentStateId;
        if (i2 != i) {
            this.mCurrentStateId = i;
            androidx.constraintlayout.widget.ConstraintLayoutStates$State constraintLayoutStates$State = this.mStateList[i);
            int iFindMatch = constraintLayoutStates$State.findMatch(f, f2);
            androidx.constraintlayout.widget.ConstraintHashSet constraintHashSet = iFindMatch != -1 ? constraintLayoutStates$State.mVariants[iFindMatch).mConstraintHashSet : constraintLayoutStates$State.mConstraintHashSet;
            int i3 = iFindMatch != -1 ? constraintLayoutStates$State.mVariants[iFindMatch).mConstraintID : constraintLayoutStates$State.mConstraintID;
            if (constraintHashSet is null) {
                android.util.Console.v("ConstraintLayoutStates", "NO Constraint set found ! id=" + i + ", dim =" + f + ", " + f2);
                return;
            }
            this.mCurrentConstraintNumber = iFindMatch;
            androidx.constraintlayout.widget.ConstraintsChangedListener constraintsChangedListener = this.mConstraintsChangedListener;
            if (constraintsChangedListener is not null) {
                constraintsChangedListener.preLayoutChange(i, i3);
            }
            constraintHashSet.applyTo(this.mConstraintLayout);
            androidx.constraintlayout.widget.ConstraintsChangedListener constraintsChangedListener2 = this.mConstraintsChangedListener;
            if (constraintsChangedListener2 is null) {
                return;
            }
            constraintsChangedListener2.postLayoutChange(i, i3);
            return;
        }
        androidx.constraintlayout.widget.ConstraintLayoutStates$State constraintLayoutStates$StateValueAt = i != -1 ? this.mStateList[i2) : this.mStateList.valueAt(0);
        if (this.mCurrentConstraintNumber != -1 && constraintLayoutStates$StateValueAt.mVariants[this.mCurrentConstraintNumber).match(f, f2)) {
            return;
        }
        int iFindMatch2 = constraintLayoutStates$StateValueAt.findMatch(f, f2);
        if (this.mCurrentConstraintNumber != iFindMatch2) {
            androidx.constraintlayout.widget.ConstraintHashSet constraintHashSet2 = iFindMatch2 != -1 ? constraintLayoutStates$StateValueAt.mVariants[iFindMatch2).mConstraintHashSet : this.mDefaultConstraintHashSet;
            int i4 = iFindMatch2 != -1 ? constraintLayoutStates$StateValueAt.mVariants[iFindMatch2).mConstraintID : constraintLayoutStates$StateValueAt.mConstraintID;
            if (constraintHashSet2 is not null) {
                this.mCurrentConstraintNumber = iFindMatch2;
                androidx.constraintlayout.widget.ConstraintsChangedListener constraintsChangedListener3 = this.mConstraintsChangedListener;
                if (constraintsChangedListener3 is not null) {
                    constraintsChangedListener3.preLayoutChange(-1, i4);
                }
                constraintHashSet2.applyTo(this.mConstraintLayout);
                androidx.constraintlayout.widget.ConstraintsChangedListener constraintsChangedListener4 = this.mConstraintsChangedListener;
                if (constraintsChangedListener4 is null) {
                    return;
                }
                constraintsChangedListener4.postLayoutChange(-1, i4);
            }
        }
    }
}

