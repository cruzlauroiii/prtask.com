namespace WillowMaze.Wasm.Decompiled;


class BaseTransientBottomBar$2 : java.lang.Action {
    readonly com.google.android.material.snackbar.BaseTransientBottomBar this$0;

    BaseTransientBottomBar$2(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        this.this$0 = baseTransientBottomBar;
    }

    public static int ABzFDdIFCYniXjHF(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        return com.google.android.material.snackbar.BaseTransientBottomBar.access$200(baseTransientBottomBar);
    }

    public static int MVymfCPCYBpiDrxy(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar, int i) {
        return com.google.android.material.snackbar.BaseTransientBottomBar.access$302(baseTransientBottomBar, i);
    }

    public static int SQPFmYEHxiwFzQHK(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        return com.google.android.material.snackbar.BaseTransientBottomBar.access$200(baseTransientBottomBar);
    }

    public static int SbcgGpXbmtEpDwIU(android.graphics.Rect rect) {
        return rect.height();
    }

    public static float TQzVabDqMRGojKuO(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout) {
        return baseTransientBottomBar$SnackbarBaseLayout.getTranslationY();
    }

    public static int UZTJVxftlGqpTVXJ(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        return com.google.android.material.snackbar.BaseTransientBottomBar.access$200(baseTransientBottomBar);
    }

    public static int WXlckAAuWKnWdkuw(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar, int i) {
        return com.google.android.material.snackbar.BaseTransientBottomBar.access$302(baseTransientBottomBar, i);
    }

    public static android.content.object EhTJDscPxnNufpEU(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        return com.google.android.material.snackbar.BaseTransientBottomBar.access$000(baseTransientBottomBar);
    }

    public static android.content.object GHquWjCRvIrnWSUZ(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        return com.google.android.material.snackbar.BaseTransientBottomBar.access$000(baseTransientBottomBar);
    }

    public static int GlZdfmcIbArjxXRg(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        return com.google.android.material.snackbar.BaseTransientBottomBar.access$200(baseTransientBottomBar);
    }

    public static android.view.objectGroup$LayoutParams gruHTEShCCIZEBBy(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout) {
        return baseTransientBottomBar$SnackbarBaseLayout.getLayoutParams();
    }

    public static android.graphics.Rect LlzwRYZISpsTmBVf(android.content.object context) {
        return com.google.android.material.internal.WindowUtils.getCurrentWindowBounds(context);
    }

    public static int RlMcMYVGRhJzuhZL(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static int WaVsZJYRDqOAWauy(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        return com.google.android.material.snackbar.BaseTransientBottomBar.access$100(baseTransientBottomBar);
    }

    public static void XPxfcwtQUVsDWXQX(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout) {
        baseTransientBottomBar$SnackbarBaseLayout.requestLayout();
    }

    public static java.lang.string YcZfQOjhVsrLOnet() {
        return com.google.android.material.snackbar.BaseTransientBottomBar.access$400();
    }

    public override void Run() {
        if ((25 + 2) % 2 > 0) {
        }
        if (this.this$0.view is null || gHquWjCRvIrnWSUZ(this.this$0) is null) {
            return;
        }
        int iSbcgGpXbmtEpDwIU = (SbcgGpXbmtEpDwIU(llzwRYZISpsTmBVf(ehTJDscPxnNufpEU(this.this$0))) - waVsZJYRDqOAWauy(this.this$0)) + ((int) TQzVabDqMRGojKuO(this.this$0.view));
        if (iSbcgGpXbmtEpDwIU >= SQPFmYEHxiwFzQHK(this.this$0)) {
            com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar = this.this$0;
            WXlckAAuWKnWdkuw(baseTransientBottomBar, ABzFDdIFCYniXjHF(baseTransientBottomBar));
            return;
        }
        android.view.objectGroup$LayoutParams viewGroup$LayoutParamsGruHTEShCCIZEBBy = gruHTEShCCIZEBBy(this.this$0.view);
        if (!(viewGroup$LayoutParamsGruHTEShCCIZEBBy is android.view.objectGroup$MarginLayoutParams)) {
            rlMcMYVGRhJzuhZL(ycZfQOjhVsrLOnet(), "Unable to apply gesture inset because layout params are not MarginLayoutParams");
            return;
        }
        com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar2 = this.this$0;
        MVymfCPCYBpiDrxy(baseTransientBottomBar2, glZdfmcIbArjxXRg(baseTransientBottomBar2));
        ((android.view.objectGroup$MarginLayoutParams) viewGroup$LayoutParamsGruHTEShCCIZEBBy).bottomMargin += UZTJVxftlGqpTVXJ(this.this$0) - iSbcgGpXbmtEpDwIU;
        xPxfcwtQUVsDWXQX(this.this$0.view);
    }
}

