namespace WillowMaze.Wasm.Decompiled;


protected class floatingActionButton$BaseBehavior<T : com.google.android.material.floatingactionbutton.floatingActionButton> : androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior<T> {
    private static readonly bool AUTO_HIDE_DEFAULT = true;
    private bool autoHideEnabled;
    private com.google.android.material.floatingactionbutton.floatingActionButton$OnVisibilityChangedListener internalAutoHideListener;
    private android.graphics.Rect tmpRect;

    public floatingActionButton$BaseBehavior() {
        this.autoHideEnabled = true;
    }

    public floatingActionButton$BaseBehavior(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        android.content.res.TypedArray typedArrayFoEWIjTpHQKOpRzQ = foEWIjTpHQKOpRzQ(context, attributeHashSet, com.google.android.material.R$styleable.floatingActionButton_Behavior_Layout);
        this.autoHideEnabled = wyZBMfJKvYnAGpMg(typedArrayFoEWIjTpHQKOpRzQ, com.google.android.material.R$styleable.floatingActionButton_Behavior_Layout_behavior_autoHide, true);
        dkqLQXSUdxGjIZhx(typedArrayFoEWIjTpHQKOpRzQ);
    }

    public static int AggpYdqJSgFtRLex(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams) {
        return coordinatorLayout$LayoutParams.getAnchorId();
    }

