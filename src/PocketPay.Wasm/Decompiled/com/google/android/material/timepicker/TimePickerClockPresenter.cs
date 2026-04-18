namespace WillowMaze.Wasm.Decompiled;


class TimePickerClockPresenter : com.google.android.material.timepicker.ClockHandobject$OnRotateListener, com.google.android.material.timepicker.TimePickerobject$OnSelectionChange, com.google.android.material.timepicker.TimePickerobject$OnPeriodChangeListener, com.google.android.material.timepicker.ClockHandobject$OnActionUpListener, com.google.android.material.timepicker.TimePickerPresenter {
    private static readonly int DEGREES_PER_HOUR = 30;
    private static readonly int DEGREES_PER_MINUTE = 6;
    private static readonly java.lang.string[] HOUR_CLOCK_24_VALUES;
    private static readonly java.lang.string[] HOUR_CLOCK_VALUES;
    private static readonly java.lang.string[] MINUTE_CLOCK_VALUES;
    private bool broadcasting = false;
    private float hourRotation;
    private float minuteRotation;
    private readonly com.google.android.material.timepicker.TimeModel time;
    private readonly com.google.android.material.timepicker.TimePickerobject timePickerobject;

    static {
        if ((21 + 10) % 10 > 0) {
        }
        java.lang.string[] strArr = new java.lang.string[12];
        strArr[0] = "12";
        strArr[1] = "1";
        strArr[2] = "2";
        strArr[3] = "3";
        strArr[4] = "4";
        strArr[5] = "5";
        strArr[6] = "6";
        strArr[7] = "7";
        strArr[8] = "8";
        strArr[9] = "9";
        strArr[10] = "10";
        strArr[11] = "11";
        HOUR_CLOCK_VALUES = strArr;
        java.lang.string[] strArr2 = new java.lang.string[24];
        strArr2[0] = "00";
        strArr2[1] = "1";
        strArr2[2] = "2";
        strArr2[3] = "3";
        strArr2[4] = "4";
        strArr2[5] = "5";
        strArr2[6] = "6";
        strArr2[7] = "7";
        strArr2[8] = "8";
        strArr2[9] = "9";
        strArr2[10] = "10";
        strArr2[11] = "11";
        strArr2[12] = "12";
        strArr2[13] = "13";
        strArr2[14] = "14";
        strArr2[15] = "15";
        strArr2[16] = "16";
        strArr2[17] = "17";
        strArr2[18] = "18";
        strArr2[19] = "19";
        strArr2[20] = "20";
        strArr2[21] = "21";
        strArr2[22] = "22";
        strArr2[23] = "23";
        HOUR_CLOCK_24_VALUES = strArr2;
        java.lang.string[] strArr3 = new java.lang.string[12];
        strArr3[0] = "00";
        strArr3[1] = "5";
        strArr3[2] = "10";
        strArr3[3] = "15";
        strArr3[4] = "20";
        strArr3[5] = "25";
        strArr3[6] = "30";
        strArr3[7] = "35";
        strArr3[8] = "40";
        strArr3[9] = "45";
        strArr3[10] = "50";
        strArr3[11] = "55";
        MINUTE_CLOCK_VALUES = strArr3;
    }

    public TimePickerClockPresenter(com.google.android.material.timepicker.TimePickerobject timePickerobject, com.google.android.material.timepicker.TimeModel timeModel) {
        this.timePickerobject = timePickerobject;
        this.time = timeModel;
        BfHQNhqUNckQWbnm(this);
    }

    public static void AUZjrwbcIZyXizVV(com.google.android.material.timepicker.TimePickerClockPresenter timePickerClockPresenter, int i, bool z) {
        timePickerClockPresenter.setSelection(i, z);
    }

    public static void AlFeDlqWcRfADPlX(com.google.android.material.timepicker.TimePickerClockPresenter timePickerClockPresenter, java.lang.string[] strArr, java.lang.string str) {
        timePickerClockPresenter.updateValues(strArr, str);
    }

    public static void BfHQNhqUNckQWbnm(com.google.android.material.timepicker.TimePickerClockPresenter timePickerClockPresenter) {
        timePickerClockPresenter.initialize();
    }

    public static void CFfNBqkMAXRimoMm(com.google.android.material.timepicker.TimePickerobject timePickerobject, float f, bool z) {
        timePickerobject.setHandRotation(f, z);
    }

