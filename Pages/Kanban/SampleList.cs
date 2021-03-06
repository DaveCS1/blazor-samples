﻿using System.Collections.Generic;
using blazor_samples;

namespace blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> Kanban { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Overview",
                Category = "Kanban",
                Directory = "Kanban/Kanban",
                Url = "kanban/overview",
                FileName = "Overview.razor"
            },
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Kanban",
                Directory = "Kanban/Kanban",
                Url = "kanban/default-functionalities",
                FileName = "DefaultFunctionalities.razor"
            },
            new Sample
            {
                Name = "Swimlane",
                Category = "Kanban",
                Directory = "Kanban/Kanban",
                Url = "kanban/swimlane",
                FileName = "Swimlane.razor"
            },
            new Sample
            {
                Name = "Stacked Header",
                Category = "Kanban",
                Directory = "Kanban/Kanban",
                Url = "kanban/stacked-header",
                FileName = "StackedHeader.razor"
            },
            new Sample
            {
                Name = "Dialog Editing",
                Category = "Kanban",
                Directory = "Kanban/Kanban",
                Url = "kanban/dialog-editing",
                FileName = "DialogEditing.razor"
            },
            new Sample
            {
                Name = "Local Data",
                Category = "Data Binding",
                Directory = "Kanban/Kanban",
                Url = "kanban/local-data",
                FileName = "LocalData.razor"
            },
            new Sample
            {
                Name = "Remote Data",
                Category = "Data Binding",
                Directory = "Kanban/Kanban",
                Url = "kanban/remote-data",
                FileName = "RemoteData.razor"
            },
            new Sample
            {
                Name = "Header Template",
                Category = "Templates",
                Directory = "Kanban/Kanban",
                Url = "kanban/header-template",
                FileName = "HeaderTemplate.razor"
            },
            new Sample
            {
                Name = "Swimlane Template",
                Category = "Templates",
                Directory = "Kanban/Kanban",
                Url = "kanban/swimlane-template",
                FileName = "SwimlaneTemplate.razor"
            },
            new Sample
            {
                Name = "Card Template",
                Category = "Templates",
                Directory = "Kanban/Kanban",
                Url = "kanban/card-template",
                FileName = "CardTemplate.razor"
            },
            new Sample
            {
                Name = "Toggle Columns",
                Category = "Columns",
                Directory = "Kanban/Kanban",
                Url = "kanban/toggle-columns",
                FileName = "ToggleColumns.razor"
            },
            new Sample
            {
                Name = "Show/Hide Columns",
                Category = "Columns",
                Directory = "Kanban/Kanban",
                Url = "kanban/showhide-columns",
                FileName = "ShowHideColumns.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "WIP Validation",
                Category = "Validation",
                Directory = "Kanban/Kanban",
                Url = "kanban/wip-validation",
                FileName = "WipValidation.razor",
                Type = SampleType.New
            }
        };
    }
}