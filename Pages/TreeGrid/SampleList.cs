﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blazor_samples;
namespace blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> TreeGrid { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Tree Grid",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/default-functionalities",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="DefaultFunctionalities.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="SelfData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Clipboard",
                Category = "Tree Grid",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/clipboard",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Clipboard",
                        FileName="Clipboard.razor"
                    },
                    new SourceCollection
                    {
                        Id="Clipboard",
                        FileName="SelfData.cs"
                    }
                }
            },

            new Sample
            {
                Name = "Context Menu",
                Category = "Tree Grid",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/context-menu",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ContextMenu",
                        FileName="ContextMenu.razor"
                    },
                    new SourceCollection
                    {
                        Id="ContextData",
                        FileName="TreeData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Remote Data",
                Category = "Tree Grid",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/remote-data",
                FileName = "RemoteData.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Conditional Formatting",
                Category = "Tree Grid",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/conditional-formatting",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Formatting",
                        FileName="ConditionalFormatting.razor"
                    },
                    new SourceCollection
                    {
                        Id="formatdata",
                        FileName="Selfdata.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Aggregates",
                Category = "Tree Grid",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/aggregate",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Aggregate",
                        FileName="Aggregate.razor"
                    },
                    new SourceCollection
                    {
                        Id="Aggregatedata",
                        FileName="ShipmentData.cs"
                    }
                }
            },
            new Sample
             {
                 Name = "Column Chooser",
                 Category = "Columns",
                 Directory = "TreeGrid/TreeGrid",
                 Url = "tree-grid/columnchooser",
                 Type = SampleType.New,
                 SourceFiles = new List<SourceCollection>()
                 {
                     new SourceCollection
                     {
                         Id="ColumnChooser",
                         FileName="TreeColumnChooser.razor"
                     },
                     new SourceCollection
                     {
                         Id="TreeData",
                         FileName="SelfData.cs"
                     }
                 }
             },
            new Sample
            {
                Name = "Column Template",
                Category = "Columns",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/column-template",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ColumnTemplate",
                        FileName="ColumnTemplate.razor"
                    },
                    new SourceCollection
                    {
                        Id="ColumnData",
                        FileName="TemplateData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Auto Wrap Column Cells",
                Category = "Columns",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/auto-wrap",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="AutoWrap",
                        FileName="AutoWrap.razor"
                    },
                    new SourceCollection
                    {
                        Id="WrapData",
                        FileName="WrapData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Show or Hide Column",
                Category = "Columns",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/show-or-hide",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ShowHide",
                        FileName="ShowOrHide.razor"
                    },
                    new SourceCollection
                    {
                        Id="ShowOrHideData",
                        FileName="SelfData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Header Template",
                Category = "Columns",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/header-template",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Headertemplate",
                        FileName="Headerstemplate.razor"
                    },
                    new SourceCollection
                    {
                        Id="headertemplateData",
                        FileName="TemplateData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Column Menu",
                Category = "Columns",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/column-menu",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ColumnMenu",
                        FileName="ColumnMenu.razor"
                    },
                    new SourceCollection
                    {
                        Id="MenuData",
                        FileName="SelfData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Resizing",
                Category = "Columns",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/resizing",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Resizing",
                        FileName="Resizing.razor"
                    },
                    new SourceCollection
                    {
                        Id="ResizeData",
                        FileName="SelfData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Reorder",
                Category = "Columns",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/reorder",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Reorder",
                        FileName="Reorder.razor"
                    },
                    new SourceCollection
                    {
                        Id="ReorderData",
                        FileName="SelfData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Frozen Column",
                Category = "Columns",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/frozen-column",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="FrozenColumn",
                        FileName="FrozenColumn.razor"
                    },
                    new SourceCollection
                    {
                        Id="FrozenData",
                        FileName="SelfData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Row Hover",
                Category = "Rows",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/row-hover",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="RowHover",
                        FileName="RowHover.razor"
                    },
                    new SourceCollection
                    {
                        Id="HoverData",
                        FileName="SelfData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Row Height",
                Category = "Rows",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/row-height",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="RowHeight",
                        FileName="RowHeight.razor"
                    },
                    new SourceCollection
                    {
                        Id="RowHeightData",
                        FileName="SelfData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Row Template",
                Category = "Rows",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/tree-grid-row-template",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="RowTemplate",
                        FileName="TreeGridRowTemplate.razor"
                    },
                    new SourceCollection
                    {
                        Id="RowData",
                        FileName="TemplateData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Detail Template",
                Category = "Rows",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/tree-grid-detail-template",
                FileName = "TreeGridDetailTemplate.razor",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="DetailTemplate",
                        FileName="TreeGridDetailTemplate.razor"
                    },
                    new SourceCollection
                    {
                        Id="TemplateData",
                        FileName="TemplateData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Inline Editing",
                Category = "Editing",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/inline-editing",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="InlineEditing",
                        FileName="InlineEditing.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="SelfData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Dialog Editing",
                Category = "Editing",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/dialog-editing",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="DialogEditing",
                        FileName="DialogEditing.razor"
                    },
                    new SourceCollection
                    {
                        Id="DialogData",
                        FileName="SelfData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Batch Editing",
                Category = "Editing",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/batch-editing",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="BatchEditing",
                        FileName="BatchEditing.razor"
                    },
                    new SourceCollection
                    {
                        Id="BatchData",
                        FileName="SelfData.cs"
                    }
                }
            },
             new Sample
            {
                Name = "Cell Edit Type",
                Category = "Editing",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/cell-edit-type",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="CellEditType",
                        FileName="CellEditType.razor"
                    },
                    new SourceCollection
                    {
                        Id="CellEditTypeData",
                        FileName="SelfData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Command Column",
                Category = "Editing",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/command-column",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="CommandColumn",
                        FileName="CommandColumn.razor"
                    },
                    new SourceCollection
                    {
                        Id="CommandData",
                        FileName="SelfData.cs"
                    }
                }
            },
             new Sample
            {
                Name = "Edit Template",
                Category = "Editing",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/cell-edit-template",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                   {
                        Id="CellEditTemplate",
                        FileName="CellEditTemplate.razor"
                    },
                    new SourceCollection
                    {
                        Id="EditTemplateData",
                        FileName="SelfData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Multi Sorting",
                Category = "Tree Grid",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/sorting",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Sorting",
                        FileName="Sorting.razor"
                    },
                    new SourceCollection
                    {
                        Id="SortData",
                        FileName="ShipmentData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Default Filtering",
                Category = "Filtering",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/default-filtering",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Filtering",
                        FileName="DefaultFiltering.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="TreeData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Filterbar Template",
                Category = "Filtering",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/filter-bar-template",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Filtering",
                        FileName="FilterBarTemplate.razor"
                    },
                    new SourceCollection
                    {
                        Id="FilterBarTemplateData",
                        FileName="TreeData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Menu Filter",
                Category = "Filtering",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/menu-filter",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="MenuFilter",
                        FileName="MenuFilter.razor"
                    },
                    new SourceCollection
                    {
                        Id="FilterData",
                        FileName="TreeData.cs"
                    }
                },
            },
            new Sample
            {
                Name = "Search",
                Category = "Filtering",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/search",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Search",
                        FileName="Search.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="TreeData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Default Selection",
                Category = "Selection",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/selection",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Selection",
                        FileName="Selection.razor"
                    },
                    new SourceCollection
                    {
                        Id="SelectionData",
                        FileName="SelfData.cs"
                    }
                }
            },
           new Sample
            {
                Name = "Selection API",
                Category = "Selection",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/selection-api",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="SelectionAPI",
                        FileName="SelectionAPI.razor"
                    },
                    new SourceCollection
                    {
                        Id="SelectionAPIData",
                        FileName="SelfData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Paging",
                Category = "Tree Grid",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/paging",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Paging",
                        FileName="Paging.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="SelfData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Checkbox Selection",
                Category = "Selection",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/checkbox-selection",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="CheckBoxSelection",
                        FileName="CheckboxSelection.razor"
                    },
                    new SourceCollection
                    {
                        Id="CheckBoxData",
                        FileName="SelfData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Default Exporting",
                Category = "Exporting",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/exporting",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="DefaultExporting",
                        FileName="Exporting.razor"
                    },
                    new SourceCollection
                    {
                        Id="DefaultExportingData",
                        FileName="SelfData.cs"
                    }
                }
            },
           new Sample
            {
               Name = "Print",
               Category = "Exporting",
               Directory = "TreeGrid/TreeGrid",
               Url = "tree-grid/print",
               Type = SampleType.None,
               SourceFiles = new List<SourceCollection>()
               {
                   new SourceCollection
                   {
                       Id="Print",
                       FileName="Print.razor"
                   },
                   new SourceCollection
                   {
                       Id="PrintData",
                       FileName="SelfData.cs"
                   }
               }
            },
            new Sample
            {
                Name = "Toolbar Template",
                Category = "Miscellaneous",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/tool-bar-template",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ToolBartemplate",
                        FileName="ToolBarTemplate.razor"
                    },
                    new SourceCollection
                    {
                        Id="ToolBarTemplateData",
                        FileName="TreeData.cs"
                    }
                }
            },
             new Sample
            {
                Name = "Keyboard Interaction",
                Category = "Miscellaneous",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/keyboard-interaction",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="KeyboardInteraction",
                        FileName="KeyboardInteraction.razor"
                    },
                    new SourceCollection
                    {
                        Id="KeyboardInteractionData",
                        FileName="WrapData.cs"
                    }
                }
             }
        };
    }

}


