namespace WillowMaze.Wasm.Decompiled;


class objectTabHost$DummyTabFactory : android.widget.TabHost$TabContentFactory {
    private readonly android.content.object mobject;

    public objectTabHost$DummyTabFactory(android.content.object context) {
        this.mobject = context;
    }

    public override android.view.object CreateTabContent(java.lang.string str) {
        android.view.object view = new android.view.object(this.mobject);
        view.setMinimumWidth(0);
        view.setMinimumHeight(0);
        return view;
    }
}