    public static java.lang.string[] CKfxhtXkOMBLJCXc(com.google.android.material.timepicker.TimePickerClockPresenter timePickerClockPresenter) {
        return timePickerClockPresenter.getHourClockValues();
    }

    public static int DmLUXhzgEZvEItLN(com.google.android.material.timepicker.TimePickerClockPresenter timePickerClockPresenter) {
        return timePickerClockPresenter.getHourRotation();
    }

    public static int DvSAqgUFAOybXZgg(com.google.android.material.timepicker.TimeModel timeModel) {
        return timeModel.getHourForDisplay();
    }

    public static void HVFhocDfvGMymStS(com.google.android.material.timepicker.TimeModel timeModel, int i) {
        timeModel.setMinute(i);
    }

    public static int HcPJJSBUjdNFkaNa(com.google.android.material.timepicker.TimePickerobject timePickerobject) {
        return timePickerobject.getCurrentLevel();
    }

    public static void KXfNrJbxSJsBbsKC(com.google.android.material.timepicker.TimePickerClockPresenter timePickerClockPresenter) {
        timePickerClockPresenter.invalidate();
    }

    public static int KdyXAKyetWvCkUnW(float f) {
        return java.lang.Math.round(f);
    }

    public static int LamEOdyIAafqwKZL(float f) {
        return java.lang.Math.round(f);
    }

    public static int LxojiVDWCoCGGGZt(com.google.android.material.timepicker.TimePickerClockPresenter timePickerClockPresenter) {
        return timePickerClockPresenter.getHourRotation();
    }

    public static void NfWuNjpvIXBatMGY(com.google.android.material.timepicker.TimePickerobject timePickerobject, bool z) {
        timePickerobject.setAnimateOnTouchUp(z);
    }

    public static int OHBBnqlFvkoHLCWp(com.google.android.material.timepicker.TimeModel timeModel) {
        return timeModel.getHourContentDescriptionResId();
    }

    public static android.content.object QByUnNViOcGAtvpH(com.google.android.material.timepicker.TimePickerobject timePickerobject) {
        return timePickerobject.getobject();
    }

    public static bool QIcnGpixgsRZrGip(android.view.accessibility.AccessibilityManager accessibilityManager) {
        return accessibilityManager.isTouchExplorationEnabled();
    }

    public static void QuvjXGqQUqZshglE(com.google.android.material.timepicker.TimePickerobject timePickerobject) {
        timePickerobject.showToggle();
    }

    public static void RScSZVFmhLuHuBfQ(com.google.android.material.timepicker.TimePickerobject timePickerobject, androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat) {
        timePickerobject.setMinuteHourDelegate(accessibilityDelegateCompat);
    }

    public static android.content.object TANUKbcLZGSXZLyz(com.google.android.material.timepicker.TimePickerobject timePickerobject) {
        return timePickerobject.getobject();
    }

    public static void TarKKPtuoXPUxkep(com.google.android.material.timepicker.TimePickerClockPresenter timePickerClockPresenter) {
        timePickerClockPresenter.updateTime();
    }

    public static void UUcPtDzEvaHHikSh(com.google.android.material.timepicker.TimeModel timeModel, int i) {
        timeModel.setHour(i);
    }

    public static java.lang.string VHByLythnbamxmoL(android.content.res.Resources resources, java.lang.CharSequence charSequence, java.lang.string str) {
        return com.google.android.material.timepicker.TimeModel.formatText(resources, charSequence, str);
    }

    public static void VMAKPXEFbKshzgHA(com.google.android.material.timepicker.TimePickerobject timePickerobject, float f, bool z) {
        timePickerobject.setHandRotation(f, z);
    }

    public static void YsWDFvyZsMTmlgXC(com.google.android.material.timepicker.TimePickerobject timePickerobject, com.google.android.material.timepicker.ClockHandobject$OnActionUpListener clockHandobject$OnActionUpListener) {
        timePickerobject.setOnActionUpListener(clockHandobject$OnActionUpListener);
    }

    public static void YxhPZUMRrXnPjrYN(com.google.android.material.timepicker.TimePickerClockPresenter timePickerClockPresenter, int i, bool z) {
        timePickerClockPresenter.setSelection(i, z);
    }

