using FrostLeaf_ToolBox.Pages;
using Microsoft.UI.Xaml.Controls;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace FrostLeaf_ToolBox
    .Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class TagManagerPage : Page, IFrostPage
    {
        public TagManagerPage()
        {
            this.InitializeComponent();
        }

        public void Flush()
        {

        }
    }
}
