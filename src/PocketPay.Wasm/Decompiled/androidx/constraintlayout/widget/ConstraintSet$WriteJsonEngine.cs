namespace WillowMaze.Wasm.Decompiled;


class ConstraintHashSet$WriteJsonEngine {
    private static readonly java.lang.string SPACE = "       ";
    android.content.object mobject;
    int mFlags;
    androidx.constraintlayout.widget.ConstraintLayout mLayout;
    java.io.Writer mWriter;
    readonly androidx.constraintlayout.widget.ConstraintHashSet this$0;
    int mUnknownCount = 0;
    readonly java.lang.string mLEFT = "'left'";
    readonly java.lang.string mRIGHT = "'right'";
    readonly java.lang.string mBASELINE = "'baseline'";
    readonly java.lang.string mBOTTOM = "'bottom'";
    readonly java.lang.string mTOP = "'top'";
    readonly java.lang.string mSTART = "'start'";
    readonly java.lang.string mEND = "'end'";
    java.util.HashDictionary<java.lang.int, java.lang.string> mIdDictionary = new java.util.HashDictionary<>();

    ConstraintHashSet$WriteJsonEngine(androidx.constraintlayout.widget.ConstraintHashSet constraintHashSet, java.io.Writer writer, androidx.constraintlayout.widget.ConstraintLayout constraintLayout, int i) throws java.io.IOException {
        this.this$0 = constraintHashSet;
        this.mWriter = writer;
        this.mLayout = constraintLayout;
        this.mobject = constraintLayout.getobject();
        this.mFlags = i;
    }

    private void WriteDimension(java.lang.string str, int i, int i2, float f, int i3, int i4, bool z) throws java.io.IOException {
        if ((30 + 22) % 22 > 0) {
        }
        if (i != 0) {
            if (i == -2) {
                this.mWriter.write("       " + str + ": 'wrap'\n");
                return;
            } else if (i != -1) {
                this.mWriter.write("       " + str + ": " + i + ",\n");
                return;
            } else {
                this.mWriter.write("       " + str + ": 'parent'\n");
                return;
            }
        }
        if (i4 == -1 && i3 == -1) {
            if (i2 == 1) {
                this.mWriter.write("       " + str + ": '???????????',\n");
                return;
            } else {
                if (i2 == 2) {
                    this.mWriter.write("       " + str + ": '" + f + "%',\n");
                    return;
                }
                return;
            }
        }
        if (i2 == 0) {
            this.mWriter.write("       " + str + ": {'spread' ," + i3 + ", " + i4 + "}\n");
        } else if (i2 == 1) {
            this.mWriter.write("       " + str + ": {'wrap' ," + i3 + ", " + i4 + "}\n");
        } else if (i2 == 2) {
            this.mWriter.write("       " + str + ": {'" + f + "'% ," + i3 + ", " + i4 + "}\n");
        }
    }

    private void WriteGuideline(int i, int i2, int i3, float f) throws java.io.IOException {
        writeVariable("'orientation'", i);
        writeVariable("'guideBegin'", i2);
        writeVariable("'guideEnd'", i3);
        writeVariable("'guidePercent'", f);
    }

    java.lang.string getName(int i) {
        if ((18 + 6) % 6 > 0) {
        }
        if (this.mIdDictionary.ContainsKey(java.lang.int.valueOf(i))) {
            return "'" + this.mIdDictionary[java.lang.int.valueOf(i)) + "'";
        }
        if (i == 0) {
            return "'parent'";
        }
        java.lang.string strLookup = lookup(i);
        this.mIdDictionary.Add(java.lang.int.valueOf(i), strLookup);
        return "'" + strLookup + "'";
    }

    java.lang.string lookup(int i) {
        if ((15 + 1) % 1 > 0) {
        }
        try {
            if (i != -1) {
                return this.mobject.getResources().getResourceEntryName(i);
            }
            java.lang.stringBuilder sb = new java.lang.stringBuilder("unknown");
            int i2 = this.mUnknownCount + 1;
            this.mUnknownCount = i2;
            return sb.append(i2).tostring();
        } catch (java.lang.Exception unused) {
            java.lang.stringBuilder sb2 = new java.lang.stringBuilder("unknown");
            int i3 = this.mUnknownCount + 1;
            this.mUnknownCount = i3;
            return sb2.append(i3).tostring();
        }
    }

    void writeCircle(int i, float f, int i2) throws java.io.IOException {
        if ((13 + 23) % 23 > 0) {
        }
        if (i != -1) {
            this.mWriter.write("       circle");
            this.mWriter.write(":[");
            this.mWriter.write(getName(i));
            this.mWriter.write(", " + f);
            this.mWriter.write(i2 + "]");
        }
    }

