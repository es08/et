function WorkFlowViewModel() {
    var self = this;
    self.workflows = ko.observableArray([]);
    self.workflow = ko.observable();
    self.DataTables = null;

    self.GetworkFlows = () => {
        $.get('/api/workflowApi', function (data) {
            data ? self.workflows(data) : self.workflows([]);
            self.DataTables = DataTableInit("dataTables", 7, "workFlow");
        });
    }

    self.ToggleDelete = (data) => {
        self.workflow(data);
        self.ToggleModal();
    }

    self.ToggleModal = (isDelete = true) => {
        isDelete ? $('#deleteModal').modal('toggle') : $('#addOrEditModal').modal('toggle');
    }

    self.AddNew = (data) => {
        self.workflow({});
        self.ToggleModal(false);
    }

    self.Edit = (data) => {
        self.workflow(data);
        self.ToggleModal(false);
    }

    self.AddOrEdit = () => {
        let form = $("#workFlowForm");
        validateKnockoutForm(form);
        if (form.valid()) {
            let url = `/api/workflowApi/${self.workflow().id || ''}`;
            let verbType = self.workflow().id ? `PUT` : `POST`;
            let formWithCheckbox = form.serializeObject();
            formWithCheckbox.Status = $("input[type='checkbox']:checked").val();
            $.ajax({
                url: url,
                type: verbType,
                contentType: "application/json; charset=utf-8",
                data: JSON.stringify(formWithCheckbox),
                success: function (result) {
                    self.GetworkFlows();
                    self.ToggleModal(false);
                    self.DataTables.clear();
                    self.DataTables.destroy();
                }
            });
        }
    }

    self.Delete = () => {
        $.ajax({
            url: `/api/workflowApi/${self.workflow().id}`,
            type: 'DELETE',
            success: function (result) {
                self.GetworkFlows();
                self.ToggleModal();
                self.DataTables.clear();
                self.DataTables.destroy();
            }
        });
    }

    self.GetworkFlows();
}

ko.applyBindings(new WorkFlowViewModel(), document.getElementById('workflowContainer'));