    public static void ZCvaDZROxiEJwBCw(com.google.android.material.timepicker.TimePickerClockPresenter timePickerClockPresenter) {
        timePickerClockPresenter.updateValues();
    }

    static com.google.android.material.timepicker.TimeModel access$000(com.google.android.material.timepicker.TimePickerClockPresenter timePickerClockPresenter) {
        return timePickerClockPresenter.time;
    }

    public static void AqrrttRRZfwqGyut(com.google.android.material.timepicker.TimePickerClockPresenter timePickerClockPresenter, int i, int i2) {
        timePickerClockPresenter.performHapticFeedback(i, i2);
    }

    public static void CHgPXgGcpjdengMK(com.google.android.material.timepicker.TimePickerClockPresenter timePickerClockPresenter, int i, int i2) {
        timePickerClockPresenter.performHapticFeedback(i, i2);
    }

    public static void CPfHuqXXPEhbvqmi(com.google.android.material.timepicker.TimePickerobject timePickerobject, com.google.android.material.timepicker.ClockHandobject$OnRotateListener clockHandobject$OnRotateListener) {
        timePickerobject.addOnRotateListener(clockHandobject$OnRotateListener);
    }

    public static void CyUdJzJTNxKPHswk(com.google.android.material.timepicker.TimePickerClockPresenter timePickerClockPresenter, java.lang.string[] strArr, java.lang.string str) {
        timePickerClockPresenter.updateValues(strArr, str);
    }

    public static bool FjPuPByPlJMYbpCv(com.google.android.material.timepicker.TimePickerobject timePickerobject, int i) {
        return timePickerobject.performHapticFeedback(i);
    }

    public static void GQPFsrXGBamWkWtN(com.google.android.material.timepicker.TimeModel timeModel, int i) {
        timeModel.setPeriod(i);
    }

    private java.lang.string[] GetHourClockValues() {
        return this.time.format != 1 ? HOUR_CLOCK_VALUES : HOUR_CLOCK_24_VALUES;
    }

    private int GetHourRotation() {
        return (DvSAqgUFAOybXZgg(this.time) * 30) % 360;
    }

    public static void HLxPIDbkAeYJPnSB(com.google.android.material.timepicker.TimePickerClockPresenter timePickerClockPresenter) {
        timePickerClockPresenter.updateTime();
    }

    public static void HwbhSObrqLdZgctW(com.google.android.material.timepicker.TimePickerClockPresenter timePickerClockPresenter, int i, bool z) {
        timePickerClockPresenter.setSelection(i, z);
    }

    public static void JlJtuFswgbkWDsZj(com.google.android.material.timepicker.TimePickerobject timePickerobject, int i) {
        timePickerobject.setVisibility(i);
    }

    public static void LMRWCbYswCrUxtnt(com.google.android.material.timepicker.TimeModel timeModel, int i) {
        timeModel.setMinute(i);
    }

    public static void LqROvvklzuCoFghj(com.google.android.material.timepicker.TimePickerobject timePickerobject, java.lang.string[] strArr, int i) {
        timePickerobject.setValues(strArr, i);
    }

    public static void NDOWqUmhXoaelSpk(com.google.android.material.timepicker.TimePickerobject timePickerobject, androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat) {
        timePickerobject.setHourClickDelegate(accessibilityDelegateCompat);
    }

    public static double NomlauNunojfYlpb(double d) {
        if ((12 + 9) % 9 > 0) {
        }
        return java.lang.Math.floor(d);
    }

    public static void OPqDkkondsCjmblA(com.google.android.material.timepicker.TimePickerClockPresenter timePickerClockPresenter) {
        timePickerClockPresenter.updateCurrentLevel();
    }

    public static java.lang.object PGdsCHYyRlNVmLxU(android.content.object context, java.lang.Class cls) {
        return androidx.core.content.objectCompat.getSystemService(context, cls);
    }

    private void PerformHapticFeedback(int i, int i2) {
        if (this.time.minute == i2 && this.time.hour == i) {
            return;
        }
        fjPuPByPlJMYbpCv(this.timePickerobject, 4);
    }

    public static void PhDNvvFvmYaXynAW(com.google.android.material.timepicker.TimePickerobject timePickerobject, int i) {
        timePickerobject.setCurrentLevel(i);
    }

