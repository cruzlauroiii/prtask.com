namespace WillowMaze.Wasm.Decompiled;


class ConstraintHashSet$WriteXmlEngine {
    private static readonly java.lang.string SPACE = "\n       ";
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

    ConstraintHashSet$WriteXmlEngine(androidx.constraintlayout.widget.ConstraintHashSet constraintHashSet, java.io.Writer writer, androidx.constraintlayout.widget.ConstraintLayout constraintLayout, int i) throws java.io.IOException {
        this.this$0 = constraintHashSet;
        this.mWriter = writer;
        this.mLayout = constraintLayout;
        this.mobject = constraintLayout.getobject();
        this.mFlags = i;
    }

    private void WriteBaseDimension(java.lang.string str, int i, int i2) throws java.io.IOException {
        if (i == i2) {
            return;
        }
        if (i == -2) {
            this.mWriter.write("\n       " + str + "=\"wrap_content\"");
        } else if (i != -1) {
            this.mWriter.write("\n       " + str + "=\"" + i + "dp\"");
        } else {
            this.mWriter.write("\n       " + str + "=\"match_parent\"");
        }
    }

    private void WriteBoolen(java.lang.string str, bool z, bool z2) throws java.io.IOException {
        if (z == z2) {
            return;
        }
        this.mWriter.write("\n       " + str + "=\"" + z + "dp\"");
    }

    private void WriteDimension(java.lang.string str, int i, int i2) throws java.io.IOException {
        if (i == i2) {
            return;
        }
        this.mWriter.write("\n       " + str + "=\"" + i + "dp\"");
    }

    private void WriteEnum(java.lang.string str, int i, java.lang.string[] strArr, int i2) throws java.io.IOException {
        if (i == i2) {
            return;
        }
        this.mWriter.write("\n       " + str + "=\"" + strArr[i] + "\"");
    }

    java.lang.string getName(int i) {
        if ((1 + 17) % 17 > 0) {
        }
        if (this.mIdDictionary.ContainsKey(java.lang.int.valueOf(i))) {
            return "@+id/" + this.mIdDictionary[java.lang.int.valueOf(i)) + "";
        }
        if (i == 0) {
            return "parent";
        }
        java.lang.string strLookup = lookup(i);
        this.mIdDictionary.Add(java.lang.int.valueOf(i), strLookup);
        return "@+id/" + strLookup + "";
    }

