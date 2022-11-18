Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.PropertyGrid

Namespace PropertyGridMenuOpening

    Public Partial Class MainWindow
        Inherits ThemedWindow

        Public Sub New()
            Me.InitializeComponent()
            Me.propertyGrid.SelectedObject = New IssueView With {.ProductName = "PropertyGridControl", .Issues = New IssueList From {New Bug With {.Header = "Rendering problem", .Assignee = "Jack Plank", .Owner = "Adam Smith", .Severity = Severity.Severe}, New Question With {.Header = "Rendering problem", .Assignee = "Elsa Lynch", .Owner = "Adam Smith"}, New BreakingChange With {.Header = "Layout update", .ChangeType = ChangeType.BehaviorChange, .Owner = "Adam Smith"}}}
        End Sub

        Private Sub OnMenuOpening(ByVal sender As Object, ByVal e As PropertyGridMenuEventArgs)
            If e.MenuType = PropertyGridMenuType.NewItem AndAlso Equals(e.Row.Path, "Issues") Then
                e.Items(0).ToolTip = "Create a new breaking change."
                e.Items(1).ToolTip = "Report a new bug."
                e.Items(2).ToolTip = "Ask a new question."
            End If
        End Sub
    End Class
End Namespace
