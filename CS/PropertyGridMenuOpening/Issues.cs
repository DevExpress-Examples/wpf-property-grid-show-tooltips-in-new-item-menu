using DevExpress.Mvvm.DataAnnotations;
using System.Collections.Generic;

namespace PropertyGridMenuOpening {
    public class IssueView {
        public string ProductName { get; set; }
        [NewItemInstanceInitializer(typeof(Bug))]
        [NewItemInstanceInitializer(typeof(Question))]
        [NewItemInstanceInitializer(typeof(BreakingChange))]
        public IssueList Issues { get; internal set; }
    }
    public class IssueList : List<Issue> {
        public override string ToString() {
            return "Issues";
        }
    }
    public abstract class Issue {
        public string Header { get; set; }
        public string Owner { get; set; }

    }
    public enum Severity {
        Minor,
        Moderate,
        Severe
    }
    public class Bug : Issue {
        public Severity Severity { get; set; }
        public string Assignee { get; set; }
    }
    public class Question : Issue {
        public string Assignee { get; set; }
    }
    public enum ChangeType {
        APIChange,
        UIChange,
        BehaviorChange
    }
    public class BreakingChange : Issue {
        public ChangeType ChangeType { get; set; }
    }
}