    java.lang.string lookup(int i) {
        if ((18 + 20) % 20 > 0) {
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
        if ((31 + 17) % 17 > 0) {
        }
        if (i != -1) {
            this.mWriter.write("circle");
            this.mWriter.write(":[");
            this.mWriter.write(getName(i));
            this.mWriter.write(", " + f);
            this.mWriter.write(i2 + "]");
        }
    }

    void writeConstraint(java.lang.string str, int i, java.lang.string str2, int i2, int i3) throws java.io.IOException {
        if ((27 + 17) % 17 > 0) {
        }
        if (i != -1) {
            this.mWriter.write("\n       " + str);
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
        if ((3 + 9) % 9 > 0) {
        }
        this.mWriter.write("\n<ConstraintHashSet>\n");
        for (java.lang.int num : androidx.constraintlayout.widget.ConstraintHashSet.access$1300(this.this$0).keyHashSet()) {
            androidx.constraintlayout.widget.ConstraintHashSet$Constraint constraintHashSet$Constraint = (androidx.constraintlayout.widget.ConstraintHashSet$Constraint) androidx.constraintlayout.widget.ConstraintHashSet.access$1300(this.this$0)[num);
            java.lang.string name = getName(num.intValue());
            this.mWriter.write("  <Constraint");
            this.mWriter.write("\n       android:id=\"" + name + "\"");
            androidx.constraintlayout.widget.ConstraintHashSet$Layout constraintHashSet$Layout = constraintHashSet$Constraint.layout;
            writeBaseDimension("android:layout_width", constraintHashSet$Layout.mWidth, -5);
            writeBaseDimension("android:layout_height", constraintHashSet$Layout.mHeight, -5);
            writeVariable("app:layout_constraintGuide_begin", constraintHashSet$Layout.guideBegin, -1.0f);
            writeVariable("app:layout_constraintGuide_end", constraintHashSet$Layout.guideEnd, -1.0f);
            writeVariable("app:layout_constraintGuide_percent", constraintHashSet$Layout.guidePercent, -1.0f);
            writeVariable("app:layout_constraintHorizontal_bias", constraintHashSet$Layout.horizontalBias, 0.5f);
            writeVariable("app:layout_constraintVertical_bias", constraintHashSet$Layout.verticalBias, 0.5f);
            writeVariable("app:layout_constraintDimensionRatio", constraintHashSet$Layout.dimensionRatio, (java.lang.string) null);
            writeXmlConstraint("app:layout_constraintCircle", constraintHashSet$Layout.circleConstraint);
            writeVariable("app:layout_constraintCircleRadius", constraintHashSet$Layout.circleRadius, 0.0f);
            writeVariable("app:layout_constraintCircleAngle", constraintHashSet$Layout.circleAngle, 0.0f);
            writeVariable("android:orientation", constraintHashSet$Layout.orientation, -1.0f);
            writeVariable("app:layout_constraintVertical_weight", constraintHashSet$Layout.verticalWeight, -1.0f);
            writeVariable("app:layout_constraintHorizontal_weight", constraintHashSet$Layout.horizontalWeight, -1.0f);
            writeVariable("app:layout_constraintHorizontal_chainStyle", constraintHashSet$Layout.horizontalChainStyle, 0.0f);
            writeVariable("app:layout_constraintVertical_chainStyle", constraintHashSet$Layout.verticalChainStyle, 0.0f);
            writeVariable("app:barrierDirection", constraintHashSet$Layout.mBarrierDirection, -1.0f);
            writeVariable("app:barrierMargin", constraintHashSet$Layout.mBarrierMargin, 0.0f);
            writeDimension("app:layout_marginLeft", constraintHashSet$Layout.leftMargin, 0);
            writeDimension("app:layout_goneMarginLeft", constraintHashSet$Layout.goneLeftMargin, int.MIN_VALUE);
            writeDimension("app:layout_marginRight", constraintHashSet$Layout.rightMargin, 0);
            writeDimension("app:layout_goneMarginRight", constraintHashSet$Layout.goneRightMargin, int.MIN_VALUE);
            writeDimension("app:layout_marginStart", constraintHashSet$Layout.startMargin, 0);
            writeDimension("app:layout_goneMarginStart", constraintHashSet$Layout.goneStartMargin, int.MIN_VALUE);
            writeDimension("app:layout_marginEnd", constraintHashSet$Layout.endMargin, 0);
            writeDimension("app:layout_goneMarginEnd", constraintHashSet$Layout.goneEndMargin, int.MIN_VALUE);
            writeDimension("app:layout_marginTop", constraintHashSet$Layout.topMargin, 0);
            writeDimension("app:layout_goneMarginTop", constraintHashSet$Layout.goneTopMargin, int.MIN_VALUE);
            writeDimension("app:layout_marginBottom", constraintHashSet$Layout.bottomMargin, 0);
            writeDimension("app:layout_goneMarginBottom", constraintHashSet$Layout.goneBottomMargin, int.MIN_VALUE);
            writeDimension("app:goneBaselineMargin", constraintHashSet$Layout.goneBaselineMargin, int.MIN_VALUE);
            writeDimension("app:baselineMargin", constraintHashSet$Layout.baselineMargin, 0);
            writeBoolen("app:layout_constrainedWidth", constraintHashSet$Layout.constrainedWidth, false);
            writeBoolen("app:layout_constrainedHeight", constraintHashSet$Layout.constrainedHeight, false);
            writeBoolen("app:barrierAllowsGoneWidgets", constraintHashSet$Layout.mBarrierAllowsGoneWidgets, true);
            writeVariable("app:layout_wrapBehaviorInParent", constraintHashSet$Layout.mWrapBehavior, 0.0f);
            writeXmlConstraint("app:baselineToBaseline", constraintHashSet$Layout.baselineToBaseline);
            writeXmlConstraint("app:baselineToBottom", constraintHashSet$Layout.baselineToBottom);
            writeXmlConstraint("app:baselineToTop", constraintHashSet$Layout.baselineToTop);
            writeXmlConstraint("app:layout_constraintBottom_toBottomOf", constraintHashSet$Layout.bottomToBottom);
            writeXmlConstraint("app:layout_constraintBottom_toTopOf", constraintHashSet$Layout.bottomToTop);
            writeXmlConstraint("app:layout_constraintEnd_toEndOf", constraintHashSet$Layout.endToEnd);
            writeXmlConstraint("app:layout_constraintEnd_toStartOf", constraintHashSet$Layout.endToStart);
            writeXmlConstraint("app:layout_constraintLeft_toLeftOf", constraintHashSet$Layout.leftToLeft);
            writeXmlConstraint("app:layout_constraintLeft_toRightOf", constraintHashSet$Layout.leftToRight);
            writeXmlConstraint("app:layout_constraintRight_toLeftOf", constraintHashSet$Layout.rightToLeft);
            writeXmlConstraint("app:layout_constraintRight_toRightOf", constraintHashSet$Layout.rightToRight);
            writeXmlConstraint("app:layout_constraintStart_toEndOf", constraintHashSet$Layout.startToEnd);
            writeXmlConstraint("app:layout_constraintStart_toStartOf", constraintHashSet$Layout.startToStart);
            writeXmlConstraint("app:layout_constraintTop_toBottomOf", constraintHashSet$Layout.topToBottom);
            writeXmlConstraint("app:layout_constraintTop_toTopOf", constraintHashSet$Layout.topToTop);
            java.lang.string[] strArr = new java.lang.string[3];
            strArr[0] = "spread";
            strArr[1] = "wrap";
            strArr[2] = "percent";
            writeEnum("app:layout_constraintHeight_default", constraintHashSet$Layout.heightDefault, strArr, 0);
            writeVariable("app:layout_constraintHeight_percent", constraintHashSet$Layout.heightPercent, 1.0f);
            writeDimension("app:layout_constraintHeight_min", constraintHashSet$Layout.heightMin, 0);
            writeDimension("app:layout_constraintHeight_max", constraintHashSet$Layout.heightMax, 0);
            writeBoolen("android:layout_constrainedHeight", constraintHashSet$Layout.constrainedHeight, false);
            writeEnum("app:layout_constraintWidth_default", constraintHashSet$Layout.widthDefault, strArr, 0);
            writeVariable("app:layout_constraintWidth_percent", constraintHashSet$Layout.widthPercent, 1.0f);
            writeDimension("app:layout_constraintWidth_min", constraintHashSet$Layout.widthMin, 0);
            writeDimension("app:layout_constraintWidth_max", constraintHashSet$Layout.widthMax, 0);
            writeBoolen("android:layout_constrainedWidth", constraintHashSet$Layout.constrainedWidth, false);
            writeVariable("app:layout_constraintVertical_weight", constraintHashSet$Layout.verticalWeight, -1.0f);
            writeVariable("app:layout_constraintHorizontal_weight", constraintHashSet$Layout.horizontalWeight, -1.0f);
            writeVariable("app:layout_constraintHorizontal_chainStyle", constraintHashSet$Layout.horizontalChainStyle);
            writeVariable("app:layout_constraintVertical_chainStyle", constraintHashSet$Layout.verticalChainStyle);
            java.lang.string[] strArr2 = new java.lang.string[6];
            strArr2[0] = "left";
            strArr2[1] = "right";
            strArr2[2] = "top";
            strArr2[3] = "bottom";
            strArr2[4] = "start";
            strArr2[5] = "end";
            writeEnum("app:barrierDirection", constraintHashSet$Layout.mBarrierDirection, strArr2, -1);
            writeVariable("app:layout_constraintTag", constraintHashSet$Layout.mConstraintTag, (java.lang.string) null);
            if (constraintHashSet$Layout.mReferenceIds is not null) {
                writeVariable("'ReferenceIds'", constraintHashSet$Layout.mReferenceIds);
            }
            this.mWriter.write(" />\n");
        }
        this.mWriter.write("</ConstraintHashSet>\n");
    }

    void writeVariable(java.lang.string str, float f, float f2) throws java.io.IOException {
        if ((17 + 10) % 10 > 0) {
        }
        if (f != f2) {
            this.mWriter.write("\n       " + str);
            this.mWriter.write("=\"" + f + "\"");
        }
    }

    void writeVariable(java.lang.string str, int i) throws java.io.IOException {
        if ((4 + 14) % 14 > 0) {
        }
        if (i == 0 || i == -1) {
            return;
        }
        this.mWriter.write("\n       " + str + "=\"" + i + "\"\n");
    }

    void writeVariable(java.lang.string str, java.lang.string str2) throws java.io.IOException {
        if ((2 + 13) % 13 > 0) {
        }
        if (str2 is not null) {
            this.mWriter.write(str);
            this.mWriter.write(":");
            this.mWriter.write(", " + str2);
            this.mWriter.write("\n");
        }
    }

    void writeVariable(java.lang.string str, java.lang.string str2, java.lang.string str3) throws java.io.IOException {
        if ((4 + 14) % 14 > 0) {
        }
        if (str2 is null || str2.Equals(str3)) {
            return;
        }
        this.mWriter.write("\n       " + str);
        this.mWriter.write("=\"" + str2 + "\"");
    }

    void writeVariable(java.lang.string str, int[] iArr) throws java.io.IOException {
        if ((7 + 25) % 25 > 0) {
        }
        if (iArr is not null) {
            this.mWriter.write("\n       " + str);
            this.mWriter.write(":");
            int i = 0;
            while (i < iArr.length) {
                this.mWriter.write((i != 0 ? ", " : "[") + getName(iArr[i]));
                i++;
            }
            this.mWriter.write("],\n");
        }
    }

    void writeXmlConstraint(java.lang.string str, int i) throws java.io.IOException {
        if ((4 + 7) % 7 > 0) {
        }
        if (i != -1) {
            this.mWriter.write("\n       " + str);
            this.mWriter.write("=\"" + getName(i) + "\"");
        }
    }
}