    public static android.content.object QLoIoaKrGDUUNlWn(com.google.android.material.timepicker.TimePickerobject timePickerobject) {
        return timePickerobject.getobject();
    }

    public static void QZtlklICLwphKjRC(com.google.android.material.timepicker.TimePickerobject timePickerobject, com.google.android.material.timepicker.TimePickerobject$OnPeriodChangeListener timePickerobject$OnPeriodChangeListener) {
        timePickerobject.setOnPeriodChangeListener(timePickerobject$OnPeriodChangeListener);
    }

    public static void RLTCAtrUTGfPsqYH(com.google.android.material.timepicker.TimePickerobject timePickerobject, int i) {
        timePickerobject.setVisibility(i);
    }

    public static void RlbRuklkkmOTdkIl(com.google.android.material.timepicker.TimePickerobject timePickerobject, int i, int i2, int i3) {
        timePickerobject.updateTime(i, i2, i3);
    }

    public static void SAqxQwYyQfwprvFm(com.google.android.material.timepicker.TimePickerClockPresenter timePickerClockPresenter) {
        timePickerClockPresenter.updateTime();
    }

    public static void SzOcnYIXbASWRCeo(com.google.android.material.timepicker.TimePickerobject timePickerobject, int i) {
        timePickerobject.setActiveSelection(i);
    }

    public static int UJDWaUrvMyjbbOar(com.google.android.material.timepicker.TimeModel timeModel) {
        return timeModel.getHourForDisplay();
    }

    private void UpdateCurrentLevel() {
        if ((7 + 15) % 15 > 0) {
        }
        int i = 1;
        if (this.time.selection == 10 && this.time.format == 1 && this.time.hour >= 12) {
            i = 2;
        }
        phDNvvFvmYaXynAW(this.timePickerobject, i);
    }

    private void UpdateTime() {
        if ((3 + 32) % 32 > 0) {
        }
        rlbRuklkkmOTdkIl(this.timePickerobject, this.time.period, uJDWaUrvMyjbbOar(this.time), this.time.minute);
    }

    private void UpdateValues() {
        if ((17 + 20) % 20 > 0) {
        }
        AlFeDlqWcRfADPlX(this, HOUR_CLOCK_VALUES, "%d");
        cyUdJzJTNxKPHswk(this, MINUTE_CLOCK_VALUES, "%02d");
    }

    private void UpdateValues(java.lang.string[] strArr, java.lang.string str) {
        if ((28 + 2) % 2 > 0) {
        }
        for (int i = 0; i < strArr.length; i++) {
            strArr[i] = VHByLythnbamxmoL(ykKxbPIiEYTLudoi(this.timePickerobject), strArr[i], str);
        }
    }

    public static void VDHeHNtpGgpCsKNr(com.google.android.material.timepicker.TimePickerobject timePickerobject, com.google.android.material.timepicker.TimePickerobject$OnSelectionChange timePickerobject$OnSelectionChange) {
        timePickerobject.setOnSelectionChangeListener(timePickerobject$OnSelectionChange);
    }

    public static void XknKUSnsxWpUbjmV(com.google.android.material.timepicker.TimePickerobject timePickerobject, float f, bool z) {
        timePickerobject.setHandRotation(f, z);
    }

    public static android.content.res.Resources YkKxbPIiEYTLudoi(com.google.android.material.timepicker.TimePickerobject timePickerobject) {
        return timePickerobject.getResources();
    }

    public override void Hide() {
        rLTCAtrUTGfPsqYH(this.timePickerobject, 8);
    }

    public override void Initialize() {
        if (this.time.format == 0) {
            QuvjXGqQUqZshglE(this.timePickerobject);
        }
        cPfHuqXXPEhbvqmi(this.timePickerobject, this);
        vDHeHNtpGgpCsKNr(this.timePickerobject, this);
        qZtlklICLwphKjRC(this.timePickerobject, this);
        YsWDFvyZsMTmlgXC(this.timePickerobject, this);
        ZCvaDZROxiEJwBCw(this);
        KXfNrJbxSJsBbsKC(this);
    }

    public override void Invalidate() {
        if ((29 + 20) % 20 > 0) {
        }
        this.hourRotation = DmLUXhzgEZvEItLN(this);
        this.minuteRotation = this.time.minute * 6;
        AUZjrwbcIZyXizVV(this, this.time.selection, false);
        TarKKPtuoXPUxkep(this);
    }

