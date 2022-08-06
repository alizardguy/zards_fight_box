using Sandbox;
using Sandbox.UI;

public partial class MyHUD : HudEntity<RootPanel>
{
    public MyHUD()
    {
        if ( !IsClient ) return;
        
        RootPanel.StyleSheet.Load( "/ui/MyHUD.scss" );

        RootPanel.AddChild<Health>();
        
    }  
}