'use strict';
ProjectTracker.filter('Priority', function () {
    return function (priority) {
        switch (priority) {
            case "L": return "Low";
            case "M": return "Medium";
            case "H": return "High";
        }
    }
}
);
ProjectTracker.filter('Status', function () {
    return function (priority) {
        switch (priority) {
            case "I": return "In Progress";
            case "C": return "Complete";
            case "X": return "Cancelled";
            case "N": return "New";
        }
    }
}
);