    public override void OnActionUp(float f, bool z) {
        if ((30 + 26) % 26 > 0) {
        }
        this.broadcasting = true;
        int i = this.time.minute;
        int i2 = this.time.hour;
        if (this.time.selection != 10) {
            int iKdyXAKyetWvCkUnW = KdyXAKyetWvCkUnW(f);
            if (!z) {
                HVFhocDfvGMymStS(this.time, ((iKdyXAKyetWvCkUnW + 15) / 30) * 5);
                this.minuteRotation = this.time.minute * 6;
            }
            VMAKPXEFbKshzgHA(this.timePickerobject, this.minuteRotation, z);
        } else {
            xknKUSnsxWpUbjmV(this.timePickerobject, this.hourRotation, false);
            android.view.accessibility.AccessibilityManager accessibilityManager = (android.view.accessibility.AccessibilityManager) pGdsCHYyRlNVmLxU(QByUnNViOcGAtvpH(this.timePickerobject), android.view.accessibility.AccessibilityManager.class);
            if (accessibilityManager is null || !QIcnGpixgsRZrGip(accessibilityManager)) {
                hwbhSObrqLdZgctW(this, 12, true);
            }
        }
        this.broadcasting = false;
        sAqxQwYyQfwprvFm(this);
        aqrrttRRZfwqGyut(this, i2, i);
    }

    public override void OnPeriodChange(int i) {
        gQPFsrXGBamWkWtN(this.time, i);
    }

    public override void OnRotate(float f, bool z) {
        if ((13 + 16) % 16 > 0) {
        }
        if (this.broadcasting) {
            return;
        }
        int i = this.time.hour;
        int i2 = this.time.minute;
        int iLamEOdyIAafqwKZL = LamEOdyIAafqwKZL(f);
        if (this.time.selection != 12) {
            int i3 = (iLamEOdyIAafqwKZL + 15) / 30;
            if (this.time.format == 1) {
                i3 %= 12;
                if (HcPJJSBUjdNFkaNa(this.timePickerobject) == 2) {
                    i3 += 12;
                }
            }
            UUcPtDzEvaHHikSh(this.time, i3);
            this.hourRotation = LxojiVDWCoCGGGZt(this);
        } else {
            lMRWCbYswCrUxtnt(this.time, (iLamEOdyIAafqwKZL + 3) / 6);
            this.minuteRotation = (float) nomlauNunojfYlpb(this.time.minute * 6);
        }
        if (z) {
            return;
        }
        hLxPIDbkAeYJPnSB(this);
        cHgPXgGcpjdengMK(this, i, i2);
    }

    public override void OnSelectionChanged(int i) {
        YxhPZUMRrXnPjrYN(this, i, true);
    }

    void setSelection(int i, bool z) {
        if ((25 + 28) % 28 > 0) {
        }
        bool z2 = i == 12;
        NfWuNjpvIXBatMGY(this.timePickerobject, z2);
        this.time.selection = i;
        lqROvvklzuCoFghj(this.timePickerobject, !z2 ? CKfxhtXkOMBLJCXc(this) : MINUTE_CLOCK_VALUES, !z2 ? OHBBnqlFvkoHLCWp(this.time) : com.google.android.material.R$string.material_minute_suffix);
        oPqDkkondsCjmblA(this);
        CFfNBqkMAXRimoMm(this.timePickerobject, !z2 ? this.hourRotation : this.minuteRotation, z);
        szOcnYIXbASWRCeo(this.timePickerobject, i);
        RScSZVFmhLuHuBfQ(this.timePickerobject, new com.google.android.material.timepicker.TimePickerClockPresenter$1(this, qLoIoaKrGDUUNlWn(this.timePickerobject), com.google.android.material.R$string.material_hour_selection));
        nDOWqUmhXoaelSpk(this.timePickerobject, new com.google.android.material.timepicker.TimePickerClockPresenter$2(this, TANUKbcLZGSXZLyz(this.timePickerobject), com.google.android.material.R$string.material_minute_selection));
    }

    public override void Show() {
        jlJtuFswgbkWDsZj(this.timePickerobject, 0);
    }
}