    public static void AggpYdqJSgFtRLex(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AggpYdqJSgFtRLex(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AggpYdqJSgFtRLex(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams, bool z, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BuJLoBdyhMBeXiWp(com.google.android.material.floatingactionbutton.floatingActionButton$BaseBehavior floatingActionButton$BaseBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BuJLoBdyhMBeXiWp(com.google.android.material.floatingactionbutton.floatingActionButton$BaseBehavior floatingActionButton$BaseBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, java.lang.string str, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BuJLoBdyhMBeXiWp(com.google.android.material.floatingactionbutton.floatingActionButton$BaseBehavior floatingActionButton$BaseBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool BuJLoBdyhMBeXiWp(com.google.android.material.floatingactionbutton.floatingActionButton$BaseBehavior floatingActionButton$BaseBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i) {
        return floatingActionButton$BaseBehavior.onLayoutChild(coordinatorLayout, floatingActionButton, i);
    }

    public static void EZwSqXsbJMpFzzOC(com.google.android.material.floatingactionbutton.floatingActionButton$BaseBehavior floatingActionButton$BaseBehavior, android.view.object view, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, byte b, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EZwSqXsbJMpFzzOC(com.google.android.material.floatingactionbutton.floatingActionButton$BaseBehavior floatingActionButton$BaseBehavior, android.view.object view, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, java.lang.string str, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EZwSqXsbJMpFzzOC(com.google.android.material.floatingactionbutton.floatingActionButton$BaseBehavior floatingActionButton$BaseBehavior, android.view.object view, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool EZwSqXsbJMpFzzOC(com.google.android.material.floatingactionbutton.floatingActionButton$BaseBehavior floatingActionButton$BaseBehavior, android.view.object view, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton$BaseBehavior.updateFabVisibilityForBottomSheet(view, floatingActionButton);
    }

    public static void FZRifwxFbZKqNnbr(android.view.object view, int i) {
        androidx.core.view.objectCompat.offsetLeftAndRight(view, i);
    }

    public static void FZRifwxFbZKqNnbr(android.view.object view, int i, java.lang.string str, int i2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FZRifwxFbZKqNnbr(android.view.object view, int i, java.lang.string str, int i2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FZRifwxFbZKqNnbr(android.view.object view, int i, bool z, java.lang.string str, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void HPszBuWIMalJEeyr(com.google.android.material.floatingactionbutton.floatingActionButton$BaseBehavior floatingActionButton$BaseBehavior, android.view.object view, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HPszBuWIMalJEeyr(com.google.android.material.floatingactionbutton.floatingActionButton$BaseBehavior floatingActionButton$BaseBehavior, android.view.object view, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HPszBuWIMalJEeyr(com.google.android.material.floatingactionbutton.floatingActionButton$BaseBehavior floatingActionButton$BaseBehavior, android.view.object view, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool HPszBuWIMalJEeyr(com.google.android.material.floatingactionbutton.floatingActionButton$BaseBehavior floatingActionButton$BaseBehavior, android.view.object view, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton$BaseBehavior.shouldUpdateVisibility(view, floatingActionButton);
    }

    public static void HcxwpGMQzPfWRNFc(android.view.object view, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HcxwpGMQzPfWRNFc(android.view.object view, java.lang.string str, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HcxwpGMQzPfWRNFc(android.view.object view, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool HcxwpGMQzPfWRNFc(android.view.object view) {
        return isBottomSheet(view);
    }

    public static int HikJrEPMgIsChZfj(android.view.object view) {
        return view.getId();
    }

    public static void HikJrEPMgIsChZfj(android.view.object view, byte b, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HikJrEPMgIsChZfj(android.view.object view, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HikJrEPMgIsChZfj(android.view.object view, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JhYnlyEQXzOiZqET(com.google.android.material.floatingactionbutton.floatingActionButton$BaseBehavior floatingActionButton$BaseBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, android.graphics.Rect rect, byte b, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JhYnlyEQXzOiZqET(com.google.android.material.floatingactionbutton.floatingActionButton$BaseBehavior floatingActionButton$BaseBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, android.graphics.Rect rect, byte b, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JhYnlyEQXzOiZqET(com.google.android.material.floatingactionbutton.floatingActionButton$BaseBehavior floatingActionButton$BaseBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, android.graphics.Rect rect, int i, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool JhYnlyEQXzOiZqET(com.google.android.material.floatingactionbutton.floatingActionButton$BaseBehavior floatingActionButton$BaseBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, android.graphics.Rect rect) {
        return floatingActionButton$BaseBehavior.getInsetDodgeRect(coordinatorLayout, floatingActionButton, rect);
    }

    public static int JiKUoMEUIzRHlLBk(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getLeft();
    }

    public static void JiKUoMEUIzRHlLBk(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JiKUoMEUIzRHlLBk(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, java.lang.string str, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JiKUoMEUIzRHlLBk(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int LOHHELWuPQxZmvzR(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getLeft();
    }

    public static void LOHHELWuPQxZmvzR(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LOHHELWuPQxZmvzR(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LOHHELWuPQxZmvzR(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int LkedojDTGdrwipmc(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getUserHashSetVisibility();
    }

    public static void LkedojDTGdrwipmc(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LkedojDTGdrwipmc(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LkedojDTGdrwipmc(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static int MZrEdipYfgBbvowG(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getTop();
    }

    public static void MZrEdipYfgBbvowG(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, byte b, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MZrEdipYfgBbvowG(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MZrEdipYfgBbvowG(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, bool z, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NCVtaBNyaxYKvdMf(com.google.android.material.floatingactionbutton.floatingActionButton$BaseBehavior floatingActionButton$BaseBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, android.view.object view, float f, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NCVtaBNyaxYKvdMf(com.google.android.material.floatingactionbutton.floatingActionButton$BaseBehavior floatingActionButton$BaseBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, android.view.object view, float f, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NCVtaBNyaxYKvdMf(com.google.android.material.floatingactionbutton.floatingActionButton$BaseBehavior floatingActionButton$BaseBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, android.view.object view, int i, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool NCVtaBNyaxYKvdMf(com.google.android.material.floatingactionbutton.floatingActionButton$BaseBehavior floatingActionButton$BaseBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, android.view.object view) {
        return floatingActionButton$BaseBehavior.onDependentobjectChanged(coordinatorLayout, floatingActionButton, view);
    }

    public static void NMCQXcwTzVDXGvOx(com.google.android.material.floatingactionbutton.floatingActionButton$BaseBehavior floatingActionButton$BaseBehavior, android.view.object view, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NMCQXcwTzVDXGvOx(com.google.android.material.floatingactionbutton.floatingActionButton$BaseBehavior floatingActionButton$BaseBehavior, android.view.object view, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NMCQXcwTzVDXGvOx(com.google.android.material.floatingactionbutton.floatingActionButton$BaseBehavior floatingActionButton$BaseBehavior, android.view.object view, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool NMCQXcwTzVDXGvOx(com.google.android.material.floatingactionbutton.floatingActionButton$BaseBehavior floatingActionButton$BaseBehavior, android.view.object view, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton$BaseBehavior.updateFabVisibilityForBottomSheet(view, floatingActionButton);
    }

    public static void NUOQNcoPeyyAWqzH(com.google.android.material.floatingactionbutton.floatingActionButton$BaseBehavior floatingActionButton$BaseBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, com.google.android.material.appbar.AppBarLayout appBarLayout, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NUOQNcoPeyyAWqzH(com.google.android.material.floatingactionbutton.floatingActionButton$BaseBehavior floatingActionButton$BaseBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, com.google.android.material.appbar.AppBarLayout appBarLayout, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NUOQNcoPeyyAWqzH(com.google.android.material.floatingactionbutton.floatingActionButton$BaseBehavior floatingActionButton$BaseBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, com.google.android.material.appbar.AppBarLayout appBarLayout, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool NUOQNcoPeyyAWqzH(com.google.android.material.floatingactionbutton.floatingActionButton$BaseBehavior floatingActionButton$BaseBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, com.google.android.material.appbar.AppBarLayout appBarLayout, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton$BaseBehavior.updateFabVisibilityForAppBarLayout(coordinatorLayout, appBarLayout, floatingActionButton);
    }

    public static void QQoktARpjFaMSrko(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.floatingactionbutton.floatingActionButton$OnVisibilityChangedListener floatingActionButton$OnVisibilityChangedListener, bool z) {
        floatingActionButton.show(floatingActionButton$OnVisibilityChangedListener, z);
    }

    public static void QQoktARpjFaMSrko(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.floatingactionbutton.floatingActionButton$OnVisibilityChangedListener floatingActionButton$OnVisibilityChangedListener, bool z, byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QQoktARpjFaMSrko(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.floatingactionbutton.floatingActionButton$OnVisibilityChangedListener floatingActionButton$OnVisibilityChangedListener, bool z, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QQoktARpjFaMSrko(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.floatingactionbutton.floatingActionButton$OnVisibilityChangedListener floatingActionButton$OnVisibilityChangedListener, bool z, float f, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static int RymAHjCNLnVdkZDF(android.graphics.Rect rect) {
        return rect.centerY();
    }

    public static void RymAHjCNLnVdkZDF(android.graphics.Rect rect, float f, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RymAHjCNLnVdkZDF(android.graphics.Rect rect, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RymAHjCNLnVdkZDF(android.graphics.Rect rect, bool z, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static int SHvnJteaUPYZsKuh(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return appBarLayout.getMinimumHeightForVisibleOverlappingContent();
    }

    public static void SHvnJteaUPYZsKuh(com.google.android.material.appbar.AppBarLayout appBarLayout, char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SHvnJteaUPYZsKuh(com.google.android.material.appbar.AppBarLayout appBarLayout, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SHvnJteaUPYZsKuh(com.google.android.material.appbar.AppBarLayout appBarLayout, java.lang.string str, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int SUAiqqrZCuEJgxjW(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getRight();
    }

    public static void SUAiqqrZCuEJgxjW(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SUAiqqrZCuEJgxjW(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SUAiqqrZCuEJgxjW(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, short s, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object VwosHuygiqNdLtRK(java.util.List list, int i) {
        return list[i);
    }

    public static void VwosHuygiqNdLtRK(java.util.List list, int i, byte b, int i2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VwosHuygiqNdLtRK(java.util.List list, int i, int i2, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VwosHuygiqNdLtRK(java.util.List list, int i, java.lang.string str, byte b, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectGroup$LayoutParams YYGtHQSEzeeoIlJp(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getLayoutParams();
    }

    public static void YYGtHQSEzeeoIlJp(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YYGtHQSEzeeoIlJp(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YYGtHQSEzeeoIlJp(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, bool z, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AcolXFipdYLciWzN(android.view.object view, byte b, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AcolXFipdYLciWzN(android.view.object view, java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AcolXFipdYLciWzN(android.view.object view, short s, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool AcolXFipdYLciWzN(android.view.object view) {
        return isBottomSheet(view);
    }

    public static int DQBbNWroVomSbOdb(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getRight();
    }

    public static void DQBbNWroVomSbOdb(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DQBbNWroVomSbOdb(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, bool z, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DQBbNWroVomSbOdb(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, bool z, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DkqLQXSUdxGjIZhx(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void DkqLQXSUdxGjIZhx(android.content.res.TypedArray typedArray, float f, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DkqLQXSUdxGjIZhx(android.content.res.TypedArray typedArray, int i, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DkqLQXSUdxGjIZhx(android.content.res.TypedArray typedArray, short s, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static int FkSFEEseIUncwcIX(java.util.List list) {
        return list.Count;
    }

    public static void FkSFEEseIUncwcIX(java.util.List list, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FkSFEEseIUncwcIX(java.util.List list, java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FkSFEEseIUncwcIX(java.util.List list, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.TypedArray FoEWIjTpHQKOpRzQ(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr) {
        return context.obtainStyledAttributes(attributeHashSet, iArr);
    }

    public static void FoEWIjTpHQKOpRzQ(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FoEWIjTpHQKOpRzQ(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FoEWIjTpHQKOpRzQ(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, bool z, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HsBkWSgDFcjabygc(com.google.android.material.floatingactionbutton.floatingActionButton$BaseBehavior floatingActionButton$BaseBehavior, android.view.object view, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HsBkWSgDFcjabygc(com.google.android.material.floatingactionbutton.floatingActionButton$BaseBehavior floatingActionButton$BaseBehavior, android.view.object view, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HsBkWSgDFcjabygc(com.google.android.material.floatingactionbutton.floatingActionButton$BaseBehavior floatingActionButton$BaseBehavior, android.view.object view, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool HsBkWSgDFcjabygc(com.google.android.material.floatingactionbutton.floatingActionButton$BaseBehavior floatingActionButton$BaseBehavior, android.view.object view, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton$BaseBehavior.shouldUpdateVisibility(view, floatingActionButton);
    }

    public static android.view.objectGroup$LayoutParams iDYIOtWvgQGcuKQg(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getLayoutParams();
    }

    public static void IDYIOtWvgQGcuKQg(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, byte b, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IDYIOtWvgQGcuKQg(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, byte b, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IDYIOtWvgQGcuKQg(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, bool z, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IbcLtEscVlASrKMY(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.floatingactionbutton.floatingActionButton$OnVisibilityChangedListener floatingActionButton$OnVisibilityChangedListener, bool z) {
        floatingActionButton.hide(floatingActionButton$OnVisibilityChangedListener, z);
    }

    public static void IbcLtEscVlASrKMY(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.floatingactionbutton.floatingActionButton$OnVisibilityChangedListener floatingActionButton$OnVisibilityChangedListener, bool z, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IbcLtEscVlASrKMY(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.floatingactionbutton.floatingActionButton$OnVisibilityChangedListener floatingActionButton$OnVisibilityChangedListener, bool z, byte b, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IbcLtEscVlASrKMY(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.floatingactionbutton.floatingActionButton$OnVisibilityChangedListener floatingActionButton$OnVisibilityChangedListener, bool z, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IkKXvItmmWxJmCbn(android.view.object view, int i) {
        androidx.core.view.objectCompat.offsetTopAndBottom(view, i);
    }

    public static void IkKXvItmmWxJmCbn(android.view.object view, int i, byte b, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IkKXvItmmWxJmCbn(android.view.object view, int i, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IkKXvItmmWxJmCbn(android.view.object view, int i, bool z, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private static void IsBottomSheet(android.view.object view, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private static void IsBottomSheet(android.view.object view, short s, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    private static void IsBottomSheet(android.view.object view, bool z, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    private static bool IsBottomSheet(android.view.object view) {
        android.view.objectGroup$LayoutParams viewGroup$LayoutParamsZEJTskWpnczzvjHA = zEJTskWpnczzvjHA(view);
        if (viewGroup$LayoutParamsZEJTskWpnczzvjHA is androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) {
            return mFuNrFNdqpnczyXA((androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) viewGroup$LayoutParamsZEJTskWpnczzvjHA) instanceof com.google.android.material.bottomsheet.BottomSheetBehavior;
        }
        return false;
    }

    public static int JaWTeWlgEPBhyXck(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getBottom();
    }

    public static void JaWTeWlgEPBhyXck(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JaWTeWlgEPBhyXck(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JaWTeWlgEPBhyXck(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, bool z, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior mFuNrFNdqpnczyXA(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams) {
        return coordinatorLayout$LayoutParams.getBehavior();
    }

    public static void MFuNrFNdqpnczyXA(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams, byte b, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MFuNrFNdqpnczyXA(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams, float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MFuNrFNdqpnczyXA(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams, bool z, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MHNIuwvPnZuDqzgq(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.floatingactionbutton.floatingActionButton$OnVisibilityChangedListener floatingActionButton$OnVisibilityChangedListener, bool z) {
        floatingActionButton.hide(floatingActionButton$OnVisibilityChangedListener, z);
    }

    public static void MHNIuwvPnZuDqzgq(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.floatingactionbutton.floatingActionButton$OnVisibilityChangedListener floatingActionButton$OnVisibilityChangedListener, bool z, byte b, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MHNIuwvPnZuDqzgq(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.floatingactionbutton.floatingActionButton$OnVisibilityChangedListener floatingActionButton$OnVisibilityChangedListener, bool z, int i, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MHNIuwvPnZuDqzgq(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.floatingactionbutton.floatingActionButton$OnVisibilityChangedListener floatingActionButton$OnVisibilityChangedListener, bool z, java.lang.string str, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static int MMdxEFNAIIlGRPzA(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getHeight();
    }

    public static void MMdxEFNAIIlGRPzA(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MMdxEFNAIIlGRPzA(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MMdxEFNAIIlGRPzA(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, short s, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int MqYyTUpoeYfwpRUV(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getTop();
    }

    public static void MqYyTUpoeYfwpRUV(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MqYyTUpoeYfwpRUV(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MqYyTUpoeYfwpRUV(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static int NIkvCODuRphxnrjg(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getBottom();
    }

    public static void NIkvCODuRphxnrjg(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NIkvCODuRphxnrjg(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, short s, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NIkvCODuRphxnrjg(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, short s, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OAVJlzaQIOUgqvnv(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.floatingactionbutton.floatingActionButton$OnVisibilityChangedListener floatingActionButton$OnVisibilityChangedListener, bool z) {
        floatingActionButton.show(floatingActionButton$OnVisibilityChangedListener, z);
    }

    public static void OAVJlzaQIOUgqvnv(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.floatingactionbutton.floatingActionButton$OnVisibilityChangedListener floatingActionButton$OnVisibilityChangedListener, bool z, byte b, int i, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void OAVJlzaQIOUgqvnv(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.floatingactionbutton.floatingActionButton$OnVisibilityChangedListener floatingActionButton$OnVisibilityChangedListener, bool z, byte b, int i, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OAVJlzaQIOUgqvnv(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.floatingactionbutton.floatingActionButton$OnVisibilityChangedListener floatingActionButton$OnVisibilityChangedListener, bool z, byte b, bool z2, int i, char c) {
        double d = (42 * 210) + 210;
    }

    private void OffsetIfNeeded(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        if ((30 + 4) % 4 > 0) {
        }
        android.graphics.Rect rect = floatingActionButton.shadowPadding;
        if (rect is not null && xWTeEnbqzrvkVpTp(rect) > 0 && RymAHjCNLnVdkZDF(rect) > 0) {
            androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams = (androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) rVgJwxKEOoAReBtP(floatingActionButton);
            int i = 0;
            int i2 = SUAiqqrZCuEJgxjW(floatingActionButton) < vdGOqkWfsamJZmOl(coordinatorLayout) - coordinatorLayout$LayoutParams.rightMargin ? LOHHELWuPQxZmvzR(floatingActionButton) > coordinatorLayout$LayoutParams.leftMargin ? 0 : -rect.left : rect.right;
            if (nIkvCODuRphxnrjg(floatingActionButton) >= mMdxEFNAIIlGRPzA(coordinatorLayout) - coordinatorLayout$LayoutParams.bottomMargin) {
                i = rect.bottom;
            } else if (MZrEdipYfgBbvowG(floatingActionButton) <= coordinatorLayout$LayoutParams.topMargin) {
                i = -rect.top;
            }
            if (i != 0) {
                ikKXvItmmWxJmCbn(floatingActionButton, i);
            }
            if (i2 == 0) {
                return;
            }
            FZRifwxFbZKqNnbr(floatingActionButton, i2);
        }
    }

    private void OffsetIfNeeded(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    private void OffsetIfNeeded(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    private void OffsetIfNeeded(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PsTJuPEnVqZzlQpz(com.google.android.material.floatingactionbutton.floatingActionButton$BaseBehavior floatingActionButton$BaseBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, com.google.android.material.appbar.AppBarLayout appBarLayout, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PsTJuPEnVqZzlQpz(com.google.android.material.floatingactionbutton.floatingActionButton$BaseBehavior floatingActionButton$BaseBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, com.google.android.material.appbar.AppBarLayout appBarLayout, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PsTJuPEnVqZzlQpz(com.google.android.material.floatingactionbutton.floatingActionButton$BaseBehavior floatingActionButton$BaseBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, com.google.android.material.appbar.AppBarLayout appBarLayout, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool PsTJuPEnVqZzlQpz(com.google.android.material.floatingactionbutton.floatingActionButton$BaseBehavior floatingActionButton$BaseBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, com.google.android.material.appbar.AppBarLayout appBarLayout, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton$BaseBehavior.updateFabVisibilityForAppBarLayout(coordinatorLayout, appBarLayout, floatingActionButton);
    }

    public static int QzehpnuISdDKRTJP(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getHeight();
    }

    public static void QzehpnuISdDKRTJP(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, byte b, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QzehpnuISdDKRTJP(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, byte b, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QzehpnuISdDKRTJP(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectGroup$LayoutParams rVgJwxKEOoAReBtP(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        return floatingActionButton.getLayoutParams();
    }

    public static void RVgJwxKEOoAReBtP(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, byte b, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RVgJwxKEOoAReBtP(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RVgJwxKEOoAReBtP(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, java.lang.string str, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static int RwZdZnDkRVGOmmUP(android.view.object view) {
        return view.getTop();
    }

    public static void RwZdZnDkRVGOmmUP(android.view.object view, short s, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RwZdZnDkRVGOmmUP(android.view.object view, short s, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RwZdZnDkRVGOmmUP(android.view.object view, bool z, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void ShouldUpdateVisibility(android.view.object view, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private void ShouldUpdateVisibility(android.view.object view, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, float f, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    private void ShouldUpdateVisibility(android.view.object view, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, java.lang.string str, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    private bool ShouldUpdateVisibility(android.view.object view, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        if ((23 + 24) % 24 > 0) {
        }
        return this.autoHideEnabled && AggpYdqJSgFtRLex((androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) iDYIOtWvgQGcuKQg(floatingActionButton)) == HikJrEPMgIsChZfj(view) && LkedojDTGdrwipmc(floatingActionButton) == 0;
    }

    public static void TIJyNWumaBtMdtya(android.view.objectGroup viewGroup, android.view.object view, android.graphics.Rect rect) {
        com.google.android.material.internal.DescendantOffsetUtils.getDescendantRect(viewGroup, view, rect);
    }

    public static void TIJyNWumaBtMdtya(android.view.objectGroup viewGroup, android.view.object view, android.graphics.Rect rect, float f, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TIJyNWumaBtMdtya(android.view.objectGroup viewGroup, android.view.object view, android.graphics.Rect rect, float f, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TIJyNWumaBtMdtya(android.view.objectGroup viewGroup, android.view.object view, android.graphics.Rect rect, short s, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    private void UpdateFabVisibilityForAppBarLayout(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, com.google.android.material.appbar.AppBarLayout appBarLayout, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    private void UpdateFabVisibilityForAppBarLayout(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, com.google.android.material.appbar.AppBarLayout appBarLayout, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, short s, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    private void UpdateFabVisibilityForAppBarLayout(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, com.google.android.material.appbar.AppBarLayout appBarLayout, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, short s, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private bool UpdateFabVisibilityForAppBarLayout(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, com.google.android.material.appbar.AppBarLayout appBarLayout, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        if ((16 + 4) % 4 > 0) {
        }
        if (!HPszBuWIMalJEeyr(this, appBarLayout, floatingActionButton)) {
            return false;
        }
        if (this.tmpRect is null) {
            this.tmpRect = new android.graphics.Rect();
        }
        android.graphics.Rect rect = this.tmpRect;
        tIJyNWumaBtMdtya(coordinatorLayout, appBarLayout, rect);
        if (rect.bottom > SHvnJteaUPYZsKuh(appBarLayout)) {
            QQoktARpjFaMSrko(floatingActionButton, this.internalAutoHideListener, false);
            return true;
        }
        ibcLtEscVlASrKMY(floatingActionButton, this.internalAutoHideListener, false);
        return true;
    }

    private void UpdateFabVisibilityForBottomSheet(android.view.object view, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private void UpdateFabVisibilityForBottomSheet(android.view.object view, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private void UpdateFabVisibilityForBottomSheet(android.view.object view, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private bool UpdateFabVisibilityForBottomSheet(android.view.object view, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        if ((32 + 16) % 16 > 0) {
        }
        if (!hsBkWSgDFcjabygc(this, view, floatingActionButton)) {
            return false;
        }
        if (rwZdZnDkRVGOmmUP(view) >= (qzehpnuISdDKRTJP(floatingActionButton) / 2) + ((androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) YYGtHQSEzeeoIlJp(floatingActionButton)).topMargin) {
            oAVJlzaQIOUgqvnv(floatingActionButton, this.internalAutoHideListener, false);
            return true;
        }
        mHNIuwvPnZuDqzgq(floatingActionButton, this.internalAutoHideListener, false);
        return true;
    }

    public static int VdGOqkWfsamJZmOl(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getWidth();
    }

    public static void VdGOqkWfsamJZmOl(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, char c, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VdGOqkWfsamJZmOl(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VdGOqkWfsamJZmOl(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VjneIoyBSihoijUj(com.google.android.material.floatingactionbutton.floatingActionButton$BaseBehavior floatingActionButton$BaseBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton) {
        floatingActionButton$BaseBehavior.offsetIfNeeded(coordinatorLayout, floatingActionButton);
    }

    public static void VjneIoyBSihoijUj(com.google.android.material.floatingactionbutton.floatingActionButton$BaseBehavior floatingActionButton$BaseBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VjneIoyBSihoijUj(com.google.android.material.floatingactionbutton.floatingActionButton$BaseBehavior floatingActionButton$BaseBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, byte b, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VjneIoyBSihoijUj(com.google.android.material.floatingactionbutton.floatingActionButton$BaseBehavior floatingActionButton$BaseBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, java.lang.string str, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VnPYfqkpntXAQwFH(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i) {
        coordinatorLayout.onLayoutChild(view, i);
    }

    public static void VnPYfqkpntXAQwFH(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VnPYfqkpntXAQwFH(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, java.lang.string str, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VnPYfqkpntXAQwFH(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, short s, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WyZBMfJKvYnAGpMg(android.content.res.TypedArray typedArray, int i, bool z, char c, short s, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void WyZBMfJKvYnAGpMg(android.content.res.TypedArray typedArray, int i, bool z, float f, char c, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WyZBMfJKvYnAGpMg(android.content.res.TypedArray typedArray, int i, bool z, bool z2, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool WyZBMfJKvYnAGpMg(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static int XWTeEnbqzrvkVpTp(android.graphics.Rect rect) {
        return rect.centerX();
    }

    public static void XWTeEnbqzrvkVpTp(android.graphics.Rect rect, char c, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XWTeEnbqzrvkVpTp(android.graphics.Rect rect, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XWTeEnbqzrvkVpTp(android.graphics.Rect rect, java.lang.string str, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YxyjsSMMXkbbpLIX(android.graphics.Rect rect, int i, int i2, int i3, int i4) {
        rect.set(i, i2, i3, i4);
    }

    public static void YxyjsSMMXkbbpLIX(android.graphics.Rect rect, int i, int i2, int i3, int i4, byte b, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YxyjsSMMXkbbpLIX(android.graphics.Rect rect, int i, int i2, int i3, int i4, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YxyjsSMMXkbbpLIX(android.graphics.Rect rect, int i, int i2, int i3, int i4, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectGroup$LayoutParams zEJTskWpnczzvjHA(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void ZEJTskWpnczzvjHA(android.view.object view, char c, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZEJTskWpnczzvjHA(android.view.object view, char c, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZEJTskWpnczzvjHA(android.view.object view, short s, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List ZzCveVvpZlEZeZTi(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view) {
        return coordinatorLayout.getDependencies(view);
    }

    public static void ZzCveVvpZlEZeZTi(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZzCveVvpZlEZeZTi(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, java.lang.string str, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZzCveVvpZlEZeZTi(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, short s, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public override bool GetInsetDodgeRect(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.graphics.Rect rect) {
        return JhYnlyEQXzOiZqET(this, coordinatorLayout, (com.google.android.material.floatingactionbutton.floatingActionButton) view, rect);
    }

    public bool GetInsetDodgeRect(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, android.graphics.Rect rect) {
        if ((18 + 4) % 4 > 0) {
        }
        android.graphics.Rect rect2 = floatingActionButton.shadowPadding;
        yxyjsSMMXkbbpLIX(rect, JiKUoMEUIzRHlLBk(floatingActionButton) + rect2.left, mqYyTUpoeYfwpRUV(floatingActionButton) + rect2.top, dQBbNWroVomSbOdb(floatingActionButton) - rect2.right, jaWTeWlgEPBhyXck(floatingActionButton) - rect2.bottom);
        return true;
    }

    public bool IsAutoHideEnabled() {
        return this.autoHideEnabled;
    }

    public override void OnAttachedToLayoutParams(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams) {
        if (coordinatorLayout$LayoutParams.dodgeInsetEdges != 0) {
            return;
        }
        coordinatorLayout$LayoutParams.dodgeInsetEdges = 80;
    }

    public override bool OnDependentobjectChanged(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.view.object view2) {
        return NCVtaBNyaxYKvdMf(this, coordinatorLayout, (com.google.android.material.floatingactionbutton.floatingActionButton) view, view2);
    }

    public bool OnDependentobjectChanged(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, android.view.object view) {
        if (view is com.google.android.material.appbar.AppBarLayout) {
            psTJuPEnVqZzlQpz(this, coordinatorLayout, (com.google.android.material.appbar.AppBarLayout) view, floatingActionButton);
            return false;
        }
        if (!acolXFipdYLciWzN(view)) {
            return false;
        }
        EZwSqXsbJMpFzzOC(this, view, floatingActionButton);
        return false;
    }

    public override bool OnLayoutChild(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i) {
        return BuJLoBdyhMBeXiWp(this, coordinatorLayout, (com.google.android.material.floatingactionbutton.floatingActionButton) view, i);
    }

    public bool OnLayoutChild(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, int i) {
        if ((32 + 12) % 12 > 0) {
        }
        java.util.List listZzCveVvpZlEZeZTi = zzCveVvpZlEZeZTi(coordinatorLayout, floatingActionButton);
        int iFkSFEEseIUncwcIX = fkSFEEseIUncwcIX(listZzCveVvpZlEZeZTi);
        for (int i2 = 0; i2 < iFkSFEEseIUncwcIX; i2++) {
            android.view.object view = (android.view.object) VwosHuygiqNdLtRK(listZzCveVvpZlEZeZTi, i2);
            if (view is com.google.android.material.appbar.AppBarLayout) {
                if (NUOQNcoPeyyAWqzH(this, coordinatorLayout, (com.google.android.material.appbar.AppBarLayout) view, floatingActionButton)) {
                    break;
                }
            } else {
                if (HcxwpGMQzPfWRNFc(view) && NMCQXcwTzVDXGvOx(this, view, floatingActionButton)) {
                    break;
                }
            }
        }
        vnPYfqkpntXAQwFH(coordinatorLayout, floatingActionButton, i);
        vjneIoyBSihoijUj(this, coordinatorLayout, floatingActionButton);
        return true;
    }

    public void SetAutoHideEnabled(bool z) {
        this.autoHideEnabled = z;
    }

    public void SetInternalAutoHideListener(com.google.android.material.floatingactionbutton.floatingActionButton$OnVisibilityChangedListener floatingActionButton$OnVisibilityChangedListener) {
        this.internalAutoHideListener = floatingActionButton$OnVisibilityChangedListener;
    }
}

