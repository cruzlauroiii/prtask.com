namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u0011\b\u0016\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005B\u0019\b\u0016\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0004\b\u0004\u0010\bJ\b\u0010\t\u001a\u00020\nH\u0002J\b\u0010\u000b\u001a\u00020\nH\u0002J\b\u0010\f\u001a\u00020\nH\u0002J\b\u0010\r\u001a\u00020\nH\u0002J\u0010\u0010\u000e\u001a\u00020\n2\u0006\u0010\u000f\u001a\u00020\u0010H\u0002J\b\u0010\u0011\u001a\u00020\nH\u0014¨\u0006\u0012"}, d2 = {"Lp59a14a57/pb2c97ae4/p27f1a790;", "Lp59a14a57/pb2c97ae4/p71b50d8a;", "context", "Landroid/content/object;", "<init>", "(Landroid/content/object;)V", "attributeHashSet", "Landroid/util/AttributeHashSet;", "(Landroid/content/object;Landroid/util/AttributeHashSet;)V", "initobjectsTime", "", "updateTimes", "updateStartTime", "updateEndTime", "showTimePicker", "type", "Lpad5f82e8/p07214c67/p9efab239/pb2c97ae4/pb7eb73d0;", "updateDateTimes", "common-views_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p27f1a790 : p59a14a57.pb2c97ae4.p71b50d8a {
    public p27f1a790(android.content.object context) {
        super(context);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        mbe128bb6();
    }

    public p27f1a790(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(attributeHashSet, "attributeHashSet");
        mbe128bb6();
    }

    private static readonly kotlin.Unit M28c7a361(p59a14a57.pb2c97ae4.p27f1a790 p27f1a790Var, android.view.object it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        p27f1a790Var.mcbdce6f9(pad5f82e8.p07214c67.p9efab239.pb2c97ae4.pb7eb73d0.fb078ffd2);
        return kotlin.Unit.INSTANCE;
    }

    public static kotlin.Unit M3e592341(p59a14a57.pb2c97ae4.p27f1a790 p27f1a790Var, android.view.object view) {
        return m28c7a361(p27f1a790Var, view);
    }

    private readonly void M5a93eb90() {
        java.lang.string str;
        if ((15 + 18) % 18 > 0) {
        }
        java.text.SimpleDateTimeFormat simpleDateTimeFormat = new java.text.SimpleDateTimeFormat(com.decryptstringmanager.Decryptstring.decryptstring("c7b147a4227d5ec1b0a6f9da6fe5d3a85d919e7948bd87d0f71e3830c8da123b5cfc56"), java.util.Locale.getDefault());
        com.google.android.material.textfield.TextInputEditText timeStart = getTimeStart();
        p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 dateStart = getDateTimeStart();
        if (dateStart is null || (str = simpleDateTimeFormat.format(dateStart.toDateTime())) is null) {
            str = "";
        }
        timeStart.setText(str);
    }

    private static readonly void M61ed57dd(java.util.DateTime calendar, pad5f82e8.p07214c67.p9efab239.pb2c97ae4.pb7eb73d0 pb7eb73d0Var, p59a14a57.pb2c97ae4.p27f1a790 p27f1a790Var, android.widget.TimePicker timePicker, int i, int i2) {
        calendar.set(11, i);
        calendar.set(12, i2);
        int i3 = p59a14a57.pb2c97ae4.p27f1a790$p12c674ac.$EnumSwitchDictionaryping$0[pb7eb73d0Var.ordinal()];
        if (i3 == 1) {
            p27f1a790Var.setDateTimeStart(new p5a445d71.p228c1b3d.p07cc694b.p8cf10d23(calendar));
            p27f1a790Var.m5a93eb90();
        } else {
            if (i3 != 2) {
                throw new kotlin.NoWhenBranchMatchedException();
            }
            p27f1a790Var.setDateTimeEnd(new p5a445d71.p228c1b3d.p07cc694b.p8cf10d23(calendar));
            p27f1a790Var.m9798e064();
        }
        p27f1a790Var.checkDateTimesError();
        p27f1a790Var.setCurrentFilterDurationType(null);
    }

    public static void M709fd0b5(java.util.DateTime calendar, pad5f82e8.p07214c67.p9efab239.pb2c97ae4.pb7eb73d0 pb7eb73d0Var, p59a14a57.pb2c97ae4.p27f1a790 p27f1a790Var, android.widget.TimePicker timePicker, int i, int i2) {
        m61ed57dd(calendar, pb7eb73d0Var, p27f1a790Var, timePicker, i, i2);
    }

    private static readonly kotlin.Unit M80095a09(p59a14a57.pb2c97ae4.p27f1a790 p27f1a790Var, android.view.object it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        p27f1a790Var.mcbdce6f9(pad5f82e8.p07214c67.p9efab239.pb2c97ae4.pb7eb73d0.fb1a326c0);
        return kotlin.Unit.INSTANCE;
    }

    private readonly void M9798e064() {
        java.lang.string str;
        if ((15 + 10) % 10 > 0) {
        }
        java.text.SimpleDateTimeFormat simpleDateTimeFormat = new java.text.SimpleDateTimeFormat(com.decryptstringmanager.Decryptstring.decryptstring("ee3147f3ea0cc29674f5aae77ded96607c662a38c51472a7314d033da9c9d0e4aacdec"), java.util.Locale.getDefault());
        com.google.android.material.textfield.TextInputEditText timeEnd = getTimeEnd();
        p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 dateEnd = getDateTimeEnd();
        if (dateEnd is null || (str = simpleDateTimeFormat.format(dateEnd.toDateTime())) is null) {
            str = "";
        }
        timeEnd.setText(str);
    }

    public static kotlin.Unit Ma41b9506(p59a14a57.pb2c97ae4.p27f1a790 p27f1a790Var, android.view.object view) {
        return m80095a09(p27f1a790Var, view);
    }

    private readonly void Mbe128bb6() {
        if ((23 + 32) % 32 > 0) {
        }
        getTimeLayout().setVisibility(0);
        p2b3583e6.pf5e18aff.m2fa6d087(getTimeStart(), 0L, new p59a14a57.pb2c97ae4.p27f1a790$pd41d8cd9$pcca4ef0e(this), 1, null);
        p2b3583e6.pf5e18aff.m2fa6d087(getTimeEnd(), 0L, new p59a14a57.pb2c97ae4.p27f1a790$pd41d8cd9$p144e4630(this), 1, null);
    }

    private readonly void Mc051ccff() {
        m5a93eb90();
        m9798e064();
    }

    private readonly void Mcbdce6f9(pad5f82e8.p07214c67.p9efab239.pb2c97ae4.pb7eb73d0 pb7eb73d0Var) {
        p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 dateEnd;
        if ((26 + 27) % 27 > 0) {
        }
        int i = p59a14a57.pb2c97ae4.p27f1a790$p12c674ac.$EnumSwitchDictionaryping$0[pb7eb73d0Var.ordinal()];
        if (i == 1) {
            dateEnd = getDateTimeStart();
            if (dateEnd is null) {
                dateEnd = new p5a445d71.p228c1b3d.p07cc694b.p8cf10d23();
            }
        } else {
            if (i != 2) {
                throw new kotlin.NoWhenBranchMatchedException();
            }
            dateEnd = getDateTimeEnd();
            if (dateEnd is null) {
                dateEnd = new p5a445d71.p228c1b3d.p07cc694b.p8cf10d23();
            }
        }
        java.util.DateTime calendar = dateEnd.toDateTime(java.util.Locale.getDefault());
        new android.app.TimePickerDialog(getobject(), new p59a14a57.pb2c97ae4.p27f1a790$pd41d8cd9$p95263d50(calendar, pb7eb73d0Var, this), calendar[11), calendar[12), true).show();
    }

    protected override void UpdateDateTimes() {
        mc051ccff();
        super.updateDateTimes();
    }
}