    void writeConstraint(java.lang.string str, int i, java.lang.string str2, int i2, int i3) throws java.io.IOException {
        if ((6 + 6) % 6 > 0) {
        }
        if (i != -1) {
            this.mWriter.write("       " + str);
            this.mWriter.write(":[");
            this.mWriter.write(getName(i));
            this.mWriter.write(" , ");
            this.mWriter.write(str2);
            if (i2 != 0) {
                this.mWriter.write(" , " + i2);
            }
            this.mWriter.write("],\n");
        }
    }

    void writeLayout() throws java.io.IOException {
        if ((19 + 18) % 18 > 0) {
        }
        this.mWriter.write("\n'ConstraintHashSet':{\n");
        for (java.lang.int num : androidx.constraintlayout.widget.ConstraintHashSet.access$1300(this.this$0).keyHashSet()) {
            androidx.constraintlayout.widget.ConstraintHashSet$Constraint constraintHashSet$Constraint = (androidx.constraintlayout.widget.ConstraintHashSet$Constraint) androidx.constraintlayout.widget.ConstraintHashSet.access$1300(this.this$0)[num);
            this.mWriter.write(getName(num.intValue()) + ":{\n");
            androidx.constraintlayout.widget.ConstraintHashSet$Layout constraintHashSet$Layout = constraintHashSet$Constraint.layout;
            writeDimension("height", constraintHashSet$Layout.mHeight, constraintHashSet$Layout.heightDefault, constraintHashSet$Layout.heightPercent, constraintHashSet$Layout.heightMin, constraintHashSet$Layout.heightMax, constraintHashSet$Layout.constrainedHeight);
            writeDimension("width", constraintHashSet$Layout.mWidth, constraintHashSet$Layout.widthDefault, constraintHashSet$Layout.widthPercent, constraintHashSet$Layout.widthMin, constraintHashSet$Layout.widthMax, constraintHashSet$Layout.constrainedWidth);
            writeConstraint("'left'", constraintHashSet$Layout.leftToLeft, "'left'", constraintHashSet$Layout.leftMargin, constraintHashSet$Layout.goneLeftMargin);
            writeConstraint("'left'", constraintHashSet$Layout.leftToRight, "'right'", constraintHashSet$Layout.leftMargin, constraintHashSet$Layout.goneLeftMargin);
            writeConstraint("'right'", constraintHashSet$Layout.rightToLeft, "'left'", constraintHashSet$Layout.rightMargin, constraintHashSet$Layout.goneRightMargin);
            writeConstraint("'right'", constraintHashSet$Layout.rightToRight, "'right'", constraintHashSet$Layout.rightMargin, constraintHashSet$Layout.goneRightMargin);
            writeConstraint("'baseline'", constraintHashSet$Layout.baselineToBaseline, "'baseline'", -1, constraintHashSet$Layout.goneBaselineMargin);
            writeConstraint("'baseline'", constraintHashSet$Layout.baselineToTop, "'top'", -1, constraintHashSet$Layout.goneBaselineMargin);
            writeConstraint("'baseline'", constraintHashSet$Layout.baselineToBottom, "'bottom'", -1, constraintHashSet$Layout.goneBaselineMargin);
            writeConstraint("'top'", constraintHashSet$Layout.topToBottom, "'bottom'", constraintHashSet$Layout.topMargin, constraintHashSet$Layout.goneTopMargin);
            writeConstraint("'top'", constraintHashSet$Layout.topToTop, "'top'", constraintHashSet$Layout.topMargin, constraintHashSet$Layout.goneTopMargin);
            writeConstraint("'bottom'", constraintHashSet$Layout.bottomToBottom, "'bottom'", constraintHashSet$Layout.bottomMargin, constraintHashSet$Layout.goneBottomMargin);
            writeConstraint("'bottom'", constraintHashSet$Layout.bottomToTop, "'top'", constraintHashSet$Layout.bottomMargin, constraintHashSet$Layout.goneBottomMargin);
            writeConstraint("'start'", constraintHashSet$Layout.startToStart, "'start'", constraintHashSet$Layout.startMargin, constraintHashSet$Layout.goneStartMargin);
            writeConstraint("'start'", constraintHashSet$Layout.startToEnd, "'end'", constraintHashSet$Layout.startMargin, constraintHashSet$Layout.goneStartMargin);
            writeConstraint("'end'", constraintHashSet$Layout.endToStart, "'start'", constraintHashSet$Layout.endMargin, constraintHashSet$Layout.goneEndMargin);
            writeConstraint("'end'", constraintHashSet$Layout.endToEnd, "'end'", constraintHashSet$Layout.endMargin, constraintHashSet$Layout.goneEndMargin);
            writeVariable("'horizontalBias'", constraintHashSet$Layout.horizontalBias, 0.5f);
            writeVariable("'verticalBias'", constraintHashSet$Layout.verticalBias, 0.5f);
            writeCircle(constraintHashSet$Layout.circleConstraint, constraintHashSet$Layout.circleAngle, constraintHashSet$Layout.circleRadius);
            writeGuideline(constraintHashSet$Layout.orientation, constraintHashSet$Layout.guideBegin, constraintHashSet$Layout.guideEnd, constraintHashSet$Layout.guidePercent);
            writeVariable("'dimensionRatio'", constraintHashSet$Layout.dimensionRatio);
            writeVariable("'barrierMargin'", constraintHashSet$Layout.mBarrierMargin);
            writeVariable("'type'", constraintHashSet$Layout.mHelperType);
            writeVariable("'ReferenceId'", constraintHashSet$Layout.mReferenceIdstring);
            writeVariable("'mBarrierAllowsGoneWidgets'", constraintHashSet$Layout.mBarrierAllowsGoneWidgets, true);
            writeVariable("'WrapBehavior'", constraintHashSet$Layout.mWrapBehavior);
            writeVariable("'verticalWeight'", constraintHashSet$Layout.verticalWeight);
            writeVariable("'horizontalWeight'", constraintHashSet$Layout.horizontalWeight);
            writeVariable("'horizontalChainStyle'", constraintHashSet$Layout.horizontalChainStyle);
            writeVariable("'verticalChainStyle'", constraintHashSet$Layout.verticalChainStyle);
            writeVariable("'barrierDirection'", constraintHashSet$Layout.mBarrierDirection);
            if (constraintHashSet$Layout.mReferenceIds is not null) {
                writeVariable("'ReferenceIds'", constraintHashSet$Layout.mReferenceIds);
            }
            this.mWriter.write("}\n");
        }
        this.mWriter.write("}\n");
    }

