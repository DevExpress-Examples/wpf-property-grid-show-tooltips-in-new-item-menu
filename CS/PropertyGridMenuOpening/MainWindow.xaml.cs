using DevExpress.Xpf.Core;
using DevExpress.Xpf.PropertyGrid;

namespace PropertyGridMenuOpening {
    public partial class MainWindow : ThemedWindow {
        public MainWindow() {
            InitializeComponent();
            propertyGrid.SelectedObject = new IssueView {
                ProductName = "PropertyGridControl",
                Issues = new IssueList {
                    new Bug { Header = "Rendering problem", Assignee = "Jack Plank", Owner = "Adam Smith", Severity = Severity.Severe },
                    new Question { Header = "Rendering problem", Assignee = "Elsa Lynch", Owner = "Adam Smith" },
                    new BreakingChange { Header = "Layout update", ChangeType = ChangeType.BehaviorChange, Owner = "Adam Smith" }
                }
            };
        }
        private void OnMenuOpening(object sender, PropertyGridMenuEventArgs e) {
            if (e.MenuType == PropertyGridMenuType.NewItem && e.Row.Path == "Issues") {
                e.Items[0].ToolTip = "Create a new breaking change.";
                e.Items[1].ToolTip = "Report a new bug.";
                e.Items[2].ToolTip = "Ask a new question.";
            }
        }
    }
}