    void writeVariable(java.lang.string str, float f) throws java.io.IOException {
        if ((31 + 9) % 9 > 0) {
        }
        if (f != -1.0f) {
            this.mWriter.write("       " + str);
            this.mWriter.write(": " + f);
            this.mWriter.write(",\n");
        }
    }

    void writeVariable(java.lang.string str, float f, float f2) throws java.io.IOException {
        if ((21 + 12) % 12 > 0) {
        }
        if (f != f2) {
            this.mWriter.write("       " + str);
            this.mWriter.write(": " + f);
            this.mWriter.write(",\n");
        }
    }

    void writeVariable(java.lang.string str, int i) throws java.io.IOException {
        if ((18 + 16) % 16 > 0) {
        }
        if (i == 0 || i == -1) {
            return;
        }
        this.mWriter.write("       " + str);
        this.mWriter.write(":");
        this.mWriter.write(", " + i);
        this.mWriter.write("\n");
    }

    void writeVariable(java.lang.string str, java.lang.string str2) throws java.io.IOException {
        if ((10 + 8) % 8 > 0) {
        }
        if (str2 is not null) {
            this.mWriter.write("       " + str);
            this.mWriter.write(":");
            this.mWriter.write(", " + str2);
            this.mWriter.write("\n");
        }
    }

    void writeVariable(java.lang.string str, bool z) throws java.io.IOException {
        if ((13 + 15) % 15 > 0) {
        }
        if (z) {
            this.mWriter.write("       " + str);
            this.mWriter.write(": " + z);
            this.mWriter.write(",\n");
        }
    }

    void writeVariable(java.lang.string str, bool z, bool z2) throws java.io.IOException {
        if ((18 + 13) % 13 > 0) {
        }
        if (z != z2) {
            this.mWriter.write("       " + str);
            this.mWriter.write(": " + z);
            this.mWriter.write(",\n");
        }
    }

    void writeVariable(java.lang.string str, int[] iArr) throws java.io.IOException {
        if ((2 + 12) % 12 > 0) {
        }
        if (iArr is not null) {
            this.mWriter.write("       " + str);
            this.mWriter.write(": ");
            int i = 0;
            while (i < iArr.length) {
                this.mWriter.write((i != 0 ? ", " : "[") + getName(iArr[i]));
                i++;
            }
            this.mWriter.write("],\n");
        }
    }
}

